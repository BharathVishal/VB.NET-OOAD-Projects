Public Class Form1
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim un As String
        Dim ps As String
        un = TextBox1.Text
        ps = TextBox2.Text
        If (TextBox1.Text = " " Or TextBox2.Text = " ") Then
            MsgBox("Pls fill in the fields")
        End If
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\cus44.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MsgBox("Fields are not complete")
            GoTo l
        End If
        sqlstr = "select * from cus4 where username='" & un & "' and password='" & ps & "' "
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        Me.Hide()
        If dr.HasRows = True Then
            Form3.Show()
            While dr.Read
                Form3.TextBox1.Text = dr(1)
                Form3.TextBox2.Text = dr(0)
                Form3.TextBox3.Text = dr(5)
                Form3.TextBox4.Text = dr(3)
            End While
            GoTo b
        Else
            MsgBox("username and password does not match, try again")
            GoTo l
        End If
l:      Me.Show()
b:
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
