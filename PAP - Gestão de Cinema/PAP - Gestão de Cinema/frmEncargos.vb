﻿Imports MySql.Data.MySqlClient
Public Class frmEncargos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    Dim dtTa_Enc As DataTable = New DataTable("Ta_Enc")
    Dim dsTa_Enc As DataSet = New DataSet
    Dim dtTa_Per(DIMTA - 2) As DataTable 'Todas as tabelas exceto a "tabela" FrmHome e FrmDefinicoes
    Dim dsTa_Per As DataSet = New DataSet
    Dim handler(3) As Boolean 'Isto resolve um erro relativamente ao mau funcionamento dos Remove Handlers do VB

    Private Sub tbc1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tbc1.SelectedIndexChanged
        If tbc1.SelectedIndex = 0 Then
            pnlProibicao.Hide()
            If lstEnc_Ativ.SelectedItem Is Nothing Then
                pnlInformacao.Show()
            Else
                pnlInformacao.Hide()
                btnAlterar.Enabled = True
                btnDesativar.Enabled = True
            End If
            btnDesativar.Show()
        End If
        If tbc1.SelectedIndex = 1 Then
            pnlProibicao.Show()
            If lstEnc_Desa.SelectedItem Is Nothing Then
                pnlInformacao.Show()
            Else
                pnlInformacao.Hide()
                btnAtivar.Enabled = True
            End If
            btnDesativar.Hide()
        End If
    End Sub

    Sub ver()
        'Mostrar Ativado
        handler(0) = False
        encher(lstEnc_Ativ, ligacao, "encargos", "nome", "codE", "select codE, nome from encargos where ativado=1")
        lstEnc_Ativ.ClearSelected()
        handler(0) = True

        'Covém desativar estes botões
        btnInserir.Enabled = True
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False
        btnAtivar.Enabled = False
        lstTa_Per.Tag = False
        lstTa_Enc.Tag = False
        txtnome.Text = ""
        txtnome.Tag = False
        If lstTa_Enc.Items.Count > 0 Then
            For Each item As DataRowView In lstTa_Enc.Items
                dtTa_Per(item("codTa") - 1).Clear()
            Next
            dtTa_Enc.Clear()
        End If

        'Mostrar DESAtivado
        handler(1) = False
        encher(lstEnc_Desa, ligacao, "encargos", "nome", "codE", "select codE, nome from encargos where ativado=0")
        lstEnc_Desa.ClearSelected()
        handler(1) = True
        pnlInformacao.Show()
    End Sub

    Private Sub frmEncargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pnlProibicao.Location = New Point(0, 0)
        'Insiro colunas ao DateTable
        dtTa_Enc.Columns.Add("codTa")
        dtTa_Enc.Columns.Add("nome")
        'Associo o DataSet à tabela do Datatable.
        dsTa_Enc.Tables.Add(dtTa_Enc)
        'Associo a ListBox ao DataSet.
        lstTa_Enc.DataSource = dsTa_Enc.Tables("Ta_Enc")
        lstTa_Enc.DisplayMember = "nome"
        lstTa_Enc.ValueMember = "codTa"
        handler(2) = True

        For x As Integer = 0 To (DIMTA - 2) - 1
            dtTa_Per(x) = New DataTable("Ta_Per")
            'Insiro colunas ao DateTable 
            dtTa_Per(x).Columns.Add("codPe")
            dtTa_Per(x).Columns.Add("nome")
        Next

        ver()
        AddHandler lstTa_Enc.SelectedIndexChanged, AddressOf SelecaoAlterada_Enc_Ta

        'Aqui, encho a listboxes com dados para o utilizador escolher
        encher(lstTabelas, ligacao, "tabelas", "nome", "codta", "select codta, nome from tabelas")
        encher(lstPermissoes, ligacao, "permissoes", "nome", "codpe", "select codpe, nome from permissoes")
    End Sub

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 4)
        CtrL_MenuCine.Sincronizar_permissoes({pnlMostrar}, {btnAlterar, btnAtivar, btnDesativar}, {btnInserir})
        If btnAlterar.Visible + btnInserir.Visible = 0 Then
            pnlControlos.Hide()
        End If
    End Sub


    Private Sub SelecaoAlterada_Enc_Ativ() Handles lstEnc_Ativ.SelectedIndexChanged
        If lstEnc_Ativ.SelectedItems.Count > 0 And handler(0) Then
            Dim codta As Integer = 0
            btnInserir.Enabled = False
            btnDesativar.Enabled = True
            btnAlterar.Enabled = True
            pnlInformacao.Hide()
            mostrar(dgvEnc_Ta_Ativ, ligacao, "aux_enc", "codAE", "select aux_enc.codAE as codAE, tabelas.nome as tabela, group_concat(' ' , permissoes.nome) as permissoes " &
            "from aux_enc, permissoes, tabelas where aux_enc.codE=" + lstEnc_Ativ.SelectedValue.ToString + " and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta group by tabelas.codta")

            txtnome.Text = lstEnc_Ativ.GetItemText(lstEnc_Ativ.SelectedItem)
            txtnome.Tag = False

            dtTa_Enc.Clear()
            For x As Integer = 0 To (DIMTA - 2) - 1
                dtTa_Per(x).Clear()
            Next

            query = "select aux_enc.codTa as codTa, tabelas.nome as tabela, aux_enc.codPe as codPe, permissoes.nome as permissao " &
            "from aux_enc, tabelas, permissoes where permissoes.codPe=aux_enc.codPe and tabelas.codTa=aux_enc.codTa and aux_enc.codE=" + lstEnc_Ativ.SelectedValue.ToString + " order by aux_enc.codTa"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            While leitor.Read
                If leitor.GetInt32("codTa") <> codta Then
                    codta = leitor.GetInt32("codTa")
                    dtTa_Enc.Rows.Add(codta, leitor.GetString("tabela"))
                End If
                dtTa_Per(codta - 1).Rows.Add(leitor.GetInt32("codPe"), leitor.GetString("permissao"))
            End While
            leitor.Close()
            ligacao.Close()
        End If
        SelecaoAlterada_Enc_Ta()
    End Sub

    Private Sub SelecaoAlterada_Enc_Desa() Handles lstEnc_Desa.SelectedIndexChanged
        If lstEnc_Desa.SelectedItems.Count > 0 And handler(1) Then
            btnAtivar.Enabled = True
            pnlInformacao.Hide()
            mostrar(dgvEnc_Ta_Desa, ligacao, "aux_enc", "codAE", "select aux_enc.codAE as codAE, tabelas.nome as tabela, group_concat(' ' , permissoes.nome) as permissoes " &
            "from aux_enc, permissoes, tabelas where aux_enc.codE=" + lstEnc_Desa.SelectedValue.ToString + " and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta group by tabelas.codta")
        End If
    End Sub

    Private Sub SelecaoAlterada_Enc_Ta()
        If lstTa_Enc.SelectedItems.Count > 0 And handler(2) Then
            'Limpo o DataSet
            dsTa_Per.Tables.Clear()
            'Associo o DataSet à tabela do Datatable.
            dsTa_Per.Tables.Add(dtTa_Per(lstTa_Enc.SelectedValue - 1))
            'Associo a ListBox ao DataSet.
            lstTa_Per.DataSource = dsTa_Per.Tables("Ta_Per")
            lstTa_Per.DisplayMember = "nome"
            lstTa_Per.ValueMember = "codPe"
        End If
    End Sub

    Private Sub btnAdi_Ta_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi_Ta.Click
        Dim TabelaSelecionada As String = CType(lstTabelas.SelectedItem, DataRowView)("nome").ToString
        Dim encontrou As Boolean = False
        For Each item As DataRowView In lstTa_Enc.Items 'Um loop que só finda quando chegar ao último item da listbox
            Dim istr As String = item("nome")
            If istr = TabelaSelecionada Then
                encontrou = True
                Exit For
            End If
        Next
        If Not encontrou Then
            lstTa_Enc.Tag = True
            dtTa_Enc.Rows.Add(lstTabelas.SelectedValue, lstTabelas.GetItemText(lstTabelas.SelectedItem))
            SelecaoAlterada_Enc_Ta()

        Else
            MessageBox.Show("Não pode adicionar a tabela '" + lstTabelas.GetItemText(lstTabelas.SelectedItem) + "' novamente", "Repetição de tabelas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnRet_Ta_Click(sender As System.Object, e As System.EventArgs) Handles btnRet_Ta.Click
        If lstTa_Enc.Items.Count > 0 Then
            If (lstTa_Per.Tag And lstEnc_Ativ.SelectedItem IsNot Nothing) Or lstTa_Per.Items.Count > 0 Then
                If MessageBox.Show("Tem a certeza que quer remover a tabela '" + lstTa_Enc.GetItemText(lstTa_Enc.SelectedItem) + "'? As permissões não serão guardadas", "Tabela não será mais acessível", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            lstTa_Enc.Tag = True
            dtTa_Per(lstTa_Enc.SelectedValue - 1).Clear()
            dtTa_Enc.Rows(lstTa_Enc.SelectedIndex).Delete()
            SelecaoAlterada_Enc_Ta()

        Else
            MessageBox.Show("Não pode remover uma tabela sem que tenha inserido uma", "Falta de tabelas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        If Not txtnome.Text = "" And lstTa_Enc.Items.Count > 0 And lstTa_Per.Items.Count > 0 Then
            If lstTa_Enc.Tag Or lstTa_Per.Tag Or txtnome.Tag Then
                If MessageBox.Show("Deseja perder as últimas alterações que fez ao encargo?", "Limpeza das últimas informações", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            ver()

            btnInserir.Enabled = True
            btnDesativar.Enabled = False
            btnAlterar.Enabled = False
        End If
    End Sub

    Private Sub btnAdi_Pe_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi_Pe.Click
        If lstTa_Enc.SelectedItems.Count > 0 Then
            Dim PermissaoSelecionada As String = CType(lstPermissoes.SelectedItem, DataRowView)("nome").ToString '= lstPermissoes.GetItemText(lstPermissoes.SelectedItem)
            Dim encontrou As Boolean = False
            For Each item As DataRowView In lstTa_Per.Items 'Um loop que só finda quando chegar ao último item da listbox
                Dim istr As String = item("nome")
                If istr = PermissaoSelecionada Then
                    encontrou = True
                    Exit For
                End If
            Next
            If Not encontrou Then
                dtTa_Per(lstTa_Enc.SelectedValue - 1).Rows.Add(lstPermissoes.SelectedValue, PermissaoSelecionada)
                lstTa_Per.Tag = True
            Else
                MessageBox.Show("Não pode adicionar a permissão para '" + lstPermissoes.GetItemText(lstPermissoes.SelectedItem) + "' novamente", "Repetição de permissões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Não pode adicionar uma permissão sem lhe associar uma tabela", "Falta de tabelas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnRet_Pe_Click(sender As System.Object, e As System.EventArgs) Handles btnRet_Pe.Click
        If lstTa_Per.Items.Count > 0 Then
            dtTa_Per(lstTa_Enc.SelectedValue - 1).Rows(lstTa_Per.SelectedIndex).Delete()
            lstTa_Per.Tag = True
        Else
            MessageBox.Show("Não pode remover uma permissão sem que tenha adicionado uma", "Sem permissões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim codE As Integer
        If txtnome.Text <> "" Then
            query = "select * from encargos where nome='" + txtnome.Text + "'"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            If Not leitor.Read Then
                ligacao.Dispose()
                AlterarEstado(rctNome, txtnome, "acertar")
                If lstTa_Enc.Items.Count > 0 Then
                    For Each item As DataRowView In lstTa_Enc.Items
                        If dtTa_Per(item("codTa") - 1).Rows.Count = 0 Then
                            lstTa_Enc.SelectedItem = item
                            MessageBox.Show("Não pode inserir um encargo com tabelas sem qualquer permissão. " &
                            "Se a lista esbranquiçada à esquerda tiver alguma tabela indesejada, remova-a", "Tabelas sem permissões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Next
                    Try
                        'Inserir o novo encargo
                        acao("inserir", ligacao, "insert into encargos (nome,ativado) values ('" + txtnome.Text + "',1)", 0)

                        'Descobrir o codE desse encargo
                        codE = ter(ligacao, "codE", "select codE from encargos where nome='" + txtnome.Text + "'")

                        'Inserir tudo no aux_enc
                        For Each item As DataRowView In lstTa_Enc.Items
                            For Each linha As DataRow In dtTa_Per(item("codTa") - 1).Rows
                                acao("inserir", ligacao, "insert into aux_enc (codE,codTa,codPe) values (" + codE.ToString + "," + item("codTa").ToString + "," + linha("codPe").ToString + ")", 0)
                            Next
                        Next

                        MessageBox.Show("O encargo '" + txtnome.Text + "' foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ver()
                        btnInserir.Enabled = False
                    Catch ex As Exception
                        ligacao.Close()
                        MessageBox.Show("O encargo '" + txtnome.Text + "' não foi inserido: " + ex.Message, "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("Não pode inserir um encargo sem lhe associar pelo menos uma tabela", "Falta de tabelas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ligacao.Dispose()
                MessageBox.Show("Não pode inserir um encargo com o mesmo nome que outro. Pode, invés disso, alterar o que já criou", "Nome repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                AlterarEstado(rctNome, txtnome, "errar")
            End If
        Else
            MessageBox.Show("Não pode inserir um encargo sem lhe dar um nome", "Sem nome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AlterarEstado(rctNome, txtnome, "errar")
        End If
    End Sub
    Private Sub txtNome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        AlterarEstado(rctNome, txtnome, "restaurar")
        txtnome.Tag = True
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        If lstTa_Enc.Tag Or lstTa_Per.Tag Or txtnome.Tag Then
            If txtnome.Text <> "" Then
                Dim cont As Integer = ter(ligacao, "cont", "select count(*) as cont from encargos where nome='" + txtnome.Text + "' and codE<>" + lstEnc_Ativ.SelectedValue.ToString)
                If cont = 0 Then
                    AlterarEstado(rctNome, txtnome, "acertar")
                    If lstTa_Enc.Items.Count > 0 Then
                        For Each item As DataRowView In lstTa_Enc.Items
                            If dtTa_Per(item("codTa") - 1).Rows.Count = 0 Then
                                lstTa_Enc.SelectedItem = item
                                MessageBox.Show("Não pode alterar um encargo de modo a ficar com tabelas sem qualquer permissão. " &
                                "Verifique se a lista esbranquiçada à esquerda tem alguma tabela sem qualquer permissão. Se sim e se não a quiser, remova-a", "Tabelas sem permissões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If
                        Next
                        Try
                            'Alterar ou não o nome do encargo
                            acao("alterar", ligacao, "update encargos set nome='" + txtnome.Text + "' where codE=" + lstEnc_Ativ.SelectedValue.ToString, 0)

                            'Apagar todos os registos da tabela aux_enc relacionados com este encargo
                            acao("apagar", ligacao, "delete from aux_enc where codE=" + lstEnc_Ativ.SelectedValue.ToString, 0)

                            'Recriar todos os registos com as novas alterações
                            For Each item As DataRowView In lstTa_Enc.Items
                                For Each linha As DataRow In dtTa_Per(item("codTa") - 1).Rows
                                    acao("inserir", ligacao, "insert into aux_enc (codE,codTa,codPe) values (" + lstEnc_Ativ.SelectedValue.ToString + "," + item("codTa").ToString + "," + linha("codPe").ToString + ")", 0)
                                Next
                                AlterarEstado(rctNome, txtnome, "restaurar")
                            Next
                            MessageBox.Show("O encargo '" + txtnome.Text + "' foi alterado sem qualquer problema", "Alteração realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            ligacao.Close()
                            MessageBox.Show("O encargo '" + txtnome.Text + "' não foi alterado: " + ex.Message, "Alteração sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                        ver()
                    Else
                        MessageBox.Show("Não pode alterar um encargo de modo a ficar sem nenhuma tabela", "Falta de tabelas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    ligacao.Dispose()
                    MessageBox.Show("Não pode mudar o nome do encargo para um partilhado por outro encargo. Pode, invés disso, colocar outro nome ou alterar o outro encargo", "Nome repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    AlterarEstado(rctNome, txtnome, "errar")
                End If
            Else
                MessageBox.Show("Não pode deixar o campo nome vazio", "Sem nome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                AlterarEstado(rctNome, txtnome, "errar")
            End If
        Else
            MessageBox.Show("Não fez nenhuma alteração, portanto não necesita de alterar", "Salvação desnecessária", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click
        If lstTa_Enc.Tag Or lstTa_Per.Tag Or txtnome.Tag Then
            If MessageBox.Show("Deseja perder as últimas alterações que fez ao encargo?", "Limpeza das últimas informações", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        Dim n_contas As Integer = ter(ligacao, "numero", "select count(funcionarios.nome) as numero from funcionarios where empregado=1 and codE=" + lstEnc_Ativ.SelectedValue.ToString)
        If n_contas > 0 Then
            If MessageBox.Show("Tem a certeza que quer desativar o encargo '" + lstEnc_Ativ.GetItemText(lstEnc_Ativ.SelectedItem) + "'? Se assim o fizer, desativará " + n_contas.ToString + " contas de funcionarios!", "Desativação de um encargo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        acao("desativar", ligacao, "update encargos set ativado=0 where codE=" + lstEnc_Ativ.SelectedValue.ToString, True)
        ver()
    End Sub

    Private Sub btnAtivar_Click(sender As System.Object, e As System.EventArgs) Handles btnAtivar.Click
        If lstTa_Enc.Tag Or lstTa_Per.Tag Or txtnome.Tag Then
            If MessageBox.Show("Deseja perder as últimas alterações que fez ao encargo?", "Limpeza das últimas informações", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        acao("ativar", ligacao, "update encargos set ativado=1 where codE=" + lstEnc_Desa.SelectedValue.ToString, True)
        ver()
    End Sub

    Private Sub frmEncargos_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub
End Class