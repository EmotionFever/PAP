﻿Imports MySql.Data.mysqlclient
Public Class frmVendas_Inserir
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim registos As Integer
    Dim leitor As MySqlDataReader
    Dim query As String = ""
    Dim contador As Integer = 0
    Public Const MAX_PRODUTOS As Integer = 50
    Public prod(MAX_PRODUTOS) As Produto
    Private Sub frmVendas_Inserir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        query = ""
        n_registo = 0

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
                query = "select codG, nome from generos"
                comando = New MySqlCommand(query, ligacao)
                contador = 0

                ligacao.Open()
                leitor = comando.ExecuteReader
                While (leitor.Read) 'Crio botões de todos os "gêneros"
                    btn(n_registo) = New Button
                    btn(n_registo).Size = New System.Drawing.Size(154, 61) 'atribuir tamanho
                    btn(n_registo).Font = New Font("Arial", 10, FontStyle.Regular) 'atribuir tipo de letra
                    btn(n_registo).BackColor = Color.CornflowerBlue
                    btn(n_registo).FlatStyle = FlatStyle.Flat
                    btn(n_registo).Text = leitor.GetString("nome")
                    btn(n_registo).Tag = leitor.GetInt32("codG")
                    AddHandler btn(n_registo).Click, AddressOf CategoriaClicada
                    flpcategorias.Controls.Add(btn(n_registo)) 'Adicionar ao formulário

                    n_registo += 1
                End While
                ligacao.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBilhetes_Click(sender As System.Object, e As System.EventArgs) Handles btnBilhetes.Click
        query = ""
        n_registo = 0

        Try
            query = "select count(codH) as registos from horarios where now() between datai and dataf"
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
                query = "select codH, nome, preco, hora from horarios,filmes where horarios.codfl = filmes.codfl"
                comando = New MySqlCommand(query, ligacao)
                contador = 0

                ligacao.Open()
                leitor = comando.ExecuteReader
                While (leitor.Read)
                    pnl(n_registo) = New Panel
                    pnl(n_registo).Size = New System.Drawing.Size(310, 79) 'atribuir tamanho
                    pnl(n_registo).BackColor = Color.Silver
                    pnl(n_registo).BorderStyle = BorderStyle.Fixed3D
                    flpitens.Controls.Add(pnl(n_registo)) 'Adicionar ao formulário

                    pct(n_registo) = New PictureBox
                    pct(n_registo).Size = New System.Drawing.Size(54, 54)
                    pct(n_registo).Location = New System.Drawing.Point(0, 0)
                    'pct(n_registo).BackgroundImage = «« Imagem »» -------> <---------
                    pct(n_registo).BackgroundImageLayout = ImageLayout.Zoom
                    pnl(n_registo).Controls.Add(pct(n_registo))

                    lbl(n_registo) = New Label
                    lbl(n_registo).Location = New System.Drawing.Point(55, 0)
                    lbl(n_registo).Font = New Font("Arial", 8, FontStyle.Bold)
                    lbl(n_registo).Text = "Filme: " + leitor.GetString("nome")
                    lbl(n_registo).AutoSize = False
                    lbl(n_registo).Size = New System.Drawing.Size(250, 20)
                    pnl(n_registo).Controls.Add(lbl(n_registo))

                    lbl(n_registo + 1) = New Label
                    lbl(n_registo + 1).Location = New System.Drawing.Point(55, 19)
                    lbl(n_registo + 1).Font = New Font("Arial", 8, FontStyle.Regular)
                    lbl(n_registo + 1).Text = "Hora: " + leitor.GetTimeSpan("hora").ToString
                    lbl(n_registo + 1).AutoSize = False
                    lbl(n_registo + 1).Size = New System.Drawing.Size(250, 20)
                    pnl(n_registo).Controls.Add(lbl(n_registo + 1))

                    lbl(n_registo + 2) = New Label
                    lbl(n_registo + 2).Location = New System.Drawing.Point(55, 38)
                    lbl(n_registo + 2).Font = New Font("Arial", 8, FontStyle.Regular)
                    lbl(n_registo + 2).Text = "Lugares: " 'Tenho de encontrar uma forma de calcular o número de lugares vazios
                    lbl(n_registo + 2).AutoSize = False
                    lbl(n_registo + 2).Size = New System.Drawing.Size(250, 20)
                    pnl(n_registo).Controls.Add(lbl(n_registo + 2))

                    lbl(n_registo + 3) = New Label
                    lbl(n_registo + 3).Location = New System.Drawing.Point(55, 58)
                    lbl(n_registo + 3).Font = New Font("Arial", 8, FontStyle.Regular)
                    lbl(n_registo + 3).Text = "Preço: " + leitor.GetString("preco") + " €"
                    lbl(n_registo + 3).AutoSize = False
                    lbl(n_registo + 3).Size = New System.Drawing.Size(250, 20)
                    pnl(n_registo).Controls.Add(lbl(n_registo + 3))

                    n_registo += 1
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

        'Try
        query = "select count(codP) as registos from produtos where codG=" + btnx.Tag.ToString
        comando = New MySqlCommand(query, ligacao)
        ligacao.Open()
        leitor = comando.ExecuteReader
        leitor.Read()
        registos = leitor.GetInt32("registos")
        ligacao.Dispose()

        If registos > 0 Then
            lbl1.Text = "Que produto deseja?"
            flpcategorias.Hide()
            flpitens.Show()

            '2ª Ligação
            query = "select * from produtos where codG=" + btnx.Tag.ToString
            comando = New MySqlCommand(query, ligacao)

            contador = 0

            ligacao.Open()
            leitor = comando.ExecuteReader
            While (leitor.Read)

                prod(contador) = New Produto
                prod(contador).Cod = leitor.GetInt32("codP") ' Guardo o CodP na respetiva posição do array do produto

                prod(contador).pnl = New Panel
                prod(contador).pnl.Size = New System.Drawing.Size(310, 58) 'atribuir tamanho
                prod(contador).pnl.BackColor = Color.Silver
                prod(contador).pnl.BorderStyle = BorderStyle.Fixed3D
                flpitens.Controls.Add(prod(contador).pnl) 'Adicionar ao formulário
                prod(contador).pnl.BringToFront()

                prod(contador).btn = New Button
                prod(contador).btn.Location = New System.Drawing.Point(268, 17)
                prod(contador).btn.AutoSize = False
                prod(contador).btn.Size = New System.Drawing.Size(25, 25)
                prod(contador).btn.BackgroundImage = My.Resources.add
                prod(contador).btn.BackgroundImageLayout = ImageLayout.Zoom
                prod(contador).btn.FlatStyle = FlatStyle.Flat
                prod(contador).btn.FlatAppearance.BorderSize = 0

                prod(contador).pnl.Controls.Add(prod(contador).btn)
                prod(contador).btn.BringToFront()
                AddHandler prod(contador).btn.Click, AddressOf ProdutoClicado

                prod(contador).pct = New PictureBox
                prod(contador).pct.Size = New System.Drawing.Size(54, 54)
                prod(contador).pct.Location = New System.Drawing.Point(0, 0)
                'prod(contador).pct.BackgroundImage = «« Imagem »» -------> <---------
                prod(contador).pct.BackgroundImageLayout = ImageLayout.Zoom
                prod(contador).pnl.Controls.Add(prod(contador).pct)

                prod(contador).lbl(0) = New Label
                prod(contador).lbl(0).Location = New System.Drawing.Point(55, 0)
                prod(contador).lbl(0).Font = New Font("Arial", 8, FontStyle.Bold)
                prod(contador).lbl(0).Text = "Nome: " + leitor.GetString("nome")
                prod(contador).lbl(0).AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
                prod(contador).lbl(0).AutoSize = False
                prod(contador).lbl(0).Size = New System.Drawing.Size(250, 20)
                prod(contador).pnl.Controls.Add(prod(contador).lbl(0))

                prod(contador).lbl(1) = New Label
                prod(contador).lbl(1).Location = New System.Drawing.Point(55, 19)
                prod(contador).lbl(1).Font = New Font("Arial", 8, FontStyle.Regular)
                prod(contador).lbl(1).Text = "Stock: " + leitor.GetUInt32("stock").ToString
                prod(contador).lbl(1).AutoSize = False
                prod(contador).lbl(1).Size = New System.Drawing.Size(250, 20)
                prod(contador).lbl(1).Controls.Add(prod(contador).lbl(1))
                prod(contador).lbl(1).Tag = contador + 1

                prod(contador).lbl(2) = New Label
                prod(contador).lbl(2).Location = New System.Drawing.Point(55, 38)
                prod(contador).lbl(2).Font = New Font("Arial", 8, FontStyle.Regular)
                prod(contador).lbl(2).Text = "Preço: " + Math.Round(leitor.GetDouble("preco"), 2).ToString + " €"
                prod(contador).lbl(2).AutoSize = False
                prod(contador).lbl(2).Size = New System.Drawing.Size(250, 20)
                prod(contador).pnl.Controls.Add(prod(contador).lbl(2))



                contador += 1
            End While

        Else
            MessageBox.Show("Não existem produtos com esse gênero", "Não foram encontados registos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'Finally
        ligacao.Close()
        'End Try
    End Sub

    Private Sub btnVoltar_Click(sender As System.Object, e As System.EventArgs) Handles btnVoltar.Click
        lbl1.Text = "Que tipo de artigo quer?"
        flpcategorias.Show()
        flpitens.Hide()
        flpitens.Controls.Clear() 'Os objetos dentro do FlowLayoutPanel desaparecem
    End Sub

    Private Sub ProdutoClicado(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button)

        If frmVendas.contador < frmVendas.MAX_ARTIGOS Then







            Try
                query = "select * from produtos where codP=" + btnx.Tag.ToString
                comando = New MySqlCommand(query, ligacao)

                ligacao.Open()
                leitor = comando.ExecuteReader
                leitor.Read()

                Dim quantidade As Integer = 0
                quantidade = CInt(InputBox("Digite a quantidade que deseja desse produto ", "Quantos produtos deseja?"))
                If quantidade > 0 Then
                    If quantidade <= leitor.GetUInt32("stock") Then
                        frmVendas.art(frmVendas.contador) = New Artigo

                        frmVendas.art(frmVendas.contador).pnl = New Panel
                        frmVendas.art(frmVendas.contador).pnl.Size = New System.Drawing.Size(289, 74) 'atribuir tamanho
                        frmVendas.art(frmVendas.contador).pnl.BackColor = Color.Firebrick
                        frmVendas.art(frmVendas.contador).pnl.BorderStyle = BorderStyle.Fixed3D
                        frmVendas.flpartigos.Controls.Add(frmVendas.art(frmVendas.contador).pnl) 'Adicionar ao formulário

                        frmVendas.art(frmVendas.contador).btn = New Button
                        frmVendas.art(frmVendas.contador).btn.Location = New System.Drawing.Point(245, 24)
                        frmVendas.art(frmVendas.contador).btn.AutoSize = False
                        frmVendas.art(frmVendas.contador).btn.Size = New System.Drawing.Size(25, 25)
                        frmVendas.art(frmVendas.contador).btn.BackgroundImage = My.Resources.lixo
                        frmVendas.art(frmVendas.contador).btn.BackgroundImageLayout = ImageLayout.Zoom
                        frmVendas.art(frmVendas.contador).btn.FlatStyle = FlatStyle.Flat
                        frmVendas.art(frmVendas.contador).btn.FlatAppearance.BorderSize = 0
                        frmVendas.art(frmVendas.contador).btn.Tag = frmVendas.contador
                        frmVendas.art(frmVendas.contador).pnl.Controls.Add(frmVendas.art(frmVendas.contador).btn)
                        frmVendas.art(frmVendas.contador).btn.BringToFront()
                        AddHandler frmVendas.art(frmVendas.contador).btn.Click, AddressOf frmVendas.ApagarProduto

                        frmVendas.art(frmVendas.contador).pct = New PictureBox
                        frmVendas.art(frmVendas.contador).pct.Size = New System.Drawing.Size(72, 72)
                        frmVendas.art(frmVendas.contador).pct.Location = New System.Drawing.Point(0, 0)
                        'pct.BackgroundImage = «« Imagem »» -------> <---------
                        frmVendas.art(frmVendas.contador).pct.BackgroundImageLayout = ImageLayout.Zoom
                        frmVendas.art(frmVendas.contador).pnl.Controls.Add(frmVendas.art(frmVendas.contador).pct)

                        frmVendas.art(frmVendas.contador).lbl(0) = New Label
                        frmVendas.art(frmVendas.contador).lbl(0).Location = New System.Drawing.Point(72, 4)
                        frmVendas.art(frmVendas.contador).lbl(0).Font = New Font("Arial", 8, FontStyle.Bold)
                        frmVendas.art(frmVendas.contador).lbl(0).ForeColor = Color.White
                        frmVendas.art(frmVendas.contador).lbl(0).Text = leitor.GetString("nome")
                        frmVendas.art(frmVendas.contador).lbl(0).AutoSize = False
                        frmVendas.art(frmVendas.contador).lbl(0).Size = New System.Drawing.Size(210, 20)
                        frmVendas.art(frmVendas.contador).lbl(0).AutoEllipsis = True 'Coloca "..." se o texto exceder o tamanho da label
                        frmVendas.art(frmVendas.contador).pnl.Controls.Add(frmVendas.art(frmVendas.contador).lbl(0))

                        frmVendas.art(frmVendas.contador).lbl(1) = New Label
                        frmVendas.art(frmVendas.contador).lbl(1).Location = New System.Drawing.Point(72, 27)
                        frmVendas.art(frmVendas.contador).lbl(1).Font = New Font("Arial", 8, FontStyle.Regular)
                        frmVendas.art(frmVendas.contador).lbl(1).ForeColor = Color.White
                        frmVendas.art(frmVendas.contador).lbl(1).Text = quantidade.ToString + " x " + Math.Round(leitor.GetDouble("preco"), 2).ToString
                        frmVendas.art(frmVendas.contador).lbl(1).AutoSize = False
                        frmVendas.art(frmVendas.contador).lbl(1).Size = New System.Drawing.Size(210, 20)
                        frmVendas.art(frmVendas.contador).pnl.Controls.Add(frmVendas.art(frmVendas.contador).lbl(1))

                        frmVendas.art(frmVendas.contador).lbl(2) = New Label
                        frmVendas.art(frmVendas.contador).lbl(2).Location = New System.Drawing.Point(72, 49)
                        frmVendas.art(frmVendas.contador).lbl(2).Font = New Font("Arial", 8, FontStyle.Regular)
                        frmVendas.art(frmVendas.contador).lbl(2).ForeColor = Color.White
                        frmVendas.art(frmVendas.contador).lbl(2).Text = "Preço Total: " + Math.Round(leitor.GetDouble("preco") * quantidade, 2).ToString + " €"
                        frmVendas.art(frmVendas.contador).lbl(2).AutoSize = False
                        frmVendas.art(frmVendas.contador).lbl(2).Size = New System.Drawing.Size(210, 20)
                        frmVendas.art(frmVendas.contador).pnl.Controls.Add(frmVendas.art(frmVendas.contador).lbl(2))

                        frmVendas.art(frmVendas.contador).listado = True
                        frmVendas.contador += 1

                    Else
                        MessageBox.Show("Não é possível vender " + quantidade.ToString + " unidades de " + leitor.GetString("nome") + " visto que só existem " + leitor.GetInt32("stock").ToString + " desse artigo disponíveis ", "Excedeu o stock disponível para esse artigo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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