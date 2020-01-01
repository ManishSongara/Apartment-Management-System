Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rd As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        cmd.CommandText = "Select * from [login] where UserName='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'"
        con.Open()
        rd = cmd.ExecuteReader
        With rd
            If .Read Then
                MsgBox("               Login Successfully ")
                TextBox1.Clear()
                TextBox2.Clear()
            Else
                TextBox1.Clear()
                TextBox2.Clear()
                MessageBox.Show("Invalid Username or Password")
            End If
        End With
        con.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles UserName.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click

    End Sub
End Class
