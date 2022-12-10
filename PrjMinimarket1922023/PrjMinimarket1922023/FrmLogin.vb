Public Class FrmLogin

    Private Sub txtid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtid.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpass.Focus()
        End Select
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmdmasuk_Click(e, AcceptButton)
        End Select
    End Sub

    Private Sub cmdbatal_Click(sender As System.Object, e As System.EventArgs) Handles cmdbatal.Click
        Me.Dispose()
    End Sub

    Private Sub cmdmasuk_Click(sender As System.Object, e As System.EventArgs) Handles cmdmasuk.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT admin.*,karyawannama FROM admin join karyawan on adminkaryawanid=karyawanid WHERE adminid='" & txtid.Text & "' AND " & _
                " adminnamapass=MD5('" & txtpass.Text & "') AND adminaktif=1"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            adminlogin = txtid.Text
            Dim leveladmin As String
            leveladmin = cek.Item("adminlevel")
            adminnama = cek.Item("karyawannama")
            If leveladmin = 2 Then ' jika yg login adalah kasir
                FrmMenu.msmenu.Enabled = False
            End If
            FrmMenu.Show()
            FrmMenu.admin.Text = adminnama

            Me.Hide()
        Else
            MsgBox("Id atau password salah", MsgBoxStyle.Information, "Informasi")
        End If
        kon.Close()
    End Sub

End Class
