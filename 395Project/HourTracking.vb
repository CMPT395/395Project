Imports System.Net.Mail


Public Class HourTracking
    Public list As New List(Of String)
    Public receiverlist As New List(Of String)
    Public Function SendeEmail(ByVal ReceiveAddressList As List(Of String))
        Dim Emailmessage As New MailMessage
        Dim smtp As New SmtpClient

        smtp.Host = "smtp.gmail.com"
        smtp.UseDefaultCredentials = False
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("monthlyhourcollector@gmail.com", "cmpt395test")
        Emailmessage.From = New MailAddress("monthlyhourcollector@gmail.com")

        ' I added the part to read all the emails from the datagridview and add it to the mailing list

        If receiverlist.Count = 0 Then Return False
        For i = 0 To receiverlist.Count - 1
            Emailmessage.To.Add(receiverlist(i))
        Next

        Emailmessage.Subject = "Monthly Hour Required"
        Emailmessage.Body = "Please click On the link To fill your working hours"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i As Integer = 0 To DataGridView1.Rows.Count - 2
            list.Add(DataGridView1.Rows(i).Cells(3).Value())
        Next
        For Each item In list
            String.Join(",", item)
            receiverlist.Add(item)
        Next





        SendeEmail(receiverlist)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Action_CTRL.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub HourTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("SELECT Contractors.CID,Contractors.LName+' '+Contractors.FName as Name,Contractors.Cemail from Contractors left join Timesheet on Contractors.CID = Timesheet.CID where Timesheet.CID is NULL")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
End Class