Imports System.Data.SqlClient
Public Class Contractor
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
        Action_CTRL.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        NewContractor.Show()
    End Sub

    Private Sub Contractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.SQL.ExecQuery("Select * from contractor")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idsearch As Integer
        idsearch = 0
        Dim searchstr As String
        searchstr = idbox.Text.ToString
        If (IsNumeric(idbox.Text)) Then
            idsearch = idbox.Text
        End If

        login.SQL.ExecQuery("select * from Contractor where ClientID = " + idsearch.ToString + "or first_name = '" + searchstr + "' or last_name = '" + searchstr + "'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intResult As Integer
        intResult = MessageBox.Show("You sure you want to cancel this order", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If intResult = DialogResult.OK Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
            login.SQL.DBDA.Update(login.SQL.DBDS)
            MsgBox("Deleted")
        End If

    End Sub
End Class