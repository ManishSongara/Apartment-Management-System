Public Class Admin_Function
    Private Sub HouseEntry_Click(sender As Object, e As EventArgs) Handles HouseEntry.Click
        House_Entry.Show()
    End Sub

    Private Sub RentInfo_Click(sender As Object, e As EventArgs) Handles RentInfo.Click
        Rent_Info.Show()
    End Sub

    Private Sub EBillInfo_Click(sender As Object, e As EventArgs) Handles EBillInfo.Click
        Pay_eletricity.Show()
    End Sub

    Private Sub BookingInfo_Click(sender As Object, e As EventArgs) Handles BookingInfo.Click
        Booking_Info.Show()
    End Sub

    Private Sub AlertNotification_Click(sender As Object, e As EventArgs) Handles AlertNotification.Click
        Alert_Notification.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Admin_Function_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class