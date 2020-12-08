<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arreglos
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbPrecio = New System.Windows.Forms.ComboBox()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCantidad = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidadRegistro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Registro = New System.Windows.Forms.GroupBox()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVender = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Registro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbPrecio)
        Me.GroupBox1.Controls.Add(Me.btnPrecio)
        Me.GroupBox1.Controls.Add(Me.cmbComputadoras)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensional"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(87, 159)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbPrecio
        '
        Me.cmbPrecio.FormattingEnabled = True
        Me.cmbPrecio.Location = New System.Drawing.Point(148, 119)
        Me.cmbPrecio.Name = "cmbPrecio"
        Me.cmbPrecio.Size = New System.Drawing.Size(95, 21)
        Me.cmbPrecio.TabIndex = 6
        '
        'btnPrecio
        '
        Me.btnPrecio.Location = New System.Drawing.Point(148, 68)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(95, 32)
        Me.btnPrecio.TabIndex = 5
        Me.btnPrecio.Text = "Generar Precio"
        Me.btnPrecio.UseVisualStyleBackColor = True
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(18, 119)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(95, 21)
        Me.cmbComputadoras.TabIndex = 4
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(18, 68)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(95, 32)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "GenerarPC"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCantidad)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinamico"
        '
        'cmbCantidad
        '
        Me.cmbCantidad.FormattingEnabled = True
        Me.cmbCantidad.Location = New System.Drawing.Point(94, 68)
        Me.cmbCantidad.Name = "cmbCantidad"
        Me.cmbCantidad.Size = New System.Drawing.Size(121, 21)
        Me.cmbCantidad.TabIndex = 3
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(9, 68)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(115, 32)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cant. Computadoras"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRegistro)
        Me.GroupBox3.Controls.Add(Me.txtRegistro)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(319, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 114)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(73, 58)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistro.TabIndex = 2
        Me.btnRegistro.Text = "Registrar"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(106, 19)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(100, 20)
        Me.txtRegistro.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cant.Comptadoras"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtCantidadRegistro)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtModelo)
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtMarca)
        Me.GroupBox4.Location = New System.Drawing.Point(319, 132)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 137)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad"
        '
        'txtCantidadRegistro
        '
        Me.txtCantidadRegistro.Location = New System.Drawing.Point(72, 103)
        Me.txtCantidadRegistro.Name = "txtCantidadRegistro"
        Me.txtCantidadRegistro.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadRegistro.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(72, 77)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Modelo"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(72, 51)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(178, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(72, 25)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtMarca.TabIndex = 0
        '
        'Registro
        '
        Me.Registro.Controls.Add(Me.btnVender)
        Me.Registro.Controls.Add(Me.Label7)
        Me.Registro.Controls.Add(Me.txtVender)
        Me.Registro.Location = New System.Drawing.Point(319, 275)
        Me.Registro.Name = "Registro"
        Me.Registro.Size = New System.Drawing.Size(259, 101)
        Me.Registro.TabIndex = 4
        Me.Registro.TabStop = False
        Me.Registro.Text = "Registro"
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(73, 59)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(75, 23)
        Me.btnVender.TabIndex = 11
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cantidad"
        '
        'txtVender
        '
        Me.txtVender.Location = New System.Drawing.Point(72, 30)
        Me.txtVender.Name = "txtVender"
        Me.txtVender.Size = New System.Drawing.Size(100, 20)
        Me.txtVender.TabIndex = 9
        '
        'Arreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Registro)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Arreglos"
        Me.Text = "Arreglos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Registro.ResumeLayout(False)
        Me.Registro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPrecio As ComboBox
    Friend WithEvents btnPrecio As Button
    Friend WithEvents cmbCantidad As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents txtRegistro As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidadRegistro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Registro As GroupBox
    Friend WithEvents btnVender As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVender As TextBox
End Class
