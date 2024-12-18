Imports System.Data.SqlClient

Public Class NhanVien
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsNhanVien1.Clear()
        OleDbDataAdapter1.Fill(DsNhanVien1)
    End Sub

    Private Sub SáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchToolStripMenuItem.Click
        Sach.Show()
        Me.Hide()

    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        KhachHang.Show()
        Me.Hide()

    End Sub

    Private Sub QuayLạiĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuayLạiĐăngNhậpToolStripMenuItem.Click
        DangNhap.Show()
        Me.Hide()

    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DsNhanVien1.Clear()
        OleDbDataAdapter1.Fill(DsNhanVien1)
        tbDiaChi.Text = ""
        tbDienThoai.Text = ""
        tbMaNV.Text = ""
        tbTenNV.Text = ""

    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        OleDbConnection1.Open()
        Dim dk As String = "INSERT INTO NhanVien (MaNV,TenNV,DiaChi,DienThoai) VALUES (N'" & tbMaNV.Text & "',N'" & tbTenNV.Text & "' ,N'" & tbDiaChi.Text & "',N'" & tbDienThoai.Text & "')"
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã thêm thành công.", vbOKOnly)

        DsNhanVien1.Clear()
        OleDbDataAdapter1.Fill(DsNhanVien1)
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        OleDbConnection1.Open()
        Dim con As SqlConnection = New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTiemSach;Integrated Security=True")
        Dim updateCmd As String = "Update NhanVien Set TenNV = '" & tbTenNV.Text & "',DiaChi = N'" & tbDiaChi.Text & "',DienThoai = N'" & tbDienThoai.Text & "'  WHERE MaNV = '" & tbMaNV.Text & "'"
        OleDbUpdateCommand1.CommandText = updateCmd
        OleDbUpdateCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Sửa thành công.", MsgBoxStyle.OkOnly)

        DsNhanVien1.Clear()
        OleDbDataAdapter1.Fill(DsNhanVien1)
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        OleDbConnection1.Open()
        Dim dk As String = "DELETE FROM NhanVien WHERE MaNV = '" & tbMaNV.Text & "' "
        Dim dk1 As String = "DELETE FROM HDBan WHERE MaNV = '" & tbMaNV.Text & "' "
        Dim dk2 As String = "DELETE FROM HDMuon WHERE MaNV = '" & tbMaNV.Text & "' "
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.CommandText = dk1
        OleDbInsertCommand1.CommandText = dk2
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã xoá thành công.", vbOKOnly)

        DsNhanVien1.Clear()
        OleDbDataAdapter1.Fill(DsNhanVien1)
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
        KtraPhanQuyen.Show()
        Me.Hide()

    End Sub
End Class