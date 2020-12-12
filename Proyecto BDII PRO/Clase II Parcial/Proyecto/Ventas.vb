Public Class Ventas
    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable
    Dim idanterior As Integer
    Public lavariable As Integer
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultarventas()
        consultarclienteventas()
        consultarempleadoventas()

        tctcodigo.Text = idventa()
    End Sub

    Private Sub consultarventas()

        Try
            DataT = conexion.consulta("Center.venta")
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

    Private Sub consultarclienteventas()

        Try
            DataT = conexion.consulta("Center.cliente")
            If DataT.Rows.Count <> 0 Then
                dgcliente.DataSource = DataT
            Else
                dgcliente.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub consultarempleadoventas()

        Try
            DataT = conexion.consulta("Center.empleados")
            If DataT.Rows.Count <> 0 Then
                dgemp.DataSource = DataT
            Else
                dgemp.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgcliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgcliente.CellContentClick
        Try

            Dim dgclientes As DataGridViewRow = dgcliente.Rows(e.RowIndex)
            txxidcliente.Text = dgclientes.Cells(0).Value.ToString()





        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub dgemp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgemp.CellContentClick
        Try

            Dim dgemps As DataGridViewRow = dgemp.Rows(e.RowIndex)
            txtidemp.Text = dgemps.Cells(0).Value.ToString()





        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub ingresarVentas()
        Try
            Dim idcodigo, idcliente, idempleado, formapago As Integer, numerofactura As Integer

            Dim fecha As String
            Dim total As Decimal

            idcodigo = tctcodigo.Text
            idcliente = txxidcliente.Text
            idempleado = txtidemp.Text
            formapago = txtformapago.Text
            numerofactura = txtfactura.Text
            fecha = txtfecha.Text
            total = txttotal.Text



            If conexion.ingresarVenta(idcodigo, idcliente, idempleado, fecha, formapago, numerofactura, total) Then
                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarventas()

                detalleventas.Show()
                Me.Hide()
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresarVentas()

    End Sub

    Private Sub actualizarVenta()
        Try
            Dim idcodigo, idcliente, idempleado, formapago, numerofactura As Integer

            Dim fecha As Date
            Dim total As Decimal

            idcodigo = tctcodigo.Text
            idcliente = txxidcliente.Text
            idempleado = txtidemp.Text
            formapago = txtformapago.Text
            numerofactura = txtfactura.Text
            fecha = txtfecha.Text
            total = txttotal.Text


            If conexion.actualizarVenta(idcodigo, idcliente, idempleado, fecha, formapago, numerofactura, total) Then

                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consultarventas()

            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function idventa()

        If conexion.retornarIdventa() = 0 Then
            idanterior = 1


        Else
            idanterior = conexion.retornarIdventa() + 1

            Return idanterior
        End If
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        actualizarVenta()
    End Sub

    Private Sub Limpiar()
        tctcodigo.Clear()
        txxidcliente.Clear()
        txtidemp.Clear()
        txtfecha.Clear()
        txtformapago.Clear()
        txtfactura.Clear()
        txttotal.Clear()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class