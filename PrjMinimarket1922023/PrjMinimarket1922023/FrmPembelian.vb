Public Class FrmPembelian
    Dim kode As String
    Dim diskon, subtot, totsel As Double

    Sub buatnofak()
        Dim kode, kodebaru, tgl As String
        Dim no As Integer
        tgl = Format(Now, "ddMMyyyy")
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from beli " & _
            " where belitgl=curdate() order by belinofak desc limit 1"
        cek = perintah.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("belinofak")
            no = Val(Microsoft.VisualBasic.Right(kode, 5))
            no = no + 1
            kodebaru = "FBL-" + tgl + Format(no, "00001")
            txtnofak.Text = kodebaru
        Else
            txtnofak.Text = "FBL-" + tgl + "00001"
        End If
        kon.Close()
    End Sub

    Sub cekkode()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from barang where " & _
            " barangid='" & txtkode.Text & "' or barangbarcode='" & txtkode.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("barangid")
            txtnamabarang.Text = cek.Item("barangnama")
            txtharga.Text = cek.Item("baranghargajual")
            txtsatuan.Text = cek.Item("barangsatuan")
        End If
        kon.Close()
    End Sub

    Sub proses(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

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

    Sub setdg()
        dg.Columns(0).HeaderText = "Id Barang"
        dg.Columns(1).HeaderText = "Nama Barang"
        dg.Columns(2).HeaderText = "Satuan"
        dg.Columns(3).HeaderText = "Harga"
        dg.Columns(4).HeaderText = "Qty"
        dg.Columns(5).HeaderText = "Sub Total"

        dg.Columns(0).Width = 155
        dg.Columns(1).Width = 200
        dg.Columns(2).Width = 93
        dg.Columns(3).Width = 100
        dg.Columns(4).Width = 93
        dg.Columns(5).Width = 200

        dg.Columns(3).DefaultCellStyle.ForeColor = Color.Red
        dg.Columns(5).DefaultCellStyle.ForeColor = Color.Blue
    End Sub

    Sub hitungtotal()
        Dim subtotal As Double
        Dim i As Integer
        For i = 0 To dg.Rows.Count - 2
            subtotal = subtotal + dg.Rows(i).Cells(5).Value
        Next
        lblsubtotal.Text = Format(subtotal, "Rp ###,###,###")
        diskon = Val(txtdiskon.Text) / 100 * subtotal
        lbldiskon.Text = Format(diskon, "Rp ###,###,###")
        totsel = subtotal - diskon
        lbltotal.Text = Format(totsel, "Rp ###,###,###")
    End Sub

    Private Sub cmdcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcari.Click
        FrmCariPemasok.ShowDialog()
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        txtsubtotal.Text = Val(txtharga.Text) * Val(txtqty.Text)
    End Sub

    Private Sub FrmPembelian_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Call bersih()
        Call proses("delete from temp")
        Call tampil("select id, barangnama, barangsatuan,harga,qty, harga * qty as subtotal from temp join barang on id=barangid")
        Call setdg()
        Call hitungtotal()
    End Sub

    Private Sub FrmPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Call proses("insert into temp values('" & kode & "','" & txtqty.Text & "','" & txtharga.Text & "')")
        Call tampil("select id, barangnama, barangsatuan,harga,qty, harga * qty as subtotal from temp join barang on id=barangid")
        Call setdg()
        Call hitungtotal()
        txtkode.Text = ""
        txtnamabarang.Text = ""
        txtsatuan.Text = ""
        txtharga.Text = ""
        txtqty.Text = ""
        txtsubtotal.Text = ""
        txtkode.Focus()
    End Sub

    Private Sub txtkode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkode.TextChanged
        Call cekkode()
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub txtdiskon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiskon.TextChanged
        Call hitungtotal()
    End Sub

    Private Sub lkbantuan_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkbantuan.LinkClicked
        FrmCariBarangBeli.ShowDialog()
    End Sub

    Private Sub cmdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsimpan.Click
        Dim x As Byte
        x = MsgBox("Data sudah benar..?", MsgBoxStyle.Information + vbYesNo, "Konfirmasi")
        If x = vbYes Then
            Call proses("insert into beli values('" & txtnofak.Text & "', " & _
 " '" & Format(dtp.Value, "yyyy-MM-dd") & "','" & txtidpemasok.Text & "', " & _
 " '" & diskon & "','" & subtot & "','" & totsel & "','" & adminlogin & "')")
            Call proses("insert into detailbeli (dbelinofak,dbelibarangid,dbeliqty,dbeliharga) " & _
 " select '" & txtnofak.Text & "', id, qty, harga from temp ")
            Call proses("delete from temp")
            cmdbaru_Click(e, AcceptButton)
        End If
        Call bersih()
    End Sub

    Private Sub cmdbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbaru.Click
        Call bersih()
        Call buatnofak()
        txtnofak.Focus()
        Call FrmPembelian_Activated(e, AcceptButton)
    End Sub

    Sub bersih()
        txtnofak.Text = ""
        txtkode.Text = ""
        txtnamabarang.Text = ""
        txtsatuan.Text = ""
        txtharga.Text = ""
        txtqty.Text = ""
        txtsubtotal.Text = ""
        txtkode.Focus()
    End Sub
End Class