Public Class Form3
        Dim con As System.Data.OleDb.OleDbConnection
        Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Dim sqlstr1 As String


        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            MsgBox("You have logged out")
            Form1.Show()
            Me.Hide()
        End Sub

        Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

        End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim un As String
        un = TextBox5.Text
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        If (TextBox5.Text = "") Then
            MsgBox("There is no book to return")
            GoTo l
        End If
        sqlstr = "update student1 set book1='' where username='" & TextBox1.Text & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        TextBox5.Text = TextBox11.Text
        GoTo b
l:      Me.Show()
b:
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim un1 As String
        un1 = TextBox8.Text
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\bk.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        If (TextBox8.Text = "") Then
            MsgBox("Pls enter a book")
            GoTo l
        End If
        sqlstr = "select * from book where bname='" & un1 & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read
                TextBox8.Text = dr(0)
                TextBox9.Text = dr(1)
                TextBox10.Text = dr(2)
            End While
            GoTo b
        Else
            MsgBox("Book is not availabe,try someother book")
            GoTo l
        End If
l:      Me.Show()
b:
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim un1 As String
        Dim temp As String
        un1 = TextBox8.Text
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        If (TextBox8.Text = "") Then
            MsgBox("Pls select a book")
            GoTo l
        End If
        If (TextBox5.Text = "" And TextBox6.Text = "" And TextBox7.Text = "") Then
            sqlstr = "update student1 set book1='" & TextBox8.Text & "' where username='" & TextBox1.Text & "'"
            cmd = New OleDb.OleDbCommand(sqlstr, con)
            dr = cmd.ExecuteReader()
            TextBox5.Text = TextBox8.Text
            GoTo b
        End If
        If (Not (TextBox5.Text = "") And TextBox6.Text = "" And TextBox7.Text = "") Then
            sqlstr = "update student1 set book2='" & TextBox8.Text & "' where username='" & TextBox1.Text & "'"
            cmd = New OleDb.OleDbCommand(sqlstr, con)
            dr = cmd.ExecuteReader()
            TextBox6.Text = TextBox8.Text
            GoTo b
        End If
        If (Not (TextBox5.Text = "") And Not (TextBox6.Text = "") And TextBox7.Text = "") Then
            sqlstr = "update student1 set book3='" & TextBox8.Text & "' where username='" & TextBox1.Text & "'"
            cmd = New OleDb.OleDbCommand(sqlstr, con)
            dr = cmd.ExecuteReader()
            TextBox7.Text = TextBox8.Text
            GoTo b
        End If
        If (Not (TextBox5.Text = "") And Not (TextBox6.Text = "") And Not (TextBox7.Text = "")) Then
            MsgBox("you have 3 books already,return books to take a new book")
            GoTo b
        End If
l:      Me.Show()
b:
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim un3 As String
        un3 = TextBox6.Text()
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        If (TextBox6.Text = "") Then
            MsgBox("There is no book to return")
            GoTo l
        End If
        sqlstr = "update student1 set book2='' where username='" & TextBox1.Text & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        TextBox6.Text = TextBox11.Text
        GoTo b
l:      Me.Show()
b:
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim un4 As String
        un4 = TextBox7.Text()
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        If (TextBox7.Text = "") Then
            MsgBox("There is no book to return")
            GoTo l
        End If
        sqlstr = "update student1 set book3='' where username='" & TextBox1.Text & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        TextBox7.Text = TextBox11.Text
        GoTo b
l:      Me.Show()
b:
    End Sub
End Class