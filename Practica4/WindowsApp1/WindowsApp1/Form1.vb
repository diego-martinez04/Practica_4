Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public Class Form1


        Dim minutos As Integer = 0
        Dim segundos As Integer = 0
        Dim milisegundos As Integer = 0
        Dim corriendo As Boolean = False

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


            LabelMinutos.Text = minutos.ToString("00")
            LabelSegundos.Text = segundos.ToString("00")
            LabelMiliSegundos.Text = milisegundos.ToString("00")
        End Sub

        Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If corriendo = False Then
            Timer1.Start()
            corriendo = True
            ButtonStart.Text = "Stop"
        Else
            Timer1.Stop()
            corriendo = False
            ButtonStart.Text = "Start"
        End If
    End Sub
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Timer1.Stop()
        corriendo = False

        minutos = 0
        segundos = 0
        milisegundos = 0

        LabelMinutos.Text = "00"
        LabelSegundos.Text = "00"
        LabelMiliSegundos.Text = "00"

        ButtonStart.Text = "Start"
    End Sub

End Class
End Sub