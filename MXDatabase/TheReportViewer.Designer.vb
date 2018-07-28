<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheReportViewer))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.MorningSheet1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.foureightHrReport1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.G1Turnover1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.inbdSheet1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.archive48hr1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.g1TurnoverWOGENWUC1 = New MXDatabase.G1TurnoverWOGENWUC
        Me.activeAircraftReport1 = New MXDatabase.ActiveAircraftReport
        Me.g1TurnoverPacerOnly1 = New MXDatabase.G1TurnoverPacerOnly
        Me.archivedAircraftReport1 = New MXDatabase.ArchivedAircraftReport
        Me.g1NoTurnoverWOGENWUC1 = New MXDatabase.G1NoTurnoverWOGENWUC
        Me.expeditor1 = New MXDatabase.Expeditor
        Me.expeditorBlank21 = New MXDatabase.ExpeditorBlank2
        Me.fuelCurrent1 = New MXDatabase.FuelCurrent
        Me.fuelLast301 = New MXDatabase.FuelLast30
        Me.fuelAll1 = New MXDatabase.FuelAll
        Me.mrtCurrent1 = New MXDatabase.MRTCurrent
        Me.mrtLast301 = New MXDatabase.MRTLast30
        Me.mrtAll1 = New MXDatabase.MRTAll
        Me.soesearch1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.jobSearch1 = New MXDatabase.JOBSearch
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(874, 711)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'jobSearch1
        '
        Me.jobSearch1.FileName = "rassdk://JobSearch.rpt"
        '
        'TheReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 711)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TheReportViewer"
        Me.Text = "TheReportViewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MorningSheet1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents foureightHrReport1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents G1Turnover1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents g1TurnoverWOGENWUC1 As MXDatabase.G1TurnoverWOGENWUC
    Friend WithEvents activeAircraftReport1 As MXDatabase.ActiveAircraftReport
    Friend WithEvents g1TurnoverPacerOnly1 As MXDatabase.G1TurnoverPacerOnly
    Friend WithEvents inbdSheet1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents archivedAircraftReport1 As MXDatabase.ArchivedAircraftReport
    Friend WithEvents archive48hr1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents g1NoTurnoverWOGENWUC1 As MXDatabase.G1NoTurnoverWOGENWUC
    Friend WithEvents expeditor1 As MXDatabase.Expeditor
    Friend WithEvents expeditorBlank21 As MXDatabase.ExpeditorBlank2
    Friend WithEvents fuelCurrent1 As MXDatabase.FuelCurrent
    Friend WithEvents fuelLast301 As MXDatabase.FuelLast30
    Friend WithEvents fuelAll1 As MXDatabase.FuelAll
    Friend WithEvents mrtCurrent1 As MXDatabase.MRTCurrent
    Friend WithEvents mrtLast301 As MXDatabase.MRTLast30
    Friend WithEvents mrtAll1 As MXDatabase.MRTAll
    Friend WithEvents soesearch1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents jobSearch1 As MXDatabase.JOBSearch
End Class
