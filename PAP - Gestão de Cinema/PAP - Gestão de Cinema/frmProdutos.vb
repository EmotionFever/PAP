Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading
Public Class frmProdutos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Dim prod(ter(ligacao, "quantidade", "select count(codP) as quantidade from produtos where ativado=1")) As Produto

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        'CtrL_MenuCine.Sincronizar_acessos(Me, 6)
    End Sub

    Private Sub ProdutoClicado(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button) 'Este botão ganha todas as características do botão clicado

        lblNomeP.Text = prod(CInt(btnx.Tag)).lblNome.Text
        pctImagemP.BackgroundImage = prod(CInt(btnx.Tag)).btnImagem.BackgroundImage
        lblGeneroP.Text = prod(CInt(btnx.Tag)).lblGenero.Text
        lblPrecoP.Text = prod(CInt(btnx.Tag)).lblPreco.Text
        lblStockP.Text = prod(CInt(btnx.Tag)).lblStock.Text
    End Sub

    Private Sub ver()
        Dim cont_prod As Integer = 0


        comando = New MySqlCommand("select codP, produtos.nome as produto, produtos.codG as codG, generos.nome as genero, preco, stock, imagem from produtos, generos where produtos.codG=generos.codG and ativado=1", ligacao)

        '-------------------------------------------------------------------------------------------------------------- Em construção
        ligacao.Open()
        leitor = comando.ExecuteReader
        While leitor.Read
            prod(cont_prod) = New Produto
            If Not IsDBNull(leitor.Item("imagem")) Then
                Dim lb() As Byte = leitor.Item("imagem")
                Dim lstr As New System.IO.MemoryStream(lb)
                prod(cont_prod).criar_prod(leitor.GetInt32("codP"), leitor.GetString("produto"), Image.FromStream(lstr), leitor.GetDouble("preco"), leitor.GetInt32("codG"), leitor.GetString("genero"), leitor.GetInt32("stock"), cont_prod, flpProdAtiv)
            Else
                prod(cont_prod).criar_prod(leitor.GetInt32("codP"), leitor.GetString("produto"), leitor.GetDouble("preco"), leitor.GetInt32("codG"), leitor.GetString("genero"), leitor.GetInt32("stock"), cont_prod, flpProdAtiv)
            End If
            AddHandler prod(cont_prod).btnImagem.Click, AddressOf ProdutoClicado
            cont_prod += 1
        End While
        ligacao.Close()

        '--------------------------------------------------------------------------------------------

    End Sub

    Private Sub LimparTudo()
        txtNome.Text = ""
        lblNome.Text = "Nome da Produto"

        cmbGenero.Text = ""
        lblGenero.Text = "Género"

        nmrPreco.Value = 0
        lblPreco.Text = "Preço"

        nmrStock.Value = 0
        lblStock.Text = "Stock"

        lblImgNome.Text = "---"
        ofdImagem.FileName = ""
        btnImagem.BackgroundImage = My.Resources.produtos
    End Sub

    Private Sub frmProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ver()
        encher(cmbGenero, ligacao, "generos", "nome", "codG", "select codG, nome from generos")
        cmbGenero.Text = ""
        cmbGenero_LostFocus()
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim codG As Integer
        Dim str_erro As String = ""

        str_erro += verificacao(txtNome)
        str_erro += verificacao(cmbGenero)
        str_erro += verificacao(nmrPreco)
        str_erro += verificacao(nmrStock)
        'str_erro += verificacao(ofdImagem)
        If str_erro = "" Then

            If cmbGenero.SelectedValue IsNot Nothing Then
                codG = cmbGenero.SelectedValue
            Else
                Try
                    'Inserir o novo genero
                    acao("inserir", ligacao, "insert into generos (nome) values ('" + cmbGenero.Text + "')", 0)

                    'Descobrir o codG desse género
                    codG = ter(ligacao, "codG", "select codG from generos where nome='" + cmbGenero.Text + "'")

                    encher(cmbGenero, ligacao, "generos", "nome", "codG", "select codG, nome from generos")
                Catch ex As Exception
                    ligacao.Close()
                    MessageBox.Show("O género '" + cmbGenero.Text + "' não foi inserido: " + ex.Message, "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If ofdImagem.FileName <> "" Then
                acao_c_Imagem("inserir", ligacao, "insert into produtos (nome,stock,preco,codG,imagem,ativado) " &
                            "values ('" + txtNome.Text + "', " + nmrStock.Value.ToString + ", " + nmrPreco.Value.ToString.Replace(",", ".") + ", " + codG.ToString + ",?Imagem,1)", Image.FromFile(ofdImagem.FileName), 1)
            Else
                acao("inserir", ligacao, "insert into produtos (nome,stock,preco,codG,imagem,ativado) " &
                            "values ('" + txtNome.Text + "', " + nmrStock.Value.ToString + ", " + nmrPreco.Value.ToString.Replace(",", ".") + ", " + codG.ToString + ",?Imagem,1)", 1)
            End If


            'Limpo os objetos input do formulário
            LimparTudo()
            MessageBox.Show("O género '" + cmbGenero.Text + "' foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(str_erro, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub lblNome_MouseEnter(sender As Object, e As System.EventArgs) Handles lblNome.MouseEnter
        txtNome.Show()
        txtNome.Select()
    End Sub
    Private Sub txtNome_LostFocus(sender As Object, e As System.EventArgs) Handles txtNome.LostFocus
        txtNome.Hide()
        If txtNome.Text <> "" Then
            lblNome.Text = txtNome.Text
        Else
            lblNome.Text = "Nome do Produto"
        End If
    End Sub

    Private Sub lblGenero_MouseEnter(sender As Object, e As System.EventArgs) Handles lblGenero.MouseEnter
        cmbGenero.Show()
        cmbGenero.Select()
        If lblGenero.Text = "Género" Then
            cmbGenero.Text = ""
        End If
    End Sub
    Private Sub cmbGenero_LostFocus() Handles cmbGenero.LostFocus
        cmbGenero.Hide()
        If cmbGenero.Text <> "" Then
            lblGenero.Text = cmbGenero.Text
        Else
            lblGenero.Text = "Género"
        End If
    End Sub

    Private Sub lblPreco_MouseEnter(sender As Object, e As System.EventArgs) Handles lblPreco.MouseEnter, nmrPreco.ValueChanged
        nmrPreco.Show()
        nmrPreco.Select()
    End Sub
    Private Sub nmrPreco_lostfocus(sender As Object, e As System.EventArgs) Handles nmrPreco.LostFocus
        nmrPreco.Hide()
        If nmrPreco.Value <> 0 Then
            lblPreco.Text = String.Format("{0:F2}", nmrPreco.Value)
        Else
            lblPreco.Text = "Preço"
        End If
    End Sub

    Private Sub lblStock_MouseEnter(sender As Object, e As System.EventArgs) Handles lblStock.MouseEnter, nmrStock.ValueChanged
        nmrStock.Show()
        nmrStock.Select()
    End Sub
    Private Sub nmrStock_LostFocus(sender As Object, e As System.EventArgs) Handles nmrStock.LostFocus
        nmrStock.Hide()
        If nmrStock.Value <> 0 Then
            lblStock.Text = nmrStock.Value
        Else
            lblStock.Text = "Stock"
        End If
    End Sub

    Private Sub btnAdi_Click(sender As System.Object, e As System.EventArgs) Handles btnAdi.Click

        If ofdImagem.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso ofdImagem.FileName <> "" Then
            If ofdImagem.SafeFileName.EndsWith(".jpg") Then
                Try
                    btnImagem.BackgroundImage = Image.FromFile(ofdImagem.FileName)
                    lblImgNome.Text = ofdImagem.SafeFileName
                    btnAdi.Show()
                Catch ex As Exception
                    MessageBox.Show("A imagem que escolheu está imagem corrompida", "Imagem corrompida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("O ficheiro que escolheu não é do tipo jpg, logo terá de o converter primeiro para este tipo.", "Imagem inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnRem_Click(sender As System.Object, e As System.EventArgs) Handles btnRem.Click
        lblImgNome.Text = "---"
        ofdImagem.FileName = ""
        btnImagem.BackgroundImage = My.Resources.produtos
    End Sub
End Class