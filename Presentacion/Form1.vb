Public Class Form1
    Public Property j As Jugadoras
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pAux As Jugadoras
        Me.j = New Jugadoras
        Try
            Me.j.LeerJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.j.JugDAO.Jugadoras
            Me.ListBox1().Items.Add(pAux.IdJugadora)
            Me.ListBox1().Items.Add(pAux.NombreJugadora)
            Me.ListBox1().Items.Add(pAux.PaisJugadora)

        Next
    End Sub
End Class