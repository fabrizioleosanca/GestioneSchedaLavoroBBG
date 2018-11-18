Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Imports System.ComponentModel
Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.Common

Public Class frmStampaOrdiniAutomatico

#Region "Proprieta Classe Campi Classe"

    Public Shared factory As New DatabaseProviderFactory()
    Public Property _db As Microsoft.Practices.EnterpriseLibrary.Data.Database = factory.Create("dbSchedaLavoroBBGConnectionString")

    Public Property PropCodiceStampato As String

    Public Property PropNumRigaOrd As Integer

    Public Property IndicePerStampaAuto As Integer

    Public Property CountItemGrid As Integer



#End Region
    Public Sub New()
        InitializeComponent()
        btnCaricaArticoli.Enabled = False
    End Sub

    Private Sub frmStampaOrdiniAutomatico_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtOrdineDaStampareAuto.Text = PropOrdineStampaAutomatica
        ToolStripStatusLabelMsg.Text = "Prima di tutto Click su Bottone - Copia Nuovo Ordine In Database Per La Stampa - "
    End Sub



    Private Sub btnCaricaArticoli_Click(sender As Object, e As EventArgs) Handles btnCaricaArticoli.Click
        'TODO: questa riga di codice carica i dati nella tabella 'DbSchedaLavoroBBGDataSet.tblNuovoOrdinePerAutom'. È possibile spostarla o rimuoverla se necessario.
        TblNuovoOrdinePerAutomTableAdapter.Fill(Me.DbSchedaLavoroBBGDataSet.tblNuovoOrdinePerAutom)
        ToolStripStatusLabelMsg.Text = "Click su bottone AVVIA STAMPA AUTOMATICA"
    End Sub
    Private Sub btnCopiaOrdineNuovo_Click(sender As Object, e As EventArgs) Handles btnCopiaOrdineNuovo.Click

        btnCaricaArticoli.Enabled = True
        ToolStripStatusLabelMsg.Text = "Click su bottone - Carica Articoli Da Stampare -  Per Caricare L'ordine Nuovo da Stampare "
        Dim ret As Integer?
        Dim result As DialogResult

        'Dim NomeTabellaOrdinePerAutom As String = "tblNuovoOrdinePerAutom"
        'ret = CopiaTabellaOrdineNuovo(NomeTabellaOrdinePerAutom)
        ret = CopiaTabellaOrdineNuovo2()

        If ret <> 0 Then
            result = MessageBox.Show("Copia dei Dati del Nuovo Ordine Eseguita Con Successo !", "Copia Dati Del Nuovo Ordine in Database", MessageBoxButtons.OKCancel)

            If result = DialogResult.Cancel Then
                Exit Sub
            End If
        Else
            Exit Sub
        End If

    End Sub

    Public Function CopiaTabellaOrdineNuovo2() As Integer
        'Nome tabella Ordine Nuovo
        Dim strNomeTabellaSelDa As String = "tab" & PropOrdineStampaAutomatica & "$"
        Dim rowsAffected As Integer

        Dim strQuerySelectDa As String = "INSERT INTO tblNuovoOrdinePerAutom ([Riga],[Materiale],[Quantita],[Descrizione],[DataConsegna],[Ordine],[Prezzo],[CodicePadre],[Meccanica],[Note],[Totale])
                                          SELECT [Riga],[Materiale],[Quantita],[Descrizione],[DataConsegna],[Ordine],[Prezzo],[CodicePadre],[Meccanica],[Note],[Totale] FROM " & "[" & strNomeTabellaSelDa & "]"

        Dim ssqlconnectionstring2 As String = ConfigurationManager.ConnectionStrings("dbSchedaLavoroBBGConnectionString").ConnectionString

        Try

            RipulisciTabellaPerCopiaOrdineNuovo()

            Using InsertCommand = _db.GetSqlStringCommand(strQuerySelectDa)
                rowsAffected = _db.ExecuteNonQuery(InsertCommand)
            End Using

        Catch ex As Exception
            MessageBox.Show("Errore CopiaTabellaOrdineNuovo2: " & ex.Message)
        End Try
        Return rowsAffected

    End Function


    Public Function RipulisciTabellaPerCopiaOrdineNuovo() As Boolean

        Dim ssqlconnectionstring2 As String = ConfigurationManager.ConnectionStrings("dbSchedaLavoroBBGConnectionString").ConnectionString
        Dim Conn As SqlConnection = New SqlConnection(ssqlconnectionstring2)
        Conn.Open()

        Try

            Dim cmd As SqlCommand = New SqlCommand("DELETE FROM [tblNuovoOrdinePerAutom]", Conn)
            Dim boolDeleted As Boolean = cmd.ExecuteNonQuery > 0

            Return boolDeleted

        Catch ex As Exception
            MessageBox.Show("Errore RipulisciTabellaPerCopiaOrdineNuovo: " & ex.Message)
        End Try

    End Function

    Private Sub btnChiudi_Click(sender As Object, e As EventArgs) Handles btnChiudi.Click
        Close()
    End Sub

    Private Sub btnAvvioStampaAutomatica_Click(sender As Object, e As EventArgs) Handles btnAvvioStampaAutomatica.Click
        IndicePerStampaAuto = 0
        CountItemGrid = DataGridViewNuovoOrdineDaStampAuto.Rows.Count

        StampaRecursiveAtomatica()
    End Sub

    Public Function StampaRecursiveAtomatica()

        Dim ret As String
        Dim iRowIndex As Integer

        ToolStripStatusLabelMsg.Text = String.Empty

        If IndicePerStampaAuto <= (CountItemGrid - 1) Then

            'Seleziona la riga della griglia
            DataGridViewNuovoOrdineDaStampAuto.Rows(IndicePerStampaAuto).Selected = True

            iRowIndex = DataGridViewNuovoOrdineDaStampAuto.CurrentRow.Index

            'Parametri del codice per il report 
            PropCodiceStampato = DataGridViewNuovoOrdineDaStampAuto.Rows(DataGridViewNuovoOrdineDaStampAuto.CurrentRow.Index).Cells(1).Value.ToString
            PropNumRigaOrd = CType(DataGridViewNuovoOrdineDaStampAuto.Rows(DataGridViewNuovoOrdineDaStampAuto.CurrentRow.Index).Cells(0).Value.ToString, Integer)

            'Check se esiste
            ret = CheckItemExist(PropCodiceStampato)

            If Not String.IsNullOrEmpty(ret) Then
                lblCodiceInStampa.Text = "Sto Stampando il Codice : " & PropCodiceStampato
                Stampa(PropCodiceStampato, PropNumRigaOrd)
                'Evidenziare item griglia e poi scorrere cursore avanti

            End If

            IndicePerStampaAuto = CountItemGrid + 1

            StampaRecursiveAtomatica()
        Else
            Exit Function

        End If

    End Function


    Private Sub RigheSelezionate()
        Dim selectedRowCount As Int32 = DataGridViewNuovoOrdineDaStampAuto.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then
            For i As Integer = 0 To selectedRowCount - 1
                DataGridViewNuovoOrdineDaStampAuto.SelectedRows(i).Visible = False
            Next
        End If
    End Sub

    Public Function CheckItemExist(ByVal codice As String) As String
        Dim cmdEsiste As DbCommand
        Dim rowsAffected As String
        Try
            cmdEsiste = _db.GetStoredProcCommand("spGetCodicePerStampaAutomatica")
            _db.AddInParameter(cmdEsiste, "Materiale", DbType.String, codice)

            Using datareader As IDataReader = _db.ExecuteReader(cmdEsiste)
                While datareader.Read
                    rowsAffected = datareader("Materiale").ToString
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Errore : CheckItemExist " & ex.Message)
        End Try
        Return rowsAffected
    End Function

    Public Sub Stampa(ByVal ParamCodice As String, ByVal ParamNumRiga As Integer)

        Dim pathApp As String = Application.StartupPath
        Dim reportPath As String = pathApp.Replace("\bin\Debug", "\CReportStampaSchedeAutomatica.rpt")

        'Create an instance of the report 
        Dim cryRpt As New ReportDocument

        cryRpt.Load(reportPath)
        'cryRpt.SetDatabaseLogon("sa", "tito")

        Dim ParameterFields As ParameterFields
        Dim ParameterValues As ParameterValues

        'Connect to Viewer
        CrystalReportViewer2.ReportSource = cryRpt

        'Get the Parameters collection from the Viewer
        ParameterFields = CrystalReportViewer2.ParameterFieldInfo

        'Get Riga parameter  
        Dim RigaFld As ParameterField = ParameterFields.Item("Riga")
        'set up ParameterValues to hold the value to pass to the viewer before execution
        ParameterValues = RigaFld.CurrentValues

        Dim Riga As ParameterDiscreteValue = New ParameterDiscreteValue
        Riga.Value = ParamNumRiga
        RigaFld.CurrentValues.Add(Riga)
        ParameterValues.Add(Riga)

        'Get Parametro Codice
        Dim CodiceFld As ParameterField = ParameterFields.Item("Materiale")
        ParameterValues = CodiceFld.CurrentValues
        Dim Materiale As ParameterDiscreteValue = New ParameterDiscreteValue
        Materiale.Value = ParamCodice
        CodiceFld.CurrentValues.Add(Materiale)
        ParameterValues.Add(Materiale)

        CrystalReportViewer2.ParameterFieldInfo = ParameterFields

        ''PARAMETRO RIGA
        'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        'Dim crParameterFieldDefinition As ParameterFieldDefinition

        'Dim crParameterValues As New ParameterValues
        'Dim crParameterDiscreteValue As New ParameterDiscreteValue

        'crParameterDiscreteValue.Value = Convert.ToInt32(ParamNumRiga)

        'crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        'crParameterFieldDefinition = crParameterFieldDefinitions.Item("Riga")
        'crParameterValues = crParameterFieldDefinition.CurrentValues

        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        ''FINE PARAMETRO RIGA


        ''PARAMETRO CODICE
        'Dim CodcrParameterFieldDefinitions As ParameterFieldDefinitions
        'Dim CodcrParameterFieldDefinition As ParameterFieldDefinition
        'Dim CodcrParameterValues As New ParameterValues
        'Dim CodcrParameterDiscreteValue As New ParameterDiscreteValue

        'CodcrParameterDiscreteValue.Value = ParamCodice
        'CodcrParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        'CodcrParameterFieldDefinition = crParameterFieldDefinitions.Item("Materiale")
        'CodcrParameterValues = crParameterFieldDefinition.CurrentValues

        'CodcrParameterValues.Clear()
        'CodcrParameterValues.Add(crParameterDiscreteValue)
        'CodcrParameterFieldDefinition.ApplyCurrentValues(CodcrParameterValues)

        'FINE PARAMETRO CODICE

        cryRpt.PrintOptions.PrinterName = "\\DESKTOPCADBBG\RICOH Aficio MP C2800 Manu"

        'cryRpt.PrintOptions.PrinterName = "\\FABDESKTOPBBG\RICOH Aficio MP C2800"
        'cryRpt.PrintToPrinter(1, 1, 1, 1)

        CrystalReportViewer2.ReportSource = cryRpt
        'try to use rptGP.PrintToPrinter(1, false, 0, 0);

        CrystalReportViewer2.Refresh()

    End Sub

