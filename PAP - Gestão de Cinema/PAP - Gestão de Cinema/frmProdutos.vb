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
        str_erro += verificacao(txtNome)
        str_erro += verificacao(cmbGeneros)
        str_erro += verificacao(nmrPreco)
        str_erro += verificacao(nmrStock)
        str_erro += verificacao(ofdImagem)

        If str_erro = "" Then
            'Limpo os objetos input do formulário
            txtNome.Text = ""

            cmbGeneros.Text = ""

            nmrPreco.Value = 0

            nmrStock.Value = 0
            If cmbGeneros.SelectedValue IsNot Nothing Then
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
                    acao("inserir", ligacao, "insert into genero (nome) values ('" + cmbGeneros.Text + "')", 0)

                    'Descobrir o codLo dessa localidade
                    comando = New MySqlCommand("select codG from generos where nome='" + cmbGeneros.Text + "'", ligacao)
                    ligacao.Open()
                    leitor = comando.ExecuteReader
                    leitor.Read()
                    codLo = leitor.GetInt32("codG")
                    ligacao.Close()

                    Using picture As Image = Image.FromFile(ofdImagem.FileName)
                        'Create an empty stream in memory.'
                        Using stream As New IO.MemoryStream
                            acao("inserir", ligacao, "insert into produtos (nome,stock,preco,codG,imagem,ativado) " &
                            "values ('" + txtNome.Text + "', '" + nmrStock.Text + "', '" + nmrPreco.Text + "', " + codLo.ToString + "," + stream.GetBuffer().ToString + "',1)", 1)
                        End Using
                    End Using

                    encher(cmbGeneros, ligacao, "generos", "nome", "codG", "select codG, nome from generos")
                    MessageBox.Show("O género " + cmbGeneros.Text + "foi inserido sem qualquer problema", "Insersão realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ligacao.Close()
                    MessageBox.Show("O género " + cmbGeneros.Text + " não foi inserido: " + ex.Message, "Insersão sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            cmbGeneros.Text = ""
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
        End If
    End Sub

    Private Sub lblGenero_MouseEnter(sender As Object, e As System.EventArgs) Handles lblGenero.MouseEnter, cmbGeneros.SelectedValueChanged
        cmbGeneros.Show()
        cmbGeneros.Select()
    End Sub
    Private Sub txtGenero_LostFocus() Handles cmbGeneros.LostFocus
        cmbGeneros.Hide()
        If cmbGeneros.Text <> "" Then
            lblGenero.Text = cmbGeneros.Text
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
        End If
    End Sub

    Private Sub frmProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        encher(cmbGeneros, ligacao, "generos", "nome", "codG", "select codG, nome from generos")
        cmbGeneros.Text = ""
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
End Class