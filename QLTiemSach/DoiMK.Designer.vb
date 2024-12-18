<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoiMK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.btXacNhan = New System.Windows.Forms.Button()
        Me.tbMK2 = New System.Windows.Forms.TextBox()
        Me.tbMK1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btQuaylai = New System.Windows.Forms.Button()
        Me.btTiepTuc = New System.Windows.Forms.Button()
        Me.tbQuenMK = New System.Windows.Forms.TextBox()
        Me.tbTK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DANGNHAP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TK", "TK"), New System.Data.Common.DataColumnMapping("MK", "MK"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("email1", "email1")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [DANGNHAP] WHERE (([TK] = ?) AND ([MK] = ?) AND ([email] = ?) AND ([e" &
    "mail1] = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_TK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_email", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_email1", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email1", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [DANGNHAP] ([TK], [MK], [email], [email1]) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("TK", System.Data.OleDb.OleDbType.VarChar, 0, "TK"), New System.Data.OleDb.OleDbParameter("MK", System.Data.OleDb.OleDbType.VarChar, 0, "MK"), New System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarChar, 0, "email"), New System.Data.OleDb.OleDbParameter("email1", System.Data.OleDb.OleDbType.VarChar, 0, "email1")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "select * from DANGNHAP"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [DANGNHAP] SET [TK] = ?, [MK] = ?, [email] = ?, [email1] = ? WHERE (([TK] " &
    "= ?) AND ([MK] = ?) AND ([email] = ?) AND ([email1] = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("TK", System.Data.OleDb.OleDbType.VarChar, 0, "TK"), New System.Data.OleDb.OleDbParameter("MK", System.Data.OleDb.OleDbType.VarChar, 0, "MK"), New System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarChar, 0, "email"), New System.Data.OleDb.OleDbParameter("email1", System.Data.OleDb.OleDbType.VarChar, 0, "email1"), New System.Data.OleDb.OleDbParameter("Original_TK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_email", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_email1", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email1", System.Data.DataRowVersion.Original, Nothing)})
        '
        'btXacNhan
        '
        Me.btXacNhan.Location = New System.Drawing.Point(573, 334)
        Me.btXacNhan.Name = "btXacNhan"
        Me.btXacNhan.Size = New System.Drawing.Size(112, 48)
        Me.btXacNhan.TabIndex = 25
        Me.btXacNhan.Text = "Xác nhận"
        Me.btXacNhan.UseVisualStyleBackColor = True
        '
        'tbMK2
        '
        Me.tbMK2.Location = New System.Drawing.Point(342, 243)
        Me.tbMK2.Name = "tbMK2"
        Me.tbMK2.Size = New System.Drawing.Size(255, 26)
        Me.tbMK2.TabIndex = 24
        '
        'tbMK1
        '
        Me.tbMK1.Location = New System.Drawing.Point(342, 183)
        Me.tbMK1.Name = "tbMK1"
        Me.tbMK1.Size = New System.Drawing.Size(255, 26)
        Me.tbMK1.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nhập lại mật khẩu mời: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Nhập mật khẩu mới: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 29)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ĐỔI MẬT KHẨU"
        '
        'btQuaylai
        '
        Me.btQuaylai.Location = New System.Drawing.Point(119, 334)
        Me.btQuaylai.Name = "btQuaylai"
        Me.btQuaylai.Size = New System.Drawing.Size(112, 48)
        Me.btQuaylai.TabIndex = 19
        Me.btQuaylai.Text = "Quay lại đăng nhập"
        Me.btQuaylai.UseVisualStyleBackColor = True
        '
        'btTiepTuc
        '
        Me.btTiepTuc.Location = New System.Drawing.Point(573, 334)
        Me.btTiepTuc.Name = "btTiepTuc"
        Me.btTiepTuc.Size = New System.Drawing.Size(112, 48)
        Me.btTiepTuc.TabIndex = 18
        Me.btTiepTuc.Text = "Tiếp tục"
        Me.btTiepTuc.UseVisualStyleBackColor = True
        '
        'tbQuenMK
        '
        Me.tbQuenMK.Location = New System.Drawing.Point(342, 243)
        Me.tbQuenMK.Name = "tbQuenMK"
        Me.tbQuenMK.Size = New System.Drawing.Size(255, 26)
        Me.tbQuenMK.TabIndex = 17
        '
        'tbTK
        '
        Me.tbTK.Location = New System.Drawing.Point(342, 180)
        Me.tbTK.Name = "tbTK"
        Me.tbTK.Size = New System.Drawing.Size(255, 26)
        Me.tbTK.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nhập email đăng ký TK: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nhập TK quên MK:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "XÁC NHẬN EMAIL ĐĂNG KÝ"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.ThoátToolStripMenuItem.Text = "Thoát "
        '
        'DoiMK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btXacNhan)
        Me.Controls.Add(Me.tbMK2)
        Me.Controls.Add(Me.tbMK1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btQuaylai)
        Me.Controls.Add(Me.btTiepTuc)
        Me.Controls.Add(Me.tbQuenMK)
        Me.Controls.Add(Me.tbTK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DoiMK"
        Me.Text = "Đổi Mật Khẩu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents btXacNhan As Button
    Friend WithEvents tbMK2 As TextBox
    Friend WithEvents tbMK1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btQuaylai As Button
    Friend WithEvents btTiepTuc As Button
    Friend WithEvents tbQuenMK As TextBox
    Friend WithEvents tbTK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class
