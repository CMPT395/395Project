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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.conFirstNameText = New System.Windows.Forms.TextBox()
        Me.conLastNameText = New System.Windows.Forms.TextBox()
        Me.conEmailText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Contractor"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "E-Mail Address:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 275)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(349, 275)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'conFirstNameText
        '
        Me.conFirstNameText.Location = New System.Drawing.Point(124, 74)
        Me.conFirstNameText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.conFirstNameText.MaxLength = 20
        Me.conFirstNameText.Name = "conFirstNameText"
        Me.conFirstNameText.Size = New System.Drawing.Size(125, 21)
        Me.conFirstNameText.TabIndex = 10
        '
        'conLastNameText
        '
        Me.conLastNameText.Location = New System.Drawing.Point(378, 73)
        Me.conLastNameText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.conLastNameText.MaxLength = 50
        Me.conLastNameText.Name = "conLastNameText"
        Me.conLastNameText.Size = New System.Drawing.Size(125, 21)
        Me.conLastNameText.TabIndex = 11
        '
        'conEmailText
        '
        Me.conEmailText.Location = New System.Drawing.Point(154, 142)
        Me.conEmailText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.conEmailText.MaxLength = 50
        Me.conEmailText.Name = "conEmailText"
        Me.conEmailText.Size = New System.Drawing.Size(125, 21)
        Me.conEmailText.TabIndex = 12
        '
        'NewContractor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 338)
        Me.Controls.Add(Me.conEmailText)
        Me.Controls.Add(Me.conLastNameText)
        Me.Controls.Add(Me.conFirstNameText)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "NewContractor"
        Me.Text = "NewContractor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents conFirstNameText As TextBox
    Friend WithEvents conLastNameText As TextBox
    Friend WithEvents conEmailText As TextBox
End Class
