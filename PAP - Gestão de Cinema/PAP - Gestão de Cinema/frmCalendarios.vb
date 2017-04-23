Imports MySql.Data.MySqlClient
Public Class frmCalendarios
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        'CtrL_MenuCine.Sincronizar_acessos(Me, 5)
    End Sub

    Private Sub ver()
        'Aqui é preciso: 1º limpar o pnlGrade; 2º criar uma TableLayoutPanel (igual à tlpGrade) e colocá-la no painel
        'Colocar as sessões, usando a respetiva classe, da BD
    End Sub

    Private Sub frmCalendarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pnlProibicao.Location = New Point(0, 3)
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False

        ver()

        'Aqui, encho as combobox com dados para o utilizador escolher
        encher(cmbFilme, ligacao, "filmes", "nome", "codfl", "select codfl, nome from filmes")
        cmbFilme.Text = ""
        encher(cmbSala, ligacao, "salas", "cods", "cods", "select cods from salas")
        cmbSala.Text = ""
        encher(cmbSalaS, ligacao, "salas", "cods", "cods", "select cods from salas")
        cmbSalaS.Text = ""
    End Sub

    Private Sub btnOutro_Click(sender As System.Object, e As System.EventArgs) Handles btnOutro.Click
        If frmLogin.ass(5).permissao(2) Then
            CtrL_MenuCine.IrParaClientes()
        Else
            MessageBox.Show("Não tem permissão para inserir novos filmes", "Insersão impossível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class