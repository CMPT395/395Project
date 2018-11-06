<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClient
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client Sign Up Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(253, 88)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(253, 137)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(108, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(269, 247)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(68, 29)
        Me.Submit.TabIndex = 6
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(165, 247)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(68, 29)
        Me.Clear.TabIndex = 7
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'NewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 343)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "NewClient"
        Me.Text = "NewClient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Submit As Button
    Friend WithEvents Clear As Button
End Class
