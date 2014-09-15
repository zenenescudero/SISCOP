<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sistemasmodificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sistemasmodificaciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdepto = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nomina = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkartus = New System.Windows.Forms.CheckBox()
        Me.checksap = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Checkmercaderiascfdi = New System.Windows.Forms.CheckBox()
        Me.Checkpeoplesoft = New System.Windows.Forms.CheckBox()
        Me.Checkch = New System.Windows.Forms.CheckBox()
        Me.Checkgl = New System.Windows.Forms.CheckBox()
        Me.Checkimportaciones = New System.Windows.Forms.CheckBox()
        Me.Checkarticuloscfdi = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdepto)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.nomina)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 103)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Departamento"
        '
        'txtdepto
        '
        Me.txtdepto.BackColor = System.Drawing.Color.White
        Me.txtdepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepto.Location = New System.Drawing.Point(471, 66)
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.ReadOnly = True
        Me.txtdepto.Size = New System.Drawing.Size(403, 24)
        Me.txtdepto.TabIndex = 42
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
        Me.nomina.ReadOnly = True
        Me.nomina.Size = New System.Drawing.Size(209, 24)
        Me.nomina.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Checkimportaciones)
        Me.GroupBox2.Controls.Add(Me.Checkarticuloscfdi)
        Me.GroupBox2.Controls.Add(Me.Checkch)
        Me.GroupBox2.Controls.Add(Me.Checkgl)
        Me.GroupBox2.Controls.Add(Me.Checkmercaderiascfdi)
        Me.GroupBox2.Controls.Add(Me.Checkpeoplesoft)
        Me.GroupBox2.Controls.Add(Me.checkartus)
        Me.GroupBox2.Controls.Add(Me.checksap)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(910, 141)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sistemas"
        '
        'checkartus
        '
        Me.checkartus.AutoSize = True
        Me.checkartus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkartus.Location = New System.Drawing.Point(230, 37)
        Me.checkartus.Name = "checkartus"
        Me.checkartus.Size = New System.Drawing.Size(77, 22)
        Me.checkartus.TabIndex = 46
        Me.checkartus.Text = "ARTUS"
        Me.checkartus.UseVisualStyleBackColor = True
        '
        'checksap
        '
        Me.checksap.AutoSize = True
        Me.checksap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checksap.Location = New System.Drawing.Point(77, 38)
        Me.checksap.Name = "checksap"
        Me.checksap.Size = New System.Drawing.Size(56, 22)
        Me.checksap.TabIndex = 45
        Me.checksap.Text = "SAP"
        Me.checksap.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Checked
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(319, 288)
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
        Me.Button2.Location = New System.Drawing.Point(466, 288)
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
        'Checkmercaderiascfdi
        '
        Me.Checkmercaderiascfdi.AutoSize = True
        Me.Checkmercaderiascfdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkmercaderiascfdi.Location = New System.Drawing.Point(230, 91)
        Me.Checkmercaderiascfdi.Name = "Checkmercaderiascfdi"
        Me.Checkmercaderiascfdi.Size = New System.Drawing.Size(143, 22)
        Me.Checkmercaderiascfdi.TabIndex = 48
        Me.Checkmercaderiascfdi.Text = "MercaderiasCFDI"
        Me.Checkmercaderiascfdi.UseVisualStyleBackColor = True
        '
        'Checkpeoplesoft
        '
        Me.Checkpeoplesoft.AutoSize = True
        Me.Checkpeoplesoft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkpeoplesoft.Location = New System.Drawing.Point(77, 92)
        Me.Checkpeoplesoft.Name = "Checkpeoplesoft"
        Me.Checkpeoplesoft.Size = New System.Drawing.Size(104, 22)
        Me.Checkpeoplesoft.TabIndex = 47
        Me.Checkpeoplesoft.Text = "People Soft"
        Me.Checkpeoplesoft.UseVisualStyleBackColor = True
        '
        'Checkch
        '
        Me.Checkch.AutoSize = True
        Me.Checkch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkch.Location = New System.Drawing.Point(567, 36)
        Me.Checkch.Name = "Checkch"
        Me.Checkch.Size = New System.Drawing.Size(49, 22)
        Me.Checkch.TabIndex = 50
        Me.Checkch.Text = "CH"
        Me.Checkch.UseVisualStyleBackColor = True
        '
        'Checkgl
        '
        Me.Checkgl.AutoSize = True
        Me.Checkgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkgl.Location = New System.Drawing.Point(414, 37)
        Me.Checkgl.Name = "Checkgl"
        Me.Checkgl.Size = New System.Drawing.Size(47, 22)
        Me.Checkgl.TabIndex = 49
        Me.Checkgl.Text = "GL"
        Me.Checkgl.UseVisualStyleBackColor = True
        '
        'Checkimportaciones
        '
        Me.Checkimportaciones.AutoSize = True
        Me.Checkimportaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkimportaciones.Location = New System.Drawing.Point(567, 90)
        Me.Checkimportaciones.Name = "Checkimportaciones"
        Me.Checkimportaciones.Size = New System.Drawing.Size(121, 22)
        Me.Checkimportaciones.TabIndex = 52
        Me.Checkimportaciones.Text = "Importaciones"
        Me.Checkimportaciones.UseVisualStyleBackColor = True
        '
        'Checkarticuloscfdi
        '
        Me.Checkarticuloscfdi.AutoSize = True
        Me.Checkarticuloscfdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkarticuloscfdi.Location = New System.Drawing.Point(414, 91)
        Me.Checkarticuloscfdi.Name = "Checkarticuloscfdi"
        Me.Checkarticuloscfdi.Size = New System.Drawing.Size(118, 22)
        Me.Checkarticuloscfdi.TabIndex = 51
        Me.Checkarticuloscfdi.Text = "ArticulosCFDI"
        Me.Checkarticuloscfdi.UseVisualStyleBackColor = True
        '
        'sistemasmodificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(934, 361)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sistemasmodificaciones"
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nomina As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtnombre As System.Windows.Forms.ComboBox
    Friend WithEvents checkartus As System.Windows.Forms.CheckBox
    Friend WithEvents checksap As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdepto As System.Windows.Forms.TextBox
    Friend WithEvents Checkimportaciones As System.Windows.Forms.CheckBox
    Friend WithEvents Checkarticuloscfdi As System.Windows.Forms.CheckBox
    Friend WithEvents Checkch As System.Windows.Forms.CheckBox
    Friend WithEvents Checkgl As System.Windows.Forms.CheckBox
    Friend WithEvents Checkmercaderiascfdi As System.Windows.Forms.CheckBox
    Friend WithEvents Checkpeoplesoft As System.Windows.Forms.CheckBox
End Class
