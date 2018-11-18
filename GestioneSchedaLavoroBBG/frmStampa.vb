Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmStampa



    Private Sub FrmStampa_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim pathApp As String = Application.StartupPath
        Dim reportPath As String = pathApp.Replace("\bin\Debug", "\CReportStampaSchede3Test.rpt")
        Dim cryRpt As New ReportDocument

        cryRpt.Load(reportPath)
        'cryRpt.SetDatabaseLogon("sa", "tito")
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition

        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = Convert.ToInt32(propIdIntestazioneStampa)
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("IDIntestazione")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        cryRpt.PrintOptions.PrinterName = "\\DESKTOPCADBBG\RICOH Aficio MP C2800 Manu"

        'cryRpt.PrintOptions.PrinterName = "\\FABDESKTOPBBG\RICOH Aficio MP C2800"
        'cryRpt.PrintToPrinter(1, 1, 1, 1)

        CrystalReportViewer1.ReportSource = cryRpt
        'try to use rptGP.PrintToPrinter(1, false, 0, 0);

        CrystalReportViewer1.Refresh()

    End Sub

End Class