<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPembelian
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdcari = New System.Windows.Forms.Button()
        Me.txtnamapemasok = New System.Windows.Forms.TextBox()
        Me.txtidpemasok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtnofak = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.lbldiskon = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdbaru = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lkbantuan = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmdcari)
        Me.GroupBox1.Controls.Add(Me.txtnamapemasok)
        Me.GroupBox1.Controls.Add(Me.txtidpemasok)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.txtnofak)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1062, 94)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(854, 27)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(33, 31)
        Me.lbltotal.TabIndex = 30
        Me.lbltotal.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(734, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 31)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Total"
        '
        'cmdcari
        '
        Me.cmdcari.BackColor = System.Drawing.Color.White
        Me.cmdcari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdcari.Location = New System.Drawing.Point(620, 16)
        Me.cmdcari.Name = "cmdcari"
        Me.cmdcari.Size = New System.Drawing.Size(54, 24)
        Me.cmdcari.TabIndex = 28
        Me.cmdcari.Text = "Cari"
        Me.cmdcari.UseVisualStyleBackColor = False
        '
        'txtnamapemasok
        '
        Me.txtnamapemasok.Location = New System.Drawing.Point(474, 53)
        Me.txtnamapemasok.Name = "txtnamapemasok"
        Me.txtnamapemasok.Size = New System.Drawing.Size(200, 21)
        Me.txtnamapemasok.TabIndex = 7
        '
        'txtidpemasok
        '
        Me.txtidpemasok.Location = New System.Drawing.Point(474, 18)
        Me.txtidpemasok.Name = "txtidpemasok"
        Me.txtidpemasok.Size = New System.Drawing.Size(140, 21)
        Me.txtidpemasok.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama Pemasok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Id Pemasok"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(128, 51)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 21)
        Me.dtp.TabIndex = 3
        '
        'txtnofak
        '
        Me.txtnofak.Location = New System.Drawing.Point(128, 18)
        Me.txtnofak.Name = "txtnofak"
        Me.txtnofak.Size = New System.Drawing.Size(200, 21)
        Me.txtnofak.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Faktur"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lkbantuan)
        Me.GroupBox2.Controls.Add(Me.cmdok)
        Me.GroupBox2.Controls.Add(Me.txtsubtotal)
        Me.GroupBox2.Controls.Add(Me.txtqty)
        Me.GroupBox2.Controls.Add(Me.txtharga)
        Me.GroupBox2.Controls.Add(Me.txtsatuan)
        Me.GroupBox2.Controls.Add(Me.txtnamabarang)
        Me.GroupBox2.Controls.Add(Me.txtkode)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1062, 87)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'cmdok
        '
        Me.cmdok.BackColor = System.Drawing.Color.White
        Me.cmdok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdok.Location = New System.Drawing.Point(938, 15)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(70, 46)
        Me.cmdok.TabIndex = 29
        Me.cmdok.Text = "OK"
        Me.cmdok.UseVisualStyleBackColor = False
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(800, 40)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(132, 21)
        Me.txtsubtotal.TabIndex = 11
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(676, 40)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(132, 21)
        Me.txtqty.TabIndex = 10
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(547, 40)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(139, 21)
        Me.txtharga.TabIndex = 9
        '
        'txtsatuan
        '
        Me.txtsatuan.Location = New System.Drawing.Point(412, 40)
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(140, 21)
        Me.txtsatuan.TabIndex = 8
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(142, 40)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(273, 21)
        Me.txtnamabarang.TabIndex = 7
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(33, 40)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(113, 21)
        Me.txtkode.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(797, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Sub Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(673, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Qty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(549, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(411, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kode"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtdiskon)
        Me.GroupBox3.Controls.Add(Me.lbldiskon)
        Me.GroupBox3.Controls.Add(Me.lblsubtotal)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cmdkeluar)
        Me.GroupBox3.Controls.Add(Me.cmdsimpan)
        Me.GroupBox3.Controls.Add(Me.cmdbaru)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 386)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1062, 120)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(849, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 15)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "%"
        '
        'txtdiskon
        '
        Me.txtdiskon.Location = New System.Drawing.Point(814, 59)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(29, 21)
        Me.txtdiskon.TabIndex = 7
        '
        'lbldiskon
        '
        Me.lbldiskon.AutoSize = True
        Me.lbldiskon.Location = New System.Drawing.Point(898, 62)
        Me.lbldiskon.Name = "lbldiskon"
        Me.lbldiskon.Size = New System.Drawing.Size(16, 15)
        Me.lbldiskon.TabIndex = 6
        Me.lbldiskon.Text = "0"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Location = New System.Drawing.Point(898, 31)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(16, 15)
        Me.lblsubtotal.TabIndex = 5
        Me.lblsubtotal.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(707, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Diskon"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(707, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Sub Total"
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(266, 31)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(111, 46)
        Me.cmdkeluar.TabIndex = 2
        Me.cmdkeluar.Text = "Keluar [Alt K]"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(142, 31)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(118, 46)
        Me.cmdsimpan.TabIndex = 1
        Me.cmdsimpan.Text = "Simpan [Alt S]"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdbaru
        '
        Me.cmdbaru.Location = New System.Drawing.Point(30, 31)
        Me.cmdbaru.Name = "cmdbaru"
        Me.cmdbaru.Size = New System.Drawing.Size(103, 46)
        Me.cmdbaru.TabIndex = 0
        Me.cmdbaru.Text = "Baru [Alt N]"
        Me.cmdbaru.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(0, 176)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(1062, 227)
        Me.dg.TabIndex = 9
        '
        'lkbantuan
        '
        Me.lkbantuan.AutoSize = True
        Me.lkbantuan.Location = New System.Drawing.Point(30, 64)
        Me.lkbantuan.Name = "lkbantuan"
        Me.lkbantuan.Size = New System.Drawing.Size(87, 15)
        Me.lkbantuan.TabIndex = 30
        Me.lkbantuan.TabStop = True
        Me.lkbantuan.Text = "Cari Barang"
        '
        'FrmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(1062, 506)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmPembelian"
        Me.Text = "Pembelian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnofak As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnamapemasok As System.Windows.Forms.TextBox
    Friend WithEvents txtidpemasok As System.Windows.Forms.TextBox
    Friend WithEvents cmdcari As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtsatuan As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdkeluar As System.Windows.Forms.Button
    Friend WithEvents cmdsimpan As System.Windows.Forms.Button
    Friend WithEvents cmdbaru As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdiskon As System.Windows.Forms.TextBox
    Friend WithEvents lbldiskon As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents lkbantuan As System.Windows.Forms.LinkLabel
End Class
