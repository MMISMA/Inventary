Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AyECompras
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As New MySqlCommand
    Dim lista As Byte

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub AyECompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT id FROM compra"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("id")
            adaptador.Fill(datos.Tables("id"))
            CBseleccionarRecibo.DataSource = datos.Tables("id")
            CBseleccionarRecibo.DisplayMember = "id"
        Catch ex As Exception
            MsgBox("No se pudo conectar a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim eliminar As String
            Dim si As Byte

            si = MsgBox("¿Desea eliminar el recibo: " & CBseleccionarRecibo.Text, vbYesNo, "Eliminar")
            If si = 6 Then
                eliminar = "DELETE FROM compra WHERE id='" & CBseleccionarRecibo.Text & "'"
                comandos = New MySqlCommand(eliminar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox(CBseleccionarRecibo.Text & " ha sido eliminado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnver.Click
        Try
            Dim sql As String

            sql = "SELECT * FROM compra WHERE id='" & CBseleccionarRecibo.Text & "'"
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos)
            lista = datos.Tables(0).Rows.Count

            Dim imgcon As Byte()
            imgcon = datos.Tables(0).Rows(0).Item("imagen")

            Dim ms As New MemoryStream(imgcon)
            Pfotos.Image = System.Drawing.Image.FromStream(ms)

            Dim consulta As String
            consulta = "SELECT fecha FROM compra WHERE id='" & CBseleccionarRecibo.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("fecha")
            adaptador.Fill(datos.Tables("fecha"))
            CBfecha.DataSource = datos.Tables("fecha")
            CBfecha.DisplayMember = "fecha"

            lbfecha.Text = CBfecha.Text
        Catch ex As Exception
            MsgBox("No hay imagen")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim consulta As String
            consulta = "SELECT id FROM compra"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("id")
            adaptador.Fill(datos.Tables("id"))
            CBseleccionarRecibo.DataSource = datos.Tables("id")
            CBseleccionarRecibo.DisplayMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class