Public Class Apartment_Details
    Private Sub BlockA_Click(sender As Object, e As EventArgs) Handles BlockA.Click
        Block_A.Show()
    End Sub

    Private Sub BlockB_Click(sender As Object, e As EventArgs) Handles BlockB.Click
        Block_B.Show()
    End Sub

    Private Sub BlockC_Click(sender As Object, e As EventArgs) Handles BlockC.Click
        Block_C.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        first_page.Show()
    End Sub
End Class