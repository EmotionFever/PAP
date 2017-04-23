Public Class Produto
    Public pnl As New Panel
    Public btnImagem As New Button
    Public lblNome As New Label
    Public lblPreco As New Label
    Public lblGenero As New Label
    Public lblStock As New Label
    Public codP As Integer 'Cod do produto
    Public codG As Integer 'Cod do género do produto

    Private Sub configurar(ByVal codPx As Integer, ByVal Nome As String, ByVal Preco As Double, _
                          ByVal codGx As Integer, ByVal Genero As String, ByVal Stock As Integer, ByVal posicao As Integer, _
                          ByRef flp As FlowLayoutPanel)
        codP = codPx ' Guardo o CodP na respetiva posição do array do produto
        codG = codGx ' Guardo o CodG na respetiva posição do array do produto

        With pnl
            .Size = New System.Drawing.Size(121, 148) 'atribuir tamanho
            .BackColor = Color.FromArgb(37, 46, 49)
            .BorderStyle = BorderStyle.FixedSingle
        End With

        With lblNome
            .Location = New System.Drawing.Point(0, 0)
            .Font = New Font("Arial", 9, FontStyle.Bold)
            .ForeColor = Color.White
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = Nome
            .AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
            .AutoSize = False
            .Size = New System.Drawing.Size(pnl.Size.Width, 15)
        End With
        pnl.Controls.Add(lblNome)

        With lblGenero
            .Location = New System.Drawing.Point(0, 102)
            .Font = New Font("Arial", 9, FontStyle.Regular)
            .ForeColor = Color.White
            .Text = Genero
            .AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
            .AutoSize = False
            .Size = New System.Drawing.Size(pnl.Size.Width, 15)
        End With
        pnl.Controls.Add(lblGenero)

        With lblPreco
            .Location = New System.Drawing.Point(0, 117)
            .Font = New Font("Arial", 9, FontStyle.Regular)
            .ForeColor = Color.White
            .AutoSize = True
            .Text = String.Format("{0:F2}", Preco) + " €"
        End With
        pnl.Controls.Add(lblPreco)

        With lblStock
            .Location = New System.Drawing.Point(0, 132)
            .Font = New Font("Arial", 9, FontStyle.Regular)
            .ForeColor = Color.White
            .AutoSize = True
            .Text = Stock
        End With
        pnl.Controls.Add(lblStock)

        flp.Controls.Add(pnl)

        With btnImagem
            .Location = New System.Drawing.Point(0, 14)
            .AutoSize = False
            .Size = New System.Drawing.Size(pnl.Size.Width, 87)
            .BackColor = Color.Firebrick
            .Tag = posicao
            .BackgroundImageLayout = ImageLayout.Zoom
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
        End With
        pnl.Controls.Add(btnImagem)
    End Sub

    Public Sub criar_prod(ByVal codPx As Integer, ByVal Nome As String, ByVal Imagem As Image, ByVal Preco As Double, _
                          ByVal codGx As Integer, ByVal Genero As String, ByVal Stock As Integer, ByVal posicao As Integer, _
                          ByRef flp As FlowLayoutPanel) 'Não esquecer que a imagem também é parâmetro de entrada
        configurar(codPx, Nome, Preco, codGx, Genero, Stock, posicao, flp)

        btnImagem.BackgroundImage = Imagem
    End Sub

    Public Sub criar_prod(ByVal codPx As Integer, ByVal Nome As String, ByVal Preco As Double, _
                          ByVal codGx As Integer, ByVal Genero As String, ByVal Stock As Integer, ByVal posicao As Integer, _
                          ByRef flp As FlowLayoutPanel)
        configurar(codPx, Nome, Preco, codGx, Genero, Stock, posicao, flp)

        btnImagem.BackgroundImage = My.Resources.produtos
    End Sub

    'Feito isto é só associar o procedimento desejado ao evento btnImage.click
End Class
