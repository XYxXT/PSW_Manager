Imports System.Data.SQLite

Module U_Sqlite
    Public ConnectionString As String = "Data Source={0};Version=3;Pooling=True;Synchronous=Off;journal mode=Memory;"
    Public ConnectionFile As String
    Public SqliteConn As SQLiteConnection
    Public SqliteCommand As SQLiteCommand
#Region "INIT"
    Public Function CreateSQLiteFile(ByVal fileName As String)
        If Not My.Computer.FileSystem.FileExists(fileName) Then
            SQLiteConnection.CreateFile(fileName)
            Return True
        End If
        Return False
    End Function
    Public Sub SqliteOpen()
        SqliteConn = New SQLiteConnection(ConnectionString)
        SqliteCommand = New SQLiteCommand(SqliteConn)
        SqliteConn.Open()
    End Sub
    Public Sub SqliteClose()
        SqliteCommand.Cancel()
        SqliteConn.Close()
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
#End Region
#Region "BASIC"
    Public Sub SqliteExecute(ByVal sqlCommand As String)
        SqliteCommand.CommandText = sqlCommand
        SqliteCommand.ExecuteNonQuery()
    End Sub
    Public Function SqliteLastID(ByVal tableName As String, ByVal fieldName As String)
        Dim dt As New DataTable
        Dim selectQuery As String = "SELECT {0} FROM {1} ORDER BY id DESC LIMIT 1"

        SqliteDbDt(dt, String.Format(selectQuery, fieldName, tableName))
        If dt.Rows.Count = 1 Then
            Return dt.Rows(0).Item(0)
        End If
        Return -1
    End Function
#End Region
#Region "DATATABLE"
    Public Sub SqliteDbDt(ByRef dt As DataTable, ByVal sqlQuery As String)
        SqliteCommand.CommandText = sqlQuery
        Using reader As SQLite.SQLiteDataReader = SqliteCommand.ExecuteReader()
            dt = New DataTable
            dt.Load(reader)
        End Using
    End Sub
    Public Sub SqliteDtBd(ByRef dt As DataTable, ByVal tableName As String)

        If dt.Rows.Count = 0 Then Exit Sub
        Dim indexX As Integer = dt.Columns.Count - 1
        Dim columnsName(dt.Columns.Count - 2) As String
        Dim columnsType(dt.Columns.Count - 2) As String

        For c As Integer = 0 To dt.Columns.Count - 2 Step 1
            columnsName(c) = dt.Columns(c).ColumnName
            columnsType(c) = dt.Columns(c).DataType.Name
        Next

        For r As Integer = dt.Rows.Count - 1 To 0 Step -1
            Select Case (dt.Rows(r).ItemArray(indexX))
                Case "N"
                    dt.Rows(r).ItemArray(indexX) = ""
                    SqliteDtBdN(dt.Rows(r), tableName, columnsName, columnsType)
                Case "M"
                    dt.Rows(r).ItemArray(indexX) = ""
                    SqliteDtBdM(dt.Rows(r), tableName, columnsName, columnsType)
                Case "D"
                    SqliteDtBdD(dt.Rows(r), tableName)
                    dt.Rows.RemoveAt(r)
                Case Else
            End Select
        Next


    End Sub
    Private Sub SqliteDtBdN(ByVal dr As DataRow, ByVal tableName As String, ByVal columnsName() As String, ByVal columnsType() As String)

        Dim insertCommand_1 As String = "INSERT INTO " + tableName + " ("
        Dim insertCommand_2 As String = ") VALUES ("
        For i As Integer = 1 To columnsName.Length - 1 Step 1
            insertCommand_1 = insertCommand_1 & columnsName(i) & ","
            Select Case (columnsType(i))
                Case "String"
                    insertCommand_2 &= ToSql_ToTxt(dr.ItemArray(i))
                Case "Int32", "Int64"
                    insertCommand_2 &= ToSql_ToInt(dr.ItemArray(i))
                Case Else
                    System.Windows.Forms.MessageBox.Show("UNKNOWN TYPE: " & columnsType(i))
            End Select
            insertCommand_2 &= ","
        Next

        Dim insertCommand As String = insertCommand_1.Substring(0, insertCommand_1.LastIndexOf(",")) &
                insertCommand_2.Substring(0, insertCommand_2.LastIndexOf(",")) & ")"
        SqliteExecute(insertCommand)
    End Sub
    Private Sub SqliteDtBdM(ByVal dr As DataRow, ByVal tableName As String, ByVal columnsName() As String, ByVal columnsType() As String)
        Dim updateCommand As String = "UPDATE " & tableName & " SET "
        For i As Integer = 1 To columnsName.Length - 1 Step 1
            updateCommand = updateCommand & columnsName(i) & " = "
            Select Case (columnsType(i))
                Case "String"
                    updateCommand &= ToSql_ToTxt(dr.ItemArray(i))
                Case "Int32", "Int64"
                    updateCommand &= ToSql_ToInt(dr.ItemArray(i))
                Case Else
                    System.Windows.Forms.MessageBox.Show("UNKNOWN TYPE: " & columnsType(i))
            End Select
            updateCommand &= ","
        Next
        updateCommand = updateCommand.Substring(0, updateCommand.LastIndexOf(",")) + "WHERE id = " + dr.ItemArray(0)
        SqliteExecute(updateCommand)
    End Sub
    Private Sub SqliteDtBdD(ByVal dr As DataRow, ByVal tableName As String)
        Dim deleteCommand As String = "DELETE FROM " & tableName + " WHERE id = " + dr.ItemArray(0)
        SqliteExecute(deleteCommand)
    End Sub
