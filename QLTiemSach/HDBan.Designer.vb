<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HDBan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HDBan))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SoHDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsHDBan1 = New QLTiemSach.dsHDBan()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HDMuonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýPhânQuyềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuayLạiĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHDBan1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SoHDDataGridViewTextBoxColumn, Me.MaNVDataGridViewTextBoxColumn, Me.MaKHDataGridViewTextBoxColumn, Me.MaSachDataGridViewTextBoxColumn, Me.NgayMuaDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "HDBan"
        Me.DataGridView1.DataSource = Me.DsHDBan1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(776, 265)
        Me.DataGridView1.TabIndex = 0
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
        'DsHDBan1
        '
        Me.DsHDBan1.DataSetName = "dsHDBan"
        Me.DsHDBan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SáchToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.HDMuonToolStripMenuItem, Me.QuảnLýPhânQuyềnToolStripMenuItem, Me.QuayLạiĐăngNhậpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 1
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
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(114, 29)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên "
        '
        'HDMuonToolStripMenuItem
        '
        Me.HDMuonToolStripMenuItem.Name = "HDMuonToolStripMenuItem"
        Me.HDMuonToolStripMenuItem.Size = New System.Drawing.Size(153, 29)
        Me.HDMuonToolStripMenuItem.Text = "Hoá Đơn Mượn"
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
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT dbo.HDBan.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   dbo.HDBan"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSOLEDBSQL.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial" &
    " Catalog=QLTiemSach"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ""QLTiemSach"".""dbo"".""HDBan"" (""SoHD"", ""MaNV"", ""MaKH"", ""MaSach"", ""NgayMu" &
    "a"", ""SoLuong"") VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SoHD", System.Data.OleDb.OleDbType.[Integer], 0, "SoHD"), New System.Data.OleDb.OleDbParameter("MaNV", System.Data.OleDb.OleDbType.[Integer], 0, "MaNV"), New System.Data.OleDb.OleDbParameter("MaKH", System.Data.OleDb.OleDbType.[Integer], 0, "MaKH"), New System.Data.OleDb.OleDbParameter("MaSach", System.Data.OleDb.OleDbType.[Integer], 0, "MaSach"), New System.Data.OleDb.OleDbParameter("NgayMua", System.Data.OleDb.OleDbType.DBDate, 0, "NgayMua"), New System.Data.OleDb.OleDbParameter("SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, "SoLuong")})
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
        'HDBan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 548)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HDBan"
        Me.Text = "Hoá Đơn Bán"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHDBan1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HDMuonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DsHDBan1 As dsHDBan
    Friend WithEvents QuảnLýPhânQuyềnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuayLạiĐăngNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoHDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaNVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
