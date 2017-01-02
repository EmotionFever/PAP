Public Class Menu
    Public Sub SelecionarBotao(ByVal numero As Integer)
        If numero >= 0 And numero < MenuCinematico.DIMLBL Then
            MenuCinematico.botao(numero).BackColor = Drawing.Color.Salmon
            MenuCinematico.botao(numero).Enabled = False
        End If
    End Sub
End Class
