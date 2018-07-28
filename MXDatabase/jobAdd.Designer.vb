<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jobAdd
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
        Dim AcftTailNumberLabel1 As System.Windows.Forms.Label
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TblAcftOnStationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAcftOnStationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
        Me.AcftTailNumberComboBox = New System.Windows.Forms.ComboBox
        Me.FKtblJobstblAcftOnStationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJobsTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblJobsTableAdapter
        Me.FKtblPOLtblAcftOnStationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPOLTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblPOLTableAdapter
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        AcftTailNumberLabel1 = New System.Windows.Forms.Label
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblJobstblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblPOLtblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.tblJobsTableAdapter = Me.TblJobsTableAdapter
        Me.TableAdapterManager.tblKickOutTableAdapter = Nothing
        Me.TableAdapterManager.tblMessageAlertTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetCheckTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetNotesTableAdapter = Nothing
        Me.TableAdapterManager.tblMRTTableAdapter = Nothing
        Me.TableAdapterManager.tblPOLTableAdapter = Me.TblPOLTableAdapter
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JCN:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "WES:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(72, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Symbol:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(107, 130)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(32, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(107, 168)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(370, 120)
        Me.TextBox4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Narr:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 78)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Note" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only use this form if the internet / A4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page is unavailable. Using this " & _
            "page" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "at any other time will result in your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "job being shown as closed automatic" & _
            "ally."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Zone:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(200, 130)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(63, 20)
        Me.TextBox5.TabIndex = 13
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
        'AcftTailNumberLabel1
        '
        AcftTailNumberLabel1.AutoSize = True
        AcftTailNumberLabel1.Location = New System.Drawing.Point(12, 15)
        AcftTailNumberLabel1.Name = "AcftTailNumberLabel1"
        AcftTailNumberLabel1.Size = New System.Drawing.Size(89, 13)
        AcftTailNumberLabel1.TabIndex = 14
        AcftTailNumberLabel1.Text = "Acft Tail Number:"
        '
        'AcftTailNumberComboBox
        '
        Me.AcftTailNumberComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAcftOnStationBindingSource, "AcftTailNumber", True))
        Me.AcftTailNumberComboBox.DataSource = Me.TblAcftOnStationBindingSource
        Me.AcftTailNumberComboBox.DisplayMember = "AcftTailNumber"
        Me.AcftTailNumberComboBox.FormattingEnabled = True
        Me.AcftTailNumberComboBox.Location = New System.Drawing.Point(107, 12)
        Me.AcftTailNumberComboBox.Name = "AcftTailNumberComboBox"
        Me.AcftTailNumberComboBox.Size = New System.Drawing.Size(156, 21)
        Me.AcftTailNumberComboBox.TabIndex = 15
        Me.AcftTailNumberComboBox.ValueMember = "PrimKey"
        '
        'FKtblJobstblAcftOnStationBindingSource
        '
        Me.FKtblJobstblAcftOnStationBindingSource.DataMember = "FK_tblJobs_tblAcftOnStation"
        Me.FKtblJobstblAcftOnStationBindingSource.DataSource = Me.TblAcftOnStationBindingSource
        '
        'TblJobsTableAdapter
        '
        Me.TblJobsTableAdapter.ClearBeforeFill = True
        '
        'FKtblPOLtblAcftOnStationBindingSource
        '
        Me.FKtblPOLtblAcftOnStationBindingSource.DataMember = "FK_tblPOL_tblAcftOnStation"
        Me.FKtblPOLtblAcftOnStationBindingSource.DataSource = Me.TblAcftOnStationBindingSource
        '
        'TblPOLTableAdapter
        '
        Me.TblPOLTableAdapter.ClearBeforeFill = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(107, 71)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(156, 20)
        Me.TextBox6.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "WUC / REFDES:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(287, 133)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Pacer"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'jobAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 330)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(AcftTailNumberLabel1)
        Me.Controls.Add(Me.AcftTailNumberComboBox)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "jobAdd"
        Me.Text = "Manual Job Entry"
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblJobstblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblPOLtblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TblAcftOnStationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
    Friend WithEvents TblAcftOnStationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblJobsTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblJobsTableAdapter
    Friend WithEvents AcftTailNumberComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FKtblJobstblAcftOnStationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPOLTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblPOLTableAdapter
    Friend WithEvents FKtblPOLtblAcftOnStationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
