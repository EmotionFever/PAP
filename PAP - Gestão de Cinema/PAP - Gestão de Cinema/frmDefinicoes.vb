Imports MySql.Data.MySqlClient
Public Class frmDefinicoes
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    Dim DS As DataSet = New DataSet
    Dim lbl As Label
    Public Const VEZESQUEPISCA As Integer = 4 'Este número pode-se alterar
    Dim npisca As Integer = 0
    Dim codLo As Integer
    Private Sub Atualizar_dados()
        Try
            query = "select username, Funcionarios.nome as nome, IFNULL(telemovel,'-') as telemovel, ifnull(localidades.nome,'-') as localidade, " &
            "ifnull(TIMESTAMPDIFF(year, datanasc, CURDATE()),'-') as idade, ifnull(day(datanasc),0) as dia, ifnull(month(datanasc),0) as mes, " &
            "ifnull(year(datanasc),0) as ano, IFNULL(rua,'-') as rua, ifnull(localidades.codlo,0) as codlo, ifnull(palavra_passe,'') as palavra_passe " &
            "from funcionarios left join localidades on localidades.codlo=funcionarios.codlo where codF=" + codF.ToString


            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            leitor.Read()

            lblNome.Text = leitor.GetString("nome")
            lblUsername.Text = leitor.GetString("username")
            If leitor.GetString("idade") <> "-" Then
                lblIdade.Text = leitor.GetString("idade") + " anos"
            Else
                lblIdade.Text = "-"
            End If
            lblRua.Text = leitor.GetString("rua")
            lblLocalidade.Text = leitor.GetString("localidade")
            lblTlm.Text = leitor.GetString("telemovel")

            txtnome.Text = leitor.GetString("nome")
            txtUsername.Text = leitor.GetString("username")
            If leitor.GetInt32("dia") > 0 Then
                dtpDatanasc.Value = leitor.GetInt32("dia").ToString + "/" + leitor.GetInt32("mes").ToString + "/" + leitor.GetInt32("ano").ToString
            End If

            If leitor.GetString("rua") = "-" Then
                txtrua.Text = ""
            Else
                txtrua.Text = leitor.GetString("rua")
            End If
            If leitor.GetString("telemovel") = "-" Then
                mtbTlm.Text = ""
            Else
                mtbTlm.Text = leitor.GetString("telemovel")
            End If

            txtPass.Text = leitor.GetString("palavra_passe")

            codLo = leitor.GetInt32("codlo")
            ligacao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro a Atualizar dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
    End Sub

    Private Sub EncherComboBox()
        'ligação para encher a combobox
        encher(cmblocalidade, ligacao, "localidades", "nome", "codlo", "select codlo, nome from localidades")

        'Seleciona a opção acabadinha de criar
        If codLo > 0 Then
            cmblocalidade.SelectedValue = codLo
        Else
            cmblocalidade.Text = ""
        End If
    End Sub

    Private Sub frmConfiguracoes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Atualizar_dados()
        EncherComboBox()

        lblEncargo.Text = "Permissões para " + mdlAcoes.encargo
        'Cógigo que faz com que o flpTabelas funcione
        For z_ As Integer = 1 To mdlAcoes.DIMTA - 2 ' Tenho de excluir o frmHome e o frmDefinicoes
            ass(z_).criar_acesso(flp)
        Next
    End Sub

    Private Sub btnNome_Click(sender As System.Object, e As System.EventArgs) Handles btnNome.Click
        If txtnome.Text <> "" Then
            If txtnome.Text(0) <> " " Then
                acao("alterar", ligacao, "update funcionarios set nome='" + txtnome.Text + "' where codF=" + mdlAcoes.codF.ToString, 0)

                MessageBox.Show("O seu antigo nome, '" + lblNome.Text + "', foi alterado para '" + txtnome.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Atualizar_dados()
                lbl = lblNome
                npisca = 0
                tmrPiscar.Start()
            Else
                MessageBox.Show("Deixou um espaço no início do nome", "Campo Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Para guardar um nome não pode começar com um espaço ' '.", "Campo Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnRua_Click(sender As System.Object, e As System.EventArgs) Handles btnRua.Click
        If txtrua.Text <> "" Then
            acao("alterar", ligacao, "update funcionarios set rua='" + txtrua.Text + "' where codF=" + mdlAcoes.codF.ToString, 0)

            MessageBox.Show("A sua antiga rua, '" + lblRua.Text + "', foi alterada para '" + txtrua.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
            lbl = lblRua
            npisca = 0
            tmrPiscar.Start()
        Else
            MessageBox.Show("Para guardar uma rua tem de ter escrito uma", "Campo Rua vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnDatanasc_Click(sender As System.Object, e As System.EventArgs) Handles btnDatanasc.Click
        If DateDiff(DateInterval.Year, dtpDatanasc.Value.Date, Now) >= 16 Then
            acao("alterar", ligacao, "update funcionarios set datanasc='" + dtpDatanasc.Value.Year.ToString + "-" + dtpDatanasc.Value.Month.ToString + "-" + dtpDatanasc.Value.Day.ToString + "' where codF=" + mdlAcoes.codF.ToString, 0)

            MessageBox.Show("A sua data de nascimento foi alterada para " + dtpDatanasc.Value.Day.ToString + "/" + dtpDatanasc.Value.Month.ToString + "/" + dtpDatanasc.Value.Year.ToString + ".", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
            lbl = lblIdade
            npisca = 0
            tmrPiscar.Start()
        Else
            MessageBox.Show("Tem de ter mais de 16 anos para trabalhar", "Data de nascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnLocalidade_Click(sender As System.Object, e As System.EventArgs) Handles btnLocalidade.Click
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
                'Associá-la ao registo do funcionário

                EncherComboBox()
            End If
            acao("alterar", ligacao, "update funcionarios set codlo=" + codLo.ToString + " where codF=" + mdlAcoes.codF.ToString, 0)
            MessageBox.Show("A sua antiga localidade, '" + lblLocalidade.Text + "', foi alterada para '" + cmblocalidade.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
            lbl = lblLocalidade
            npisca = 0
            tmrPiscar.Start()
        Else
            MessageBox.Show("Tem de escolher uma localidade. Caso a que queira não esteja na lista carregue no botão ao lado que diz 'Outra'.", "Não selecionou uma localidade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnTlm_Click(sender As System.Object, e As System.EventArgs) Handles btnTlm.Click
        If mtbTlm.Text.Length = 9 Then
            acao("alterar", ligacao, "update funcionarios set telemovel='" + mtbTlm.Text + "' where codF=" + mdlAcoes.codF.ToString, 0)

            MessageBox.Show("O seu antigo número de telemóvel, " + lblTlm.Text + ", foi alterado para " + mtbTlm.Text + ".", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
            lbl = lblTlm
            npisca = 0
            tmrPiscar.Start()
        Else
            MessageBox.Show("Um número de telemóvel tem de ter 9 dígitos", "Número de telemóvel invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPass_Click(sender As System.Object, e As System.EventArgs) Handles btnPass.Click
        If txtPass.Text <> "" Then
            acao("alterar", ligacao, "update funcionarios set palavra_passe='" + txtPass.Text + "' where codF=" + mdlAcoes.codF.ToString, 0)

            MessageBox.Show("A sua palavra-passe foi alterada para '" + txtPass.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Para guardar uma palavra-passe tem de ter escrito uma", "Campo Password vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 9)
    End Sub

    Private Sub tmrPiscar_Tick(sender As System.Object, e As System.EventArgs) Handles tmrPiscar.Tick
        npisca += 1
        If npisca <= VEZESQUEPISCA * 2 Then
            If lbl.Visible Then
                lbl.Hide()
            Else
                lbl.Show()
            End If
        Else
            tmrPiscar.Stop()
        End If
    End Sub

    Private Sub chkTexto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTexto.CheckStateChanged
        If txtPass.UseSystemPasswordChar Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnUsername_Click(sender As System.Object, e As System.EventArgs) Handles btnUsername.Click
        If txtUsername.Text <> "" Then
            query = "select username from funcionarios where username='" + txtUsername.Text + "'"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            If Not leitor.Read Then
                ligacao.Close()
                acao("alterar", ligacao, "update funcionarios set username='" + txtUsername.Text + "' where codF=" + mdlAcoes.codF.ToString, 0)
                MessageBox.Show("O seu antigo nome de utilizador, '" + lblUsername.Text + "', foi alterado para '" + txtUsername.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Atualizar_dados()
                lbl = lblUsername
                npisca = 0
                tmrPiscar.Start()
            Else
                ligacao.Close()
                MessageBox.Show("O nome de utilizador '" + txtUsername.Text + "' já foi atribuído", "Username não único", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Para guardar um nome de utilizador tem de ter escrito um", "Campo Username vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmDefinicoes_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub
End Class