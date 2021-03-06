﻿Imports MySql.Data.MySqlClient
Public Class frmClientes
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Public Const CAMPOSC As Integer = 5
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

    Sub ver()
        'DataGridView Ativado
        mostrar(dgvAtivado, ligacao, "clientes", "codC", "select codc, clientes.nome, nif, rua, localidades.nome as localidade, telemovel " &
                                            "from clientes left join localidades on localidades.codlo=clientes.codlo where ativado=1")

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False


        'DataGridView DESAtivado
        mostrar(dgvDesativado, ligacao, "clientes", "codC", "select codc, clientes.nome, nif, rua, localidades.nome as localidade, telemovel " &
                                            "from clientes left join localidades on localidades.codlo=clientes.codlo where ativado=0")

        'Covém desativar estes botões
        btnAtivar.Enabled = False
    End Sub

    Private Sub LimparTudo()
        'Limpo os objetos input do formulário
        txtnome.Text = ""
        AlterarEstado(rctNome, txtnome, "restaurar")
        chknome.Checked = False

        mtbNIF.Text = ""
        AlterarEstado(rctNIF, mtbNIF, "restaurar")
        chkNIF.Checked = False

        txtRua.Text = ""
        AlterarEstado(rctRua, txtRua, "restaurar")
        chkRua.Checked = False

        cmblocalidade.Text = ""
        cmblocalidade.SelectedValue = 0
        AlterarEstado(rctLocalidade, "restaurar")
        chkLocalidade.Checked = False

        mtbTlm.Text = ""
        AlterarEstado(rctTlm, mtbTlm, "restaurar")
        chkTlm.Checked = False
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        pnlProibicao.Location = New Point(0, 3)
        btnDesativar.Enabled = False
        btnAtivar.Enabled = False
        btnAlterar.Enabled = False

        ver()

        lbl(0) = lblnome
        lbl(1) = lblNIF
        lbl(2) = lblRua
        lbl(3) = lblLocalidade
        lbl(4) = lblTlm

        'Aqui, encho a combobox com dados para o utilizador escolher
        encher(cmblocalidade, ligacao, "localidades", "nome", "codlo", "select codlo, nome from localidades")
        cmblocalidade.Text = ""
        cmblocalidade.SelectedValue = 0
    End Sub

    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 2)
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
        Dim codLo As String
        Dim str_erro As String = ""
        str_erro += verificacao(rctNome, txtnome)
        str_erro += verificacao(rctNIF, mtbNIF)
        If txtRua.Text <> "" Then '!!!!!!!!!!!!!!!!! Este campo não é obrigatório !!!!!!!!!!!!!!!!!!
            str_erro += verificacao(rctRua, txtRua)
        End If
        If mtbTlm.Text <> "" Then
            str_erro += verificacao(rctTlm, mtbTlm)
        End If
        If str_erro = "" Then
            If cmblocalidade.Text <> "" Then
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
            Else
                codLo = ""
            End If
            If codLo = "" Then
                acao("inserir", ligacao, "insert into clientes (nome,NIF,rua,telemovel,ativado) " &
                "values ('" + txtnome.Text + "', '" + mtbNIF.Text + "', '" + txtRua.Text + "','" + mtbTlm.Text + "',1)", 1)
            Else
                acao("inserir", ligacao, "insert into clientes (nome,NIF,rua,codlo,telemovel,ativado) " &
                "values ('" + txtnome.Text + "', '" + mtbNIF.Text + "', '" + txtRua.Text + "', " + codLo + ",'" + mtbTlm.Text + "',1)", 1)
            End If

            LimparTudo()

            'Volto a mostrar a tabela, desta vez, atualizada.
            ver()
        Else
            MessageBox.Show(str_erro, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcurar.Click
        'Basicamente, isto pesquisa na base de dados
        Dim str_erro As String = ""
        Dim pquery As String = ""

        'Apenas as checkboxes de um campo com um certo são pesquisados. 
        'Ou seja, se eu selecionar o campo ordenado apenas procuro os registos com aquele ordenado mesmo que os outros campos tenham coisas escritas

        str_erro += Campo_Selecionado_proc("nome", "clientes", chknome, txtnome, rctNome, pquery)
        str_erro += Campo_Selecionado_proc("NIF", "clientes", chkNIF, mtbNIF, rctNIF, pquery)
        str_erro += Campo_Selecionado_proc("rua", "clientes", chkRua, txtRua, rctRua, pquery)
        str_erro += Campo_Selecionado_proc("codlo", "clientes", chkLocalidade, cmblocalidade, rctLocalidade, pquery)
        str_erro += Campo_Selecionado_proc("telemovel", "clientes", chkTlm, mtbTlm, rctTlm, pquery)

        'No final deste if tenho 'parte' de um query

        'Caso o pquery esteja vazio significa que o utilizador não escolheu nenhum campo, ou seja "ERRRRRRRO"!!!!
        If str_erro = "" Then
            If pquery <> "" Then
                mostrar(dgvAtivado, ligacao, "clientes", "codC", "select codc, clientes.nome, nif, rua, localidades.nome as localidade, telemovel " &
                                            "from clientes left join localidades on localidades.codlo=clientes.codlo where ativado=1" + pquery)
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
        Dim codlo As Integer
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String = ""
        If dgvAtivado.SelectedRows.Count > 0 Then
            If Not dgvAtivado.CurrentRow.IsNewRow Then

                str_erro += Campo_Selecionado_alte("nome", chknome, lbl(0), txtnome, rctNome, pquery)
                str_erro += Campo_Selecionado_alte("NIF", chkNIF, lbl(1), mtbNIF, rctNIF, pquery)
                str_erro += Campo_Selecionado_alte("rua", chkRua, lbl(2), txtRua, rctRua, pquery)
                str_erro += Campo_Selecionado_alte("telemovel", chkTlm, lbl(4), mtbTlm, rctTlm, pquery)
                If chkLocalidade.Checked Then
                    averiguar = verificacao(rctLocalidade, cmblocalidade)
                    If averiguar = "" Then
                        If str_erro = "" Then
                            If pquery <> "" Then
                                pquery += ","
                            End If
                            If cmblocalidade.SelectedValue IsNot Nothing Then
                                codlo = cmblocalidade.SelectedValue
                                lbl(3).Font = New Font(lbl(3).Font, lbl(3).Font.Style Or FontStyle.Strikeout)
                            Else
                                codlo = novo_registo(ligacao, "codlo", "localidades", cmblocalidade)
                                If codlo > 0 Then
                                    MessageBox.Show("A localidade " + cmblocalidade.Text + " foi inserida sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    encher(cmblocalidade, ligacao, "localidades", "nome", "codlo", "select codlo, nome from localidades")
                                    lbl(3).Font = New Font(lbl(3).Font, lbl(3).Font.Style Or FontStyle.Strikeout)
                                Else
                                    MessageBox.Show("A localidade " + cmblocalidade.Text + " não foi inserida", "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    LimparTudo()
                                    Exit Sub
                                End If
                            End If
                            pquery += " clientes.codlo=" + codlo.ToString
                        End If
                    Else
                        str_erro += averiguar
                    End If
                End If

                If str_erro = "" Then
                    If pquery <> "" Then
                        acao("alterar", ligacao, "update clientes set" + pquery + " where codc=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 1)

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
                acao("desativar", ligacao, "update clientes set ativado=0 where codc = " + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 1)

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
            acao("ativar", ligacao, "update clientes set ativado=1 where codc = " + dgvDesativado.CurrentRow.Cells(0).Value.ToString, 1)

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

    Private Sub mtbNIF_TextChanged(sender As Object, e As System.EventArgs) Handles mtbNIF.TextChanged
        AlterarEstado(rctNIF, mtbNIF, "restaurar")
    End Sub

    Private Sub txtRua_TextChanged(sender As Object, e As System.EventArgs) Handles txtRua.TextChanged
        AlterarEstado(rctRua, txtRua, "restaurar")
    End Sub

    Private Sub cmblocalidade_TextChanged(sender As Object, e As System.EventArgs) Handles cmblocalidade.TextChanged
        AlterarEstado(rctLocalidade, "restaurar")
    End Sub

    Private Sub mtbTlm_TextChanged(sender As Object, e As System.EventArgs) Handles mtbTlm.TextChanged
        AlterarEstado(rctTlm, mtbTlm, "restaurar")
    End Sub



    Private Sub frmClientes_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub
End Class