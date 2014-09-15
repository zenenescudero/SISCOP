<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleadonuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleadonuevo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombretxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.correopersonal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.telcelular = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fechanac = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sexotxt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.edadtxt = New System.Windows.Forms.TextBox()
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.fechaingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 33)
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
        Me.nombretxt.Size = New System.Drawing.Size(706, 24)
        Me.nombretxt.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.correopersonal)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.telcelular)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.fechanac)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.sexotxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.edadtxt)
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
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(378, 114)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(108, 18)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "Email Personal"
        '
        'correopersonal
        '
        Me.correopersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correopersonal.Location = New System.Drawing.Point(492, 108)
        Me.correopersonal.Name = "correopersonal"
        Me.correopersonal.Size = New System.Drawing.Size(398, 24)
        Me.correopersonal.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(262, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 25)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(20, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 25)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(466, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 25)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(798, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 25)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(4, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 25)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Celular"
        '
        'telcelular
        '
        Me.telcelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telcelular.Location = New System.Drawing.Point(86, 105)
        Me.telcelular.Name = "telcelular"
        Me.telcelular.Size = New System.Drawing.Size(197, 24)
        Me.telcelular.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(44, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha Nac"
        '
        'fechanac
        '
        Me.fechanac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechanac.Location = New System.Drawing.Point(126, 67)
        Me.fechanac.Name = "fechanac"
        Me.fechanac.Size = New System.Drawing.Size(117, 24)
        Me.fechanac.TabIndex = 7
        Me.fechanac.Value = New Date(2013, 4, 9, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(822, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Sexo"
        '
        'sexotxt
        '
        Me.sexotxt.FormattingEnabled = True
        Me.sexotxt.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.sexotxt.Location = New System.Drawing.Point(821, 29)
        Me.sexotxt.Name = "sexotxt"
        Me.sexotxt.Size = New System.Drawing.Size(81, 26)
        Me.sexotxt.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edad"
        '
        'edadtxt
        '
        Me.edadtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edadtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edadtxt.Location = New System.Drawing.Point(330, 69)
        Me.edadtxt.Name = "edadtxt"
        Me.edadtxt.Size = New System.Drawing.Size(62, 24)
        Me.edadtxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(403, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estudios"
        '
        'estudiostxt
        '
        Me.estudiostxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.estudiostxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estudiostxt.Location = New System.Drawing.Point(492, 66)
        Me.estudiostxt.Name = "estudiostxt"
        Me.estudiostxt.Size = New System.Drawing.Size(398, 24)
        Me.estudiostxt.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 67)
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
        Me.Label7.Location = New System.Drawing.Point(18, 64)
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
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.HorarioComedor)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.estatus)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label12)
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
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.fechaingreso)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.nomina)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(910, 306)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Laborales"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(723, 244)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(125, 18)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Horario Comedor"
        '
        'HorarioComedor
        '
        Me.HorarioComedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HorarioComedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorarioComedor.FormattingEnabled = True
        Me.HorarioComedor.Items.AddRange(New Object() {"1.00 pm a 2.00 pm", "1.00 pm a 3.00 pm", "2.00 pm a 3.00 pm", "2.00 pm a 4.00 pm"})
        Me.HorarioComedor.Location = New System.Drawing.Point(726, 268)
        Me.HorarioComedor.MaxDropDownItems = 5
        Me.HorarioComedor.Name = "HorarioComedor"
        Me.HorarioComedor.Size = New System.Drawing.Size(138, 26)
        Me.HorarioComedor.TabIndex = 36
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(723, 185)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 18)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Estatus"
        '
        'estatus
        '
        Me.estatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.estatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estatus.FormattingEnabled = True
        Me.estatus.Items.AddRange(New Object() {"Activo", "Baja"})
        Me.estatus.Location = New System.Drawing.Point(726, 212)
        Me.estatus.MaxDropDownItems = 5
        Me.estatus.Name = "estatus"
        Me.estatus.Size = New System.Drawing.Size(138, 26)
        Me.estatus.TabIndex = 34
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(103, 62)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 25)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(867, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 25)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "*"
        '
        'gerente
        '
        Me.gerente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.gerente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.gerente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerente.FormattingEnabled = True
        Me.gerente.Location = New System.Drawing.Point(129, 264)
        Me.gerente.MaxDropDownItems = 5
        Me.gerente.Name = "gerente"
        Me.gerente.Size = New System.Drawing.Size(566, 26)
        Me.gerente.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 267)
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
        Me.subgerente.Location = New System.Drawing.Point(129, 225)
        Me.subgerente.MaxDropDownItems = 5
        Me.subgerente.Name = "subgerente"
        Me.subgerente.Size = New System.Drawing.Size(566, 26)
        Me.subgerente.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 228)
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
        Me.inmediato.Location = New System.Drawing.Point(129, 185)
        Me.inmediato.MaxDropDownItems = 5
        Me.inmediato.Name = "inmediato"
        Me.inmediato.Size = New System.Drawing.Size(566, 26)
        Me.inmediato.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 188)
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
        Me.puesto.Location = New System.Drawing.Point(126, 98)
        Me.puesto.MaxDropDownItems = 5
        Me.puesto.Name = "puesto"
        Me.puesto.Size = New System.Drawing.Size(455, 26)
        Me.puesto.TabIndex = 25
        '
        'departamento
        '
        Me.departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.departamento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.FormattingEnabled = True
        Me.departamento.Location = New System.Drawing.Point(475, 64)
        Me.departamento.MaxDropDownItems = 5
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(389, 26)
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
        Me.correochedraui.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correochedraui.Location = New System.Drawing.Point(127, 142)
        Me.correochedraui.Name = "correochedraui"
        Me.correochedraui.Size = New System.Drawing.Size(454, 24)
        Me.correochedraui.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(622, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 18)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Extencion"
        '
        'extencion
        '
        Me.extencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.extencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extencion.Location = New System.Drawing.Point(712, 136)
        Me.extencion.Name = "extencion"
        Me.extencion.Size = New System.Drawing.Size(149, 24)
        Me.extencion.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(607, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 18)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Fecha Ingreso"
        '
        'fechaingreso
        '
        Me.fechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaingreso.Location = New System.Drawing.Point(712, 100)
        Me.fechaingreso.Name = "fechaingreso"
        Me.fechaingreso.Size = New System.Drawing.Size(149, 26)
        Me.fechaingreso.TabIndex = 15
        Me.fechaingreso.Value = New Date(2013, 3, 8, 0, 0, 0, 0)
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
        Me.Button1.Location = New System.Drawing.Point(365, 493)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 57)
        Me.Button1.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Button1, "Registrar Empleado")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(486, 493)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 57)
        Me.Button2.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Button2, "Cancelar y Cerrar Formulario")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'empleadonuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(934, 562)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "empleadonuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado Nuevo"
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents sexotxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents edadtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents fechaingreso As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents correopersonal As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents estatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents HorarioComedor As System.Windows.Forms.ComboBox
End Class
