Imports MySql.Data.MySqlClient

Public Class empleadonuevo

    Private Sub empleadonuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fechaingreso.Value = Date.Now
        fechanac.Value = Date.Now

        opcionescombo(departamento, "select id,descripcion from depto order by id")
        opcionescombo(puesto, "select id,descripcion from puestos order by id")
        opcionescombo(inmediato, "select id,nombre from jefes order by id")
        opcionescombo(subgerente, "select id,nombre from subgerente order by id")
        opcionescombo(empresa, "select id,nombre from empresa order by id")
        opcionescombo(gerente, "select id,nombre from gerente order by id")
        correopersonal.Text = ""

        estatus.Text = "Activo"
        HorarioComedor.Text = "Selecciona"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles edadtxt.KeyPress, telcelular.KeyPress, nomina.KeyPress, extencion.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Public Sub validar()

        Dim resul As String = "si"
        If nombretxt.Text.Length < 10 Or sexotxt.Text.Length < 5 Or edadtxt.Text.Length < 1 Or estudiostxt.Text.Length < 5 Or nomina.Text.Length < 1 Then
            resul = "no"
        End If
        If Not IsNumeric(empresa.SelectedValue) Or Not IsNumeric(departamento.SelectedValue) Or Not IsNumeric(puesto.SelectedValue) Or Not IsNumeric(inmediato.SelectedValue) Or Not IsNumeric(subgerente.SelectedValue) Or Not IsNumeric(gerente.SelectedValue) Then
            MsgBox("Devees Usar solo los valores de la Lista", MsgBoxStyle.Critical, "Error Seleecion de Lista")
            Exit Sub
            resul = "no"
        End If


        If resul = "si" Then
            registrar()
        Else
            MsgBox("Faltan Campos Por Rellenar", MsgBoxStyle.Critical, "Registro Empleado")
        End If
    End Sub

    Public Sub registrar()
        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "insert into colaborador VALUES (@nombre,@sexo,@fecha_nac,@edad,@estudios,@tel_cel,@empresa,@departamento,@puesto,@no_nomina,@fecha_ingreso,@antiguedad ,@extencion,@email,@jefe_inmediato,@subgerente,@gerente,@dias_vac,@horario_comedor,@estatus,@email_personal)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@nombre", nombretxt.Text)
            comando.Parameters.AddWithValue("@sexo", sexotxt.Text)
            comando.Parameters.AddWithValue("@fecha_nac", fechanac.Value)
            comando.Parameters.AddWithValue("@edad", edadtxt.Text)
            comando.Parameters.AddWithValue("@estudios", estudiostxt.Text)
            If telcelular.Text.Length < 1 Then
                comando.Parameters.AddWithValue("@tel_cel", "000")
            Else
                comando.Parameters.AddWithValue("@tel_cel", telcelular.Text)
            End If
            comando.Parameters.AddWithValue("@empresa", empresa.SelectedValue)
            comando.Parameters.AddWithValue("@departamento", departamento.SelectedValue)
            comando.Parameters.AddWithValue("@puesto", puesto.SelectedValue)
            comando.Parameters.AddWithValue("@no_nomina", nomina.Text)
            comando.Parameters.AddWithValue("@fecha_ingreso", fechaingreso.Value)
            comando.Parameters.AddWithValue("@antiguedad", 0)
            If extencion.Text.Length < 1 Then
                comando.Parameters.AddWithValue("@extencion", 0)
            Else
                comando.Parameters.AddWithValue("@extencion", extencion.Text)
            End If

            If correochedraui.Text.Length < 1 Then
                comando.Parameters.AddWithValue("@email", "sin asignar")
            Else
                comando.Parameters.AddWithValue("@email", correochedraui.Text)
            End If
             comando.Parameters.AddWithValue("@jefe_inmediato", inmediato.SelectedValue)
            comando.Parameters.AddWithValue("@subgerente", subgerente.SelectedValue)
            comando.Parameters.AddWithValue("@gerente", gerente.SelectedValue)
            comando.Parameters.AddWithValue("@dias_vac", 0)
            comando.Parameters.AddWithValue("@horario_comedor", HorarioComedor.Text)
            comando.Parameters.AddWithValue("@estatus", estatus.Text)
            comando.Parameters.AddWithValue("@email_personal", correopersonal.Text)

            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Registrado Corectamente", vbInformation, "colaborador")
            empleados.consultar("select * from vicolaborador")
            Me.Close()
        Catch ex As Exception
            MsgBox(" El Numero de nomina Pertenece a Otro Empleado ... consultar administrador", vbQuestion, "Error del Sistema")
            coneccion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        validar()
    End Sub

 
    Private Sub fechanac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechanac.ValueChanged
        Try
            edadtxt.Text = Convert.ToInt32(DateDiff("m", fechanac.Value, Date.Now) / 12)
        Catch ex As Exception
            edadtxt.Text = "0"
        End Try
    End Sub

End Class