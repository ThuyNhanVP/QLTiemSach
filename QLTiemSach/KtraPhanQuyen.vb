Imports System.Data.SqlClient

Public Class KtraPhanQuyen
    Private Sub QuayLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuayLạiToolStripMenuItem.Click
        Sach.Show()
        Me.Hide()

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM TaiKhoan WHERE TK = N'" & TK & "' AND MK = N'" & MK & "' ", con)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            QLTK.Show()
            Me.Hide()
        Else MsgBox("Vui long kiem tra lai thong tin dang nhap")
        End If
    End Sub
End Class