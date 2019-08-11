Public Class Root
#Region "VARIABLE"
#End Region
#Region "FORM"
    Private Sub Root_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartConfig()
        InitForm()
    End Sub
#End Region
#Region "DATA"
    Private Sub InitForm()
        FtpPath_Tbx.Text = FTPServer
    End Sub
#End Region
#Region "CONTROL"
#Region "   BUTTON"
    Private Sub Root_Btn_Click(sender As Object, e As EventArgs) Handles Root_Btn.Click
        Psw_Tbx.Select()
    End Sub
    Private Sub Download_Btn_Click(sender As Object, e As EventArgs) Handles Download_Btn.Click
        Ftp_Download(FtpPath_Tbx.Text & FTPPath & "PSW_Manager.db", "PSW_Manager.db")
    End Sub
    Private Sub Upload_Btn_Click(sender As Object, e As EventArgs) Handles Upload_Btn.Click
        Ftp_Upload(FtpPath_Tbx.Text & FTPPath & "PSW_Manager_" & Format(Now, "yyyy_MM_dd_HH_mm_ss") & ".db", "PSW_Manager.db")
    End Sub
#End Region
#Region "   TEXT BOX"
    Private Sub Psw_Tbx_TextChanged(sender As Object, e As EventArgs) Handles Psw_Tbx.TextChanged
        IsRoot = (Psw_Tbx.Text = RootPSW)
    End Sub
    Private Sub Root_Btn_Enter(sender As Object, e As EventArgs) Handles Psw_Tbx.Enter
        'Close()
        'PSWList.Show()
    End Sub
    Private Sub Psw_Tbx_KeyDown(sender As Object, e As KeyEventArgs) Handles Psw_Tbx.KeyDown
        If e.KeyCode = Keys.Enter Then
            PSWList.Show()
            Close()
        End If
    End Sub
#End Region
#End Region
End Class