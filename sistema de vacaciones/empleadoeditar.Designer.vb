<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleadoeditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleadoeditar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombretxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.sexotxt = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.edadtxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcumple = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.antigu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dias_vac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fechaingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.telcelular = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fechanac = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.estudiostxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nomina = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.HorarioComedor = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.estatus = New System.Windows.Forms.ComboBox()
        Me.gerente = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.subgerente = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inmediato = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.empresa = New System.Windows.Forms.ComboBox()
        Me.puesto = New System.Windows.Forms.ComboBox()
        Me.departamento = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.correochedraui = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.extencion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.emailpersonal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'nombretxt
        '
        Me.nombretxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombretxt.Location = New System.Drawing.Point(86, 30)
        Me.nombretxt.Name = "nombretxt"
        Me.nombretxt.Size = New System.Drawing.Size(669, 24)
        Me.nombretxt.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.sexotxt)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.edadtxt)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtcumple)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.antigu)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dias_vac)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.fechaingreso)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.telcelular)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.fechanac)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nombretxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.estudiostxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(775, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 25)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(799, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 18)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Sexo"
        '
        'sexotxt
        '
        Me.sexotxt.FormattingEnabled = True
        Me.sexotxt.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.sexotxt.Location = New System.Drawing.Point(798, 28)
        Me.sexotxt.Name = "sexotxt"
        Me.sexotxt.Size = New System.Drawing.Size(81, 26)
        Me.sexotxt.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(231, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 18)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Edad"
        '
        'edadtxt
        '
        Me.edadtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edadtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edadtxt.Location = New System.Drawing.Point(279, 66)
        Me.edadtxt.Name = "edadtxt"
        Me.edadtxt.Size = New System.Drawing.Size(62, 24)
        Me.edadtxt.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(278, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 18)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Cumple MM/DD"
        '
        'txtcumple
        '
        Me.txtcumple.BackColor = System.Drawing.Color.White
        Me.txtcumple.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcumple.Location = New System.Drawing.Point(289, 115)
        Me.txtcumple.Name = "txtcumple"
        Me.txtcumple.ReadOnly = True
        Me.txtcumple.Size = New System.Drawing.Size(87, 24)
        Me.txtcumple.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(637, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Antiguedad/Años"
        '
        'antigu
        '
        Me.antigu.BackColor = System.Drawing.Color.White
        Me.antigu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.antigu.Location = New System.Drawing.Point(654, 118)
        Me.antigu.Name = "antigu"
        Me.antigu.ReadOnly = True
        Me.antigu.Size = New System.Drawing.Size(77, 24)
        Me.antigu.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(769, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Dias Vacaciones"
        '
        'dias_vac
        '
        Me.dias_vac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias_vac.Location = New System.Drawing.Point(772, 117)
        Me.dias_vac.Name = "dias_vac"
        Me.dias_vac.Size = New System.Drawing.Size(116, 24)
        Me.dias_vac.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(393, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha Ingreso"
        '
        'fechaingreso
        '
        Me.fechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaingreso.Location = New System.Drawing.Point(501, 112)
        Me.fechaingreso.Name = "fechaingreso"
        Me.fechaingreso.Size = New System.Drawing.Size(117, 24)
        Me.fechaingreso.TabIndex = 17
        Me.fechaingreso.Value = New Date(2013, 4, 5, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Celular"
        '
        'telcelular
        '
        Me.telcelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telcelular.Location = New System.Drawing.Point(68, 115)
        Me.telcelular.Name = "telcelular"
        Me.telcelular.Size = New System.Drawing.Size(197, 24)
        Me.telcelular.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha Nac"
        '
        'fechanac
        '
        Me.fechanac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechanac.Location = New System.Drawing.Point(99, 66)
        Me.fechanac.Name = "fechanac"
        Me.fechanac.Size = New System.Drawing.Size(117, 24)
        Me.fechanac.TabIndex = 7
        Me.fechanac.Value = New Date(2013, 4, 5, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estudios"
        '
        'estudiostxt
        '
        Me.estudiostxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.estudiostxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estudiostxt.Location = New System.Drawing.Point(488, 66)
        Me.estudiostxt.Name = "estudiostxt"
        Me.estudiostxt.Size = New System.Drawing.Size(402, 24)
        Me.estudiostxt.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Departamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Empresa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "No. Nomina"
        '
        'nomina
        '
        Me.nomina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomina.Location = New System.Drawing.Point(121, 61)
        Me.nomina.Name = "nomina"
        Me.nomina.Size = New System.Drawing.Size(209, 24)
        Me.nomina.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.emailpersonal)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.HorarioComedor)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.estatus)
        Me.GroupBox2.Controls.Add(Me.gerente)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.subgerente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.inmediato)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.empresa)
        Me.GroupBox2.Controls.Add(Me.puesto)
        Me.GroupBox2.Controls.Add(Me.departamento)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.correochedraui)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.extencion)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.nomina)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(910, 324)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Laborales"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(681, 266)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(125, 18)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Horario Comedor"
        '
        'HorarioComedor
        '
        Me.HorarioComedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HorarioComedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorarioComedor.FormattingEnabled = True
        Me.HorarioComedor.Items.AddRange(New Object() {"1.00 pm a 2.00 pm", "1.00 pm a 3.00 pm", "2.00 pm a 3.00 pm", "2.00 pm a 4.00 pm"})
        Me.HorarioComedor.Location = New System.Drawing.Point(684, 290)
        Me.HorarioComedor.MaxDropDownItems = 5
        Me.HorarioComedor.Name = "HorarioComedor"
        Me.HorarioComedor.Size = New System.Drawing.Size(195, 26)
        Me.HorarioComedor.TabIndex = 40
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(681, 207)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 18)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Estatus"
        '
        'estatus
        '
        Me.estatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.estatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estatus.FormattingEnabled = True
        Me.estatus.Items.AddRange(New Object() {"Activo", "Baja"})
        Me.estatus.Location = New System.Drawing.Point(684, 234)
        Me.estatus.MaxDropDownItems = 5
        Me.estatus.Name = "estatus"
        Me.estatus.Size = New System.Drawing.Size(195, 26)
        Me.estatus.TabIndex = 38
        '
        'gerente
        '
        Me.gerente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.gerente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.gerente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerente.FormattingEnabled = True
        Me.gerente.Location = New System.Drawing.Point(130, 286)
        Me.gerente.MaxDropDownItems = 5
        Me.gerente.Name = "gerente"
        Me.gerente.Size = New System.Drawing.Size(535, 26)
        Me.gerente.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Gerente"
        '
        'subgerente
        '
        Me.subgerente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.subgerente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.subgerente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subgerente.FormattingEnabled = True
        Me.subgerente.Location = New System.Drawing.Point(130, 247)
        Me.subgerente.MaxDropDownItems = 5
        Me.subgerente.Name = "subgerente"
        Me.subgerente.Size = New System.Drawing.Size(535, 26)
        Me.subgerente.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Subgerente"
        '
        'inmediato
        '
        Me.inmediato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.inmediato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.inmediato.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inmediato.FormattingEnabled = True
        Me.inmediato.Location = New System.Drawing.Point(130, 207)
        Me.inmediato.MaxDropDownItems = 5
        Me.inmediato.Name = "inmediato"
        Me.inmediato.Size = New System.Drawing.Size(535, 26)
        Me.inmediato.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Jefe Inmediato"
        '
        'empresa
        '
        Me.empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.empresa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empresa.FormattingEnabled = True
        Me.empresa.Location = New System.Drawing.Point(121, 24)
        Me.empresa.MaxDropDownItems = 5
        Me.empresa.Name = "empresa"
        Me.empresa.Size = New System.Drawing.Size(743, 26)
        Me.empresa.TabIndex = 16
        '
        'puesto
        '
        Me.puesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.puesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.puesto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puesto.FormattingEnabled = True
        Me.puesto.Location = New System.Drawing.Point(124, 98)
        Me.puesto.MaxDropDownItems = 5
        Me.puesto.Name = "puesto"
        Me.puesto.Size = New System.Drawing.Size(476, 26)
        Me.puesto.TabIndex = 25
        '
        'departamento
        '
        Me.departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.departamento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.FormattingEnabled = True
        Me.departamento.Location = New System.Drawing.Point(516, 64)
        Me.departamento.MaxDropDownItems = 5
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(348, 26)
        Me.departamento.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 142)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 18)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Email Chedraui"
        '
        'correochedraui
        '
        Me.correochedraui.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.correochedraui.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correochedraui.Location = New System.Drawing.Point(127, 142)
        Me.correochedraui.Name = "correochedraui"
        Me.correochedraui.Size = New System.Drawing.Size(413, 24)
        Me.correochedraui.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(624, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 18)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Extencion"
        '
        'extencion
        '
        Me.extencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.extencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extencion.Location = New System.Drawing.Point(701, 98)
        Me.extencion.Name = "extencion"
        Me.extencion.Size = New System.Drawing.Size(165, 24)
        Me.extencion.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Puesto"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Checked
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(361, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 57)
        Me.Button1.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Button1, "Guardar Cambios")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(481, 511)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 57)
        Me.Button2.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Button2, "Cancelar Modificación")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 177)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 18)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Email Personal"
        '
        'emailpersonal
        '
        Me.emailpersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.emailpersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailpersonal.Location = New System.Drawing.Point(127, 177)
        Me.emailpersonal.Name = "emailpersonal"
        Me.emailpersonal.Size = New System.Drawing.Size(413, 24)
        Me.emailpersonal.TabIndex = 43
        '
        'empleadoeditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(934, 580)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "empleadoeditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Empleado"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombretxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fechanac As System.Windows.Forms.DateTimePicker
    Friend WithEvents estudiostxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nomina As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents telcelular As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents correochedraui As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents extencion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents empresa As System.Windows.Forms.ComboBox
    Friend WithEvents puesto As System.Windows.Forms.ComboBox
    Friend WithEvents departamento As System.Windows.Forms.ComboBox
    Friend WithEvents gerente As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents subgerente As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents inmediato As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fechaingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dias_vac As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents antigu As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcumple As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents edadtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents sexotxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents HorarioComedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents estatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents emailpersonal As System.Windows.Forms.TextBox
End Class
