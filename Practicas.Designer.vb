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
        Me.btnrecargar = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnverpractica = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CBseleccionarPractica = New System.Windows.Forms.ComboBox()
        Me.TTMSG = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelMen.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMen
        '
        Me.PanelMen.Controls.Add(Me.btnrecargar)
        Me.PanelMen.Controls.Add(Me.LinkLabel2)
        Me.PanelMen.Controls.Add(Me.LinkLabel1)
        Me.PanelMen.Controls.Add(Me.btnListar)
        Me.PanelMen.Controls.Add(Me.btnverpractica)
        Me.PanelMen.Controls.Add(Me.DataGridView1)
        Me.PanelMen.Controls.Add(Me.CBseleccionarPractica)
        Me.PanelMen.Location = New System.Drawing.Point(0, 0)
        Me.PanelMen.Name = "PanelMen"
        Me.PanelMen.Size = New System.Drawing.Size(466, 458)
        Me.PanelMen.TabIndex = 0
        '
        'btnrecargar
        '
        Me.btnrecargar.BackColor = System.Drawing.Color.Transparent
        Me.btnrecargar.BackgroundImage = Global.Inventary.My.Resources.Resources.refresh
        Me.btnrecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrecargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrecargar.FlatAppearance.BorderSize = 0
        Me.btnrecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrecargar.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecargar.Location = New System.Drawing.Point(423, 32)
        Me.btnrecargar.Name = "btnrecargar"
        Me.btnrecargar.Size = New System.Drawing.Size(24, 25)
        Me.btnrecargar.TabIndex = 43
        Me.btnrecargar.UseVisualStyleBackColor = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(198, 426)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(240, 23)
        Me.LinkLabel2.TabIndex = 42
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Añadir reactivos a practica"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(29, 426)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 23)
        Me.LinkLabel1.TabIndex = 41
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Añadir practica"
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnListar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListar.FlatAppearance.BorderSize = 0
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(260, 49)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(152, 32)
        Me.btnListar.TabIndex = 38
        Me.btnListar.Text = "Listar reactivos"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnverpractica
        '
        Me.btnverpractica.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnverpractica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnverpractica.FlatAppearance.BorderSize = 0
        Me.btnverpractica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverpractica.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverpractica.Location = New System.Drawing.Point(260, 12)
        Me.btnverpractica.Name = "btnverpractica"
        Me.btnverpractica.Size = New System.Drawing.Size(152, 32)
        Me.btnverpractica.TabIndex = 19
        Me.btnverpractica.Text = "Ver practica"
        Me.btnverpractica.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(425, 302)
        Me.DataGridView1.TabIndex = 17
        '
        'CBseleccionarPractica
        '
        Me.CBseleccionarPractica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBseleccionarPractica.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBseleccionarPractica.FormattingEnabled = True
        Me.CBseleccionarPractica.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CBseleccionarPractica.Location = New System.Drawing.Point(22, 32)
        Me.CBseleccionarPractica.Name = "CBseleccionarPractica"
        Me.CBseleccionarPractica.Size = New System.Drawing.Size(232, 26)
        Me.CBseleccionarPractica.TabIndex = 16
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
    Friend WithEvents CBseleccionarPractica As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnverpractica As Button
    Friend WithEvents TTMSG As ToolTip
    Friend WithEvents btnListar As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnrecargar As Button
End Class
