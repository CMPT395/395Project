Public Class ViewContractor

    Private Sub ViewContractor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        viewFirstNameLabel.Text = Contractor.DataGridView1.CurrentRow.Cells(1).Value.ToString
        viewLastNameLabel.Text = Contractor.DataGridView1.CurrentRow.Cells(2).Value.ToString
        viewIDLabel.Text = Contractor.DataGridView1.CurrentRow.Cells(0).Value.ToString
        viewEmailLabel.Text = Contractor.DataGridView1.CurrentRow.Cells(3).Value.ToString
        viewRateOfPayLabel.Text = Contractor.DataGridView1.CurrentRow.Cells(4).Value.ToString
        viewContractLengthLabel.Text = Contractor.DataGridView1.CurrentRow.Cells(5).Value.ToString





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Contractor.Show()
        Me.Close()

    End Sub

    Private Sub viewLastNameLabel_Click(sender As Object, e As EventArgs) Handles viewLastNameLabel.Click

    End Sub
End Class