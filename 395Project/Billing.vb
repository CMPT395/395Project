Imports System.Data.SqlClient


Public Class Billing
    ''Dim table As New DataTable("Table")
    Public Sub LoadGrid()
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = searchbox.Text.ToString
        If (IsNumeric(searchbox.Text)) Then
            idsearch = searchbox.Text
        End If
        ' stored proc will not compatible with the gridview data update and delete!!! May have to use simpler way
        'login.SQL.ExecQuery("searchClient " + idsearch.ToString + "," + searchstr)
        login.SQL.ExecQuery("select * from Bill")
        ''where CID = " + idsearch.ToString + "or FileNum = '" + searchstr + "' or ClientID = '" + searchstr +
        ''"' or Salary = '" + searchstr + "' or Renewable = '" + searchstr + "' or RenewYear = '" + searchstr + "'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Contract.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        LoadGrid()
    End Sub
End Class