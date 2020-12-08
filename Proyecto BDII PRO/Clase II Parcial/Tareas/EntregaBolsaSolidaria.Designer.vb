<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregaBolsaSolidaria
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.cmbTipoDeBolsa = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtIntegrantes = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstTipoDeBolsa = New System.Windows.Forms.ListBox()
        Me.lstDirrecion = New System.Windows.Forms.ListBox()
        Me.lstEstado = New System.Windows.Forms.ListBox()
        Me.lstIntegrantes = New System.Windows.Forms.ListBox()
        Me.lstNombre = New System.Windows.Forms.ListBox()
        Me.lstIdentidad = New System.Windows.Forms.ListBox()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEntregar)
        Me.GroupBox1.Controls.Add(Me.cmbTipoDeBolsa)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.txtIntegrantes)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(520, 475)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(214, 407)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(150, 44)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(44, 407)
        Me.btnEntregar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(150, 44)
        Me.btnEntregar.TabIndex = 14
        Me.btnEntregar.Text = "Entregar "
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'cmbTipoDeBolsa
        '
        Me.cmbTipoDeBolsa.FormattingEnabled = True
        Me.cmbTipoDeBolsa.Items.AddRange(New Object() {"Basica ", "Regular"})
        Me.cmbTipoDeBolsa.Location = New System.Drawing.Point(214, 342)
        Me.cmbTipoDeBolsa.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbTipoDeBolsa.Name = "cmbTipoDeBolsa"
        Me.cmbTipoDeBolsa.Size = New System.Drawing.Size(189, 33)
        Me.cmbTipoDeBolsa.TabIndex = 13
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(214, 248)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(282, 31)
        Me.txtDireccion.TabIndex = 12
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pobreza Extrema", "Pobreza", "Estable", "Acomodado"})
        Me.cmbEstado.Location = New System.Drawing.Point(214, 196)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(189, 33)
        Me.cmbEstado.TabIndex = 11
        '
        'txtIntegrantes
        '
        Me.txtIntegrantes.Location = New System.Drawing.Point(214, 146)
        Me.txtIntegrantes.Margin = New System.Windows.Forms.Padding(6)
        Me.txtIntegrantes.Mask = "99"
        Me.txtIntegrantes.Name = "txtIntegrantes"
        Me.txtIntegrantes.Size = New System.Drawing.Size(55, 31)
        Me.txtIntegrantes.TabIndex = 10
        Me.txtIntegrantes.ValidatingType = GetType(Integer)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(214, 96)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(282, 31)
        Me.txtNombre.TabIndex = 8
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(214, 46)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(6)
        Me.txtIdentidad.Mask = "0000-0000-00000"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(282, 31)
        Me.txtIdentidad.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 160)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Integrantes "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 262)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 358)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo De Bolsa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lstTipoDeBolsa)
        Me.GroupBox2.Controls.Add(Me.lstDirrecion)
        Me.GroupBox2.Controls.Add(Me.lstEstado)
        Me.GroupBox2.Controls.Add(Me.lstIntegrantes)
        Me.GroupBox2.Controls.Add(Me.lstNombre)
        Me.GroupBox2.Controls.Add(Me.lstIdentidad)
        Me.GroupBox2.Location = New System.Drawing.Point(574, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1340, 503)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(229, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 25)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(534, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 25)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Integr"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(599, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(775, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Direccion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1085, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo de Bolsa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Identidad"
        '
        'lstTipoDeBolsa
        '
        Me.lstTipoDeBolsa.FormattingEnabled = True
        Me.lstTipoDeBolsa.ItemHeight = 25
        Me.lstTipoDeBolsa.Location = New System.Drawing.Point(1090, 71)
        Me.lstTipoDeBolsa.Name = "lstTipoDeBolsa"
        Me.lstTipoDeBolsa.Size = New System.Drawing.Size(230, 404)
        Me.lstTipoDeBolsa.TabIndex = 4
        '
        'lstDirrecion
        '
        Me.lstDirrecion.FormattingEnabled = True
        Me.lstDirrecion.ItemHeight = 25
        Me.lstDirrecion.Location = New System.Drawing.Point(780, 71)
        Me.lstDirrecion.Name = "lstDirrecion"
        Me.lstDirrecion.Size = New System.Drawing.Size(304, 404)
        Me.lstDirrecion.TabIndex = 5
        '
        'lstEstado
        '
        Me.lstEstado.FormattingEnabled = True
        Me.lstEstado.ItemHeight = 25
        Me.lstEstado.Location = New System.Drawing.Point(600, 71)
        Me.lstEstado.Name = "lstEstado"
        Me.lstEstado.Size = New System.Drawing.Size(174, 404)
        Me.lstEstado.TabIndex = 3
        '
        'lstIntegrantes
        '
        Me.lstIntegrantes.FormattingEnabled = True
        Me.lstIntegrantes.ItemHeight = 25
        Me.lstIntegrantes.Location = New System.Drawing.Point(539, 71)
        Me.lstIntegrantes.Name = "lstIntegrantes"
        Me.lstIntegrantes.Size = New System.Drawing.Size(55, 404)
        Me.lstIntegrantes.TabIndex = 2
        '
        'lstNombre
        '
        Me.lstNombre.FormattingEnabled = True
        Me.lstNombre.ItemHeight = 25
        Me.lstNombre.Location = New System.Drawing.Point(234, 71)
        Me.lstNombre.Name = "lstNombre"
        Me.lstNombre.Size = New System.Drawing.Size(299, 404)
        Me.lstNombre.TabIndex = 1
        '
        'lstIdentidad
        '
        Me.lstIdentidad.FormattingEnabled = True
        Me.lstIdentidad.ItemHeight = 25
        Me.lstIdentidad.Location = New System.Drawing.Point(20, 71)
        Me.lstIdentidad.Name = "lstIdentidad"
        Me.lstIdentidad.Size = New System.Drawing.Size(208, 404)
        Me.lstIdentidad.TabIndex = 0
        '
        'txtContador
        '
        Me.txtContador.Enabled = False
        Me.txtContador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtContador.Location = New System.Drawing.Point(1794, 532)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(100, 31)
        Me.txtContador.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1569, 538)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(219, 25)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Canastas Entregadas"
        '
        'EntregaBolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1930, 626)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtContador)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "EntregaBolsaSolidaria"
        Me.Text = "EntregaBolsaSolidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEntregar As Button
    Friend WithEvents cmbTipoDeBolsa As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtIntegrantes As MaskedTextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdentidad As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstTipoDeBolsa As ListBox
    Friend WithEvents lstDirrecion As ListBox
    Friend WithEvents lstEstado As ListBox
    Friend WithEvents lstIntegrantes As ListBox
    Friend WithEvents lstNombre As ListBox
    Friend WithEvents lstIdentidad As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtContador As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnLimpiar As Button
End Class
