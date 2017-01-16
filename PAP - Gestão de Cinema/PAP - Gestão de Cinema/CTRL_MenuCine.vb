Public Class CTRL_MenuCine
    Dim contador As Integer = 0
    Public Const DIMLBL As Integer = 9
    Public botao(DIMLBL) As System.Windows.Forms.Button

    Private Sub CTRL_MenuCine_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '"Apontar" os apontadores de botões aos botãoes do CTRL / Códigos do procedimento SelecionarBotao(«código»)
        botao(0) = btnInicio
        botao(1) = btnBilhetes
        botao(2) = btnClientes
        botao(3) = btnFuncionarios
        botao(4) = btnEncargos
        botao(5) = btnHorarios
        botao(6) = btnProdutos
        botao(7) = btnSalas
        botao(8) = btnVendas
    End Sub

    Private Sub pctBotao_Click(sender As System.Object, e As System.EventArgs) Handles pctBotao.Click
        tmrAnimacao.Enabled = True
    End Sub

    Private Sub tmrAnimacao_Tick(sender As System.Object, e As System.EventArgs) Handles tmrAnimacao.Tick
        Dim variavel As Integer = Math.Round((2 / 5) * contador) 'Deste modo, a variável será maior e maior
        If pctBotao.Tag Then 'Menu expandido, então tem-se que se escolhe-lo
            If Me.Size.Width > 49 Then 'Enquanto o comprimento for maior que 49

                Me.Size = New System.Drawing.Size(Me.Size.Width - variavel, Me.Size.Height)
                pctBotao.Location = New Point(pctBotao.Location.X - variavel, pctBotao.Location.Y)

            Else 'Quando chega aos 49, tem o compriemnto ideal
                pctBotao.Tag = False
                pctLogo.Hide()
                pctEncolhido.Show()
                tmrAnimacao.Stop()
                contador = -1 ' Tem de ficar -1 para quando chegar ao final somar com 1 e dar ZERO
            End If
        Else 'Menu encolhido, então tem-se que se expandi-lo
            If pnl1.Size.Width < 260 Then

                pctLogo.Show()
                pctEncolhido.Hide()

                Me.Size = New System.Drawing.Size(Me.Size.Width + variavel, Me.Size.Height)
                pctBotao.Location = New Point(pctBotao.Location.X + variavel, pctBotao.Location.Y)

            Else '250 é o comprimento ideal
                pctBotao.Tag = True
                tmrAnimacao.Stop()
                contador = -1 ' Tem de ficar -1 para quando chegar ao final somar com 1 e dar ZERO
            End If
        End If
        contador += 1
    End Sub

    Public Sub SelecionarBotao(ByVal numero As Integer)
        If numero >= 0 And numero < DIMLBL Then
            botao(numero).Enabled = False
            botao(numero).BackColor = Color.FromArgb(37, 46, 49)
        End If
    End Sub


    Private Sub btnInicio_Click(sender As System.Object, e As System.EventArgs) Handles btnInicio.Click
        'Fechar todos os forms ----> <-------
        frmClientes.Hide()
        frmHome.Show()

    End Sub


    Private Sub btnClientes_Click(sender As System.Object, e As System.EventArgs) Handles btnClientes.Click
        'Fechar todos os forms ----> <-------
        frmHome.Hide()
        frmClientes.Show()
    End Sub

    Private Sub btnVendas_Click(sender As System.Object, e As System.EventArgs) Handles btnVendas.Click
        frmHome.Hide()
        frmVendas.Show()
    End Sub
End Class
