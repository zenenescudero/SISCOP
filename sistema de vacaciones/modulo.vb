Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml
Imports System.IO



Module modulo

    Public vec(20) As String
    Public formactivo As Form
    Public formlocal As Form
    Public coneccion As New MySqlConnection
    Dim servidor As String
    Dim usuario As String
    Dim contrasena As String
    Dim contra As String
    Dim basedatos As String

    Public Function calculadias(ByVal inicio As DateTime, ByVal fin As DateTime) As String
        Dim fechainicial As DateTime
        Dim fechafinal As DateTime
        Dim auxfecha As DateTime
        Dim duracion As String = ""
        Dim nohabil As Integer = 0
        Try
            fechainicial = Convert.ToDateTime(inicio)
        Catch ex As Exception
        End Try

        Try
            fechafinal = Convert.ToDateTime(fin)
        Catch ex As Exception
        End Try

        Try
            auxfecha = Convert.ToDateTime(inicio)
        Catch ex As Exception
        End Try

        Try
            duracion = (DateDiff("d", fechainicial, fechafinal)).ToString
        Catch ex As Exception
            duracion = ""
        End Try

        If duracion.Length > 0 Then
            While (auxfecha < fechafinal)
                If auxfecha.DayOfWeek = 0 Or auxfecha.DayOfWeek = 6 Then
                    nohabil = nohabil + 1
                End If
                auxfecha = DateAdd("d", 1, auxfecha)
            End While
            duracion = duracion - nohabil
        End If


        Return duracion
    End Function

    Public Function calcularduracion(ByVal inicio As String, ByVal fin As String) As String
        Dim horaini As DateTime
        Dim horafin As DateTime
        Try
            horaini = Convert.ToDateTime(inicio)
        Catch ex As Exception
        End Try

        Try
            horafin = Convert.ToDateTime(fin)
        Catch ex As Exception
        End Try

        Try
            Return " " & (DateDiff(DateInterval.Hour, horaini, horafin)).ToString & ":" & (DateDiff(DateInterval.Minute, horaini, horafin)) Mod 60 & "  Horas"
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function convertirabinario(ByVal fileName As String) As Byte()

        ' Si no existe el archivo, abandono la función.
        '
        If (Not (File.Exists(fileName))) Then Return Nothing

        Try
            ' Creamos un objeto Stream para poder leer el archivo especificado.
            '
            Using fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)

                ' Creamos un array de bytes, cuyo límite superior se corresponderá
                ' con la longitud en bytes de la secuencia menos una unidad.
                '
                Dim length As Int32 = Convert.ToInt32(fs.Length - 1)

                Dim data() As Byte = New Byte(length) {}

                ' Al leer la secuencia, se rellenará la matriz.
                '
                fs.Read(data, 0, length)

                ' Devolvemos el array de bytes.
                '
                Return data

            End Using

        Catch ex As Exception
            ' Devolvemos la excepción al procedimiento llamador.
            '
            Throw
        End Try
    End Function

    Public Function obtenerextension(ByVal archivoselecionado As OpenFileDialog) As String
        Dim extension As String = ""

        Try
            Dim archivo As String = archivoselecionado.SafeFileName
            archivo = StrReverse(archivo)
            Dim cadenas() As String = Split(archivo, ".")
            extension = StrReverse(cadenas(0))
        Catch ex As Exception
            extension = ""
        End Try
        Return extension
    End Function

    Public Sub convertirdebinarioaarchivo(ByVal aByte() As Byte, _
                          ByVal fileName As String, ByVal visualizar As String)

        ' El procedimiento creará un archivo con la secuencia de bytes
        ' especificada en el argumento.

        ' Compruebo los distintos parámetros pasados a la función.
        '
        If (aByte Is Nothing) Then _
            Throw New ArgumentNullException("aByte", "No se ha especificado ningún array de Bytes.")

        If (String.IsNullOrEmpty(fileName)) Then _
            Throw New ArgumentNullException("fileName", "No se ha especificado el archivo de destino.")

        Try
            ' Compruebo si existe el archivo especificado.
            '
            If visualizar <> "SI" Then
                If (File.Exists(fileName)) Then
                    If (MessageBox.Show("Ya existe un archivo con el mismo nombre. " & _
                        "¿Desea sobrescribirlo?", _
                        "Grabar archivo", _
                        MessageBoxButtons.YesNo, _
                        MessageBoxIcon.Question) = _
                        Windows.Forms.DialogResult.No) Then Return

                    ' Elimino el archivo
                    File.Delete(fileName)
                End If
            Else
                File.Delete(fileName)
            End If


            ' Número de bytes que se van a escribir
            Dim data As Integer = aByte.Length

            ' Obtengo el nombre de un archivo temporal, donde
            ' primeramente se guardará el documento.
            '
            Dim tempFileName As String = Path.GetTempFileName()

            ' Abrimos o creamos el archivo.
            Using fs As New FileStream(tempFileName, FileMode.OpenOrCreate)

                ' Crea el escritor para los datos.
                Dim bw As New BinaryWriter(fs)

                ' Escribimos en el archivo los datos realmente leídos.
                bw.Write(aByte, 0, data)

                ' Borra todos los búferes del sistema de escritura actual y hace
                ' que todos los datos almacenados en el búfer se escriban en el
                ' dispositivo subyacente. 
                bw.Flush()

                bw = Nothing

            End Using

            ' Muevo el archivo a la ruta indicada.
            '
            File.Move(tempFileName, fileName)

            If visualizar = "SI" Then
                Process.Start(fileName)
            Else
                MsgBox("El archivo se descargo :) " & fileName, MsgBoxStyle.Information, "Descarga de Comprobante")
            End If

        Catch ex As Exception
            ' Devolvemos la excepción al procedimiento llamador.
            '
            Throw

        End Try

    End Sub

    Public Sub datosdebase()
        Dim leer As StreamReader = File.OpenText("inicio.txt")
        Try
            servidor = leer.ReadLine()
            basedatos = leer.ReadLine()
            usuario = leer.ReadLine
            contra = leer.ReadLine
            leer.Close()
        Catch ex As Exception
            leer.Close()
            MsgBox("Error al conectar Origen de Datos", MsgBoxStyle.Critical, "Coneccion a Datos")
        End Try


    End Sub

    Public Sub registrar(ByVal nomina As String, ByVal anios As Integer, ByVal asigno As String)
        Try
            varconeccion()
            coneccion.Open()
            Dim agrega As String = "call registrardiasvac(@nomina,@anios,@asigno)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@nomina", nomina)
            comando.Parameters.AddWithValue("@anios", anios)
            comando.Parameters.AddWithValue("@asigno", asigno)
            comando.ExecuteNonQuery()
            coneccion.Close()

        Catch ex As Exception
            coneccion.Close()

        End Try

    End Sub

    Public Sub exportaraexcel(ByVal grid As DataGridView, ByVal ruta As String, ByVal g1 As Integer)

        If g1 = 1 Then
            grid.Columns.Remove("id")
            grid.Columns.Remove("dias_vac")
        End If

        If g1 = 0 Then
            grid.Columns.Remove("id")
        End If

        Dim workbook1 = New ClosedXML.Excel.XLWorkbook()
        Dim worksheet = workbook1.Worksheets.Add("Datos")

        For x1 As Integer = 0 To grid.ColumnCount - 1
            worksheet.Cell(1, x1 + 1).Value = grid.Columns(x1).HeaderText
        Next

        For X As Integer = 0 To grid.RowCount - 1

            For y As Integer = 0 To grid.ColumnCount - 1
                worksheet.Cell(X + 2, y + 1).Value = grid.Item(y, X).Value
            Next
        Next

        ruta = ruta
        workbook1.SaveAs(ruta)
        If MsgBox("Deseas Abrir el Archivo?" & Chr(13) & ruta & "", MsgBoxStyle.YesNo, "Exportación Finalizada") = MsgBoxResult.Yes Then
            Diagnostics.Process.Start(ruta)
        Else

        End If


    End Sub

    Public Sub mostrarform(ByVal Formlocal)

        If formactivo Is Nothing Then
        Else
            If Formlocal.Equals(formactivo) Then
            Else
                formactivo.Close()
                formactivo.Dispose()
            End If
        End If
        formactivo = Formlocal
        formactivo.TopLevel = False
        formactivo.Parent = Sistema.contenedor()
        formactivo.Show()

    End Sub

    Public Sub varconeccion()

        '  coneccion.ConnectionString = "server=" & servidor & ";userid=" & usuario & ";password=" & contrasena & ";database=siscop;port=3306"
        coneccion.ConnectionString = "server=" & servidor & ";userid=" & usuario & ";password=" & contra & ";database=" & basedatos & ";port=3306"

    End Sub


    Public Sub opcionescombo( _
        ByVal ComboBox As ComboBox, _
        ByVal sql As String)
        'se rellena el combo el primer valor sera el identificador el segundo sera la descripcion.

        varconeccion()


        Try

            ' Abrir la conexión a Sql  
            coneccion.Open()

            ' Pasar la consulta sql y la conexión al Sql Command   
            Dim cmd As New MySqlCommand(sql, coneccion)

            ' Inicializar un nuevo SqlDataAdapter   
            Dim da As New MySqlDataAdapter(cmd)

            'Crear y Llenar un Dataset  
            Dim ds As New DataSet
            da.Fill(ds)

            ' asignar el DataSource al combobox  
            ComboBox.DataSource = ds.Tables(0)

            ' Asignar el campo a la propiedad DisplayMember del combo   
            ComboBox.DisplayMember = ds.Tables(0).Columns(1).Caption.ToString
            ComboBox.ValueMember = ds.Tables(0).Columns(0).Caption.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, _
                            "error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            coneccion.Close()

        Finally
            If coneccion.State = ConnectionState.Open Then
                coneccion.Close()
            End If
        End Try

    End Sub

    Public Sub vacaciones()

        varconeccion()
        Try
            coneccion.Open()
            Dim dsetdatos As New DataSet
            Dim dadaptador As New MySqlDataAdapter
            dadaptador.SelectCommand = New MySqlCommand("select no_nomina,DATEDIFF(CURRENT_DATE,fecha_ingreso)/365 as antiguedad  from colaborador", coneccion)
            dadaptador.Fill(dsetdatos)
            coneccion.Close()
        Catch ex As Exception

        End Try

    End Sub

End Module
