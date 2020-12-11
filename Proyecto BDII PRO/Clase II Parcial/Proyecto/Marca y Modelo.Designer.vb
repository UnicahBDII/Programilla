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
        Me.btnLimpiarModelo = New System.Windows.Forms.Button()
        Me.btnBuscarModelo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEditarModelo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIngresarModelo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDMarcaModelo = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtIDModelo = New System.Windows.Forms.TextBox()
        Me.dgvModelo = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarMarca = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarMarca = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnActualizarMarca = New System.Windows.Forms.Button()
        Me.btnIngresarMarca = New System.Windows.Forms.Button()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtIDMarca = New System.Windows.Forms.TextBox()
        Me.dgvMarca = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMarca, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(417, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(412, 430)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modelo"
        '
        'btnLimpiarModelo
        '
        Me.btnLimpiarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLimpiarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLimpiarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.limpiar
        Me.btnLimpiarModelo.Location = New System.Drawing.Point(344, 344)
        Me.btnLimpiarModelo.Name = "btnLimpiarModelo"
        Me.btnLimpiarModelo.Size = New System.Drawing.Size(51, 45)
        Me.btnLimpiarModelo.TabIndex = 39
        Me.btnLimpiarModelo.UseVisualStyleBackColor = True
        '
        'btnBuscarModelo
        '
        Me.btnBuscarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.buscar
        Me.btnBuscarModelo.Location = New System.Drawing.Point(344, 292)
        Me.btnBuscarModelo.Name = "btnBuscarModelo"
        Me.btnBuscarModelo.Size = New System.Drawing.Size(51, 45)
        Me.btnBuscarModelo.TabIndex = 42
        Me.btnBuscarModelo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID Marca"
        '
        'btnEditarModelo
        '
        Me.btnEditarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.copiar
        Me.btnEditarModelo.Location = New System.Drawing.Point(344, 241)
        Me.btnEditarModelo.Name = "btnEditarModelo"
        Me.btnEditarModelo.Size = New System.Drawing.Size(51, 45)
        Me.btnEditarModelo.TabIndex = 41
        Me.btnEditarModelo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Modelo"
        '
        'btnIngresarModelo
        '
        Me.btnIngresarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresarModelo.Image = Global.Clase_II_Parcial.My.Resources.Resources.editar1
        Me.btnIngresarModelo.Location = New System.Drawing.Point(344, 190)
        Me.btnIngresarModelo.Name = "btnIngresarModelo"
        Me.btnIngresarModelo.Size = New System.Drawing.Size(51, 45)
        Me.btnIngresarModelo.TabIndex = 40
        Me.btnIngresarModelo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'txtIDMarcaModelo
        '
        Me.txtIDMarcaModelo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDMarcaModelo.Location = New System.Drawing.Point(164, 115)
        Me.txtIDMarcaModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDMarcaModelo.Name = "txtIDMarcaModelo"
        Me.txtIDMarcaModelo.Size = New System.Drawing.Size(120, 26)
        Me.txtIDMarcaModelo.TabIndex = 4
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(164, 76)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(120, 26)
        Me.txtModelo.TabIndex = 3
        '
        'txtIDModelo
        '
        Me.txtIDModelo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDModelo.Location = New System.Drawing.Point(164, 39)
        Me.txtIDModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDModelo.Name = "txtIDModelo"
        Me.txtIDModelo.Size = New System.Drawing.Size(120, 26)
        Me.txtIDModelo.TabIndex = 2
        '
        'dgvModelo
        '
        Me.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModelo.Location = New System.Drawing.Point(29, 190)
        Me.dgvModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvModelo.Name = "dgvModelo"
        Me.dgvModelo.RowHeadersWidth = 51
        Me.dgvModelo.RowTemplate.Height = 24
        Me.dgvModelo.Size = New System.Drawing.Size(302, 203)
        Me.dgvModelo.TabIndex = 1
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
        Me.GroupBox2.Font = New System.Drawing.Font("Fugaz One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(26, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(361, 430)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marca"
        '
        'btnLimpiarMarca
        '
        Me.btnLimpiarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnLimpiarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnLimpiarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.limpiar
        Me.btnLimpiarMarca.Location = New System.Drawing.Point(5, 344)
        Me.btnLimpiarMarca.Name = "btnLimpiarMarca"
        Me.btnLimpiarMarca.Size = New System.Drawing.Size(51, 45)
        Me.btnLimpiarMarca.TabIndex = 43
        Me.btnLimpiarMarca.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Marca"
        '
        'btnBuscarMarca
        '
        Me.btnBuscarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.buscar
        Me.btnBuscarMarca.Location = New System.Drawing.Point(5, 292)
        Me.btnBuscarMarca.Name = "btnBuscarMarca"
        Me.btnBuscarMarca.Size = New System.Drawing.Size(51, 45)
        Me.btnBuscarMarca.TabIndex = 46
        Me.btnBuscarMarca.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID"
        '
        'btnActualizarMarca
        '
        Me.btnActualizarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnActualizarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnActualizarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.copiar
        Me.btnActualizarMarca.Location = New System.Drawing.Point(5, 241)
        Me.btnActualizarMarca.Name = "btnActualizarMarca"
        Me.btnActualizarMarca.Size = New System.Drawing.Size(51, 45)
        Me.btnActualizarMarca.TabIndex = 45
        Me.btnActualizarMarca.UseVisualStyleBackColor = True
        '
        'btnIngresarMarca
        '
        Me.btnIngresarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresarMarca.Image = Global.Clase_II_Parcial.My.Resources.Resources.editar1
        Me.btnIngresarMarca.Location = New System.Drawing.Point(5, 190)
        Me.btnIngresarMarca.Name = "btnIngresarMarca"
        Me.btnIngresarMarca.Size = New System.Drawing.Size(51, 45)
        Me.btnIngresarMarca.TabIndex = 44
        Me.btnIngresarMarca.UseVisualStyleBackColor = True
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(146, 112)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(120, 26)
        Me.txtMarca.TabIndex = 5
        '
        'txtIDMarca
        '
        Me.txtIDMarca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDMarca.Location = New System.Drawing.Point(146, 74)
        Me.txtIDMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDMarca.Name = "txtIDMarca"
        Me.txtIDMarca.Size = New System.Drawing.Size(120, 26)
        Me.txtIDMarca.TabIndex = 4
        '
        'dgvMarca
        '
        Me.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarca.Location = New System.Drawing.Point(67, 190)
        Me.dgvMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMarca.Name = "dgvMarca"
        Me.dgvMarca.RowHeadersWidth = 51
        Me.dgvMarca.RowTemplate.Height = 24
        Me.dgvMarca.Size = New System.Drawing.Size(269, 203)
        Me.dgvMarca.TabIndex = 0
        '
        'Marca_y_Modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 451)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Marca_y_Modelo"
        Me.Text = "Marca_y_Modelo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvModelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvMarca, System.ComponentModel.ISupportInitialize).EndInit()
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
