Imports System.Data.SqlClient
Public Class Client
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
        login.SQL.ExecQuery("select * from Client where CLientID = " + idsearch.ToString + "or Name like '%" + searchstr + "%' or Pemail like '%" + searchstr + "%'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intResult As Integer


        If (DataGridView1.SelectedCells.Count > 0) Then
            intResult = MessageBox.Show("You sure you want to remove this client?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            If intResult = DialogResult.OK Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
                Dim bbb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
                login.SQL.DBDA.Update(login.SQL.DBDS)
                MsgBox("Client has been removed")
            Else
                MessageBox.Show("Please make a selection before removing")
            End If

        End If
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        Action_CTRL.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        NewClient.Show()

    End Sub

End Class