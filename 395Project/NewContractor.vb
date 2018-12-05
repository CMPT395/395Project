Imports System.Text.RegularExpressions
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

                Dim insertQuery As String = "INSERT INTO Contractors(FName,LName,Cemail) VALUES (@first_name,@last_name,@email)"
                Dim emailCheck As Match = Regex.Match(conEmailText.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase)

                If (System.Text.RegularExpressions.Regex.Match(conFirstNameText.Text, "^[1-9]+$").Success) Then
                    MessageBox.Show("Please enter a valid First Name")
                    conFirstNameText.Clear()
                ElseIf (System.Text.RegularExpressions.Regex.IsMatch(conLastNameText.Text, "^[1-9]+$")) Then
                    MessageBox.Show("Please enter a valid Last Name")
                    conLastNameText.Clear()
                ElseIf emailCheck.Success = False Then
                    MessageBox.Show("Please enter a valid email")
                    conEmailText.Clear()
                Else
                    login.SQL.AddParam("@first_name", conFirstNameText.Text)
                    login.SQL.AddParam("@last_name", conLastNameText.Text)
                    login.SQL.AddParam("@email", conEmailText.Text)


                    login.SQL.ExecQuery(insertQuery)
                    MessageBox.Show("Contractor Sucessfully Added")

                    conFirstNameText.Clear()
                    conLastNameText.Clear()
                    conEmailText.Clear()

                End If

            Catch ex As Exception
                MessageBox.Show("Insert failed: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub NewContractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class