<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historicovac
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historicovac))
        Me.Gridempleados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fecharegreso = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fechasalida = New System.Windows.Forms.DateTimePicker()
        Me.motivo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sifecharegreso = New System.Windows.Forms.CheckBox()
        Me.sifechasalida = New System.Windows.Forms.CheckBox()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.activar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.guardar = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Gridempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gridempleados
        '
        Me.Gridempleados.AllowUserToAddRows = False
        Me.Gridempleados.AllowUserToResizeRows = False
        Me.Gridempleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gridempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gridempleados.GridColor = System.Drawing.SystemColors.Control
        Me.Gridempleados.Location = New System.Drawing.Point(12, 144)
        Me.Gridempleados.MultiSelect = False
        Me.Gridempleados.Name = "Gridempleados"
        Me.Gridempleados.ReadOnly = True
        Me.Gridempleados.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Gridempleados.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Gridempleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Gridempleados.Size = New System.Drawing.Size(929, 466)
        Me.Gridempleados.TabIndex = 49
        Me.Gridempleados.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 25)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Historial de Vacaciones"
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(17, 50)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(99, 26)
        Me.TxtNom.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nomina"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 20)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Hasta"
        '
        'fecharegreso
        '
        Me.fecharegreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecharegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharegreso.Location = New System.Drawing.Point(72, 58)
        Me.fecharegreso.Name = "fecharegreso"
        Me.fecharegreso.Size = New System.Drawing.Size(115, 26)
        Me.fecharegreso.TabIndex = 76
        Me.fecharegreso.Value = New Date(2013, 4, 8, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 20)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Desde"
        '
        'fechasalida
        '
        Me.fechasalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechasalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechasalida.Location = New System.Drawing.Point(72, 25)
        Me.fechasalida.Name = "fechasalida"
        Me.fechasalida.Size = New System.Drawing.Size(115, 26)
        Me.fechasalida.TabIndex = 74
        Me.fechasalida.Value = New Date(2013, 4, 8, 0, 0, 0, 0)
        '
        'motivo
        '
        Me.motivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.motivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.motivo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motivo.FormattingEnabled = True
        Me.motivo.Location = New System.Drawing.Point(323, 43)
        Me.motivo.MaxDropDownItems = 5
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(65, 26)
        Me.motivo.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(333, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Año "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.sifecharegreso)
        Me.GroupBox1.Controls.Add(Me.sifechasalida)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.motivo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.fechasalida)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.fecharegreso)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(266, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 97)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(436, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Dias Disponibles"
        Me.Label8.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(394, 45)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(203, 22)
        Me.CheckBox1.TabIndex = 85
        Me.CheckBox1.Text = "Sum Usados en el periodo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(436, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 18)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Dias Disponibles"
        '
        'sifecharegreso
        '
        Me.sifecharegreso.AutoSize = True
        Me.sifecharegreso.Location = New System.Drawing.Point(207, 56)
        Me.sifecharegreso.Name = "sifecharegreso"
        Me.sifecharegreso.Size = New System.Drawing.Size(92, 22)
        Me.sifecharegreso.TabIndex = 82
        Me.sifecharegreso.Text = "Fecha Fin"
        Me.sifecharegreso.UseVisualStyleBackColor = True
        '
        'sifechasalida
        '
        Me.sifechasalida.AutoSize = True
        Me.sifechasalida.Location = New System.Drawing.Point(207, 23)
        Me.sifechasalida.Name = "sifechasalida"
        Me.sifechasalida.Size = New System.Drawing.Size(106, 22)
        Me.sifechasalida.TabIndex = 81
        Me.sifechasalida.Text = "Fecha Inicio"
        Me.sifechasalida.UseVisualStyleBackColor = True
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.Location = New System.Drawing.Point(14, 79)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(13, 13)
        Me.mensaje.TabIndex = 81
        Me.mensaje.Text = "s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "s"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "s"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(848, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 30)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "CERRAR"
        Me.ToolTip2.SetToolTip(Me.Button2, "Cerrar Ventana")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Edit
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(663, 105)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 35)
        Me.Button4.TabIndex = 89
        Me.ToolTip1.SetToolTip(Me.Button4, "Exportar Datos a Pdf")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.table_green_48
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(521, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 35)
        Me.Button3.TabIndex = 88
        Me.ToolTip1.SetToolTip(Me.Button3, "Exportar Datos a Excel")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'activar
        '
        Me.activar.AccessibleDescription = ""
        Me.activar.BackgroundImage = CType(resources.GetObject("activar.BackgroundImage"), System.Drawing.Image)
        Me.activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.activar.Location = New System.Drawing.Point(254, 105)
        Me.activar.Name = "activar"
        Me.activar.Size = New System.Drawing.Size(45, 36)
        Me.activar.TabIndex = 87
        Me.activar.TabStop = False
        Me.activar.Tag = ""
        Me.ToolTip2.SetToolTip(Me.activar, "Eliminar Registro Seleccionado")
        Me.activar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.buscar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(151, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 43)
        Me.Button1.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.Button1, "Ejecutar Consulta")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(459, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "EXCEL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(588, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Ver PDF"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        '
        'Historicovac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(953, 622)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.activar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Gridempleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Historicovac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historico de permisos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Gridempleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gridempleados As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents fecharegreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fechasalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents sifecharegreso As System.Windows.Forms.CheckBox
    Friend WithEvents sifechasalida As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents activar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
End Class
