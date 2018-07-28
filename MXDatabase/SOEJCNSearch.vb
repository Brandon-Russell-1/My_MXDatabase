Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SOEJCNSearch


    Private Sub SOEJCNSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.JobReportFilter' table. You can move, or remove it, as needed.
        Me.JobReportFilterTableAdapter.Fill(Me.MxDatabaseDataSet.JobReportFilter)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblMorningSheetLocation' table. You can move, or remove it, as needed.
        Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.Archive_tblJobs' table. You can move, or remove it, as needed.
        Me.Archive_tblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblJobs)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.Archive_tblSOE' table. You can move, or remove it, as needed.
        Me.Archive_tblSOETableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblSOE)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.ReportFilter' table. You can move, or remove it, as needed.
        Me.ReportFilterTableAdapter.Fill(Me.MxDatabaseDataSet.ReportFilter)

    End Sub

    Private Sub btnSOESearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSOESearch.Click

        ' Try
        'MsgBox(Me.RecallDropDown.Text)
        sqlUpdateBetter("TheFilter", Me.SOEStartDate.Value, "ReportFilter", "TheName", "SOE")
        sqlUpdateBetter("TheFilter2", Me.SOEEndDate.Value, "ReportFilter", "TheName", "SOE")
        sqlUpdateBetter("TheFilter3", Me.txtSOEKeyword.Text, "ReportFilter", "TheName", "SOE")

        Me.ReportFilterTableAdapter.Update(Me.MxDatabaseDataSet.ReportFilter)
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).BeginEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).Item("TheFilter") = Me.SOEStartDate.Value
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).EndEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).AcceptChanges()

        Me.ReportFilterTableAdapter.Update(Me.MxDatabaseDataSet.ReportFilter)
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).BeginEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).Item("TheFilter2") = Me.SOEEndDate.Value
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).EndEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).AcceptChanges()

        Me.ReportFilterTableAdapter.Update(Me.MxDatabaseDataSet.ReportFilter)
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).BeginEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).Item("TheFilter3") = Me.txtSOEKeyword.Text
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).EndEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(1).AcceptChanges()


        Dim OpenReportViewer As New TheReportViewer
        Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempLocation As String = ""
        For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
            TempLocation = row("Location").ToString
        Next row
        OpenReportViewer.soesearch1.FileName = TempLocation & "SOESearch.rpt"
        OpenReportViewer.CrystalReportViewer1.RefreshReport()
        'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\MorningSheet.rpt"
        OpenReportViewer.soesearch1.Refresh()
        OpenReportViewer.soesearch1.VerifyDatabase()

        OpenReportViewer.soesearch1.SetDataSource(MxDatabaseDataSet)
        OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.soesearch1

        OpenReportViewer.Show()

        ' Catch ex As Exception
        'MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
        '   MsgBox("Error opening report" & ex.Message)
        '   MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on SOE Search Report Open")
        ' End Try



    End Sub

    Private Sub btnJOBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJOBSearch.Click
        ' Try
        'MsgBox(Me.RecallDropDown.Text)
        Dim TheWUC As String = ""
        Dim TheStartDate As String = ""
        Dim TheEndDate As String = ""
        Dim TheKeyword As String = ""
        TheWUC = Me.txtWUC.Text
        TheStartDate = Me.JobStartDate.Value
        TheEndDate = Me.JobEndDate.Value
        TheKeyword = Me.txtJobKeyword.Text

        sqlUpdateBetter("TheFilter", TheWUC, "ReportFilter", "TheName", "JOB")
        sqlUpdateBetter("TheFilter2", TheStartDate, "ReportFilter", "TheName", "JOB")
        sqlUpdateBetter("TheFilter3", TheEndDate, "ReportFilter", "TheName", "JOB")
        sqlUpdateBetter("TheFilter4", TheKeyword, "ReportFilter", "TheName", "JOB")

        Me.ReportFilterTableAdapter.Update(Me.MxDatabaseDataSet.ReportFilter)
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).BeginEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).Item("TheFilter") = TheWUC
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).EndEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).AcceptChanges()

        Me.ReportFilterTableAdapter.Update(Me.MxDatabaseDataSet.ReportFilter)
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).BeginEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).Item("TheFilter2") = TheStartDate
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).EndEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).AcceptChanges()

        Me.ReportFilterTableAdapter.Update(Me.MxDatabaseDataSet.ReportFilter)
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).BeginEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).Item("TheFilter3") = TheEndDate
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).EndEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).AcceptChanges()

        Me.ReportFilterTableAdapter.Update(Me.MxDatabaseDataSet.ReportFilter)
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).BeginEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).Item("TheFilter4") = TheKeyword
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).EndEdit()
        Me.MxDatabaseDataSet.ReportFilter.FindByTheAutoPrimKey(2).AcceptChanges()


        Dim OpenReportViewer As New TheReportViewer
        Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
        Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempLocation As String = ""
        For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
            TempLocation = row("Location").ToString
        Next row
        OpenReportViewer.jobSearch1.FileName = TempLocation & "JOBSearch.rpt"
        OpenReportViewer.CrystalReportViewer1.RefreshReport()
        'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\MorningSheet.rpt"
        OpenReportViewer.jobSearch1.Refresh()
        OpenReportViewer.jobSearch1.VerifyDatabase()

        OpenReportViewer.jobSearch1.SetDataSource(MxDatabaseDataSet)
        OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.jobSearch1

        OpenReportViewer.Show()

        ' Catch ex As Exception
        'MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
        '   MsgBox("Error opening report" & ex.Message)
        '   MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on SOE Search Report Open")
        ' End Try
    End Sub


    Private Sub sqlUpdateBetter(ByVal feild As String, ByVal value As String, ByVal TableName As String, ByVal WhereField As String, ByVal WhereValue As String)
        Dim newConnection As SqlConnection
        Dim newCommand As SqlCommand
        Dim ra1 As Integer

        newConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        newConnection.Open()

        newCommand = New SqlCommand("UPDATE " & TableName & " set " & feild & "='" & value & "' WHERE " & WhereField & " = '" & WhereValue & "'", newConnection)
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


End Class