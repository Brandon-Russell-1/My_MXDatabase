Partial Class MxDatabaseDataSet
    Partial Class Archive_tblAcftOnStationDataTable

        Private Sub Archive_tblAcftOnStationDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.flareColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace MxDatabaseDataSetTableAdapters
    
    Partial Public Class TEMPInboundTableAdapter
    End Class
End Namespace
