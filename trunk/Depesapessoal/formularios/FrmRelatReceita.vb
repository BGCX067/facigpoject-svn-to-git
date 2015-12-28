Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmRelatReceita

    Private Sub FrmRelatReceita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument

        'Verify the path to the Crystal Report's .RPT file:

        Dim strReportPath As String = Application.StartupPath & "\RelatReceitas.rpt"
        If Not IO.File.Exists(strReportPath) Then
            Throw (New Exception("Não foi possivel localizar o arquivo:" & vbCrLf & strReportPath))
        End If

        cryRpt.Load(strReportPath)
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class