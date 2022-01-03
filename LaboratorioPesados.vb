Imports MySql.Data.MySqlClient

Public Class LaboratorioPesados
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As New MySqlCommand

    Private Sub LaboratorioPesados_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            MsgBox("Conexion lograda")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnver_Click(sender As Object, e As EventArgs) Handles btnver.Click
        Dim consulta As String
        consulta = "SELECT * FROM inventario_l_pesados"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "inventario_l_pesados")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "inventario_l_pesados"
    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click
        Try
            comandos = New MySqlCommand("INSERT INTO `inventario_l_pesados`(codigo,nombre,marca,modelo,num_serie,uso,clave_patrimonial,guia_y_manual,observaciones,laboratorio,antiguedad,tipo)" & Chr(13) &
                                        "VALUES(@codigo,@nombre,@marca,@modelo,@num_serie,@uso,@clave_patrimonial,@guia_y_manual,@observaciones,@laboratorio,@antiguedad,@tipo)", conexion)
            comandos.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            comandos.Parameters.AddWithValue("@nombre", txtnombre.Text)
            comandos.Parameters.AddWithValue("@marca", txtmarca.Text)
            comandos.Parameters.AddWithValue("@modelo", txtmodelo.Text)
            comandos.Parameters.AddWithValue("@num_serie", txtnserie.Text)
            comandos.Parameters.AddWithValue("@uso", txtuso.Text)
            comandos.Parameters.AddWithValue("@clave_patrimonial", txtcpatrimonial.Text)
            comandos.Parameters.AddWithValue("@guia_y_manual", txtguiaymanual.Text)
            comandos.Parameters.AddWithValue("@observaciones", txtobservaciones.Text)
            comandos.Parameters.AddWithValue("@laboratorio", txtlab.Text)
            comandos.Parameters.AddWithValue("@antiguedad", txtantiguedad.Text)
            comandos.Parameters.AddWithValue("@tipo", txttipo.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Ingresado Correctamente")
            txtcodigo.Text = ""
            txtnombre.Text = ""
            txtmarca.Text = ""
            txtmodelo.Text = ""
            txtnserie.Text = ""
            txtuso.Text = ""
            txtcpatrimonial.Text = ""
            txtguiaymanual.Text = ""
            txtobservaciones.Text = ""
            txtlab.Text = ""
            txtantiguedad.Text = ""
            txttipo.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim actualizar As String
        actualizar = "UPDATE inventario_l_pesados SET nombre='" & txtnombre.Text & "', marca='" & txtmarca.Text & "', modelo='" & txtmodelo.Text & "', num_serie='" & txtnserie.Text & "', uso='" & txtuso.Text & "', clave_patrimonial='" & txtcpatrimonial.Text & "', guia_y_manual='" & txtguiaymanual.Text & "', observaciones='" & txtobservaciones.Text & "', laboratorio='" & txtlab.Text & "', antiguedad='" & txtantiguedad.Text & "',tipo='" & txttipo.Text & "'WHERE codigo='" & txtcodigo.Text & "'"
        comandos = New MySqlCommand(actualizar, conexion)
        comandos.ExecuteNonQuery()
        MsgBox("Reactivo Actualizada")
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim eliminar As String
        Dim si As Byte

        si = MsgBox("¿Desea eliminar: " & txtcodigo.Text, vbYesNo, "Eliminar")
        If si = 6 Then
            eliminar = "DELETE FROM inventario_l_pesados WHERE codigo='" & txtcodigo.Text & "'"
            comandos = New MySqlCommand(eliminar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox(txtcodigo.Text & " ha sido eliminado")
            txtnombre.Text = ""
            txtmarca.Text = ""
            txtmodelo.Text = ""
            txtnserie.Text = ""
            txtuso.Text = ""
            txtcpatrimonial.Text = ""
            txtguiaymanual.Text = ""
            txtobservaciones.Text = ""
            txtlab.Text = ""
            txtantiguedad.Text = ""
            txttipo.Text = ""
        End If
    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover
        TTMSG.SetToolTip(btnActualizar, "Ingresa todos los datos a actualizar")
    End Sub

    Private Sub btnañadir_MouseHover(sender As Object, e As EventArgs) Handles btnañadir.MouseHover
        TTMSG.SetToolTip(btnañadir, "Ingresa todos los datos a añadir")
    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Ingresa el codigo a Eliminar")
    End Sub
End Class