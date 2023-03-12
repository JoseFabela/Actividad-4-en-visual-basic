Public MustInherit Class Animal
    Public MustOverride Sub HacerSonido()
End Class

Public Class Perro
    Inherits Animal
    Implements IMascota

    Public Overrides Sub HacerSonido()
        MessageBox.Show("Guau!")
    End Sub

    Public Sub Jugar() Implements IMascota.Jugar
        MessageBox.Show("Jugando con el perro")
    End Sub
End Class

Public Class Gato
    Inherits Animal
    Implements IMascota

    Public Overrides Sub HacerSonido()
        MessageBox.Show("Miau!")
    End Sub

    Public Sub Jugar() Implements IMascota.Jugar
        MessageBox.Show("Jugando con el gato")
    End Sub
End Class

Public Interface IMascota
    Sub Jugar()
End Interface


