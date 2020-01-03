Imports System.Data
Imports System.Data.SqlClient
Public Class Tenant_Login
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rd As SqlDataReader
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        cmd.CommandText = "Select * from [tenant_login] where tenant_id=" + tenantid1.Text + " and password='" + password1.Text + "'"
        con.Open()
        rd = cmd.ExecuteReader
        With rd
            If .Read Then
                MsgBox("               Login Successfully ")
                tenantid1.Clear()
                password1.Clear()
                Tenant_Function.Show()
            Else
                tenantid1.Clear()
                password1.Clear()
                MessageBox.Show("Invalid Username or Password")
            End If
        End With
        con.Close()
    End Sub

    Private Sub NewRegistration_Click(sender As Object, e As EventArgs) Handles NewRegistration.Click
        Tenant_Registration.Show()
    End Sub
End Class