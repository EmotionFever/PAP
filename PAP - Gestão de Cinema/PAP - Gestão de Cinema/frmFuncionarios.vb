Imports MySql.Data.MySqlClient
Public Class frmFuncionarios
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Public Const CAMPOSC As Integer = 8
    Dim lbl(CAMPOSC) As Label

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

    Private Sub LimparTudo()
        'Limpo os objetos input do formulário
        txtnome.Text = ""
        AlterarEstado(rctNome, txtnome, "restaurar")
        chknome.Checked = False

        cmblocalidade.Text = ""
        AlterarEstado(rctLocalidade, cmblocalidade, "restaurar")
        chklocalidade.Checked = False

        dtpDatanasc.Value = DateTime.Now
        AlterarEstado(rctDatanasc, "restaurar")
        chkdatanasc.Checked = False

        txtrua.Text = ""
        AlterarEstado(rctRua, txtrua, "restaurar")
        chkRua.Checked = False

        txtordenado.Text = ""
        AlterarEstado(rctOrdenado, txtordenado, "restaurar")
        chkOrdenado.Checked = False

        mtbTlm.Text = ""
        AlterarEstado(rctTlm, mtbTlm, "restaurar")
        chkTlm.Checked = False

        txtUtl.Text = ""
        AlterarEstado(rctUtl, txtUtl, "restaurar")
        chkUtl.Checked = False

        cmbEncargo.Text = ""
        AlterarEstado(rctEnc, cmbEncargo, "restaurar")
        chkEncargo.Checked = False
    End Sub

    Private Sub ver()
        'DataGridView empregado
        mostrar(dgvAtivado, ligacao, "funcionarios", "codf", "select codf, funcionarios.nome, encargos.nome as encargo, localidades.nome as localidade, telemovel, TIMESTAMPDIFF(year, datanasc, CURDATE()) as idade, rua, ordenado, username " &
                                            "from funcionarios, localidades, encargos where encargos.code=funcionarios.code and localidades.codlo=funcionarios.codlo and empregado=1")

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False


        'DataGridView DESempregado
        mostrar(dgvDesativado, ligacao, "funcionarios", "codf", "select codf, funcionarios.nome, encargos.nome as encargo, localidades.nome as localidade, telemovel, TIMESTAMPDIFF(year, datanasc, CURDATE()) as idade, rua, ordenado, username " &
                                            "from funcionarios, localidades, encargos where encargos.code=funcionarios.code and localidades.codlo=funcionarios.codlo and empregado=0")

        'Covém desativar estes botões
        btnAtivar.Enabled = False
    End Sub

    Private Sub frmFuncionarios_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub

    Private Sub frmFuncionarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pnlProibicao.Location = New Point(0, 3)
        btnDesativar.Enabled = False
        btnAtivar.Enabled = False
        btnAlterar.Enabled = False

        ver()

        lbl(0) = lblnome
        lbl(1) = lblEncargo
        lbl(2) = lblLocalidade
        lbl(3) = lblTlm
        lbl(4) = lblidade
        lbl(5) = lblRua
        lbl(6) = lblOrdenado
        lbl(7) = lblUtl


        'Aqui, encho a combobox com dados para o utilizador escolher
        encher(cmbEncargo, ligacao, "encargos", "nome", "code", "select code, nome from encargos where ativado=1")
        cmbEncargo.Text = ""

        encher(cmblocalidade, ligacao, "localidades", "nome", "codlo", "select codlo, nome from localidades")
        cmblocalidade.Text = ""
    End Sub

    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 3)
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

        'Tiro o rasurado caso esteja a mostrar os funcionarios empregados senão  e coloco os valores da linha selecionada nas labels
        For a As Integer = 0 To CAMPOSC - 1
            lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout)
            lbl(a).Text = dgvAtivado.CurrentRow.Cells(a + 1).Value.ToString
        Next
    End Sub

    Private Sub dgvdesAtivado_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDesativado.CellClick
        ' Quando o utilizador clica numa célula do DGV este código seleciona a linha toda
        Try
            Dim i As Integer = dgvdesAtivado.CurrentCell.RowIndex
            dgvdesAtivado.Rows(i).Selected = True
            btnAtivar.Enabled = True
        Catch ex As Exception
            btnAtivar.Enabled = False
        End Try

        'Tiro o rasurado caso esteja a mostrar os funcionarios empregados senão coloco os valores da linha selecionada nas labels
        For a As Integer = 0 To CAMPOSC - 1
            lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout)
            lbl(a).Text = dgvdesAtivado.CurrentRow.Cells(a + 1).Value.ToString
        Next
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim codLo As Integer
        Dim str_erro As String = ""
        str_erro += verificacao(rctUtl, txtUtl)
        If str_erro = "" Then
            If ter(ligacao, "quantidade", "select count(codf) as quantidade from funcionarios where username='" + txtUtl.Text + "'") > 0 Then
                str_erro += "O " + txtUtl.Tag + " que escreveu já está em uso. "
                AlterarEstado(rctUtl, txtUtl, "errar")
            End If
        End If
        str_erro += verificacao(rctNome, txtnome)
        str_erro += verificacao(rctLocalidade, cmblocalidade)
        str_erro += verificacao(rctTlm, mtbTlm)

        str_erro += verificacao(rctEnc, cmbEncargo)
        If DateDiff(DateInterval.Year, dtpDatanasc.Value.Date, Now) >= 16 Then
            AlterarEstado(rctDatanasc, "acertar")
        Else
            AlterarEstado(rctDatanasc, "errar")
            str_erro += "O funcionário tem de ter mais de 16 anos para trabalhar. "
        End If
        If txtrua.Text <> "" Then
            str_erro += verificacao(rctRua, txtrua)
        End If
        If txtordenado.Text <> "" Then
            If IsNumeric(txtordenado.Text) Then
                If CInt(txtordenado.Text) < 557 Then
                    str_erro += "O ordenado mínimo é de 557 €. "
                    AlterarEstado(rctOrdenado, txtordenado, "errar")
                Else
                    AlterarEstado(rctOrdenado, txtordenado, "acertar")
                End If
            Else
                str_erro += "O campo ordenado não tem só números. "
                AlterarEstado(rctOrdenado, txtordenado, "errar")
            End If
        Else
            str_erro += "O campo ordenado está vazio. "
            AlterarEstado(rctOrdenado, txtordenado, "errar")
        End If

        If str_erro = "" Then
            If cmblocalidade.SelectedValue IsNot Nothing Then
                codLo = cmblocalidade.SelectedValue
            Else
                codLo = novo_registo(ligacao, "codlo", "localidades", cmblocalidade)
                If codLo > 0 Then
                    MessageBox.Show("A localidade '" + cmblocalidade.Text + "' foi inserida sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("A localidade '" + cmblocalidade.Text + "' não foi inserida", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            acao("inserir", ligacao, "insert into funcionarios (nome,codlo,datanasc,rua,ordenado,telemovel,username,codE,empregado) " &
            "values ('" + txtnome.Text + "', " + codLo.ToString + "," &
            "'" + dtpDatanasc.Value.Year.ToString + "-" + dtpDatanasc.Value.Month.ToString + "-" + dtpDatanasc.Value.Day.ToString + "'," &
            "'" + txtrua.Text + "'," + txtordenado.Text + ",'" + mtbTlm.Text + "','" + txtUtl.Text + "'," + cmbEncargo.SelectedValue.ToString + ",1)", 1)
            LimparTudo()

            'Volto a mostrar a tabela, mas, desta vez, atualizada.
            ver()
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcurar.Click
        'Basicamente, isto pesquisa na base de dados
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String = ""

        'Apenas as checkboxes de um campo com um certo são pesquisados. 
        'Ou seja, se eu selecionar o campo ordenado apenas procuro os registos com aquele ordenado mesmo que os outros campos tenham coisas escritas

        str_erro += Campo_Selecionado_proc("nome", "funcionarios", chknome, txtnome, rctNome, pquery)
        str_erro += Campo_Selecionado_proc("codlo", "funcionarios", chklocalidade, cmblocalidade, rctLocalidade, pquery)
        If chkdatanasc.Checked Then
            If DateTime.Compare(dtpDatanasc.Value, DateTime.Today) < 16 Then
                AlterarEstado(rctDatanasc, "errar")
                str_erro += "O funcionário tem de ter mais de 16 anos para trabalhar. "
            Else
                AlterarEstado(rctDatanasc, "acertar")
                pquery += " and funcionarios.datanasc='" + dtpDatanasc.Value.Year.ToString + "-" + dtpDatanasc.Value.Month.ToString + "-" + dtpDatanasc.Value.Day.ToString + "'"
            End If
        End If
        str_erro += Campo_Selecionado_proc("rua", "funcionarios", chkRua, txtrua, rctRua, pquery)
        If chkOrdenado.Checked Then
            If txtordenado.Text <> "" Then
                If IsNumeric(txtordenado.Text) Then
                    If CInt(txtordenado.Text) < 557 Then
                        str_erro += "O ordenado mínimo é de 557 €. "
                        AlterarEstado(rctOrdenado, txtordenado, "errar")
                    Else
                        pquery += " and ordenado=" + txtordenado.Text
                        AlterarEstado(rctOrdenado, txtordenado, "acertar")
                    End If
                Else
                    str_erro += "O campo ordenado não tem só números. "
                    AlterarEstado(rctOrdenado, txtordenado, "errar")
                End If
            Else
                str_erro += "O campo ordenado está vazio. "
                AlterarEstado(rctOrdenado, txtordenado, "errar")
            End If
        End If

        str_erro += Campo_Selecionado_proc("telemovel", "funcionarios", chkTlm, mtbTlm, rctTlm, pquery)
        str_erro += Campo_Selecionado_proc("username", "funcionarios", chkUtl, txtUtl, rctUtl, pquery)
        str_erro += Campo_Selecionado_proc("codE", "funcionarios", chkEncargo, cmbEncargo, rctEnc, pquery)

        'No final deste if tenho 'parte' de um query

        'Caso o pquery esteja vazio significa que o utilizador não escolheu nenhum campo, ou seja "ERRRRRRRO"!!!!
        If str_erro = "" Then
            If pquery <> "" Then
                mostrar(dgvAtivado, ligacao, "funcionarios", "codf", "select codf, funcionarios.nome, encargos.nome as encargo, localidades.nome as localidade, telemovel, TIMESTAMPDIFF(year, datanasc, CURDATE()) as idade, rua, ordenado, username " &
                                            "from funcionarios, localidades, encargos where encargos.code=funcionarios.code and localidades.codlo=funcionarios.codlo and empregado=1" + pquery)

                'Como fiquei sem nenhuma linha selecionada tenho de desativar os botões
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
        Dim codlo As Integer
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String = ""
        If dgvAtivado.SelectedRows.Count > 0 Then
            If Not dgvAtivado.CurrentRow.IsNewRow Then

                str_erro += Campo_Selecionado_alte("nome", chknome, lbl(0), txtnome, rctNome, pquery)
                str_erro += Campo_Selecionado_alte("codE", chkEncargo, lbl(1), cmbEncargo, rctEnc, pquery)

                str_erro += Campo_Selecionado_alte("telemovel", chkTlm, lbl(3), mtbTlm, rctTlm, pquery)
                If chkdatanasc.Checked Then
                    If DateDiff(DateInterval.Year, dtpDatanasc.Value, Now) >= 16 Then
                        AlterarEstado(rctDatanasc, "acertar")
                        If pquery <> "" Then
                            pquery += ","
                        End If
                        pquery += " funcionarios.datanasc='" + dtpDatanasc.Value.Year.ToString + "-" + dtpDatanasc.Value.Month.ToString + "-" + dtpDatanasc.Value.Day.ToString + "'"
                        lbl(4).Font = New Font(lbl(4).Font, lbl(4).Font.Style Or FontStyle.Strikeout)
                    Else
                        AlterarEstado(rctDatanasc, "errar")
                        str_erro += "O funcionário tem de ter mais de 16 anos para trabalhar. "
                    End If
                End If
                str_erro += Campo_Selecionado_alte("rua", chkRua, lbl(5), txtrua, rctRua, pquery)
                If chkOrdenado.Checked Then
                    If txtordenado.Text <> "" Then
                        If IsNumeric(txtordenado.Text) Then
                            If CInt(txtordenado.Text) < 557 Then
                                str_erro += "O ordenado mínimo é de 557 €. "
                                AlterarEstado(rctOrdenado, txtordenado, "errar")
                            Else
                                If pquery <> "" Then
                                    pquery += ","
                                End If
                                pquery += " ordenado=" + txtordenado.Text
                                lbl(6).Font = New Font(lbl(6).Font, lbl(6).Font.Style Or FontStyle.Strikeout)
                                AlterarEstado(rctOrdenado, txtordenado, "acertar")
                            End If
                        Else
                            str_erro += "O campo ordenado não tem só números. "
                            AlterarEstado(rctOrdenado, txtordenado, "errar")
                        End If
                    Else
                        str_erro += "O campo ordenado está vazio. "
                        AlterarEstado(rctOrdenado, txtordenado, "errar")
                    End If
                End If
                If chkUtl.Checked Then
                    If ter(ligacao, "quant", "select count(codf) as quant from funcionarios where username='" + txtUtl.Text + "'") > 0 Then
                        str_erro += "O " + txtUtl.Tag + " que escreveu já está em uso. "
                        AlterarEstado(rctUtl, txtUtl, "errar")
                    Else
                        str_erro += Campo_Selecionado_alte("username", chkUtl, lbl(7), txtUtl, rctUtl, pquery)
                    End If
                End If
                If chklocalidade.Checked Then
                    averiguar = verificacao(rctLocalidade, cmblocalidade)
                    If averiguar = "" Then
                        If str_erro = "" Then
                            If pquery <> "" Then
                                pquery += ","
                            End If
                            If cmblocalidade.SelectedValue IsNot Nothing Then
                                codlo = cmblocalidade.SelectedValue
                                lbl(1).Font = New Font(lbl(2).Font, lbl(2).Font.Style Or FontStyle.Strikeout)
                            Else
                                codlo = novo_registo(ligacao, "codlo", "localidades", cmblocalidade)
                                If codlo > 0 Then
                                    MessageBox.Show("A localidade " + cmblocalidade.Text + " foi inserida sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    encher(cmblocalidade, ligacao, "localidades", "nome", "codlo", "select codlo, nome from localidades")
                                    lbl(1).Font = New Font(lbl(1).Font, lbl(1).Font.Style Or FontStyle.Strikeout)
                                Else
                                    MessageBox.Show("A localidade " + cmblocalidade.Text + " não foi inserida", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    LimparTudo()
                                    Exit Sub
                                End If
                            End If
                            pquery += " funcionarios.codlo=" + codlo.ToString
                        End If
                    Else
                        str_erro += averiguar
                    End If
                End If

                If str_erro = "" Then
                    If pquery <> "" Then
                        acao("alterar", ligacao, "update funcionarios set" + pquery + " where codf=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 1)

                        ver()

                        LimparTudo()
                    Else
                        MessageBox.Show("Não selecionou nenhum campo para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click ' EM DESENVOLVIMENTO
        'Desativo os dados da linha selecionada na base de dados
        If dgvAtivado.SelectedRows.Count > 0 Then

            If Not dgvAtivado.CurrentRow.IsNewRow Then
                acao("desativar", ligacao, "update funcionarios set empregado=0 where codf = " + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 1)

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
        If dgvdesAtivado.SelectedRows.Count > 0 Then
            acao("ativar", ligacao, "update funcionarios set empregado=1 where codf = " + dgvdesAtivado.CurrentRow.Cells(0).Value.ToString, 1)

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

    Private Sub cmblocalidade_TextChanged(sender As Object, e As System.EventArgs) Handles cmblocalidade.TextChanged
        AlterarEstado(rctLocalidade, "restaurar")
    End Sub

    Private Sub dtpDatanasc_ValueChanged(sender As Object, e As System.EventArgs) Handles dtpDatanasc.ValueChanged
        AlterarEstado(rctDatanasc, "restaurar")
    End Sub

    Private Sub txtRua_TextChanged(sender As Object, e As System.EventArgs) Handles txtrua.TextChanged
        AlterarEstado(rctRua, txtrua, "restaurar")
    End Sub

    Private Sub txtOrdenado_TextChanged(sender As Object, e As System.EventArgs) Handles txtordenado.TextChanged
        AlterarEstado(rctOrdenado, txtordenado, "restaurar")
    End Sub

    Private Sub mtbTlm_TextChanged(sender As Object, e As System.EventArgs) Handles mtbTlm.TextChanged
        AlterarEstado(rctTlm, mtbTlm, "restaurar")
    End Sub

    Private Sub txtUtl_TextChanged(sender As Object, e As System.EventArgs) Handles txtUtl.TextChanged
        AlterarEstado(rctUtl, txtUtl, "restaurar")
    End Sub

    Private Sub cmbencargo_TextChanged(sender As Object, e As System.EventArgs) Handles cmbEncargo.SelectedValueChanged
        AlterarEstado(rctEnc, cmbEncargo, "restaurar")
    End Sub

    Private Sub cmbEncargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEncargo.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnOutro_Click(sender As System.Object, e As System.EventArgs) Handles btnOutro.Click
        If ass(4).permissao(2) Then
            CtrL_MenuCine.IrParaEncargos()
        Else
            MessageBox.Show("Não tem permissão para inserir novos encargos", "Insersão impossível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class