<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NhanVien))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsNhanVien1 = New QLTiemSach.dsNhanVien()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuayLạiĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMaNV = New System.Windows.Forms.TextBox()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbTenNV = New System.Windows.Forms.TextBox()
        Me.tbDienThoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNhanVien1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNVDataGridViewTextBoxColumn, Me.TenNVDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.DienThoaiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "NhanVien"
        Me.DataGridView1.DataSource = Me.DsNhanVien1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(731, 195)
        Me.DataGridView1.TabIndex = 0
        '
        'MaNVDataGridViewTextBoxColumn
        '
        Me.MaNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV"
        Me.MaNVDataGridViewTextBoxColumn.HeaderText = "Mã NV"
        Me.MaNVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaNVDataGridViewTextBoxColumn.Name = "MaNVDataGridViewTextBoxColumn"
        Me.MaNVDataGridViewTextBoxColumn.Width = 65
        '
        'TenNVDataGridViewTextBoxColumn
        '
        Me.TenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV"
        Me.TenNVDataGridViewTextBoxColumn.HeaderText = "Tên NV"
        Me.TenNVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TenNVDataGridViewTextBoxColumn.Name = "TenNVDataGridViewTextBoxColumn"
        Me.TenNVDataGridViewTextBoxColumn.Width = 110
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ"
        Me.DiaChiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.Width = 110
        '
        'DienThoaiDataGridViewTextBoxColumn
        '
        Me.DienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai"
        Me.DienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện Thoại"
        Me.DienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DienThoaiDataGridViewTextBoxColumn.Name = "DienThoaiDataGridViewTextBoxColumn"
        Me.DienThoaiDataGridViewTextBoxColumn.Width = 120
        '
        'DsNhanVien1
        '
        Me.DsNhanVien1.DataSetName = "dsNhanVien"
        Me.DsNhanVien1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.NhanVien.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.NhanVien"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""NhanVien"" (""MaNV"", ""TenNV"", ""DiaChi"", ""DienThoai""" &
    ") VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("TenNV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenNV"), New System.Data.OleDb.OleDbParameter("DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, "DiaChi"), New System.Data.OleDb.OleDbParameter("DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, "DienThoai")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("TenNV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenNV"), New System.Data.OleDb.OleDbParameter("DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, "DiaChi"), New System.Data.OleDb.OleDbParameter("DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, "DienThoai"), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenNV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DiaChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DienThoai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ""QLTiemSach"".""dbo"".""NhanVien"" WHERE ((""MaNV"" = ?) AND (""TenNV"" = ?) A" &
    "ND ((? = 1 AND ""DiaChi"" IS NULL) OR (""DiaChi"" = ?)) AND ((? = 1 AND ""DienThoai"" " &
    "IS NULL) OR (""DienThoai"" = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenNV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DiaChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DienThoai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NhanVien", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaNV", "MaNV"), New System.Data.Common.DataColumnMapping("TenNV", "TenNV"), New System.Data.Common.DataColumnMapping("DiaChi", "DiaChi"), New System.Data.Common.DataColumnMapping("DienThoai", "DienThoai")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.QuayLạiĐăngNhậpToolStripMenuItem, Me.QuảnLýToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(758, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SáchToolStripMenuItem
        '
        Me.SáchToolStripMenuItem.Name = "SáchToolStripMenuItem"
        Me.SáchToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.SáchToolStripMenuItem.Text = "Sách"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(120, 29)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'QuayLạiĐăngNhậpToolStripMenuItem
        '
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Name = "QuayLạiĐăngNhậpToolStripMenuItem"
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(183, 29)
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Text = "Quay lại đăng nhập"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(650, 452)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(93, 39)
        Me.btThoat.TabIndex = 54
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(469, 453)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(93, 39)
        Me.btXoa.TabIndex = 53
        Me.btXoa.Text = "Xoá"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(322, 452)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(93, 39)
        Me.btSua.TabIndex = 52
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(173, 453)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(93, 39)
        Me.btThem.TabIndex = 51
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Mã NV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Địa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(396, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Tên NV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Điện Thoại"
        '
        'tbMaNV
        '
        Me.tbMaNV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.MaNV", True))
        Me.tbMaNV.Location = New System.Drawing.Point(139, 268)
        Me.tbMaNV.Name = "tbMaNV"
        Me.tbMaNV.Size = New System.Drawing.Size(221, 26)
        Me.tbMaNV.TabIndex = 60
        '
        'tbDiaChi
        '
        Me.tbDiaChi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.DiaChi", True))
        Me.tbDiaChi.Location = New System.Drawing.Point(139, 344)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(221, 26)
        Me.tbDiaChi.TabIndex = 61
        '
        'tbTenNV
        '
        Me.tbTenNV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.TenNV", True))
        Me.tbTenNV.Location = New System.Drawing.Point(492, 268)
        Me.tbTenNV.Name = "tbTenNV"
        Me.tbTenNV.Size = New System.Drawing.Size(221, 26)
        Me.tbTenNV.TabIndex = 62
        '
        'tbDienThoai
        '
        Me.tbDienThoai.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNhanVien1, "NhanVien.DienThoai", True))
        Me.tbDienThoai.Location = New System.Drawing.Point(492, 344)
        Me.tbDienThoai.Name = "tbDienThoai"
        Me.tbDienThoai.Size = New System.Drawing.Size(221, 26)
        Me.tbDienThoai.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "(Lưu ý: không được trùng Mã NV)"
        '
        'NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 521)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDienThoai)
        Me.Controls.Add(Me.tbTenNV)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.tbMaNV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NhanVien"
        Me.Text = "Nhân Viên"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNhanVien1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsNhanVien1 As dsNhanVien
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuayLạiĐăngNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMaNV As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbTenNV As TextBox
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents MaNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
End Class
