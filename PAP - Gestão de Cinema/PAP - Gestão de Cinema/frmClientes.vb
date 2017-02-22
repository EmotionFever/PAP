Imports MySql.Data.MySqlClient
Public Class frmClientes
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim DS As DataSet = New DataSet
    Dim comando As MySqlCommand
    Dim DS1 As DataSet
    Public Const CAMPOSC As Integer = 5
    Dim lbl(CAMPOSC) As Label

    Function verificacao() As Boolean 'Verificar os valores ou textos dos objetos input. Apenas verifico os obrigatórios
        Dim str_erro As String = ""
        If txtnome.Text = "" Or IsNumeric(txtnome.Text) Then
            str_erro += "Não escreveu um nome válido. "
            txtnome.BackColor = Color.Salmon
            rctNome.BackColor = Color.Salmon
            rctLocalidade.BorderColor = Color.Salmon
            rctNome.BorderColor = Color.Salmon
            txtnome.ForeColor = Color.Red

        Else
            txtnome.BackColor = Color.LightGreen
            rctNome.BackColor = Color.LightGreen
            rctLocalidade.BorderColor = Color.LightGreen
            rctNome.BorderColor = Color.LightGreen
        End If
        If mtbNIF.Text = "" Or mtbNIF.Text.Length < 9 Then
            str_erro += "Não escreveu um NIF. "
            mtbNIF.BackColor = Color.Salmon
            rctNIF.BackColor = Color.Salmon
            rctNIF.BorderColor = Color.Salmon
        Else
            mtbNIF.BackColor = Color.LightGreen
            rctNIF.BackColor = Color.LightGreen
            rctNIF.BorderColor = Color.LightGreen
        End If

        If txtRua.Text <> "" Then
            If IsNumeric(txtRua.Text) Then
                str_erro += "Não escreveu uma rua válida. "
                txtRua.BackColor = Color.Salmon
                rctRua.BackColor = Color.Salmon
                rctRua.BorderColor = Color.Salmon
                txtRua.ForeColor = Color.Red
            Else
                txtRua.BackColor = Color.LightGreen
                rctRua.BackColor = Color.LightGreen
                rctRua.BorderColor = Color.LightGreen
            End If
        End If

        If cmblocalidade.Text = "" Then
            str_erro += "Não escolheu uma localidade. "
            rctLocalidade.BackColor = Color.Salmon
            rctLocalidade.BorderColor = Color.Salmon
        Else
            rctLocalidade.BackColor = Color.LightGreen
            rctLocalidade.BorderColor = Color.LightGreen
        End If

        If mtbTlm.Text <> "" Then
            If mtbTlm.Text.Length < 9 Then
                str_erro += "Não escreveu um número de telemóvel. "
                mtbNIF.BackColor = Color.Salmon
                rctNIF.BackColor = Color.Salmon
                rctNIF.BorderColor = Color.Salmon
                txtRua.ForeColor = Color.Red
            Else
                mtbNIF.BackColor = Color.LightGreen
                rctNIF.BackColor = Color.LightGreen
                rctNIF.BorderColor = Color.LightGreen
            End If
        End If

        If str_erro <> "" Then
            MessageBox.Show(str_erro, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Sub ver()
        adapter.SelectCommand = New MySqlCommand
        adapter.SelectCommand.Connection = ligacao
        adapter.SelectCommand.CommandText = "select codc, clientes.nome, nif, rua, localidades.nome as localidade, telemovel  from clientes, localidades where localidades.codlo=clientes.codlo and ativado=1"
        DS.Clear()
        ligacao.Open()
        adapter.Fill(DS, "clientes")
        ligacao.Close()

        dgv1.AutoGenerateColumns = True
        dgv1.DataSource = DS
        dgv1.DataMember = "clientes"
        dgv1.Columns.Item("codc").Visible = False

        'Covém desativar estes botões
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False
    End Sub

    Private Sub dgv1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick

        ' Quando o utilizador clica numa célula do DGV este código seleciona a linha toda
        Try
            Dim i As Integer = dgv1.CurrentCell.RowIndex
            dgv1.Rows(i).Selected = True

            'Como foi selecionada uma linha posso (re)ativar os botões apagar e alterar
            btnDesativar.Enabled = True
            btnAlterar.Enabled = True
        Catch ex As Exception
            btnDesativar.Enabled = False
            btnAlterar.Enabled = False
        End Try

        'Tiro o rasurado e coloco os valores da linha selecionada nas labels
        For a As Integer = 0 To CAMPOSC - 1
            lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style And Not FontStyle.Strikeout)
            lbl(a).Text = dgv1.CurrentRow.Cells(a + 1).Value.ToString
        Next
    End Sub


    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos()
        CtrL_MenuCine.SelecionarBotao(2)
    End Sub

    Private Sub frmClientes_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub


    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        'Insiro os dados na base de dados
        If verificacao() Then

            comando = New MySqlCommand

            comando.Connection = ligacao
            comando.CommandText = "insert into condominios (nome,NIF,rua,codlo,telemovel) " &
            "values ('" + txtnome.Text + "', '" + mtbNIF.Text + "', '" + txtRua.Text + "', " + cmblocalidade.SelectedValue.ToString + ",'" + mtbTlm.Text + "')"
            DS.Clear()
            ligacao.Open()
            comando.ExecuteNonQuery()
            ligacao.Close()

            'Volto a mostrar a tabela, desta vez, atualizada.
            ver()

            'Limpo os objetos input do formulário
            txtnome.Text = ""
            restaurar(rctNome, txtnome)

            mtbNIF.Text = ""
            restaurar(rctNIF, mtbNIF)

            txtRua.Text = ""
            restaurar(rctRua, txtRua)

            cmblocalidade.Text = ""
            restaurar(rctLocalidade)

            mtbTlm.Text = ""
            restaurar(rctTlm, mtbTlm)
        End If
    End Sub

    Private Sub restaurar(rct As PowerPacks.RectangleShape, obj As Object)
        obj.BackColor = Color.White
        rct.BackColor = Color.White
        rct.BorderColor = Color.White
        obj.ForeColor = Color.Black
    End Sub
    Private Sub restaurar(rct As PowerPacks.RectangleShape)
        rct.BackColor = Color.White
        rct.BorderColor = Color.White
    End Sub

    Private Sub destacar(rct As PowerPacks.RectangleShape, obj As Object)
        obj.BackColor = Color.LightSalmon
        rct.BackColor = Color.LightSalmon
        rct.BorderColor = Color.LightSalmon
        obj.ForeColor = Color.Red
    End Sub
    Private Sub destacar(rct As PowerPacks.RectangleShape)
        rct.BackColor = Color.LightSalmon
        rct.BorderColor = Color.LightSalmon
    End Sub

    Private Sub txtnome_TextChanged(sender As Object, e As System.EventArgs) Handles txtnome.TextChanged
        restaurar(rctNome, txtnome)
    End Sub

    Private Sub mtbNIF_TextChanged(sender As Object, e As System.EventArgs) Handles mtbNIF.TextChanged
        restaurar(rctNIF, mtbNIF)
    End Sub

    Private Sub txtRua_TextChanged(sender As Object, e As System.EventArgs) Handles txtRua.TextChanged
        restaurar(rctRua, txtRua)
    End Sub

    Private Sub cmblocalidade_TextChanged(sender As Object, e As System.EventArgs) Handles cmblocalidade.TextChanged
        restaurar(rctLocalidade)
    End Sub

    Private Sub mtbTlm_TextChanged(sender As Object, e As System.EventArgs) Handles mtbTlm.TextChanged
        restaurar(rctTlm, mtbTlm)
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Dim str_erro As String = ""
        Dim pquery As String = ""
        If dgv1.SelectedRows.Count > 0 Then
            Try
                If Not dgv1.CurrentRow.IsNewRow Then

                    'O código é muito parecido ao pesquisar... invés de procurar esses campos altera-os
                    If chknome.Checked Then
                        If Not (txtnome.Text = "" Or IsNumeric(txtnome.Text)) Then
                            pquery += " nome='" + txtnome.Text + "'"
                            lbl(0).Font = New Font(lbl(0).Font, lbl(0).Font.Style Or FontStyle.Strikeout)
                        Else
                            str_erro += "Não escreveu um nome válido. "
                            destacar(rctNome, txtnome)
                        End If
                    End If
                    If chkNIF.Checked Then
                        If Not (mtbNIF.Text = "" Or mtbNIF.Text.Length < 9) Then
                            If pquery <> "" Then
                                pquery += ","
                            End If
                            pquery += " NIF='" + mtbNIF.Text + "'"
                            lbl(1).Font = New Font(lbl(1).Font, lbl(1).Font.Style Or FontStyle.Strikeout)
                        Else
                            str_erro += "Não escreveu um NIF. "
                        End If
                    End If
                    If chkRua.Checked Then
                        If Not (txtRua.Text = "" Or IsNumeric(txtRua.Text)) Then
                            If pquery <> "" Then
                                pquery += ","
                            End If
                            pquery += " Rua='" + txtRua.Text + "'"
                            lbl(2).Font = New Font(lbl(2).Font, lbl(2).Font.Style Or FontStyle.Strikeout)
                        Else
                            str_erro += "Não escreveu uma rua. "
                        End If
                    End If
                    If chkLocalidade.Checked Then
                        If cmblocalidade.Text <> "" Then
                            If pquery <> "" Then
                                pquery += ","
                            End If
                            pquery += " clientes.codlo=" + cmblocalidade.SelectedValue.ToString
                            lbl(3).Font = New Font(lbl(3).Font, lbl(3).Font.Style Or FontStyle.Strikeout)
                        Else
                            str_erro += "Não escolheu uma localidade. "
                        End If
                    End If
                    If chkTlm.Checked Then
                        If Not (mtbTlm.Text = "" Or mtbTlm.Text.Length < 9) Then
                            If pquery <> "" Then
                                pquery += ","
                            End If
                            pquery += " telemovel='" + mtbTlm.Text + "'"
                            lbl(4).Font = New Font(lbl(4).Font, lbl(4).Font.Style Or FontStyle.Strikeout)
                        Else
                            str_erro += "Não escreveu um número de telemóvel válido. "
                        End If
                    End If
                    If str_erro = "" Then
                        If pquery <> "" Then
                            MessageBox.Show(str_erro)
                            pquery = "update clientes set" + pquery + " where codc=" + dgv1.CurrentRow.Cells(0).Value.ToString
                            Dim comando As New MySqlCommand
                            comando.Connection = ligacao
                            comando.CommandText = pquery
                            DS.Clear()
                            ligacao.Open()
                            comando.ExecuteNonQuery()
                            ligacao.Close()

                            ver()

                            MessageBox.Show("Registo alterado", "Operação executada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else
                            MessageBox.Show("Não selecionou nenhum campo para alterar")
                        End If
                    Else
                        MessageBox.Show(str_erro, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ligacao.Close()
            End Try
        Else
            MessageBox.Show("Não selecionou nenhuma linha", "Selecione uma linha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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
        DS1 = New DataSet

        adapter.SelectCommand = New MySqlCommand
        adapter.SelectCommand.Connection = ligacao
        adapter.SelectCommand.CommandText = "select codlo, nome from localidades"

        ligacao.Open()
        adapter.Fill(DS1, "localidades")
        ligacao.Close()

        cmblocalidade.DataSource = DS1.Tables("localidades")
        cmblocalidade.DisplayMember = "nome"
        cmblocalidade.ValueMember = "codlo"
        cmblocalidade.Text = ""
    End Sub

    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click ' EM DESENVOLVIMENTO
        'Apago os dados da linha selecionada na base de dados
        Dim query As String
        If dgv1.SelectedRows.Count > 0 Then
            Try
                If Not dgv1.CurrentRow.IsNewRow Then
                    query = "update clientes set ativado=0 where codc = " + dgv1.CurrentRow.Cells(0).Value.ToString

                    Dim comando As New MySqlCommand(query, ligacao)
                    ligacao.Open()
                    comando.ExecuteNonQuery()
                    ligacao.Close()
                    ver()

                    'Isto muda o texto da label (que cada apontador de label está apontar)
                    For a As Integer = 0 To 3
                        lbl(a).Font = New Font(lbl(a).Font, lbl(a).Font.Style Or FontStyle.Strikeout) ' Tudo isto quando podia simplesmente utlizar "lbl(a).FontStyle.Strikeout=True"!
                    Next

                    MessageBox.Show("O registo que selecionou foi desativado", "Operação executada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                ligacao.Close()
            End Try
        End If
    End Sub

    Private Sub btnProcurar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcurar.Click
        'Basicamente, isto pesquisa na base de dados
        Dim str_erro As String = ""
        Dim pquery As String = ""

        'Apenas as checkboxes de um campo com um certo são pesquisados. Ou seja, se eu selecionar o campo ordenado apenas procuro os registos com aquele ordenado mesmo que os outros campos tenham coisas escritas
        If chknome.Checked Then
            If Not (txtnome.Text = "" Or IsNumeric(txtnome.Text)) Then
                pquery += " and clientes.nome like '%" + txtnome.Text + "%'"
            Else
                str_erro += "Não escreveu um nome. "
            End If
        End If
        If chkNIF.Checked Then
            If mtbNIF.Text <> "" And mtbNIF.Text.Length <= 9 Then 'Pode-se procurar sequencias de números
                pquery += " and NIF like '%" + mtbNIF.Text + "%'"
            Else
                str_erro += "Não escreveu um NIF. "
            End If
        End If
        If chkRua.Checked Then
            If Not (txtRua.Text = "" Or IsNumeric(txtRua.Text)) Then
                pquery += " and rua like '%" + txtRua.Text + "%'"
            Else
                str_erro += "Não escreveu uma rua. "
            End If
        End If
        If chkLocalidade.Checked Then
            If cmblocalidade.Text <> "" Then
                pquery += " and clientes.codlo=" + cmblocalidade.SelectedValue.ToString
            Else
                str_erro += "Não escolheu uma localidade. "
            End If
        End If
        If chkTlm.Checked Then
            If mtbTlm.Text <> "" And mtbTlm.Text.Length <= 9 Then 'Pode-se procurar sequencias de números
                pquery += " and telemovel like '%" + mtbTlm.Text + "%'"
            Else
                str_erro += "Não escreveu um número de telemóvel. "
            End If
        End If

        'No final deste if tenho 'parte' de um query

        'Caso o pquery esteja vazio significa que o utilizador não escolheu nenhum campo, ou seja "ERRRRRRRO"!!!!
        If str_erro = "" Then
            If pquery <> "" Then
                adapter.SelectCommand = New MySqlCommand
                adapter.SelectCommand.Connection = ligacao
                adapter.SelectCommand.CommandText = "select codc, clientes.nome, NIF, Rua, localidades.nome as localidade, telemovel  from clientes, localidades where localidades.codlo=clientes.codlo" + pquery
                DS.Clear()
                ligacao.Open()
                adapter.Fill(DS, "clientes")
                ligacao.Close()

                dgv1.AutoGenerateColumns = True
                dgv1.DataSource = DS
                dgv1.DataMember = "clientes"
                dgv1.Columns.Item("codc").Visible = False

                'Como fiquei sem nenhum linha selecionada tenho de desativar os botões
                btnDesativar.Enabled = False
                btnAlterar.Enabled = False
            Else
                MessageBox.Show("Não selecionou nenhum campo para a pesquisa", "Sem campo para pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Erro", str_erro, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class