Imports MySql.Data.MySqlClient

Public Class AyEReactivos
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

    Private Sub AyEReactivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            'MsgBox("Conexion lograda")
            Dim consulta As String
            consulta = "SELECT id FROM practica"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("id")
            adaptador.Fill(datos.Tables("id"))
            CBPractica.DataSource = datos.Tables("id")
            CBPractica.DisplayMember = "id"

            consulta = "SELECT reactivo FROM inventario_reactivos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("reactivo")
            adaptador.Fill(datos.Tables("reactivo"))
            CBReactivo.DataSource = datos.Tables("reactivo")
            CBReactivo.DisplayMember = "reactivo"
        Catch ex As Exception
            MsgBox("No se conecto con la base de datos", ex.Message)
        End Try
    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click
        Try
            Dim reativoB As String
            reativoB = "SELECT N_inventario FROM inventario_reactivos WHERE reactivo='" & CBReactivo.Text & "'"
            adaptador = New MySqlDataAdapter(reativoB, conexion)
            datos = New DataSet
            datos.Tables.Add("N_inventario")
            adaptador.Fill(datos.Tables("N_inventario"))
            CBnInv.DataSource = datos.Tables("N_inventario")
            CBnInv.DisplayMember = "N_inventario"

            comandos = New MySqlCommand("INSERT INTO `reactivo`(N_inventario,cantidad,medida,practica)" & Chr(13) &
                                        "VALUES(@N_inventario,@cantidad,@medida,@practica)", conexion)
            comandos.Parameters.AddWithValue("@N_inventario", CBnInv.Text)
            comandos.Parameters.AddWithValue("@cantidad", txtCant.Text)
            comandos.Parameters.AddWithValue("@medida", txtMedida.Text)
            comandos.Parameters.AddWithValue("@practica", CBPractica.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Se añadio el reactivo: " & CBReactivo.Text & " dentro de la practica: " & CBPractica.Text & " Correctamente")
            txtCant.Text = ""
            txtMedida.Text = ""
        Catch ex As Exception
            MsgBox("Llenar todos los datos", ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim reativoB As String
            reativoB = "SELECT N_inventario FROM inventario_reactivos WHERE reactivo='" & CBReactivo.Text & "'"
            adaptador = New MySqlDataAdapter(reativoB, conexion)
            datos = New DataSet
            datos.Tables.Add("N_inventario")
            adaptador.Fill(datos.Tables("N_inventario"))
            CBnInv.DataSource = datos.Tables("N_inventario")
            CBnInv.DisplayMember = "N_inventario"

            Dim actualizar As String
            actualizar = "UPDATE reactivo SET cantidad='" & txtCant.Text & "', medida='" & txtMedida.Text & "'WHERE practica='" & CBPractica.Text & "' AND N_inventario='" & CBnInv.Text & "'"
            comandos = New MySqlCommand(actualizar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Practica Actualizada")
        Catch ex As Exception
            MsgBox("Ingresa todos los datos")
        End Try

    End Sub

    Private Sub btneliminar_Click_1(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim reativoB As String
            reativoB = "SELECT N_inventario FROM inventario_reactivos WHERE reactivo='" & CBReactivo.Text & "'"
            adaptador = New MySqlDataAdapter(reativoB, conexion)
            datos = New DataSet
            datos.Tables.Add("N_inventario")
            adaptador.Fill(datos.Tables("N_inventario"))
            CBnInv.DataSource = datos.Tables("N_inventario")
            CBnInv.DisplayMember = "N_inventario"

            Dim eliminar As String
            Dim si As Byte

            si = MsgBox("¿Desea eliminar el reactivo: " & CBReactivo.Text & " de la practica: " & CBPractica.Text, vbYesNo, "Eliminar")
            If si = 6 Then
                eliminar = "DELETE FROM reactivo WHERE practica='" & CBPractica.Text & "' AND N_inventario='" & CBnInv.Text & "'"
                comandos = New MySqlCommand(eliminar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("El reactivo: " & CBReactivo.Text & " de la practica: " & CBPractica.Text & " a sido eliminado")
            End If
        Catch ex As Exception
            MsgBox("Reactivo o practica no valida", ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim consulta As String
            consulta = "SELECT id FROM practica"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("id")
            adaptador.Fill(datos.Tables("id"))
            CBPractica.DataSource = datos.Tables("id")
            CBPractica.DisplayMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnañadir_MouseHover(sender As Object, e As EventArgs) Handles btnañadir.MouseHover
        TTMSG.SetToolTip(btnañadir, "Selecciona el reactivo y la practica donde se desea añadir e inserte la cantidad y medida ")
    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Para eliminar selecciona el reactivo y la practica que se desea eliminar")
    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover
        TTMSG.SetToolTip(btnActualizar, "Selecciona el reactivo dentro de la practica a actualizar e ingresa la cantidad y medida para actualizar")
    End Sub

    Private Sub CBPractica_MouseHover(sender As Object, e As EventArgs) Handles CBPractica.MouseHover
        TTMSG.SetToolTip(CBPractica, "Selecciona una practica existente")
    End Sub

    Private Sub CBReactivo_MouseHover(sender As Object, e As EventArgs) Handles CBReactivo.MouseHover
        TTMSG.SetToolTip(CBReactivo, "Selecciona un reactivo existente")
    End Sub

    Private Sub txtCant_MouseHover(sender As Object, e As EventArgs) Handles txtCant.MouseHover
        TTMSG.SetToolTip(txtCant, "Ingrese la cantidad del reactivo")
    End Sub

    Private Sub txtMedida_MouseHover(sender As Object, e As EventArgs) Handles txtMedida.MouseHover
        TTMSG.SetToolTip(txtMedida, "Ingrese la medida del reactivo (litro, gramo, etc)")
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        TTMSG.SetToolTip(Button2, "Recarga los datos")
    End Sub
End Class