Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Inicio
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

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

    Private Sub UC_Tick(sender As Object, e As EventArgs) Handles UC.Tick
        Label2.Text += 1
        Lcontra.Top -= 3
        Lusuario.Top -= 3
        If Label2.Text = 8 Then
            UC.Stop()
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        If Label2.Text = "0" Then
            UC.Start()
            txtcontra.Text = ""
            txtusuario.Text = ""

            Button2.BackgroundImage = My.Resources.close
            txtcontra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtcontra_TextChanged(sender As Object, e As EventArgs) Handles txtcontra.TextChanged
        If Label2.Text = "0" Then
            UC.Start()
            txtcontra.Text = ""
            txtusuario.Text = ""

            Button2.BackgroundImage = My.Resources.close
            txtcontra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If txtcontra.UseSystemPasswordChar = False Then
            Button2.BackgroundImage = My.Resources.close
            txtcontra.UseSystemPasswordChar = True
        Else
            Button2.BackgroundImage = My.Resources.open
            txtcontra.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta As String
        Dim lista As Byte
        If txtusuario.Text <> "" And txtcontra.Text <> "" Then
            consulta = "SELECT * FROM usuario Where usuario =' " & txtusuario.Text & "' and contraseña = '" & txtcontra.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Registros")
            lista = datos.Tables("Registros").Rows.Count
        End If
        If lista <> 0 Then
            MenuI.Show()
            MsgBox("Bienvenido", vbInformation)
            Me.Hide()
        Else
            MsgBox("Intente de nuevo")
        End If

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server= www.db4free.net; user=mmismael; password=12345678;database=inventary"
            conexion.Open()
            MsgBox("Conexion lograda")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try
        '    Dim conexion As New MySqlConnectionStringBuilder()
        '    conexion.Server = "localhost"
        '    conexion.UserID = "root"
        '    conexion.Password = ""
        '    conexion.Database = "inventarios"

        '    Dim con As New MySqlConnection(conexion.ToString())
        '    con.Open()
        '    MsgBox("La conexion se realizo")
        'Catch ex As Exception
        '    MsgBox("No se pudo conectar " & ex.Message)
        'End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class
