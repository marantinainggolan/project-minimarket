<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTambahKaryawan
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txttmplhr = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.dtptgllhr = New System.Windows.Forms.DateTimePicker()
        Me.rblakilaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.lkcari = New System.Windows.Forms.LinkLabel()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No Hp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alamat"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(164, 29)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(173, 20)
        Me.txtid.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(164, 63)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(242, 20)
        Me.txtnama.TabIndex = 8
        '
        'txttmplhr
        '
        Me.txttmplhr.Location = New System.Drawing.Point(164, 132)
        Me.txttmplhr.Name = "txttmplhr"
        Me.txttmplhr.Size = New System.Drawing.Size(242, 20)
        Me.txttmplhr.TabIndex = 9
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(164, 204)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(242, 20)
        Me.txtnohp.TabIndex = 10
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(164, 233)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(318, 57)
        Me.txtalamat.TabIndex = 11
        '
        'dtptgllhr
        '
        Me.dtptgllhr.Location = New System.Drawing.Point(164, 166)
        Me.dtptgllhr.Name = "dtptgllhr"
        Me.dtptgllhr.Size = New System.Drawing.Size(242, 20)
        Me.dtptgllhr.TabIndex = 12
        '
        'rblakilaki
        '
        Me.rblakilaki.AutoSize = True
        Me.rblakilaki.ForeColor = System.Drawing.Color.DarkBlue
        Me.rblakilaki.Location = New System.Drawing.Point(164, 100)
        Me.rblakilaki.Name = "rblakilaki"
        Me.rblakilaki.Size = New System.Drawing.Size(84, 18)
        Me.rblakilaki.TabIndex = 13
        Me.rblakilaki.TabStop = True
        Me.rblakilaki.Text = "Laki-laki"
        Me.rblakilaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbperempuan.Location = New System.Drawing.Point(267, 100)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(101, 18)
        Me.rbperempuan.TabIndex = 14
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'lkcari
        '
        Me.lkcari.AutoSize = True
        Me.lkcari.Location = New System.Drawing.Point(413, 207)
        Me.lkcari.Name = "lkcari"
        Me.lkcari.Size = New System.Drawing.Size(66, 14)
        Me.lkcari.TabIndex = 15
        Me.lkcari.TabStop = True
        Me.lkcari.Text = "Cari Foto"
        '
        'cmdsimpan
        '
        Me.cmdsimpan.BackColor = System.Drawing.Color.White
        Me.cmdsimpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdsimpan.Location = New System.Drawing.Point(164, 306)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(109, 29)
        Me.cmdsimpan.TabIndex = 16
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = False
        '
        'cmdbatal
        '
        Me.cmdbatal.BackColor = System.Drawing.Color.White
        Me.cmdbatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdbatal.Location = New System.Drawing.Point(279, 306)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(109, 29)
        Me.cmdbatal.TabIndex = 17
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = False
        '
        'FrmTambahKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(509, 347)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.lkcari)
        Me.Controls.Add(Me.rbperempuan)
        Me.Controls.Add(Me.rblakilaki)
        Me.Controls.Add(Me.dtptgllhr)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txttmplhr)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmTambahKaryawan"
        Me.Text = " Tambah Karyawan"
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
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txttmplhr As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents dtptgllhr As System.Windows.Forms.DateTimePicker
    Friend WithEvents rblakilaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents lkcari As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdsimpan As System.Windows.Forms.Button
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
End Class
