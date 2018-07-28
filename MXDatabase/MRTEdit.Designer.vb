<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRTEdit
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
        Dim MRTEquipNSNLabel As System.Windows.Forms.Label
        Dim MRTEquipPNLabel As System.Windows.Forms.Label
        Dim MRTEquipTypeLabel As System.Windows.Forms.Label
        Dim MRTPersonSpecLabel As System.Windows.Forms.Label
        Dim MRTTypeLabel As System.Windows.Forms.Label
        Dim MRTLocationLabel As System.Windows.Forms.Label
        Dim MRTDateTimeCmpLabel As System.Windows.Forms.Label
        Dim MRTDateTimeArrLabel As System.Windows.Forms.Label
        Dim MRTRemarksLabel As System.Windows.Forms.Label
        Dim MRTJCNLabel As System.Windows.Forms.Label
        Dim MRTDateTimeReqLabel As System.Windows.Forms.Label
        Dim MRTAcftLabel As System.Windows.Forms.Label
        Dim MRTInOutLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MRTEdit))
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TblMRTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMRTTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblMRTTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.MRTEquipNSNTextBox = New System.Windows.Forms.TextBox
        Me.MRTEquipPNTextBox = New System.Windows.Forms.TextBox
        Me.MRTEquipTypeTextBox = New System.Windows.Forms.TextBox
        Me.MRTPersonSpecTextBox = New System.Windows.Forms.TextBox
        Me.MRTTypeTextBox = New System.Windows.Forms.TextBox
        Me.MRTLocationTextBox = New System.Windows.Forms.TextBox
        Me.MRTDateTimeCmpDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MRTDateTimeArrDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MRTRemarksTextBox = New System.Windows.Forms.TextBox
        Me.MRTJCNTextBox = New System.Windows.Forms.TextBox
        Me.MRTDateTimeReqDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MRTAcftTextBox = New System.Windows.Forms.TextBox
        Me.TheAutoPrimKeyTextBox = New System.Windows.Forms.TextBox
        Me.MRTInOutCmb = New System.Windows.Forms.TextBox
        MRTEquipNSNLabel = New System.Windows.Forms.Label
        MRTEquipPNLabel = New System.Windows.Forms.Label
        MRTEquipTypeLabel = New System.Windows.Forms.Label
        MRTPersonSpecLabel = New System.Windows.Forms.Label
        MRTTypeLabel = New System.Windows.Forms.Label
        MRTLocationLabel = New System.Windows.Forms.Label
        MRTDateTimeCmpLabel = New System.Windows.Forms.Label
        MRTDateTimeArrLabel = New System.Windows.Forms.Label
        MRTRemarksLabel = New System.Windows.Forms.Label
        MRTJCNLabel = New System.Windows.Forms.Label
        MRTDateTimeReqLabel = New System.Windows.Forms.Label
        MRTAcftLabel = New System.Windows.Forms.Label
        MRTInOutLabel = New System.Windows.Forms.Label
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMRTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MRTEquipNSNLabel
        '
        MRTEquipNSNLabel.AutoSize = True
        MRTEquipNSNLabel.Location = New System.Drawing.Point(271, 278)
        MRTEquipNSNLabel.Name = "MRTEquipNSNLabel"
        MRTEquipNSNLabel.Size = New System.Drawing.Size(63, 13)
        MRTEquipNSNLabel.TabIndex = 51
        MRTEquipNSNLabel.Text = "Equip NSN:"
        '
        'MRTEquipPNLabel
        '
        MRTEquipPNLabel.AutoSize = True
        MRTEquipPNLabel.Location = New System.Drawing.Point(280, 244)
        MRTEquipPNLabel.Name = "MRTEquipPNLabel"
        MRTEquipPNLabel.Size = New System.Drawing.Size(55, 13)
        MRTEquipPNLabel.TabIndex = 49
        MRTEquipPNLabel.Text = "Equip PN:"
        '
        'MRTEquipTypeLabel
        '
        MRTEquipTypeLabel.AutoSize = True
        MRTEquipTypeLabel.Location = New System.Drawing.Point(271, 211)
        MRTEquipTypeLabel.Name = "MRTEquipTypeLabel"
        MRTEquipTypeLabel.Size = New System.Drawing.Size(64, 13)
        MRTEquipTypeLabel.TabIndex = 47
        MRTEquipTypeLabel.Text = "Equip Type:"
        '
        'MRTPersonSpecLabel
        '
        MRTPersonSpecLabel.AutoSize = True
        MRTPersonSpecLabel.Location = New System.Drawing.Point(264, 177)
        MRTPersonSpecLabel.Name = "MRTPersonSpecLabel"
        MRTPersonSpecLabel.Size = New System.Drawing.Size(71, 13)
        MRTPersonSpecLabel.TabIndex = 45
        MRTPersonSpecLabel.Text = "Person Spec:"
        '
        'MRTTypeLabel
        '
        MRTTypeLabel.AutoSize = True
        MRTTypeLabel.Location = New System.Drawing.Point(608, 133)
        MRTTypeLabel.Name = "MRTTypeLabel"
        MRTTypeLabel.Size = New System.Drawing.Size(34, 13)
        MRTTypeLabel.TabIndex = 43
        MRTTypeLabel.Text = "Type:"
        '
        'MRTLocationLabel
        '
        MRTLocationLabel.AutoSize = True
        MRTLocationLabel.Location = New System.Drawing.Point(432, 133)
        MRTLocationLabel.Name = "MRTLocationLabel"
        MRTLocationLabel.Size = New System.Drawing.Size(51, 13)
        MRTLocationLabel.TabIndex = 41
        MRTLocationLabel.Text = "Location:"
        '
        'MRTDateTimeCmpLabel
        '
        MRTDateTimeCmpLabel.AutoSize = True
        MRTDateTimeCmpLabel.Location = New System.Drawing.Point(10, 241)
        MRTDateTimeCmpLabel.Name = "MRTDateTimeCmpLabel"
        MRTDateTimeCmpLabel.Size = New System.Drawing.Size(108, 13)
        MRTDateTimeCmpLabel.TabIndex = 39
        MRTDateTimeCmpLabel.Text = "Date/Time Complete:"
        '
        'MRTDateTimeArrLabel
        '
        MRTDateTimeArrLabel.AutoSize = True
        MRTDateTimeArrLabel.Location = New System.Drawing.Point(10, 211)
        MRTDateTimeArrLabel.Name = "MRTDateTimeArrLabel"
        MRTDateTimeArrLabel.Size = New System.Drawing.Size(97, 13)
        MRTDateTimeArrLabel.TabIndex = 37
        MRTDateTimeArrLabel.Text = "Date/Time Arrived:"
        '
        'MRTRemarksLabel
        '
        MRTRemarksLabel.AutoSize = True
        MRTRemarksLabel.Location = New System.Drawing.Point(590, 197)
        MRTRemarksLabel.Name = "MRTRemarksLabel"
        MRTRemarksLabel.Size = New System.Drawing.Size(52, 13)
        MRTRemarksLabel.TabIndex = 35
        MRTRemarksLabel.Text = "Remarks:"
        '
        'MRTJCNLabel
        '
        MRTJCNLabel.AutoSize = True
        MRTJCNLabel.Location = New System.Drawing.Point(286, 133)
        MRTJCNLabel.Name = "MRTJCNLabel"
        MRTJCNLabel.Size = New System.Drawing.Size(30, 13)
        MRTJCNLabel.TabIndex = 33
        MRTJCNLabel.Text = "JCN:"
        '
        'MRTDateTimeReqLabel
        '
        MRTDateTimeReqLabel.AutoSize = True
        MRTDateTimeReqLabel.Location = New System.Drawing.Point(10, 181)
        MRTDateTimeReqLabel.Name = "MRTDateTimeReqLabel"
        MRTDateTimeReqLabel.Size = New System.Drawing.Size(107, 13)
        MRTDateTimeReqLabel.TabIndex = 31
        MRTDateTimeReqLabel.Text = "Date/Time Required:"
        '
        'MRTAcftLabel
        '
        MRTAcftLabel.AutoSize = True
        MRTAcftLabel.Location = New System.Drawing.Point(141, 133)
        MRTAcftLabel.Name = "MRTAcftLabel"
        MRTAcftLabel.Size = New System.Drawing.Size(29, 13)
        MRTAcftLabel.TabIndex = 29
        MRTAcftLabel.Text = "Acft:"
        '
        'MRTInOutLabel
        '
        MRTInOutLabel.AutoSize = True
        MRTInOutLabel.Location = New System.Drawing.Point(32, 110)
        MRTInOutLabel.Name = "MRTInOutLabel"
        MRTInOutLabel.Size = New System.Drawing.Size(54, 13)
        MRTInOutLabel.TabIndex = 28
        MRTInOutLabel.Text = "In or Out?"
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMRTBindingSource
        '
        Me.TblMRTBindingSource.DataMember = "tblMRT"
        Me.TblMRTBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblMRTTableAdapter
        '
        Me.TblMRTTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ReportFilterTableAdapter = Nothing
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
        Me.TableAdapterManager.tblMorningSheetLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetNotesTableAdapter = Nothing
        Me.TableAdapterManager.tblMRTTableAdapter = Me.TblMRTTableAdapter
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Archive MRT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MRTEquipNSNTextBox
        '
        Me.MRTEquipNSNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTEquipNSN", True))
        Me.MRTEquipNSNTextBox.Location = New System.Drawing.Point(341, 275)
        Me.MRTEquipNSNTextBox.Name = "MRTEquipNSNTextBox"
        Me.MRTEquipNSNTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTEquipNSNTextBox.TabIndex = 52
        '
        'MRTEquipPNTextBox
        '
        Me.MRTEquipPNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTEquipPN", True))
        Me.MRTEquipPNTextBox.Location = New System.Drawing.Point(341, 240)
        Me.MRTEquipPNTextBox.Name = "MRTEquipPNTextBox"
        Me.MRTEquipPNTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTEquipPNTextBox.TabIndex = 50
        '
        'MRTEquipTypeTextBox
        '
        Me.MRTEquipTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTEquipType", True))
        Me.MRTEquipTypeTextBox.Location = New System.Drawing.Point(341, 208)
        Me.MRTEquipTypeTextBox.Name = "MRTEquipTypeTextBox"
        Me.MRTEquipTypeTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTEquipTypeTextBox.TabIndex = 48
        '
        'MRTPersonSpecTextBox
        '
        Me.MRTPersonSpecTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTPersonSpec", True))
        Me.MRTPersonSpecTextBox.Location = New System.Drawing.Point(341, 174)
        Me.MRTPersonSpecTextBox.Name = "MRTPersonSpecTextBox"
        Me.MRTPersonSpecTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTPersonSpecTextBox.TabIndex = 46
        '
        'MRTTypeTextBox
        '
        Me.MRTTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTType", True))
        Me.MRTTypeTextBox.Location = New System.Drawing.Point(650, 129)
        Me.MRTTypeTextBox.Name = "MRTTypeTextBox"
        Me.MRTTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTTypeTextBox.TabIndex = 44
        '
        'MRTLocationTextBox
        '
        Me.MRTLocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTLocation", True))
        Me.MRTLocationTextBox.Location = New System.Drawing.Point(489, 129)
        Me.MRTLocationTextBox.Name = "MRTLocationTextBox"
        Me.MRTLocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTLocationTextBox.TabIndex = 42
        '
        'MRTDateTimeCmpDateTimePicker
        '
        Me.MRTDateTimeCmpDateTimePicker.CustomFormat = "MM/dd/yy HH:mm"
        Me.MRTDateTimeCmpDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTDateTimeCmp", True))
        Me.MRTDateTimeCmpDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblMRTBindingSource, "MRTDateTimeCmp", True))
        Me.MRTDateTimeCmpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MRTDateTimeCmpDateTimePicker.Location = New System.Drawing.Point(124, 237)
        Me.MRTDateTimeCmpDateTimePicker.Name = "MRTDateTimeCmpDateTimePicker"
        Me.MRTDateTimeCmpDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.MRTDateTimeCmpDateTimePicker.TabIndex = 40
        '
        'MRTDateTimeArrDateTimePicker
        '
        Me.MRTDateTimeArrDateTimePicker.CustomFormat = "MM/dd/yy HH:mm"
        Me.MRTDateTimeArrDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTDateTimeArr", True))
        Me.MRTDateTimeArrDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblMRTBindingSource, "MRTDateTimeArr", True))
        Me.MRTDateTimeArrDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MRTDateTimeArrDateTimePicker.Location = New System.Drawing.Point(123, 207)
        Me.MRTDateTimeArrDateTimePicker.Name = "MRTDateTimeArrDateTimePicker"
        Me.MRTDateTimeArrDateTimePicker.Size = New System.Drawing.Size(126, 20)
        Me.MRTDateTimeArrDateTimePicker.TabIndex = 38
        '
        'MRTRemarksTextBox
        '
        Me.MRTRemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTRemarks", True))
        Me.MRTRemarksTextBox.Location = New System.Drawing.Point(648, 197)
        Me.MRTRemarksTextBox.Multiline = True
        Me.MRTRemarksTextBox.Name = "MRTRemarksTextBox"
        Me.MRTRemarksTextBox.Size = New System.Drawing.Size(224, 185)
        Me.MRTRemarksTextBox.TabIndex = 36
        '
        'MRTJCNTextBox
        '
        Me.MRTJCNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTJCN", True))
        Me.MRTJCNTextBox.Location = New System.Drawing.Point(322, 129)
        Me.MRTJCNTextBox.Name = "MRTJCNTextBox"
        Me.MRTJCNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTJCNTextBox.TabIndex = 34
        '
        'MRTDateTimeReqDateTimePicker
        '
        Me.MRTDateTimeReqDateTimePicker.CustomFormat = "MM/dd/yy HH:mm"
        Me.MRTDateTimeReqDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTDateTimeReq", True))
        Me.MRTDateTimeReqDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblMRTBindingSource, "MRTDateTimeReq", True))
        Me.MRTDateTimeReqDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MRTDateTimeReqDateTimePicker.Location = New System.Drawing.Point(123, 177)
        Me.MRTDateTimeReqDateTimePicker.Name = "MRTDateTimeReqDateTimePicker"
        Me.MRTDateTimeReqDateTimePicker.Size = New System.Drawing.Size(126, 20)
        Me.MRTDateTimeReqDateTimePicker.TabIndex = 32
        '
        'MRTAcftTextBox
        '
        Me.MRTAcftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTAcft", True))
        Me.MRTAcftTextBox.Location = New System.Drawing.Point(181, 129)
        Me.MRTAcftTextBox.Name = "MRTAcftTextBox"
        Me.MRTAcftTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTAcftTextBox.TabIndex = 30
        '
        'TheAutoPrimKeyTextBox
        '
        Me.TheAutoPrimKeyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "TheAutoPrimKey", True))
        Me.TheAutoPrimKeyTextBox.Location = New System.Drawing.Point(679, 311)
        Me.TheAutoPrimKeyTextBox.Name = "TheAutoPrimKeyTextBox"
        Me.TheAutoPrimKeyTextBox.ReadOnly = True
        Me.TheAutoPrimKeyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TheAutoPrimKeyTextBox.TabIndex = 55
        '
        'MRTInOutCmb
        '
        Me.MRTInOutCmb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMRTBindingSource, "MRTInOut", True))
        Me.MRTInOutCmb.Location = New System.Drawing.Point(18, 129)
        Me.MRTInOutCmb.Name = "MRTInOutCmb"
        Me.MRTInOutCmb.Size = New System.Drawing.Size(100, 20)
        Me.MRTInOutCmb.TabIndex = 56
        '
        'MRTEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 488)
        Me.Controls.Add(Me.MRTInOutCmb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MRTEquipNSNLabel)
        Me.Controls.Add(Me.MRTEquipNSNTextBox)
        Me.Controls.Add(MRTEquipPNLabel)
        Me.Controls.Add(Me.MRTEquipPNTextBox)
        Me.Controls.Add(MRTEquipTypeLabel)
        Me.Controls.Add(Me.MRTEquipTypeTextBox)
        Me.Controls.Add(MRTPersonSpecLabel)
        Me.Controls.Add(Me.MRTPersonSpecTextBox)
        Me.Controls.Add(MRTTypeLabel)
        Me.Controls.Add(Me.MRTTypeTextBox)
        Me.Controls.Add(MRTLocationLabel)
        Me.Controls.Add(Me.MRTLocationTextBox)
        Me.Controls.Add(MRTDateTimeCmpLabel)
        Me.Controls.Add(Me.MRTDateTimeCmpDateTimePicker)
        Me.Controls.Add(MRTDateTimeArrLabel)
        Me.Controls.Add(Me.MRTDateTimeArrDateTimePicker)
        Me.Controls.Add(MRTRemarksLabel)
        Me.Controls.Add(Me.MRTRemarksTextBox)
        Me.Controls.Add(MRTJCNLabel)
        Me.Controls.Add(Me.MRTJCNTextBox)
        Me.Controls.Add(MRTDateTimeReqLabel)
        Me.Controls.Add(Me.MRTDateTimeReqDateTimePicker)
        Me.Controls.Add(MRTAcftLabel)
        Me.Controls.Add(Me.MRTAcftTextBox)
        Me.Controls.Add(MRTInOutLabel)
        Me.Controls.Add(Me.TheAutoPrimKeyTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MRTEdit"
        Me.Text = "MRT Edit"
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMRTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents TblMRTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMRTTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblMRTTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MRTEquipNSNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTEquipPNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTEquipTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTPersonSpecTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTDateTimeCmpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MRTDateTimeArrDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MRTRemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTJCNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTDateTimeReqDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MRTAcftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TheAutoPrimKeyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTInOutCmb As System.Windows.Forms.TextBox
End Class
