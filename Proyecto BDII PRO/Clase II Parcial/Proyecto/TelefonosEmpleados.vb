Public Class TelefonosEmpleados
    Dim conexion As conexion = New conexion
    Dim DataT As DataTable
    Private Sub TelefonosEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarModelo()
        MostrarTelefonosEmpleado()
        MostrarTipoPaquete()
    End Sub
    Private Sub MostrarModelo()
        Try
            DataT = conexion.consulta("dbo.vMarcas")
            If DataT.Rows.Count <> 0 Then
                dgvMarca.DataSource = DataT
            Else
                dgvMarca.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarTelefonosEmpleado()
        Try
            DataT = conexion.consulta("dbo.Telefonos_Empleados")
            If DataT.Rows.Count <> 0 Then
                dgvTelefonosEmpleados.DataSource = DataT
            Else
                dgvTelefonosEmpleados.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarTipoPaquete()
        Try
            DataT = conexion.consulta("dbo.Tipo_Paquete")
            If DataT.Rows.Count <> 0 Then
                dgvTipoPaquete.DataSource = DataT
            Else
                dgvTipoPaquete.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresarEmpleado()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        actualizarEmpleado()
    End Sub


    Private Sub ingresarEmpleado()
        Try
            Dim Telefono, TipoPaquete As Integer


            Telefono = txtTelefono.Text
            TipoPaquete = txtTipoPaquete.Text

            If conexion.ingresarTelefonosEmpleado(Telefono, TipoPaquete) Then
                MessageBox.Show("Información ingresada correctamente", "Ingresando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarTelefonosEmpleado()
            Else
                MessageBox.Show("Error Ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub actualizarEmpleado()

        Try
                Dim ID, Telefono, TipoPaquete As Integer

                ID = txtID.Text
                Telefono = txtTelefono.Text
                TipoPaquete = txtTipoPaquete.Text

                If conexion.actualizarTelefonosEmpleado(ID, Telefono, TipoPaquete) Then
                    MessageBox.Show("Información actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarTelefonosEmpleado()
                Else
                    MessageBox.Show("Error Actualización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
    End Sub

End Class