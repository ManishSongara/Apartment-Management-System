Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rd As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MANISH\SOURCE\REPOS\APARTMENT-MANAGEMENT-SYSTEM2\APART.MDF;Integrated Security=True"
            cmd.Connection = con
            cmd.CommandText = "Select * from [login] where UserName='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'"
            con.Close()
            con.Open()
            rd = cmd.ExecuteReader
            With rd
                If .Read Then
                    MsgBox("               Login Successfully ")
                    Admin_Function.Show()
                    TextBox1.Clear()
                    TextBox2.Clear()
                Else
                    TextBox1.Clear()
                    TextBox2.Clear()
                    MessageBox.Show("Invalid Username or Password")
                End If
            End With
            con.Close()
        Catch ex As Exception
            MsgBox("invalid access")
        End Try




    End Sub



    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
