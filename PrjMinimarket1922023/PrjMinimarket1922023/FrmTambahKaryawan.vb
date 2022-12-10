Public Class FrmTambahKaryawan
    Dim jekel As String

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
        perintah.CommandText = "SELECT * FROM karyawan WHERE karyawanid='" & txtid.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnama.Text = cek.Item("karyawannama")
            jekel = cek.Item("karyawanjkl")
            If jekel = "L" Then
                rblakilaki.Checked = True
            Else
                rbperempuan.Checked = True
            End If
            txttmplhr.Text = cek.Item("karyawantmplhr")
            dtptgllhr.Value = cek.Item("karyawantgllhr")
            txtnohp.Text = cek.Item("karyawannohp")
            txtalamat.Text = cek.Item("karyawanalamat")
        End If
        kon.Close()
    End Sub

    Private Sub txtid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtid.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtnama.Focus()
                txtid.Text = UCase(txtid.Text)
        End Select
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        Call cekkode()
    End Sub

    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        If txtid.Text.Length > 0 And txtnama.Text.Length > 0 Then
            If rblakilaki.Checked = True Then
                jekel = "L"
            Else
                jekel = "P"
            End If
            If cmdsimpan.Text = "Simpan" Then
                Call proses("INSERT INTO karyawan VALUES('" & txtid.Text & "','" & txtnama.Text & "','" & jekel & "','" & txttmplhr.Text & "','" & Format(dtptgllhr.Value, "yyyy-MM-dd") & "','" & txtnohp.Text & "','" & txtalamat.Text & "')") 'Buat perintah simpan
                MsgBox("Data Karyawan Berhasil Ditambahkan", MsgBoxStyle.Information, "Tambah Karyawan")
            Else
                Call proses("update karyawan set karyawannama='" & txtnama.Text & "','" & jekel & "','" & txttmplhr.Text & "','" & Format(dtptgllhr.Value, "yyyy-MM-dd") & "','" & txtnohp.Text & "','" & txtalamat.Text & "')")
                cmdsimpan.Text = "Simpan"
                MsgBox("Data Barang Berhasil Di Update", MsgBoxStyle.Information, "Tambah Karyawan")
            End If
            txtid.Text = ""
            txtnama.Text = ""
            FrmKaryawan.dg.Columns.Clear()
            FrmKaryawan.tampil("select * from karyawan")
            FrmKaryawan.setdg()
            FrmKaryawan.buattombol()
            Me.cmdsimpan.Text = "Simpan"
            Me.Close()
        Else
            MsgBox("Lengkapi isian yang ada tanda *", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Me.Dispose()
    End Sub

    Private Sub txtnohp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnohp.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtalamat.Focus()
        End Select
    End Sub

    Private Sub rblakilaki_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rblakilaki.CheckedChanged
        txttmplhr.Focus()
    End Sub

    Private Sub rbperempuan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbperempuan.CheckedChanged
        txttmplhr.Focus()
    End Sub
End Class