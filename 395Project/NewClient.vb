Imports System.Text.RegularExpressions
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
        Dim emptyTextBoxes =
        From txt In Me.Controls.OfType(Of TextBox)()
        Where txt.Text.Length = 0
        Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))
        Else
            Dim name, email As String
            name = TextBox1.Text
            email = TextBox2.Text.ToString
            Dim emailCheck As Match = Regex.Match(email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase)
            If (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text, "^[1-9]+$")) Then
                MsgBox("Please enter a valid Name")
                TextBox1.Clear()
            ElseIf emailCheck.Success = False Then


                MessageBox.Show("Please enter a valid email")
                TextBox2.Clear()
            Else
                'change this to correct sql
                login.SQL.ExecQuery("AddClient '" + name + "','" + email + "'")
                MessageBox.Show("Add New Client Done")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub


End Class