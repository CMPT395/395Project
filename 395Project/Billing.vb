Imports System.Data.SqlClient
Imports System.Net.Mail


Public Class Billing

    Dim message As String
    Public receiverlist As New List(Of String)


    ''a = 
    ''login.SQL.DBDS.Tables(0).Rows(1)(1)
    ''login.SQL.DBDS.Tables(0).row
    ''e = DataGridView1.



    ''Dim table As New DataTable("Table")
    Public Sub LoadGrid()
        ''Dim idsearch As Integer
        ''idsearch = 0
        ''Dim searchstr As String
        ''searchstr = searchbox.Text.ToString
        ''If (IsNumeric(searchbox.Text)) Then
        ''idsearch = searchbox.Text
        ''End If
        ' stored proc will not compatible with the gridview data update and delete!!! May have to use simpler way
        'login.SQL.ExecQuery("searchClient " + idsearch.ToString + "," + searchstr)
        login.SQL.ExecQuery("SELECT Bill.BID, Bill.CID, Bill.ClientID, Timesheet.Year, Timesheet.Month, Timesheet.Hour * Contracts.Salary as Amount, Client.Pemail
                             FROM Bill, Timesheet, Contracts, Client
                             WHERE Bill.CID=Timesheet.CID AND Bill.CID=Contracts.CID AND Bill.ClientID=Client.ClientID and timesheet.status != 'emailed'")
        ''AND Bill.BID = " + idsearch.ToString + "or Bill.CID = '" + searchstr + "' or Bill.ClientID = '" + searchstr +
        ''"' or  Timesheet.Year = '" + searchstr + "' or Timesheet.Month = '" + searchstr + "' or Amount = '" + searchstr + "'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)

        ''Dim a As String
        ''a = login.SQL.DBDS.Tables(0).Rows(1)(1)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Action_CTRL.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        LoadGrid()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        Label9.Text = selectedRow.Cells(0).Value.ToString()
        Label10.Text = selectedRow.Cells(1).Value.ToString()
        Label11.Text = selectedRow.Cells(2).Value.ToString()
        Label12.Text = selectedRow.Cells(3).Value.ToString()
        Label13.Text = selectedRow.Cells(4).Value.ToString()
        Label14.Text = selectedRow.Cells(5).Value.ToString()
        Label15.Text = selectedRow.Cells(6).Value.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim BID As String
        Dim CID As String
        Dim ClientID As String
        Dim Year As String
        Dim Month As String
        Dim Amount As String
        Dim Email As String
        BID = Label9.Text ''= selectedRow.Cells(0).Value.ToString()
        CID = Label10.Text '' = selectedRow.Cells(1).Value.ToString()
        ClientID = Label11.Text ''= selectedRow.Cells(2).Value.ToString()
        Year = Label12.Text '' = selectedRow.Cells(3).Value.ToString()
        Month = Label13.Text '' = selectedRow.Cells(4).Value.ToString()
        Amount = Label14.Text '' = selectedRow.Cells(5).Value.ToString()
        login.SQL.ExecQuery("select pemail from client where ClientID = " + ClientID)
        Email = login.SQL.DBDS.Tables(0).Rows(0)(0)
        message = "Invoice Number: " + BID + vbCrLf + "Your monthly payment to:" + CID + vbCrLf + "Amount:" + Amount + vbCrLf + "For " + Year + "/" + Month + vbCrLf + "Send to " + Email
        test.Text = message
        ' change email to client email
        SendeEmail(Email)
    End Sub

    Public Function SendeEmail(ByVal ReceiveAddress As String)
        Dim Emailmessage As New MailMessage
        Dim smtp As New SmtpClient
        login.SQL.ExecQuery("SELECT * from email where duty = 'sendInvoice'")
        'Label1.Text = login.SQL.DBDS.Tables(0).Rows(0)(1)
        smtp.Host = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
        smtp.UseDefaultCredentials = False
        smtp.Port = login.SQL.DBDS.Tables(0).Rows(0)(2)
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString, login.SQL.DBDS.Tables(0).Rows(0)(4).ToString)
        Emailmessage.From = New MailAddress(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString)

        ' I added the part to read all the emails from the datagridview and add it to the mailing list

        Emailmessage.To.Add(ReceiveAddress)

        Emailmessage.Subject = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString 'get email field from database
        Emailmessage.Body = message 'message string defined by button clicked

        Try
            smtp.Send(Emailmessage)
            MessageBox.Show("Email Send！")
            Return True
        Catch
            MessageBox.Show("Failed！")
            Return False
        Finally
            Emailmessage.Dispose()

        End Try

    End Function

    Private Sub Label14_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class