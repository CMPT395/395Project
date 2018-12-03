<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddClient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.fNameTextBox = New System.Windows.Forms.TextBox()
        Me.contractLengthTextBox = New System.Windows.Forms.TextBox()
        Me.payRateTextBox = New System.Windows.Forms.TextBox()
        Me.emailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.lNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EIDText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(465, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rate of Pay:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(465, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contract length:"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(96, 355)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(150, 47)
        Me.backButton.TabIndex = 6
        Me.backButton.Text = "Go Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(508, 355)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(150, 47)
        Me.submitButton.TabIndex = 7
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'fNameTextBox
        '
        Me.fNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNameTextBox.Location = New System.Drawing.Point(172, 115)
        Me.fNameTextBox.Name = "fNameTextBox"
        Me.fNameTextBox.Size = New System.Drawing.Size(262, 34)
        Me.fNameTextBox.TabIndex = 8
        '
        'contractLengthTextBox
        '
        Me.contractLengthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contractLengthTextBox.Location = New System.Drawing.Point(653, 176)
        Me.contractLengthTextBox.Name = "contractLengthTextBox"
        Me.contractLengthTextBox.Size = New System.Drawing.Size(135, 34)
        Me.contractLengthTextBox.TabIndex = 9
        '
        'payRateTextBox
        '
        Me.payRateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payRateTextBox.Location = New System.Drawing.Point(600, 118)
        Me.payRateTextBox.Name = "payRateTextBox"
        Me.payRateTextBox.Size = New System.Drawing.Size(188, 34)
        Me.payRateTextBox.TabIndex = 10
        '
        'emailAddressTextBox
        '
        Me.emailAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailAddressTextBox.Location = New System.Drawing.Point(210, 268)
        Me.emailAddressTextBox.Name = "emailAddressTextBox"
        Me.emailAddressTextBox.Size = New System.Drawing.Size(262, 34)
        Me.emailAddressTextBox.TabIndex = 11
        '
        'lNameTextBox
        '
        Me.lNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNameTextBox.Location = New System.Drawing.Point(172, 193)
        Me.lNameTextBox.Name = "lNameTextBox"
        Me.lNameTextBox.Size = New System.Drawing.Size(262, 34)
        Me.lNameTextBox.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(495, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "EID:"
        '
        'EIDText
        '
        Me.EIDText.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EIDText.Location = New System.Drawing.Point(559, 273)
        Me.EIDText.Name = "EIDText"
        Me.EIDText.Size = New System.Drawing.Size(135, 34)
        Me.EIDText.TabIndex = 14
        '
        'AddClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EIDText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lNameTextBox)
        Me.Controls.Add(Me.emailAddressTextBox)
        Me.Controls.Add(Me.payRateTextBox)
        Me.Controls.Add(Me.contractLengthTextBox)
        Me.Controls.Add(Me.fNameTextBox)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddClient"
        Me.Text = "AddClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents fNameTextBox As TextBox
    Friend WithEvents contractLengthTextBox As TextBox
    Friend WithEvents payRateTextBox As TextBox
    Friend WithEvents emailAddressTextBox As TextBox
    Friend WithEvents lNameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EIDText As TextBox
End Class
