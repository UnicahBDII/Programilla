Imports System.Data.SqlClient
Public Class EMPLEADOS
    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable


    Private Sub limpiar()
        txtCodigo.Clear()
        txtIdentidad.Clear()
        txtBarrio.Clear()
        cmbPuesto.SelectedIndex = -1
        txtNombre.Clear()
        txtEdad.Clear()
        txtidpuesto.Clear()
        conexion.conexion.Close()
        cmbSexo.SelectedIndex = -1
        txtestado.Clear()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
        txtCodigo.Enabled = True
    End Sub






    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresarEmpleado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim id As Integer
        id = cmbPuesto.SelectedIndex
        txtidpuesto.Text = id

    End Sub
    Private Sub cmbPuesto_LostFocus(sender As Object, e As EventArgs) Handles cmbPuesto.LostFocus
        Dim id As Integer
        id = cmbPuesto.SelectedIndex
        txtidpuesto.Text = id
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim id As String
        id = txtIdentidad.Text
        txtCodigo.Text = id

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        actualizarEmpleado()
    End Sub

    Private Sub DGListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListado.CellContentClick
        Try

            Dim dgempleados As DataGridViewRow = DGListado.Rows(e.RowIndex)
            txtCodigo.Text = dgempleados.Cells(0).Value.ToString()
            txtIdentidad.Text = dgempleados.Cells(1).Value.ToString()
            txtNombre.Text = dgempleados.Cells(2).Value.ToString()
            txtBarrio.Text = dgempleados.Cells(3).Value.ToString()
            txtEdad.Text = dgempleados.Cells(4).Value.ToString()
            cmbSexo.Text = dgempleados.Cells(5).Value.ToString()
            txtidpuesto.Text = dgempleados.Cells(6).Value.ToString()
            txtestado.Text = dgempleados.Cells(7).Value.ToString()



            txtCodigo.Enabled = False

            btnEliminar.Enabled = True
            btnEditar.Enabled = True

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try

    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarEmpleado()
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Ejemplo: 0318-2004-02610")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ejemplo: Alberto Jose Martinez Lopez")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtBarrio_MouseHover(sender As Object, e As EventArgs) Handles txtBarrio.MouseHover
        ToolTip.SetToolTip(txtBarrio, "Ejemplo: San Juan")
        ToolTip.ToolTipTitle = "Barrio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Ejemplo: 99")
        ToolTip.ToolTipTitle = "Años"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbPuesto_MouseHover(sender As Object, e As EventArgs) Handles cmbPuesto.MouseHover
        ToolTip.SetToolTip(cmbPuesto, "Ejemplo: Jefe de RRHH")
        ToolTip.ToolTipTitle = "Puesto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrueba_MouseHover(sender As Object, e As EventArgs) Handles txtidpuesto.MouseHover
        ToolTip.SetToolTip(txtidpuesto, "Se selecciona automaticamente")
        ToolTip.ToolTipTitle = "ID puesto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ToolTip.SetToolTip(btnIngresar, "Ingresa un nuevo Empleado a la Base de Datos")
        ToolTip.ToolTipTitle = "Ingresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip.SetToolTip(Button1, "Limpia la informacion antes registrada")
        ToolTip.ToolTipTitle = "Limpiar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub DGListado_MouseHover(sender As Object, e As EventArgs) Handles DGListado.MouseHover
        ToolTip.SetToolTip(DGListado, "Muestra todos los registros que se encuentran en la base de datos")
        ToolTip.ToolTipTitle = "Ingreso de Información"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbSexo_MouseHover(sender As Object, e As EventArgs) Handles cmbSexo.MouseHover
        ToolTip.SetToolTip(cmbSexo, "Ejemplo: Masculino")
        ToolTip.ToolTipTitle = "Seleccion de sexo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        ToolTip.SetToolTip(btnEditar, "Realiza una actualizacion de un registro")
        ToolTip.ToolTipTitle = "Editar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover
        ToolTip.SetToolTip(btnEliminar, "Realiza una eliminacion de un registro")
        ToolTip.ToolTipTitle = "Eliminar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        ToolTip.SetToolTip(btnBuscar, "Realiza una busqueda de un registro")
        ToolTip.ToolTipTitle = "Buscar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbDepto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub cmbSexo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbSexo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbmunicipio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbPuesto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbPuesto.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtBarrio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBarrio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtPrueba_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtidpuesto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub ingresarEmpleado()
        Try
            Dim idcodigo, edad, idpuesto As Integer
            Dim Identidad, nombre, direccion, sexo As String


            idcodigo = txtCodigo.Text
            identidad = txtIdentidad.Text
            nombre = txtNombre.Text
            direccion = txtBarrio.Text
            edad = txtEdad.Text
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
    Private Sub actualizarEmpleado()
        Try
            Dim identidad As String, nombre As String, direccion As String, edad As Integer, sexo As String, idpuesto As Integer


            identidad = txtIdentidad.Text
            nombre = txtNombre.Text
            direccion = txtBarrio.Text
            edad = txtEdad.Text
            sexo = cmbSexo.SelectedItem
            idpuesto = txtidpuesto.Text



            If conexion.actualizarEmpleado(identidad, nombre, direccion, edad, sexo, idpuesto) Then

                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarEmpleado()
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarEmpleado()
        Try
            Dim identidad

            identidad = txtIdentidad.Text

            If conexion.eliminarEmpleado(identidad) Then
                MessageBox.Show("Información Eliminada correctamente", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarEmpleado()
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscarEmpleado()

        Dim identidad

            identidad = txtIdentidad.Text

        Try
            DataT = conexion.BuscarEmpleado(identidad)
            If DataT.Rows.Count <> 0 Then
                    DGListado.DataSource = DataT


                MessageBox.Show("Información Encontrada del Empleado", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                    DGListado.DataSource = Nothing
                    MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarEmpleado()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub EMPLEADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        consultarEmpleado()
    End Sub
    Private Sub consultarEmpleado()

        Try
            DataT = conexion.consulta("Center.empleados")
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

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtestado.TextChanged

    End Sub
End Class