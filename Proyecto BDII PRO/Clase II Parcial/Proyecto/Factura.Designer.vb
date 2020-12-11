<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
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
        Me.DGListado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.txtnombreempleado = New System.Windows.Forms.TextBox()
        Me.Fec = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGListado
        '
        Me.DGListado.AllowUserToAddRows = False
        Me.DGListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListado.Location = New System.Drawing.Point(33, 149)
        Me.DGListado.Name = "DGListado"
        Me.DGListado.Size = New System.Drawing.Size(724, 259)
        Me.DGListado.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Compu Center"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clase_II_Parcial.My.Resources.Resources.LOGO_EMPRESA_FINAL1
        Me.PictureBox1.Location = New System.Drawing.Point(408, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(147, 50)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 22
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Location = New System.Drawing.Point(147, 90)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(100, 20)
        Me.txtnombrecliente.TabIndex = 23
        '
        'txtnombreempleado
        '
        Me.txtnombreempleado.Location = New System.Drawing.Point(555, 50)
        Me.txtnombreempleado.Name = "txtnombreempleado"
        Me.txtnombreempleado.Size = New System.Drawing.Size(100, 20)
        Me.txtnombreempleado.TabIndex = 24
        '
        'Fec
        '
        Me.Fec.AutoSize = True
        Me.Fec.Location = New System.Drawing.Point(39, 57)
        Me.Fec.Name = "Fec"
        Me.Fec.Size = New System.Drawing.Size(37, 13)
        Me.Fec.TabIndex = 25
        Me.Fec.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(460, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nombre Cajero"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(632, 443)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(542, 446)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Total a Pagar"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 495)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Fec)
        Me.Controls.Add(Me.txtnombreempleado)
        Me.Controls.Add(Me.txtnombrecliente)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGListado)
        Me.Name = "Factura"
        Me.Text = "Factura"
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGListado As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents txtnombreempleado As TextBox
    Friend WithEvents Fec As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label4 As Label
End Class
