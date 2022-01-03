Imports MySql.Data.MySqlClient

Public Class Inventarios
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As New MySqlCommand

    Private Sub Inventarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            MsgBox("Conexion lograda")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String
        Dim a As String
        consulta = "SELECT * FROM inventario_l_pesados"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "inventario_l_pesados")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "inventario_l_pesados"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta As String
        Dim a As String
        consulta = "SELECT * FROM inventario_reactivos"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "inventario_reactivos")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "inventario_reactivos"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta As String
        Dim a As String
        consulta = "SELECT * FROM inventario_residuos"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "inventario_residuos")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "inventario_residuos"
    End Sub
End Class