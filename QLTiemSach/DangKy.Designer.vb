<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangKy
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
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btDN = New System.Windows.Forms.Button()
        Me.btDK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMK = New System.Windows.Forms.TextBox()
        Me.tbTK = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNhapLaiMK = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DANGNHAP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TK", "TK"), New System.Data.Common.DataColumnMapping("MK", "MK"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("email1", "email1")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [DANGNHAP] ([TK], [MK], [email], [email1]) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("TK", System.Data.OleDb.OleDbType.VarChar, 0, "TK"), New System.Data.OleDb.OleDbParameter("MK", System.Data.OleDb.OleDbType.VarChar, 0, "MK"), New System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarChar, 0, "email"), New System.Data.OleDb.OleDbParameter("email1", System.Data.OleDb.OleDbType.VarChar, 0, "email1")})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=MSI\SQLEXPRESS;Integrated Security=SSPI;Initial C" &
    "atalog=QLTiemSach"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   DANGNHAP"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(347, 321)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(270, 26)
        Me.tbEmail.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 32)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ĐĂNG KÝ"
        '
        'btDN
        '
        Me.btDN.Location = New System.Drawing.Point(130, 389)
        Me.btDN.Name = "btDN"
        Me.btDN.Size = New System.Drawing.Size(106, 43)
        Me.btDN.TabIndex = 25
        Me.btDN.Text = "Đăng Nhập"
        Me.btDN.UseVisualStyleBackColor = True
        '
        'btDK
        '
        Me.btDK.Location = New System.Drawing.Point(542, 389)
        Me.btDK.Name = "btDK"
        Me.btDK.Size = New System.Drawing.Size(106, 43)
        Me.btDK.TabIndex = 24
        Me.btDK.Text = "Đăng ký"
        Me.btDK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Mật khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tài khoản"
        '
        'tbMK
        '
        Me.tbMK.Location = New System.Drawing.Point(347, 217)
        Me.tbMK.Name = "tbMK"
        Me.tbMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMK.Size = New System.Drawing.Size(270, 26)
        Me.tbMK.TabIndex = 21
        '
        'tbTK
        '
        Me.tbTK.Location = New System.Drawing.Point(347, 165)
        Me.tbTK.Name = "tbTK"
        Me.tbTK.Size = New System.Drawing.Size(270, 26)
        Me.tbTK.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nhập lại mật khẩu"
        '
        'tbNhapLaiMK
        '
        Me.tbNhapLaiMK.Location = New System.Drawing.Point(347, 271)
        Me.tbNhapLaiMK.Name = "tbNhapLaiMK"
        Me.tbNhapLaiMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNhapLaiMK.Size = New System.Drawing.Size(270, 26)
        Me.tbNhapLaiMK.TabIndex = 33
        '
        'DangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbNhapLaiMK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btDN)
        Me.Controls.Add(Me.btDK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMK)
        Me.Controls.Add(Me.tbTK)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "DangKy"
        Me.Text = "Đăng Ký"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btDN As Button
    Friend WithEvents btDK As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMK As TextBox
    Friend WithEvents tbTK As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNhapLaiMK As TextBox
End Class
