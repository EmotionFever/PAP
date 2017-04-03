Imports MySql.Data.MySqlClient
Public Class frmProdutos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 6)
    End Sub

    Private Sub ver()

    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim codLo As Integer
        Dim str_erro As String = ""
        str_erro += verificacao(txtNome1)
        str_erro += verificacao(cmbGeneros1)
        str_erro += verificacao(nmrPreco1)
        str_erro += verificacao(nmrStock1)
        str_erro += verificacao(ofdImagem)

        If str_erro = "" Then
            'Limpo os objetos input do formulário
            txtNome1.Text = ""

            cmbGeneros1.Text = ""

            nmrPreco1.Value = 0

            nmrStock1.Value = 0
            If cmbGeneros1.SelectedValue IsNot Nothing Then
                'Insiro os dados na base de dados
                Using picture As Image = Image.FromFile(ofdImagem.FileName)
                    'Create an empty stream in memory.'
                    Using stream As New IO.MemoryStream
                        'acao("inserir", ligacao, "insert into produtos (nome,stock,preco,codG,imagem,ativado) " &
                        '"values ('" + txtNome.Text + "', '" + nmrStock.Text + "', '" + nmrPreco.Text + "', " + cmbGeneros.SelectedValue.ToString + "," + stream.GetBuffer().ToString + ",1)", 1)
                    End Using
                End Using
                'Volto a mostrar a tabela, desta vez, atualizada.
                ver()
            Else
                Try
                    'Inserir o novo genero
                    acao("inserir", ligacao, "insert into genero (nome) values ('" + cmbGeneros1.Text + "')", 0)

                    'Descobrir o codLo dessa localidade
                    comando = New MySqlCommand("select codG from generos where nome='" + cmbGeneros1.Text + "'", ligacao)
                    ligacao.Open()
                    leitor = comando.ExecuteReader
                    leitor.Read()
                    codLo = leitor.GetInt32("codG")
                    ligacao.Close()

                    Using picture As Image = Image.FromFile(ofdImagem.FileName)
                        'Create an empty stream in memory.'
                        Using stream As New IO.MemoryStream
                            acao("inserir", ligacao, "insert into produtos (nome,stock,preco,codG,imagem,ativado) " &
                            "values ('" + txtNome1.Text + "', '" + nmrStock1.Text + "', '" + nmrPreco1.Text + "', " + codLo.ToString + "," + stream.GetBuffer().ToString + "',1)", 1)
                        End Using
                    End Using

                    encher(cmbGeneros1, ligacao, "generos", "nome", "codG", "select codG, nome from generos")
                    MessageBox.Show("O género " + cmbGeneros1.Text + "foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ligacao.Close()
                    MessageBox.Show("O género " + cmbGeneros1.Text + " não foi inserido: " + ex.Message, "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            cmbGeneros1.Text = ""
        Else
            MessageBox.Show(str_erro, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub lblNome_MouseEnter(sender As Object, e As System.EventArgs) Handles lblNome.MouseEnter
        txtNome1.Show()
        txtNome1.Select()
    End Sub
    Private Sub txtNome_LostFocus(sender As Object, e As System.EventArgs) Handles txtNome1.LostFocus
        txtNome1.Hide()
        If txtNome1.Text <> "" Then
            lblNome.Text = txtNome1.Text
        End If
    End Sub

    Private Sub lblGenero_MouseEnter(sender As Object, e As System.EventArgs) Handles lblGenero.MouseEnter, cmbGeneros1.SelectedValueChanged
        cmbGeneros1.Show()
        cmbGeneros1.Select()
    End Sub
    Private Sub txtGenero_LostFocus() Handles cmbGeneros1.LostFocus
        cmbGeneros1.Hide()
        If cmbGeneros1.Text <> "" Then
            lblGenero.Text = cmbGeneros1.Text
        End If
    End Sub

    Private Sub lblPreco_MouseEnter(sender As Object, e As System.EventArgs) Handles lblPreco.MouseEnter, nmrPreco1.ValueChanged
        nmrPreco1.Show()
        nmrPreco1.Select()
    End Sub
    Private Sub nmrPreco_lostfocus(sender As Object, e As System.EventArgs) Handles nmrPreco1.LostFocus
        nmrPreco1.Hide()
        If nmrPreco1.Value <> 0 Then
            lblPreco.Text = String.Format("{0:F2}", nmrPreco1.Value)
        End If
    End Sub

    Private Sub lblStock_MouseEnter(sender As Object, e As System.EventArgs) Handles lblStock.MouseEnter, nmrStock1.ValueChanged
        nmrStock1.Show()
        nmrStock1.Select()
    End Sub
    Private Sub nmrStock_LostFocus(sender As Object, e As System.EventArgs) Handles nmrStock1.LostFocus
        nmrStock1.Hide()
        If nmrStock1.Value <> 0 Then
            lblStock.Text = nmrStock1.Value
        End If
    End Sub

    Private Sub frmProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        encher(cmbGeneros0, cmbGeneros1, ligacao, "generos", "nome", "codG", "select codG, nome from generos")
        cmbGeneros1.Text = ""
        txtGenero_LostFocus()
    End Sub

    Private Sub btnEscolher_Click(sender As System.Object, e As System.EventArgs) Handles btnEscolher.Click
        If ofdImagem.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso ofdImagem.FileName <> "" Then
            lblImgNome.Text = ofdImagem.SafeFileName
            pctImgLoc.BackgroundImage = Image.FromFile(ofdImagem.FileName)
            btnImagem.BackgroundImage = Image.FromFile(ofdImagem.FileName)
            btnXImg.Show()
        End If
    End Sub

    Private Sub btnXImg_Click(sender As System.Object, e As System.EventArgs) Handles btnXImg.Click
        lblImgNome.Text = "---"
        pctImgLoc.BackgroundImage = Nothing
        btnImagem.BackgroundImage = Nothing
        btnXImg.Hide()
    End Sub

    Private Sub txtGenero_LostFocus(sender As System.Object, e As System.EventArgs) Handles cmbGeneros1.LostFocus

    End Sub

    Private Sub tbc3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tbcFormulario.SelectedIndexChanged

    End Sub
End Class