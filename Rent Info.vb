Public Class Rent_Info
    Private Sub Rent_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApartDataSet.houseentry' table. You can move, or remove it, as needed.
        Me.HouseentryTableAdapter.Fill(Me.ApartDataSet.houseentry)
        'TODO: This line of code loads data into the 'ApartDataSet.RentDetails' table. You can move, or remove it, as needed.
        Me.RentDetailsTableAdapter.Fill(Me.ApartDataSet.RentDetails)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Admin_Function.Show()
    End Sub
End Class