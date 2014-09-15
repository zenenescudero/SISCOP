<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sistema))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.contenedor = New System.Windows.Forms.Panel()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncapacidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoIncapacidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalgoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JefesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubgerentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AccesosToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1011, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'contenedor
        '
        Me.contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contenedor.Location = New System.Drawing.Point(21, 35)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(956, 661)
        Me.contenedor.TabIndex = 1
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.PersonalToolStripMenuItem.Image = CType(resources.GetObject("PersonalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(105, 23)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.EmpleadosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmpleadosToolStripMenuItem.Image = CType(resources.GetObject("EmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Colaboradores"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Image = CType(resources.GetObject("SalirDelSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosToolStripMenuItem, Me.VacacionesToolStripMenuItem, Me.IncapacidadToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Image = CType(resources.GetObject("OpcionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(98, 23)
        Me.OpcionesToolStripMenuItem.Text = "Generar"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Image = CType(resources.GetObject("PermisosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'VacacionesToolStripMenuItem
        '
        Me.VacacionesToolStripMenuItem.Image = CType(resources.GetObject("VacacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VacacionesToolStripMenuItem.Name = "VacacionesToolStripMenuItem"
        Me.VacacionesToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.VacacionesToolStripMenuItem.Text = "Vacaciones"
        '
        'IncapacidadToolStripMenuItem
        '
        Me.IncapacidadToolStripMenuItem.Image = CType(resources.GetObject("IncapacidadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IncapacidadToolStripMenuItem.Name = "IncapacidadToolStripMenuItem"
        Me.IncapacidadToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.IncapacidadToolStripMenuItem.Text = "Incapacidad"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoricoPermisosToolStripMenuItem, Me.HistoricoVacacionesToolStripMenuItem, Me.HistoricoIncapacidadToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = CType(resources.GetObject("ReportesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(107, 23)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'HistoricoPermisosToolStripMenuItem
        '
        Me.HistoricoPermisosToolStripMenuItem.Image = CType(resources.GetObject("HistoricoPermisosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistoricoPermisosToolStripMenuItem.Name = "HistoricoPermisosToolStripMenuItem"
        Me.HistoricoPermisosToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.HistoricoPermisosToolStripMenuItem.Text = "Historico Permisos"
        '
        'HistoricoVacacionesToolStripMenuItem
        '
        Me.HistoricoVacacionesToolStripMenuItem.Image = CType(resources.GetObject("HistoricoVacacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistoricoVacacionesToolStripMenuItem.Name = "HistoricoVacacionesToolStripMenuItem"
        Me.HistoricoVacacionesToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.HistoricoVacacionesToolStripMenuItem.Text = "Historico Vacaciones"
        '
        'HistoricoIncapacidadToolStripMenuItem
        '
        Me.HistoricoIncapacidadToolStripMenuItem.Image = CType(resources.GetObject("HistoricoIncapacidadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistoricoIncapacidadToolStripMenuItem.Name = "HistoricoIncapacidadToolStripMenuItem"
        Me.HistoricoIncapacidadToolStripMenuItem.Size = New System.Drawing.Size(244, 24)
        Me.HistoricoIncapacidadToolStripMenuItem.Text = "Historico Incapacidad"
        '
        'AccesosToolStripMenuItem
        '
        Me.AccesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalgoToolStripMenuItem, Me.InventarioEquipoToolStripMenuItem})
        Me.AccesosToolStripMenuItem.Image = CType(resources.GetObject("AccesosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccesosToolStripMenuItem.Name = "AccesosToolStripMenuItem"
        Me.AccesosToolStripMenuItem.Size = New System.Drawing.Size(103, 23)
        Me.AccesosToolStripMenuItem.Text = "Accesos"
        '
        'CatalgoToolStripMenuItem
        '
        Me.CatalgoToolStripMenuItem.Name = "CatalgoToolStripMenuItem"
        Me.CatalgoToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.CatalgoToolStripMenuItem.Text = "Catalogo Accesos"
        '
        'InventarioEquipoToolStripMenuItem
        '
        Me.InventarioEquipoToolStripMenuItem.Name = "InventarioEquipoToolStripMenuItem"
        Me.InventarioEquipoToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.InventarioEquipoToolStripMenuItem.Text = "Inventario Equipos"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuestosToolStripMenuItem, Me.DepartamentosToolStripMenuItem, Me.JefesToolStripMenuItem, Me.SubgerentesToolStripMenuItem, Me.GerenteToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.ServidorToolStripMenuItem, Me.SistemasToolStripMenuItem, Me.VacacionesToolStripMenuItem1, Me.SistemasToolStripMenuItem1, Me.AcercaDeToolStripMenuItem})
        Me.ConfiguracionesToolStripMenuItem.Image = CType(resources.GetObject("ConfiguracionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(164, 23)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'PuestosToolStripMenuItem
        '
        Me.PuestosToolStripMenuItem.Name = "PuestosToolStripMenuItem"
        Me.PuestosToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.PuestosToolStripMenuItem.Text = "Puestos"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'JefesToolStripMenuItem
        '
        Me.JefesToolStripMenuItem.Name = "JefesToolStripMenuItem"
        Me.JefesToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.JefesToolStripMenuItem.Text = "Jefes"
        '
        'SubgerentesToolStripMenuItem
        '
        Me.SubgerentesToolStripMenuItem.Name = "SubgerentesToolStripMenuItem"
        Me.SubgerentesToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.SubgerentesToolStripMenuItem.Text = "Subgerentes"
        '
        'GerenteToolStripMenuItem
        '
        Me.GerenteToolStripMenuItem.Name = "GerenteToolStripMenuItem"
        Me.GerenteToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.GerenteToolStripMenuItem.Text = "Gerente"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'ServidorToolStripMenuItem
        '
        Me.ServidorToolStripMenuItem.Name = "ServidorToolStripMenuItem"
        Me.ServidorToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.ServidorToolStripMenuItem.Text = "Servidor"
        '
        'SistemasToolStripMenuItem
        '
        Me.SistemasToolStripMenuItem.Name = "SistemasToolStripMenuItem"
        Me.SistemasToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.SistemasToolStripMenuItem.Text = "Sistemas"
        '
        'VacacionesToolStripMenuItem1
        '
        Me.VacacionesToolStripMenuItem1.Name = "VacacionesToolStripMenuItem1"
        Me.VacacionesToolStripMenuItem1.Size = New System.Drawing.Size(195, 24)
        Me.VacacionesToolStripMenuItem1.Text = "Vacaciones"
        '
        'SistemasToolStripMenuItem1
        '
        Me.SistemasToolStripMenuItem1.Name = "SistemasToolStripMenuItem1"
        Me.SistemasToolStripMenuItem1.Size = New System.Drawing.Size(195, 24)
        Me.SistemasToolStripMenuItem1.Text = "Sistemas"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'Sistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1011, 725)
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Sistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Permisos y Vacaciones Chedraui- Mercaderias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncapacidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoricoIncapacidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoricoPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoricoVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VacacionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contenedor As System.Windows.Forms.Panel
    Friend WithEvents JefesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubgerentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalgoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioEquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
