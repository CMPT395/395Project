Imports System.Net.Mail

Public Class HourTracking
    Dim ReceiverAddressList As New List(Of String) From {
            "leonxiao587@gmail.com"
        }


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Emailmessage As New MailMessage
        Dim smtp As New SmtpClient

        smtp.Host = "smtp.gmail.com"
        smtp.UseDefaultCredentials = False
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("monthlyhourcollector@gmail.com", "cmpt395test")
        Emailmessage.From = New MailAddress("leonxiao587@gmail.com")
        'add Receiver
        Emailmessage.To.Add("xiaoj3@mymacewan.ca")
        'put body and subject for email here
        Emailmessage.Subject = "Monthly Hour Required"
        Emailmessage.Body = "Please click On the link To fill your working hours"

        Try
            smtp.Send(Emailmessage)
            MessageBox.Show("Email Send！")

        Catch
            MessageBox.Show("Failed！")
        Finally
            Emailmessage.Dispose()
        End Try
        'ReceiverAddressList.Add("xiaoj3@mymacewan.ca")
        'test = SendMail(ReceiverAddressList, "Monthly Hour Required", "Please click On the link To fill your working hours")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class