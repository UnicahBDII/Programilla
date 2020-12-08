<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGListado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.prueba2 = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGListado)
        Me.GroupBox2.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(374, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 413)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compras"
        '
        'DGListado
        '
        Me.DGListado.AllowUserToAddRows = False
        Me.DGListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListado.Location = New System.Drawing.Point(6, 24)
        Me.DGListado.Name = "DGListado"
        Me.DGListado.Size = New System.Drawing.Size(577, 383)
        Me.DGListado.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.prueba2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 295)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de compras"
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
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1025, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Compras"
        Me.Text = "Compras"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGListado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents prueba2 As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEliminar As Button
End Class
