Module U_SqlFormat
#Region "To SQL"
    Public Function ToSql_BoolToBit(ByVal value As Boolean)
        If value Then Return 1
        Return 0
    End Function
    Public Function ToSql_ToTxt(ByVal obj As Object)
        Dim value As String = ""
        If Not IsNothing(obj) Then value = obj.ToString
        If value.Contains("'") Then value = value.Replace("'", "`")
        Return "'" & value & "'"
      End Function
    Public Function ToSql_ToInt(ByVal obj As Object)
        Return Val(obj)
    End Function
#End Region
#Region "To APP"
    Public Function ToApp_BitToBool(ByVal value As Integer)
        Return value = 1
    End Function
#End Region
End Module
