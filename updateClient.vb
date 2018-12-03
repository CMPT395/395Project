Imports System.Text.RegularExpressions
Public Class updateClient

    Private Sub updateClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientNameTextBox.Text = Client.DataGridView1.CurrentRow.Cells(1).Value.ToString

        CIDTextBox.Text = Client.DataGridView1.CurrentRow.Cells(0).Value.ToString
        emailTextBox.Text = Client.DataGridView1.CurrentRow.Cells(2).Value.ToString

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Client.Show()
        Me.Hide()
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim emptyTextBoxes =
            From txt In Me.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))

        Else
            Try

                Dim updateQuery As String = "UPDATE Client SET name = @client_name,Pemail = @email where ClientID = '" + CIDTextBox.Text + "'"
                Dim emailCheck As Match = Regex.Match(emailTextBox.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase)


                If (System.Text.RegularExpressions.Regex.Match(clientNameTextBox.Text, "^[1-9]+$").Success) Then
                    MessageBox.Show("Please enter a valid Client Name")
                    clientNameTextBox.Clear()

                ElseIf emailCheck.Success = False Then
                    MessageBox.Show("Please enter a valid email")
                    emailTextBox.Clear()
                Else
                    login.SQL.AddParam("@client_name", clientNameTextBox.Text)

                    login.SQL.AddParam("@email", emailTextBox.Text)

                    login.SQL.ExecQuery(updateQuery)
                    MessageBox.Show("Client Sucessfully Updated")

                    clientNameTextBox.Clear()

                    emailTextBox.Clear()

                End If

            Catch ex As Exception
                MessageBox.Show("Update failed: " & ex.Message)
            End Try
        End If


    End Sub
End Class