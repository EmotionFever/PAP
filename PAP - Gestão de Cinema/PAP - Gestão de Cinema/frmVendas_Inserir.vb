Imports MySql.Data.mysqlclient
Public Class frmVendas_Inserir
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim DS As DataSet = New DataSet
    Dim comando As MySqlCommand
    Dim DS1 As DataSet
    Dim constante As Integer
    Private Sub frmVendas_Inserir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim leitor As MySqlDataReader
        Dim query As String
        Dim n_registo As Integer

        Try
            query = "select count(codG) as registos from generos"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            leitor.Read()
            constante = leitor.GetInt32("registos")
            ligacao.Dispose()

            Dim btn(constante) As Button

            '2ª Ligação
            query = "select codG, nome from generos"
            comando = New MySqlCommand(query, ligacao)
            n_registo = 0

            ligacao.Open()
            leitor = comando.ExecuteReader
            While (leitor.Read)
                btn(n_registo) = New Button
                btn(n_registo).Size = New System.Drawing.Size(154, 61) 'atribuir tamanho
                btn(n_registo).Font = New Font("Arial", 10, FontStyle.Regular) 'atribuir tipo de letra
                btn(n_registo).BackColor = Color.CornflowerBlue
                btn(n_registo).FlatStyle = FlatStyle.Flat
                btn(n_registo).Text = leitor.GetString("nome")
                btn(n_registo).Tag = n_registo
                flpcategorias.Controls.Add(btn(n_registo)) 'Adicionar ao formulário

                n_registo += 1
            End While
            ligacao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try







        Try
            query = "select count(codP) as registos from produtos"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            leitor.Read()
            constante = leitor.GetInt32("registos")
            ligacao.Dispose()

            Dim pnl(constante) As Panel
            Dim lbl(constante * 3) As Label
            Dim pct(constante) As PictureBox

            '2ª Ligação
            query = "select codP, nome, stock, preco from produtos"
            comando = New MySqlCommand(query, ligacao)
            n_registo = 0

            ligacao.Open()
            leitor = comando.ExecuteReader
            While (leitor.Read)
                pnl(n_registo) = New Panel
                pnl(n_registo).Size = New System.Drawing.Size(289, 58) 'atribuir tamanho
                'pnl(n_registo).Location = New System.Drawing.Point(12, 180) 'atribuir uma localização
                pnl(n_registo).BackColor = Color.Silver
                pnl(n_registo).BorderStyle = BorderStyle.Fixed3D
                flpitens.Controls.Add(pnl(n_registo)) 'Adicionar ao formulário

                pct(n_registo) = New PictureBox
                pct(n_registo).Size = New System.Drawing.Size(54, 54)
                pct(n_registo).Location = New System.Drawing.Point(0, 0)
                'pct(n_registo).BackgroundImage = «« Imagem »» -------> <---------
                pct(n_registo).BackgroundImageLayout = ImageLayout.Zoom
                pnl(n_registo).Controls.Add(pct(n_registo))

                lbl(n_registo) = New Label
                lbl(n_registo).Location = New System.Drawing.Point(55, 0)
                lbl(n_registo).Font = New Font("Arial", 8, FontStyle.Bold)
                lbl(n_registo).Text = "Nome: " + leitor.GetString("nome")
                lbl(n_registo).AutoSize = False
                lbl(n_registo).Size = New System.Drawing.Size(200, 20)
                pnl(n_registo).Controls.Add(lbl(n_registo))

                lbl(n_registo + 1) = New Label
                lbl(n_registo + 1).Location = New System.Drawing.Point(55, 19)
                lbl(n_registo + 1).Font = New Font("Arial", 8, FontStyle.Regular)
                lbl(n_registo + 1).Text = "Stock: " + Math.Round(leitor.GetDouble("stock"), 2).ToString
                lbl(n_registo + 1).AutoSize = False
                lbl(n_registo + 1).Size = New System.Drawing.Size(200, 20)
                pnl(n_registo).Controls.Add(lbl(n_registo + 1))

                lbl(n_registo + 2) = New Label
                lbl(n_registo + 2).Location = New System.Drawing.Point(55, 38)
                lbl(n_registo + 2).Font = New Font("Arial", 8, FontStyle.Regular)
                lbl(n_registo + 2).Text = "Preço: " + leitor.GetString("preco") + " €"
                lbl(n_registo + 2).AutoSize = False
                lbl(n_registo + 2).Size = New System.Drawing.Size(200, 20)
                pnl(n_registo).Controls.Add(lbl(n_registo + 2))

                n_registo += 1
            End While
            ligacao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class