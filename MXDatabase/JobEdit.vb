Imports System.Data.SqlClient

Public Class JobEdit
    Dim NewRunRemoveSC As New RemoveSpecialCharacters()
    Dim TempString As String = ""

    Event ARecordDeleted()
    Private Sub TblJobsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblJobsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MxDatabaseDataSet)

    End Sub

    Private Sub JobEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        NewRunRemoveSC.SetOrigString(CorrActionTextBox.Text)
        NewRunRemoveSC.SetSpecialCharacter("\'")
        TempString = NewRunRemoveSC.RunRemoveAction()

        sqlUpdateBetter("CorrAction", TempString, "tblJobs")

        If Me.CWDateTimeTextBox.Text.Length < 2 And Me.CorrActionTextBox.Text.Length > 1 Then

            sqlUpdateBetter("CWDateTime", System.DateTime.Now.ToUniversalTime.ToString, "tblJobs")

        End If

        Me.Dispose()

    End Sub

    Private Sub JobEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.tblJobs)

    End Sub

    Private Sub CorrActionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrActionTextBox.TextChanged
        NewRunRemoveSC.SetOrigString(CorrActionTextBox.Text)
        NewRunRemoveSC.SetSpecialCharacter("\'")
        TempString = NewRunRemoveSC.RunRemoveAction()

        sqlUpdateBetter("CorrAction", TempString, "tblJobs")
    End Sub

    Private Sub sqlUpdateBetter(ByVal feild As String, ByVal value As String, ByVal TableName As String)
        

        Dim newConnection As SqlConnection
        Dim newCommand As SqlCommand
        Dim ra1 As Integer

        newConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        newConnection.Open()

        If Me.WCETextBox.Text = "" Then
            newCommand = New SqlCommand("UPDATE " & TableName & " set " & feild & "='" & value & "' WHERE AcftTailNum='" & Me.AcftTailNumTextBox.Text & "' AND JCN='" & Me.JCNTextBox.Text & "' AND (WCE='" & Me.WCETextBox.Text & "' OR WCE IS NULL)", newConnection)
        Else
            newCommand = New SqlCommand("UPDATE " & TableName & " set " & feild & "='" & value & "' WHERE AcftTailNum='" & Me.AcftTailNumTextBox.Text & "' AND JCN='" & Me.JCNTextBox.Text & "' AND WCE='" & Me.WCETextBox.Text & "'", newConnection)
        End If

        ra1 = newCommand.ExecuteNonQuery
        newConnection.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newConnection As SqlConnection
        Dim newCommand As SqlCommand
        Dim ra1 As Integer

        newConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        newConnection.Open()

        If Me.WCETextBox.Text = "" Then
            newCommand = New SqlCommand("DELETE from tblJobs WHERE  AcftTailNum= '" & AcftTailNumTextBox.Text & "' AND JCN = '" & JCNTextBox.Text & "'", newConnection)
        Else
            newCommand = New SqlCommand("DELETE from tblJobs WHERE  AcftTailNum= '" & AcftTailNumTextBox.Text & "' AND JCN = '" & JCNTextBox.Text & "' AND WCE = '" & WCETextBox.Text & "'", newConnection)
        End If

        ra1 = newCommand.ExecuteNonQuery
        newConnection.Close()

        RaiseEvent ARecordDeleted()

        Me.Close()

    End Sub
End Class