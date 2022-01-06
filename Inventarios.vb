Imports MySql.Data.MySqlClient

Public Class Inventarios
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

    Private Sub Inventarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM inventario_l_pesados"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "inventario_l_pesados")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "inventario_l_pesados"
        Catch ex As Exception
            MsgBox("No se pudo comunicar con a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM inventario_reactivos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "inventario_reactivos")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "inventario_reactivos"
        Catch ex As Exception
            MsgBox("No se pudo comunicar con a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM inventario_residuos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "inventario_residuos")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "inventario_residuos"
        Catch ex As Exception
            MsgBox("No se pudo comunicar con a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        Try
            Dim consulta As String
            consulta = "SELECT id, fecha, imagen FROM compra"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "compra")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "compra"
        Catch ex As Exception
            MsgBox("No se pudo comunicar con a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        TTMSG.SetToolTip(Button1, "Ver todos los elementos dentro del inventario de Pesados")
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        TTMSG.SetToolTip(Button2, "Ver todos los Reactivos")
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        TTMSG.SetToolTip(Button3, "Ver todos los Residuos")
    End Sub

    Private Sub btnCompras_MouseHover(sender As Object, e As EventArgs) Handles btnCompras.MouseHover
        TTMSG.SetToolTip(btnCompras, "Ver todos las compras realizadas")
    End Sub
End Class