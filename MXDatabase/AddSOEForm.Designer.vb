<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSOEForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSOEForm))
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMDS = New System.Windows.Forms.Label
        Me.lblAcftTailNum = New System.Windows.Forms.Label
        Me.PrimKeyComboBox = New System.Windows.Forms.ComboBox
        Me.TblAutoSOEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TblSOEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSOETableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblSOETableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.TblAutoSOETableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblAutoSOETableAdapter
        CType(Me.TblAutoSOEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSOEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add SOE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(46, 66)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(573, 94)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input SOE Entry Here:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Auto SOE:"
        '
        'lblMDS
        '
        Me.lblMDS.AutoSize = True
        Me.lblMDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMDS.Location = New System.Drawing.Point(42, 9)
        Me.lblMDS.Name = "lblMDS"
        Me.lblMDS.Size = New System.Drawing.Size(48, 20)
        Me.lblMDS.TabIndex = 5
        Me.lblMDS.Text = "MDS"
        '
        'lblAcftTailNum
        '
        Me.lblAcftTailNum.AutoSize = True
        Me.lblAcftTailNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcftTailNum.Location = New System.Drawing.Point(115, 9)
        Me.lblAcftTailNum.Name = "lblAcftTailNum"
        Me.lblAcftTailNum.Size = New System.Drawing.Size(37, 20)
        Me.lblAcftTailNum.TabIndex = 6
        Me.lblAcftTailNum.Text = "Tail"
        '
        'PrimKeyComboBox
        '
        Me.PrimKeyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAutoSOEBindingSource, "PrimKey", True))
        Me.PrimKeyComboBox.DataSource = Me.TblAutoSOEBindingSource
        Me.PrimKeyComboBox.DisplayMember = "PrimKey"
        Me.PrimKeyComboBox.FormattingEnabled = True
        Me.PrimKeyComboBox.Location = New System.Drawing.Point(504, 208)
        Me.PrimKeyComboBox.Name = "PrimKeyComboBox"
        Me.PrimKeyComboBox.Size = New System.Drawing.Size(182, 21)
        Me.PrimKeyComboBox.TabIndex = 7
        Me.PrimKeyComboBox.ValueMember = "Entry"
        '
        'TblAutoSOEBindingSource
        '
        Me.TblAutoSOEBindingSource.DataMember = "tblAutoSOE"
        Me.TblAutoSOEBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSOEBindingSource
        '
        Me.TblSOEBindingSource.DataMember = "tblSOE"
        Me.TblSOEBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'TblSOETableAdapter
        '
        Me.TblSOETableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblAutoSOETableAdapter = Me.TblAutoSOETableAdapter
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
        Me.TableAdapterManager.tblSOETableAdapter = Me.TblSOETableAdapter
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
        'TblAutoSOETableAdapter
        '
        Me.TblAutoSOETableAdapter.ClearBeforeFill = True
        '
        'AddSOEForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 241)
        Me.Controls.Add(Me.PrimKeyComboBox)
        Me.Controls.Add(Me.lblAcftTailNum)
        Me.Controls.Add(Me.lblMDS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddSOEForm"
        Me.Text = "Add SOE"
        CType(Me.TblAutoSOEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSOEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Public WithEvents TblSOEBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents TblSOETableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblSOETableAdapter
    Public WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblMDS As System.Windows.Forms.Label
    Friend WithEvents lblAcftTailNum As System.Windows.Forms.Label
    Friend WithEvents TblAutoSOETableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblAutoSOETableAdapter
    Friend WithEvents TblAutoSOEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimKeyComboBox As System.Windows.Forms.ComboBox
End Class
