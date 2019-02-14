Imports MySql.Data.MySqlClient
Public Class frmProdutos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Public Const MAXPROD As Integer = 100 'Número máximo de produtos na tabela
    Dim prod(MAXPROD) As Produto
    Dim cont_prod As Integer
    Dim posSelecionadoAtiv As Integer = -1
    Dim posSelecionadoDesAtiv As Integer = -1
    Dim rct As New PowerPacks.RectangleShape
    Public Const CAMPOSC As Integer = 4
    Dim lbl(CAMPOSC) As Label

    Private Sub tbc1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tbc1.SelectedIndexChanged
        If tbc1.SelectedIndex = 0 Then
            pnlProibicao.Hide()
            btnInserir.Enabled = True
            If posSelecionadoAtiv > -1 Then
                selecionar(posSelecionadoAtiv, True)
                btnAlterar.Enabled = True
                btnDesativar.Enabled = True
            Else
                des_selecionar(posSelecionadoAtiv)
            End If
            btnAtivar.Enabled = False
            btnProcurar.Enabled = True
            btnDesativar.Show()
        End If
        If tbc1.SelectedIndex = 1 Then
            pnlProibicao.Show()
            btnInserir.Enabled = False
            If posSelecionadoDesAtiv > -1 Then
                selecionar(posSelecionadoDesAtiv, False)
                btnAtivar.Enabled = True
            Else
                des_selecionar(posSelecionadoDesAtiv)
            End If
            btnAlterar.Enabled = False
            btnDesativar.Enabled = False
            btnDesativar.Hide()
        End If
    End Sub

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 6)
        CtrL_MenuCine.Sincronizar_permissoes({btnProcurar}, {btnAlterar, pnlAtivar}, {btnInserir})
        If Not (btnProcurar.Visible Or btnAlterar.Visible) Then
            tbc1.Hide()
        End If
    End Sub

    Private Sub formatar_labels(ByVal ativado As Boolean)
        If ativado Then
            For a As Integer = 0 To CAMPOSC - 1
                lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout)
            Next
        Else
            For a As Integer = 0 To CAMPOSC - 1
                lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout)
            Next
        End If
    End Sub

    Private Sub des_selecionar(ByRef pos As Integer)
        pnlSelecionado.BorderStyle = BorderStyle.FixedSingle
        lblNomeP.Text = "Nome do Produto"
        pctImagemP.BackgroundImage = My.Resources.produtos
        lblGeneroP.Text = "Género"
        lblPrecoP.Text = "Preço"
        lblStockP.Text = "Stock"
        formatar_labels(True)

        pos = -1

        btnAlterar.Enabled = False
        btnAtivar.Enabled = False
        btnDesativar.Enabled = False
    End Sub

    Private Sub selecionar(ByVal pos As Integer, ByVal ativado As Boolean)
        pnlSelecionado.BorderStyle = BorderStyle.Fixed3D
        lblNomeP.Text = prod(pos).lblNome.Text
        pctImagemP.BackgroundImage = prod(pos).btnImagem.BackgroundImage
        lblGeneroP.Text = prod(pos).lblGenero.Text
        lblPrecoP.Text = prod(pos).lblPreco.Text
        lblStockP.Text = prod(pos).lblStock.Text

        If ativado Then
            posSelecionadoAtiv = pos
            formatar_labels(True)
        Else
            posSelecionadoDesAtiv = pos
            formatar_labels(False)
        End If

        btnAlterar.Enabled = True
        btnAtivar.Enabled = True
        btnDesativar.Enabled = True
    End Sub

    Private Sub ProdutoClicado(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button) 'Este botão ganha todas as características do botão clicado

        If flpProdAtiv.Controls.Contains(prod(CInt(btnx.Tag)).pnl) Then
            selecionar(CInt(btnx.Tag), True)
        Else
            selecionar(CInt(btnx.Tag), False)
        End If
    End Sub

    Private Sub ver(ByVal query As String, ByRef flp As FlowLayoutPanel)
        flp.Controls.Clear()
        btnDesativar.Enabled = False
        btnAtivar.Enabled = False
        btnAlterar.Enabled = False

        Try
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            While leitor.Read
                If cont_prod < MAXPROD Then
                    prod(cont_prod) = New Produto
                    If Not IsDBNull(leitor.Item("imagem")) Then
                        Dim lb() As Byte = leitor.Item("imagem")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        prod(cont_prod).criar_prod(leitor.GetInt32("codP"), leitor.GetString("produto"), Image.FromStream(lstr), leitor.GetDouble("preco"), leitor.GetInt32("codG"), leitor.GetString("genero"), leitor.GetInt32("stock"), cont_prod, flp)
                    Else
                        prod(cont_prod).criar_prod(leitor.GetInt32("codP"), leitor.GetString("produto"), leitor.GetDouble("preco"), leitor.GetInt32("codG"), leitor.GetString("genero"), leitor.GetInt32("stock"), cont_prod, flp)
                    End If
                    AddHandler prod(cont_prod).btnImagem.Click, AddressOf ProdutoClicado
                    cont_prod += 1

                Else
                    MessageBox.Show("O limite máximo de imagens que o programa pode mostrar é de " + MAXPROD.ToString + " imagens", "Excesso de produtos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit While
                End If
            End While
            ligacao.Close()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro a ver: " + ex.Message, "Visualização sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try

        If query.Contains("ativado=1") Then
            des_selecionar(posSelecionadoAtiv)
        Else
            des_selecionar(posSelecionadoDesAtiv)
        End If
    End Sub

    Private Sub ver_todos()
        cont_prod = 0
        ver("select codP" &
            ", produtos.nome as produto" &
            ", produtos.codG as codG" &
            ", generos.nome as genero" &
            ", preco" &
            ", stock" &
            ", imagem " &
            "from produtos, generos " &
            "where produtos.codG=generos.codG " &
            "and ativado=1", flpProdAtiv)

        ver("select codP" &
            ", produtos.nome as produto" &
            ", produtos.codG as codG" &
            ", generos.nome as genero" &
            ", preco" &
            ", stock" &
            ", imagem " &
            "from produtos, generos " &
            "where produtos.codG=generos.codG " &
            "and ativado=0", flpProdDesa)
    End Sub

    Private Sub LimparTudo()
        chkNome.Checked = False
        txtNome.Text = ""
        lblNome.Text = "Nome da Produto"

        chkGenero.Checked = False
        cmbGenero.Text = ""
        lblGenero.Text = "Género"

        chkPreco.Checked = False
        nmrPreco.Value = 0
        lblPreco.Text = "Preço"

        chkStock.Checked = False
        nmrStock.Value = 0
        lblStock.Text = "Stock"

        chkImagem.Checked = False
        lblImgNome.Text = "---"
        ofdImagem.FileName = ""
        btnImagem.BackgroundImage = My.Resources.produtos
    End Sub

    Private Sub frmProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pnlProibicao.Location = New Point(12, 3)

        lbl(0) = lblNomeP
        lbl(1) = lblGeneroP
        lbl(2) = lblPrecoP
        lbl(3) = lblStockP

        ver_todos()

        encher(cmbGenero, ligacao, "generos", "nome", "codG", "select codG, nome from generos")
        cmbGenero.Text = ""
        cmbGenero_LostFocus()
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim codG As Integer
        Dim str_erro As String = ""

        str_erro += verificacao(txtNome)
        str_erro += verificacao(cmbGenero)
        str_erro += verificacao(nmrPreco)
        str_erro += verificacao(nmrStock)
        If str_erro = "" Then

            If cmbGenero.SelectedValue IsNot Nothing Then
                codG = cmbGenero.SelectedValue
            Else
                codG = novo_registo(ligacao, "codg", "generos", cmbGenero)
                If codG > 0 Then
                    MessageBox.Show("O género '" + cmbGenero.Text + "' foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("O genero '" + cmbGenero.Text + "' não foi inserido", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If ofdImagem.FileName <> "" Then
                acao_c_Imagem("inserir", ligacao, "insert into produtos (nome,stock,preco,codG,imagem,ativado) " &
                            "values ('" + txtNome.Text + "', " + nmrStock.Value.ToString + ", " + nmrPreco.Value.ToString.Replace(",", ".") + ", " + codG.ToString + ",?Imagem,1)", Image.FromFile(ofdImagem.FileName), 1)
            Else
                acao("inserir", ligacao, "insert into produtos (nome,stock,preco,codG,ativado) " &
                            "values ('" + txtNome.Text + "', " + nmrStock.Value.ToString + ", " + nmrPreco.Value.ToString.Replace(",", ".") + ", " + codG.ToString + ",1)", 1)
            End If

            ver_todos()

            'Limpo os objetos input do formulário
            LimparTudo()

        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub lblNome_MouseEnter(sender As Object, e As System.EventArgs) Handles lblNome.MouseEnter
        txtNome.Show()
        txtNome.Select()
    End Sub
    Private Sub txtNome_LostFocus(sender As Object, e As System.EventArgs) Handles txtNome.LostFocus
        txtNome.Hide()
        If txtNome.Text <> "" Then
            lblNome.Text = txtNome.Text
        Else
            lblNome.Text = "Nome do Produto"
        End If
    End Sub

    Private Sub lblGenero_MouseEnter(sender As Object, e As System.EventArgs) Handles lblGenero.MouseEnter
        cmbGenero.Show()
        cmbGenero.Select()
        If lblGenero.Text = "Género" Then
            cmbGenero.Text = ""
        End If
    End Sub
    Private Sub cmbGenero_LostFocus() Handles cmbGenero.LostFocus
        cmbGenero.Hide()
        If cmbGenero.Text <> "" Then
            lblGenero.Text = cmbGenero.Text
        Else
            lblGenero.Text = "Género"
        End If
    End Sub

    Private Sub lblPreco_MouseEnter(sender As Object, e As System.EventArgs) Handles lblPreco.MouseEnter, nmrPreco.ValueChanged
        nmrPreco.Show()
        nmrPreco.Select()
    End Sub
    Private Sub nmrPreco_lostfocus(sender As Object, e As System.EventArgs) Handles nmrPreco.LostFocus
        nmrPreco.Hide()
        If nmrPreco.Value <> 0 Then
            lblPreco.Text = String.Format("{0:F2}", nmrPreco.Value).Replace(",", ".")
        Else
            lblPreco.Text = "Preço"
        End If
    End Sub

    Private Sub lblStock_MouseEnter(sender As Object, e As System.EventArgs) Handles lblStock.MouseEnter, nmrStock.ValueChanged
        nmrStock.Show()
        nmrStock.Select()
    End Sub
    Private Sub nmrStock_LostFocus(sender As Object, e As System.EventArgs) Handles nmrStock.LostFocus
        nmrStock.Hide()
        If nmrStock.Value <> 0 Then
            lblStock.Text = nmrStock.Value
        Else
            lblStock.Text = "Stock"
        End If
    End Sub

    Private Sub btnAdi_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi.Click
        If ofdImagem.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso ofdImagem.FileName <> "" Then
            Try
                btnImagem.BackgroundImage = Image.FromFile(ofdImagem.FileName)
                lblImgNome.Text = ofdImagem.SafeFileName
                btnAdi.Show()
            Catch ex As Exception
                MessageBox.Show("A imagem que escolheu está corrompida", "Imagem corrompida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRem_Click(sender As System.Object, e As System.EventArgs) Handles btnRem.Click
        lblImgNome.Text = "---"
        ofdImagem.FileName = ""
        btnImagem.BackgroundImage = My.Resources.produtos
    End Sub

    Private Sub btnProcurar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcurar.Click
        'Basicamente, isto pesquisa na base de dados
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim txt As New TextBox
        'Apenas as checkboxes de um campo com um certo são pesquisados. 
        'Ou seja, se eu selecionar o campo ordenado apenas procuro os registos com aquele ordenado mesmo que os outros campos tenham coisas escritas
        txt.Text = txtNome.Text
        txt.Tag = "nome"
        str_erro += Campo_Selecionado_proc("nome", "produtos", chkNome, txt, rct, pquery)
        str_erro += Campo_Selecionado_proc("codg", "produtos", chkGenero, cmbGenero, rct, pquery)
        txt.Text = lblPreco.Text
        txt.Tag = "preço"
        str_erro += Campo_Selecionado_proc("preco", "produtos", chkPreco, txt, rct, pquery)
        str_erro += Campo_Selecionado_proc("stock", "produtos", chkStock, nmrStock, rct, pquery)
        If chkImagem.Checked Then
            MessageBox.Show("Este programa não permite pesquisar por imagens, logo selecionar o campo imagem para a pesquisa é inócuo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'No final deste if tenho 'parte' de um query

        'Caso o pquery esteja vazio significa que o utilizador não escolheu nenhum campo, ou seja "ERRRRRRRO"!!!!
        If str_erro = "" Then
            If pquery <> "" Then
                cont_prod = 0
                ver("select codP" &
                    ", produtos.nome as produto" &
                    ", produtos.codG as codG" &
                    ", generos.nome as genero" &
                    ", preco" &
                    ", stock" &
                    ", imagem " &
                    "from produtos, generos " &
                    "where produtos.codG=generos.codG " &
                    "and ativado=1" + pquery, flpProdAtiv)

                'Como fiquei sem nenhum linha selecionada tenho de desativar os botões
                btnDesativar.Enabled = False
                btnAlterar.Enabled = False

            Else
                MessageBox.Show("Não selecionou nenhum campo para a pesquisa", "Sem campo para pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Dim codg As Integer
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String = ""
            str_erro += Campo_Selecionado_alte("nome", chkNome, lblNomeP, txtNome, rct, pquery)
            str_erro += Campo_Selecionado_alte("stock", chkStock, lblStockP, nmrStock, rct, pquery)
            If chkPreco.Checked Then
                If nmrPreco.Value = 0 Then
                    str_erro += "O preço não pode ser zero. "
                Else
                    If pquery <> "" Then
                        pquery += ","
                    End If
                    pquery += " preco=" + nmrPreco.Value.ToString.Replace(",", ".")
                    lblPrecoP.Font = New Font(lblPrecoP.Font, lblPrecoP.Font.Style Or FontStyle.Strikeout)
                End If
            End If
            If chkImagem.Checked Then
                If ofdImagem.FileName = "" Then
                    str_erro += "Não escolheu uma imagem. "
                Else
                    If pquery <> "" Then
                        pquery += ","
                    End If
                    pquery += " imagem=?Imagem"
                End If
            End If
        If chkGenero.Checked Then
            If str_erro = "" Then
                averiguar = verificacao(rct, cmbGenero)
                If averiguar = "" Then
                    If pquery <> "" Then
                        pquery += ","
                    End If
                    If cmbGenero.SelectedValue IsNot Nothing Then
                        codg = cmbGenero.SelectedValue
                        lblGeneroP.Font = New Font(lblGeneroP.Font, lblGeneroP.Font.Style Or FontStyle.Strikeout)
                    Else
                        codg = novo_registo(ligacao, "codg", "generos", cmbGenero)
                        If codg > 0 Then
                            MessageBox.Show("O género " + cmbGenero.Text + " foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lblGeneroP.Font = New Font(lblGeneroP.Font, lblGeneroP.Font.Style Or FontStyle.Strikeout)
                        Else
                            MessageBox.Show("O género " + cmbGenero.Text + " não foi inserido", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            LimparTudo()
                            Exit Sub
                        End If
                    End If
                    pquery += " produtos.codg=" + codg.ToString
                Else
                    str_erro += averiguar
                End If
            End If
        End If
        If str_erro = "" Then
            If pquery <> "" Then
                If chkImagem.Checked Then
                    acao_c_Imagem("alterar", ligacao, "update produtos set" + pquery + " where codp=" + prod(posSelecionadoAtiv).codP.ToString, Image.FromFile(ofdImagem.FileName), 1)
                Else
                    acao("alterar", ligacao, "update produtos set" + pquery + " where codp=" + prod(posSelecionadoAtiv).codP.ToString, 1)
                End If

                ver_todos()

                LimparTudo()
            Else
                MessageBox.Show("Não selecionou nenhum campo para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click
        'Desativo os dados da linha selecionada na base de dados
        If posSelecionadoAtiv > 0 Then

            acao("desativar", ligacao, "update produtos set ativado=0 where codp = " + prod(posSelecionadoAtiv).codP.ToString, 1)

            ver_todos()

            LimparTudo()
        End If
    End Sub

    Private Sub btnAtivar_Click(sender As System.Object, e As System.EventArgs) Handles btnAtivar.Click
        'Desativo os dados da linha selecionada na base de dados
        If posSelecionadoDesAtiv > 0 Then

            acao("ativar", ligacao, "update produtos set ativado=1 where codp = " + prod(posSelecionadoDesAtiv).codP.ToString, 1)

            ver_todos()

            LimparTudo()
        End If
    End Sub

    Private Sub frmProdutos_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub
End Class