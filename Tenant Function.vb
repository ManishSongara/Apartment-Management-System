Public Class Tenant_Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BookEventHall.Click
        Event_Hall.Show()
    End Sub

    Private Sub Tenant_Function_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlatRent_Click(sender As Object, e As EventArgs) Handles FlatRent.Click
        Flat_Rent.Show()
    End Sub

    Private Sub PayElectricity_Click(sender As Object, e As EventArgs) Handles PayElectricity.Click
        Pay_eletricity.Show()
    End Sub

    Private Sub ProblemReport_Click(sender As Object, e As EventArgs) Handles ProblemReport.Click
        Problem_Report.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        Tenant_Login.Show()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Close()
        Tenant_Login.Show()
    End Sub
End Class