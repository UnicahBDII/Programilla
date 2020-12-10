<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marca_y_Modelo
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvMarca = New System.Windows.Forms.DataGridView()
        Me.dgvModelo = New System.Windows.Forms.DataGridView()
        Me.txtIDModelo = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtIDMarca = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtIDMarcaModelo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscarModelo = New System.Windows.Forms.Button()
        Me.btnEditarModelo = New System.Windows.Forms.Button()
        Me.btnIngresarModelo = New System.Windows.Forms.Button()
        Me.btnLimpiarModelo = New System.Windows.Forms.Button()
        Me.btnLimpiarMarca = New System.Windows.Forms.Button()
        Me.btnBuscarMarca = New System.Windows.Forms.Button()
        Me.btnActualizarMarca = New System.Windows.Forms.Button()
        Me.btnIngresarMarca = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiarModelo)
        Me.GroupBox1.Controls.Add(Me.btnBuscarModelo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnEditarModelo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnIngresarModelo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIDMarcaModelo)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtIDModelo)
        Me.GroupBox1.Controls.Add(Me.dgvModelo)
        Me.GroupBox1.Location = New System.Drawing.Point(556, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 529)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modelo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimpiarMarca)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnBuscarMarca)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnActualizarMarca)
        Me.GroupBox2.Controls.Add(Me.btnIngresarMarca)
        Me.GroupBox2.Controls.Add(Me.txtMarca)
        Me.GroupBox2.Controls.Add(Me.txtIDMarca)
        Me.GroupBox2.Controls.Add(Me.dgvMarca)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 529)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marca"
        '
        'dgvMarca
        '
        Me.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarca.Location = New System.Drawing.Point(89, 234)
        Me.dgvMarca.Name = "dgvMarca"
        Me.dgvMarca.RowHeadersWidth = 51
        Me.dgvMarca.RowTemplate.Height = 24
        Me.dgvMarca.Size = New System.Drawing.Size(359, 250)
        Me.dgvMarca.TabIndex = 0
        '
        'dgvModelo
        '
        Me.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModelo.Location = New System.Drawing.Point(39, 234)
        Me.dgvModelo.Name = "dgvModelo"
        Me.dgvModelo.RowHeadersWidth = 51
        Me.dgvModelo.RowTemplate.Height = 24
        Me.dgvModelo.Size = New System.Drawing.Size(403, 250)
        Me.dgvModelo.TabIndex = 1
        '
        'txtIDModelo
        '
        Me.txtIDModelo.Location = New System.Drawing.Point(219, 48)
        Me.txtIDModelo.Name = "txtIDModelo"
        Me.txtIDModelo.Size = New System.Drawing.Size(158, 22)
        Me.txtIDModelo.TabIndex = 2
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(219, 94)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(158, 22)
        Me.txtModelo.TabIndex = 3
        '
        'txtIDMarca
        '
        Me.txtIDMarca.Location = New System.Drawing.Point(179, 62)
        Me.txtIDMarca.Name = "txtIDMarca"
        Me.txtIDMarca.Size = New System.Drawing.Size(158, 22)
        Me.txtIDMarca.TabIndex = 4
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(179, 108)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(158, 22)
        Me.txtMarca.TabIndex = 5
        '
        'txtIDMarcaModelo
        '
        Me.txtIDMarcaModelo.Location = New System.Drawing.Point(219, 141)
        Me.txtIDMarcaModelo.Name = "txtIDMarcaModelo"
        Me.txtIDMarcaModelo.Size = New System.Drawing.Size(158, 22)
        Me.txtIDMarcaModelo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID"
        '
        'btnBuscarModelo
        '
        Me.btnBuscarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.buscar
        Me.btnBuscarModelo.Location = New System.Drawing.Point(459, 360)
        Me.btnBuscarModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarModelo.Name = "btnBuscarModelo"
        Me.btnBuscarModelo.Size = New System.Drawing.Size(68, 55)
        Me.btnBuscarModelo.TabIndex = 42
        Me.btnBuscarModelo.UseVisualStyleBackColor = True
        '
        'btnEditarModelo
        '
        Me.btnEditarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.copiar
        Me.btnEditarModelo.Location = New System.Drawing.Point(459, 297)
        Me.btnEditarModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarModelo.Name = "btnEditarModelo"
        Me.btnEditarModelo.Size = New System.Drawing.Size(68, 55)
        Me.btnEditarModelo.TabIndex = 41
        Me.btnEditarModelo.UseVisualStyleBackColor = True
        '
        'btnIngresarModelo
        '
        Me.btnIngresarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.editar1
        Me.btnIngresarModelo.Location = New System.Drawing.Point(459, 234)
        Me.btnIngresarModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIngresarModelo.Name = "btnIngresarModelo"
        Me.btnIngresarModelo.Size = New System.Drawing.Size(68, 55)
        Me.btnIngresarModelo.TabIndex = 40
        Me.btnIngresarModelo.UseVisualStyleBackColor = True
        '
        'btnLimpiarModelo
        '
        Me.btnLimpiarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLimpiarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLimpiarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.limpiar
        Me.btnLimpiarModelo.Location = New System.Drawing.Point(459, 423)
        Me.btnLimpiarModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiarModelo.Name = "btnLimpiarModelo"
        Me.btnLimpiarModelo.Size = New System.Drawing.Size(68, 55)
        Me.btnLimpiarModelo.TabIndex = 39
        Me.btnLimpiarModelo.UseVisualStyleBackColor = True
        '
        'btnLimpiarMarca
        '
        Me.btnLimpiarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLimpiarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLimpiarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.limpiar
        Me.btnLimpiarMarca.Location = New System.Drawing.Point(7, 423)
        Me.btnLimpiarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiarMarca.Name = "btnLimpiarMarca"
        Me.btnLimpiarMarca.Size = New System.Drawing.Size(68, 55)
        Me.btnLimpiarMarca.TabIndex = 43
        Me.btnLimpiarMarca.UseVisualStyleBackColor = True
        '
        'btnBuscarMarca
        '
        Me.btnBuscarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.buscar
        Me.btnBuscarMarca.Location = New System.Drawing.Point(7, 360)
        Me.btnBuscarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarMarca.Name = "btnBuscarMarca"
        Me.btnBuscarMarca.Size = New System.Drawing.Size(68, 55)
        Me.btnBuscarMarca.TabIndex = 46
        Me.btnBuscarMarca.UseVisualStyleBackColor = True
        '
        'btnActualizarMarca
        '
        Me.btnActualizarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnActualizarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnActualizarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.copiar
        Me.btnActualizarMarca.Location = New System.Drawing.Point(7, 297)
        Me.btnActualizarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizarMarca.Name = "btnActualizarMarca"
        Me.btnActualizarMarca.Size = New System.Drawing.Size(68, 55)
        Me.btnActualizarMarca.TabIndex = 45
        Me.btnActualizarMarca.UseVisualStyleBackColor = True
        '
        'btnIngresarMarca
        '
        Me.btnIngresarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.editar1
        Me.btnIngresarMarca.Location = New System.Drawing.Point(7, 234)
        Me.btnIngresarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIngresarMarca.Name = "btnIngresarMarca"
        Me.btnIngresarMarca.Size = New System.Drawing.Size(68, 55)
        Me.btnIngresarMarca.TabIndex = 44
        Me.btnIngresarMarca.UseVisualStyleBackColor = True
        '
        'Marca_y_Modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 555)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Marca_y_Modelo"
        Me.Text = "Marca_y_Modelo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvModelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDMarcaModelo As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtIDModelo As TextBox
    Friend WithEvents dgvModelo As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtIDMarca As TextBox
    Friend WithEvents dgvMarca As DataGridView
    Friend WithEvents btnLimpiarModelo As Button
    Friend WithEvents btnBuscarModelo As Button
    Friend WithEvents btnEditarModelo As Button
    Friend WithEvents btnIngresarModelo As Button
    Friend WithEvents btnLimpiarMarca As Button
    Friend WithEvents btnBuscarMarca As Button
    Friend WithEvents btnActualizarMarca As Button
    Friend WithEvents btnIngresarMarca As Button
End Class
