Public Class LibretaDeAhorro
    Private Monto As Integer
    'Procedimientos
    Private Sub activarControles()
        txtNombre.Enabled = False
        txtMonto.Enabled = False
        btnApertura.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub

    Private Sub DesactiveControles()
        txtNombre.Enabled = True
        txtMonto.Enabled = True
        btnApertura.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub

    Private Sub Limpiar()
        DesactiveControles()
        txtNombre.Clear()
        txtSaldoTotal.Clear()
        txtMonto.Clear()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
    End Sub

    Private Sub LibretaDeAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactiveControles()
    End Sub

    Private Sub mostrarSaldo()
        txtSaldoTotal.Text = Monto
    End Sub

    Private Sub btnApertura_Click(sender As Object, e As EventArgs) Handles btnApertura.Click
        Dim cliente As String
        cliente = txtNombre.Text
        Monto = Val(txtMonto.Text)
        If (Monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("Ingrese un monto valido", "Ingreso monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "operacion")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        Monto += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > Monto) Then
            MessageBox.Show("Saldo Insuficiente", "Error de deposito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Monto -= retiro
            lstRetiros.Items.Add(retiro)
            mostrarSaldo()
        End If
    End Sub
End Class