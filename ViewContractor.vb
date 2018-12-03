Imports System.Text.RegularExpressions
Public Class ViewContractor

    Private Sub ViewContractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        firstNameTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(1).Value.ToString
        lastNameTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(2).Value.ToString
        CIDTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(0).Value.ToString
        emailTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(3).Value.ToString
        payTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(4).Value.ToString
        contractTextBox.Text = Contractor.DataGridView1.CurrentRow.Cells(5).Value.ToString






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
                Dim parsedValue As Integer
                Dim updateQuery As String = "UPDATE Contractor SET first_name = @first_name, last_name = @last_name,email = @email,rate_of_pay =@rate_of_pay,@contract_length = @contract_length where ClientID = '" + CIDTextBox.Text + "'"
                Dim emailCheck As Match = Regex.Match(emailTextBox.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase)
                If (Not Integer.TryParse(payTextBox.Text, parsedValue)) Or parsedValue <= 0 Then
                    MessageBox.Show("Please enter a valid rate")
                    payTextBox.Clear()
                ElseIf (Not Integer.TryParse(contractTextBox.Text, parsedValue)) Or parsedValue <= 0 Then
                    MessageBox.Show("Please enter a valid contract length")
                    contractTextBox.Clear()
                ElseIf (System.Text.RegularExpressions.Regex.Match(firstNameTextBox.Text, "^[1-9]+$").Success) Then
                    MessageBox.Show("Please enter a valid First Name")
                    firstNameTextBox.Clear()
                ElseIf (System.Text.RegularExpressions.Regex.IsMatch(lastNameTextBox.Text, "^[1-9]+$")) Then
                    MessageBox.Show("Please enter a valid Last Name")
                    firstNameTextBox.Clear()
                ElseIf emailCheck.Success = False Then
                    MessageBox.Show("Please enter a valid email")
                    emailTextBox.Clear()
                Else
                    login.SQL.AddParam("@first_name", firstNameTextBox.Text)
                    login.SQL.AddParam("@last_name", lastNameTextBox.Text)
                    login.SQL.AddParam("@email", emailTextBox.Text)
                    login.SQL.AddParam("@rate_of_pay", payTextBox.Text)
                    login.SQL.AddParam("@contract_length", contractTextBox.Text)

                    login.SQL.ExecQuery(updateQuery)
                    MessageBox.Show("Contractor Sucessfully Updated")

                    firstNameTextBox.Clear()
                    lastNameTextBox.Clear()
                    emailTextBox.Clear()
                    payTextBox.Clear()
                    contractTextBox.Clear()
                End If

            Catch ex As Exception
                MessageBox.Show("Update failed: " & ex.Message)
            End Try
        End If

    End Sub
End Class