Module Start
    Public Sub StartConfig()
        IsRoot = False
        ConnectionFile = "PSW_Manager.db"
        ConnectionString = String.Format(ConnectionString, ConnectionFile)
    End Sub
End Module
