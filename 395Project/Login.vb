Public Class login
    Public SQL As New Sqlcon
    Public idshow As String
    Public empname As String

    Private Function MLog() As Boolean
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        If Len(idbox.Text) <> 0! Or Len(passwordbox.Text) <> 0! Then
            SQL.ExecQuery("SELECT Count(Username) As userCount FROM Manager WHERE Username='" & idbox.Text &
            "' AND Passward='" & passwordbox.Text & "'")
            If SQL.DBDS.Tables(0).Rows(0).Item("userCount") = 1 Then
                '
                Return True
            End If
            MsgBox("Invalid id or password", MsgBoxStyle.Critical, "Failed!")
            Return False
        End If
        MsgBox("you entered nothing")
        Return False
    End Function

    Private Sub MLOGIN_Click(sender As Object, e As EventArgs) Handles MLOGIN.Click
        If SQL.HasConnection = True Then
            If MLog() = True Then
                SQL.ExecQuery("SELECT * FROM Manager WHERE Username='" & idbox.Text & "'")
                empname = SQL.DBDS.Tables(0).Rows(0)("Lname").ToString
                MsgBox("Login as successful!")
                Action_CTRL.Show()
                Me.Hide()
                idshow = idbox.Text
                Action_CTRL.Label2.Text = "Manager:" & empname
            End If
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub idbox_TextChanged(sender As Object, e As EventArgs) Handles idbox.TextChanged

    End Sub
End Class
