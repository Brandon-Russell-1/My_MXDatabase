<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A4Browse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A4Browse))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.WebBrowserProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TblAcftOnStationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAcftOnStationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        Me.TblWebsiteHelpLocationTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblWebsiteHelpLocationTableAdapter
        Me.TblWebsiteHelpLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.StatusStrip1.SuspendLayout()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblWebsiteHelpLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(986, 740)
        Me.WebBrowser1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebBrowserProgressBar, Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 718)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(986, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'WebBrowserProgressBar
        '
        Me.WebBrowserProgressBar.Name = "WebBrowserProgressBar"
        Me.WebBrowserProgressBar.Size = New System.Drawing.Size(100, 16)
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
        Me.TableAdapterManager.Archive_tblSOETableAdapter = Nothing
        Me.TableAdapterManager.Archive_tblTurnoverTableAdapter = Nothing
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
        Me.TableAdapterManager.tblJobsTableAdapter = Nothing
        Me.TableAdapterManager.tblKickOutTableAdapter = Nothing
        Me.TableAdapterManager.tblMessageAlertTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetCheckTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetLocationTableAdapter = Nothing
        Me.TableAdapterManager.tblMorningSheetNotesTableAdapter = Nothing
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
        Me.TableAdapterManager.tblWebsiteHelpLocationTableAdapter = Me.TblWebsiteHelpLocationTableAdapter
        Me.TableAdapterManager.TEMPInboundTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblWebsiteHelpLocationTableAdapter
        '
        Me.TblWebsiteHelpLocationTableAdapter.ClearBeforeFill = True
        '
        'TblWebsiteHelpLocationBindingSource
        '
        Me.TblWebsiteHelpLocationBindingSource.DataMember = "tblWebsiteHelpLocation"
        Me.TblWebsiteHelpLocationBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'A4Browse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 740)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A4Browse"
        Me.Text = "A4 Browse"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAcftOnStationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblWebsiteHelpLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents WebBrowserProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents TblAcftOnStationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAcftOnStationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblAcftOnStationTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblWebsiteHelpLocationTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblWebsiteHelpLocationTableAdapter
    Friend WithEvents TblWebsiteHelpLocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
End Class
