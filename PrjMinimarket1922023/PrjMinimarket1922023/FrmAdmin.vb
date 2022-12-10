Public Class FrmAdmin
    Dim mnRandomNumber As Integer

    Function GetRandomNumber(ByVal vnMinimumNumber As Integer, ByVal vnMaximumNumber As Integer)
        Randomize()
        GetRandomNumber = CInt(Int((vnMaximumNumber - vnMinimumNumber + 1) * Rnd() + vnMinimumNumber))
    End Function

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

        'tambahkan button hapus
        Dim chapus As New DataGridViewButtonColumn
        chapus.Name = "chapus"
        chapus.HeaderText = ""
        chapus.FlatStyle = FlatStyle.Popup
        chapus.DefaultCellStyle.ForeColor = Color.Red
        chapus.Text = "Hapus"
        chapus.Width = 50
        chapus.UseColumnTextForButtonValue = True
        dg.Columns.Add(chapus)

        'tambahkan button reset password
        Dim creset As New DataGridViewButtonColumn
        creset.Name = "creset"
        creset.HeaderText = ""
        creset.FlatStyle = FlatStyle.Popup
        creset.DefaultCellStyle.ForeColor = Color.Blue
        creset.Text = "Reset Password"
        creset.Width = 150
        creset.UseColumnTextForButtonValue = True
        dg.Columns.Add(creset)

        Dim cblok As New DataGridViewButtonColumn
        cblok.Name = "cblok"
        cblok.HeaderText = ""
        cblok.FlatStyle = FlatStyle.Popup
        cblok.DefaultCellStyle.ForeColor = Color.Blue
        cblok.Text = "Blokir User"
        cblok.Width = 100
        cblok.UseColumnTextForButtonValue = True
        dg.Columns.Add(cblok)

        Dim caktif As New DataGridViewButtonColumn
        caktif.Name = "caktif"
        caktif.HeaderText = ""
        caktif.FlatStyle = FlatStyle.Popup
        caktif.DefaultCellStyle.ForeColor = Color.Blue
        caktif.Text = "Aktifkan User"
        caktif.Width = 100
        caktif.UseColumnTextForButtonValue = True
        dg.Columns.Add(caktif)
    End Sub

    Sub setdg()
        dg.Columns(0).HeaderText = "Id Admin"
        dg.Columns(1).HeaderText = "Nama Admin"
        dg.Columns(2).HeaderText = "Level"
        dg.Columns(0).Width = 100
        dg.Columns(1).Width = 400
        dg.Columns(2).Width = 100
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        dg.Columns.Clear()
        Call tampil("SELECT adminid, karyawannama, IF(adminlevel=1,'Admin','Kasir') AS level FROM admin JOIN karyawan ON adminkaryawanid=karyawanid WHERE adminid='" & txtcari.Text & "' OR karyawannama LIKE '" & txtcari.Text & "'")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub FrmAdmin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dg.Columns.Clear()
        Call tampil("SELECT adminid, karyawannama, IF(adminlevel=1,'Admin','Kasir') AS level FROM admin JOIN karyawan ON adminkaryawanid=karyawanid")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub cmdtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtambah.Click
        FrmTambahAdmin.Dispose()
        FrmTambahAdmin.cmdsimpan.Text = "Simpan"
        FrmTambahAdmin.txtid.Enabled = True
        FrmTambahAdmin.txtid.Text = ""
        FrmTambahAdmin.txtnamkaryawan.Text = ""
        FrmTambahAdmin.txtidkaryawan.Text = ""
        FrmTambahAdmin.ShowDialog()
        FrmTambahAdmin.txtid.Focus()
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick
        Dim i As Integer
        Dim id As String
        i = dg.CurrentRow.Index
        id = dg.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 3 Then
            FrmTambahAdmin.txtid.Text = id
            FrmTambahAdmin.txtid.Enabled = False
            FrmTambahAdmin.txtidkaryawan.Focus()
            FrmTambahAdmin.cmdsimpan.Text = "Update"
            FrmTambahAdmin.ShowDialog()
        End If

        If e.ColumnIndex = 4 Then
            Dim x As Byte
            x = MsgBox("Hapus data Admin dengan id " & id & " ?", MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "DELETE FROM admin WHERE adminid='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()
                dg.Columns.Clear()
                Call tampil("SELECT adminid, karyawannama, IF(adminlevel=1,'Admin','Kasir') AS level" & "FROM admin JOIN karyawan ON adminkaryawanid=karyawanid")
                Call setdg()
                Call buattombol()
            End If
        End If

        If e.ColumnIndex = 5 Then
            Dim pass As String
            mnRandomNumber = GetRandomNumber(1, 10000)
            pass = mnRandomNumber

            'Program untuk mereset password dibuat pada bagian ini
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "UPDATE admin SET adminnamapass=md5('" & pass & "') WHERE adminid='" & id & "'"
            perintah.ExecuteNonQuery()
            kon.Close()
            MsgBox("Password Baru : " & pass, MsgBoxStyle.Information, "Informasi")
        End If

        If e.ColumnIndex = 6 Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "UPDATE admin SET adminaktif=0 WHERE adminid='" & id & "'"
            perintah.ExecuteNonQuery()
            kon.Close()
            MsgBox("Sukses Di Blokir", MsgBoxStyle.Information, "Informasi")
        End If

        If e.ColumnIndex = 7 Then
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "UPDATE admin SET adminaktif=1 WHERE adminid='" & id & "'"
            perintah.ExecuteNonQuery()
            kon.Close()
            MsgBox("Sukses", MsgBoxStyle.Information, "Informasi")
        End If

    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub

End Class