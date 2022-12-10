<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGantiPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGantiPassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtps = New System.Windows.Forms.TextBox()
        Me.txtpb = New System.Windows.Forms.TextBox()
        Me.txtupb = New System.Windows.Forms.TextBox()
        Me.cmdubah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Sekarang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password Baru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ulangi Password Baru"
        '
        'txtps
        '
        Me.txtps.Location = New System.Drawing.Point(216, 23)
        Me.txtps.Name = "txtps"
        Me.txtps.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtps.Size = New System.Drawing.Size(231, 20)
        Me.txtps.TabIndex = 3
        '
        'txtpb
        '
        Me.txtpb.Location = New System.Drawing.Point(216, 52)
        Me.txtpb.Name = "txtpb"
        Me.txtpb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpb.Size = New System.Drawing.Size(231, 20)
        Me.txtpb.TabIndex = 4
        '
        'txtupb
        '
        Me.txtupb.Location = New System.Drawing.Point(216, 83)
        Me.txtupb.Name = "txtupb"
        Me.txtupb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtupb.Size = New System.Drawing.Size(231, 20)
        Me.txtupb.TabIndex = 5
        '
        'cmdubah
        '
        Me.cmdubah.BackgroundImage = CType(resources.GetObject("cmdubah.BackgroundImage"), System.Drawing.Image)
        Me.cmdubah.ForeColor = System.Drawing.Color.Green
        Me.cmdubah.Location = New System.Drawing.Point(216, 117)
        Me.cmdubah.Name = "cmdubah"
        Me.cmdubah.Size = New System.Drawing.Size(183, 30)
        Me.cmdubah.TabIndex = 6
        Me.cmdubah.Text = "Ubah Password"
        Me.cmdubah.UseVisualStyleBackColor = True
        '
        'FrmGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(473, 159)
        Me.Controls.Add(Me.cmdubah)
        Me.Controls.Add(Me.txtupb)
        Me.Controls.Add(Me.txtpb)
        Me.Controls.Add(Me.txtps)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmGantiPassword"
        Me.Text = "Ganti Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtps As System.Windows.Forms.TextBox
    Friend WithEvents txtpb As System.Windows.Forms.TextBox
    Friend WithEvents txtupb As System.Windows.Forms.TextBox
    Friend WithEvents cmdubah As System.Windows.Forms.Button
End Class
