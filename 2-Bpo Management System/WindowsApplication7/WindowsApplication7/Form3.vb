Public Class Form3
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlstr As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Current call passed on to other operator,clik ok to continue")

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
    End Sub
End Class