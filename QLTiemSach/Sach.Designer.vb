<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sach))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaSachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NhaXBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChuDeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrongKhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsSach1 = New QLTiemSach.dsSach()
        Me.DsSach1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaSach = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SachBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbNhaXB = New System.Windows.Forms.TextBox()
        Me.tbTenSach = New System.Windows.Forms.TextBox()
        Me.tbDonGia = New System.Windows.Forms.TextBox()
        Me.tbTacGia = New System.Windows.Forms.TextBox()
        Me.tbChuDe = New System.Windows.Forms.TextBox()
        Me.tbTrongKho = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.QuayLạiĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSach1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSach1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SachBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSachDataGridViewTextBoxColumn, Me.TenSachDataGridViewTextBoxColumn, Me.TacGiaDataGridViewTextBoxColumn, Me.NhaXBDataGridViewTextBoxColumn, Me.ChuDeDataGridViewTextBoxColumn, Me.DonGiaDataGridViewTextBoxColumn, Me.TrongKhoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Sach"
        Me.DataGridView1.DataSource = Me.DsSach1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1139, 277)
        Me.DataGridView1.TabIndex = 0
        '
        'MaSachDataGridViewTextBoxColumn
        '
        Me.MaSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach"
        Me.MaSachDataGridViewTextBoxColumn.HeaderText = "Mã Sách"
        Me.MaSachDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaSachDataGridViewTextBoxColumn.Name = "MaSachDataGridViewTextBoxColumn"
        Me.MaSachDataGridViewTextBoxColumn.Width = 60
        '
        'TenSachDataGridViewTextBoxColumn
        '
        Me.TenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach"
        Me.TenSachDataGridViewTextBoxColumn.HeaderText = "Tên Sách"
        Me.TenSachDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TenSachDataGridViewTextBoxColumn.Name = "TenSachDataGridViewTextBoxColumn"
        Me.TenSachDataGridViewTextBoxColumn.Width = 200
        '
        'TacGiaDataGridViewTextBoxColumn
        '
        Me.TacGiaDataGridViewTextBoxColumn.DataPropertyName = "TacGia"
        Me.TacGiaDataGridViewTextBoxColumn.HeaderText = "Tác Giả"
        Me.TacGiaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TacGiaDataGridViewTextBoxColumn.Name = "TacGiaDataGridViewTextBoxColumn"
        Me.TacGiaDataGridViewTextBoxColumn.Width = 150
        '
        'NhaXBDataGridViewTextBoxColumn
        '
        Me.NhaXBDataGridViewTextBoxColumn.DataPropertyName = "NhaXB"
        Me.NhaXBDataGridViewTextBoxColumn.HeaderText = "Nhà XB"
        Me.NhaXBDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NhaXBDataGridViewTextBoxColumn.Name = "NhaXBDataGridViewTextBoxColumn"
        Me.NhaXBDataGridViewTextBoxColumn.Width = 95
        '
        'ChuDeDataGridViewTextBoxColumn
        '
        Me.ChuDeDataGridViewTextBoxColumn.DataPropertyName = "ChuDe"
        Me.ChuDeDataGridViewTextBoxColumn.HeaderText = "Chủ Đề"
        Me.ChuDeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ChuDeDataGridViewTextBoxColumn.Name = "ChuDeDataGridViewTextBoxColumn"
        Me.ChuDeDataGridViewTextBoxColumn.Width = 70
        '
        'DonGiaDataGridViewTextBoxColumn
        '
        Me.DonGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia"
        Me.DonGiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá"
        Me.DonGiaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DonGiaDataGridViewTextBoxColumn.Name = "DonGiaDataGridViewTextBoxColumn"
        Me.DonGiaDataGridViewTextBoxColumn.Width = 70
        '
        'TrongKhoDataGridViewTextBoxColumn
        '
        Me.TrongKhoDataGridViewTextBoxColumn.DataPropertyName = "TrongKho"
        Me.TrongKhoDataGridViewTextBoxColumn.HeaderText = "Trong Kho"
        Me.TrongKhoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TrongKhoDataGridViewTextBoxColumn.Name = "TrongKhoDataGridViewTextBoxColumn"
        Me.TrongKhoDataGridViewTextBoxColumn.Width = 70
        '
        'DsSach1
        '
        Me.DsSach1.DataSetName = "dsSach"
        Me.DsSach1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsSach1BindingSource
        '
        Me.DsSach1BindingSource.DataSource = Me.DsSach1
        Me.DsSach1BindingSource.Position = 0
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.Sach.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.Sach"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""Sach"" (""MaSach"", ""TenSach"", ""TacGia"", ""NhaXB"", ""C" &
    "huDe"", ""DonGia"", ""TrongKho"") VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("TenSach", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSach"), New System.Data.OleDb.OleDbParameter("TacGia", System.Data.OleDb.OleDbType.VarWChar, 0, "TacGia"), New System.Data.OleDb.OleDbParameter("NhaXB", System.Data.OleDb.OleDbType.VarWChar, 0, "NhaXB"), New System.Data.OleDb.OleDbParameter("ChuDe", System.Data.OleDb.OleDbType.VarWChar, 0, "ChuDe"), New System.Data.OleDb.OleDbParameter("DonGia", System.Data.OleDb.OleDbType.Currency, 0, "DonGia"), New System.Data.OleDb.OleDbParameter("TrongKho", System.Data.OleDb.OleDbType.[Integer], 0, "TrongKho")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("TenSach", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSach"), New System.Data.OleDb.OleDbParameter("TacGia", System.Data.OleDb.OleDbType.VarWChar, 0, "TacGia"), New System.Data.OleDb.OleDbParameter("NhaXB", System.Data.OleDb.OleDbType.VarWChar, 0, "NhaXB"), New System.Data.OleDb.OleDbParameter("ChuDe", System.Data.OleDb.OleDbType.VarWChar, 0, "ChuDe"), New System.Data.OleDb.OleDbParameter("DonGia", System.Data.OleDb.OleDbType.Currency, 0, "DonGia"), New System.Data.OleDb.OleDbParameter("TrongKho", System.Data.OleDb.OleDbType.[Integer], 0, "TrongKho"), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSach", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TacGia", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TacGia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NhaXB", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NhaXB", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ChuDe", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChuDe", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DonGia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DonGia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DonGia", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DonGia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TrongKho", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TrongKho", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TrongKho", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrongKho", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSach", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TacGia", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TacGia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NhaXB", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NhaXB", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ChuDe", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChuDe", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DonGia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DonGia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DonGia", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DonGia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TrongKho", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TrongKho", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TrongKho", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TrongKho", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sach", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSach", "MaSach"), New System.Data.Common.DataColumnMapping("TenSach", "TenSach"), New System.Data.Common.DataColumnMapping("TacGia", "TacGia"), New System.Data.Common.DataColumnMapping("NhaXB", "NhaXB"), New System.Data.Common.DataColumnMapping("ChuDe", "ChuDe"), New System.Data.Common.DataColumnMapping("DonGia", "DonGia"), New System.Data.Common.DataColumnMapping("TrongKho", "TrongKho")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.QuayLạiĐăngNhậpToolStripMenuItem, Me.QuảnLýToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1139, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(120, 29)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
        Me.NhânViênToolStripMenuItem.Text = "Nhân viên"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.QuảnLýToolStripMenuItem.Text = "Quản Lý"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(912, 592)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(93, 39)
        Me.btThoat.TabIndex = 43
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(539, 592)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(93, 39)
        Me.btXoa.TabIndex = 42
        Me.btXoa.Text = "Xoá"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(396, 592)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(93, 39)
        Me.btSua.TabIndex = 41
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(242, 592)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(93, 39)
        Me.btThem.TabIndex = 40
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "(*Lưu ý: ko được trùng Mã Sách)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(624, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nhà XB"
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Location = New System.Drawing.Point(120, 421)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(68, 20)
        Me.d.TabIndex = 37
        Me.d.Text = "Tác Giả "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Tên Sách"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Mã Sách"
        '
        'tbMaSach
        '
        Me.tbMaSach.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSach1, "Sach.MaSach", True))
        Me.tbMaSach.Location = New System.Drawing.Point(211, 347)
        Me.tbMaSach.Name = "tbMaSach"
        Me.tbMaSach.Size = New System.Drawing.Size(247, 26)
        Me.tbMaSach.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Chủ Đề"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(624, 471)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Đơn Giá"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 529)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Trong Kho"
        '
        'SachBindingSource
        '
        Me.SachBindingSource.DataMember = "Sach"
        Me.SachBindingSource.DataSource = Me.DsSach1
        '
        'tbNhaXB
        '
        Me.tbNhaXB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSach1, "Sach.NhaXB", True))
        Me.tbNhaXB.Location = New System.Drawing.Point(750, 406)
        Me.tbNhaXB.Name = "tbNhaXB"
        Me.tbNhaXB.Size = New System.Drawing.Size(255, 26)
        Me.tbNhaXB.TabIndex = 33
        '
        'tbTenSach
        '
        Me.tbTenSach.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSach1, "Sach.TenSach", True))
        Me.tbTenSach.Location = New System.Drawing.Point(750, 347)
        Me.tbTenSach.Name = "tbTenSach"
        Me.tbTenSach.Size = New System.Drawing.Size(255, 26)
        Me.tbTenSach.TabIndex = 34
        '
        'tbDonGia
        '
        Me.tbDonGia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSach1, "Sach.DonGia", True))
        Me.tbDonGia.Location = New System.Drawing.Point(750, 468)
        Me.tbDonGia.Name = "tbDonGia"
        Me.tbDonGia.Size = New System.Drawing.Size(255, 26)
        Me.tbDonGia.TabIndex = 47
        '
        'tbTacGia
        '
        Me.tbTacGia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSach1, "Sach.TacGia", True))
        Me.tbTacGia.Location = New System.Drawing.Point(211, 418)
        Me.tbTacGia.Name = "tbTacGia"
        Me.tbTacGia.Size = New System.Drawing.Size(247, 26)
        Me.tbTacGia.TabIndex = 32
        '
        'tbChuDe
        '
        Me.tbChuDe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSach1, "Sach.ChuDe", True))
        Me.tbChuDe.Location = New System.Drawing.Point(211, 471)
        Me.tbChuDe.Name = "tbChuDe"
        Me.tbChuDe.Size = New System.Drawing.Size(247, 26)
        Me.tbChuDe.TabIndex = 46
        '
        'tbTrongKho
        '
        Me.tbTrongKho.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSach1, "Sach.TrongKho", True))
        Me.tbTrongKho.Location = New System.Drawing.Point(211, 526)
        Me.tbTrongKho.Name = "tbTrongKho"
        Me.tbTrongKho.Size = New System.Drawing.Size(247, 26)
        Me.tbTrongKho.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 592)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'QuayLạiĐăngNhậpToolStripMenuItem
        '
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Name = "QuayLạiĐăngNhậpToolStripMenuItem"
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Text = "Đăng xuất"
        '
        'Sach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 666)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbTrongKho)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbDonGia)
        Me.Controls.Add(Me.tbChuDe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTenSach)
        Me.Controls.Add(Me.tbNhaXB)
        Me.Controls.Add(Me.tbTacGia)
        Me.Controls.Add(Me.tbMaSach)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Sach"
        Me.Text = "Sách"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSach1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSach1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SachBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsSach1BindingSource As BindingSource
    Friend WithEvents DsSach1 As dsSach
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btThoat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents d As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMaSach As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SachBindingSource As BindingSource
    Friend WithEvents tbNhaXB As TextBox
    Friend WithEvents tbTenSach As TextBox
    Friend WithEvents tbDonGia As TextBox
    Friend WithEvents tbTacGia As TextBox
    Friend WithEvents tbChuDe As TextBox
    Friend WithEvents tbTrongKho As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MaSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TacGiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NhaXBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChuDeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DonGiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrongKhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Public WithEvents QuayLạiĐăngNhậpToolStripMenuItem As ToolStripMenuItem
End Class
