<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equipomodificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(equipomodificaciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnombre = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nomina = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.departamento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sistemaoperativo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.checkdvd = New System.Windows.Forms.CheckBox()
        Me.checkcd = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.monitormarcaserie = New System.Windows.Forms.TextBox()
        Me.serie = New System.Windows.Forms.TextBox()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.puertosusb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.discoduro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.memoriaram = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.procesador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreequipo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.TextBox()
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.nomina)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.departamento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 103)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'txtnombre
        '
        Me.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtnombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.FormattingEnabled = True
        Me.txtnombre.Location = New System.Drawing.Point(89, 30)
        Me.txtnombre.MaxDropDownItems = 5
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(785, 26)
        Me.txtnombre.TabIndex = 40
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "No. Nomina"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(106, 67)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 25)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "*"
        '
        'nomina
        '
        Me.nomina.BackColor = System.Drawing.Color.White
        Me.nomina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomina.Location = New System.Drawing.Point(124, 66)
        Me.nomina.Name = "nomina"
        Me.nomina.Size = New System.Drawing.Size(209, 24)
        Me.nomina.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Departamento"
        '
        'departamento
        '
        Me.departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.departamento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departamento.FormattingEnabled = True
        Me.departamento.Location = New System.Drawing.Point(492, 67)
        Me.departamento.MaxDropDownItems = 5
        Me.departamento.Name = "departamento"
        Me.departamento.Size = New System.Drawing.Size(382, 26)
        Me.departamento.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.sistemaoperativo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.checkdvd)
        Me.GroupBox2.Controls.Add(Me.checkcd)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.monitormarcaserie)
        Me.GroupBox2.Controls.Add(Me.serie)
        Me.GroupBox2.Controls.Add(Me.marca)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tipo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.puertosusb)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.discoduro)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.memoriaram)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.procesador)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.nombreequipo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.usuario)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(910, 284)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Equipo"
        '
        'sistemaoperativo
        '
        Me.sistemaoperativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sistemaoperativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sistemaoperativo.Location = New System.Drawing.Point(570, 151)
        Me.sistemaoperativo.Name = "sistemaoperativo"
        Me.sistemaoperativo.Size = New System.Drawing.Size(304, 24)
        Me.sistemaoperativo.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(457, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 18)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Sis. Operativo"
        '
        'checkdvd
        '
        Me.checkdvd.AutoSize = True
        Me.checkdvd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkdvd.Location = New System.Drawing.Point(746, 242)
        Me.checkdvd.Name = "checkdvd"
        Me.checkdvd.Size = New System.Drawing.Size(128, 22)
        Me.checkdvd.TabIndex = 46
        Me.checkdvd.Text = "Unidad de DVD"
        Me.checkdvd.UseVisualStyleBackColor = True
        '
        'checkcd
        '
        Me.checkcd.AutoSize = True
        Me.checkcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkcd.Location = New System.Drawing.Point(593, 243)
        Me.checkcd.Name = "checkcd"
        Me.checkcd.Size = New System.Drawing.Size(119, 22)
        Me.checkcd.TabIndex = 45
        Me.checkcd.Text = "Unidad de CD"
        Me.checkcd.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 18)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Monitor Marca/Serie"
        '
        'monitormarcaserie
        '
        Me.monitormarcaserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.monitormarcaserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitormarcaserie.Location = New System.Drawing.Point(155, 240)
        Me.monitormarcaserie.Name = "monitormarcaserie"
        Me.monitormarcaserie.Size = New System.Drawing.Size(417, 24)
        Me.monitormarcaserie.TabIndex = 43
        '
        'serie
        '
        Me.serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serie.Location = New System.Drawing.Point(570, 195)
        Me.serie.Name = "serie"
        Me.serie.Size = New System.Drawing.Size(304, 24)
        Me.serie.TabIndex = 42
        '
        'marca
        '
        Me.marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marca.Location = New System.Drawing.Point(103, 195)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(334, 24)
        Me.marca.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(513, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 18)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Serie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 18)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Marca"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Tipo"
        '
        'tipo
        '
        Me.tipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.FormattingEnabled = True
        Me.tipo.Items.AddRange(New Object() {"Escritorio", "Laptop"})
        Me.tipo.Location = New System.Drawing.Point(103, 153)
        Me.tipo.MaxDropDownItems = 5
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(334, 26)
        Me.tipo.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(463, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Puertos USB"
        '
        'puertosusb
        '
        Me.puertosusb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.puertosusb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puertosusb.Location = New System.Drawing.Point(570, 109)
        Me.puertosusb.Name = "puertosusb"
        Me.puertosusb.Size = New System.Drawing.Size(304, 24)
        Me.puertosusb.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Disco Duro"
        '
        'discoduro
        '
        Me.discoduro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.discoduro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discoduro.Location = New System.Drawing.Point(103, 111)
        Me.discoduro.Name = "discoduro"
        Me.discoduro.Size = New System.Drawing.Size(334, 24)
        Me.discoduro.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(455, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Memoria Ram"
        '
        'memoriaram
        '
        Me.memoriaram.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memoriaram.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memoriaram.Location = New System.Drawing.Point(571, 68)
        Me.memoriaram.Name = "memoriaram"
        Me.memoriaram.Size = New System.Drawing.Size(303, 24)
        Me.memoriaram.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Procesador"
        '
        'procesador
        '
        Me.procesador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.procesador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.procesador.Location = New System.Drawing.Point(103, 71)
        Me.procesador.Name = "procesador"
        Me.procesador.Size = New System.Drawing.Size(334, 24)
        Me.procesador.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nom.Equipo"
        '
        'nombreequipo
        '
        Me.nombreequipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombreequipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreequipo.Location = New System.Drawing.Point(103, 29)
        Me.nombreequipo.Name = "nombreequipo"
        Me.nombreequipo.Size = New System.Drawing.Size(334, 24)
        Me.nombreequipo.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(498, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 18)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Usuario"
        '
        'usuario
        '
        Me.usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(571, 25)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(303, 24)
        Me.usuario.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Checked
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(378, 411)
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
        Me.Button2.Location = New System.Drawing.Point(513, 411)
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
        'equipomodificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(934, 474)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "equipomodificaciones"
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nomina As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents departamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtnombre As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombreequipo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents monitormarcaserie As System.Windows.Forms.TextBox
    Friend WithEvents serie As System.Windows.Forms.TextBox
    Friend WithEvents marca As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents puertosusb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents discoduro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents memoriaram As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents procesador As System.Windows.Forms.TextBox
    Friend WithEvents checkdvd As System.Windows.Forms.CheckBox
    Friend WithEvents checkcd As System.Windows.Forms.CheckBox
    Friend WithEvents sistemaoperativo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
