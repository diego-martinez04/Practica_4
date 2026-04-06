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
        Me.lblminutos = New System.Windows.Forms.Label()
        Me.lblsegundos = New System.Windows.Forms.Label()
        Me.lblmilisegundos = New System.Windows.Forms.Label()
        Me.BtnStartStop = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cronómetro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Temporizador = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSegTemp = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.btnStopTemp = New System.Windows.Forms.Button()
        Me.BtnResetTemp = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btn5min = New System.Windows.Forms.Button()
        Me.btn1min = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblminutos
        '
        Me.lblminutos.AutoSize = True
        Me.lblminutos.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminutos.Location = New System.Drawing.Point(49, 105)
        Me.lblminutos.Name = "lblminutos"
        Me.lblminutos.Size = New System.Drawing.Size(72, 51)
        Me.lblminutos.TabIndex = 0
        Me.lblminutos.Text = "00"
        '
        'lblsegundos
        '
        Me.lblsegundos.AutoSize = True
        Me.lblsegundos.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsegundos.Location = New System.Drawing.Point(143, 105)
        Me.lblsegundos.Name = "lblsegundos"
        Me.lblsegundos.Size = New System.Drawing.Size(72, 51)
        Me.lblsegundos.TabIndex = 1
        Me.lblsegundos.Text = "00"
        '
        'lblmilisegundos
        '
        Me.lblmilisegundos.AutoSize = True
        Me.lblmilisegundos.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmilisegundos.Location = New System.Drawing.Point(241, 105)
        Me.lblmilisegundos.Name = "lblmilisegundos"
        Me.lblmilisegundos.Size = New System.Drawing.Size(72, 51)
        Me.lblmilisegundos.TabIndex = 2
        Me.lblmilisegundos.Text = "00"
        '
        'BtnStartStop
        '
        Me.BtnStartStop.Location = New System.Drawing.Point(88, 195)
        Me.BtnStartStop.Name = "BtnStartStop"
        Me.BtnStartStop.Size = New System.Drawing.Size(88, 43)
        Me.BtnStartStop.TabIndex = 3
        Me.BtnStartStop.Text = "Start"
        Me.BtnStartStop.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(190, 195)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(82, 43)
        Me.BtnReset.TabIndex = 4
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Cronómetro
        '
        Me.Cronómetro.AutoSize = True
        Me.Cronómetro.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cronómetro.Location = New System.Drawing.Point(81, 43)
        Me.Cronómetro.Name = "Cronómetro"
        Me.Cronómetro.Size = New System.Drawing.Size(184, 38)
        Me.Cronómetro.TabIndex = 5
        Me.Cronómetro.Text = "Cronómetro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = ":"
        '
        'Temporizador
        '
        Me.Temporizador.AutoSize = True
        Me.Temporizador.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temporizador.Location = New System.Drawing.Point(81, 305)
        Me.Temporizador.Name = "Temporizador"
        Me.Temporizador.Size = New System.Drawing.Size(211, 38)
        Me.Temporizador.TabIndex = 7
        Me.Temporizador.Text = "Temporizador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 33)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = ":"
        '
        'lblSegTemp
        '
        Me.lblSegTemp.AutoSize = True
        Me.lblSegTemp.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegTemp.Location = New System.Drawing.Point(143, 367)
        Me.lblSegTemp.Name = "lblSegTemp"
        Me.lblSegTemp.Size = New System.Drawing.Size(72, 51)
        Me.lblSegTemp.TabIndex = 9
        Me.lblSegTemp.Text = "00"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinTemp.Location = New System.Drawing.Point(49, 367)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(72, 51)
        Me.lblMinTemp.TabIndex = 8
        Me.lblMinTemp.Text = "00"
        '
        'btnStopTemp
        '
        Me.btnStopTemp.Location = New System.Drawing.Point(46, 449)
        Me.btnStopTemp.Name = "btnStopTemp"
        Me.btnStopTemp.Size = New System.Drawing.Size(75, 23)
        Me.btnStopTemp.TabIndex = 13
        Me.btnStopTemp.Text = "Stop"
        Me.btnStopTemp.UseVisualStyleBackColor = True
        '
        'BtnResetTemp
        '
        Me.BtnResetTemp.Location = New System.Drawing.Point(140, 449)
        Me.BtnResetTemp.Name = "BtnResetTemp"
        Me.BtnResetTemp.Size = New System.Drawing.Size(75, 23)
        Me.BtnResetTemp.TabIndex = 14
        Me.BtnResetTemp.Text = "Reset"
        Me.BtnResetTemp.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'btn5min
        '
        Me.btn5min.Location = New System.Drawing.Point(238, 367)
        Me.btn5min.Name = "btn5min"
        Me.btn5min.Size = New System.Drawing.Size(75, 23)
        Me.btn5min.TabIndex = 15
        Me.btn5min.Text = "5 min"
        Me.btn5min.UseVisualStyleBackColor = True
        '
        'btn1min
        '
        Me.btn1min.Location = New System.Drawing.Point(238, 396)
        Me.btn1min.Name = "btn1min"
        Me.btn1min.Size = New System.Drawing.Size(75, 23)
        Me.btn1min.TabIndex = 16
        Me.btn1min.Text = "1 min"
        Me.btn1min.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 582)
        Me.Controls.Add(Me.btn1min)
        Me.Controls.Add(Me.btn5min)
        Me.Controls.Add(Me.BtnResetTemp)
        Me.Controls.Add(Me.btnStopTemp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSegTemp)
        Me.Controls.Add(Me.lblMinTemp)
        Me.Controls.Add(Me.Temporizador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cronómetro)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnStartStop)
        Me.Controls.Add(Me.lblmilisegundos)
        Me.Controls.Add(Me.lblsegundos)
        Me.Controls.Add(Me.lblminutos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblminutos As Label
    Friend WithEvents lblsegundos As Label
    Friend WithEvents lblmilisegundos As Label
    Friend WithEvents BtnStartStop As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Cronómetro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Temporizador As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSegTemp As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents btnStopTemp As Button
    Friend WithEvents BtnResetTemp As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btn5min As Button
    Friend WithEvents btn1min As Button
End Class
