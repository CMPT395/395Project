﻿Imports System.Net.Mail
Public Class Status

    Public list As New List(Of String)
    Public receiverlist As New List(Of String)
    Public Function SendeEmail(ByVal ReceiveAddressList As List(Of String))
        Dim Emailmessage As New MailMessage
        Dim smtp As New SmtpClient
        login.SQL.ExecQuery("SELECT * from email where duty = 'getHours'")
        'Label1.Text = login.SQL.DBDS.Tables(0).Rows(0)(1)
        smtp.Host = login.SQL.DBDS.Tables(0).Rows(0)(1).ToString
        smtp.UseDefaultCredentials = False
        smtp.Port = login.SQL.DBDS.Tables(0).Rows(0)(2)
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString, login.SQL.DBDS.Tables(0).Rows(0)(4).ToString)
        Emailmessage.From = New MailAddress(login.SQL.DBDS.Tables(0).Rows(0)(3).ToString)

        ' I added the part to read all the emails from the datagridview and add it to the mailing list

        If receiverlist.Count = 0 Then Return False
        For i = 0 To receiverlist.Count - 1
            Emailmessage.To.Add(receiverlist(i))
        Next

        Emailmessage.Subject = login.SQL.DBDS.Tables(0).Rows(0)(5).ToString 'get email field from database
        Emailmessage.Body = login.SQL.DBDS.Tables(0).Rows(0)(6).ToString

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

    Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As DateTime = DateTime.Now
        login.SQL.ExecQuery("SELECT * from timesheet where Status = 'emailed' and month =" + currentDate.Month.ToString)
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.CurrentCell Is Nothing Then
            MsgBox("Already send to all")
        Else

            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                list.Add(DataGridView1.Rows(i).Cells(5).Value())
            Next
            For Each item In list
                String.Join(",", item)
                receiverlist.Add(item)
            Next
            SendeEmail(receiverlist)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        HourTracking.Show()

    End Sub
End Class