#End Region
#Region "DATAGRIDVIEW"
    Public Sub SqliteDbDgv(ByVal dgv As DataGridView, ByVal sqlQuery As String)
        dgv.Rows.Clear()
        Dim dt As New DataTable
        SqliteDbDt(dt, sqlQuery)
        'dgv.DataSource = dt
        For rw As Integer = 0 To dt.Rows.Count - 1 Step 1
            dgv.Rows.Add()
            For cl As Integer = 0 To dt.Columns.Count - 1 Step 1
                DgvCellSet(dgv, rw, cl, dt.Rows(rw).Item(cl))
            Next
        Next
    End Sub
    Public Sub SqliteDbDgv(ByVal dgv As DataGridView, ByVal sqlQuery As String, ByRef columnsName() As String, ByRef columnsType() As String)
        Dim dt As New DataTable
        SqliteDbDt(dt, sqlQuery)

        Dim indexX As Integer = dt.Columns.Count - 1
        ReDim columnsName(dt.Columns.Count - 2)
        ReDim columnsType(dt.Columns.Count - 2)

        For c As Integer = 0 To dt.Columns.Count - 2 Step 1
            columnsName(c) = dt.Columns(c).ColumnName
            columnsType(c) = dt.Columns(c).DataType.Name
        Next

        dgv.Rows.Clear()

        For rw As Integer = 0 To dt.Rows.Count - 1 Step 1
            dgv.Rows.Add()
            For cl As Integer = 0 To dt.Columns.Count - 1 Step 1
                DgvCellSet(dgv, rw, cl, dt.Rows(rw).Item(cl))
            Next
        Next
    End Sub
    Public Sub SqliteDgvDb(ByVal dgv As DataGridView, ByVal tableName As String, ByVal columnsName() As String, ByVal columnsType() As String)
        If dgv.Rows.Count = 0 Then Exit Sub
        Dim indexX As Integer = dgv.Columns.Count - 1
        For r As Integer = dgv.Rows.Count - 1 To 0 Step -1
            Select Case (DgvCellGet(dgv, r, indexX))
                Case "N"
                    DgvCellSet(dgv, r, indexX, "")
                    SqliteDgvBdN(dgv, r, tableName, columnsName, columnsType)
                Case "M"
                    DgvCellSet(dgv, r, indexX, "")
                    SqliteDgvBdM(dgv, r, tableName, columnsName, columnsType)
                Case "D"
                    SqliteDgvBdD(dgv, r, tableName)
                    dgv.Rows.RemoveAt(r)
                Case Else
            End Select
        Next
    End Sub
    Private Sub SqliteDgvBdN(ByVal dgv As DataGridView, ByVal rw As Integer, ByVal tableName As String, ByVal columnsName() As String, ByVal columnsType() As String)
        Dim insertCommand_1 As String = "INSERT INTO " + tableName + " ("
        Dim insertCommand_2 As String = ") VALUES ("
        For i As Integer = 1 To columnsName.Length - 1 Step 1
            insertCommand_1 = insertCommand_1 & columnsName(i) & ","
            Select Case (columnsType(i))
                Case "String"
                    insertCommand_2 &= ToSql_ToTxt(DgvCellGet(dgv, rw, i))
                Case "Int32", "Int64"
                    insertCommand_2 &= ToSql_ToInt(DgvCellGet(dgv, rw, i))
                Case Else
                    System.Windows.Forms.MessageBox.Show("UNKNOWN TYPE: " & columnsType(i))
                    Exit Sub
            End Select
            insertCommand_2 &= ","
        Next

        Dim insertCommand As String = insertCommand_1.Substring(0, insertCommand_1.LastIndexOf(",")) &
                insertCommand_2.Substring(0, insertCommand_2.LastIndexOf(",")) & ")"
        SqliteExecute(insertCommand)
    End Sub
    Private Sub SqliteDgvBdM(ByVal dgv As DataGridView, ByVal rw As Integer, ByVal tableName As String, ByVal columnsName() As String, ByVal columnsType() As String)
        Dim updateCommand As String = "UPDATE " & tableName & " SET "
        For i As Integer = 1 To columnsName.Length - 1 Step 1
            updateCommand = updateCommand & columnsName(i) & " = "
            Select Case (columnsType(i))
                Case "String"
                    updateCommand &= ToSql_ToTxt(DgvCellGet(dgv, rw, i))
                Case "Int32", "Int64"
                    updateCommand &= ToSql_ToInt(DgvCellGet(dgv, rw, i))
                Case Else
                    System.Windows.Forms.MessageBox.Show("UNKNOWN TYPE: " & columnsType(i))
            End Select
            updateCommand &= ","
        Next
        updateCommand = updateCommand.Substring(0, updateCommand.LastIndexOf(",")) & " WHERE id = " & (DgvCellGet(dgv, rw, 0))
        SqliteExecute(updateCommand)
    End Sub
    Private Sub SqliteDgvBdD(ByVal dgv As DataGridView, ByVal rw As Integer, ByVal tableName As String)
        Dim deleteCommand As String = "DELETE FROM " & tableName + " WHERE id = " & DgvCellGet(dgv, rw, 0)
        SqliteExecute(deleteCommand)
    End Sub
#End Region


End Module
