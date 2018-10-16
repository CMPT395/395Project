<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.ID = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.idbox = New System.Windows.Forms.TextBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.MLOGIN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(129, 89)
        Me.ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(32, 21)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(91, 171)
        Me.Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(98, 21)
        Me.Password.TabIndex = 1
        Me.Password.Text = "Password"
        '
        'idbox
        '
        Me.idbox.Location = New System.Drawing.Point(215, 86)
        Me.idbox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.idbox.Name = "idbox"
        Me.idbox.Size = New System.Drawing.Size(176, 31)
        Me.idbox.TabIndex = 2
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(215, 168)
        Me.passwordbox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.Size = New System.Drawing.Size(176, 31)
        Me.passwordbox.TabIndex = 3
        Me.passwordbox.UseSystemPasswordChar = True
        '
        'MLOGIN
        '
        Me.MLOGIN.Location = New System.Drawing.Point(227, 244)
        Me.MLOGIN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MLOGIN.Name = "MLOGIN"
        Me.MLOGIN.Size = New System.Drawing.Size(108, 38)
        Me.MLOGIN.TabIndex = 5
        Me.MLOGIN.Text = "Login"
        Me.MLOGIN.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 351)
        Me.Controls.Add(Me.MLOGIN)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.idbox)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.ID)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID As Label
    Friend WithEvents Password As Label
    Friend WithEvents idbox As TextBox
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents MLOGIN As Button
End Class
