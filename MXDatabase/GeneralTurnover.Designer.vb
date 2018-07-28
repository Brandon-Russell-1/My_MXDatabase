<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralTurnover
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
        Dim WarningDescLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneralTurnover))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TblGeneralTurnoverDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblGeneralTurnoverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TblGeneralTurnoverTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblGeneralTurnoverTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.btnAddWeather = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.GTurnoverStartDate = New System.Windows.Forms.DateTimePicker
        Me.GEntry = New System.Windows.Forms.TextBox
        WarningDescLabel1 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TblGeneralTurnoverDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGeneralTurnoverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddWeather)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GTurnoverStartDate)
        Me.SplitContainer1.Panel1.Controls.Add(WarningDescLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GEntry)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TblGeneralTurnoverDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(755, 502)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 0
        '
        'TblGeneralTurnoverDataGridView
        '
        Me.TblGeneralTurnoverDataGridView.AllowUserToAddRows = False
        Me.TblGeneralTurnoverDataGridView.AllowUserToOrderColumns = True
        Me.TblGeneralTurnoverDataGridView.AutoGenerateColumns = False
        Me.TblGeneralTurnoverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblGeneralTurnoverDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblGeneralTurnoverDataGridView.DataSource = Me.TblGeneralTurnoverBindingSource
        Me.TblGeneralTurnoverDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblGeneralTurnoverDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblGeneralTurnoverDataGridView.Name = "TblGeneralTurnoverDataGridView"
        Me.TblGeneralTurnoverDataGridView.Size = New System.Drawing.Size(500, 502)
        Me.TblGeneralTurnoverDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TurnDateTime"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TurnDateTime"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Entry"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Entry"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TheAutoPrimKey"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TheAutoPrimKey"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'TblGeneralTurnoverBindingSource
        '
        Me.TblGeneralTurnoverBindingSource.DataMember = "tblGeneralTurnover"
        Me.TblGeneralTurnoverBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGeneralTurnoverTableAdapter
        '
        Me.TblGeneralTurnoverTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Archive_tblAcftOnStationTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblJobsTableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblSOETableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblTurnoverTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GOAircraftTableAdapter = Nothing
        Me.TableAdapterManager.GODataTableAdapter = Nothing
        Me.TableAdapterManager.GOJCNSTableAdapter = Nothing
        Me.TableAdapterManager.tblAcftOnStationTableAdapter = Nothing
        Me.TableAdapterManager.tblAutoSOETableAdapter = Nothing
        Me.TableAdapterManager.tblDevCodeListTableAdapter = Nothing
        Me.TableAdapterManager.tblErrorLogTableAdapter = Nothing
        Me.TableAdapterManager.tblFullLocationListTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralInfoTableAdapter = Nothing
        Me.TableAdapterManager.tblGeneralTurnoverTableAdapter = Me.TblGeneralTurnoverTableAdapter
        Me.TableAdapterManager.tblHazCargoListTableAdapter = Nothing
        Me.TableAdapterManager.tblJobsTableAdapter = Nothing
        Me.TableAdapterManager.tblKickOutTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetCheckTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetNotesTableAdapter = Nothing
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
        Me.TableAdapterManager.TEMPInboundTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnAddWeather
        '
        Me.btnAddWeather.Location = New System.Drawing.Point(75, 307)
        Me.btnAddWeather.Name = "btnAddWeather"
        Me.btnAddWeather.Size = New System.Drawing.Size(75, 23)
        Me.btnAddWeather.TabIndex = 21
        Me.btnAddWeather.Text = "Add"
        Me.btnAddWeather.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Date:"
        '
        'GTurnoverStartDate
        '
        Me.GTurnoverStartDate.CustomFormat = "MM/dd/yy HH:mm"
        Me.GTurnoverStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GTurnoverStartDate.Location = New System.Drawing.Point(12, 239)
        Me.GTurnoverStartDate.Name = "GTurnoverStartDate"
        Me.GTurnoverStartDate.Size = New System.Drawing.Size(200, 20)
        Me.GTurnoverStartDate.TabIndex = 17
        '
        'WarningDescLabel1
        '
        WarningDescLabel1.AutoSize = True
        WarningDescLabel1.Location = New System.Drawing.Point(12, 28)
        WarningDescLabel1.Name = "WarningDescLabel1"
        WarningDescLabel1.Size = New System.Drawing.Size(34, 13)
        WarningDescLabel1.TabIndex = 15
        WarningDescLabel1.Text = "Entry:"
        '
        'GEntry
        '
        Me.GEntry.Location = New System.Drawing.Point(12, 44)
        Me.GEntry.Multiline = True
        Me.GEntry.Name = "GEntry"
        Me.GEntry.Size = New System.Drawing.Size(217, 172)
        Me.GEntry.TabIndex = 16
        '
        'GeneralTurnover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 502)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GeneralTurnover"
        Me.Text = "GeneralTurnover"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TblGeneralTurnoverDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGeneralTurnoverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents TblGeneralTurnoverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblGeneralTurnoverTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblGeneralTurnoverTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblGeneralTurnoverDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddWeather As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GTurnoverStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GEntry As System.Windows.Forms.TextBox
End Class
