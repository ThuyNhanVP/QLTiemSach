<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KtraPhanQuyen
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuayLạiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTK = New System.Windows.Forms.TextBox()
        Me.tbMK = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuayLạiToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuayLạiToolStripMenuItem
        '
        Me.QuayLạiToolStripMenuItem.Name = "QuayLạiToolStripMenuItem"
        Me.QuayLạiToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.QuayLạiToolStripMenuItem.Text = "Quay lại"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ĐĂNG NHẬP QUẢN LÝ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tài Khoản"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mật Khẩu"
        '
        'tbTK
        '
        Me.tbTK.Location = New System.Drawing.Point(198, 181)
        Me.tbTK.Name = "tbTK"
        Me.tbTK.Size = New System.Drawing.Size(208, 26)
        Me.tbTK.TabIndex = 4
        '
        'tbMK
        '
        Me.tbMK.Location = New System.Drawing.Point(198, 238)
        Me.tbMK.Name = "tbMK"
        Me.tbMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMK.Size = New System.Drawing.Size(208, 26)
        Me.tbMK.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 48)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Đăng Nhập"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KtraPhanQuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 370)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tbMK)
        Me.Controls.Add(Me.tbTK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "KtraPhanQuyen"
        Me.Text = "Kiểm Tra Phân Quyền"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuayLạiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTK As TextBox
    Friend WithEvents tbMK As TextBox
    Friend WithEvents Button2 As Button
End Class
