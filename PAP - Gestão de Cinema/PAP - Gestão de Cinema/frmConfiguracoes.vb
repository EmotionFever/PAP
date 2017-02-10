Imports MySql.Data.MySqlClient
Public Class frmConfiguracoes
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    Dim DS As DataSet = New DataSet

    Private Sub frmConfiguracoes_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Atualizar_dados()
        query = "select Funcionarios.nome as nome, IFNULL(telemovel,'-') as telemovel, ifnull(localidades.nome,'-') as localidade, ifnull(TIMESTAMPDIFF(year, datanasc, CURDATE()),0) as idade, day(datanasc) as dia, month(datanasc) as mes, year(datanasc) as ano, IFNULL(rua,'-') as rua, ifnull(localidades.codlo,0) as codlo from funcionarios left join localidades on localidades.codlo=funcionarios.codlo where codF=" + frmLogin.codF.ToString

        comando = New MySqlCommand(query, ligacao)
        ligacao.Open()
        leitor = comando.ExecuteReader
        leitor.Read()

        lblNome.Text = leitor.GetString("nome")
        lblIdade.Text = leitor.GetString("idade") + " anos" 'pode dar erro
        lblRua.Text = leitor.GetString("rua")
        lblLocalidade.Text = leitor.GetString("localidade")
        lblTlm.Text = leitor.GetString("telemovel")
        ligacao.Dispose()
    End Sub

    Private Sub frmConfiguracoes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        query = "select Funcionarios.nome as nome, IFNULL(telemovel,'-') as telemovel, ifnull(localidades.nome,'-') as localidade, ifnull(TIMESTAMPDIFF(year, datanasc, CURDATE()),0) as idade, day(datanasc) as dia, month(datanasc) as mes, year(datanasc) as ano, IFNULL(rua,'-') as rua, ifnull(localidades.codlo,0) as codlo from funcionarios left join localidades on localidades.codlo=funcionarios.codlo where codF=" + frmLogin.codF.ToString
        Dim codLo As Integer

        comando = New MySqlCommand(query, ligacao)
        ligacao.Open()
        leitor = comando.ExecuteReader
        leitor.Read()

        lblNome.Text = leitor.GetString("nome")
        lblIdade.Text = leitor.GetString("idade") + " anos" 'pode dar erro
        lblRua.Text = leitor.GetString("rua")
        lblLocalidade.Text = leitor.GetString("localidade")
        lblTlm.Text = leitor.GetString("telemovel")

        txtnome.Text = leitor.GetString("nome")
        dtpDatanasc.Value = leitor.GetInt32("dia").ToString + "/" + leitor.GetInt32("mes").ToString + "/" + leitor.GetInt32("ano").ToString
        txtrua.Text = leitor.GetString("rua")
        mtbTlm.Text = leitor.GetString("telemovel")
        codLo = leitor.GetInt32("codlo")
        ligacao.Dispose()

        'ligação para encher a combobox
        adapter.SelectCommand = New MySqlCommand
        adapter.SelectCommand.Connection = ligacao
        adapter.SelectCommand.CommandText = "select * from localidades"

        ligacao.Open()
        adapter.Fill(DS, "localidades")
        ligacao.Close()

        cmblocalidade.DataSource = DS.Tables("localidades")
        cmblocalidade.DisplayMember = "nome"
        cmblocalidade.ValueMember = "codlo"
        If codLo <> 0 Then
            cmblocalidade.SelectedValue = codLo
        Else
            cmblocalidade.Text = ""
        End If
    End Sub

    Private Sub btnNome_Click(sender As System.Object, e As System.EventArgs) Handles btnNome.Click
        If txtnome.Text <> "" Then
            comando.Connection = ligacao
            comando.CommandText = "update funcionarios set nome='" + txtnome.Text + "' where codF=" + frmLogin.codF.ToString
            ligacao.Open()
            comando.ExecuteNonQuery()
            ligacao.Close()

            MessageBox.Show("O seu antigo nome, '" + lblNome.Text + "' foi alterado para '" + txtnome.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
        Else
            MessageBox.Show("Para guardar um nome tem de ter escrito um", "Campo Nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnRua_Click(sender As System.Object, e As System.EventArgs) Handles btnRua.Click
        If txtrua.Text <> "" Then
            comando.Connection = ligacao
            comando.CommandText = "update funcionarios set rua='" + txtrua.Text + "' where codF=" + frmLogin.codF.ToString
            ligacao.Open()
            comando.ExecuteNonQuery()
            ligacao.Close()

            MessageBox.Show("A sua antiga rua, '" + lblRua.Text + "' foi alterado para '" + txtrua.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
        Else
            MessageBox.Show("Para guardar uma rua tem de ter escrito uma", "Campo Rua vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnDatanasc_Click(sender As System.Object, e As System.EventArgs) Handles btnDatanasc.Click
        comando.Connection = ligacao
        comando.CommandText = "update funcionarios set datanasc='" + dtpDatanasc.Value.Year.ToString + "-" + dtpDatanasc.Value.Month.ToString + "-" + dtpDatanasc.Value.Day.ToString + "' where codF=" + frmLogin.codF.ToString
        ligacao.Open()
        comando.ExecuteNonQuery()
        ligacao.Close()

        MessageBox.Show("A sua data de nascimento foi alterado para " + dtpDatanasc.Value.Day.ToString + "/" + dtpDatanasc.Value.Month.ToString + "/" + dtpDatanasc.Value.Year.ToString + ".", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Atualizar_dados()
    End Sub

    Private Sub btnLocalidade_Click(sender As System.Object, e As System.EventArgs) Handles btnLocalidade.Click
        If cmblocalidade.Text <> "" Then
            comando.Connection = ligacao
            comando.CommandText = "update funcionarios set codlo=" + cmblocalidade.SelectedValue.ToString + " where codF=" + frmLogin.codF.ToString
            ligacao.Open()
            comando.ExecuteNonQuery()
            ligacao.Close()

            MessageBox.Show("A sua antiga localidade, '" + lblLocalidade.Text + "' foi alterado para '" + cmblocalidade.Text + "'.", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
        Else
            MessageBox.Show("Tem de escolher uma localidade. Caso a que queira não esteja na lista carregue no botão ao lado que diz 'Outra'.", "Não selecionou uma localidade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnTlm_Click(sender As System.Object, e As System.EventArgs) Handles btnTlm.Click
        If mtbTlm.Text.Length = 9 Then
            comando.Connection = ligacao
            comando.CommandText = "update funcionarios set telemovel='" + mtbTlm.Text + "' where codF=" + frmLogin.codF.ToString
            ligacao.Open()
            comando.ExecuteNonQuery()
            ligacao.Close()

            MessageBox.Show("O seu antigo número de telemóvel, " + lblTlm.Text + " foi alterado para " + mtbTlm.Text + ".", "Alteração salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Atualizar_dados()
        Else
            MessageBox.Show("Um número de telemóvel tem de ter 9 números", "Número de telemóvel invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.SelecionarBotao(9)
        CtrL_MenuCine.Sincronizar_acessos()
    End Sub
End Class