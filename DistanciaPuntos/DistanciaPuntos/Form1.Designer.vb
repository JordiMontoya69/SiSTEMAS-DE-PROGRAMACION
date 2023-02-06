<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Lbl_y = New System.Windows.Forms.Label()
        Me.tbY2 = New System.Windows.Forms.TextBox()
        Me.Lbl_x = New System.Windows.Forms.Label()
        Me.tbX2 = New System.Windows.Forms.TextBox()
        Me.tbY1 = New System.Windows.Forms.TextBox()
        Me.tbResultado = New System.Windows.Forms.TextBox()
        Me.tbX1 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Lbl_Punto2 = New System.Windows.Forms.Label()
        Me.Lbl_Punto1 = New System.Windows.Forms.Label()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbZ2 = New System.Windows.Forms.TextBox()
        Me.tbZ1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_y
        '
        Me.Lbl_y.AutoSize = True
        Me.Lbl_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Lbl_y.Location = New System.Drawing.Point(241, 52)
        Me.Lbl_y.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_y.Name = "Lbl_y"
        Me.Lbl_y.Size = New System.Drawing.Size(15, 13)
        Me.Lbl_y.TabIndex = 34
        Me.Lbl_y.Text = "Y"
        '
        'tbY2
        '
        Me.tbY2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbY2.Location = New System.Drawing.Point(219, 118)
        Me.tbY2.Name = "tbY2"
        Me.tbY2.Size = New System.Drawing.Size(71, 20)
        Me.tbY2.TabIndex = 33
        '
        'Lbl_x
        '
        Me.Lbl_x.AutoSize = True
        Me.Lbl_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_x.Location = New System.Drawing.Point(145, 52)
        Me.Lbl_x.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_x.Name = "Lbl_x"
        Me.Lbl_x.Size = New System.Drawing.Size(15, 13)
        Me.Lbl_x.TabIndex = 32
        Me.Lbl_x.Text = "X"
        '
        'tbX2
        '
        Me.tbX2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbX2.Location = New System.Drawing.Point(119, 118)
        Me.tbX2.Name = "tbX2"
        Me.tbX2.Size = New System.Drawing.Size(71, 20)
        Me.tbX2.TabIndex = 31
        '
        'tbY1
        '
        Me.tbY1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbY1.Location = New System.Drawing.Point(219, 70)
        Me.tbY1.Name = "tbY1"
        Me.tbY1.Size = New System.Drawing.Size(71, 20)
        Me.tbY1.TabIndex = 30
        '
        'tbResultado
        '
        Me.tbResultado.Enabled = False
        Me.tbResultado.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResultado.Location = New System.Drawing.Point(184, 188)
        Me.tbResultado.Name = "tbResultado"
        Me.tbResultado.Size = New System.Drawing.Size(71, 20)
        Me.tbResultado.TabIndex = 29
        '
        'tbX1
        '
        Me.tbX1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbX1.Location = New System.Drawing.Point(119, 70)
        Me.tbX1.Name = "tbX1"
        Me.tbX1.Size = New System.Drawing.Size(71, 20)
        Me.tbX1.TabIndex = 28
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(284, 188)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(71, 27)
        Me.btnCalcular.TabIndex = 27
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Resultado.Location = New System.Drawing.Point(104, 191)
        Me.Lbl_Resultado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_Resultado.TabIndex = 26
        Me.Lbl_Resultado.Text = "Resultado:"
        '
        'Lbl_Punto2
        '
        Me.Lbl_Punto2.AutoSize = True
        Me.Lbl_Punto2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Punto2.Location = New System.Drawing.Point(39, 120)
        Me.Lbl_Punto2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Punto2.Name = "Lbl_Punto2"
        Me.Lbl_Punto2.Size = New System.Drawing.Size(60, 13)
        Me.Lbl_Punto2.TabIndex = 25
        Me.Lbl_Punto2.Text = "Punto 2:"
        '
        'Lbl_Punto1
        '
        Me.Lbl_Punto1.AutoSize = True
        Me.Lbl_Punto1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Punto1.Location = New System.Drawing.Point(39, 71)
        Me.Lbl_Punto1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Punto1.Name = "Lbl_Punto1"
        Me.Lbl_Punto1.Size = New System.Drawing.Size(60, 13)
        Me.Lbl_Punto1.TabIndex = 24
        Me.Lbl_Punto1.Text = "Punto 1:"
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(100, 0)
        Me.Lbl_Titulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(225, 17)
        Me.Lbl_Titulo.TabIndex = 23
        Me.Lbl_Titulo.Text = "DISTANCIA ENTRE PUNTOS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 17)
        Me.Panel1.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Location = New System.Drawing.Point(329, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(85, 16)
        Me.Panel2.TabIndex = 39
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel3.Location = New System.Drawing.Point(1, 253)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 16)
        Me.Panel3.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(340, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Z"
        '
        'tbZ2
        '
        Me.tbZ2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbZ2.Location = New System.Drawing.Point(318, 119)
        Me.tbZ2.Name = "tbZ2"
        Me.tbZ2.Size = New System.Drawing.Size(71, 20)
        Me.tbZ2.TabIndex = 41
        '
        'tbZ1
        '
        Me.tbZ1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbZ1.Location = New System.Drawing.Point(318, 71)
        Me.tbZ1.Name = "tbZ1"
        Me.tbZ1.Size = New System.Drawing.Size(71, 20)
        Me.tbZ1.TabIndex = 40
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 264)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbZ2)
        Me.Controls.Add(Me.tbZ1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_y)
        Me.Controls.Add(Me.tbY2)
        Me.Controls.Add(Me.Lbl_x)
        Me.Controls.Add(Me.tbX2)
        Me.Controls.Add(Me.tbY1)
        Me.Controls.Add(Me.tbResultado)
        Me.Controls.Add(Me.tbX1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Lbl_Punto2)
        Me.Controls.Add(Me.Lbl_Punto1)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_y As Label
    Friend WithEvents tbY2 As TextBox
    Friend WithEvents Lbl_x As Label
    Friend WithEvents tbX2 As TextBox
    Friend WithEvents tbY1 As TextBox
    Friend WithEvents tbResultado As TextBox
    Friend WithEvents tbX1 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Lbl_Punto2 As Label
    Friend WithEvents Lbl_Punto1 As Label
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents tbZ2 As TextBox
    Friend WithEvents tbZ1 As TextBox
End Class
