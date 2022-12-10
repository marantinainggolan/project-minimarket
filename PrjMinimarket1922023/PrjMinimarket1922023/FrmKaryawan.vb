Public Class FrmKaryawan
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
        cedit.Text = "Edit"
        cedit.Width = 50
        cedit.UseColumnTextForButtonValue = True
        dg.Columns.Add(cedit)

        'tambahkan button hapus
        Dim chapus As New DataGridViewButtonColumn
        chapus.Name = "chapus"
        chapus.HeaderText = ""
        chapus.Text = "Hapus"
        chapus.Width = 50
        chapus.UseColumnTextForButtonValue = True
        dg.Columns.Add(chapus)
    End Sub

    Sub setdg()
        dg.Columns(0).HeaderText = "NIK"
        dg.Columns(1).HeaderText = "Nama"
        dg.Columns(2).HeaderText = "Jenis Kelamin"
        dg.Columns(3).HeaderText = "Tempat Lahir"
        dg.Columns(4).HeaderText = "Tanggal Lahir"
        dg.Columns(5).HeaderText = "No. HP"
        dg.Columns(6).HeaderText = "Alamat"
        dg.Columns(0).Width = 80
        dg.Columns(1).Width = 150
        dg.Columns(2).Width = 100
        dg.Columns(3).Width = 150
        dg.Columns(4).Width = 100
        dg.Columns(5).Width = 100
        dg.Columns(6).Width = 400
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        dg.Columns.Clear()
        Call tampil("SELECT * FROM karyawan WHERE karyawanid='" & txtcari.Text & "' OR karyawannama LIKE '%" & txtcari.Text & "%'")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub FrmKaryawan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dg.Columns.Clear()
        Call tampil("SELECT * FROM karyawan WHERE karyawanid='" & txtcari.Text & "' OR karyawannama LIKE '%" & txtcari.Text & "%'")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub cmdtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtambah.Click
        FrmTambahKaryawan.Dispose()
        FrmTambahKaryawan.ShowDialog()
        FrmTambahKaryawan.cmdsimpan.Text = "Simpan"
        FrmTambahKaryawan.txtid.Enabled = True
        FrmTambahKaryawan.txtid.Text = ""
        FrmTambahKaryawan.txtnama.Text = ""
        FrmTambahKaryawan.txtnohp.Text = ""
        FrmTambahKaryawan.txtalamat.Text = ""
        FrmTambahKaryawan.cmdsimpan.Text = "Simpan"
        FrmTambahKaryawan.txtid.Focus()
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick
        Dim i As Integer
        Dim id As String
        i = dg.CurrentRow.Index
        id = dg.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 7 Then
            FrmTambahKaryawan.txtid.Text = id
            FrmTambahKaryawan.txtid.Enabled = False
            FrmTambahKaryawan.txtnama.Focus()
            FrmTambahKaryawan.cmdsimpan.Text = "Update"
            FrmTambahKaryawan.ShowDialog()
        End If
        If e.ColumnIndex = 8 Then
            Dim x As Byte
            x = MsgBox("Hapus data karyawan dengan kode " & id & " ?", MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "DELETE FROM karyawan WHERE karyawanid='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()
                dg.Columns.Clear()
                Call tampil("SELECT * FROM karyawan")
                Call setdg()
                Call buattombol()
            End If
        End If
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub
End Class