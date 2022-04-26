Public Class Partidos
    Public Property SetsJugados As Integer
    Public Property intAleatorio As Integer
    Public Property j As Juegos
    Public ReadOnly Property ParDAO As PartidosDAO
    Public Sub New()
        Me.ParDAO = New PartidosDAO
    End Sub
    Sub CalcularJuegos()
        intAleatorio = j.CalcularJuego
    End Sub

    Sub calcularSet()
        Dim juegosJugador1 As Integer
        juegosJugador1 = 0
        Dim juegosJugador2 As Integer
        juegosJugador2 = 0
        Dim setJugador1 As Integer
        setJugador1 = 0
        Dim setJugador2 As Integer
        setJugador2 = 0
        Dim xet As Integer
        xet = 2
        Dim finPartido As Boolean
        finPartido = False

        While (Not finPartido)
            CalcularJuegos()
            If (intAleatorio = 1) Then
                juegosJugador1 += 1
            Else
                juegosJugador2 += 2
            End If

            If (juegosJugador1 = 6 & juegosJugador1 = 6) Then
                'tie break
            End If

            If (juegosJugador1 >= 6 & Math.Abs(juegosJugador1 - juegosJugador2) > 1 Or juegosJugador1 = 7 & juegosJugador2 = 6) Then
                setJugador1 += 1
                'Jugador1 gana a Jugador 2
                juegosJugador1 = 0
                juegosJugador2 = 0
                If (setJugador1 = xet & setJugador1 > setJugador2) Then
                    'Jugador 1 gana el partido
                    finPartido = True
                End If
            End If

            If (juegosJugador2 >= 6 & Math.Abs(juegosJugador2 - juegosJugador1) > 1 Or juegosJugador2 = 7 & juegosJugador1 = 6) Then
                setJugador2 += 1
                'Jugador2 gana a Jugador 1
                juegosJugador1 = 0
                juegosJugador2 = 0
                If (setJugador2 = xet & setJugador2 > setJugador1) Then
                    'Jugador 2 gana el partido
                    finPartido = True
                End If
            End If
        End While
    End Sub
End Class
