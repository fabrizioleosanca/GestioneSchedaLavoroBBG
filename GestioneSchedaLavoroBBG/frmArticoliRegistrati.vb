Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Localization
Imports System.Globalization
Imports Telerik.WinControls.Data
Imports Telerik.WinControls
Imports System.Data.OleDb


Public Class frmArticoliRegistrati

#Region "Proprieta Classe Campi Classe"
    Public Shared factory As New DatabaseProviderFactory()
    Public Property _db As Database = factory.Create("dbSchedaLavoroBBGConnectionString")
    Public Property IndexRigaPerAggiorna As Integer
    Public Property IndiceRimaneSuRigaPostAgg As Integer

    Public collNomeFile As New Collection

    Private Delegate Sub ProgressChanged(ByVal info As UIProgress)
    Private Delegate Sub CopyError(ByVal err As UIError)

    Private OnChange As ProgressChanged
    Private OnError As CopyError

#End Region

#Region "Eventi"

    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        Me.cmbLottoNum.AutoSizeDropDownToBestFit = True
        Dim multiColumnComboElement As RadMultiColumnComboBoxElement = Me.cmbLottoNum.MultiColumnComboBoxElement
        multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        multiColumnComboElement.DropDownMinSize = New Size(550, 420)
        multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = False

        Me.cmbLottoNum.AutoFilter = True
        Me.cmbLottoNum.DisplayMember = "txtCompleto"
        Me.cmbLottoNum.ValueMember = "txtCompleto"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.cmbLottoNum.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.cmbLottoNum.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)

        Me.cmbLottoNum.DropDownStyle = RadDropDownStyle.DropDown

        Dim gridViewControl As RadGridView = Me.cmbLottoNum.EditorControl

        gridViewControl.MasterTemplate.AutoGenerateColumns = False

        gridViewControl.Columns.Add(New GridViewTextBoxColumn("materiale"))
        gridViewControl.Columns("materiale").HeaderText = "Materiale"
        gridViewControl.Columns.Add(New GridViewTextBoxColumn("numeroLotto"))
        gridViewControl.Columns("numeroLotto").HeaderText = "Numero Lotto"
        gridViewControl.Columns.Add(New GridViewTextBoxColumn("fornitore"))
        gridViewControl.Columns("fornitore").HeaderText = "Fornitore"
        gridViewControl.Columns.Add(New GridViewTextBoxColumn("numDDT"))
        gridViewControl.Columns("numDDT").HeaderText = "Numero DDT"
        gridViewControl.Columns.Add(New GridViewTextBoxColumn("txtCompleto"))
        gridViewControl.Columns("txtCompleto").IsVisible = False

        For Each column As GridViewDataColumn In Me.cmbLottoNum.MultiColumnComboBoxElement.Columns
            column.BestFit()
        Next column

        'Delegati per copia file asincrona
        AddHandler bwCopier.DoWork, AddressOf DoCopy
        AddHandler bwCopier.RunWorkerCompleted, AddressOf WorkerCompleted

        bwCopier.WorkerSupportsCancellation = True

        OnChange = AddressOf ChangeProgress
        OnError = AddressOf ErrorThrow

        UpdateUI(False)


    End Sub

    Private Sub OnTextBoxItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.cmbLottoNum.MultiColumnComboBoxElement.ShowPopup()
    End Sub


    Private Sub FrmArticoliRegistrati_Load(sender As Object, e As EventArgs) Handles Me.Load

        RadGridLocalizationProvider.CurrentProvider = New MyItalianRadGridLocalizationProvider()
        Me.DataGridViewDisegni.AutoGenerateColumns = False

        Try
            GetTestata()
            RiempiComboMateriali()
            PopolaComboLavorazioniBBG()
            PopolaComboClientiTrattamento()
            PopolaComboVari("spGetClienteVerniciatura", txtClienteVerniciatura, "ClienteVerniciatura")
            PopolaComboVari("spGetClientiHelicoil", txtClienteHelicolil, "ClienteHelicoil")
            PopolaComboVari("spGetTrattamenti", txtTrattamento, "Trattamenti")
            PopolaComboVari("spGetNoteVerniciaturaCombo", txtNoteVerniciatura, "NoteVerniciatura")
            PopolaComboVari("spNoteHelicoilCombo", txtNoteHelicoil, "NoteHelicoil")
            'popolaComboVari("spGetOperatoreCombo", txtOperatore, "Operatore")


            RiempiComboFornitori()
            RiempiComboOperatore()


            cmbLottoNum.SelectedIndex = -1

            Me.Controls.UnBold(Of GroupBox)()


        Catch ex As Exception
            MessageBox.Show("Errore Load Dati in Grid :" & ex.Message)
        End Try

    End Sub

    Private Sub CmdChiudi_Click(sender As Object, e As EventArgs) Handles cmdChiudi.Click
        Close()
    End Sub

    Private Sub CmdNuovoArtDaEsistente_Click(sender As Object, e As EventArgs) Handles cmdNuovoArtDaEsistente.Click
        Dim result As DialogResult
        Dim frmNuovaSchedaDaEsistente As New frmNuovaSchedaDaEsistente
        If Me.DataGridViewDisegni.MasterTemplate.SelectedRows.Count > 0 Then
            frmNuovaSchedaDaEsistente.Show()
        Else
            result = MessageBox.Show("Per favore selezionare una riga della griglia Schede Di Lavoro Salvate", "Messaggio di Errore", MessageBoxButtons.OK)
            If result = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

#End Region

