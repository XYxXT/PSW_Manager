Public Class PSWInfo
#Region "VARIABLE"
    Dim id_password As Integer
    Dim dt As DataTable
    Dim columnsName() As String, columnsType() As String
#End Region
#Region "FORM"
    Private Sub PSWInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
        LoadData()
    End Sub
#End Region

#Region "DATA"
    Private Sub InitForm()
        id_password = PswSelected
        dt = New DataTable
        Add_Btn.Enabled = True
        Delete_Btn.Enabled = True
        Me.BackColor = Color.White
        ExtInfo_Dgv.Rows.Clear()
    End Sub
    Private Sub LoadData()
        If id_password > 0 Then
            LoadPSWInfo()
            LoadExtInfo()
        Else
            Add_Btn.Enabled = False
            Delete_Btn.Enabled = False
            Me.BackColor = Color.DarkGray
        End If
    End Sub
    Private Sub LoadPSWInfo()
        Dim selectQuery As String = "SELECT id, site, web_site, description, date_create, date_last_edit, user," +
                " user_name, user_psw, root FROM password WHERE id = " & id_password
        SqliteOpen()
        SqliteDbDt(dt, selectQuery)
        SqliteClose()

        Site_Tbx.Text = dt.Rows(0).ItemArray(1)
        WebSite_Tbx.Text = dt.Rows(0).ItemArray(2)
        Description_Tbx.Text = dt.Rows(0).ItemArray(3)
        User_Tbx.Text = dt.Rows(0).ItemArray(6)
        UserName_Tbx.Text = dt.Rows(0).ItemArray(7)
        UserPSW_Tbx.Text = dt.Rows(0).ItemArray(8)
        Root_Cbx.Checked = ToApp_BitToBool(dt.Rows(0).ItemArray(9))
    End Sub
    Private Sub LoadExtInfo()
        Dim queryCommand As String = "SELECT id, id_password, description, value, '' as x FROM ext_info WHERE id_password = " & id_password
        SqliteOpen()
        SqliteDbDgv(ExtInfo_Dgv, queryCommand, columnsName, columnsType)
        SqliteClose()
    End Sub
    Private Sub SaveEdit()
        Dim updateCommand As String = "UPDATE password SET site = '{0}', web_site = '{1}', description = '{2}', " +
                "date_last_edit = '{3}', user = '{4}', user_name = '{5}', user_psw = '{6}', root = {7} WHERE " +
                "id = {8}"
        SqliteOpen()
        SqliteExecute(String.Format(updateCommand, Site_Tbx.Text, WebSite_Tbx.Text,
                Description_Tbx.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), User_Tbx.Text, UserName_Tbx.Text,
                UserPSW_Tbx.Text, ToSql_BoolToBit(Root_Cbx.Checked), id_password))
        SqliteClose()
        SaveExtInfo()
        If dt.Rows(0).ItemArray(7) <> UserName_Tbx.Text Or dt.Rows(0).ItemArray(8) <> UserPSW_Tbx.Text Then
            SaveNewLastPSW(Format(dt.Rows(0).ItemArray(5), "yyyy-MM-dd HH:mm"),
                           dt.Rows(0).ItemArray(7), dt.Rows(0).ItemArray(8))
        End If
    End Sub
    Private Sub SaveNew()
        Dim insertCommand As String = "INSERT INTO password ( site, web_site, description, date_create, date_last_edit," +
                " user, user_name, user_psw, root) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}', {8})"
        SqliteOpen()
        SqliteExecute(String.Format(insertCommand, Site_Tbx.Text, WebSite_Tbx.Text,
                Description_Tbx.Text, Format(Now, "yyyy-MM-dd HH:mm"), Format(Now, "yyyy-MM-dd HH:mm"),
                User_Tbx.Text, UserName_Tbx.Text, UserPSW_Tbx.Text, Root_Cbx.Checked))
        PswSelected = SqliteLastID("password")
        SqliteClose()
        SaveNewLastPSW(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), UserName_Tbx.Text, UserPSW_Tbx.Text)

        InitForm()
        LoadData()
        Refresh()
    End Sub
    Private Sub SaveExtInfo()
        SqliteOpen()
        SqliteDgvDb(ExtInfo_Dgv, "ext_info", columnsName, columnsType)
        SqliteClose()
    End Sub
    Private Sub SaveNewLastPSW(ByVal lastDate As String, ByVal lastUser As String, ByVal lastPsw As String)
        SqliteOpen()
        Dim insertCommand As String = "INSERT INTO last_edit (id_password, date_last_edit, last_user, last_psw) VALUES " +
                "({0}, '{1}', '{2}', '{3}')"
        SqliteExecute(String.Format(insertCommand, id_password, lastDate, lastUser, lastPsw))
        SqliteClose()
    End Sub
#End Region
#Region "CONTROL"
#Region "   BUTTON"
    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        If id_password = 0 Then
            SaveNew()
        Else
            SaveEdit()
        End If

    End Sub
    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles Add_Btn.Click
        Dim ro As Integer = ExtInfo_Dgv.Rows.Add()
        DgvCellSet(ExtInfo_Dgv, ro, 0, -1)
        DgvCellSet(ExtInfo_Dgv, ro, 1, id_password)
        DgvCellSet(ExtInfo_Dgv, ro, 4, "N")
    End Sub
    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click
        If ExtInfo_Dgv.SelectedCells(0).RowIndex > -1 Then
            Dim X As String = DgvCellGet(ExtInfo_Dgv, ExtInfo_Dgv.SelectedCells(0).RowIndex, 4)
            If X = "M" Or X = "" Then
                DgvCellSet(ExtInfo_Dgv, ExtInfo_Dgv.SelectedCells(0).RowIndex, 4, "D")
            End If
        End If
    End Sub
#End Region
#Region "   TEXT BOX"

#End Region
#Region "   DATAGRIDVIEW"
    Private Sub ExtInfo_Dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ExtInfo_Dgv.CellEndEdit
        If e.RowIndex > -1 Then
            Dim X As String = DgvCellGet(ExtInfo_Dgv, e.RowIndex, 4)
            If X = "D" Or X = "" Then
                DgvCellSet(ExtInfo_Dgv, e.RowIndex, 4, "M")
            End If
        End If
    End Sub
#End Region
#End Region
End Class