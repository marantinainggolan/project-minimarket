Public Class FrmGantiPassword

    Private Sub txtps_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtps.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "SELECT * FROM admin WHERE adminid='" & adminlogin & "' AND adminpass=md5('" & txtps.Text & "')"
                cek = perintah.ExecuteReader()
                cek.Read()
                If cek.HasRows Then
                    txtpb.Enabled = True
                    txtpb.Focus()
                Else
                    MsgBox("Password Anda Salah", MsgBoxStyle.Information, "Informasi")
                End If
                cek.Close()
                kon.Close()
        End Select
    End Sub

    Private Sub txtpb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpb.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If (txtpb.Text.Length) >= 6 Then
                    txtupb.Enabled = True
                    txtupb.Focus()
                Else
                    MsgBox("Password Baru Minimal 6 Karakter", MsgBoxStyle.Information, "Informasi")
                    txtpb.Focus()
                End If
        End Select
    End Sub

    Private Sub txtupb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtupb.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If (txtupb.Text <> txtpb.Text) Then
                    MsgBox("Ulangi! Password Baru Tidak Sama", MsgBoxStyle.Information, "Pesan")
                    txtupb.Focus()
                Else
                    cmdubah.Enabled = True
                    cmdubah.Focus()
                End If
        End Select

    End Sub

    Private Sub cmdubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdubah.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE admin SET adminnamapass=md5('" & txtpb.Text & "') WHERE adminid='" & adminlogin & "'"
        perintah.ExecuteNonQuery()
        MsgBox("Password Anda Berhasil Diubah", MsgBoxStyle.Information, "Informasi")
        kon.Close()
        Me.Close()
    End Sub
End Class