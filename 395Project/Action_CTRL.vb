Public Class Action_CTRL
    Public SQL As New Sqlcon


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles back.Click
        If SQL.HasConnection = True Then
            login.Show()
            login.idbox.Clear()
            login.passwordbox.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub Employers_Click(sender As Object, e As EventArgs) Handles Employers.Click
        Me.Hide()
        Client.Show()
        login.SQL.ExecQuery("select * from Client")
        Client.DataGridView1.DataSource = login.SQL.DBDS.Tables(0)

    End Sub
End Class
