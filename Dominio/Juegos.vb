Public Class Juegos
    Public Function CalcularJuego() As Integer
        Dim intAleatorio As Integer
        intAleatorio = Int((2 - 1 + 1) * Rnd() + 1)
        Return intAleatorio
    End Function
End Class
