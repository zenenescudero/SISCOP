Imports MySql.Data.MySqlClient


Public Class Sistema

    Dim dset As DataSet

    Public Sub consultar(ByVal consulta As String)

        Try
            varconeccion()
            coneccion.Open()
            dset = New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand(consulta, coneccion)
            dadaptador.Fill(dset)
            coneccion.Close()
        Catch ex As Exception
            coneccion.Close()
        End Try

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click

        formlocal = empleados
        mostrarform(formlocal)

    End Sub
    
    Private Sub Sistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        datosdebase()

       
        consultar("select * from viantiguedad where anios >=1")
        Dim nomina As String
        Dim anios As Double
        Dim asigno As String

        If dset.Tables(0).Rows.Count >= 1 Then

            For x As Integer = 0 To dset.Tables(0).Rows.Count - 1

                If IsDBNull(dset.Tables(0).Rows(x)(3)) Then
                    asigno = ""
                Else
                    asigno = dset.Tables(0).Rows(x)(3)
                End If
                anios = dset.Tables(0).Rows(x)(2)
                '  MsgBox("años " & anios & "")
                anios = anios - (anios Mod 1)
                '  MsgBox("años " & anios & "")
                nomina = dset.Tables(0).Rows(x)(0)
                ' la modificacion se ixo en el procesidimeinto registrardiasvac se comentaron unas lineas, el calculo de antiguedad se raliza correctamente

                registrar(nomina, anios, asigno)

            Next

        End If

    End Sub

    Private Sub PermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosToolStripMenuItem.Click

        formlocal = Permisos_Salida
        mostrarform(formlocal)

    End Sub

    Private Sub IncapacidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncapacidadToolStripMenuItem.Click

        formlocal = incapacidad
        mostrarform(formlocal)

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Informacion.Show()

    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresasToolStripMenuItem.Click

        formlocal = empresas
        mostrarform(formlocal)

    End Sub

    Private Sub PuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuestosToolStripMenuItem.Click

        formlocal = puestos
        mostrarform(formlocal)

    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click

        formlocal = departamentos
        mostrarform(formlocal)

    End Sub

    Private Sub GerenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerenteToolStripMenuItem.Click

        formlocal = gerente
        mostrarform(formlocal)

    End Sub

    Private Sub SubgerentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubgerentesToolStripMenuItem.Click

        formlocal = subgerente
        mostrarform(formlocal)

    End Sub

    Private Sub JefesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JefesToolStripMenuItem.Click

        formlocal = jefes
        mostrarform(formlocal)

    End Sub

    Private Sub VacacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VacacionesToolStripMenuItem1.Click
        Vacaciones.Show()

    End Sub

    Private Sub HistoricoPermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoricoPermisosToolStripMenuItem.Click

        formlocal = Historicopermisos
        mostrarform(formlocal)

    End Sub

    Private Sub VacacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VacacionesToolStripMenuItem.Click

        formlocal = Permisos_vacaciones
        mostrarform(formlocal)

    End Sub

    Private Sub HistoricoIncapacidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoricoIncapacidadToolStripMenuItem.Click
        formlocal = Historiincapacidad
        mostrarform(formlocal)
    End Sub

    Private Sub HistoricoVacacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoricoVacacionesToolStripMenuItem.Click

        formlocal = Historicovac
        mostrarform(Historicovac)

    End Sub

    Private Sub ServidorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServidorToolStripMenuItem.Click
        Origen_de_Datos.Show()

    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CatalgoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalgoToolStripMenuItem.Click

        formlocal = catalogoaccesos
        mostrarform(formlocal)

    End Sub

    Private Sub InventarioEquipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioEquipoToolStripMenuItem.Click
        formlocal = catalogoequipos
        mostrarform(formlocal)
    End Sub
End Class
