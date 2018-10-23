Public Class Client
    Public Sub LoadGrid()
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = searchbox.Text.ToString
        If (IsNumeric(searchbox.Text)) Then
            idsearch = searchbox.Text
        End If

        login.SQL.ExecQuery("searchClient " + idsearch.ToString + "," + searchstr)
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
    End Sub

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class