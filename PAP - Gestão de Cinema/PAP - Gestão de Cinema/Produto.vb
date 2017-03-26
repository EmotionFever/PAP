Public Class Produto
    Public pnl As New Panel
    Public btnImagem As New Button
    Public lblNome As New Label
    Public lblPreco As New Label
    Public lblGenero As New Label
    Public lblStock As New Label
    Public codP As Integer 'Cod do produto
    Public codG As Integer 'Cod do género do produto
    Public Sub criar_prod(ByVal codPx As Integer, ByVal Nome As String, ByVal Imagem As Image, ByVal Preco As Double, _
                          ByVal codGx As Integer, ByVal Genero As String, ByVal Stock As Integer, ByVal posicao As Integer, _
                          ByRef flp As FlowLayoutPanel) 'Não esquecer que a imagem também é parâmetro de entrada
        codP = codPx ' Guardo o CodP na respetiva posição do array do produto
        codG = codGx ' Guardo o CodG na respetiva posição do array do produto

        pnl = New Panel
        pnl.Size = New System.Drawing.Size(132, 134) 'atribuir tamanho
        pnl.BackColor = Color.Black

        lblNome.Location = New System.Drawing.Point(0, 0)
        lblNome.Font = New Font("Arial", 10, FontStyle.Regular)
        lblNome.Text = Nome
        lblNome.AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
        lblNome.AutoSize = False
        lblNome.BackColor = Color.FromArgb(255, 255, 128)
        lblNome.Size = New System.Drawing.Size(132, 33)
        pnl.Controls.Add(lblNome)

        btnImagem.Location = New System.Drawing.Point(0, 34)
        btnImagem.AutoSize = False
        btnImagem.Size = New System.Drawing.Size(25, 25)
        btnImagem.BackgroundImage = Imagem
        btnImagem.BackColor = Color.White
        btnImagem.Tag = posicao
        btnImagem.BackgroundImageLayout = ImageLayout.Zoom
        btnImagem.FlatStyle = FlatStyle.Flat
        btnImagem.FlatAppearance.BorderSize = 0
        pnl.Controls.Add(btnImagem)

        lblGenero.Location = New System.Drawing.Point(79, 35)
        lblGenero.Font = New Font("Arial", 10, FontStyle.Regular)
        lblGenero.Text = Genero
        lblGenero.AutoSize = False
        lblNome.BackColor = Color.FromArgb(255, 123, 123)
        lblGenero.Size = New System.Drawing.Size(13, 98)
        pnl.Controls.Add(lblGenero)

        lblPreco.Location = New System.Drawing.Point(79, 35)
        lblPreco.Font = New Font("Arial", 10, FontStyle.Regular)
        lblPreco.Text = String.Format("{0:F2}", Preco) + " €"
        lblPreco.AutoSize = False
        lblPreco.BackColor = Color.FromArgb(255, 192, 128)
        lblPreco.Size = New System.Drawing.Size(52, 16)
        pnl.Controls.Add(lblPreco)

        lblStock.Location = New System.Drawing.Point(91, 116)
        lblStock.Font = New Font("Arial", 10, FontStyle.Regular)
        lblStock.Text = Preco
        lblStock.AutoSize = False
        lblStock.BackColor = Color.FromArgb(255, 123, 123)
        lblStock.Size = New System.Drawing.Size(40, 17)
        pnl.Controls.Add(lblStock)
    End Sub

    'Feito isto é só associar o procedimento desejado ao evento btnImage.click
End Class
