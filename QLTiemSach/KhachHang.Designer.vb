<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KhachHang))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NguoiGTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsKhach1 = New QLTiemSach.dsKhach()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuayLạiĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMaKH = New System.Windows.Forms.TextBox()
        Me.tbTenKH = New System.Windows.Forms.TextBox()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbDienThoai = New System.Windows.Forms.TextBox()
        Me.tbQuan = New System.Windows.Forms.TextBox()
        Me.tbNguoiGT = New System.Windows.Forms.TextBox()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsKhach1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKHDataGridViewTextBoxColumn, Me.TenKHDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.QuanDataGridViewTextBoxColumn, Me.DienThoaiDataGridViewTextBoxColumn, Me.NguoiGTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "KhachHang"
        Me.DataGridView1.DataSource = Me.DsKhach1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1149, 327)
        Me.DataGridView1.TabIndex = 0
        '
        'MaKHDataGridViewTextBoxColumn
        '
        Me.MaKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH"
        Me.MaKHDataGridViewTextBoxColumn.HeaderText = "Mã KH"
        Me.MaKHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaKHDataGridViewTextBoxColumn.Name = "MaKHDataGridViewTextBoxColumn"
        Me.MaKHDataGridViewTextBoxColumn.Width = 150
        '
        'TenKHDataGridViewTextBoxColumn
        '
        Me.TenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH"
        Me.TenKHDataGridViewTextBoxColumn.HeaderText = "Tên KH"
        Me.TenKHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TenKHDataGridViewTextBoxColumn.Name = "TenKHDataGridViewTextBoxColumn"
        Me.TenKHDataGridViewTextBoxColumn.Width = 150
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ"
        Me.DiaChiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.Width = 150
        '
        'QuanDataGridViewTextBoxColumn
        '
        Me.QuanDataGridViewTextBoxColumn.DataPropertyName = "Quan"
        Me.QuanDataGridViewTextBoxColumn.HeaderText = "Quận"
        Me.QuanDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.QuanDataGridViewTextBoxColumn.Name = "QuanDataGridViewTextBoxColumn"
        Me.QuanDataGridViewTextBoxColumn.Width = 150
        '
        'DienThoaiDataGridViewTextBoxColumn
        '
        Me.DienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai"
        Me.DienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện Thoại"
        Me.DienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DienThoaiDataGridViewTextBoxColumn.Name = "DienThoaiDataGridViewTextBoxColumn"
        Me.DienThoaiDataGridViewTextBoxColumn.Width = 150
        '
        'NguoiGTDataGridViewTextBoxColumn
        '
        Me.NguoiGTDataGridViewTextBoxColumn.DataPropertyName = "NguoiGT"
        Me.NguoiGTDataGridViewTextBoxColumn.HeaderText = "Người GT"
        Me.NguoiGTDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NguoiGTDataGridViewTextBoxColumn.Name = "NguoiGTDataGridViewTextBoxColumn"
        Me.NguoiGTDataGridViewTextBoxColumn.Width = 150
        '
        'DsKhach1
        '
        Me.DsKhach1.DataSetName = "dsKhach"
        Me.DsKhach1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.KhachHang.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.KhachHang"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""KhachHang"" (""MaKH"", ""TenKH"", ""DiaChi"", ""Quan"", ""D" &
    "ienThoai"", ""NguoiGT"") VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("TenKH", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKH"), New System.Data.OleDb.OleDbParameter("DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, "DiaChi"), New System.Data.OleDb.OleDbParameter("Quan", System.Data.OleDb.OleDbType.VarWChar, 0, "Quan"), New System.Data.OleDb.OleDbParameter("DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, "DienThoai"), New System.Data.OleDb.OleDbParameter("NguoiGT", System.Data.OleDb.OleDbType.VarWChar, 0, "NguoiGT")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("TenKH", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKH"), New System.Data.OleDb.OleDbParameter("DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, "DiaChi"), New System.Data.OleDb.OleDbParameter("Quan", System.Data.OleDb.OleDbType.VarWChar, 0, "Quan"), New System.Data.OleDb.OleDbParameter("DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, "DienThoai"), New System.Data.OleDb.OleDbParameter("NguoiGT", System.Data.OleDb.OleDbType.VarWChar, 0, "NguoiGT"), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKH", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Quan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DienThoai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NguoiGT", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NguoiGT", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NguoiGT", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NguoiGT", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKH", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Quan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DienThoai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DienThoai", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DienThoai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NguoiGT", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NguoiGT", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NguoiGT", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NguoiGT", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "KhachHang", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaKH", "MaKH"), New System.Data.Common.DataColumnMapping("TenKH", "TenKH"), New System.Data.Common.DataColumnMapping("DiaChi", "DiaChi"), New System.Data.Common.DataColumnMapping("Quan", "Quan"), New System.Data.Common.DataColumnMapping("DienThoai", "DienThoai"), New System.Data.Common.DataColumnMapping("NguoiGT", "NguoiGT")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.QuayLạiĐăngNhậpToolStripMenuItem, Me.QuảnLýToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1173, 36)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SáchToolStripMenuItem
        '
        Me.SáchToolStripMenuItem.Name = "SáchToolStripMenuItem"
        Me.SáchToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.SáchToolStripMenuItem.Text = "Sách"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(107, 32)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'QuayLạiĐăngNhậpToolStripMenuItem
        '
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Name = "QuayLạiĐăngNhậpToolStripMenuItem"
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(183, 32)
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Text = "Quay lại đăng nhập"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(92, 32)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã KH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên KH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Địa Chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 541)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Điện Thoại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(594, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quận"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(594, 538)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Người GT"
        '
        'tbMaKH
        '
        Me.tbMaKH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsKhach1, "KhachHang.MaKH", True))
        Me.tbMaKH.Location = New System.Drawing.Point(182, 395)
        Me.tbMaKH.Name = "tbMaKH"
        Me.tbMaKH.Size = New System.Drawing.Size(250, 26)
        Me.tbMaKH.TabIndex = 8
        '
        'tbTenKH
        '
        Me.tbTenKH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsKhach1, "KhachHang.TenKH", True))
        Me.tbTenKH.Location = New System.Drawing.Point(696, 395)
        Me.tbTenKH.Name = "tbTenKH"
        Me.tbTenKH.Size = New System.Drawing.Size(248, 26)
        Me.tbTenKH.TabIndex = 9
        '
        'tbDiaChi
        '
        Me.tbDiaChi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsKhach1, "KhachHang.DiaChi", True))
        Me.tbDiaChi.Location = New System.Drawing.Point(182, 470)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(250, 26)
        Me.tbDiaChi.TabIndex = 9
        '
        'tbDienThoai
        '
        Me.tbDienThoai.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsKhach1, "KhachHang.DienThoai", True))
        Me.tbDienThoai.Location = New System.Drawing.Point(182, 535)
        Me.tbDienThoai.Name = "tbDienThoai"
        Me.tbDienThoai.Size = New System.Drawing.Size(250, 26)
        Me.tbDienThoai.TabIndex = 10
        '
        'tbQuan
        '
        Me.tbQuan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsKhach1, "KhachHang.Quan", True))
        Me.tbQuan.Location = New System.Drawing.Point(696, 467)
        Me.tbQuan.Name = "tbQuan"
        Me.tbQuan.Size = New System.Drawing.Size(248, 26)
        Me.tbQuan.TabIndex = 11
        '
        'tbNguoiGT
        '
        Me.tbNguoiGT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsKhach1, "KhachHang.NguoiGT", True))
        Me.tbNguoiGT.Location = New System.Drawing.Point(696, 535)
        Me.tbNguoiGT.Name = "tbNguoiGT"
        Me.tbNguoiGT.Size = New System.Drawing.Size(248, 26)
        Me.tbNguoiGT.TabIndex = 12
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(875, 598)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(93, 40)
        Me.btThoat.TabIndex = 47
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(502, 598)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(93, 40)
        Me.btXoa.TabIndex = 46
        Me.btXoa.Text = "Xoá"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(359, 598)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(93, 40)
        Me.btSua.TabIndex = 45
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(205, 598)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(93, 40)
        Me.btThem.TabIndex = 44
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "(*Lưu ý: ko được trùng Mã KH)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 598)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 650)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.tbNguoiGT)
        Me.Controls.Add(Me.tbQuan)
        Me.Controls.Add(Me.tbDienThoai)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.tbTenKH)
        Me.Controls.Add(Me.tbMaKH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "KhachHang"
        Me.Text = "Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsKhach1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsKhach1 As dsKhach
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuayLạiĐăngNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbMaKH As TextBox
    Friend WithEvents tbTenKH As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents tbQuan As TextBox
    Friend WithEvents tbNguoiGT As TextBox
    Friend WithEvents btThoat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MaKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NguoiGTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
End Class
