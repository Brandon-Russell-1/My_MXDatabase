Imports System.Threading
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class A4Browse

    Delegate Sub myDelegate()

    Private Sub A4Browse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblWebsiteHelpLocation' table. You can move, or remove it, as needed.
        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblAcftOnStation' table. You can move, or remove it, as needed.
        Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)

        Dim myThread As New Threading.Thread(AddressOf MainThread)
        myThread.Priority = ThreadPriority.Highest
        myThread.IsBackground = True
        myThread.Start()



    End Sub


    Private Sub MainThread()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New myDelegate(AddressOf LoadWeb))
            End If

        Catch ex As Exception

            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Thread Exception")
        End Try
    End Sub

    Private Sub LoadWeb()

        Me.WebBrowser1.Tag = "Loading"
        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
        Me.TblWebsiteHelpLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)

        Dim CheckWebsiteUpdate As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempWebsite As String = ""
        For Each row In CheckWebsiteUpdate("tblWebsiteHelpLocation").Select("ID='A4'")
            TempWebsite = row("Location").ToString
        Next row


        Me.WebBrowser1.Dispose()
        Me.WebBrowser1 = New WebBrowser
        Me.Controls.Add(Me.WebBrowser1)
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(986, 740)
        Me.WebBrowser1.TabIndex = 0
        '

        Me.WebBrowser1.Navigate(TempWebsite)


        While Me.WebBrowser1.Tag <> "Loaded"
            Application.DoEvents()
        End While



    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.WebBrowserProgressBar.Value = 0
        Me.WebBrowser1.Tag = "Loaded"
    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged

        Me.WebBrowserProgressBar.Maximum = Convert.ToInt32(e.MaximumProgress)
        Me.WebBrowserProgressBar.Value = Convert.ToInt32(e.CurrentProgress)

    End Sub


    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick
        Dim myThread As New Threading.Thread(AddressOf MainThread)
        myThread.Priority = ThreadPriority.Highest
        myThread.IsBackground = True
        myThread.Start()
    End Sub
End Class