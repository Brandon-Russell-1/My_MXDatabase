Public Class AdminSection

    Private Sub AdminSection_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.TblErrorLogTableAdapter.Update(Me.MxDatabaseDataSet.tblErrorLog)
        Me.TblErrorLogTableAdapter.Fill(Me.MxDatabaseDataSet.tblErrorLog)

        Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

        Me.TblMessageAlertTableAdapter.Update(Me.MxDatabaseDataSet.tblMessageAlert)
        Me.TblMessageAlertTableAdapter.Fill(Me.MxDatabaseDataSet.tblMessageAlert)

        Me.TblWebsiteHelpLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)

        Me.TblRegexUpdateTableAdapter.Update(Me.MxDatabaseDataSet.tblRegexUpdate)
        Me.TblRegexUpdateTableAdapter.Fill(Me.MxDatabaseDataSet.tblRegexUpdate)
    End Sub



    Private Sub AdminSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblRegexUpdate' table. You can move, or remove it, as needed.
        Me.TblRegexUpdateTableAdapter.Fill(Me.MxDatabaseDataSet.tblRegexUpdate)

        Me.TblRegexUpdateTableAdapter.Fill(Me.MxDatabaseDataSet.tblRegexUpdate)

        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)

        Me.TblMessageAlertTableAdapter.Fill(Me.MxDatabaseDataSet.tblMessageAlert)

        Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

        Me.TblUserNamesTableAdapter.Fill(Me.MxDatabaseDataSet.tblUserNames)

        Me.TblErrorLogTableAdapter.Fill(Me.MxDatabaseDataSet.tblErrorLog)

    End Sub

  

    Private Sub TblErrorLogDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblErrorLogDataGridView.CellEndEdit
        Me.TblErrorLogTableAdapter.Update(Me.MxDatabaseDataSet.tblErrorLog)
        'Me.TblErrorLogTableAdapter.Fill(Me.MxDatabaseDataSet.tblErrorLog)
    End Sub

    Private Sub TblErrorLogDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblErrorLogDataGridView.UserDeletedRow
        Me.TblErrorLogTableAdapter.Update(Me.MxDatabaseDataSet.tblErrorLog)
        'Me.TblErrorLogTableAdapter.Fill(Me.MxDatabaseDataSet.tblErrorLog)
    End Sub

 
    Private Sub TblMorningSheetLocationDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMorningSheetLocationDataGridView.CellEndEdit
        Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        'Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
    End Sub

    Private Sub TblMorningSheetLocationDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblMorningSheetLocationDataGridView.UserDeletedRow
        Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        ' Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
    End Sub

 


    Private Sub TblMessageAlertDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMessageAlertDataGridView.CellEndEdit
        Me.TblMessageAlertTableAdapter.Update(Me.MxDatabaseDataSet.tblMessageAlert)
    End Sub


    Private Sub TblWebsiteHelpLocationDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblWebsiteHelpLocationDataGridView.CellEndEdit
        Me.TblWebsiteHelpLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
    End Sub


    Private Sub TblRegexUpdateDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Me.TblRegexUpdateTableAdapter.Update(Me.MxDatabaseDataSet.tblRegexUpdate)
    End Sub
End Class