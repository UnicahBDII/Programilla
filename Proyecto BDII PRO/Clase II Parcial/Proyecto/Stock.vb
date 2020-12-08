Imports System.Data.SqlClient
Public Class Stock
    Public comando As SqlCommand
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")
    Public dr As SqlDataReader

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            abrirConexion()
            conexion.Open()
            comando = New SqlCommand("Select count(*) as paquete1 from Center.stock where puesto='Gerente'")



            'Dim mostrar As String = "select st.IdCodigo, st.identidad , st.nombre, st.puesto, te.modelo,te.tipoPaquete,te.Descripcion, te.cantidad from Center.stock st inner join Center.telefonos te on st.idPuesto = te.id"

            'If conexion.MostrarAsignacion(mostrar) = False Then
            'MessageBox.Show("No se ha hecho ninguna asignacion", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'End If
            llenarDataGridStock(DGstock)
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

End Class