<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTambahAdmin
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtidkaryawan = New System.Windows.Forms.TextBox()
        Me.txtnamkaryawan = New System.Windows.Forms.TextBox()
        Me.rbadmin = New System.Windows.Forms.RadioButton()
        Me.rbkasir = New System.Windows.Forms.RadioButton()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmdcari = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Level"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(159, 24)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(245, 20)
        Me.txtid.TabIndex = 5
        '
        'txtidkaryawan
        '
        Me.txtidkaryawan.Location = New System.Drawing.Point(159, 55)
        Me.txtidkaryawan.Name = "txtidkaryawan"
        Me.txtidkaryawan.Size = New System.Drawing.Size(181, 20)
        Me.txtidkaryawan.TabIndex = 6
        '
        'txtnamkaryawan
        '
        Me.txtnamkaryawan.Location = New System.Drawing.Point(159, 84)
        Me.txtnamkaryawan.Name = "txtnamkaryawan"
        Me.txtnamkaryawan.Size = New System.Drawing.Size(245, 20)
        Me.txtnamkaryawan.TabIndex = 7
        '
        'rbadmin
        '
        Me.rbadmin.AutoSize = True
        Me.rbadmin.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbadmin.Location = New System.Drawing.Point(159, 115)
        Me.rbadmin.Name = "rbadmin"
        Me.rbadmin.Size = New System.Drawing.Size(70, 18)
        Me.rbadmin.TabIndex = 14
        Me.rbadmin.TabStop = True
        Me.rbadmin.Text = "Admin"
        Me.rbadmin.UseVisualStyleBackColor = True
        '
        'rbkasir
        '
        Me.rbkasir.AutoSize = True
        Me.rbkasir.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbkasir.Location = New System.Drawing.Point(256, 115)
        Me.rbkasir.Name = "rbkasir"
        Me.rbkasir.Size = New System.Drawing.Size(60, 18)
        Me.rbkasir.TabIndex = 15
        Me.rbkasir.TabStop = True
        Me.rbkasir.Text = "Kasir"
        Me.rbkasir.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.BackColor = System.Drawing.Color.White
        Me.cmdsimpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdsimpan.Location = New System.Drawing.Point(159, 139)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(88, 29)
        Me.cmdsimpan.TabIndex = 17
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = False
        '
        'cmdbatal
        '
        Me.cmdbatal.BackColor = System.Drawing.Color.White
        Me.cmdbatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdbatal.Location = New System.Drawing.Point(256, 139)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(88, 29)
        Me.cmdbatal.TabIndex = 18
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = False
        '
        'cmdcari
        '
        Me.cmdcari.BackColor = System.Drawing.Color.White
        Me.cmdcari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdcari.Location = New System.Drawing.Point(349, 50)
        Me.cmdcari.Name = "cmdcari"
        Me.cmdcari.Size = New System.Drawing.Size(55, 29)
        Me.cmdcari.TabIndex = 19
        Me.cmdcari.Text = "Cari"
        Me.cmdcari.UseVisualStyleBackColor = False
        '
        'FrmTambahAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(423, 180)
        Me.Controls.Add(Me.cmdcari)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.rbkasir)
        Me.Controls.Add(Me.rbadmin)
        Me.Controls.Add(Me.txtnamkaryawan)
        Me.Controls.Add(Me.txtidkaryawan)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmTambahAdmin"
        Me.Text = "Tambah Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtidkaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtnamkaryawan As System.Windows.Forms.TextBox
    Friend WithEvents rbadmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbkasir As System.Windows.Forms.RadioButton
    Friend WithEvents cmdsimpan As System.Windows.Forms.Button
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents cmdcari As System.Windows.Forms.Button
End Class
