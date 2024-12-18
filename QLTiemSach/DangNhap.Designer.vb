<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangNhap
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
        Me.btDN = New System.Windows.Forms.Button()
        Me.btDK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMK = New System.Windows.Forms.TextBox()
        Me.tbTK = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lQMK = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btDN
        '
        Me.btDN.Location = New System.Drawing.Point(497, 375)
        Me.btDN.Name = "btDN"
        Me.btDN.Size = New System.Drawing.Size(106, 43)
        Me.btDN.TabIndex = 14
        Me.btDN.Text = "Đăng Nhập"
        Me.btDN.UseVisualStyleBackColor = True
        '
        'btDK
        '
        Me.btDK.Location = New System.Drawing.Point(123, 375)
        Me.btDK.Name = "btDK"
        Me.btDK.Size = New System.Drawing.Size(106, 43)
        Me.btDK.TabIndex = 13
        Me.btDK.Text = "Đăng ký"
        Me.btDK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mật khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tài khoản"
        '
        'tbMK
        '
        Me.tbMK.Location = New System.Drawing.Point(310, 268)
        Me.tbMK.Name = "tbMK"
        Me.tbMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMK.Size = New System.Drawing.Size(270, 26)
        Me.tbMK.TabIndex = 10
        '
        'tbTK
        '
        Me.tbTK.Location = New System.Drawing.Point(310, 182)
        Me.tbTK.Name = "tbTK"
        Me.tbTK.Size = New System.Drawing.Size(270, 26)
        Me.tbTK.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'lQMK
        '
        Me.lQMK.AutoSize = True
        Me.lQMK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lQMK.Location = New System.Drawing.Point(449, 315)
        Me.lQMK.Name = "lQMK"
        Me.lQMK.Size = New System.Drawing.Size(131, 20)
        Me.lQMK.TabIndex = 17
        Me.lQMK.TabStop = True
        Me.lQMK.Text = "Quên mật khẩu ?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ĐĂNG NHẬP HỆ THỐNG"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btDN)
        Me.Controls.Add(Me.btDK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMK)
        Me.Controls.Add(Me.tbTK)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lQMK)
        Me.Controls.Add(Me.Label3)
        Me.Name = "DangNhap"
        Me.Text = "Đăng Nhập"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btDN As Button
    Friend WithEvents btDK As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMK As TextBox
    Friend WithEvents tbTK As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lQMK As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
End Class
