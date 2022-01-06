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
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnver_Click(sender As Object, e As EventArgs) Handles btnver.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM inventario_l_pesados"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "inventario_l_pesados")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "inventario_l_pesados"
        Catch ex As Exception
            MsgBox("No se pudo comuncar con a la base de datos")
            MsgBox(ex.Message)
        End Try

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
            MsgBox("Datos no validos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim actualizar As String
            actualizar = "UPDATE inventario_l_pesados SET nombre='" & txtnombre.Text & "', marca='" & txtmarca.Text & "', modelo='" & txtmodelo.Text & "', num_serie='" & txtnserie.Text & "', uso='" & txtuso.Text & "', clave_patrimonial='" & txtcpatrimonial.Text & "', guia_y_manual='" & txtguiaymanual.Text & "', observaciones='" & txtobservaciones.Text & "', laboratorio='" & txtlab.Text & "', antiguedad='" & txtantiguedad.Text & "',tipo='" & txttipo.Text & "'WHERE codigo='" & txtcodigo.Text & "'"
            comandos = New MySqlCommand(actualizar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Actualizada")
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
            MsgBox("Datos no validos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
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
        Catch ex As Exception
            MsgBox("Dato no valido")
            MsgBox(ex.Message)
        End Try
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

    Private Sub btnver_MouseHover(sender As Object, e As EventArgs) Handles btnver.MouseHover
        TTMSG.SetToolTip(btnver, "Ver todo dentro de Pesados")
    End Sub
    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        TTMSG.SetToolTip(txtcodigo, "Ingresa el codigo")
    End Sub

    Private Sub txtantiguedad_MouseHover(sender As Object, e As EventArgs) Handles txtantiguedad.MouseHover
        TTMSG.SetToolTip(txtantiguedad, "Ingresa la antiguedad")
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        TTMSG.SetToolTip(txtnombre, "Ingresa el nombre")
    End Sub

    Private Sub txtmodelo_MouseHover(sender As Object, e As EventArgs) Handles txtmodelo.MouseHover
        TTMSG.SetToolTip(txtmodelo, "Ingresa el Modelo")
    End Sub

    Private Sub txtnserie_MouseHover(sender As Object, e As EventArgs) Handles txtnserie.MouseHover
        TTMSG.SetToolTip(txtnserie, "Ingresa el Numero de Serie")
    End Sub

    Private Sub txtuso_MouseHover(sender As Object, e As EventArgs) Handles txtuso.MouseHover
        TTMSG.SetToolTip(txtuso, "Ingresa el Uso")
    End Sub

    Private Sub txtcpatrimonial_MouseHover(sender As Object, e As EventArgs) Handles txtcpatrimonial.MouseHover
        TTMSG.SetToolTip(txtcpatrimonial, "Ingresa la Clave Patrimonial")
    End Sub

    Private Sub txtguiaymanual_MouseHover(sender As Object, e As EventArgs) Handles txtguiaymanual.MouseHover
        TTMSG.SetToolTip(txtguiaymanual, "Ingresa la guia y/o manual")
    End Sub

    Private Sub txtobservaciones_MouseHover(sender As Object, e As EventArgs) Handles txtobservaciones.MouseHover
        TTMSG.SetToolTip(txtobservaciones, "Ingresa las observaciones")
    End Sub

    Private Sub txtlab_MouseHover(sender As Object, e As EventArgs) Handles txtlab.MouseHover
        TTMSG.SetToolTip(txtlab, "Ingresa el laboratorio")
    End Sub

    Private Sub txttipo_MouseHover(sender As Object, e As EventArgs) Handles txttipo.MouseHover
        TTMSG.SetToolTip(txttipo, "Ingresa el tipo")
    End Sub
End Class