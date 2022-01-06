Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Register
    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        Try
            If txtnombre.Text = "Administrador" Then
                MsgBox("Nombre: Administrador, reservado")
            ElseIf txtContraAdmin.Text = CBcontra.Text Then
                comandos = New MySqlCommand("INSERT INTO `usuario`(nombre,usuario,contraseña,rol)" & Chr(13) &
                                            "VALUES(@nombre,@usuario,@contraseña,@rol)", conexion)
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
                txtContraAdmin.Text = ""
            Else
                MsgBox("Ingrese la contraseña del Administrador")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()

            Dim consulta As String
            consulta = "SELECT contraseña FROM usuario WHERE nombre ='" & LBadmin.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("contraseña")
            adaptador.Fill(datos.Tables("contraseña"))
            CBcontra.DataSource = datos.Tables("contraseña")
            CBcontra.DisplayMember = "contraseña"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        EliminarUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Try
            If txtnombre.Text = "Administrador" Then
                MsgBox("No se puede actualizar al administrador")
            Else
                Dim actualizar As String
                actualizar = "UPDATE usuario SET nombre='" & txtnombre.Text & "', usuario='" & txtusuario.Text & "', contraseña='" & txtcontra.Text & "', rol='" & txtrol.Text & "'WHERE nombre='" & txtnombre.Text & "'"
                comandos = New MySqlCommand(actualizar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Usuario Actualizado")
                txtnombre.Text = ""
                txtusuario.Text = ""
                txtcontra.Text = ""
                txtrol.Text = ""
                txtContraAdmin.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Ingrese todos los datos para actualizar")
        End Try

    End Sub
    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Eliminar un usuario")
    End Sub

    Private Sub btnregistrar_MouseHover(sender As Object, e As EventArgs) Handles btnregistrar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Para registrar ingresa todos los datos")
    End Sub

    Private Sub txtcontra_MouseHover(sender As Object, e As EventArgs) Handles txtcontra.MouseHover
        TTMSG.SetToolTip(txtcontra, "Ingresa una contraseña")
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        TTMSG.SetToolTip(txtnombre, "Ingresa un nombre")
    End Sub

    Private Sub txtusuario_MouseHover(sender As Object, e As EventArgs) Handles txtusuario.MouseHover
        TTMSG.SetToolTip(txtusuario, "Ingresa un nombre de usuario")
    End Sub
    Private Sub txtrol_MouseHover(sender As Object, e As EventArgs) Handles txtrol.MouseHover
        TTMSG.SetToolTip(txtrol, "Ingresa un numero, 1)Administrador 2)Jefe de departamento 3)Asistente")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Try
            Dim consulta As String
            consulta = "SELECT contraseña FROM usuario WHERE nombre ='" & LBadmin.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("contraseña")
            adaptador.Fill(datos.Tables("contraseña"))
            CBcontra.DataSource = datos.Tables("contraseña")
            CBcontra.DisplayMember = "contraseña"
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos")
        End Try

    End Sub

    Private Sub btnactualizar_MouseHover(sender As Object, e As EventArgs) Handles btnactualizar.MouseHover
        TTMSG.SetToolTip(btnactualizar, "Ingrese el nombre del usuario que se desea actualizar junto con el resto de datos")
    End Sub
End Class