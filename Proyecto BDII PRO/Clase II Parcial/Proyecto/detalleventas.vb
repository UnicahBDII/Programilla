Public Class detalleventas

    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable


    Dim idanterior As Integer

    Public sumatotal As Integer
    Public restarsuma As Integer
    Private Sub detalleventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idnuevo()
        consultarproductos()
    End Sub


    Function idnuevodetalle()

        If conexion.retornarIddetalleproducto() = 0 Then
            idanterior = 1


        Else
            idanterior = conexion.retornarIddetalleproducto() + 1
            Return idanterior
        End If
    End Function

    Private Sub idnuevo()

        'If conexion.retornarventa() Then

        '    txtidventa.Text = conexion.retornarventa()


        'Else
        '    MessageBox.Show("error")
        'End If

        For i = 0 To 5 Step 1
            Select Case i
                Case 0
                    txtidventa.Text = conexion.retornarventa(0)
                Case 1
                    txtidcliente.Text = conexion.retornarventa(1)
                Case 2
                    txtnombrecliente.Text = conexion.retornarventa(2)
                Case 3
                    txt1.Text = conexion.retornarventa(3)
                Case 4
                    txttotal.Text = conexion.retornarventa(4)
                    'Case 5
                    '    txtnumerodoc.Text = conexion.retornarventa(5)

            End Select
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub consultarproductos()

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
    Private Sub insertardetalle()
        Dim id, iddetalleventa, idventa, idProducto, cantidad As Integer
        Dim precio As Decimal
        id = Val(idnuevodetalle())
        idventa = Val(txtidventa.Text)
        idProducto = txtidproducto.Text
        cantidad = Val(txtcantidad.Text)
        precio = Val(txtprecio.Text)

        Try
            If conexion.insertardetalleVenta(id, idventa, idproducto, cantidad, precio) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                idnuevo()


                consultardetalleactual()

                consultarproductos()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub consultardetalleventa()

        Try
            DataT = conexion.consulta("Center.detalleventa")
            If DataT.Rows.Count <> 0 Then
                dgcarrito.DataSource = DataT
            Else
                dgcarrito.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertardetalle()
        idnuevo()
    End Sub

    Private Sub consultardetalleactual()
        Dim idventa As Integer
        idventa = conexion.retornarIdventa()

        Try
            DataT = conexion.selectdeproductosdetalle(idventa)

            If DataT.Rows.Count <> 0 Then
                dgcarrito.DataSource = DataT
            Else
                dgcarrito.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer


        id = idnuevodetalle() - 1
        MsgBox(idnuevodetalle())

        Dim Pregunta As Integer

        Pregunta = MsgBox("Deseas Eliminar el producto del articulo ?", vbYesNoCancel + vbInformation, "Eliminar producto")

        Select Case Pregunta
            Case Is = 6

                Try
                    If conexion.Eliminardetalleventa(id) Then
                        MsgBox("Se elimino")

                        consultardetalleactual()
                        idnuevo()
                        consultarproductos()
                    End If
                Catch ex As Exception

                End Try
            Case Is = 7

            Case Else

        End Select
    End Sub

    Private Sub DGListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListado.CellContentClick
        Try

            Dim DGlistados As DataGridViewRow = DGListado.Rows(e.RowIndex)
            txtidproducto.Text = DGlistados.Cells(0).Value.ToString()
            txtprecio.Text = DGlistados.Cells(5).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub consultarfactura()
        Dim factura As String
        Dim idventa As Integer
        idventa = Val(txtidventa.Text)

        factura = "dbo.vFactura where [Numero de factura] = " & idventa

        Try
            DataT = conexion.consulta(factura)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Factura.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class