Public Class Form2
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\cus44.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection ok")
        sqlstr = "insert into cus4 values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        cmd.ExecuteNonQuery()
        MsgBox("record inserted")
        con.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class