﻿Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class login
    Public SQL As New Sqlcon

    Dim row_name As String
    Dim row_password As String
    Public idshow As String
    Public empname As String

<<<<<<< HEAD
    Private Function MLog() As Boolean
        If SQL.DBDS IsNot Nothing Then
            SQL.DBDS.Clear()
        End If
        If Len(idbox.Text) <> 0! Or Len(passwordbox.Text) <> 0! Then
            SQL.ExecQuery("SELECT Count(Username) As userCount FROM Manager WHERE Username COLLATE Latin1_General_CS_AS='" & idbox.Text &
            "' AND Passward COLLATE Latin1_General_CS_AS ='" & passwordbox.Text & "'")
            If SQL.DBDS.Tables(0).Rows(0).Item("userCount") = 1 Then
                '
                Return True
            End If
            MsgBox("Invalid id or password", MsgBoxStyle.Critical, "Failed!")
            Return False
        End If
        MsgBox("you entered nothing")
        Return False
    End Function
=======
>>>>>>> New-Login-

    Private Sub MLOGIN_Click(sender As Object, e As EventArgs) Handles MLOGIN.Click
        If SQL.HasConnection = True Then
            Dim conn As New SqlConnection("Data Source=DESKTOP-UUM78C3;Initial Catalog=CMPT395;Integrated Security=True")
            Dim query As String = "SELECT * from Manager WHERE username COLLATE Latin1_General_CS_AS = @username And passward COLLATE Latin1_General_CS_AS = @password"
            Dim command As New SqlClient.SqlCommand(query, conn)
            command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = idbox.Text
            command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = passwordbox.Text
            conn.Open()
            Dim results As System.Data.SqlClient.SqlDataReader
            results = command.ExecuteReader()

            If results.HasRows = True Then
                While (results.Read())

                    row_name = results.GetString(1)
                    row_password = results.GetString(2)
                    If String.Compare(idbox.Text, row_name, False) And String.Compare(passwordbox.Text, row_password, False) Then
                        MsgBox("Login as successful!")
                        Action_CTRL.Show()
                        Me.Hide()
                        idshow = idbox.Text
                        Action_CTRL.Label2.Text = "Manager:" & empname
                    Else
                        MsgBox("Incorrect username/password")
                    End If

                End While
            Else
                MsgBox("Incorrect username/password")
                idbox.Clear()
                passwordbox.Clear()
            End If
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub idbox_TextChanged(sender As Object, e As EventArgs) Handles idbox.TextChanged

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        idbox.Clear()
        passwordbox.Clear()
    End Sub
End Class
