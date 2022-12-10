Public Class FrmTambahBarang
    Sub cekkode()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT barangid,barangbarcode,barangnama,barangsatuan,barangkategoriid,kategorinama,baranghargajual,barangstok from barang join kategori " & _
        " on barangkategoriid=kategoriid where barangid='" & txtid.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnama.Text = cek.Item("barangnama")
            txtsatuan.Text = cek.Item("barangsatuan")
            txtharga.Text = cek.Item("baranghargajual")
            txtbarcode.Text = cek.Item("barangbarcode")
            txtidkategori.Text = cek.Item("barangkategoriid")
            txtstok.Text = cek.Item("barangstok")
            txtnamakategori.Text = cek.Item("kategorinama")
        End If
        kon.Close()
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        Call cekkode()
    End Sub

    Private Sub cmdcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcari.Click
        FrmCarikategori.Show()
    End Sub
    Sub proses(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txtbarcode.Text = ""
        txtnamakategori.Text = ""
        txtsatuan.Text = ""
        txtstok.Text = ""
        txtharga.Text = ""
        txtidkategori.Text = ""
    End Sub


    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        If cmdsimpan.Text = "Simpan" Then
            Call proses("INSERT INTO barang(barangid,barangbarcode,barangnama,barangsatuan,barangkategoriid,baranghargajual,barangstok,barangtglinput,baranglastupdate,barangadminid)" & " VALUES('" & txtid.Text & "','" & txtbarcode.Text & "','" & txtnama.Text & "','" & txtsatuan.Text & "','" & txtidkategori.Text & "','" & txtharga.Text & "','" & txtstok.Text & "', Now(), Now(),'" & adminlogin & "')")
        Else
            Call proses("update barang set barangnama='" & txtnama.Text & "',barangsatuan='" & txtsatuan.Text & "'," & " barangbarcode='" & txtbarcode.Text & "',baranghargajual='" & txtharga.Text & "',barangstok='" & txtstok.Text & "'," & " baranglastupdate= now() where barangid='" & txtid.Text & "'")
            cmdsimpan.Text = "Simpan"
        End If
        txtid.Text = ""
        txtnama.Text = ""
        FrmBarang.dg.Columns.Clear()
        FrmBarang.tampil("SELECT barangid,barangnama,barangsatuan,kategorinama,baranghargajual,barangstok from barang join kategori " & " on barangkategoriid=kategoriid")
        FrmBarang.setdg()
        FrmBarang.buattombol()
        Me.cmdsimpan.Text = "Simpan"
        Me.Close()

    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Me.Dispose()
    End Sub
End Class