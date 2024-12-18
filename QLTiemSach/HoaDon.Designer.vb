<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HoaDon))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbLoaiHoaDon = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBan = New System.Windows.Forms.DataGridView()
        Me.DsHDBan1 = New QLTiemSach.dsHDBan()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.SoHDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMuon = New System.Windows.Forms.DataGridView()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DsHDMuon1 = New QLTiemSach.dsHDMuon()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter()
        Me.SoHDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNVDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKHDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSachDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTraDuKienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvBan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHDBan1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHDMuon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1025, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'cbLoaiHoaDon
        '
        Me.cbLoaiHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiHoaDon.FormattingEnabled = True
        Me.cbLoaiHoaDon.Items.AddRange(New Object() {"Hoá Đơn Mượn", "Hoá Đơn Bán"})
        Me.cbLoaiHoaDon.Location = New System.Drawing.Point(125, 36)
        Me.cbLoaiHoaDon.Name = "cbLoaiHoaDon"
        Me.cbLoaiHoaDon.Size = New System.Drawing.Size(183, 28)
        Me.cbLoaiHoaDon.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Loại hoá đơn:"
        '
        'dgvBan
        '
        Me.dgvBan.AutoGenerateColumns = False
        Me.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SoHDDataGridViewTextBoxColumn, Me.MaNVDataGridViewTextBoxColumn, Me.MaKHDataGridViewTextBoxColumn, Me.MaSachDataGridViewTextBoxColumn, Me.NgayMuaDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn})
        Me.dgvBan.DataMember = "HDBan"
        Me.dgvBan.DataSource = Me.DsHDBan1
        Me.dgvBan.Location = New System.Drawing.Point(18, 81)
        Me.dgvBan.Name = "dgvBan"
        Me.dgvBan.RowHeadersWidth = 62
        Me.dgvBan.RowTemplate.Height = 28
        Me.dgvBan.Size = New System.Drawing.Size(995, 392)
        Me.dgvBan.TabIndex = 3
        '
        'DsHDBan1
        '
        Me.DsHDBan1.DataSetName = "dsHDBan"
        Me.DsHDBan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMua", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMua"), New System.Data.OleDb.OleDbParameter("SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, "SoLuong"), New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMua", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMua", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ""QLTiemSach"".""dbo"".""HDBan"" WHERE ((""SoHD"" = ?) AND (""MaNV"" = ?) AND (" &
    """MaKH"" = ?) AND (""MaSach"" = ?) AND (""NgayMua"" = ?) AND ((? = 1 AND ""SoLuong"" IS " &
    "NULL) OR (""SoLuong"" = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMua", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMua", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "HDBan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SoHD", "SoHD"), New System.Data.Common.DataColumnMapping("MaNV", "MaNV"), New System.Data.Common.DataColumnMapping("MaKH", "MaKH"), New System.Data.Common.DataColumnMapping("MaSach", "MaSach"), New System.Data.Common.DataColumnMapping("NgayMua", "NgayMua"), New System.Data.Common.DataColumnMapping("SoLuong", "SoLuong")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""HDBan"" (""SoHD"", ""MaNV"", ""MaKH"", ""MaSach"", ""NgayMu" &
    "a"", ""SoLuong"") VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMua", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMua"), New System.Data.OleDb.OleDbParameter("SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, "SoLuong")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.HDBan.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.HDBan"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'SoHDDataGridViewTextBoxColumn
        '
        Me.SoHDDataGridViewTextBoxColumn.DataPropertyName = "SoHD"
        Me.SoHDDataGridViewTextBoxColumn.HeaderText = "SoHD"
        Me.SoHDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SoHDDataGridViewTextBoxColumn.Name = "SoHDDataGridViewTextBoxColumn"
        Me.SoHDDataGridViewTextBoxColumn.Width = 150
        '
        'MaNVDataGridViewTextBoxColumn
        '
        Me.MaNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV"
        Me.MaNVDataGridViewTextBoxColumn.HeaderText = "MaNV"
        Me.MaNVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaNVDataGridViewTextBoxColumn.Name = "MaNVDataGridViewTextBoxColumn"
        Me.MaNVDataGridViewTextBoxColumn.Width = 150
        '
        'MaKHDataGridViewTextBoxColumn
        '
        Me.MaKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH"
        Me.MaKHDataGridViewTextBoxColumn.HeaderText = "MaKH"
        Me.MaKHDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaKHDataGridViewTextBoxColumn.Name = "MaKHDataGridViewTextBoxColumn"
        Me.MaKHDataGridViewTextBoxColumn.Width = 150
        '
        'MaSachDataGridViewTextBoxColumn
        '
        Me.MaSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach"
        Me.MaSachDataGridViewTextBoxColumn.HeaderText = "MaSach"
        Me.MaSachDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaSachDataGridViewTextBoxColumn.Name = "MaSachDataGridViewTextBoxColumn"
        Me.MaSachDataGridViewTextBoxColumn.Width = 150
        '
        'NgayMuaDataGridViewTextBoxColumn
        '
        Me.NgayMuaDataGridViewTextBoxColumn.DataPropertyName = "NgayMua"
        Me.NgayMuaDataGridViewTextBoxColumn.HeaderText = "NgayMua"
        Me.NgayMuaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NgayMuaDataGridViewTextBoxColumn.Name = "NgayMuaDataGridViewTextBoxColumn"
        Me.NgayMuaDataGridViewTextBoxColumn.Width = 150
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.Width = 150
        '
        'dgvMuon
        '
        Me.dgvMuon.AutoGenerateColumns = False
        Me.dgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SoHDDataGridViewTextBoxColumn1, Me.MaNVDataGridViewTextBoxColumn1, Me.MaKHDataGridViewTextBoxColumn1, Me.MaSachDataGridViewTextBoxColumn1, Me.NgayMuonDataGridViewTextBoxColumn, Me.NgayTraDuKienDataGridViewTextBoxColumn, Me.TinhTrangDataGridViewTextBoxColumn})
        Me.dgvMuon.DataMember = "HDMuon"
        Me.dgvMuon.DataSource = Me.DsHDMuon1
        Me.dgvMuon.Location = New System.Drawing.Point(18, 81)
        Me.dgvMuon.Name = "dgvMuon"
        Me.dgvMuon.RowHeadersWidth = 62
        Me.dgvMuon.RowTemplate.Height = 28
        Me.dgvMuon.Size = New System.Drawing.Size(995, 392)
        Me.dgvMuon.TabIndex = 4
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT dbo.HDMuon.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.HDMuon"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""HDMuon"" (""SoHD"", ""MaNV"", ""MaKH"", ""MaSach"", ""NgayM" &
    "uon"", ""NgayTraDuKien"", ""TinhTrang"") VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMuon"), New System.Data.OleDb.OleDbParameter("NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, "NgayTraDuKien"), New System.Data.OleDb.OleDbParameter("TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, "TinhTrang")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMuon"), New System.Data.OleDb.OleDbParameter("NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, "NgayTraDuKien"), New System.Data.OleDb.OleDbParameter("TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, "TinhTrang"), New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMuon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayTraDuKien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinhTrang", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = resources.GetString("OleDbDeleteCommand2.CommandText")
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMuon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayTraDuKien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinhTrang", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "HDMuon", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SoHD", "SoHD"), New System.Data.Common.DataColumnMapping("MaNV", "MaNV"), New System.Data.Common.DataColumnMapping("MaKH", "MaKH"), New System.Data.Common.DataColumnMapping("MaSach", "MaSach"), New System.Data.Common.DataColumnMapping("NgayMuon", "NgayMuon"), New System.Data.Common.DataColumnMapping("NgayTraDuKien", "NgayTraDuKien"), New System.Data.Common.DataColumnMapping("TinhTrang", "TinhTrang")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'DsHDMuon1
        '
        Me.DsHDMuon1.DataSetName = "dsHDMuon"
        Me.DsHDMuon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT dbo.HDMuon.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.HDMuon"
        Me.OleDbCommand1.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbCommand2
        '
        Me.OleDbCommand2.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""HDMuon"" (""SoHD"", ""MaNV"", ""MaKH"", ""MaSach"", ""NgayM" &
    "uon"", ""NgayTraDuKien"", ""TinhTrang"") VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbCommand2.Connection = Me.OleDbConnection2
        Me.OleDbCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMuon"), New System.Data.OleDb.OleDbParameter("NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, "NgayTraDuKien"), New System.Data.OleDb.OleDbParameter("TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, "TinhTrang")})
        '
        'OleDbCommand3
        '
        Me.OleDbCommand3.CommandText = resources.GetString("OleDbCommand3.CommandText")
        Me.OleDbCommand3.Connection = Me.OleDbConnection2
        Me.OleDbCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMuon"), New System.Data.OleDb.OleDbParameter("NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, "NgayTraDuKien"), New System.Data.OleDb.OleDbParameter("TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, "TinhTrang"), New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMuon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayTraDuKien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinhTrang", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbCommand4
        '
        Me.OleDbCommand4.CommandText = resources.GetString("OleDbCommand4.CommandText")
        Me.OleDbCommand4.Connection = Me.OleDbConnection2
        Me.OleDbCommand4.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMuon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayTraDuKien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinhTrang", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbCommand4
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbCommand2
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbCommand1
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "HDMuon", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SoHD", "SoHD"), New System.Data.Common.DataColumnMapping("MaNV", "MaNV"), New System.Data.Common.DataColumnMapping("MaKH", "MaKH"), New System.Data.Common.DataColumnMapping("MaSach", "MaSach"), New System.Data.Common.DataColumnMapping("NgayMuon", "NgayMuon"), New System.Data.Common.DataColumnMapping("NgayTraDuKien", "NgayTraDuKien"), New System.Data.Common.DataColumnMapping("TinhTrang", "TinhTrang")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbCommand3
        '
        'SoHDDataGridViewTextBoxColumn1
        '
        Me.SoHDDataGridViewTextBoxColumn1.DataPropertyName = "SoHD"
        Me.SoHDDataGridViewTextBoxColumn1.HeaderText = "SoHD"
        Me.SoHDDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.SoHDDataGridViewTextBoxColumn1.Name = "SoHDDataGridViewTextBoxColumn1"
        Me.SoHDDataGridViewTextBoxColumn1.Width = 150
        '
        'MaNVDataGridViewTextBoxColumn1
        '
        Me.MaNVDataGridViewTextBoxColumn1.DataPropertyName = "MaNV"
        Me.MaNVDataGridViewTextBoxColumn1.HeaderText = "MaNV"
        Me.MaNVDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.MaNVDataGridViewTextBoxColumn1.Name = "MaNVDataGridViewTextBoxColumn1"
        Me.MaNVDataGridViewTextBoxColumn1.Width = 150
        '
        'MaKHDataGridViewTextBoxColumn1
        '
        Me.MaKHDataGridViewTextBoxColumn1.DataPropertyName = "MaKH"
        Me.MaKHDataGridViewTextBoxColumn1.HeaderText = "MaKH"
        Me.MaKHDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.MaKHDataGridViewTextBoxColumn1.Name = "MaKHDataGridViewTextBoxColumn1"
        Me.MaKHDataGridViewTextBoxColumn1.Width = 150
        '
        'MaSachDataGridViewTextBoxColumn1
        '
        Me.MaSachDataGridViewTextBoxColumn1.DataPropertyName = "MaSach"
        Me.MaSachDataGridViewTextBoxColumn1.HeaderText = "MaSach"
        Me.MaSachDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.MaSachDataGridViewTextBoxColumn1.Name = "MaSachDataGridViewTextBoxColumn1"
        Me.MaSachDataGridViewTextBoxColumn1.Width = 150
        '
        'NgayMuonDataGridViewTextBoxColumn
        '
        Me.NgayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon"
        Me.NgayMuonDataGridViewTextBoxColumn.HeaderText = "NgayMuon"
        Me.NgayMuonDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NgayMuonDataGridViewTextBoxColumn.Name = "NgayMuonDataGridViewTextBoxColumn"
        Me.NgayMuonDataGridViewTextBoxColumn.Width = 150
        '
        'NgayTraDuKienDataGridViewTextBoxColumn
        '
        Me.NgayTraDuKienDataGridViewTextBoxColumn.DataPropertyName = "NgayTraDuKien"
        Me.NgayTraDuKienDataGridViewTextBoxColumn.HeaderText = "NgayTraDuKien"
        Me.NgayTraDuKienDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NgayTraDuKienDataGridViewTextBoxColumn.Name = "NgayTraDuKienDataGridViewTextBoxColumn"
        Me.NgayTraDuKienDataGridViewTextBoxColumn.Width = 150
        '
        'TinhTrangDataGridViewTextBoxColumn
        '
        Me.TinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang"
        Me.TinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang"
        Me.TinhTrangDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TinhTrangDataGridViewTextBoxColumn.Name = "TinhTrangDataGridViewTextBoxColumn"
        Me.TinhTrangDataGridViewTextBoxColumn.Width = 150
        '
        'HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 808)
        Me.Controls.Add(Me.dgvMuon)
        Me.Controls.Add(Me.dgvBan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbLoaiHoaDon)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HoaDon"
        Me.Text = "Hoá Đơn"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvBan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHDBan1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMuon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHDMuon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbLoaiHoaDon As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBan As DataGridView
    Friend WithEvents DsHDBan1 As dsHDBan
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents SoHDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvMuon As DataGridView
    Friend WithEvents OleDbSelectCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As OleDb.OleDbDataAdapter
    Friend WithEvents DsHDMuon1 As dsHDMuon
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As OleDb.OleDbConnection
    Friend WithEvents OleDbCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter3 As OleDb.OleDbDataAdapter
    Friend WithEvents SoHDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaNVDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaKHDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaSachDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayTraDuKienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TinhTrangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
