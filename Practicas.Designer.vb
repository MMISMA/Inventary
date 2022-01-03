<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Practicas
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
        Me.PanelMen = New System.Windows.Forms.Panel()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtinfo = New System.Windows.Forms.TextBox()
        Me.txtpractica = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CBseleccionarPractica = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TTMSG = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelMen.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMen
        '
        Me.PanelMen.Controls.Add(Me.btnActualizar)
        Me.PanelMen.Controls.Add(Me.btneliminar)
        Me.PanelMen.Controls.Add(Me.Label5)
        Me.PanelMen.Controls.Add(Me.Label4)
        Me.PanelMen.Controls.Add(Me.Label3)
        Me.PanelMen.Controls.Add(Me.txtinfo)
        Me.PanelMen.Controls.Add(Me.txtpractica)
        Me.PanelMen.Controls.Add(Me.txtid)
        Me.PanelMen.Controls.Add(Me.btnañadir)
        Me.PanelMen.Controls.Add(Me.Label2)
        Me.PanelMen.Controls.Add(Me.Button1)
        Me.PanelMen.Controls.Add(Me.DataGridView1)
        Me.PanelMen.Controls.Add(Me.CBseleccionarPractica)
        Me.PanelMen.Controls.Add(Me.Label1)
        Me.PanelMen.Location = New System.Drawing.Point(0, 0)
        Me.PanelMen.Name = "PanelMen"
        Me.PanelMen.Size = New System.Drawing.Size(466, 458)
        Me.PanelMen.TabIndex = 0
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(258, 413)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(110, 32)
        Me.btnActualizar.TabIndex = 37
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.Bisque
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(374, 413)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(77, 33)
        Me.btneliminar.TabIndex = 36
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Info de la Practica"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nombre de la practica"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Id"
        '
        'txtinfo
        '
        Me.txtinfo.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinfo.Location = New System.Drawing.Point(258, 318)
        Me.txtinfo.Multiline = True
        Me.txtinfo.Name = "txtinfo"
        Me.txtinfo.Size = New System.Drawing.Size(152, 53)
        Me.txtinfo.TabIndex = 25
        '
        'txtpractica
        '
        Me.txtpractica.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpractica.Location = New System.Drawing.Point(258, 257)
        Me.txtpractica.Multiline = True
        Me.txtpractica.Name = "txtpractica"
        Me.txtpractica.Size = New System.Drawing.Size(152, 55)
        Me.txtpractica.TabIndex = 24
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(258, 222)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(45, 29)
        Me.txtid.TabIndex = 23
        '
        'btnañadir
        '
        Me.btnañadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnañadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnañadir.FlatAppearance.BorderSize = 0
        Me.btnañadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnañadir.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnañadir.Location = New System.Drawing.Point(167, 414)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(85, 32)
        Me.btnañadir.TabIndex = 22
        Me.btnañadir.Text = "Añadir"
        Me.btnañadir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Añadir o eliminar Practica"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(316, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(425, 67)
        Me.DataGridView1.TabIndex = 17
        '
        'CBseleccionarPractica
        '
        Me.CBseleccionarPractica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBseleccionarPractica.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBseleccionarPractica.FormattingEnabled = True
        Me.CBseleccionarPractica.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CBseleccionarPractica.Location = New System.Drawing.Point(257, 33)
        Me.CBseleccionarPractica.Name = "CBseleccionarPractica"
        Me.CBseleccionarPractica.Size = New System.Drawing.Size(43, 31)
        Me.CBseleccionarPractica.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ver Practica"
        '
        'Practicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(466, 458)
        Me.Controls.Add(Me.PanelMen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Practicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retirar"
        Me.PanelMen.ResumeLayout(False)
        Me.PanelMen.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMen As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CBseleccionarPractica As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtinfo As TextBox
    Friend WithEvents txtpractica As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents btnañadir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents TTMSG As ToolTip
    Friend WithEvents btnActualizar As Button
End Class
