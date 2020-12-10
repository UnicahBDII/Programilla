<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelefonosEmpleados
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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtTipoPaquete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dgvTelefonosEmpleados = New System.Windows.Forms.DataGridView()
        Me.dgvMarca = New System.Windows.Forms.DataGridView()
        Me.dgvTipoPaquete = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTelefonosEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTipoPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.Image = Global.Clase_II_Parcial.My.Resources.Resources.editar1
        Me.btnIngresar.Location = New System.Drawing.Point(387, 63)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(68, 55)
        Me.btnIngresar.TabIndex = 37
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEditar.Image = Global.Clase_II_Parcial.My.Resources.Resources.copiar
        Me.btnEditar.Location = New System.Drawing.Point(387, 126)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(68, 55)
        Me.btnEditar.TabIndex = 38
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(182, 107)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(97, 22)
        Me.txtTelefono.TabIndex = 39
        '
        'txtTipoPaquete
        '
        Me.txtTipoPaquete.Location = New System.Drawing.Point(182, 170)
        Me.txtTipoPaquete.Name = "txtTipoPaquete"
        Me.txtTipoPaquete.Size = New System.Drawing.Size(97, 22)
        Me.txtTipoPaquete.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Paquete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(182, 45)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(97, 22)
        Me.txtID.TabIndex = 43
        '
        'dgvTelefonosEmpleados
        '
        Me.dgvTelefonosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonosEmpleados.Location = New System.Drawing.Point(530, 31)
        Me.dgvTelefonosEmpleados.Name = "dgvTelefonosEmpleados"
        Me.dgvTelefonosEmpleados.RowHeadersWidth = 51
        Me.dgvTelefonosEmpleados.RowTemplate.Height = 24
        Me.dgvTelefonosEmpleados.Size = New System.Drawing.Size(383, 150)
        Me.dgvTelefonosEmpleados.TabIndex = 45
        '
        'dgvMarca
        '
        Me.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMarca.Location = New System.Drawing.Point(530, 272)
        Me.dgvMarca.Name = "dgvMarca"
        Me.dgvMarca.RowHeadersWidth = 51
        Me.dgvMarca.RowTemplate.Height = 24
        Me.dgvMarca.Size = New System.Drawing.Size(383, 150)
        Me.dgvMarca.TabIndex = 46
        '
        'dgvTipoPaquete
        '
        Me.dgvTipoPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoPaquete.Location = New System.Drawing.Point(72, 272)
        Me.dgvTipoPaquete.Name = "dgvTipoPaquete"
        Me.dgvTipoPaquete.RowHeadersWidth = 51
        Me.dgvTipoPaquete.RowTemplate.Height = 24
        Me.dgvTipoPaquete.Size = New System.Drawing.Size(383, 150)
        Me.dgvTipoPaquete.TabIndex = 47
        '
        'TelefonosEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 454)
        Me.Controls.Add(Me.dgvTipoPaquete)
        Me.Controls.Add(Me.dgvMarca)
        Me.Controls.Add(Me.dgvTelefonosEmpleados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTipoPaquete)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIngresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TelefonosEmpleados"
        Me.Text = "TelefonosEmpleados"
        CType(Me.dgvTelefonosEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTipoPaquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtTipoPaquete As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents dgvTelefonosEmpleados As DataGridView
    Friend WithEvents dgvMarca As DataGridView
    Friend WithEvents dgvTipoPaquete As DataGridView
End Class
