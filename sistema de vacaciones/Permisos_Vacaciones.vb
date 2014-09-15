Imports MySql.Data.MySqlClient
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Image
Imports System.IO

Public Class Permisos_vacaciones

    Dim encontro As Integer = 0
    Dim vardisponibles As Double = 0
    Dim varsolicitar As Double = 0
    Dim varfaltan As Double = 0
    Dim fecha_ingreso As Date
    Dim anios As Integer = 0


    Private Sub Permisos_Salida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecharegreso.Value = Date.Now
        fechasalida.Value = Date.Now
        opcionescombo(empleado, "select no_nomina,nombre from vicolaborador order by nombre")
        opcionescombo(jefeinmediato, "select * from jefes order by id")
        opcionescombo(depto, "select id,descripcion from depto order by id")
        opcionescombo(subgerente, "select id,nombre from subgerente order by id")
        opcionescombo(gerente, "select id,nombre from gerente order by id")
        opcionescombo(empresabox, "select id,nombre from empresa order by id")
    End Sub

    Public Sub generarestructura()
        Gridpermisos.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)
        Gridpermisos.Columns("nomina").HeaderText = "Nomina"
        Gridpermisos.Columns("fecha_ingreso").HeaderText = "Fecha de Ingreso"
        Gridpermisos.Columns("antiguedad").HeaderText = "Antiguedad"
        Gridpermisos.Columns("asignados").HeaderText = "Asignados"
        Gridpermisos.Columns("dias_tomados").HeaderText = "Dias Tomados"
        Gridpermisos.Columns("fecha_inicio").HeaderText = "Fecha De Salida"
        Gridpermisos.Columns("fecha_fin").HeaderText = "Fecha de regreso"
        Gridpermisos.Columns("nota").HeaderText = "Nota Adicional"
        Gridpermisos.Columns("id").Visible = False

        Gridpermisos.Columns("nomina").Width = 100
        Gridpermisos.Columns("fecha_ingreso").Width = 100
        Gridpermisos.Columns("antiguedad").Width = 100
        Gridpermisos.Columns("asignados").Width = 100
        Gridpermisos.Columns("dias_tomados").Width = 100
        Gridpermisos.Columns("fecha_inicio").Width = 100
        Gridpermisos.Columns("fecha_fin").Width = 100
        Gridpermisos.Columns("nota").Width = 350
    End Sub

    Public Sub datos(ByVal consulta As String)

        Try
            solicitar.Text = "0"
            faltan.Text = "0"

            varconeccion()
            coneccion.Open()
            Dim dsetdatos As New DataSet
            Dim dadaptador As New MySqlDataAdapter

            dadaptador.SelectCommand = New MySqlCommand(consulta, coneccion)
            dadaptador.Fill(dsetdatos)
            coneccion.Close()

            nomina.Text = dsetdatos.Tables(0).Rows(0)(0)
            depto.Text = dsetdatos.Tables(0).Rows(0)(3)
            jefeinmediato.Text = dsetdatos.Tables(0).Rows(0)(4)
            subgerente.Text = dsetdatos.Tables(0).Rows(0)(5)
            gerente.Text = dsetdatos.Tables(0).Rows(0)(6)
            empleado.Text = dsetdatos.Tables(0).Rows(0)(2)
            disponibles.Text = dsetdatos.Tables(0).Rows(0)(8)
            empresabox.Text = dsetdatos.Tables(0).Rows(0)(1)
            fecha_ingreso = dsetdatos.Tables(0).Rows(0)(9)
            anios = dsetdatos.Tables(0).Rows(0)(10)
            Label12.Text = "Antiguedad En la Empresa:  " & Math.Round(DateDiff(DateInterval.Day, fecha_ingreso, Date.Now) / 365, 2) & " Años"

            encontro = 1

        Catch ex As Exception

            coneccion.Close()
            MsgBox("No se encontraron datos", MsgBoxStyle.Critical, "Resultado")
            nomina.Text = ""
            empleado.Text = ""
            jefeinmediato.Text = ""
            subgerente.Text = ""
            gerente.Text = ""
            empresabox.Text = ""
            encontro = 0

        End Try

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nomina.KeyDown
        If e.KeyValue = Keys.Enter Then
            datos("select no_nomina,empresa,nombre,departamento,jefe_inmediato,subgerente,gerente,antiguedad,dias_vac,fecha_ingreso,antiguedad from vicolaborador where no_nomina= '" & nomina.Text & "'")
            consultar("select nomina,fecha_ingreso,antiguedad,asignados,dias_tomados,fecha_inicio,fecha_fin,nota,id from bitacora where nomina= '" & nomina.Text & "' order by fecha_inicio desc")
        End If

    End Sub

    Private Sub empleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleado.SelectedIndexChanged

        Try
            datos("select no_nomina,empresa,nombre,departamento,jefe_inmediato,subgerente,gerente,antiguedad,dias_vac,fecha_ingreso,antiguedad from vicolaborador where no_nomina= '" & empleado.SelectedValue & "'")
            consultar("select nomina,fecha_ingreso,antiguedad,asignados,dias_tomados,fecha_inicio,fecha_fin,nota,id from bitacora where nomina='" & empleado.SelectedValue & "' order by fecha_inicio desc")
        Catch ex As Exception

        End Try

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
            Gridpermisos.DataSource = dtable
            generarestructura()

        Catch ex As Exception
            coneccion.Close()
        End Try

    End Sub
    Function validar() As Integer

        Dim resul As Integer = 0
       
        If Not IsNumeric(jefeinmediato.SelectedValue) Or Not IsNumeric(depto.SelectedValue) Or Not IsNumeric(subgerente.SelectedValue) Or Not IsNumeric(gerente.SelectedValue) Or Not IsNumeric(empresabox.SelectedValue) Then
            MsgBox("Deves Utilizar los Valores de La lista, no se permite agregar datos Manualmente", MsgBoxStyle.Critical, "Error Seleccion de Lista")
            resul = 1
        End If
        If vardisponibles < varsolicitar Then
            MsgBox("No Tienes Dias Suficientes Para Vacaciones", MsgBoxStyle.Critical, "Vacaciones")
            resul = 1
        End If

        Return resul

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If encontro = 0 Then
                MsgBox("No existen Datos Validos" & Chr(13) & "Selecciona Un empleado Registrado", MsgBoxStyle.Critical, "Permisos")
                Exit Sub
            End If
            If solicitar.Text.Length < 1 Or varsolicitar = 0 Then
                MsgBox("No estas Solicitando dias", MsgBoxStyle.Critical, "Error Vacaciones")
                Exit Sub
            End If
            If Not IsNumeric(empresabox.SelectedValue) Or Not IsNumeric(depto.SelectedValue) Or Not IsNumeric(jefeinmediato.SelectedValue) Or Not IsNumeric(subgerente.SelectedValue) Or Not IsNumeric(gerente.SelectedValue) Then
                MsgBox("No estas seleccionando De la lista", MsgBoxStyle.Critical, "Error al Seleccionar de la lista")
                Exit Sub
            End If

            If validar() = 0 Then
                registrar()
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un Error", MsgBoxStyle.Critical, "Error Vacaciones")
        End Try

    End Sub

 

    Public Sub pruebadereporte()

        Dim Documento As New Document 'Declaracion del documento
        Dim parrafo As New Paragraph ' Declaracion de un parrafo
        Dim error1 As Integer = 0
        Dim pdfw As iTextSharp.text.pdf.PdfWriter

        While (error1 = 0)
            Try
                pdfw = pdf.PdfWriter.GetInstance(Documento, New FileStream("Permiso Vac.pdf", FileMode.Create)) 'Crea el archivo "DEMO.PDF
                error1 = 1
            Catch ex As Exception
                MsgBox("EL Reporte esta Abierto CIERRALO Y OPRIME ACEPTAR Para poder Continuar", MsgBoxStyle.Critical, "ARCHIVO ABIERTO")
                error1 = 0
            End Try
        End While

        Documento.Open() 'Abre documento para su escritura
        parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafo.Font = FontFactory.GetFont("Arial", 12, ALIGN_CENTER) 'Asigan fuente
        parrafo.Add(Chr(13) & empresabox.Text & Chr(13) & "MERCADERIAS" & Chr(13) & "AVISO DE VACACIONES" & Chr(13) & Chr(13)) 'Texto que se insertara
        Documento.Add(parrafo) 'Agrega el parrafo al documento

        parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
        Documento.Add(New Paragraph("" & Chr(13)))
        Documento.Add(New Paragraph("" & Chr(13)))
        Documento.Add(New Paragraph("" & Chr(13)))

        Dim tab As New PdfPTable(1)
        tab.SetWidthPercentage({580}, PageSize.A4)
        Dim t1 As New PdfPCell(New Paragraph("PARA: JEFE DE PERSONAL                                                                               " & Date.Now.ToShortDateString & Chr(13) & "DE: GERENCIA DE MERCADERIAS"))
        t1.Border = 0
        tab.AddCell(t1)
        Documento.Add(tab)

        Dim tabla2 As New PdfPTable(1)
        tabla2.SetWidthPercentage({550}, PageSize.A4)

        Dim cuerpodoc As New Paragraph
        cuerpodoc.Font = FontFactory.GetFont("Arial", 12)

        Dim negrita As New Chunk
        negrita = New Chunk(empleado.Text, FontFactory.GetFont("Arial", 12, 1))

        cuerpodoc.Add(Chr(13) & Chr(13) & "                Informo a Usted que el C.  ")
        cuerpodoc.Add(negrita)
        cuerpodoc.Add(" con número de colaborador  ")
        negrita = New Chunk(nomina.Text, FontFactory.GetFont("Arial", 12, 1))
        cuerpodoc.Add(negrita)
        cuerpodoc.Add("  perteneciente al Departamento de ")
        negrita = New Chunk(depto.Text, FontFactory.GetFont("Arial", 12, 1))
        cuerpodoc.Add(negrita)
        cuerpodoc.Add("   disfrutará de ")
        negrita = New Chunk(solicitar.Text, FontFactory.GetFont("Arial", 12, 1))
        cuerpodoc.Add(negrita)
        cuerpodoc.Add(" Dia(s) hábil(es) de vacaciones , A partir del periodo Señalado." & Chr(13) & Chr(13) & Chr(13) & Chr(13))

        Dim c21 As New PdfPCell(New Paragraph(cuerpodoc))
        cuerpodoc.Clear()

        c21.Border = 0
        c21.HorizontalAlignment = Element.ALIGN_JUSTIFIED
        tabla2.AddCell(c21)

        Documento.Add(tabla2)

        Dim tabla3 As New PdfPTable(3)
        tabla3.SetWidthPercentage({185, 185, 190}, PageSize.A4)
        Dim c31 As New PdfPCell(New Paragraph("Fecha de Salida: " & Chr(13) & " " & fechasalida.Text, FontFactory.GetFont("Arial", 12)))
        'c31.Border = 0
        Dim c32 As New PdfPCell(New Paragraph("Fecha de Regreso: " & Chr(13) & " " & fecharegreso.Text, FontFactory.GetFont("Arial", 12)))
        'c32.Border = 0
        Dim c33 As New PdfPCell(New Paragraph("Vacaciones Pendientes: " & Chr(13) & " " & faltan.Text & "  Dias", FontFactory.GetFont("Arial", 12)))
        ' c33.Border = 0

        tabla3.AddCell(c31)
        tabla3.AddCell(c32)
        tabla3.AddCell(c33)
        Documento.Add(tabla3)
        Documento.Add(New Paragraph(Chr(13) & Chr(13)))

        Dim auto As New PdfPTable(3)
        auto.SetWidthPercentage({150, 250, 160}, PageSize.A4)
       
        Dim cel As New PdfPCell
        cel = New PdfPCell(New Paragraph("" & Chr(13) & Chr(13) & "Autorizado Por" & Chr(13) & Chr(13) & Chr(13), FontFactory.GetFont("Arial", 12, 1)))
        cel.HorizontalAlignment = Element.ALIGN_CENTER
        cel.Border = 0
        cel.Colspan = 3

        auto.AddCell(cel)
        Documento.Add(auto)

        Dim firmas As New PdfPTable(3)
        firmas.SetWidthPercentage({200, 200, 200}, PageSize.A4)
        Dim cadena As String = "" & "" & Chr(13) & "" & Chr(13) & "" & Chr(13) & "" & Chr(13) & ""
        Dim celda1 As New PdfPCell
        Dim celda2 As New PdfPCell
        Dim celda3 As New PdfPCell
        Dim emple As Integer = 0
        If jefeinmediato.SelectedValue > 1 Then
            cuerpodoc.Add(cadena & "_______________________" & Chr(13) & "" & jefeinmediato.Text & "" & Chr(13))
            negrita = New Chunk("JEFE INMEDIATO", FontFactory.GetFont("Arial", 12, 1))
            cuerpodoc.Add(negrita)
            celda1 = New PdfPCell(New Paragraph(cuerpodoc))
            cuerpodoc.Clear()
            celda1.HorizontalAlignment = Element.ALIGN_CENTER
            celda1.Border = 0
            firmas.AddCell(celda1)
        Else
            cuerpodoc.Add(cadena & "_______________________" & Chr(13) & "" & empleado.Text & "" & Chr(13))
            negrita = New Chunk("SOLICITANTE", FontFactory.GetFont("Arial", 12, 1))
            cuerpodoc.Add(negrita)
            celda1 = New PdfPCell(New Paragraph(cuerpodoc))
            cuerpodoc.Clear()

            celda1.HorizontalAlignment = Element.ALIGN_CENTER
            celda1.Border = 0
            firmas.AddCell(celda1)
            emple = 1
        End If

        cuerpodoc.Add(cadena & "_______________________" & Chr(13) & "" & gerente.Text & "" & Chr(13))
        negrita = New Chunk("GERENTE", FontFactory.GetFont("Arial", 12, 1))
        cuerpodoc.Add(negrita)
        celda2 = New PdfPCell(New Paragraph(cuerpodoc))
        cuerpodoc.Clear()
        celda2.HorizontalAlignment = Element.ALIGN_CENTER
        celda2.Border = 0
        firmas.AddCell(celda2)

        Dim jp As Integer = 0

        If subgerente.SelectedValue > 1 Then
            cuerpodoc.Add(cadena & "____________________" & Chr(13) & "" & subgerente.Text & "" & Chr(13))
            negrita = New Chunk("SUBGERENTE", FontFactory.GetFont("Arial", 12, 1))
            cuerpodoc.Add(negrita)
            celda3 = New PdfPCell(New Paragraph(cuerpodoc))
            celda3.HorizontalAlignment = Element.ALIGN_CENTER
            celda3.Border = 0
            firmas.AddCell(celda3)
            cuerpodoc.Clear()
        Else

            If emple = 0 Then
                cuerpodoc.Add(cadena & "_______________________" & Chr(13) & "" & empleado.Text & "" & Chr(13))
                negrita = New Chunk("SOLICITANTE", FontFactory.GetFont("Arial", 12, 1))
                cuerpodoc.Add(negrita)
                celda3 = New PdfPCell(New Paragraph(cuerpodoc))
                cuerpodoc.Clear()
                celda3.HorizontalAlignment = Element.ALIGN_CENTER
                celda3.Border = 0
                firmas.AddCell(celda3)
                emple = 1
            Else
                cuerpodoc.Add(cadena & "_______________________" & Chr(13))
                negrita = New Chunk("JEFE DE PERSONAL", FontFactory.GetFont("Arial", 12, 1))
                cuerpodoc.Add(negrita)
                celda3 = New PdfPCell(New Paragraph(cuerpodoc))
                cuerpodoc.Clear()
                celda3.HorizontalAlignment = Element.ALIGN_CENTER
                celda3.Border = 0
                firmas.AddCell(celda3)
                jp = 1

            End If

        End If

        Dim n1 As New PdfPCell
        Dim n2 As New PdfPCell
        Dim n3 As New PdfPCell

        If emple = 0 Then
            cuerpodoc.Add(cadena & "_______________________" & Chr(13) & "" & empleado.Text & "" & Chr(13))
            negrita = New Chunk("SOLICITA", FontFactory.GetFont("Arial", 12, 1))
            cuerpodoc.Add(negrita)
            n1 = New PdfPCell(New Paragraph(cuerpodoc))
            cuerpodoc.Clear()
            n1.HorizontalAlignment = Element.ALIGN_CENTER
            n1.Border = 0
            firmas.AddCell(n1)
            emple = 1
        Else

            If jp = 0 Then
                cuerpodoc.Add(cadena & "_______________________" & Chr(13) & "")
                negrita = New Chunk("JEFE DE PERSONAL", FontFactory.GetFont("Arial", 12, 1))
                cuerpodoc.Add(negrita)
                n1 = New PdfPCell(New Paragraph(cuerpodoc))
                cuerpodoc.Clear()
                n1.HorizontalAlignment = Element.ALIGN_CENTER
                n1.Border = 0
                firmas.AddCell(n1)
                jp = 1
            Else
                n1.Border = 0
                firmas.AddCell(n1)
            End If
        End If

        n2 = New PdfPCell(New Paragraph(cadena & Chr(13) & Chr(13)))
        n2.Border = 0
        firmas.AddCell(n2)

        If jp = 0 Then
            cuerpodoc.Add(cadena & "_______________________" & Chr(13))
            negrita = New Chunk("JEFE DE PERSONAL", FontFactory.GetFont("Arial", 12, 1))
            cuerpodoc.Add(negrita)
            n3 = New PdfPCell(New Paragraph(cuerpodoc))
            cuerpodoc.Clear()
            n3.HorizontalAlignment = Element.ALIGN_CENTER
            n3.Border = 0
            firmas.AddCell(n3)
            jp = 1
        Else
            n3.Border = 0
            firmas.AddCell(n3)
        End If

        Documento.Add(firmas)

        Documento.Add(New Paragraph(Chr(13) & Chr(13) & Chr(13) & Chr(13) & "Ccp. Interesado                                                                                        Ingreso: " & fecha_ingreso & Chr(13) & "Ccp. Archivo                                                                                         " & "  Antiguedad " & Math.Round(DateDiff(DateInterval.Day, fecha_ingreso, Date.Now) / 365, 2) & " Años"))

        'prueba de rectangulo
        Dim rectangulo As PdfContentByte
        rectangulo = pdfw.DirectContent

        rectangulo.SetLineWidth(2)
        rectangulo.SetColorStroke(BaseColor.BLACK)
        rectangulo.Rectangle(30.0F, 45.0F, 530.0F, 750.0F)
        rectangulo.Stroke()

        Documento.Close() 'Cierra el documento
        'Abre el archivo DEMO.PDF

    End Sub
    Public Sub registrar()
      
        pruebadereporte()
        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "call registropermisovac(@nomina,@dias,@fecha_in,@fecha_fin,@nota,@restan,@archivo,@extension,@comprobante)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@nomina", nomina.Text)
            comando.Parameters.AddWithValue("@dias", varsolicitar)
            comando.Parameters.AddWithValue("@fecha_in", fechasalida.Value)
            comando.Parameters.AddWithValue("@fecha_fin", fecharegreso.Value)
            comando.Parameters.AddWithValue("@nota", TextBox2.Text)
            comando.Parameters.AddWithValue("@restan", varfaltan)
            comando.Parameters.AddWithValue("@archivo", convertirabinario("Permiso Vac.pdf"))
            comando.Parameters.AddWithValue("@extension", ".pdf")
            comando.Parameters.AddWithValue("@comprobante", "SI")
            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Permiso generado con exito", MsgBoxStyle.Information, "Permiso")
            System.Diagnostics.Process.Start("Permiso Vac.pdf")
            Me.Close()
        Catch ex As Exception
            MsgBox(" No se pudo Generar el Permiso", vbQuestion, "Error del Sistema" & ex.ToString)
            coneccion.Close()
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub


    Private Sub solicitar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles solicitar.TextChanged
        Try
            vardisponibles = disponibles.Text
            varsolicitar = solicitar.Text
            varfaltan = vardisponibles - varsolicitar
            faltan.Text = varfaltan
        Catch ex As Exception
            varfaltan = 0
            faltan.Text = varfaltan
        End Try



    End Sub

    Private Sub solicitar_CursorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles solicitar.LostFocus
        Try
            If solicitar.Text.Length < 1 Then
                MsgBox("Valor no Valido en Dias a Solicitar", MsgBoxStyle.Critical, "Error de Sistema")

                solicitar.Text = "0"
                faltan.Text = 0

            End If
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub solicitar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles solicitar.KeyPress, nomina.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        pruebadereporte()
        Try
            System.Diagnostics.Process.Start("Permiso Vac.pdf")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub


    Private Sub nomina_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nomina.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub fechasalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechasalida.ValueChanged
    

    End Sub
End Class