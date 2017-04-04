Imports MySql.Data.MySqlClient
Module mdlAcoes
    Public Sub AlterarEstado(ByRef rct As PowerPacks.RectangleShape, ByRef obj As Object, pct As PictureBox, ByVal str As String)
        If str = "restaurar" Then
            obj.BackColor = Color.White
            rct.BackColor = Color.White
            rct.BorderColor = Color.White
            obj.ForeColor = Color.Black
            pct.BackColor = Color.White
        ElseIf str = "errar" Then
            obj.BackColor = Color.LightSalmon
            rct.BackColor = Color.LightSalmon
            rct.BorderColor = Color.LightSalmon
            obj.ForeColor = Color.Red
            pct.BackColor = Color.LightSalmon
        ElseIf str = "acertar" Then
            obj.BackColor = Color.LightGreen
            rct.BackColor = Color.LightGreen
            rct.BorderColor = Color.LightGreen
            pct.BackColor = Color.LightGreen
        End If
    End Sub
    Public Sub AlterarEstado(ByRef rct As PowerPacks.RectangleShape, ByRef obj As Object, ByVal str As String)
        If str = "restaurar" Then
            obj.BackColor = Color.White
            rct.BackColor = Color.White
            rct.BorderColor = Color.White
            obj.ForeColor = Color.Black
        ElseIf str = "errar" Then
            obj.BackColor = Color.LightSalmon
            rct.BackColor = Color.LightSalmon
            rct.BorderColor = Color.LightSalmon
            obj.ForeColor = Color.Red
        ElseIf str = "acertar" Then
            obj.BackColor = Color.LightGreen
            rct.BackColor = Color.LightGreen
            rct.BorderColor = Color.LightGreen
        End If
    End Sub
    Public Sub AlterarEstado(ByRef rct As PowerPacks.RectangleShape, ByVal str As String)
        If str = "restaurar" Then
            rct.BackColor = Color.White
            rct.BorderColor = Color.White
        ElseIf str = "errar" Then
            rct.BackColor = Color.LightSalmon
            rct.BorderColor = Color.LightSalmon
        ElseIf str = "acertar" Then
            rct.BackColor = Color.LightGreen
            rct.BorderColor = Color.LightGreen
        End If
    End Sub

    Function verificacao(ByRef obj As Object) As String
        If TypeOf obj Is TextBox Then
            If obj.Text = "" Or IsNumeric(obj.Text) Then
                Return "Não escreveu um " + obj.tag.ToString + " válido. "
            Else
                Return ""
            End If
        ElseIf TypeOf obj Is NumericUpDown Then
            If obj.value = 0 Then
                Return "Não digitou um " + obj.tag.ToString + " válido. "
            Else
                Return ""
            End If
        ElseIf TypeOf obj Is ComboBox Then
            If obj.Text = "" Then
                Return "Não escolheu uma " + obj.tag.ToString + ". "
            Else
                Return ""
            End If
        ElseIf TypeOf obj Is OpenFileDialog Then
            If obj.FileName = "" Then
                Return "Não escolheu uma " + obj.tag.ToString + ". "
            Else
                Return ""
            End If
        Else
            Return "Erro"
        End If
    End Function

    Function verificacao(ByRef rct As PowerPacks.RectangleShape, ByRef obj As Object) As String
        If TypeOf obj Is TextBox Then
            If obj.Text = "" Or IsNumeric(obj.Text) Then
                AlterarEstado(rct, obj, "errar")
                Return "Não escreveu um " + obj.tag.ToString + " válido. "
            Else
                AlterarEstado(rct, obj, "acertar")
                Return ""
            End If

        ElseIf TypeOf obj Is MaskedTextBox Then
            If obj.Text = "" Or obj.Text.Length < 9 Then
                AlterarEstado(rct, obj, "errar")
                Return "Não escreveu um " + obj.tag.ToString + ". "
            Else
                AlterarEstado(rct, obj, "acertar")
                Return ""
            End If

        ElseIf TypeOf obj Is ComboBox Then
            If obj.Text = "" Then
                AlterarEstado(rct, "errar")
                Return "Não escolheu uma " + obj.tag.ToString + ". "
            Else
                AlterarEstado(rct, "acertar")
                Return ""
            End If
        Else
            Return "Objeto como parâmetro da Verificacao inválido"
        End If
    End Function

    Public Sub mostrar(dgv As DataGridView, ByRef ligacao As MySqlConnection, ByVal nome_tabela As String, ByVal chave_primaria As String, ByVal query As String) 'DatagGrids
        Dim adapter As New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        Try
            adapter.SelectCommand = New MySqlCommand
            adapter.SelectCommand.Connection = ligacao

            adapter.SelectCommand.CommandText = query

            ds.Clear()
            ligacao.Open()
            adapter.Fill(ds, nome_tabela)
            ligacao.Close()

            dgv.AutoGenerateColumns = True
            dgv.DataSource = ds
            dgv.DataMember = nome_tabela
            dgv.Columns.Item(chave_primaria).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro a Mostrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
    End Sub

    Public Sub encher(ByRef cmb As Object, ligacao As MySqlConnection, ByVal nome_tabela As String, ByVal campo As String, ByVal chave_primaria As String, ByVal query As String) 'ComboBoxes
        If TypeOf cmb Is ComboBox Or TypeOf cmb Is ListBox Then
            Try
                'Aqui, encho a combobox com dados para o utilizador escolher
                Dim adapter As New MySqlDataAdapter
                Dim ds As DataSet = New DataSet

                adapter.SelectCommand = New MySqlCommand
                adapter.SelectCommand.Connection = ligacao
                adapter.SelectCommand.CommandText = query

                ligacao.Open()
                adapter.Fill(ds, nome_tabela)
                ligacao.Close()

                cmb.DataSource = ds.Tables(nome_tabela)
                cmb.DisplayMember = campo
                cmb.ValueMember = chave_primaria
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro a Encher", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ligacao.Close()
            End Try
        Else
            ligacao.Close()
            MessageBox.Show("Parametro de entrada do procedimento Encher são inválidos", "Erro de programação", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub encher(ByRef cmb1 As Object, cmb2 As Object, ligacao As MySqlConnection, ByVal nome_tabela As String, ByVal campo As String, ByVal chave_primaria As String, ByVal query As String) 'ComboBoxes
        If TypeOf cmb1 Is ComboBox Or TypeOf cmb1 Is ListBox And TypeOf cmb2 Is ComboBox Or TypeOf cmb2 Is ListBox Then
            Try
                'Aqui, encho as combobox com dados para o utilizador escolher
                Dim adapter As New MySqlDataAdapter
                Dim ds As DataSet = New DataSet

                adapter.SelectCommand = New MySqlCommand
                adapter.SelectCommand.Connection = ligacao
                adapter.SelectCommand.CommandText = query

                ligacao.Open()
                adapter.Fill(ds, nome_tabela)
                ligacao.Close()

                cmb1.DataSource = ds.Tables(nome_tabela)
                cmb1.DisplayMember = campo
                cmb1.ValueMember = chave_primaria

                cmb2.DataSource = ds.Tables(nome_tabela)
                cmb2.DisplayMember = campo
                cmb2.ValueMember = chave_primaria
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro a Encher", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ligacao.Close()
            End Try
        Else
            ligacao.Close()
            MessageBox.Show("Parametro de entrada do procedimento Encher são inválidos", "Erro de programação", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub acao(ByVal objetivo As String, ByRef ligacao As MySqlConnection, ByVal ordem As String, ByVal MessagemAutomatica As Boolean) 'Comandos
        Try
            Dim comando As MySqlCommand = New MySqlCommand

            comando.Connection = ligacao
            comando.CommandText = ordem
            ligacao.Open()
            comando.ExecuteNonQuery()
            ligacao.Close()
            If MessagemAutomatica = True Then
                MessageBox.Show("O ato de " + objetivo + " foi realizado com sucesso", "Operação executada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro a " + objetivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
    End Sub

    Public Sub acao_c_Imagem(ByVal objetivo As String, ByRef ligacao As MySqlConnection, ByVal ordem As String, ByVal imagem As Image, ByVal MessagemAutomatica As Boolean) 'Comandos
        If ordem.Contains("@Imagem") Then
            Try
                Dim comando As New MySqlCommand(ordem, ligacao)

                'Código que o Prof. Nelson nos deu
                Using picture As Image = imagem
                    'Create an empty stream in memory.'     
                    Using stream As New IO.MemoryStream
                        'Fill the stream with the binary data from the 'imagem'.   
                        picture.Save(stream, Imaging.ImageFormat.Jpeg)

                        'Get an array of Bytes from the stream and assign to the parameter.'         
                        comando.Parameters.Add("@Imagem", MySqlDbType.VarBinary).Value = stream.GetBuffer()
                    End Using
                End Using
                ligacao.Open()
                comando.ExecuteNonQuery()
                ligacao.Close()
                If MessagemAutomatica = True Then
                    MessageBox.Show("O ato de " + objetivo + " foi realizado com sucesso", "Operação executada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro a " + objetivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ligacao.Close()
            End Try
        Else
            MessageBox.Show("A Query do acao_c_imagem tem de ter '[campo da imagem] = @Imagem'", "Erro de programção: Query sem '@Imagem'", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function ter(ByRef ligacao As MySqlConnection, ByVal campo As String, ByVal query As String) As Integer  'Apenas returna um resultado numérico da query 
        Dim comando As MySqlCommand = New MySqlCommand(query, ligacao)
        Dim leitor As MySqlDataReader
        Dim valor As Integer = 0
        ligacao.Open()
        leitor = comando.ExecuteReader
        If leitor.Read Then
            valor = leitor.GetInt32(campo)
        End If
        ligacao.Close()
        Return valor
    End Function
    Public Function Campo_Selecionado(ByVal campo As String, ByVal tabela As String, ByVal chk As CheckBox, ByRef obj As Object, ByRef rct As PowerPacks.RectangleShape, ByRef str_erro As String) As String
        Dim averiguar As String
        If chk.Checked Then
            averiguar = verificacao(rct, obj)
            If averiguar = "" Then
                If TypeOf obj Is TextBox Or TypeOf obj Is MaskedTextBox Then
                    Return " and " + tabela + "." + campo + " like '%" + obj.Text + "%'"
                ElseIf TypeOf obj Is NumericUpDown Then
                    Return " and " + tabela + "." + campo + " = " + obj.Value.ToString
                ElseIf TypeOf obj Is ComboBox Then
                    Return " and " + tabela + "." + campo + " = " + obj.SelectedValue.ToString
                Else
                    MessageBox.Show("A função Campo_Selecionado recebeu um objeto desconhecido", "Campo_Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("", "Campo_Secionado")
                End If
            Else
                str_erro += averiguar
            End If
        End If
            Return ""
    End Function
End Module
