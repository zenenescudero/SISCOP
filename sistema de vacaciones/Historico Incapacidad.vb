Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Image
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Historiincapacidad


    Dim consultaformada As String

    Private Sub Historicopermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fechasalida.Value = Date.Now
        fecharegreso.Value = Date.Now


        opcionescombo(motivo, "select distinct tipo,tipo from incapacidad")
        motivo.Text = ""
        mensaje.Text = "*vacio para " & Chr(13) & " consultar todos" & Chr(13) & "Dar Enter"
        Label4.Text = "Estas Selecionando" & Chr(13) & "Sin filtros"

        Try
            consultar("select * from incapacidad order by id desc")
            generarestructura()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub generarestructura()

        Gridempleados.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridempleados.Columns("nomina").HeaderText = "Nomina"
        Gridempleados.Columns("nombre").HeaderText = "Nombre"
        Gridempleados.Columns("tipo").HeaderText = "Tipo Incapacidad"
        Gridempleados.Columns("segurosocial").HeaderText = "Seguro Social"
        Gridempleados.Columns("dias").HeaderText = "Dias"
        Gridempleados.Columns("fecha_inicial").HeaderText = "Fecha Inicio"
        Gridempleados.Columns("fecha_final").HeaderText = "Fecha Fin"
        Gridempleados.Columns("notas").HeaderText = "Nota Adicional"
        Gridempleados.Columns("id").HeaderText = "id"
        Gridempleados.Columns("id").Visible = False

        Gridempleados.Columns("nomina").Width = 80
        Gridempleados.Columns("nombre").Width = 200
        Gridempleados.Columns("tipo").Width = 200
        Gridempleados.Columns("segurosocial").Width = 70
        Gridempleados.Columns("dias").Width = 80
        Gridempleados.Columns("fecha_inicial").Width = 90
        Gridempleados.Columns("fecha_final").Width = 90
        Gridempleados.Columns("notas").Width = 320

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
        Dim consulta As String = "select * from incapacidad "

        Try
            If motivo.Text.Length > 0 Then
                consulta = consulta & " where tipo='" & motivo.Text & "'"
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
                consulta = consulta & " and fecha_inicial BETWEEN " & cadena & cadena2
            Else
                consulta = consulta & " where fecha_inicial BETWEEN " & cadena & cadena2
            End If

            filtros = 1
            RANGOANTES = 1
        End If

        If sifecharegreso.Checked Then
            If filtros = 1 Then
                If RANGOANTES = 1 Then
                    consulta = consulta & " OR fecha_final BETWEEN " & cadena & cadena2
                Else
                    consulta = consulta & " and fecha_final BETWEEN " & cadena & cadena2
                    RANGOANTES = 1
                End If

            Else
                consulta = consulta & " where fecha_final BETWEEN " & cadena & cadena2
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

        Catch ex As Exception
            coneccion.Close()

        End Try

    End Sub



    Private Sub TxtNom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNom.KeyDown

        If e.KeyValue = Keys.Enter Then
            If TxtNom.Text.Length > 0 Then
                consultar("select * from incapacidad where nomina='" & TxtNom.Text & "'")
                Label4.Text = "Estas Selecionando" & Chr(13) & "Con filtros"
            Else
                consultar("Select * from incapacidad order by id desc")
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
        Try
            pruebadereporte(Gridempleados)

        Catch ex As Exception

        End Try
       
    End Sub

    Public Sub pruebadereporte(ByVal grid As DataGridView)
        Dim Documento As New Document 'Declaracion del documento
        Dim parrafo As New Paragraph ' Declaracion de un parrafo
        Dim error1 As Integer = 0

        While error1 = 0
            Try
                pdf.PdfWriter.GetInstance(Documento, New FileStream("REPORTE DE INCAPACIDAD.pdf", FileMode.Create)) 'Crea el archivo "DEMO.PDF
                error1 = 1
            Catch ex As Exception
                error1 = 0
                MsgBox("EL Reporte esta Abierto CIERRALO Y OPRIME ACEPTAR Para poder Continuar", MsgBoxStyle.Critical, "ARCHIVO ABIERTO")
            End Try
           
        End While

        '  Documento.SetPageSize(iTextSharp.text.PageSize.A4.Rotate())

        Documento.Open() 'Abre documento para su escritura
        parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafo.Font = FontFactory.GetFont("Arial", 10, ALIGN_CENTER) 'Asigan fuente
        parrafo.Add("TIENDAS CHEDRAUI S.A DE C.V" & Chr(13) & "MERCADERIAS TIENDAS" & Chr(13) & "REPORTE DE INCAPACIDAD" & Chr(13) & Chr(13)) 'Texto que se insertara
        Documento.Add(parrafo) 'Agrega el parrafo al documento
        parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente


        Dim tablademo As New PdfPTable(8) 'declara la tabla con 4 columnas

        tablademo.SetWidthPercentage({60, 160, 60, 100, 100, 25, 55, 55}, PageSize.A4) 'Ajusta el tamaño de cada columna

        tablademo.AddCell(New Paragraph("Nomina", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
        tablademo.AddCell(New Paragraph("Nombre", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
        tablademo.AddCell(New Paragraph("Seguro Social", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
        tablademo.AddCell(New Paragraph("Tipo incapacidad", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
        tablademo.AddCell(New Paragraph("Nota Adicional", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
        tablademo.AddCell(New Paragraph("Dias", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
        tablademo.AddCell(New Paragraph("Fecha Inicial", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
        tablademo.AddCell(New Paragraph("Fecha Final", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8

        For ciclo As Integer = 0 To grid.RowCount - 1
            tablademo.AddCell(New Paragraph("" & grid.Item(0, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo.AddCell(New Paragraph("" & grid.Item(1, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph("" & grid.Item(3, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo.AddCell(New Paragraph("" & grid.Item(2, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph("" & grid.Item(7, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo.AddCell(New Paragraph("" & grid.Item(4, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph("" & grid.Item(5, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph("" & grid.Item(6, ciclo).Value, FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
        Next
        Documento.Add(tablademo)
        Documento.Close() 'Cierra el documento
        System.Diagnostics.Process.Start("REPORTE DE INCAPACIDAD.pdf") 'Abre el archivo DEMO.PDF
    End Sub

    Private Sub activar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activar.Click

        If MsgBox("Estas Seguro de elimnar Este Registro", MsgBoxStyle.OkCancel, "Confirmación") = vbOK Then
            Try
                varconeccion()
                coneccion.Open()
                'nueva forma de agregar
                Dim agrega As String = "delete from incapacidad where id='" & Gridempleados.Item(Gridempleados.Columns("id").Index, Gridempleados.CurrentRow.Index).Value & "'"
                Dim comando As New MySqlCommand(agrega, coneccion)
                comando.CommandType = CommandType.Text
                comando.ExecuteNonQuery()
                coneccion.Close()
                consultar("Select * from incapacidad order by id desc")

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

    Private Sub fecharegreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecharegreso.ValueChanged

    End Sub

    Private Sub TxtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNom.TextChanged

    End Sub
End Class