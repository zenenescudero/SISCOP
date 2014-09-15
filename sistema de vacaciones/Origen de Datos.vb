Imports System.IO

Public Class Origen_de_Datos

    Private Sub Origen_de_Datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        If MsgBox(" Estas seguro de cambiar" & Chr(13) & "La Información de Base de Datos" & Chr(13) & "Esto Podria Generar Errores.", vbOKCancel, "Confirmación") = vbOK Then
            Try
                If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 And TextBox3.Text.Length > 0 And TextBox4.Text.Length > 0 Then
                    File.WriteAllText("inicio.txt", "")
                    Dim crear As StreamWriter = File.AppendText("inicio.txt")
                    crear.WriteLine(TextBox1.Text)
                    crear.WriteLine(TextBox2.Text)
                    crear.WriteLine(TextBox4.Text)
                    crear.WriteLine(TextBox3.Text)
                    crear.Close()
                    Me.Close()

                    MsgBox("Origen De datos Regitrado", vbOKOnly, "Siscop -- Configuración")
                    datosdebase()
                Else
                    MsgBox("Todos los datos Son Obligatorios", MsgBoxStyle.Exclamation, "Faltan Datos")
                End If
              

            Catch ex As Exception
                MsgBox("Error al registrar Orgien de datos", vbOKOnly, "Siscop -- Configuración")
            End Try

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class