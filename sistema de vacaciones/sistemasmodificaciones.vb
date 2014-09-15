Imports MySql.Data.MySqlClient

Public Class sistemasmodificaciones

    Private Sub empleadonuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opcionescombo(txtnombre, "select no_nomina,nombre from colaborador order by nombre desc")

        If Not Me.Text = "Nuevo" Then

            txtnombre.Text = vec(1)
            nomina.Text = vec(0)
            txtdepto.Text = vec(10)

            If vec(2) = "SI" Then
                checkartus.Checked = True
            Else
                checkartus.Checked = False
            End If

            If vec(3) = "SI" Then
                Checkgl.Checked = True
            Else
                Checkgl.Checked = False
            End If

            If vec(4) = "SI" Then
                Checkch.Checked = True
            Else
                Checkch.Checked = False
            End If

            If vec(5) = "SI" Then
                checksap.Checked = True
            Else
                checksap.Checked = False
            End If

            If vec(6) = "SI" Then
                Checkpeoplesoft.Checked = True
            Else
                Checkpeoplesoft.Checked = False
            End If

            If vec(7) = "SI" Then
                Checkmercaderiascfdi.Checked = True
            Else
                Checkmercaderiascfdi.Checked = False
            End If

            If vec(8) = "SI" Then
                Checkarticuloscfdi.Checked = True
            Else
                Checkarticuloscfdi.Checked = False
            End If

            If vec(9) = "SI" Then
                Checkimportaciones.Checked = True
            Else
                Checkimportaciones.Checked = False
            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub validar()


        If nomina.Text.Length > 0 Then
        Else
            MsgBox("Deves asignar un numero de Nomina", MsgBoxStyle.Information, "No. Nomina")
            Exit Sub
        End If

        If Me.Text = "Nuevo" Then
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
            Dim agrega As String = "update sistemas set sap=@sap,artus=@artus,gl=@gl,ch=@ch,people_soft=@people_soft,MercaderiasCFDI=@mercaderiascfdi,articuloscfdi=@articuloscfdi,importaciones=@importaciones where no_nomina='" & vec(0) & "'"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            If checksap.Checked = True Then
                comando.Parameters.AddWithValue("@sap", "SI")
            Else
                comando.Parameters.AddWithValue("@sap", "NO")
            End If

            If checkartus.Checked = True Then
                comando.Parameters.AddWithValue("@artus", "SI")
            Else
                comando.Parameters.AddWithValue("@artus", "NO")
            End If
            If Checkgl.Checked = True Then
                comando.Parameters.AddWithValue("@gl", "SI")
            Else
                comando.Parameters.AddWithValue("@gl", "NO")
            End If

            If Checkch.Checked = True Then
                comando.Parameters.AddWithValue("@ch", "SI")
            Else
                comando.Parameters.AddWithValue("@ch", "NO")
            End If

            If Checkpeoplesoft.Checked = True Then
                comando.Parameters.AddWithValue("@people_soft", "SI")
            Else
                comando.Parameters.AddWithValue("@people_soft", "NO")
            End If

            If Checkmercaderiascfdi.Checked = True Then
                comando.Parameters.AddWithValue("@mercaderiascfdi", "SI")
            Else
                comando.Parameters.AddWithValue("@mercaderiascfdi", "NO")
            End If

            If Checkarticuloscfdi.Checked = True Then
                comando.Parameters.AddWithValue("@articuloscfdi", "SI")
            Else
                comando.Parameters.AddWithValue("@articuloscfdi", "NO")
            End If

            If Checkimportaciones.Checked = True Then
                comando.Parameters.AddWithValue("@importaciones", "SI")
            Else
                comando.Parameters.AddWithValue("@importaciones", "NO")
            End If

            comando.ExecuteNonQuery()
            coneccion.Close()

            MsgBox("Editado Corectamente", vbInformation, "Sistemas")
            catalogoaccesos.consultar("select c.nombre,(select descripcion from depto where id=c.departamento) as Departamento,s.* from sistemas s inner join colaborador c on ( s.no_nomina=c.no_nomina)")
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
            Dim agrega As String = "insert into sistemas VALUES (@no_nomina,@sap,@artus,@gl,@ch,@people_soft,@mercaderiascfdi,@articuloscfdi,@importaciones)"
            Dim comando As New MySqlCommand(agrega, coneccion)
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@no_nomina", nomina.Text)
            If checksap.Checked = True Then
                comando.Parameters.AddWithValue("@sap", "SI")
            Else
                comando.Parameters.AddWithValue("@sap", "NO")
            End If

            If checkartus.Checked = True Then
                comando.Parameters.AddWithValue("@artus", "SI")
            Else
                comando.Parameters.AddWithValue("@artus", "NO")
            End If
            If Checkgl.Checked = True Then
                comando.Parameters.AddWithValue("@gl", "SI")
            Else
                comando.Parameters.AddWithValue("@gl", "NO")
            End If

            If Checkch.Checked = True Then
                comando.Parameters.AddWithValue("@ch", "SI")
            Else
                comando.Parameters.AddWithValue("@ch", "NO")
            End If

            If Checkpeoplesoft.Checked = True Then
                comando.Parameters.AddWithValue("@people_soft", "SI")
            Else
                comando.Parameters.AddWithValue("@people_soft", "NO")
            End If

            If Checkmercaderiascfdi.Checked = True Then
                comando.Parameters.AddWithValue("@mercaderiascfdi", "SI")
            Else
                comando.Parameters.AddWithValue("@mercaderiascfdi", "NO")
            End If

            If Checkarticuloscfdi.Checked = True Then
                comando.Parameters.AddWithValue("@articuloscfdi", "SI")
            Else
                comando.Parameters.AddWithValue("@articuloscfdi", "NO")
            End If

            If Checkimportaciones.Checked = True Then
                comando.Parameters.AddWithValue("@importaciones", "SI")
            Else
                comando.Parameters.AddWithValue("@importaciones", "NO")
            End If

            comando.ExecuteNonQuery()
            coneccion.Close()
            MsgBox("Registrado Corectamente", vbInformation, "Sistemas")
            catalogoaccesos.consultar("select c.nombre,(select descripcion from depto where id=c.departamento) as Departamento,s.* from sistemas s inner join colaborador c on ( s.no_nomina=c.no_nomina)")
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

    Private Sub puertosusb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

End Class