Imports System.Net.Mail

Public Class HourTracking

    Dim ReceiverList As New List(Of String) From { 'build a list of receivers' email address for sendemail function to send each one
            "leonxiao587@gmail.com",
            "xiaoj3@mymacewan.ca"
        }
    ''' <summary>
    ''' use SmtpClient class to send email
    ''' </summary>
    ''' <param name="ReceiveAddressList">a list of receivers' email address</param>

    Private Function sendemail(ByVal ReceiveAddressList As List(Of String))
        Dim Emailmessage As New MailMessage
        Dim smtp As New SmtpClient

        smtp.Host = "smtp.gmail.com"
        smtp.UseDefaultCredentials = False
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("monthlyhourcollector@gmail.com", "cmpt395test")
        Emailmessage.From = New MailAddress("leonxiao587@gmail.com")
        'add Receiver
        If ReceiveAddressList.Count = 0 Then Return False
        For i = 0 To ReceiveAddressList.Count - 1
            Emailmessage.To.Add(ReceiveAddressList.Item(i))
        Next

        'put body and subject for email here
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
        'ReceiverAddressList.Add("xiaoj3@mymacewan.ca")
        'test = SendMail(ReceiverAddressList, "Monthly Hour Required", "Please click On the link To fill your working hours")
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sendemail(ReceiverList)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class