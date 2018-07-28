<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AircraftReportSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AircraftReportSelector))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.Archive_tblAcftOnStationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Archive_tblAcftOnStationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblAcftOnStationTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.Archive_tblJobsTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblJobsTableAdapter
        Me.Archive_tblSOETableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblSOETableAdapter
        Me.Archive_tblTurnoverTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblTurnoverTableAdapter
        Me.TblAcftOnStationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
        Me.TblJobsTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblJobsTableAdapter
        Me.TblSOETableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblSOETableAdapter
        Me.TblTurnoverTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblTurnoverTableAdapter
        Me.TblAcftOnStationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcftTailNumberListBox = New System.Windows.Forms.ListBox
        Me.AcftSpotListBox = New System.Windows.Forms.ListBox
        Me.btnOpenACReportOnStation = New System.Windows.Forms.Button
        Me.btnOpen48ReportOnStation = New System.Windows.Forms.Button
        Me.btnOpen48hrReportAll = New System.Windows.Forms.Button
        Me.btnOpenACReportAll = New System.Windows.Forms.Button
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.ListBox4 = New System.Windows.Forms.ListBox
        Me.TblSOEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Archive_tblJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Archive_tblSOEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTurnoverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Archive_tblTurnoverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMorningSheetLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMorningSheetLocationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblMorningSheetLocationTableAdapter
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Archive_tblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSOEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Archive_tblJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Archive_tblSOEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTurnoverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Archive_tblTurnoverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMorningSheetLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "On Station"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "All"
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Archive_tblAcftOnStationBindingSource
        '
        Me.Archive_tblAcftOnStationBindingSource.DataMember = "Archive_tblAcftOnStation"
        Me.Archive_tblAcftOnStationBindingSource.DataSource = Me.MxDatabaseDataSet
        Me.Archive_tblAcftOnStationBindingSource.Sort = "ETDJulian DESC, ETDTime DESC"
        '
        'Archive_tblAcftOnStationTableAdapter
        '
        Me.Archive_tblAcftOnStationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Archive_tblAcftOnStationTableAdapter = Me.Archive_tblAcftOnStationTableAdapter
        Me.TableAdapterManager.Archive_tblJobsTableAdapter = Me.Archive_tblJobsTableAdapter
        Me.TableAdapterManager.Archive_tblSOETableAdapter = Me.Archive_tblSOETableAdapter
        Me.TableAdapterManager.Archive_tblTurnoverTableAdapter = Me.Archive_tblTurnoverTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GOAircraftTableAdapter = Nothing
        Me.TableAdapterManager.GODataTableAdapter = Nothing
        Me.TableAdapterManager.GOJCNSTableAdapter = Nothing
        Me.TableAdapterManager.tblAcftOnStationTableAdapter = Me.TblAcftOnStationTableAdapter
        Me.TableAdapterManager.tblAutoSOETableAdapter = Nothing
        Me.TableAdapterManager.tblDevCodeListTableAdapter = Nothing
        Me.TableAdapterManager.tblErrorLogTableAdapter = Nothing
        Me.TableAdapterManager.tblFullLocationListTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralTurnoverTableAdapter = Nothing
        Me.TableAdapterManager.tblHazCargoListTableAdapter = Nothing
        Me.TableAdapterManager.tblJobsTableAdapter = Me.TblJobsTableAdapter
        Me.TableAdapterManager.tblKickOutTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetCheckTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetLocationTableAdapter = Me.TblMorningSheetLocationTableAdapter
        Me.TableAdapterManager.tblMorningSheetNotesTableAdapter = Nothing
        Me.TableAdapterManager.tblSOETableAdapter = Me.TblSOETableAdapter
        Me.TableAdapterManager.tblTempMorningSheetDelaysTableAdapter = Nothing
        Me.TableAdapterManager.tblTempMorningSheetInboundTableAdapter = Nothing
        Me.TableAdapterManager.tblTempMorningSheetOutboundTableAdapter = Nothing
        Me.TableAdapterManager.tblTempMorningSheetPWTableAdapter = Nothing
        Me.TableAdapterManager.tblTempSOEWeatherTableAdapter = Nothing
        Me.TableAdapterManager.tblTurnoverTableAdapter = Me.TblTurnoverTableAdapter
        Me.TableAdapterManager.tblUserNamesTableAdapter = Nothing
        Me.TableAdapterManager.tblWeatherCurrentTableAdapter = Nothing
        Me.TableAdapterManager.tblWeatherWarningListTableAdapter = Nothing
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
        'Archive_tblTurnoverTableAdapter
        '
        Me.Archive_tblTurnoverTableAdapter.ClearBeforeFill = True
        '
        'TblAcftOnStationTableAdapter
        '
        Me.TblAcftOnStationTableAdapter.ClearBeforeFill = True
        '
        'TblJobsTableAdapter
        '
        Me.TblJobsTableAdapter.ClearBeforeFill = True
        '
        'TblSOETableAdapter
        '
        Me.TblSOETableAdapter.ClearBeforeFill = True
        '
        'TblTurnoverTableAdapter
        '
        Me.TblTurnoverTableAdapter.ClearBeforeFill = True
        '
        'TblAcftOnStationBindingSource
        '
        Me.TblAcftOnStationBindingSource.DataMember = "tblAcftOnStation"
        Me.TblAcftOnStationBindingSource.DataSource = Me.MxDatabaseDataSet
        Me.TblAcftOnStationBindingSource.Sort = "ETDJulian ASC, ETDTime ASC"
        '
        'AcftTailNumberListBox
        '
        Me.AcftTailNumberListBox.DataSource = Me.TblAcftOnStationBindingSource
        Me.AcftTailNumberListBox.DisplayMember = "AcftTailNumber"
        Me.AcftTailNumberListBox.FormattingEnabled = True
        Me.AcftTailNumberListBox.Location = New System.Drawing.Point(53, 56)
        Me.AcftTailNumberListBox.Name = "AcftTailNumberListBox"
        Me.AcftTailNumberListBox.Size = New System.Drawing.Size(82, 329)
        Me.AcftTailNumberListBox.TabIndex = 4
        Me.AcftTailNumberListBox.ValueMember = "PrimKey"
        '
        'AcftSpotListBox
        '
        Me.AcftSpotListBox.DataSource = Me.TblAcftOnStationBindingSource
        Me.AcftSpotListBox.DisplayMember = "AcftSpot"
        Me.AcftSpotListBox.FormattingEnabled = True
        Me.AcftSpotListBox.Location = New System.Drawing.Point(132, 56)
        Me.AcftSpotListBox.Name = "AcftSpotListBox"
        Me.AcftSpotListBox.Size = New System.Drawing.Size(51, 329)
        Me.AcftSpotListBox.TabIndex = 5
        Me.AcftSpotListBox.ValueMember = "PrimKey"
        '
        'btnOpenACReportOnStation
        '
        Me.btnOpenACReportOnStation.Location = New System.Drawing.Point(72, 391)
        Me.btnOpenACReportOnStation.Name = "btnOpenACReportOnStation"
        Me.btnOpenACReportOnStation.Size = New System.Drawing.Size(92, 23)
        Me.btnOpenACReportOnStation.TabIndex = 6
        Me.btnOpenACReportOnStation.Text = "Aircraft Report"
        Me.btnOpenACReportOnStation.UseVisualStyleBackColor = True
        '
        'btnOpen48ReportOnStation
        '
        Me.btnOpen48ReportOnStation.Location = New System.Drawing.Point(72, 420)
        Me.btnOpen48ReportOnStation.Name = "btnOpen48ReportOnStation"
        Me.btnOpen48ReportOnStation.Size = New System.Drawing.Size(92, 23)
        Me.btnOpen48ReportOnStation.TabIndex = 7
        Me.btnOpen48ReportOnStation.Text = "48hr Report"
        Me.btnOpen48ReportOnStation.UseVisualStyleBackColor = True
        '
        'btnOpen48hrReportAll
        '
        Me.btnOpen48hrReportAll.Location = New System.Drawing.Point(250, 420)
        Me.btnOpen48hrReportAll.Name = "btnOpen48hrReportAll"
        Me.btnOpen48hrReportAll.Size = New System.Drawing.Size(92, 23)
        Me.btnOpen48hrReportAll.TabIndex = 15
        Me.btnOpen48hrReportAll.Text = "48hr Report"
        Me.btnOpen48hrReportAll.UseVisualStyleBackColor = True
        '
        'btnOpenACReportAll
        '
        Me.btnOpenACReportAll.Location = New System.Drawing.Point(250, 391)
        Me.btnOpenACReportAll.Name = "btnOpenACReportAll"
        Me.btnOpenACReportAll.Size = New System.Drawing.Size(92, 23)
        Me.btnOpenACReportAll.TabIndex = 14
        Me.btnOpenACReportAll.Text = "Aircraft Report"
        Me.btnOpenACReportAll.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.DataSource = Me.Archive_tblAcftOnStationBindingSource
        Me.ListBox3.DisplayMember = "ETDDateTime"
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(310, 56)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(89, 329)
        Me.ListBox3.TabIndex = 13
        Me.ListBox3.ValueMember = "PrimKey"
        '
        'ListBox4
        '
        Me.ListBox4.DataSource = Me.Archive_tblAcftOnStationBindingSource
        Me.ListBox4.DisplayMember = "AcftTailNumber"
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(231, 56)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(82, 329)
        Me.ListBox4.TabIndex = 12
        Me.ListBox4.ValueMember = "PrimKey"
        '
        'TblSOEBindingSource
        '
        Me.TblSOEBindingSource.DataMember = "tblSOE"
        Me.TblSOEBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblJobsBindingSource
        '
        Me.TblJobsBindingSource.DataMember = "tblJobs"
        Me.TblJobsBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'Archive_tblJobsBindingSource
        '
        Me.Archive_tblJobsBindingSource.DataMember = "Archive_tblJobs"
        Me.Archive_tblJobsBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'Archive_tblSOEBindingSource
        '
        Me.Archive_tblSOEBindingSource.DataMember = "Archive_tblSOE"
        Me.Archive_tblSOEBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblTurnoverBindingSource
        '
        Me.TblTurnoverBindingSource.DataMember = "tblTurnover"
        Me.TblTurnoverBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'Archive_tblTurnoverBindingSource
        '
        Me.Archive_tblTurnoverBindingSource.DataMember = "Archive_tblTurnover"
        Me.Archive_tblTurnoverBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblMorningSheetLocationBindingSource
        '
        Me.TblMorningSheetLocationBindingSource.DataMember = "tblMorningSheetLocation"
        Me.TblMorningSheetLocationBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblMorningSheetLocationTableAdapter
        '
        Me.TblMorningSheetLocationTableAdapter.ClearBeforeFill = True
        '
        'AircraftReportSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 474)
        Me.Controls.Add(Me.btnOpen48hrReportAll)
        Me.Controls.Add(Me.btnOpenACReportAll)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.btnOpen48ReportOnStation)
        Me.Controls.Add(Me.btnOpenACReportOnStation)
        Me.Controls.Add(Me.AcftSpotListBox)
        Me.Controls.Add(Me.AcftTailNumberListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AircraftReportSelector"
        Me.Text = "Aircraft Report Selector"
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Archive_tblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSOEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Archive_tblJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Archive_tblSOEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTurnoverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Archive_tblTurnoverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMorningSheetLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents Archive_tblAcftOnStationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Archive_tblAcftOnStationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblAcftOnStationTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblAcftOnStationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
    Friend WithEvents TblAcftOnStationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AcftTailNumberListBox As System.Windows.Forms.ListBox
    Friend WithEvents AcftSpotListBox As System.Windows.Forms.ListBox
    Friend WithEvents btnOpenACReportOnStation As System.Windows.Forms.Button
    Friend WithEvents btnOpen48ReportOnStation As System.Windows.Forms.Button
    Friend WithEvents btnOpen48hrReportAll As System.Windows.Forms.Button
    Friend WithEvents btnOpenACReportAll As System.Windows.Forms.Button
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents TblSOETableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblSOETableAdapter
    Friend WithEvents TblSOEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobsTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblJobsTableAdapter
    Friend WithEvents TblJobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Archive_tblJobsTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblJobsTableAdapter
    Friend WithEvents Archive_tblJobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Archive_tblSOETableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblSOETableAdapter
    Friend WithEvents Archive_tblSOEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTurnoverTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblTurnoverTableAdapter
    Friend WithEvents TblTurnoverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Archive_tblTurnoverTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.Archive_tblTurnoverTableAdapter
    Friend WithEvents Archive_tblTurnoverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMorningSheetLocationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblMorningSheetLocationTableAdapter
    Friend WithEvents TblMorningSheetLocationBindingSource As System.Windows.Forms.BindingSource
End Class
