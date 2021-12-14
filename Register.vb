Public Class Register
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Txtadmin.Text = "1234" Then
            Me.Hide()
            MsgBox("Registrado correctamente", vbInformation)
            Inicio.Show()
        Else
            MsgBox("Se necesita la contraseña del admin", vbInformation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Close()
    End Sub
End Class