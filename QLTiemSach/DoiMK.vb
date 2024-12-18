Imports System.Data.SqlClient

Public Class DoiMK
    Private Sub DoiMK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTK.Focus()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        tbMK1.Hide()
        tbMK2.Hide()
        btXacNhan.Hide()
    End Sub

    Private Sub btQuaylai_Click(sender As Object, e As EventArgs) Handles btQuaylai.Click
        DangNhap.Show()
        Me.Hide()
    End Sub

    Private Sub btXacNhan_Click(sender As Object, e As EventArgs) Handles btXacNhan.Click
        If String.IsNullOrEmpty(tbMK1.Text) Then
            MessageBox.Show("Vui lòng nhập mật khẩu.")
            Return
        End If

        If String.IsNullOrEmpty(tbMK2.Text) Then
            MessageBox.Show("Vui lòng nhập  mật khẩu.")
            Return
        End If

        If tbMK1.Text = tbMK2.Text Then
            OleDbConnection1.Open()
            Dim con As SqlConnection = New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTiemSach;Integrated Security=True")
            Dim updateCmd As String = "Update TaiKhoan Set MK = N'" & tbMK1.Text & " '  WHERE email = N'" & tbQuenMK.Text & "'"
            OleDbUpdateCommand1.CommandText = updateCmd
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            MsgBox("Sửa thành công. Chuyển đến trang đăng nhập.", MsgBoxStyle.OkOnly)
            DangNhap.Show()
            Me.Hide()
        Else
            MessageBox.Show("MK không khớp vui lòng nhập lại.")
        End If


    End Sub

    Private Sub btTiepTuc_Click(sender As Object, e As EventArgs) Handles btTiepTuc.Click
        If String.IsNullOrEmpty(tbTK.Text) Then
            MessageBox.Show("Vui lòng nhập tài khoản.")
            Return
        End If

        If String.IsNullOrEmpty(tbQuenMK.Text) Then
            MessageBox.Show("Vui lòng nhập email.")
            Return
        End If

        Dim TK As String = tbTK.Text
        Dim email As String = tbQuenMK.Text
        Dim con As SqlConnection = New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTiemSach;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM TaiKhoan WHERE TK = '" & TK & "' AND email = '" & email & "' ", con)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MsgBox("Xác nhận thành công đang đến đổi mật khẩu")
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            tbTK.Hide()
            tbQuenMK.Hide()
            btTiepTuc.Hide()

            Label4.Show()
            Label5.Show()
            Label6.Show()
            tbMK1.Show()
            tbMK2.Show()
            btXacNhan.Show()
        Else MsgBox("TK và email không khớp vui lòng nhập lại!!!")
        End If
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class