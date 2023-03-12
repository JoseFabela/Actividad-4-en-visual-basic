Public Class Form1
    Private perro As Perro
    Private gato As Gato

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        perro = New Perro()
        gato = New Gato()
    End Sub

    Private Sub btnPerro_Click(sender As Object, e As EventArgs) Handles btnPerro.Click
        lblResultado.Text = ""
        Perro.HacerSonido()
        lblResultado.Text = "El perro hace un sonido de 'Guau!'" & vbCrLf

        Dim mascota As IMascota = Perro
        mascota.Jugar()
        lblResultado.Text += "Jugando con el perro"
    End Sub

    Private Sub btnGato_Click(sender As Object, e As EventArgs) Handles btnGato.Click
        lblResultado.Text = ""
        Gato.HacerSonido()
        lblResultado.Text = "El gato hace un sonido de 'Miau!'" & vbCrLf

        Dim mascota As IMascota = Gato
        mascota.Jugar()
        lblResultado.Text += "Jugando con el gato"
    End Sub
End Class

