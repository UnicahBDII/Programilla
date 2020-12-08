Public Class Arreglos

    'estas son variables globales para el programa
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private Index As Byte
    Private encuentra As Boolean = False

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim computadoras(3) As String

        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "Mac"

        For i = 0 To (computadoras.Length - 1) Step 1

            cmbComputadoras.Items.Add(computadoras(i))

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrecio.Click
        Dim precio(3) As Integer

        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000

        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecio.Items.Add(precio(i))
        Next

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim cant As Integer
        Dim comp() As String

        cant = Val(txtCantidad.Text)

        ReDim comp(cant)

        For i = 0 To cant - 1 Step 1
            comp(i) = InputBox("Ingrese la marca de la computadora", "Solicitud")
        Next

        For j = 0 To cant - 1 Step 1
            cmbCantidad.Items.Add(comp(j))
        Next

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbPrecio.Items.Clear()
        cmbComputadoras.Items.Clear()
    End Sub

    Private Sub Arreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModelo.Enabled = False
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        cantComputadoras = Val(txtRegistro.Text)
        ReDim mComputadoras(cantComputadoras, 3)

        'matriz de 3x3 comenzara a contar desde 0
        For i = 0 To (cantComputadoras - 1) Step 1
            mComputadoras(i, 0) = InputBox("Ingrese la marca de la computadora " & (i + 1), "Marca")
            mComputadoras(i, 1) = InputBox("Ingrese el modelode la computadora " & (i + 1), "Marca")
            mComputadoras(i, 2) = InputBox("Ingrese el precio de la computadora " & (i + 1), "Marca")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad de la computadora " & (i + 1), "Marca")
            Index = i
        Next
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim marca As String
        marca = txtMarca.Text

        For i = 0 To (cantComputadoras - 1) Step 1
            If (mComputadoras(i, 0) = marca) Then
                txtModelo.Text = mComputadoras(i, 1)
                txtPrecio.Text = mComputadoras(i, 2)
                txtCantidad.Text = mComputadoras(i, 3)
                encuentra = True
                btnVender.Enabled = True
                btnBuscar.Enabled = True
            End If
        Next
        If (encuentra = False) Then
            MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim cantVender, stock As Integer
        cantVender = Val(txtVender.Text)
        stock = mComputadoras(Index, 3)
        If (cantVender >= stock) Then
            MessageBox.Show("Sin stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            mComputadoras(Index, 3) = stock - cantVender
            MessageBox.Show("Venta Realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class