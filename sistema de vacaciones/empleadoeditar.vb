Imports MySql.Data.MySqlClient

Public Class empleadoeditar

    Dim nomina_anterior As String

    Dim antiguedad As Integer
    Private Sub empleadonuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtcumple.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("cumple_anos").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        opcionescombo(departamento, "select id,descripcion from depto order by id")
        opcionescombo(puesto, "select id,descripcion from puestos order by id")
        opcionescombo(inmediato, "select id,nombre from jefes order by id")
        opcionescombo(subgerente, "select id,nombre from subgerente order by id")
        opcionescombo(empresa, "select id,nombre from empresa order by id")
        opcionescombo(gerente, "select id,nombre from gerente order by id")

        nombretxt.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("nombre").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        fechanac.Value = Convert.ToDateTime(Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("fecha_nac").Index, empleados.Gridempleados.CurrentRow.Index).Value))

        fechaingreso.Value = Convert.ToDateTime(Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("fecha_ingreso").Index, empleados.Gridempleados.CurrentRow.Index).Value))
        antiguedad = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("antiguedad").Index, empleados.Gridempleados.CurrentRow.Index).Value)
        antigu.Text = antiguedad

        sexotxt.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("sexo").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        edadtxt.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("edad").Index, empleados.Gridempleados.CurrentRow.Index).Value)


        estudiostxt.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("estudios").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        telcelular.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("tel_cel").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        empresa.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("empresa").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        departamento.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("departamento").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        puesto.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("puesto").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        nomina.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("no_nomina").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        extencion.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("extencion").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        correochedraui.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("email").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        emailpersonal.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("email_personal").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        inmediato.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("jefe_inmediato").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        subgerente.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("subgerente").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        gerente.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("gerente").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        nomina_anterior = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("no_nomina").Index, empleados.Gridempleados.CurrentRow.Index).Value)

        dias_vac.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("dias_vac").Index, empleados.Gridempleados.CurrentRow.Index).Value)
        estatus.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("estatus").Index, empleados.Gridempleados.CurrentRow.Index).Value)
        HorarioComedor.Text = Convert.ToString(empleados.Gridempleados.Item(empleados.Gridempleados.Columns("horario_comedor").Index, empleados.Gridempleados.CurrentRow.Index).Value)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Sistema.Enabled = True

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles telcelular.KeyPress, nomina.KeyPress, extencion.KeyPress, dias_vac.KeyPress, antigu.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub


    Public Sub modificarvac()
      

    End Sub

    Public Sub validar()
        Dim resul As String = "si"
        If nombretxt.Text.Length < 10 Or estudiostxt.Text.Length < 5 Or nomina.Text.Length < 1 Then
            resul = "no"
        End If
        If Not IsNumeric(empresa.SelectedValue) Or Not IsNumeric(departamento.SelectedValue) Or Not IsNumeric(puesto.SelectedValue) Or Not IsNumeric(inmediato.SelectedValue) Or Not IsNumeric(subgerente.SelectedValue) Or Not IsNumeric(gerente.SelectedValue) Then
            resul = "no"
            MsgBox("Deves usar los valores de la Lista", MsgBoxStyle.Critical, "Error Seleccion de lista")
            Exit Sub
        End If

        If dias_vac.Text.Length < 1 Then
            resul = "no"
        End If

        If resul = "si" Then
            modificar()
        Else
            MsgBox("Faltan Campos Por Rellenar", MsgBoxStyle.Critical, "Registro Empleado")
        End If
    End Sub


    Public Sub modificar()


        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "call updatecolaborador (@fechaingreso,@fecha_nac,@estudios,@tel_cel,@empresa,@departamento,@puesto,@nomina,@extencion,@email,@jefe_inmediato,@subgerente,@gerente,@nomina_anterior,@nombre,@dias_vaca,@horario_comedor,@estatus,@email_personal)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
             comando.Parameters.AddWithValue("@fechaingreso", fechaingreso.Value)
            comando.Parameters.AddWithValue("@fecha_nac", fechanac.Value)
            comando.Parameters.AddWithValue("@estudios", estudiostxt.Text)
            If telcelular.Text.Length < 1 Then
                comando.Parameters.AddWithValue("@tel_cel", "0")
            Else
                comando.Parameters.AddWithValue("@tel_cel", telcelular.Text)
            End If
            comando.Parameters.AddWithValue("@empresa", empresa.SelectedValue)
            comando.Parameters.AddWithValue("@departamento", departamento.SelectedValue)
            comando.Parameters.AddWithValue("@puesto", puesto.SelectedValue)
            comando.Parameters.AddWithValue("@nomina", nomina.Text)
            If extencion.Text.Length < 1 Then
                comando.Parameters.AddWithValue("@extencion", "00")
            Else
                comando.Parameters.AddWithValue("@extencion", extencion.Text)
            End If
            If correochedraui.Text.Length < 1 Then
                comando.Parameters.AddWithValue("@email", "Sin asignar")
            Else
                comando.Parameters.AddWithValue("@email", correochedraui.Text)
            End If

            comando.Parameters.AddWithValue("@jefe_inmediato", inmediato.SelectedValue)
            comando.Parameters.AddWithValue("@subgerente", subgerente.SelectedValue)
            comando.Parameters.AddWithValue("@gerente", gerente.SelectedValue)
            comando.Parameters.AddWithValue("@nomina_anterior", nomina_anterior)
            comando.Parameters.AddWithValue("@nombre", nombretxt.Text)
            If dias_vac.Text.Length > 0 Then
                comando.Parameters.AddWithValue("@dias_vaca", dias_vac.Text)
            Else
                comando.Parameters.AddWithValue("@dias_vaca", 0)
            End If
            comando.Parameters.AddWithValue("@horario_comedor", HorarioComedor.Text)
            comando.Parameters.AddWithValue("@estatus", estatus.Text)
            comando.Parameters.AddWithValue("@email_personal", emailpersonal.Text)
            comando.ExecuteNonQuery()
            coneccion.Close()

            MsgBox("Editado Corectamente", vbInformation, "colaborador")

            empleados.consultar("select * from vicolaborador")
            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)
            MsgBox(" No se actualizo", vbQuestion, "Error del Sistema")
            coneccion.Close()

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        validar()
    End Sub


    Private Sub telcelular_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles telcelular.TextChanged

    End Sub

    Private Sub fechanac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechanac.ValueChanged
        Try

            edadtxt.Text = Convert.ToInt32(DateDiff("m", fechanac.Value, Date.Now) / 12)
        Catch ex As Exception
            edadtxt.Text = "0"
        End Try

        Try
            txtcumple.Text = ""
            If fechanac.Value.Month < 10 Then
                txtcumple.Text = "0" & fechanac.Value.Month
            Else
                txtcumple.Text = fechanac.Value.Month
            End If

            If fechanac.Value.Day < 10 Then
                txtcumple.Text = txtcumple.Text & "-0" & fechanac.Value.Day
            Else
                txtcumple.Text = txtcumple.Text & "-" & fechanac.Value.Day
            End If

        Catch ex As Exception
            txtcumple.Text = "0"
        End Try


    End Sub

    Private Sub fechaingreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaingreso.ValueChanged
        Try

            antigu.Text = Convert.ToInt32(DateDiff("m", fechaingreso.Value, Date.Now) / 12)
        Catch ex As Exception
            antigu.Text = "0"
        End Try
    End Sub

    Private Sub empleadoeditar_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Sistema.Enabled = True
    End Sub
End Class