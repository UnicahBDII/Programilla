Imports System.Runtime.InteropServices

Public Class MainPage
    Private Sub AbrirFormulario(frmHijo As Object)
        Try
            If (panelCentral.Controls.Count > 0) Then
                panelCentral.Controls.RemoveAt(0)
            Else
                Dim frm As Form
                frm = frmHijo
                frm.TopLevel = False
                frm.Dock = DockStyle.Fill
                panelCentral.Controls.Add(frm)
                panelCentral.Tag = frm
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs)
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs)
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea cerrar sesion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        AbrirFormulario(EMPLEADOS)

    End Sub

    Private Sub MainPage_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgBox("Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub btnMinimizar_Click_1(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click_1(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True

        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMaximizar_Click_1(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormulario(Productos)

    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) 
        AbrirFormulario(Compras)

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormulario(Ventas)

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        AbrirFormulario(UsuarioAdministracion)
    End Sub

    Private Sub txtTelefono_Click(sender As Object, e As EventArgs) Handles txtTelefono.Click
        AbrirFormulario(TelefonosEmpleados)
    End Sub

    Private Sub txtRegistro_Click(sender As Object, e As EventArgs) Handles txtRegistro.Click
        AbrirFormulario(RegistroCompleto)
    End Sub
End Class




