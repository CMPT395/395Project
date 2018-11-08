<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Action_CTRL
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Employers = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Constructors = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Employers
        '
        Me.Employers.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employers.Location = New System.Drawing.Point(186, 142)
        Me.Employers.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Employers.Name = "Employers"
        Me.Employers.Size = New System.Drawing.Size(253, 46)
        Me.Employers.TabIndex = 3
        Me.Employers.Text = "Manage Client"
        Me.Employers.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(38, 32)
        Me.back.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(138, 38)
        Me.back.TabIndex = 4
        Me.back.Text = "Sign Out"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Manager name"
        '
        'Constructors
        '
        Me.Constructors.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Constructors.Location = New System.Drawing.Point(186, 209)
        Me.Constructors.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Constructors.Name = "Constructors"
        Me.Constructors.Size = New System.Drawing.Size(253, 41)
        Me.Constructors.TabIndex = 8
        Me.Constructors.Text = "Manage Contractors"
        Me.Constructors.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 287)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "View Contract"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(250, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Action_CTRL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 455)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Constructors)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Employers)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Action_CTRL"
        Me.Text = "ManagerAction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Employers As Button
    Friend WithEvents back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Constructors As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
