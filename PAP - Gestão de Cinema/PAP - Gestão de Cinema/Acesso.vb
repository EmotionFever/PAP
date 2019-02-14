Public Class Acesso
    Public imagem As Image
    Public Const DIMPER As Integer = 3
    Public permissao(DIMPER) As Boolean
    Private pnl As Panel
    Private pctImagem As New PictureBox
    Private pct(DIMPER - 1) As PictureBox
    '0 -> consultar; 1 -> alterar; 2 -> inserir

    Public Function acesso() As Boolean
        Dim soma As Integer = 0
        For y As Integer = 0 To DIMPER - 1
            soma += permissao(y)
        Next
        If soma = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub criar_acesso(ByRef flp As FlowLayoutPanel)
        pnl = New Panel
        With pnl
            .Size = New System.Drawing.Size(80, 60) 'atribuir tamanho
            .BackColor = Color.FromArgb(37, 46, 49)
        End With
        flp.Controls.Add(pnl)
        pctImagem = New PictureBox
        With pctImagem
            .Location = New System.Drawing.Point(0, 0)
            .Size = New System.Drawing.Size(pnl.Size.Height, pnl.Size.Height)
            .BackgroundImage = imagem
            .BackgroundImageLayout = ImageLayout.Zoom
            .BackColor = Color.PeachPuff
        End With
        pnl.Controls.Add(pctImagem)
        For z As Integer = 0 To DIMPER - 1
            pct(z) = New PictureBox
            With pct(z)
                .Location = New System.Drawing.Point(61, 20 * z)
                .BackColor = Color.PeachPuff
                .Size = New System.Drawing.Size(19, 19)
                .BackgroundImageLayout = ImageLayout.Zoom
                If permissao(z) Then
                    pct(z).BackColor = Color.FromArgb(128, 255, 128)
                Else
                    pct(z).BackColor = Color.FromArgb(255, 128, 128)
                End If
            End With
            pnl.Controls.Add(pct(z))
        Next
        pct(0).BackgroundImage = My.Resources.consultar
        pct(1).BackgroundImage = My.Resources.alterar
        pct(2).BackgroundImage = My.Resources.inserir
    End Sub
End Class
