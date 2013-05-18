<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlagQuiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.selectLabel = New System.Windows.Forms.Label()
        Me.flagGroupBox = New System.Windows.Forms.GroupBox()
        Me.flagPicture = New System.Windows.Forms.PictureBox()
        Me.countriesComboBox = New System.Windows.Forms.ComboBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.feedBackLabel = New System.Windows.Forms.Label()
        Me.flagGroupBox.SuspendLayout()
        CType(Me.flagPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selectLabel
        '
        Me.selectLabel.AutoSize = True
        Me.selectLabel.Location = New System.Drawing.Point(137, 14)
        Me.selectLabel.Name = "selectLabel"
        Me.selectLabel.Size = New System.Drawing.Size(85, 15)
        Me.selectLabel.TabIndex = 4
        Me.selectLabel.Text = "Select country:"
        '
        'flagGroupBox
        '
        Me.flagGroupBox.Controls.Add(Me.flagPicture)
        Me.flagGroupBox.Location = New System.Drawing.Point(11, 14)
        Me.flagGroupBox.Name = "flagGroupBox"
        Me.flagGroupBox.Size = New System.Drawing.Size(111, 92)
        Me.flagGroupBox.TabIndex = 3
        Me.flagGroupBox.TabStop = False
        Me.flagGroupBox.Text = "Flag"
        '
        'flagPicture
        '
        Me.flagPicture.Location = New System.Drawing.Point(15, 27)
        Me.flagPicture.Name = "flagPicture"
        Me.flagPicture.Size = New System.Drawing.Size(80, 56)
        Me.flagPicture.TabIndex = 0
        Me.flagPicture.TabStop = False
        '
        'countriesComboBox
        '
        Me.countriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.countriesComboBox.FormattingEnabled = True
        Me.countriesComboBox.IntegralHeight = False
        Me.countriesComboBox.Location = New System.Drawing.Point(140, 33)
        Me.countriesComboBox.MaxDropDownItems = 4
        Me.countriesComboBox.Name = "countriesComboBox"
        Me.countriesComboBox.Size = New System.Drawing.Size(133, 23)
        Me.countriesComboBox.TabIndex = 0
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(286, 33)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 1
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(286, 75)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 23)
        Me.nextButton.TabIndex = 2
        Me.nextButton.Text = "Next Flag"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'feedBackLabel
        '
        Me.feedBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.feedBackLabel.Location = New System.Drawing.Point(140, 75)
        Me.feedBackLabel.Name = "feedBackLabel"
        Me.feedBackLabel.Size = New System.Drawing.Size(133, 31)
        Me.feedBackLabel.TabIndex = 5
        Me.feedBackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlagQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 118)
        Me.Controls.Add(Me.feedBackLabel)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.countriesComboBox)
        Me.Controls.Add(Me.flagGroupBox)
        Me.Controls.Add(Me.selectLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FlagQuiz"
        Me.Text = "Flag Quiz"
        Me.flagGroupBox.ResumeLayout(False)
        CType(Me.flagPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selectLabel As System.Windows.Forms.Label
    Friend WithEvents flagGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents flagPicture As System.Windows.Forms.PictureBox
    Friend WithEvents countriesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents feedBackLabel As System.Windows.Forms.Label

End Class
