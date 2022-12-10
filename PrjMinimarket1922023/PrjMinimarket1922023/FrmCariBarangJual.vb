Public Class FrmCariBarangJual
    Dim nama As String
    Dim id As String
    Dim i As Integer
    Dim muncul As String

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
        Dim cpilih As New DataGridViewButtonColumn
        cpilih.Name = "cpilih"
        cpilih.HeaderText = ""
        cpilih.FlatStyle = FlatStyle.Popup
        cpilih.DefaultCellStyle.ForeColor = Color.DarkGreen
        cpilih.Text = "Pilih"
        cpilih.Width = 50
        cpilih.UseColumnTextForButtonValue = True
        dg.Columns.Add(cpilih)

        Dim cedit As New DataGridViewButtonColumn
        cedit.Name = "cedit"
        cedit.HeaderText = ""
        cedit.FlatStyle = FlatStyle.Popup
        cedit.DefaultCellStyle.ForeColor = Color.DarkGreen
        cedit.Text = "Edit Barang"
        cedit.Width = 100
        cedit.UseColumnTextForButtonValue = True
        dg.Columns.Add(cedit)
    End Sub

    Sub setdg()
        dg.Columns(0).HeaderText = "Id Barang"
        dg.Columns(1).HeaderText = "Nama Barang"
        dg.Columns(2).HeaderText = "Harga Jual"
        dg.Columns(0).Width = 100
        dg.Columns(1).Width = 200
        dg.Columns(2).Width = 100
    End Sub
End Class