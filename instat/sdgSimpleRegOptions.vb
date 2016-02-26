' Instat-R
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
Imports instat.Translations
Public Class sdgSimpleRegOptions
    Public clsRModelFunction As RFunction
    Public clsRaovFunction, clsRaovpvalFunction, clsRestpvalFunction As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub sdgSimpleRegOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetRModelFunction(clsRModelFunc As RFunction)
        clsRModelFunction = clsRModelFunc
    End Sub

    Private Sub AnovaTable()
        clsRaovFunction.SetRCommand("aov")
        clsRaovFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)
        frmMain.clsRLink.RunScript(clsRaovFunction.ToScript(), 2)
    End Sub

    Private Sub AnovaTablePvalues()
        clsRaovpvalFunction.SetRCommand("summary")
        clsRaovpvalFunction.AddParameter("", clsRFunctionParameter:=clsRaovFunction)
        frmMain.clsRLink.RunScript(clsRaovpvalFunction.ToScript(), 2)
    End Sub

    Private Sub Estimates()
        frmMain.clsRLink.RunScript(dlgRegressionSimple.ucrBase.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub

    Private Sub EstimatesPvalues()
        clsRestpvalFunction.SetRCommand("summary")
        clsRestpvalFunction.AddParameter("", clsRFunctionParameter:=dlgRegressionSimple.ucrBase.clsRsyntax.clsBaseFunction)
        frmMain.clsRLink.RunScript(clsRestpvalFunction.ToScript(), 2)
    End Sub

    Private Sub Model()
        'I am not sure what should be output when model is checked.
        'There is an option lm$model which outputs the input variables which I think is not correct
        'For now it has the lm just like Estimates()
        frmMain.clsRLink.RunScript(dlgRegressionSimple.ucrBase.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub

    Public Sub SetDefaults()
        chkAnovaTable.Checked = False
        chkAnovaPvalues.Checked = False
        chkAnovaPvalues.Enabled = False
        chkEstimatesPvalues.Checked = False
        chkEstimatesPvalues.Enabled = False
        chkPredictionInterval.Enabled = False
        chkConfidenceInterval.Enabled = False
        lblConfidenceLevel.Enabled = False
        nudConvidenceLevel.Enabled = False
        chkPredictionInterval.Enabled = False
        chkPredictionInterval.Checked = False
        chkFittedModel.Checked = False

    End Sub

    Private Sub chkAnovaTable_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnovaTable.CheckedChanged
        If (chkAnovaTable.Checked) Then
            chkAnovaPvalues.Enabled = True
            chkEstimates.Checked = False 'should we run one command at a time?
            chkModel.Checked = False
        Else
            chkAnovaPvalues.Enabled = False
        End If

    End Sub

    Private Sub chkEstimates_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstimates.CheckedChanged
        If (chkEstimates.Checked) Then
            chkEstimatesPvalues.Enabled = True
            chkAnovaTable.Checked = False
            chkModel.Checked = False
        Else
            chkEstimatesPvalues.Enabled = False
        End If
    End Sub

    Private Sub chkModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkModel.CheckedChanged
        If (chkModel.Checked) Then
            chkAnovaTable.Checked = False
            chkEstimates.Checked = False
        End If
    End Sub

    Private Sub chkFittedModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkFittedModel.CheckedChanged
        If (chkFittedModel.Checked) Then
            chkPredictionInterval.Enabled = True
            chkConfidenceInterval.Enabled = True
        Else
            chkPredictionInterval.Enabled = False
            chkConfidenceInterval.Enabled = False
        End If
    End Sub

    Private Sub chkConfidenceInterval_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfidenceInterval.CheckedChanged
        If (chkConfidenceInterval.Checked) Then
            lblConfidenceLevel.Enabled = True
            nudConvidenceLevel.Enabled = True
            chkPredictionInterval.Checked = False
        Else
            lblConfidenceLevel.Enabled = False
            nudConvidenceLevel.Enabled = False
        End If
    End Sub

    Private Sub chkPredictionInterval_CheckedChanged(sender As Object, e As EventArgs) Handles chkPredictionInterval.CheckedChanged
        If (chkPredictionInterval.Checked) Then
            chkConfidenceInterval.Checked = False
        End If
    End Sub

    Public Sub RegOptions()
        If (chkAnovaTable.Checked) Then
            If (chkAnovaPvalues.Checked) Then
                AnovaTablePvalues()
            Else
                AnovaTable()
            End If
        ElseIf (chkEstimates.Checked) Then

            If (chkEstimatesPvalues.Checked) Then
                EstimatesPvalues()
            Else
                Estimates()
            End If
        ElseIf (chkModel.Checked)
            Model()
        Else

        End If
    End Sub
End Class