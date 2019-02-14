Imports MySql.Data.mysqlclient
Public Class frmVendas_Inserir
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim registos As Integer = 0
    Dim leitor As MySqlDataReader

    Public lug(0, 0) As Lugar
    Public Const L_ESPACO As Integer = 6

    Dim query As String = ""
    Dim form_quant As Integer = 0
    Public pos_corrente As Integer
    Public posSessao As Integer
    Public btn(ter(ligacao, "registos", "select count(codG) as registos from generos") - 1) As Button
    Public prod(ter(ligacao, "quantidade", "select count(codP) as quantidade from produtos where ativado=1") - 1) As Produto
    Public sss(ter(ligacao, "quantidade", "select count(codCa) as quantidade from calendarios where date(now()) between datai and dataf and hour(calendarios.hora)>hour(sysdate())") - 1) As Sessao

    Private Sub frmVendas_Inserir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(671, 504)
        lblCaminho.Text = "Tipos de artigos "

        For x As Integer = 0 To prod.Length - 1
            prod(x) = New Produto
            prod(x).criar_prod(frmVendas.prod(x).codP, frmVendas.prod(x).lblNome.Text, frmVendas.prod(x).btnImagem.BackgroundImage, CDec(frmVendas.prod(x).lblPreco.Text), frmVendas.prod(x).codG, frmVendas.prod(x).lblGenero.Text, CInt(frmVendas.prod(x).lblStock.Text), x, flpitens)
            AddHandler prod(x).btnImagem.Click, AddressOf ProdutoClicado
        Next
        For x As Integer = 0 To btn.Length - 1
            btn(x) = New Button
            btn(x).Size = New System.Drawing.Size(154, 61) 'atribuir tamanho
            btn(x).Font = New Font("Arial", 10, FontStyle.Regular) 'atribuir tipo de letra
            btn(x).BackColor = Color.CornflowerBlue
            btn(x).FlatStyle = FlatStyle.Flat
            btn(x).Text = frmVendas.btn(x).Text
            btn(x).Tag = frmVendas.btn(x).Tag
            AddHandler btn(x).Click, AddressOf CategoriaClicada
            flpcategorias.Controls.Add(btn(x)) 'Adicionar ao formulário
        Next
        flpitens.Controls.Clear()

    End Sub

    Private Sub btnBilhetes_Click(sender As System.Object, e As System.EventArgs) Handles btnBilhetes.Click 'EM DESENVOLVIMENTO
        Dim cont_cal As Integer = 0
        Try
            If sss.Length > 0 Then
                lblCaminho.Text = "Tipos de artigos ► Bilhetes"
                lbl1.Text = "Que sessão deseja?"
                flpcategorias.Hide()
                flpitens.Show()

                '2ª Ligação
                query = "select codCa" &
                ", filmes.nome as filme" &
                ", hour(calendarios.hora) * 60 + minute(calendarios.hora) as minutosi, (hour(calendarios.hora)+hour(filmes.duracao)) * 60 + minute(calendarios.hora)+minute(filmes.duracao) as minutosf" &
                ", salas.nome as sala" &
                ", calendarios.datai as datai" &
                ", calendarios.dataf as dataf" &
                ", filmes.imagem as imagem " &
                "from calendarios, filmes, salas " &
                "where calendarios.cods=salas.cods " &
                "and calendarios.codfl=filmes.codfl " &
                "and date(now()) between calendarios.datai and calendarios.dataf " &
                "and hour(calendarios.hora) > hour(sysdate())"
                comando = New MySqlCommand(query, ligacao)
                ligacao.Open()
                leitor = comando.ExecuteReader
                While leitor.Read
                    sss(cont_cal) = New Sessao
                    If Not IsDBNull(leitor.Item("imagem")) Then
                        Dim lb() As Byte = leitor.Item("imagem")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        sss(cont_cal).criar_sss(leitor.GetInt32("codCa"), leitor.GetString("filme"), Image.FromStream(lstr), leitor.GetInt32("minutosi"), leitor.GetInt32("minutosf"), leitor.GetString("sala"), leitor.GetString("datai"), leitor.GetString("dataf"), cont_cal, flpitens)
                    Else
                        sss(cont_cal).criar_sss(leitor.GetInt32("codCa"), leitor.GetString("filme"), leitor.GetInt32("minutoi"), leitor.GetInt32("minutof"), leitor.GetString("sala"), leitor.GetString("datai"), leitor.GetString("dataf"), cont_cal, flpitens)
                    End If
                    AddHandler sss(cont_cal).btnImgFilme.Click, AddressOf SessaoClicada
                    cont_cal += 1

                End While
                ligacao.Close()
            Else
                MessageBox.Show("Não existem horários de filmes por agora", "Não foram encontados registos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro a ver: " + ex.Message, "Visualização sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
    End Sub


    Private Sub criar_label(ByVal x As Integer, ByVal y As Integer, ByVal texto As String)
        Dim lbl As New Label

        lbl.Name = x.ToString + "-" + y.ToString
        lbl.Location = New System.Drawing.Point(x, y)
        lbl.AutoSize = False
        lbl.Size = New System.Drawing.Size(20, 20)
        lbl.Text = texto
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.ForeColor = Color.White

        pnlLugares.Controls.Add(lbl)
    End Sub

    Private Sub SessaoClicada(ByVal sender As Object, ByVal e As EventArgs)
        pnlLugares.Controls.Clear()
        Dim btnx As Button = DirectCast(sender, Button) 'Este botão ganha todas as características do botão clicado

        posSessao = CInt(btnx.Tag)

        Dim vagas As Integer = ter(ligacao, "quant", "select count(l1.codl) as quant " &
        "from lugares l1 " &
        "INNER JOIN linhas ON l1.codln = linhas.codln " &
        "INNER JOIN salas ON l1.cods = salas.cods " &
        "INNER JOIN calendarios ON salas.cods = calendarios.cods " &
        "where NOT EXISTS (select l2.codl" &
        ", concat(linhas.nome,'-',coluna) as nome " &
        "from lugares l2 " &
        "INNER JOIN linhas ON l2.codln = linhas.codln " &
        "INNER JOIN bilhetes ON bilhetes.codl=l2.codl " &
        "INNER JOIN vendas ON vendas.codv=bilhetes.codv " &
        "where l1.codl = l2.codl " &
        "and vendas.datav=date(sysdate()) " &
        "and bilhetes.codca=" + sss(posSessao).codCa.ToString + ") " &
        "and calendarios.codca=" + sss(posSessao).codCa.ToString + " " &
        "order by l1.codln, l1.coluna asc")
        If vagas > 0 Then
            flpitens.Hide()
            lblsala.Text = "Lugares disponiveis na " + sss(posSessao).lblSalas.Text.ToString
            Dim cods As Integer = ter(ligacao, "cods", "select cods from calendarios " &
            "where calendarios.codca=" + sss(posSessao).codCa.ToString)
            Dim colunas As Integer = ter(ligacao, "quant", "select max(coluna) as quant from lugares " &
            "where cods=" + cods.ToString)
            Dim linhas As Integer = ter(ligacao, "quant", "select max(codln) as quant from lugares " &
            "where cods=" + cods.ToString)
            ReDim lug(colunas - 1, linhas - 1)
            Dim nome_linha As String
            Dim codl As Integer
            For y As Integer = 0 To linhas
                nome_linha = ter_str(ligacao, "linha", "select linhas.nome as linha from linhas where codln=" + (linhas - (y - 1)).ToString)
                For x As Integer = 0 To colunas
                    If x = 0 And y = 0 Then
                        'Não faz nada aqui 
                    ElseIf x = 0 And y > 0 Then
                        'Legenda vertical
                        criar_label(x * (L_ESPACO + 20), y * (L_ESPACO + 20), nome_linha)
                    ElseIf x > 0 And y = 0 Then
                        'Legenda horizontal
                        criar_label(x * (L_ESPACO + 20), y * (L_ESPACO + 20), x.ToString)
                    Else
                        'Mostrar lugar
                        lug(x - 1, y - 1) = New Lugar
                        codl = ter(ligacao, "codl", "select codl from lugares where coluna=" + x.ToString + " and codln=" + (linhas - (y - 1)).ToString + " and cods=" + cods.ToString)

                        lug(x - 1, y - 1).criar_lugar(codl, x * (L_ESPACO + 20), y * (L_ESPACO + 20), x - 1, y - 1, pnlLugares)
                        tlt1.SetToolTip(lug(x - 1, y - 1).btn, nome_linha + "-" + x.ToString)

                        AddHandler lug(x - 1, y - 1).btn.Click, AddressOf Adicionar
                    End If
                Next
            Next
            'Ocupa os lugares ocupados
            query = "select l2.codln as codln" &
                    ", l2.coluna as coluna " &
                    "from lugares l2 " &
                    "INNER JOIN bilhetes ON bilhetes.codl=l2.codl " &
                    "INNER JOIN vendas ON vendas.codv=bilhetes.codv " &
                    "where vendas.datav=date(sysdate()) " &
                    "and bilhetes.codca=" + sss(posSessao).codCa.ToString

            Dim comando As MySqlCommand = New MySqlCommand(query, ligacao)
            Dim leitor As MySqlDataReader
            Try
                ligacao.Open()
                leitor = comando.ExecuteReader
                While leitor.Read
                    lug(leitor.GetInt32("coluna") - 1, linhas - (leitor.GetInt32("codln") - 1) - 1).estado = "ocupado"
                End While
                ligacao.Close()
            Catch ex As Exception
                ligacao.Close()
            End Try
            'Verificar se já estão lugares selecionados
            'ATENÇÃO: A seleção tem de vir depois da ocupação porque podem haver lugares selecionados e vendidos
            If frmVendas.cont_art > 0 Then
                For x As Integer = 0 To frmVendas.cont_art - 1
                    If frmVendas.art(x).query <> "" Then
                        query = "select l2.codln as codln" &
                                ", l2.coluna as coluna " &
                                "from lugares l2 " &
                                "where l2.codl=" + frmVendas.art(x).codL.ToString

                        comando = New MySqlCommand(query, ligacao)
                        Try
                            ligacao.Open()
                            leitor = comando.ExecuteReader
                            If leitor.Read Then
                                If frmVendas.art(x).listado Then
                                    lug(leitor.GetInt32("coluna") - 1, (linhas - (leitor.GetInt32("codln") - 1)) - 1).estado = "selecionado"
                                Else
                                    lug(leitor.GetInt32("coluna") - 1, (linhas - (leitor.GetInt32("codln") - 1)) - 1).estado = "normal"
                                End If

                            End If
                            ligacao.Close()
                        Catch ex As Exception
                            ligacao.Close()
                        End Try
                    End If
                Next
            End If
        Else
            MessageBox.Show("Esta sessão tem todos os lugares ocupados", "Sala lotada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Adicionar(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button) 'Este botão ganha todas as características do botão clicado

        Dim str As String = btnx.Tag.ToString

        Dim i_divisao As Integer = btnx.Tag.IndexOf(":")

        '1º está o X depois a seguir ao ':' está o Y
        Dim posX As Integer = CInt(str.Substring(0, i_divisao))
        Dim posY As Integer = CInt(str.Substring(i_divisao + 1, str.Length - (i_divisao + 1)))

        query = "insert into bilhetes (codl,codca,preco,codv) values (" + lug(posX, posY).codl.ToString + "," + sss(posSessao).codCa.ToString + "," + frmVendas.precoBilhete.ToString + ","

        If lug(posX, posY).estado = "normal" Then
            If frmVendas.cont_art < frmVendas.MAX_ARTIGOS Then

                'Ainda falta depois o codV e fechar )
                frmVendas.art(frmVendas.cont_art) = New Artigo

                Dim str_lugar As String = ter_str(ligacao, "lugar", "select concat(linhas.nome,'-',coluna) as lugar from lugares INNER JOIN linhas ON linhas.codln=lugares.codln where codl=" + lug(posX, posY).codl.ToString)

                frmVendas.art(frmVendas.cont_art).criar_art(-1, sss(posSessao).btnImgFilme.BackgroundImage, sss(posSessao).lblFilme.Text, "Lugar " + str_lugar + " : " + sss(posSessao).lblSalas.Text, frmVendas.precoBilhete, 1, query, frmVendas.cont_art, frmVendas.flpartigos)
                AddHandler frmVendas.art(frmVendas.cont_art).btn.Click, AddressOf frmVendas.ApagarProduto
                frmVendas.art(frmVendas.cont_art).codL = lug(posX, posY).codl

                frmVendas.cont_art += 1

                lug(posX, posY).estado = "selecionado"
            Else
                MessageBox.Show("Infelizmente, não poderá adicionar mais nenhum artigo visto que chegou ao limte máximo de " + frmVendas.MAX_ARTIGOS.ToString + " artigos", "A sua listagem alcançou o limite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf lug(posX, posY).estado = "selecionado" Then
            'DESESLECIONAR
            For x As Integer = 0 To frmVendas.cont_art - 1
                If query = frmVendas.art(x).query And frmVendas.art(x).listado Then
                    frmVendas.art(x).listado = False
                    frmVendas.flpartigos.Controls.Remove(frmVendas.art(x).pnl)
                End If
            Next
            lug(posX, posY).estado = "normal"
        End If
    End Sub


    Public Sub CategoriaClicada(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button) 'Este botão ganha todas as características do botão clicado

        registos = 0
        For corrente As Integer = 0 To prod.Length - 1
            If prod(corrente).codG = CInt(btnx.Tag) Then
                flpitens.Controls.Add(prod(corrente).pnl) 'Adicionar ao formulário
                prod(corrente).pnl.BringToFront()
                registos += 1
            End If
        Next
        If registos > 0 Then
            lblCaminho.Text = "Tipos de artigos ► " + btnx.Text
            lbl1.Text = "Que produto deseja?"
            flpcategorias.Hide()
            flpitens.Show()
        Else
            MessageBox.Show("Não existem produtos com esse género", "Não foram encontados registos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As System.Object, e As System.EventArgs) Handles btnVoltar.Click
        If flpitens.Visible = False Then
            flpitens.Visible = True
            lblCaminho.Text = "Tipos de artigos ► Bilhetes"
            lbl1.Text = "Que sessão deseja?"
        Else
            lbl1.Text = "Que tipo de artigo quer?"
            lblCaminho.Text = "Tipos de artigos "
            flpcategorias.Show()
            flpitens.Hide()
            flpitens.Controls.Clear() 'Os objetos dentro do FlowLayoutPanel desaparecem
            Me.Size = New System.Drawing.Size(671, 504)
        End If
    End Sub

    Public Sub ProdutoClicado(ByVal sender As Object, ByVal e As EventArgs)

        Dim btnx As Button = DirectCast(sender, Button)
        If CInt(prod(btnx.Tag).lblStock.Text) > 0 Then
            lblprod.Text = "Digite quantas unidades deseja de " + prod(btnx.Tag).lblNome.Text
            nmrQuant.Value = 1
            nmrQuant.Maximum = CInt(prod(btnx.Tag).lblStock.Text)
            lblquant.Text = "Só existem " + prod(btnx.Tag).lblStock.Text + " unidades"
            pos_corrente = btnx.Tag

            Me.Size = New System.Drawing.Size(671, 625)
        Else
            MessageBox.Show("Não existem produtos em stock", "Sem stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.Click
        'TENHO de fazer com que a label do stock diminua a quantidade selecionada aqui!!!!!!!!!!!!!!

        form_quant = nmrQuant.Value
        If frmVendas.cont_art < frmVendas.MAX_ARTIGOS Then
            Try
                query = "select * from produtos where codP=" + prod(pos_corrente).codP.ToString
                comando = New MySqlCommand(query, ligacao)

                ligacao.Open()
                leitor = comando.ExecuteReader
                leitor.Read()
                prod(pos_corrente).lblStock.Text = CInt(prod(pos_corrente).lblStock.Text) - form_quant
                Me.Size = New System.Drawing.Size(671, 504)

                Dim posEncontrada As Integer = -1

                For x As Integer = 0 To frmVendas.cont_art - 1
                    If frmVendas.art(x).Cod = prod(pos_corrente).codP And frmVendas.art(x).query = "" And frmVendas.art(x).listado Then
                        posEncontrada = x
                    End If
                Next

                If posEncontrada = -1 Then
                    frmVendas.art(frmVendas.cont_art) = New Artigo

                    frmVendas.art(frmVendas.cont_art).criar_art(prod(pos_corrente).codP, prod(pos_corrente).btnImagem.BackgroundImage, prod(pos_corrente).lblNome.Text, form_quant.ToString + " unidades x " + String.Format("{0:F2}", leitor.GetDouble("preco")) + " €", leitor.GetDouble("preco") * form_quant, form_quant, "", frmVendas.cont_art, frmVendas.flpartigos)
                    AddHandler frmVendas.art(frmVendas.cont_art).btn.Click, AddressOf frmVendas.ApagarProduto
                    frmVendas.cont_art += 1
                Else
                    frmVendas.art(posEncontrada).lbl(1).Text = (form_quant + frmVendas.art(posEncontrada).quant).ToString + " unidades x " + String.Format("{0:F2}", leitor.GetDouble("preco")) + " €"
                    frmVendas.art(posEncontrada).lbl(2).Text = "Preço Total: " + String.Format("{0:F2}", Math.Round(leitor.GetDouble("preco") * (form_quant + frmVendas.art(posEncontrada).quant), 2, MidpointRounding.AwayFromZero)) + " €"
                    frmVendas.art(posEncontrada).quant += form_quant
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

    Private Sub frmVendas_Inserir_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmVendas.btnProduto.Enabled = True
        For x As Integer = 0 To prod.Length - 1
            frmVendas.prod(x) = New Produto
            frmVendas.prod(x).criar_prod(prod(x).codP, prod(x).lblNome.Text, prod(x).btnImagem.BackgroundImage, CDec(prod(x).lblPreco.Text), prod(x).codG, prod(x).lblGenero.Text, CInt(prod(x).lblStock.Text), x, frmVendas.flpInocuo)
            AddHandler prod(x).btnImagem.Click, AddressOf ProdutoClicado
        Next
        frmVendas.flpInocuo.Controls.Clear()
    End Sub
End Class