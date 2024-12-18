Public Class HoaDon
    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsHDBan1.Clear()
        DsHDMuon1.Clear()
        OleDbDataAdapter1.Fill(DsHDBan1)
        OleDbDataAdapter2.Fill(DsHDMuon1)
    End Sub

    Private Sub cbLoaiHoaDon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiHoaDon.SelectedIndexChanged
        If cbLoaiHoaDon.Text = "Hoá Đơn Mượn" Then
            DsHDMuon1.Clear()
            OleDbDataAdapter2.Fill(DsHDMuon1)
            dgvMuon.Show()
            dgvBan.Hide()

        ElseIf cbLoaiHoaDon.Text = "Hoá Đơn Bán" Then
            DsHDBan1.Clear()
            OleDbDataAdapter1.Fill(DsHDBan1)
            dgvBan.Show()
            dgvMuon.Hide()

        End If
    End Sub
End Class