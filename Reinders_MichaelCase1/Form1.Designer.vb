<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnFutureValue = New System.Windows.Forms.Button()
        Me.btnPresentValue = New System.Windows.Forms.Button()
        Me.btnNumberOfPeriods = New System.Windows.Forms.Button()
        Me.btnInterestRate = New System.Windows.Forms.Button()
        Me.btnStraightLineDepreciation = New System.Windows.Forms.Button()
        Me.lblInitialSelection = New System.Windows.Forms.Label()
        Me.lblModeDescription = New System.Windows.Forms.Label()
        Me.lblEnterVariables = New System.Windows.Forms.Label()
        Me.lblVariable1 = New System.Windows.Forms.Label()
        Me.txtVariable1 = New System.Windows.Forms.TextBox()
        Me.txtVariable2 = New System.Windows.Forms.TextBox()
        Me.lblVariable2 = New System.Windows.Forms.Label()
        Me.txtVariable3 = New System.Windows.Forms.TextBox()
        Me.lblVariable3 = New System.Windows.Forms.Label()
        Me.btnClearMode = New System.Windows.Forms.Button()
        Me.btnCalculateFV = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalculatePV = New System.Windows.Forms.Button()
        Me.btnCalculateNPer = New System.Windows.Forms.Button()
        Me.btnCalculateRate = New System.Windows.Forms.Button()
        Me.btnCalculateSLN = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFutureValue
        '
        Me.btnFutureValue.Location = New System.Drawing.Point(16, 42)
        Me.btnFutureValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFutureValue.Name = "btnFutureValue"
        Me.btnFutureValue.Size = New System.Drawing.Size(100, 28)
        Me.btnFutureValue.TabIndex = 0
        Me.btnFutureValue.Text = "FV"
        Me.btnFutureValue.UseVisualStyleBackColor = True
        '
        'btnPresentValue
        '
        Me.btnPresentValue.Location = New System.Drawing.Point(124, 42)
        Me.btnPresentValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPresentValue.Name = "btnPresentValue"
        Me.btnPresentValue.Size = New System.Drawing.Size(100, 28)
        Me.btnPresentValue.TabIndex = 1
        Me.btnPresentValue.Text = "PV"
        Me.btnPresentValue.UseVisualStyleBackColor = True
        '
        'btnNumberOfPeriods
        '
        Me.btnNumberOfPeriods.Location = New System.Drawing.Point(232, 42)
        Me.btnNumberOfPeriods.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNumberOfPeriods.Name = "btnNumberOfPeriods"
        Me.btnNumberOfPeriods.Size = New System.Drawing.Size(100, 28)
        Me.btnNumberOfPeriods.TabIndex = 2
        Me.btnNumberOfPeriods.Text = "NPer"
        Me.btnNumberOfPeriods.UseVisualStyleBackColor = True
        '
        'btnInterestRate
        '
        Me.btnInterestRate.Location = New System.Drawing.Point(340, 42)
        Me.btnInterestRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInterestRate.Name = "btnInterestRate"
        Me.btnInterestRate.Size = New System.Drawing.Size(100, 28)
        Me.btnInterestRate.TabIndex = 3
        Me.btnInterestRate.Text = "Rate"
        Me.btnInterestRate.UseVisualStyleBackColor = True
        '
        'btnStraightLineDepreciation
        '
        Me.btnStraightLineDepreciation.Location = New System.Drawing.Point(448, 42)
        Me.btnStraightLineDepreciation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStraightLineDepreciation.Name = "btnStraightLineDepreciation"
        Me.btnStraightLineDepreciation.Size = New System.Drawing.Size(100, 28)
        Me.btnStraightLineDepreciation.TabIndex = 4
        Me.btnStraightLineDepreciation.Text = " SLN"
        Me.btnStraightLineDepreciation.UseVisualStyleBackColor = True
        '
        'lblInitialSelection
        '
        Me.lblInitialSelection.Location = New System.Drawing.Point(19, 15)
        Me.lblInitialSelection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialSelection.Name = "lblInitialSelection"
        Me.lblInitialSelection.Size = New System.Drawing.Size(529, 23)
        Me.lblInitialSelection.TabIndex = 5
        Me.lblInitialSelection.Text = "Please select the desired mode by clicking one of the approriate buttons below: "
        '
        'lblModeDescription
        '
        Me.lblModeDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeDescription.Location = New System.Drawing.Point(19, 74)
        Me.lblModeDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModeDescription.Name = "lblModeDescription"
        Me.lblModeDescription.Size = New System.Drawing.Size(529, 49)
        Me.lblModeDescription.TabIndex = 6
        Me.lblModeDescription.Text = "Select one of the buttons above to see description..."
        '
        'lblEnterVariables
        '
        Me.lblEnterVariables.Location = New System.Drawing.Point(19, 183)
        Me.lblEnterVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnterVariables.Name = "lblEnterVariables"
        Me.lblEnterVariables.Size = New System.Drawing.Size(511, 30)
        Me.lblEnterVariables.TabIndex = 7
        Me.lblEnterVariables.Text = "Please enter the variables in the appropriate text boxes."
        '
        'lblVariable1
        '
        Me.lblVariable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariable1.Location = New System.Drawing.Point(19, 116)
        Me.lblVariable1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable1.Name = "lblVariable1"
        Me.lblVariable1.Size = New System.Drawing.Size(163, 36)
        Me.lblVariable1.TabIndex = 8
        Me.lblVariable1.Text = "Variable1"
        Me.lblVariable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVariable1
        '
        Me.txtVariable1.Location = New System.Drawing.Point(16, 155)
        Me.txtVariable1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVariable1.Name = "txtVariable1"
        Me.txtVariable1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVariable1.Size = New System.Drawing.Size(164, 22)
        Me.txtVariable1.TabIndex = 9
        '
        'txtVariable2
        '
        Me.txtVariable2.Location = New System.Drawing.Point(196, 155)
        Me.txtVariable2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVariable2.Name = "txtVariable2"
        Me.txtVariable2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVariable2.Size = New System.Drawing.Size(171, 22)
        Me.txtVariable2.TabIndex = 11
        '
        'lblVariable2
        '
        Me.lblVariable2.Location = New System.Drawing.Point(192, 116)
        Me.lblVariable2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable2.Name = "lblVariable2"
        Me.lblVariable2.Size = New System.Drawing.Size(176, 36)
        Me.lblVariable2.TabIndex = 10
        Me.lblVariable2.Text = "Variable2"
        Me.lblVariable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVariable3
        '
        Me.txtVariable3.Location = New System.Drawing.Point(383, 155)
        Me.txtVariable3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVariable3.Name = "txtVariable3"
        Me.txtVariable3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVariable3.Size = New System.Drawing.Size(164, 22)
        Me.txtVariable3.TabIndex = 13
        '
        'lblVariable3
        '
        Me.lblVariable3.Location = New System.Drawing.Point(383, 114)
        Me.lblVariable3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable3.Name = "lblVariable3"
        Me.lblVariable3.Size = New System.Drawing.Size(165, 38)
        Me.lblVariable3.TabIndex = 12
        Me.lblVariable3.Text = "Variable3"
        Me.lblVariable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearMode
        '
        Me.btnClearMode.Location = New System.Drawing.Point(16, 289)
        Me.btnClearMode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClearMode.Name = "btnClearMode"
        Me.btnClearMode.Size = New System.Drawing.Size(156, 63)
        Me.btnClearMode.TabIndex = 14
        Me.btnClearMode.Text = "Clear Mode"
        Me.btnClearMode.UseVisualStyleBackColor = True
        '
        'btnCalculateFV
        '
        Me.btnCalculateFV.Location = New System.Drawing.Point(16, 217)
        Me.btnCalculateFV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculateFV.Name = "btnCalculateFV"
        Me.btnCalculateFV.Size = New System.Drawing.Size(156, 64)
        Me.btnCalculateFV.TabIndex = 15
        Me.btnCalculateFV.Text = "Calculate"
        Me.btnCalculateFV.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(192, 217)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(353, 64)
        Me.lblResult.TabIndex = 16
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnCalculatePV
        '
        Me.btnCalculatePV.Location = New System.Drawing.Point(16, 217)
        Me.btnCalculatePV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculatePV.Name = "btnCalculatePV"
        Me.btnCalculatePV.Size = New System.Drawing.Size(156, 64)
        Me.btnCalculatePV.TabIndex = 17
        Me.btnCalculatePV.Text = "Calculate"
        Me.btnCalculatePV.UseVisualStyleBackColor = True
        '
        'btnCalculateNPer
        '
        Me.btnCalculateNPer.Location = New System.Drawing.Point(16, 217)
        Me.btnCalculateNPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculateNPer.Name = "btnCalculateNPer"
        Me.btnCalculateNPer.Size = New System.Drawing.Size(156, 64)
        Me.btnCalculateNPer.TabIndex = 18
        Me.btnCalculateNPer.Text = "Calculate"
        Me.btnCalculateNPer.UseVisualStyleBackColor = True
        '
        'btnCalculateRate
        '
        Me.btnCalculateRate.Location = New System.Drawing.Point(16, 217)
        Me.btnCalculateRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculateRate.Name = "btnCalculateRate"
        Me.btnCalculateRate.Size = New System.Drawing.Size(156, 64)
        Me.btnCalculateRate.TabIndex = 19
        Me.btnCalculateRate.Text = "Calculate"
        Me.btnCalculateRate.UseVisualStyleBackColor = True
        '
        'btnCalculateSLN
        '
        Me.btnCalculateSLN.Location = New System.Drawing.Point(16, 216)
        Me.btnCalculateSLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculateSLN.Name = "btnCalculateSLN"
        Me.btnCalculateSLN.Size = New System.Drawing.Size(156, 64)
        Me.btnCalculateSLN.TabIndex = 20
        Me.btnCalculateSLN.Text = "Calculate"
        Me.btnCalculateSLN.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDate.Location = New System.Drawing.Point(392, 324)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(156, 27)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "Date: "
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 362)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnCalculateSLN)
        Me.Controls.Add(Me.btnCalculateRate)
        Me.Controls.Add(Me.btnCalculateNPer)
        Me.Controls.Add(Me.btnCalculatePV)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalculateFV)
        Me.Controls.Add(Me.btnClearMode)
        Me.Controls.Add(Me.txtVariable3)
        Me.Controls.Add(Me.lblVariable3)
        Me.Controls.Add(Me.txtVariable2)
        Me.Controls.Add(Me.lblVariable2)
        Me.Controls.Add(Me.txtVariable1)
        Me.Controls.Add(Me.lblVariable1)
        Me.Controls.Add(Me.lblEnterVariables)
        Me.Controls.Add(Me.lblModeDescription)
        Me.Controls.Add(Me.lblInitialSelection)
        Me.Controls.Add(Me.btnStraightLineDepreciation)
        Me.Controls.Add(Me.btnInterestRate)
        Me.Controls.Add(Me.btnNumberOfPeriods)
        Me.Controls.Add(Me.btnPresentValue)
        Me.Controls.Add(Me.btnFutureValue)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFutureValue As Button
    Friend WithEvents btnPresentValue As Button
    Friend WithEvents btnNumberOfPeriods As Button
    Friend WithEvents btnInterestRate As Button
    Friend WithEvents btnStraightLineDepreciation As Button
    Friend WithEvents lblInitialSelection As Label
    Friend WithEvents lblModeDescription As Label
    Friend WithEvents lblEnterVariables As Label
    Friend WithEvents lblVariable1 As Label
    Friend WithEvents txtVariable1 As TextBox
    Friend WithEvents txtVariable2 As TextBox
    Friend WithEvents lblVariable2 As Label
    Friend WithEvents txtVariable3 As TextBox
    Friend WithEvents lblVariable3 As Label
    Friend WithEvents btnClearMode As Button
    Friend WithEvents btnCalculateFV As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculatePV As Button
    Friend WithEvents btnCalculateNPer As Button
    Friend WithEvents btnCalculateRate As Button
    Friend WithEvents btnCalculateSLN As Button
    Friend WithEvents lblDate As Label
End Class
