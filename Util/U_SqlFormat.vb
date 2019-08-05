Module U_SqlFormat
#Region "To SQL"
    Public Function ToSql_BoolToBit(ByVal value As Boolean)
        If value Then Return 1
        Return 0
    End Function
#End Region
#Region "To APP"
    Public Function ToApp_BitToBool(ByVal value As Integer)
        Return value = 1
    End Function
#End Region
End Module
