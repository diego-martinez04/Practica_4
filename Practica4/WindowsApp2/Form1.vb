Public Class Form1
    Dim formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""

        ' Este es el formato 24h
        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        ' Time_mod(0) = "08"
        ' Time_mod(1) = "06"
        Hora.Text = Time_mod(0)
        Minutos.Text = Time_mod(1)
        Segundos.Text = Time_mod(2)
        Dias.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Configuracion.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            Hora.ForeColor = Color.White
            Minutos.ForeColor = Color.White
            Segundos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Dias.ForeColor = Color.White
            Fecha.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            Hora.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Segundos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Dias.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
        ElseIf color_texto = "Azul" Then
            Hora.ForeColor = Color.Blue
            Minutos.ForeColor = Color.Blue
            Segundos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Dias.ForeColor = Color.Blue
            Fecha.ForeColor = Color.Blue
        ElseIf color_texto = "Amarillo" Then
            Hora.ForeColor = Color.Yellow
            Minutos.ForeColor = Color.Yellow
            Segundos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Dias.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow
        ElseIf color_texto = "Verde" Then
            Hora.ForeColor = Color.Green
            Minutos.ForeColor = Color.Green
            Segundos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Dias.ForeColor = Color.Green
            Fecha.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            Start.Text = "Stop"
        ElseIf boton_start = True Then
            Timer3.Enabled = False
            boton_start = False
            Start.Text = "Start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        tiempo_crono = 0
        Timer3.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tiempo_crono = tiempo_crono + 1
        tiempo.text = tiempo_crono.ToString
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub
End Class
