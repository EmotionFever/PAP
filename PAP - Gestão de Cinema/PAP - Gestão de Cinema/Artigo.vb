Public Class Artigo 'Classe dos artigos que aparecem no flpartigos!
    Public pnl As Panel
    Public btn As Button
    Public pct As PictureBox
    Public lbl(4) As Label
    Public listado As Boolean ' Se VERDADEIRO significa que está na flpartigos do frmVendas_Inserir se FALSO foi eliminado entretanto
    Public Cod As Integer 'Cod de um produto ou de um calendario
    Public query As String ' Se a string for ≠ de vazio significa que terá guardada um query para INSERIR um novo bilhete (registo) na tabela BILHETES - ou seja, o artigo é um bilhete
    Public quant As Integer 'Guarda a quantidade de artigos da venda
    Public codL As Integer = 0 'Código de um lugar

    Private Sub configurar(ByVal codx As Integer, ByVal titulo As String, _
                     ByVal subtitulo As String, ByVal preco As Double, ByVal quantx As Integer, ByVal queryx As String, _
                     ByVal posicao As Integer, ByRef flp As FlowLayoutPanel)
        Cod = codx

        pnl = New Panel
        pnl.Size = New System.Drawing.Size(289, 74) 'atribuir tamanho
        pnl.BackColor = Color.Firebrick
        pnl.BorderStyle = BorderStyle.Fixed3D
        frmVendas.flpartigos.Controls.Add(pnl) 'Adicionar ao formulário

        btn = New Button
        btn.Location = New System.Drawing.Point(245, 24)
        btn.AutoSize = False
        btn.Size = New System.Drawing.Size(25, 25)
        btn.BackgroundImage = My.Resources.lixo
        btn.BackgroundImageLayout = ImageLayout.Zoom
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Tag = posicao
        pnl.Controls.Add(btn)
        btn.BringToFront()

        pct = New PictureBox
        pct.Size = New System.Drawing.Size(72, 72)
        pct.Location = New System.Drawing.Point(0, 0)
        pct.BackgroundImageLayout = ImageLayout.Zoom
        pnl.Controls.Add(pct)

        lbl(0) = New Label
        lbl(0).Location = New System.Drawing.Point(72, 4)
        lbl(0).Font = New Font("Arial", 8, FontStyle.Bold)
        lbl(0).ForeColor = Color.White
        lbl(0).Text = titulo
        lbl(0).AutoSize = False
        lbl(0).Size = New System.Drawing.Size(210, 20)
        lbl(0).AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
        pnl.Controls.Add(lbl(0))

        lbl(1) = New Label
        lbl(1).Location = New System.Drawing.Point(72, 27)
        lbl(1).Font = New Font("Arial", 8, FontStyle.Regular)
        lbl(1).ForeColor = Color.White
        lbl(1).Text = subtitulo
        lbl(1).AutoSize = False
        lbl(1).Size = New System.Drawing.Size(210, 20)
        pnl.Controls.Add(lbl(1))

        lbl(2) = New Label
        lbl(2).Location = New System.Drawing.Point(72, 49)
        lbl(2).Font = New Font("Arial", 8, FontStyle.Regular)
        lbl(2).ForeColor = Color.White
        lbl(2).Text = "Preço: " + String.Format("{0:F2}", Math.Round(preco, 2, MidpointRounding.AwayFromZero)) + " €"
        lbl(2).AutoSize = False
        lbl(2).Size = New System.Drawing.Size(210, 20)
        pnl.Controls.Add(lbl(2))
        quant = quantx
        query = queryx

        listado = True
    End Sub


    Public Sub criar_art(ByVal codx As Integer, ByVal imagem As Image, ByVal titulo As String, _
                     ByVal subtitulo As String, ByVal preco As Double, ByVal quantx As Integer, ByVal queryx As String, _
                     ByVal posicao As Integer, ByRef flp As FlowLayoutPanel)
        configurar(codx, titulo, subtitulo, preco, quantx, queryx, posicao, flp)
        pct.BackgroundImage = imagem
    End Sub
    Public Sub criar_art(ByVal codx As Integer, ByVal titulo As String, _
                     ByVal subtitulo As String, ByVal preco As Double, ByVal quantx As Integer, ByVal queryx As String, _
                     ByVal posicao As Integer, ByRef flp As FlowLayoutPanel)
        configurar(codx, titulo, subtitulo, preco, quantx, queryx, posicao, flp)
        pct.BackgroundImage = My.Resources.vendas
    End Sub
End Class
