﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgWaterBalance
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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.lblWBLessthan = New System.Windows.Forms.Label()
        Me.nudWBLessThan = New System.Windows.Forms.NumericUpDown()
        Me.nudCapacity = New System.Windows.Forms.NumericUpDown()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.ucrSaveWaterBalance = New instat.ucrSave()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForWaterBalance = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoRain = New System.Windows.Forms.RadioButton()
        Me.rdoWaterBalance = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFreqDisplay = New instat.UcrPanel()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.grpRain = New System.Windows.Forms.GroupBox()
        Me.grpWaterBalance = New System.Windows.Forms.GroupBox()
        Me.ucrNudTotalOverDays = New instat.ucrNud()
        Me.lblTotalOverDays = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.ucrNudAmount = New instat.ucrNud()
        Me.grpRainParameters.SuspendLayout()
        CType(Me.nudWBLessThan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRain.SuspendLayout()
        Me.grpWaterBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(248, 173)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 17
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(247, 89)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "Date:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(247, 215)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 19
        Me.lblDOY.Text = "Day of Year:"
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.nudFrom)
        Me.grpRainParameters.Controls.Add(Me.lblFrom)
        Me.grpRainParameters.Controls.Add(Me.nudTo)
        Me.grpRainParameters.Controls.Add(Me.lblTo)
        Me.grpRainParameters.Location = New System.Drawing.Point(12, 253)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(318, 40)
        Me.grpRainParameters.TabIndex = 21
        Me.grpRainParameters.TabStop = False
        '
        'lblWBLessthan
        '
        Me.lblWBLessthan.AutoSize = True
        Me.lblWBLessthan.Location = New System.Drawing.Point(270, 16)
        Me.lblWBLessthan.Name = "lblWBLessthan"
        Me.lblWBLessthan.Size = New System.Drawing.Size(93, 13)
        Me.lblWBLessthan.TabIndex = 7
        Me.lblWBLessthan.Tag = "Water Balance <="
        Me.lblWBLessthan.Text = "Water Balance <="
        '
        'nudWBLessThan
        '
        Me.nudWBLessThan.DecimalPlaces = 2
        Me.nudWBLessThan.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWBLessThan.Location = New System.Drawing.Point(369, 16)
        Me.nudWBLessThan.Name = "nudWBLessThan"
        Me.nudWBLessThan.Size = New System.Drawing.Size(53, 20)
        Me.nudWBLessThan.TabIndex = 6
        Me.nudWBLessThan.Value = New Decimal(New Integer() {85, 0, 0, 131072})
        '
        'nudCapacity
        '
        Me.nudCapacity.DecimalPlaces = 2
        Me.nudCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudCapacity.Location = New System.Drawing.Point(211, 16)
        Me.nudCapacity.Name = "nudCapacity"
        Me.nudCapacity.Size = New System.Drawing.Size(53, 20)
        Me.nudCapacity.TabIndex = 1
        Me.nudCapacity.Value = New Decimal(New Integer() {85, 0, 0, 131072})
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(151, 18)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblCapacity.TabIndex = 0
        Me.lblCapacity.Tag = "Capacity:"
        Me.lblCapacity.Text = "Capacity:"
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(62, 18)
        Me.nudFrom.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudFrom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudFrom.Size = New System.Drawing.Size(53, 20)
        Me.nudFrom.TabIndex = 3
        Me.nudFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudFrom.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(6, 20)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(55, 13)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From Day:"
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(218, 19)
        Me.nudTo.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudTo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(53, 20)
        Me.nudTo.TabIndex = 5
        Me.nudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(148, 20)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(45, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To Day:"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(246, 131)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 15
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(7, 22)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(67, 13)
        Me.lblEvaporation.TabIndex = 24
        Me.lblEvaporation.Text = "Evaporation:"
        '
        'ucrSaveWaterBalance
        '
        Me.ucrSaveWaterBalance.Location = New System.Drawing.Point(12, 399)
        Me.ucrSaveWaterBalance.Name = "ucrSaveWaterBalance"
        Me.ucrSaveWaterBalance.Size = New System.Drawing.Size(276, 24)
        Me.ucrSaveWaterBalance.TabIndex = 27
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(80, 22)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputEvaporation.TabIndex = 26
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(246, 188)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.TabIndex = 18
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(246, 104)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.TabIndex = 14
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(246, 230)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.TabIndex = 20
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(246, 146)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.TabIndex = 16
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrSelectorForWaterBalance
        '
        Me.ucrSelectorForWaterBalance.bShowHiddenColumns = False
        Me.ucrSelectorForWaterBalance.bUseCurrentFilter = True
        Me.ucrSelectorForWaterBalance.Location = New System.Drawing.Point(9, 49)
        Me.ucrSelectorForWaterBalance.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForWaterBalance.Name = "ucrSelectorForWaterBalance"
        Me.ucrSelectorForWaterBalance.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForWaterBalance.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 425)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 56)
        Me.ucrBase.TabIndex = 23
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoBoth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoBoth.Location = New System.Drawing.Point(242, 14)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(100, 28)
        Me.rdoBoth.TabIndex = 31
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoRain
        '
        Me.rdoRain.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRain.Checked = True
        Me.rdoRain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatAppearance.BorderSize = 2
        Me.rdoRain.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoRain.Location = New System.Drawing.Point(44, 14)
        Me.rdoRain.Name = "rdoRain"
        Me.rdoRain.Size = New System.Drawing.Size(100, 28)
        Me.rdoRain.TabIndex = 29
        Me.rdoRain.TabStop = True
        Me.rdoRain.Text = "Rain"
        Me.rdoRain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRain.UseVisualStyleBackColor = True
        '
        'rdoWaterBalance
        '
        Me.rdoWaterBalance.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWaterBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoWaterBalance.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWaterBalance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.FlatAppearance.BorderSize = 2
        Me.rdoWaterBalance.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWaterBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoWaterBalance.Location = New System.Drawing.Point(144, 14)
        Me.rdoWaterBalance.Name = "rdoWaterBalance"
        Me.rdoWaterBalance.Size = New System.Drawing.Size(100, 28)
        Me.rdoWaterBalance.TabIndex = 30
        Me.rdoWaterBalance.Text = "Water Balance"
        Me.rdoWaterBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoWaterBalance.UseVisualStyleBackColor = True
        '
        'ucrPnlFreqDisplay
        '
        Me.ucrPnlFreqDisplay.Location = New System.Drawing.Point(22, 13)
        Me.ucrPnlFreqDisplay.Name = "ucrPnlFreqDisplay"
        Me.ucrPnlFreqDisplay.Size = New System.Drawing.Size(349, 29)
        Me.ucrPnlFreqDisplay.TabIndex = 28
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(247, 50)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 32
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(246, 65)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.TabIndex = 33
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'grpRain
        '
        Me.grpRain.Controls.Add(Me.lblAmount)
        Me.grpRain.Controls.Add(Me.ucrNudAmount)
        Me.grpRain.Controls.Add(Me.lblTotalOverDays)
        Me.grpRain.Controls.Add(Me.ucrNudTotalOverDays)
        Me.grpRain.Location = New System.Drawing.Point(9, 300)
        Me.grpRain.Name = "grpRain"
        Me.grpRain.Size = New System.Drawing.Size(304, 39)
        Me.grpRain.TabIndex = 34
        Me.grpRain.TabStop = False
        Me.grpRain.Text = "Rain"
        '
        'grpWaterBalance
        '
        Me.grpWaterBalance.Controls.Add(Me.lblWBLessthan)
        Me.grpWaterBalance.Controls.Add(Me.nudWBLessThan)
        Me.grpWaterBalance.Controls.Add(Me.ucrInputEvaporation)
        Me.grpWaterBalance.Controls.Add(Me.lblEvaporation)
        Me.grpWaterBalance.Controls.Add(Me.nudCapacity)
        Me.grpWaterBalance.Controls.Add(Me.lblCapacity)
        Me.grpWaterBalance.Location = New System.Drawing.Point(9, 345)
        Me.grpWaterBalance.Name = "grpWaterBalance"
        Me.grpWaterBalance.Size = New System.Drawing.Size(429, 48)
        Me.grpWaterBalance.TabIndex = 35
        Me.grpWaterBalance.TabStop = False
        Me.grpWaterBalance.Text = "Water Balance"
        '
        'ucrNudTotalOverDays
        '
        Me.ucrNudTotalOverDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTotalOverDays.Location = New System.Drawing.Point(106, 19)
        Me.ucrNudTotalOverDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTotalOverDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTotalOverDays.Name = "ucrNudTotalOverDays"
        Me.ucrNudTotalOverDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTotalOverDays.TabIndex = 0
        Me.ucrNudTotalOverDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTotalOverDays
        '
        Me.lblTotalOverDays.AutoSize = True
        Me.lblTotalOverDays.Location = New System.Drawing.Point(10, 23)
        Me.lblTotalOverDays.Name = "lblTotalOverDays"
        Me.lblTotalOverDays.Size = New System.Drawing.Size(90, 13)
        Me.lblTotalOverDays.TabIndex = 33
        Me.lblTotalOverDays.Text = "Total Over Day(s)"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(167, 19)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(68, 13)
        Me.lblAmount.TabIndex = 35
        Me.lblAmount.Text = "Amount (mm)"
        '
        'ucrNudAmount
        '
        Me.ucrNudAmount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAmount.Location = New System.Drawing.Point(248, 16)
        Me.ucrNudAmount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAmount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAmount.Name = "ucrNudAmount"
        Me.ucrNudAmount.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAmount.TabIndex = 34
        Me.ucrNudAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgWaterBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 489)
        Me.Controls.Add(Me.grpWaterBalance)
        Me.Controls.Add(Me.grpRain)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.rdoRain)
        Me.Controls.Add(Me.rdoWaterBalance)
        Me.Controls.Add(Me.ucrPnlFreqDisplay)
        Me.Controls.Add(Me.ucrSaveWaterBalance)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrSelectorForWaterBalance)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWaterBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "End_of_Rains_Season"
        Me.Text = "End of Rains/Season"
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        CType(Me.nudWBLessThan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRain.ResumeLayout(False)
        Me.grpRain.PerformLayout()
        Me.grpWaterBalance.ResumeLayout(False)
        Me.grpWaterBalance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents lblDOY As Label
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents nudCapacity As NumericUpDown
    Friend WithEvents lblCapacity As Label
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents lblFrom As Label
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents lblTo As Label
    Friend WithEvents lblRainfall As Label
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrSelectorForWaterBalance As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudWBLessThan As NumericUpDown
    Friend WithEvents lblWBLessthan As Label
    Friend WithEvents ucrSaveWaterBalance As ucrSave
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoRain As RadioButton
    Friend WithEvents rdoWaterBalance As RadioButton
    Friend WithEvents ucrPnlFreqDisplay As UcrPanel
    Friend WithEvents grpWaterBalance As GroupBox
    Friend WithEvents grpRain As GroupBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents ucrNudAmount As ucrNud
    Friend WithEvents lblTotalOverDays As Label
    Friend WithEvents ucrNudTotalOverDays As ucrNud
End Class
