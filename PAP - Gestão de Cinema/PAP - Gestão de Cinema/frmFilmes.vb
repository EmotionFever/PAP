Imports MySql.Data.MySqlClient
Public Class frmFilmes
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Public Const CAMPOSC As Integer = 7
    Dim lbl(CAMPOSC) As Label
    Dim dtFil_Cat As DataTable = New DataTable("Fil_Cat")
    Dim dsFil_Cat As DataSet = New DataSet
    Dim dtFil_Pai As DataTable = New DataTable("Fil_Pai")
    Dim dsFil_Pai As DataSet = New DataSet

    Private Sub tbc1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tbc1.SelectedIndexChanged
        If tbc1.SelectedIndex = 0 Then
            pnlProibicao.Hide()
            btnInserir.Enabled = True
            If dgvAtivado.SelectedRows.Count > 0 Then
                btnAlterar.Enabled = True
                btnDesativar.Enabled = True
                For a As Integer = 0 To CAMPOSC - 1
                    lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout)
                    lbl(a).Text = dgvAtivado.CurrentRow.Cells(a + 2).Value.ToString
                Next
            End If
            btnAtivar.Enabled = False
            btnProcurar.Enabled = True
            btnDesativar.Show()
        End If
        If tbc1.SelectedIndex = 1 Then
            pnlProibicao.Show()
            btnInserir.Enabled = False
            If dgvDesativado.SelectedRows.Count > 0 Then
                btnAtivar.Enabled = True
                For a As Integer = 0 To CAMPOSC - 1
                    lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout)
                    lbl(a).Text = dgvDesativado.CurrentRow.Cells(a + 2).Value.ToString
                Next
            End If
            btnAlterar.Enabled = False
            btnDesativar.Enabled = False
            btnDesativar.Hide()
        End If
    End Sub

    Private Sub LimparTudo()
        'Limpo os objetos input do formulário
        chkImagem.Checked = False
        lblImgNome.Text = ""
        ofdImagem.FileName = ""
        pctImagem.BackgroundImage = My.Resources.filmes

        txtnome.Text = ""
        AlterarEstado(rctNome, txtnome, "restaurar")
        chknome.Checked = False

        cmbClassificacao.Text = ""
        AlterarEstado(rctClassificacao, cmbClassificacao, "restaurar")
        chkClassificacao.Checked = False

        mtbAno.Text = ""
        AlterarEstado(rctAno, "restaurar")
        chkAno.Checked = False

        cmbRealizador.Text = ""
        cmbRealizador.SelectedValue = 0
        AlterarEstado(rctRealizador, "restaurar")
        chkRealizador.Checked = False

        dtpDuracao.Value = "01/01/2000 00:00:00"
        AlterarEstado(rctAno, "restaurar")
        chkAno.Checked = False

        dtFil_Cat.Clear()
        chkCategorias.Checked = False

        dtFil_Pai.Clear()
        chkPaises.Checked = False

        pnlProibicao.BringToFront()
    End Sub

    Private Sub ver(ByRef dgv As DataGridView, ByVal query As String)
        dgv.Rows.Clear()

        'Coluna do cod
        dgv.ColumnCount = 1
        dgv.Columns(0).Name = "codfl"
        dgv.Columns(0).Visible = False
        'Programar coluna imagem
        Dim imgCol As DataGridViewImageColumn = New DataGridViewImageColumn()
        imgCol.Name = "imagem"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgv.Columns.Add(imgCol)
        'Resto das colunas
        dgv.ColumnCount = 9
        dgv.Columns(2).Name = "nome"
        dgv.Columns(3).Name = "categorias"
        dgv.Columns(4).Name = "classificacao"
        dgv.Columns(5).Name = "ano"
        dgv.Columns(6).Name = "realizador"
        dgv.Columns(7).Name = "paises"
        dgv.Columns(8).Name = "duracao"

        'Inserir linhas/registos
        Dim row As Object()
        comando = New MySqlCommand(query, ligacao)
        Try
            ligacao.Open()
            leitor = comando.ExecuteReader
            While leitor.Read
                If Not IsDBNull(leitor.Item("imagem")) Then
                    Dim lb() As Byte = leitor.Item("imagem")
                    Dim lstr As New System.IO.MemoryStream(lb)
                    row = New Object() {leitor.GetInt32("codfl"), Image.FromStream(lstr), leitor.GetString("filme"), leitor.GetString("categorias"), leitor.GetString("classificacao"), leitor.GetString("ano"), leitor.GetString("realizador"), leitor.GetString("paises"), leitor.GetString("horas") + ":" + CInt(leitor.GetString("minutos")).ToString("00")}
                Else
                    row = New Object() {leitor.GetInt32("codfl"), My.Resources.filmes, leitor.GetString("filme"), leitor.GetString("categorias"), leitor.GetString("classificacao"), leitor.GetString("ano"), leitor.GetString("realizador"), leitor.GetString("paises"), leitor.GetString("horas") + ":" + CInt(leitor.GetString("minutos")).ToString("00")}
                End If
                dgv.Rows.Add(row)
            End While
            dgv.ClearSelection()
            ligacao.Close()
        Catch ex As Exception
            ligacao.Close()
        End Try
    End Sub

    Private Sub ver_todos()
        'DataGridView ativado
        ver(dgvAtivado, "select filmes.codfl as codfl" &
        ", filmes.imagem as imagem" &
        ", filmes.nome as filme" &
        ", ifnull(group_concat(DISTINCT categorias.nome),'') as categorias" &
        ", classificacoes.nome as classificacao" &
        ", filmes.ano as ano" &
        ", ifnull(realizadores.nome,'') as realizador" &
        ", ifnull(group_concat(DISTINCT paises.nome),'') as paises" &
        ", hour(filmes.duracao) as horas" &
        ", minute(filmes.duracao) as minutos " &
        "from filmes " &
        "LEFT JOIN realizadores ON filmes.codr=realizadores.codr " &
        "LEFT JOIN aux_pai ON filmes.codfl=aux_pai.codfl " &
        "LEFT JOIN paises ON aux_pai.codps=paises.codps " &
        "LEFT JOIN aux_cat ON filmes.codfl=aux_cat.codfl " &
        "LEFT JOIN categorias ON aux_cat.codcat=categorias.codcat " &
        "INNER JOIN classificacoes ON classificacoes.codcs=filmes.codcs " &
        "where filmes.ativado = 1 " &
        "group by filmes.codfl")

        'DataGridView DESativado
        ver(dgvDesAtivado, "select filmes.codfl as codfl" &
        ", filmes.imagem as imagem" &
        ", filmes.nome as filme" &
        ", ifnull(group_concat(DISTINCT categorias.nome),'') as categorias" &
        ", classificacoes.nome as classificacao" &
        ", filmes.ano as ano" &
        ", ifnull(realizadores.nome,'') as realizador" &
        ", ifnull(group_concat(DISTINCT paises.nome),'') as paises" &
        ", hour(filmes.duracao) as horas" &
        ", minute(filmes.duracao) as minutos " &
        "from filmes " &
        "LEFT JOIN realizadores ON filmes.codr=realizadores.codr " &
        "LEFT JOIN aux_pai ON filmes.codfl=aux_pai.codfl " &
        "LEFT JOIN paises ON aux_pai.codps=paises.codps " &
        "LEFT JOIN aux_cat ON filmes.codfl=aux_cat.codfl " &
        "LEFT JOIN categorias ON aux_cat.codcat=categorias.codcat " &
        "INNER JOIN classificacoes ON classificacoes.codcs=filmes.codcs " &
        "where filmes.ativado = 0 " &
        "group by filmes.codfl")

        'Covém desativar estes botões
        btnAtivar.Enabled = False
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False
    End Sub

    Private Sub frmFuncionarios_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub

    Private Sub frmFilmes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pnlProibicao.Location = New Point(0, 3)
        btnDesativar.Enabled = False
        btnAtivar.Enabled = False
        btnAlterar.Enabled = False

        'Insiro colunas ao DateTable
        dtFil_Cat.Columns.Add("codCat")
        dtFil_Cat.Columns.Add("nome")
        'Associo o DataSet à tabela do Datatable.
        dsFil_Cat.Tables.Add(dtFil_Cat)
        'Associo a ListBox ao DataSet.
        lstFil_Cat.DataSource = dsFil_Cat.Tables("Fil_Cat")
        lstFil_Cat.DisplayMember = "nome"
        lstFil_Cat.ValueMember = "codCat"

        'Insiro colunas ao DateTable
        dtFil_Pai.Columns.Add("codPs")
        dtFil_Pai.Columns.Add("nome")
        'Associo o DataSet à tabela do Datatable.
        dsFil_Pai.Tables.Add(dtFil_Pai)
        'Associo a ListBox ao DataSet.
        lstFil_Pai.DataSource = dsFil_Pai.Tables("Fil_Pai")
        lstFil_Pai.DisplayMember = "nome"
        lstFil_Pai.ValueMember = "codPs"


        ver_todos()

        lbl(0) = lblnome
        lbl(1) = lblCategorias
        lbl(2) = lblClassificacao
        lbl(3) = lblAno
        lbl(4) = lblRealizador
        lbl(5) = lblPais
        lbl(6) = lblDuracao


        'Aqui, encho a combobox com dados para o utilizador escolher
        encher(cmbClassificacao, ligacao, "classificacoes", "nome", "codcs", "select codcs, nome from classificacoes")
        encher(cmbRealizador, ligacao, "realizadores", "nome", "codr", "select codr, nome from realizadores")

        'Aqui, encho a listboxes com dados para o utilizador escolher
        encher(lstCategorias, ligacao, "categorias", "nome", "codcat", "select codcat, nome from categorias")
        encher(lstPaises, ligacao, "paises", "nome", "codps", "select codps, nome from paises")

        LimparTudo()
    End Sub

    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 1)
        CtrL_MenuCine.Sincronizar_permissoes({btnProcurar}, {btnAlterar, pnlAtivar}, {btnInserir})
        If Not (btnProcurar.Visible Or btnAlterar.Visible) Then
            tbc1.Hide()
        End If
    End Sub

    Private Sub dgvAtivado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAtivado.CellClick
        btnDesativar.Enabled = True
        btnAlterar.Enabled = True

        'Tiro o rasurado caso esteja a mostrar os funcionarios empregados senão  e coloco os valores da linha selecionada nas labels
        For a As Integer = 0 To CAMPOSC - 1
            lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout)
            lbl(a).Text = dgvAtivado.CurrentRow.Cells(a + 2).Value.ToString
        Next
    End Sub

    Private Sub dgvdesAtivado_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDesAtivado.CellClick
        btnAtivar.Enabled = True

        'Tiro o rasurado caso esteja a mostrar os funcionarios empregados senão coloco os valores da linha selecionada nas labels
        For a As Integer = 0 To CAMPOSC - 1
            lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout)
            lbl(a).Text = dgvDesAtivado.CurrentRow.Cells(a + 2).Value.ToString
        Next
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim codR As Integer
        Dim str_erro As String = ""

        str_erro += verificacao(rctNome, txtnome)
        str_erro += verificacao(rctClassificacao, cmbClassificacao)
        If mtbAno.Text <> "" Then
            If Not (mtbAno.TextLength = 4 And CInt(mtbAno.Text) >= 1900 And CInt(mtbAno.Text) <= DateTime.Now.Year + 1) Then
                AlterarEstado(rctAno, mtbAno, "errar")
                str_erro += "O ano '" + mtbAno.Text + "' não válido. "
            Else
                AlterarEstado(rctAno, mtbAno, "acertar")
            End If
        Else
            AlterarEstado(rctAno, mtbAno, "errar")
            str_erro += "Não inseriu um ano. "
        End If

        Dim duracao_min As Integer = dtpDuracao.Value.Hour * 60 + dtpDuracao.Value.Minute
        If duracao_min > 4 * 60 Or duracao_min < 1 * 60 Then
            AlterarEstado(rctDuracao, "errar")
            str_erro += "Um filme não pode exceder as 4 horas nem ser menor que uma. "
        Else
            AlterarEstado(rctDuracao, "acertar")
        End If
        If str_erro = "" Then
            If cmbRealizador.Text <> "" Then
                If cmbRealizador.SelectedValue > 0 Then
                    codR = cmbRealizador.SelectedValue
                Else
                    codR = novo_registo(ligacao, "codr", "realizadores", cmbRealizador)
                    If codR > 0 Then
                        MessageBox.Show("O realizador '" + cmbRealizador.Text + "' foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("O realizador '" + cmbRealizador.Text + "' não foi inserido", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                AlterarEstado(rctRealizador, "acertar")
            End If
            If ofdImagem.FileName <> "" Then
                If cmbRealizador.SelectedValue = 0 Then
                    acao_c_Imagem("inserir", ligacao, "insert into filmes (imagem,nome,codCs,ano,duracao,ativado) " &
                                                "values (?Imagem,'" + txtnome.Text + "', " + cmbClassificacao.SelectedValue.ToString + ", '" + mtbAno.Text + "', '" + dtpDuracao.Value.Hour.ToString + ":" + dtpDuracao.Value.Minute.ToString + "',1)", Image.FromFile(ofdImagem.FileName), 1)
                Else
                    acao_c_Imagem("inserir", ligacao, "insert into filmes (imagem,nome,codCs,ano,codR,duracao,ativado) " &
                                                "values (?Imagem,'" + txtnome.Text + "', " + cmbClassificacao.SelectedValue.ToString + ", '" + mtbAno.Text + "', " + codR.ToString + ", '" + dtpDuracao.Value.Hour.ToString + ":" + dtpDuracao.Value.Minute.ToString + "',1)", Image.FromFile(ofdImagem.FileName), 1)
                End If
            Else
                If cmbRealizador.SelectedValue = 0 Then
                    acao("inserir", ligacao, "insert into filmes (nome,codCs,ano,duracao,ativado) " &
                            "values ('" + txtnome.Text + "', " + cmbClassificacao.SelectedValue.ToString + ", '" + mtbAno.Text + "', '" + dtpDuracao.Value.Hour.ToString + ":" + dtpDuracao.Value.Minute.ToString + "',1)", 1)
                Else
                    acao("inserir", ligacao, "insert into filmes (nome,codCs,ano,codR,duracao,ativado) " &
                                                "values ('" + txtnome.Text + "', " + cmbClassificacao.SelectedValue.ToString + ", '" + mtbAno.Text + "', " + codR.ToString + ", '" + dtpDuracao.Value.Hour.ToString + ":" + dtpDuracao.Value.Minute.ToString + "',1)", 1)
                End If
            End If
            'Recuperar o código acabado de inserir
            Dim codFl As Integer = ter(ligacao, "codFl", "select max(codfl) as codFl from filmes")
            'Associar as categorias selecionadas ao filme na posição codFl
            If lstFil_Cat.Items.Count > 0 Then
                For Each linha As DataRow In dtFil_Cat.Rows
                    acao("inserir", ligacao, "insert into aux_cat (codFl,codCat) values (" + codFl.ToString + "," + linha("codCat").ToString + ")", 0)
                Next
            End If
            'Associar os paises selecionados ao filme na posição codFl
            If lstFil_Pai.Items.Count > 0 Then
                For Each linha As DataRow In dtFil_Pai.Rows
                    acao("inserir", ligacao, "insert into aux_pai (codFl,codPs) values (" + codFl.ToString + "," + linha("codPs").ToString + ")", 0)
                Next
            End If
            ver_todos()
            'Limpo os objetos input do formulário
            LimparTudo()
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcurar.Click
        'Basicamente, isto pesquisa na base de dados
        Dim str_erro As String = ""
        Dim pquery As String = ""
        'Apenas as checkboxes de um campo com um certo são pesquisados. 
        'Ou seja, se eu selecionar o campo ordenado apenas procuro os registos com aquele ordenado mesmo que os outros campos tenham coisas escritas

        str_erro += Campo_Selecionado_proc("nome", "filmes", chknome, txtnome, rctNome, pquery)
        str_erro += Campo_Selecionado_proc("codcs", "filmes", chkClassificacao, cmbClassificacao, rctClassificacao, pquery)
        str_erro += Campo_Selecionado_proc("ano", "filmes", chkAno, mtbAno, rctAno, pquery)
        str_erro += Campo_Selecionado_proc("codr", "filmes", chkRealizador, cmbRealizador, rctRealizador, pquery)

        If chkDuracao.Checked Then
            Dim duracao_min As Integer = dtpDuracao.Value.Hour * 60 + dtpDuracao.Value.Minute
            If duracao_min > 4 * 60 Or duracao_min < 1 * 60 Then
                AlterarEstado(rctDuracao, "errar")
                str_erro += "Um filme não pode exceder as 4 horas nem ser menor que uma. "
            Else : pquery += " and filmes.duracao='" + dtpDuracao.Value.Hour.ToString + ":" + dtpDuracao.Value.Minute.ToString + "'"
                AlterarEstado(rctDuracao, "acertar")
            End If
        End If
        If chkImagem.Checked Then
            MessageBox.Show("Este programa não permite pesquisar por imagens, logo selecionar o campo imagem para a pesquisa é inócuo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If chkCategorias.Checked Then
            If lstFil_Cat.Items.Count > 0 Then
                For Each linha As DataRow In dtFil_Cat.Rows
                    pquery += " and categorias.codcat=" + linha("codCat").ToString
                Next
            Else
                str_erro += "Não selecionou nenhuma categoria. "
            End If
        End If

        'Associar os paises selecionados ao filme na posição codFl
        If chkPaises.Checked Then
            If lstFil_Pai.Items.Count > 0 Then
                For Each linha As DataRow In dtFil_Pai.Rows
                    pquery += " and paises.codps=" + linha("codPs").ToString
                Next
            Else
                str_erro += "Não selecionou nenhum país. "
            End If

        End If

        'No final deste if tenho 'parte' de um query

        'Caso o pquery esteja vazio significa que o utilizador não escolheu nenhum campo, ou seja "ERRRRRRRO"!!!!
        If str_erro = "" Then
            If pquery <> "" Then
                ver(dgvAtivado, "select filmes.codfl as codfl" &
                ", filmes.imagem as imagem" &
                ", filmes.nome as filme" &
                ", group_concat(DISTINCT categorias.nome) as categoria" &
                ", classificacoes.nome as classificacao" &
                ", filmes.ano as ano" &
                ", realizadores.nome as realizador" &
                ", group_concat(DISTINCT paises.nome) as paises" &
                ", hour(filmes.duracao) as horas" &
                ", minute(filmes.duracao) as minutos " &
                "from filmes " &
                "LEFT JOIN realizadores ON filmes.codr=realizadores.codr " &
                "LEFT JOIN aux_pai ON filmes.codfl=aux_pai.codfl " &
                "LEFT JOIN paises ON aux_pai.codps=paises.codps " &
                "LEFT JOIN aux_cat ON filmes.codfl=aux_cat.codfl " &
                "LEFT JOIN categorias ON aux_cat.codcat=categorias.codcat " &
                "INNER JOIN classificacoes ON classificacoes.codcs=filmes.codcs " &
                "where filmes.ativado = 1 " + pquery &
                "group by filmes.codfl")

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
        Dim codR As Integer
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String = ""
        Dim pcondicao1 As Boolean = False
        Dim pcondicao2 As Boolean = False
        str_erro += Campo_Selecionado_alte("nome", chknome, lblnome, txtnome, rctNome, pquery)
        str_erro += Campo_Selecionado_alte("codcs", chkClassificacao, lblClassificacao, cmbClassificacao, rctClassificacao, pquery)
        If chkAno.Checked Then
            If mtbAno.Text <> "" Then
                If mtbAno.TextLength = 4 And CInt(mtbAno.Text) >= 1900 And CInt(mtbAno.Text) <= DateTime.Now.Year + 1 Then
                    If pquery <> "" Then
                        pquery += ", "
                    End If
                    pquery += " ano=" + mtbAno.Text
                    pcondicao2 = True
                Else
                    AlterarEstado(rctAno, mtbAno, "errar")
                    str_erro += "O ano " + mtbAno.Text + "' não válido. "
                End If
            Else
                AlterarEstado(rctAno, mtbAno, "errar")
                str_erro += "Não escreveu um ano. "
            End If
        End If

        If chkDuracao.Checked Then
            Dim duracao_min As Integer = dtpDuracao.Value.Hour + dtpDuracao.Value.Minute * 60
            If duracao_min <= 4 * 60 And duracao_min >= 1 * 60 Then
                pquery += " duracao='" + dtpDuracao.Value.Hour.ToString + ":" + dtpDuracao.Value.Minute.ToString + "'"
                pcondicao2 = True
            Else
                AlterarEstado(rctDuracao, "errar")
                str_erro += "Um filme não pode exceder as 4 horas nem ser menor que uma. "
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
                pcondicao2 = True
            End If
        End If
        If chkCategorias.Checked Then
            If lstFil_Cat.Items.Count = 0 Then
                str_erro += "Não selecionou nenhuma categoria. "
            Else
                pcondicao1 = True
            End If
        End If
        If chkPaises.Checked Then
            If lstFil_Pai.Items.Count = 0 Then
                str_erro += "Não selecionou nenhum país. "
            Else
                pcondicao1 = True
            End If
        End If
        If chkRealizador.Checked Then
            averiguar = verificacao(rctRealizador, cmbRealizador)

            If averiguar = "" Then
                If str_erro = "" Then
                    If pquery <> "" Then
                        pquery += ","
                    End If
                    If cmbRealizador.SelectedValue > 0 Then
                        codR = cmbRealizador.SelectedValue
                        lblRealizador.Font = New Font(lblRealizador.Font, lblRealizador.Font.Style Or FontStyle.Strikeout)

                    Else
                        codR = novo_registo(ligacao, "codr", "realizadores", cmbRealizador)
                        If codR > 0 Then
                            MessageBox.Show("O realizador " + cmbRealizador.Text + " foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lblRealizador.Font = New Font(lblRealizador.Font, lblRealizador.Font.Style Or FontStyle.Strikeout)
                            encher(cmbRealizador, ligacao, "realizadores", "nome", "codr", "select codr, nome from realizadores")
                        Else
                            MessageBox.Show("O realizador '" + cmbRealizador.Text + "' não foi inserido", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            LimparTudo()
                            Exit Sub
                        End If
                    End If
                    pquery += " filmes.codr=" + codR.ToString
                    pcondicao2 = True
                End If
            Else
                str_erro += averiguar
            End If

        End If
        If str_erro = "" Then
            If pquery <> "" Or pcondicao1 = True Then
                If pcondicao2 Then
                    If chkImagem.Checked Then
                        acao_c_Imagem("alterar", ligacao, "update filmes set" + pquery + " where codfl=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, Image.FromFile(ofdImagem.FileName), 0)
                    Else
                        acao("alterar", ligacao, "update filmes set" + pquery + " where codfl=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 0)
                    End If
                End If

                If chkCategorias.Checked Then
                    acao("eliminar", ligacao, "delete from aux_cat where codfl=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 0)
                    'Associar as categorias selecionadas ao filme na posição codFl
                    If lstFil_Cat.Items.Count > 0 Then
                        For Each linha As DataRow In dtFil_Cat.Rows
                            acao("inserir", ligacao, "insert into aux_cat (codFl,codCat) values (" + dgvAtivado.CurrentRow.Cells(0).Value.ToString + "," + linha("codCat").ToString + ")", 0)
                        Next
                    End If
                End If

                If chkPaises.Checked Then
                    acao("eliminar", ligacao, "delete from aux_pai where codfl=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 0)
                    'Associar os paises selecionados ao filme na posição codFl
                    If lstFil_Pai.Items.Count > 0 Then
                        For Each linha As DataRow In dtFil_Pai.Rows
                            acao("inserir", ligacao, "insert into aux_pai (codFl,codPs) values (" + dgvAtivado.CurrentRow.Cells(0).Value.ToString + "," + linha("codPs").ToString + ")", 0)
                        Next
                    End If
                End If

                ver_todos()

                MessageBox.Show("O ato de alterar foi realizado com sucesso", "Ação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimparTudo()
            Else
                MessageBox.Show("Não selecionou nenhum campo para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click ' EM DESENVOLVIMENTO
        'Desativo os dados da linha selecionada na base de dados
        If dgvAtivado.SelectedRows.Count > 0 Then

            If Not dgvAtivado.CurrentRow.IsNewRow Then
                acao("desativar", ligacao, "update filmes set ativado=0 where codfl = " + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 1)

                ver_todos()

                'Isto muda o texto da label (que cada apontador de label está apontar)
                For a As Integer = 0 To CAMPOSC - 1
                    lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout) ' Tudo isto quando podia simplesmente utlizar "lbl(a).FontStyle.Strikeout=True"!
                Next
            End If

        End If
    End Sub

    Private Sub btnAtivar_Click(sender As Object, e As System.EventArgs) Handles btnAtivar.Click
        'Desativo os dados da linha selecionada na base de dados
        If dgvdesAtivado.SelectedRows.Count > 0 Then
            acao("ativar", ligacao, "update filmes set ativado=1 where codfl = " + dgvDesativado.CurrentRow.Cells(0).Value.ToString, 1)

            ver_todos()

            'Isto muda o texto da label (que cada apontador de label está apontar)
            For a As Integer = 0 To CAMPOSC - 1
                lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout) ' Tudo isto quando podia simplesmente utlizar "lbl(a).FontStyle.Strikeout=false"!
            Next
        End If
    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As System.EventArgs) Handles txtnome.TextChanged
        AlterarEstado(rctNome, txtnome, "restaurar")
    End Sub

    Private Sub cmbClassificacao_TextChanged(sender As Object, e As System.EventArgs) Handles cmbClassificacao.TextChanged
        AlterarEstado(rctClassificacao, "restaurar")
    End Sub

    Private Sub mtbAno_TextChanged(sender As Object, e As System.EventArgs) Handles mtbAno.TextChanged
        AlterarEstado(rctAno, mtbAno, "restaurar")
    End Sub

    Private Sub txtRealizador_TextChanged(sender As Object, e As System.EventArgs) Handles cmbRealizador.TextChanged
        AlterarEstado(rctRealizador, "restaurar")
    End Sub

    Private Sub dtpDuracao_TextChanged(sender As Object, e As System.EventArgs) Handles dtpDuracao.ValueChanged
        AlterarEstado(rctDuracao, "restaurar")
    End Sub

    Private Sub btnAdi_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi.Click
        If ofdImagem.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso ofdImagem.FileName <> "" Then
            Try
                pctImagem.BackgroundImage = Image.FromFile(ofdImagem.FileName)
                lblImgNome.Text = ofdImagem.SafeFileName
                btnAdi.Show()
            Catch ex As Exception
                MessageBox.Show("A imagem que escolheu está corrompida", "Imagem corrompida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRem_Click(sender As System.Object, e As System.EventArgs) Handles btnRem.Click
        lblImgNome.Text = ""
        ofdImagem.FileName = ""
        pctImagem.BackgroundImage = My.Resources.filmes
    End Sub

    Private Sub btnAdi_Cat_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi_Cat.Click
        Dim CategoriaSelecionada As String = CType(lstCategorias.SelectedItem, DataRowView)("nome").ToString
        Dim encontrou As Boolean = False
        For Each item As DataRowView In lstFil_Cat.Items 'Um loop que só finda quando chegar ao último item da listbox
            Dim istr As String = item("nome")
            If istr = CategoriaSelecionada Then
                encontrou = True
                Exit For
            End If
        Next
        If Not encontrou Then
            dtFil_Cat.Rows.Add(lstCategorias.SelectedValue, lstCategorias.GetItemText(lstCategorias.SelectedItem))
        Else
            MessageBox.Show("Não pode adicionar a categoria '" + lstCategorias.GetItemText(lstCategorias.SelectedItem) + "' novamente", "Repetição de categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnRet_Cat_Click(sender As System.Object, e As System.EventArgs) Handles btnRet_Cat.Click
        If lstFil_Cat.Items.Count > 0 Then
            dtFil_Cat.Rows(lstFil_Cat.SelectedIndex).Delete()
        Else
            MessageBox.Show("Não pode remover uma categoria sem que tenha inserido uma", "Falta de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAdi_Pai_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi_Pai.Click
        Dim PaisSelecionado As String = CType(lstPaises.SelectedItem, DataRowView)("nome").ToString
        Dim encontrou As Boolean = False
        For Each item As DataRowView In lstFil_Pai.Items 'Um loop que só finda quando chegar ao último item da listbox
            Dim istr As String = item("nome")
            If istr = PaisSelecionado Then
                encontrou = True
                Exit For
            End If
        Next
        If Not encontrou Then
            dtFil_Pai.Rows.Add(lstPaises.SelectedValue, lstPaises.GetItemText(lstPaises.SelectedItem))
        Else
            MessageBox.Show("Não pode adicionar o país '" + lstPaises.GetItemText(lstPaises.SelectedItem) + "' novamente", "Repetição de categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnRet_Pai_Click(sender As System.Object, e As System.EventArgs) Handles btnRet_Pai.Click
        If lstFil_Pai.Items.Count > 0 Then
            dtFil_Pai.Rows(lstFil_Pai.SelectedIndex).Delete()
        Else
            MessageBox.Show("Não pode remover um país sem que tenha inserido um", "Falta de paises", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNovoPai_Click(sender As System.Object, e As System.EventArgs) Handles btnNovoPai.Click
        Dim Pais As String = InputBox("Digite, dentro da caixa branca, o nome do país que deseja inserir.", "Inserir País")
        If Pais <> "" Then
            If Pais(0) <> " " Then
                Dim codPs As Integer = ter(ligacao, "codps", "select codps from paises where nome='" + Pais + "'")
                If codPs = 0 Then
                    'Inserir o novo pais
                    acao("inserir", ligacao, "insert into paises (nome) values ('" + Pais + "')", 0)

                    'Descobrir o codPs desse pais
                    codPs = ter(ligacao, "codps", "select codps from paises where nome='" + Pais + "'")

                    'Associá-la aos registos existentes
                    encher(lstPaises, ligacao, "paises", "nome", "codps", "select codps, nome from paises")
                    lstPaises.SelectedValue = codPs
                    dtFil_Pai.Rows.Add(lstPaises.SelectedValue, lstPaises.GetItemText(lstPaises.SelectedItem))
                    If codPs > 0 Then
                        MessageBox.Show("O país '" + Pais + "' foi inserido com sucesso.", "Insersão bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("O país '" + Pais + "' não foi inserido", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    lstPaises.SelectedValue = codPs
                    MessageBox.Show("O país '" + Pais + "' já se encontra na base de dados. Veja-o selecionado na lista.", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("O primeiro caracter não pode ser espaço", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Deixou a caixa de texto em branco", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmbClassificacao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbClassificacao.KeyPress
        e.Handled = True
    End Sub
End Class