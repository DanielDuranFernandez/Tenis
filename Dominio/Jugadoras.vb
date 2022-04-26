Public Class Jugadoras
    Public Property IdJugadora As Integer
    Public Property NombreJugadora As String
    Public Property FechaNacimientoJugadora As Date
    Public Property PuntosJugadora As Integer
    Public Property PaisJugadora As String
    Public ReadOnly Property JugDAO As JugadorasDAO
    Public Sub New()
        Me.JugDAO = New JugadorasDAO
    End Sub

    Public Sub New(id As String)
        Me.JugDAO = New JugadorasDAO
        Me.IdJugadora = id
    End Sub
    Public Function InsertarJugadora() As Integer
        Return Me.JugDAO.Insertar(Me)
    End Function
    Public Function ActualizarPuntos() As Integer
        Return Me.JugDAO.Actualizar(Me)
    End Function
    Public Function LeerJugadoras()
        Me.JugDAO.LeerTodas()
    End Function
End Class
