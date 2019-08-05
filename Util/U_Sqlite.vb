﻿Imports System.Data.SQLite

Module U_Sqlite
    Public ConnectionString As String = "Data Source={0};Version=3;"
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
    End Sub
#End Region
#Region "BASIC"
    Public Sub SqliteExecute(ByVal sqlCommand As String)
        SqliteCommand.CommandText = sqlCommand
        SqliteCommand.ExecuteNonQuery()
    End Sub
    Public Function LastID(ByVal tableName As String)
        Dim dt As New DataTable
        Dim selectQuery As String = "SELECT id FROM {0} ORDER BY id DESC LIMIT 1"

        SqliteDbDt(dt, String.Format(selectQuery, tableName))
        If dt.Rows.Count = 0 Then
            Return Convert.ToInt32(dt.Rows(0).ItemArray(0))
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
#End Region
#Region "DATAGRIDVIEW"
    Public Sub SqliteDbDgv(ByVal dgv As DataGridView, ByVal sqlQuery As String, Optional ByVal autogeneratedColumn As Boolean = False)
        Dim dt As New DataTable
        dgv.AutoGenerateColumns = autogeneratedColumn
        SqliteDbDt(dt, sqlQuery)
        dgv.DataSource = dt
    End Sub
#End Region


End Module
