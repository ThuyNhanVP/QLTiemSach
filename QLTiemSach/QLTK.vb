Imports System.Data.SqlClient

Public Class QLTK
    Private Sub QLTK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsTaiKhoan1.Clear()
        OleDbDataAdapter1.Fill(DsTaiKhoan1)
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        OleDbConnection1.Open()
        Dim dk As String = "INSERT INTO TaiKhoan (TK,MK,email) VALUES (N'" & tbTaiKhoan.Text & "',N'" & tbMatKhau.Text & "' ,N'" & tbEmail.Text & "')"
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã thêm thành công.", vbOKOnly)

        DsTaiKhoan1.Clear()
        OleDbDataAdapter1.Fill(DsTaiKhoan1)
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        OleDbConnection1.Open()
        Dim con As SqlConnection = New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTiemSach;Integrated Security=True")
        Dim updateCmd As String = "Update TaiKhoan Set TK = '" & tbTaiKhoan.Text & "',MK = N'" & tbMatKhau.Text & "',email = N'" & tbEmail.Text & "'  WHERE TK = '" & tbTaiKhoan.Text & "'"
        OleDbUpdateCommand1.CommandText = updateCmd
        OleDbUpdateCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Sửa thành công.", MsgBoxStyle.OkOnly)

        DsTaiKhoan1.Clear()
        OleDbDataAdapter1.Fill(DsTaiKhoan1)
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        OleDbConnection1.Open()
        Dim dk As String = "DELETE FROM TaiKhoan WHERE TK = '" & tbTaiKhoan.Text & "' "
        OleDbInsertCommand1.CommandText = dk
        OleDbInsertCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        MsgBox("Đã xoá thành công.", vbOKOnly)

        DsTaiKhoan1.Clear()
        OleDbDataAdapter1.Fill(DsTaiKhoan1)
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If
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
End Class