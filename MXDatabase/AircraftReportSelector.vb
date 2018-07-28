Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AircraftReportSelector



    Private Sub AircraftReportSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblMorningSheetLocation' table. You can move, or remove it, as needed.
        Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

        Me.Archive_tblTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblTurnover)
        Me.TblTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblTurnover)
        Me.Archive_tblSOETableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblSOE)
        Me.Archive_tblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblJobs)
        Me.TblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.tblJobs)
        Me.TblSOETableAdapter.Fill(Me.MxDatabaseDataSet.tblSOE)
        Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)
        Me.Archive_tblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)

    End Sub

    Private Sub btnOpenACReportOnStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenACReportOnStation.Click
        Try
            Dim GetPrimKey As String = Me.AcftTailNumberListBox.SelectedValue

            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row


            OpenReportViewer.activeAircraftReport1.FileName = TempLocation & "ActiveAircraftReport.rpt"

            Me.TblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.tblAcftOnStation)
            Me.TblSOETableAdapter.Update(Me.MxDatabaseDataSet.tblSOE)
            Me.TblJobsTableAdapter.Update(Me.MxDatabaseDataSet.tblJobs)

            Me.TblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.tblJobs)
            Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)
            Me.TblSOETableAdapter.Fill(Me.MxDatabaseDataSet.tblSOE)

            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\ActiveAircraftReport.rpt"
            OpenReportViewer.activeAircraftReport1.Refresh()
            OpenReportViewer.activeAircraftReport1.VerifyDatabase()

            OpenReportViewer.activeAircraftReport1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.activeAircraftReport1
            OpenReportViewer.CrystalReportViewer1.SelectionFormula = "{tblAcftOnStation.PrimKey}= '" & GetPrimKey & "'"

            OpenReportViewer.Show()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening Report")
        End Try
    End Sub





    Private Sub btnOpenACReportAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenACReportAll.Click
        Try
            Dim GetPrimKey As String = Me.ListBox4.SelectedValue

            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.archivedAircraftReport1.FileName = TempLocation & "ArchivedAircraftReport.rpt"
            Me.Archive_tblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
            Me.Archive_tblSOETableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblSOE)
            Me.Archive_tblJobsTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblJobs)

            Me.Archive_tblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
            Me.Archive_tblSOETableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblSOE)
            Me.Archive_tblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblJobs)

            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\ArchivedAircraftReport.rpt"
            OpenReportViewer.archivedAircraftReport1.Refresh()
            OpenReportViewer.archivedAircraftReport1.VerifyDatabase()

            OpenReportViewer.archivedAircraftReport1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.archivedAircraftReport1
            OpenReportViewer.CrystalReportViewer1.SelectionFormula = "{Archive_tblAcftOnStation.PrimKey}= '" & GetPrimKey & "'"

            OpenReportViewer.Show()

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening Report")
        End Try
    End Sub

    Private Sub btnOpen48ReportOnStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen48ReportOnStation.Click
        Try
            Dim GetPrimKey As String = Me.AcftTailNumberListBox.SelectedValue

            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.foureightHrReport1.FileName = TempLocation & "Active48hr.rpt"
            Me.TblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.tblAcftOnStation)
            Me.TblSOETableAdapter.Update(Me.MxDatabaseDataSet.tblSOE)
            Me.TblJobsTableAdapter.Update(Me.MxDatabaseDataSet.tblJobs)
            Me.TblTurnoverTableAdapter.Update(Me.MxDatabaseDataSet.tblTurnover)

            Me.TblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.tblJobs)
            Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)
            Me.TblSOETableAdapter.Fill(Me.MxDatabaseDataSet.tblSOE)
            Me.TblTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblTurnover)

            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\Active48hr.rpt"
            OpenReportViewer.foureightHrReport1.Refresh()
            OpenReportViewer.foureightHrReport1.VerifyDatabase()

            OpenReportViewer.foureightHrReport1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.foureightHrReport1
            OpenReportViewer.CrystalReportViewer1.SelectionFormula = "{tblAcftOnStation.PrimKey}= '" & GetPrimKey & "'"

            OpenReportViewer.Show()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening Report")
        End Try
    End Sub

    Private Sub btnOpen48hrReportAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen48hrReportAll.Click
        Try

            Dim GetPrimKey As String = Me.ListBox4.SelectedValue

            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.archive48hr1.FileName = TempLocation & "Archive48hr.rpt"
            Me.Archive_tblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
            Me.Archive_tblSOETableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblSOE)
            Me.Archive_tblJobsTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblJobs)
            Me.Archive_tblTurnoverTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblTurnover)

            Me.Archive_tblTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblTurnover)
            Me.Archive_tblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
            Me.Archive_tblSOETableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblSOE)
            Me.Archive_tblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblJobs)

            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\Archive48hr.rpt"
            OpenReportViewer.archive48hr1.Refresh()
            OpenReportViewer.archive48hr1.VerifyDatabase()

            OpenReportViewer.archive48hr1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.archive48hr1
            OpenReportViewer.CrystalReportViewer1.SelectionFormula = "{Archive_tblAcftOnStation.PrimKey}= '" & GetPrimKey & "'"

            OpenReportViewer.Show()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening Report")
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
End Class