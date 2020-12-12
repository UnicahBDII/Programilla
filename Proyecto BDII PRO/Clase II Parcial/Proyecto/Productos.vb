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

    Private Sub eliminarProduct()
        Try
            Dim id As Integer
            Dim codbarra As String

            id = idtxt.Text
            codbarra = txtcodbarra.Text


            If conexion.eliminarProducto(id, codbarra) Then
                MessageBox.Show("Información Eliminada correctamente", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarproducto()
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub actualizarproduct()

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

            If conexion.actualizarProducto(id, nombre, preciocompra, precioventa, cantidad, caracteristicas) Then

                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarproducto()
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListado.CellContentClick
        Try

            Dim DGlistados As DataGridViewRow = DGListado.Rows(e.RowIndex)
            idtxt.Text = DGlistados.Cells(0).Value.ToString()
            txtcodbarra.Text = DGlistados.Cells(1).Value.ToString()
            txttiproducto.Text = DGlistados.Cells(2).Value.ToString()
            txtnombre.Text = DGlistados.Cells(3).Value.ToString()
            txtpreciocompra.Text = DGlistados.Cells(4).Value.ToString()
            txtventa.Text = DGlistados.Cells(5).Value.ToString()
            txtcantidad.Text = DGlistados.Cells(6).Value.ToString()
            txtcaracteristica.Text = DGlistados.Cells(7).Value.ToString()
            txtestado.Text = DGlistados.Cells(8).Value.ToString()
            txtmodelo.Text = DGlistados.Cells(9).Value.ToString()


            btnEliminar.Enabled = True
            btnEditar.Enabled = True

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarProduct()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        actualizarproduct()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Private Sub limpiar()
        idtxt.Clear()
        txtcodbarra.Clear()
        txttiproducto.Clear()
        txtnombre.Clear()
        txtpreciocompra.Clear()
        txtventa.Clear()
        txtcantidad.Clear()
        txtestado.Clear()
        txtmodelo.Clear()
        txtcaracteristica.Clear()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class