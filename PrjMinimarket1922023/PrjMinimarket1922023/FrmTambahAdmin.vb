Public Class FrmTambahAdmin
    Dim level As String
    Dim mnRandomNumber As Integer

    Function GetRandomNumber(ByVal vnMinimumNumber As Integer, ByVal vnMaximumNumber As Integer)
        Randomize()
        GetRandomNumber = CInt(Int((vnMaximumNumber - vnMinimumNumber + 1) * Rnd() + vnMinimumNumber))
    End Function

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
        perintah.CommandText = "SELECT adminid,adminkaryawanid,karyawannama,adminlevel FROM admin JOIN karyawan ON admin.adminkaryawanid=karyawan.karyawanid WHERE adminid='" & txtid.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnamkaryawan.Text = cek.Item("karyawannama")
            txtidkaryawan.Text = cek.Item("adminkaryawanid")
            level = cek.Item("adminlevel")
            If level = "1" Then
                rbadmin.Checked = True
            Else
                rbkasir.Checked = True
            End If
        End If
        kon.Close()
    End Sub

    Private Sub cmdcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcari.Click
        FrmCariKaryawan.ShowDialog()
    End Sub

    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        Dim pass As String
        mnRandomNumber = GetRandomNumber(1, 10000)
        pass = mnRandomNumber
        If txtid.Text.Length > 0 And txtidkaryawan.Text.Length > 0 Then
            If rbadmin.Checked = True Then
                level = "1"
            Else
                level = "2"
            End If

            If cmdsimpan.Text = "Simpan" Then
                Call proses("INSERT INTO admin VALUES('" & txtid.Text & "', md5('" & pass & "'), '" & txtidkaryawan.Text & "', '1', '" & level & "')")
                MsgBox("Password Dengan Nama " & txtnamkaryawan.Text & " adalah : " & pass, MsgBoxStyle.Information, "Informasi")
            Else
                Call proses("UPDATE admin SET adminkaryawanid='" & txtidkaryawan.Text & "', adminlevel='" & level & "' WHERE adminid='" & txtid.Text & "'")
                cmdsimpan.Text = "Simpan"
            End If
            txtid.Text = ""
            txtidkaryawan.Text = ""
            txtnamkaryawan.Text = ""

            FrmAdmin.dg.Columns.Clear()
            FrmAdmin.tampil("SELECT adminid, karyawannama, IF(adminlevel=1,'Admin','Kasir') AS level FROM admin JOIN karyawan ON adminkaryawanid=karyawanid")
            FrmAdmin.setdg()
            FrmAdmin.buattombol()
            Me.cmdsimpan.Text = "Simpan"
            Me.Close()
        Else
            MsgBox("Lengkapi Isian yang ada tanda *", MsgBoxStyle.Information, "Informasi")
        End If

    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Me.Dispose()
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        Call cekkode()
    End Sub

    Private Sub rbadmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbadmin.CheckedChanged
        cmdsimpan.Enabled = True
    End Sub

    Private Sub rbkasir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbkasir.CheckedChanged
        cmdsimpan.Enabled = True
    End Sub

    Private Sub txtidkaryawan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidkaryawan.TextChanged
        Call cekkode()
    End Sub
End Class