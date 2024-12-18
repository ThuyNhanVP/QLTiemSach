Imports System.Data.SqlClient

Public Class KhachHang
    Private Sub KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsKhach1.Clear()
        OleDbDataAdapter1.Fill(DsKhach1)
    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        OleDbConnection1.Open()
        Dim dk As String = "INSERT INTO KhachHang (MaKH,TenKH,DiaChi,Quan,DienThoai,NguoiGT) VALUES (N'" & tbMaKH.Text & "',N'" & tbTenKH.Text & "' ,N'" & tbDiaChi.Text & "',N'" & tbQuan.Text & "',N'" & tbDienThoai.Text & "',N'" & tbNguoiGT.Text & "')"
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã thêm thành công.", vbOKOnly)

        DsKhach1.Clear()
        OleDbDataAdapter1.Fill(DsKhach1)
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        OleDbConnection1.Open()
        Dim con As SqlConnection = New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTiemSach;Integrated Security=True")
        Dim updateCmd As String = "Update KhachHang Set TenKH = '" & tbTenKH.Text & "',DiaChi = N'" & tbDiaChi.Text & "',Quan = N'" & tbQuan.Text & "',DienThoai = N'" & tbDienThoai.Text & "',NguoiGT = N'" & tbNguoiGT.Text & "'  WHERE MaKH = '" & tbMaKH.Text & "'"
        OleDbUpdateCommand1.CommandText = updateCmd
        OleDbUpdateCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Sửa thành công.", MsgBoxStyle.OkOnly)

        DsKhach1.Clear()
        OleDbDataAdapter1.Fill(DsKhach1)
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        OleDbConnection1.Open()
        Dim dk As String = "DELETE FROM KhachHang WHERE MaKH = '" & tbMaKH.Text & "' "
        Dim dk1 As String = "DELETE FROM HDBan WHERE MaKH = '" & tbMaKH.Text & "' "
        Dim dk2 As String = "DELETE FROM HDMuon WHERE MaKH = '" & tbMaKH.Text & "' "
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.CommandText = dk1
        OleDbInsertCommand1.CommandText = dk2
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã xoá thành công.", vbOKOnly)

        DsKhach1.Clear()
        OleDbDataAdapter1.Fill(DsKhach1)
    End Sub

    Private Sub btThoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DsKhach1.Clear()
        OleDbDataAdapter1.Fill(DsKhach1)
        tbMaKH.Text = ""
        tbDienThoai.Text = ""
        tbNguoiGT.Text = ""
        tbQuan.Text = ""
        tbTenKH.Text = ""
        tbDiaChi.Text = ""
    End Sub

    Private Sub SáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SáchToolStripMenuItem.Click
        Sach.Show()
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

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
        KtraPhanQuyen.Show()
        Me.Hide()

    End Sub
End Class