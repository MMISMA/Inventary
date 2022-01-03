Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Register
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand

    Dim puntoX, puntoY As Integer
    Dim mover As Boolean
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Try
        '    comandos = New MySqlCommand("INSERT INTO `rol`(id,nombre)" & Chr(13) &
        '                                "VALUES(@id,@nombre)", conexion)
        '    comandos.Parameters.AddWithValue("@id", ttttt)
        '    comandos.Parameters.AddWithValue("@nombre", rrrr)
        '    comandos.ExecuteNonQuery()
        '    MsgBox("Ingresado Correctamente")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Try
            comandos = New MySqlCommand("INSERT INTO `usuario`(id,nombre,usuario,contraseña,rol)" & Chr(13) &
                                        "VALUES(@id,@nombre,@usuario,@contraseña,@rol)", conexion)
            comandos.Parameters.AddWithValue("@id", txtid.Text)
            comandos.Parameters.AddWithValue("@nombre", txtnombre.Text)
            comandos.Parameters.AddWithValue("@usuario", txtusuario.Text)
            comandos.Parameters.AddWithValue("@contraseña", txtcontra.Text)
            comandos.Parameters.AddWithValue("@rol", txtrol.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Ingresado Correctamente")
            txtid.Text = ""
            txtnombre.Text = ""
            txtusuario.Text = ""
            txtcontra.Text = ""
            txtrol.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            MsgBox("Conexion lograda")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim eliminar As String
        Dim si As Byte
        si = MsgBox("¿Desea eliminar a: " & txtnombre.Text, vbYesNo, "Eliminar")
        If si = 6 Then
            eliminar = "DELETE FROM usuario WHERE nombre='" & txtnombre.Text & "'"
            comandos = New MySqlCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox(txtnombre.Text & " ha sido eliminado")
            txtid.Text = ""
            txtnombre.Text = ""
            txtusuario.Text = ""
            txtcontra.Text = ""
            txtrol.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Close()
    End Sub
End Class