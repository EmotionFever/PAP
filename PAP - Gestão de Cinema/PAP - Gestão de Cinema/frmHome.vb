Imports MySql.Data.MySqlClient
Public Class frmHome
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    'Código tipo para todos os formulários
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.SelecionarBotao(0)
    End Sub



    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlLugares.Hide()
        pnlClientes.Hide()
        pnlFuncionarios.Hide()
        pnlEncargos.Hide()
        pnlCalendarios.Hide()
        pnlProdutos.Hide()
        pnlSalas.Hide()
        pnlVendas.Hide()

        Dim nome = "", nome_completo As String
        query = "select Funcionarios.nome as nome, Encargos.nome as encargo, telemovel, localidades.nome as localidade, TIMESTAMPDIFF(datanasc, '1970-02-01', CURDATE()) as idade, ordenado, rua from funcionarios, encargos, localidades where localidades.codlo=funcionarios.codlo and funcionarios.code=encargos.code and codF=" + frmLogin.codF.ToString

        comando = New MySqlCommand(query, ligacao)
        ligacao.Open()
        leitor = comando.ExecuteReader
        leitor.Read()
        nome_completo = leitor.GetString("nome")

        'Código para mostrar apenas o 1º nome
        For y As Integer = 0 To nome_completo.Length - 1
            If nome_completo(y) = " " Then
                nome = nome_completo.Remove(y, nome_completo.Length - y)
                Exit For
            End If
        Next
        lblPergunta.Text = "O que deseja fazer, " + nome + "?"

        lblNome.Text = leitor.GetString("nome")
        lblFuncao.Text = leitor.GetString("encargo")
        lblTlm.Text = leitor.GetString("telemovel")
        lblmorada.Text = leitor.GetString("localidade")
        ligacao.Dispose()

        '2ª ligação

        query = "select tabelas.nome as tabela, group_concat(' ',permissoes.nome) as permissoes from funcionarios, encargos, aux_enc, permissoes, tabelas where funcionarios.codE=encargos.codE and  encargos.codE=aux_enc.codE and aux_enc.codPe=permissoes.codPe and tabelas.codTa=aux_enc.codta and codF=" + frmLogin.codF.ToString + " group by tabelas.nome"

        comando = New MySqlCommand(query, ligacao)
        ligacao.Open()

        leitor = comando.ExecuteReader
        While leitor.Read
            If leitor.GetString("tabela").Contains("Lugares") Then
                pnlLugares.Show()
                lblLugares.Text = "Pode" + leitor.GetString("permissoes") + " lugares"
            End If

            If leitor.GetString("tabela").Contains("Clientes") Then
                pnlClientes.Show()
                lblClientes.Text = "Pode" + leitor.GetString("permissoes") + " clientes"
            End If

            If leitor.GetString("tabela").Contains("Funcionarios") Then
                pnlFuncionarios.Show()
                lblFuncionarios.Text = "Pode" + leitor.GetString("permissoes") + " funcionários"
            End If

            If leitor.GetString("tabela").Contains("Encargos") Then
                pnlEncargos.Show()
                lblEncargos.Text = "Pode" + leitor.GetString("permissoes") + " encargos"
            End If

            If leitor.GetString("tabela").Contains("Calendarios") Then
                pnlCalendarios.Show()
                lblCalendarios.Text = "Pode" + leitor.GetString("permissoes") + " calendários de salas"
            End If

            If leitor.GetString("tabela").Contains("Produtos") Then
                pnlProdutos.Show()
                lblProdutos.Text = "Pode" + leitor.GetString("permissoes") + " produtos"
            End If

            If leitor.GetString("tabela").Contains("Salas") Then
                pnlSalas.Show()
                lblSalas.Text = "Pode" + leitor.GetString("permissoes") + " salas"
            End If

            If leitor.GetString("tabela").Contains("Vendas") Then
                pnlVendas.Show()
                lblVendas.Text = "Pode" + leitor.GetString("permissoes") + " vendas"
            End If
        End While
        ligacao.Dispose()
    End Sub

    Private Sub frmHome_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub


    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles lbl453.Click

    End Sub

    Private Sub lblLocal_Click(sender As System.Object, e As System.EventArgs) Handles lblmorada.Click

    End Sub
End Class