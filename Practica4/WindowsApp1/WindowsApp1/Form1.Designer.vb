<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMinutos = New System.Windows.Forms.Label()
        Me.LabelSegundos = New System.Windows.Forms.Label()
        Me.LabelMiliSegundos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cronómetro"
        '
        'LabelMinutos
        '
        Me.LabelMinutos.AutoSize = True
        Me.LabelMinutos.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinutos.Location = New System.Drawing.Point(66, 91)
        Me.LabelMinutos.Name = "LabelMinutos"
        Me.LabelMinutos.Size = New System.Drawing.Size(57, 40)
        Me.LabelMinutos.TabIndex = 1
        Me.LabelMinutos.Text = "00"
        '
        'LabelSegundos
        '
        Me.LabelSegundos.AutoSize = True
        Me.LabelSegundos.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSegundos.Location = New System.Drawing.Point(129, 91)
        Me.LabelSegundos.Name = "LabelSegundos"
        Me.LabelSegundos.Size = New System.Drawing.Size(57, 40)
        Me.LabelSegundos.TabIndex = 2
        Me.LabelSegundos.Text = "00"
        '
        'LabelMiliSegundos
        '
        Me.LabelMiliSegundos.AutoSize = True
        Me.LabelMiliSegundos.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMiliSegundos.Location = New System.Drawing.Point(192, 91)
        Me.LabelMiliSegundos.Name = "LabelMiliSegundos"
        Me.LabelMiliSegundos.Size = New System.Drawing.Size(57, 40)
        Me.LabelMiliSegundos.TabIndex = 3
        Me.LabelMiliSegundos.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "minutos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "segundos"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(73, 180)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStart.TabIndex = 6
        Me.ButtonStart.Text = "Start/Stop"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(164, 180)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 7
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 450)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelMiliSegundos)
        Me.Controls.Add(Me.LabelSegundos)
        Me.Controls.Add(Me.LabelMinutos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMinutos As Label
    Friend WithEvents LabelSegundos As Label
    Friend WithEvents LabelMiliSegundos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents Timer1 As Timer
End Class
