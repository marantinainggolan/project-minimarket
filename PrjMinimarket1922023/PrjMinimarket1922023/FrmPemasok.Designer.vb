<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPemasok
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
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Controls.Add(Me.cmdkeluar)
        Me.GroupBox1.Controls.Add(Me.cmdtambah)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmdkeluar
        '
        Me.cmdkeluar.BackColor = System.Drawing.Color.White
        Me.cmdkeluar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdkeluar.Location = New System.Drawing.Point(475, 25)
        Me.cmdkeluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(70, 24)
        Me.cmdkeluar.TabIndex = 5
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = False
        '
        'cmdtambah
        '
        Me.cmdtambah.BackColor = System.Drawing.Color.White
        Me.cmdtambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdtambah.Location = New System.Drawing.Point(388, 25)
        Me.cmdtambah.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(70, 24)
        Me.cmdtambah.TabIndex = 4
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = False
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(146, 27)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(222, 21)
        Me.txtnama.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari ID/Nama"
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(0, 73)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(819, 234)
        Me.dg.TabIndex = 2
        '
        'FrmPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(819, 307)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmPemasok"
        Me.Text = "Pemasok"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cmdtambah As System.Windows.Forms.Button
    Friend WithEvents cmdkeluar As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
End Class
