Public Class ThongTin
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Batdau.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim response As Integer
        response = MsgBox("Bạn có muốn thoát chương trình?", vbOKCancel, "Thoát chương trình")
        If response = vbOK Then
            Me.Close()
        End If
    End Sub
End Class