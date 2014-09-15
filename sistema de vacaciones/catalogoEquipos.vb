Imports MySql.Data.MySqlClient

Imports System.IO

Public Class catalogoequipos

    Private Sub empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        varconeccion()
        consultar("select c.nombre,e.no_nomina,(select descripcion from depto where id=e.departamento) departamento,e.usuario,e.nom_equipo,e.procesador,e.memoria_ram,e.disco_duro,e.cd,e.dvd,e.sistema_operativo,e.puertos_usb,e.tipo_equipo,e.marca,e.serie_equipo,e.monitor_marca_serie from colaborador c right join equipo e on (c.no_nomina=e.no_nomina)")
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
        equipomodificaciones.Show()
        equipomodificaciones.Text = "Nuevo Equipo"

    End Sub

    Private Sub activar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activar.Click
        varconeccion()
        If MsgBox("Estas seguro de eliminar este Equipo", MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Ok Then

            Try
                varconeccion()
                coneccion.Open()
                'nueva forma de agregar
                Dim agrega As String = "delete from equipo where no_nomina='" & Gridempleados.Item(Gridempleados.Columns("no_nomina").Index, Gridempleados.CurrentRow.Index).Value & "' "
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.ExecuteNonQuery()
                coneccion.Close()
                MsgBox("Eliminado Corectamente", vbInformation, "Equipo")
                consultar("select c.nombre,e.no_nomina,(select descripcion from depto where id=e.departamento) departamento,e.usuario,e.nom_equipo,e.procesador,e.memoria_ram,e.disco_duro,e.cd,e.dvd,e.sistema_operativo,e.puertos_usb,e.tipo_equipo,e.marca,e.serie_equipo,e.monitor_marca_serie from colaborador c right join equipo e on (c.no_nomina=e.no_nomina)")
                'limpiar campos
            Catch ex As Exception
                coneccion.Close()
            End Try

        Else

        End If

    End Sub

    Private Sub TxtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNom.TextChanged
        consultar("select c.nombre,e.no_nomina,(select descripcion from depto where id=e.departamento) departamento,e.usuario,e.nom_equipo,e.procesador,e.memoria_ram,e.disco_duro,e.cd,e.dvd,e.sistema_operativo,e.puertos_usb,e.tipo_equipo,e.marca,e.serie_equipo,e.monitor_marca_serie from colaborador c right join equipo e on (c.no_nomina=e.no_nomina) where nombre like'%" & TxtNom.Text & "%'")
    End Sub
    Public Sub generarestructura()
        Gridempleados.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridempleados.Columns("nombre").HeaderText = "Nombre"
        
        Gridempleados.Columns("no_nomina").HeaderText = "Nomina"
       
        
        Gridempleados.Columns("nombre").Width = 200
        Gridempleados.Columns("no_nomina").Width = 100
        
    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        If Gridempleados.RowCount > 0 Then
        Else
            Exit Sub
        End If

        Try
            vec(0) = Convert.ToString(Gridempleados.Item(0, Gridempleados.CurrentRow.Index).Value)
            vec(1) = Gridempleados.Item(1, Gridempleados.CurrentRow.Index).Value
            vec(2) = Gridempleados.Item(2, Gridempleados.CurrentRow.Index).Value
            vec(3) = Gridempleados.Item(3, Gridempleados.CurrentRow.Index).Value
            vec(4) = Gridempleados.Item(4, Gridempleados.CurrentRow.Index).Value
            vec(5) = Gridempleados.Item(5, Gridempleados.CurrentRow.Index).Value
            vec(6) = Gridempleados.Item(6, Gridempleados.CurrentRow.Index).Value
            vec(7) = Gridempleados.Item(7, Gridempleados.CurrentRow.Index).Value
            vec(8) = Gridempleados.Item(8, Gridempleados.CurrentRow.Index).Value
            vec(9) = Gridempleados.Item(9, Gridempleados.CurrentRow.Index).Value
            vec(10) = Gridempleados.Item(10, Gridempleados.CurrentRow.Index).Value
            vec(11) = Gridempleados.Item(11, Gridempleados.CurrentRow.Index).Value
            vec(12) = Gridempleados.Item(12, Gridempleados.CurrentRow.Index).Value
            vec(13) = Gridempleados.Item(13, Gridempleados.CurrentRow.Index).Value
            vec(14) = Gridempleados.Item(14, Gridempleados.CurrentRow.Index).Value
            vec(15) = Gridempleados.Item(15, Gridempleados.CurrentRow.Index).Value

            equipomodificaciones.Show()
            equipomodificaciones.Text = "Editar Equipo"
        Catch ex As Exception
            MsgBox("Error al enviar los datos al fromulario editar", MsgBoxStyle.Critical, "Informe")
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