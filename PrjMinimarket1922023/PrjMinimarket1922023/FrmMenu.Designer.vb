<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lkgantipassword = New System.Windows.Forms.LinkLabel()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdpenjualan = New System.Windows.Forms.Button()
        Me.cmdpembelian = New System.Windows.Forms.Button()
        Me.ststatus = New System.Windows.Forms.StatusStrip()
        Me.admin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.msmenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.ststatus.SuspendLayout()
        Me.msmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Controls.Add(Me.lkgantipassword)
        Me.GroupBox1.Controls.Add(Me.cmdkeluar)
        Me.GroupBox1.Controls.Add(Me.cmdpenjualan)
        Me.GroupBox1.Controls.Add(Me.cmdpembelian)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 484)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lkgantipassword
        '
        Me.lkgantipassword.AutoSize = True
        Me.lkgantipassword.Location = New System.Drawing.Point(17, 216)
        Me.lkgantipassword.Name = "lkgantipassword"
        Me.lkgantipassword.Size = New System.Drawing.Size(107, 14)
        Me.lkgantipassword.TabIndex = 6
        Me.lkgantipassword.TabStop = True
        Me.lkgantipassword.Text = "Ganti Password"
        '
        'cmdkeluar
        '
        Me.cmdkeluar.BackColor = System.Drawing.Color.White
        Me.cmdkeluar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdkeluar.Location = New System.Drawing.Point(12, 100)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(112, 29)
        Me.cmdkeluar.TabIndex = 4
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = False
        '
        'cmdpenjualan
        '
        Me.cmdpenjualan.BackColor = System.Drawing.Color.White
        Me.cmdpenjualan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdpenjualan.Location = New System.Drawing.Point(12, 65)
        Me.cmdpenjualan.Name = "cmdpenjualan"
        Me.cmdpenjualan.Size = New System.Drawing.Size(112, 29)
        Me.cmdpenjualan.TabIndex = 3
        Me.cmdpenjualan.Text = "Penjualan"
        Me.cmdpenjualan.UseVisualStyleBackColor = False
        '
        'cmdpembelian
        '
        Me.cmdpembelian.BackColor = System.Drawing.Color.White
        Me.cmdpembelian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdpembelian.Location = New System.Drawing.Point(12, 30)
        Me.cmdpembelian.Name = "cmdpembelian"
        Me.cmdpembelian.Size = New System.Drawing.Size(112, 29)
        Me.cmdpembelian.TabIndex = 2
        Me.cmdpembelian.Text = "Pembelian"
        Me.cmdpembelian.UseVisualStyleBackColor = False
        '
        'ststatus
        '
        Me.ststatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.admin, Me.ToolStripStatusLabel1})
        Me.ststatus.Location = New System.Drawing.Point(140, 462)
        Me.ststatus.Name = "ststatus"
        Me.ststatus.Size = New System.Drawing.Size(587, 22)
        Me.ststatus.TabIndex = 3
        Me.ststatus.Text = "StatusStrip1"
        '
        'admin
        '
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(119, 17)
        Me.admin.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'msmenu
        '
        Me.msmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.msmenu.Location = New System.Drawing.Point(140, 0)
        Me.msmenu.Name = "msmenu"
        Me.msmenu.Size = New System.Drawing.Size(587, 24)
        Me.msmenu.TabIndex = 5
        Me.msmenu.Text = "MenuStrip1"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KaryawanToolStripMenuItem, Me.AdminToolStripMenuItem, Me.KategoriToolStripMenuItem, Me.BarangToolStripMenuItem, Me.PemasokToolStripMenuItem})
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem.Text = "Master"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.KategoriToolStripMenuItem.Text = "Kategori"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PemasokToolStripMenuItem
        '
        Me.PemasokToolStripMenuItem.Name = "PemasokToolStripMenuItem"
        Me.PemasokToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PemasokToolStripMenuItem.Text = "Pemasok"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(727, 484)
        Me.Controls.Add(Me.ststatus)
        Me.Controls.Add(Me.msmenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ststatus.ResumeLayout(False)
        Me.ststatus.PerformLayout()
        Me.msmenu.ResumeLayout(False)
        Me.msmenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdpembelian As System.Windows.Forms.Button
    Friend WithEvents lkgantipassword As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdkeluar As System.Windows.Forms.Button
    Friend WithEvents cmdpenjualan As System.Windows.Forms.Button
    Friend WithEvents ststatus As System.Windows.Forms.StatusStrip
    Friend WithEvents admin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents msmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PemasokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
