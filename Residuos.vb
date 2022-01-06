Imports MySql.Data.MySqlClient

Public Class Residuos

    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As New MySqlCommand

    Private Sub Residuos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click
        Try
            comandos = New MySqlCommand("INSERT INTO `inventario_residuos`(nombre,cantidad,contenedor,fecha_de_generacion,tipo,medida)" & Chr(13) &
                                        "VALUES(@nombre,@cantidad,@contenedor,@fecha_de_generacion,@tipo,@medida)", conexion)
            comandos.Parameters.AddWithValue("@nombre", txtnombre.Text)
            comandos.Parameters.AddWithValue("@cantidad", txtcantidad.Text)
            comandos.Parameters.AddWithValue("@contenedor", txtcontenedor.Text)
            comandos.Parameters.AddWithValue("@fecha_de_generacion", txtfecha.Text)
            comandos.Parameters.AddWithValue("@tipo", txttipo.Text)
            comandos.Parameters.AddWithValue("@medida", txtmedida.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Ingresado Correctamente")
            txtnombre.Text = ""
            txtcantidad.Text = ""
            txtcontenedor.Text = ""
            txtfecha.Text = ""
            txttipo.Text = ""
            txtmedida.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim actualizar As String
            actualizar = "UPDATE inventario_residuos SET nombre='" & txtnombre.Text & "', cantidad='" & txtcantidad.Text & "', contenedor='" & txtcontenedor.Text & "', fecha_de_generacion='" & txtfecha.Text & "', tipo='" & txttipo.Text & "', medida='" & txtmedida.Text & "'WHERE nombre='" & txtnombre.Text & "'"
            comandos = New MySqlCommand(actualizar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Residuo Actualizado")
            txtnombre.Text = ""
            txtcantidad.Text = ""
            txtcontenedor.Text = ""
            txtfecha.Text = ""
            txttipo.Text = ""
            txtmedida.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim eliminar As String
            Dim si As Byte

            si = MsgBox("¿Desea eliminar la residuo: " & txtnombre.Text, vbYesNo, "Eliminar")
            If si = 6 Then
                eliminar = "DELETE FROM inventario_residuos WHERE nombre='" & txtnombre.Text & "'"
                comandos = New MySqlCommand(eliminar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox(txtnombre.Text & " ha sido eliminado")
                txtcantidad.Text = ""
                txtcontenedor.Text = ""
                txtfecha.Text = ""
                txttipo.Text = ""
                txtmedida.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnver_Click(sender As Object, e As EventArgs) Handles btnver.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM inventario_residuos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "inventario_residuos")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "inventario_residuos"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_MouseHover(sender As Object, e As EventArgs) Handles btnActualizar.MouseHover
        TTMSG.SetToolTip(btnActualizar, "Ingresa todos los datos del residuo a actualizar")
    End Sub

    Private Sub btnañadir_MouseHover(sender As Object, e As EventArgs) Handles btnañadir.MouseHover
        TTMSG.SetToolTip(btnañadir, "Ingresa todos los datos del residuo a añadir")
    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        TTMSG.SetToolTip(btneliminar, "Ingresa el nombre del residuo a Eliminar")
    End Sub
    Private Sub btnver_MouseHover(sender As Object, e As EventArgs) Handles btnver.MouseHover
        TTMSG.SetToolTip(btnver, "Mostrar todos los residuos")
    End Sub

    Private Sub txtfecha_MouseHover(sender As Object, e As EventArgs) Handles txtfecha.MouseHover
        TTMSG.SetToolTip(btnActualizar, "Ingrese la fecha con el formato YYYY/MM/DD")
    End Sub

    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        TTMSG.SetToolTip(txtcantidad, "Ingresa la cantidad del residuo")
    End Sub

    Private Sub txtcontenedor_MouseHover(sender As Object, e As EventArgs) Handles txtcontenedor.MouseHover
        TTMSG.SetToolTip(txtcontenedor, "Ingresa el contenedor del residuo")
    End Sub

    Private Sub txtmedida_MouseHover(sender As Object, e As EventArgs) Handles txtmedida.MouseHover
        TTMSG.SetToolTip(txtmedida, "Ingresa la medida del residuo (litro, gramo, etc)")
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        TTMSG.SetToolTip(txtnombre, "Ingresa el nombre del residuo")
    End Sub

    Private Sub txttipo_MouseHover(sender As Object, e As EventArgs) Handles txttipo.MouseHover
        TTMSG.SetToolTip(txttipo, "Ingresa el tipo de residuo")
    End Sub
End Class