Imports MySql.Data.MySqlClient

Public Class Practicas
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

    Private Sub Practicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM practica"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("nombre")
            adaptador.Fill(datos.Tables("nombre"))
            CBseleccionarPractica.DataSource = datos.Tables("nombre")
            CBseleccionarPractica.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox("No se pudo conectar a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnverpractica.Click
        Try
            Dim consulta As String
            consulta = "SELECT id, info FROM practica WHERE nombre='" & CBseleccionarPractica.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "practica")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "practica"
        Catch ex As Exception
            MsgBox("No se pudo comunicar con la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim consulta As String
            consulta = "SELECT reactivo.N_inventario, inventario_reactivos.reactivo, reactivo.cantidad, reactivo.medida, reactivo.practica FROM reactivo INNER JOIN practica ON reactivo.practica = practica.id INNER JOIN inventario_reactivos ON inventario_reactivos.N_inventario = reactivo.N_inventario WHERE practica.nombre='" & CBseleccionarPractica.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "practica")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "practica"
        Catch ex As Exception
            MsgBox("No se pudo comunicar con la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnrecargar.Click
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
            MsgBox("No se pudo conectar a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AyE_Practicas.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        AyEReactivos.Show()
    End Sub

    Private Sub btnListar_MouseHover(sender As Object, e As EventArgs) Handles btnListar.MouseHover
        TTMSG.SetToolTip(btnListar, "Ver todos los Reactivos de la practica seleccionada")
    End Sub

    Private Sub btnverpractica_MouseHover(sender As Object, e As EventArgs) Handles btnverpractica.MouseHover
        TTMSG.SetToolTip(btnverpractica, "Ver el numero de practica y su información")
    End Sub

    Private Sub btnrecargar_MouseHover(sender As Object, e As EventArgs) Handles btnrecargar.MouseHover
        TTMSG.SetToolTip(btnrecargar, "Recarga las practicas del menu desplegable")
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseHover
        TTMSG.SetToolTip(LinkLabel1, "Añadir, modificar o eliminar practicas")
    End Sub

    Private Sub LinkLabel2_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel2.MouseHover
        TTMSG.SetToolTip(LinkLabel2, "Añadir, modificar o eliminar Reactivos a una practica seleccionada")
    End Sub
End Class