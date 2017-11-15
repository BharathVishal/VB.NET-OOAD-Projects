Public Class Form1
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim un As String
        Dim ps As String
        un = TextBox3.Text()
        ps = TextBox4.Text()
        If (TextBox3.Text = " " Or TextBox4.Text = " ") Then
            MsgBox("Pls fill in the fields")
        End If
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\emp.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        If (TextBox3.Text = "" Or TextBox4.Text = "") Then
            MsgBox("Fields are not complete")
            GoTo l
        End If
        sqlstr = "select * from emp1 where username='" & un & "' and password='" & ps & "' "
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        Me.Hide()
        If dr.HasRows = True Then
            Form3.Show()
            While dr.Read
                Form3.Label2.Text = dr(2)
                Form3.TextBox1.Text = dr(0)
                Form3.TextBox2.Text = dr(2)
                Form3.TextBox3.Text = dr(6)
                Form3.TextBox4.Text = dr(7)
                Form3.TextBox5.Text = dr(9)
                Form3.TextBox6.Text = dr(5)
            End While
            GoTo b
        Else
            MsgBox("username and password does not match, try again")
            GoTo l
        End If
l:      Me.Show()
b:
    End Sub
End Class
