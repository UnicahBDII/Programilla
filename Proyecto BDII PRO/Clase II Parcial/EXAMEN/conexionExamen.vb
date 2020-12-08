Imports System.Data.Sql
Imports System.Data.SqlClient
Module conexionExamen
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=Tienda;Integrated Security=True")
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public Sub abrirConexionTienda()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=Tienda;Integrated Security=True")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Nose pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub

    Sub llenarDataGridTienda(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select fc.nombre, fc.apellido, fp.nombreProducto, fv.precio, fv.cantidad, fv.fechaVenta  
            from factura.Venta fv
            inner join factura.cliente fc 
            on fv.idCliente = fc.idCliente inner join factura.producto fp
            on fv.idProducto = fp.idProducto  ", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub


End Module
