Imports MySql.Data.MySqlClient
Module Module1
    Dim strkon As String = "server=localhost;uid=root;database=minimarket"
    Public kon As New MySqlConnection(strkon)
    Public perintah As New MySqlCommand
    Public cek As MySqlDataReader
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
    Public adminlogin, adminnama, admin, i, id As String
End Module