#Region "Popola Combo"

    Public Sub RiempiComboOperatore()
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand

        'Dim connectionstring As String = "Provider=SQLOLEDB;Data Source=FABLENOVO;Initial Catalog=dbSchedaLavoroSviluppo;Integrated Security=SSPI"
        Dim connectionstring As String = "Provider=SQLOLEDB;Data Source=UTENTEBBGSQL-PC\SQLEXPRESS;Initial Catalog=dbSchedaLavoroSviluppo;User Id=sa;Password=tito;"

        Dim strSQL As String = "SELECT ID, DataInserimento, Operatore FROM tblOperatoreCombo"

        Try

            con = New OleDbConnection(connectionstring)
            con.Open()
            cmd = New OleDbCommand(strSQL, con)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim bs1 As New BindingSource()
            bs1.DataSource = dt
            Dim dr As DataRow = dt.NewRow
            dr("ID") = 0
            dt.Rows.InsertAt(dr, 0)

            txtOperatore.DisplayMember = "Operatore"
            txtOperatore.ValueMember = "ID"
            txtOperatore.DataSource = bs1
            txtOperatore.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Errore RiempiComboOperatore: " & ex.Message)
        End Try

    End Sub

    Private Sub TxtOperatore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtOperatore.SelectedIndexChanged
        PropStringOperatore = txtOperatore.Text
        PropIntOperatore = CType(txtOperatore.SelectedValue, Integer)
        txtNumOperatore.Text = CType(PropIntOperatore, String)
    End Sub

    Public Sub RiempiComboFornitori()
        Dim cmdForn As DbCommand
        Dim strSQLForn As String = "spSelezionaFornitoriTutto"
        cmdForn = _db.GetStoredProcCommand(strSQLForn)
        Using datareader As IDataReader = _db.ExecuteReader(cmdForn)
            While datareader.Read
                Me.cmbFornitore.Items.Add(datareader("NomeFornitore"))
            End While
        End Using
    End Sub

    Private Sub CmbFornitore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFornitore.SelectedIndexChanged
        Dim selFornitore As String = CType(cmbFornitore.SelectedItem, String)
        RiempiComboLottoByFornitore(selFornitore)
    End Sub

    Public Sub RiempiComboLottoByFornitore(ByVal strFornitore As String)

        Dim cmd As DbCommand
        Dim tb As New DataTable
        Dim strSQL As String = "spColonnaConcatenataLotto"
        cmd = _db.GetStoredProcCommand(strSQL)
        _db.AddInParameter(cmd, "fornitore", DbType.String, strFornitore)

        Using datareader As IDataReader = _db.ExecuteReader(cmd)
            tb.Load(datareader)
            Me.cmbLottoNum.DataSource = tb
        End Using

        cmbLottoNum.EditorControl.CurrentRow = Nothing

    End Sub


    Public Sub ClearItemMultiColumnComboBox()
        Dim rows As New List(Of GridViewRowInfo)(Me.cmbLottoNum.EditorControl.Rows)
        For Each rowInfo As GridViewRowInfo In rows
            rowInfo.Delete()
        Next
    End Sub

    Public Sub PopolaComboVari(ByVal strNomeSP As String, ByVal nomeControllo As ComboBox, ByVal nomeTab As String)
        Dim cmdGen As DbCommand
        Dim ctrlCombo As ComboBox = nomeControllo

        cmdGen = _db.GetStoredProcCommand(strNomeSP)
        Using datareader As IDataReader = _db.ExecuteReader(cmdGen)
            While datareader.Read
                ctrlCombo.Items.Add(datareader(nomeTab))
            End While
        End Using

    End Sub

    Public Sub PopolaComboLavorazioniBBG()
        Dim cmdLav As DbCommand
        Dim strSQLLavo As String = "getLavorBBG"
        cmdLav = _db.GetStoredProcCommand(strSQLLavo)
        Using datareader As IDataReader = _db.ExecuteReader(cmdLav)
            While datareader.Read
                Me.txtLavorazioniBBG.Items.Add(datareader("Lavorazioni"))
            End While
        End Using
    End Sub

    Public Sub PopolaComboClientiTrattamento()
        Dim cmdCliTratt As DbCommand
        Dim strSQLCliTratt As String = "GetClientiTrattamento"
        cmdCliTratt = _db.GetStoredProcCommand(strSQLCliTratt)
        Using datareader As IDataReader = _db.ExecuteReader(cmdCliTratt)
            While datareader.Read
                Me.txtClienteTrattamento.Items.Add(datareader("ClienteTrattamento"))
            End While
        End Using
    End Sub

    Public Sub RiempiComboMateriali()
        Dim cmdMat As DbCommand
        Dim strSQLMat As String = "getMateriali"
        cmdMat = _db.GetStoredProcCommand(strSQLMat)
        Using datareader As IDataReader = _db.ExecuteReader(cmdMat)
            While datareader.Read
                Me.txtMateriale.Items.Add(datareader("Materiale"))
            End While
        End Using
    End Sub

#End Region

#Region "Testata"

    Public Sub GetTestata()

        Try
            Dim dataColumn As GridViewDataColumn = TryCast(Me.DataGridViewDisegni.Columns("Data"), GridViewDataColumn)
            dataColumn.FormatString = "{0:dd/MM/yyyy}"
            dataColumn.FormatInfo = CultureInfo.CreateSpecificCulture("it-IT")
            Dim cmd As DbCommand = _db.GetStoredProcCommand("spSelectQueryIntestazione")
            Using datareader As IDataReader = _db.ExecuteReader(cmd)
                DataGridViewDisegni.MasterTemplate.LoadFrom(datareader)
            End Using
            DataGridViewDisegni.CurrentRow = Nothing
        Catch ex As Exception
            MessageBox.Show("Errore GetTestata :" & ex.Message)
        End Try

    End Sub

#End Region

#Region "Update Panel Info"

    Private Sub DataGridViewDisegni_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles DataGridViewDisegni.CurrentRowChanged
        'Try
        '    Dim currentRow As GridViewRowInfo
        '    currentRow = DataGridViewDisegni.CurrentRow
        '    If currentRow IsNot Nothing AndAlso Not (TypeOf currentRow Is GridViewNewRowInfo) Then
        '        'IdIntestazione salvato globalmente in propIdPerSalvaDaEsistente per usarlo in salva da esistente
        '        propIdPerSalvaDaEsistente = CType(currentRow.Cells("IDIntestazione").Value, Integer)
        '    End If
        '    UpdatePanelInfo(DataGridViewDisegni.CurrentRow)
        'Catch ex As Exception
        '    MessageBox.Show("Errore DataGridViewDisegni_CurrentRowChanged :" & ex.Message)
        'End Try
        Try
            If e.CurrentRow IsNot Nothing AndAlso Not (TypeOf e.CurrentRow Is GridViewNewRowInfo) Then
                If e.CurrentRow.Cells("CodArticolo").Value IsNot Nothing Then
                    'IdIntestazione salvato globalmente in propIdPerSalvaDaEsistente per usarlo in salva da esistente
                    propIdPerSalvaDaEsistente = CType(e.CurrentRow.Cells("IDIntestazione").Value, Integer)
                    UpdatePanelInfo(DataGridViewDisegni.CurrentRow)
                    propCodArtReg = e.CurrentRow.Cells("CodArticolo").Value.ToString
                    propNomeArticoloPerNomeDirReg = propCodArtReg.Replace("/", "-")
                    Dim pathDisegni As String = propPathDisegniApprovati + propNomeArticoloPerNomeDirReg
                    propPathDirDisegno = pathDisegni
                    PopolaGrigliaReg(pathDisegni)
                    'Ripulisce la label sul commandbar del menu 
                    CommandBarLabelSchede.Text = String.Empty
                End If
                ' propCodArtReg = Me.DataGridViewDisegni.Rows(Me.DataGridViewDisegni.CurrentRow.Index).Cells(2).Value

            End If
        Catch ex As Exception
            MessageBox.Show("Errore DataGridViewDisegni_CurrentRowChanged :" & ex.Message)
        End Try
    End Sub

    Private Sub UpdatePanelInfo(ByVal currentRow As GridViewRowInfo)

        Dim testFaiBool As Boolean
        Dim testKcBool As Boolean

        If currentRow IsNot Nothing AndAlso Not (TypeOf currentRow Is GridViewNewRowInfo) Then
            IndexRigaPerAggiorna = CType(currentRow.Cells("IDIntestazione").Value, Integer)

            Dim cmd As DbCommand = _db.GetStoredProcCommand("spGetDatiSchedeByIDIntestazione")
            _db.AddInParameter(cmd, "IDIntestazione", DbType.Int32, IndexRigaPerAggiorna)

            Using datareader As IDataReader = _db.ExecuteReader(cmd)
                While datareader.Read
                    propIdIntestazione = datareader("IDIntestazione")
                    txtCodiceOrdine.Text = datareader("NumOrdine").ToString
                    txtCodiceArticolo.Text = datareader("CodArticolo").ToString
                    propDataReport = Convert(datareader("Data").ToString)
                    dtpDataConsegna.Value = propDataReport
                    txtMateriale.Text = datareader("Materiale")
                    txtNumeroRiga.Text = CType(datareader("RigaOrdNum"), String)
                    txtNumeroPezziOrd.Text = CType(datareader("NumPezzi"), String)
                    txtNote.Text = datareader("Note")
                    cmbFornitore.Text = CType(datareader("Fornitori"), String)
                    cmbLottoNum.Text = CType(datareader("Lotto"), String)
                    txtLavorazioniBBG.Text = datareader("LavorazioneBBG")
                    txtOperatore.Text = datareader("Operatore")
                    txtTrattamento.Text = datareader("Trattamento")
                    txtClienteTrattamento.Text = datareader("ClienteTrattamento")
                    txtClienteVerniciatura.Text = datareader("ClienteVerniciatura")
                    txtNoteVerniciatura.Text = datareader("NoteVerniciatura")
                    txtClienteHelicolil.Text = datareader("ClienteHelicoil")
                    txtNoteHelicoil.Text = datareader("NoteHelicoil")
                    txtAltreLavorazioni.Text = datareader("AltreLavorazioni")
                    txtNoteAltreLavorazioni.Text = datareader("NoteAltreLavorazioni")
                    testFaiBool = CType(datareader("Fai"), Boolean)
                    testKcBool = CType(datareader("Kc"), Boolean)

                    If testFaiBool = False Then
                        chkFAI.Checked = False
                    Else
                        chkFAI.Checked = True
                    End If

                    If testKcBool = False Then
                        chkKC.Checked = False
                    Else
                        chkKC.Checked = True
                    End If

                End While
            End Using
        Else
            propIdIntestazione = 0
            txtCodiceOrdine.Text = String.Empty
            txtCodiceArticolo.Text = String.Empty
            dtpDataConsegna.Value = Today
            txtMateriale.Text = String.Empty
            txtNumeroRiga.Text = String.Empty
            txtNumeroPezziOrd.Text = String.Empty
            txtNote.Text = String.Empty
            cmbFornitore.Text = String.Empty
            cmbLottoNum.Text = String.Empty
            txtLavorazioniBBG.Text = String.Empty
            txtOperatore.Text = String.Empty
            txtTrattamento.Text = String.Empty
            txtClienteTrattamento.Text = String.Empty
            txtClienteVerniciatura.Text = String.Empty
            txtClienteHelicolil.Text = String.Empty
            txtNoteHelicoil.Text = String.Empty
            txtAltreLavorazioni.Text = String.Empty
            txtNoteAltreLavorazioni.Text = String.Empty
            chkFAI.Checked = False
            chkKC.Checked = False
        End If
    End Sub

