Public Class first_page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AdminLogin.Click
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TenantLogin.Click
        Tenant_Login.Show()
    End Sub
    Private Sub ApartmentDetails_Click(sender As Object, e As EventArgs) Handles ApartmentDetails.Click
        Apartment_Details.Show()
    End Sub
End Class