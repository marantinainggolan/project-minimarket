Public Class FrmTambahPemasok
    Sub proses(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub
    Sub bersih()
        txtkode.Text = ""
        txtnama.Text = ""
        'txttmplhr.Text = ""
        txtalamat.Text = ""
        txtnohp.Text = ""
    End Sub

    Sub cekkode()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from pemasok where pemasokid='" & txtkode.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnama.Text = cek.Item("pemasoknama")
            txtnohp.Text = cek.Item("pemasoknotelp")
            txtalamat.Text = cek.Item("pemasokalamat")
        End If
        kon.Close()
    End Sub

    Private Sub txtkode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtnama.Focus()
                txtkode.Text = UCase(txtkode.Text)
        End Select
    End Sub

    Private Sub txtkode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkode.TextChanged
        Call cekkode()
    End Sub

    Private Sub txtnama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnama.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtnohp.Focus()
                'txtid.Text = UCase(txtid.Text)
        End Select
    End Sub

    Private Sub txtnama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub txtnohp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnohp.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtalamat.Focus()
                ' txtid.Text = UCase(txtid.Text)
        End Select
    End Sub

    Private Sub txtnohp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnohp.TextChanged

    End Sub

    Private Sub txtalamat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtalamat.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmdsimpan.Focus()
                'txtid.Text = UCase(txtid.Text)
        End Select
    End Sub

    Private Sub txtalamat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtalamat.TextChanged

    End Sub

    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        If cmdsimpan.Text = "Simpan" Then
            Call proses("INSERT INTO pemasok VALUES('" & txtkode.Text & "','" & txtnama.Text & "','" & txtnohp.Text & "','" & txtalamat.Text & "')")
        Else

            Call proses("update pemasok set pemasoknama='" & txtnama.Text & "',pemasoknotelp='" & txtnohp.Text & "', pemasokalamat='" & txtalamat.Text & "' where pemasokid='" & txtkode.Text & "'")
            cmdsimpan.Text = "Simpan"
        End If
        txtkode.Text = ""
        txtnama.Text = ""
        FrmPemasok.dg.Columns.Clear()
        FrmPemasok.tampil("select * from pemasok")
        FrmPemasok.setdg()
        FrmPemasok.buattombol()
        Me.cmdsimpan.Text = "Simpan"
        Me.Close()

    End Sub

    Private Sub cmdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatal.Click
        Me.Dispose()
    End Sub
End Class