#End Region

#Region "Update"

    Private Sub BtnAggiornaScheda_Click(sender As Object, e As EventArgs) Handles btnAggiornaScheda.Click

        Dim result As DialogResult
        Dim intAggiornaTestataBusinessLayer As Nullable(Of Integer)
        Dim intLavorazioniBusinnesLayer As Nullable(Of Integer)
        Dim intAggiornaTabInteraPerStampaBusinessLayer As Nullable(Of Integer)

        Try
            intAggiornaTestataBusinessLayer = AggiornaTestataBusinessLayer(propIdIntestazione)
            intLavorazioniBusinnesLayer = AggiornaLavorazioniBusinessLayer(propIdIntestazione)
            intAggiornaTabInteraPerStampaBusinessLayer = AggiornaTabInteraPerStampaBusinessLayer(propIdIntestazione)

            If (Not intAggiornaTestataBusinessLayer Is Nothing) Or (Not intLavorazioniBusinnesLayer Is Nothing) Or (Not intAggiornaTabInteraPerStampaBusinessLayer Is Nothing) Then
                GetTestata()
                'Torna sulla riga selezionata
                DataGridViewDisegni.CurrentRow = DataGridViewDisegni.Rows(IndiceRimaneSuRigaPostAgg)
                DataGridViewDisegni.CurrentRow.IsSelected = True
                result = MessageBox.Show("Scheda Lavorazione Aggiornata Con Successo", "Aggiornamento Scheda Lavorazione in Database", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    Exit Sub
                End If
            Else
                Exit Sub
            End If


        Catch ex As Exception
            MessageBox.Show("Errore btnAggiorna_Click :" & ex.Message)
        End Try

    End Sub

    Public Function AggiornaTabInteraPerStampaBusinessLayer(ByVal id_intestazione As Integer) As Integer

        Dim numOrd As String
        Dim codArt As String
        Dim data As Date
        Dim materiale As String
        Dim rigaOrdNum As Integer
        Dim numPezzi As Integer
        Dim noteTest As String
        Dim fornitori As String
        Dim lotto As String
        Dim lavorazioneBBG As String
        ' Dim operatore As String
        Dim trattamento As String
        Dim clienteTrattamento As String
        Dim clienteVerniciatura As String
        Dim noteVerniciatura As String
        Dim clienteHelicoil As String
        Dim noteHelicoil As String
        Dim altreLavorazioni As String
        Dim noteAltreLavorazioni As String
        Dim boolFai As Boolean
        Dim boolKc As Boolean

        Try

            Dim iDIntestazione As Integer = id_intestazione
            numOrd = txtCodiceOrdine.Text
            codArt = txtCodiceArticolo.Text
            data = Convert(dtpDataConsegna.Value)
            materiale = txtMateriale.Text
            rigaOrdNum = CType(txtNumeroRiga.Text, Integer)
            numPezzi = CType(txtNumeroPezziOrd.Text, Integer)
            noteTest = txtNote.Text
            fornitori = CType(cmbFornitore.Text, String)
            lotto = CType(cmbLottoNum.Text, String)
            lavorazioneBBG = txtLavorazioniBBG.Text
            ' operatore = txtOperatore.Text
            trattamento = txtTrattamento.Text
            clienteTrattamento = txtClienteTrattamento.Text
            clienteVerniciatura = txtClienteVerniciatura.Text
            noteVerniciatura = txtNoteVerniciatura.Text
            clienteHelicoil = txtClienteHelicolil.Text
            noteHelicoil = txtNoteHelicoil.Text
            altreLavorazioni = txtAltreLavorazioni.Text
            noteAltreLavorazioni = txtNoteAltreLavorazioni.Text
            boolFai = chkFAI.CheckState
            boolKc = chkKC.CheckState


            Dim ret As Nullable(Of Integer) = AggiornaTabInteraStampa(iDIntestazione, numOrd, codArt, data, materiale,
                                              rigaOrdNum, numPezzi, noteTest, fornitori, lotto, lavorazioneBBG,
                                               PropStringOperatore, PropIntOperatore, trattamento, clienteTrattamento, clienteVerniciatura,
                                              noteVerniciatura, clienteHelicoil, noteHelicoil, altreLavorazioni, noteAltreLavorazioni, boolFai, boolKc)


            If Not ret Is Nothing Then
                AggiornaTabInteraPerStampaBusinessLayer = ret
            End If

        Catch ex As Exception
            MessageBox.Show("Errore AggiornaTabInteraPerStampaBusinessLayer :" & ex.Message)
        End Try

        Return AggiornaTabInteraPerStampaBusinessLayer

    End Function

    Public Function AggiornaTabInteraStampa(ByVal idIntestazione As Integer, ByVal numOrdine As String,
                                            ByVal codArticolo As String, ByVal data As Date, ByVal materiale As String,
                                            ByVal rigaOrdNum As Integer, ByVal numPezzi As Integer, ByVal note As String, ByVal fornitori As String, ByVal lotto As String, ByVal lavorazioneBBG As String,
                                            ByVal operatore As String, ByVal numeroOperatore As Integer,
                                            ByVal trattamento As String, ByVal clienteTrattamento As String,
                                            ByVal clienteVerniciatura As String, ByVal noteVerniciatura As String,
                                            ByVal clienteHelicoil As String, ByVal noteHelicoil As String, ByVal altreLavorazioni As String,
                                            ByVal noteAltreLavorazioni As String, ByVal boolFai As Boolean, ByVal boolKc As Boolean) As Integer

        Dim rowsAffected As Integer
        Dim dataShorth As Date = Convert(data)

        Dim updateCommand As DbCommand = Nothing
        updateCommand = _db.GetStoredProcCommand("spUpdateQueryTabCompletaPerStampa")

        Try

            _db.AddInParameter(updateCommand, "IDIntestazione", DbType.Int32, idIntestazione)
            _db.AddInParameter(updateCommand, "NumOrdine", DbType.String, numOrdine)
            _db.AddInParameter(updateCommand, "CodArticolo", DbType.String, codArticolo)
            _db.AddInParameter(updateCommand, "Data", DbType.Date, dataShorth)
            _db.AddInParameter(updateCommand, "Materiale", DbType.String, materiale)
            _db.AddInParameter(updateCommand, "RigaOrdNum", DbType.Int32, rigaOrdNum)
            _db.AddInParameter(updateCommand, "NumPezzi", DbType.Int32, numPezzi)
            _db.AddInParameter(updateCommand, "Note", DbType.String, note)
            _db.AddInParameter(updateCommand, "Fornitori", DbType.String, fornitori)
            _db.AddInParameter(updateCommand, "Lotto", DbType.String, lotto)
            _db.AddInParameter(updateCommand, "LavorazioneBBG", DbType.String, lavorazioneBBG)
            _db.AddInParameter(updateCommand, "Operatore", DbType.String, operatore)
            _db.AddInParameter(updateCommand, "NumOperatore", DbType.Int32, numeroOperatore)
            _db.AddInParameter(updateCommand, "Trattamento", DbType.String, trattamento)
            _db.AddInParameter(updateCommand, "ClienteTrattamento", DbType.String, clienteTrattamento)
            _db.AddInParameter(updateCommand, "ClienteVerniciatura", DbType.String, clienteVerniciatura)
            _db.AddInParameter(updateCommand, "NoteVerniciatura", DbType.String, noteVerniciatura)
            _db.AddInParameter(updateCommand, "ClienteHelicoil", DbType.String, clienteHelicoil)
            _db.AddInParameter(updateCommand, "NoteHelicoil", DbType.String, noteHelicoil)
            _db.AddInParameter(updateCommand, "AltreLavorazioni", DbType.String, altreLavorazioni)
            _db.AddInParameter(updateCommand, "NoteAltreLavorazioni", DbType.String, noteAltreLavorazioni)
            _db.AddInParameter(updateCommand, "Fai", DbType.Boolean, boolFai)
            _db.AddInParameter(updateCommand, "Kc", DbType.Boolean, boolKc)


            rowsAffected = _db.ExecuteNonQuery(updateCommand)


        Catch ex As Exception
            MessageBox.Show("Errore AggiornaTabInteraPerStampa: " & ex.Message)
        End Try

        Return rowsAffected

    End Function



    Public Function AggiornaTestataBusinessLayer(ByVal id_intestazione As Integer) As Integer

        Dim numOrd As String
        Dim codArt As String
        Dim data As Date
        Dim materiale As String
        Dim rigaOrdNum As Integer
        Dim numPezzi As Integer
        Dim noteTest As String
        Dim fornitori As String
        Dim lotto As String

        Try
            Dim iDIntestazione As Integer = id_intestazione
            numOrd = txtCodiceOrdine.Text
            codArt = txtCodiceArticolo.Text
            data = Convert(dtpDataConsegna.Value)
            materiale = txtMateriale.Text
            rigaOrdNum = CType(txtNumeroRiga.Text, Integer)
            numPezzi = CType(txtNumeroPezziOrd.Text, Integer)
            noteTest = txtNote.Text
            fornitori = cmbFornitore.Text
            lotto = cmbLottoNum.Text


            Dim ret As Nullable(Of Integer) = AggiornaTestataSchede(iDIntestazione, numOrd, codArt, data, materiale, rigaOrdNum, numPezzi, noteTest, fornitori, lotto)

            If Not ret Is Nothing Then
                AggiornaTestataBusinessLayer = ret
            End If

        Catch ex As Exception
            MessageBox.Show("Errore AggiornaTestataBusinessLayer :" & ex.Message)
        End Try

        Return AggiornaTestataBusinessLayer

    End Function

    Public Function AggiornaTestataSchede(ByVal idIntestazione As Integer, ByVal numOrdine As String,
                                          ByVal codArticolo As String, ByVal data As Date, ByVal materiale As String,
                                          ByVal rigaOrdNum As Integer, ByVal numPezzi As Integer, ByVal note As String, ByVal fornitore As String, ByVal lotto As String) As Integer

        Dim rowsAffected As Integer
        Dim dataShorth As Date = Convert(data)

        Dim updateCommand As DbCommand = Nothing
        updateCommand = _db.GetStoredProcCommand("spUpdateQueryIntestazioneSchede")

        Try
            _db.AddInParameter(updateCommand, "IDIntestazione", DbType.Int32, idIntestazione)
            _db.AddInParameter(updateCommand, "NumOrdine", DbType.String, numOrdine)
            _db.AddInParameter(updateCommand, "CodArticolo", DbType.String, codArticolo)
            _db.AddInParameter(updateCommand, "Data", DbType.Date, dataShorth)
            _db.AddInParameter(updateCommand, "Materiale", DbType.String, materiale)
            _db.AddInParameter(updateCommand, "RigaOrdNum", DbType.Int32, rigaOrdNum)
            _db.AddInParameter(updateCommand, "NumPezzi", DbType.Int32, numPezzi)
            _db.AddInParameter(updateCommand, "Note", DbType.String, note)
            _db.AddInParameter(updateCommand, "Fornitori", DbType.String, fornitore)
            _db.AddInParameter(updateCommand, "Lotto", DbType.String, lotto)


            rowsAffected = _db.ExecuteNonQuery(updateCommand)

        Catch ex As Exception
            MessageBox.Show("Errore AggiornaTestataSchede: " & ex.Message)
        End Try

        Return rowsAffected

    End Function

    Public Function AggiornaLavorazioniBusinessLayer(ByVal id_intestazione As Integer) As Integer

        Dim codArticolo As String
        Dim lavorazioneBBG As String
        'Dim operatore As String
        Dim trattamento As String
        Dim clienteTrattamento As String
        Dim clienteVerniciatura As String
        Dim noteVerniciatura As String
        Dim clienteHelicoil As String
        Dim noteHelicoil As String
        Dim altreLavorazioni As String
        Dim noteAltreLavorazioni As String
        Dim boolFai As Boolean
        Dim boolKc As Boolean


        Try
            Dim iDIntestazione As Integer = id_intestazione

            codArticolo = txtCodiceArticolo.Text
            lavorazioneBBG = txtLavorazioniBBG.Text
            'operatore = txtOperatore.Text
            trattamento = txtTrattamento.Text
            clienteTrattamento = txtClienteTrattamento.Text
            clienteVerniciatura = txtClienteVerniciatura.Text
            noteVerniciatura = txtNoteVerniciatura.Text
            clienteHelicoil = txtClienteHelicolil.Text
            noteHelicoil = txtNoteHelicoil.Text
            altreLavorazioni = txtAltreLavorazioni.Text
            noteAltreLavorazioni = txtNoteAltreLavorazioni.Text
            boolFai = chkFAI.Checked
            boolKc = chkKC.Checked

            Dim ret As Nullable(Of Integer) = AggiornaLavorazioni(iDIntestazione, codArticolo, lavorazioneBBG,
                                              PropStringOperatore, PropIntOperatore, trattamento, clienteTrattamento, clienteVerniciatura,
                                              noteVerniciatura, clienteHelicoil, noteHelicoil, altreLavorazioni, noteAltreLavorazioni, boolFai, boolKc)


            If Not ret Is Nothing Then
                AggiornaLavorazioniBusinessLayer = ret
            End If

        Catch ex As Exception
            MessageBox.Show("Errore AggiornaLavorazioniBusinessLayer: " & ex.Message)
        End Try

        Return AggiornaLavorazioniBusinessLayer

    End Function

    Public Function AggiornaLavorazioni(ByVal idIntestazione As Integer, ByVal codArticolo As String,
                                        ByVal lavorazioneBBG As String, ByVal operatore As String, ByVal numeroOperatore As Integer,
                                        ByVal trattamento As String, ByVal clienteTrattamento As String,
                                        ByVal clienteVerniciatura As String, ByVal noteVerniciatura As String,
                                        ByVal clienteHelicoil As String, ByVal noteHelicoil As String, ByVal altreLavorazioni As String, ByVal noteAltreLavorazioni As String, ByVal boolFai As Boolean, ByVal boolKc As Boolean) As Integer


        Dim rowsAffected As Integer

        Dim updateCommand As DbCommand = Nothing
        updateCommand = _db.GetStoredProcCommand("spUpdateQueryLavorazioni")

        Try

            _db.AddInParameter(updateCommand, "IDIntestazione", DbType.Int32, idIntestazione)
            _db.AddInParameter(updateCommand, "CodiceArticolo", DbType.String, codArticolo)
            _db.AddInParameter(updateCommand, "LavorazioneBBG", DbType.String, lavorazioneBBG)
            _db.AddInParameter(updateCommand, "Operatore", DbType.String, operatore)
            _db.AddInParameter(updateCommand, "NumeroOperatore", DbType.Int32, numeroOperatore)
            _db.AddInParameter(updateCommand, "Trattamento", DbType.String, trattamento)
            _db.AddInParameter(updateCommand, "ClienteTrattamento", DbType.String, clienteTrattamento)
            _db.AddInParameter(updateCommand, "ClienteVerniciatura", DbType.String, clienteVerniciatura)
            _db.AddInParameter(updateCommand, "NoteVerniciatura", DbType.String, noteVerniciatura)
            _db.AddInParameter(updateCommand, "ClienteHelicoil", DbType.String, clienteHelicoil)
            _db.AddInParameter(updateCommand, "NoteHelicoil", DbType.String, noteHelicoil)
            _db.AddInParameter(updateCommand, "AltreLavorazioni", DbType.String, altreLavorazioni)
            _db.AddInParameter(updateCommand, "NoteAltreLavorazioni", DbType.String, noteAltreLavorazioni)
            _db.AddInParameter(updateCommand, "Fai", DbType.Boolean, boolFai)
            _db.AddInParameter(updateCommand, "Kc", DbType.Boolean, boolKc)



            rowsAffected = _db.ExecuteNonQuery(updateCommand)

        Catch ex As Exception
            MessageBox.Show("Errore AggiornaLavorazioni: " & ex.Message)
        End Try

        Return rowsAffected

    End Function

#End Region

#Region "Stampa"

    Private Sub CmdAnteprimaDiStampaScheda_Click(sender As Object, e As EventArgs) Handles cmdAnteprimaDiStampaScheda.Click
        CommandBarLabelSchede.Text = "Sto Caricando i Dati : Attendere Prego ......"
        GetAndInsertPerStampa()
        Dim frmStampa As New frmStampa
        frmStampa.Show()
        CommandBarLabelSchede.Text = String.Empty
    End Sub

    Private Sub GetAndInsertPerStampa()
        Try
            Dim lastRow As GridViewRowInfo = DataGridViewDisegni.Rows(DataGridViewDisegni.Rows.Count - 1)
            For Each rowInfo As GridViewRowInfo In DataGridViewDisegni.Rows
                'Loop sulle righe selezionate griglia
                If rowInfo.IsSelected Then
                    rowInfo.EnsureVisible()
                    'Legge Id della riga selezionata nella griglia
                    propIdIntestazioneStampa = rowInfo.Cells("IDIntestazione").Value
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Errore GetAndInsertPerStampa :" & ex.Message)
        End Try
    End Sub



#End Region

#Region "Utilita"

    Private Function GetSafeString(ByVal value As Object) As String
        If value Is Nothing Then
            Return String.Empty
        End If
        Return value.ToString()
    End Function

    Public Function Convert(ByVal value As Date) As Date
        Dim DateValue As DateTime = CType(value, DateTime)
        Return DateValue.ToShortDateString
    End Function



    Public Function Converti(ByVal value As Date) As Date
        Dim DateValue As DateTime = CType(value, DateTime)
        Return DateValue.ToShortDateString
    End Function


#End Region

#Region "Cancella Scheda"


    Private Sub CmdEliminaScheda_Click(sender As Object, e As EventArgs) Handles cmdEliminaScheda.Click

        'propIdIntestazione = Me.DataGridViewDisegni.Rows(Me.DataGridViewDisegni.CurrentRow.Index).Cells(0).Value

        propIdIntestazione = DataGridViewDisegni.ChildRows(DataGridViewDisegni.CurrentRow.Index).Cells(0).Value

        Dim result As DialogResult
        If (Not propIdIntestazione = Nothing) Then

            If DataGridViewDisegni.SelectedRows.Count > 0 Then

                result = MessageBox.Show(" Sei sicuro di voler eliminare la Scheda N° : " & propIdIntestazione & " ? ", "Elimina Scheda Lavorazioni in Database", MessageBoxButtons.OKCancel)
                boolReturnMain = False
                If result = DialogResult.Cancel Then
                    Exit Sub
                End If
                If result = DialogResult.OK Then
                    EliminaTestataByIdIntestazione(propIdIntestazione)
                    EliminaLavorazioniByIdIntestazione(propIdIntestazione)
                    EliminaSchedaInteraByIdIntestazione(propIdIntestazione)
                    GetTestata()
                Else
                    Exit Sub
                End If

            End If

        Else
            MessageBox.Show("Per Favore Selezionare una riga !!")
        End If

    End Sub

    Public Function EliminaTestataByIdIntestazione(ByVal idIntestazione As Integer) As Integer

        Dim deleteCommand As DbCommand = Nothing
        Dim rowsAffectedTest As Integer

        Try
            deleteCommand = _db.GetStoredProcCommand("spDeleteIntestazioneByIdIntestazione")
            _db.AddInParameter(deleteCommand, "IDIntestazione", DbType.Int32, idIntestazione)
            rowsAffectedTest = _db.ExecuteNonQuery(deleteCommand)

        Catch ex As Exception
            MessageBox.Show("Errore EliminaTestataByIdIntestazione : " & ex.Message)
        End Try
        Return rowsAffectedTest
    End Function

    Public Function EliminaLavorazioniByIdIntestazione(ByVal idIntestazione As Integer) As Integer
        Dim deleteCommand As DbCommand = Nothing
        Dim rowsAffectedLavo As Integer
        Try
            deleteCommand = _db.GetStoredProcCommand("spDeleteLavorazioniByIdIntestazione")
            _db.AddInParameter(deleteCommand, "IDIntestazione", DbType.Int32, idIntestazione)
            rowsAffectedLavo = _db.ExecuteNonQuery(deleteCommand)

        Catch ex As Exception
            MessageBox.Show("Errore EliminaLavorazioniByIdIntestazione : " & ex.Message)
        End Try
        Return rowsAffectedLavo

    End Function

    Public Function EliminaSchedaInteraByIdIntestazione(ByVal idIntestazione As Integer) As Integer
        Dim deleteCommand As DbCommand = Nothing
        Dim rowsAffectedIntera As Integer
        Try
            deleteCommand = _db.GetStoredProcCommand("spDeleteSchedaInteraByIdIntestazione")
            _db.AddInParameter(deleteCommand, "IDIntestazione", DbType.Int32, idIntestazione)
            rowsAffectedIntera = _db.ExecuteNonQuery(deleteCommand)

        Catch ex As Exception
            MessageBox.Show("Errore EliminaSchedaInteraByIdIntestazione : " & ex.Message)
        End Try
        Return rowsAffectedIntera

    End Function


#End Region

#Region "GridView"

    'Private Sub DataGridViewDisegni_CellClick(sender As Object, e As GridViewCellEventArgs) Handles DataGridViewDisegni.CellClick
    '    'Griglia Schede
    '    If Me.DataGridViewDisegni.MasterTemplate.SelectedRows.Count > 0 Then
    '        propCodArtReg = Me.DataGridViewDisegni.Rows(Me.DataGridViewDisegni.CurrentRow.Index).Cells(2).Value
    '        propNomeArticoloPerNomeDirReg = propCodArtReg.Replace("/", "-")
    '        Dim pathDisegni As String = propPathDisegniApprovati + propNomeArticoloPerNomeDirReg
    '        propPathDirDisegno = pathDisegni
    '        popolaGrigliaReg(pathDisegni)
    '    End If
    'End Sub

    Public Sub PopolaGrigliaReg(ByVal pathFile As String)

        Dim table As New DataTable()

        Try
            Dim files As [String]() = Directory.GetFiles(pathFile)
            table.Columns.Add("NomeFileSchede")
            table.Columns.Add("PercorsoFileSchede")

            For i As Integer = 0 To files.Length - 1
                Dim file As New FileInfo(files(i))
                table.Rows.Add(file.Name, file.FullName)
            Next

            gridViewDisegni.DataSource = table

        Catch ex As ArgumentException
            ''Ripulisce la griglia disegni al cambio articolo
            For j = gridViewDisegni.RowCount - 1 To 0 Step -1
                gridViewDisegni.Rows.RemoveAt(j)
            Next
            ' MessageBox.Show("Il Nome Del File Non è Stato Trovato. CLICK OK PER ANDARE AVANTI SENZA PROBLEMI! : " + ex.Message)
        Catch ex As FileNotFoundException
            ''Ripulisce la griglia disegni al cambio articolo
            For j = gridViewDisegni.RowCount - 1 To 0 Step -1
                gridViewDisegni.Rows.RemoveAt(j)
            Next
            ' MessageBox.Show("Il File Ricercato Non è Stato Trovato . CLICK OK PER ANDARE AVANTI SENZA PROBLEMI!: " + ex.Message)
        Catch ex As DirectoryNotFoundException
            ''Ripulisce la griglia disegni al cambio articolo
            For j = gridViewDisegni.RowCount - 1 To 0 Step -1
                gridViewDisegni.Rows.RemoveAt(j)
            Next
            '  MessageBox.Show("Il File Ricercato Non è Stato Trovato . CLICK OK PER ANDARE AVANTI SENZA PROBLEMI! : " + ex.Message)
        End Try

    End Sub


    Private Sub GridViewDisegni_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridViewDisegni.CellContentClick

        'Griglia Disegni
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim nomeFile As String
        Dim strEstension As String
        Dim pathCompleto As String

        Try
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'TODO - Button Clicked - Execute Code Here
                nomeFile = CType(gridViewDisegni.CurrentRow.Cells(1).Value, String)
                strEstension = Path.GetExtension(nomeFile)
                pathCompleto = propPathDirDisegno + "\" + nomeFile

                'Se il disegno è PDF apre il disegno
                If strEstension = ".pdf" Then
                    Dim frmViewer As New FrmPDF(pathCompleto)
                    frmViewer.Show()
                End If

                'Se il disegno è ZIP apre la directory
                If strEstension = ".zip" Then
                    Process.Start("explorer.exe", pathCompleto)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Errore GridViewDisegni : " + ex.Message)
        End Try
    End Sub



#End Region

#Region "Salva Disegni"


    Private Sub CmdSalvaDisegni_Click(sender As Object, e As EventArgs) Handles cmdSalvaDisegni.Click

        Dim docopy As Boolean = cmdSalvaDisegni.Text = "Copia Disegni"
        UpdateUI(docopy)
        If (docopy) Then
            bwCopier.RunWorkerAsync()
        Else
            bwCopier.CancelAsync()
        End If

    End Sub

    Private Sub UpdateUI(ByVal docopy As Boolean)

        ToolStripStatusLabel1.Visible = docopy
        ToolStripProgressBar1.Visible = docopy

        If docopy Then
            cmdSalvaDisegni.Text = "Cancella Copia Disegni"
        Else
            cmdSalvaDisegni.Text = "Copia Disegni"
        End If

        ToolStripStatusLabel1.Text = "Inizio Copia..."
        ToolStripProgressBar1.Value = 0

    End Sub

    Private Sub DoCopy(ByVal sender As Object, ByVal e As DoWorkEventArgs)

        'Codice Articolo per ricerca disegni
        propCodiceArticolo = txtCodiceArticolo.Text

        propNomeArticoloPerNomeDir = propCodiceArticolo.Replace("/", "-")
        propCodiceArticoloPerRicerca = propCodiceArticolo.Replace("/", "-")

        Dim strPathArticolo As String = propPathDisegniApprovati & propNomeArticoloPerNomeDir

        'Array file articoli meccanica e codicepadre da ricercare
        Dim arrFile As String() = {propCodiceArticoloPerRicerca}

        'Controlla se esiste la meccanica se esiste aggiunge all'array
        If Not (propMeccanica = String.Empty) Then
            If Not (propMeccanica = propCodiceArticolo) Then
                propMeccanicaPerRicerca = propMeccanica.Replace("/", "-")
                Array.Resize(arrFile, arrFile.Length + 1)
                arrFile(arrFile.Length - 1) = propMeccanicaPerRicerca
            End If
        End If

        'Percorso dove vengono copiati i files
        propPathDirCopiaFile = strPathArticolo

        'Oggetto directory file copiati
        Dim dirCopiaFile As DirectoryInfo = New DirectoryInfo(propPathDirCopiaFile)

        'Crea la directory dove verranno copiati i disegni se non esiste gia
        If Directory.Exists(dirCopiaFile.FullName) = False Then
            Directory.CreateDirectory(dirCopiaFile.FullName)
        Else
            ' MsgBox("La Cartella del Disegno Esiste Gia !!", MsgBoxStyle.OkCancel)
            CommandBarLabelSchede.Text = "La Cartella del Disegno Esiste Gia.Continua la lettura File!"
        End If


        'Cartella disegni dove cercare
        'Dim strFolderPath As String = "C:\Users\fabri\Documents\BBGSCHEDA\CARTELLA DISEGNI"
        Dim strFolderPath As String = "\\Desktopcadbbg\f\CARTELLA DISEGNI"

        'Oggetto DirectoryInfo della directory dei disegni
        Dim diDirectory As New DirectoryInfo(strFolderPath)

        Dim lngMaxBytes As Long = 0
        Dim lstFiles As New List(Of FileInfo)

        For Each strExt As String In arrFile

            Dim strContain As String = strExt.Substring(4, 4)
            Dim fiFolder As FileInfo() = diDirectory.GetFiles("*" & strExt & "*", SearchOption.AllDirectories)

            For Each fiFile As FileInfo In fiFolder
                If ((fiFile.Attributes And FileAttributes.Directory) <> 0) Then
                    Continue For
                End If

                lstFiles.Add(fiFile)
                lngMaxBytes += fiFile.Length

            Next fiFile

        Next strExt

        Dim lngBytes As Long = 0

        For Each file As FileInfo In lstFiles

            Try
                If file.Exists Then
                    BeginInvoke(OnChange, New Object() {New UIProgress(file.Name, lngBytes, lngMaxBytes)})
                    IO.File.Copy(file.FullName, dirCopiaFile.FullName + "\" + file.Name, False)
                End If

            Catch ex As Exception
                Dim err As New UIError(ex, file.FullName)
                Invoke(OnError, New Object() {err})
                If err.drResult = Windows.Forms.DialogResult.Cancel Then Exit For
            End Try

            lngBytes += file.Length
        Next

    End Sub


    Private Sub ChangeProgress(ByVal info As UIProgress)
        ToolStripStatusLabel1.Text = "Sto Copiando " + info.strName
        ToolStripProgressBar1.Value = CInt(100.0 * info.lngBytes / info.lngMaxBytes)
    End Sub

    Private Sub ErrorThrow(ByVal err As UIError)
        Dim msg As String = String.Format("MESSAGGIO COPIA FILE :  {0}\n{1}\n  CLICK OK PER CONTINUARE COPIA FILES..... ", " - " + err.strFilePath + " - ", err.strErrorMsg)
        err.drResult = MessageBox.Show(msg, "ERRORE COPIA ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub WorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)

        If e.Error IsNot Nothing Then
            ' se BackgroundWorker è terminato a causa di errori
            MessageBox.Show(e.Error.Message)
            ToolStripStatusLabel1.Text = "Errore Task!"

        ElseIf e.Cancelled Then
            'altrimenti se è stata annullata
            MessageBox.Show("Task cancellato!")
            ToolStripStatusLabel1.Text = "Task Cancellato!"

        Else
            'TODO:Popolare griglia
            PopolaGriglia(propPathDirCopiaFile)

            UpdateUI(False)

        End If


        If Not gridViewDisegni.Rows(0).Cells("NomeFileSchede").Value Is Nothing Then
            CommandBarLabelSchede.Text = "Copia Disegni Completato!"
        Else
            CommandBarLabelSchede.Text = "Disegni Non Trovati nella Directory Disegni!"
        End If

    End Sub

    Private Sub PopolaGriglia(ByVal pathFile As String)

        Try

            Dim files As [String]() = Directory.GetFiles(pathFile)

            Dim table As New DataTable()
            table.Columns.Add("NomeFileSchede")
            table.Columns.Add("PercorsoFileSchede")

            For i As Integer = 0 To files.Length - 1
                Dim file As New FileInfo(files(i))
                table.Rows.Add(file.Name, file.FullName)
            Next

            gridViewDisegni.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Errore Subroutine Popola Griglia : " + ex.Message)
        End Try

    End Sub

    Private Sub DataGridViewDisegni_CellClick(sender As Object, e As GridViewCellEventArgs) Handles DataGridViewDisegni.CellClick
        If TypeOf DataGridViewDisegni.CurrentRow Is GridViewDataRowInfo Then
            IndiceRimaneSuRigaPostAgg = DataGridViewDisegni.Rows.IndexOf(DirectCast(DataGridViewDisegni.CurrentRow, GridViewDataRowInfo))
        End If
    End Sub

#End Region

End Class


#Region "Codice vecchio"

'Public Sub RiFormatColonneGrid(ByVal dgridview As DataGridView)

'    dgridview.DataSource = Nothing
'    dgridview.Rows.Clear()
'    dgridview.ColumnCount = 2

'    Dim style As DataGridViewCellStyle = New DataGridViewCellStyle()
'    style.Alignment = DataGridViewContentAlignment.MiddleCenter

'    Dim NomeFileColumn As New DataGridViewTextBoxColumn()
'    NomeFileColumn.Name = "NomeFileSchede"
'    NomeFileColumn.HeaderText = "Nome File"
'    NomeFileColumn.Width = 155
'    NomeFileColumn.HeaderCell.Style = style
'    dgridview.Columns.Add(NomeFileColumn)

'    Dim PercorsoFileSchedeFileColumn As New DataGridViewTextBoxColumn()
'    PercorsoFileSchedeFileColumn.Name = "PercorsoFileSchede"
'    PercorsoFileSchedeFileColumn.HeaderText = "Percorso File"
'    PercorsoFileSchedeFileColumn.Width = 330
'    PercorsoFileSchedeFileColumn.HeaderCell.Style = style

'    dgridview.Columns.Add(PercorsoFileSchedeFileColumn)

'    Dim row As String() = New String() {"FILE NON PRESENTE", "PERCORSO FILE NON PRESENTE"}
'    dgridview.Rows.Add(row)

'    Dim btn As New DataGridViewButtonColumn()

'    btn.HeaderText = "Apri File"
'    btn.Text = "Apri File"
'    btn.Name = "btnApriFileSchede"
'    btn.UseColumnTextForButtonValue = True
'    btn.Width = 120
'    dgridview.Columns.Add(btn)

'    'Dim row1 As String() = New String() {" ", " "}
'    'Dim rows As Object() = New Object() {row1}
'    'Dim rowArray As String()
'    'For Each rowArray In rows
'    '    dgridview.Rows.Add(rowArray)
'    'Next

'End Sub



'Public Sub getSchedaInteraByIdIntestazioneStampa(ByVal intIdItestazioneStampa As Integer)

'    Try
'        Dim cmd As DbCommand = _db.GetStoredProcCommand("spGetDatiSchedeByIDIntestazione")

'        _db.AddInParameter(cmd, "IDIntestazione", DbType.Int32, intIdItestazioneStampa)

'        Dim dataScheda As Date

'        Using datareader As IDataReader = _db.ExecuteReader(cmd)

'            While datareader.Read

'                propIdIntestazioneStampa = datareader("IDIntestazione")
'                propNumOrdineStampa = datareader("NumOrdine")
'                propCodArticoloStampa = datareader("CodArticolo")
'                dataScheda = Converti(datareader("Data").ToString)
'                propDataStampa = dataScheda
'                If Not datareader("Materiale").ToString Is Nothing Then
'                    propMaterialeStampa = datareader("Materiale").ToString
'                Else
'                    propMaterialeStampa = "No Materiale"
'                End If
'                propRigaOrdNumStampa = CType(datareader("RigaOrdNum"), Integer)
'                propNumPezziStampa = CType(datareader("NumPezzi"), Integer)
'                propNoteStampa = datareader("Note")
'                propLavorazioneBBGStampa = datareader("LavorazioneBBG")
'                propPrePostLavorazioneBBGStampa = datareader("PrePostLavorazioneBBG")
'                propTrattamentoStampa = datareader("Trattamento")
'                propClienteTrattamentoStampa = datareader("ClienteTrattamento")
'                propClienteVerniciaturaStampa = datareader("ClienteVerniciatura")
'                propNoteVerniciaturaStampa = datareader("NoteVerniciatura")
'                propClienteHelicoilStampa = datareader("ClienteHelicoil")
'                propNoteHelicoilStampa = datareader("NoteHelicoil")
'                propAltreLavorazioniStampa = datareader("AltreLavorazioni")
'                propNoteAltreLavorazioniStampa = datareader("NoteAltreLavorazioni")
'            End While

'        End Using

'    Catch ex As Exception

'    End Try
'End Sub

'Public Sub SalvaSchedaInteraByIdIntestazioneStampa()
'    Dim ret As Nullable(Of Integer)
'    Dim result As DialogResult
'    Try
'        Dim iDIntestazione As Integer = propIdIntestazioneStampa
'        Dim numOrdine As String = propNumOrdineStampa
'        Dim codiceArticolo As String = propCodArticoloStampa
'        Dim dataConsegna As Date = Converti(propDataStampa)
'        Dim materiale As String = propMaterialeStampa
'        Dim rigaOrdNum As Integer = propRigaOrdNumStampa
'        Dim numPezzi As Integer = propNumPezziStampa
'        Dim NoteTestata As String = propNoteStampa
'        Dim lavorazioniBBG As String = propLavorazioneBBGStampa
'        Dim prePostLavorazioneBBG As String = propPrePostLavorazioneBBGStampa
'        Dim trattamento As String = propTrattamentoStampa
'        Dim clienteTrattamento As String = propClienteTrattamentoStampa
'        Dim clienteVerniciatura As String = propClienteVerniciaturaStampa
'        Dim noteVerniciatura As String = propNoteVerniciaturaStampa
'        Dim clienteHelicoil As String = propClienteHelicoilStampa
'        Dim noteHelicoil As String = propNoteHelicoilStampa
'        Dim altreLavorazioni As String = propAltreLavorazioniStampa
'        Dim noteAltreLavorazioni As String = propNoteAltreLavorazioniStampa


'        ret = InsertSchedaPerStampa(iDIntestazione, numOrdine, codiceArticolo, dataConsegna,
'                                    materiale, rigaOrdNum, numPezzi, NoteTestata, lavorazioniBBG, prePostLavorazioneBBG,
'                                    trattamento, clienteTrattamento, clienteVerniciatura, noteVerniciatura, clienteHelicoil, noteHelicoil,
'                                    altreLavorazioni, noteAltreLavorazioni)

'        If Not ret Is Nothing Then
'            'result = MessageBox.Show("Intestazione Per Stampa Salvata", "Inserimento test Report in Tabella Temporanea per Stampa", MessageBoxButtons.OKCancel)
'            If result = DialogResult.Cancel Then
'                Exit Sub
'            End If
'        End If

'    Catch ex As Exception
'        MessageBox.Show("Errore SalvaSchedaInteraByIdIntestazioneStampa :" & ex.Message)
'    End Try
'End Sub

'Public Function InsertSchedaPerStampa(ByVal iDIntestazione As Integer, ByVal numOrdine As String, ByVal codiceArticolo As String,
'                                      ByVal dataConsegna As Date, ByVal materiale As String, ByVal rigaOrdNum As Integer, ByVal numPezzi As Integer,
'                                      ByVal NoteTestata As String, ByVal lavorazioniBBG As String, ByVal prePostLavorazioneBBG As String,
'                                      ByVal trattamento As String, ByVal clienteTrattamento As String, ByVal clienteVerniciatura As String, ByVal noteVerniciatura As String,
'                                      ByVal clienteHelicoil As String, ByVal noteHelicoil As String, ByVal altreLavorazioni As String, ByVal noteAltreLavorazioni As String) As Integer

'    Dim insertCommand As DbCommand = Nothing
'    Dim rowsAffected As Integer
'    Dim dataShorth As Date = Converti(dataConsegna)

'    Try
'        insertCommand = _db.GetStoredProcCommand("spInsertQuerySchedaPerStampa")

'        _db.AddInParameter(insertCommand, "IDIntestazione", DbType.Int32, iDIntestazione)
'        _db.AddInParameter(insertCommand, "NumOrdine", DbType.String, numOrdine)
'        _db.AddInParameter(insertCommand, "CodArticolo", DbType.String, codiceArticolo)
'        _db.AddInParameter(insertCommand, "Data", DbType.Date, dataShorth)
'        _db.AddInParameter(insertCommand, "Materiale", DbType.String, materiale)
'        _db.AddInParameter(insertCommand, "RigaOrdNum", DbType.Int32, rigaOrdNum)
'        _db.AddInParameter(insertCommand, "NumPezzi", DbType.Int32, numPezzi)
'        _db.AddInParameter(insertCommand, "Note", DbType.String, NoteTestata)
'        _db.AddInParameter(insertCommand, "LavorazioneBBG", DbType.String, lavorazioniBBG)
'        _db.AddInParameter(insertCommand, "PrePostLavorazioneBBG", DbType.String, prePostLavorazioneBBG)
'        _db.AddInParameter(insertCommand, "Trattamento", DbType.String, trattamento)
'        _db.AddInParameter(insertCommand, "ClienteTrattamento", DbType.String, clienteTrattamento)
'        _db.AddInParameter(insertCommand, "ClienteVerniciatura", DbType.String, clienteVerniciatura)
'        _db.AddInParameter(insertCommand, "NoteVerniciatura", DbType.String, noteVerniciatura)
'        _db.AddInParameter(insertCommand, "ClienteHelicoil", DbType.String, clienteHelicoil)
'        _db.AddInParameter(insertCommand, "NoteHelicoil", DbType.String, noteHelicoil)
'        _db.AddInParameter(insertCommand, "AltreLavorazioni", DbType.String, altreLavorazioni)
'        _db.AddInParameter(insertCommand, "NoteAltreLavorazioni", DbType.String, noteAltreLavorazioni)

'        rowsAffected = _db.ExecuteNonQuery(insertCommand)

'    Catch ex As Exception
'        MessageBox.Show("Errore InsertSchedaPerStampa : " & ex.Message)
'    End Try

'    Return rowsAffected

'End Function


#End Region