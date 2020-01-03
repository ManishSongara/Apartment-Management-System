Imports System.Data.SqlClient
Public Class Problem_Report
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim wr As SqlDataAdapter
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manish\Source\Repos\Apartment-Management-System2\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        cmd.CommandText = "insert into complain(tenantid,name,flatnumber,complain,date) values(" + t_id.Text + ",'" + tname.Text + "'," + f_no.Text + ",'" + complain.SelectedItem + "','" + t_date.Text + "')"
        con.Open()
        If cmd.ExecuteNonQuery() = 1 Then

            MessageBox.Show(" Added")
        Else
            MessageBox.Show(" Not Added")

        End If
        con.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        t_date.Text = MonthCalendar1.SelectionEnd
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

    End Sub
End Class