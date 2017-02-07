Imports MySql.Data.mysqlclient
Public Class frmVendas_Inserir
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim registos As Integer = 0
    Dim leitor As MySqlDataReader
    Dim query As String = ""
    Dim cont_prod As Integer = 0
    Dim cont_genero As Integer = 0
    Dim cont_bilhete As Integer = 0
    Public Const MAX_PRODUTOS As Integer = 50 ' A base de dados não deve ter mais que «MAX_PRODUTOS» produtos!!!!
    Public prod(MAX_PRODUTOS) As Produto
    Private Sub frmVendas_Inserir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Guardo todos mas TODOS os produtos no array prod(MAX_PRODUTOS)

        ''''''''Try
        query = "select count(codP) as registos from produtos"
        comando = New MySqlCommand(query, ligacao)
        ligacao.Open()
        leitor = comando.ExecuteReader
        leitor.Read()
        registos = leitor.GetInt32("registos")
        ligacao.Dispose()

        If registos > 0 Then

            '2ª Ligação
            query = "select * from produtos"
            comando = New MySqlCommand(query, ligacao)

            ligacao.Open()
            leitor = comando.ExecuteReader
            While (leitor.Read)

                prod(cont_prod) = New Produto
                prod(cont_prod).codP = leitor.GetInt32("codP") ' Guardo o CodP na respetiva posição do array do produto
                prod(cont_prod).codG = leitor.GetInt32("codG") ' Guardo o CodG na respetiva posição do array do produto

                prod(cont_prod).pnl = New Panel
                prod(cont_prod).pnl.Size = New System.Drawing.Size(310, 58) 'atribuir tamanho
                prod(cont_prod).pnl.BackColor = Color.Silver
                prod(cont_prod).pnl.BorderStyle = BorderStyle.Fixed3D

                prod(cont_prod).btn = New Button
                prod(cont_prod).btn.Location = New System.Drawing.Point(268, 17)
                prod(cont_prod).btn.AutoSize = False
                prod(cont_prod).btn.Size = New System.Drawing.Size(25, 25)
                prod(cont_prod).btn.BackgroundImage = My.Resources.add
                prod(cont_prod).btn.Tag = cont_prod
                prod(cont_prod).btn.BackgroundImageLayout = ImageLayout.Zoom
                prod(cont_prod).btn.FlatStyle = FlatStyle.Flat
                prod(cont_prod).btn.FlatAppearance.BorderSize = 0

                prod(cont_prod).pnl.Controls.Add(prod(cont_prod).btn)
                prod(cont_prod).btn.BringToFront()
                AddHandler prod(cont_prod).btn.Click, AddressOf ProdutoClicado

                prod(cont_prod).pct = New PictureBox
                prod(cont_prod).pct.Size = New System.Drawing.Size(54, 54)
                prod(cont_prod).pct.Location = New System.Drawing.Point(0, 0)
                'prod(contador).pct.BackgroundImage = «« Imagem »» -------> <---------
                prod(cont_prod).pct.BackgroundImageLayout = ImageLayout.Zoom
                prod(cont_prod).pnl.Controls.Add(prod(cont_prod).pct)

                prod(cont_prod).lbl(0) = New Label
                prod(cont_prod).lbl(0).Location = New System.Drawing.Point(55, 0)
                prod(cont_prod).lbl(0).Font = New Font("Arial", 8, FontStyle.Bold)
                prod(cont_prod).lbl(0).Text = "Nome: " + leitor.GetString("nome")
                prod(cont_prod).lbl(0).AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
                prod(cont_prod).lbl(0).AutoSize = False
                prod(cont_prod).lbl(0).Size = New System.Drawing.Size(250, 20)
                prod(cont_prod).pnl.Controls.Add(prod(cont_prod).lbl(0))

                prod(cont_prod).lbl(1) = New Label
                prod(cont_prod).lbl(1).Location = New System.Drawing.Point(55, 19)
                prod(cont_prod).lbl(1).Font = New Font("Arial", 8, FontStyle.Regular)
                prod(cont_prod).lbl(1).Text = "Stock: " + leitor.GetUInt32("stock").ToString
                prod(cont_prod).quant = leitor.GetUInt32("stock")
                prod(cont_prod).lbl(1).AutoSize = False
                prod(cont_prod).lbl(1).Size = New System.Drawing.Size(250, 20)
                prod(cont_prod).pnl.Controls.Add(prod(cont_prod).lbl(1))

                prod(cont_prod).lbl(2) = New Label
                prod(cont_prod).lbl(2).Location = New System.Drawing.Point(55, 38)
                prod(cont_prod).lbl(2).Font = New Font("Arial", 8, FontStyle.Regular)
                prod(cont_prod).lbl(2).Text = "Preço: " + Math.Round(leitor.GetDouble("preco"), 2).ToString + " €"
                prod(cont_prod).lbl(2).AutoSize = False
                prod(cont_prod).lbl(2).Size = New System.Drawing.Size(250, 20)
                prod(cont_prod).pnl.Controls.Add(prod(cont_prod).lbl(2))



                cont_prod += 1
            End While

        Else
            MessageBox.Show("Não existem produtos registados", "Não foram encontados registos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close() ' PODE DAR ERRO $&%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        End If
        '' Catch ex As Exception
        ''''  MessageBox.Show(ex.Message)
        'Finally
        ligacao.Close()
        ' End Try


        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        query = ""

        Try
            query = "select count(codG) as registos from generos"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            leitor.Read()
            registos = leitor.GetInt32("registos")
            ligacao.Dispose()

            If registos > 0 Then 'Existe categorias?
                Dim btn(registos) As Button

                '2ª Ligação
                query = "select * from generos"
                comando = New MySqlCommand(query, ligacao)

                ligacao.Open()
                leitor = comando.ExecuteReader
                While (leitor.Read) 'Crio botões de todos os "gêneros"
                    btn(cont_genero) = New Button
                    btn(cont_genero).Size = New System.Drawing.Size(154, 61) 'atribuir tamanho
                    btn(cont_genero).Font = New Font("Arial", 10, FontStyle.Regular) 'atribuir tipo de letra
                    btn(cont_genero).BackColor = Color.CornflowerBlue
                    btn(cont_genero).FlatStyle = FlatStyle.Flat
                    btn(cont_genero).Text = leitor.GetString("nome")
                    btn(cont_genero).Tag = leitor.GetInt32("codG")
                    AddHandler btn(cont_genero).Click, AddressOf CategoriaClicada
                    flpcategorias.Controls.Add(btn(cont_genero)) 'Adicionar ao formulário

                    cont_genero += 1
                End While
                ligacao.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBilhetes_Click(sender As System.Object, e As System.EventArgs) Handles btnBilhetes.Click 'EM DESENVOLVIMENTO
        query = ""

        Try
            query = "select count(codCa) as registos from calendarios where now() between datai and dataf"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            leitor.Read()
            registos = leitor.GetInt32("registos")
            ligacao.Dispose()

            If registos > 0 Then
                lbl1.Text = "Que sessão deseja?"
                flpcategorias.Hide()
                flpitens.Show()

                Dim pnl(registos) As Panel
                Dim lbl(registos * 4) As Label
                Dim pct(registos) As PictureBox

                '2ª Ligação
                query = "select codCa, nome, preco, hora from calendarios, filmes where calendarios.codfl = filmes.codfl and now() between datai and dataf"
                comando = New MySqlCommand(query, ligacao)
                cont_bilhete = 0

                ligacao.Open()
                leitor = comando.ExecuteReader
                While (leitor.Read)
                    pnl(cont_bilhete) = New Panel
                    pnl(cont_bilhete).Size = New System.Drawing.Size(310, 79) 'atribuir tamanho
                    pnl(cont_bilhete).BackColor = Color.Silver
                    pnl(cont_bilhete).BorderStyle = BorderStyle.Fixed3D
                    flpitens.Controls.Add(pnl(cont_bilhete)) 'Adicionar ao formulário

                    pct(cont_bilhete) = New PictureBox
                    pct(cont_bilhete).Size = New System.Drawing.Size(54, 54)
                    pct(cont_bilhete).Location = New System.Drawing.Point(0, 0)
                    'pct(n_registo).BackgroundImage = «« Imagem »» -------> <---------
                    pct(cont_bilhete).BackgroundImageLayout = ImageLayout.Zoom
                    pnl(cont_bilhete).Controls.Add(pct(cont_bilhete))

                    lbl(cont_bilhete) = New Label
                    lbl(cont_bilhete).Location = New System.Drawing.Point(55, 0)
                    lbl(cont_bilhete).Font = New Font("Arial", 8, FontStyle.Bold)
                    lbl(cont_bilhete).Text = "Filme: " + leitor.GetString("nome")
                    lbl(cont_bilhete).AutoSize = False
                    lbl(cont_bilhete).Size = New System.Drawing.Size(250, 20)
                    pnl(cont_bilhete).Controls.Add(lbl(cont_bilhete))

                    lbl(cont_bilhete + 1) = New Label
                    lbl(cont_bilhete + 1).Location = New System.Drawing.Point(55, 19)
                    lbl(cont_bilhete + 1).Font = New Font("Arial", 8, FontStyle.Regular)
                    lbl(cont_bilhete + 1).Text = "Hora: " + leitor.GetTimeSpan("hora").ToString
                    lbl(cont_bilhete + 1).AutoSize = False
                    lbl(cont_bilhete + 1).Size = New System.Drawing.Size(250, 20)
                    pnl(cont_bilhete).Controls.Add(lbl(cont_bilhete + 1))

                    lbl(cont_bilhete + 2) = New Label
                    lbl(cont_bilhete + 2).Location = New System.Drawing.Point(55, 38)
                    lbl(cont_bilhete + 2).Font = New Font("Arial", 8, FontStyle.Regular)
                    lbl(cont_bilhete + 2).Text = "Lugares: " 'Tenho de encontrar uma forma de calcular o número de lugares vazios
                    lbl(cont_bilhete + 2).AutoSize = False
                    lbl(cont_bilhete + 2).Size = New System.Drawing.Size(250, 20)
                    pnl(cont_bilhete).Controls.Add(lbl(cont_bilhete + 2))

                    lbl(cont_bilhete + 3) = New Label
                    lbl(cont_bilhete + 3).Location = New System.Drawing.Point(55, 58)
                    lbl(cont_bilhete + 3).Font = New Font("Arial", 8, FontStyle.Regular)
                    lbl(cont_bilhete + 3).Text = "Preço: " + leitor.GetString("preco") + " €"
                    lbl(cont_bilhete + 3).AutoSize = False
                    lbl(cont_bilhete + 3).Size = New System.Drawing.Size(250, 20)
                    pnl(cont_bilhete).Controls.Add(lbl(cont_bilhete + 3))

                    cont_bilhete += 1
                End While
                ligacao.Close()
            Else
                MessageBox.Show("Não existem horários de filmes", "Não foram encontados registos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CategoriaClicada(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button) 'Este botão ganha todas as características do botão clicado

        registos = 0
        For corrente As Integer = 0 To cont_prod - 1
            If prod(corrente).codG = CInt(btnx.Tag) Then
                flpitens.Controls.Add(prod(corrente).pnl) 'Adicionar ao formulário
                prod(corrente).pnl.BringToFront()
                registos += 1
            End If
        Next

            If registos > 0 Then
                lbl1.Text = "Que produto deseja?"
                flpcategorias.Hide()
                flpitens.Show()
            Else
                MessageBox.Show("Não existem produtos com esse género", "Não foram encontados registos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
    End Sub

    Private Sub btnVoltar_Click(sender As System.Object, e As System.EventArgs) Handles btnVoltar.Click
        lbl1.Text = "Que tipo de artigo quer?"
        flpcategorias.Show()
        flpitens.Hide()
        flpitens.Controls.Clear() 'Os objetos dentro do FlowLayoutPanel desaparecem
    End Sub

    Private Sub ProdutoClicado(ByVal sender As Object, ByVal e As EventArgs)
        'TENHO de fazer com que a label do stock diminua a quantidade selecionada aqui!!!!!!!!!!!!!!

        Dim btnx As Button = DirectCast(sender, Button)

        If frmVendas.cont_art < frmVendas.MAX_ARTIGOS Then







            Try
                query = "select * from produtos where codP=" + prod(btnx.Tag).codP.ToString
                comando = New MySqlCommand(query, ligacao)

                ligacao.Open()
                leitor = comando.ExecuteReader
                leitor.Read()

                Dim quantidade As Integer = 0
                quantidade = CInt(InputBox("Digite a quantidade que deseja desse produto ", "Quantos produtos deseja?"))
                If quantidade > 0 Then
                    If quantidade <= prod(btnx.Tag).quant Then
                        prod(btnx.Tag).quant -= quantidade
                        prod(btnx.Tag).lbl(1).Text = "Stock: " + prod(btnx.Tag).quant.ToString



                        frmVendas.art(frmVendas.cont_art) = New Artigo

                        frmVendas.art(frmVendas.cont_art).pnl = New Panel
                        frmVendas.art(frmVendas.cont_art).pnl.Size = New System.Drawing.Size(289, 74) 'atribuir tamanho
                        frmVendas.art(frmVendas.cont_art).pnl.BackColor = Color.Firebrick
                        frmVendas.art(frmVendas.cont_art).pnl.BorderStyle = BorderStyle.Fixed3D
                        frmVendas.flpartigos.Controls.Add(frmVendas.art(frmVendas.cont_art).pnl) 'Adicionar ao formulário

                        frmVendas.art(frmVendas.cont_art).btn = New Button
                        frmVendas.art(frmVendas.cont_art).btn.Location = New System.Drawing.Point(245, 24)
                        frmVendas.art(frmVendas.cont_art).btn.AutoSize = False
                        frmVendas.art(frmVendas.cont_art).btn.Size = New System.Drawing.Size(25, 25)
                        frmVendas.art(frmVendas.cont_art).btn.BackgroundImage = My.Resources.lixo
                        frmVendas.art(frmVendas.cont_art).btn.BackgroundImageLayout = ImageLayout.Zoom
                        frmVendas.art(frmVendas.cont_art).btn.FlatStyle = FlatStyle.Flat
                        frmVendas.art(frmVendas.cont_art).btn.FlatAppearance.BorderSize = 0
                        frmVendas.art(frmVendas.cont_art).btn.Tag = frmVendas.cont_art
                        frmVendas.art(frmVendas.cont_art).pnl.Controls.Add(frmVendas.art(frmVendas.cont_art).btn)
                        frmVendas.art(frmVendas.cont_art).btn.BringToFront()
                        AddHandler frmVendas.art(frmVendas.cont_art).btn.Click, AddressOf frmVendas.ApagarProduto

                        frmVendas.art(frmVendas.cont_art).pct = New PictureBox
                        frmVendas.art(frmVendas.cont_art).pct.Size = New System.Drawing.Size(72, 72)
                        frmVendas.art(frmVendas.cont_art).pct.Location = New System.Drawing.Point(0, 0)
                        'pct.BackgroundImage = «« Imagem »» -------> <---------
                        frmVendas.art(frmVendas.cont_art).pct.BackgroundImageLayout = ImageLayout.Zoom
                        frmVendas.art(frmVendas.cont_art).pnl.Controls.Add(frmVendas.art(frmVendas.cont_art).pct)

                        frmVendas.art(frmVendas.cont_art).lbl(0) = New Label
                        frmVendas.art(frmVendas.cont_art).lbl(0).Location = New System.Drawing.Point(72, 4)
                        frmVendas.art(frmVendas.cont_art).lbl(0).Font = New Font("Arial", 8, FontStyle.Bold)
                        frmVendas.art(frmVendas.cont_art).lbl(0).ForeColor = Color.White
                        frmVendas.art(frmVendas.cont_art).lbl(0).Text = leitor.GetString("nome")
                        frmVendas.art(frmVendas.cont_art).lbl(0).AutoSize = False
                        frmVendas.art(frmVendas.cont_art).lbl(0).Size = New System.Drawing.Size(210, 20)
                        frmVendas.art(frmVendas.cont_art).lbl(0).AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
                        frmVendas.art(frmVendas.cont_art).pnl.Controls.Add(frmVendas.art(frmVendas.cont_art).lbl(0))

                        frmVendas.art(frmVendas.cont_art).lbl(1) = New Label
                        frmVendas.art(frmVendas.cont_art).lbl(1).Location = New System.Drawing.Point(72, 27)
                        frmVendas.art(frmVendas.cont_art).lbl(1).Font = New Font("Arial", 8, FontStyle.Regular)
                        frmVendas.art(frmVendas.cont_art).lbl(1).ForeColor = Color.White
                        frmVendas.art(frmVendas.cont_art).lbl(1).Text = quantidade.ToString + " x " + Math.Round(leitor.GetDouble("preco"), 2).ToString
                        frmVendas.art(frmVendas.cont_art).lbl(1).AutoSize = False
                        frmVendas.art(frmVendas.cont_art).lbl(1).Size = New System.Drawing.Size(210, 20)
                        frmVendas.art(frmVendas.cont_art).pnl.Controls.Add(frmVendas.art(frmVendas.cont_art).lbl(1))

                        frmVendas.art(frmVendas.cont_art).lbl(2) = New Label
                        frmVendas.art(frmVendas.cont_art).lbl(2).Location = New System.Drawing.Point(72, 49)
                        frmVendas.art(frmVendas.cont_art).lbl(2).Font = New Font("Arial", 8, FontStyle.Regular)
                        frmVendas.art(frmVendas.cont_art).lbl(2).ForeColor = Color.White
                        frmVendas.art(frmVendas.cont_art).lbl(2).Text = "Preço Total: " + Math.Round(leitor.GetDouble("preco") * quantidade, 2).ToString + " €"
                        frmVendas.art(frmVendas.cont_art).lbl(2).AutoSize = False
                        frmVendas.art(frmVendas.cont_art).lbl(2).Size = New System.Drawing.Size(210, 20)
                        frmVendas.art(frmVendas.cont_art).pnl.Controls.Add(frmVendas.art(frmVendas.cont_art).lbl(2))

                        frmVendas.art(frmVendas.cont_art).listado = True
                        frmVendas.cont_art += 1

                    Else
                        MessageBox.Show("Não é possível vender " + quantidade.ToString + " unidades de " + leitor.GetString("nome") + " visto que só existem " + prod(btnx.Tag).quant.ToString + " desse artigo disponíveis ", "Excedeu o stock disponível para esse artigo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Não pode adicionar '" + quantidade.ToString + "' artigos. Tem de digitar um número inteiro maior que 0.", "Não adicionou um número válido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                ligacao.Close()
            End Try


        Else
            MessageBox.Show("Infelizmente, não poderá adicionar mais nenhum artigo visto que chegou ao limte máximo de " + frmVendas.MAX_ARTIGOS.ToString + " artigos", "A sua listagem alcançou o limite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class