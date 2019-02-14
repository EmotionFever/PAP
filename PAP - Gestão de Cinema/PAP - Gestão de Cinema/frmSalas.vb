Imports MySql.Data.MySqlClient
Public Class frmSalas
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Public Const CAMPOSC As Integer = 4
    Dim lbl(CAMPOSC) As Label
    Const DIMACOES As Integer = 100
    Dim ds As DataSet = New DataSet
    Dim dsDesa As DataSet = New DataSet

    Private Sub tbc1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tbc1.SelectedIndexChanged
        If tbc1.SelectedIndex = 0 Then
            pnlProibicao.Hide()
            btnInserir.Enabled = True
            If dgvAtivado.SelectedRows.Count > 0 Then
                btnAlterar.Enabled = True
                btnDesativar.Enabled = True
                For a As Integer = 0 To CAMPOSC - 1
                    lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout)
                    lbl(a).Text = dgvAtivado.CurrentRow.Cells(a + 1).Value.ToString
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
                    lbl(a).Text = dgvDesativado.CurrentRow.Cells(a + 1).Value.ToString
                Next
            End If
            btnAlterar.Enabled = False
            btnDesativar.Enabled = False
            btnDesativar.Hide()
        End If
    End Sub

    Private Sub mostrar_salas(dgv As DataGridView, ByRef ligacao As MySqlConnection, ByRef ds As DataSet, ByVal nome_tabela As String, ByVal chave_primaria As String, ByVal query As String) 'DatagGrids
        Dim adapter As New MySqlDataAdapter
        Try
            adapter.SelectCommand = New MySqlCommand
            adapter.SelectCommand.Connection = ligacao

            adapter.SelectCommand.CommandText = query

            ds.Clear()
            ligacao.Open()
            adapter.Fill(ds, nome_tabela)
            ligacao.Close()

            dgv.AutoGenerateColumns = True
            dgv.DataSource = ds
            dgv.DataMember = nome_tabela
            dgv.Columns.Item(chave_primaria).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro a Mostrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
    End Sub

    Sub ver()
        'DataGridView Ativado
        mostrar_salas(dgvAtivado, ligacao, ds, "salas", "codS", "select salas.cods as cods, salas.nome as nome, tipos.nome as tipo, max(coluna) as colunas, max(codln) as linhas " &
                                    "from salas, lugares, tipos where salas.cods=lugares.cods and salas.codt=tipos.codt and salas.ativado=1 group by salas.cods")

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False


        'DataGridView DESAtivado
        mostrar_salas(dgvDesativado, ligacao, dsDesa, "salas", "codS", "select salas.cods as cods, salas.nome as nome, tipos.nome as tipo, max(coluna) as colunas, max(codln) as linhas " &
                                        "from salas, lugares, tipos where salas.cods=lugares.cods and salas.codt=tipos.codt and salas.ativado=0 group by salas.cods")

        'Covém desativar estes botões
        btnAtivar.Enabled = False
    End Sub

    Private Sub frmSalas_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        pnlProibicao.Location = New Point(0, 3)
        btnDesativar.Enabled = False
        btnAtivar.Enabled = False
        btnAlterar.Enabled = False

        ver()

        lbl(0) = lblnome
        lbl(1) = lblTipo
        lbl(2) = lblColunas
        lbl(3) = lblLinhas

        'Aqui, encho a combobox com dados para o utilizador escolher
        encher(cmbtipo, ligacao, "tipos", "nome", "codt", "select codt, nome from tipos")
        cmbtipo.Text = ""
        nmrLinhas.Maximum = ter(ligacao, "max", "select max(codln) as max from linhas")
    End Sub

    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 7)
        CtrL_MenuCine.Sincronizar_permissoes({btnProcurar}, {btnAlterar, pnlAtivar}, {btnInserir})
        If Not (btnProcurar.Visible Or btnAlterar.Visible) Then
            tbc1.Hide()
        End If
    End Sub

    Private Sub dgvAtivado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAtivado.CellClick
        ' Quando o utilizador clica numa célula do DGV este código seleciona a linha toda
        Try
            Dim i As Integer = dgvAtivado.CurrentCell.RowIndex
            dgvAtivado.Rows(i).Selected = True

            'Como foi selecionada uma linha posso (re)ativar os botões apagar e alterar
            btnDesativar.Enabled = True
            btnAlterar.Enabled = True

        Catch ex As Exception
            btnDesativar.Enabled = False
            btnAlterar.Enabled = False
        End Try

        'Tiro o rasurado caso esteja a mostrar os clientes ativados senão  e coloco os valores da linha selecionada nas labels
        For a As Integer = 0 To CAMPOSC - 1
            lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout)
            lbl(a).Text = dgvAtivado.CurrentRow.Cells(a + 1).Value.ToString
        Next
    End Sub

    Private Sub dgvDesativado_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDesativado.CellClick
        ' Quando o utilizador clica numa célula do DGV este código seleciona a linha toda
        Try
            Dim i As Integer = dgvDesativado.CurrentCell.RowIndex
            dgvDesativado.Rows(i).Selected = True
            btnAtivar.Enabled = True
        Catch ex As Exception
            btnAtivar.Enabled = False
        End Try

        'Tiro o rasurado caso esteja a mostrar os clientes ativados senão coloco os valores da linha selecionada nas labels
        For a As Integer = 0 To CAMPOSC - 1
            lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout)
            lbl(a).Text = dgvDesativado.CurrentRow.Cells(a + 1).Value.ToString
        Next
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim str_erro As String = ""
        If txtnome.Text <> "" Then
            If ter(ligacao, "quant", "select count(*) as quant from salas where nome='" + txtnome.Text + "'") > 0 Then
                AlterarEstado(rctNome, txtnome, "errar")
                str_erro += "O nome que escreveu já está a ser usado. "
            End If
        Else
            AlterarEstado(rctNome, txtnome, "errar")
            str_erro += "Não escreveu um nome. "
        End If
        str_erro += verificacao(rctTipo, cmbtipo)
        If nmrLinhas.Value > ter(ligacao, "quant", "select count(*) as quant from linhas") Then
            str_erro += " O número de linhas que digitou ultrapassa o limite da base de dados. "
            AlterarEstado(rctLinhas, nmrLinhas, "errar")
        End If

        If str_erro = "" Then
            Dim cod As Integer = 0
            'Inserir a nova sala
            acao("inserir", ligacao, "insert into salas (nome,codt,ativado) " &
            "values ('" + txtnome.Text + "'," + cmbtipo.SelectedValue.ToString + ",1)", 1)

            'Descobrir o cods dessa sala
            cod = ter(ligacao, "cods", "select cods from salas where nome='" + txtnome.Text + "'")

            For x As Integer = 1 To nmrColunas.Value
                For y As Integer = 1 To nmrLinhas.Value
                    acao("inserir", ligacao, "insert into lugares (cods,coluna,codln) " &
                         "values (" + cod.ToString + ", " + x.ToString + "," + y.ToString + ")", 0)
                Next
            Next

            LimparTudo()

            'Volto a mostrar a tabela, desta vez, atualizada.
            ver()
        Else
            MessageBox.Show(str_erro, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcurar.Click

        'Basicamente, isto pesquisa na datagridview
        Dim str_erro As String = ""
        Dim pquery As String = ""

        'Apenas as checkboxes de um campo com um certo são pesquisados. 
        'Ou seja, se eu selecionar o campo ordenado apenas procuro os registos com aquele ordenado mesmo que os outros campos tenham coisas escritas

        str_erro += Campo_Selecionado_proc("nome", "salas", chknome, txtnome, rctNome, pquery)

        str_erro += Campo_Selecionado_proc("codt", "salas", chktipo, cmbtipo, rctTipo, pquery)

        If chkcolunas.Checked Then
            pquery += " and max(lugares.coluna)=" + nmrColunas.Value.ToString
        End If

        If chklinhas.Checked Then
            pquery += " and max(lugares.codln)=" + nmrLinhas.Value.ToString
        End If

        'No final deste if tenho 'parte' de um query

        'Caso o pquery esteja vazio significa que o utilizador não escolheu nenhum campo, ou seja "ERRRRRRRO"!!!!
        If str_erro = "" Then
            If pquery <> "" Then
                Dim dv As DataView
                dv = New DataView(ds.Tables(0), pquery.Remove(0, 5).Replace("salas.", ""), "cods asc", DataViewRowState.CurrentRows)
                dgvAtivado.DataSource = dv
                dgvAtivado.Columns.Item("cods").Visible = False
                'Como fiquei sem nenhum linha selecionada tenho de desativar os botões
                btnDesativar.Enabled = False
                btnAlterar.Enabled = False
            Else
                MessageBox.Show("Não selecionou nenhum campo para a pesquisa", "Sem campo para pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim mensagem As String = ""

        If dgvAtivado.SelectedRows.Count > 0 Then
            'Linha do Lugar Mais Perto do Fim da Coluna
            Dim llmpfc As Integer = ter(ligacao, "codln", "select max(codln) as codln from bilhetes, lugares " &
            "where bilhetes.codl = lugares.codl " &
            "and lugares.cods=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString)

            'Coluna do Lugar Mais Perto do Fim da Linha
            Dim clmpfl As Integer = ter(ligacao, "coluna", "select max(coluna) as coluna from bilhetes, lugares " &
            "where bilhetes.codl = lugares.codl " &
            "and lugares.cods=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString)

            ' A posição 0 fica com o valor da BD enquanto a 1 fica com o inserido pelo utlizador
            Dim linhas(1), colunas(1) As Integer
            linhas(0) = ter(ligacao, "linhas", "select max(codln) as linhas from lugares where cods=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString)
            If chklinhas.Checked Then
                If nmrLinhas.Value <= llmpfc Then
                    str_erro += "Existe um lugar associado a um bilhete vendido na linha " + ter_str(ligacao, "linha", "select l.nome as linha from linhas l where l.codln=" + llmpfc.ToString) + " (" + llmpfc.ToString + "). " &
                    "Portanto, a sala '" + dgvAtivado.CurrentRow.Cells(1).Value.ToString + "' pode ter no mínimo " + (llmpfc + 1).ToString + " linhas. "
                    AlterarEstado(rctLinhas, nmrLinhas, "errar")
                Else
                    linhas(1) = nmrLinhas.Value
                    AlterarEstado(rctLinhas, nmrLinhas, "acertar")
                End If
            Else
                linhas(1) = linhas(0)
            End If
            colunas(0) = ter(ligacao, "colunas", "select max(coluna) as colunas from lugares where cods=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString)
            If chkcolunas.Checked Then
                If nmrColunas.Value <= clmpfl Then
                    str_erro += "Existe um lugar associado a um bilhete vendido na coluna " + clmpfl.ToString + ". " &
                    "Portanto, a sala '" + dgvAtivado.CurrentRow.Cells(1).Value.ToString + "' pode ter no mínimo " + (clmpfl + 1).ToString + " colunas. "
                    AlterarEstado(rctColunas, nmrColunas, "errar")
                Else
                    colunas(1) = nmrColunas.Value
                    AlterarEstado(rctColunas, nmrColunas, "acertar")
                End If
            Else
                colunas(1) = colunas(0)
            End If

            str_erro += Campo_Selecionado_alte("nome", chknome, lbl(0), txtnome, rctNome, pquery)
            str_erro += Campo_Selecionado_alte("codt", chktipo, lbl(3), cmbtipo, rctTipo, pquery)

            If str_erro = "" Then
                For x As Integer = Math.Max(colunas(0), colunas(1)) To 1 Step -1
                    For y As Integer = Math.Max(linhas(0), linhas(1)) To 1 Step -1
                        If x > colunas(1) Or y > linhas(1) Then
                            'Apagar esse lugar
                            acao("eliminar", ligacao, "delete from lugares where coluna=" + x.ToString + " and codln=" + y.ToString + " and cods=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 0)
                        Else
                            If x > colunas(0) Or y > linhas(0) Then
                                'Criar esse lugar
                                acao("inserir", ligacao,
                                     "insert into lugares (cods,coluna,codln) values " &
                                     "(" + dgvAtivado.CurrentRow.Cells(0).Value.ToString + ", " + x.ToString + "," + y.ToString + ")", 0)
                            End If
                            'Else o lugar já foi criado antes
                        End If
                    Next
                Next
                If chknome.Checked Or chktipo.Checked Or chkcolunas.Checked Or chklinhas.Checked Then
                    If pquery <> "" Then
                        acao("alterar", ligacao, "update salas set" + pquery + " where cods=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 0)
                    End If

                    MessageBox.Show("A sala foi alterada com sucesso", "Alteração bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ver()

                    LimparTudo()
                Else
                    MessageBox.Show("Não selecionou nenhum campo para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click
        'Desativo os dados da linha selecionada na base de dados
        If dgvAtivado.SelectedRows.Count > 0 Then

            If Not dgvAtivado.CurrentRow.IsNewRow Then
                acao("desativar", ligacao, "update salas set ativado=0 where cods = " + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 1)

                ver()

                'Isto muda o texto da label (que cada apontador de label está apontar)
                For a As Integer = 0 To CAMPOSC - 1
                    lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout) ' Tudo isto quando podia simplesmente utlizar "lbl(a).FontStyle.Strikeout=True"!
                Next
            End If

        End If
    End Sub

    Private Sub btnAtivar_Click(sender As Object, e As System.EventArgs) Handles btnAtivar.Click
        'Desativo os dados da linha selecionada na base de dados
        If dgvDesativado.SelectedRows.Count > 0 Then
            acao("ativar", ligacao, "update salas set ativado=1 where cods = " + dgvDesativado.CurrentRow.Cells(0).Value.ToString, 1)

            ver()

            'Isto muda o texto da label (que cada apontador de label está apontar)
            For a As Integer = 0 To CAMPOSC - 1
                lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout) ' Tudo isto quando podia simplesmente utlizar "lbl(a).FontStyle.Strikeout=false"!
            Next
        End If
    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As System.EventArgs) Handles txtnome.TextChanged
        AlterarEstado(rctNome, txtnome, "restaurar")
    End Sub

    Private Sub nmrcolunas_TextChanged(sender As Object, e As System.EventArgs) Handles nmrColunas.ValueChanged
        AlterarEstado(rctColunas, nmrColunas, "restaurar")
    End Sub

    Private Sub nmrlinhas_TextChanged(sender As Object, e As System.EventArgs) Handles nmrLinhas.ValueChanged
        AlterarEstado(rctLinhas, nmrLinhas, "restaurar")
    End Sub

    Private Sub cmbtipo_TextChanged(sender As Object, e As System.EventArgs) Handles cmbtipo.SelectedValueChanged
        AlterarEstado(rctTipo, "restaurar")
    End Sub

    Private Sub LimparTudo()
        'Limpo os objetos input do formulário
        txtnome.Text = ""
        AlterarEstado(rctNome, txtnome, "restaurar")
        chknome.Checked = False

        nmrColunas.Value = 1
        AlterarEstado(rctColunas, nmrColunas, "restaurar")
        chkcolunas.Checked = False

        nmrLinhas.Text = 1
        AlterarEstado(rctLinhas, nmrLinhas, "restaurar")
        chklinhas.Checked = False

        cmbtipo.Text = ""
        AlterarEstado(rctTipo, "restaurar")
        chktipo.Checked = False
    End Sub

    Private Sub frmSalas_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub

    Private Sub cmbTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipo.KeyPress
        e.Handled = True
    End Sub
End Class