<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLTK
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
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.DsTaiKhoan1 = New QLTiemSach.dsTaiKhoan()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.lblhoten = New System.Windows.Forms.Label()
        Me.lbltaikhoan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.tbTaiKhoan = New System.Windows.Forms.TextBox()
        Me.tbMatKhau = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoáĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoáĐơnBánToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoáĐơnMượnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DsTaiKhoan1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbEmail
        '
        Me.tbEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsTaiKhoan1, "TaiKhoan.email", True))
        Me.tbEmail.Location = New System.Drawing.Point(226, 540)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(394, 26)
        Me.tbEmail.TabIndex = 48
        '
        'DsTaiKhoan1
        '
        Me.DsTaiKhoan1.DataSetName = "dsTaiKhoan"
        Me.DsTaiKhoan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(496, 623)
        Me.btnthoat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(112, 35)
        Me.btnthoat.TabIndex = 47
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(359, 623)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(112, 35)
        Me.btnxoa.TabIndex = 46
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btncapnhat
        '
        Me.btncapnhat.Location = New System.Drawing.Point(226, 623)
        Me.btncapnhat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(112, 35)
        Me.btncapnhat.TabIndex = 45
        Me.btncapnhat.Text = "Cập nhật"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = True
        Me.lblmatkhau.Location = New System.Drawing.Point(106, 545)
        Me.lblmatkhau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(48, 20)
        Me.lblmatkhau.TabIndex = 44
        Me.lblmatkhau.Text = "Email"
        '
        'lblhoten
        '
        Me.lblhoten.AutoSize = True
        Me.lblhoten.Location = New System.Drawing.Point(106, 500)
        Me.lblhoten.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhoten.Name = "lblhoten"
        Me.lblhoten.Size = New System.Drawing.Size(75, 20)
        Me.lblhoten.TabIndex = 43
        Me.lblhoten.Text = "Mật khẩu"
        '
        'lbltaikhoan
        '
        Me.lbltaikhoan.AutoSize = True
        Me.lbltaikhoan.Location = New System.Drawing.Point(106, 454)
        Me.lbltaikhoan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltaikhoan.Name = "lbltaikhoan"
        Me.lbltaikhoan.Size = New System.Drawing.Size(78, 20)
        Me.lbltaikhoan.TabIndex = 42
        Me.lbltaikhoan.Text = "Tài khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.CausesValidation = False
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 47)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "QUẢN LÝ TÀI KHOẢN"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(98, 623)
        Me.btnthem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(112, 35)
        Me.btnthem.TabIndex = 40
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'tbTaiKhoan
        '
        Me.tbTaiKhoan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsTaiKhoan1, "TaiKhoan.TK", True))
        Me.tbTaiKhoan.Location = New System.Drawing.Point(226, 449)
        Me.tbTaiKhoan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTaiKhoan.Name = "tbTaiKhoan"
        Me.tbTaiKhoan.Size = New System.Drawing.Size(394, 26)
        Me.tbTaiKhoan.TabIndex = 39
        '
        'tbMatKhau
        '
        Me.tbMatKhau.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsTaiKhoan1, "TaiKhoan.MK", True))
        Me.tbMatKhau.Location = New System.Drawing.Point(226, 495)
        Me.tbMatKhau.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMatKhau.Name = "tbMatKhau"
        Me.tbMatKhau.Size = New System.Drawing.Size(394, 26)
        Me.tbMatKhau.TabIndex = 38
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TKDataGridViewTextBoxColumn, Me.MKDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "TaiKhoan"
        Me.DataGridView1.DataSource = Me.DsTaiKhoan1
        Me.DataGridView1.Location = New System.Drawing.Point(51, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(626, 343)
        Me.DataGridView1.TabIndex = 49
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.TaiKhoan.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.TaiKhoan"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""TaiKhoan"" (""TK"", ""MK"", ""email"") VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("TK", System.Data.OleDb.OleDbType.VarChar, 0, "TK"), New System.Data.OleDb.OleDbParameter("MK", System.Data.OleDb.OleDbType.VarChar, 0, "MK"), New System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarChar, 0, "email")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ""QLTiemSach"".""dbo"".""TaiKhoan"" SET ""TK"" = ?, ""MK"" = ?, ""email"" = ? WHERE ((" &
    """TK"" = ?) AND (""MK"" = ?) AND (""email"" = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("TK", System.Data.OleDb.OleDbType.VarChar, 0, "TK"), New System.Data.OleDb.OleDbParameter("MK", System.Data.OleDb.OleDbType.VarChar, 0, "MK"), New System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarChar, 0, "email"), New System.Data.OleDb.OleDbParameter("Original_TK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_email", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ""QLTiemSach"".""dbo"".""TaiKhoan"" WHERE ((""TK"" = ?) AND (""MK"" = ?) AND (""" &
    "email"" = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_TK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MK", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MK", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_email", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TaiKhoan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TK", "TK"), New System.Data.Common.DataColumnMapping("MK", "MK"), New System.Data.Common.DataColumnMapping("email", "email")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.HoáĐơnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(727, 33)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SáchToolStripMenuItem
        '
        Me.SáchToolStripMenuItem.Name = "SáchToolStripMenuItem"
        Me.SáchToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.SáchToolStripMenuItem.Text = "Sách "
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(123, 29)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên"
        '
        'HoáĐơnToolStripMenuItem
        '
        Me.HoáĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HoáĐơnBánToolStripMenuItem, Me.HoáĐơnMượnToolStripMenuItem})
        Me.HoáĐơnToolStripMenuItem.Name = "HoáĐơnToolStripMenuItem"
        Me.HoáĐơnToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
        Me.HoáĐơnToolStripMenuItem.Text = "Hoá Đơn"
        '
        'HoáĐơnBánToolStripMenuItem
        '
        Me.HoáĐơnBánToolStripMenuItem.Name = "HoáĐơnBánToolStripMenuItem"
        Me.HoáĐơnBánToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.HoáĐơnBánToolStripMenuItem.Text = "Hoá Đơn Bán"
        '
        'HoáĐơnMượnToolStripMenuItem
        '
        Me.HoáĐơnMượnToolStripMenuItem.Name = "HoáĐơnMượnToolStripMenuItem"
        Me.HoáĐơnMượnToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.HoáĐơnMượnToolStripMenuItem.Text = "Hoá Đơn Mượn"
        '
        'TKDataGridViewTextBoxColumn
        '
        Me.TKDataGridViewTextBoxColumn.DataPropertyName = "TK"
        Me.TKDataGridViewTextBoxColumn.HeaderText = "Tài Khoản"
        Me.TKDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TKDataGridViewTextBoxColumn.Name = "TKDataGridViewTextBoxColumn"
        Me.TKDataGridViewTextBoxColumn.Width = 150
        '
        'MKDataGridViewTextBoxColumn
        '
        Me.MKDataGridViewTextBoxColumn.DataPropertyName = "MK"
        Me.MKDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu"
        Me.MKDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MKDataGridViewTextBoxColumn.Name = "MKDataGridViewTextBoxColumn"
        Me.MKDataGridViewTextBoxColumn.Width = 150
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'QLTK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 701)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.lblmatkhau)
        Me.Controls.Add(Me.lblhoten)
        Me.Controls.Add(Me.lbltaikhoan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.tbTaiKhoan)
        Me.Controls.Add(Me.tbMatKhau)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "QLTK"
        Me.Text = "Quản Lý Tài Khoản"
        CType(Me.DsTaiKhoan1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbEmail As TextBox
    Friend WithEvents btnthoat As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents btncapnhat As Button
    Friend WithEvents lblmatkhau As Label
    Friend WithEvents lblhoten As Label
    Friend WithEvents lbltaikhoan As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnthem As Button
    Friend WithEvents tbTaiKhoan As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsTaiKhoan1 As dsTaiKhoan
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoáĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoáĐơnBánToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoáĐơnMượnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
