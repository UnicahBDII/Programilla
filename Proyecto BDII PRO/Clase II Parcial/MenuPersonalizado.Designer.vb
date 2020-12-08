<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPersonalizado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.DimGray
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 32)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(734, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(30, 33)
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(698, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 33)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(734, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 33)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(770, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 33)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelLateral.Controls.Add(Me.Panel3)
        Me.PanelLateral.Controls.Add(Me.btnEmpleados)
        Me.PanelLateral.Controls.Add(Me.Panel2)
        Me.PanelLateral.Controls.Add(Me.btnClientes)
        Me.PanelLateral.Controls.Add(Me.Panel1)
        Me.PanelLateral.Controls.Add(Me.btnProductos)
        Me.PanelLateral.Controls.Add(Me.btnMenu)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 32)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(165, 418)
        Me.PanelLateral.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 127)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 33)
        Me.Panel3.TabIndex = 8
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Bebas Neue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnEmpleados.Image = Global.Clase_II_Parcial.My.Resources.Resources.empleados
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 127)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(158, 33)
        Me.btnEmpleados.TabIndex = 7
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 33)
        Me.Panel2.TabIndex = 6
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Bebas Neue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnClientes.Image = Global.Clase_II_Parcial.My.Resources.Resources.clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 88)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(157, 33)
        Me.btnClientes.TabIndex = 5
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 33)
        Me.Panel1.TabIndex = 4
        '
        'btnProductos
        '
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Bebas Neue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnProductos.Image = Global.Clase_II_Parcial.My.Resources.Resources.producto
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 52)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(157, 33)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.Clase_II_Parcial.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(119, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(40, 40)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.Location = New System.Drawing.Point(165, 32)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(635, 418)
        Me.PanelForms.TabIndex = 2
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrar
        '
        '
        'MenuPersonalizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPersonalizado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPersonalizado"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelForms As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnProductos As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrar As Timer
End Class
