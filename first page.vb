Public Class first_page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AdminLogin.Click
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TenantLogin.Click
        Tenant_Login.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class