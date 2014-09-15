﻿Imports MySql.Data.MySqlClient

Public Class gerente

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "update gerente set nombre=@nombre where id='" & Gridempleados.Item(0, Gridempleados.CurrentRow.Index).Value & "'"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@nombre", TxtNom.Text)
            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Modificado Corectamente", vbInformation, "Gerente")
            consultar("select * from gerente")

        Catch ex As Exception
            MsgBox(" La modificacion fallo...", vbQuestion, "Error del Sistema")
            coneccion.Close()
        End Try

    End Sub

    Public Sub generarestructura()
        Gridempleados.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)
        Gridempleados.Columns("id").HeaderText = "ID"
        Gridempleados.Columns("nombre").HeaderText = "      Gerente"
        Gridempleados.Columns("id").Visible = False
        Gridempleados.Columns("nombre").Width = 750

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

    Private Sub Gridempleados_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gridempleados.CellEnter
        TxtNom.Text = Gridempleados.Item(1, Gridempleados.CurrentRow.Index).Value

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim seborra As Integer = 1

        Try
            varconeccion()
            coneccion.Open()
            Dim dset As New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand("select count(gerente) from colaborador where gerente='" & Gridempleados.Item(0, Gridempleados.CurrentRow.Index).Value & "'", coneccion)
            dadaptador.Fill(dset)
            coneccion.Close()
            seborra = Convert.ToInt32(dset.Tables(0).Rows(0)(0))
        Catch ex As Exception
            coneccion.Close()
        End Try

        If MsgBox("Estas Seguro De Eliminar", MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Ok Then

            If seborra = 0 Then
                Try
                    varconeccion()
                    coneccion.Open()
                    'nueva forma de agregar
                    Dim agrega As String = "delete from gerente where id='" & Gridempleados.Item(0, Gridempleados.CurrentRow.Index).Value & "'"
                    Dim comando As New MySqlCommand(agrega, coneccion)
                    comando.CommandType = CommandType.Text

                    comando.ExecuteNonQuery()
                    coneccion.Close()
                    MsgBox("Eliminación Correcta", vbInformation, "Resultado")
                    consultar("select * from gerente")

                Catch ex As Exception
                    coneccion.Close()
                End Try
            Else
                MsgBox(" No se puede Eliminar devido a que exiten colaboradores con este gerente regisrado" & Chr(13) & "SUGERENCIA: Intenta modificar el nombre del gerente...", MsgBoxStyle.Critical, "Error del Sistema")
            End If
        End If


    End Sub

    Private Sub empresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultar("Select  * from gerente")
        generarestructura()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "insert into gerente values(default,@nombre)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@nombre", TextBox1.Text)
            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Inserción Correcta", vbInformation, "Resultado")
            consultar("select * from gerente")

        Catch ex As Exception
            coneccion.Close()
        End Try


    End Sub

    Private Sub desactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desactivar.Click
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        SaveFileDialog1.Title = "Exportar a Excel"
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.Length > 0 Then
            exportaraexcel(Gridempleados, SaveFileDialog1.FileName, 2)
        Else
            MsgBox("No seleccionaste donde guardar", MsgBoxStyle.Critical, "Exportar a Excel")
        End If
    End Sub
End Class