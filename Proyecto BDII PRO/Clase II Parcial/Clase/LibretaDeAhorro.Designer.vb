<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibretaDeAhorro
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
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.lstDepositos = New System.Windows.Forms.ListBox()
        Me.btnApertura = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRetirar)
        Me.GroupBox1.Controls.Add(Me.btnDepositar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(87, 19)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 40)
        Me.btnRetirar.TabIndex = 1
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(6, 19)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(75, 40)
        Me.btnDepositar.TabIndex = 0
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMonto)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingreso de Informacion"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(110, 54)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(110, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de Usuario"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.txtSaldoTotal)
        Me.GroupBox3.Controls.Add(Me.lstRetiros)
        Me.GroupBox3.Controls.Add(Me.lstDepositos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 179)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Retiros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Depositos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo Total"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(264, 150)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtSaldoTotal
        '
        Me.txtSaldoTotal.Location = New System.Drawing.Point(258, 126)
        Me.txtSaldoTotal.Name = "txtSaldoTotal"
        Me.txtSaldoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoTotal.TabIndex = 2
        '
        'lstRetiros
        '
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.Location = New System.Drawing.Point(134, 39)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(120, 134)
        Me.lstRetiros.TabIndex = 1
        '
        'lstDepositos
        '
        Me.lstDepositos.FormattingEnabled = True
        Me.lstDepositos.Location = New System.Drawing.Point(6, 39)
        Me.lstDepositos.Name = "lstDepositos"
        Me.lstDepositos.Size = New System.Drawing.Size(120, 134)
        Me.lstDepositos.TabIndex = 0
        '
        'btnApertura
        '
        Me.btnApertura.Location = New System.Drawing.Point(202, 118)
        Me.btnApertura.Name = "btnApertura"
        Me.btnApertura.Size = New System.Drawing.Size(75, 38)
        Me.btnApertura.TabIndex = 2
        Me.btnApertura.Text = "Aperturar Cuenta"
        Me.btnApertura.UseVisualStyleBackColor = True
        '
        'LibretaDeAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 393)
        Me.Controls.Add(Me.btnApertura)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LibretaDeAhorro"
        Me.Text = "LibretaDeAhorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtSaldoTotal As TextBox
    Friend WithEvents lstRetiros As ListBox
    Friend WithEvents lstDepositos As ListBox
    Friend WithEvents btnApertura As Button
End Class
