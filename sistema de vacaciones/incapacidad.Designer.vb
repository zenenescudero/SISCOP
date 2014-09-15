<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incapacidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(incapacidad))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nomina = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gridpermisos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.segurosocial = New System.Windows.Forms.TextBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.notas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fecharegreso = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fechasalida = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.empleado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Gridpermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(391, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nombre"
        '
        'nomina
        '
        Me.nomina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomina.Location = New System.Drawing.Point(25, 70)
        Me.nomina.Name = "nomina"
        Me.nomina.Size = New System.Drawing.Size(104, 26)
        Me.nomina.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "No. Nomina"
        '
        'Gridpermisos
        '
        Me.Gridpermisos.AllowUserToAddRows = False
        Me.Gridpermisos.AllowUserToResizeRows = False
        Me.Gridpermisos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gridpermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gridpermisos.GridColor = System.Drawing.SystemColors.Control
        Me.Gridpermisos.Location = New System.Drawing.Point(25, 133)
        Me.Gridpermisos.MultiSelect = False
        Me.Gridpermisos.Name = "Gridpermisos"
        Me.Gridpermisos.ReadOnly = True
        Me.Gridpermisos.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Gridpermisos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Gridpermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Gridpermisos.Size = New System.Drawing.Size(934, 148)
        Me.Gridpermisos.TabIndex = 48
        Me.Gridpermisos.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.segurosocial)
        Me.Panel1.Controls.Add(Me.tipo)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.notas)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.dias)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.fecharegreso)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.fechasalida)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(25, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 209)
        Me.Panel1.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Seguro Social"
        '
        'segurosocial
        '
        Me.segurosocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.segurosocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segurosocial.Location = New System.Drawing.Point(147, 61)
        Me.segurosocial.Name = "segurosocial"
        Me.segurosocial.Size = New System.Drawing.Size(104, 26)
        Me.segurosocial.TabIndex = 81
        '
        'tipo
        '
        Me.tipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.FormattingEnabled = True
        Me.tipo.Items.AddRange(New Object() {"INCAPACIDAD POR ENFERMEDAD GENERAL", "INCAPACIDAD POR MATERNIDAD", "INCAPACIDAD POR RIESGO DE TRABAJO"})
        Me.tipo.Location = New System.Drawing.Point(125, 101)
        Me.tipo.MaxDropDownItems = 5
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(466, 26)
        Me.tipo.TabIndex = 80
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 20)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Nota Adicional"
        '
        'notas
        '
        Me.notas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.notas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notas.Location = New System.Drawing.Point(125, 148)
        Me.notas.Multiline = True
        Me.notas.Name = "notas"
        Me.notas.Size = New System.Drawing.Size(466, 50)
        Me.notas.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(257, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 20)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "No. Dias"
        '
        'dias
        '
        Me.dias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.Location = New System.Drawing.Point(332, 24)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(99, 26)
        Me.dias.TabIndex = 74
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(446, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Fecha Fin"
        '
        'fecharegreso
        '
        Me.fecharegreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecharegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharegreso.Location = New System.Drawing.Point(532, 23)
        Me.fecharegreso.Name = "fecharegreso"
        Me.fecharegreso.Size = New System.Drawing.Size(128, 26)
        Me.fecharegreso.TabIndex = 72
        Me.fecharegreso.Value = New Date(2013, 3, 8, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 20)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Fecha Inicio"
        '
        'fechasalida
        '
        Me.fechasalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechasalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechasalida.Location = New System.Drawing.Point(110, 19)
        Me.fechasalida.Name = "fechasalida"
        Me.fechasalida.Size = New System.Drawing.Size(128, 26)
        Me.fechasalida.TabIndex = 70
        Me.fechasalida.Value = New Date(2013, 3, 8, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(55, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Motivo"
        '
        'empleado
        '
        Me.empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.empleado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empleado.FormattingEnabled = True
        Me.empleado.Location = New System.Drawing.Point(156, 71)
        Me.empleado.MaxDropDownItems = 5
        Me.empleado.Name = "empleado"
        Me.empleado.Size = New System.Drawing.Size(626, 26)
        Me.empleado.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 25)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Registro De Incapacidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Historial de Incapacidad"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(510, 502)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 61)
        Me.Button2.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.Button2, "Cancelar Registro")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Checked
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(408, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 61)
        Me.Button1.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.Button1, "Registrar Incapacidad")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'incapacidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1009, 575)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.empleado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gridpermisos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nomina)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "incapacidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos_Salida"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Gridpermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nomina As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gridpermisos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents empleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dias As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents fecharegreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fechasalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents notas As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents segurosocial As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
