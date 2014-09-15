Imports MySql.Data.MySqlClient

Imports System.IO

Public Class catalogoaccesos


    Private Sub empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        varconeccion()
        consultar("select c.nombre,(select descripcion from depto where id=c.departamento) as Departamento,s.* from sistemas s inner join colaborador c on ( s.no_nomina=c.no_nomina)")
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
        sistemasmodificaciones.Show()
        sistemasmodificaciones.Text = "Nuevo"
    End Sub

    Private Sub activar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activar.Click


        If Gridempleados.RowCount > 0 Then
        Else
            Exit Sub
        End If

        varconeccion()
        If MsgBox("Estas seguro de eliminar este Acceso", MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Ok Then

            Try
                varconeccion()
                coneccion.Open()
                'nueva forma de agregar
                Dim agrega As String = "delete from sistemas where no_nomina='" & Gridempleados.Item(Gridempleados.Columns("no_nomina").Index, Gridempleados.CurrentRow.Index).Value & "'"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.ExecuteNonQuery()
                coneccion.Close()
                MsgBox("Eliminado Corectamente", vbInformation, "Acceso Sistema")
                consultar("select c.nombre,(select descripcion from depto where id=c.departamento) as Departamento,s.* from sistemas s inner join colaborador c on ( s.no_nomina=c.no_nomina)")
                'limpiar campos
            Catch ex As Exception
                coneccion.Close()
            End Try

        Else

        End If

    End Sub

    Private Sub TxtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNom.TextChanged
        consultar("select c.nombre,(select descripcion from depto where id=c.departamento) as Departamento,s.* from sistemas s inner join colaborador c on ( s.no_nomina=c.no_nomina)  where nombre like'%" & TxtNom.Text & "%'")
    End Sub
    Public Sub generarestructura()
        Gridempleados.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridempleados.Columns("nombre").HeaderText = "Nombre"
        Gridempleados.Columns("no_nomina").HeaderText = "Nomina"
        Gridempleados.Columns("nombre").Width = 300
        Gridempleados.Columns("Artus").Width = 50
        Gridempleados.Columns("GL").Width = 50
        Gridempleados.Columns("CH").Width = 50
        Gridempleados.Columns("SAP").Width = 50



    End Sub

    Public Sub datosedicion()
        Try
            vec(0) = Gridempleados.Item(Gridempleados.Columns("no_nomina").Index, Gridempleados.CurrentRow.Index).Value
            vec(1) = Gridempleados.Item(Gridempleados.Columns("nombre").Index, Gridempleados.CurrentRow.Index).Value
            vec(2) = Gridempleados.Item(Gridempleados.Columns("Artus").Index, Gridempleados.CurrentRow.Index).Value
            vec(3) = Gridempleados.Item(Gridempleados.Columns("GL").Index, Gridempleados.CurrentRow.Index).Value
            vec(4) = Gridempleados.Item(Gridempleados.Columns("CH").Index, Gridempleados.CurrentRow.Index).Value
            vec(5) = Gridempleados.Item(Gridempleados.Columns("SAP").Index, Gridempleados.CurrentRow.Index).Value
            vec(6) = Gridempleados.Item(Gridempleados.Columns("People_Soft").Index, Gridempleados.CurrentRow.Index).Value
            vec(7) = Gridempleados.Item(Gridempleados.Columns("MercaderiasCFDI").Index, Gridempleados.CurrentRow.Index).Value
            vec(8) = Gridempleados.Item(Gridempleados.Columns("ArticulosCFDI").Index, Gridempleados.CurrentRow.Index).Value
            vec(9) = Gridempleados.Item(Gridempleados.Columns("Importaciones").Index, Gridempleados.CurrentRow.Index).Value

            vec(10) = Gridempleados.Item(Gridempleados.Columns("Departamento").Index, Gridempleados.CurrentRow.Index).Value
            sistemasmodificaciones.Show()
            sistemasmodificaciones.Text = "Editar"
        Catch ex As Exception
            MsgBox("Error al enviar los datos al fromulario editar: " & ex.Message, MsgBoxStyle.Critical, "Informe")
        End Try

    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        If Gridempleados.RowCount > 0 Then
            datosedicion()
        End If
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

    Private Sub Gridempleados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gridempleados.DoubleClick
        If Gridempleados.RowCount > 0 Then
            datosedicion()
        End If
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
End Class