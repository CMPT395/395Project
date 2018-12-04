Imports System.Text.RegularExpressions
Public Class ViewContractor

    Private Sub ViewContractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        firstNameTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(1).Value.ToString
        lastNameTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(2).Value.ToString
        CIDTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(0).Value.ToString
        ''emailTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(3).Value.ToString






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Contractor.Show()
        Me.Close()

    End Sub

    Private Sub viewLastNameLabel_Click(sender As Object, e As EventArgs)

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
                Dim updateQuery As String = "UPDATE Contractor SET first_name = @first_name, last_name = @last_name,email = @email where ClientID = '" + CIDTextBox.Text + "'"
                ''Dim emailCheck As Match = Regex.Match(emailTextBox.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase)

                If (System.Text.RegularExpressions.Regex.Match(firstNameTextBox.Text, "^[1-9]+$").Success) Then
                    MessageBox.Show("Please enter a valid First Name")
                    firstNameTextBox.Clear()
                ElseIf (System.Text.RegularExpressions.Regex.IsMatch(lastNameTextBox.Text, "^[1-9]+$")) Then
                    MessageBox.Show("Please enter a valid Last Name")
                    firstNameTextBox.Clear()
                Else
                    login.SQL.AddParam("@first_name", firstNameTextBox.Text)
                    login.SQL.AddParam("@last_name", lastNameTextBox.Text)


                    login.SQL.ExecQuery(updateQuery)
                    MessageBox.Show("Contractor Sucessfully Updated")

                    firstNameTextBox.Clear()
                    lastNameTextBox.Clear()
                    contractTextBox.Clear()
                End If

            Catch ex As Exception
                MessageBox.Show("Update failed: " & ex.Message)
            End Try
        End If

    End Sub
End Class