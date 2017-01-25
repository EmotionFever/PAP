Imports MySql.Data.mysqlclient
Public Class frmVendas_Inserir
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim DS As DataSet = New DataSet
    Dim comando As MySqlCommand
    Dim DS1 As DataSet
    Dim constante As Integer
    Dim leitor As MySqlDataReader
    Dim query As String = ""
    Dim n_registo As Integer = 0
    Private Sub frmVendas_Inserir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        query = ""
        n_registo = 0

        Try
            query = "select count(codG) as registos from generos"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            leitor.Read()
            constante = leitor.GetInt32("registos")
            ligacao.Dispose()

            If constante > 0 Then 'Existe categorias?
                Dim btn(constante) As Button

                '2ª Ligação
                query = "select codG, nome from generos"
                comando = New MySqlCommand(query, ligacao)
                n_registo = 0

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
            constante = leitor.GetInt32("registos")
            ligacao.Dispose()

            If constante > 0 Then
                lbl1.Text = "Que sessão deseja?"
                flpcategorias.Hide()
                flpitens.Show()

                Dim pnl(constante) As Panel
                Dim lbl(constante * 4) As Label
                Dim pct(constante) As PictureBox

                '2ª Ligação
                query = "select codH, nome, preco, hora from horarios,filmes where horarios.codfl = filmes.codfl"
                comando = New MySqlCommand(query, ligacao)
                n_registo = 0

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
        constante = leitor.GetInt32("registos")
        ligacao.Dispose()

        If constante > 0 Then
            lbl1.Text = "Que produto deseja?"
            flpcategorias.Hide()
            flpitens.Show()
            Dim pnl(constante) As Panel
            Dim lbl(constante * 3) As Label
            Dim pct(constante) As PictureBox
            Dim btn(constante) As Button

            '2ª Ligação
            query = "select codP, nome, stock, preco from produtos where codG=" + btnx.Tag.ToString
            comando = New MySqlCommand(query, ligacao)
            n_registo = 0

            ligacao.Open()
            leitor = comando.ExecuteReader
            While (leitor.Read)


                pnl(n_registo) = New Panel
                pnl(n_registo).Size = New System.Drawing.Size(310, 58) 'atribuir tamanho
                pnl(n_registo).BackColor = Color.Silver
                pnl(n_registo).BorderStyle = BorderStyle.Fixed3D
                flpitens.Controls.Add(pnl(n_registo)) 'Adicionar ao formulário
                pnl(n_registo).BringToFront()

                btn(n_registo) = New Button
                btn(n_registo).Location = New System.Drawing.Point(268, 17)
                btn(n_registo).AutoSize = False
                btn(n_registo).Size = New System.Drawing.Size(25, 25)
                btn(n_registo).BackgroundImage = My.Resources.add
                btn(n_registo).BackgroundImageLayout = ImageLayout.Zoom
                btn(n_registo).FlatStyle = FlatStyle.Popup
                btn(n_registo).Tag = leitor.GetInt32("codP") 'os cods começam no 1 não no 0 <------
                pnl(n_registo).Controls.Add(btn(n_registo))
                btn(n_registo).BringToFront()
                AddHandler btn(n_registo).Click, AddressOf ProdutoClicado

                pct(n_registo) = New PictureBox
                pct(n_registo).Size = New System.Drawing.Size(54, 54)
                pct(n_registo).Location = New System.Drawing.Point(0, 0)
                'pct(n_registo).BackgroundImage = «« Imagem »» -------> <---------
                pct(n_registo).BackgroundImageLayout = ImageLayout.Zoom
                pnl(n_registo).Controls.Add(pct(n_registo))

                lbl(n_registo) = New Label
                lbl(n_registo).Location = New System.Drawing.Point(55, 0)
                lbl(n_registo).Font = New Font("Arial", 8, FontStyle.Bold)
                lbl(n_registo).Text = "Nome: " + leitor.GetString("nome")
                lbl(n_registo).AutoSize = False
                lbl(n_registo).Size = New System.Drawing.Size(250, 20)
                pnl(n_registo).Controls.Add(lbl(n_registo))

                lbl(n_registo + 1) = New Label
                lbl(n_registo + 1).Location = New System.Drawing.Point(55, 19)
                lbl(n_registo + 1).Font = New Font("Arial", 8, FontStyle.Regular)
                lbl(n_registo + 1).Text = "Stock: " + Math.Round(leitor.GetDouble("stock"), 2).ToString
                lbl(n_registo + 1).AutoSize = False
                lbl(n_registo + 1).Size = New System.Drawing.Size(250, 20)
                pnl(n_registo).Controls.Add(lbl(n_registo + 1))
                lbl(n_registo + 1).Tag = n_registo + 1

                lbl(n_registo + 2) = New Label
                lbl(n_registo + 2).Location = New System.Drawing.Point(55, 38)
                lbl(n_registo + 2).Font = New Font("Arial", 8, FontStyle.Regular)
                lbl(n_registo + 2).Text = "Preço: " + leitor.GetString("preco") + " €"
                lbl(n_registo + 2).AutoSize = False
                lbl(n_registo + 2).Size = New System.Drawing.Size(250, 20)
                pnl(n_registo).Controls.Add(lbl(n_registo + 2))



                n_registo += 1
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
        lbl1.Text = "Que tipo de produto quer?"
        flpcategorias.Show()
        flpitens.Hide()
        flpitens.Controls.Clear() 'Os objetos dentro do FlowLayoutPanel desaparecem
    End Sub

    Private Sub ProdutoClicado(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button)

        Dim pnl As Panel
        Dim lbl(4) As Label
        Dim pct As PictureBox
        Dim btn As Button

        Try
            query = "select nome, stock, preco from produtos where codP=" + btnx.Tag.ToString
            comando = New MySqlCommand(query, ligacao)

            ligacao.Open()
            leitor = comando.ExecuteReader
            leitor.Read()


            pnl = New Panel
            pnl.Size = New System.Drawing.Size(289, 74) 'atribuir tamanho
            pnl.BackColor = Color.Firebrick
            pnl.BorderStyle = BorderStyle.Fixed3D
            frmVendas.flpartigos.Controls.Add(pnl) 'Adicionar ao formulário

            btn = New Button
            btn.Location = New System.Drawing.Point(268, 17)
            btn.AutoSize = False
            btn.Size = New System.Drawing.Size(25, 25)
            btn.BackgroundImage = My.Resources.add
            btn.BackgroundImageLayout = ImageLayout.Zoom
            btn.FlatStyle = FlatStyle.Popup
            btn.Tag = leitor.GetInt32("codP")
            pnl.Controls.Add(btn)
            btn.BringToFront()
            AddHandler btn.Click, AddressOf frmVendas.ApagarProduto 'difwieufiw

            pct = New PictureBox
            pct.Size = New System.Drawing.Size(72, 72)
            pct.Location = New System.Drawing.Point(0, 0)
            'pct.BackgroundImage = «« Imagem »» -------> <---------
            pct.BackgroundImageLayout = ImageLayout.Zoom
            pnl.Controls.Add(pct)

            lbl(0) = New Label
            lbl(0).Location = New System.Drawing.Point(72, 4)
            lbl(0).Font = New Font("Arial", 8, FontStyle.Bold)
            lbl(0).ForeColor = Color.White
            lbl(0).Text = "Nome: " + leitor.GetString("nome")
            lbl(0).AutoSize = False
            lbl(0).Size = New System.Drawing.Size(250, 20)
            pnl.Controls.Add(lbl(0))

            lbl(1) = New Label
            lbl(1).Location = New System.Drawing.Point(72, 27)
            lbl(1).Font = New Font("Arial", 8, FontStyle.Regular)
            lbl(1).ForeColor = Color.White
            lbl(1).Text = "Stock: " + leitor.GetUInt32("stock").ToString
            lbl(1).AutoSize = False
            lbl(1).Size = New System.Drawing.Size(250, 20)
            pnl.Controls.Add(lbl(1))

            lbl(2) = New Label
            lbl(2).Location = New System.Drawing.Point(72, 49)
            lbl(2).Font = New Font("Arial", 8, FontStyle.Regular)
            lbl(2).ForeColor = Color.White
            lbl(2).Text = "Preço: " + Math.Round(leitor.GetDouble("preco"), 2).ToString + " €"
            lbl(2).AutoSize = False
            lbl(2).Size = New System.Drawing.Size(250, 20)
            pnl.Controls.Add(lbl(2))


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ligacao.Close()
        End Try
    End Sub
End Class