Public Class TenisForm
    Public Property j As Jugadoras

    Private Sub ButtonAnadirJugadora_Click(sender As Object, e As EventArgs) Handles ButtonAnadirJugadora.Click
        If Me.txtIdJugadora.Text <> String.Empty And Me.txtNombreJugadora.Text <> String.Empty And Me.txtFechaJugadora.Text <> String.Empty And Me.txtPaisJugadora.Text <> String.Empty Then
            j = New Jugadoras
            j.IdJugadora = txtIdJugadora.Text
            j.NombreJugadora = txtNombreJugadora.Text
            j.PuntosJugadora = 0
            j.FechaNacimientoJugadora = txtFechaJugadora.Text
            j.PaisJugadora = txtPaisJugadora.Text
            Try
                If j.InsertarJugadora() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstJugadoras.Items.Add(j.IdJugadora)
        End If
    End Sub
    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        Dim pAux As Jugadoras
        Me.j = New Jugadoras
        Try
            Me.j.LeerJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.j.JugDAO.Jugadoras
            Me.lstJugadoras.Items.Add(pAux.IdJugadora)
        Next
        Form1.Show()
    End Sub
End Class
