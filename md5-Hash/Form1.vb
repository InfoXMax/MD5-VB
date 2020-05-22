Imports MaterialSkin

Public Class MD5Hasher
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 = TextBox1.Text
        Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytes() As Byte = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(text1))
        Dim s As String
        For Each i As Byte In bytes
            s &= i.ToString("x2")
        Next
        TextBox2.Text = s
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText("" & TextBox2.Text)
        MsgBox("Copied")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
