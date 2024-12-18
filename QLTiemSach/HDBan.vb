Public Class HDBan
    Private Sub HDMuonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HDMuonToolStripMenuItem.Click
        HDMuon.Show()
        Me.Hide()

    End Sub

    Private Sub SáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchToolStripMenuItem.Click
        Sach.Show()
        Me.Hide()

    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        KhachHang.Show()
        Me.Hide()

    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        NhanVien.Show()
        Me.Hide()

    End Sub

    Private Sub QuảnLýPhânQuyềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhânQuyềnToolStripMenuItem.Click
        KtraPhanQuyen.Show()
        Me.Hide()

    End Sub

    Private Sub QuayLạiĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuayLạiĐăngNhậpToolStripMenuItem.Click
        DangNhap.Show()
        Me.Hide()

    End Sub

    Private Sub HDBan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsHDBan1.Clear()
        OleDbDataAdapter1.Fill(DsHDBan1)
    End Sub
End Class