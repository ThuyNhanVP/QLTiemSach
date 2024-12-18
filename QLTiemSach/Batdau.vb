Public Class Batdau
    Private Sub ChươngTrìnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChươngTrìnhToolStripMenuItem.Click
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

    Private Sub ThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinToolStripMenuItem.Click
        ThongTin.Show()
        Me.Hide()
    End Sub
End Class
