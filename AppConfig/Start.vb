Module Start
    Public Sub StartConfig()
        IsRoot = False
        ConnectionFile = "PSW_Manager.db"
        ConnectionString = String.Format(ConnectionString, ConnectionFile)

        If IsDebug() Then
            IsRoot = True
        End If
    End Sub
End Module
