Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Compra
    Dim comandos As New MySqlCommand
    Dim conexion As New MySqlConnection

    Dim filefoto As String

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"

        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos", ex.Message)
        End Try
    End Sub

    Private Sub btnsubir_Click(sender As Object, e As EventArgs) Handles btnsubir.Click
        Try
            OFDcargar.Filter = "PNG |*.png|GIF |*.gif|JPG |*.jpg"
            OFDcargar.FileName = "Cargar Foto"
            OFDcargar.Title = "Subir archivo"

            If OFDcargar.ShowDialog = Windows.Forms.DialogResult.OK Then
                filefoto = OFDcargar.FileName
                Pfotos.Image = System.Drawing.Image.FromFile(filefoto)
            End If
        Catch ex As Exception
            MsgBox("Error al subir la foto")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim sql As String
            Dim ft As MemoryStream = New MemoryStream()
            Dim fs As FileStream = New FileStream(filefoto, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            ft.SetLength(fs.Length)
            fs.Read(ft.GetBuffer(), 0, CInt(fs.Length))
            Dim imgcon As Byte() = ft.GetBuffer()
            fs.Close()

            conexion.Open()
            sql = "INSERT INTO compra(id,fecha,imagen) VALUES (@id,@fecha,@imagen)"
            comandos = New MySqlCommand(sql, conexion)
            comandos.Parameters.AddWithValue("@id", txtid.Text)
            comandos.Parameters.AddWithValue("@fecha", txtfecha.Text)
            comandos.Parameters.Add("@imagen", MySqlDbType.VarBinary).Value = imgcon

            comandos.ExecuteNonQuery()
            conexion.Close()
            Pfotos.Image = Nothing
            MsgBox("Imagen guardada correctamente")
            txtid.Text = ""
            txtfecha.Text = ""
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AyECompras.Show()
    End Sub

    Private Sub btnGuardar_MouseHover(sender As Object, e As EventArgs) Handles btnGuardar.MouseHover
        TTMSG.SetToolTip(btnGuardar, "Guardar la imagen en la Base de Datos")
    End Sub

    Private Sub btnsubir_MouseHover(sender As Object, e As EventArgs) Handles btnsubir.MouseHover
        TTMSG.SetToolTip(btnsubir, "Subir una imagen")
    End Sub

    Private Sub txtfecha_MouseHover(sender As Object, e As EventArgs) Handles txtfecha.MouseHover
        TTMSG.SetToolTip(txtfecha, "Ingrese la fecha del recibo de la compra")
    End Sub

    Private Sub txtid_MouseHover(sender As Object, e As EventArgs) Handles txtid.MouseHover
        TTMSG.SetToolTip(txtid, "Ingrese el numero de recibo")
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseHover
        TTMSG.SetToolTip(LinkLabel1, "Ir a ver las compras")
    End Sub
End Class