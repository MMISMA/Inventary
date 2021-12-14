<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Lusuario = New System.Windows.Forms.Label()
        Me.Txtadmin = New System.Windows.Forms.TextBox()
        Me.Lcontra = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lusuario
        '
        Me.Lusuario.AutoSize = True
        Me.Lusuario.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lusuario.Location = New System.Drawing.Point(230, 122)
        Me.Lusuario.Name = "Lusuario"
        Me.Lusuario.Size = New System.Drawing.Size(86, 25)
        Me.Lusuario.TabIndex = 23
        Me.Lusuario.Text = "Usuario"
        '
        'Txtadmin
        '
        Me.Txtadmin.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtadmin.Location = New System.Drawing.Point(234, 281)
        Me.Txtadmin.Name = "Txtadmin"
        Me.Txtadmin.Size = New System.Drawing.Size(138, 29)
        Me.Txtadmin.TabIndex = 25
        Me.Txtadmin.UseSystemPasswordChar = True
        '
        'Lcontra
        '
        Me.Lcontra.AutoSize = True
        Me.Lcontra.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcontra.Location = New System.Drawing.Point(230, 186)
        Me.Lcontra.Name = "Lcontra"
        Me.Lcontra.Size = New System.Drawing.Size(117, 25)
        Me.Lcontra.TabIndex = 24
        Me.Lcontra.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Contraseña del administrador"
        '
        'txtusuario
        '
        Me.txtusuario.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(235, 150)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(138, 29)
        Me.txtusuario.TabIndex = 19
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(219, 401)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(171, 16)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Regresar a inicio de sesión"
        '
        'txtcontra
        '
        Me.txtcontra.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontra.Location = New System.Drawing.Point(235, 211)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(138, 29)
        Me.txtcontra.TabIndex = 20
        Me.txtcontra.UseSystemPasswordChar = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(235, 341)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 33)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Registrarse"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel.Controls.Add(Me.PictureBox1)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.Button1)
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(604, 59)
        Me.Panel.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 33)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ITCM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(543, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 34)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Registrar usuario"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Lusuario)
        Me.Controls.Add(Me.Txtadmin)
        Me.Controls.Add(Me.Lcontra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lusuario As Label
    Friend WithEvents Txtadmin As TextBox
    Friend WithEvents Lcontra As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
