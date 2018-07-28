Imports System
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Collections.Generic
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports CrystalDecisions.Enterprise.InfoStore
Imports CrystalDecisions.Web
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource


Delegate Sub myDelegate()
Delegate Sub myDelegate2()
Delegate Sub myDelegate3()
Delegate Sub myDelegate4()
Delegate Sub myDelegate5()
Delegate Sub myDelegate6()
Delegate Sub myDelegate7()
Delegate Sub myDelegate8()

Public Class Main
    Dim CheckSSL As Integer
    Dim WithEvents SOEForm As AddSOEForm = New AddSOEForm
    Dim WithEvents TurnoverForm As AddTurnoverForm = New AddTurnoverForm
    Dim WithEvents TheAcftAdd As acftAdd = New acftAdd
    Dim WithEvents TheJobAdd As jobAdd = New jobAdd


    Dim Get_A4_Time As Regex = New Regex("lblAsOfDate"".*>Current as of:</strong>(?<Time>.*?,.*?/.\d+:\d+.*?)<")
    Dim Time_Match As Match

    Dim Get_A4_Error As Regex = New Regex(">No aircraft found using the current selection criteria<")
    Dim A4_Error_Match As Match

    Dim Get_A4_NoParam As New Regex("action=""params.aspx""", RegexOptions.Singleline)
    Dim A4_NoParam As Match

    Dim Get_Web_Down As New Regex(">The Web Server may be down, too busy, or experiencing other problems preventing it from responding to requests. You may wish to try again at a later time.<", RegexOptions.Singleline)
    Dim Web_Down_Match As Match

    Dim Get_Web_Down2 As New Regex(">Navigation to the webpage was canceled<", RegexOptions.Singleline)
    Dim Web_Down_Match2 As Match

    Dim Get_Web_Down3 As New Regex(">This program cannot display the webpage<", RegexOptions.Singleline)
    Dim Web_Down_Match3 As Match

    Dim Get_Web_Down4 As New Regex(">The page requires a client certificate<", RegexOptions.Singleline)
    Dim Web_Down_Match4 As Match

    Dim Get_Web_Down5 As New Regex(">Access Denied<", RegexOptions.Singleline)
    Dim Web_Down_Match5 As Match

    Dim Get_Web_Down6 As New Regex(">Server Error", RegexOptions.Singleline)
    Dim Web_Down_Match6 As Match

    Dim Get_Web_Down7 As New Regex(">The page cannot be found<", RegexOptions.Singleline)
    Dim Web_Down_Match7 As Match

    Dim Get_Web_Down8 As New Regex(">Appliance Error<", RegexOptions.Singleline)
    Dim Web_Down_Match8 As Match

    Dim MonthToDigit As New Hashtable


    Dim Get_A4_AircraftData As New Regex("(table class=""acTbl"".*?""acIdData"">(?<TailNum>.{6,8})<.*?Status.*?""acData"">(?<Status>.*?)<.*?Mission.*?acData"">(?<Mission>.*?)<.*?acRmrksData.*?>(?<Remarks>.*?)<.*?""acLbls"">MDS.*?""acIdData"">(?<MDS>.*?)<.*?ETIC.*?acData"">(?<ETIC>.*?)<.*?ETD.*?acData"">(?<ETD>.*?)<.*?LOX.*?acData"">(?<LOX>.*?)<.*?Preflt.*?acData"">(?<Preflt>.*?)<.*?acLbls.*?Block In.*?acData"">(?<BlockIn>.*?)<.*?Fuel.*?acData"">(?<Fuel>.*?)<.*?LN2.*?acData"">(?<LN2>.*?)<.*?HSC.*?acData"">(?<HSC>.*?)<.*?Spot.*?acData"">(?<Spot>.*?)<.*?Last Dep.*?acData"">(?<LastDep>.*?)<.*?Config.*?acData"">(?<Config>.*?)<.*?ISO Due.*?acData"">(?<ISO>.*?)<.*?</table>)+", RegexOptions.Singleline)
    '
    Dim AircraftData_Match As Match

    Dim Get_A4_StatusJCN As New Regex("tblStatusDiscrepancies.*?StatusJcn"".value=""(?<StatusJCN>.*?)"".*?>(?<StatusIndex>\d+)\.\d+<.*?tdJcnDisplay.*?>.*?<.*?text-align:.left;"">(?<WUC>.*?)<.*?color:red.*?>(?<SYMBOL>.*?)<.*?<strong>(?<Narr>.*?)</strong>.*?</tr>.*?</table>", RegexOptions.Singleline)
    '
    Dim StatusJCN_Match As Match

    Dim Get_A4_Jobs As New Regex("(lblIndex"">(?<Index>\d+)\..*?lblJcnDisplay"">(?<JCN>.*?)<\/span.*?lblWes"">(?<WES>.*?)<.*?lblWorkCode"">(?<WUC>.*?)<.*?lblShopZone"">(?<ShopZone>.*?)<\/span>.*?lblSymbol"">(?<Symbol>.*?)<.*?lblDiscrepancy""><strong>(?<Narr>.*?)</span)+", RegexOptions.Singleline)
    '
    Dim A4Job_Match As Match

    Dim alarmTime As Date
    Dim StartRandomRefresh As Integer = 180000
    Dim EndRandomRefresh As Integer = 480000
    'Dim RefreshInProgress As Boolean = False
    'Dim ReportOpenInProgress As Boolean = False

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            UpdateMyDataSources()
            Application.ExitThread()
            Application.Exit()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub




    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblBlocker' table. You can move, or remove it, as needed.
        Me.TblBlockerTableAdapter.Fill(Me.MxDatabaseDataSet.tblBlocker)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.Archive_tblMRT' table. You can move, or remove it, as needed.
        Me.Archive_tblMRTTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblMRT)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblMRT' table. You can move, or remove it, as needed.
        Me.TblMRTTableAdapter.Fill(Me.MxDatabaseDataSet.tblMRT)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.ReportFilter' table. You can move, or remove it, as needed.
        Me.ReportFilterTableAdapter.Fill(Me.MxDatabaseDataSet.ReportFilter)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.Archive_tblPOL' table. You can move, or remove it, as needed.
        Me.Archive_tblPOLTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblPOL)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblPOL' table. You can move, or remove it, as needed.
        Me.TblPOLTableAdapter.Fill(Me.MxDatabaseDataSet.tblPOL)

        MonthToDigit.Add("jan", 1)
        MonthToDigit.Add("feb", 2)
        MonthToDigit.Add("mar", 3)
        MonthToDigit.Add("apr", 4)
        MonthToDigit.Add("may", 5)
        MonthToDigit.Add("jun", 6)
        MonthToDigit.Add("jul", 7)
        MonthToDigit.Add("aug", 8)
        MonthToDigit.Add("sep", 9)
        MonthToDigit.Add("oct", 10)
        MonthToDigit.Add("nov", 11)
        MonthToDigit.Add("dec", 12)


        CheckSSL = 0

        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
        Me.TblSnappleFactsTableAdapter.Fill(Me.MxDatabaseDataSet.tblSnappleFacts)
        Me.TblMessageAlertTableAdapter.Fill(Me.MxDatabaseDataSet.tblMessageAlert)
        Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)


        Me.Archive_tblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
        Me.TblMorningSheetNotesTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetNotes)
        Me.TblTempMorningSheetPWTableAdapter.Fill(Me.MxDatabaseDataSet.tblTempMorningSheetPW)
        Me.TblGeneralInfoTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralInfo)
        Me.TblGeneralTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralTurnover)
        Me.TEMPInboundTableAdapter.Fill(Me.MxDatabaseDataSet.TEMPInbound)
        Me.TblWeatherWarningListTableAdapter.Fill(Me.MxDatabaseDataSet.tblWeatherWarningList)
        Me.TblUserNamesTableAdapter.Fill(Me.MxDatabaseDataSet.tblUserNames)
        Me.TblDevCodeListTableAdapter.Fill(Me.MxDatabaseDataSet.tblDevCodeList)

        Try
            Timer2.Start()
            Me.TblTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblTurnover)
            Me.TblSOETableAdapter.Fill(Me.MxDatabaseDataSet.tblSOE)
            Me.TblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.tblJobs)
            Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)
            Me.TblWeatherCurrentTableAdapter.Fill(Me.MxDatabaseDataSet.tblWeatherCurrent)

            lblJulianDay.Text = System.DateTime.Now.DayOfYear
            'RefreshMyDataSources()
            'Timer1.Start()
            'Connect to A4 Code
            'Me.alarmTime = Date.Now.AddMinutes(5)
            Timer3.Enabled = True
            Timer3.Start()

            Dim myThread As New Threading.Thread(AddressOf MainThread)
            myThread.Priority = ThreadPriority.Highest
            myThread.IsBackground = True
            myThread.Start()
            lblA4TimeStamp.Text = ""
            lblA4PageLoad.Text = "A4 Website Loading..."
            'End Connect to A4 Code

        Catch ex As Exception
            MsgBox("Main Form Load Exception caught:" & ex.Message)
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Main Form Load Error")
        End Try
    End Sub


    Private Sub MainThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate(AddressOf A4_Load))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception")
        End Try
    End Sub


    Private Sub A4_Load()
        Dim RandomClass As New Random()

        Try

            Timer3.Stop()
            Me.lblNextRefresh.Text = "Now"
            ManualEntryToolStripMenuItem.Enabled = False
            AddAircraftToolStripMenuItem.Enabled = False
            AddJobToolStripMenuItem.Enabled = False
            EditAircraftToolStripMenuItem.Enabled = False
            'Me.WebBrowserProgressBar.Value = 0
            RefreshMyDataSources()
            Me.WebBrowser1.Tag = "Loading"
            Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
            Me.TblWebsiteHelpLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)

            Dim CheckWebsiteUpdate As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempWebsite As String = ""
            For Each row In CheckWebsiteUpdate("tblWebsiteHelpLocation").Select("ID='A4'")
                TempWebsite = row("Location").ToString
            Next row

            Dim CheckUserDataTable As DataTableCollection = MxDatabaseDataSet.Tables
            Dim CheckAccount As String = ""

            For Each row In CheckUserDataTable("tblUserNames").Select("UserName = '" & My.User.Name.ToString & "'")
                CheckAccount = row("Account").ToString
            Next row

            Dim CheckBlockerBit As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TheBlocker As Boolean = False
            For Each row In CheckBlockerBit("tblBlocker").Select("TheAutoPrimKey=1")
                TheBlocker = row("BlockBit")
            Next row

            If CheckAccount = "G1" Or TheBlocker Then
                lblA4PageLoad.Text = "A4 Website Loading..."

                Me.WebBrowser1.Dispose()
                Me.WebBrowser1 = New WebBrowser
                Me.TabPage4.Controls.Add(Me.WebBrowser1)
                'WebBrowser1
                '
                Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
                Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
                Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
                Me.WebBrowser1.Name = "WebBrowser1"
                Me.WebBrowser1.Size = New System.Drawing.Size(756, 373)
                Me.WebBrowser1.TabIndex = 0
                '

                Me.WebBrowser1.Navigate(TempWebsite)


                While Me.WebBrowser1.Tag <> "Loaded"
                    Application.DoEvents()
                End While

                'https://amclg.okc.disa.mil/mi/aircraftstatussheet/default.aspx



                txtA4HTML.Text = WebBrowser1.DocumentText


                'Begin Regex A4 Code
                Web_Down_Match = Get_Web_Down.Match(txtA4HTML.Text)
                Web_Down_Match2 = Get_Web_Down2.Match(txtA4HTML.Text)
                Web_Down_Match3 = Get_Web_Down3.Match(txtA4HTML.Text)
                Web_Down_Match4 = Get_Web_Down4.Match(txtA4HTML.Text)
                Web_Down_Match5 = Get_Web_Down5.Match(txtA4HTML.Text)
                Web_Down_Match6 = Get_Web_Down6.Match(txtA4HTML.Text)
                Web_Down_Match7 = Get_Web_Down7.Match(txtA4HTML.Text)
                Web_Down_Match8 = Get_Web_Down8.Match(txtA4HTML.Text)
                'MsgBox(Web_Down_Match2.Success.ToString)
                If Web_Down_Match.Success Or Web_Down_Match2.Success Or Web_Down_Match3.Success Or Web_Down_Match4.Success Or Web_Down_Match5.Success Or Web_Down_Match6.Success Or Web_Down_Match7.Success Or Web_Down_Match8.Success Then
                    lblA4PageLoad.Text = "Internet Unavailable"
                    ManualEntryToolStripMenuItem.Enabled = True
                    AddAircraftToolStripMenuItem.Enabled = True
                    AddJobToolStripMenuItem.Enabled = True
                    EditAircraftToolStripMenuItem.Enabled = True
                    Me.lblNextRefresh.Text = "N/A"
                    RefreshMyDataSources()
                    If CheckSSL <> 1 Then
                        If Web_Down_Match4.Success Then
                            CheckSSL = 1
                            Dim CheckSSLMsg As MsgBoxResult
                            CheckSSLMsg = MsgBox("You need to Clear your SSL State!" & vbCrLf & "Goto Tools->Internet Options->Content->Clear SSL State", MsgBoxStyle.OkOnly, "SSL Error")
                            If CheckSSLMsg = MsgBoxResult.Ok Then
                                Dim TempIE As New SHDocVw.InternetExplorer
                                TempIE.Navigate("http://www.google.com")
                                CheckSSL = 0
                            End If
                        End If
                    End If
                    Timer1.Start()
                    'MsgBox("Internet is down, will try again later.")
                    Exit Sub
                End If


                RefreshMyDataSources()

                lblA4TimeStamp.Text = ""
                lblA4PageLoad.Text = "A4 Website Loaded"


                Dim RandomNumber As Integer
                RandomNumber = RandomClass.Next(StartRandomRefresh, EndRandomRefresh)
                While RandomNumber Mod 30000 <> 0
                    RandomNumber = RandomClass.Next(StartRandomRefresh, EndRandomRefresh)
                End While
                Me.alarmTime = Date.Now.AddMilliseconds(RandomNumber)

                Timer3.Start()
                Timer1.Interval = RandomNumber
                Timer1.Start()
                Exit Sub

            End If



            Dim BlockerHash As New Hashtable
            BlockerHash.Add("BlockBit", "True")
            Dim SetTheBlocker As New MySqlBuilder(My.Settings.MxDatabaseConnectionString, BlockerHash, "tblBlocker", "TheAutoPrimKey", "1", "UPDATE")
            SetTheBlocker.RunSQL()

            Dim MyPrimKey As String = ""


            Me.WebBrowser1.Dispose()
            Me.WebBrowser1 = New WebBrowser
            Me.TabPage4.Controls.Add(Me.WebBrowser1)
            'WebBrowser1
            '
            Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.Size = New System.Drawing.Size(756, 373)
            Me.WebBrowser1.TabIndex = 0
            '

            Me.WebBrowser1.Navigate(TempWebsite)


            While Me.WebBrowser1.Tag <> "Loaded"
                Application.DoEvents()
            End While


            lblA4TimeStamp.Text = "A4 Download Current as of: "
            lblA4PageLoad.Text = "Parsing A4 Web Data..."
            txtA4HTML.Text = WebBrowser1.DocumentText
            'Begin Regex A4 Code

            Web_Down_Match = Get_Web_Down.Match(txtA4HTML.Text)

            Web_Down_Match2 = Get_Web_Down2.Match(txtA4HTML.Text)

            Web_Down_Match3 = Get_Web_Down3.Match(txtA4HTML.Text)
            Web_Down_Match4 = Get_Web_Down4.Match(txtA4HTML.Text)
            Web_Down_Match5 = Get_Web_Down5.Match(txtA4HTML.Text)
            Web_Down_Match6 = Get_Web_Down6.Match(txtA4HTML.Text)
            Web_Down_Match7 = Get_Web_Down7.Match(txtA4HTML.Text)
            Web_Down_Match8 = Get_Web_Down8.Match(txtA4HTML.Text)


            If Web_Down_Match.Success Or Web_Down_Match2.Success Or Web_Down_Match3.Success Or Web_Down_Match4.Success Or Web_Down_Match5.Success Or Web_Down_Match6.Success Or Web_Down_Match7.Success Or Web_Down_Match8.Success Then
                lblA4PageLoad.Text = "Internet Unavailable"
                ManualEntryToolStripMenuItem.Enabled = True
                AddAircraftToolStripMenuItem.Enabled = True
                AddJobToolStripMenuItem.Enabled = True
                Me.lblNextRefresh.Text = "N/A"
                'MsgBox("Internet is down, will try again later.")
                RefreshMyDataSources()

                If CheckSSL <> 1 Then
                    If Web_Down_Match4.Success Then
                        CheckSSL = 1
                        Dim CheckSSLMsg As MsgBoxResult
                        CheckSSLMsg = MsgBox("You need to Clear your SSL State!" & vbCrLf & "Goto Tools->Internet Options->Content->Clear SSL State", MsgBoxStyle.OkOnly, "SSL Error")
                        If CheckSSLMsg = MsgBoxResult.Ok Then
                            Dim TempIE As New SHDocVw.InternetExplorer
                            TempIE.Navigate("http://www.google.com")
                            CheckSSL = 0
                        End If
                    End If
                End If

                Timer1.Start()
                Exit Sub
            End If



            A4_Error_Match = Get_A4_Error.Match(txtA4HTML.Text)
            A4_NoParam = Get_A4_NoParam.Match(txtA4HTML.Text)
            If A4_Error_Match.Success Or A4_NoParam.Success Then
                lblA4PageLoad.Text = "You need to setup your A4 Page!"
                Me.lblNextRefresh.Text = "N/A"
            Else

                Dim ra As Integer
                Dim myConnection As SqlConnection
                Dim myCommand As SqlCommand
                Dim sqltrans As SqlTransaction
                myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
                myConnection.Open()
                'Begin Transaction
                sqltrans = myConnection.BeginTransaction
                Try
                    Dim MyAircraftCollection As MatchCollection = Get_A4_AircraftData.Matches(txtA4HTML.Text)
                    Dim MyJobCollection As MatchCollection = Get_A4_Jobs.Matches(txtA4HTML.Text)
                    Dim MyStatusCollection As MatchCollection = Get_A4_StatusJCN.Matches(txtA4HTML.Text)

                    Dim MyTailCount As Integer = MyAircraftCollection.Count - 1
                    Dim MyJobCount As Integer = MyJobCollection.Count - 1
                    Dim MyStatusCount As Integer = MyStatusCollection.Count - 1



                    Time_Match = Get_A4_Time.Match(txtA4HTML.Text)
                    'MsgBox(Time_Match.Groups("Time").Value)
                    'MsgBox("Status Count: " & MyStatusCount)
                    If MyTailCount = 0 Then
                        MsgBox("Congrats! There are no planes on the Ground, go home!")
                        Exit Sub
                    End If

                    myCommand = New SqlCommand("UPDATE tblJobs SET IsCurrent='" & False & "'", myConnection)
                    myCommand.Transaction = sqltrans
                    ra = myCommand.ExecuteNonQuery()
                    myCommand = New SqlCommand("UPDATE tblAcftOnStation SET IsCurrent='" & False & "'", myConnection)
                    myCommand.Transaction = sqltrans
                    ra = myCommand.ExecuteNonQuery()
                    'MsgBox(ra & " - Set records set to false")
                    Dim RamdomClass As New Random
                    For i = 0 To MyTailCount
                        MyPrimKey = MyAircraftCollection.Item(i).Groups("TailNum").Value & MyAircraftCollection.Item(i).Groups("MDS").Value & MyAircraftCollection.Item(i).Groups("BlockIn").Value & MyAircraftCollection.Item(i).Groups("Spot").Value & System.DateTime.Now.Year
                        MyPrimKey = Regex.Replace(MyPrimKey, "[\s\\]+", "")
                        'MsgBox(MyPrimKey)
                        Dim view As DataView = Me.MxDatabaseDataSet.tblAcftOnStation.DefaultView
                        view.RowFilter = "AcftTailNumber='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "'"

                        If view.Count = 0 Then
                            'MsgBox("Add Aircraft")
                            If (Not String.IsNullOrEmpty(MyAircraftCollection.Item(i).Groups("BlockIn").Value)) And (Not String.IsNullOrEmpty(MyAircraftCollection.Item(i).Groups("Spot").Value)) Then

                                Dim TempETDConvert As String = ""
                                Dim TempDateHolder As String = ""
                                Dim TempDateHolder2 As Date
                                Dim TempTimeHolder As String = ""
                                Dim TempCrewShow As String = ""

                                If MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Length > 6 Then
                                    TempTimeHolder = MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Substring(0, 4)
                                    TempDateHolder = MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Substring(5, MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Length - MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.IndexOf("/") - 1)
                                    TempDateHolder2 = DateValue(TempDateHolder)
                                    'MsgBox(TempDateHolder2.DayOfYear.ToString & "/" & TempTimeHolder)

                                End If
                                'MsgBox(MyPrimKey & " - Insert - " & MyAircraftCollection.Item(i).Groups("TailNum").Value)
                                TempCrewShow = UpdateCrewShow(MyAircraftCollection.Item(i).Groups("ETD").Value.ToString, MyAircraftCollection.Item(i).Groups("MDS").Value)
                                Dim TempRemarks As String = ""
                                TempRemarks = Regex.Replace(MyAircraftCollection.Item(i).Groups("Remarks").Value, "\'", " ", RegexOptions.Singleline)
                                myCommand = New SqlCommand("insert into tblAcftOnStation(PrimKey, AcftType, AcftTailNumber, BlockInDateTime, AcftSpot, Status, BPODateTime, Fuel, Nitro, Lox, ETDDateTime, ETICDateTime, MissionNumber, HSCDue, ISODue, LastDepDateTime, Remarks, IsCurrent, ETDJulian, ETDTime, CrewShowEst, CurrConf) values('" & MyPrimKey & "','" & MyAircraftCollection.Item(i).Groups("MDS").Value & "', '" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "','" & MyAircraftCollection.Item(i).Groups("BlockIn").Value & "','" & MyAircraftCollection.Item(i).Groups("Spot").Value & "','" & MyAircraftCollection.Item(i).Groups("Status").Value & "','" & MyAircraftCollection.Item(i).Groups("Preflt").Value & "','" & MyAircraftCollection.Item(i).Groups("Fuel").Value & "','" & MyAircraftCollection.Item(i).Groups("LN2").Value & "','" & MyAircraftCollection.Item(i).Groups("LOX").Value & "','" & MyAircraftCollection.Item(i).Groups("ETD").Value & "','" & MyAircraftCollection.Item(i).Groups("ETIC").Value & "','" & MyAircraftCollection.Item(i).Groups("Mission").Value & "','" & MyAircraftCollection.Item(i).Groups("HSC").Value & "','" & MyAircraftCollection.Item(i).Groups("ISO").Value & "','" & MyAircraftCollection.Item(i).Groups("LastDep").Value & "','" & TempRemarks & "','" & True & "', '" & TempDateHolder2.DayOfYear.ToString & "',' " & TempTimeHolder & "', '" & TempCrewShow & "', '" & MyAircraftCollection.Item(i).Groups("Config").Value & "')", myConnection)
                                myCommand.Transaction = sqltrans
                                ra = myCommand.ExecuteNonQuery()

                                'Begin Gnd time Calculate

                                Dim TheBlockIn As String = ""
                                TheBlockIn = MyAircraftCollection.Item(i).Groups("BlockIn").Value
                                Dim TheETD As String = ""
                                TheETD = MyAircraftCollection.Item(i).Groups("ETD").Value
                                Dim TheHour As Integer
                                Dim TheMinute As Integer
                                Dim CombineHourMinute As String = ""
                                If TheBlockIn <> "" And TheETD <> "" Then

                                    Dim TheBlockInTime As String = TheBlockIn.Substring(0, 4)
                                    Dim TheBlockInMin As String = TheBlockInTime.Substring(2, 2)
                                    Dim TheBlockInHour As String = TheBlockInTime.Substring(0, 2)
                                    Dim TheBlockInDay As String = TheBlockIn.Substring(TheBlockIn.IndexOf("/") + 1, 2)
                                    Dim TheBlockInMonth As String = TheBlockIn.Substring(TheBlockIn.IndexOf("/") + 4, 3)
                                    Dim TheBlockInDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(MonthToDigit(TheBlockInMonth.ToLower)), CInt(TheBlockInDay), CInt(TheBlockInHour), CInt(TheBlockInMin), 0)

                                    Dim TheETDTime As String = TheETD.Substring(0, 4)
                                    Dim TheETDMin As String = TheETDTime.Substring(2, 2)
                                    Dim TheETDHour As String = TheETDTime.Substring(0, 2)
                                    Dim TheETDDay As String = TheETD.Substring(TheETD.IndexOf("/") + 1, 2)
                                    Dim TheETDMonth As String = TheETD.Substring(TheETD.IndexOf("/") + 4, 3)
                                    Dim TheETDDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(MonthToDigit(TheETDMonth.ToLower)), CInt(TheETDDay), CInt(TheETDHour), CInt(TheETDMin), 0)

                                    TheHour = DateDiff(DateInterval.Minute, TheBlockInDate, TheETDDate) / 60
                                    TheMinute = DateDiff(DateInterval.Minute, TheBlockInDate, TheETDDate) Mod 60
                                    CombineHourMinute = TheHour & "+" & TheMinute
                                    myCommand = New SqlCommand("UPDATE tblAcftOnStation SET GroundTime='" & CombineHourMinute & "' WHERE PrimKey='" & MyPrimKey & "'", myConnection)
                                    myCommand.Transaction = sqltrans
                                    ra = myCommand.ExecuteNonQuery
                                End If

                                'End GndTime Calculate
                                'Begin Import Last/Next ICAO From TempInbound
                                'MyAircraftCollection.Item(i).Groups("Mission").Value
                                Dim TempLastICAO As String = ""
                                Dim TempnextICAO As String = ""
                                Dim TempPri As String = ""

                                Dim CheckLastNextTable As DataTableCollection = MxDatabaseDataSet.Tables
                                For Each row In CheckLastNextTable("TEMPInbound").Select("MissionNum = '" & MyAircraftCollection.Item(i).Groups("Mission").Value & "'")
                                    TempLastICAO = row("PrevICAO").ToString
                                    TempnextICAO = row("NextICAO").ToString
                                    TempPri = row("Pri").ToString
                                Next row

                                myCommand = New SqlCommand("UPDATE tblAcftOnStation SET PrevICAO='" & TempLastICAO & "', NextICAO='" & TempnextICAO & "', Pri='" & TempPri & "' WHERE MissionNumber='" & MyAircraftCollection.Item(i).Groups("Mission").Value & "'", myConnection)
                                myCommand.Transaction = sqltrans
                                ra = myCommand.ExecuteNonQuery()

                                'End Import Last/Next ICAO

                                myCommand = New SqlCommand("DELETE FROM TEMPInbound WHERE MissionNum='" & MyAircraftCollection.Item(i).Groups("Mission").Value & "'", myConnection)
                                myCommand.Transaction = sqltrans
                                ra = myCommand.ExecuteNonQuery()

                            End If
                        Else
                            'MsgBox("Update Aircraft")
                            Dim tmpAircraftDataTable As DataTableCollection = MxDatabaseDataSet.Tables

                            For Each row In tmpAircraftDataTable("tblAcftOnStation").Select("AcftTailNumber = '" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "'")
                                MyPrimKey = row("PrimKey").ToString
                            Next row

                            Dim MyStatus As String = ""
                            Dim StatusChangeText As String = ""
                            For Each row In tmpAircraftDataTable("tblAcftOnStation").Select("AcftTailNumber = '" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "'")
                                MyStatus = row("Status").ToString
                            Next row
                            If MyStatus <> MyAircraftCollection.Item(i).Groups("Status").Value Then
                                StatusChangeText = "Status Changed from " & MyStatus & " to " & MyAircraftCollection.Item(i).Groups("Status").Value
                                Dim com As SqlCommand = New SqlCommand("insert into tblSOE(PrimKey, MDS, AcftTailNum, SOEDateTime, Entry, UserName) values('" & MyPrimKey & "','" & MyAircraftCollection.Item(i).Groups("MDS").Value & "', '" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "', '" & System.DateTime.Now & "', '" & StatusChangeText & "', 'Automatic')", myConnection)
                                com.Transaction = sqltrans
                                Dim result As Integer = com.ExecuteNonQuery
                            End If

                            Dim TempETDConvert As String = ""
                            Dim TempDateHolder As String = ""
                            Dim TempDateHolder2 As Date
                            Dim TempTimeHolder As String = ""
                            Dim TempCrewShow As String = ""
                            If MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Length > 6 Then
                                TempTimeHolder = MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Substring(0, 4)
                                TempDateHolder = MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Substring(5, MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.Length - MyAircraftCollection.Item(i).Groups("ETD").Value.ToString.IndexOf("/") - 1)
                                TempDateHolder2 = DateValue(TempDateHolder)
                                'MsgBox(TempDateHolder2.DayOfYear.ToString & "/" & TempTimeHolder)

                            End If



                            'MsgBox(MyPrimKey & " - Updated - " & MyAircraftCollection.Item(i).Groups("Config").Value)
                            'MyPrimKey = Me.MxDatabaseDataSet.tblAcftOnStation.Rows(0).Item(0)
                            TempCrewShow = UpdateCrewShow(MyAircraftCollection.Item(i).Groups("ETD").Value.ToString, MyAircraftCollection.Item(i).Groups("MDS").Value)
                            Dim TempRemarks As String = ""
                            TempRemarks = Regex.Replace(MyAircraftCollection.Item(i).Groups("Remarks").Value, "\'", " ", RegexOptions.Singleline)
                            myCommand = New SqlCommand("UPDATE tblAcftOnStation SET BlockInDateTime='" & MyAircraftCollection.Item(i).Groups("BlockIn").Value & "', AcftSpot='" & MyAircraftCollection.Item(i).Groups("Spot").Value & "', Status='" & MyAircraftCollection.Item(i).Groups("Status").Value & "', BPODateTime='" & MyAircraftCollection.Item(i).Groups("Preflt").Value & "', Fuel='" & MyAircraftCollection.Item(i).Groups("Fuel").Value & "', Nitro='" & MyAircraftCollection.Item(i).Groups("LN2").Value & "', Lox='" & MyAircraftCollection.Item(i).Groups("LOX").Value & "', ETDDateTime='" & MyAircraftCollection.Item(i).Groups("ETD").Value & "', ETICDateTime='" & MyAircraftCollection.Item(i).Groups("ETIC").Value & "', MissionNumber='" & MyAircraftCollection.Item(i).Groups("Mission").Value & "', HSCDue='" & MyAircraftCollection.Item(i).Groups("HSC").Value & "', ISODue='" & MyAircraftCollection.Item(i).Groups("ISO").Value & "', LastDepDateTime='" & MyAircraftCollection.Item(i).Groups("LastDep").Value & "', Remarks='" & TempRemarks & "', IsCurrent='" & True & "', ETDJulian='" & TempDateHolder2.DayOfYear.ToString & "', ETDTime='" & TempTimeHolder & "', CrewShowEst='" & TempCrewShow & "', CurrConf='" & MyAircraftCollection.Item(i).Groups("Config").Value & "' WHERE AcftTailNumber='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "'", myConnection)
                            myCommand.Transaction = sqltrans
                            ra = myCommand.ExecuteNonQuery()

                            'Begin Gnd time Calculate

                            Dim TheBlockIn As String = ""
                            TheBlockIn = MyAircraftCollection.Item(i).Groups("BlockIn").Value
                            Dim TheETD As String = ""
                            TheETD = MyAircraftCollection.Item(i).Groups("ETD").Value
                            Dim TheHour As Integer
                            Dim TheMinute As Integer
                            Dim CombineHourMinute As String = ""
                            If TheBlockIn <> "" And TheETD <> "" Then

                                Dim TheBlockInTime As String = TheBlockIn.Substring(0, 4)
                                Dim TheBlockInMin As String = TheBlockInTime.Substring(2, 2)
                                Dim TheBlockInHour As String = TheBlockInTime.Substring(0, 2)
                                Dim TheBlockInDay As String = TheBlockIn.Substring(TheBlockIn.IndexOf("/") + 1, 2)
                                Dim TheBlockInMonth As String = TheBlockIn.Substring(TheBlockIn.IndexOf("/") + 4, 3)
                                Dim TheBlockInDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(MonthToDigit(TheBlockInMonth.ToLower)), CInt(TheBlockInDay), CInt(TheBlockInHour), CInt(TheBlockInMin), 0)

                                Dim TheETDTime As String = TheETD.Substring(0, 4)
                                Dim TheETDMin As String = TheETDTime.Substring(2, 2)
                                Dim TheETDHour As String = TheETDTime.Substring(0, 2)
                                Dim TheETDDay As String = TheETD.Substring(TheETD.IndexOf("/") + 1, 2)
                                Dim TheETDMonth As String = TheETD.Substring(TheETD.IndexOf("/") + 4, 3)
                                Dim TheETDDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(MonthToDigit(TheETDMonth.ToLower)), CInt(TheETDDay), CInt(TheETDHour), CInt(TheETDMin), 0)

                                TheHour = DateDiff(DateInterval.Minute, TheBlockInDate, TheETDDate) / 60
                                TheMinute = DateDiff(DateInterval.Minute, TheBlockInDate, TheETDDate) Mod 60
                                CombineHourMinute = TheHour & "+" & TheMinute
                                myCommand = New SqlCommand("UPDATE tblAcftOnStation SET GroundTime='" & CombineHourMinute & "' WHERE AcftTailNumber='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "'", myConnection)
                                myCommand.Transaction = sqltrans
                                ra = myCommand.ExecuteNonQuery
                            End If

                            'End GndTime Calculate

                        End If



                        'MsgBox("Test1")
                        For z = 0 To MyStatusCount

                            'MsgBox("Test2 " & MyStatusCollection.Item(0).Groups("StatusIndex").Value)
                            If (MyStatusCollection.Item(z).Groups("StatusIndex").Value = i + 1) Then
                                'MsgBox(MyStatusCollection.Item(z).Groups("StatusIndex").Value & " - " & MyAircraftCollection.Item(i).Groups("TailNum").Value)
                                Dim JCNModify As String = MyStatusCollection.Item(z).Groups("StatusJCN").Value
                                JCNModify = Regex.Replace(MyStatusCollection.Item(z).Groups("StatusJCN").Value, ".*>(.*?)<\/a>", "$1")
                                If JCNModify.Contains("RECUR") Or JCNModify.Contains("REPEAT") Then
                                    JCNModify = Regex.Replace(MyJobCollection.Item(z).Groups("JCN").Value, "(.*?)<.*", "$1")
                                End If
                                'JCNModify = Regex.Replace(MyStatusCollection.Item(z).Groups("StatusJCN").Value, "(.*?)<.*", "$1")

                                Dim view1 As DataView = Me.MxDatabaseDataSet.tblJobs.DefaultView
                                view1.RowFilter = "AcftTailNum='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "' AND JCN='" & JCNModify & "'"
                                'Dim view2 As DataView = Me.MxDatabaseDataSet.tblJobs.DefaultView
                                'view2.RowFilter = "JCN='" & JCNModify & "'"



                                Dim ResultString As String = Regex.Replace(MyStatusCollection.Item(z).Groups("Narr").Value, "</strong><br/>", " ", RegexOptions.Singleline)
                                ResultString = Regex.Replace(ResultString, "\'", " ", RegexOptions.Singleline)



                                'MsgBox(MyStatusCollection.Item(z).Groups("StatusIndex").Value & " - " & MyStatusCollection.Item(z).Groups("StatusJCN").Value & " - " & MyStatusCollection.Item(z).Groups("WUC").Value & " - " & MyStatusCollection.Item(z).Groups("SYMBOL").Value & " - " & MyStatusCollection.Item(z).Groups("Narr").Value)
                                If view1.Count = 0 Then

                                    If (Not String.IsNullOrEmpty(MyAircraftCollection.Item(i).Groups("BlockIn").Value)) And (Not String.IsNullOrEmpty(MyAircraftCollection.Item(i).Groups("Spot").Value)) Then

                                        'MsgBox("Add Status Job" & JCNModify & " " & MyAircraftCollection.Item(i).Groups("TailNum").Value)
                                        myCommand = New SqlCommand("insert into tblJobs(PrimKey, MDS, AcftTailNum, Pacer, JCN, Narr, Symbol, WUC, WhenEntered, IsCurrent,Closed) values('" & MyPrimKey & "','" & MyAircraftCollection.Item(i).Groups("MDS").Value & "', '" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "', '" & True & "','" & JCNModify & "','" & ResultString & "','" & MyStatusCollection.Item(z).Groups("SYMBOL").Value & "','" & MyStatusCollection.Item(z).Groups("WUC").Value & "','" & System.DateTime.Now.ToString & "','" & True & "','" & False & "')", myConnection)
                                        myCommand.Transaction = sqltrans
                                        ra = myCommand.ExecuteNonQuery()
                                    End If
                                Else
                                    'MsgBox("update status job - " & JCNModify & " " & MyAircraftCollection.Item(i).Groups("TailNum").Value)
                                    myCommand = New SqlCommand("UPDATE tblJobs SET Pacer='" & True & "', Narr='" & ResultString & "', Symbol='" & MyStatusCollection.Item(z).Groups("SYMBOL").Value & "', WUC='" & MyStatusCollection.Item(z).Groups("WUC").Value & "', Closed='" & False & "', IsCurrent='" & True & "' WHERE AcftTailNum='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "' AND JCN='" & JCNModify & "'", myConnection)
                                    myCommand.Transaction = sqltrans
                                    ra = myCommand.ExecuteNonQuery()
                                    'MsgBox(ra & " Job Updated - " & JCNModify & " " & MyAircraftCollection.Item(i).Groups("TailNum").Value)

                                End If

                            End If
                        Next
                        For x = 0 To MyJobCount
                            'MsgBox("Test3")
                            If (MyJobCollection.Item(x).Groups("Index").Value = i + 1) Then

                                Dim JCNModify As String = MyJobCollection.Item(x).Groups("JCN").Value
                                JCNModify = Regex.Replace(MyJobCollection.Item(x).Groups("JCN").Value, ".*>(.*?)<\/a>", "$1")
                                If JCNModify.Contains("RECUR") Or JCNModify.Contains("REPEAT") Then
                                    JCNModify = Regex.Replace(MyJobCollection.Item(x).Groups("JCN").Value, "(.*?)<.*", "$1")
                                End If
                                'MsgBox(MyJobCollection.Item(x).Groups("JCN").Value & " - " & JCNModify)
                                Dim view3 As DataView = Me.MxDatabaseDataSet.tblJobs.DefaultView
                                view3.RowFilter = "AcftTailNum='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "' AND JCN ='" & JCNModify & "'"

                                'Dim view4 As DataView = Me.MxDatabaseDataSet.tblJobs.DefaultView
                                'view4.RowFilter = "JCN LIKE '%" & JCNModify & "%'"

                                Dim ResultString As String = Regex.Replace(MyJobCollection.Item(x).Groups("Narr").Value, "</strong><br/>", " ", RegexOptions.Singleline)
                                ResultString = Regex.Replace(ResultString, "\'", " ", RegexOptions.Singleline)
                                Dim ShopZoneModify As String = Regex.Replace(MyJobCollection.Item(x).Groups("ShopZone").Value, "<br />", " ", RegexOptions.Singleline)

                                If view3.Count = 0 Then

                                    If (Not String.IsNullOrEmpty(MyAircraftCollection.Item(i).Groups("BlockIn").Value)) And (Not String.IsNullOrEmpty(MyAircraftCollection.Item(i).Groups("Spot").Value)) Then


                                        'MsgBox("Add job - " & MyPrimKey & "','" & MyAircraftCollection.Item(i).Groups("MDS").Value & "', '" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "', '" & False & "','" & JCNModify & "','" & MyJobCollection.Item(x).Groups("WES").Value & "','" & ResultString & "','" & MyJobCollection.Item(x).Groups("Symbol").Value & "','" & MyJobCollection.Item(x).Groups("WUC").Value & "','" & ShopZoneModify & "','" & System.DateTime.Now.ToString & "','" & True & "','" & False & "')")
                                        myCommand = New SqlCommand("insert into tblJobs(PrimKey, MDS, AcftTailNum, Pacer, JCN, WCE, Narr, Symbol, WUC, ShopZone, WhenEntered, IsCurrent, Closed) values('" & MyPrimKey & "','" & MyAircraftCollection.Item(i).Groups("MDS").Value & "', '" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "', '" & False & "','" & JCNModify & "','" & MyJobCollection.Item(x).Groups("WES").Value & "','" & ResultString & "','" & MyJobCollection.Item(x).Groups("Symbol").Value & "','" & MyJobCollection.Item(x).Groups("WUC").Value & "','" & ShopZoneModify & "','" & System.DateTime.Now.ToString & "','" & True & "','" & False & "')", myConnection)
                                        myCommand.Transaction = sqltrans
                                        ra = myCommand.ExecuteNonQuery()
                                    End If

                                Else
                                    'MsgBox("update job")
                                    If MyJobCollection.Item(x).Groups("WES").Value.Count < 3 Then
                                        'MsgBox("If -" & MyAircraftCollection.Item(i).Groups("TailNum").Value & " - " & JCNModify & " - " & MyJobCollection.Item(x).Groups("WES").Value)
                                        myCommand = New SqlCommand("UPDATE tblJobs SET Pacer='" & False & "', Narr='" & ResultString & "', Symbol='" & MyJobCollection.Item(x).Groups("Symbol").Value & "', WUC='" & MyJobCollection.Item(x).Groups("WUC").Value & "', ShopZone='" & ShopZoneModify & "', IsCurrent='" & True & "', Closed='" & False & "' WHERE AcftTailNum='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "' AND JCN='" & JCNModify & "'", myConnection)
                                        myCommand.Transaction = sqltrans
                                        ra = myCommand.ExecuteNonQuery()
                                    Else
                                        'MsgBox("Else - " & MyAircraftCollection.Item(i).Groups("TailNum").Value & " - " & JCNModify & " - " & MyJobCollection.Item(x).Groups("WES").Value)
                                        myCommand = New SqlCommand("UPDATE tblJobs SET Pacer='" & False & "', Narr='" & ResultString & "', Symbol='" & MyJobCollection.Item(x).Groups("Symbol").Value & "', WUC='" & MyJobCollection.Item(x).Groups("WUC").Value & "', ShopZone='" & ShopZoneModify & "', IsCurrent='" & True & "', Closed='" & False & "' WHERE AcftTailNum='" & MyAircraftCollection.Item(i).Groups("TailNum").Value & "' AND JCN='" & JCNModify & "' AND WCE='" & MyJobCollection.Item(x).Groups("WES").Value & "'", myConnection)
                                        myCommand.Transaction = sqltrans
                                        ra = myCommand.ExecuteNonQuery()
                                    End If
                                End If

                            End If

                        Next

                    Next


                    myCommand = New SqlCommand("UPDATE tblJobs SET Closed='" & True & "', Pacer='" & False & "' FROM tblJobs j LEFT OUTER JOIN tblAcftOnStation a ON j.PrimKey=a.PrimKey WHERE j.IsCurrent='" & False & "' AND (a.IsCurrent='" & True & "' AND j.PrimKey=a.PrimKey);", myConnection)
                    myCommand.Transaction = sqltrans
                    ra = myCommand.ExecuteNonQuery()

                    'Commit Transactions
                    sqltrans.Commit()
                    'MsgBox("Transactions Commited")

                Catch ex As Exception
                    'Rollback Transactions
                    sqltrans.Rollback()
                    'MsgBox("transactions rolled back" & vbCrLf & ex.Message)
                    MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "RollBack on Aircraft A4 Load")
                Finally
                    myConnection.Close()
                End Try
            End If

            'End Regex A4 Code

            RefreshMyDataSources()

            lblA4TimeStamp.Text = "A4 Download Current as of: " & Time_Match.Groups("Time").Value
            lblA4PageLoad.Text = ""

            'Me.WebBrowserProgressBar.Value = 0
            'Start Connect to 21st Weather WWA

            Dim CheckRegexWeather As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            Dim TempLocation2 As String = ""
            For Each row In CheckRegexWeather("tblWebsiteHelpLocation").Select("ID='RegexWeather'")
                TempLocation = row("Location").ToString
            Next row
            For Each row In CheckRegexWeather("tblWebsiteHelpLocation").Select("ID='btnWeather'")
                TempLocation2 = row("Location").ToString
            Next row

            Dim WeatherBrowse As New WebBrowser
            Dim WeatherText As String = ""
            WeatherBrowse.Navigate(TempLocation)

            While WeatherBrowse.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While
            WeatherText = WeatherBrowse.DocumentText

            Dim viewWeather As DataView = Me.MxDatabaseDataSet.tblWeatherCurrent.DefaultView
            Dim viewAccountType As DataView = Me.MxDatabaseDataSet.tblUserNames.DefaultView
            viewAccountType.RowFilter = "UserName='" & My.User.Name & "' And Account='MOC'"

            If WeatherText.Contains("Rota") And viewWeather.Count = 0 And viewAccountType.Count > 0 Then
                Dim MsgboxCheck As MsgBoxResult = MsgBox("There is a new Weather Warning, Watch, or Advisory for Rota. Would you like to go to the website now?", MsgBoxStyle.YesNo)
                If MsgboxCheck = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start(TempLocation2)
                Else
                End If
            Else
            End If

            'End Connect to 21st Weather WWA


        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on A4 Load")
        Finally

            Dim RandomNumber1 As Integer
            RandomNumber1 = RandomClass.Next(StartRandomRefresh, EndRandomRefresh)
            While RandomNumber1 Mod 30000 <> 0
                RandomNumber1 = RandomClass.Next(StartRandomRefresh, EndRandomRefresh)
            End While
            Me.alarmTime = Date.Now.AddMilliseconds(RandomNumber1)

            Timer3.Start()
            Timer1.Interval = RandomNumber1
            Timer1.Start()
            Dim SetBlockToFalse As New Hashtable
            SetBlockToFalse.Add("BlockBit", "False")
            Dim SetBlocker As New MySqlBuilder(My.Settings.MxDatabaseConnectionString, SetBlockToFalse, "tblBlocker", "TheAutoPrimKey", "1", "UPDATE")
            SetBlocker.RunSQL()
        End Try

    End Sub

    Private Sub Update_Delay_Data(ByVal fieldName As String, ByVal fieldData As String, ByVal ThePrimKey As String)
        Try
            Dim myConnection As SqlConnection
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            Dim com As SqlCommand = New SqlCommand("UPDATE tblAcftOnStation SET " & fieldName & " ='" & fieldData & "' WHERE PrimKey = '" & ThePrimKey & "';", myConnection)
            myConnection.Open()

            '  Execute the command and process the result.

            Dim result As Integer = com.ExecuteNonQuery
            myConnection.Close()
        Catch ex As Exception
            MsgBox("Error on delay update")
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on Delay Update")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Connect to A4 Code

        Me.TblMessageAlertTableAdapter.Update(Me.MxDatabaseDataSet.tblMessageAlert)
        Me.TblMessageAlertTableAdapter.Fill(Me.MxDatabaseDataSet.tblMessageAlert)
        Dim CheckMessageAlert As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempMessage As String = ""
        For Each row In CheckMessageAlert("tblMessageAlert").Select("ID=1")
            TempMessage = row("YourMessage").ToString
        Next row
        If TempMessage <> "" Then
            Dim RandomClass As New Random
            Dim RandomNumber As New Integer
            Dim Rowcount As New Integer
            Dim LastRowId As New Integer
            Dim TempSnappleMessage As String = ""
            Rowcount = CheckMessageAlert("tblSnappleFacts").Rows.Count - 1
            LastRowId = CheckMessageAlert("tblSnappleFacts").Rows(Rowcount).Item("ID")

            RandomNumber = RandomClass.Next(LastRowId)
            While (RandomNumber Mod 2 = 0)
                RandomNumber = RandomClass.Next(LastRowId)
            End While

            For Each row In CheckMessageAlert("tblSnappleFacts").Select("ID=" & RandomNumber & "")
                TempSnappleMessage = row("fact").ToString
            Next row

            MsgBox(TempMessage & vbCrLf & vbCrLf & "Snapple Fact: " & TempSnappleMessage, MsgBoxStyle.Information, "Message Alert!")
        End If

        Dim myThread As New Threading.Thread(AddressOf MainThread)
        myThread.Priority = ThreadPriority.Highest
        myThread.IsBackground = True
        myThread.Start()
        lblA4TimeStamp.Text = ""
        lblA4PageLoad.Text = "A4 Website Loading..."
        lblJulianDay.Text = System.DateTime.Now.DayOfYear
        'End Connect to A4 Code
    End Sub

    Private Sub btnRefreshA4Data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshA4Data.Click
        Timer1.Stop()
        'Connect to A4 Code
        Dim myThread As New Threading.Thread(AddressOf MainThread)
        myThread.Priority = ThreadPriority.Highest
        myThread.IsBackground = True
        myThread.Start()
        lblA4TimeStamp.Text = ""
        lblA4PageLoad.Text = "A4 Website Loading..."
        'End Connect to A4 Code
    End Sub

    Private Sub ListBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedValueChanged
      

        Try
            Dim DepartView As DataView = Me.MxDatabaseDataSet.tblAcftOnStation.DefaultView
            DepartView.RowFilter = "PrimKey='" & ListBox1.SelectedValue & "' AND IsCurrent='False'"

            If DepartView.Count > 0 Then
                lblDeparted.Text = "This Aircraft has Departed on the A4 Website."
                picDeparted.Visible = True
            Else
                lblDeparted.Text = "This Aircraft is still loaded on the A4 Website."
                picDeparted.Visible = False
            End If


            Dim CheckBIETD As DataTableCollection = MxDatabaseDataSet.Tables

            Dim TheBlockIn As String = ""
            Dim TheETD As String = ""
            Dim TheHour As Integer
            Dim TheMinute As Integer
            Dim CombineHourMinute As String = ""
            For Each row In CheckBIETD("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "'")
                TheBlockIn = row("BlockInDateTime").ToString
                TheETD = row("ETDDateTime").ToString
            Next row
            If TheBlockIn <> "" And TheETD <> "" Then

                Dim TheBlockInTime As String = TheBlockIn.Substring(0, 4)
                Dim TheBlockInMin As String = TheBlockInTime.Substring(2, 2)
                Dim TheBlockInHour As String = TheBlockInTime.Substring(0, 2)
                Dim TheBlockInDay As String = TheBlockIn.Substring(TheBlockIn.IndexOf("/") + 1, 2)
                Dim TheBlockInMonth As String = TheBlockIn.Substring(TheBlockIn.IndexOf("/") + 4, 3)
                Dim TheBlockInDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(MonthToDigit(TheBlockInMonth.ToLower)), CInt(TheBlockInDay), CInt(TheBlockInHour), CInt(TheBlockInMin), 0)

                Dim TheETDTime As String = TheETD.Substring(0, 4)
                Dim TheETDMin As String = TheETDTime.Substring(2, 2)
                Dim TheETDHour As String = TheETDTime.Substring(0, 2)
                Dim TheETDDay As String = TheETD.Substring(TheETD.IndexOf("/") + 1, 2)
                Dim TheETDMonth As String = TheETD.Substring(TheETD.IndexOf("/") + 4, 3)
                Dim TheETDDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(MonthToDigit(TheETDMonth.ToLower)), CInt(TheETDDay), CInt(TheETDHour), CInt(TheETDMin), 0)

                TheHour = DateDiff(DateInterval.Minute, TheBlockInDate, TheETDDate) / 60
                TheMinute = DateDiff(DateInterval.Minute, TheBlockInDate, TheETDDate) Mod 60
                CombineHourMinute = TheHour & "+" & TheMinute
                Dim myConnection As SqlConnection
                Dim sqltrans As SqlTransaction
                myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
                myConnection.Open()
                sqltrans = myConnection.BeginTransaction
                Try
                    Dim com As SqlCommand = New SqlCommand("UPDATE tblAcftOnStation SET GroundTime='" & CombineHourMinute & "' WHERE PrimKey='" & Me.ListBox1.SelectedValue & "'", myConnection)
                    com.Transaction = sqltrans
                    Dim result As Integer = com.ExecuteNonQuery

                    sqltrans.Commit()
                    'MsgBox("commited")
                Catch ex As Exception
                    ' MsgBox("Rollback")
                    sqltrans.Rollback()
                Finally
                    myConnection.Close()
                End Try
                Me.GroundTimeTextBox.Text = CombineHourMinute

                Dim CheckTFGT As DataTableCollection = MxDatabaseDataSet.Tables
                Me.ThruflightDateTimeDateTimePicker.Checked = False
                For Each row In CheckTFGT("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND ThruflightDateTime IS NOT NULL")
                    Me.ThruflightDateTimeDateTimePicker.Checked = True
                    Me.ThruflightDateTimeDateTimePicker.Value = row("ThruflightDateTime").ToString
                Next row
            Else

                Dim CheckTFGT As DataTableCollection = MxDatabaseDataSet.Tables
                Me.ThruflightDateTimeDateTimePicker.Checked = False
                For Each row In CheckTFGT("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND ThruflightDateTime IS NOT NULL")
                    Me.ThruflightDateTimeDateTimePicker.Checked = True
                    Me.ThruflightDateTimeDateTimePicker.Value = row("ThruflightDateTime").ToString
                Next row


                Dim CheckGT As DataTableCollection = MxDatabaseDataSet.Tables
                Me.ThruflightDateTimeDateTimePicker.Checked = False
                For Each row In CheckGT("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "'")
                    Me.GroundTimeTextBox.Text = row("GroundTime").ToString
                Next row
            End If



            Dim TempSQL As String = "SELECT * FROM tblAcftOnStation"
            Dim TempConn As SqlConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            Dim da As SqlDataAdapter = New SqlDataAdapter
            da.SelectCommand = New SqlCommand(TempSQL, TempConn)
            Dim ds As DataSet = New DataSet
            da.Fill(ds, "tblAcftOnStation")

            Dim CheckDST As DataTableCollection = ds.Tables
            Dim TempDST As String = ""
            Dim TempHaz As String = ""
            Dim TempSeal As String = ""
            Dim TempPriDelay As String = ""
            Dim TempPriTime As String = ""
            Dim TempPriRemarks As String = ""
            Dim TempSecRemarks As String = ""
            Dim TempSectime As String = ""
            Dim TempSecDelay As String = ""
            Dim TempPrevIcao As String = ""
            Dim TempNextIcao As String = ""

            Me.PrevICAOTextBox.Text = TempPrevIcao
            Me.NextICAOTextBox.Text = TempNextIcao

            Me.PrimaryDelayCodeComboBox.Text = TempPriDelay
            Me.PrimaryDelayTimeTextBox.Text = TempPriTime
            Me.PrimaryDelayRemarksTextBox.Text = TempPriRemarks

            Me.SecondaryDelayCodeComboBox.Text = TempSecDelay
            Me.SecondaryDelayTimeTextBox.Text = TempSectime
            Me.SecondaryDelayRemarksTextBox.Text = TempSecRemarks

            Me.DSTDateTimeTextBox.Text = TempDST
            Me.HazCargoTextBox.Text = TempHaz
            Me.CrewSealTextBox.Text = TempSeal

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND DSTDateTime IS NOT NULL")
                TempDST = row("DSTDateTime").ToString
            Next row
            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND HazCargo IS NOT NULL")
                TempHaz = row("HazCargo").ToString
            Next row
            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND CrewSeal IS NOT NULL")
                TempSeal = row("CrewSeal").ToString
            Next row

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND PrimaryDelayCode IS NOT NULL")
                TempPriDelay = row("PrimaryDelayCode").ToString
            Next row

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND PrimaryDelayTime IS NOT NULL")
                TempPriTime = row("PrimaryDelayTime").ToString
            Next row

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND PrimaryDelayRemarks IS NOT NULL")
                TempPriRemarks = row("PrimaryDelayRemarks").ToString
            Next row


            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND SecondaryDelayCode IS NOT NULL")
                TempSecDelay = row("SecondaryDelayCode").ToString
            Next row

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND SecondaryDelayTime IS NOT NULL")
                TempSectime = row("SecondaryDelayTime").ToString
            Next row

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND SecondaryDelayRemarks IS NOT NULL")
                TempSecRemarks = row("SecondaryDelayRemarks").ToString
            Next row

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND PrevICAO IS NOT NULL")
                TempPrevIcao = row("PrevICAO").ToString
            Next row

            For Each row In CheckDST("tblAcftOnStation").Select("PrimKey='" & Me.ListBox1.SelectedValue & "' AND NextICAO IS NOT NULL")
                TempNextIcao = row("NextICAO").ToString
            Next row

            If TempPrevIcao <> "" Then
                Me.PrevICAOTextBox.Text = TempPrevIcao
            End If

            If TempNextIcao <> "" Then
                Me.NextICAOTextBox.Text = TempNextIcao
            End If

            If TempPriDelay <> "" Then
                Me.PrimaryDelayCodeComboBox.Text = TempPriDelay
            End If
            If TempPriTime <> "" Then
                Me.PrimaryDelayTimeTextBox.Text = TempPriTime
            End If
            If TempPriRemarks <> "" Then
                Me.PrimaryDelayRemarksTextBox.Text = TempPriRemarks
            End If

            If TempSecDelay <> "" Then
                Me.SecondaryDelayCodeComboBox.Text = TempSecDelay
            End If
            If TempSectime <> "" Then
                Me.SecondaryDelayTimeTextBox.Text = TempSectime
            End If
            If TempSecRemarks <> "" Then
                Me.SecondaryDelayRemarksTextBox.Text = TempSecRemarks
            End If

            If TempDST <> "" Then
                Me.DSTDateTimeTextBox.Text = TempDST
            End If
            If TempHaz <> "" Then
                Me.HazCargoTextBox.Text = TempHaz
            End If
            If TempSeal <> "" Then
                Me.CrewSealTextBox.Text = TempSeal
            End If




            da.Dispose()
            ds.Dispose()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on Aircraft Listbox Change")
        End Try
    End Sub

    Private Sub PrimaryDelayTimeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimaryDelayTimeTextBox.TextChanged
        ' Me.Update_Delay_Data("PrimaryDelayTime", Me.PrimaryDelayTimeTextBox.Text, Me.ListBox1.SelectedValue)

        If Me.PrimaryDelayTimeTextBox.Text <> "" And Not Me.PrimaryDelayTimeTextBox.Text Is DBNull.Value And Not Me.PrimaryDelayTimeTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("PrimaryDelayTime", Me.PrimaryDelayTimeTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf Me.PrimaryDelayTimeTextBox.Focused And Me.PrimaryDelayTimeTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("PrimaryDelayTime", Me.PrimaryDelayTimeTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub

    Private Sub PrimaryDelayRemarksTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimaryDelayRemarksTextBox.TextChanged
        ' Me.Update_Delay_Data("PrimaryDelayRemarks", Me.PrimaryDelayRemarksTextBox.Text, Me.ListBox1.SelectedValue)

        If Me.PrimaryDelayRemarksTextBox.Text <> "" And Not Me.PrimaryDelayRemarksTextBox.Text Is DBNull.Value And Not Me.PrimaryDelayRemarksTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("PrimaryDelayRemarks", Me.PrimaryDelayRemarksTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf Me.PrimaryDelayRemarksTextBox.Focused And Me.PrimaryDelayRemarksTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("PrimaryDelayRemarks", Me.PrimaryDelayRemarksTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub


    Private Sub SecondaryDelayTimeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondaryDelayTimeTextBox.TextChanged
        'Me.Update_Delay_Data("SecondaryDelayTime", Me.SecondaryDelayTimeTextBox.Text, Me.ListBox1.SelectedValue)

        If Me.SecondaryDelayTimeTextBox.Text <> "" And Not Me.SecondaryDelayTimeTextBox.Text Is DBNull.Value And Not Me.SecondaryDelayTimeTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("SecondaryDelayTime", Me.SecondaryDelayTimeTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf Me.SecondaryDelayTimeTextBox.Focused And Me.SecondaryDelayTimeTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("SecondaryDelayTime", Me.SecondaryDelayTimeTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub

    Private Sub SecondaryDelayRemarksTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondaryDelayRemarksTextBox.TextChanged
        ' Me.Update_Delay_Data("SecondaryDelayRemarks", Me.SecondaryDelayRemarksTextBox.Text, Me.ListBox1.SelectedValue)

        If Me.SecondaryDelayRemarksTextBox.Text <> "" And Not Me.SecondaryDelayRemarksTextBox.Text Is DBNull.Value And Not Me.SecondaryDelayRemarksTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("SecondaryDelayRemarks", Me.SecondaryDelayRemarksTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf Me.SecondaryDelayRemarksTextBox.Focused And Me.SecondaryDelayRemarksTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("SecondaryDelayRemarks", Me.SecondaryDelayRemarksTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub

    Private Sub btnDeparted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeparted.Click
        Me.TblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.tblJobs)

        If lblDeparted.Text = "This Aircraft is still loaded on the A4 Website." Then
            MsgBox("You cannot depart an Aircraft that is still loaded on the A4 Website.")
            Exit Sub
        End If

        Dim myDataTable As DataTableCollection = MxDatabaseDataSet.Tables
        Dim CountJobs As Integer

        For Each row In myDataTable("tblJobs").Select("AcftTailNum='" & AcftTailNumberLabel1.Text & "'")
            If row.Item("Closed") = True And (row.Item("CorrAction") Is DBNull.Value Or row.Item("CorrAction").ToString = "") And Not row.Item("WUC").ToString.StartsWith("0") And Not row.Item("WUC").ToString.StartsWith("11") And Not row.Item("WUC").ToString.StartsWith("12") Then
                CountJobs += 1
            End If
        Next
        If CountJobs > 0 Then
            MsgBox("You need to enter Corrective Actions for " & CountJobs & " jobs before you can depart this aircraft.")
            Exit Sub
        End If


        Dim myConnection As SqlConnection
        Dim sqltrans As SqlTransaction
        myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        myConnection.Open()
        sqltrans = myConnection.BeginTransaction
        Try
            Dim com As SqlCommand = New SqlCommand("UPDATE tblAcftOnStation SET WhenDeparted='" & System.DateTime.Now.ToString & "' WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            Dim result As Integer = com.ExecuteNonQuery

            com = New SqlCommand("INSERT INTO Archive_tblAcftOnStation SELECT * FROM tblAcftOnStation WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            com = New SqlCommand("INSERT INTO Archive_tblJobs SELECT * FROM tblJobs WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            com = New SqlCommand("INSERT INTO Archive_tblPOL SELECT * FROM tblPOL WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            com = New SqlCommand("INSERT INTO Archive_tblSOE(PrimKey, MDS, AcftTailNum, SOEDateTime, Entry, UserName, TheAutoPrimKey) SELECT PrimKey, MDS, AcftTailNum, SOEDateTime, Entry, UserName, TheAutoPrimKey  FROM tblSOE WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery


            com = New SqlCommand("INSERT INTO Archive_tblTurnover(PrimKey, MDS, AcftTailNum, TurnDateTime, Entry, UserName, TheAutoPrimKey) SELECT PrimKey, MDS, AcftTailNum, TurnDateTime, Entry, UserName, TheAutoPrimKey  FROM tblTurnover WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            com = New SqlCommand("DELETE FROM tblTurnover WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            com = New SqlCommand("DELETE FROM tblSOE WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            com = New SqlCommand("DELETE FROM tblJobs WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            com = New SqlCommand("DELETE FROM tblPOL WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery


            com = New SqlCommand("DELETE FROM tblAcftOnStation WHERE PrimKey='" & ListBox1.SelectedValue & "'", myConnection)
            com.Transaction = sqltrans
            result = com.ExecuteNonQuery

            sqltrans.Commit()
            'MsgBox("commited")
            
        Catch ex As Exception
            sqltrans.Rollback()
            'MsgBox("rollback")
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error Departing aircraft")
            'MsgBox("Error Departing Aircraft")
        Finally
            myConnection.Close()
            RefreshMyDataSources()
            Me.Refresh()

        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.ExitThread()
        Application.Exit()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim AboutForm As New AboutBox1
        AboutForm.Show()

    End Sub


    Public Function GetCurrentPrimKey()
        Return Me.ListBox1.SelectedValue
    End Function

    Public Sub RefreshMyDataSources()
        'RefreshInProgress = True

        Dim KeepThePrimKey As String = ""
        KeepThePrimKey = Me.ListBox1.SelectedValue
        Me.ThruflightDateTimeDateTimePicker.Checked = False

        Me.ListBox1.ClearSelected()

        UpdateMyDataSources()

        Me.TblTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblTurnover)
        Me.TblSOETableAdapter.Fill(Me.MxDatabaseDataSet.tblSOE)
        Me.TblJobsTableAdapter.Fill(Me.MxDatabaseDataSet.tblJobs)
        Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)
        Me.TblWeatherCurrentTableAdapter.Fill(Me.MxDatabaseDataSet.tblWeatherCurrent)

        Me.TblGeneralInfoTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralInfo)
        Me.TblGeneralTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralTurnover)
        Me.TEMPInboundTableAdapter.Fill(Me.MxDatabaseDataSet.TEMPInbound)

        Me.TblMorningSheetNotesTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetNotes)
        Me.TblTempMorningSheetPWTableAdapter.Fill(Me.MxDatabaseDataSet.tblTempMorningSheetPW)
        Me.Archive_tblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
        Me.Archive_tblPOLTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblPOL)

        Me.TblMRTTableAdapter.Fill(Me.MxDatabaseDataSet.tblMRT)
        Me.Archive_tblMRTTableAdapter.Fill(Me.MxDatabaseDataSet.Archive_tblMRT)

        Me.TblPOLTableAdapter.Fill(Me.MxDatabaseDataSet.tblPOL)
        Me.TblBlockerTableAdapter.Fill(Me.MxDatabaseDataSet.tblBlocker)

        If KeepThePrimKey <> "" Then
            Me.ListBox1.SelectedValue = KeepThePrimKey
            Me.ListBox2.SelectedValue = KeepThePrimKey
            Me.ListBox3.SelectedValue = KeepThePrimKey
        End If
        'RefreshInProgress = False

    End Sub

    Public Sub UpdateMyDataSources()

        Me.TblWeatherCurrentTableAdapter.Update(MxDatabaseDataSet.tblWeatherCurrent)
        Me.TblTurnoverTableAdapter.Update(MxDatabaseDataSet.tblTurnover)
        Me.TblSOETableAdapter.Update(MxDatabaseDataSet.tblSOE)
        Me.TblJobsTableAdapter.Update(MxDatabaseDataSet.tblJobs)
        Me.TblAcftOnStationTableAdapter.Update(MxDatabaseDataSet.tblAcftOnStation)

        Me.TblGeneralInfoTableAdapter.Update(Me.MxDatabaseDataSet.tblGeneralInfo)
        Me.TblGeneralTurnoverTableAdapter.Update(Me.MxDatabaseDataSet.tblGeneralTurnover)
        Me.TEMPInboundTableAdapter.Update(Me.MxDatabaseDataSet.TEMPInbound)

        Me.TblMorningSheetNotesTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetNotes)
        Me.TblTempMorningSheetPWTableAdapter.Update(Me.MxDatabaseDataSet.tblTempMorningSheetPW)
        Me.Archive_tblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblAcftOnStation)
        Me.TblPOLTableAdapter.Update(Me.MxDatabaseDataSet.tblPOL)
        Me.Archive_tblPOLTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblPOL)

        Me.TblMRTTableAdapter.Update(Me.MxDatabaseDataSet.tblMRT)
        Me.Archive_tblMRTTableAdapter.Update(Me.MxDatabaseDataSet.Archive_tblMRT)
        Me.TblBlockerTableAdapter.Update(Me.MxDatabaseDataSet.tblBlocker)
    End Sub

    Private Sub SOEForm_NewRecordAddedEvent() Handles SOEForm.NewRecordAddedEvent
        RefreshMyDataSources()
        Me.ListBox1.SelectedValue = SOEForm.GetPrimKey
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWeather.Click
        Try
            Dim myConnection As SqlConnection
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()

            If Me.WarningDescTextBox.Text = "" Then
                myConnection.Close()
                Exit Sub
            End If

            Dim ResultString As String = Me.WarningDescTextBox.Text
            ResultString = Regex.Replace(ResultString, "\'", " ", RegexOptions.Singleline)

            Dim com As SqlCommand = New SqlCommand("insert into tblWeatherCurrent( WarningDateTime, WarningType, EndDateTime, Remarks) values('" & Me.WeatherStartDate.Value.ToString & "','" & Me.WarningNameComboBox.Text & "','" & Me.WeatherEndTime.Value.ToString & "', '" & ResultString & "')", myConnection)
            Dim result As Integer = com.ExecuteNonQuery


            Dim CheckAircraftPrimKeyDataTable As DataTableCollection = MxDatabaseDataSet.Tables
            Dim CheckAircraftPrimKey As String = ""
            Dim CheckAircraftTail As String = ""
            Dim CheckAircraftMDS As String = ""
            Dim WeatherEntry As String = Me.WarningNameComboBox.Text & " - " & Me.WarningDescTextBox.Text & " - Until: " & Me.WeatherEndTime.Value.ToString

            For Each row In CheckAircraftPrimKeyDataTable("tblAcftOnStation").Select()
                CheckAircraftPrimKey = row("PrimKey").ToString
                CheckAircraftMDS = row("AcftType").ToString
                CheckAircraftTail = row("AcftTailNumber").ToString

                com = New SqlCommand("insert into tblSOE(PrimKey, MDS, AcftTailNum, SOEDateTime, Entry, UserName) values('" & CheckAircraftPrimKey & "','" & CheckAircraftMDS & "', '" & CheckAircraftTail & "', '" & System.DateTime.Now & "', '" & WeatherEntry & "', '" & My.User.Name & "')", myConnection)
                result = com.ExecuteNonQuery
            Next row

            myConnection.Close()
            RefreshMyDataSources()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error adding weather")
            MsgBox("Error adding Weather")

        End Try
    End Sub



    Private Sub TblWeatherCurrentDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblWeatherCurrentDataGridView.UserDeletedRow
        Me.TblWeatherCurrentTableAdapter.Update(MxDatabaseDataSet.tblWeatherCurrent)
    End Sub

    Private Sub TblSOEDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblSOEDataGridView.CellEndEdit

        Me.TblSOETableAdapter.Update(MxDatabaseDataSet.tblSOE)
    End Sub



    Private Sub TblSOEDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblSOEDataGridView.UserDeletedRow
        Me.TblSOETableAdapter.Update(MxDatabaseDataSet.tblSOE)
    End Sub



    Private Sub SOEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOEToolStripMenuItem.Click

        If Not IsNothing(SOEForm) Then
            If Not SOEForm.IsDisposed() Then
                SOEForm.BringToFront()
                SOEForm.SetPrimKey(Me.ListBox1.SelectedValue, Me.AcftTailNumberLabel1.Text, Me.AcftTypeLabel1.Text)
                SOEForm.Show()
            Else
                SOEForm = New AddSOEForm()
                SOEForm.SetPrimKey(Me.ListBox1.SelectedValue, Me.AcftTailNumberLabel1.Text, Me.AcftTypeLabel1.Text)
                SOEForm.Show()
            End If
        Else
            SOEForm = New AddSOEForm()
            SOEForm.SetPrimKey(Me.ListBox1.SelectedValue, Me.AcftTailNumberLabel1.Text, Me.AcftTypeLabel1.Text)
            SOEForm.Show()
        End If


    End Sub

    Private Sub TurnoverToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoverToolStripMenuItem2.Click
        If Not IsNothing(TurnoverForm) Then
            If Not TurnoverForm.IsDisposed() Then
                TurnoverForm.BringToFront()
                TurnoverForm.SetPrimKey(Me.ListBox1.SelectedValue, Me.AcftTailNumberLabel1.Text, Me.AcftTypeLabel1.Text)
                TurnoverForm.Show()
            Else
                TurnoverForm = New AddTurnoverForm()
                TurnoverForm.SetPrimKey(Me.ListBox1.SelectedValue, Me.AcftTailNumberLabel1.Text, Me.AcftTypeLabel1.Text)
                TurnoverForm.Show()
            End If
        Else
            TurnoverForm = New AddTurnoverForm()
            TurnoverForm.SetPrimKey(Me.ListBox1.SelectedValue, Me.AcftTailNumberLabel1.Text, Me.AcftTypeLabel1.Text)
            TurnoverForm.Show()
        End If
    End Sub

    Private Sub TurnoverForm_NewRecordAddedEvent() Handles TurnoverForm.NewRecordAddedEvent
        RefreshMyDataSources()
        Me.ListBox1.SelectedValue = TurnoverForm.GetPrimKey
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub TblTurnoverDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTurnoverDataGridView.CellEndEdit
        Me.TblTurnoverTableAdapter.Update(MxDatabaseDataSet.tblTurnover)
    End Sub

    Private Sub TblTurnoverDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblTurnoverDataGridView.UserDeletedRow
        Me.TblTurnoverTableAdapter.Update(MxDatabaseDataSet.tblTurnover)
    End Sub

    Private Sub GeneralTurnoverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralTurnoverToolStripMenuItem.Click
        Dim MyGeneralTurnover As New GeneralTurnover
        MyGeneralTurnover.Show()
    End Sub



    Private Sub btnRemarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemarks.Click
        Dim CheckRemarksDataTable As DataTableCollection = MxDatabaseDataSet.Tables

        For Each row In CheckRemarksDataTable("tblAcftOnStation").Select("PrimKey = '" & Me.ListBox1.SelectedValue & "'")
            MsgBox(row("Remarks").ToString)
        Next row
    End Sub

    Private Sub EquipStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipStatusToolStripMenuItem.Click
        Dim NewEquipStatusForm As EquipStatus = New EquipStatus
        NewEquipStatusForm.Show()
    End Sub

    Private Sub EditArchivedAircraftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditArchivedAircraftToolStripMenuItem.Click
        Dim NewArchiveAircraftEdit As New ArchivedAircraftEdit
        NewArchiveAircraftEdit.Show()
    End Sub




    Private Sub NoFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoFilterToolStripMenuItem.Click
        Try
            RefreshMyDataSources()
            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.G1Turnover1.FileName = TempLocation & "G1Turnover.rpt"

            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\G1Turnover.rpt"
            OpenReportViewer.G1Turnover1.Refresh()
            OpenReportViewer.G1Turnover1.VerifyDatabase()

            OpenReportViewer.G1Turnover1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.G1Turnover1

            OpenReportViewer.Show()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try

    End Sub

    Private Sub WOGeneralWUCsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WOGeneralWUCsToolStripMenuItem.Click

        Dim myThread3 As New Threading.Thread(AddressOf ProSupWOGENThread)
        myThread3.Priority = ThreadPriority.Lowest
        myThread3.IsBackground = True
        myThread3.Start()
    End Sub

    Private Sub ProSupWOGENThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate5(AddressOf OpenProSupWOGEN))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception on Pro Sup Report Open WOGEN")
        End Try
    End Sub

    Private Sub OpenProSupWOGEN()
        Try
            RefreshMyDataSources()


            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.g1TurnoverWOGENWUC1.FileName = TempLocation & "G1TurnoverWOGENWUC.rpt"
            'MsgBox("rassdk://" & My.Application.Info.DirectoryPath & "\Reports\G1TurnoverWOGENWUC.rpt")


            OpenReportViewer.CrystalReportViewer1.RefreshReport()


            OpenReportViewer.g1TurnoverWOGENWUC1.Refresh()
            OpenReportViewer.g1TurnoverWOGENWUC1.VerifyDatabase()

            OpenReportViewer.g1TurnoverWOGENWUC1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.g1TurnoverWOGENWUC1

            OpenReportViewer.Show()

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub NoJobsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoJobsToolStripMenuItem.Click
        Try
            RefreshMyDataSources()

            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.g1TurnoverPacerOnly1.FileName = TempLocation & "G1TurnoverPacerOnly.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\G1TurnoverPacerOnly.rpt"
            OpenReportViewer.g1TurnoverPacerOnly1.Refresh()
            OpenReportViewer.g1TurnoverPacerOnly1.VerifyDatabase()

            OpenReportViewer.g1TurnoverPacerOnly1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.g1TurnoverPacerOnly1

            OpenReportViewer.Show()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try

    End Sub

    Private Sub InbdSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InbdSheetToolStripMenuItem.Click
        Try
            RefreshMyDataSources()

            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.inbdSheet1.FileName = TempLocation & "InbdSheet.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\InbdSheet.rpt"
            OpenReportViewer.inbdSheet1.Refresh()
            OpenReportViewer.inbdSheet1.VerifyDatabase()

            OpenReportViewer.inbdSheet1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.inbdSheet1

            OpenReportViewer.Show()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")

        End Try
    End Sub


    Private Sub MorningSheetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MorningSheetToolStripMenuItem1.Click
        Dim myThread2 As New Threading.Thread(AddressOf MSOpenThread)
        myThread2.Priority = ThreadPriority.Lowest
        myThread2.IsBackground = True
        myThread2.Start()
    End Sub

    Private Sub MSOpenThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate4(AddressOf OpenMorningSheet))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception on Morning Sheet Open")
        End Try
    End Sub

    Private Sub OpenMorningSheet()
        Try
            'MorningSheet Open Section


            RefreshMyDataSources()


            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.MorningSheet1.FileName = TempLocation & "MorningSheet.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\MorningSheet.rpt"
            OpenReportViewer.MorningSheet1.Refresh()
            OpenReportViewer.MorningSheet1.VerifyDatabase()

            OpenReportViewer.MorningSheet1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.MorningSheet1

            OpenReportViewer.Show()



        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub MorningSheetNotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MorningSheetNotesToolStripMenuItem.Click
        Dim EditMorningSheetform As New MorningSheetEdit

        EditMorningSheetform.Show()
    End Sub



    Private Sub AircraftReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AircraftReportsToolStripMenuItem.Click
        Dim OpenACSelector As New AircraftReportSelector
        OpenACSelector.Show()

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

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click

        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
        Me.TblWebsiteHelpLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)

        Dim CheckHelpUpdate As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempHelp As String = ""
        For Each row In CheckHelpUpdate("tblWebsiteHelpLocation").Select("ID='Help'")
            TempHelp = row("Location").ToString
        Next row

        System.Diagnostics.Process.Start(TempHelp)
    End Sub

    Private Sub AdminSectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminSectionToolStripMenuItem.Click


        If My.User.Name = My.Settings.AdminUser1 Or My.User.Name = My.Settings.AdminUser2 Then
            Dim NewAdminForm As AdminSection = New AdminSection
            NewAdminForm.Show()
        Else
            MsgBox("Sorry, you do not have admin rights!")
            Exit Sub
        End If

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.WebBrowserProgressBar.Value = 0
        Me.WebBrowser1.Tag = "Loaded"
    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged

        Me.WebBrowserProgressBar.Maximum = Convert.ToInt32(e.MaximumProgress)
        Me.WebBrowserProgressBar.Value = Convert.ToInt32(e.CurrentProgress)

    End Sub


    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Dim myThread1 As New Threading.Thread(AddressOf MSThread)
        myThread1.Priority = ThreadPriority.Lowest
        myThread1.IsBackground = True
        myThread1.Start()


    End Sub

    Private Sub MSThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate2(AddressOf MSExport))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception on Morning Sheet Export")
        End Try
    End Sub

    Private Sub MSExport()
        Try
            RefreshMyDataSources()

            Dim CheckWebsiteUpdate As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempMSLocation As String = ""
            For Each row In CheckWebsiteUpdate("tblWebsiteHelpLocation").Select("ID='MorningSheet'")
                TempMSLocation = row("Location").ToString
            Next row

            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.MorningSheet1.FileName = TempLocation & "MorningSheet.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            'OpenReportViewer.G1Turnover1.FileName = "\\rta-fs-02\725ams\Logistics\MxDatabase\Reports\MorningSheet.rpt"
            OpenReportViewer.MorningSheet1.Refresh()
            OpenReportViewer.MorningSheet1.VerifyDatabase()

            OpenReportViewer.MorningSheet1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.MorningSheet1

            OpenReportViewer.MorningSheet1.ExportToDisk(ExportFormatType.PortableDocFormat, TempMSLocation)

            ' Code for MICAP refresh
            Me.WebBrowser2.Refresh()

        Catch ex As Exception
            Dim NewErrorLog As ErrorLog = New ErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error Exporting Morning Sheet on Timer2")
            NewErrorLog.SubmitError()

            'MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error Exporting Morning Sheet on Timer2")
            'MsgBox("Crash - " & ex.Message)
        End Try
    End Sub

    Private Sub PrimaryDelayCodeComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrimaryDelayCodeComboBox.TextChanged
        'Me.Update_Delay_Data("PrimaryDelayCode", Me.PrimaryDelayCodeComboBox.Text, Me.ListBox1.SelectedValue)

        If Me.PrimaryDelayCodeComboBox.Text <> "" And Not Me.PrimaryDelayCodeComboBox.Text Is DBNull.Value And Not Me.PrimaryDelayCodeComboBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("PrimaryDelayCode", Me.PrimaryDelayCodeComboBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf Me.PrimaryDelayCodeComboBox.Focused And Me.PrimaryDelayCodeComboBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("PrimaryDelayCode", Me.PrimaryDelayCodeComboBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub

    Private Sub SecondaryDelayCodeComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SecondaryDelayCodeComboBox.TextChanged
        'Me.Update_Delay_Data("SecondaryDelayCode", Me.SecondaryDelayCodeComboBox.Text, Me.ListBox1.SelectedValue)


        If Me.SecondaryDelayCodeComboBox.Text <> "" And Not Me.SecondaryDelayCodeComboBox.Text Is DBNull.Value And Not Me.SecondaryDelayCodeComboBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("SecondaryDelayCode", Me.SecondaryDelayCodeComboBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf Me.SecondaryDelayCodeComboBox.Focused And Me.SecondaryDelayCodeComboBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("SecondaryDelayCode", Me.SecondaryDelayCodeComboBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'http://ows.public.sembach.af.mil/index.cfm?section=WWA
        Dim CheckHelpUpdate As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempHelp As String = ""
        For Each row In CheckHelpUpdate("tblWebsiteHelpLocation").Select("ID='btnWeather'")
            TempHelp = row("Location").ToString
        Next row

        System.Diagnostics.Process.Start(TempHelp)
    End Sub



    Private Sub TblJobsDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblJobsDataGridView.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim JCNObj As Object = TblJobsDataGridView.Rows(e.RowIndex).Cells(2).Value
        Dim WCEObj As Object = TblJobsDataGridView.Rows(e.RowIndex).Cells(3).Value
        Dim NewEditJobs As JobEdit = New JobEdit
        Dim TempTail As String = AcftTailNumberLabel1.Text
        Dim TempJCN As String = Convert.ToString(JCNObj)
        Dim TempWCE As String = Convert.ToString(WCEObj)
        'MsgBox(TempTail & " _ " & TempJCN & " _ " & TempWCE)
        If TempWCE = "" Or TempWCE = " " Or Regex.IsMatch(TempWCE, "\s+") Then
            NewEditJobs.TblJobsBindingSource.Filter = "AcftTailNum='" & TempTail & "' AND JCN='" & TempJCN & "' AND (WCE='" & TempWCE & "' OR WCE IS NULL)"
        Else
            NewEditJobs.TblJobsBindingSource.Filter = "AcftTailNum='" & TempTail & "' AND JCN='" & TempJCN & "' AND WCE='" & TempWCE & "'"
        End If

        NewEditJobs.Show()

    End Sub


    Private Sub TabPage4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage4.DoubleClick
        Dim NewA4Browser As A4Browse = New A4Browse
        A4Browse.Show()
    End Sub

    Private Sub A4PageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4PageToolStripMenuItem.Click
        Dim NewA4Browser As A4Browse = New A4Browse
        A4Browse.Show()
    End Sub


    Private Sub cxtAddSOE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cxtAddSOE.Click
        SOEToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub AddTurnoverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTurnoverToolStripMenuItem.Click
        TurnoverToolStripMenuItem2_Click(sender, e)
    End Sub

    Private Sub GeneralTurnoverToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralTurnoverToolStripMenuItem1.Click
        GeneralTurnoverToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub EquipStatusToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipStatusToolStripMenuItem1.Click
        EquipStatusToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub MorningSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MorningSheetToolStripMenuItem.Click
        MorningSheetNotesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub cxtDepartAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cxtDepartAC.Click
        Me.TabControl1.SelectedTab = TabPage5
        btnDeparted_Click(sender, e)
    End Sub

    Private Sub WOTurnoverEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WOTurnoverEntriesToolStripMenuItem.Click
        Dim myThread4 As New Threading.Thread(AddressOf OpenProSupWOTurnoverThread)
        myThread4.Priority = ThreadPriority.Lowest
        myThread4.IsBackground = True
        myThread4.Start()
    End Sub

    Private Sub OpenProSupWOTurnoverThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate6(AddressOf OpenProSupWOTurnover))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception on Pro Sup WOTurnover Open")
        End Try
    End Sub

    Private Sub OpenProSupWOTurnover()
        Try
            RefreshMyDataSources()


            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.g1NoTurnoverWOGENWUC1.FileName = TempLocation & "G1NoTurnoverWOGENWUC.rpt"
            'MsgBox("rassdk://" & My.Application.Info.DirectoryPath & "\Reports\G1TurnoverWOGENWUC.rpt")


            OpenReportViewer.CrystalReportViewer1.RefreshReport()


            OpenReportViewer.g1NoTurnoverWOGENWUC1.Refresh()
            OpenReportViewer.g1NoTurnoverWOGENWUC1.VerifyDatabase()

            OpenReportViewer.g1NoTurnoverWOGENWUC1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.g1NoTurnoverWOGENWUC1

            OpenReportViewer.Show()

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub ExpeditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpeditorToolStripMenuItem.Click
        Dim myThread5 As New Threading.Thread(AddressOf OpenExpediterReportThread)
        myThread5.Priority = ThreadPriority.Lowest
        myThread5.IsBackground = True
        myThread5.Start()
    End Sub

    Private Sub OpenExpediterReportThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate7(AddressOf OpenExpediterReport))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception on Expediter Report Open")
        End Try
    End Sub

    Private Sub OpenExpediterReport()
        Try
            RefreshMyDataSources()


            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.expeditor1.FileName = TempLocation & "Expeditor.rpt"
            'MsgBox("rassdk://" & My.Application.Info.DirectoryPath & "\Reports\G1TurnoverWOGENWUC.rpt")


            OpenReportViewer.CrystalReportViewer1.RefreshReport()


            OpenReportViewer.expeditor1.Refresh()
            OpenReportViewer.expeditor1.VerifyDatabase()

            OpenReportViewer.expeditor1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.expeditor1

            OpenReportViewer.Show()

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub InbdSheetBlankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InbdSheetBlankToolStripMenuItem.Click
        Dim myThread6 As New Threading.Thread(AddressOf OpenBlankInbdSheetThread)
        myThread6.Priority = ThreadPriority.Lowest
        myThread6.IsBackground = True
        myThread6.Start()
    End Sub

    Private Sub OpenBlankInbdSheetThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate8(AddressOf OpenBlankInbdSheet))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception on Blank Inbd Sheet Report Open")
        End Try
    End Sub

    Private Sub OpenBlankInbdSheet()
        Try
            RefreshMyDataSources()


            Dim OpenReportViewer As New TheReportViewer

            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.expeditorBlank21.FileName = TempLocation & "ExpeditorBlank2.rpt"
            'MsgBox("rassdk://" & My.Application.Info.DirectoryPath & "\Reports\G1TurnoverWOGENWUC.rpt")


            OpenReportViewer.CrystalReportViewer1.RefreshReport()


            OpenReportViewer.expeditorBlank21.Refresh()
            OpenReportViewer.expeditorBlank21.VerifyDatabase()

            OpenReportViewer.expeditorBlank21.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.expeditorBlank21

            OpenReportViewer.Show()

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub


    Private Sub ThruflightDateTimeDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThruflightDateTimeDateTimePicker.ValueChanged
        If Me.ThruflightDateTimeDateTimePicker.Checked = True Then
            Dim myConnection As SqlConnection
            Dim sqltrans As SqlTransaction
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()
            sqltrans = myConnection.BeginTransaction
            Try
                Dim com As SqlCommand = New SqlCommand("UPDATE tblAcftOnStation SET ThruflightDatetime='" & Me.ThruflightDateTimeDateTimePicker.Value & "' WHERE PrimKey='" & Me.ListBox1.SelectedValue & "'", myConnection)
                com.Transaction = sqltrans
                Dim result As Integer = com.ExecuteNonQuery

                sqltrans.Commit()
                'MsgBox(Me.ThruflightDateTimeDateTimePicker.Value & "- Commited -" & result)
            Catch ex As Exception
                'MsgBox("RollBack")
                sqltrans.Rollback()
            Finally
                myConnection.Close()
                Me.TblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.tblAcftOnStation)
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).BeginEdit()
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).Item("ThruflightDateTime") = Me.ThruflightDateTimeDateTimePicker.Value
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).EndEdit()
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).AcceptChanges()
            End Try
        Else
            Dim myConnection As SqlConnection
            Dim sqltrans As SqlTransaction
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()
            sqltrans = myConnection.BeginTransaction
            Try
                Dim com As SqlCommand = New SqlCommand("UPDATE tblAcftOnStation SET ThruflightDatetime = NULL WHERE PrimKey='" & Me.ListBox1.SelectedValue & "'", myConnection)
                com.Transaction = sqltrans
                Dim result As Integer = com.ExecuteNonQuery

                sqltrans.Commit()
                'MsgBox(Me.ThruflightDateTimeDateTimePicker.Value & "- Commited -" & result)
            Catch ex As Exception
                'MsgBox("RollBack")
                sqltrans.Rollback()
            Finally
                myConnection.Close()
                Me.TblAcftOnStationTableAdapter.Update(Me.MxDatabaseDataSet.tblAcftOnStation)
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).BeginEdit()
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).Item("ThruflightDateTime") = DBNull.Value
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).EndEdit()
                Me.MxDatabaseDataSet.tblAcftOnStation.FindByPrimKey(Me.ListBox1.SelectedValue).AcceptChanges()
            End Try
        End If

    End Sub


    Private Sub MRTTrackingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRTTrackingToolStripMenuItem.Click
        Dim NewMRTMain As MRTMain = New MRTMain
        NewMRTMain.Show()
    End Sub

    Private Sub btnAddFuel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFuel.Click
        Try
            Dim TempDefuel As Boolean = False
            If Me.DefuelCheckBox.Checked = True Then
                TempDefuel = True
            Else
                TempDefuel = False
            End If
            Dim ra As Integer
            Dim myConnection As SqlConnection
            Dim myCommand As SqlCommand
            Dim sqltrans As SqlTransaction
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()
            'Begin Transaction
            sqltrans = myConnection.BeginTransaction
            Try
                myCommand = New SqlCommand("insert into tblPOL(PrimKey, AcftType, AcftTailNumber, FuelDate, FuelStart, FuelStop, Defuel, ReqTime, AlertTime, ShowTime, StartTime, StopTime) values('" & Me.ListBox1.SelectedValue & "','" & Me.AcftTypeLabel1.Text & "','" & Me.AcftTailNumberLabel1.Text & "','" & Me.FuelDateDateTimePicker.Text & "','" & Me.FuelStartTextBox.Text & "','" & Me.FuelStopTextBox.Text & "','" & TempDefuel & "','" & Me.ReqTimeTextBox.Text & "','" & Me.AlertTimeTextBox.Text & "','" & Me.ShowTimeTextBox.Text & "','" & Me.StartTimeTextBox.Text & "','" & Me.StopTimeTextBox.Text & "')", myConnection)
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
                RefreshMyDataSources()
            End Try
        Catch ex As Exception
            Dim NewErrorLog As New ErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on Fuel Add")
            NewErrorLog.SubmitError()
        End Try
    End Sub


    Private Sub TblPOLDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPOLDataGridView.CellEndEdit
        Me.TblPOLTableAdapter.Update(Me.MxDatabaseDataSet.tblPOL)
    End Sub

    Private Sub TblPOLDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblPOLDataGridView.UserDeletedRow
        Me.TblPOLTableAdapter.Update(Me.MxDatabaseDataSet.tblPOL)
    End Sub




    Private Sub CurrentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentToolStripMenuItem.Click
        Try

            RefreshMyDataSources()
            Dim OpenReportViewer As New TheReportViewer
            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)

            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.fuelCurrent1.FileName = TempLocation & "FuelCurrent.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            OpenReportViewer.fuelCurrent1.Refresh()
            OpenReportViewer.fuelCurrent1.VerifyDatabase()

            OpenReportViewer.fuelCurrent1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.fuelCurrent1

            OpenReportViewer.Show()


        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub Last30DaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last30DaysToolStripMenuItem.Click
        Try

            RefreshMyDataSources()
            Dim OpenReportViewer As New TheReportViewer
            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.fuelLast301.FileName = TempLocation & "FuelLast30.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            OpenReportViewer.fuelLast301.Refresh()
            OpenReportViewer.fuelLast301.VerifyDatabase()

            OpenReportViewer.fuelLast301.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.fuelLast301

            OpenReportViewer.Show()


        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        Try

            RefreshMyDataSources()
            Dim OpenReportViewer As New TheReportViewer
            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.fuelAll1.FileName = TempLocation & "FuelAll.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            OpenReportViewer.fuelAll1.Refresh()
            OpenReportViewer.fuelAll1.VerifyDatabase()

            OpenReportViewer.fuelAll1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.fuelAll1

            OpenReportViewer.Show()


        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub


    Private Sub StatusLabel1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusLabel1.TextChanged
        If StatusLabel1.Text.StartsWith("F") Then
            StatusLabel1.ForeColor = Color.Green
        ElseIf StatusLabel1.Text.StartsWith("P") Then
            StatusLabel1.ForeColor = Color.DarkKhaki
        ElseIf StatusLabel1.Text.StartsWith("N") Then
            StatusLabel1.ForeColor = Color.Red
        Else
            StatusLabel1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CurrentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentToolStripMenuItem1.Click
        Try

            RefreshMyDataSources()
            Dim OpenReportViewer As New TheReportViewer
            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.mrtCurrent1.FileName = TempLocation & "MRTCurrent.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            OpenReportViewer.mrtCurrent1.Refresh()
            OpenReportViewer.mrtCurrent1.VerifyDatabase()

            OpenReportViewer.mrtCurrent1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.mrtCurrent1

            OpenReportViewer.Show()


        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub Last30DaysToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last30DaysToolStripMenuItem1.Click
        Try

            RefreshMyDataSources()
            Dim OpenReportViewer As New TheReportViewer
            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.mrtLast301.FileName = TempLocation & "MRTLast30.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            OpenReportViewer.mrtLast301.Refresh()
            OpenReportViewer.mrtLast301.VerifyDatabase()

            OpenReportViewer.mrtLast301.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.mrtLast301

            OpenReportViewer.Show()


        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub AllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem1.Click
        Try

            RefreshMyDataSources()
            Dim OpenReportViewer As New TheReportViewer
            Me.TblMorningSheetLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Me.TblMorningSheetLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetLocation)
            Dim CheckMorningSheetLocation As DataTableCollection = MxDatabaseDataSet.Tables
            Dim TempLocation As String = ""
            For Each row In CheckMorningSheetLocation("tblMorningSheetLocation").Select("ID=1")
                TempLocation = row("Location").ToString
            Next row

            OpenReportViewer.mrtAll1.FileName = TempLocation & "MRTAll.rpt"
            OpenReportViewer.CrystalReportViewer1.RefreshReport()
            OpenReportViewer.mrtAll1.Refresh()
            OpenReportViewer.mrtAll1.VerifyDatabase()

            OpenReportViewer.mrtAll1.SetDataSource(MxDatabaseDataSet)
            OpenReportViewer.CrystalReportViewer1.ReportSource = OpenReportViewer.mrtAll1

            OpenReportViewer.Show()


        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error opening report")
            MsgBox("Error opening report")
        End Try
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim OpenSOEJOBSearch As New SOEJCNSearch
        OpenSOEJOBSearch.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub BPODateTimeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPODateTimeTextBox.TextChanged
        ' Begin Calculate Preflit overdue time
        'BPODateTimeTextBox.BackColor = Color.Transparent
        If BPODateTimeTextBox.Text.Count > 0 Then

            Dim CurrDate As Date = System.DateTime.Now
            Dim PrefltTime As String = BPODateTimeTextBox.Text.Substring(0, 4)
            Dim PrefltMin As String = PrefltTime.Substring(2, 2)
            Dim PrefltHour As String = PrefltTime.Substring(0, 2)
            Dim PrefltDay As String = BPODateTimeTextBox.Text.Substring(BPODateTimeTextBox.Text.IndexOf("/") + 1, 2)
            Dim PrefltMonth As String = BPODateTimeTextBox.Text.Substring(BPODateTimeTextBox.Text.IndexOf("/") + 4, 3)
            Dim PrefltDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(MonthToDigit(PrefltMonth.ToLower)), CInt(PrefltDay), CInt(PrefltHour), CInt(PrefltMin), 0)
            'MsgBox(DateDiff(DateInterval.Hour, PrefltDate, CurrDate))
            If DateDiff(DateInterval.Hour, PrefltDate, CurrDate) >= 72 Then
                lblExpired.ForeColor = Color.Red
                lblExpired.Visible = True
                '   MsgBox("1")
            ElseIf DateDiff(DateInterval.Hour, PrefltDate, CurrDate) >= 60 Then
                lblExpired.ForeColor = Color.Orange
                lblExpired.Visible = True
                '  MsgBox("2")
            Else
                lblExpired.ForeColor = Color.Black
                lblExpired.Visible = False
            End If
        Else
            lblExpired.ForeColor = Color.Black
            lblExpired.Visible = False
        End If
        ' End Calculate Preflt overdue time
    End Sub



    Private Sub DSTDateTimeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DSTDateTimeTextBox.TextChanged
        If DSTDateTimeTextBox.Text <> "" And Not DSTDateTimeTextBox.Text Is DBNull.Value And Not DSTDateTimeTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("DSTDateTime", Me.DSTDateTimeTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf DSTDateTimeTextBox.Focused And (Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value) Then
        ElseIf Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value Then
        ElseIf DSTDateTimeTextBox.Focused And DSTDateTimeTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("DSTDateTime", Me.DSTDateTimeTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If


    End Sub

    Private Sub HazCargoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HazCargoTextBox.TextChanged
        If HazCargoTextBox.Text <> "" And Not HazCargoTextBox.Text Is DBNull.Value And Not HazCargoTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("HazCargo", Me.HazCargoTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf HazCargoTextBox.Focused And (Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value) Then
        ElseIf Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value Then
        ElseIf HazCargoTextBox.Focused And HazCargoTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("HazCargo", Me.HazCargoTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If

    End Sub

    Private Sub CrewSealTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrewSealTextBox.TextChanged
        If CrewSealTextBox.Text <> "" And Not CrewSealTextBox.Text Is DBNull.Value And Not CrewSealTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("CrewSeal", Me.CrewSealTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf CrewSealTextBox.Focused And (Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value) Then
        ElseIf Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value Then
        ElseIf CrewSealTextBox.Focused And CrewSealTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("CrewSeal", Me.CrewSealTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub



    Private Sub Label12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.DoubleClick

    End Sub

    Private Sub GroundTimeTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroundTimeTextBox.KeyUp
        If e.Control = True And e.Shift = True And e.Alt = True And e.KeyCode = Keys.P Then
            Dim myThread1 As New Threading.Thread(AddressOf PCThread)
            myThread1.Priority = ThreadPriority.Highest
            myThread1.IsBackground = False
            myThread1.Start()
        End If
    End Sub


    Private Sub PCThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate3(AddressOf PlayPC))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception on PC Play Export")
        End Try
    End Sub

    Private Sub PlayPC()
        Dim NewGame As frmGame = New frmGame
        NewGame.Show()
    End Sub


    Private Sub PrimaryDelayCodeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimaryDelayCodeComboBox.SelectedIndexChanged

    End Sub

    Private Sub SecondaryDelayCodeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondaryDelayCodeComboBox.SelectedIndexChanged

    End Sub

    Private Sub PrevICAOTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevICAOTextBox.TextChanged
        If PrevICAOTextBox.Text <> "" And Not PrevICAOTextBox.Text Is DBNull.Value And Not PrevICAOTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("PrevICAO", Me.PrevICAOTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf PrevICAOTextBox.Focused And (Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value) Then
        ElseIf Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value Then
        ElseIf PrevICAOTextBox.Focused And PrevICAOTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("PrevICAO", Me.PrevICAOTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub

    Private Sub NextICAOTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextICAOTextBox.TextChanged
        If NextICAOTextBox.Text <> "" And Not NextICAOTextBox.Text Is DBNull.Value And Not NextICAOTextBox.Text Is Nothing Then
            Dim AHash As New Hashtable
            AHash.Add("NextICAO", Me.NextICAOTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        ElseIf NextICAOTextBox.Focused And (Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value) Then
        ElseIf Me.ListBox1.SelectedValue Is Nothing Or Me.ListBox1.SelectedValue = "" Or Me.ListBox1.SelectedValue Is DBNull.Value Then

        ElseIf NextICAOTextBox.Focused And NextICAOTextBox.Text = "" Then
            Dim AHash As New Hashtable
            AHash.Add("NextICAO", Me.NextICAOTextBox.Text)
            Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.ListBox1.SelectedValue, "UPDATE")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Else

        End If
    End Sub



    Private Sub GUIG081ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUIG081ToolStripMenuItem.Click
        Dim CheckHelpUpdate As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempHelp As String = ""
        For Each row In CheckHelpUpdate("tblWebsiteHelpLocation").Select("ID='GO'")
            TempHelp = row("Location").ToString
        Next row

        System.Diagnostics.Process.Start(TempHelp)
    End Sub




    Private Function UpdateCrewShow(ByVal ETDTime As String, ByVal TempMDS As String)
        If ETDTime.Length < 1 Then
            Return ""
        End If

        Dim TempTime As String = ""
        Dim TempHour As String = ""
        Dim TempMinute As String = ""
        Dim TempDate As String = ""
        Dim TempDay As String = ""
        Dim TempMonth As String = ""
        Dim TempNumMonth As String = ""
        Dim MyRow As DictionaryEntry
        Dim TheCrewShow As Date
        Dim TempMonthHash As Hashtable = New Hashtable
        TempMonthHash.Add("JAN", "1")
        TempMonthHash.Add("FEB", "2")
        TempMonthHash.Add("MAR", "3")
        TempMonthHash.Add("APR", "4")
        TempMonthHash.Add("MAY", "5")
        TempMonthHash.Add("JUN", "6")
        TempMonthHash.Add("JUL", "7")
        TempMonthHash.Add("AUG", "8")
        TempMonthHash.Add("SEP", "9")
        TempMonthHash.Add("OCT", "10")
        TempMonthHash.Add("NOV", "11")
        TempMonthHash.Add("DEC", "12")

        TempTime = ETDTime.Substring(0, 4)
        TempHour = TempTime.Substring(0, 2)
        TempMinute = TempTime.Substring(2, 2)

        TempDate = ETDTime.Substring(5, ETDTime.Length - 5)
        TempDay = TempDate.Substring(0, 2)
        TempMonth = TempDate.Substring(2, TempDate.Length - 2)
        For Each MyRow In TempMonthHash
            If MyRow.Key = TempMonth.Trim Then
                TempNumMonth = MyRow.Value
                Exit For
            End If
        Next

        Dim ETDDate As Date = New Date(CInt(System.DateTime.Now.Year), CInt(TempNumMonth), CInt(TempDay), CInt(TempHour), CInt(TempMinute), CInt(0))

        If TempMDS.Contains("C017") Then
            TheCrewShow = DateAdd(DateInterval.Hour, -2, ETDDate)
            TheCrewShow = DateAdd(DateInterval.Minute, -45, TheCrewShow)
            Return TheCrewShow.ToString("HHmm/dd MMM")
        Else
            TheCrewShow = DateAdd(DateInterval.Hour, -3, ETDDate)
            TheCrewShow = DateAdd(DateInterval.Minute, -15, TheCrewShow)
            Return TheCrewShow.ToString("HHmm/dd MMM")
        End If



    End Function


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Try
            'Dim remainingTime As TimeSpan = Me.alarmTime.Subtract(Date.Now)
            Dim remainingSec As Integer = DateDiff(DateInterval.Second, Date.Now, Me.alarmTime)
            Dim TheMin As Integer = remainingSec / 60
            Dim TheSec As Integer = remainingSec Mod 60
            'lblNextRefresh.Text = String.Format("", remainingTime.Minutes, remainingTime.Seconds)
            'Dim TheMilliSecs As Integer = Math.Abs((remainingMin * 60 * 1000) + (remainingSec * 1000))
            If TheSec >= 30 Then
                TheMin -= 1
            End If
            lblNextRefresh.Text = Math.Abs(TheMin) & " Minutes and " & Math.Abs(TheSec) & "Seconds"
        Catch ex As Exception
            lblNextRefresh.Text = ""
        End Try

    End Sub


    Private Sub AddAircraftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAircraftToolStripMenuItem.Click
        If Not IsNothing(TheAcftAdd) Then
            If Not TheAcftAdd.IsDisposed() Then
                TheAcftAdd.BringToFront()
                TheAcftAdd.Show()
            Else
                TheAcftAdd = New acftAdd
                TheAcftAdd.Show()
            End If
        Else
            TheAcftAdd = New acftAdd
            TheAcftAdd.Show()
        End If
    End Sub

    Private Sub AddJobToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddJobToolStripMenuItem.Click
        If Not IsNothing(TheJobAdd) Then
            If Not TheJobAdd.IsDisposed() Then
                TheJobAdd.BringToFront()
                TheJobAdd.Show()
            Else
                TheJobAdd = New jobAdd
                TheJobAdd.Show()
            End If
        Else
            TheJobAdd = New jobAdd
            TheJobAdd.Show()
        End If

    End Sub
    Private Sub TheJobAdd_NewRecordAddedEvent() Handles TheJobAdd.NewRecordAddedEvent
        RefreshMyDataSources()
        Me.ListBox1.SelectedValue = TheJobAdd.GetPrimKey
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub TheAcftAdd_NewRecordAddedEvent() Handles TheAcftAdd.NewRecordAddedEvent
        RefreshMyDataSources()
        Me.ListBox1.SelectedValue = TheAcftAdd.GetPrimKey
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub EditAircraftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditAircraftToolStripMenuItem.Click
        Dim TheEditAcft As New manAcftEdit
        TheEditAcft.Show()
    End Sub

    Private Sub FlareCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlareCheckBox.CheckedChanged
        UpdateMyDataSources()
    End Sub


    Private Sub CrewStatusCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrewStatusCheckBox.CheckedChanged
        UpdateMyDataSources()
    End Sub
End Class


