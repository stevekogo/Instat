﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUnstack
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFactorToUnstackBy = New System.Windows.Forms.Label()
        Me.lblColumnToUnstack = New System.Windows.Forms.Label()
        Me.lblIDColumns = New System.Windows.Forms.Label()
        Me.ucrIDColumns = New instat.ucrReceiverMultiple()
        Me.ucrColumnToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrChkDropMissingCombinations = New instat.ucrCheck()
        Me.ucrSelectorForUnstack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblFactorToUnstackBy
        '
        Me.lblFactorToUnstackBy.Location = New System.Drawing.Point(282, 43)
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Size = New System.Drawing.Size(121, 16)
        Me.lblFactorToUnstackBy.TabIndex = 1
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        Me.lblFactorToUnstackBy.Text = "Factor to Unstack by:"
        '
        'lblColumnToUnstack
        '
        Me.lblColumnToUnstack.Location = New System.Drawing.Point(282, 91)
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Size = New System.Drawing.Size(119, 17)
        Me.lblColumnToUnstack.TabIndex = 3
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack"
        Me.lblColumnToUnstack.Text = "Column to Unstack by:"
        '
        'lblIDColumns
        '
        Me.lblIDColumns.Location = New System.Drawing.Point(282, 136)
        Me.lblIDColumns.Name = "lblIDColumns"
        Me.lblIDColumns.Size = New System.Drawing.Size(100, 16)
        Me.lblIDColumns.TabIndex = 5
        Me.lblIDColumns.Tag = "ID_Columns"
        Me.lblIDColumns.Text = "ID Columns:"
        '
        'ucrIDColumns
        '
        Me.ucrIDColumns.frmParent = Me
        Me.ucrIDColumns.Location = New System.Drawing.Point(282, 152)
        Me.ucrIDColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrIDColumns.Name = "ucrIDColumns"
        Me.ucrIDColumns.Selector = Nothing
        Me.ucrIDColumns.Size = New System.Drawing.Size(120, 110)
        Me.ucrIDColumns.TabIndex = 6
        '
        'ucrColumnToUnstackReceiver
        '
        Me.ucrColumnToUnstackReceiver.frmParent = Me
        Me.ucrColumnToUnstackReceiver.Location = New System.Drawing.Point(282, 108)
        Me.ucrColumnToUnstackReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnToUnstackReceiver.Name = "ucrColumnToUnstackReceiver"
        Me.ucrColumnToUnstackReceiver.Selector = Nothing
        Me.ucrColumnToUnstackReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrColumnToUnstackReceiver.TabIndex = 4
        '
        'ucrFactorToUnstackReceiver
        '
        Me.ucrFactorToUnstackReceiver.frmParent = Me
        Me.ucrFactorToUnstackReceiver.Location = New System.Drawing.Point(282, 60)
        Me.ucrFactorToUnstackReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorToUnstackReceiver.Name = "ucrFactorToUnstackReceiver"
        Me.ucrFactorToUnstackReceiver.Selector = Nothing
        Me.ucrFactorToUnstackReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorToUnstackReceiver.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 265)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'ucrNewDFName
        '
        Me.ucrNewDFName.Location = New System.Drawing.Point(10, 238)
        Me.ucrNewDFName.Name = "ucrNewDFName"
        Me.ucrNewDFName.Size = New System.Drawing.Size(268, 24)
        Me.ucrNewDFName.TabIndex = 8
        '
        'ucrChkDropMissingCombinations
        '
        Me.ucrChkDropMissingCombinations.Checked = False
        Me.ucrChkDropMissingCombinations.Location = New System.Drawing.Point(10, 210)
        Me.ucrChkDropMissingCombinations.Name = "ucrChkDropMissingCombinations"
        Me.ucrChkDropMissingCombinations.Size = New System.Drawing.Size(159, 20)
        Me.ucrChkDropMissingCombinations.TabIndex = 7
        '
        'ucrSelectorForUnstack
        '
        Me.ucrSelectorForUnstack.bShowHiddenColumns = False
        Me.ucrSelectorForUnstack.bUseCurrentFilter = True
        Me.ucrSelectorForUnstack.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForUnstack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForUnstack.Name = "ucrSelectorForUnstack"
        Me.ucrSelectorForUnstack.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForUnstack.TabIndex = 0
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 325)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.ucrChkDropMissingCombinations)
        Me.Controls.Add(Me.ucrIDColumns)
        Me.Controls.Add(Me.ucrColumnToUnstackReceiver)
        Me.Controls.Add(Me.ucrFactorToUnstackReceiver)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorForUnstack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblIDColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_Columns"
        Me.Text = "Unstack Columns"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForUnstack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorToUnstackBy As Label
    Friend WithEvents lblColumnToUnstack As Label
    Friend WithEvents ucrFactorToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumnToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrIDColumns As ucrReceiverMultiple
    Friend WithEvents lblIDColumns As Label
    Friend WithEvents ucrNewDFName As ucrSave
    Friend WithEvents ucrChkDropMissingCombinations As ucrCheck
End Class
