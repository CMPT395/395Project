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
        Me.SuspendLayout()
        '
        'Employers
        '
        Me.Employers.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employers.Location = New System.Drawing.Point(203, 162)
        Me.Employers.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Employers.Name = "Employers"
        Me.Employers.Size = New System.Drawing.Size(249, 53)
        Me.Employers.TabIndex = 3
        Me.Employers.Text = "Manage Client"
        Me.Employers.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(41, 37)
        Me.back.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(151, 43)
        Me.back.TabIndex = 4
        Me.back.Text = "Sign Out"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(407, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Manager name"
        '
        'Constructors
        '
        Me.Constructors.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Constructors.Location = New System.Drawing.Point(203, 239)
        Me.Constructors.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Constructors.Name = "Constructors"
        Me.Constructors.Size = New System.Drawing.Size(249, 47)
        Me.Constructors.TabIndex = 8
        Me.Constructors.Text = "Manage Contractors"
        Me.Constructors.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(203, 314)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 49)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "View Contract"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Action_CTRL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Constructors)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Employers)
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
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
End Class
