Public Class Form7
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amt As Integer
        Dim amt1 As Integer
        con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\cus55.mdb;Jet OLEDB:Database Password='';")
        con.Open()
        sqlstr = "select * from cus5 where id='" & TextBox2.Text & "'"
        cmd = New OleDb.OleDbCommand(sqlstr, con)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read
                amt1 = CInt(dr(5))
            End While
        End If
        If (Val(TextBox1.Text) > 500) Then
            If (RadioButton1.Checked = True) Then
                amt = Val(TextBox1.Text) + amt1
                sqlstr = "update cus5 set balance='" & amt & "' where id='" & TextBox2.Text & "'"
                cmd = New OleDb.OleDbCommand(sqlstr, con)
                dr = cmd.ExecuteReader()
                MsgBox("transaction complete")
            End If
        End If
        If (Val(TextBox1.Text) < amt1) Then
            If (RadioButton2.Checked = True) Then
                amt = amt1 - Val(TextBox1.Text)
                sqlstr = "update cus5 set balance='" & amt & "' where id='" & TextBox2.Text & "'"
                cmd = New OleDb.OleDbCommand(sqlstr, con)
                dr = cmd.ExecuteReader()
                MsgBox("transaction complete")
            End If
            con.Close()
        End If







    End Sub
End Class