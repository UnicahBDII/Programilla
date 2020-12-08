<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioAdministracion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.prueba2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGListado = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.prueba2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(365, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 295)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambio de usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 21)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Codigo"
        '
        'prueba2
        '
        Me.prueba2.Location = New System.Drawing.Point(101, 24)
        Me.prueba2.Name = "prueba2"
        Me.prueba2.Size = New System.Drawing.Size(121, 28)
        Me.prueba2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 21)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Rol"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 21)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 21)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Usuario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Contraseña"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 28)
        Me.txtNombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGListado)
        Me.GroupBox2.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 413)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de Usuario"
        '
        'DGListado
        '
        Me.DGListado.AllowUserToAddRows = False
        Me.DGListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListado.Location = New System.Drawing.Point(6, 24)
        Me.DGListado.Name = "DGListado"
        Me.DGListado.Size = New System.Drawing.Size(331, 359)
        Me.DGListado.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 28)
        Me.TextBox1.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 135)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 28)
        Me.TextBox2.TabIndex = 44
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(101, 169)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 28)
        Me.TextBox3.TabIndex = 45
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(101, 237)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(151, 28)
        Me.TextBox5.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(101, 202)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 29)
        Me.ComboBox1.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_II_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(270, 126)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(51, 45)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditar.Image = Global.Clase_II_Parcial.My.Resources.Resources.copiar
        Me.btnEditar.Location = New System.Drawing.Point(270, 75)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(51, 45)
        Me.btnEditar.TabIndex = 37
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.Image = Global.Clase_II_Parcial.My.Resources.Resources.editar1
        Me.btnIngresar.Location = New System.Drawing.Point(270, 24)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(51, 45)
        Me.btnIngresar.TabIndex = 36
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.Image = Global.Clase_II_Parcial.My.Resources.Resources.limpiar
        Me.Button1.Location = New System.Drawing.Point(270, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEliminar.Image = Global.Clase_II_Parcial.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(270, 177)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(51, 45)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(734, 444)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents prueba2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGListado As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
