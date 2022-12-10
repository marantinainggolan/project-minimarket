Public Class FrmBarang
    Private Property i As Integer
    Private Property id As Object

    Sub tampil(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        dg.DataSource = (ds.Tables("data"))
        setdg()
        kon.Close()
    End Sub
    Sub buattombol()
        'tambahkan button edit 
        Dim cedit As New DataGridViewButtonColumn
        cedit.Name = "cedit"
        cedit.HeaderText = ""
        cedit.FlatStyle = FlatStyle.Popup
        cedit.DefaultCellStyle.ForeColor = Color.DarkGreen
        cedit.Text = "Edit"
        cedit.Width = 50
        cedit.UseColumnTextForButtonValue = True
        dg.Columns.Add(cedit)



        'tambahkan button edit 
        Dim chapus As New DataGridViewButtonColumn
        chapus.Name = "chapus"
        chapus.HeaderText = ""
        chapus.FlatStyle = FlatStyle.Popup
        chapus.DefaultCellStyle.ForeColor = Color.Red
        chapus.Text = "Hapus"
        chapus.Width = 50
        chapus.UseColumnTextForButtonValue = True
        dg.Columns.Add(chapus)
    End Sub
    Sub setdg()
        dg.Columns(0).HeaderText = "Kode Barang"
        dg.Columns(1).HeaderText = "Nama Barang"
        dg.Columns(2).HeaderText = "Satuan"
        dg.Columns(3).HeaderText = "Kategori"
        dg.Columns(4).HeaderText = "Harga Jual"
        dg.Columns(5).HeaderText = "Stock"

        dg.Columns(0).Width = 80
        dg.Columns(1).Width = 120
        dg.Columns(2).Width = 100
        dg.Columns(3).Width = 110
        dg.Columns(4).Width = 100
        dg.Columns(5).Width = 100
        'dg.Columns(6).Width = 200
        'Call buattombol()
    End Sub

    Private Sub cmdtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtambah.Click
        FrmTambahBarang.Dispose()
        FrmTambahBarang.ShowDialog()
        FrmTambahBarang.cmdsimpan.Text = "Simpan"
        FrmTambahBarang.txtid.Enabled = True

        FrmTambahBarang.txtid.Text = ""
        FrmTambahBarang.txtnama.Text = ""
        FrmTambahBarang.txtbarcode.Text = ""
        FrmTambahBarang.txtsatuan.Text = ""
        FrmTambahBarang.txtidkategori.Text = ""
        FrmTambahBarang.txtnamakategori.Text = ""
        FrmTambahBarang.txtharga.Text = ""
        FrmTambahBarang.txtstok.Text = ""
        FrmTambahBarang.cmdsimpan.Text = "Simpan"
        FrmTambahBarang.txtid.Focus()
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        dg.Columns.Clear()
        Call tampil("SELECT barangid,barangnama,barangsatuan,kategorinama,baranghargajual,barangstok from barang join kategori " & _
        " on barangkategoriid=kategoriid where barangid like '%" & txtcari.Text &
        "%' or barangnama like '%" & txtcari.Text & "%'")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub FrmBarang_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dg.Columns.Clear()
        Call tampil("SELECT barangid,barangnama,barangsatuan,kategorinama,baranghargajual,barangstok from barang join kategori " & _
        " on barangkategoriid=kategoriid")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        i = dg.CurrentRow.Index
        id = dg.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 6 Then
            FrmTambahBarang.txtid.Text = id
            FrmTambahBarang.txtid.Enabled = False
            FrmTambahBarang.txtnama.Focus()
            FrmTambahBarang.cmdsimpan.Text = "Update"
            FrmTambahBarang.ShowDialog()
        End If
        If e.ColumnIndex = 7 Then
            Dim x As Byte
            x = MsgBox("Hapus data Barang dengan kode " & id & " ?",
MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "delete from barang where barangid='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()
                dg.Columns.Clear()
                Call tampil("SELECT barangid,barangnama,barangsatuan,kategorinama,baranghargajual,barangstok from barang join kategori " & _
        " on barangkategoriid=kategoriid")
                Call setdg()
                Call buattombol()
            End If
        End If
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub
End Class