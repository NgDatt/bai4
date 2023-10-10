Public Class Đăng_Nhập
    Private Sub Đăng_Nhập_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(TextBox1, "Đăng Nhập Thành Công $$$", "Thông Tin")
        Me.Close()
    End Sub
End Class