Public Class Productos

    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultarproducto()
        MostrarModelo()
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
            cantidad = txtcantidad.Text
            caracteristicas = txtcaracteristica.Text
            modelo = txtmodelo.Text



            If conexion.ingresarProductos(id, codigobarra, nombre, preciocompra, precioventa, cantidad, caracteristicas, modelo) Then
                MessageBox.Show("producto ingresado correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarproducto()
            Else
                MessageBox.Show("producto no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresarProducto()
    End Sub

    Private Sub dgvModelos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvModelos.CellContentClick

    End Sub

    Private Sub MostrarModelo()
        Try
            DataT = conexion.consulta("dbo.vMarcas")
            If DataT.Rows.Count <> 0 Then
                dgvModelos.DataSource = DataT
            Else
                dgvModelos.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class