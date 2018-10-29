Public Class Action_CTRL
    Public SQL As New Sqlcon


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles back.Click
        If SQL.HasConnection = True Then
            login.Show()
            login.idbox.Clear()
            login.passwordbox.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub Employers_Click(sender As Object, e As EventArgs) Handles Employers.Click
        Me.Hide()
        Client.Show()
        login.SQL.ExecQuery("select * from Client")
        Client.DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        Client.DataGridView1.Columns(0).ReadOnly = True ' restricted the Client ID cannot be changed
        Client.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells ' auto size the cells in dataview


    End Sub

    Private Sub Constructors_Click(sender As Object, e As EventArgs) Handles Constructors.Click

    End Sub

    Private Sub Contract_Click(sender As Object, e As EventArgs) Handles Contract.Click
        Me.Hide()
        Contract.Show()
        login.SQL.ExecQuery("select * from Contracts")
        'Contract.DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
        'Contract.DataGridView1.Columns(0).ReadOnly = True ' restricted the Client ID cannot be changed
        'Contract.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells ' auto size the cells in dataview

    End Sub
End Class
