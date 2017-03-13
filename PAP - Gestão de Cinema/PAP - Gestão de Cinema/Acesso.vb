Public Class Acesso
    Public Const DIMPER As Integer = 4
    Public tabela As Integer
    Public permissao(DIMPER) As Boolean
    '0 -> consultar; 1 -> alterar; 2 -> inserir; 3 -> desativar/apagar

    Public Function acesso() As Boolean
        If permissao(0) + permissao(1) + permissao(2) + permissao(3) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
