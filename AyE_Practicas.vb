Imports MySql.Data.MySqlClient

Public Class AyE_Practicas

    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As New MySqlCommand

    Dim puntoX, puntoY As Integer
    Dim mover As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel.MouseDown
        puntoX = e.X
        puntoY = e.Y
        mover = True
    End Sub

    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel.MouseUp
        mover = False
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel.MouseMove
        If mover = True Then
            Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - puntoX, Control.MousePosition.Y - Me.Location.Y - puntoY))
        End If
    End Sub

    Private Sub AyE_Practicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            'MsgBox("Conexion lograda")
        Catch ex As Exception
            MsgBox("No se conecto con la base de datos", ex.Message)
        End Try
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

    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim actualizar As String
            actualizar = "UPDATE practica SET nombre='" & txtpractica.Text & "', info='" & txtinfo.Text & "'WHERE id='" & txtid.Text & "'"
            comandos = New MySqlCommand(actualizar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Practica Actualizada")
        Catch ex As Exception
            MsgBox("Ingrese datos validos")
        End Try

    End Sub

    Private Sub btneliminar_Click_1(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim eliminar As String
            Dim si As Byte

            si = MsgBox("¿Desea eliminar la practica: " & txtid.Text, vbYesNo, "Eliminar")
            If si = 6 Then
                eliminar = "DELETE FROM practica WHERE id='" & txtid.Text & "'"
                comandos = New MySqlCommand(eliminar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox(txtid.Text & " ha sido eliminado")
            End If
        Catch ex As Exception
            MsgBox("No debe de haber ningun reactivo en la practica para eliminar")
        End Try

    End Sub

    Private Sub btnañadir_MouseHover(sender As Object, e As EventArgs) Handles btnañadir.MouseHover
        TTMSG.SetToolTip(btnañadir, "Ingresa todos los datos de la practica")
    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Para eliminar solo ingresa el id de la practica")
    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover
        TTMSG.SetToolTip(btnActualizar, "Ingresa todos los datos de la practica a actualizar")
    End Sub

    Private Sub txtid_MouseHover(sender As Object, e As EventArgs) Handles txtid.MouseHover
        TTMSG.SetToolTip(txtid, "Ingrese el numero de la practica")
    End Sub

    Private Sub txtinfo_MouseHover(sender As Object, e As EventArgs) Handles txtinfo.MouseHover
        TTMSG.SetToolTip(txtinfo, "Ingrese la información de la practica")
    End Sub

    Private Sub txtpractica_MouseHover(sender As Object, e As EventArgs) Handles txtpractica.MouseHover
        TTMSG.SetToolTip(txtpractica, "Ingrese el nombre de la practica")
    End Sub
End Class