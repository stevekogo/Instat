﻿' Instat+R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class RCodeStructure
    'Decides whether or not the output of the R-command should be part of the script or not, in the case this has already been assigned.
    Public strAssignTo As String
    'strAssignTo is the name that should be used to assign in R the output of the main (Base) R-command.
    Public strAssignToDataFrame As String
    Public strAssignToColumn As String
    Public strAssignToModel As String
    Public strAssignToGraph As String
    'These AssingTo's are only relevant in the string case, as RFunction and ROperator have internal equivalents.
    'If they are empty, the output Of the command Is Not linked To an R-instat object.
    'If they are non-empty, that gives the name of the R-instat Object fields it needs to be linked with.
    Public bToBeAssigned As Boolean = False
    'bToBeAssigned is a boolean telling whether or not, AT THE CURRENT STAGE of running code within R, the output of the Base R-command NEEDS TO BE assigned to 
    ' - the variable With the appropriate name: strAssignTo, 
    ' - And potentially assigned to elements in an R-instat object, if specified in the AssignToDataFrame,... parameters.
    Public bIsAssigned As Boolean = False
    'bIsAssigned tells blindly whether or not the output of the R-command has been assigned and, if relevant, the link with the appropriate R-instat object has been done.
    'Both booleans are necessary to distinguish the case where nothing needs to be assigned, and nothing is indeed assigned from the case, nothing needs to be assigned as it has already been assigned. 
    'So bIsAssigned Is Not enough To decide whether Or Not we should assign, unless we use the information "is strAssignTo empty or not", but for the moment we keep it like it is.
    Public bAssignToIsPrefix As Boolean = False
    Public bAssignToColumnWithoutNames As Boolean = False
    Public bInsertColumnBefore As Boolean = False

    Public Event ParametersChanged()

    Protected Sub OnParametersChanged()
        RaiseEvent ParametersChanged()
    End Sub

    'More methods can probably be moved into here from RFunction/ROperator
    'For now the main ones are here
    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False)
        strAssignTo = strTemp
        If Not strTempDataframe = "" Then
            strAssignToDataFrame = strTempDataframe
            If Not strTempColumn = "" Then
                strAssignToColumn = strTempColumn
            End If
        End If
        If Not strTempModel = "" Then
            strAssignToModel = strTempModel
        End If
        If Not strTempGraph = "" Then
            strAssignToGraph = strTempGraph
        End If
        bToBeAssigned = True
        bIsAssigned = False
        Me.bAssignToIsPrefix = bAssignToIsPrefix
        Me.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        Me.bInsertColumnBefore = bInsertColumnBefore
    End Sub

    Public Sub RemoveAssignTo()
        strAssignTo = ""
        strAssignToDataFrame = ""
        strAssignToColumn = ""
        strAssignToModel = ""
        bToBeAssigned = False
        bIsAssigned = False
    End Sub

    Public Overridable Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        Dim clsAddColumns As New RFunction
        Dim clsGetColumns As New RFunction
        Dim clsAddData As New RFunction
        Dim clsGetData As New RFunction
        Dim clsAddModels As New RFunction
        Dim clsGetModels As New RFunction
        Dim clsAddGraphs As New RFunction
        Dim clsGetGraphs As New RFunction
        Dim clsDataList As New RFunction

        If bIsAssigned Then
            Return (strAssignTo)
        End If

        If bToBeAssigned Then
            If Not frmMain.clsRLink.bInstatObjectExists Then
                frmMain.clsRLink.CreateNewInstatObject()
            End If
            strScript = strScript & strAssignTo & " <- " & strTemp & vbCrLf
            If Not strAssignToDataFrame = "" AndAlso (Not strAssignToColumn = "" OrElse bAssignToColumnWithoutNames) Then
                clsAddColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
                clsAddColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                If Not bAssignToColumnWithoutNames Then
                    clsAddColumns.AddParameter("col_name", Chr(34) & strAssignToColumn & Chr(34))
                End If
                clsAddColumns.AddParameter("col_data", strAssignTo)
                If bAssignToIsPrefix Then
                    clsAddColumns.AddParameter("use_col_name_as_prefix", "TRUE")
                Else
                    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                        clsAddColumns.AddParameter("use_col_name_as_prefix", "FALSE")
                    End If
                End If
                If bInsertColumnBefore Then
                    clsAddColumns.AddParameter("before", "TRUE")
                Else
                    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                        clsAddColumns.AddParameter("before", "FALSE")
                    End If
                End If
                strScript = strScript & clsAddColumns.ToScript() & vbCrLf

                clsGetColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                clsGetColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                clsGetColumns.AddParameter("col_name", Chr(34) & strAssignToColumn & Chr(34))
                strAssignTo = clsGetColumns.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            ElseIf Not strAssignToModel = "" Then
                clsAddModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_model")
                clsAddModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                clsAddModels.AddParameter("model", strAssignTo)
                If Not strAssignToDataFrame = "" Then
                    clsAddColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetModels.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddModels.ToScript() & vbCrLf

                clsGetModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
                clsGetModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                strAssignTo = clsGetModels.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            ElseIf Not strAssignToGraph = "" Then
                clsAddGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_graph")
                clsAddGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                clsAddGraphs.AddParameter("graph", strAssignTo)
                If Not strAssignToDataFrame = "" Then
                    clsAddGraphs.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetGraphs.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddGraphs.ToScript() & vbCrLf

                clsGetGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
                clsGetGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                strAssignTo = clsGetGraphs.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            ElseIf Not strAssignToDataFrame = "" Then
                clsAddData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
                clsDataList.SetRCommand("list")
                clsDataList.AddParameter(strAssignToDataFrame, strAssignTo)
                clsAddData.AddParameter("data_tables", clsRFunctionParameter:=clsDataList)
                strScript = strScript & clsAddData.ToScript() & vbCrLf

                clsGetData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                clsGetData.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                strAssignTo = clsGetData.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            End If
            Return strAssignTo
        Else
            Return strTemp
        End If
    End Function

    Public Overridable Function GetParameter(strName As String) As RParameter
        Return New RParameter
    End Function

End Class