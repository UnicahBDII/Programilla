Public Class EntregaBolsaSolidaria
    Private contador As Integer
    Private Identidades() As String
    Dim Temporal As String

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim Datos(5) As String
        Try
            ReDim Identidades(contador - 1)

            Datos(0) = txtIdentidad.Text


            Datos(1) = txtNombre.Text

            Datos(2) = Val(txtIntegrantes.Text)

            Select Case cmbEstado.SelectedIndex
                Case 0
                    Datos(3) = "Pobreza Extrema"
                Case 1
                    Datos(3) = "Pobreza"
                Case 2
                    Datos(3) = "Estable"
                Case 3
                    Datos(3) = "Acomodado"
            End Select

            Datos(4) = txtDireccion.Text

            Select Case cmbTipoDeBolsa.SelectedIndex
                Case 0
                    Datos(5) = "Basica"
                Case 1
                    Datos(5) = "Regular"
            End Select


            If Temporal = Datos(0) Then
                MessageBox.Show("Ya se ha entregado una bolsa a este usuario", "Duplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lstIdentidad.Items.Add(Datos(0))
                lstNombre.Items.Add(Datos(1))
                lstIntegrantes.Items.Add(Datos(2))
                lstEstado.Items.Add(Datos(3))
                lstDirrecion.Items.Add(Datos(4))
                lstTipoDeBolsa.Items.Add(Datos(5))
                Identidades(contador - 1) = txtIdentidad.Text
                contador = contador + 1
            End If

            Temporal = txtIdentidad.Text
            txtContador.Text = contador

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Ingrese una identificación correcta ejemplo: 0318200200555")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese su nombre completo")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIntegrantes_MouseHover(sender As Object, e As EventArgs) Handles txtIntegrantes.MouseHover
        ToolTip.SetToolTip(txtIntegrantes, "Numero de Integrantes en su hogar")
        ToolTip.ToolTipTitle = "Integrantes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip.SetToolTip(cmbEstado, "Selecciones la condicion de su habitad")
        ToolTip.ToolTipTitle = "Estado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtDireccion, "Ingrese municipio y departamento en donde habita")
        ToolTip.ToolTipTitle = "Direccion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbTipoDeBolsa_MouseHover(sender As Object, e As EventArgs) Handles cmbTipoDeBolsa.MouseHover
        ToolTip.SetToolTip(cmbTipoDeBolsa, "Basica: Arroz, frijoles, azucar, harina, café, maíz, manteca<-->Regular: Basica + pasta, aceite, sal, cornflakes, salsa y condimentos")
        ToolTip.ToolTipTitle = "Tipo de Bolsa"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtIdentidad.Clear()
        txtNombre.Clear()
        txtIntegrantes.Clear()
        cmbEstado.ResetText()
        txtDireccion.Clear()
        cmbTipoDeBolsa.ResetText()
    End Sub
End Class