End Class


#Region "Codice Vecchio"
'Public Function CopiaTabellaOrdineNuovo(ByVal nomeTabella As String) As Integer

'    Dim ret As Integer = 0
'    Dim strNomeTabellaSelDa As String = "tab" & PropOrdineStampaAutomatica & "$"
'    'Seleziona i dati dalla tabella del nuovo ordine salvato da excel
'    Dim strQuerySelectDa As String = "SELECT * FROM " & "[" & strNomeTabellaSelDa & "]"

'    Dim ssqlconnectionstring As String = "Provider=SQLOLEDB;Data Source=UTENTEBBGSQL-PC\SQLEXPRESS;Initial Catalog=dbSchedaLavoroSviluppo;Persist Security Info=True;User ID=sa;Password=tito;"
'    Dim ssqlconnectionstring2 As String = ConfigurationManager.ConnectionStrings("dbSchedaLavoroBBGConnectionString").ConnectionString

'    Try

'        'esegue una stored procedure per cancellare una tabella se esiste
'        'Cancella la tabella che viene creata tutte le volte che c'è un ordine nuovo
'        Using delCommand = _db.GetStoredProcCommand("spDropSeEsiste")
'            _db.AddInParameter(delCommand, "tableName", DbType.String, nomeTabella)
'            _db.ExecuteNonQuery(delCommand)
'        End Using

