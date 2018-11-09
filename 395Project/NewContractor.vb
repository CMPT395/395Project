Public Class NewContractor
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Contractor.Show()
        Me.Hide()
    End Sub
    'https://stackoverflow.com/questions/9489671/check-for-empty-textbox-controls-in-vb-net'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                Dim insertQuery As String = "INSERT INTO Contractor(first_name,last_name,email,rate_of_pay,contract_length) VALUES (@first_name,@last_name,@email,@rate_of_pay,@contract_length)"
                If (Not Integer.TryParse(conPayText.Text, parsedValue)) Then
                    MessageBox.Show("Please enter a valid rate")
                    conPayText.Clear()
                ElseIf (Not Integer.TryParse(contractLengthText.Text, parsedValue)) Then
                    MessageBox.Show("Please enter a valid contract length")
                    contractLengthText.Clear()
                Else
                    'limit the substring?'
                    login.SQL.AddParam("@first_name", conFirstNameText.Text)
                    login.SQL.AddParam("@last_name", conLastNameText.Text)
                    login.SQL.AddParam("@email", conEmailText.Text)
                    login.SQL.AddParam("@rate_of_pay", conPayText.Text)
                    login.SQL.AddParam("@contract_length", contractLengthText.Text)

                    login.SQL.ExecQuery(insertQuery)
                    MessageBox.Show("Contractor Sucessfully Added")

                    conFirstNameText.Clear()
                    conLastNameText.Clear()
                    conEmailText.Clear()
                    conPayText.Clear()
                    conPayText.Clear()
                    contractLengthText.Clear()
                End If

            Catch ex As Exception
                MessageBox.Show("Insert failed: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub NewContractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class