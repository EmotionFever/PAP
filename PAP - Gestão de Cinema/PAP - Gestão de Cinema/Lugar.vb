Public Class Lugar
    Public btn As Button
    Public codl As Integer
    Private cor_normal As Color = Color.GreenYellow
    Private cor_ocupado As Color = Color.Firebrick
    Private cor_selecionado As Color = Color.Blue

    Property estado As String
        Get
            Select Case btn.BackColor
                Case cor_normal : Return "normal"
                Case cor_ocupado : Return "ocupado"
                Case cor_selecionado : Return "selecionado"
                Case Else : Return "erro"
            End Select
        End Get
        Set(ByVal texto As String) 'btn.BackColor
            Select Case texto
                Case "normal" : btn.BackColor = cor_normal
                    btn.Enabled = True
                Case "ocupado" : btn.BackColor = cor_ocupado
                    btn.Enabled = False
                Case "selecionado" : btn.BackColor = cor_selecionado
                    btn.Enabled = True
                Case Else : btn.BackColor = Color.Gold
            End Select
        End Set
    End Property

    Public Sub criar_lugar(ByVal codlx As Integer, ByVal x As Integer, ByVal y As Integer, ByVal posX As Integer, ByVal posY As Integer, ByRef pnl As Panel)
        codl = codlx

        btn = New Button
        btn.Location = New System.Drawing.Point(x, y)
        btn.AutoSize = False
        btn.Size = New System.Drawing.Size(20, 20)
        btn.BackgroundImage = My.Resources.lugar_transparente
        btn.BackgroundImageLayout = ImageLayout.Zoom
        btn.BackColor = cor_normal
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Tag = posX.ToString + ":" + posY.ToString
        pnl.Controls.Add(btn)
        btn.BringToFront()

        'Associar no final ao handler
    End Sub
End Class
