Imports MySql.Data.MySqlClient

Imports System.IO

Public Class empleados

    Private Sub empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        varconeccion()
        consultar("select * from vicolaborador")
        generarestructura()

        Label13.Text = "Empleados:  " & Gridempleados.RowCount

    End Sub

    Public Sub consultar(ByVal consulta As String)

        Try
            varconeccion()
            coneccion.Open()
            Dim dset As New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand(consulta, coneccion)
            dadaptador.Fill(dset)
            coneccion.Close()
            Dim dtable As DataTable = dset.Tables(0)
            Gridempleados.DataSource = dtable
        Catch ex As Exception
            coneccion.Close()
        End Try

    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        empleadonuevo.Show()

    End Sub

    Private Sub activar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activar.Click
        varconeccion()
        If MsgBox("Estas seguro de eliminar este Empleado", MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Ok Then

            Try
                varconeccion()
                coneccion.Open()
                'nueva forma de agregar
                Dim agrega As String = "call eliempleado(@nomina)"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@nomina", Gridempleados.Item(9, Gridempleados.CurrentRow.Index).Value)
                comando.ExecuteNonQuery()
                coneccion.Close()
                MsgBox("Eliminado Corectamente", vbInformation, "Colaborador")
                consultar("select * from vicolaborador")
                'limpiar campos
            Catch ex As Exception
                coneccion.Close()
            End Try

        Else

        End If
        
    End Sub

    Private Sub TxtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNom.TextChanged
        consultar("select * from vicolaborador where nombre like'%" & TxtNom.Text & "%'")
    End Sub
    Public Sub generarestructura()
        Gridempleados.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridempleados.Columns("nombre").HeaderText = "Nombre"
        Gridempleados.Columns("Estatus").HeaderText = "Estatus"
        Gridempleados.Columns("horario_comedor").HeaderText = "Horario Comedor"

        Gridempleados.Columns("sexo").HeaderText = "Sexo"
        Gridempleados.Columns("fecha_nac").HeaderText = "Fecha Nac"
        Gridempleados.Columns("cumple_anos").HeaderText = "Cumple Años(MM,DD)"

        Gridempleados.Columns("edad").HeaderText = "Edad"
        Gridempleados.Columns("estudios").HeaderText = "Estudios"
        Gridempleados.Columns("tel_cel").HeaderText = "Tel_cel"
        Gridempleados.Columns("empresa").HeaderText = "Empresa"
        Gridempleados.Columns("departamento").HeaderText = "Departamento"
        Gridempleados.Columns("puesto").HeaderText = "Puesto"
        Gridempleados.Columns("no_nomina").HeaderText = "Nomina"
        Gridempleados.Columns("fecha_ingreso").HeaderText = "Fecha Ingreso"
        Gridempleados.Columns("antiguedad").HeaderText = "Antiguedad"
        Gridempleados.Columns("extencion").HeaderText = "Extención"
        Gridempleados.Columns("email").HeaderText = "Correo Corporativo"
        Gridempleados.Columns("email_personal").HeaderText = "Correo Personal"
        Gridempleados.Columns("jefe_inmediato").HeaderText = "Jefe Inmediato"
        Gridempleados.Columns("subgerente").HeaderText = "Subgerente"
        Gridempleados.Columns("gerente").HeaderText = "Gerente"
        Gridempleados.Columns("dias_vac").HeaderText = "Vacaciones/Dias"

        Gridempleados.Columns("nombre").Width = 200
        Gridempleados.Columns("sexo").Width = 50
        Gridempleados.Columns("fecha_nac").Width = 100
        Gridempleados.Columns("edad").Width = 40
        Gridempleados.Columns("cumple_anos").Width = 84
        Gridempleados.Columns("estudios").Width = 150
        Gridempleados.Columns("tel_cel").Width = 100
        Gridempleados.Columns("empresa").Width = 200
        Gridempleados.Columns("departamento").Width = 150
        Gridempleados.Columns("puesto").Width = 150
        Gridempleados.Columns("no_nomina").Width = 100
        Gridempleados.Columns("fecha_ingreso").Width = 100
        Gridempleados.Columns("antiguedad").Width = 80
        Gridempleados.Columns("extencion").Width = 80
        Gridempleados.Columns("email").Width = 150
        Gridempleados.Columns("jefe_inmediato").Width = 200
        Gridempleados.Columns("subgerente").Width = 200
        Gridempleados.Columns("gerente").Width = 200
        Gridempleados.Columns("dias_vac").Width = 150
        Gridempleados.Columns("email_personal").Width = 150
        Gridempleados.Columns("Estatus").Width = 80


    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click

        Try
            empleadoeditar.Show()
            Sistema.Enabled = False
        Catch ex As Exception
            MsgBox("Error al enviar los datos al fromulario editar: " & ex.Message, MsgBoxStyle.Critical, "Informe")
        End Try

    End Sub

    Private Sub desactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desactivar.Click
        guardar.FileName = ""
        guardar.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        guardar.Title = "Exportar a Excel"

        guardar.ShowDialog()

        If guardar.FileName.Length > 0 Then
            exportaraexcel(Gridempleados, guardar.FileName, 2)

        Else
            MsgBox("Selecciona Donde Guardar", MsgBoxStyle.Critical, "Exportación a Excel")

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

 
    Private Sub Gridempleados_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Gridempleados.ColumnHeaderMouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then

        End If


        'secundariomenu.Show()

    End Sub

    Private Sub Gridempleados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gridempleados.DoubleClick
        Try
            empleadoeditar.Show()
            Sistema.Enabled = False
        Catch ex As Exception
            MsgBox("Error al enviar los datos al fromulario editar", MsgBoxStyle.Critical, "Informe")
        End Try
    End Sub

    Private Sub Gridempleados_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Gridempleados.RowsRemoved

        Try
            Label13.Text = "Empleados: " & Gridempleados.RowCount
        Catch ex As Exception
            Label13.Text = "Empleados: " & "0"
        End Try


    End Sub

    Private Sub Gridempleados_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Gridempleados.RowsAdded
        Try
            Label13.Text = "Empleados: " & Gridempleados.RowCount
        Catch ex As Exception
            Label13.Text = "Empleados: " & Gridempleados.RowCount
        End Try
    End Sub

    Private Sub Gridempleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gridempleados.CellContentClick

    End Sub
End Class