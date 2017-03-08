Imports MySql.Data.MySqlClient
Public Class frmEncargos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    Dim dtTa_Enc As DataTable = New DataTable("Ta_Enc")
    Dim dsTa_Enc As DataSet = New DataSet
    Dim dtTa_Per As DataTable = New DataTable("Ta_Per")
    Dim dsTa_Per As DataSet = New DataSet

    Private Sub tbc1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tbc1.SelectedIndexChanged
        If tbc1.SelectedIndex = 0 Then
            btnInserir.Enabled = True
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
            If lstEnc_Desa.SelectedItem Is Nothing Then
                pnlInformacao.Show()
            Else
                pnlInformacao.Hide()
                btnInserir.Enabled = False
                btnAlterar.Enabled = False
            End If
            btnDesativar.Hide()
        End If
    End Sub

    Sub ver()
        'Mostrar Ativado
        RemoveHandler lstEnc_Ativ.SelectedIndexChanged, AddressOf SelecaoAlterada_Enc_Ativ
        encher(lstEnc_Ativ, ligacao, "encargos", "nome", "codE", "select codE, nome from encargos where ativado=1")
        lstEnc_Ativ.ClearSelected()
        AddHandler lstEnc_Ativ.SelectedIndexChanged, AddressOf SelecaoAlterada_Enc_Ativ
        pnlInformacao.Show()

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False
        btnAtivar.Enabled = False

        'Mostrar DESAtivado
        RemoveHandler lstEnc_Desa.SelectedIndexChanged, AddressOf SelecaoAlterada_Enc_Desa
        encher(lstEnc_Desa, ligacao, "encargos", "nome", "codE", "select codE, nome from encargos where ativado=0")
        lstEnc_Desa.ClearSelected()
        AddHandler lstEnc_Desa.SelectedIndexChanged, AddressOf SelecaoAlterada_Enc_Desa
        pnlInformacao.Show()

        'Covém desativar estes botões

    End Sub

    Private Sub frmEncargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Insiro colunas ao DateTable
        dtTa_Enc.Columns.Add("codTa")
        dtTa_Enc.Columns.Add("nome")
        'Associo o DataSet à tabela do Datatable.
        dsTa_Enc.Tables.Add(dtTa_Enc)
        'Associo a ListBox ao DataSet.
        lstTa_Enc.DataSource = dsTa_Enc.Tables("Ta_Enc")
        lstTa_Enc.DisplayMember = "nome"
        lstTa_Enc.ValueMember = "codTa"
        AddHandler lstTa_Enc.SelectedIndexChanged, AddressOf SelecaoAlterada_Enc_Ta

        'Insiro colunas ao DateTable
        dtTa_Per.Columns.Add("codPe")
        dtTa_Per.Columns.Add("nome")
        'Associo o DataSet à tabela do Datatable.
        dsTa_Per.Tables.Add(dtTa_Per)
        'Associo a ListBox ao DataSet.
        lstTa_Per.DataSource = dsTa_Per.Tables("Ta_Per")
        lstTa_Per.DisplayMember = "nome"
        lstTa_Per.ValueMember = "codPe"

        btnDesativar.Enabled = False
        btnAlterar.Enabled = False

        ver()

        'Aqui, encho a combobox com dados para o utilizador escolher
        encher(lstTabelas, ligacao, "tabelas", "nome", "codta", "select codta, nome from tabelas")
        encher(lstPermissoes, ligacao, "permissoes", "nome", "codpe", "select codpe, nome from permissoes")
    End Sub

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos()
        CtrL_MenuCine.SelecionarBotao(8)
    End Sub


    Private Sub SelecaoAlterada_Enc_Ativ()
        If lstEnc_Ativ.SelectedItem IsNot Nothing Then
            btnInserir.Enabled = False
            pnlInformacao.Hide()
            mostrar(dgvEnc_Ta_Ativ, ligacao, "aux_enc", "codAE", "select aux_enc.codAE as codAE, tabelas.nome as tabela, group_concat(' ' , permissoes.nome) as permissoes " &
                    "from aux_enc, permissoes, tabelas where aux_enc.codE=" + lstEnc_Ativ.SelectedValue.ToString + " and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta group by tabelas.codta")

            txtnome.Text = lstEnc_Ativ.GetItemText(lstEnc_Ativ.SelectedItem)
            dtTa_Enc.Clear()

            query = "select distinct tabelas.nome as nome, aux_enc.codTa as codTa " &
                    "from aux_enc, tabelas where tabelas.codTa=aux_enc.codta and aux_enc.codE=" + lstEnc_Ativ.SelectedValue.ToString
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            While leitor.Read
                dtTa_Enc.Rows.Add(leitor.GetString("codTa"), leitor.GetString("nome"))
            End While
            ligacao.Dispose()
        End If
    End Sub

    Private Sub SelecaoAlterada_Enc_Desa()
        btnInserir.Enabled = False
        pnlInformacao.Hide()
        mostrar(dgvEnc_Ta_Desa, ligacao, "aux_enc", "codAE", "select aux_enc.codAE as codAE, tabelas.nome as tabela, group_concat(' ' , permissoes.nome) as permissoes " &
                "from aux_enc, permissoes, tabelas where aux_enc.codE=" + lstEnc_Desa.SelectedValue.ToString + " and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta group by tabelas.codta")
    End Sub

    Private Sub SelecaoAlterada_Enc_Ta()
        If Not btnInserir.Enabled And lstTa_Enc.SelectedItem IsNot Nothing Then
            dtTa_Per.Clear()

            query = "select distinct permissoes.nome as nome, aux_enc.codPe as codPe " &
                    "from aux_enc, permissoes where permissoes.codPe=aux_enc.codPe and aux_enc.codE=" + lstEnc_Ativ.SelectedValue.ToString
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            While leitor.Read
                dtTa_Per.Rows.Add(leitor.GetString("codPe"), leitor.GetString("nome"))
            End While
            ligacao.Dispose()
        End If
    End Sub

    Private Sub btnAdi_Ta_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi_Ta.Click
        Dim TabelaSelecionada As String = CType(lstTabelas.SelectedItem, DataRowView)("nome").ToString
        Dim encontrou As Boolean = True
        For Each item As Object In lstTa_Enc.Items 'Um loop que só finda quando chegar ao último item da listbox
            Dim istr As String = CType(item, DataRowView)("nome").ToString
            If istr = TabelaSelecionada Then
                encontrou = False
                Exit For
            End If
        Next
        If encontrou Then
            dtTa_Enc.Rows.Add(lstTabelas.ValueMember, lstTabelas.GetItemText(lstTabelas.SelectedItem))
        Else
            MessageBox.Show("Não pode adicionar a tabela '" + lstTabelas.GetItemText(lstTabelas.SelectedItem) + "' novamente", "Repetição de tabelas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnRet_Ta_Click(sender As System.Object, e As System.EventArgs) Handles btnRet_Ta.Click
        If lstTa_Enc.SelectedItem IsNot Nothing Then
            dtTa_Enc.Rows(lstTa_Enc.SelectedIndex).Delete()
        Else
            MessageBox.Show("Não pode remover uma tabela sem que haja primeiro uma na lista adicionada por si", "Sem tabelas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        If lstEnc_Ativ.SelectedItem Is Nothing Then
            If lstTa_Enc.SelectedItem IsNot Nothing Then
                If MessageBox.Show("Quer perder todos as informações do último encargo que criou?", "Limpeza das últimas informações", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
        Else
            dgvEnc_Ta_Ativ.Dispose()
            lstEnc_Ativ.ClearSelected()
            pnlInformacao.Show()
        End If
        txtnome.Text = ""
        dtTa_Enc.Clear()
        dtTa_Per.Clear()
        btnInserir.Enabled = True
    End Sub
End Class