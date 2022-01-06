Imports MySql.Data.MySqlClient

Public Class Reactivos
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Dim comandos As New MySqlCommand

    Private Sub Reactivos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la Base de Datos")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnver_Click(sender As Object, e As EventArgs) Handles btnver.Click
        Try
            Dim consulta As String
            consulta = "SELECT * FROM inventario_reactivos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "inventario_reactivos")
            DataGridView1.DataSource = datos
            DataGridView1.DataMember = "inventario_reactivos"
        Catch ex As Exception
            MsgBox("No se pudo comunicar con la Base de Datos")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnañadir_Click(sender As Object, e As EventArgs) Handles btnañadir.Click
        Try
            comandos = New MySqlCommand("INSERT INTO `inventario_reactivos`(N_inventario,reactivo,grupo,formula,tipo,id_compra,cantidad_aprox,medida)" & Chr(13) &
                                        "VALUES(@N_inventario,@reactivo,@grupo,@formula,@tipo,@id_compra,@cantidad_aprox,@medida)", conexion)
            comandos.Parameters.AddWithValue("@N_inventario", txtninventario.Text)
            comandos.Parameters.AddWithValue("@reactivo", txtreactivo.Text)
            comandos.Parameters.AddWithValue("@grupo", txtgrupo.Text)
            comandos.Parameters.AddWithValue("@formula", txtformula.Text)
            comandos.Parameters.AddWithValue("@tipo", txttipo.Text)
            comandos.Parameters.AddWithValue("@id_compra", txtidcompra.Text)
            comandos.Parameters.AddWithValue("@cantidad_aprox", txtcantA.Text)
            comandos.Parameters.AddWithValue("@medida", txtmedida.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Ingresado Correctamente")
            txtninventario.Text = ""
            txtreactivo.Text = ""
            txtgrupo.Text = ""
            txtformula.Text = ""
            txttipo.Text = ""
            txtidcompra.Text = ""
            txtcantA.Text = ""
            txtmedida.Text = ""
        Catch ex As Exception
            MsgBox("No se pudo comunicar con la Base de Datos, no se añadio el reactivo")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim actualizar As String
            actualizar = "UPDATE inventario_reactivos SET N_inventario='" & txtninventario.Text & "', reactivo='" & txtreactivo.Text & "', grupo='" & txtgrupo.Text & "', formula='" & txtformula.Text & "', tipo='" & txttipo.Text & "', id_compra='" & txtidcompra.Text & "', cantidad_aprox='" & txtcantA.Text & "', medida='" & txtmedida.Text & "'WHERE N_inventario='" & txtninventario.Text & "'"
            comandos = New MySqlCommand(actualizar, conexion)
            comandos.ExecuteNonQuery()
            MsgBox("Reactivo Actualizada")
            txtninventario.Text = ""
            txtreactivo.Text = ""
            txtgrupo.Text = ""
            txtformula.Text = ""
            txttipo.Text = ""
            txtidcompra.Text = ""
            txtcantA.Text = ""
            txtmedida.Text = ""
        Catch ex As Exception
            MsgBox("No se pudo comunicar con la Base de Datos, no se pudo actualizar")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim eliminar As String
            Dim si As Byte

            si = MsgBox("¿Desea eliminar el reactivo: " & txtninventario.Text, vbYesNo, "Eliminar")
            If si = 6 Then
                eliminar = "DELETE FROM inventario_reactivos WHERE N_inventario='" & txtninventario.Text & "'"
                comandos = New MySqlCommand(eliminar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox(txtninventario.Text & " ha sido eliminado")
                txtninventario.Text = ""
                txtreactivo.Text = ""
                txtgrupo.Text = ""
                txtformula.Text = ""
                txttipo.Text = ""
                txtidcompra.Text = ""
                txtcantA.Text = ""
                txtmedida.Text = ""
            End If
        Catch ex As Exception
            MsgBox("No se pudo comunicar con la Base de Datos, no se pudo eliminar el reactivo")
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
        TTMSG.SetToolTip(btnver, "Mostrar todos los reactivos")
    End Sub

    Private Sub txtninventario_MouseHover(sender As Object, e As EventArgs) Handles txtninventario.MouseHover
        TTMSG.SetToolTip(txtninventario, "Ingresa el numero del reactivo")
    End Sub

    Private Sub txtreactivo_MouseHover(sender As Object, e As EventArgs) Handles txtreactivo.MouseHover
        TTMSG.SetToolTip(txtreactivo, "Ingresa reactivo")
    End Sub

    Private Sub txtgrupo_MouseHover(sender As Object, e As EventArgs) Handles txtgrupo.MouseHover
        TTMSG.SetToolTip(txtgrupo, "Ingresa el grupo del reactivo")
    End Sub

    Private Sub txtformula_MouseHover(sender As Object, e As EventArgs) Handles txtformula.MouseHover
        TTMSG.SetToolTip(txtformula, "Ingresa la formula del reactivo")
    End Sub

    Private Sub txttipo_MouseHover(sender As Object, e As EventArgs) Handles txttipo.MouseHover
        TTMSG.SetToolTip(txttipo, "Ingresa el tipo de reactivo")
    End Sub

    Private Sub txtidcompra_MouseHover(sender As Object, e As EventArgs) Handles txtidcompra.MouseHover
        TTMSG.SetToolTip(txtidcompra, "Ingresa el id de compra")
    End Sub

    Private Sub txtcantA_MouseHover(sender As Object, e As EventArgs) Handles txtcantA.MouseHover
        TTMSG.SetToolTip(txtcantA, "Ingresa una cantidad aproximada del reactivo")
    End Sub

    Private Sub txtmedida_MouseHover(sender As Object, e As EventArgs) Handles txtmedida.MouseHover
        TTMSG.SetToolTip(txtmedida, "Ingresa la medida del reactivo (litro, gramo, etc)")
    End Sub
End Class