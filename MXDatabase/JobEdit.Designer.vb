<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobEdit
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
        Dim AcftTailNumLabel As System.Windows.Forms.Label
        Dim JCNLabel As System.Windows.Forms.Label
        Dim WCELabel As System.Windows.Forms.Label
        Dim SymbolLabel As System.Windows.Forms.Label
        Dim WUCLabel As System.Windows.Forms.Label
        Dim NarrLabel As System.Windows.Forms.Label
        Dim CorrActionLabel As System.Windows.Forms.Label
        Dim CWDateTimeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobEdit))
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TblJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobsTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblJobsTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.AcftTailNumTextBox = New System.Windows.Forms.TextBox
        Me.JCNTextBox = New System.Windows.Forms.TextBox
        Me.WCETextBox = New System.Windows.Forms.TextBox
        Me.SymbolTextBox = New System.Windows.Forms.TextBox
        Me.WUCTextBox = New System.Windows.Forms.TextBox
        Me.NarrTextBox = New System.Windows.Forms.TextBox
        Me.CorrActionTextBox = New System.Windows.Forms.TextBox
        Me.CWDateTimeTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        AcftTailNumLabel = New System.Windows.Forms.Label
        JCNLabel = New System.Windows.Forms.Label
        WCELabel = New System.Windows.Forms.Label
        SymbolLabel = New System.Windows.Forms.Label
        WUCLabel = New System.Windows.Forms.Label
        NarrLabel = New System.Windows.Forms.Label
        CorrActionLabel = New System.Windows.Forms.Label
        CWDateTimeLabel = New System.Windows.Forms.Label
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AcftTailNumLabel
        '
        AcftTailNumLabel.AutoSize = True
        AcftTailNumLabel.Location = New System.Drawing.Point(12, 9)
        AcftTailNumLabel.Name = "AcftTailNumLabel"
        AcftTailNumLabel.Size = New System.Drawing.Size(67, 13)
        AcftTailNumLabel.TabIndex = 1
        AcftTailNumLabel.Text = "Tail Number:"
        '
        'JCNLabel
        '
        JCNLabel.AutoSize = True
        JCNLabel.Location = New System.Drawing.Point(253, 9)
        JCNLabel.Name = "JCNLabel"
        JCNLabel.Size = New System.Drawing.Size(30, 13)
        JCNLabel.TabIndex = 2
        JCNLabel.Text = "JCN:"
        '
        'WCELabel
        '
        WCELabel.AutoSize = True
        WCELabel.Location = New System.Drawing.Point(394, 9)
        WCELabel.Name = "WCELabel"
        WCELabel.Size = New System.Drawing.Size(35, 13)
        WCELabel.TabIndex = 4
        WCELabel.Text = "WCE:"
        '
        'SymbolLabel
        '
        SymbolLabel.AutoSize = True
        SymbolLabel.Location = New System.Drawing.Point(543, 9)
        SymbolLabel.Name = "SymbolLabel"
        SymbolLabel.Size = New System.Drawing.Size(44, 13)
        SymbolLabel.TabIndex = 6
        SymbolLabel.Text = "Symbol:"
        '
        'WUCLabel
        '
        WUCLabel.AutoSize = True
        WUCLabel.Location = New System.Drawing.Point(43, 35)
        WUCLabel.Name = "WUCLabel"
        WUCLabel.Size = New System.Drawing.Size(36, 13)
        WUCLabel.TabIndex = 8
        WUCLabel.Text = "WUC:"
        '
        'NarrLabel
        '
        NarrLabel.AutoSize = True
        NarrLabel.Location = New System.Drawing.Point(12, 55)
        NarrLabel.Name = "NarrLabel"
        NarrLabel.Size = New System.Drawing.Size(30, 13)
        NarrLabel.TabIndex = 10
        NarrLabel.Text = "Narr:"
        '
        'CorrActionLabel
        '
        CorrActionLabel.AutoSize = True
        CorrActionLabel.Location = New System.Drawing.Point(12, 139)
        CorrActionLabel.Name = "CorrActionLabel"
        CorrActionLabel.Size = New System.Drawing.Size(91, 13)
        CorrActionLabel.TabIndex = 12
        CorrActionLabel.Text = "Corrective Action:"
        '
        'CWDateTimeLabel
        '
        CWDateTimeLabel.AutoSize = True
        CWDateTimeLabel.Location = New System.Drawing.Point(510, 314)
        CWDateTimeLabel.Name = "CWDateTimeLabel"
        CWDateTimeLabel.Size = New System.Drawing.Size(77, 13)
        CWDateTimeLabel.TabIndex = 14
        CWDateTimeLabel.Text = "Job Closed on:"
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblJobsBindingSource
        '
        Me.TblJobsBindingSource.DataMember = "tblJobs"
        Me.TblJobsBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblJobsTableAdapter
        '
        Me.TblJobsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Archive_tblAcftOnStationTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblJobsTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblMRTTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblPOLTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblSOETableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblTurnoverTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GOAircraftTableAdapter = Nothing
        Me.TableAdapterManager.GODataTableAdapter = Nothing
        Me.TableAdapterManager.GOJCNSTableAdapter = Nothing
        Me.TableAdapterManager.JobReportFilterTableAdapter = Nothing
        Me.TableAdapterManager.ReportFilterTableAdapter = Nothing
        Me.TableAdapterManager.tblAcftOnStationTableAdapter = Nothing
        Me.TableAdapterManager.tblAutoSOETableAdapter = Nothing
        Me.TableAdapterManager.tblBlockerTableAdapter = Nothing
        Me.TableAdapterManager.tblDevCodeListTableAdapter = Nothing
        Me.TableAdapterManager.tblErrorLogTableAdapter = Nothing
        Me.TableAdapterManager.tblFullLocationListTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralTurnoverTableAdapter = Nothing
        Me.TableAdapterManager.tblHazCargoListTableAdapter = Nothing
        Me.TableAdapterManager.tblJobsTableAdapter = Me.TblJobsTableAdapter
        Me.TableAdapterManager.tblKickOutTableAdapter = Nothing
        Me.TableAdapterManager.tblMessageAlertTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetCheckTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetLocationTableAdapter = Nothing
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
        'AcftTailNumTextBox
        '
        Me.AcftTailNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "AcftTailNum", True))
        Me.AcftTailNumTextBox.Location = New System.Drawing.Point(92, 6)
        Me.AcftTailNumTextBox.Name = "AcftTailNumTextBox"
        Me.AcftTailNumTextBox.ReadOnly = True
        Me.AcftTailNumTextBox.Size = New System.Drawing.Size(155, 20)
        Me.AcftTailNumTextBox.TabIndex = 2
        '
        'JCNTextBox
        '
        Me.JCNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "JCN", True))
        Me.JCNTextBox.Location = New System.Drawing.Point(289, 6)
        Me.JCNTextBox.Name = "JCNTextBox"
        Me.JCNTextBox.ReadOnly = True
        Me.JCNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JCNTextBox.TabIndex = 3
        '
        'WCETextBox
        '
        Me.WCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "WCE", True))
        Me.WCETextBox.Location = New System.Drawing.Point(435, 6)
        Me.WCETextBox.Name = "WCETextBox"
        Me.WCETextBox.ReadOnly = True
        Me.WCETextBox.Size = New System.Drawing.Size(100, 20)
        Me.WCETextBox.TabIndex = 5
        '
        'SymbolTextBox
        '
        Me.SymbolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "Symbol", True))
        Me.SymbolTextBox.Location = New System.Drawing.Point(593, 6)
        Me.SymbolTextBox.Name = "SymbolTextBox"
        Me.SymbolTextBox.ReadOnly = True
        Me.SymbolTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SymbolTextBox.TabIndex = 7
        '
        'WUCTextBox
        '
        Me.WUCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "WUC", True))
        Me.WUCTextBox.Location = New System.Drawing.Point(92, 32)
        Me.WUCTextBox.Name = "WUCTextBox"
        Me.WUCTextBox.ReadOnly = True
        Me.WUCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WUCTextBox.TabIndex = 9
        '
        'NarrTextBox
        '
        Me.NarrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "Narr", True))
        Me.NarrTextBox.Location = New System.Drawing.Point(15, 71)
        Me.NarrTextBox.Multiline = True
        Me.NarrTextBox.Name = "NarrTextBox"
        Me.NarrTextBox.ReadOnly = True
        Me.NarrTextBox.Size = New System.Drawing.Size(748, 53)
        Me.NarrTextBox.TabIndex = 11
        '
        'CorrActionTextBox
        '
        Me.CorrActionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "CorrAction", True))
        Me.CorrActionTextBox.Location = New System.Drawing.Point(15, 155)
        Me.CorrActionTextBox.Multiline = True
        Me.CorrActionTextBox.Name = "CorrActionTextBox"
        Me.CorrActionTextBox.Size = New System.Drawing.Size(748, 121)
        Me.CorrActionTextBox.TabIndex = 13
        '
        'CWDateTimeTextBox
        '
        Me.CWDateTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblJobsBindingSource, "CWDateTime", True))
        Me.CWDateTimeTextBox.Location = New System.Drawing.Point(593, 311)
        Me.CWDateTimeTextBox.Name = "CWDateTimeTextBox"
        Me.CWDateTimeTextBox.ReadOnly = True
        Me.CWDateTimeTextBox.Size = New System.Drawing.Size(170, 20)
        Me.CWDateTimeTextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Delete Job"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "- For use on duplicate jobs only"
        '
        'JobEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 343)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CWDateTimeLabel)
        Me.Controls.Add(Me.CWDateTimeTextBox)
        Me.Controls.Add(CorrActionLabel)
        Me.Controls.Add(Me.CorrActionTextBox)
        Me.Controls.Add(NarrLabel)
        Me.Controls.Add(Me.NarrTextBox)
        Me.Controls.Add(WUCLabel)
        Me.Controls.Add(Me.WUCTextBox)
        Me.Controls.Add(SymbolLabel)
        Me.Controls.Add(Me.SymbolTextBox)
        Me.Controls.Add(WCELabel)
        Me.Controls.Add(Me.WCETextBox)
        Me.Controls.Add(JCNLabel)
        Me.Controls.Add(Me.JCNTextBox)
        Me.Controls.Add(AcftTailNumLabel)
        Me.Controls.Add(Me.AcftTailNumTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "JobEdit"
        Me.Text = "Job Edit"
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents TblJobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobsTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblJobsTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AcftTailNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JCNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WCETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SymbolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WUCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NarrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorrActionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CWDateTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
