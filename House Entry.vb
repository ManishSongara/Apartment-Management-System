Imports System.Data.SqlClient
Public Class House_Entry
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim wr As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manish\Source\Repos\Apartment-Management-System2\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        cmd.CommandText = "insert into houseentry(tenant ID,No of person in Family,Block No,flat no,flat type,rent Amount, Payment Status,Phone) values(" + t_id.Text + ",'" + tname.Text + "'," + f_no.Text + ",'" + complain.SelectedItem + "','" + t_date.Text + "')"
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
End Class