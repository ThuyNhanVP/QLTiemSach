Imports System.Data.SqlClient

Public Class DangNhap
    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub lQMK_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lQMK.LinkClicked
        DoiMK.Show()
        Me.Hide()
    End Sub

    Private Sub btDN_Click(sender As Object, e As EventArgs) Handles btDN.Click
        If String.IsNullOrEmpty(tbTK.Text) Then
            MessageBox.Show("Vui lòng nhập tài khoản.")
            Return
        End If

        If String.IsNullOrEmpty(tbMK.Text) Then
            MessageBox.Show("Vui lòng nhập mật khẩu.")
            Return
        End If

        Dim TK As String = tbTK.Text
        Dim MK As String = tbMK.Text
        Dim con As SqlConnection = New SqlConnection("Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTiemSach;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM TaiKhoan WHERE TK = N'" & "admin" & "' AND MK = N'" & "admin" & "' ", con)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Sach.Show()
            Me.Hide()
        Else MsgBox("Vui long kiem tra lai thong tin dang nhap")
        End If
    End Sub

    Private Sub btDK_Click(sender As Object, e As EventArgs) Handles btDK.Click
        DangKy.Show()
        Me.Hide()
    End Sub
End Class