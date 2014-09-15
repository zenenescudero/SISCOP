Imports MySql.Data.MySqlClient

Public Class equipomodificaciones

    Private Sub empleadonuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opcionescombo(departamento, "select id,descripcion from depto order by id")
        opcionescombo(txtnombre, "select no_nomina,nombre from colaborador order by nombre desc")

        If Not Me.Text = "Nuevo Equipo" Then

            txtnombre.Text = vec(0)
            nomina.Text = vec(1)
            departamento.Text = vec(2)
            usuario.Text = vec(3)
            nombreequipo.Text = vec(4)
            procesador.Text = vec(5)
            memoriaram.Text = vec(6)
            discoduro.Text = vec(7)

            If vec(8) = "SI" Then
                checkcd.Checked = True
            Else
                checkcd.Checked = False
            End If

            If vec(9) = "SI" Then
                checkdvd.Checked = True
            Else
                checkdvd.Checked = False
            End If

            sistemaoperativo.Text = vec(10)
            puertosusb.Text = vec(11)
            tipo.Text = vec(12)
            marca.Text = vec(13)
            serie.Text = vec(14)
            monitormarcaserie.Text = vec(15)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles puertosusb.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub validar()

        If puertosusb.Text = "" Then
            puertosusb.Text = "0"
        End If

        If nomina.Text.Length > 0 Then
        Else
            MsgBox("Deves asignar un numero de Nomina- Si no tienes numero de nomina usa Xinclremeto : ejemplo X1,X2,X3,X4 ETC", MsgBoxStyle.Information, "No. Nomina")
            Exit Sub
        End If

        If Me.Text = "Nuevo Equipo" Then
            registrar()
        Else
            actualizar()
        End If

    End Sub

    Public Sub actualizar()

        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "update equipo set no_nomina=@no_nomina,departamento=@departamento,usuario=@usuario,nom_equipo=@nom_equipo,procesador=@procesador,memoria_ram=@memoria_ram,disco_duro=@disco_duro,cd=@cd,dvd=@dvd,sistema_operativo=@sistema_operativo,puertos_usb=@puertos_usb,tipo_equipo=@tipo_equipo,marca=@marca,serie_equipo=@serie_equipo,monitor_marca_serie=@monitor_marca_serie where no_nomina='" & vec(1) & "'"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@no_nomina", nomina.Text)
            comando.Parameters.AddWithValue("@departamento", departamento.SelectedValue)
            comando.Parameters.AddWithValue("@usuario", usuario.Text)
            comando.Parameters.AddWithValue("@nom_equipo", nombreequipo.Text)
            comando.Parameters.AddWithValue("@procesador", procesador.Text)
            comando.Parameters.AddWithValue("@memoria_ram", memoriaram.Text)
            comando.Parameters.AddWithValue("@disco_duro", discoduro.Text)
            If checkcd.Checked = True Then
                comando.Parameters.AddWithValue("@cd", "SI")
            Else
                comando.Parameters.AddWithValue("@cd", "NO")
            End If

            If checkdvd.Checked = True Then
                comando.Parameters.AddWithValue("@dvd", "SI")
            Else
                comando.Parameters.AddWithValue("@dvd", "NO")
            End If

            comando.Parameters.AddWithValue("@sistema_operativo", sistemaoperativo.Text)
            comando.Parameters.AddWithValue("@puertos_usb", puertosusb.Text)
            comando.Parameters.AddWithValue("@tipo_equipo", tipo.Text)
            comando.Parameters.AddWithValue("@marca", marca.Text)
            comando.Parameters.AddWithValue("@serie_equipo", serie.Text)
            comando.Parameters.AddWithValue("@monitor_marca_serie", monitormarcaserie.Text)
            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Editado Corectamente", vbInformation, "Equipos")
            catalogoequipos.consultar("select c.nombre,e.no_nomina,(select descripcion from depto where id=e.departamento) departamento,e.usuario,e.nom_equipo,e.procesador,e.memoria_ram,e.disco_duro,e.cd,e.dvd,e.sistema_operativo,e.puertos_usb,e.tipo_equipo,e.marca,e.serie_equipo,e.monitor_marca_serie from colaborador c right join equipo e on (c.no_nomina=e.no_nomina)")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbQuestion, "Error del Sistema")
            coneccion.Close()
        End Try

    End Sub

    Public Sub registrar()
        Try
            varconeccion()
            coneccion.Open()
            'nueva forma de agregar
            Dim agrega As String = "insert into equipo VALUES (@no_nomina,@departamento,@usuario,@nom_equipo,@procesador,@memoria_ram,@disco_duro,@cd,@dvd,@sistema_operativo,@puertos_usb,@tipo_equipo,@marca,@serie_equipo,@monitor_marca_serie)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@no_nomina", nomina.Text)
            comando.Parameters.AddWithValue("@departamento", departamento.SelectedValue)
            comando.Parameters.AddWithValue("@usuario", usuario.Text)
            comando.Parameters.AddWithValue("@nom_equipo", nombreequipo.Text)
            comando.Parameters.AddWithValue("@procesador", procesador.Text)
            comando.Parameters.AddWithValue("@memoria_ram", memoriaram.Text)
            comando.Parameters.AddWithValue("@disco_duro", discoduro.Text)
            If checkcd.Checked = True Then
                comando.Parameters.AddWithValue("@cd", "SI")
            Else
                comando.Parameters.AddWithValue("@cd", "NO")
            End If

            If checkdvd.Checked = True Then
                comando.Parameters.AddWithValue("@dvd", "SI")
            Else
                comando.Parameters.AddWithValue("@dvd", "NO")
            End If
            comando.Parameters.AddWithValue("@sistema_operativo", sistemaoperativo.Text)
            comando.Parameters.AddWithValue("@puertos_usb", puertosusb.Text)
            comando.Parameters.AddWithValue("@tipo_equipo", tipo.Text)
            comando.Parameters.AddWithValue("@marca", marca.Text)
            comando.Parameters.AddWithValue("@serie_equipo", serie.Text)
            comando.Parameters.AddWithValue("@monitor_marca_serie", monitormarcaserie.Text)
            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Registrado Corectamente", vbInformation, "Equipos")
            catalogoequipos.consultar("select c.nombre,e.no_nomina,(select descripcion from depto where id=e.departamento) departamento,e.usuario,e.nom_equipo,e.procesador,e.memoria_ram,e.disco_duro,e.cd,e.dvd,e.sistema_operativo,e.puertos_usb,e.tipo_equipo,e.marca,e.serie_equipo,e.monitor_marca_serie from colaborador c right join equipo e on (c.no_nomina=e.no_nomina)")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbQuestion, "Error del Sistema")
            coneccion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        validar()

    End Sub

    Private Sub txtnombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.SelectedIndexChanged
        Try
            nomina.Text = txtnombre.SelectedValue
        Catch ex As Exception
            nomina.Text = ""
        End Try
    End Sub

    Private Sub puertosusb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles puertosusb.TextChanged
    End Sub

End Class