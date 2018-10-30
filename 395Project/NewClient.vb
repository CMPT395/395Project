﻿Public Class NewClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Client.Show()

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ClientName.Clear()
        Email.Clear()

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))
        Else
            Dim name, email As String
            name = Me.ClientName.Text.ToString
            email = Me.Email.Text.ToString
            'change this to correct sql
            login.SQL.ExecQuery("AddClient '" + name + "','" + email + "'")
            MessageBox.Show("Add New Client Done")
            Me.ClientName.Clear()
            Me.Email.Clear()
        End If
    End Sub

End Class