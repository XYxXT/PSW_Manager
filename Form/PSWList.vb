Imports System.Data.SQLite
Imports System.IO

Public Class PSWList
#Region "VARIABLE"
    Private lastText As String
#End Region
#Region "FORM"
    Private Sub PSWList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
        LoadData()
    End Sub
#End Region

#Region "DATA"
    Private Sub InitForm()
        lastText = ""
    End Sub
    Private Sub LoadData()
        Dim whereCommand As String = "( site LIKE '%" & Search_Tbx.Text &
                "%' OR description LIKE '%" & Search_Tbx.Text &
                 "%' OR user LIKE '%" & Search_Tbx.Text & "%' )"
        Dim selectCommand As String = "SELECT id_password, site, user, user_name, user_psw FROM password WHERE (root = 0 OR root = " & ToSql_BoolToBit(IsRoot) & ") AND " & whereCommand
        SqliteOpen()
        SqliteDbDgv(Psw_Dgv, selectCommand)
        SqliteClose()
    End Sub
#End Region
#Region "CONTROL"
#Region "   BUTTON"
    Private Sub Root_Btn_Click(sender As Object, e As EventArgs) Handles Root_Btn.Click
        Root.ShowDialog()
    End Sub
    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles Add_Btn.Click
        PswSelected = Nothing
        PSWInfo.ShowDialog()
        LoadData()
    End Sub
#End Region
#Region "   TEXT BOX"
    Private Sub Search_Tbx_TextChanged(sender As TextBox, e As EventArgs) Handles Search_Tbx.TextChanged
        If sender.Text <> lastText Then
            lastText = sender.Text
            LoadData()
        End If
    End Sub
#End Region
#Region "   DATAGRIDVIEW"
    Private Sub Psw_Dgv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Psw_Dgv.CellContentDoubleClick
        PswSelected = Psw_Dgv.Rows(e.RowIndex).Cells(0).Value
        PSWInfo.ShowDialog()
        LoadData()
    End Sub
#End Region
#End Region
End Class
