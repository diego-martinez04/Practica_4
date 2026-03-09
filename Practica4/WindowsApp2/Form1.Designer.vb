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
        Me.components = New System.ComponentModel.Container()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.Location = New System.Drawing.Point(35, 48)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(104, 73)
        Me.Hora.TabIndex = 0
        Me.Hora.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 73)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.Location = New System.Drawing.Point(174, 48)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(104, 73)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dias.Location = New System.Drawing.Point(39, 155)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(121, 42)
        Me.Dias.TabIndex = 3
        Me.Dias.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(42, 223)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(296, 33)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "09 de marzo del 2026"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 323)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Hora)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hora As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Dias As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
End Class
