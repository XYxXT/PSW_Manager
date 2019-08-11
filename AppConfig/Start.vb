Imports System.IO

Module Start
    Public Sub StartConfig()
        IsRoot = False
        ConnectionFile = "PSW_Manager.db"
        ConnectionString = String.Format(ConnectionString, ConnectionFile)
        If File.Exists("_" & ConnectionFile) Then
            File.Delete(ConnectionFile)
            My.Computer.FileSystem.RenameFile("_" & ConnectionFile, ConnectionFile)
        End If

        If IsDebug() Then
            IsRoot = True
        End If
    End Sub
End Module
