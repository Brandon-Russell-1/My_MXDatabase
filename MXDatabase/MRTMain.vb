Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class MRTMain
    Dim WithEvents NewEditMRT As MRTEdit = New MRTEdit
    Private Sub TblMRTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblMRTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MxDatabaseDataSet)

    End Sub

    Private Sub MRTMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblMRT' table. You can move, or remove it, as needed.
        Me.TblMRTTableAdapter.Fill(Me.MxDatabaseDataSet.tblMRT)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ra As Integer
        Dim myConnection As SqlConnection
        Dim myCommand As SqlCommand
        Dim sqltrans As SqlTransaction
        myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        myConnection.Open()
        'Begin Transaction
        sqltrans = myConnection.BeginTransaction
        Try
            myCommand = New SqlCommand("insert into tblMRT(MRTInOut, MRTAcft, MRTDateTimeReq, MRTJCN, MRTRemarks, MRTDateTimeArr, MRTDateTimeCmp, MRTLocation, MRTType, MRTPersonSpec, MRTEquipType, MRTEquipPN, MRTEquipNSN) values('" & Me.MRTInOutCmb.Text & "','" & Me.MRTAcftTextBox.Text & "','" & Me.MRTDateTimeReqDateTimePicker.Text & "','" & Me.MRTJCNTextBox.Text & "','" & Me.MRTRemarksTextBox.Text & "','" & Me.MRTDateTimeArrDateTimePicker.Text & "','" & Me.MRTDateTimeCmpDateTimePicker.Text & "','" & Me.MRTLocationTextBox.Text & "','" & Me.MRTTypeTextBox.Text & "','" & Me.MRTPersonSpecTextBox.Text & "','" & Me.MRTEquipTypeTextBox.Text & "','" & Me.MRTEquipPNTextBox.Text & "','" & Me.MRTEquipNSNTextBox.Text & "')", myConnection)
            myCommand.Transaction = sqltrans
            ra = myCommand.ExecuteNonQuery

            sqltrans.Commit()
            'MsgBox("Transactions Commited")

        Catch ex As Exception
            'Rollback Transactions
            sqltrans.Rollback()
            'MsgBox("transactions rolled back" & vbCrLf & ex.Message)
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "RollBack on Fuel Add")
        Finally
            myConnection.Close()
            Me.TblMRTTableAdapter.Update(Me.MxDatabaseDataSet.tblMRT)
            Me.TblMRTTableAdapter.Fill(Me.MxDatabaseDataSet.tblMRT)

        End Try
    End Sub

    Private Sub MyErrorLog(ByVal TheDescription As String, ByVal TheDate As Date, ByVal TheUser As String, ByVal TheMessage As String)
        TheDescription = Regex.Replace(TheDescription, "\'", " ", RegexOptions.Singleline)
        Dim myConnection As SqlConnection
        myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        myConnection.Open()

        Dim com As SqlCommand = New SqlCommand("insert into tblErrorLog(txtErrDescription, txtErrDate, txtUser, txtApplication) values('" & TheDescription & "','" & TheDate & "', '" & TheUser & "', '" & TheMessage & "')", myConnection)
        Dim result As Integer = com.ExecuteNonQuery

        myConnection.Close()
    End Sub

 

    Private Sub TblMRTDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMRTDataGridView.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim PrimObj As Object = TblMRTDataGridView.Rows(e.RowIndex).Cells(0).Value
        Dim TempPrim As Int64 = Convert.ToInt64(PrimObj)
        
        If NewEditMRT.IsDisposed Then
            NewEditMRT = New MRTEdit
        End If
        NewEditMRT.TblMRTBindingSource.Filter = "TheAutoPrimKey=" & TempPrim
        NewEditMRT.Show()
    End Sub

 
    Private Sub NewEditMRT_MRTArchivedEvent() Handles NewEditMRT.MRTArchivedEvent
        Me.TblMRTTableAdapter.Update(Me.MxDatabaseDataSet.tblMRT)
        Me.TblMRTTableAdapter.Fill(Me.MxDatabaseDataSet.tblMRT)
    End Sub
End Class