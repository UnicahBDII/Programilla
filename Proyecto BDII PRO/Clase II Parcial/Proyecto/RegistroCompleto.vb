Public Class RegistroCompleto

    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable
    Dim idanterior As Integer
    Public lavariable As Integer
    Private Sub RegistroCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub consultarventas()
        Try
            DataT = conexion.consultaProcediminetos("dbo.clientesconmasventas")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clienteEstrella()
        Try
            DataT = conexion.consulta("dbo.vVentasporMES")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub empleadosEstrella()
        Try
            DataT = conexion.consultaProcediminetos("dbo.VentasEmpleados")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub empleadoEstrella()
        Try
            DataT = conexion.consultaProcediminetos("dbo.EmpleadoDelMes")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub infoEmpleado()
        Try
            DataT = conexion.consulta("dbo.vEmpleados")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub infoProductos()
        Try
            DataT = conexion.consulta("dbo.vProductos")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub infoEntrada()
        Try
            DataT = conexion.consulta("dbo.vEntrada")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub infoSalida()
        Try
            DataT = conexion.consulta("dbo.vSalida")
            If DataT.Rows.Count <> 0 Then
                DGpopo.DataSource = DataT
            Else
                DGpopo.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        clienteEstrella()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consultarventas()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        empleadosEstrella()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        empleadoEstrella()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        infoEmpleado()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        infoProductos()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        infoEntrada()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        infoSalida()
    End Sub
End Class