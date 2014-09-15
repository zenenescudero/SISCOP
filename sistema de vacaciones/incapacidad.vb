Imports MySql.Data.MySqlClient
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Image
Imports System.IO

Public Class incapacidad
    Dim encontro As Integer = 0
    Private Sub Permisos_Salida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecharegreso.Value = Date.Now
        fechasalida.Value = Date.Now

        opcionescombo(empleado, "select no_nomina,nombre from vicolaborador order by nombre")

    End Sub

    Public Sub generarestructura()

        Gridpermisos.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)

        Gridpermisos.Columns("nomina").HeaderText = "Nomina"
        Gridpermisos.Columns("nombre").HeaderText = "Nombre"
        Gridpermisos.Columns("tipo").HeaderText = "Tipo de Incapacidad"
        Gridpermisos.Columns("segurosocial").HeaderText = "Seguro Social"
        Gridpermisos.Columns("dias").HeaderText = "Dias"
        Gridpermisos.Columns("fecha_inicial").HeaderText = "Fecha Inicial"
        Gridpermisos.Columns("fecha_final").HeaderText = "Fecha Final"
        Gridpermisos.Columns("notas").HeaderText = "Nota Adicional"
        Gridpermisos.Columns("id").HeaderText = "ID"
        Gridpermisos.Columns("id").Visible = False

        Gridpermisos.Columns("nomina").Width = 100
        Gridpermisos.Columns("nombre").Width = 200
        Gridpermisos.Columns("tipo").Width = 200
        Gridpermisos.Columns("segurosocial").Width = 100
        Gridpermisos.Columns("dias").Width = 60
        Gridpermisos.Columns("fecha_inicial").Width = 100
        Gridpermisos.Columns("fecha_final").Width = 100
        Gridpermisos.Columns("notas").Width = 250


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
            empleado.Text = dsetdatos.Tables(0).Rows(0)(1)
            encontro = 1

        Catch ex As Exception
            coneccion.Close()
            MsgBox("No se encontraron datos", MsgBoxStyle.Critical, "Resultado")
            encontro = 0

        End Try

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nomina.KeyDown
        If e.KeyValue = Keys.Enter Then

            datos("select no_nomina,nombre from vicolaborador where no_nomina= '" & nomina.Text & "'")
            consultar("select * from incapacidad where nomina='" & nomina.Text & "' order by fecha_inicial desc")

        End If

    End Sub

   
    Private Sub empleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleado.SelectedIndexChanged
        Try

            datos("select no_nomina,nombre from vicolaborador where no_nomina= '" & empleado.SelectedValue & "'")
            consultar("select * from incapacidad where nomina='" & empleado.SelectedValue & "'order by fecha_inicial desc")
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

        If dias.Text.Length < 1 Then
            MsgBox("No estas Asiganado Dias", MsgBoxStyle.Critical, "Error en Dias")
            resul = 1
        End If

        If segurosocial.Text.Length < 1 Then
            MsgBox("Asigana el numero de Seguro Social", MsgBoxStyle.Critical, "Error Seguro Social")
            resul = 1
        End If

        If tipo.Text.Length < 1 Then
            MsgBox("Agrega un Motivo Puedes Escribir Libremente", MsgBoxStyle.Critical, "Error Motivo")
            resul = 1
        End If

        If fecharegreso.Value < fechasalida.Value Then
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Error Fechas")
            resul = 1
        End If


        Return resul

    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If encontro = 1 Then
            If validar() = 0 Then

                registrar()

            End If

        Else
            MsgBox("No existen datos de Colaborador Selecciona Otro", MsgBoxStyle.Critical, "Permisos")
        End If

    End Sub

    Public Sub registrar()
        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "insert into incapacidad VALUES (@nomina,@nombre,@tipo,@segurosocial,@dias,@fecha_inicial,@fecha_final,@notas,default)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@nomina", nomina.Text)
            comando.Parameters.AddWithValue("@nombre", empleado.Text)
            comando.Parameters.AddWithValue("@tipo", tipo.Text)
            comando.Parameters.AddWithValue("@segurosocial", segurosocial.Text)
            comando.Parameters.AddWithValue("@dias", dias.Text)
            comando.Parameters.AddWithValue("@fecha_inicial", fechasalida.Value)
            comando.Parameters.AddWithValue("@fecha_final", fecharegreso.Value)
            comando.Parameters.AddWithValue("@notas", notas.Text)
            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Registro Correcto", MsgBoxStyle.Information, "Mensajes de Sistema")

            Me.Close()

        Catch ex As Exception
            MsgBox(" No se pudo Generar la Incapacidad", MsgBoxStyle.Critical, "Error del Sistema")
            coneccion.Close()
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class