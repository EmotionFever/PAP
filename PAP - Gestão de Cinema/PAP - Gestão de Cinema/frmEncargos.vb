Imports MySql.Data.MySqlClient
Public Class frmEncargos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim dtTa_Enc As DataTable = New DataTable("Ta_Enc")
    Dim dsTa As DataSet = New DataSet("Ta_E")
    Private Property dgvEnc_Ativ As Object

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
        'DataGridView Ativado
        RemoveHandler lstEnc_Ativ.SelectedIndexChanged, AddressOf SelecaoAlterada_Ativ
        encher(lstEnc_Ativ, ligacao, "encargos", "nome", "codE", "select codE, nome from encargos where ativado=1")
        lstEnc_Ativ.ClearSelected()
        AddHandler lstEnc_Ativ.SelectedIndexChanged, AddressOf SelecaoAlterada_Ativ
        pnlInformacao.Show()

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False


        'DataGridView DESAtivado
        RemoveHandler lstEnc_Desa.SelectedIndexChanged, AddressOf SelecaoAlterada_Desa
        encher(lstEnc_Desa, ligacao, "encargos", "nome", "codE", "select codE, nome from encargos where ativado=0")
        lstEnc_Desa.ClearSelected()
        AddHandler lstEnc_Desa.SelectedIndexChanged, AddressOf SelecaoAlterada_Desa
        pnlInformacao.Show()

        'Covém desativar estes botões
        btnAtivar.Enabled = False
    End Sub

    Private Sub frmEncargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Insiro colunas ao DateTable
        dtTa_Enc.Columns.Add("codTa")
        dtTa_Enc.Columns.Add("nome")
        'Associo o DataSet à tabela do Datetable.
        dsTa.Tables.Add(dtTa_Enc)
        'Associo a ListBox ao DataSet.
        lstTa_Enc.DataSource = dsTa.Tables("Ta_Enc")
        lstTa_Enc.DisplayMember = "nome"
        lstTa_Enc.ValueMember = "codTa"

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

    Private Sub dgvEnc_Ta_Ativ_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEnc_Ta_Ativ.CellClick
        ' Quando o utilizador clica numa célula do DGV este código seleciona a linha toda
        Try
            Dim i As Integer = dgvEnc_Ta_Ativ.CurrentCell.RowIndex
            dgvEnc_Ta_Ativ.Rows(i).Selected = True

            'Como foi selecionada uma linha posso (re)ativar os botões apagar e alterar
            btnDesativar.Enabled = True
            btnAlterar.Enabled = True

        Catch ex As Exception
            btnDesativar.Enabled = False
            btnAlterar.Enabled = False
        End Try

        'Tiro o rasurado caso esteja a mostrar os clientes ativados senão  e coloco os valores da linha selecionada nas labels
    End Sub


    Private Sub SelecaoAlterada_Ativ()
        btnInserir.Enabled = False
        pnlInformacao.Hide()
        mostrar(dgvEnc_Ta_Ativ, ligacao, "aux_enc", "codAE", "select aux_enc.codAE as codAE, tabelas.nome as tabela, group_concat(' ' , permissoes.nome) as permissoes " &
                "from aux_enc, permissoes, tabelas where aux_enc.codE=" + lstEnc_Ativ.SelectedValue.ToString + " and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta group by tabelas.codta")
    End Sub

    Private Sub SelecaoAlterada_Desa()
        btnInserir.Enabled = False
        pnlInformacao.Hide()
        mostrar(dgvEnc_Ta_Desa, ligacao, "aux_enc", "codAE", "select aux_enc.codAE as codAE, tabelas.nome as tabela, group_concat(' ' , permissoes.nome) as permissoes " &
                "from aux_enc, permissoes, tabelas where aux_enc.codE=" + lstEnc_Desa.SelectedValue.ToString + " and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta group by tabelas.codta")
    End Sub

    Private Sub btnAdi_Ta_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi_Ta.Click
        Dim lst1Selected As String = lstTabelas.SelectedItem
        Dim flag As Integer = 0
        For Each istr As String In lstTa_Enc.Items
            If istr = lst1Selected Then
                flag = 1
                Exit For
            End If
        Next

        If flag = 0 Then
            dtTa_Enc.Rows.Add(lstTabelas.ValueMember, lstTabelas.GetItemText(lstTabelas.SelectedItem))
        End If
    End Sub
End Class