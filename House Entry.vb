Imports System.Data.SqlClient
Public Class House_Entry
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim wr As SqlDataAdapter
    Dim rd As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim a As String
            If RadioButton2.Checked Then
                a = RadioButton2.Text
            ElseIf PaidPartially.Checked Then
                a = PaidPartially.Checked
            End If
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manish\Source\Repos\Apartment-Management-System2\apart.mdf;Integrated Security=True"
            cmd.Connection = con
            cmd.CommandText = "insert into houseentry(tenantID,NoofpersoninFamily,BlockNo,flatno,flattype,rentAmount,PaymentStatus,Phone) values(" + ComboBox1.Text + "," + MaskedTextBox1.Text + "," + TextBox1.Text + "," + TextBox2.Text + ",'" + TextBox3.Text + "'," + MaskedTextBox2.Text + ",'" + a + "'," + MaskedTextBox3.Text + ")"
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Function.Show()
        Me.Close()
    End Sub


    Private Sub House_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\apart.mdf;Integrated Security=True"
            cmd.Connection = con
            cmd.CommandText = "Select * from [tenant_login] "
            con.Open()
            rd = cmd.ExecuteReader
            While rd.Read
                ComboBox1.Items.Add(rd("tenant_id"))
            End While
            rd.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("invalid command")
        End Try

    End Sub
End Class