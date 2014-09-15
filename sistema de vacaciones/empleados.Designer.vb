<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.activar = New System.Windows.Forms.Button()
        Me.editar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Gridempleados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.desactivar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.Gridempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'activar
        '
        Me.activar.AccessibleDescription = ""
        Me.activar.BackgroundImage = CType(resources.GetObject("activar.BackgroundImage"), System.Drawing.Image)
        Me.activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.activar.Location = New System.Drawing.Point(88, 44)
        Me.activar.Name = "activar"
        Me.activar.Size = New System.Drawing.Size(70, 45)
        Me.activar.TabIndex = 46
        Me.activar.TabStop = False
        Me.activar.Tag = ""
        Me.ToolTip1.SetToolTip(Me.activar, "Eliminar Empleado Seleccionado")
        Me.activar.UseVisualStyleBackColor = True
        '
        'editar
        '
        Me.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.editar.Image = CType(resources.GetObject("editar.Image"), System.Drawing.Image)
        Me.editar.Location = New System.Drawing.Point(164, 43)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(70, 45)
        Me.editar.TabIndex = 44
        Me.editar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.editar, "Editar Empleado Seleccionado")
        Me.editar.UseVisualStyleBackColor = True
        '
        'nuevo
        '
        Me.nuevo.BackgroundImage = CType(resources.GetObject("nuevo.BackgroundImage"), System.Drawing.Image)
        Me.nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.Location = New System.Drawing.Point(12, 43)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(70, 45)
        Me.nuevo.TabIndex = 43
        Me.nuevo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.nuevo, "Registrar Nuevo Empleado")
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'TxtNom
        '
        Me.TxtNom.AccessibleDescription = ""
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(316, 61)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(439, 26)
        Me.TxtNom.TabIndex = 41
        Me.TxtNom.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nombre"
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
        Me.Gridempleados.Location = New System.Drawing.Point(12, 128)
        Me.Gridempleados.MultiSelect = False
        Me.Gridempleados.Name = "Gridempleados"
        Me.Gridempleados.ReadOnly = True
        Me.Gridempleados.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Gridempleados.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Gridempleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Gridempleados.Size = New System.Drawing.Size(897, 402)
        Me.Gridempleados.TabIndex = 47
        Me.Gridempleados.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Empleados"
        '
        'desactivar
        '
        Me.desactivar.AccessibleDescription = ""
        Me.desactivar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.table_green_48
        Me.desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.desactivar.Location = New System.Drawing.Point(799, 50)
        Me.desactivar.Name = "desactivar"
        Me.desactivar.Size = New System.Drawing.Size(70, 45)
        Me.desactivar.TabIndex = 49
        Me.desactivar.TabStop = False
        Me.desactivar.Tag = ""
        Me.ToolTip1.SetToolTip(Me.desactivar, "Exportar a Excel")
        Me.desactivar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(817, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 25)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Cerrar"
        Me.ToolTip1.SetToolTip(Me.Button1, "Cerrar Formulario")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Celular"
        '
        'empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(928, 542)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.desactivar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Gridempleados)
        Me.Controls.Add(Me.activar)
        Me.Controls.Add(Me.editar)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Gridempleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents activar As System.Windows.Forms.Button
    Friend WithEvents editar As System.Windows.Forms.Button
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Gridempleados As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents desactivar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
