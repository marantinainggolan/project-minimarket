Public Class FrmPemasok
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
        dg.Columns(0).HeaderText = "Kode Pemasok"
        dg.Columns(1).HeaderText = "Nama Pemasok"
        dg.Columns(2).HeaderText = "Alamat Pemasok"
        dg.Columns(3).HeaderText = "No Telepone"

        dg.Columns(0).Width = 80
        dg.Columns(1).Width = 120
        dg.Columns(2).Width = 100
        dg.Columns(3).Width = 110

        'Call buattombol()
    End Sub

    Private Sub txtnama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged
        dg.Columns.Clear()
        Call tampil("SELECT * from pemasok where pemasokid like '%" & txtnama.Text & "%' or pemasoknama like '%" & txtnama.Text & "%'")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub FrmPemasok_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dg.Columns.Clear()
        Call tampil("SELECT * from pemasok")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub FrmPemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtambah.Click
        FrmTambahPemasok.Dispose()
        FrmTambahPemasok.ShowDialog()
        FrmTambahPemasok.cmdsimpan.Text = "Simpan"
        FrmTambahPemasok.txtkode.Enabled = True

        FrmTambahPemasok.txtkode.Text = ""
        FrmTambahPemasok.txtnama.Text = ""
        FrmTambahPemasok.txtnohp.Text = ""
        FrmTambahPemasok.txtalamat.Text = ""
        FrmTambahPemasok.cmdsimpan.Text = "Simpan"
        FrmTambahPemasok.txtkode.Focus()

    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim i As Integer
        Dim id As String
        i = dg.CurrentRow.Index
        id = dg.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 4 Then
            FrmTambahPemasok.txtkode.Text = id
            FrmTambahPemasok.txtkode.Enabled = False
            FrmTambahPemasok.txtnama.Focus()
            FrmTambahPemasok.cmdsimpan.Text = "Update"
            FrmTambahPemasok.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            Dim x As Byte
            x = MsgBox("Hapus data Pemasok dengan kode " & id & " ?", MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "delete from pemasok where pemasokid='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()
                dg.Columns.Clear()
                Call tampil("select * from pemasok")
                Call setdg()
                Call buattombol()
            End If
        End If
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub
End Class