Public Class UsuarioAdministracion
    Dim conexion As conexion = New conexion
    Dim dataT As DataTable

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DGListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListado.CellContentClick

    End Sub

    Private Sub UsuarioAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuarios()
        MostrarRol()
    End Sub

    Private Sub MostrarUsuarios()

        Try
            dataT = conexion.consulta("Center.usuario")
            If dataT.Rows.Count <> 0 Then
                DGListado.DataSource = dataT
            Else
                DGListado.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MostrarRol()

        Try
            dataT = conexion.consulta("Center.rol")
            If dataT.Rows.Count <> 0 Then
                dgvRol.DataSource = dataT
            Else
                dgvRol.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub agregarUsuario()
        Try
            Dim nombre, apellido, Usuario, contrasena, correo, rol, estado As String, id As Integer

            id = txtId.Text
            nombre = txtNombre.Text
            apellido = txtApellido.Text
            Usuario = txtUsuario.Text
            contrasena = txtContraseña.Text
            correo = txtCorreo.Text
            rol = txtRol.Text
            estado = cmbEstado.SelectedItem


            If conexion.agregarUsuario(id, nombre, apellido, Usuario, contrasena, correo, rol, estado) Then
                MessageBox.Show("Información Ingresada correctamente", "Ingresando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuarios()
            Else
                MessageBox.Show("Usuario no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub actualizarUsuario()
        Try
            Dim nombre, apellido, Usuario, contrasena, correo, rol, estado As String, id As Integer

            id = txtId.Text
            nombre = txtNombre.Text
            apellido = txtApellido.Text
            Usuario = txtUsuario.Text
            contrasena = txtContraseña.Text
            correo = txtCorreo.Text
            rol = txtRol.Text
            estado = cmbEstado.SelectedItem


            If conexion.ActualizarUsuario(id, nombre, apellido, Usuario, contrasena, correo, rol, estado) Then

                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuarios()
            Else
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarEmpleado()

        Dim nombreUsuario As String

        nombreUsuario = Usuario.Text

        Try
            dataT = conexion.BuscarUsuario(nombreUsuario)
            If dataT.Rows.Count <> 0 Then
                DGListado.DataSource = dataT


                MessageBox.Show("Información Encontrada del Usuario", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                DGListado.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        agregarUsuario()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        actualizarUsuario()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarEmpleado()
    End Sub
End Class