Imports MySql.Data.MySqlClient
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Image
Imports System.IO

Public Class Permisos_Salida

    Dim encontro As Integer = 0
    Dim empresa As String = ""

    Private Sub Permisos_Salida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fechapermiso.Value = Date.Now
        fecharegreso.Value = Date.Now
        fechasalida.Value = Date.Now
        opcionescombo(empleado, "select no_nomina,nombre from vicolaborador order by nombre")
        opcionescombo(jefeinmediato, "select * from jefes order by id")
        opcionescombo(depto, "select id,descripcion from depto order by id")
        opcionescombo(subgerente, "select id,nombre from subgerente order by id")
        opcionescombo(gerente, "select id,nombre from gerente order by id")


    End Sub

    Public Sub generarestructura()
        Gridpermisos.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridpermisos.Columns("nomina").HeaderText = "Nomina"
        Gridpermisos.Columns("nombre").HeaderText = "Nombre"
        Gridpermisos.Columns("motivo").HeaderText = "Motivo"
        Gridpermisos.Columns("nota").HeaderText = "Nota Adicional"
        Gridpermisos.Columns("fecha_permiso").HeaderText = "Fecha_Permiso"
        Gridpermisos.Columns("duracion").HeaderText = "Duracion"
        Gridpermisos.Columns("de").HeaderText = "De"
        Gridpermisos.Columns("a").HeaderText = "A"
        Gridpermisos.Columns("dias_completos").HeaderText = "Dias Completos"
        Gridpermisos.Columns("fecha_salida").HeaderText = "Fecha De Salida"
        Gridpermisos.Columns("fecha_regreso").HeaderText = "Fecha de regreso"

        Gridpermisos.Columns("id").Visible = False

        Gridpermisos.Columns("nomina").Width = 100
        Gridpermisos.Columns("nombre").Width = 200
        Gridpermisos.Columns("motivo").Width = 200
        Gridpermisos.Columns("nota").Width = 200
        Gridpermisos.Columns("fecha_permiso").Width = 100
        Gridpermisos.Columns("duracion").Width = 60
        Gridpermisos.Columns("de").Width = 50
        Gridpermisos.Columns("a").Width = 50
        Gridpermisos.Columns("dias_completos").Width = 50
        Gridpermisos.Columns("fecha_salida").Width = 100
        Gridpermisos.Columns("fecha_regreso").Width = 100

    End Sub

    Public Sub datos(ByVal consulta As String)

        Try
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
            empresa = dsetdatos.Tables(0).Rows(0)(1)

            encontro = 1
        Catch ex As Exception
            coneccion.Close()
            MsgBox("No se encontraron datos", MsgBoxStyle.Critical, "Resultado")
            nomina.Text = ""
            jefeinmediato.Text = ""
            depto.Text = ""
            subgerente.Text = ""
            gerente.Text = ""
            encontro = 0
        End Try

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nomina.KeyDown
        If e.KeyValue = Keys.Enter Then
            datos("select no_nomina,empresa,nombre,departamento,jefe_inmediato,subgerente,gerente from vicolaborador where no_nomina= '" & nomina.Text & "'")
            consultar("select nomina,nombre,motivo,nota,fecha_permiso,duracion,de,a,dias_completos,fecha_salida,fecha_regreso,id from permisos where nomina= '" & nomina.Text & "' order by id desc")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            fecharegreso.Visible = True
            fechasalida.Visible = True
            dias.Visible = True
            de.Text = ""
            a.Text = ""
            duracion.Text = ""
            Label8.Text = "Fecha De Impresión"

        Else
            Label8.Text = "Fecha De Salida"
            Label13.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            fecharegreso.Visible = False
            fechasalida.Visible = False
            dias.Visible = False

        End If
    End Sub

    Private Sub empleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleado.SelectedIndexChanged

        Try
            datos("select no_nomina,empresa,nombre,departamento,jefe_inmediato,subgerente,gerente from vicolaborador where no_nomina= '" & empleado.SelectedValue & "'")
            consultar("select nomina,nombre,motivo,nota,fecha_permiso,duracion,de,a,dias_completos,fecha_salida,fecha_regreso,id from permisos where nomina='" & empleado.SelectedValue & "' order by id desc")
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

    Public Function validar() As Integer
        Dim x As Integer = 0
        dias.BackColor = Color.White
        duracion.BackColor = Color.White
        de.BackColor = Color.White
        a.BackColor = Color.White

        If CheckBox1.Checked Then

            If dias.Text.Length < 1 Then
                ' MessageBox.Show("No existe el valor de dias")
                dias.BackColor = Color.LightYellow
                x = 1
            End If

            If fechasalida.Value > fecharegreso.Value Then
                MessageBox.Show("Las fechas Estan mal Asignadas," & Chr(13) & " Fecha de Salida no puede ser menor a Fecha Regreso")
                x = 1
            End If

        Else

            If duracion.Text.Length < 2 Then
                '  MessageBox.Show("Asigna la duracion")
                duracion.BackColor = Color.LightYellow
                x = 1
            End If

            If de.Text.Length < 2 Then
                '  MessageBox.Show("No contiene datos de...")
                de.BackColor = Color.LightYellow
                x = 1
            End If
            If a.Text.Length < 2 Then
                '  MessageBox.Show("No contiene datos a...")
                a.BackColor = Color.LightYellow
                x = 1
            End If

        End If

        If x = 1 Then
            MsgBox("No se puede Generar el Permiso Errores en Color AMARILLO", MsgBoxStyle.Critical, "Error de Validación")
        End If


        Return x

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If motivo.Text.Length < 1 Then
            MsgBox("Deves Asignar un Motivo", MsgBoxStyle.Critical, "")

        End If

        If encontro = 1 Then
            If validar() = 0 Then
                registrar()
            End If

        Else
            MsgBox("No Existen Datos de Empleado Selecciona Otro", MsgBoxStyle.Critical, "Permisos")
        End If

    End Sub

    Public Sub pruebadereporte()

        Dim Documento As New Document 'Declaracion del documento
        Dim parrafo As New Paragraph ' Declaracion de un parrafo

        Dim error1 As Integer = 0

        While error1 = 0
            Try
                pdf.PdfWriter.GetInstance(Documento, New FileStream("Permiso Salida.pdf", FileMode.Create)) 'Crea el archivo "DEMO.PDF
                error1 = 1
            Catch ex As Exception
                error1 = 0
                MsgBox("EL Reporte esta Abierto CIERRALO Y OPRIME ACEPTAR Para poder Continuar", MsgBoxStyle.Critical, "ARCHIVO ABIERTO")
            End Try

        End While

        '  Documento.SetPageSize(iTextSharp.text.PageSize.A4.Rotate())

        Documento.Open() 'Abre documento para su escritura
        parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
        parrafo.Font = FontFactory.GetFont("Arial", 11, ALIGN_CENTER) 'Asigan fuente
        parrafo.Add(empresa & Chr(13) & "MERCADERIAS" & Chr(13) & "Permiso de Salida" & Chr(13) & Chr(13)) 'Texto que se insertara
        Documento.Add(parrafo) 'Agrega el parrafo al documento
        parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente

        Dim tabla1 As New PdfPTable(1)
        tabla1.SetWidthPercentage({640}, PageSize.A4)
        tabla1.SkipLastFooter = True
        tabla1.AddCell(New Paragraph("DATOS DEL COLABORADOR", FontFactory.GetFont("Arial", 10)))
        Documento.Add(tabla1)

        Dim tablademo As New PdfPTable(4) 'declara la tabla con 4 columnas
        tablademo.SetWidthPercentage({100, 220, 220, 100}, PageSize.A4) 'Ajusta el tamaño de cada columna
        tablademo.AddCell(New Paragraph("Nomina: " & Chr(13) & nomina.Text, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
        tablademo.AddCell(New Paragraph("Colaborador: " & Chr(13) & empleado.Text, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
        tablademo.AddCell(New Paragraph("Departamento: " & Chr(13) & depto.Text, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
        If CheckBox1.Checked Then
            tablademo.AddCell(New Paragraph("Fecha de Impresión: " & Chr(13) & fechapermiso.Text, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
        Else
            tablademo.AddCell(New Paragraph("Fecha de Salida: " & Chr(13) & fechapermiso.Text, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
        End If
         Documento.Add(tablademo)

        Dim tabla2 As New PdfPTable(1)
        tabla2.SetWidthPercentage({640}, PageSize.A4)

        tabla2.AddCell(New Paragraph("Motivo: " & Chr(13) & " " & motivo.Text & " " & Chr(13), FontFactory.GetFont("Arial", 10)))
        ' If TextBox2.Text.Length > 0 Then
        'tabla2.AddCell(New Paragraph("Nota Adicional: " & Chr(13) & " " & TextBox2.Text & " " & Chr(13), FontFactory.GetFont("Arial", 11)))
        ' Else
        'tabla2.AddCell(New Paragraph("Nota Adicional: " & Chr(13) & " " & TextBox2.Text & " " & Chr(13) & Chr(13), FontFactory.GetFont("Arial", 11)))

        ' End If
        Documento.Add(tabla2)


        Dim tabla3 As New PdfPTable(3)
        tabla3.SetWidthPercentage({210, 220, 210}, PageSize.A4)
        If CheckBox1.Checked Then
            tabla3.AddCell(New Paragraph("Fecha de Salida: " & " " & fechasalida.Text, FontFactory.GetFont("Arial", 10)))
            tabla3.AddCell(New Paragraph("Fecha de Regreso: " & " " & fecharegreso.Text, FontFactory.GetFont("Arial", 10)))
            tabla3.AddCell(New Paragraph("Dias Otorgados: " & " " & dias.Text, FontFactory.GetFont("Arial", 10)))

        Else
            tabla3.AddCell(New Paragraph("Hora de Salida: " & " " & de.Text, FontFactory.GetFont("Arial", 10)))
            tabla3.AddCell(New Paragraph("Hora de LLegada: " & " " & a.Text, FontFactory.GetFont("Arial", 10)))
            tabla3.AddCell(New Paragraph("Tiempo Estimado: " & " " & duracion.Text, FontFactory.GetFont("Arial", 10)))
        End If
        Documento.Add(tabla3)

        Dim auto As New PdfPTable(1)
        auto.SetWidthPercentage({640}, PageSize.A4)
        Dim cel As New PdfPCell
        cel = New PdfPCell(New Paragraph("", FontFactory.GetFont("Arial", 10)))
        cel.HorizontalAlignment = Element.ALIGN_CENTER
        cel.Border = 0
        auto.AddCell(cel)
        Documento.Add(auto)

        Dim firmas As New PdfPTable(3)
        firmas.SetWidthPercentage({210, 220, 210}, PageSize.A4)
        Dim cadena As String = "" & Chr(13) & "" & Chr(13) & "" & Chr(13) & "" & Chr(13) & "" & Chr(13) & ""
        Dim celda1 As New PdfPCell
        Dim celda2 As New PdfPCell
        Dim celda3 As New PdfPCell

        Dim celda4 As New PdfPCell
        celda4 = New PdfPCell(New Paragraph(Chr(13) & "Solicita" & cadena & "_____________________________" & Chr(13) & "" & empleado.Text & "" & Chr(13) & "", FontFactory.GetFont("Arial", 10)))
        celda4.HorizontalAlignment = Element.ALIGN_CENTER
        Dim yaemp As Integer = 0
        Dim yage As Integer = 1
        celda1 = New PdfPCell(New Paragraph(Chr(13) & "Reviso" & cadena & "_____________________________" & Chr(13) & "" & jefeinmediato.Text & "" & Chr(13) & "JEFE INMEDIATO", FontFactory.GetFont("Arial", 10)))
        celda1.HorizontalAlignment = Element.ALIGN_CENTER
        celda2 = New PdfPCell(New Paragraph(Chr(13) & "Autorizo" & cadena & "_____________________________" & Chr(13) & "" & gerente.Text & "" & Chr(13) & "GERENTE", FontFactory.GetFont("Arial", 10)))
        celda2.HorizontalAlignment = Element.ALIGN_CENTER
        celda3 = New PdfPCell(New Paragraph(cadena & "____________________________" & Chr(13) & "" & subgerente.Text & "" & Chr(13) & "SUBGERENTE", FontFactory.GetFont("Arial", 10)))
        celda3.HorizontalAlignment = Element.ALIGN_CENTER
        Dim celdavacia As New PdfPCell
        ' celdavacia.Border = 0

        firmas.AddCell(celda4)
        firmas.AddCell(celda2)
        If jefeinmediato.SelectedValue > 1 Then
            firmas.AddCell(celda1)
        Else
            firmas.AddCell(celdavacia)

        End If

        Documento.Add(firmas)

          Documento.Close() 'Cierra el documento
        'Abre el archivo DEMO.PDF

    End Sub

    Public Sub registrar()
        pruebadereporte()
        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "insert into permisos VALUES (@nomina,@nombre,@motivo,@nota,@fecha_permiso,@duracion,@de,@a,@dias_completos,@fecha_salida,@fecha_regreso,default,@archivo,@extension,@comprobante)"
            Dim comando As New MySqlCommand(agrega, coneccion)

            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@nomina", nomina.Text)
            comando.Parameters.AddWithValue("@nombre", empleado.Text)
            comando.Parameters.AddWithValue("@motivo", motivo.Text)
            comando.Parameters.AddWithValue("@nota", TextBox2.Text)
            comando.Parameters.AddWithValue("@fecha_permiso", fechapermiso.Value)
            comando.Parameters.AddWithValue("@duracion", duracion.Text)
            comando.Parameters.AddWithValue("@de", de.Text)
            comando.Parameters.AddWithValue("@a", a.Text)

            If CheckBox1.Checked Then
                comando.Parameters.AddWithValue("@dias_completos", dias.Text)
                comando.Parameters.AddWithValue("@fecha_salida", fechasalida.Value)
                comando.Parameters.AddWithValue("@fecha_regreso", fecharegreso.Value)
            Else
                comando.Parameters.AddWithValue("@dias_completos", "0")
                comando.Parameters.AddWithValue("@fecha_salida", fechapermiso.Value)
                comando.Parameters.AddWithValue("@fecha_regreso", fechapermiso.Value)
            End If
            comando.Parameters.AddWithValue("@archivo", convertirabinario("Permiso Salida.pdf"))
            comando.Parameters.AddWithValue("@extension", ".pdf")
            comando.Parameters.AddWithValue("@comprobante", "SI")

            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Permiso generado con exito", MsgBoxStyle.Information, "Permiso")
            System.Diagnostics.Process.Start("Permiso Salida.pdf")
            Me.Close()

        Catch ex As Exception

            MsgBox(" No se pudo Generar el Permiso", vbQuestion, "Error del Sistema")
            coneccion.Close()

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        pruebadereporte()
        Try
            System.Diagnostics.Process.Start("Permiso Salida.pdf")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


   

    Private Sub fechasalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechasalida.ValueChanged
        'los dias de la semana van desde 0 domingo a 6 sabado.
        If CheckBox1.Checked = True Then
        Else
            Exit Sub
        End If
          Try
            If fechasalida.Value > fecharegreso.Value Then
                MessageBox.Show("El rango de Fechas no es Valido", "Fechas", MessageBoxButtons.OK)
                dias.Text = ""
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Try
            dias.Text = calculadias(fechasalida.Value, fecharegreso.Value)
        Catch ex As Exception
            dias.Text = ""
        End Try

    End Sub

    Private Sub fecharegreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecharegreso.ValueChanged
        If CheckBox1.Checked = True Then
        Else
            Exit Sub
        End If
      
        Try
            If fechasalida.Value > fecharegreso.Value Then
                MessageBox.Show("El rango de Fechas no es Valido", "Fechas", MessageBoxButtons.OK)
                dias.Text = ""
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Try
            dias.Text = calculadias(fechasalida.Value, fecharegreso.Value)
        Catch ex As Exception
            dias.Text = ""
        End Try

    End Sub

  

    Private Sub a_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.SelectedIndexChanged
        If de.Text.Length > 0 And a.Text.Length > 0 Then
        Else
            Exit Sub
        End If
        duracion.Text = calcularduracion(de.Text, a.Text)

    End Sub

    Private Sub de_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles de.SelectedIndexChanged
        If de.Text.Length > 0 And a.Text.Length > 0 Then
        Else
            Exit Sub
        End If
        duracion.Text = calcularduracion(de.Text, a.Text)
    End Sub
End Class