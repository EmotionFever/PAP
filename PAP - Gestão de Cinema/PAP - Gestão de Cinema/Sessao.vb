Public Class Sessao
    Public pnl As New Panel
    Public btnImgFilme As New Button
    Public lblFilme As New Label
    Public lblHoras As New Label
    Public lblSalas As New Label
    Public lblData As New Label
    Public codCa As Integer
    Public ativado As Boolean

    Private Sub configurar(ByVal codCax As Integer, ByVal NomeFilme As String, ByVal MinutoI As Integer, _
                          ByVal MinutoF As Integer, ByVal NomeSala As String, ByVal DataI As String, ByVal DataF As String, _
                          ByVal posicao As Integer, ByRef pnlCal As Panel)
        Dim conta As Double
        Dim horas, minutos As Integer

        codCa = codCax  ' Guardo o CodCa na respetiva posição do array da sessao
        DataI = DataI.Substring(0, 10)
        DataF = DataF.Substring(0, 10)

        With pnl
            .Location = New System.Drawing.Point(12, MinutoI)
            .BackColor = Color.FromArgb(255, 142, 50)
            .BorderStyle = BorderStyle.FixedSingle
            .Size = New System.Drawing.Size(245, MinutoF - MinutoI) 'atribuir tamanho
        End With

        With lblFilme
            .Location = New System.Drawing.Point(79, 0)
            .Font = New Font("Arial", 9, FontStyle.Bold)
            .ForeColor = Color.Black
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = NomeFilme
            .AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
            .AutoSize = False
            .Size = New System.Drawing.Size(164, 19)
        End With
        pnl.Controls.Add(lblFilme)

        MinutoI = If(MinutoI < 0, MinutoI + 24 * 60, MinutoI)
        MinutoF = If(MinutoF > 24 * 60, MinutoF - 24 * 60, MinutoF)
        With lblHoras
            .Location = New System.Drawing.Point(79, Math.Round(pnl.Size.Height / 4)) ' [ Filme | {Horários} | Salas | Dias ] = 1/4
            .Font = New Font("Arial", 9, FontStyle.Regular)
            .ForeColor = Color.Black
            conta = MinutoI / 60
            horas = Math.Floor(conta)
            minutos = (conta - horas) * 60
            .Text = horas.ToString("00") + ":" + minutos.ToString("00")
            .Text = .Text + " - "
            conta = MinutoF / 60
            horas = Math.Floor(conta)
            minutos = (conta - horas) * 60
            .Text = .Text + horas.ToString("00") + ":" + minutos.ToString("00")
            .AutoSize = True
        End With
        pnl.Controls.Add(lblHoras)

        With lblSalas
            .Location = New System.Drawing.Point(79, pnl.Size.Height / 2) ' [ Filme | Horários | {Salas} | Dias ] = 2/4 = 1/2
            .Font = New Font("Arial", 9, FontStyle.Regular)
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = "Sala " + NomeSala
        End With
        pnl.Controls.Add(lblSalas)

        With lblData
            .Location = New System.Drawing.Point(101, pnl.Size.Height - 17)
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .TextAlign = ContentAlignment.MiddleRight
            .ForeColor = Color.White
            .AutoSize = True
            .Text = "De " + DataI + " a " + DataF
        End With
        pnl.Controls.Add(lblData)

        With btnImgFilme
            .Location = New System.Drawing.Point(0, 1)
            .AutoSize = False
            .Size = New System.Drawing.Size(77, pnl.Size.Height - 4)
            .BackColor = Color.Transparent
            .Tag = posicao
            .BackgroundImageLayout = ImageLayout.Zoom
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
        End With
        pnl.Controls.Add(btnImgFilme)

        pnlCal.Controls.Add(pnl)

        pnl.BringToFront()
    End Sub

    Public Sub criar_sss(ByVal codCax As Integer, ByVal NomeFilme As String, ByVal Imagem As Image, ByVal MinutoI As Integer, _
                         ByVal MinutoF As Integer, ByVal NomeSala As String, ByVal DataI As String, ByVal DataF As String, _
                         ByVal posicao As Integer, ByRef pnlCal As Panel) 'Não esquecer que a imagem também é parâmetro de entrada
        configurar(codCax, NomeFilme, MinutoI, MinutoF, NomeSala, DataI, DataF, posicao, pnlCal)

        btnImgFilme.BackgroundImage = Imagem
    End Sub

    Public Sub criar_sss(ByVal codCax As Integer, ByVal NomeFilme As String, ByVal MinutoI As Integer, _
                         ByVal MinutoF As Integer, ByVal NomeSala As String, ByVal DataI As String, ByVal DataF As String, _
                         ByVal posicao As Integer, ByRef pnlCal As Panel)
        configurar(codCax, NomeFilme, MinutoI, MinutoF, NomeSala, DataI, DataF, posicao, pnlCal)

        btnImgFilme.BackgroundImage = My.Resources.horarios
    End Sub

    'Feito isto é só associar o procedimento desejado ao evento btnImgFilme.click
End Class
