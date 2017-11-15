Public Class Form4
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\customer.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection ok")
        sqlstr = "insert into cust1 values('" & TextBox1.Text & "'," & TextBox2.Text & ",'" & TextBox3.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        cmd.ExecuteNonQuery()
        MsgBox("record inserted")
        con.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dr As System.Data.OleDb.OleDbDataReader
        Dim i As Integer
        i = Val(InputBox("Enter the customer id : "))
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\customer.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        sqlstr = "select * from cust1 where cusid=" & i & ""
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read
                TextBox1.Text = dr(0)
                TextBox2.Text = dr(1)
                TextBox3.Text = dr(2)
                TextBox4.Text = dr(3)
                TextBox5.Text = dr(4)
                TextBox6.Text = dr(5)
                TextBox7.Text = dr(6)
                TextBox8.Text = dr(7)
                TextBox9.Text = dr(8)
            End While
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Integer
        n = TextBox2.Text
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\customer.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection ok")
        sqlstr = "update cust1 set pending='" & TextBox10.Text & "' where cusid=" & n & ""
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        cmd.ExecuteNonQuery()
        MsgBox("Call closed")
        con.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1 As Integer
        n1 = TextBox2.Text
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\customer.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        sqlstr = "update cust1 set cname='" & TextBox1.Text & "',cusid='" & TextBox2.Text & "',address='" & TextBox3.Text & "',problem='" & TextBox4.Text & "',pending='" & TextBox5.Text & "',calledsupporter='" & TextBox6.Text & "',timewaited='" & TextBox7.Text & "',timescalled='" & TextBox8.Text & "',operatorassigned='" & TextBox9.Text & "' where cusid=" & n1 & ""
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
    End Sub
End Class