Imports System.IO

Module U_Ftp
    Public FTPServer As String = "127.0.0.1"
    Public FTP_UserName As String = "admin"
    Public FTP_UserPSW As String = "admin"
    Public Sub Ftp_Download(ByVal fptPath As String, ByVal localPath As String)
        If File.Exists(localPath) Then File.Delete(localPath)
        My.Computer.Network.DownloadFile("ftp://" & fptPath, localPath, FTP_UserName, FTP_UserPSW)
    End Sub
    Public Sub Ftp_Upload(ByVal fptPath As String, ByVal localPath As String)
        My.Computer.Network.UploadFile(localPath, "ftp://" & fptPath, FTP_UserName, FTP_UserPSW, True, 500, FileIO.UICancelOption.DoNothing)
    End Sub
End Module
