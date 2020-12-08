Imports System.Data.SqlClient
Public Class Examen_II_Parcial
    Dim conexion As CRUDexamen = New CRUDexamen
    Dim dt As New DataTable

    Private Sub Examen_II_Parcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexionTienda()
        llenarDataGridTienda(DGtienda)
        mostrarDatos()
    End Sub

    Private Sub mostrarDatos()
        conexion.Consulta("select fc.nombre, fc.apellido, fp.nombreProducto, fv.precio, fv.cantidad, fv.fechaVenta  
        from factura.Venta fv
        inner join factura.cliente fc 
        on fv.idCliente = fc.idCliente inner join factura.producto fp
        on fv.idProducto = fp.idProducto  ", "factura.ventas")
        DGtienda.DataSource = conexion.ds.Tables("factura.ventas")
    End Sub

    Sub limpiar()
        txtNombre.Clear()
        txtApellido.Clear()
        cmbProducto.ResetText()
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtFecha.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim producto As Integer
        Try
            producto = cmbProducto.SelectedIndex + 1
            If cmbProducto.SelectedIndex = -1 Then
                MessageBox.Show("Olvido rellenar un campo obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If txtNombre.Text = "" Or txtFecha.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Or txtApellido.Text = "" Then
                MessageBox.Show("Olvido rellenar un campo obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim agregar As String = "insert into factura.venta values(" + txtNombre.Text + ", '" + txtApellido.Text + "','" + ListBox1.SelectedItem + "','" + txtFecha.Text + "','" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + ListBox2.SelectedItem + "','" + producto + "')"

            If (conexion.Insertar(agregar)) Then
                MessageBox.Show("Empleado agregado correctamente!!!", "Ingreso de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrarDatos()

            Else
                MessageBox.Show("Error al ingresar su compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
        conexion.conexion.Close()
    End Sub

    Private Sub cmbProducto_LostFocus(sender As Object, e As EventArgs) Handles cmbProducto.LostFocus
        Dim IdProducto As Integer
        IdProducto = cmbProducto.SelectedIndex

        Select Case IdProducto
            Case 0
                txtPrecio.Text = 20
                txtDescripcion.Text = "Especial para hacer un buen hatrick"
            Case 1
                txtPrecio.Text = 15
                txtDescripcion.Text = "De calidad y comodidad"
            Case 2
                txtPrecio.Text = 15
                txtDescripcion.Text = "Otorgan velocidad y regates magistrales"
            Case 3
                txtPrecio.Text = 1000
                txtDescripcion.Text = "Los mejores del mundo tienen una"
            Case 4
                txtPrecio.Text = 100
                txtDescripcion.Text = "Todo gran goleador tiene una"
            Case 5
                txtPrecio.Text = 50
                txtDescripcion.Text = "Perfectas para ver a tus fans"


        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(CInt(Rnd() * 100000))
        ListBox2.Items.Add(CInt(Rnd() * 100000))
        btnAgregar.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("factura.Ventas", "nombre = " + txtNombre.Text)) Then
                MessageBox.Show("Registro eliminado correctamente")
                mostrarDatos()
            Else
                MessageBox.Show("error al eliminar")

            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim modificar As String =
           "nombre='" + txtNombre.Text + "', apellido='" + txtApellido.Text + "', cantidad='" + txtCantidad.Text + "', precio='" + txtPrecio.Text + "',fechaVenta='" + txtFecha.Text + "',puesto='"
            If (conexion.modificar("factura.Ventas", modificar, " nombre=" + txtNombre.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ejemplo: Fernando")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        ToolTip.SetToolTip(txtApellido, "Ejemplo: Flores")
        ToolTip.ToolTipTitle = "Apellido"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Ejemplo: Barrio El Carmen")
        ToolTip.ToolTipTitle = "Direccion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbProducto_MouseHover(sender As Object, e As EventArgs) Handles cmbProducto.MouseHover
        ToolTip.SetToolTip(cmbProducto, "Elija el producto de su preferencia")
        ToolTip.ToolTipTitle = "Productos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Informacion sobre el producto")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip.SetToolTip(txtCantidad, "Ejemplo: 99")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip.SetToolTip(txtPrecio, "Informacion del precio del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtFecha_MouseHover(sender As Object, e As EventArgs) Handles txtFecha.MouseHover
        ToolTip.SetToolTip(txtFecha, "Fecha de la compra")
        ToolTip.ToolTipTitle = "Fecha"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