'        'Esegue una stored procedure per creare una tabella 
'        Using createCommand = _db.GetStoredProcCommand("sp_tabCreate")
'            _db.AddInParameter(createCommand, "tabName", DbType.String, nomeTabella)
'            _db.ExecuteNonQuery(createCommand)
'        End Using


'        Dim oledbconn As New OleDbConnection(ssqlconnectionstring)
'        Dim oledbcmd As New OleDbCommand(strQuerySelectDa, oledbconn)
'        oledbconn.Open()

'        'serie di comandi per la bulk copy data da tabella sorgente in una tabella ricevente database sql server
'        Dim dr As OleDbDataReader = oledbcmd.ExecuteReader()
'        Dim bulkcopy As New SqlBulkCopy(ssqlconnectionstring2)
'        bulkcopy.DestinationTableName = nomeTabella

'        If Not dr Is Nothing Then
'            While dr.Read()
'                bulkcopy.WriteToServer(dr)
'            End While
'            ret = 1
'        Else
'            dr.Close()
'            oledbconn.Close()
'            Return ret
'            Exit Function
'        End If

'        dr.Close()
'        oledbconn.Close()

'        Return ret

'    Catch ex As Exception
'        MessageBox.Show("Errore CopiaTabellaOrdineNuovo: " & ex.Message)
'    End Try

'End Function
#End Region