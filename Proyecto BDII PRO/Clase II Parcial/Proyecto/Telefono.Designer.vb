<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Telefono
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrueba = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGtelefono = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGtelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEntregar)
        Me.GroupBox1.Controls.Add(Me.txtPuesto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPrueba)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identidad Solicitada"
        '
        'btnEntregar
        '
        Me.btnEntregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEntregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregar.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregar.Location = New System.Drawing.Point(39, 217)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(157, 58)
        Me.btnEntregar.TabIndex = 4
        Me.btnEntregar.Text = "Asignar Telefono  Celular"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'txtPuesto
        '
        Me.txtPuesto.Enabled = False
        Me.txtPuesto.Location = New System.Drawing.Point(75, 135)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(100, 28)
        Me.txtPuesto.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "ID puesto"
        '
        'txtPrueba
        '
        Me.txtPrueba.Enabled = False
        Me.txtPrueba.Location = New System.Drawing.Point(75, 169)
        Me.txtPrueba.Name = "txtPrueba"
        Me.txtPrueba.Size = New System.Drawing.Size(121, 28)
        Me.txtPrueba.TabIndex = 47
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Enabled = False
        Me.txtIdentidad.Location = New System.Drawing.Point(75, 70)
        Me.txtIdentidad.Mask = "9999-9999-99999"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(100, 28)
        Me.txtIdentidad.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Puesto"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(75, 101)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(157, 28)
        Me.txtNombre.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nombre"
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Location = New System.Drawing.Point(15, 77)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(62, 21)
        Me.txtId.TabIndex = 44
        Me.txtId.Text = "Identidad"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(75, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 28)
        Me.txtCodigo.TabIndex = 40
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_II_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(181, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(51, 45)
        Me.btnBuscar.TabIndex = 39
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGtelefono)
        Me.GroupBox2.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(284, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 238)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de Ingreso"
        '
        'DGtelefono
        '
        Me.DGtelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGtelefono.Location = New System.Drawing.Point(16, 27)
        Me.DGtelefono.Name = "DGtelefono"
        Me.DGtelefono.Size = New System.Drawing.Size(540, 191)
        Me.DGtelefono.TabIndex = 3
        '
        'Telefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(875, 323)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Telefono"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGtelefono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGtelefono As DataGridView
    Friend WithEvents btnEntregar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrueba As TextBox
    Friend WithEvents txtIdentidad As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As Label
End Class
