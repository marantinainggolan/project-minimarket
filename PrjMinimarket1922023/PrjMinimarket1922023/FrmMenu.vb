Public Class FrmMenu

    Private Sub lkgantipassword_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkgantipassword.LinkClicked
        FrmGantiPassword.Show()
    End Sub

    Private Sub cmdkeluar_Click(sender As System.Object, e As System.EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KaryawanToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click
        FrmKaryawan.Dispose()
        FrmKaryawan.MdiParent = Me
        FrmKaryawan.Show()
        FrmKaryawan.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AdminToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        FrmAdmin.Dispose()
        FrmAdmin.MdiParent = Me
        FrmAdmin.Show()
        FrmAdmin.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub KategoriToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategoriToolStripMenuItem.Click
        FrmKategori.Dispose()
        FrmKategori.MdiParent = Me
        FrmKategori.Show()
        FrmKategori.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarangToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FrmBarang.Dispose()
        FrmBarang.MdiParent = Me
        FrmBarang.Show()
        FrmBarang.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PemasokToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemasokToolStripMenuItem.Click
        FrmPemasok.Dispose()
        FrmPemasok.MdiParent = Me
        FrmPemasok.Show()
        FrmPemasok.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PembelianToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        FrmPembelian.Dispose()
        FrmPembelian.MdiParent = Me
        FrmPembelian.Show()
        FrmPembelian.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FrmPenjualan.Dispose()
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
        FrmPenjualan.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdpembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpembelian.Click
        FrmPembelian.Dispose()
        FrmPembelian.MdiParent = Me
        FrmPembelian.Show()
        FrmPembelian.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdpenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpenjualan.Click
        FrmPenjualan.Dispose()
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
        FrmPenjualan.WindowState = FormWindowState.Maximized
    End Sub

End Class