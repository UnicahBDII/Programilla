<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPageUsuario
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
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelCentral = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSuperior.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.Black
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1084, 32)
        Me.PanelSuperior.TabIndex = 2
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
        Me.btnRestaurar.Location = New System.Drawing.Point(1018, 0)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(982, 0)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(1018, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1054, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 33)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'panelCentral
        '
        Me.panelCentral.BackColor = System.Drawing.SystemColors.Window
        Me.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentral.Location = New System.Drawing.Point(180, 32)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(904, 510)
        Me.panelCentral.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Clase_II_Parcial.My.Resources.Resources._96fa72f23263060b83a37cc084d34d85
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 510)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button2.Image = Global.Clase_II_Parcial.My.Resources.Resources.reloj_de_pared
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(27, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 42)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Ventas x Dia"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel5.Location = New System.Drawing.Point(3, 332)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(18, 42)
        Me.Panel5.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(3, 236)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(18, 42)
        Me.Panel2.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button3.Image = Global.Clase_II_Parcial.My.Resources.Resources.bolsa_de_la_compra
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(27, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 42)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Ventas"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Image = Global.Clase_II_Parcial.My.Resources.Resources.dfdf
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(27, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Productos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel6.Location = New System.Drawing.Point(3, 284)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(18, 42)
        Me.Panel6.TabIndex = 10
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSalir.Image = Global.Clase_II_Parcial.My.Resources.Resources.close
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(27, 332)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(152, 42)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel4.Location = New System.Drawing.Point(3, 188)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(18, 42)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Location = New System.Drawing.Point(3, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 42)
        Me.Panel3.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clase_II_Parcial.My.Resources.Resources.LOGO_EMPRESA_FINAL1
        Me.PictureBox1.Location = New System.Drawing.Point(42, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainPageUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1084, 542)
        Me.Controls.Add(Me.panelCentral)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainPageUsuario"
        Me.Text = "MainPageAlternative"
        Me.PanelSuperior.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelCentral As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
End Class
