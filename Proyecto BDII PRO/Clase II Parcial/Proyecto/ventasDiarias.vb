Public Class ventasDiarias
    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable
    Dim idanterior As Integer
    Public lavariable As Integer
    Private Sub ventasDiarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultarventas()
    End Sub

    Private Sub consultarventas()
        Try
            DataT = conexion.consulta("dbo.vVentaspordiaEmp")
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

End Class