Imports CrystalDecisions.CrystalReports.Engine

Public Class PLANT_REPORT
    Private Sub PLANT_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Project\WindowsApplication1\WindowsApplication1\PLANT.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class

