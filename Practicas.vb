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
            datos.Tables.Add("id")
            adaptador.Fill(datos.Tables("id"))
            CBseleccionarPractica.DataSource = datos.Tables("id")
            CBseleccionarPractica.DisplayMember = "id"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String
        consulta = "SELECT * FROM practica WHERE id='" & CBseleccionarPractica.Text & "'"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "practica")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "practica"
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim actualizar As String
        actualizar = "UPDATE practica SET nombre='" & txtpractica.Text & "', info='" & txtinfo.Text & "'WHERE id='" & txtid.Text & "'"
        comandos = New MySqlCommand(actualizar, conexion)
        comandos.ExecuteNonQuery()
        MsgBox("Practica Actualizada")
    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click
        Try
            comandos = New MySqlCommand("INSERT INTO `practica`(id,nombre,info)" & Chr(13) &
                                        "VALUES(@id,@nombre,@info)", conexion)
            comandos.Parameters.AddWithValue("@id", txtid.Text)
            comandos.Parameters.AddWithValue("@nombre", txtpractica.Text)
            comandos.Parameters.AddWithValue("@info", txtinfo.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Ingresado Correctamente")
            txtid.Text = ""
            txtpractica.Text = ""
            txtinfo.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim eliminar As String
        Dim si As Byte

        si = MsgBox("¿Desea eliminar la practica: " & txtid.Text, vbYesNo, "Eliminar")
        If si = 6 Then
            eliminar = "DELETE FROM practica WHERE id='" & txtid.Text & "'"
            comandos = New MySqlCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox(txtid.Text & " ha sido eliminado")
        End If
    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Para eliminar solo ingresa el id de la practica")
    End Sub

    Private Sub btnañadir_MouseHover(sender As Object, e As EventArgs) Handles btnañadir.MouseHover
        TTMSG.SetToolTip(btnañadir, "Ingresa todos los datos de la practica")
    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover
        TTMSG.SetToolTip(btnActualizar, "Ingresa todos los datos de la practica a actualizar")
    End Sub
End Class