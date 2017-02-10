Imports MySql.Data.MySqlClient
Public Class frmHome
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    Public Const DIMLBL As Integer = 7
    Dim lblI(DIMLBL) As Label
    Public Const ESPACAMENTO As Integer = 6
    Dim cont_lbl As Integer = 0

    'Código tipo para todos os formulários
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.SelecionarBotao(0)
    End Sub

    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblI(0) = lblx1
        lblI(1) = lblx2
        lblI(2) = lblx3
        lblI(3) = lblx4
        lblI(4) = lblx5
        lblI(5) = lblx6
        lblI(6) = lblx7


        pnlLugares.Hide()
        pnlClientes.Hide()
        pnlFuncionarios.Hide()
        pnlEncargos.Hide()
        pnlCalendarios.Hide()
        pnlProdutos.Hide()
        pnlSalas.Hide()
        pnlVendas.Hide()

        Dim nome = "", nome_completo As String
        query = "select Funcionarios.nome as nome, Encargos.nome as encargo, IFNULL(telemovel,'') as telemovel, localidades.nome as localidade, TIMESTAMPDIFF(year, datanasc, CURDATE()) as idade, ordenado, IFNULL(rua,'') as rua, IFNULL(ordenado,'') as ordenado from funcionarios, encargos, localidades where localidades.codlo=funcionarios.codlo and funcionarios.code=encargos.code and codF=" + frmLogin.codF.ToString

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


        'Novo Código ////////////////////////////////////// EXPERIMENTAL

        If leitor.GetString("nome") <> "" Then
            lblI(cont_lbl).Text = leitor.GetString("nome")
            cont_lbl += 1
        End If
        If leitor.GetString("encargo") <> "" Then
            lblI(cont_lbl).Text = leitor.GetString("encargo")
            cont_lbl += 1
        End If
        If leitor.GetString("telemovel") <> "" Then
            lblI(cont_lbl).Text = leitor.GetString("telemovel")
            cont_lbl += 1
        End If
        If leitor.GetString("rua") <> "" Then
            lblI(cont_lbl).Text = leitor.GetString("rua")
            cont_lbl += 1
        End If
        If leitor.GetString("localidade") <> "" Then
            lblI(cont_lbl).Text = leitor.GetString("localidade")
            cont_lbl += 1
        End If
        If leitor.GetInt32("idade").ToString <> "" Then
            lblI(cont_lbl).Text = leitor.GetInt32("idade").ToString + " anos"
            cont_lbl += 1
        End If
        If leitor.GetInt32("ordenado").ToString Then
            lblI(cont_lbl).Text = leitor.GetInt32("ordenado").ToString + " €/mês"
        End If
        ligacao.Dispose()

        lblx1.Location = New Point(pnlAndante.Size.Width, 0)
        For x As Integer = 1 To DIMLBL - 1 ' Tem de começar no 1 porque a localização da lbl(0), que é igual a lblNome, já está definida e tem sempre texto
            If lblI(x).Text <> "" Then
                lblI(x).Location = New Point(lblI(x - 1).Location.X + lblI(x - 1).Size.Width + ESPACAMENTO, 0)
            End If
        Next

        tmr.Start()
        'Novo Código /////////////////////////

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

    Private Sub tmr_Tick(sender As System.Object, e As System.EventArgs) Handles tmr.Tick
        For x As Integer = 0 To cont_lbl
            lblI(x).Location = New Point(lblI(x).Location.X - 1, 0)
            If lblI(x).Location.X = -lblI(x).Size.Width Then
                If x = 0 Then
                    lblI(0).Location = New Point(lblI(cont_lbl).Location.X + lblI(cont_lbl).Width + ESPACAMENTO * 50)
                Else
                    lblI(x).Location = New Point(lblI(x - 1).Location.X + lblI(x - 1).Width + ESPACAMENTO)
                End If
            End If
        Next
    End Sub

    Private Sub pctVendas_Click(sender As System.Object, e As System.EventArgs) Handles pctVendas.Click, lbl_Vendas.Click, lblVendas.Click, pnlVendas.Click
        Me.Hide()
        frmVendas.Show()
    End Sub


    Private Sub lbl_Clientes_Click(sender As System.Object, e As System.EventArgs) Handles lbl_Clientes.Click, lblClientes.Click, pctClientes.Click, pnlClientes.Click
        Me.Hide()
        frmClientes.Show()
    End Sub

    Private Sub Parar_Texto(sender As System.Object, e As System.EventArgs) Handles lblx1.MouseHover, lblx1.MouseHover, lblx2.MouseHover, lblx7.MouseHover, lblx5.MouseHover, lblx6.MouseHover, lblx3.MouseHover, lblx4.MouseHover
        tmr.Stop()
    End Sub

    Private Sub Retomar_Texto(sender As System.Object, e As System.EventArgs) Handles lblx1.MouseLeave, lblx1.MouseLeave, lblx2.MouseLeave, lblx7.MouseLeave, lblx5.MouseLeave, lblx6.MouseLeave, lblx3.MouseLeave, lblx4.MouseLeave
        tmr.Start()
    End Sub
End Class