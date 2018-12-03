Public Class NewContract
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim FileNum As Integer
        Dim ClientID As Integer
        Dim CID As Integer
        Dim Salary As Integer
        Dim StartDate As Integer
        Dim EndDate As Integer
        Dim Renewable As String
        Dim RenewYear As Integer

        ''Dim f As String
        'Dim t As String
        'f = Replace(StartDate.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        't = Replace(EndDate.Value.Date.ToString("yyyy/MM/dd"), "/", "-")

        FileNum = TextBox1.Text.ToString
        ClientID = TextBox2.Text.ToString
        CID = TextBox3.Text.ToString
        Salary = TextBox4.Text.ToString
        StartDate = TextBox5.Text.ToString
        EndDate = TextBox6.Text.ToString
        Renewable = TextBox7.Text.ToString
        RenewYear = TextBox8.Text.ToString
        login.SQL.ExecQuery("AddContracts '" + FileNum + "','" + ClientID + "'" + CID + "'" + Salary + "'" +
                            StartDate + "'" + EndDate + "'" + Renewable + "'" + RenewYear + "'")
        MessageBox.Show("Add New Contract Done")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Contract.Show()
    End Sub

    Private Sub from_date_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class