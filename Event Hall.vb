Imports System.Data
Imports System.Data.SqlClient
Public Class Event_Hall
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim wr As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save1()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        Dim answer As DialogResult

        If e.KeyCode = Keys.Escape Then
            answer = MessageBox.Show("Do you want to exit", "press yes for exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                Me.Close()
            End If
        End If
        If (e.Control And e.KeyCode = Keys.S) Then
            answer = MessageBox.Show("Do you want to SAVE", "press yes for SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                save1()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            'ItemInfo.ShowDialog()
        End If
        If e.KeyCode = Keys.F8 Then
            'partyledger.Show()
        End If
    End Sub
    Public Function save1()

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manish\Source\Repos\Apartment-Management-System2\apart.mdf;Integrated Security=True"
        cmd.Connection = con
        cmd.CommandText = "insert into eventhall(TenantID,BlockNo,FlatNo,Date,Purpose) values(" + t_id.Text + "," + blockno.Text + "," + flatn.Text + ",'" + DateTimePicker1.Value + "','" + purpose1.Text + "')"
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("done")
        con.Close()
    End Function
End Class