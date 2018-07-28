<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manAcftEdit
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
        Dim AcftSpotLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim FuelLabel As System.Windows.Forms.Label
        Dim NitroLabel As System.Windows.Forms.Label
        Dim LoxLabel As System.Windows.Forms.Label
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TblAcftOnStationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAcftOnStationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.AcftSpotTextBox = New System.Windows.Forms.TextBox
        Me.StatusTextBox = New System.Windows.Forms.TextBox
        Me.FuelTextBox = New System.Windows.Forms.TextBox
        Me.NitroTextBox = New System.Windows.Forms.TextBox
        Me.LoxTextBox = New System.Windows.Forms.TextBox
        Me.AcftTailNumberListBox = New System.Windows.Forms.ListBox
        AcftSpotLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        FuelLabel = New System.Windows.Forms.Label
        NitroLabel = New System.Windows.Forms.Label
        LoxLabel = New System.Windows.Forms.Label
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAcftOnStationBindingSource
        '
        Me.TblAcftOnStationBindingSource.DataMember = "tblAcftOnStation"
        Me.TblAcftOnStationBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblAcftOnStationTableAdapter
        '
        Me.TblAcftOnStationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblAcftOnStationTableAdapter = Me.TblAcftOnStationTableAdapter
        Me.TableAdapterManager.tblAutoSOETableAdapter = Nothing
        Me.TableAdapterManager.tblBlockerTableAdapter = Nothing
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(LoxLabel)
        Me.GroupBox1.Controls.Add(Me.LoxTextBox)
        Me.GroupBox1.Controls.Add(NitroLabel)
        Me.GroupBox1.Controls.Add(Me.NitroTextBox)
        Me.GroupBox1.Controls.Add(FuelLabel)
        Me.GroupBox1.Controls.Add(Me.FuelTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(AcftSpotLabel)
        Me.GroupBox1.Controls.Add(Me.AcftSpotTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 319)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'AcftSpotLabel
        '
        AcftSpotLabel.AutoSize = True
        AcftSpotLabel.Location = New System.Drawing.Point(6, 35)
        AcftSpotLabel.Name = "AcftSpotLabel"
        AcftSpotLabel.Size = New System.Drawing.Size(54, 13)
        AcftSpotLabel.TabIndex = 0
        AcftSpotLabel.Text = "Acft Spot:"
        '
        'AcftSpotTextBox
        '
        Me.AcftSpotTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAcftOnStationBindingSource, "AcftSpot", True))
        Me.AcftSpotTextBox.Location = New System.Drawing.Point(78, 32)
        Me.AcftSpotTextBox.Name = "AcftSpotTextBox"
        Me.AcftSpotTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AcftSpotTextBox.TabIndex = 1
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(6, 61)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 2
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAcftOnStationBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(78, 58)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 3
        '
        'FuelLabel
        '
        FuelLabel.AutoSize = True
        FuelLabel.Location = New System.Drawing.Point(6, 85)
        FuelLabel.Name = "FuelLabel"
        FuelLabel.Size = New System.Drawing.Size(30, 13)
        FuelLabel.TabIndex = 4
        FuelLabel.Text = "Fuel:"
        '
        'FuelTextBox
        '
        Me.FuelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAcftOnStationBindingSource, "Fuel", True))
        Me.FuelTextBox.Location = New System.Drawing.Point(78, 85)
        Me.FuelTextBox.Name = "FuelTextBox"
        Me.FuelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FuelTextBox.TabIndex = 5
        '
        'NitroLabel
        '
        NitroLabel.AutoSize = True
        NitroLabel.Location = New System.Drawing.Point(6, 115)
        NitroLabel.Name = "NitroLabel"
        NitroLabel.Size = New System.Drawing.Size(32, 13)
        NitroLabel.TabIndex = 6
        NitroLabel.Text = "Nitro:"
        '
        'NitroTextBox
        '
        Me.NitroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAcftOnStationBindingSource, "Nitro", True))
        Me.NitroTextBox.Location = New System.Drawing.Point(78, 112)
        Me.NitroTextBox.Name = "NitroTextBox"
        Me.NitroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NitroTextBox.TabIndex = 7
        '
        'LoxLabel
        '
        LoxLabel.AutoSize = True
        LoxLabel.Location = New System.Drawing.Point(6, 146)
        LoxLabel.Name = "LoxLabel"
        LoxLabel.Size = New System.Drawing.Size(27, 13)
        LoxLabel.TabIndex = 8
        LoxLabel.Text = "Lox:"
        '
        'LoxTextBox
        '
        Me.LoxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAcftOnStationBindingSource, "Lox", True))
        Me.LoxTextBox.Location = New System.Drawing.Point(78, 139)
        Me.LoxTextBox.Name = "LoxTextBox"
        Me.LoxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LoxTextBox.TabIndex = 9
        '
        'AcftTailNumberListBox
        '
        Me.AcftTailNumberListBox.DataSource = Me.TblAcftOnStationBindingSource
        Me.AcftTailNumberListBox.DisplayMember = "AcftType"
        Me.AcftTailNumberListBox.FormattingEnabled = True
        Me.AcftTailNumberListBox.Location = New System.Drawing.Point(12, 41)
        Me.AcftTailNumberListBox.Name = "AcftTailNumberListBox"
        Me.AcftTailNumberListBox.Size = New System.Drawing.Size(150, 316)
        Me.AcftTailNumberListBox.TabIndex = 4
        Me.AcftTailNumberListBox.ValueMember = "PrimKey"
        '
        'manAcftEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 395)
        Me.Controls.Add(Me.AcftTailNumberListBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "manAcftEdit"
        Me.Text = "Aircraft Vitals Edit"
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents TblAcftOnStationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAcftOnStationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LoxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NitroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FuelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcftSpotTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AcftTailNumberListBox As System.Windows.Forms.ListBox
End Class
