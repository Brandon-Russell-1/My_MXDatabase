<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SOEJCNSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SOEJCNSearch))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SOEStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.SOEEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSOEKeyword = New System.Windows.Forms.TextBox
        Me.btnSOESearch = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtWUC = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.JobStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.JobEndDate = New System.Windows.Forms.DateTimePicker
        Me.btnJOBSearch = New System.Windows.Forms.Button
        Me.txtJobKeyword = New System.Windows.Forms.TextBox
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.ReportFilterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportFilterTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.ReportFilterTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.Archive_tblJobsTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblJobsTableAdapter
        Me.Archive_tblSOETableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblSOETableAdapter
        Me.JobReportFilterTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.JobReportFilterTableAdapter
        Me.TblMorningSheetLocationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblMorningSheetLocationTableAdapter
        Me.Archive_tblSOEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Archive_tblJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMorningSheetLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobReportFilterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportFilterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Archive_tblSOEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Archive_tblJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMorningSheetLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobReportFilterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.SOEStartDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SOEEndDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSOEKeyword)
        Me.GroupBox1.Controls.Add(Me.btnSOESearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SOE Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Start Date:"
        '
        'SOEStartDate
        '
        Me.SOEStartDate.CustomFormat = "MM/dd/yy"
        Me.SOEStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SOEStartDate.Location = New System.Drawing.Point(72, 98)
        Me.SOEStartDate.Name = "SOEStartDate"
        Me.SOEStartDate.Size = New System.Drawing.Size(200, 20)
        Me.SOEStartDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "End Date:"
        '
        'SOEEndDate
        '
        Me.SOEEndDate.CustomFormat = "MM/dd/yy"
        Me.SOEEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SOEEndDate.Location = New System.Drawing.Point(72, 124)
        Me.SOEEndDate.Name = "SOEEndDate"
        Me.SOEEndDate.Size = New System.Drawing.Size(200, 20)
        Me.SOEEndDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Keyword:"
        '
        'txtSOEKeyword
        '
        Me.txtSOEKeyword.Location = New System.Drawing.Point(72, 165)
        Me.txtSOEKeyword.Name = "txtSOEKeyword"
        Me.txtSOEKeyword.Size = New System.Drawing.Size(176, 20)
        Me.txtSOEKeyword.TabIndex = 1
        '
        'btnSOESearch
        '
        Me.btnSOESearch.Location = New System.Drawing.Point(108, 262)
        Me.btnSOESearch.Name = "btnSOESearch"
        Me.btnSOESearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSOESearch.TabIndex = 0
        Me.btnSOESearch.Text = "Search"
        Me.btnSOESearch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtWUC)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.JobStartDate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.JobEndDate)
        Me.GroupBox2.Controls.Add(Me.btnJOBSearch)
        Me.GroupBox2.Controls.Add(Me.txtJobKeyword)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 395)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "JCN Search"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "WUC:"
        '
        'txtWUC
        '
        Me.txtWUC.Location = New System.Drawing.Point(75, 45)
        Me.txtWUC.Name = "txtWUC"
        Me.txtWUC.Size = New System.Drawing.Size(174, 20)
        Me.txtWUC.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Start Date:"
        '
        'JobStartDate
        '
        Me.JobStartDate.CustomFormat = "MM/dd/yy"
        Me.JobStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.JobStartDate.Location = New System.Drawing.Point(75, 95)
        Me.JobStartDate.Name = "JobStartDate"
        Me.JobStartDate.Size = New System.Drawing.Size(200, 20)
        Me.JobStartDate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "End Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Keyword:"
        '
        'JobEndDate
        '
        Me.JobEndDate.CustomFormat = "MM/dd/yy"
        Me.JobEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.JobEndDate.Location = New System.Drawing.Point(75, 121)
        Me.JobEndDate.Name = "JobEndDate"
        Me.JobEndDate.Size = New System.Drawing.Size(200, 20)
        Me.JobEndDate.TabIndex = 7
        '
        'btnJOBSearch
        '
        Me.btnJOBSearch.Location = New System.Drawing.Point(110, 262)
        Me.btnJOBSearch.Name = "btnJOBSearch"
        Me.btnJOBSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnJOBSearch.TabIndex = 1
        Me.btnJOBSearch.Text = "Search"
        Me.btnJOBSearch.UseVisualStyleBackColor = True
        '
        'txtJobKeyword
        '
        Me.txtJobKeyword.Location = New System.Drawing.Point(76, 164)
        Me.txtJobKeyword.Name = "txtJobKeyword"
        Me.txtJobKeyword.Size = New System.Drawing.Size(174, 20)
        Me.txtJobKeyword.TabIndex = 3
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportFilterBindingSource
        '
        Me.ReportFilterBindingSource.DataMember = "ReportFilter"
        Me.ReportFilterBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'ReportFilterTableAdapter
        '
        Me.ReportFilterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Archive_tblAcftOnStationTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblJobsTableAdapter = Me.Archive_tblJobsTableAdapter
        Me.TableAdapterManager.Archive_tblMRTTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblPOLTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblSOETableAdapter = Me.Archive_tblSOETableAdapter
        Me.TableAdapterManager.Archive_tblTurnoverTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GOAircraftTableAdapter = Nothing
        Me.TableAdapterManager.GODataTableAdapter = Nothing
        Me.TableAdapterManager.GOJCNSTableAdapter = Nothing
        Me.TableAdapterManager.JobReportFilterTableAdapter = Me.JobReportFilterTableAdapter
        Me.TableAdapterManager.ReportFilterTableAdapter = Me.ReportFilterTableAdapter
        Me.TableAdapterManager.tblAcftOnStationTableAdapter = Nothing
        Me.TableAdapterManager.tblAutoSOETableAdapter = Nothing
        Me.TableAdapterManager.tblDevCodeListTableAdapter = Nothing
        Me.TableAdapterManager.tblErrorLogTableAdapter = Nothing
        Me.TableAdapterManager.tblFullLocationListTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralTurnoverTableAdapter = Nothing
        Me.TableAdapterManager.tblHazCargoListTableAdapter = Nothing
        Me.TableAdapterManager.tblJobsTableAdapter = Nothing
        Me.TableAdapterManager.tblKickOutTableAdapter = Nothing
        Me.TableAdapterManager.tblMessageAlertTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetCheckTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetLocationTableAdapter = Me.TblMorningSheetLocationTableAdapter
        Me.TableAdapterManager.tblMorningSheetNotesTableAdapter = Nothing
        Me.TableAdapterManager.tblMRTTableAdapter = Nothing
        Me.TableAdapterManager.tblPOLTableAdapter = Nothing
        Me.TableAdapterManager.tblRegexUpdateTableAdapter = Nothing
        Me.TableAdapterManager.tblSnappleFactsTableAdapter = Nothing
        Me.TableAdapterManager.tblSOETableAdapter = Nothing
        Me.TableAdapterManager.tblTempMorningSheetDelaysTableAdapter = Nothing
        Me.TableAdapterManager.tblTempMorningSheetInboundTableAdapter = Nothing
        Me.TableAdapterManager.tblTempMorningSheetOutboundTableAdapter = Nothing
        Me.TableAdapterManager.tblTempMorningSheetPWTableAdapter = Nothing
        Me.TableAdapterManager.tblTempSOEWeatherTableAdapter = Nothing
        Me.TableAdapterManager.tblTurnoverTableAdapter = Nothing
        Me.TableAdapterManager.tblUserNamesTableAdapter = Nothing
        Me.TableAdapterManager.tblWeatherCurrentTableAdapter = Nothing
        Me.TableAdapterManager.tblWeatherWarningListTableAdapter = Nothing
        Me.TableAdapterManager.tblWebsiteHelpLocationTableAdapter = Nothing
        Me.TableAdapterManager.TEMPInboundTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Archive_tblJobsTableAdapter
        '
        Me.Archive_tblJobsTableAdapter.ClearBeforeFill = True
        '
        'Archive_tblSOETableAdapter
        '
        Me.Archive_tblSOETableAdapter.ClearBeforeFill = True
        '
        'JobReportFilterTableAdapter
        '
        Me.JobReportFilterTableAdapter.ClearBeforeFill = True
        '
        'TblMorningSheetLocationTableAdapter
        '
        Me.TblMorningSheetLocationTableAdapter.ClearBeforeFill = True
        '
        'Archive_tblSOEBindingSource
        '
        Me.Archive_tblSOEBindingSource.DataMember = "Archive_tblSOE"
        Me.Archive_tblSOEBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'Archive_tblJobsBindingSource
        '
        Me.Archive_tblJobsBindingSource.DataMember = "Archive_tblJobs"
        Me.Archive_tblJobsBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblMorningSheetLocationBindingSource
        '
        Me.TblMorningSheetLocationBindingSource.DataMember = "tblMorningSheetLocation"
        Me.TblMorningSheetLocationBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'JobReportFilterBindingSource
        '
        Me.JobReportFilterBindingSource.DataMember = "JobReportFilter"
        Me.JobReportFilterBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'SOEJCNSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 446)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SOEJCNSearch"
        Me.Text = "SOE/JCN Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportFilterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Archive_tblSOEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Archive_tblJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMorningSheetLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobReportFilterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents ReportFilterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportFilterTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.ReportFilterTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Archive_tblSOETableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblSOETableAdapter
    Friend WithEvents Archive_tblSOEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Archive_tblJobsTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblJobsTableAdapter
    Friend WithEvents Archive_tblJobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSOESearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnJOBSearch As System.Windows.Forms.Button
    Friend WithEvents txtSOEKeyword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJobKeyword As System.Windows.Forms.TextBox
    Friend WithEvents SOEEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SOEStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents JobStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents JobEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtWUC As System.Windows.Forms.TextBox
    Friend WithEvents TblMorningSheetLocationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblMorningSheetLocationTableAdapter
    Friend WithEvents TblMorningSheetLocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobReportFilterTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.JobReportFilterTableAdapter
    Friend WithEvents JobReportFilterBindingSource As System.Windows.Forms.BindingSource
End Class
