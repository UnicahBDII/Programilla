Public Class Factura

    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable


    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idnuevo()
        consultarfactura()
    End Sub

    Private Sub idnuevo()

        'If conexion.retornarventa() Then

        '    txtidventa.Text = conexion.retornarventa()


        'Else
        '    MessageBox.Show("error")
        'End If

        For i = 0 To 5 Step 1
            Select Case i
                'Case 0
                '    txtidventa.Text = conexion.retornarventa(0)
                'Case 1
                '    TextBox1.Text = conexion.retornarventa(1)
                Case 2
                    txtnombrecliente.Text = conexion.retornarventa(2)
                Case 3
                    txtfecha.Text = conexion.retornarventa(3)
                Case 4
                    txttotal.Text = conexion.retornarventa(4)
                    'Case 5
                    '    txtnombreempleado.Text = conexion.retornarventa(5)

            End Select
        Next
        txtnombreempleado.Text = conexion.retornaremp()

    End Sub






    Private Sub consultarfactura()
        Dim factura As String
        Dim idventa As Integer
        idventa = conexion.retornarventa(0)

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
End Class