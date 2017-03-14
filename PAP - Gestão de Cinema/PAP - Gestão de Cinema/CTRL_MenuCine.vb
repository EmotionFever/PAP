Public Class CTRL_MenuCine
    Dim contador As Integer = 0
    Public Const DIMTA As Integer = 10
    Public botao(DIMTA) As System.Windows.Forms.Button
    Dim frm(DIMTA) As Form
    Dim frmAtual As Form
    Dim codta As Integer

    Private Sub CTRL_MenuCine_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '"Apontar" os apontadores de botões para os botões do CTRL / Códigos do procedimento SelecionarBotao(«código»)
        botao(0) = btnInicio
        botao(1) = btnFilmes
        botao(2) = btnClientes
        botao(3) = btnFuncionarios
        botao(4) = btnEncargos
        botao(5) = btnCalendarios
        botao(6) = btnProdutos
        botao(7) = btnSalas
        botao(8) = btnVendas
        botao(9) = btnDefinicoes
    End Sub

    Public Sub Sincronizar_acessos(ByRef frmEu As Form, ByVal numero As Integer) 'Faz desaparecer os botões que o funcionário não tem acesso
        If numero >= 0 And numero < DIMTA Then
            botao(numero).Enabled = False
            botao(numero).BackColor = Color.FromArgb(37, 46, 49)
        End If
        For a As Integer = 0 To DIMTA - 1
            botao(a).Visible = frmLogin.ass(a).acesso()
        Next
        frmAtual = frmEu
        codTa = numero
    End Sub

    Public Sub Sincronizar_permissoes(ByRef objConsultar() As Object, objAlterar() As Object, objInserir As Object)
        For Each objeto As Object In objConsultar
            objeto.visible = frmLogin.ass(codTa).permissao(0)
        Next

        For Each objeto As Object In objAlterar
            objeto.visible = frmLogin.ass(codTa).permissao(1)
        Next

        For Each objeto As Object In objInserir
            objeto.visible = frmLogin.ass(codTa).permissao(2)
        Next
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



    Public Sub IrParaFilmes() Handles btnFilmes.Click
        frmFilmes.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaHome() Handles btnInicio.Click
        frmHome.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaClientes() Handles btnClientes.Click
        frmClientes.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaVendas() Handles btnVendas.Click
        frmVendas.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaDefinicoes() Handles btnDefinicoes.Click
        frmDefinicoes.Show()
        frmAtual.Close()
    End Sub
    Public Sub IrParaFuncionarios() Handles btnFuncionarios.Click
        frmFuncionarios.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaEncargos() Handles btnEncargos.Click
        frmEncargos.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaCalendarios() Handles btnCalendarios.Click
        frmCalendarios.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaProdutos() Handles btnProdutos.Click
        frmProdutos.Show()
        frmAtual.Close()
    End Sub

    Public Sub IrParaSalas() Handles btnSalas.Click
        frmSalas.Show()
        frmAtual.Close()
    End Sub
End Class
