Public Class Status
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("SELECT * from timesheet where Status = 'emailed'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class