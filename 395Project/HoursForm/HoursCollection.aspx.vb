Imports System.Data.SqlClient

Partial Class HoursCollection
    Inherits System.Web.UI.Page

    Protected Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim updateString As String
        updateString = "UPDATE Timesheet SET Hour = '" & TextBox2.Text & "',Status = submitted WHERE CID = '" & TextBox1.Text & "'"

        Using connection As New SqlConnection(ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString)
            connection.Open()
            Dim command As New SqlCommand(updateString, connection)
            command.ExecuteNonQuery()



            connection.Close()
        End Using
    End Sub
End Class
