Public Class MenuCinematico
    Public Const DIMLBL As Integer = 7
    Public botao(DIMLBL) As System.Windows.Forms.Button
    Dim contador As Integer = 1
    Dim abcissa, ordenada, comprimento, largura As Integer
    Private Sub MeuCinematico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'é preciso verificar sempre as localizações e o comprimento pois podem mudar
        abcissa = pctBotao.Location.X
        ordenada = pctBotao.Location.Y
        comprimento = pnl1.Size.Width
        largura = Me.Size.Height

        '"Apontar" os apontadores de label às labels do CTRL
        botao(0) = btnInicio
        botao(1) = btnEscolha2
        botao(2) = btnEscolha3
        botao(3) = btnEscolha4
        botao(4) = btnEscolha5
        botao(5) = btnEscolha6
        botao(6) = btnEscolha7
    End Sub

    Private Sub tmrAnimador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimador.Tick
        Dim variavel As Integer = Math.Round((2 / 5) * contador)
        If pctBotao.Tag Then 'Menu expandido, então tem-se que se escolhe-lo
            If pnl1.Size.Width > 49 Then 'Enquanto o comprimento for maior que 49


                comprimento -= variavel
                pnl1.Size = New System.Drawing.Size(comprimento, largura)

                abcissa -= variavel
                pctBotao.Location = New Drawing.Point(abcissa, ordenada)
                contador += 1

            Else 'Quando chega aos 49, tem o compriemnto ideal
                pctBotao.Tag = False
                pctLogo.Hide()
                pctEncolhido.Show()
                tmrAnimador.Stop()
                contador = 0
            End If
        Else 'Menu encolhido, então tem-se que se expandi-lo
            If pnl1.Size.Width < 260 Then

                pctLogo.Show()
                pctEncolhido.Hide()

                comprimento += variavel
                pnl1.Size = New System.Drawing.Size(comprimento, largura)

                abcissa += variavel
                pctBotao.Location = New Drawing.Point(abcissa, ordenada)

                contador += 1

            Else '250 é o comprimento ideal
                pctBotao.Tag = True
                tmrAnimador.Stop()
                contador = 0
            End If
        End If
        contador += 1
    End Sub

    Private Sub pctBotao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctBotao.Click
        tmrAnimador.Start()
    End Sub

    Public Sub SelecionarBotao(ByVal numero As Integer)
        If numero >= 0 And numero < DIMLBL Then
            botao(numero).BackColor = Drawing.Color.Salmon
            botao(numero).Enabled = False
        End If
    End Sub
End Class
