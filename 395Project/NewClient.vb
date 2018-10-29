Public Class NewClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Client.Show()

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim name, email As String
        name = TextBox1.Text.ToString
        email = TextBox2.Text.ToString
        login.SQL.ExecQuery("AddClient '" + name + "','" + email + "'")
        MessageBox.Show("Add New Client Done")
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class