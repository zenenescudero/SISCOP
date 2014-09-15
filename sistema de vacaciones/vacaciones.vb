Imports MySql.Data.MySqlClient

Public Class Vacaciones

    Private Sub Vacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultar("Select * from vacaciones order by anos")
        generarestructura()

    End Sub
    Public Sub generarestructura()
        DataGridView1.Font = New Drawing.Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)


        DataGridView1.Columns("anos").HeaderText = "Antiguedad"
        DataGridView1.Columns("dias").HeaderText = "Dias/Vacaciones"

        DataGridView1.Columns("anos").Width = 150
        DataGridView1.Columns("dias").Width = 130

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
            DataGridView1.DataSource = dtable

        Catch ex As Exception
            coneccion.Close()

        End Try

    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Estas A punto de Actualizar las Vacaciones", MsgBoxStyle.OkCancel, "Confirmación") = MsgBoxResult.Ok Then
            Try
                varconeccion()

                For x As Integer = 0 To DataGridView1.RowCount - 1

                    coneccion.Open()

                    Dim agrega As String = "update vacaciones set dias='" & DataGridView1.Item(1, x).Value & "' where anos='" & DataGridView1.Item(0, x).Value & "'"

                    Dim comando As New MySqlCommand(agrega, coneccion)
                    comando.CommandType = CommandType.Text

                    'comando.Parameters.AddWithValue("@nomina", mpleados.CurrentRow.Index).Value)

                    comando.ExecuteNonQuery()
                    coneccion.Close()

                Next
                coneccion.Open()
                'nueva forma de agregar


               
                MsgBox("Actualizacion correcta", vbInformation, "Vacaciones")

                consultar("select * from vacaciones order by anos")

                'limpiar campos
            Catch ex As Exception
                coneccion.Close()


            End Try
        Else

        End If
    End Sub

    Private Sub desactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desactivar.Click
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "Excel 2007 y Superior|*.xlsx|Excel 2003|*.xls"
        SaveFileDialog1.Title = "Exportar a Excel"
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.Length > 0 Then
            exportaraexcel(DataGridView1, SaveFileDialog1.FileName, 2)
        Else
            MsgBox("No seleccionaste donde Guardar", MsgBoxStyle.Critical, "Exportar a Excel")
        End If
    End Sub
End Class