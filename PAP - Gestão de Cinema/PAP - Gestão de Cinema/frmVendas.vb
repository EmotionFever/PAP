Imports MySql.Data.MySqlClient
Public Class frmVendas
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Public Const MAX_ARTIGOS As Integer = 100
    Public art(MAX_ARTIGOS - 1) As Artigo
    Public cont_art As Integer = 0
    Public Const precoBilhete As Double = 5
    Public prod(ter(ligacao, "quantidade", "select count(codP) as quantidade from produtos where ativado=1") - 1) As Produto
    Public btn(ter(ligacao, "registos", "select count(codG) as registos from generos")) As Button
    Dim carregado As Boolean = False
    Public flpInocuo As New FlowLayoutPanel
    Public codvSelecionado As Integer

    Private Sub ver()
        'DataGridView empregado
        mostrar(dgvSempre, ligacao, "vendas", "codv", "select vendas.codv" &
", funcionarios.nome as funcionário " &
", concat(day(datav),'/',month(datav),'/',year(datav)) as data" &
", sum(ifnull(aux_vend.quantidade,0)) as 'produtos'" &
", count(distinct bilhetes.codb) as 'bilhetes'" &
", sum(ifnull(produtos.preco,0) * ifnull(aux_vend.quantidade,0) + ifnull(bilhetes.preco,0)) as 'preço total/€' " &
", clientes.nome as cliente " &
        "from vendas " &
"LEFT JOIN clientes ON clientes.codc=vendas.codc " &
"INNER JOIN funcionarios ON funcionarios.codf=vendas.codf " &
"LEFT JOIN aux_vend ON aux_vend.codv=vendas.codv " &
"LEFT JOIN produtos ON produtos.codp=aux_vend.codp " &
"LEFT JOIN bilhetes ON bilhetes.codv=vendas.codv " &
"GROUP BY vendas.codv")

        mostrar(dgvMes, ligacao, "vendas", "codv", "select vendas.codv" &
", funcionarios.nome as funcionário " &
", concat(day(datav),'/',month(datav),'/',year(datav)) as data" &
", sum(ifnull(aux_vend.quantidade,0)) as 'produtos'" &
", count(distinct bilhetes.codb) as 'bilhetes'" &
", sum(ifnull(produtos.preco,0) * ifnull(aux_vend.quantidade,0) + ifnull(bilhetes.preco,0)) as 'preço total/€' " &
", clientes.nome as cliente " &
        "from vendas " &
"LEFT JOIN clientes ON clientes.codc=vendas.codc " &
"INNER JOIN funcionarios ON funcionarios.codf=vendas.codf " &
"LEFT JOIN aux_vend ON aux_vend.codv=vendas.codv " &
"LEFT JOIN produtos ON produtos.codp=aux_vend.codp " &
"LEFT JOIN bilhetes ON bilhetes.codv=vendas.codv " &
" where month(sysdate())=month(datav) " &
"GROUP BY vendas.codv")

        mostrar(dgvSemana, ligacao, "vendas", "codv", "select vendas.codv" &
", funcionarios.nome as funcionário " &
", concat(day(datav),'/',month(datav),'/',year(datav)) as data" &
", sum(ifnull(aux_vend.quantidade,0)) as 'produtos'" &
", count(distinct bilhetes.codb) as 'bilhetes'" &
", sum(ifnull(produtos.preco,0) * ifnull(aux_vend.quantidade,0) + ifnull(bilhetes.preco,0)) as 'preço total/€' " &
", clientes.nome as cliente " &
        "from vendas " &
"LEFT JOIN clientes ON clientes.codc=vendas.codc " &
"INNER JOIN funcionarios ON funcionarios.codf=vendas.codf " &
"LEFT JOIN aux_vend ON aux_vend.codv=vendas.codv " &
"LEFT JOIN produtos ON produtos.codp=aux_vend.codp " &
"LEFT JOIN bilhetes ON bilhetes.codv=vendas.codv " &
" where YEARWEEK(sysdate())=YEARWEEK(datav) " &
"GROUP BY vendas.codv")
        btnAlterar.Enabled = False
        btnNovo.Enabled = True
        codvSelecionado = 0
    End Sub

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CTRL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 8)
        CtrL_MenuCine.Sincronizar_permissoes({tbc1}, {btnAlterar}, {btnInserir})
        If Not btnAlterar.Visible And Not btnProduto.Visible Then
            pnlControlos.Hide()
        End If
    End Sub

    Private Sub btnOutro_Click(sender As System.Object, e As System.EventArgs) Handles btnOutro.Click
        If ass(2).permissao(2) Then
            CtrL_MenuCine.IrParaClientes()
        Else
            MessageBox.Show("Não tem permissão para inserir novos clientes", "Insersão impossível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub LimparTudo()
        flpartigos.Controls.Clear()
        For h As Integer = 0 To cont_art - 1
            art(h) = Nothing
        Next
        cont_art = 0
        carregado = False
        cmbclientes.SelectedValue = 0
        cmbclientes.Text = ""
        lblnomefunc.Text = ter_str(ligacao, "nome", "select nome from funcionarios where codf=" + mdlAcoes.codF.ToString)
        lblnomefunc.Tag = mdlAcoes.codF
        AlterarEstado(rctcliente, "restaurar")
        'NÃO colocar codvSelecionado = 0

    End Sub

    Private Sub frmVendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        encher(cmbclientes, ligacao, "clientes", "nome", "codc", "select codc, nome from clientes where ativado=1")
        LimparTudo()
        ver()
    End Sub


    Public Sub encher_carrinho(ByVal codv As Integer)
        LimparTudo()
        Dim codc As Integer = ter(ligacao, "codc", "select codc from vendas where codv=" + codv.ToString)
        If codc > 0 Then
            cmbclientes.SelectedValue = codc
        Else
            cmbclientes.Text = ""
            cmbclientes.SelectedValue = 0
        End If
        lblnomefunc.Tag = ter(ligacao, "codf", "select codf from vendas where codv=" + codv.ToString)
        lblnomefunc.Text = ter_str(ligacao, "nome", "select nome from funcionarios where codf=" + lblnomefunc.Tag.ToString)
        Dim comando As MySqlCommand
        Dim leitor As MySqlDataReader
        'A venda tem produtos?
        If ter(ligacao, "quant", "select count(*) as quant from aux_vend where codv=" + codv.ToString) > 0 Then
            comando = New MySqlCommand("select produtos.codp as codp, imagem, produtos.nome as produto, preco, aux_vend.quantidade as quantidade " &
            "from aux_vend INNER JOIN produtos ON produtos.codp=aux_vend.codp " &
            "where aux_vend.codv=" + codv.ToString, ligacao)
            Try
                ligacao.Open()
                leitor = comando.ExecuteReader
                While leitor.Read
                    art(cont_art) = New Artigo
                    If Not IsDBNull(leitor.Item("imagem")) Then
                        Dim lb() As Byte = leitor.Item("imagem")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        art(cont_art).criar_art(leitor.GetInt32("codp"), Image.FromStream(lstr), leitor.GetString("produto"), leitor.GetInt32("quantidade").ToString + " unidades x " + String.Format("{0:F2}", leitor.GetDouble("preco")) + " €", leitor.GetDouble("preco") * leitor.GetInt32("quantidade"), leitor.GetInt32("quantidade"), "", cont_art, flpartigos)
                    Else
                        art(cont_art).criar_art(leitor.GetInt32("codp"), leitor.GetString("produto"), leitor.GetInt32("quantidade").ToString + " unidades x " + String.Format("{0:F2}", leitor.GetDouble("preco")) + " €", leitor.GetDouble("preco") * leitor.GetInt32("quantidade"), leitor.GetInt32("quantidade"), "", cont_art, flpartigos)
                    End If
                    AddHandler art(cont_art).btn.Click, AddressOf ApagarProduto
                    cont_art += 1
                End While
                ligacao.Close()
            Catch ex As Exception
                ligacao.Close()
            End Try
        End If
        'A venda tem bilhetes?
        If ter(ligacao, "quant", "select count(*) as quant from bilhetes where codv=" + codv.ToString) > 0 Then
            Dim query As String
            comando = New MySqlCommand("select bilhetes.codl as codl, bilhetes.codca as codca, preco, imagem, filmes.nome as filme, concat(linhas.nome,'-',coluna) as lugar, salas.nome as sala " &
            "from bilhetes INNER JOIN calendarios ON calendarios.codca=bilhetes.codca " &
            "INNER JOIN filmes ON filmes.codfl=calendarios.codfl " &
            "INNER JOIN lugares ON lugares.codl=bilhetes.codl " &
            "INNER JOIN salas ON salas.cods=lugares.cods " &
            "INNER JOIN linhas ON linhas.codln=lugares.codln " &
            "where bilhetes.codv=" + codv.ToString, ligacao)
            Try
                ligacao.Open()
                leitor = comando.ExecuteReader
                While leitor.Read
                    query = "insert into bilhetes (codl,codca,preco,codv) values (" + leitor.GetString("codl") + "," + leitor.GetString("codca").ToString + "," + leitor.GetString("preco").ToString + ","
                    art(cont_art) = New Artigo
                    If Not IsDBNull(leitor.Item("imagem")) Then
                        Dim lb() As Byte = leitor.Item("imagem")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        art(cont_art).criar_art(leitor.GetInt32("codca"), Image.FromStream(lstr), leitor.GetString("filme"), "Lugar " + leitor.GetString("lugar") + " : Sala " + leitor.GetString("sala"), leitor.GetDouble("preco"), 1, query, cont_art, flpartigos)
                    Else
                        art(cont_art).criar_art(leitor.GetInt32("codca"), leitor.GetString("filme"), "Lugar " + leitor.GetString("lugar") + " : Sala " + leitor.GetString("sala"), leitor.GetDouble("preco"), 1, query, cont_art, flpartigos)
                    End If
                    AddHandler art(cont_art).btn.Click, AddressOf ApagarProduto
                    art(cont_art).codL = leitor.GetInt32("codl")
                    cont_art += 1
                End While
                ligacao.Close()
            Catch ex As Exception
                ligacao.Close()
            End Try
        End If
    End Sub

    Private Sub dgvVendas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSempre.CellClick, dgvMes.CellClick, dgvSemana.CellClick, dgvVendas.CellClick
        Dim dgvx As DataGridView = DirectCast(sender, DataGridView) 'Esta dgv ganha todas as características da dgv clicada
        ' Quando o utilizador clica numa célula do DGV este código seleciona a linha toda
        Try
            If Not TypeOf dgvx.CurrentRow.Cells(0).Value Is DBNull Then
                codvSelecionado = dgvx.CurrentRow.Cells(0).Value
                encher_carrinho(codvSelecionado)
            Else
                MessageBox.Show("A linha que selecionou não é válida, insira algum registo para esta desaparecer", "Selecionou uma linha vazia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvx.ClearSelection()
                Exit Sub
            End If
            Dim i As Integer = dgvx.CurrentCell.RowIndex
            dgvSempre.ClearSelection()
            dgvMes.ClearSelection()
            dgvSemana.ClearSelection()
            dgvx.Rows(i).Selected = True

            'Como foi selecionada uma linha posso (re)ativar os botões apagar e alterar
            btnAlterar.Enabled = True
            btnInserir.Enabled = False

        Catch ex As Exception
            btnAlterar.Enabled = False
        End Try
    End Sub

    Private Sub btnProduto_Click(sender As System.Object, e As System.EventArgs) Handles btnProduto.Click
        Dim cont_prod As Integer

        btnProduto.Enabled = False
        If Not carregado Then
            'Carregar todos os produtos para a matriz 'prod'
            Dim query As String = ""
            Dim comando As MySqlCommand
            Dim leitor As MySqlDataReader
            Try
                cont_prod = 0
                query = "select codP" &
                    ", produtos.nome as produto" &
                    ", produtos.codG as codG" &
                    ", generos.nome as genero" &
                    ", preco" &
                    ", stock" &
                    ", imagem " &
                    "from produtos, generos " &
                    "where produtos.codG=generos.codG " &
                    "and ativado=1"
                comando = New MySqlCommand(query, ligacao)
                ligacao.Open()
                leitor = comando.ExecuteReader
                While leitor.Read
                    prod(cont_prod) = New Produto
                    If Not IsDBNull(leitor.Item("imagem")) Then
                        Dim lb() As Byte = leitor.Item("imagem")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        prod(cont_prod).criar_prod(leitor.GetInt32("codP"), leitor.GetString("produto"), Image.FromStream(lstr), leitor.GetDouble("preco"), leitor.GetInt32("codG"), leitor.GetString("genero"), leitor.GetInt32("stock"), cont_prod, flpInocuo)
                    Else
                        prod(cont_prod).criar_prod(leitor.GetInt32("codP"), leitor.GetString("produto"), leitor.GetDouble("preco"), leitor.GetInt32("codG"), leitor.GetString("genero"), leitor.GetInt32("stock"), cont_prod, flpInocuo)
                    End If
                    cont_prod += 1
                End While
                flpInocuo.Controls.Clear() 'Os objetos dentro do FlowLayoutPanel desaparecem
                ligacao.Close()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro a ver: " + ex.Message, "Visualização sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ligacao.Close()
            End Try

            Dim cont_genero As Integer = 0
            'Mostar as categorias disponiveis
            Try
                If btn.Length > 0 Then 'Existe categorias?

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

                        cont_genero += 1
                    End While
                    ligacao.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        frmVendas_Inserir.Show()
        carregado = True
    End Sub

    Public Sub ApagarProduto(sender As System.Object, e As System.EventArgs)
        Dim btnx As Button = DirectCast(sender, Button)
        Dim posApagar As Integer = CInt(btnx.Tag)
        If Not btnProduto.Enabled Then
            For y As Integer = 0 To prod.Length - 1
                If art(posApagar).Cod = prod(y).codP Then
                    frmVendas_Inserir.prod(y).lblStock.Text = CInt(prod(y).lblStock.Text) + art(posApagar).quant
                    If frmVendas_Inserir.pos_corrente = y Then
                        frmVendas_Inserir.nmrQuant.Maximum = CInt(prod(frmVendas_Inserir.pos_corrente).lblStock.Text)
                        frmVendas_Inserir.lblquant.Text = "Só existem " + prod(frmVendas_Inserir.pos_corrente).lblStock.Text + " unidades"
                    End If
                End If
            Next
            If frmVendas_Inserir.flpcategorias.Visible = False And frmVendas_Inserir.flpitens.Visible = False Then
                If art(posApagar).query <> "" Then
                    Dim linhas As Integer = ter(ligacao, "quant", "select max(codln) as quant from lugares " &
                    "where lugares.cods=(select cods from lugares where codl=" + art(posApagar).codL.ToString + ")")

                    Dim query As String = "select l2.codln as codln" &
                    ", l2.coluna as coluna " &
                    "from lugares l2 " &
                    "where l2.codl=" + art(posApagar).codL.ToString

                    Dim comando As MySqlCommand = New MySqlCommand(query, ligacao)
                    Dim leitor As MySqlDataReader
                    Try
                        ligacao.Open()
                        leitor = comando.ExecuteReader
                        If leitor.Read Then
                            frmVendas_Inserir.lug(leitor.GetInt32("coluna"), linhas - (leitor.GetInt32("codln") - 1)).estado = "normal"
                            End If
                        ligacao.Close()
                    Catch ex As Exception
                        ligacao.Close()
                        End Try
                End If
            End If
        End If
        art(posApagar).listado = False
        flpartigos.Controls.Remove(art(posApagar).pnl)
    End Sub

    Private Sub cmbCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbclientes.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim str_erro As String = ""
        If flpartigos.Controls.Count = 0 Then
            str_erro += "Não selecionou nenhum artigo. "
        End If
        If str_erro = "" Then
            If cmbclientes.SelectedValue > 0 Then
                acao("inserir", ligacao, "insert into vendas (codf,codc,datav) " &
                "values (" + mdlAcoes.codF.ToString + ", " + cmbclientes.SelectedValue.ToString + ",date(sysdate()))", 1)
            Else
                acao("inserir", ligacao, "insert into vendas (codf,datav) " &
                "values (" + mdlAcoes.codF.ToString + ",date(sysdate()))", 1)
            End If
            Dim codv As Integer = ter(ligacao, "codv", "select max(codv) as codv from vendas where codf=" + lblnomefunc.Tag.ToString)
            For x As Integer = 0 To cont_art - 1
                If art(x).listado Then
                    If art(x).query = "" Then
                        'Inserir registo de venda de Produto
                        acao("inserir", ligacao, "insert into aux_vend (codv,codp,quantidade) " &
                        "values (" + codv.ToString + ", " + art(x).Cod.ToString + "," + art(x).quant.ToString + ")", 0)
                        acao("alterar", ligacao, "update produtos set stock = stock - " + art(x).quant.ToString + " " &
                        "where codp=" + art(x).Cod.ToString, 0)
                    Else
                        'Inserir Bilhete
                        acao("inserir", ligacao, art(x).query + codv.ToString + ")", 0)
                    End If
                End If
            Next
            flpartigos.Controls.Clear()
            For h As Integer = 0 To cont_art - 1
                art(h) = Nothing
            Next
            'Clonar o prod atualizado do Form Vendas_Inserir para o do form Vendas
            frmVendas_Inserir.Close()
            ver()
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        If flpartigos.Controls.Count > 0 Or codvSelecionado > 0 Then
            If MessageBox.Show("Deseja perder a venda que estava a fazer?", "Limpeza das últimas informações", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dgvSempre.ClearSelection()
                dgvMes.ClearSelection()
                dgvSemana.ClearSelection()
                LimparTudo()
                frmVendas_Inserir.Close()
                codvSelecionado = 0
                btnAlterar.Enabled = False
                btnInserir.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Dim str_erro As String = ""
        If flpartigos.Controls.Count = 0 Then
            str_erro += "Não selecionou nenhum artigo. "
        End If
        If str_erro = "" Then
            If cmbclientes.SelectedValue > 0 Then
                acao("alterar", ligacao, "update vendas set codc=" + cmbclientes.SelectedValue.ToString + " where codv=" + codvSelecionado.ToString, False)
            End If
            acao("alterar", ligacao, "update vendas set codc=" + cmbclientes.SelectedValue.ToString + " where codv=" + codvSelecionado.ToString, False)
            Dim n_prod As Integer = ter(ligacao, "quant", "select count(*) as quant from aux_vend where codv=" + codvSelecionado.ToString)
            If n_prod > 0 Then
                'repôr stocks da venda a apagar
                Dim leitor As MySqlDataReader
                Dim acoes(n_prod - 1) As String
                Dim cont_acoes As Integer = 0
                Dim comandoAV As MySqlCommand = New MySqlCommand("select codp, quantidade from aux_vend where codv=" + codvSelecionado.ToString, ligacao)
                Try
                    ligacao.Open()
                    leitor = comandoAV.ExecuteReader
                    While leitor.Read
                        acoes(cont_acoes) = "update produtos set stock=stock+" + leitor.GetInt32("quantidade").ToString + " where codp=" + leitor.GetInt32("codp").ToString
                        cont_acoes += 1
                    End While
                    ligacao.Close()
                    For x As Integer = 0 To acoes.Length - 1
                        acao("alterar", ligacao, acoes(x), False)
                    Next
                Catch ex As Exception
                    ligacao.Close()
                    MessageBox.Show("Algo correu mal: " + ex.Message, "Alterar Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                acao("eliminar", ligacao, "delete from aux_vend where codv=" + codvSelecionado.ToString, False)
            End If
            acao("eliminar", ligacao, "delete from bilhetes where codv=" + codvSelecionado.ToString, False)
            For x As Integer = 0 To cont_art - 1
                If art(x).listado Then
                    If art(x).query = "" Then
                        'Inserir registo de venda de Produto
                        acao("inserir", ligacao, "insert into aux_vend (codv,codp,quantidade) " &
                        "values (" + codvSelecionado.ToString + ", " + art(x).Cod.ToString + "," + art(x).quant.ToString + ")", 0)
                        acao("alterar", ligacao, "update produtos set stock = stock - " + art(x).quant.ToString + " " &
                        "where codp=" + art(x).Cod.ToString, 0)
                    Else
                        'Inserir Bilhete
                        acao("inserir", ligacao, art(x).query + codvSelecionado.ToString + ")", 0)
                    End If
                End If
            Next
            LimparTudo()
            'Clonar o prod atualizado do Form Vendas_Inserir para o do form Vendas
            frmVendas_Inserir.Close()
            ver()
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmVendas_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub
End Class