Public Class Form5
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\supporter.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection ok")
        sqlstr = "insert into sup1 values('" & TextBox1.Text & "'," & TextBox2.Text & ",'" & TextBox3.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "')"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        cmd.ExecuteNonQuery()
        MsgBox("record inserted")
        con.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim in1 As Integer
        in1 = Val(InputBox("Enter the supporter id : "))
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\supporter.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        sqlstr = "select * from sup1 where sid=" & in1 & ""
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read
                TextBox6.Text = dr(0)
                TextBox7.Text = dr(1)
                TextBox8.Text = dr(2)
                TextBox9.Text = dr(3)
                TextBox10.Text = dr(4)
            End While
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n11 As Integer
        n11 = TextBox7.Text
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\supporter.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        sqlstr = "update sup1 set sname='" & TextBox6.Text & "',sid='" & TextBox7.Text & "',timescalled='" & TextBox8.Text & "',phoneno='" & TextBox9.Text & "',emailid='" & TextBox10.Text & "' where sid=" & n11 & ""
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
    End Sub
End Class