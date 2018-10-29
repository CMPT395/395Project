Public Class NewContractor
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Contractor.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim parsedValue As Integer
            Dim insertQuery As String = "INSERT INTO Contractor(first_name,last_name,email,rate_of_pay,contract_length) VALUES (@first_name,@last_name,@email,@rate_of_pay,@contract_length)"
            If (Not Integer.TryParse(conPayText.Text, parsedValue)) Then
                MessageBox.Show("Please enter a valid rate")
                conPayText.Clear()
            ElseIf (Not Integer.TryParse(contractLengthText.Text, parsedValue)) Then
                MessageBox.Show("Please enter a valud contract length")
                contractLengthText.Clear()
            Else
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


    End Sub
End Class