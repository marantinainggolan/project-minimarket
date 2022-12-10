<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTambahBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.txtidkategori = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.cmdcari = New System.Windows.Forms.Button()
        Me.txtnamakategori = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kategori"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Jual"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Stok"
        '
        'cmdsimpan
        '
        Me.cmdsimpan.BackColor = System.Drawing.Color.White
        Me.cmdsimpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdsimpan.Location = New System.Drawing.Point(185, 288)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(123, 29)
        Me.cmdsimpan.TabIndex = 18
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = False
        '
        'cmdbatal
        '
        Me.cmdbatal.BackColor = System.Drawing.Color.White
        Me.cmdbatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdbatal.Location = New System.Drawing.Point(332, 288)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(123, 29)
        Me.cmdbatal.TabIndex = 19
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(185, 36)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(270, 21)
        Me.txtid.TabIndex = 20
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(185, 70)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(270, 21)
        Me.txtbarcode.TabIndex = 21
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(185, 105)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(460, 21)
        Me.txtnama.TabIndex = 22
        '
        'txtsatuan
        '
        Me.txtsatuan.Location = New System.Drawing.Point(185, 141)
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(270, 21)
        Me.txtsatuan.TabIndex = 23
        '
        'txtidkategori
        '
        Me.txtidkategori.Location = New System.Drawing.Point(185, 175)
        Me.txtidkategori.Name = "txtidkategori"
        Me.txtidkategori.Size = New System.Drawing.Size(184, 21)
        Me.txtidkategori.TabIndex = 24
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(185, 210)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(184, 21)
        Me.txtharga.TabIndex = 25
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(185, 245)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(184, 21)
        Me.txtstok.TabIndex = 26
        '
        'cmdcari
        '
        Me.cmdcari.BackColor = System.Drawing.Color.White
        Me.cmdcari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdcari.Location = New System.Drawing.Point(375, 172)
        Me.cmdcari.Name = "cmdcari"
        Me.cmdcari.Size = New System.Drawing.Size(80, 24)
        Me.cmdcari.TabIndex = 27
        Me.cmdcari.Text = "Cari"
        Me.cmdcari.UseVisualStyleBackColor = False
        '
        'txtnamakategori
        '
        Me.txtnamakategori.Location = New System.Drawing.Point(461, 175)
        Me.txtnamakategori.Name = "txtnamakategori"
        Me.txtnamakategori.Size = New System.Drawing.Size(184, 21)
        Me.txtnamakategori.TabIndex = 28
        '
        'FrmTambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(668, 338)
        Me.Controls.Add(Me.txtnamakategori)
        Me.Controls.Add(Me.cmdcari)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtidkategori)
        Me.Controls.Add(Me.txtsatuan)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtbarcode)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmTambahBarang"
        Me.Text = "Tambah Data Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdsimpan As System.Windows.Forms.Button
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtsatuan As System.Windows.Forms.TextBox
    Friend WithEvents txtidkategori As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtstok As System.Windows.Forms.TextBox
    Friend WithEvents cmdcari As System.Windows.Forms.Button
    Friend WithEvents txtnamakategori As System.Windows.Forms.TextBox
End Class
