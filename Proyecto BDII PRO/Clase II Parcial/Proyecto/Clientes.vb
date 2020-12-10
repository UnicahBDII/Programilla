Public Class Clientes
    Dim conexion As conexion = New conexion
    Dim dataT As DataTable


    Private Sub consultarCliente()

        Try
            dataT = conexion.consulta("Center.cliente")
            If dataT.Rows.Count <> 0 Then
                dgvClientes.DataSource = dataT
            Else
                dgvClientes.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub ingresarCliente()
        Try
            Dim identidad As String, nombre As String, numero As String, apellido As String, direccion As String

            identidad = txtidentidad.Text
            nombre = txtNombre.Text
            apellido = txtApellido.Text
            numero = txtNumero.Text
            direccion = txtDirección.Text



            If conexion.IngresarCliente(identidad, nombre, numero, apellido, direccion) Then
                MessageBox.Show("Información ingresada correctamente", "Ingresando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarCliente()
            Else
                MessageBox.Show("Error al ingresar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub actualizarCliente()
        Try
            Dim identidad As String, nombre As String, numero As String, apellido As String, direccion As String

            identidad = txtidentidad.Text
            nombre = txtNombre.Text
            apellido = txtApellido.Text
            numero = txtNumero.Text
            direccion = txtDirección.Text



            If conexion.ActualizarCliente(identidad, nombre, numero, apellido, direccion) Then

                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarCliente()
            Else
                MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarCliente()
        Try
            Dim identidad

            identidad = txtidentidad.Text

            If conexion.eliminarCliente(identidad) Then
                MessageBox.Show("Información Eliminada correctamente", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarCliente()
            Else
                MessageBox.Show("cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresarCliente()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        actualizarCliente()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarCliente()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultarCliente()
    End Sub
End Class