Public Class GridVisualDisplayHelper
    Public Shared Sub SetGridColumnsNames(grid As DataGridView, names As List(Of String))
        For Each column As DataGridViewColumn In grid.Columns
            column.HeaderText = names(column.Index)
        Next
    End Sub

End Class
