Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Compra
    Dim comandos As New MySqlCommand()
    Dim conexion As New MySqlConnection

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            MsgBox("Conexion lograda")
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos", ex.Message)
        End Try
    End Sub

    Private Sub btnsubir_Click(sender As Object, e As EventArgs) Handles btnsubir.Click
        Try
            Dim opf As New OpenFileDialog
            opf.Filter = "Escoje una imagen(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

            If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
                Pfotos.Image = Image.FromFile(opf.FileName)
            End If
        Catch ex As Exception
            MsgBox("Error al subir la imagen")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim ms As New MemoryStream
            Pfotos.Image.Save(ms, Pfotos.Image.RawFormat)
            comandos = New MySqlCommand("INSERT INTO `compra`(id,fecha, info)" & Chr(13) &
                                        "VALUES (@id,@fecha,@info)", conexion)
            comandos.Parameters.AddWithValue("@id", txtid.Text)
            comandos.Parameters.AddWithValue("@fecha", txtfecha.Text)
            comandos.Parameters.Add("@info", MySqlDbType.Blob).Value = ms.ToArray()
            comandos.ExecuteNonQuery()
            MsgBox("Imagen ingresada correctamente")
        Catch ex As Exception
            MsgBox("No se ingreso la imagen ", ex.Message)
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
End Class