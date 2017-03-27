Imports MySql.Data.MySqlClient
Public Class frmProdutos
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        'CtrL_MenuCine.Sincronizar_acessos(Me, 6)
    End Sub

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim codLo As Integer
        Dim str_erro As String = ""
        str_erro += verificacao(txtNome)
        str_erro += verificacao(txtGenero)
        str_erro += verificacao(nmrPreco)
        str_erro += verificacao(nmrStock)

        If str_erro = "" Then
            'Limpo os objetos input do formulário
            txtNome.Text = ""

            txtGenero.Text = ""

            nmrPreco.Value = 0

            nmrStock.Value = 0
            If cmblocalidade.SelectedValue IsNot Nothing Then
                'Insiro os dados na base de dados
                acao("inserir", ligacao, "insert into clientes (nome,NIF,rua,codlo,telemovel,ativado) " &
                "values ('" + txtNome.Text + "', '" + mtbNIF.Text + "', '" + txtRua.Text + "', " + cmblocalidade.SelectedValue.ToString + ",'" + mtbTlm.Text + "',1)", 1)

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
                    "values ('" + txtNome.Text + "', '" + mtbNIF.Text + "', '" + txtRua.Text + "', " + codLo.ToString + ",'" + mtbTlm.Text + "',1)", 1)

                    encher(cmblocalidade, ligacao, "localidades", "nome", "codlo", "select codlo, nome from localidades")
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



























        Dim query As String = "UPDATE MyTable SET Picture = @Picture WHERE ID = 1"
        comando = New MySqlCommand(query, ligacao)
        'Create an Image object.' 
        Using picture As Image = Image.FromFile("file path here")
            'Create an empty stream in memory.' 
            Using stream As New IO.MemoryStream
                'Fill the stream with the binary data from the Image.' 
                picture.Save(stream, Imaging.ImageFormat.Jpeg)
                'Get an array of Bytes from the stream and assign to the parameter.' 
                comando.Parameters.Add("@Picture", MySqlDbType.VarBinary).Value = stream.GetBuffer()
            End Using
        End Using
        ligacao.Open()
        comando.ExecuteNonQuery()
        ligacao.Close()
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

    Private Sub lblGenero_MouseEnter(sender As Object, e As System.EventArgs) Handles lblGenero.MouseEnter
        txtGenero.Show()
        txtGenero.Select()
    End Sub
    Private Sub txtGenero_LostFocus(sender As Object, e As System.EventArgs)
        txtGenero.Hide()
        If txtGenero.Text <> "" Then
            lblGenero.Text = txtGenero.Text
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

    Private Sub lblstock_MouseEnter(sender As Object, e As System.EventArgs) Handles lblStock.MouseEnter, nmrStock.ValueChanged
        nmrStock.Show()
        nmrStock.Select()
    End Sub
    Private Sub nmrStock_LostFocus(sender As Object, e As System.EventArgs) Handles nmrStock.LostFocus
        nmrStock.Hide()
        lblStock.Text = nmrStock.Value
    End Sub

    Private Sub frmProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        encher(cmbGeneros, ligacao, "generos", "nome", "codg", "select codg, nome from encargos")
        cmbGeneros.Text = ""
    End Sub
End Class