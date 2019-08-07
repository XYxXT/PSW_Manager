Module U_DataGridView
    Public Sub DgvCellSet(ByVal dgv As DataGridView, ByVal rw As Integer, ByVal cl As Integer, ByVal value As Object)
        dgv.Rows(rw).Cells(cl).Value = value
    End Sub
    Public Function DgvCellGet(ByVal dgv As DataGridView, ByVal rw As Integer, ByVal cl As Integer)
        Return dgv.Rows(rw).Cells(cl).Value
    End Function
End Module
