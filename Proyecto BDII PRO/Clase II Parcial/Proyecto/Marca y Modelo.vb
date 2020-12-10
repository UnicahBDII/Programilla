Public Class Marca_y_Modelo
    Dim conexion As conexion = New conexion
    Dim dataT As DataTable

    Private Sub Marca_y_Modelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMarca()
        MostrarModelo()

    End Sub

    Private Sub MostrarMarca()

        Try
            dataT = conexion.consulta("Center.marca")
            If dataT.Rows.Count <> 0 Then
                dgvMarca.DataSource = dataT
            Else
                dgvMarca.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MostrarModelo()

        Try
            dataT = conexion.consulta("Center.modelo")
            If dataT.Rows.Count <> 0 Then
                dgvModelo.DataSource = dataT
            Else
                dgvModelo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Funciones Marca
    Private Sub agregarMarca()
        Try
            Dim marca As String
            marca = txtMarca.Text



            If conexion.ingresarMarca(marca) Then
                MessageBox.Show("Información Ingresada correctamente", "Ingresando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarMarca()
            Else
                MessageBox.Show("Marca no ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub actualizarMarca()
        Try
            Dim marca As String, id As Integer

            id = txtIDMarca.Text
            marca = txtMarca.Text



            If conexion.ActualizarMarca(id, marca) Then

                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarMarca()
            Else
                MessageBox.Show("Marca no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarMarca()

        Dim marca As String

        marca = txtMarca.Text

        Try
            dataT = conexion.BuscarMarca(marca)
            If dataT.Rows.Count <> 0 Then
                dgvMarca.DataSource = dataT


                MessageBox.Show("Información Encontrada de la marca", "Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                dgvMarca.DataSource = Nothing
                MessageBox.Show("Error al buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Funciones Modelo
    Private Sub agregarModelo()
        Try
            Dim modelo As String, marca As Integer
            modelo = txtModelo.Text
            marca = txtIDMarcaModelo.Text


            If conexion.IngresarModelo(modelo, marca) Then
                MessageBox.Show("Información Ingresada correctamente", "Ingresando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarModelo()
            Else
                MessageBox.Show("Modelo no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub actualizarModelo()
        Try
            Dim modelo, marca As String, id As Integer

            id = txtIDModelo.Text
            modelo = txtModelo.Text
            marca = txtIDMarcaModelo.Text


            If conexion.ActualizarModelo(id, modelo, marca) Then

                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarModelo()
            Else
                MessageBox.Show("Modelo no encontradao", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarModelo()

        Dim modelo As String

        modelo = txtModelo.Text

        Try
            dataT = conexion.BuscarModelo(modelo)
            If dataT.Rows.Count <> 0 Then
                dgvModelo.DataSource = dataT


                MessageBox.Show("Información Encontrada del Modelo", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                dgvMarca.DataSource = Nothing
                MessageBox.Show("Error al buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresarMarca_Click(sender As Object, e As EventArgs) Handles btnIngresarMarca.Click
        agregarMarca()
    End Sub

    Private Sub btnActualizarMarca_Click(sender As Object, e As EventArgs) Handles btnActualizarMarca.Click
        actualizarMarca()
    End Sub

    Private Sub btnBuscarMarca_Click(sender As Object, e As EventArgs) Handles btnBuscarMarca.Click
        buscarMarca()
    End Sub

    Private Sub btnLimpiarMarca_Click(sender As Object, e As EventArgs) Handles btnLimpiarMarca.Click

    End Sub

    Private Sub btnIngresarModelo_Click(sender As Object, e As EventArgs) Handles btnIngresarModelo.Click
        agregarModelo()
    End Sub

    Private Sub btnEditarModelo_Click(sender As Object, e As EventArgs) Handles btnEditarModelo.Click
        actualizarModelo()
    End Sub

    Private Sub btnBuscarModelo_Click(sender As Object, e As EventArgs) Handles btnBuscarModelo.Click
        buscarModelo()
    End Sub

    Private Sub btnLimpiarModelo_Click(sender As Object, e As EventArgs) Handles btnLimpiarModelo.Click

    End Sub
End Class