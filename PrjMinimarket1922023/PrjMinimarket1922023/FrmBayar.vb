Public Class FrmBayar
    Dim total, kembali As Double
    Sub cetakfaktur()
        'Dim crfaktur As New LapFaktur
        'kon.Open()
        'perintah.Connection = kon
        'perintah.CommandType = CommandType.Text
        'perintah.CommandText = "SELECT jualnofak,jualtgl,barangnama,djualqty, " & _
        '" djualharga,jualtotalkotor,jualdisc,jualtotalbersih,karyawannama as adminnama,jualtotalbersih FROM detailjual JOIN jual ON djualjualnofak=jualnofak JOIN barang ON djualbarangid=barangid " & _
        '" join admin on jualadminid=adminid join karyawan on adminkaryawanid=karyawanid " & _
        '" where djualjualnofak='" & FrmPenjualan.txtnofak.Text & "'"
        'mda.SelectCommand = perintah
        'ds.Tables.Clear()
        'mda.Fill(ds, "data")
        'crfaktur.SetDataSource(ds.Tables("data"))
        'FrmCetak.crv.ReportSource = crfaktur
        'kon.Close()
        'FrmCetak.MdiParent = FrmMenu
        'FrmCetak.Show()
        'FrmCetak.WindowState = FormWindowState.Maximized
    End Sub
    Sub proses(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

    Private Sub FrmBayar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtjumlah.Focus()
    End Sub

    Private Sub FrmBayar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdtutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtutup.Click
        Call proses("update jual set jualtotalbersih='" & txtjumlah.Text & "' where jualnofak='" & txttotal.Text & "'")
        Call cetakfaktur()
        'FrmPenjualan.bersih()
        FrmPenjualan.proses("delete from temp")
        FrmPenjualan.tampil("select id, barangnama, barangsatuan,harga,qty, harga * qty as subtotal from temp join barang on id=barangid")
        FrmPenjualan.setdg()
        FrmPenjualan.hitungtotal()
        FrmPenjualan.buatnofak()
        FrmPenjualan.txtkode.Focus()
        Me.Dispose()
    End Sub

    Private Sub txtkembali_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkembali.TextChanged

    End Sub

    Private Sub txtjumlah_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtjumlah.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmdtutup_Click(e, AcceptButton)
        End Select
    End Sub

    Private Sub txtjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjumlah.TextChanged
        txtkembali.Text = Val(txtjumlah.Text) - Val(txttotal.Text)
    End Sub

End Class