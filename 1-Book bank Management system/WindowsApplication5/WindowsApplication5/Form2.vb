Public Class form2
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox7.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        ComboBox1.Text = " "
        ComboBox2.Text = " "
        ComboBox3.Text = " "
        ComboBox4.Text = " "

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\student.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection ok")
        sqlstr = "insert into student1 values('" & TextBox1.Text & "'," & TextBox4.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "', '" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        cmd.ExecuteNonQuery()
        MsgBox("record inserted")
        con.Close()
    End Sub
End Class