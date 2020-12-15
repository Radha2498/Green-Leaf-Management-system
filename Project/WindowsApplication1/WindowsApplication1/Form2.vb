Imports CrystalDecisions.CrystalReports.Engine

Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Admin\Desktop\GREEN LEAF SYSTEM\Project\WindowsApplication1\WindowsApplication1\CUSTOMER.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class

