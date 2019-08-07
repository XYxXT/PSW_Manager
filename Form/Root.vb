Public Class Root
#Region "VARIABLE"
#End Region
#Region "FORM"
    Private Sub Root_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
#Region "DATA"

#End Region
#Region "CONTROL"
#Region "   BUTTON"
    Private Sub Root_Btn_Click(sender As Object, e As EventArgs) Handles Root_Btn.Click
        Psw_Tbx.Select()
    End Sub
    Private Sub Download_Btn_Click(sender As Object, e As EventArgs) Handles Download_Btn.Click

    End Sub
    Private Sub Upload_Btn_Click(sender As Object, e As EventArgs) Handles Upload_Btn.Click

    End Sub
#End Region
#Region "   TEXT BOX"
    Private Sub Psw_Tbx_TextChanged(sender As Object, e As EventArgs) Handles Psw_Tbx.TextChanged
        If Psw_Tbx.Text = RootPSW Then IsRoot = True : Close()
    End Sub
#End Region
#End Region
End Class