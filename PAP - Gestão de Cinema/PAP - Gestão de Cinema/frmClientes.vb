Imports MySql.Data.MySqlClient
Public Class frmClientes
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Public Const CAMPOSC As Integer = 5
    Dim lbl(CAMPOSC) As Label

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
        mostrar(dgvAtivado, ligacao, "clientes", "codC", "select codc, clientes.nome, nif, rua, localidades.nome as localidade, telemovel " &
                                            "from clientes, localidades where localidades.codlo=clientes.codlo and ativado=1")

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False


        'DataGridView DESAtivado
        mostrar(dgvDesativado, ligacao, "clientes", "codC", "select codc, clientes.nome, nif, rua, localidades.nome as localidade, telemovel " &
                                 "from clientes, localidades where localidades.codlo=clientes.codlo and ativado=0")

        'Covém desativar estes botões
        btnAtivar.Enabled = False
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        btnDesativar.Enabled = False
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
    End Sub

    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 2)
        CtrL_MenuCine.Sincronizar_permissoes({tbc1, btnProcurar}, {btnAlterar, pnlAtivar, tbc1}, {btnInserir}) 'O tbc1 'tá em 2 casos já que para alterar preciso de selecionar um registo primeiro. 
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
        Dim codLo As Integer
        Dim str_erro As String = ""
        str_erro += verificacao(rctNome, txtnome)
        str_erro += verificacao(rctNIF, mtbNIF)
        If txtRua.Text <> "" Then

            str_erro += verificacao(rctRua, txtRua)
        End If
        str_erro += verificacao(rctLocalidade, cmblocalidade)
        If mtbTlm.Text <> "" Then
            str_erro += verificacao(rctTlm, mtbTlm)
        End If


        If str_erro = "" Then
            'Limpo os objetos input do formulário
            txtnome.Text = ""
            AlterarEstado(rctNome, txtnome, "restaurar")

            mtbNIF.Text = ""
            AlterarEstado(rctNIF, mtbNIF, "restaurar")

            txtRua.Text = ""
            AlterarEstado(rctRua, txtRua, "restaurar")

            mtbTlm.Text = ""
            AlterarEstado(rctTlm, mtbTlm, "restaurar")
            If cmblocalidade.SelectedValue IsNot Nothing Then
                'Insiro os dados na base de dados
                acao("inserir", ligacao, "insert into clientes (nome,NIF,rua,codlo,telemovel,ativado) " &
                "values ('" + txtnome.Text + "', '" + mtbNIF.Text + "', '" + txtRua.Text + "', " + cmblocalidade.SelectedValue.ToString + ",'" + mtbTlm.Text + "',1)", 1)

                'Volto a mostrar a tabela, desta vez, atualizada.
                ver()
            Else
                Try
                    'Inserir a nova localidade
                    acao("inserir", ligacao, "insert into localidades (nome) values ('" + cmblocalidade.Text + "')", 0)

                    'Descobrir o codLo dessa localidade
                    comando = New MySqlCommand("select codlo from localidades where nome='" + cmblocalidade.Text + "'", ligacao)
                    ligacao.Open()
                    leitor = comando.ExecuteReader
                    leitor.Read()
                    codLo = leitor.GetInt32("codlo")
                    ligacao.Close()

                    'Associá-la ao registo do funcionário
                    acao("inserir", ligacao, "insert into clientes (nome,NIF,rua,codlo,telemovel,ativado) " &
               "values ('" + txtnome.Text + "', '" + mtbNIF.Text + "', '" + txtRua.Text + "', " + codLo + ",'" + mtbTlm.Text + "',1)", 1)

                    encher(cmblocalidade, ligacao, "localidades", "nome", "codlo", "select codlo, nome from localidades")
                    cmblocalidade.Text = ""
                    MessageBox.Show("A localidade " + cmblocalidade.Text + "foi inserida sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ligacao.Close()
                    MessageBox.Show("A localidade " + cmblocalidade.Text + " não foi inserida: " + ex.Message, "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            cmblocalidade.Text = ""
            AlterarEstado(rctLocalidade, "restaurar")
        Else
            MessageBox.Show(str_erro, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcurar.Click
        'Basicamente, isto pesquisa na base de dados
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String

        'Apenas as checkboxes de um campo com um certo são pesquisados. Ou seja, se eu selecionar o campo ordenado apenas procuro os registos com aquele ordenado mesmo que os outros campos tenham coisas escritas
        If chknome.Checked Then
            averiguar = verificacao(rctNome, txtnome)
            If averiguar = "" Then
                pquery += " and clientes.nome like '%" + txtnome.Text + "%'"
            Else
                str_erro += averiguar
            End If
        End If
        If chkNIF.Checked Then
            averiguar = verificacao(rctNIF, mtbNIF)
            If averiguar = "" Then 'Pode-se procurar sequencias de números
                pquery += " and NIF like '%" + mtbNIF.Text + "%'"
            Else
                str_erro += averiguar
            End If
        End If
        If chkRua.Checked Then
            averiguar = verificacao(rctRua, txtRua)
            If averiguar = "" Then
                pquery += " and rua like '%" + txtRua.Text + "%'"
            Else
                str_erro += averiguar
            End If
        End If
        If chkLocalidade.Checked Then
            averiguar = verificacao(rctLocalidade, cmblocalidade)
            If averiguar = "" Then
                pquery += " and clientes.codlo=" + cmblocalidade.SelectedValue.ToString
            Else
                str_erro += "Não escolheu uma localidade. "
            End If
        End If
        If chkTlm.Checked Then
            averiguar = verificacao(rctTlm, mtbTlm)
            If averiguar = "" Then
                pquery += " and telemovel = '" + mtbTlm.Text + "'"
            Else
                str_erro += averiguar
            End If
        End If

        'No final deste if tenho 'parte' de um query

        'Caso o pquery esteja vazio significa que o utilizador não escolheu nenhum campo, ou seja "ERRRRRRRO"!!!!
        If str_erro = "" Then
            If pquery <> "" Then
                If tbc1.SelectedIndex = 0 Then
                    mostrar(dgvAtivado, ligacao, "clientes", "codC", "select codc, clientes.nome, NIF, Rua, localidades.nome as localidade, telemovel " &
                                        "from clientes, localidades where ativado=1 and localidades.codlo=clientes.codlo" + pquery)

                    'Como fiquei sem nenhum linha selecionada tenho de desativar os botões
                    btnDesativar.Enabled = False
                    btnAlterar.Enabled = False
                End If
                If tbc1.SelectedIndex = 1 Then
                    mostrar(dgvDesativado, ligacao, "clientes", "codC", "select codc, clientes.nome, NIF, Rua, localidades.nome as localidade, telemovel " &
                                        "from clientes, localidades where ativado=0 and localidades.codlo=clientes.codlo" + pquery)
                    btnAtivar.Enabled = False
                End If
            Else
                MessageBox.Show("Não selecionou nenhum campo para a pesquisa", "Sem campo para pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Atenção", str_erro, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String = ""
        If dgvAtivado.SelectedRows.Count > 0 Then
            If Not dgvAtivado.CurrentRow.IsNewRow Then

                'O código é muito parecido ao pesquisar... invés de procurar esses campos altera-los
                If chknome.Checked Then
                    averiguar = verificacao(rctNome, txtnome)
                    If averiguar = "" Then
                        pquery += " nome='" + txtnome.Text + "'"
                        lbl(0).Font = New Font(lbl(0).Font, lbl(0).Font.Style Or FontStyle.Strikeout)
                    Else
                        str_erro += averiguar
                    End If
                End If
                If chkNIF.Checked Then
                    averiguar = verificacao(rctNIF, mtbNIF)
                    If averiguar = "" Then
                        If pquery <> "" Then
                            pquery += ","
                        End If
                        pquery += " NIF='" + mtbNIF.Text + "'"
                        lbl(1).Font = New Font(lbl(1).Font, lbl(1).Font.Style Or FontStyle.Strikeout)
                    Else
                        str_erro += averiguar
                    End If
                End If
                If chkRua.Checked Then
                    averiguar = verificacao(rctRua, txtRua)
                    If averiguar = "" Then
                        If pquery <> "" Then
                            pquery += ","
                        End If
                        pquery += " Rua='" + txtRua.Text + "'"
                        lbl(2).Font = New Font(lbl(2).Font, lbl(2).Font.Style Or FontStyle.Strikeout)
                    Else
                        str_erro += averiguar
                    End If
                End If
                If chkLocalidade.Checked Then
                    averiguar = verificacao(rctLocalidade, cmblocalidade)
                    If averiguar = "" Then
                        If pquery <> "" Then
                            pquery += ","
                        End If
                        pquery += " clientes.codlo=" + cmblocalidade.SelectedValue.ToString
                        lbl(3).Font = New Font(lbl(3).Font, lbl(3).Font.Style Or FontStyle.Strikeout)
                    Else
                        str_erro += averiguar
                    End If
                End If
                If chkTlm.Checked Then
                    averiguar = verificacao(rctTlm, mtbTlm)
                    If averiguar = "" Then
                        If pquery <> "" Then
                            pquery += ","
                        End If
                        pquery += " telemovel='" + mtbTlm.Text + "'"
                        lbl(4).Font = New Font(lbl(4).Font, lbl(4).Font.Style Or FontStyle.Strikeout)
                    Else
                        str_erro += averiguar
                    End If
                End If
                If str_erro = "" Then
                    If pquery <> "" Then
                        acao("alterar", ligacao, "update clientes set" + pquery + " where codc=" + dgvAtivado.CurrentRow.Cells(0).Value.ToString, 1)

                        ver()

                        'Limpo os objetos input do formulário
                        txtnome.Text = ""
                        AlterarEstado(rctNome, txtnome, "restaurar")

                        mtbNIF.Text = ""
                        AlterarEstado(rctNIF, mtbNIF, "restaurar")

                        txtRua.Text = ""
                        AlterarEstado(rctRua, txtRua, "restaurar")

                        cmblocalidade.Text = ""
                        AlterarEstado(rctLocalidade, "restaurar")

                        mtbTlm.Text = ""
                        AlterarEstado(rctTlm, mtbTlm, "restaurar")
                    Else
                        MessageBox.Show("Não selecionou nenhum campo para alterar")
                    End If
                Else
                    MessageBox.Show("Atenção", str_erro, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
End Class