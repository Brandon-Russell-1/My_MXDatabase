Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class MRTEdit
    Event MRTArchivedEvent()
    Private Sub TblMRTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblMRTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MxDatabaseDataSet)

    End Sub

    Private Sub MRTEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            myCommand = New SqlCommand("insert into Archive_tblMRT(MRTInOut, MRTAcft, MRTDateTimeReq, MRTJCN, MRTRemarks, MRTDateTimeArr, MRTDateTimeCmp, MRTLocation, MRTType, MRTPersonSpec, MRTEquipType, MRTEquipPN, MRTEquipNSN, TheAutoPrimKey) values('" & Me.MRTInOutCmb.Text & "','" & Me.MRTAcftTextBox.Text & "','" & Me.MRTDateTimeReqDateTimePicker.Text & "','" & Me.MRTJCNTextBox.Text & "','" & Me.MRTRemarksTextBox.Text & "','" & Me.MRTDateTimeArrDateTimePicker.Text & "','" & Me.MRTDateTimeCmpDateTimePicker.Text & "','" & Me.MRTLocationTextBox.Text & "','" & Me.MRTTypeTextBox.Text & "','" & Me.MRTPersonSpecTextBox.Text & "','" & Me.MRTEquipTypeTextBox.Text & "','" & Me.MRTEquipPNTextBox.Text & "','" & Me.MRTEquipNSNTextBox.Text & "', " & Me.TheAutoPrimKeyTextBox.Text & ")", myConnection)
            myCommand.Transaction = sqltrans
            ra = myCommand.ExecuteNonQuery

            myCommand = New SqlCommand("DELETE FROM tblMRT WHERE TheAutoPrimKey=" & Me.TheAutoPrimKeyTextBox.Text & "", myConnection)
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
            RaiseEvent MRTArchivedEvent()
            Me.Close()
        End Try
    End Sub


    Private Sub sqlUpdateBetter(ByVal feild As String, ByVal value As String, ByVal TableName As String, ByVal WhereField As String, ByVal WhereValue As String)
        Dim newConnection As SqlConnection
        Dim newCommand As SqlCommand
        Dim ra1 As Integer

        newConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        newConnection.Open()

        newCommand = New SqlCommand("UPDATE " & TableName & " set " & feild & "='" & value & "' WHERE " & WhereField & " = " & WhereValue & "", newConnection)
        ra1 = newCommand.ExecuteNonQuery
        'MsgBox(ra1)
        newConnection.Close()
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



    Private Sub MRTAcftTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTAcftTextBox.TextChanged
        sqlUpdateBetter("MRTAcft", Me.MRTAcftTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTJCNTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTJCNTextBox.TextChanged
        sqlUpdateBetter("MRTJCN", Me.MRTJCNTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTLocationTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTLocationTextBox.TextChanged
        sqlUpdateBetter("MRTLocation", Me.MRTLocationTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTTypeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTTypeTextBox.TextChanged
        sqlUpdateBetter("MRTType", Me.MRTTypeTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTDateTimeReqDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTDateTimeReqDateTimePicker.ValueChanged
        sqlUpdateBetter("MRTDateTimeReq", Me.MRTDateTimeReqDateTimePicker.Value, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTDateTimeArrDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTDateTimeArrDateTimePicker.ValueChanged
        sqlUpdateBetter("MRTDateTimeArr", Me.MRTDateTimeArrDateTimePicker.Value, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTDateTimeCmpDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTDateTimeCmpDateTimePicker.ValueChanged
        sqlUpdateBetter("MRTDateTimeCmp", Me.MRTDateTimeCmpDateTimePicker.Value, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTPersonSpecTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTPersonSpecTextBox.TextChanged
        sqlUpdateBetter("MRTPersonSpec", Me.MRTPersonSpecTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTEquipTypeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTEquipTypeTextBox.TextChanged
        sqlUpdateBetter("MRTEquipType", Me.MRTEquipTypeTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTEquipPNTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTEquipPNTextBox.TextChanged
        sqlUpdateBetter("MRTEquipPN", Me.MRTEquipPNTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTEquipNSNTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTEquipNSNTextBox.TextChanged
        sqlUpdateBetter("MRTEquipNSN", Me.MRTEquipNSNTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTRemarksTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTRemarksTextBox.TextChanged
        sqlUpdateBetter("MRTRemarks", Me.MRTRemarksTextBox.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub

    Private Sub MRTInOutCmb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTInOutCmb.TextChanged
        sqlUpdateBetter("MRTInOut", Me.MRTInOutCmb.Text, "tblMRT", "TheAutoPrimKey", Me.TheAutoPrimKeyTextBox.Text)
        RaiseEvent MRTArchivedEvent()
    End Sub
End Class