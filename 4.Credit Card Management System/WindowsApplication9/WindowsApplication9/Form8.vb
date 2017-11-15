Public Class Form8
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\cus55.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        sqlstr = "select * from cus5 where id='" & TextBox2.Text & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read
                TextBox1.Text = dr(5)
            End While
        End If
    End Sub
End Class