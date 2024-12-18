Public Class DangKy
    Private Sub btDK_Click(sender As Object, e As EventArgs) Handles btDK.Click
        If String.IsNullOrEmpty(tbTK.Text) Then
            MessageBox.Show("Vui lòng nhập tài khoản.")
            Return
        End If

        If String.IsNullOrEmpty(tbMK.Text) Then
            MessageBox.Show("Vui lòng nhập mật khẩu.")
            Return
        End If

        If String.IsNullOrEmpty(tbNhapLaiMK.Text) Then
            MessageBox.Show("Vui lòng nhập lại mật khẩu.")
            Return
        End If

        If String.IsNullOrEmpty(tbEmail.Text) Then
            MessageBox.Show("Vui lòng nhập email.")
            Return
        End If

        If tbMK.Text <> tbNhapLaiMK.Text Then
            MessageBox.Show("Mật khẩu không khớp vui lòng nhập lại.")
            Return
        End If

        OleDbConnection1.Open()
        Dim dk As String = "INSERT INTO TaiKhoan ([TK],[MK],[email]) VALUES (N'" & tbTK.Text & "',N'" & tbMK.Text & "' ,'" & tbEmail.Text & "')"
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Da dang ki thanh cong vui long dang nhap!", vbOKOnly)
        Me.Hide()
        DangNhap.Show()
    End Sub

    Private Sub btDN_Click(sender As Object, e As EventArgs) Handles btDN.Click
        DangNhap.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub DangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class