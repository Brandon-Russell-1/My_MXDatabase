Public Class ArchivedAircraftEdit

    Private Sub Archive_tblAcftOnStationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Archive_tblAcftOnStationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MxDatabaseDataSet)

    End Sub

    Private Sub ArchivedAircraftEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Archive_tblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
    End Sub

    Private Sub ArchivedAircraftEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.Archive_tblAcftOnStation' table. You can move, or remove it, as needed.
        Me.Archive_tblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)

    End Sub

    Private Sub Archive_tblAcftOnStationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Archive_tblAcftOnStationDataGridView.CellContentClick

    End Sub

    Private Sub Archive_tblAcftOnStationDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Archive_tblAcftOnStationDataGridView.CellEndEdit
        Me.Archive_tblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
    End Sub
End Class