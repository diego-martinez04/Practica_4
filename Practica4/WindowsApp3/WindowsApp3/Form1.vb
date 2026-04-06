Public Class Form1
    Dim minutos As Integer = 0
    Dim segundos As Integer = 0
    Dim milisegundos As Integer = 0
    Dim corriendo As Boolean = False
    Dim minTemp As Integer = 0
    Dim segTemp As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        milisegundos += 1

        If milisegundos = 100 Then
            milisegundos = 0
            segundos += 1
        End If

        If segundos = 60 Then
            segundos = 0
            minutos += 1
        End If

        lblminutos.Text = minutos.ToString("00")
        lblsegundos.Text = segundos.ToString("00")
        lblmilisegundos.Text = milisegundos.ToString("00")

    End Sub

    Private Sub BtnStartStop_Click(sender As Object, e As EventArgs) Handles BtnStartStop.Click
        If corriendo = False Then
            Timer1.Start()
            corriendo = True
            BtnStartStop.Text = "Stop"
        Else
            Timer1.Stop()
            corriendo = False
            BtnStartStop.Text = "Start"
        End If

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Timer1.Stop()
        corriendo = False

        minutos = 0
        segundos = 0
        milisegundos = 0

        lblminutos.Text = "00"
        lblsegundos.Text = "00"
        lblmilisegundos.Text = "00"

        BtnStartStop.Text = "Start"
    End Sub

    'Cronometro -------------

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If segTemp = 0 Then
            If minTemp = 0 Then
                Timer2.Stop()
                Exit Sub
            Else
                minTemp -= 1
                segTemp = 59
            End If
        Else
            segTemp -= 1
        End If

        lblMinTemp.Text = minTemp.ToString("00")
        lblSegTemp.Text = segTemp.ToString("00")

    End Sub

    Private Sub btn5min_Click(sender As Object, e As EventArgs) Handles btn5min.Click
        minTemp = 5
        segTemp = 0

        lblMinTemp.Text = "05"
        lblSegTemp.Text = "00"

        Timer2.Start()
    End Sub

    Private Sub btn1min_Click(sender As Object, e As EventArgs) Handles btn1min.Click
        minTemp = 1
        segTemp = 0

        lblMinTemp.Text = "01"
        lblSegTemp.Text = "00"

        Timer2.Start()
    End Sub


    Private Sub btnStopTemp_Click(sender As Object, e As EventArgs) Handles btnStopTemp.Click
        Timer2.Stop()
    End Sub

    Private Sub BtnResetTemp_Click(sender As Object, e As EventArgs) Handles BtnResetTemp.Click
        Timer2.Stop()

        minTemp = 0
        segTemp = 0

        lblMinTemp.Text = "00"
        lblSegTemp.Text = "00"

        'GGs Ez Profe

    End Sub
End Class
