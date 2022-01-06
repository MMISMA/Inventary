Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class EliminarUsuario

    Dim conexion As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

    Dim puntoX, puntoY As Integer
    Dim mover As Boolean

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        puntoX = e.X
        puntoY = e.Y
        mover = True
    End Sub

    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        mover = False
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If mover = True Then
            Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - puntoX, Control.MousePosition.Y - Me.Location.Y - puntoY))
        End If
    End Sub

    Private Sub UC_Tick(sender As Object, e As EventArgs) Handles UC.Tick
        Label2.Text += 1
        Lusuario.Top -= 3
        If Label2.Text = 8 Then
            UC.Stop()
        End If
    End Sub

    Private Sub EliminarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()

            Dim consulta As String
            consulta = "SELECT * FROM usuario"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("usuario")
            adaptador.Fill(datos.Tables("usuario"))
            CBusuario.DataSource = datos.Tables("usuario")
            CBusuario.DisplayMember = "usuario"

            consulta = "SELECT contraseña FROM usuario WHERE nombre ='" & LBadmin.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("contraseña")
            adaptador.Fill(datos.Tables("contraseña"))
            CBcontra.DataSource = datos.Tables("contraseña")
            CBcontra.DisplayMember = "contraseña"
        Catch ex As Exception
            MsgBox("No se conecto con la base de datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If CBusuario.Text = "Admin" Then
                MsgBox("No se puede eliminar el administrador")
            ElseIf txtContraAdmin.Text = CBcontra.Text Then
                Dim eliminar As String
                Dim si As Byte

                si = MsgBox("¿Desea eliminar a: " & CBusuario.Text, vbYesNo, "Eliminar")
                If si = 6 Then
                    eliminar = "DELETE FROM usuario WHERE usuario='" & CBusuario.Text & "'"
                    comandos = New MySqlCommand(eliminar, conexion)
                    comandos.ExecuteNonQuery()
                    MsgBox(CBusuario.Text & " ha sido eliminado")
                    txtContraAdmin.Text = ""
                End If
            Else
                MsgBox("Ingrese la contraseña del Administrador")
            End If
        Catch ex As Exception
            MsgBox("Favor de recargar")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM usuario"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("usuario")
            adaptador.Fill(datos.Tables("usuario"))
            CBusuario.DataSource = datos.Tables("usuario")
            CBusuario.DisplayMember = "usuario"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
        Me.Hide()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Eliminar a un usuario")
    End Sub

    Private Sub txtContraAdmin_MouseHover(sender As Object, e As EventArgs) Handles txtContraAdmin.MouseHover
        TTMSG.SetToolTip(txtContraAdmin, "Ingrese la contraseña del administrador")
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseHover
        TTMSG.SetToolTip(LinkLabel1, "Regresar a Registrar usuario")
    End Sub
End Class