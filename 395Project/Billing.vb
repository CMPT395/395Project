Imports System.Data.SqlClient


Public Class Billing
    Shared BID As String
    Shared CID As String
    Shared ClientID As String
    Shared Year As String
    Shared Month As String
    Shared Amount As String
    Shared Email As String


    ''a = 
    ''login.SQL.DBDS.Tables(0).Rows(1)(1)
    ''login.SQL.DBDS.Tables(0).row
    ''e = DataGridView1.



    ''Dim table As New DataTable("Table")
    Public Sub LoadGrid()
        ''Dim idsearch As Integer
        ''idsearch = 0
        ''Dim searchstr As String
        ''searchstr = searchbox.Text.ToString
        ''If (IsNumeric(searchbox.Text)) Then
        ''idsearch = searchbox.Text
        ''End If
        ' stored proc will not compatible with the gridview data update and delete!!! May have to use simpler way
        'login.SQL.ExecQuery("searchClient " + idsearch.ToString + "," + searchstr)
        login.SQL.ExecQuery("SELECT Bill.BID, Bill.CID, Bill.ClientID, Timesheet.Year, Timesheet.Month, Timesheet.Hour * Contracts.Salary as Amount, Contractors.Cemail
                             FROM Bill, Timesheet, Contracts, Contractors
                             WHERE Bill.CID=Timesheet.CID AND Bill.CID=Contracts.CID AND Bill.CID=Contractors.CID")
        ''AND Bill.BID = " + idsearch.ToString + "or Bill.CID = '" + searchstr + "' or Bill.ClientID = '" + searchstr +
        ''"' or  Timesheet.Year = '" + searchstr + "' or Timesheet.Month = '" + searchstr + "' or Amount = '" + searchstr + "'")
        DataGridView1.DataSource = login.SQL.DBDS.Tables(0)

        ''Dim a As String
        ''a = login.SQL.DBDS.Tables(0).Rows(1)(1)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Action_CTRL.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.MultiSelect = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        LoadGrid()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        TextBox2.Text = selectedRow.Cells(1).Value.ToString()
        TextBox3.Text = selectedRow.Cells(2).Value.ToString()
        TextBox4.Text = selectedRow.Cells(3).Value.ToString()
        TextBox5.Text = selectedRow.Cells(4).Value.ToString()
        TextBox6.Text = selectedRow.Cells(5).Value.ToString()
        TextBox7.Text = selectedRow.Cells(6).Value.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BID = TextBox1.Text ''= selectedRow.Cells(0).Value.ToString()
        CID = TextBox2.Text '' = selectedRow.Cells(1).Value.ToString()
        ClientID = TextBox3.Text ''= selectedRow.Cells(2).Value.ToString()
        Year = TextBox4.Text '' = selectedRow.Cells(3).Value.ToString()
        Month = TextBox5.Text '' = selectedRow.Cells(4).Value.ToString()
        Amount = TextBox6.Text '' = selectedRow.Cells(5).Value.ToString()
        Email = TextBox7.Text '' = selectedRow.Cells(6).Value.ToString()
        ''PrintLine("BID, CID, ClientID, Year, Month, Amount, Email")
    End Sub
End Class