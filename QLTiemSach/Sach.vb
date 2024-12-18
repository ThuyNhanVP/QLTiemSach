Imports System.Data.SqlClient

Public Class Sach
    Private Sub Sach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsSach1.Clear()
        OleDbDataAdapter1.Fill(DsSach1)
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        OleDbConnection1.Open()
        Dim dk As String = "INSERT INTO Sach (MaSach,TenSach,Tacgia,NhaXB,ChuDe,DonGia,TrongKho) VALUES (N'" & tbMaSach.Text & "',N'" & tbTenSach.Text & "' ,N'" & tbTacGia.Text & "',N'" & tbNhaXB.Text & "',N'" & tbChuDe.Text & "',N'" & tbDonGia.Text & "',N'" & tbTrongKho.Text & "')"
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã thêm thành công.", vbOKOnly)

        DsSach1.Clear()
        OleDbDataAdapter1.Fill(DsSach1)
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        OleDbConnection1.Open()
        Dim con As SqlConnection = New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTiemSach;Integrated Security=True")
        Dim updateCmd As String = "Update Sach Set TenSach = N'" & tbTenSach.Text & "',Tacgia = '" & tbTacGia.Text & "',NhaXB = N'" & tbNhaXB.Text & "',ChuDe = N'" & tbChuDe.Text & "',DonGia = N'" & tbDonGia.Text & "',TrongKho = N'" & tbTrongKho.Text & "'  WHERE MaSach = '" & tbMaSach.Text & "'"
        OleDbUpdateCommand1.CommandText = updateCmd
        OleDbUpdateCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Sửa thành công.", MsgBoxStyle.OkOnly)

        DsSach1.Clear()
        OleDbDataAdapter1.Fill(DsSach1)
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        OleDbConnection1.Open()
        Dim dk As String = "DELETE FROM Sach WHERE MaSach = '" & tbMaSach.Text & "' "
        Dim dk1 As String = "DELETE FROM HDBan WHERE MaSach = '" & tbMaSach.Text & "' "
        Dim dk2 As String = "DELETE FROM HDMuon WHERE MaSach = '" & tbMaSach.Text & "' "
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.CommandText = dk1
        OleDbInsertCommand1.CommandText = dk2
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã xoá thành công.", vbOKOnly)

        DsSach1.Clear()
        OleDbDataAdapter1.Fill(DsSach1)
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        KhachHang.Show()
        Me.Hide()
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        NhanVien.Show()
        Me.Hide()

    End Sub

    Private Sub QuayLạiĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuayLạiĐăngNhậpToolStripMenuItem.Click
        DangNhap.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DsSach1.Clear()
        OleDbDataAdapter1.Fill(DsSach1)
        tbChuDe.ResetText()
        tbDonGia.ResetText()
        tbMaSach.ResetText()
        tbNhaXB.ResetText()
        tbTacGia.ResetText()
        tbTenSach.ResetText()
        tbTrongKho.ResetText()
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
        KtraPhanQuyen.Show()
        Me.Hide()

    End Sub
End Class