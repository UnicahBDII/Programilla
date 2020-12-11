<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.txtpreciocompra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcaracteristica = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txttiproducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodbarra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvModelos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGListado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(357, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 413)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de Productos"
        '
        'DGListado
        '
        Me.DGListado.AllowUserToAddRows = False
        Me.DGListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListado.Location = New System.Drawing.Point(6, 24)
        Me.DGListado.Name = "DGListado"
        Me.DGListado.RowHeadersWidth = 51
        Me.DGListado.Size = New System.Drawing.Size(520, 372)
        Me.DGListado.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtpreciocompra)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtcaracteristica)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtmodelo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtestado)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtventa)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txttiproducto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.idtxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcodbarra)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 515)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txtpreciocompra
        '
        Me.txtpreciocompra.Location = New System.Drawing.Point(119, 187)
        Me.txtpreciocompra.Name = "txtpreciocompra"
        Me.txtpreciocompra.Size = New System.Drawing.Size(121, 26)
        Me.txtpreciocompra.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Precio.Compra"
        '
        'txtcaracteristica
        '
        Me.txtcaracteristica.Location = New System.Drawing.Point(101, 397)
        Me.txtcaracteristica.Multiline = True
        Me.txtcaracteristica.Name = "txtcaracteristica"
        Me.txtcaracteristica.Size = New System.Drawing.Size(220, 102)
        Me.txtcaracteristica.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 436)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Caracteristica"
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(101, 330)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(151, 26)
        Me.txtmodelo.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Marca"
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(101, 296)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(151, 26)
        Me.txtestado.TabIndex = 47
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(119, 262)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(121, 26)
        Me.txtcantidad.TabIndex = 46
        '
        'txtventa
        '
        Me.txtventa.Location = New System.Drawing.Point(119, 228)
        Me.txtventa.Name = "txtventa"
        Me.txtventa.Size = New System.Drawing.Size(121, 26)
        Me.txtventa.TabIndex = 45
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(113, 132)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(151, 26)
        Me.txtnombre.TabIndex = 44
        '
        'txttiproducto
        '
        Me.txttiproducto.Location = New System.Drawing.Point(101, 96)
        Me.txttiproducto.Name = "txttiproducto"
        Me.txttiproducto.Size = New System.Drawing.Size(151, 26)
        Me.txttiproducto.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 20)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Id"
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(101, 24)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(121, 26)
        Me.idtxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Cantidad"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-3, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Tipo.Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Precio.Venta"
        '
        'txtcodbarra
        '
        Me.txtcodbarra.Location = New System.Drawing.Point(101, 58)
        Me.txtcodbarra.Name = "txtcodbarra"
        Me.txtcodbarra.Size = New System.Drawing.Size(151, 26)
        Me.txtcodbarra.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cod.Barra"
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
        'dgvModelos
        '
        Me.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModelos.Location = New System.Drawing.Point(431, 431)
        Me.dgvModelos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvModelos.Name = "dgvModelos"
        Me.dgvModelos.RowHeadersWidth = 51
        Me.dgvModelos.RowTemplate.Height = 24
        Me.dgvModelos.Size = New System.Drawing.Size(376, 88)
        Me.dgvModelos.TabIndex = 7
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(932, 539)
        Me.Controls.Add(Me.dgvModelos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvModelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGListado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtestado As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtventa As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttiproducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents idtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcodbarra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtcaracteristica As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpreciocompra As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvModelos As DataGridView
End Class
