Public Class FrmTambahKategori
    Sub proses(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub cekkode()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from kategori where kategoriid='" & txtid.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnamakategori.Text = cek.Item("kategorinama")
        End If
        kon.Close()
    End Sub

    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        If cmdsimpan.Text = "Simpan" Then
            Call proses("INSERT INTO kategori(kategorinama) VALUES('" & txtnamakategori.Text & "')")
            MsgBox("Data Kategori Berhasil Ditambahkan", MsgBoxStyle.Information, "Tambah Kategori")
        Else
            Call proses("update kategori set kategorinama='" & txtnamakategori.Text & "' where kategoriid='" & txtid.Text & "'")
            cmdsimpan.Text = "Simpan"
            MsgBox("Data Kategori Berhasil Di Update", MsgBoxStyle.Information, "Update Kategori")
        End If
        txtid.Text = ""
        txtnamakategori.Text = ""
        FrmKategori.dg.Columns.Clear()
        FrmKategori.tampil("select * from kategori")
        FrmKategori.setdg()
        FrmKategori.buattombol()
        Me.cmdsimpan.Text = "Simpan"
        FrmCariKategori.Show()
        Me.Close()
    End Sub

    Private Sub txtnamakategori_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnamakategori.TextChanged

    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Me.Dispose()
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtid.Visible = False
    End Sub
End Class