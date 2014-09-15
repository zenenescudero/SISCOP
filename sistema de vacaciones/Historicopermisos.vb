Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Image
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Historicopermisos

    Dim consultaformada As String

    Private Sub Historicopermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecharegreso.Value = Date.Now
        fechasalida.Value = Date.Now

        opcionescombo(motivo, "select distinct motivo,motivo from permisos")
        motivo.Text = ""
        mensaje.Text = "*vacio para " & Chr(13) & " consultar todos" & Chr(13) & "Dar Enter"
        Label4.Text = "Estas Selecionando" & Chr(13) & "Sin filtros"

        Try
            consultar("select * from permisos order by id desc")
            generarestructura()
        Catch ex As Exception

        End Try
      
    End Sub

    Public Sub generarestructura()

        Gridempleados.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridempleados.Columns("nomina").HeaderText = "Nomina"
        Gridempleados.Columns("nombre").HeaderText = "Nombre"
        Gridempleados.Columns("motivo").HeaderText = "Motivo de Permiso"
        Gridempleados.Columns("nota").HeaderText = "Nota Adicional"
        Gridempleados.Columns("fecha_permiso").HeaderText = "Fecha de Permiso"
        Gridempleados.Columns("duracion").HeaderText = "Duracion de Salida"
        Gridempleados.Columns("de").HeaderText = "Desde"
        Gridempleados.Columns("a").HeaderText = "Hasta"
        Gridempleados.Columns("dias_completos").HeaderText = "No. Dias"
        Gridempleados.Columns("fecha_salida").HeaderText = "Fecha Salida"
        Gridempleados.Columns("fecha_regreso").HeaderText = "Fecha De Regreso"
        Gridempleados.Columns("id").HeaderText = "id"
        Gridempleados.Columns("archivo").Visible = False
        Gridempleados.Columns("extension").Visible = False
        Gridempleados.Columns("comprobante").HeaderText = "Archivo"
        Gridempleados.Columns("id").Visible = False

        Gridempleados.Columns("nomina").Width = 80
        Gridempleados.Columns("nombre").Width = 200
        Gridempleados.Columns("motivo").Width = 200
        Gridempleados.Columns("nota").Width = 200
        Gridempleados.Columns("fecha_permiso").Width = 70
        Gridempleados.Columns("duracion").Width = 80
        Gridempleados.Columns("de").Width = 60
        Gridempleados.Columns("a").Width = 60
        Gridempleados.Columns("dias_completos").Width = 60
        Gridempleados.Columns("fecha_salida").Width = 70
        Gridempleados.Columns("fecha_regreso").Width = 70

    End Sub

    Public Sub formarconsulta()

        Dim partir As String()
        Dim cadena As String = fechasalida.Text
        partir = cadena.Split("/")
        cadena = "'" + partir(2) + "/" + partir(1) + "/" + partir(0) + "'  AND '"

        Dim partir2 As String()
        Dim cadena2 As String = fecharegreso.Text
        partir2 = cadena2.Split("/")
        cadena2 = partir2(2) + "/" + partir2(1) + "/" + partir2(0) + "'"

        Dim filtros As Integer = 0
        Dim RANGOANTES As Integer = 0
        Dim consulta As String = "select * from permisos "

        Try
            If motivo.Text.Length > 0 Then
                consulta = consulta & " where motivo='" & motivo.Text & "'"
                filtros = 1
            End If
        Catch ex As Exception

        End Try

        If TxtNom.Text.Length > 0 Then
            If filtros = 1 Then
                consulta = consulta & " AND nomina='" & TxtNom.Text & "'"
            Else
                consulta = consulta & " where nomina='" & TxtNom.Text & "'"
                filtros = 1
            End If
        End If

        If sifechapermiso.Checked Then
            If filtros = 1 Then
                consulta = consulta & " and fecha_permiso BETWEEN " & cadena & cadena2
            Else
                consulta = consulta & " where fecha_permiso BETWEEN " & cadena & cadena2
            End If

            filtros = 1
            RANGOANTES = 1
        End If

        If sifecharegreso.Checked Then
            If filtros = 1 Then
                If RANGOANTES = 1 Then
                    consulta = consulta & " OR fecha_regreso BETWEEN " & cadena & cadena2
                Else
                    consulta = consulta & " and fecha_regreso BETWEEN " & cadena & cadena2
                    RANGOANTES = 1
                End If

            Else
                consulta = consulta & " where fecha_regreso BETWEEN " & cadena & cadena2
            End If
            filtros = 1
            RANGOANTES = 1
        End If

        If sifechasalida.Checked Then
            If filtros = 1 Then
                If RANGOANTES = 1 Then
                    consulta = consulta & "  OR fecha_salida BETWEEN " & cadena & cadena2
                Else
                    consulta = consulta & "  and fecha_salida BETWEEN " & cadena & cadena2
                End If
            Else
                consulta = consulta & "  WHERE fecha_salida BETWEEN " & cadena & cadena2
            End If
            filtros = 1
        End If

        consulta = consulta & "  order by id desc"
        consultar(consulta)

        If filtros = 1 Then
            Label4.Text = "Estas Selecionando" & Chr(13) & "Con filtros"
        Else
            Label4.Text = "Estas Selecionando" & Chr(13) & "Sin filtros"
        End If

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
            Label5.Text = "Se Seleccionaron: " & dset.Tables(0).Rows.Count & " Registros"

        Catch ex As Exception
            coneccion.Close()

        End Try

    End Sub


   
    Private Sub TxtNom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNom.KeyDown

        If e.KeyValue = Keys.Enter Then
            If TxtNom.Text.Length > 0 Then
                consultar("select * from permisos where nomina='" & TxtNom.Text & "'")
                Label4.Text = "Estas Selecionando" & Chr(13) & "Con filtros"
            Else
                consultar("Select * from permisos order by id desc")
                Label4.Text = "Estas Selecionando" & Chr(13) & "Sin filtros"
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formarconsulta()

    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Gridempleados.RowCount > 0 Then
        Else
            Exit Sub
        End If
        Try
            If Gridempleados.Item(Gridempleados.Columns("comprobante").Index, Gridempleados.CurrentRow.Index).Value = "SI" Then
                Try
                    Dim consulta As String = "SELECT archivo FROM permisos where id='" & Gridempleados.Item(Gridempleados.Columns("id").Index, Gridempleados.CurrentRow.Index).Value & "'"
                    Dim coman As MySqlCommand = coneccion.CreateCommand
                    coman.CommandText = consulta
                    coneccion.Open()
                    Dim datareader As MySqlDataReader = coman.ExecuteReader(CommandBehavior.CloseConnection)

                    datareader.Read()

                    Dim bufferSize As Int32 = Convert.ToInt32(datareader.GetBytes(0, 0, Nothing, 0, 0))
                    Dim aByte(bufferSize - 1) As Byte
                    datareader.GetBytes(0, 0, aByte, 0, bufferSize)
                    Dim extension As String = Gridempleados.Item(Gridempleados.Columns("extension").Index, Gridempleados.CurrentRow.Index).Value

                    convertirdebinarioaarchivo(aByte, "visualizandoarchivo" & extension, "SI")
                    coneccion.Close()
                Catch ex As Exception
                    coneccion.Close()
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("No existe Comprobante Guardado en el Sistema :(", MsgBoxStyle.Information, "Comprobante")
            End If
        Catch ex As Exception
            MsgBox("No existe Comprobante Guardado en el Sistema :(", MsgBoxStyle.Information, "Comprobante")
        End Try

    End Sub


    Private Sub activar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activar.Click

        If MsgBox("Estas Seguro de elimnar Este Registro", MsgBoxStyle.OkCancel, "Confirmación") = vbOK Then
            Try
                varconeccion()
                coneccion.Open()
                'nueva forma de agregar
                Dim agrega As String = "delete from permisos where id='" & Gridempleados.Item(11, Gridempleados.CurrentRow.Index).Value & "'"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.ExecuteNonQuery()
                coneccion.Close()
                consultar("Select * from permisos order by id desc")

            Catch ex As Exception
                MsgBox(" No se pudo Eliminar", vbQuestion, "Error del Sistema")
                coneccion.Close()
            End Try

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            guardar.FileName = ""
            guardar.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
            guardar.Title = "Exportar a Excel"

            guardar.ShowDialog()

            If guardar.FileName.Length > 0 Then
                exportaraexcel(Gridempleados, guardar.FileName, 0)
            Else
                MsgBox("Elige donde guardar el documento", MsgBoxStyle.Critical, "Guardar a Excel")
            End If
        Catch ex As Exception

        End Try



        'MsgBox("ruta elegida: " & guardar.FileName)
    End Sub
End Class