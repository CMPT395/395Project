Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class AddClient
    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Try
            Using connection As New SqlConnection("Data Source=DESKTOP-UUM78C3;Initial Catalog=CMPT395;Integrated Security=True")
                connection.Open()
                Dim Insertquery As String = "INSERT INTO Contractors (EID,FName,LName,Cemail,contractLength,payRate) VALUES (@eid,@fname,@lname,@email,@contract,@rate) "
                Dim command As New SqlCommand(Insertquery, connection)

                command.Parameters.AddWithValue("@eid", EIDText.Text)
                command.Parameters.AddWithValue("@fname", fNameTextBox.Text)
                command.Parameters.AddWithValue("@lname", lNameTextBox.Text)
                command.Parameters.AddWithValue("@email", emailAddressTextBox.Text)
                command.Parameters.AddWithValue("@contract", contractLengthTextBox.Text)
                command.Parameters.AddWithValue("@rate", payRateTextBox.Text)
                command.ExecuteNonQuery()
                MessageBox.Show("Contractor Sucessfully Added")

            End Using

        Catch ex As Exception
            MessageBox.Show("Insert failed: " & ex.Message)
        End Try
        EIDText.Clear()
        fNameTextBox.Clear()
        lNameTextBox.Clear()
        emailAddressTextBox.Clear()
        contractLengthTextBox.Clear()
        payRateTextBox.Clear()

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        login.Show()
        Me.Hide()

    End Sub
End Class