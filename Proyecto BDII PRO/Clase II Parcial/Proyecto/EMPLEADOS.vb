Imports System.Data.SqlClient
Public Class EMPLEADOS
    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable


    Private Sub limpiar()
        prueba2.Clear()
        txtIdentidad.Clear()
        cmbDepto.SelectedIndex = -1
        cmbmunicipio.SelectedIndex = -1
        txtBarrio.Clear()
        cmbPuesto.SelectedIndex = -1
        txtNombre.Clear()
        txtEdad.Clear()
        txtPrueba.Clear()
        conexion.conexion.Close()
    End Sub

    Private Sub cmbDepto_LostFocus(sender As Object, e As EventArgs) Handles cmbDepto.LostFocus
        Dim Departamento As Integer
        Departamento = cmbDepto.SelectedIndex
        Select Case Departamento
            Case 0
                Dim atlantida(7) As String
                atlantida(0) = "La Ceiba"
                atlantida(1) = "El Porvenir"
                atlantida(2) = "Esparta"
                atlantida(3) = "Jutiapa"
                atlantida(4) = "La Masica"
                atlantida(5) = "San Francisco"
                atlantida(6) = "Tela"
                atlantida(7) = "Arizna"
                cmbmunicipio.Items.Clear()
                For i = 0 To (atlantida.Length - 1) Step 1
                    cmbmunicipio.Items.Add(atlantida(i))
                Next
            Case 1
                Dim colon(9) As String
                colon(0) = "Trujillo"
                colon(1) = "Balfate"
                colon(2) = "Iriona"
                colon(3) = "Limón"
                colon(4) = "Sabá"
                colon(5) = "Santa Fe"
                colon(6) = "Santa Rosa de Aguán"
                colon(7) = "Sonaguera"
                colon(8) = "Tocoa"
                colon(9) = "Bonito Oriental"
                cmbmunicipio.Items.Clear()
                For i = 0 To (colon.Length - 1) Step 1
                    cmbmunicipio.Items.Add(colon(i))
                Next
            Case 2
                Dim comayagua(20) As String
                comayagua(0) = "Comayagua"
                comayagua(1) = "Ajuterique"
                comayagua(2) = "El Rosario"
                comayagua(3) = "Esquías"
                comayagua(4) = "Humuya"
                comayagua(5) = "La Libertad"
                comayagua(6) = "Lamaní"
                comayagua(7) = "La Trinidad"
                comayagua(8) = "Lejamaní"
                comayagua(9) = "Meámbar"
                comayagua(10) = "Minas de Oro"
                comayagua(11) = "Ojos de Agua"
                comayagua(12) = "San Jerónimo"
                comayagua(13) = "San José de Comayagua"
                comayagua(14) = "San José del Potrero"
                comayagua(15) = "San Luis"
                comayagua(16) = "San Sebastián"
                comayagua(17) = "Siguatepeque"
                comayagua(18) = "Villa de San Antonio "
                comayagua(19) = "Las Lajas"
                comayagua(20) = "Taulabé"
                cmbmunicipio.Items.Clear()
                For i = 0 To (comayagua.Length - 1) Step 1
                    cmbmunicipio.Items.Add(comayagua(i))
                Next
            Case 3
                Dim copan(22) As String
                copan(0) = "Santa Rosa de Copán"
                copan(1) = "Cabañas"
                copan(2) = "Concepción"
                copan(3) = "Copán Ruinas"
                copan(4) = "Corquín"
                copan(5) = "Cucuyagua"
                copan(6) = "Dolores"
                copan(7) = "Dulce Nombre"
                copan(8) = "El Paraíso"
                copan(9) = "Florida"
                copan(10) = "La Jigua"
                copan(11) = "La Unión"
                copan(12) = "Nueva Arcadia"
                copan(13) = "San Agustín"
                copan(14) = "San Antonio"
                copan(15) = "San Jerinimo"
                copan(16) = "San José"
                copan(17) = "San Juan de Opoa"
                copan(18) = "San Nicolás"
                copan(19) = "San Pedro"
                copan(20) = "Santa Rita "
                copan(21) = "Trinidad de Copán"
                copan(22) = "Veracruz"
                cmbmunicipio.Items.Clear()
                For i = 0 To (copan.Length - 1) Step 1
                    cmbmunicipio.Items.Add(copan(i))
                Next
            Case 4
                Dim cortes(11) As String
                cortes(0) = "San Pedro Sula"
                cortes(1) = "Choloma"
                cortes(2) = "Omoa"
                cortes(3) = "Pimienta"
                cortes(4) = "Potrerillos"
                cortes(5) = "Puerto Cortés"
                cortes(6) = "San Antonio de Cortés"
                cortes(7) = "San Francisco de Yojoa"
                cortes(8) = "San Manuel"
                cortes(9) = "Santa Cruz de Yojoa"
                cortes(10) = "villanueva"
                cortes(11) = "La Lima"
                cmbmunicipio.Items.Clear()
                For i = 0 To (cortes.Length - 1) Step 1
                    cmbmunicipio.Items.Add(cortes(i))
                Next

            Case 5
                Dim choluteca(15) As String
                choluteca(0) = "Choluteca"
                choluteca(1) = "Apacilagua"
                choluteca(2) = "Concepción de María"
                choluteca(3) = "Duyure"
                choluteca(4) = "El Corpus"
                choluteca(5) = "El Triunfo"
                choluteca(6) = "Marcovia"
                choluteca(7) = "Morolina"
                choluteca(8) = "Namasigüe"
                choluteca(9) = "Orocuina"
                choluteca(10) = "Pespire"
                choluteca(11) = "San Antonio de Flores"
                choluteca(12) = "San Isidro"
                choluteca(13) = "San José"
                choluteca(14) = "San Marcos de Colón"
                choluteca(15) = "Santa Ana de Yusguare"
                cmbmunicipio.Items.Clear()
                For i = 0 To (choluteca.Length - 1) Step 1
                    cmbmunicipio.Items.Add(choluteca(i))
                Next
            Case 6
                Dim paraiso(18) As String
                paraiso(0) = "Yuscarán"
                paraiso(1) = "Alauca"
                paraiso(2) = "Danlí"
                paraiso(3) = "El Paraiso"
                paraiso(4) = "Güinope"
                paraiso(5) = "Jacaleapa"
                paraiso(6) = "Liure"
                paraiso(7) = "Morocelí"
                paraiso(8) = "Oropolí"
                paraiso(9) = "Potrerillos"
                paraiso(10) = "San Antonio de Flors"
                paraiso(11) = "San Lucas"
                paraiso(12) = "San Matías"
                paraiso(13) = "Soledad"
                paraiso(14) = "Teupasenti"
                paraiso(15) = "Vado Ancho"
                paraiso(16) = "Yauyupe"
                paraiso(17) = "Trojes"
                paraiso(18) = "Texiguat"
                cmbmunicipio.Items.Clear()
                For i = 0 To (paraiso.Length - 1) Step 1
                    cmbmunicipio.Items.Add(paraiso(i))
                Next
            Case 7
                Dim francisco(27) As String
                francisco(0) = "Tegucigalpa"
                francisco(1) = "Alabarén"
                francisco(2) = "Cedros"
                francisco(3) = "Curarén"
                francisco(4) = "El Porvenir"
                francisco(5) = "Guaimaca"
                francisco(6) = "La Libertad"
                francisco(7) = "La Venta"
                francisco(8) = "Lepaterique"
                francisco(9) = "Maraita"
                francisco(10) = "marela"
                francisco(11) = "Nueva Armenia"
                francisco(12) = "Ojojona"
                francisco(13) = "Orica"
                francisco(14) = "Reitoca"
                francisco(15) = "Sabanagrande"
                francisco(16) = "San Antonio de Oriente"
                francisco(17) = "San Buenaventura"
                francisco(18) = "San Ignacio"
                francisco(19) = "San Juan de Flores(Cantarranas)"
                francisco(20) = "San Miguelito"
                francisco(21) = "Santa Ana"
                francisco(22) = "Santa Lucía"
                francisco(23) = "Talanga"
                francisco(24) = "Tatumbla"
                francisco(25) = "Valle de Ángeles"
                francisco(26) = "Villa de San Francisco"
                francisco(27) = "Vallecillo"
                cmbmunicipio.Items.Clear()
                For i = 0 To (francisco.Length - 1) Step 1
                    cmbmunicipio.Items.Add(francisco(i))
                Next

            Case 8
                Dim gracias(5) As String
                gracias(0) = "Puerto Lempira"
                gracias(1) = "Brus Laguna"
                gracias(2) = "Ahuas"
                gracias(3) = "Juan Francisco Bulnes"
                gracias(4) = "Ramón Villeda Morales"
                gracias(5) = "Wampusirpe"
                cmbmunicipio.Items.Clear()
                For i = 0 To (gracias.Length - 1) Step 1
                    cmbmunicipio.Items.Add(gracias(i))
                Next
            Case 9
                Dim intibuca(16) As String
                intibuca(0) = "La Esperanza"
                intibuca(1) = "Camasca"
                intibuca(2) = "Colomoncagua"
                intibuca(3) = "Concepción"
                intibuca(4) = "Dolores"
                intibuca(5) = "Intibucá"
                intibuca(6) = "Jesus de Otoro"
                intibuca(7) = "Magdalena"
                intibuca(8) = "Masaguara"
                intibuca(9) = "San Antonio"
                intibuca(10) = "San Isidro"
                intibuca(11) = "San Juan"
                intibuca(12) = "San Marcos de la Sierra"
                intibuca(13) = "San Miguel Guancapla"
                intibuca(14) = "Santa Lucía"
                intibuca(15) = "Yamaranguila"
                intibuca(16) = "San Francisco de Opalaca"
                cmbmunicipio.Items.Clear()
                For i = 0 To (intibuca.Length - 1) Step 1
                    cmbmunicipio.Items.Add(intibuca(i))
                Next
            Case 10
                Dim bahia(3) As String
                bahia(0) = "Roatán"
                bahia(1) = "Guanaja"
                bahia(2) = "José Santos Guardiola"
                bahia(3) = "Utila"
                cmbmunicipio.Items.Clear()
                For i = 0 To (bahia.Length - 1) Step 1
                    cmbmunicipio.Items.Add(bahia(i))
                Next
            Case 11
                Dim paz(18) As String
                paz(0) = "La Paz"
                paz(1) = "Aguanqueterique"
                paz(2) = "Cabañas"
                paz(3) = "Cane"
                paz(4) = "Chinacla"
                paz(5) = "Guajiquiro"
                paz(6) = "Lauterique"
                paz(7) = "Marcala"
                paz(8) = "Mercedes de Oriente"
                paz(9) = "Opatoro"
                paz(10) = "San Antonio del Norte"
                paz(11) = "San José"
                paz(12) = "San Juan"
                paz(13) = "San Pedro de Tutule"
                paz(14) = "Santa Ana"
                paz(15) = "Santa Elena"
                paz(16) = "Santa María"
                paz(17) = "Santiago de Puringa"
                paz(18) = "Yarula"
                cmbmunicipio.Items.Clear()
                For i = 0 To (paz.Length - 1) Step 1
                    cmbmunicipio.Items.Add(paz(i))
                Next
            Case 12
                Dim lempira(27) As String
                lempira(0) = "Gracias"
                lempira(1) = "Belén"
                lempira(2) = "Candelaria"
                lempira(3) = "Cololaca"
                lempira(4) = "Erandique"
                lempira(5) = "Gualcince"
                lempira(6) = "Guarita"
                lempira(7) = "La Campa"
                lempira(8) = "La Iguala"
                lempira(9) = "Las Flores"
                lempira(10) = "La Unión"
                lempira(11) = "La Virtud"
                lempira(12) = "Lepaera"
                lempira(13) = "Mapulaca"
                lempira(14) = "Piraera"
                lempira(15) = "San Andrés"
                lempira(16) = "San Francisco"
                lempira(17) = "San Juan Guarita"
                lempira(18) = "San Manuel Colohete"
                lempira(19) = "San Rafael"
                lempira(20) = "San Sebastián"
                lempira(21) = "Santa Cruz"
                lempira(22) = "Talgua"
                lempira(23) = "Tambla"
                lempira(24) = "Valladolid"
                lempira(25) = "Virginia"
                lempira(26) = "San Marcos de Caiquín"
                lempira(27) = "Tomalá"
                cmbmunicipio.Items.Clear()
                For i = 0 To (lempira.Length - 1) Step 1
                    cmbmunicipio.Items.Add(lempira(i))
                Next
            Case 13
                Dim ocotepeque(15) As String
                ocotepeque(0) = "Nueva Ocotepeque"
                ocotepeque(1) = "Belén Gualcho"
                ocotepeque(2) = "Concepción"
                ocotepeque(3) = "Doloren Merendón"
                ocotepeque(4) = "Fraternidad"
                ocotepeque(5) = "La Encarganición"
                ocotepeque(6) = "La labor"
                ocotepeque(7) = "Lucerna"
                ocotepeque(8) = "Mercedes"
                ocotepeque(9) = "San Fernando"
                ocotepeque(10) = "San Francisco del Valle"
                ocotepeque(11) = "San Jorge"
                ocotepeque(12) = "San Marcos"
                ocotepeque(13) = "Santa Fe"
                ocotepeque(14) = "Senseti"
                ocotepeque(15) = "Sinuapa"
                cmbmunicipio.Items.Clear()
                For i = 0 To (ocotepeque.Length - 1) Step 1
                    cmbmunicipio.Items.Add(ocotepeque(i))
                Next
            Case 14
                Dim olancho(22) As String
                olancho(0) = "Juticalpa"
                olancho(1) = "Campamento"
                olancho(2) = "Catacamas"
                olancho(3) = "Concordia"
                olancho(4) = "Dulce Nombre de Culmí"
                olancho(5) = "el Rosario"
                olancho(6) = "Esquipulas del Norte"
                olancho(7) = "Gualaco"
                olancho(8) = "Guarizoma"
                olancho(9) = "Guata"
                olancho(10) = "Guayape"
                olancho(11) = "Jano"
                olancho(12) = "La Unión"
                olancho(13) = "Mangulile"
                olancho(14) = "Manto"
                olancho(15) = "Salamá"
                olancho(16) = "San Esteban"
                olancho(17) = "San Francisco de Becerra"
                olancho(18) = "San Francisco de la Paz"
                olancho(19) = "Santa María del Real"
                olancho(20) = "Silca"
                olancho(21) = "Yocón"
                olancho(22) = "Patuca"
                cmbmunicipio.Items.Clear()
                For i = 0 To (olancho.Length - 1) Step 1
                    cmbmunicipio.Items.Add(olancho(i))
                Next
            Case 15
                Dim santa(27) As String
                santa(0) = "Santa Bárbara"
                santa(1) = "Arada"
                santa(2) = "Atima"
                santa(3) = "Azacualpa"
                santa(4) = "Ceguaca"
                santa(5) = "San José de las Colinas"
                santa(6) = "Concepción del Norte"
                santa(7) = "Concepción del Sur"
                santa(8) = "Chinda"
                santa(9) = "El Níspero"
                santa(10) = "Gualala"
                santa(11) = "Llama"
                santa(12) = "Macuelizo"
                santa(13) = "Naranjito"
                santa(14) = "Nuevo Celilac"
                santa(15) = "Petoa"
                santa(16) = "Protección"
                santa(17) = "Quimistán"
                santa(18) = "San Francisco de Ojuera"
                santa(19) = "San Luis"
                santa(20) = "San Marcos"
                santa(21) = "San Nicolás"
                santa(22) = "San Pedro Zacapa"
                santa(23) = "Santa Rita"
                santa(24) = "San Vicente Centenario"
                santa(25) = "Trinidad"
                santa(26) = "Las Vegas"
                santa(27) = "Nueva Frontera"
                cmbmunicipio.Items.Clear()
                For i = 0 To (santa.Length - 1) Step 1
                    cmbmunicipio.Items.Add(santa(i))
                Next
            Case 16
                Dim valle(8) As String
                valle(0) = "Alianza"
                valle(1) = "Amapala"
                valle(2) = "Aramecina"
                valle(3) = "Caridad"
                valle(4) = "Giascorán"
                valle(5) = "Langue"
                valle(6) = "Nacaome"
                valle(7) = "San Francisco de Coray"
                valle(8) = "san Lorenzo"
                cmbmunicipio.Items.Clear()
                For i = 0 To (valle.Length - 1) Step 1
                    cmbmunicipio.Items.Add(valle(i))
                Next
            Case 17
                Dim yoro(10) As String
                yoro(0) = "Yoro"
                yoro(1) = "Arenal"
                yoro(2) = "El Negrito"
                yoro(3) = "El Progreso"
                yoro(4) = "Jocón"
                yoro(5) = "Morazán"
                yoro(6) = "Olnachito"
                yoro(7) = "Santa Rita"
                yoro(8) = "Sulaco"
                yoro(9) = "Victoria"
                yoro(10) = "Yorito"
                cmbmunicipio.Items.Clear()
                For i = 0 To (yoro.Length - 1) Step 1
                    cmbmunicipio.Items.Add(yoro(i))
                Next
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
        prueba2.Enabled = True
    End Sub






    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            direccion = cmbDepto.Text & ", " & cmbmunicipio.Text & ", " & txtBarrio.Text
            If txtIdentidad.Text.Length <> 15 Then
                MessageBox.Show("La identidad esta incompleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If cmbmunicipio.SelectedIndex = -1 Or cmbDepto.SelectedIndex = -1 Or cmbPuesto.SelectedIndex = -1 Or cmbSexo.SelectedIndex = -1 Then
                MessageBox.Show("Debe llenar todos los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If prueba2.Text = "" Or txtNombre.Text = "" Or txtPrueba.Text = "" Or txtBarrio.Text = "" Or txtEdad.Text = "" Then
                MessageBox.Show("Debe llenar todos los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            index = Val(cmbPuesto.SelectedIndex)
            Identidad = txtIdentidad.Text


            If (conexion.validarEmpleados(prueba2.Text) = False) Then
                    Dim agregar As String = "insert into Center.empleados values(" + prueba2.Text + ",'" + Identidad + "','" + txtNombre.Text + "','" + direccion + "','" + txtEdad.Text + "','" + cmbSexo.Text + "','" + cmbPuesto.Text + "', '" + txtPrueba.Text + "')"
                    If (conexion.Insertar(agregar)) Then
                        MessageBox.Show("Empleado agregado correctamente!!!", "Ingreso de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()

                Else
                        MessageBox.Show("Error al agregar el Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MsgBox("Este empleado ya existe", vbObjectError)
                    conexion.conexion.Close()

                End If



        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
        conexion.conexion.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim id As Integer
        id = cmbPuesto.SelectedIndex
        txtPrueba.Text = id

    End Sub
    Private Sub cmbPuesto_LostFocus(sender As Object, e As EventArgs) Handles cmbPuesto.LostFocus
        Dim id As Integer
        id = cmbPuesto.SelectedIndex
        txtPrueba.Text = id
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim id As String
        id = txtIdentidad.Text
        prueba2.Text = id

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        direccion = cmbDepto.Text & ", " & cmbmunicipio.Text & ", " & txtBarrio.Text
        Try
            Dim modificar As String =
           "identidad='" + txtIdentidad.Text + "', nombre='" + txtNombre.Text + "', direccion='" + txtBarrio.Text + "', edad='" + txtEdad.Text + "',sexo='" + cmbSexo.Text + "',puesto='" + cmbPuesto.Text + "',idPuesto='" + txtPrueba.Text + "'"
            If (conexion.modificar("Center.empleados", modificar, " IdCodigo=" + prueba2.Text)) Then
                MessageBox.Show("Actualizado")

                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub DGListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListado.CellContentClick
        Try

            Dim dgempleados As DataGridViewRow = DGListado.Rows(e.RowIndex)
            prueba2.Text = dgempleados.Cells(0).Value.ToString()
            txtIdentidad.Text = dgempleados.Cells(1).Value.ToString()
            txtNombre.Text = dgempleados.Cells(2).Value.ToString()
            txtBarrio.Text = dgempleados.Cells(3).Value.ToString()
            txtEdad.Text = dgempleados.Cells(4).Value.ToString()
            cmbSexo.Text = dgempleados.Cells(5).Value.ToString()
            cmbPuesto.Text = dgempleados.Cells(6).Value.ToString()
            txtPrueba.Text = dgempleados.Cells(7).Value.ToString()

            cmbDepto.SelectedIndex = -1
            cmbmunicipio.SelectedIndex = -1

            cmbDepto.Enabled = False
            cmbmunicipio.Enabled = False
            prueba2.Enabled = False

            btnEliminar.Enabled = True
            btnEditar.Enabled = True

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try

    End Sub


    Private Sub consultarPresidente()
        Try
            DataT = conexion.llenarDataGridEmpleado()
            If DataT.Rows.Count <> 0 Then
                DGListado.DataSource = DataT
                DGListado.DataSource = DataT
            Else
                DGListado.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("Center.empleados", "IdCodigo = " + prueba2.Text)) Then
                MessageBox.Show("Registro eliminado correctamente")

            Else
                MessageBox.Show("error al eliminar")

            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Ejemplo: 0318-2004-02610")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepto_MouseHover(sender As Object, e As EventArgs) Handles cmbDepto.MouseHover
        ToolTip.SetToolTip(cmbDepto, "Ejemplo: Comayagua")
        ToolTip.ToolTipTitle = "Departamento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ejemplo: Alberto Jose Martinez Lopez")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbmunicipio_MouseHover(sender As Object, e As EventArgs) Handles cmbmunicipio.MouseHover
        ToolTip.SetToolTip(cmbmunicipio, "Ejemplo: Siguatepeque")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtBarrio_MouseHover(sender As Object, e As EventArgs) Handles txtBarrio.MouseHover
        ToolTip.SetToolTip(txtBarrio, "Ejemplo: San Juan")
        ToolTip.ToolTipTitle = "Barrio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Ejemplo: 99")
        ToolTip.ToolTipTitle = "Años"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbPuesto_MouseHover(sender As Object, e As EventArgs) Handles cmbPuesto.MouseHover
        ToolTip.SetToolTip(cmbPuesto, "Ejemplo: Jefe de RRHH")
        ToolTip.ToolTipTitle = "Puesto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrueba_MouseHover(sender As Object, e As EventArgs) Handles txtPrueba.MouseHover
        ToolTip.SetToolTip(txtPrueba, "Se selecciona automaticamente")
        ToolTip.ToolTipTitle = "ID puesto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ToolTip.SetToolTip(btnIngresar, "Ingresa un nuevo Empleado a la Base de Datos")
        ToolTip.ToolTipTitle = "Ingresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip.SetToolTip(Button1, "Limpia la informacion antes registrada")
        ToolTip.ToolTipTitle = "Limpiar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub DGListado_MouseHover(sender As Object, e As EventArgs) Handles DGListado.MouseHover
        ToolTip.SetToolTip(DGListado, "Muestra todos los registros que se encuentran en la base de datos")
        ToolTip.ToolTipTitle = "Ingreso de Información"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbSexo_MouseHover(sender As Object, e As EventArgs) Handles cmbSexo.MouseHover
        ToolTip.SetToolTip(cmbSexo, "Ejemplo: Masculino")
        ToolTip.ToolTipTitle = "Seleccion de sexo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        ToolTip.SetToolTip(btnEditar, "Realiza una actualizacion de un registro")
        ToolTip.ToolTipTitle = "Editar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEliminar_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover
        ToolTip.SetToolTip(btnEliminar, "Realiza una eliminacion de un registro")
        ToolTip.ToolTipTitle = "Eliminar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        ToolTip.SetToolTip(btnBuscar, "Realiza una busqueda de un registro")
        ToolTip.ToolTipTitle = "Buscar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbDepto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbDepto.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub cmbSexo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbSexo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbmunicipio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbmunicipio.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbPuesto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbPuesto.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtBarrio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBarrio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtPrueba_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrueba.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub busquedaDeDatos()
        conexion.Consulta("select * from Center.empleados where IdCodigo = '" + prueba2.Text + "'", "Center.empleados")
        DGListado.DataSource = conexion.ds.Tables("Center.empleados")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.Consulta("select * from Center.empleados where IdCodigo = '" + prueba2.Text + "'", "Center.empleados")

        If (conexion.validarEmpleados(prueba2.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatos()

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub EMPLEADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class