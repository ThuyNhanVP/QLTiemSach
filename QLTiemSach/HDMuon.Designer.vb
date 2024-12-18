<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HDMuon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDMuon))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DsHDMuon1 = New QLTiemSach.dsHDMuon()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HDMuonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýPhânQuyềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuayLạiĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoHDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTraDuKienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHDMuon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SoHDDataGridViewTextBoxColumn, Me.MaNVDataGridViewTextBoxColumn, Me.MaKHDataGridViewTextBoxColumn, Me.MaSachDataGridViewTextBoxColumn, Me.NgayMuonDataGridViewTextBoxColumn, Me.NgayTraDuKienDataGridViewTextBoxColumn, Me.TinhTrangDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "HDMuon"
        Me.DataGridView1.DataSource = Me.DsHDMuon1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(776, 263)
        Me.DataGridView1.TabIndex = 0
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.HDMuon.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.HDMuon"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""HDMuon"" (""SoHD"", ""MaNV"", ""MaKH"", ""MaSach"", ""NgayM" &
    "uon"", ""NgayTraDuKien"", ""TinhTrang"") VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMuon"), New System.Data.OleDb.OleDbParameter("NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, "NgayTraDuKien"), New System.Data.OleDb.OleDbParameter("TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, "TinhTrang")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMuon"), New System.Data.OleDb.OleDbParameter("NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, "NgayTraDuKien"), New System.Data.OleDb.OleDbParameter("TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, "TinhTrang"), New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMuon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayTraDuKien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinhTrang", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_SoHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKH", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSach", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSach", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayMuon", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayMuon", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgayTraDuKien", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgayTraDuKien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinhTrang", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinhTrang", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinhTrang", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "HDMuon", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SoHD", "SoHD"), New System.Data.Common.DataColumnMapping("MaNV", "MaNV"), New System.Data.Common.DataColumnMapping("MaKH", "MaKH"), New System.Data.Common.DataColumnMapping("MaSach", "MaSach"), New System.Data.Common.DataColumnMapping("NgayMuon", "NgayMuon"), New System.Data.Common.DataColumnMapping("NgayTraDuKien", "NgayTraDuKien"), New System.Data.Common.DataColumnMapping("TinhTrang", "TinhTrang")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DsHDMuon1
        '
        Me.DsHDMuon1.DataSetName = "dsHDMuon"
        Me.DsHDMuon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.HDMuonToolStripMenuItem, Me.QuảnLýPhânQuyềnToolStripMenuItem, Me.QuayLạiĐăngNhậpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
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
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(114, 29)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên "
        '
        'HDMuonToolStripMenuItem
        '
        Me.HDMuonToolStripMenuItem.Name = "HDMuonToolStripMenuItem"
        Me.HDMuonToolStripMenuItem.Size = New System.Drawing.Size(134, 29)
        Me.HDMuonToolStripMenuItem.Text = "Hoá Đơn Bán"
        '
        'QuảnLýPhânQuyềnToolStripMenuItem
        '
        Me.QuảnLýPhânQuyềnToolStripMenuItem.Name = "QuảnLýPhânQuyềnToolStripMenuItem"
        Me.QuảnLýPhânQuyềnToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.QuảnLýPhânQuyềnToolStripMenuItem.Text = "Quản Lý"
        '
        'QuayLạiĐăngNhậpToolStripMenuItem
        '
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Name = "QuayLạiĐăngNhậpToolStripMenuItem"
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(183, 29)
        Me.QuayLạiĐăngNhậpToolStripMenuItem.Text = "Quay lại đăng nhập"
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
        'HDMuon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "HDMuon"
        Me.Text = "Hoá Đơn Mượn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHDMuon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DsHDMuon1 As dsHDMuon
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HDMuonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýPhânQuyềnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuayLạiĐăngNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoHDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayTraDuKienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TinhTrangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
