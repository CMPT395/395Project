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
        login.SQL.ExecQuery("Select * from Contractor")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intResult As Integer
        If (DataGridView1.Rows.Count > 1) Then

            intResult = MessageBox.Show("You sure you want to remove this contractor?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            If intResult = DialogResult.OK Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
                Dim scb As SqlCommandBuilder = New SqlCommandBuilder(login.SQL.DBDA)
                login.SQL.DBDA.Update(login.SQL.DBDS)
                MsgBox("Contractor Successfully Removed")
            Else

                MessageBox.Show("Please make a selection before removing")
            End If
        End If

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If DataGridView1.Rows.Count > 1 Then




            ViewContractor.Show()
        Else
            MessageBox.Show("Empty table")
        End If




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.MultiSelect = False
    End Sub
End Class