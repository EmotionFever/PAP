Imports MySql.Data.MySqlClient
Public Class frmEncargos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")

    Private Sub tbc1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tbc1.SelectedIndexChanged
        If tbc1.SelectedIndex = 0 Then
            btnInserir.Enabled = True
            If dgvAtivado.SelectedRows.Count > 0 Then
                btnAlterar.Enabled = True
                btnDesativar.Enabled = True
            End If
            btnDesativar.Show()
        End If
        If tbc1.SelectedIndex = 1 Then
            btnInserir.Enabled = False
            btnAlterar.Enabled = False
            btnDesativar.Hide()
        End If
    End Sub

    Sub ver()
        'DataGridView Ativado
        mostrar(dgvAtivado, ligacao, "encargos", "codAE", "select aux_enc.codAE as codAE, encargos.nome, tabelas.nome as tabela, group_concat(' ' , permissoes.nome) as permissoes from funcionarios, encargos, aux_enc, permissoes, tabelas where funcionarios.codE=encargos.codE and encargos.codE=aux_enc.codE and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta group by tabelas.nome")

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False


        'DataGridView DESAtivado
        mostrar(dgvDesativado, ligacao, "clientes", "codC", "select codc, clientes.nome, nif, rua, localidades.nome as localidade, telemovel " &
                                 "from clientes, localidades where localidades.codlo=clientes.codlo and ativado=0")

        'Covém desativar estes botões
        btnAtivar.Enabled = False
    End Sub

    Private Sub frmEncargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
    End Sub
End Class