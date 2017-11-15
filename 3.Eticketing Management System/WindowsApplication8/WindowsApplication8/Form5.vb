Public Class Form5
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As String
        i = Val(TextBox1.Text)
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ticket.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        sqlstr = "delete from ticket1 where idno='" & i & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        MsgBox("Ticket cancellation is successful")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As String
        i = Val(InputBox("Enter the ticket id : "))
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ticket.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        sqlstr = "select * from ticket1 where idno='" & i & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read
                TextBox1.Text = dr(0)
                TextBox2.Text = dr(4)
                TextBox3.Text = dr(5)
                TextBox4.Text = dr(1)
                TextBox5.Text = dr(6)
            End While
        End If
    End Sub
End Class