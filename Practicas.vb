Imports MySql.Data.MySqlClient

Public Class Practicas
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As New MySqlCommand

    Private Sub Practicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            MsgBox("Conexion lograda")
            Dim consulta As String
            consulta = "SELECT * FROM practica"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("nombre")
            adaptador.Fill(datos.Tables("nombre"))
            CBseleccionarPractica.DataSource = datos.Tables("nombre")
            CBseleccionarPractica.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String
        consulta = "SELECT id, info FROM practica WHERE nombre='" & CBseleccionarPractica.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "practica")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "practica"
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim consulta As String
        consulta = "SELECT reactivo.N_inventario, inventario_reactivos.reactivo, reactivo.cantidad, reactivo.medida, reactivo.practica FROM reactivo INNER JOIN practica ON reactivo.practica = practica.id INNER JOIN inventario_reactivos ON inventario_reactivos.N_inventario = reactivo.N_inventario WHERE practica.nombre='" & CBseleccionarPractica.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "practica")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "practica"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AyE_Practicas.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        AyEReactivos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM practica"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("nombre")
            adaptador.Fill(datos.Tables("nombre"))
            CBseleccionarPractica.DataSource = datos.Tables("nombre")
            CBseleccionarPractica.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class