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
<<<<<<< HEAD
        Me.Contract = New System.Windows.Forms.Button()
=======
        Me.addClientButton = New System.Windows.Forms.Button()
>>>>>>> New-Login-
        Me.SuspendLayout()
        '
        'Employers
        '
        Me.Employers.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Employers.Location = New System.Drawing.Point(101, 76)
        Me.Employers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Employers.Name = "Employers"
        Me.Employers.Size = New System.Drawing.Size(137, 26)
=======
        Me.Employers.Location = New System.Drawing.Point(135, 108)
        Me.Employers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Employers.Name = "Employers"
        Me.Employers.Size = New System.Drawing.Size(148, 29)
>>>>>>> New-Login-
        Me.Employers.TabIndex = 3
        Me.Employers.Text = "Manage Client"
        Me.Employers.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.back.Location = New System.Drawing.Point(21, 18)
        Me.back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 22)
=======
        Me.back.Location = New System.Drawing.Point(28, 24)
        Me.back.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(100, 29)
>>>>>>> New-Login-
        Me.back.TabIndex = 4
        Me.back.Text = "Sign Out"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
<<<<<<< HEAD
        Me.Label2.Location = New System.Drawing.Point(189, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
=======
        Me.Label2.Location = New System.Drawing.Point(252, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
>>>>>>> New-Login-
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "manager name"
        '
        'Constructors
        '
        Me.Constructors.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Constructors.Location = New System.Drawing.Point(101, 119)
        Me.Constructors.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Constructors.Name = "Constructors"
        Me.Constructors.Size = New System.Drawing.Size(137, 23)
=======
        Me.Constructors.Location = New System.Drawing.Point(135, 159)
        Me.Constructors.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Constructors.Name = "Constructors"
        Me.Constructors.Size = New System.Drawing.Size(148, 29)
>>>>>>> New-Login-
        Me.Constructors.TabIndex = 8
        Me.Constructors.Text = "Manage Constructors"
        Me.Constructors.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'Contract
        '
        Me.Contract.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contract.Location = New System.Drawing.Point(101, 161)
        Me.Contract.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Contract.Name = "Contract"
        Me.Contract.Size = New System.Drawing.Size(137, 23)
        Me.Contract.TabIndex = 9
        Me.Contract.Text = "Contract"
        Me.Contract.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Contract.UseVisualStyleBackColor = True
        '
        'Action_CTRL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 261)
        Me.Controls.Add(Me.Contract)
=======
        'addClientButton
        '
        Me.addClientButton.Location = New System.Drawing.Point(135, 217)
        Me.addClientButton.Name = "addClientButton"
        Me.addClientButton.Size = New System.Drawing.Size(148, 23)
        Me.addClientButton.TabIndex = 9
        Me.addClientButton.Text = "Add client"
        Me.addClientButton.UseVisualStyleBackColor = True
        '
        'Action_CTRL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 347)
        Me.Controls.Add(Me.addClientButton)
>>>>>>> New-Login-
        Me.Controls.Add(Me.Constructors)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Employers)
<<<<<<< HEAD
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
=======
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
>>>>>>> New-Login-
        Me.Name = "Action_CTRL"
        Me.Text = "ManagerAction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Employers As Button
    Friend WithEvents back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Constructors As Button
<<<<<<< HEAD
    Friend WithEvents Contract As Button
=======
    Friend WithEvents addClientButton As Button
>>>>>>> New-Login-
End Class
