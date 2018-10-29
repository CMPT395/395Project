Imports System.Data.SqlClient

Public Class Contract
    Private Sub Contract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("Select * from contractor")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class