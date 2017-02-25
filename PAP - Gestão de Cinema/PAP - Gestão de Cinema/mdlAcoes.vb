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
            Return "Erro"
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
            MessageBox.Show(ex.Message, "Erro a Ver", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
    End Sub

    Public Sub encher(ByRef cmb As ComboBox, ligacao As MySqlConnection, ByVal nome_tabela As String, ByVal campo As String, ByVal chave_primaria As String, ByVal query As String) 'ComboBoxes
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
        cmb.Text = ""
    End Sub

    Public Sub acao(ByVal objetivo As String, ByRef ligacao As MySqlConnection, ByVal ordem As String) 'Comandos
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = ligacao
        comando.CommandText = ordem
        ligacao.Open()
        comando.ExecuteNonQuery()
        ligacao.Close()

        MessageBox.Show("O ato de " + objetivo + " foi realizado com sucesso", "Operação executada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
