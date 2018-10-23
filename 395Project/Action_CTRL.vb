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

    End Sub
End Class
