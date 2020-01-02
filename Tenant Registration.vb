Imports System.Data.SqlClient
Public Class Tenant_Registration
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim wr As SqlDataAdapter

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manish\Source\Repos\Apartment-Management-System2\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into tenant_login(tenant_id,user_name,password,tenantName,email,phone,blockNo,flatNumber,flatType) values(" + t_id.Text + ",'" + user_name.Text + "','" + t_password.Text + "','" + t_name.Text + "','" + t_email.Text + "'," + t_phone.Text + "," + t_block.Text + "," + flat_no.Text + ",'" + flat_type.Text + "'  )"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class