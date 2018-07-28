<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRTMain
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
        Dim MRTInOutLabel As System.Windows.Forms.Label
        Dim MRTAcftLabel As System.Windows.Forms.Label
        Dim MRTDateTimeReqLabel As System.Windows.Forms.Label
        Dim MRTJCNLabel As System.Windows.Forms.Label
        Dim MRTRemarksLabel As System.Windows.Forms.Label
        Dim MRTDateTimeArrLabel As System.Windows.Forms.Label
        Dim MRTDateTimeCmpLabel As System.Windows.Forms.Label
        Dim MRTLocationLabel As System.Windows.Forms.Label
        Dim MRTTypeLabel As System.Windows.Forms.Label
        Dim MRTPersonSpecLabel As System.Windows.Forms.Label
        Dim MRTEquipTypeLabel As System.Windows.Forms.Label
        Dim MRTEquipPNLabel As System.Windows.Forms.Label
        Dim MRTEquipNSNLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MRTMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Button1 = New System.Windows.Forms.Button
        Me.MRTInOutCmb = New System.Windows.Forms.ListBox
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
        Me.TblMRTDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblMRTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MxDatabaseDataSet = New MXDatabase.MxDatabaseDataSet
        Me.TblMRTTableAdapter = New MXDatabase.MxDatabaseDataSetTableAdapters.tblMRTTableAdapter
        Me.TableAdapterManager = New MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
        MRTInOutLabel = New System.Windows.Forms.Label
        MRTAcftLabel = New System.Windows.Forms.Label
        MRTDateTimeReqLabel = New System.Windows.Forms.Label
        MRTJCNLabel = New System.Windows.Forms.Label
        MRTRemarksLabel = New System.Windows.Forms.Label
        MRTDateTimeArrLabel = New System.Windows.Forms.Label
        MRTDateTimeCmpLabel = New System.Windows.Forms.Label
        MRTLocationLabel = New System.Windows.Forms.Label
        MRTTypeLabel = New System.Windows.Forms.Label
        MRTPersonSpecLabel = New System.Windows.Forms.Label
        MRTEquipTypeLabel = New System.Windows.Forms.Label
        MRTEquipPNLabel = New System.Windows.Forms.Label
        MRTEquipNSNLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TblMRTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMRTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MRTInOutLabel
        '
        MRTInOutLabel.AutoSize = True
        MRTInOutLabel.Location = New System.Drawing.Point(43, 9)
        MRTInOutLabel.Name = "MRTInOutLabel"
        MRTInOutLabel.Size = New System.Drawing.Size(54, 13)
        MRTInOutLabel.TabIndex = 0
        MRTInOutLabel.Text = "In or Out?"
        '
        'MRTAcftLabel
        '
        MRTAcftLabel.AutoSize = True
        MRTAcftLabel.Location = New System.Drawing.Point(152, 28)
        MRTAcftLabel.Name = "MRTAcftLabel"
        MRTAcftLabel.Size = New System.Drawing.Size(29, 13)
        MRTAcftLabel.TabIndex = 2
        MRTAcftLabel.Text = "Acft:"
        '
        'MRTDateTimeReqLabel
        '
        MRTDateTimeReqLabel.AutoSize = True
        MRTDateTimeReqLabel.Location = New System.Drawing.Point(21, 80)
        MRTDateTimeReqLabel.Name = "MRTDateTimeReqLabel"
        MRTDateTimeReqLabel.Size = New System.Drawing.Size(107, 13)
        MRTDateTimeReqLabel.TabIndex = 4
        MRTDateTimeReqLabel.Text = "Date/Time Required:"
        '
        'MRTJCNLabel
        '
        MRTJCNLabel.AutoSize = True
        MRTJCNLabel.Location = New System.Drawing.Point(297, 28)
        MRTJCNLabel.Name = "MRTJCNLabel"
        MRTJCNLabel.Size = New System.Drawing.Size(30, 13)
        MRTJCNLabel.TabIndex = 6
        MRTJCNLabel.Text = "JCN:"
        '
        'MRTRemarksLabel
        '
        MRTRemarksLabel.AutoSize = True
        MRTRemarksLabel.Location = New System.Drawing.Point(601, 96)
        MRTRemarksLabel.Name = "MRTRemarksLabel"
        MRTRemarksLabel.Size = New System.Drawing.Size(52, 13)
        MRTRemarksLabel.TabIndex = 8
        MRTRemarksLabel.Text = "Remarks:"
        '
        'MRTDateTimeArrLabel
        '
        MRTDateTimeArrLabel.AutoSize = True
        MRTDateTimeArrLabel.Location = New System.Drawing.Point(21, 110)
        MRTDateTimeArrLabel.Name = "MRTDateTimeArrLabel"
        MRTDateTimeArrLabel.Size = New System.Drawing.Size(97, 13)
        MRTDateTimeArrLabel.TabIndex = 10
        MRTDateTimeArrLabel.Text = "Date/Time Arrived:"
        '
        'MRTDateTimeCmpLabel
        '
        MRTDateTimeCmpLabel.AutoSize = True
        MRTDateTimeCmpLabel.Location = New System.Drawing.Point(21, 140)
        MRTDateTimeCmpLabel.Name = "MRTDateTimeCmpLabel"
        MRTDateTimeCmpLabel.Size = New System.Drawing.Size(108, 13)
        MRTDateTimeCmpLabel.TabIndex = 12
        MRTDateTimeCmpLabel.Text = "Date/Time Complete:"
        '
        'MRTLocationLabel
        '
        MRTLocationLabel.AutoSize = True
        MRTLocationLabel.Location = New System.Drawing.Point(443, 28)
        MRTLocationLabel.Name = "MRTLocationLabel"
        MRTLocationLabel.Size = New System.Drawing.Size(51, 13)
        MRTLocationLabel.TabIndex = 14
        MRTLocationLabel.Text = "Location:"
        '
        'MRTTypeLabel
        '
        MRTTypeLabel.AutoSize = True
        MRTTypeLabel.Location = New System.Drawing.Point(619, 28)
        MRTTypeLabel.Name = "MRTTypeLabel"
        MRTTypeLabel.Size = New System.Drawing.Size(34, 13)
        MRTTypeLabel.TabIndex = 16
        MRTTypeLabel.Text = "Type:"
        '
        'MRTPersonSpecLabel
        '
        MRTPersonSpecLabel.AutoSize = True
        MRTPersonSpecLabel.Location = New System.Drawing.Point(275, 76)
        MRTPersonSpecLabel.Name = "MRTPersonSpecLabel"
        MRTPersonSpecLabel.Size = New System.Drawing.Size(71, 13)
        MRTPersonSpecLabel.TabIndex = 18
        MRTPersonSpecLabel.Text = "Person Spec:"
        '
        'MRTEquipTypeLabel
        '
        MRTEquipTypeLabel.AutoSize = True
        MRTEquipTypeLabel.Location = New System.Drawing.Point(282, 110)
        MRTEquipTypeLabel.Name = "MRTEquipTypeLabel"
        MRTEquipTypeLabel.Size = New System.Drawing.Size(64, 13)
        MRTEquipTypeLabel.TabIndex = 20
        MRTEquipTypeLabel.Text = "Equip Type:"
        '
        'MRTEquipPNLabel
        '
        MRTEquipPNLabel.AutoSize = True
        MRTEquipPNLabel.Location = New System.Drawing.Point(291, 143)
        MRTEquipPNLabel.Name = "MRTEquipPNLabel"
        MRTEquipPNLabel.Size = New System.Drawing.Size(55, 13)
        MRTEquipPNLabel.TabIndex = 22
        MRTEquipPNLabel.Text = "Equip PN:"
        '
        'MRTEquipNSNLabel
        '
        MRTEquipNSNLabel.AutoSize = True
        MRTEquipNSNLabel.Location = New System.Drawing.Point(282, 177)
        MRTEquipNSNLabel.Name = "MRTEquipNSNLabel"
        MRTEquipNSNLabel.Size = New System.Drawing.Size(63, 13)
        MRTEquipNSNLabel.TabIndex = 24
        MRTEquipNSNLabel.Text = "Equip NSN:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTInOutCmb)
        Me.SplitContainer1.Panel1.Controls.Add(MRTEquipNSNLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTEquipNSNTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTEquipPNLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTEquipPNTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTEquipTypeLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTEquipTypeTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTPersonSpecLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTPersonSpecTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTTypeLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTTypeTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTLocationLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTLocationTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTDateTimeCmpLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTDateTimeCmpDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(MRTDateTimeArrLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTDateTimeArrDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(MRTRemarksLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTRemarksTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTJCNLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTJCNTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTDateTimeReqLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTDateTimeReqDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(MRTAcftLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MRTAcftTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(MRTInOutLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TblMRTDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(897, 619)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Add MRT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MRTInOutCmb
        '
        Me.MRTInOutCmb.FormattingEnabled = True
        Me.MRTInOutCmb.Items.AddRange(New Object() {"In", "Out"})
        Me.MRTInOutCmb.Location = New System.Drawing.Point(22, 25)
        Me.MRTInOutCmb.Name = "MRTInOutCmb"
        Me.MRTInOutCmb.Size = New System.Drawing.Size(120, 30)
        Me.MRTInOutCmb.TabIndex = 26
        '
        'MRTEquipNSNTextBox
        '
        Me.MRTEquipNSNTextBox.Location = New System.Drawing.Point(352, 174)
        Me.MRTEquipNSNTextBox.Name = "MRTEquipNSNTextBox"
        Me.MRTEquipNSNTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTEquipNSNTextBox.TabIndex = 25
        '
        'MRTEquipPNTextBox
        '
        Me.MRTEquipPNTextBox.Location = New System.Drawing.Point(352, 139)
        Me.MRTEquipPNTextBox.Name = "MRTEquipPNTextBox"
        Me.MRTEquipPNTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTEquipPNTextBox.TabIndex = 23
        '
        'MRTEquipTypeTextBox
        '
        Me.MRTEquipTypeTextBox.Location = New System.Drawing.Point(352, 107)
        Me.MRTEquipTypeTextBox.Name = "MRTEquipTypeTextBox"
        Me.MRTEquipTypeTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTEquipTypeTextBox.TabIndex = 21
        '
        'MRTPersonSpecTextBox
        '
        Me.MRTPersonSpecTextBox.Location = New System.Drawing.Point(352, 73)
        Me.MRTPersonSpecTextBox.Name = "MRTPersonSpecTextBox"
        Me.MRTPersonSpecTextBox.Size = New System.Drawing.Size(214, 20)
        Me.MRTPersonSpecTextBox.TabIndex = 19
        '
        'MRTTypeTextBox
        '
        Me.MRTTypeTextBox.Location = New System.Drawing.Point(661, 25)
        Me.MRTTypeTextBox.Name = "MRTTypeTextBox"
        Me.MRTTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTTypeTextBox.TabIndex = 17
        '
        'MRTLocationTextBox
        '
        Me.MRTLocationTextBox.Location = New System.Drawing.Point(500, 25)
        Me.MRTLocationTextBox.Name = "MRTLocationTextBox"
        Me.MRTLocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTLocationTextBox.TabIndex = 15
        '
        'MRTDateTimeCmpDateTimePicker
        '
        Me.MRTDateTimeCmpDateTimePicker.CustomFormat = "MM/dd/yy HH:mm"
        Me.MRTDateTimeCmpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MRTDateTimeCmpDateTimePicker.Location = New System.Drawing.Point(135, 136)
        Me.MRTDateTimeCmpDateTimePicker.Name = "MRTDateTimeCmpDateTimePicker"
        Me.MRTDateTimeCmpDateTimePicker.Size = New System.Drawing.Size(125, 20)
        Me.MRTDateTimeCmpDateTimePicker.TabIndex = 13
        '
        'MRTDateTimeArrDateTimePicker
        '
        Me.MRTDateTimeArrDateTimePicker.CustomFormat = "MM/dd/yy HH:mm"
        Me.MRTDateTimeArrDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MRTDateTimeArrDateTimePicker.Location = New System.Drawing.Point(134, 106)
        Me.MRTDateTimeArrDateTimePicker.Name = "MRTDateTimeArrDateTimePicker"
        Me.MRTDateTimeArrDateTimePicker.Size = New System.Drawing.Size(126, 20)
        Me.MRTDateTimeArrDateTimePicker.TabIndex = 11
        '
        'MRTRemarksTextBox
        '
        Me.MRTRemarksTextBox.Location = New System.Drawing.Point(661, 93)
        Me.MRTRemarksTextBox.Multiline = True
        Me.MRTRemarksTextBox.Name = "MRTRemarksTextBox"
        Me.MRTRemarksTextBox.Size = New System.Drawing.Size(224, 185)
        Me.MRTRemarksTextBox.TabIndex = 9
        '
        'MRTJCNTextBox
        '
        Me.MRTJCNTextBox.Location = New System.Drawing.Point(333, 25)
        Me.MRTJCNTextBox.Name = "MRTJCNTextBox"
        Me.MRTJCNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTJCNTextBox.TabIndex = 7
        '
        'MRTDateTimeReqDateTimePicker
        '
        Me.MRTDateTimeReqDateTimePicker.CustomFormat = "MM/dd/yy HH:mm"
        Me.MRTDateTimeReqDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MRTDateTimeReqDateTimePicker.Location = New System.Drawing.Point(134, 76)
        Me.MRTDateTimeReqDateTimePicker.Name = "MRTDateTimeReqDateTimePicker"
        Me.MRTDateTimeReqDateTimePicker.Size = New System.Drawing.Size(126, 20)
        Me.MRTDateTimeReqDateTimePicker.TabIndex = 5
        '
        'MRTAcftTextBox
        '
        Me.MRTAcftTextBox.Location = New System.Drawing.Point(192, 25)
        Me.MRTAcftTextBox.Name = "MRTAcftTextBox"
        Me.MRTAcftTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MRTAcftTextBox.TabIndex = 3
        '
        'TblMRTDataGridView
        '
        Me.TblMRTDataGridView.AllowUserToAddRows = False
        Me.TblMRTDataGridView.AllowUserToDeleteRows = False
        Me.TblMRTDataGridView.AutoGenerateColumns = False
        Me.TblMRTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblMRTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.TblMRTDataGridView.DataSource = Me.TblMRTBindingSource
        Me.TblMRTDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblMRTDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblMRTDataGridView.Name = "TblMRTDataGridView"
        Me.TblMRTDataGridView.ReadOnly = True
        Me.TblMRTDataGridView.Size = New System.Drawing.Size(897, 316)
        Me.TblMRTDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TheAutoPrimKey"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TheAutoPrimKey"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MRTInOut"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MRTInOut"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MRTAcft"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MRTAcft"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MRTDateTimeReq"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MRTDateTimeReq"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MRTJCN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MRTJCN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MRTRemarks"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MRTRemarks"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MRTDateTimeArr"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MRTDateTimeArr"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MRTDateTimeCmp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MRTDateTimeCmp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MRTLocation"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MRTLocation"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MRTType"
        Me.DataGridViewTextBoxColumn10.HeaderText = "MRTType"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "MRTPersonSpec"
        Me.DataGridViewTextBoxColumn11.HeaderText = "MRTPersonSpec"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "MRTEquipType"
        Me.DataGridViewTextBoxColumn12.HeaderText = "MRTEquipType"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "MRTEquipPN"
        Me.DataGridViewTextBoxColumn13.HeaderText = "MRTEquipPN"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "MRTEquipNSN"
        Me.DataGridViewTextBoxColumn14.HeaderText = "MRTEquipNSN"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'TblMRTBindingSource
        '
        Me.TblMRTBindingSource.DataMember = "tblMRT"
        Me.TblMRTBindingSource.DataSource = Me.MxDatabaseDataSet
        '
        'MxDatabaseDataSet
        '
        Me.MxDatabaseDataSet.DataSetName = "MxDatabaseDataSet"
        Me.MxDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MRTMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 619)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MRTMain"
        Me.Text = "MRTMain"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TblMRTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMRTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MxDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MxDatabaseDataSet As MXDatabase.MxDatabaseDataSet
    Friend WithEvents TblMRTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMRTTableAdapter As MXDatabase.MxDatabaseDataSetTableAdapters.tblMRTTableAdapter
    Friend WithEvents TableAdapterManager As MXDatabase.MxDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblMRTDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MRTDateTimeArrDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MRTRemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTJCNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTDateTimeReqDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MRTAcftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTEquipNSNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTEquipPNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTEquipTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTPersonSpecTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MRTDateTimeCmpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MRTInOutCmb As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
