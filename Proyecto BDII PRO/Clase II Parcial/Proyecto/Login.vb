Imports System.Runtime.InteropServices

Public Class Login
    Dim conexion As conexion = New conexion()

    Dim dt As New DataTable
    Dim direccion As String
    Dim Identidad As String
    Dim index As Integer
    Dim DataT As New DataTable

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña.Clear()
        txtUsuario.Clear()

    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click




        Try
            validacionus()

        Catch ex As Exception
            MessageBox.Show("error")
        End Try
        'If txtContraseña.Text = contra And txtUsuario.Text = Usuario Then
        '    MsgBox("Ingreso al sistema Exitosamente!", vbInformation + vbOK, "Informacion")
        '    Me.Hide()
        '    PantallaDeCarga.Show()
        'Else
        '    MsgBox("Ingreso fallido, vuelva a intentarlo...", vbObjectError + vbOK, "Error")
        'End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip.SetToolTip(txtUsuario, "Ejemplo: ADMIN")
        ToolTip.ToolTipTitle = "Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        ToolTip.SetToolTip(txtContraseña, "Ejemplo: 12345")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub validacionus()
        Try
            Dim username As String
            Dim llave As String
            Dim rol, compare As String
            Dim vars As Integer
            username = txtUsuario.Text
            llave = txtContraseña.Text


            If conexion.VerificarUsuario(username, llave) Then
                MessageBox.Show("Bienvenido a Compucenter.;)", "Sesion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                username = txtUsuario.Text
                TextBox1.Text = conexion.retornarrol(username)
                rol = TextBox1.Text.ToString

                'MsgBox(rol)
                compare = "Empleado"
                vars = String.Compare(rol, compare)
                'MsgBox(vars)

                If (vars) = 1 Then
                    Me.Hide()
                    MainPageUsuario.Show()

                Else


                    MainPage.Show()

                    Me.Hide()
                End If

            Else
                MessageBox.Show("No se pudo iniciar la sesion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class