<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewContractor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        Me.contractTextBox = New System.Windows.Forms.TextBox()
        Me.payTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contractor Profile"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CID:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(294, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contract Length:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rate of Pay:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'emailLabel
        '
        Me.emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(386, 271)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(117, 23)
        Me.emailLabel.TabIndex = 13
        Me.emailLabel.Text = "Email:"
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(155, 94)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(152, 22)
        Me.firstNameTextBox.TabIndex = 14
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(450, 94)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(152, 22)
        Me.lastNameTextBox.TabIndex = 15
        '
        'CIDTextBox
        '
        Me.CIDTextBox.Enabled = False
        Me.CIDTextBox.Location = New System.Drawing.Point(126, 190)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(152, 22)
        Me.CIDTextBox.TabIndex = 16
        '
        'contractTextBox
        '
        Me.contractTextBox.Location = New System.Drawing.Point(450, 186)
        Me.contractTextBox.Name = "contractTextBox"
        Me.contractTextBox.Size = New System.Drawing.Size(152, 22)
        Me.contractTextBox.TabIndex = 17
        '
        'payTextBox
        '
        Me.payTextBox.Location = New System.Drawing.Point(169, 273)
        Me.payTextBox.Name = "payTextBox"
        Me.payTextBox.Size = New System.Drawing.Size(152, 22)
        Me.payTextBox.TabIndex = 18
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(474, 278)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(152, 22)
        Me.emailTextBox.TabIndex = 19
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(499, 363)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(168, 46)
        Me.submitButton.TabIndex = 20
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'ViewContractor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.payTextBox)
        Me.Controls.Add(Me.contractTextBox)
        Me.Controls.Add(Me.CIDTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewContractor"
        Me.Text = "ViewClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents emailLabel As Label
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents CIDTextBox As TextBox
    Friend WithEvents contractTextBox As TextBox
    Friend WithEvents payTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents submitButton As Button
End Class
