Public Class NewContract
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ''TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        StartDate.Refresh()
        EndDate.Refresh()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        ''Dim FileNum As Integer
        ''Dim ClientID As Integer
        ''Dim CID As Integer
        ''Dim Salary As Integer
        ''Dim StartDate As String
        ''Dim EndDate As String
        ''Dim Renewable As String
        ''Dim RenewYear As Integer

        ''Dim f As String
        ''Dim t As String
        ''f = Replace(from_date.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        ''t = Replace(to_date.Value.Date.ToString("yyyy/MM/dd"), "/", "-")

        ''login.SQL.ExecQuery("
        ''INSERT INTO Rental(VIN,CUSID,BID_F,BID_T,from_date,to_date,Cost)
        ''VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & f & "','" & t & "','" & TextBox5.Text & "')")
        ''MsgBox("Reservation Processed!")

        Dim f As String
        Dim t As String


        ''FileNum = TextBox1.Text.ToString
        ''ClientID = TextBox2.Text.ToString
        ''CID = TextBox3.Text.ToString
        ''Salary = TextBox4.Text.ToString
        ''StartDate = TextBox5.Text.ToString
        ''EndDate = TextBox6.Text.ToString
        ''Renewable = TextBox7.Text.ToString
        ''RenewYear = TextBox8.Text.ToString

        f = Replace(StartDate.Value.Date.ToString("yyyy/MM/dd"), "/", "-")
        t = Replace(EndDate.Value.Date.ToString("yyyy/MM/dd"), "/", "-")

        ''login.SQL.ExecQuery("AddContracts '" + FileNum + "','" + ClientID + "'" + CID + "'" + Salary + "'" +
        ''StartDate + "'" + EndDate + "'" + Renewable + "'" + RenewYear + "'")
        login.SQL.ExecQuery("INSERT INTO Contracts(ClientID, CID, Salary, StartDate, EndDate, Renewable, RenewYear)
                             VALUES ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & f & "','" & t & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                            )


        MessageBox.Show("Add New Contract Done")
        ''TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        StartDate.Refresh()
        EndDate.Refresh()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Contract.Show()
    End Sub

    Private Sub from_date_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles StartDate.ValueChanged

    End Sub
End Class