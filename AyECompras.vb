Imports MySql.Data.MySqlClient

Public Class AyECompras
    Dim conexion As New MySqlConnection
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AyECompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            'MsgBox("Conexion lograda")
            Dim consulta As String
            consulta = "SELECT id FROM compra"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("id")
            adaptador.Fill(datos.Tables("id"))
            CBseleccionarRecibo.DataSource = datos.Tables("id")
            CBseleccionarRecibo.DisplayMember = "id"

        Catch ex As Exception
            MsgBox("No se pudo conectar a la Base de Datos", ex.Message)
        End Try
    End Sub
End Class