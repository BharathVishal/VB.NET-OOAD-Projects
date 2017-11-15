Public Class Form10
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As String
        i = Val(InputBox("Enter the customer id : "))
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\cus55.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        MsgBox("connection sucessful")
        sqlstr = "select * from cus5 where id='" & i & "'"
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
            End While
        End If
    End Sub
End Class