Imports System.Data.SqlClient

Public Class Telefono
    ' Nconexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")

    Dim codigo As String
    Dim identidadEmp As String
    Dim NombreEmp As String
    Dim puesto As String
    Dim idPuesto As String

    Dim conexion As ConexionCrud = New ConexionCrud

    Private Sub Telefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub busquedaDeDatos()
        conexion.Consulta("select * from Center.empleados where IdCodigo = '" + txtCodigo.Text + "'", "Center.empleados")
        DGtelefono.DataSource = conexion.ds.Tables("Center.empleados")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.Consulta("select * from Center.empleados where IdCodigo = '" + txtCodigo.Text + "'", "Center.empleados")

        If (conexion.validarEmpleados(txtCodigo.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatos()

        End If
        conexion.conexion.Close()

    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click

        Try
            Dim id As Integer
            id = Val(txtPrueba.Text)

            If txtIdentidad.Text = "" Or txtNombre.Text = "" Or txtPrueba.Text = "" Or txtPuesto.Text = "" Or txtCodigo.Text = "" Then
                MessageBox.Show("Debe seleccionar la infomacion mostrada en la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If id > 8 Then
                MessageBox.Show("No hay telefono disponible para este usuario", "Error al asiganr telefono", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                If (conexion.validarStock(txtCodigo.Text) = False) Then
                        Dim agregar As String = "insert into Center.stock values(" + txtCodigo.Text + ",'" + txtIdentidad.Text + "','" + txtNombre.Text + "','" + txtPuesto.Text + "','" + txtPrueba.Text + "')"
                        If (conexion.Insertar(agregar)) Then
                            MessageBox.Show("Asignacion de telefono completada!!!", "Ingreso de telefono", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            conexion.conexion.Close()
                        Else
                            MessageBox.Show("Error en la asiganacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Telefono ya asignado a este empleado", "Repeticion de asignacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                conexion.conexion.Close()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
        conexion.conexion.Close()

    End Sub

    Private Sub DGtelefono_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGtelefono.CellContentClick
        Try
            Dim dgempleados As DataGridViewRow = DGtelefono.Rows(e.RowIndex)
            txtCodigo.Text = dgempleados.Cells(0).Value.ToString()
            txtIdentidad.Text = dgempleados.Cells(1).Value.ToString()
            txtNombre.Text = dgempleados.Cells(2).Value.ToString()
            txtPuesto.Text = dgempleados.Cells(6).Value.ToString()
            txtPrueba.Text = dgempleados.Cells(7).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
        conexion.conexion.Close()

    End Sub


End Class