Public Class FrmKategori
    Private Property i As Integer
    Private Property id As Object

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
        'Call buattombol()
    End Sub
    Sub setdg()
        dg.Columns(0).HeaderText = "Id Kategori"
        dg.Columns(1).HeaderText = "Nama Kategori"
        dg.Columns(0).Width = 200
        dg.Columns(1).Width = 200
    End Sub

    Private Sub cmdtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtambah.Click
        FrmTambahKategori.ShowDialog()
    End Sub

    Private Sub FrmKategori_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dg.Columns.Clear()
        Call tampil("select * from kategori")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub FrmKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dg.Columns.Clear()
        Call tampil("select * from kategori")
        Call setdg()
        Call buattombol()
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick
        i = dg.CurrentRow.Index
        id = dg.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 2 Then
            FrmTambahKategori.txtid.Text = id
            FrmTambahKategori.txtid.Enabled = False
            FrmTambahKategori.txtnamakategori.Focus()
            FrmTambahKategori.cmdsimpan.Text = "Update"
            FrmTambahKategori.ShowDialog()
        End If
        If e.ColumnIndex = 3 Then
            Dim x As Byte
            x = MsgBox("Hapus data Kategori dengan kode " & id & " ?", MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "delete from kategori where kategoriid='" & id & "'"
                perintah.ExecuteNonQuery()
                kon.Close()
                dg.Columns.Clear()
                Call tampil("select * from kategori")
                Call setdg()
                Call buattombol()
            End If
        End If
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub
End Class