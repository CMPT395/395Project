<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateClient
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
        Me.clientNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client Profile"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client Name:"
        '
        'clientNameTextBox
        '
        Me.clientNameTextBox.Location = New System.Drawing.Point(165, 103)
        Me.clientNameTextBox.Name = "clientNameTextBox"
        Me.clientNameTextBox.Size = New System.Drawing.Size(290, 22)
        Me.clientNameTextBox.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "CID:"
        '
        'CIDTextBox
        '
        Me.CIDTextBox.Enabled = False
        Me.CIDTextBox.Location = New System.Drawing.Point(165, 188)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(152, 22)
        Me.CIDTextBox.TabIndex = 19
        '
        'emailLabel
        '
        Me.emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(362, 186)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(117, 23)
        Me.emailLabel.TabIndex = 20
        Me.emailLabel.Text = "Email:"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(485, 193)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(152, 22)
        Me.emailTextBox.TabIndex = 21
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(80, 359)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(133, 57)
        Me.backButton.TabIndex = 22
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(463, 359)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(133, 57)
        Me.submitButton.TabIndex = 23
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'updateClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.CIDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clientNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "updateClient"
        Me.Text = "updateClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents clientNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CIDTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents backButton As Button
    Friend WithEvents submitButton As Button
End Class
