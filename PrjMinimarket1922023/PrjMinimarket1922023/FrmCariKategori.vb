﻿Public Class FrmCarikategori
    Dim nama As String

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
        'Tambah button edit
        Dim cpilih As New DataGridViewButtonColumn
        cpilih.Name = "cpilih"
        cpilih.HeaderText = ""
        cpilih.FlatStyle = FlatStyle.Popup
        cpilih.DefaultCellStyle.ForeColor = Color.DarkGreen
        cpilih.Text = "Pilih"
        cpilih.Width = 50
        cpilih.UseColumnTextForButtonValue = True
        dg.Columns.Add(cpilih)
    End Sub

    Sub setdg()
        dg.Columns(0).HeaderText = "No"
        dg.Columns(1).HeaderText = "Nama Kategori"
        dg.Columns(0).Width = 100
        dg.Columns(1).Width = 200
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick
        Dim i As Integer
        Dim id As String
        i = dg.CurrentRow.Index
        id = dg.Rows.Item(i).Cells(0).Value
        nama = dg.Rows.Item(i).Cells(1).Value
        If e.ColumnIndex = 2 Then
            FrmTambahBarang.txtidkategori.Text = id
            FrmTambahBarang.txtnamakategori.Text = nama
            Me.Dispose()
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        dg.Columns.Clear()
        Call tampil("SELECT kategoriid,kategorinama  from kategori " & _
                    " where kategoriid='" & txtcari.Text & "' or kategorinama like '%" & txtcari.Text & "%'")
        Call setdg()
        Call buattombol()

    End Sub

    Private Sub FrmCarikategori_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dg.Columns.Clear()
        Call tampil("SELECT kategoriid,kategorinama  from kategori")
        Call setdg()
        Call buattombol()

    End Sub

    Private Sub FrmCarikategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class