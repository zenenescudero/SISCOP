
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Image
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Historicovac

    Dim consultaformada As String

    Private Sub Historicopermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecharegreso.Value = Date.Now
        fechasalida.Value = Date.Now

        opcionescombo(motivo, "select distinct antiguedad,antiguedad from bitacora")
        motivo.Text = ""
        mensaje.Text = "*vacio para " & Chr(13) & " consultar todos" & Chr(13) & "Dar Enter"
        Label4.Text = "Estas Selecionando" & Chr(13) & "Sin filtros"

        Try
            consultar("select * from vibitacora order by id desc")
            generarestructura()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub generarestructura()

        Gridempleados.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridempleados.Columns("nombre").HeaderText = "Nombre"
        Gridempleados.Columns("nomina").HeaderText = "Nomina"
        Gridempleados.Columns("fecha_ingreso").HeaderText = "Fecha de Ingreso"
        Gridempleados.Columns("antiguedad").HeaderText = "Antiguedad"
        Gridempleados.Columns("asignados").HeaderText = "Dias Asignados"
        Gridempleados.Columns("dias_tomados").HeaderText = "Dias Tomados"
        Gridempleados.Columns("dias_vac").HeaderText = "Dias Disponibles"
        Gridempleados.Columns("fecha_inicio").HeaderText = "Fecha Salida"
        Gridempleados.Columns("fecha_fin").HeaderText = "Fecha Regreso"
        Gridempleados.Columns("nota").HeaderText = "Nota Adicional"
        Gridempleados.Columns("id").HeaderText = "id"
        Gridempleados.Columns("extension").HeaderText = "extension"
        Gridempleados.Columns("comprobante").HeaderText = "Comprobante"
        Gridempleados.Columns("extension").Visible = False

        Gridempleados.Columns("id").Visible = False
        Gridempleados.Columns("dias_vac").Visible = False

        Gridempleados.Columns("nomina").Width = 100
        Gridempleados.Columns("nombre").Width = 200
        Gridempleados.Columns("fecha_ingreso").Width = 100
        Gridempleados.Columns("antiguedad").Width = 80
        Gridempleados.Columns("asignados").Width = 80
        Gridempleados.Columns("dias_tomados").Width = 80
        Gridempleados.Columns("dias_vac").Width = 80
        Gridempleados.Columns("fecha_inicio").Width = 90
        Gridempleados.Columns("fecha_fin").Width = 90
        Gridempleados.Columns("nota").Width = 320

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
        Dim consulta As String = "select * from vibitacora "

        Try
            If motivo.Text.Length > 0 Then
                consulta = consulta & " where antiguedad='" & motivo.Text & "'"
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

        If sifechasalida.Checked Then
            If filtros = 1 Then
                consulta = consulta & " and fecha_inicio BETWEEN " & cadena & cadena2
            Else
                consulta = consulta & " where fecha_inicio BETWEEN " & cadena & cadena2
            End If

            filtros = 1
            RANGOANTES = 1
        End If

        If sifecharegreso.Checked Then
            If filtros = 1 Then
                If RANGOANTES = 1 Then
                    consulta = consulta & " OR fecha_fin BETWEEN " & cadena & cadena2
                Else
                    consulta = consulta & " and fecha_fin BETWEEN " & cadena & cadena2
                    RANGOANTES = 1
                End If

            Else
                consulta = consulta & " where fecha_fin BETWEEN " & cadena & cadena2
            End If
            filtros = 1
            RANGOANTES = 1
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
            If TxtNom.Text.Length > 0 Then

                Label9.Text = "Dias Disponibles  " & dset.Tables(0).Rows(0)(6)

            Else

                Label9.Text = "Dias Disponibles"

            End If
        Catch ex As Exception
            coneccion.Close()

        End Try

    End Sub



    Private Sub TxtNom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNom.KeyDown

        If e.KeyValue = Keys.Enter Then
            If TxtNom.Text.Length > 0 Then
                consultar("select * from vibitacora where nomina='" & TxtNom.Text & "'")
                Label4.Text = "Estas Selecionando" & Chr(13) & "Con filtros"
                opcionescombo(motivo, "Select distinct antiguedad,antiguedad from bitacora where nomina='" & TxtNom.Text & "'")
            Else
                consultar("Select * from vibitacora order by id desc")
                opcionescombo(motivo, "select distinct antiguedad,antiguedad from bitacora")
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
                    Dim consulta As String = "SELECT archivo FROM bitacora where id='" & Gridempleados.Item(Gridempleados.Columns("id").Index, Gridempleados.CurrentRow.Index).Value & "'"
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
                Dim agrega As String = "call eliminarvac(@nomina1,@id1,@antiguedad1,@dias)"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.Parameters.AddWithValue("@nomina1", Gridempleados.Item(1, Gridempleados.CurrentRow.Index).Value)
                comando.Parameters.AddWithValue("@id1", Gridempleados.Item(10, Gridempleados.CurrentRow.Index).Value)
                comando.Parameters.AddWithValue("@antiguedad1", Gridempleados.Item(3, Gridempleados.CurrentRow.Index).Value)
                comando.Parameters.AddWithValue("@dias", Gridempleados.Item(5, Gridempleados.CurrentRow.Index).Value)

                comando.ExecuteNonQuery()
                coneccion.Close()
                consultar("Select * from vibitacora order by id desc")

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
                exportaraexcel(Gridempleados, guardar.FileName, 1)
            Else
                MsgBox("Elige donde guardar el documento", MsgBoxStyle.Critical, "Guardar a Excel")
            End If
        Catch ex As Exception
        End Try

        'MsgBox("ruta elegida: " & guardar.FileName)
    End Sub

  
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        Dim suma As Integer = 0
        If CheckBox1.Checked Then

            If TxtNom.Text.Length > 0 And motivo.Text.Length > 0 Then
                For x As Integer = 0 To Gridempleados.RowCount - 1
                    If TxtNom.Text = Gridempleados.Item(1, x).Value And motivo.Text = Gridempleados.Item(3, x).Value Then
                        suma = suma + Gridempleados.Item(5, x).Value
                    End If

                Next
                Label8.Text = suma & " Dias Disfrutados"
                Label8.Visible = True
            Else
                Label8.Visible = False
                Label8.Text = ""
            End If
        Else
            Label8.Visible = False



        End If
    End Sub
End Class