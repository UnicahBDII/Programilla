<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Informacion
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnCanjear = New System.Windows.Forms.Button()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnRegresar)
        Me.GroupBox1.Controls.Add(Me.btnCanjear)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.txtBarrio)
        Me.GroupBox1.Controls.Add(Me.txtDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtSexo)
        Me.GroupBox1.Controls.Add(Me.txtPuesto)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 377)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion De Empleado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 21)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Barrio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Municipio"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(187, 311)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 43)
        Me.btnRegresar.TabIndex = 17
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnCanjear
        '
        Me.btnCanjear.Location = New System.Drawing.Point(106, 311)
        Me.btnCanjear.Name = "btnCanjear"
        Me.btnCanjear.Size = New System.Drawing.Size(75, 43)
        Me.btnCanjear.TabIndex = 16
        Me.btnCanjear.Text = "CAnjear"
        Me.btnCanjear.UseVisualStyleBackColor = True
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(106, 141)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(156, 28)
        Me.txtMunicipio.TabIndex = 15
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(106, 175)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(242, 28)
        Me.txtBarrio.TabIndex = 14
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(106, 107)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(156, 28)
        Me.txtDepartamento.TabIndex = 13
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(106, 209)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(56, 28)
        Me.txtEdad.TabIndex = 12
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(106, 243)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(56, 28)
        Me.txtSexo.TabIndex = 11
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(106, 277)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(156, 28)
        Me.txtPuesto.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(265, 28)
        Me.txtNombre.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "puesto "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identidad"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(106, 39)
        Me.txtIdentidad.Mask = "0000-0000-00000"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(156, 28)
        Me.txtIdentidad.TabIndex = 0
        '
        'Informacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(411, 405)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Informacion"
        Me.Text = "Informacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdentidad As MaskedTextBox
    Friend WithEvents btnCanjear As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
