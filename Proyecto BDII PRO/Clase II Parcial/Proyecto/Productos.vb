Public Class Productos

    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultarproducto()
    End Sub


    Private Sub consultarproducto()

        Try
            DataT = conexion.consulta("Center.producto")
            If DataT.Rows.Count <> 0 Then
                DGListado.DataSource = DataT
            Else
                DGListado.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ingresarProducto()
        Try
            Dim id As Integer, codigobarra As String, nombre As String, preciocompra As Decimal,
            precioventa As Decimal, cantidad As Integer, caracteristicas As String, modelo As Integer

            id = idtxt.Text
            codigobarra = txtcodbarra.Text
            nombre = txtnombre.Text
            preciocompra = txtpreciocompra.Text
            precioventa = txtventa.Text
            sexo = cmbSexo.SelectedItem
            idpuesto = txtidpuesto.Text



            If conexion.ingresarEmpleado(idcodigo, Identidad, nombre, direccion, edad, sexo, idpuesto) Then
                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarEmpleado()
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class