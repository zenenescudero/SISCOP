<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permisos_Salida
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Permisos_Salida))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nomina = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gridpermisos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.duracion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fecharegreso = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fechasalida = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.motivo = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.de = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.depto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fechapermiso = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jefeinmediato = New System.Windows.Forms.ComboBox()
        Me.gerente = New System.Windows.Forms.ComboBox()
        Me.subgerente = New System.Windows.Forms.ComboBox()
        Me.empleado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Gridpermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(391, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nombre"
        '
        'nomina
        '
        Me.nomina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomina.Location = New System.Drawing.Point(25, 60)
        Me.nomina.Name = "nomina"
        Me.nomina.Size = New System.Drawing.Size(104, 26)
        Me.nomina.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 37)
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
        Me.Gridpermisos.Location = New System.Drawing.Point(25, 112)
        Me.Gridpermisos.MultiSelect = False
        Me.Gridpermisos.Name = "Gridpermisos"
        Me.Gridpermisos.ReadOnly = True
        Me.Gridpermisos.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Gridpermisos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Gridpermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Gridpermisos.Size = New System.Drawing.Size(962, 170)
        Me.Gridpermisos.TabIndex = 48
        Me.Gridpermisos.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.duracion)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.dias)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.fecharegreso)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.fechasalida)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.motivo)
        Me.Panel1.Controls.Add(Me.a)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.de)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.depto)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.fechapermiso)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.jefeinmediato)
        Me.Panel1.Controls.Add(Me.gerente)
        Me.Panel1.Controls.Add(Me.subgerente)
        Me.Panel1.Location = New System.Drawing.Point(25, 288)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 256)
        Me.Panel1.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 199)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 20)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Nota Adicional"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(125, 199)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(534, 50)
        Me.TextBox2.TabIndex = 78
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(793, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 20)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Duracion"
        '
        'duracion
        '
        Me.duracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duracion.Location = New System.Drawing.Point(786, 76)
        Me.duracion.Name = "duracion"
        Me.duracion.Size = New System.Drawing.Size(156, 26)
        Me.duracion.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(673, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 20)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "No. Dias"
        Me.Label15.Visible = False
        '
        'dias
        '
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.Location = New System.Drawing.Point(748, 201)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(104, 26)
        Me.dias.TabIndex = 74
        Me.dias.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(673, 173)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 20)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Fecha Regreso"
        Me.Label14.Visible = False
        '
        'fecharegreso
        '
        Me.fecharegreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecharegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharegreso.Location = New System.Drawing.Point(797, 168)
        Me.fecharegreso.Name = "fecharegreso"
        Me.fecharegreso.Size = New System.Drawing.Size(117, 26)
        Me.fecharegreso.TabIndex = 72
        Me.fecharegreso.Value = New Date(2013, 4, 8, 0, 0, 0, 0)
        Me.fecharegreso.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(673, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 20)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Fecha Salida"
        Me.Label13.Visible = False
        '
        'fechasalida
        '
        Me.fechasalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechasalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechasalida.Location = New System.Drawing.Point(797, 132)
        Me.fechasalida.Name = "fechasalida"
        Me.fechasalida.Size = New System.Drawing.Size(117, 26)
        Me.fechasalida.TabIndex = 70
        Me.fechasalida.Value = New Date(2013, 4, 8, 0, 0, 0, 0)
        Me.fechasalida.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(677, 110)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 24)
        Me.CheckBox1.TabIndex = 69
        Me.CheckBox1.Text = "Dias Completos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(55, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Motivo"
        '
        'motivo
        '
        Me.motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motivo.Location = New System.Drawing.Point(131, 143)
        Me.motivo.Multiline = True
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(464, 50)
        Me.motivo.TabIndex = 67
        '
        'a
        '
        Me.a.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.a.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.a.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.FormattingEnabled = True
        Me.a.Items.AddRange(New Object() {"8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00"})
        Me.a.Location = New System.Drawing.Point(677, 77)
        Me.a.MaxDropDownItems = 5
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(99, 26)
        Me.a.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(639, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 20)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(639, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 20)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "DE"
        '
        'de
        '
        Me.de.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.de.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.de.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.de.Items.AddRange(New Object() {"8:00", "8:15", "8:30", "8:45", "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45", "17:00", "17:15", "17:30", "17:45", "18:00", "18:15", "18:30", "18:45", "19:00"})
        Me.de.Location = New System.Drawing.Point(677, 44)
        Me.de.MaxDropDownItems = 5
        Me.de.Name = "de"
        Me.de.Size = New System.Drawing.Size(99, 26)
        Me.de.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Departamento"
        '
        'depto
        '
        Me.depto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.depto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.depto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depto.FormattingEnabled = True
        Me.depto.Location = New System.Drawing.Point(138, 9)
        Me.depto.MaxDropDownItems = 5
        Me.depto.Name = "depto"
        Me.depto.Size = New System.Drawing.Size(457, 26)
        Me.depto.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(617, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 20)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Fecha De Salida"
        '
        'fechapermiso
        '
        Me.fechapermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechapermiso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechapermiso.Location = New System.Drawing.Point(770, 9)
        Me.fechapermiso.Name = "fechapermiso"
        Me.fechapermiso.Size = New System.Drawing.Size(128, 26)
        Me.fechapermiso.TabIndex = 59
        Me.fechapermiso.Value = New Date(2013, 4, 8, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Gerente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Subgerente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Jefe Inmediato"
        '
        'jefeinmediato
        '
        Me.jefeinmediato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.jefeinmediato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.jefeinmediato.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jefeinmediato.FormattingEnabled = True
        Me.jefeinmediato.Location = New System.Drawing.Point(138, 43)
        Me.jefeinmediato.MaxDropDownItems = 5
        Me.jefeinmediato.Name = "jefeinmediato"
        Me.jefeinmediato.Size = New System.Drawing.Size(457, 26)
        Me.jefeinmediato.TabIndex = 55
        '
        'gerente
        '
        Me.gerente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.gerente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.gerente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerente.FormattingEnabled = True
        Me.gerente.Location = New System.Drawing.Point(138, 108)
        Me.gerente.MaxDropDownItems = 5
        Me.gerente.Name = "gerente"
        Me.gerente.Size = New System.Drawing.Size(457, 26)
        Me.gerente.TabIndex = 54
        '
        'subgerente
        '
        Me.subgerente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.subgerente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.subgerente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subgerente.FormattingEnabled = True
        Me.subgerente.Location = New System.Drawing.Point(138, 75)
        Me.subgerente.MaxDropDownItems = 5
        Me.subgerente.Name = "subgerente"
        Me.subgerente.Size = New System.Drawing.Size(457, 26)
        Me.subgerente.TabIndex = 53
        '
        'empleado
        '
        Me.empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.empleado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empleado.FormattingEnabled = True
        Me.empleado.Location = New System.Drawing.Point(156, 61)
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
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Permiso Salida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Historial de permisos"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(513, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 47)
        Me.Button2.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.Button2, "Cancelar Permiso")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Checked
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(412, 547)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 47)
        Me.Button1.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.Button1, "Registrar Permiso")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(840, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "Salir"
        Me.ToolTip1.SetToolTip(Me.Button3, "Salir de la Ventana")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(840, 51)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 46)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Vista Previa de Permiso"
        Me.ToolTip1.SetToolTip(Me.Button4, "Vista Previa del Reporte")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Permisos_Salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1011, 606)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
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
        Me.Name = "Permisos_Salida"
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jefeinmediato As System.Windows.Forms.ComboBox
    Friend WithEvents gerente As System.Windows.Forms.ComboBox
    Friend WithEvents subgerente As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dias As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents fecharegreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fechasalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents motivo As System.Windows.Forms.TextBox
    Friend WithEvents a As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents depto As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fechapermiso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents duracion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents de As System.Windows.Forms.ComboBox
End Class
