Imports MySql.Data.MySqlClient
Module mdlAcoes
    Public Const DIMTA As Integer = 10
    Public encargo As String
    Public ass(DIMTA) As Acesso
    Public codF As Integer
    Public fechar As Boolean = True

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
            obj.ForeColor = Color.Black
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
            obj.ForeColor = Color.Black
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
            ElseIf obj.Text(0) = " " Then
                Return "O " + obj.tag.ToString + " não pode começar com um espaço. "
            Else
                Return ""
            End If
        ElseIf TypeOf obj Is NumericUpDown Then
            If obj.value = 0 Then
                Return "Não digitou um " + obj.tag.ToString + " válido. "
            End If
        ElseIf TypeOf obj Is ComboBox Then
            If obj.Text = "" Then
                Return "Não escolheu uma " + obj.tag.ToString + ". "
            End If

        ElseIf TypeOf obj Is DateTimePicker Then

        Else
            Return "Erro"
        End If
        Return ""
    End Function

    Function verificacao(ByRef rct As PowerPacks.RectangleShape, ByRef obj As Object) As String
        If TypeOf obj Is TextBox Then
            If obj.Text = "" Or IsNumeric(obj.Text) Then
                AlterarEstado(rct, obj, "errar")
                Return "Não escreveu um " + obj.tag.ToString + " válido. "
            ElseIf obj.Text(0) = " " Then
                AlterarEstado(rct, obj, "errar")
                Return "O " + obj.tag.ToString + " não pode começar com um espaço. "
            Else
                AlterarEstado(rct, obj, "acertar")
                Return ""
            End If
        ElseIf TypeOf obj Is MaskedTextBox Then
            If obj.Text = "" Or obj.Text.Length < 9 Then
                AlterarEstado(rct, obj, "errar")
                Return "Não escreveu um " + obj.tag.ToString + " válido. "
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
        ElseIf TypeOf obj Is NumericUpDown Then
            If obj.value = 0 Then
                AlterarEstado(rct, "errar")
                Return "Não digitou um " + obj.tag.ToString + " válido. "
            Else
                Return ""
            End If
        ElseIf TypeOf obj Is OpenFileDialog Then
            If obj.FileName = "" Then
                Return "Não escolheu uma imagem. "
            End If
        Else
            Return "Objeto como parâmetro da Verificacao inválido"
        End If
        Return ""
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
            dgv.ClearSelection()
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
            MessageBox.Show("Parametro de entrada do procedimento Encher é inválido", "Erro de programação", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If ordem.Contains("?Imagem") Then
            Try
                Dim comando As New MySqlCommand(ordem, ligacao)
                Dim ms As New IO.MemoryStream

                imagem.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
                comando.Parameters.Add("?Imagem", MySqlDbType.LongBlob, ms.Length).Value = ms.GetBuffer

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
        Try
            ligacao.Open()
            leitor = comando.ExecuteReader
            If leitor.Read Then
                valor = leitor.GetInt32(campo)
            End If
            ligacao.Close()
        Catch ex As Exception
            ligacao.Close()
        End Try
        Return valor
    End Function
    Public Function ter_str(ByRef ligacao As MySqlConnection, ByVal campo As String, ByVal query As String) As String  'Apenas returna um resultado varchar da query 
        Dim comando As MySqlCommand = New MySqlCommand(query, ligacao)
        Dim leitor As MySqlDataReader
        Dim str As String = ""
        Try
            ligacao.Open()
            leitor = comando.ExecuteReader
            If leitor.Read Then
                str = leitor.GetString(campo)
            End If
            ligacao.Close()
        Catch ex As Exception
            ligacao.Close()
        End Try
        Return str
    End Function
    Public Function Campo_Selecionado_proc(ByVal campo As String, ByVal tabela As String, ByVal chk As CheckBox, ByRef obj As Object, ByRef rct As PowerPacks.RectangleShape, ByRef pquery As String) As String
        Dim averiguar As String = ""
        If chk.Checked Then
            averiguar = verificacao(rct, obj)
            If averiguar = "" Then
                If TypeOf obj Is TextBox Or TypeOf obj Is MaskedTextBox Then
                    pquery += " and " + tabela + "." + campo + " like '%" + obj.Text + "%'"
                ElseIf TypeOf obj Is NumericUpDown Then
                    pquery += " and " + tabela + "." + campo + " = " + obj.Value.ToString
                ElseIf TypeOf obj Is ComboBox Then
                    pquery += " and " + tabela + "." + campo + " = " + obj.SelectedValue.ToString
                ElseIf TypeOf obj Is DateTimePicker Then
                    pquery += " and " + tabela + "." + campo + "='" + obj.Value.Year.ToString + "-" + obj.Value.Month.ToString + "-" + obj.Value.Day.ToString + "'"
                Else
                    MessageBox.Show("A função Campo_Selecionado_proc recebeu um objeto desconhecido", "Campo_Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        Return averiguar
    End Function

    Public Function Campo_Selecionado_alte(ByVal campo As String, ByVal chk As CheckBox, ByRef lbl As Label, ByRef obj As Object, ByRef rct As PowerPacks.RectangleShape, ByRef pquery As String) As String
        Dim averiguar As String = ""
        If chk.Checked Then
            averiguar = verificacao(rct, obj)
            If averiguar = "" Then
                If TypeOf obj Is TextBox Or TypeOf obj Is MaskedTextBox Then
                    If pquery <> "" Then
                        pquery += ", "
                    End If
                    pquery += " " + campo + "='" + obj.Text + "'"
                ElseIf TypeOf obj Is NumericUpDown Then
                    If pquery <> "" Then
                        pquery += ","
                    End If
                    pquery += " " + campo + "=" + obj.Value.ToString
                ElseIf TypeOf obj Is ComboBox Then
                    If pquery <> "" Then
                        pquery += ","
                    End If
                    pquery += " " + campo + "=" + obj.SelectedValue.ToString
                Else
                    MessageBox.Show("A função Campo_Selecionado_alte recebeu um objeto desconhecido", "Campo_Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                lbl.Font = New Font(lbl.Font, lbl.Font.Style Or FontStyle.Strikeout)
            End If
        End If
        Return averiguar
    End Function

    Public Function novo_registo(ByRef ligacao As MySqlConnection, chave_primaria As String, ByVal tabela As String, ByRef cmb As ComboBox) As Integer
        Dim cod As Integer = 0
        'Inserir a nova localidade
        acao("inserir", ligacao, "insert into " + tabela + " (nome) values ('" + cmb.Text + "')", 0)

        'Descobrir o codLo dessa localidade
        cod = ter(ligacao, chave_primaria, "select " + chave_primaria + " from " + tabela + " where nome='" + cmb.Text + "'")

        'Associá-la ao registo do funcionário
        encher(cmb, ligacao, tabela, "nome", chave_primaria, "select " + chave_primaria + ", nome from " + tabela)
        cmb.SelectedValue = cod
        Return cod
    End Function
End Module
