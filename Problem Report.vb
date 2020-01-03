Imports System.Data.SqlClient
Public Class Problem_Report
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim wr As SqlDataAdapter
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manish\Source\Repos\Apartment-Management-System2\apart.mdf;Integrated Security=True"
            cmd.Connection = con
            cmd.CommandText = "insert into complain(tenantid,name,flatnumber,complain,date) values(" + t_id.Text + ",'" + tname.Text + "'," + f_no.Text + ",'" + complain.SelectedItem + "','" + DateTimePicker1.Value + "')"
            con.Open()
            If cmd.ExecuteNonQuery() = 1 Then

                MessageBox.Show(" Added")
            Else
                MessageBox.Show(" Not Added")

            End If
            con.Close()
        Catch ex As Exception
            MsgBox("invalid cmd")
        End Try

    End Sub



    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
    End Sub


End Class