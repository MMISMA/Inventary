﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AyE_Practicas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AyE_Practicas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtinfo = New System.Windows.Forms.TextBox()
        Me.txtpractica = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TTMSG = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 25)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Información de la Practica"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Nombre de la practica"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 25)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "N. de practica"
        '
        'txtinfo
        '
        Me.txtinfo.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinfo.Location = New System.Drawing.Point(268, 282)
        Me.txtinfo.Multiline = True
        Me.txtinfo.Name = "txtinfo"
        Me.txtinfo.Size = New System.Drawing.Size(152, 93)
        Me.txtinfo.TabIndex = 39
        '
        'txtpractica
        '
        Me.txtpractica.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpractica.Location = New System.Drawing.Point(270, 166)
        Me.txtpractica.Multiline = True
        Me.txtpractica.Name = "txtpractica"
        Me.txtpractica.Size = New System.Drawing.Size(152, 96)
        Me.txtpractica.TabIndex = 38
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(270, 131)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(45, 29)
        Me.txtid.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(108, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(258, 25)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Añadir o eliminar Practica"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(173, 413)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(110, 32)
        Me.btnActualizar.TabIndex = 45
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.Bisque
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(289, 413)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(77, 33)
        Me.btneliminar.TabIndex = 44
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btnañadir
        '
        Me.btnañadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnañadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnañadir.FlatAppearance.BorderSize = 0
        Me.btnañadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnañadir.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnañadir.Location = New System.Drawing.Point(82, 414)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(85, 32)
        Me.btnañadir.TabIndex = 43
        Me.btnañadir.Text = "Añadir"
        Me.btnañadir.UseVisualStyleBackColor = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel.Controls.Add(Me.PictureBox1)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.Button1)
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(466, 59)
        Me.Panel.TabIndex = 46
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ITCM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(409, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AyE_Practicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(466, 458)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnañadir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtinfo)
        Me.Controls.Add(Me.txtpractica)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AyE_Practicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AyE_Practicas"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtinfo As TextBox
    Friend WithEvents txtpractica As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnañadir As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TTMSG As ToolTip
End Class
