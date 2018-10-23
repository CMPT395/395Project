Imports System.Data.SqlClient

Public Class Contract
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Contract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to cancel this order", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Deleted")
        End If
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = searchbox.Text.ToString
        If (IsNumeric(searchbox.Text)) Then
            idsearch = searchbox.Text
        End If
        ' stored proc will not compatible with the gridview data update and delete!!! May have to use simpler way
        login.SQL.ExecQuery("searchClient " + idsearch.ToString + "," + searchstr)
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to make these changes", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Changes updated!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class