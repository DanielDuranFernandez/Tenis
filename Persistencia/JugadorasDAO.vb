Public Class JugadorasDAO
    Public ReadOnly Property Jugadoras As Collection
    Public Sub New()
        Me.Jugadoras = New Collection
    End Sub
    Public Sub LeerTodas()
        Dim j As Jugadoras
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY IdJugadora")
        For Each aux In col
            j = New Jugadoras(aux(1).ToString)
            j.NombreJugadora = aux(2).ToString
            j.FechaNacimientoJugadora = aux(3).ToString
            j.PuntosJugadora = aux(4).ToString
            j.PaisJugadora = aux(5).ToString
            Me.Jugadoras.Add(j)
        Next
    End Sub
    Public Function Insertar(ByVal j As Jugadoras) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras VALUES ('" & j.IdJugadora & "', '" & j.NombreJugadora & "', '" & j.FechaNacimientoJugadora & "', '" & j.PuntosJugadora & "', '" & j.PaisJugadora & "');")
    End Function
    Public Function Actualizar(ByVal j As Jugadoras) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET PuntosJugadora='" & j.PuntosJugadora & "' WHERE IdJugadora='" & j.IdJugadora & "';")
    End Function
End Class
