Imports System.Data.SqlClient
Public Class Flat_Rent
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim wr As SqlDataAdapter
    Dim rd As SqlDataReader
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manish\Source\Repos\Apartment-Management-System2\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = " insert into RentDetails(tenantId,name,blockNumber,flatType,flatNumber,phone,date,rentAmount)values(@tenantId,@name,@blockNumber,@flatType,@flatNumber,@phone,@date,@rentAmout )"
        cmd.Parameters.Add("@tenantId", SqlDbType.Int).Value = ComboBox1.Text
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = MaskedTextBox1.Text
        cmd.Parameters.Add("@blockNumber", SqlDbType.Int).Value = b_name.Text
        cmd.Parameters.Add("@flatType", SqlDbType.VarChar).Value = flattype.Text
        cmd.Parameters.Add("@flatNumber", SqlDbType.Int).Value = flatNumber.Text
        cmd.Parameters.Add("@phone", SqlDbType.Int).Value = MaskedTextBox3.Text
        cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTimePicker1.Value
        cmd.Parameters.Add("@rentAmout", SqlDbType.Int).Value = ComboBox5.Text
        con.Close()
        MsgBox("done")
        ComboBox1.SelectedIndex = 0
        MaskedTextBox1.Clear()
        b_name.Clear()
        flattype.Clear()
        flatNumber.Clear()
        MaskedTextBox3.Clear()
        ComboBox5.SelectedIndex = 0
    End Sub
    Private Sub Flat_Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Panel2.Hide()
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        cmd.CommandText = "Select * from [tenant_login] where tenant_id = " + ComboBox1.SelectedItem.ToString + " "
        con.Open()
        rd = cmd.ExecuteReader
        With rd
            If .Read Then
                MaskedTextBox1.Text = rd("tenantName")
                b_name.Text = (rd("blockNo"))
                flattype.Text = rd("flatType")
                flatNumber.Text = rd("flatNumber")
                MaskedTextBox3.Text = rd("phone")

            Else

                MessageBox.Show("Invalid")
            End If
        End With
        con.Close()
    End Sub

    Private Sub PAY_Click(sender As Object, e As EventArgs) Handles PAY.Click
        Panel2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Admin_Function.Show()
    End Sub
End Class