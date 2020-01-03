Public Class Booking_Info
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        Admin_Function.Show()
    End Sub

    Private Sub View_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Booking_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApartDataSet.eventhall' table. You can move, or remove it, as needed.
        Me.EventhallTableAdapter.Fill(Me.ApartDataSet.eventhall)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.EventhallTableAdapter.FillBy(Me.ApartDataSet.eventhall)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class