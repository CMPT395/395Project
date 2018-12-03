<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewContractor
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.conFirstNameText = New System.Windows.Forms.TextBox()
        Me.conLastNameText = New System.Windows.Forms.TextBox()
        Me.conEmailText = New System.Windows.Forms.TextBox()
        Me.conPayText = New System.Windows.Forms.TextBox()
        Me.contractLengthText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Contractor"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(382, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 37)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rate of Pay:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 37)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contract Length:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 37)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "E-Mail Address:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(465, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'conFirstNameText
        '
        Me.conFirstNameText.Location = New System.Drawing.Point(166, 99)
        Me.conFirstNameText.MaxLength = 20
        Me.conFirstNameText.Name = "conFirstNameText"
        Me.conFirstNameText.Size = New System.Drawing.Size(165, 22)
        Me.conFirstNameText.TabIndex = 10
        '
        'conLastNameText
        '
        Me.conLastNameText.Location = New System.Drawing.Point(504, 97)
        Me.conLastNameText.MaxLength = 50
        Me.conLastNameText.Name = "conLastNameText"
        Me.conLastNameText.Size = New System.Drawing.Size(165, 22)
        Me.conLastNameText.TabIndex = 11
        '
        'conEmailText
        '
        Me.conEmailText.Location = New System.Drawing.Point(205, 189)
        Me.conEmailText.MaxLength = 50
        Me.conEmailText.Name = "conEmailText"
        Me.conEmailText.Size = New System.Drawing.Size(165, 22)
        Me.conEmailText.TabIndex = 12
        '
        'conPayText
        '
        Me.conPayText.Location = New System.Drawing.Point(185, 286)
        Me.conPayText.Name = "conPayText"
        Me.conPayText.Size = New System.Drawing.Size(165, 22)
        Me.conPayText.TabIndex = 14
        '
        'contractLengthText
        '
        Me.contractLengthText.Location = New System.Drawing.Point(551, 288)
        Me.contractLengthText.Name = "contractLengthText"
        Me.contractLengthText.Size = New System.Drawing.Size(165, 22)
        Me.contractLengthText.TabIndex = 15
        '
        'NewContractor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.contractLengthText)
        Me.Controls.Add(Me.conPayText)
        Me.Controls.Add(Me.conEmailText)
        Me.Controls.Add(Me.conLastNameText)
        Me.Controls.Add(Me.conFirstNameText)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewContractor"
        Me.Text = "NewContractor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents conFirstNameText As TextBox
    Friend WithEvents conLastNameText As TextBox
    Friend WithEvents conEmailText As TextBox
    Friend WithEvents conPayText As TextBox
    Friend WithEvents contractLengthText As TextBox
End Class
