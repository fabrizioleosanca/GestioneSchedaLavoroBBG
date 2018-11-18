Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports Telerik.WinControls
Imports System.Data.OleDb

Public Class frmNuovaSchedaDaEsistente

#Region "Proprieta Classe Campi Classe"
    Public Shared factory As New DatabaseProviderFactory()
    Public Property _db As Database = factory.Create("dbSchedaLavoroBBGConnectionString")
    Public Property RigaOrdNum As Nullable(Of Integer)
    Public Property PezziOrdNum As Nullable(Of Integer)
#End Region

#Region "Eventi"

    Private Sub CmdSalvaNuovaScheda_Click(sender As Object, e As EventArgs) Handles cmdSalvaNuovaScheda.Click
        Dim result As DialogResult
        Dim intSalvaTestataSchedaLavoroBusLayer As Nullable(Of Integer)
        Dim intSalvaLavorazioniBuslayer As Nullable(Of Integer)

        'Controlla Se l'ID è stato aggiornato
        propNuovoIDPerSalvareDaEsistente = CType(txtIDSchedaLavoro.Text, Integer)
        If propNuovoIDPerSalvareDaEsistente = propIdPerSalvaDaEsistente Then
            MessageBox.Show("ATTENZIONE: Per favore prima di salvare devi aggiornare l'ID cliccando sul bottone Cambia ID Scheda")
            Exit Sub
        End If

        Try
            intSalvaTestataSchedaLavoroBusLayer = SalvaTestataSchedaLavoroBusLayer()
            intSalvaLavorazioniBuslayer = SalvaLavorazioniBuslayer()
            'Salva anche in tabella per stampa
            SalvaSchedaInteraByIdIntestazioneStampa()

            'Inserisce solo ID in tabella lavorazioni se il resto dei dati lavorazioni sono vuoti
            If (Not intSalvaTestataSchedaLavoroBusLayer Is Nothing) Then
                If (intSalvaLavorazioniBuslayer Is Nothing) Then
                    inserisciSoloIDLavorazioniSeVuote()
                End If

                result = MessageBox.Show("Scheda Lavorazione Inserita Con Successo", "Inserimento Scheda Lavorazioni in Database", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    Exit Sub
                Else
                    CommandBarLabelAvvisi.Text = "Scheda Pronta Per La Stampa."
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Errore Registrazione Scheda lavoro Da Esistente In Database :" & ex.Message)
        End Try

    End Sub

    Public Sub SalvaSchedaInteraByIdIntestazioneStampa()
        Dim ret As Nullable(Of Integer)
        Try
            Dim iDIntestazione As Integer = propNuovoIDPerSalvareDaEsistente
            Dim numOrdine As String = txtCodiceOrdine.Text
            Dim codiceArticolo As String = txtCodiceArticolo.Text
            Dim dataConsegna As Date = Convert(dtpDataConsegna.Text)
            Dim materiale As String = txtMateriale.Text
            Dim rigaOrdNum As Integer = txtNumeroRiga.Text
            Dim numPezzi As Integer = txtNumeroPezziOrd.Text
            Dim NoteTestata As String = txtNote.Text
            Dim fornitore As String = cmbFornitore.Text
            Dim lotto As String = cmbLottoNum.Text


            Dim lavorazioniBBG As String = txtLavorazioniBBG.Text
            'Dim operatore As String = txtOperatore.Text
            Dim trattamento As String = txtTrattamento.Text
            Dim clienteTrattamento As String = txtClienteTrattamento.Text
            Dim clienteVerniciatura As String = txtClienteVerniciatura.Text
            Dim noteVerniciatura As String = txtNoteVernciatura.Text
            Dim clienteHelicoil As String = txtClienteHelicolil.Text
            Dim noteHelicoil As String = txtNoteHelicoil.Text
            Dim altreLavorazioni As String = txtAltreLavorazioni.Text
            Dim noteAltreLavorazioni As String = txtNoteAltreLavorazioni.Text
            Dim boolFai As Boolean
            If chkFAI.Checked = True Then
                boolFai = True
            Else
                boolFai = False
            End If

            Dim boolKc As Boolean
            If chkKC.Checked = True Then
                boolKc = True
            Else
                boolKc = False
            End If

            ret = InsertSchedaInteraPerStampa(iDIntestazione, numOrdine, codiceArticolo, dataConsegna,
                                        materiale, rigaOrdNum, numPezzi, NoteTestata, fornitore, lotto, lavorazioniBBG, PropStringOperatore, PropIntOperatore,
                                        trattamento, clienteTrattamento, clienteVerniciatura, noteVerniciatura, clienteHelicoil, noteHelicoil,
                                        altreLavorazioni, noteAltreLavorazioni, boolFai, boolKc)

            If Not ret Is Nothing Then
                CommandBarLabelAvvisi.Text = "Salvate Scheda Lavorazione e Scheda Per Stampa"
            End If

        Catch ex As Exception
            MessageBox.Show("Errore SalvaSchedaInteraByIdIntestazioneStampa :" & ex.Message)
        End Try
    End Sub

    Public Function InsertSchedaInteraPerStampa(ByVal iDIntestazione As Integer, ByVal numOrdine As String, ByVal codiceArticolo As String,
                                          ByVal dataConsegna As Date, ByVal materiale As String, ByVal rigaOrdNum As Integer, ByVal numPezzi As Integer,
                                          ByVal NoteTestata As String, ByVal fornitore As String, ByVal lotto As String, ByVal lavorazioniBBG As String, ByVal operatore As String, ByVal numeroOperatore As Integer,
                                          ByVal trattamento As String, ByVal clienteTrattamento As String, ByVal clienteVerniciatura As String, ByVal noteVerniciatura As String,
                                          ByVal clienteHelicoil As String, ByVal noteHelicoil As String, ByVal altreLavorazioni As String, ByVal noteAltreLavorazioni As String, ByVal boolFai As Boolean, ByVal boolKc As Boolean) As Integer

        Dim insertCommand As DbCommand = Nothing
        Dim rowsAffected As Integer
        Dim dataShorth As Date = Convert(dataConsegna)

        Try
            insertCommand = _db.GetStoredProcCommand("spInsertQuerySchedaPerStampa")

            _db.AddInParameter(insertCommand, "IDIntestazione", DbType.Int32, iDIntestazione)
            _db.AddInParameter(insertCommand, "NumOrdine", DbType.String, numOrdine)
            _db.AddInParameter(insertCommand, "CodArticolo", DbType.String, codiceArticolo)
            _db.AddInParameter(insertCommand, "Data", DbType.Date, dataShorth)
            _db.AddInParameter(insertCommand, "Materiale", DbType.String, materiale)
            _db.AddInParameter(insertCommand, "RigaOrdNum", DbType.Int32, rigaOrdNum)
            _db.AddInParameter(insertCommand, "NumPezzi", DbType.Int32, numPezzi)
            _db.AddInParameter(insertCommand, "Note", DbType.String, NoteTestata)
            _db.AddInParameter(insertCommand, "Fornitori", DbType.String, fornitore)
            _db.AddInParameter(insertCommand, "Lotto", DbType.String, lotto)
            _db.AddInParameter(insertCommand, "LavorazioneBBG", DbType.String, lavorazioniBBG)
            _db.AddInParameter(insertCommand, "Operatore", DbType.String, operatore)
            _db.AddInParameter(insertCommand, "NumOperatore", DbType.Int32, numeroOperatore)
            _db.AddInParameter(insertCommand, "Trattamento", DbType.String, trattamento)
            _db.AddInParameter(insertCommand, "ClienteTrattamento", DbType.String, clienteTrattamento)
            _db.AddInParameter(insertCommand, "ClienteVerniciatura", DbType.String, clienteVerniciatura)
            _db.AddInParameter(insertCommand, "NoteVerniciatura", DbType.String, noteVerniciatura)
            _db.AddInParameter(insertCommand, "ClienteHelicoil", DbType.String, clienteHelicoil)
            _db.AddInParameter(insertCommand, "NoteHelicoil", DbType.String, noteHelicoil)
            _db.AddInParameter(insertCommand, "AltreLavorazioni", DbType.String, altreLavorazioni)
            _db.AddInParameter(insertCommand, "NoteAltreLavorazioni", DbType.String, noteAltreLavorazioni)
            _db.AddInParameter(insertCommand, "Fai", DbType.Boolean, boolFai)
            _db.AddInParameter(insertCommand, "Kc", DbType.Boolean, boolKc)


            rowsAffected = _db.ExecuteNonQuery(insertCommand)

        Catch ex As Exception
            MessageBox.Show("Errore InsertSchedaInteraPerStampa : " & ex.Message)
        End Try

        Return rowsAffected

    End Function


    Public Function SalvaLavorazioniBuslayer() As Integer

        Dim retLavorazioni As Nullable(Of Integer)

        Try
            'ID 
            Dim iDIntestazione As Integer = propNuovoIDPerSalvareDaEsistente
            Dim codArticolo As String = txtCodiceArticolo.Text

            Dim lavorazioneBBG As String = txtLavorazioniBBG.Text
            'Dim operatore As String = txtOperatore.Text

            Dim trattamento As String = txtTrattamento.Text
            Dim clienteTrattamento As String = txtClienteTrattamento.Text
            Dim verniciatura As String = txtClienteVerniciatura.Text
            Dim noteVerniciatura As String = txtNoteVernciatura.Text
            Dim helicoil As String = txtClienteHelicolil.Text
            Dim noteHelicoil As String = txtNoteHelicoil.Text
            Dim altreEventualiLavorazioni As String = txtAltreLavorazioni.Text
            Dim noteAltreEventualiLav As String = txtNoteAltreLavorazioni.Text
            Dim boolFai As Boolean
            If chkFAI.Checked = True Then
                boolFai = True
            Else
                boolFai = False
            End If

            Dim boolKc As Boolean
            If chkKC.Checked = True Then
                boolKc = True
            Else
                boolKc = False
            End If

            retLavorazioni = InsertLavorazioniSchedaLavoro(iDIntestazione, codArticolo, lavorazioneBBG,
                                                           PropStringOperatore, PropIntOperatore, trattamento, clienteTrattamento,
                                                           verniciatura, noteVerniciatura,
                                                           helicoil, noteHelicoil, altreEventualiLavorazioni, noteAltreEventualiLav, boolFai, boolKc)


        Catch ex As Exception
            MessageBox.Show("Errore SalvaLavorazioni :" & ex.Message)
        End Try

        Return retLavorazioni

    End Function


    Public Function InsertLavorazioniSchedaLavoro(ByVal idIntestazioni As Integer, ByVal codiceArticolo As String, ByVal lavorazioneBBG As String,
                                              ByVal operatore As String, ByVal numeroOperatore As Integer, ByVal trattamento As String,
                                              ByVal clienteTrattamento As String, ByVal verniciatura As String,
                                              ByVal noteVerniciatura As String, ByVal helicoil As String,
                                              ByVal noteHelicoil As String, ByVal altreEventualiLavorazioni As String, ByVal noteAltreEventualiLav As String, ByVal boolFai As Boolean, ByVal boolKc As Boolean) As Integer


        Dim insertCommandLavorazioniSchedaLavoro As DbCommand = Nothing
        Dim rowsAffectedLavorazioniSchedaLavoro As Integer = Nothing

        Try

            insertCommandLavorazioniSchedaLavoro = _db.GetStoredProcCommand("spInsertQueryLavorazioni")

            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "IdIntestazione", DbType.Int32, idIntestazioni)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "CodiceArticolo", DbType.String, codiceArticolo)

            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "LavorazioneBBG", DbType.String, lavorazioneBBG)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "Operatore", DbType.String, operatore)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "NumeroOperatore", DbType.Int32, numeroOperatore)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "Trattamento", DbType.String, trattamento)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "ClienteTrattamento", DbType.String, clienteTrattamento)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "ClienteVerniciatura", DbType.String, verniciatura)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "NoteVerniciatura", DbType.String, noteVerniciatura)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "ClienteHelicoil", DbType.String, helicoil)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "NoteHelicoil", DbType.String, noteHelicoil)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "AltreLavorazioni", DbType.String, altreEventualiLavorazioni)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "NoteAltreLavorazioni", DbType.String, noteAltreEventualiLav)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "Fai", DbType.Boolean, boolFai)
            _db.AddInParameter(insertCommandLavorazioniSchedaLavoro, "Kc", DbType.Boolean, boolKc)


            rowsAffectedLavorazioniSchedaLavoro = _db.ExecuteNonQuery(insertCommandLavorazioniSchedaLavoro)


        Catch ex As Exception
            MessageBox.Show("Errore InsertLavorazioniSchedaLavoro : " & ex.Message)
        End Try

        Return rowsAffectedLavorazioniSchedaLavoro


    End Function


    Public Function SalvaTestataSchedaLavoroBusLayer() As Integer


        Dim retScheda As Nullable(Of Integer)
        Dim intScheda As Nullable(Of Integer)
        Dim intContatore As Integer = propNuovoIDPerSalvareDaEsistente

        Dim iDIntestazione As Integer = intContatore
        Dim data As Date = Convert(dtpDataConsegna.Text)
        Dim codiceArticolo As String = txtCodiceArticolo.Text
        Dim ordineArticolo As String = txtCodiceOrdine.Text
        'Numero Pezzi e Numero Riga sono in evento validating
        Dim pezziOrdNum As Integer = CType(Me.txtNumeroPezziOrd.Text, Integer)
        Dim rigaOrdNum As Integer = CType(Me.txtNumeroRiga.Text, Integer)
        Dim materiale As String = txtMateriale.Text
        Dim noteTestata As String = txtNote.Text
        Dim fornitori As String = cmbFornitore.Text
        Dim lotto As String = cmbLottoNum.Text


        Try
            intScheda = InsertTestataSchedaLavoro(iDIntestazione, ordineArticolo, propCodiceArticolo, data, materiale, pezziOrdNum, rigaOrdNum, noteTestata, fornitori, lotto)

            If Not intScheda Is Nothing Then
                retScheda = intScheda
            End If

        Catch ex As Exception
            MessageBox.Show("Errore SalvaTestataSchedaLavoroBusLayer :" & ex.Message)
        End Try

        Return retScheda

    End Function



    Public Function InsertTestataSchedaLavoro(ByVal idIntestazione As Integer,
                                          ByVal ordineArticolo As String,
                                          ByVal codiceArticolo As String,
                                          ByVal data As Date, ByVal materiale As String,
                                          ByVal numpezzi As Integer, ByVal rigaordnum As Integer,
                                          ByVal noteTestata As String, ByVal fornitori As String, ByVal lotto As String) As Integer

        Dim insertCommand As DbCommand = Nothing
        Dim rowsAffected As Integer
        Dim dataShorth As Date = Convert(data)

        Try

            insertCommand = _db.GetStoredProcCommand("spInsertQueryIntestazione")

            _db.AddInParameter(insertCommand, "IDIntestazione", DbType.Int32, idIntestazione)
            _db.AddInParameter(insertCommand, "NumOrdine", DbType.String, ordineArticolo)
            _db.AddInParameter(insertCommand, "CodArticolo", DbType.String, codiceArticolo)
            _db.AddInParameter(insertCommand, "Data", DbType.Date, data)
            _db.AddInParameter(insertCommand, "Materiale", DbType.String, materiale)
            _db.AddInParameter(insertCommand, "RigaOrdNum", DbType.Int32, rigaordnum)
            _db.AddInParameter(insertCommand, "NumPezzi", DbType.Int32, numpezzi)
            _db.AddInParameter(insertCommand, "Note", DbType.String, noteTestata)
            _db.AddInParameter(insertCommand, "Fornitori", DbType.String, fornitori)
            _db.AddInParameter(insertCommand, "Lotto", DbType.String, lotto)

            rowsAffected = _db.ExecuteNonQuery(insertCommand)

        Catch ex As Exception
            MessageBox.Show("Errore insertTestataSchedaLavoro : " & ex.Message)
        End Try

        Return rowsAffected

    End Function


    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
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

        gridViewControl.EnableFiltering = True
        gridViewControl.EnableAlternatingRowColor = True
        gridViewControl.ShowFilteringRow = True
        gridViewControl.ReadOnly = True
        gridViewControl.SelectionMode = GridViewSelectionMode.FullRowSelect
        gridViewControl.UseCompatibleTextRendering = True
        gridViewControl.Focusable = True

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

        AddHandler Me.cmbLottoNum.DropDownClosing, AddressOf DropDownClosing



    End Sub

    Private Sub DropDownClosing(sender As Object, args As Telerik.WinControls.UI.RadPopupClosingEventArgs)
        If TypeOf sender Is RadMultiColumnComboBox Then
            Dim rmc As RadMultiColumnComboBox = sender
            If rmc.SelectedIndex > -1 Then
                'se la messa a fuoco è su una riga, lascia il popup chiuso
                'Console.WriteLine("clicked on: " & CStr(rmc.SelectedIndex))
            Else
                'altrimenti, controllare la posizione del mouse e non consentire la chiusura se all'interno dell'area della finestra popup
                'Varibile con valori dei punti che delimitano il menu a tendina (Pop Up)
                Dim pt As Point = rmc.EditorControl.TableElement.PointFromControl(MousePosition)
                Dim popTop As Integer = rmc.MultiColumnComboBoxElement.MultiColumnPopupForm.Top
                Dim popLft As Integer = rmc.MultiColumnComboBoxElement.MultiColumnPopupForm.Left
                Dim popHt As Integer = rmc.MultiColumnComboBoxElement.MultiColumnPopupForm.Height
                Dim popWd As Integer = rmc.MultiColumnComboBoxElement.MultiColumnPopupForm.Width
                'Se
                If pt.X >= popLft And pt.X <= popLft + popWd Then
                    If pt.Y >= popTop And pt.Y <= popTop + popHt Then
                        '--- dovrebbe fare clic all'interno della finestra, quindi lasciarlo aperto
                        args.Cancel = True
                        If rmc.EditorControl.ActiveEditor IsNot Nothing Then
                            Dim editor As RadTextBoxEditor = TryCast(rmc.EditorControl.ActiveEditor, RadTextBoxEditor)
                            If editor IsNot Nothing Then
                                Dim editorElement As RadTextBoxEditorElement = TryCast(editor.EditorElement, RadTextBoxEditorElement)
                                editorElement.Focus()
                            End If

                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub OnTextBoxItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.cmbLottoNum.MultiColumnComboBoxElement.ShowPopup()
    End Sub



    Private Sub FrmNuovaSchedaDaEsistente_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            gridViewDisegni.AutoGenerateColumns = False
            Dim result As DialogResult

            'Controlla se nella form schede salvate è stato selezionato un articolo
            If propIdPerSalvaDaEsistente = 0 Then
                result = MessageBox.Show("Prima devi selezionare un articolo!", "Errore selezione articolo", MessageBoxButtons.OK)
                If result = Windows.Forms.DialogResult.OK Then
                    Me.Close()
                End If
            End If

            'Popola Combo
            RiempiComboMateriali()
            PopolaComboLavorazioniBBG()
            PopolaComboClientiTrattamento()
            popolaComboVari("spGetClienteVerniciatura", txtClienteVerniciatura, "ClienteVerniciatura")
            popolaComboVari("spGetClientiHelicoil", txtClienteHelicolil, "ClienteHelicoil")
            popolaComboVari("spGetTrattamenti", txtTrattamento, "Trattamenti")
            'popolaComboVari("spGetOperatoreCombo", txtOperatore, "Operatore")
            RiempiComboOperatore()
            'Popola campi dati testata e lavorazioni
            getTestataByIdIntestazioneNew(propIdPerSalvaDaEsistente)
            GetLavorazioniByIDIntestazioneNew(propIdPerSalvaDaEsistente)

            CodArtPerDisegniNew = txtCodiceArticolo.Text
            propNomeArticoloPerNomeDirRegNew = CodArtPerDisegniNew.Replace("/", "-")
            Dim pathDisegniNew As String = propPathDisegniApprovati + propNomeArticoloPerNomeDirRegNew
            propPathDirDisegnoNew = pathDisegniNew
            popolaGriglia(propPathDirDisegnoNew)

            cmbLottoNum.SelectedIndex = -1
            RiempiComboFornitori()


        Catch ex As Exception
            MessageBox.Show("Errore Riempimento Combo :" & ex.Message)
        End Try

    End Sub

    Public Sub RiempiComboOperatore()
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand

        Dim connectionstring As String = "Provider=SQLOLEDB;Data Source=UTENTEBBGSQL-PC\SQLEXPRESS;Initial Catalog=dbSchedaLavoroSviluppo;User Id=sa;Password=tito;"
        'Dim connectionstring As String = "Provider=SQLOLEDB;Data Source=FABLENOVO;Initial Catalog=dbSchedaLavoroSviluppo;Integrated Security=SSPI"

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

    Private Sub CmdChiudiForm_Click(sender As Object, e As EventArgs) Handles cmdChiudiForm.Click
        Close()
    End Sub

    Private Sub cmdCambiaIDScheda_Click(sender As Object, e As EventArgs) Handles cmdCambiaIDScheda.Click
        Dim intContatoreCambia As Integer = contatoreNuovoID()
        Me.txtIDSchedaLavoro.Text = intContatoreCambia
    End Sub


#End Region

#Region "Contatore"

    Public Function IDCorrente() As Integer
        Dim i As Nullable(Of Integer)
        Try
            Dim strSQL As String = "SELECT MAX(IDIntestazione) AS IDIntestazione FROM tblIntestazione"
            Dim cmd As DbCommand = _db.GetSqlStringCommand(strSQL)
            Using datareader As IDataReader = _db.ExecuteReader(cmd)
                While datareader.Read
                    i = datareader("IDIntestazione")
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Errore IDCorrente : " & ex.Message)
        End Try
        Return i
    End Function

    Public Function contatoreNuovoID() As Integer
        Dim i As Nullable(Of Integer)
        Try
            Dim strSQL As String = "SELECT MAX(IDIntestazione) AS IDIntestazione FROM tblIntestazione"
            Dim cmd As DbCommand = _db.GetSqlStringCommand(strSQL)

            Using datareader As IDataReader = _db.ExecuteReader(cmd)
                While datareader.Read
                    If IsDBNull(datareader("IDIntestazione")) Then
                        i = 1
                    Else
                        i = datareader("IDIntestazione")
                        i = i + 1
                    End If
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Errore contatore con ID + 1 : " & ex.Message)
        End Try

        Return i

    End Function

    Public Function contatore() As Integer
        Dim i As Nullable(Of Integer)
        Try
            Dim strSQL As String = "SELECT MAX(IDIntestazione) AS IDIntestazione FROM tblIntestazione"
            Dim cmd As DbCommand = _db.GetSqlStringCommand(strSQL)

            Using datareader As IDataReader = _db.ExecuteReader(cmd)
                While datareader.Read
                    If IsDBNull(datareader("IDIntestazione")) Then
                        i = 1
                    Else
                        i = datareader("IDIntestazione")
                    End If
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Errore contatore con ID + 1 : " & ex.Message)
        End Try

        Return i

    End Function

    Public Function inserisciSoloIDLavorazioniSeVuote() As Integer

        Dim intContatoreLavorazioni As Integer = propIdPerSalvaDaEsistente
        Dim CodiceArticoloDb As String = propCodiceArticoloNew

        Dim IDIntestazione As Integer = intContatoreLavorazioni
        Dim strCodiceArticolo As String = CodiceArticoloDb

        Try
            Dim retInsertLavorazioniSoloID As Nullable(Of Integer) = inserisciSoloIDLavorazioniDAL(IDIntestazione, strCodiceArticolo)

            If Not retInsertLavorazioniSoloID Is Nothing Then
                inserisciSoloIDLavorazioniSeVuote = retInsertLavorazioniSoloID
            End If

        Catch ex As Exception
            MessageBox.Show("Errore inserisciSoloIDLavorazioniSeVuote : " & ex.Message)
        End Try

        Return inserisciSoloIDLavorazioniSeVuote

    End Function

    Public Function inserisciSoloIDLavorazioniDAL(ByVal idIntestazione As Integer, ByVal codArt As String) As Integer

        Dim insertCommandLavorazioniSoloID As DbCommand = Nothing
        Dim rowsAffected As Integer = Nothing

        Try
            insertCommandLavorazioniSoloID = _db.GetStoredProcCommand("spInsertQueryLavorazioniSoloID")

            _db.AddInParameter(insertCommandLavorazioniSoloID, "IdIntestazione", DbType.Int32, idIntestazione)
            _db.AddInParameter(insertCommandLavorazioniSoloID, "CodiceArticolo", DbType.String, codArt)

            rowsAffected = _db.ExecuteNonQuery(insertCommandLavorazioniSoloID)

        Catch ex As Exception
            MessageBox.Show("Errore inserisciSoloIDLavorazioniDAL :" & ex.Message)
        End Try

        Return rowsAffected

    End Function



#End Region


#Region "Popola Combo"

    Public Sub popolaComboVari(ByVal strNomeSP As String, ByVal nomeControllo As ComboBox, ByVal nomeTab As String)
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

#Region "Carica Dati Testata e Lavorazioni By IDIntestazione"

    Public Sub GetLavorazioniByIDIntestazioneNew(ByVal intIdIntestazione As Integer)
        Dim cmd As DbCommand = _db.GetStoredProcCommand("spGetLavorazioniByIdIntestazioneNew")
        Try
            _db.AddInParameter(cmd, "IDIntestazione", DbType.Int32, intIdIntestazione)

            Using datareader As IDataReader = _db.ExecuteReader(cmd)
                While datareader.Read

                    'IDIntestazione
                    propIdIntestazioneNew = CType(datareader("IDIntestazione"), Integer)

                    'LavorazioniBBG
                    If Not datareader("LavorazioneBBG").ToString Is Nothing Then
                        propLavorazioniBBGNew = datareader("LavorazioneBBG").ToString
                        txtLavorazioniBBG.SelectedItem = propLavorazioniBBGNew
                    Else
                        txtLavorazioniBBG.SelectedValue = -1
                    End If

                    'Operatore
                    If Not datareader("Operatore").ToString Is Nothing Then
                        propOperatoreNew = datareader("Operatore").ToString
                        txtOperatore.SelectedItem = propOperatoreNew
                    Else
                        txtOperatore.SelectedValue = -1
                    End If

                    'Trattamento
                    If Not datareader("Trattamento").ToString Is Nothing Then
                        propTrattamentoNew = datareader("Trattamento").ToString
                        txtTrattamento.SelectedItem = propTrattamentoNew
                    Else
                        txtTrattamento.SelectedValue = -1
                    End If

                    'ClienteTrattamento
                    If Not datareader("ClienteTrattamento").ToString Is Nothing Then
                        propClienteTrattamentoNew = datareader("ClienteTrattamento").ToString
                        txtClienteTrattamento.SelectedItem = propClienteTrattamentoNew
                    Else
                        txtClienteTrattamento.SelectedValue = -1
                    End If

                    'ClienteVerniciatura
                    If Not datareader("ClienteVerniciatura").ToString Is Nothing Then
                        propClienteVerniciaturaNew = datareader("ClienteVerniciatura").ToString
                        txtClienteVerniciatura.SelectedItem = propClienteVerniciaturaNew
                    Else
                        txtClienteVerniciatura.SelectedValue = -1
                    End If

                    'NoteVerniciatura
                    If Not datareader("NoteVerniciatura").ToString Is Nothing Then
                        propNoteVerniciaturaNew = datareader("NoteVerniciatura").ToString
                        txtNoteVernciatura.Text = propNoteVerniciaturaNew
                    Else
                        Me.txtNoteVernciatura.Text = ""
                    End If

                    'ClienteHelicoil
                    If Not datareader("ClienteHelicoil").ToString Is Nothing Then
                        propClienteHelicoilNew = datareader("ClienteHelicoil").ToString
                        txtClienteHelicolil.SelectedItem = propClienteHelicoilNew
                    Else
                        txtClienteHelicolil.SelectedValue = -1
                    End If

                    'NoteHelicoil
                    If Not datareader("NoteHelicoil").ToString Is Nothing Then
                        propNoteHelicoilNew = datareader("NoteHelicoil").ToString
                        txtNoteHelicoil.Text = propNoteHelicoilNew
                    Else
                        txtNoteHelicoil.Text = ""
                    End If

                    'AltreLavorazioni
                    If Not datareader("AltreLavorazioni").ToString Is Nothing Then
                        propAltreLavorazioniNew = datareader("AltreLavorazioni").ToString
                        txtAltreLavorazioni.Text = propAltreLavorazioniNew
                    Else
                        txtAltreLavorazioni.Text = ""
                    End If

                    'NoteAltreLavorazioni
                    If Not datareader("NoteAltreLavorazioni").ToString Is Nothing Then
                        propNoteAltreLavorazioniNew = datareader("NoteAltreLavorazioni").ToString
                        txtNoteAltreLavorazioni.Text = propNoteAltreLavorazioniNew
                    Else
                        txtNoteAltreLavorazioni.Text = ""
                    End If

                    'FAI
                    chkFAI.Checked = CType(datareader("Fai"), Boolean)
                    'KC
                    chkKC.Checked = CType(datareader("Kc"), Boolean)

                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Errore getLavorazioniByIDIntestazioneNew : " & ex.Message)
        End Try

    End Sub

    Public Sub getTestataByIdIntestazioneNew(ByVal intIdItestazione As Integer)
        Dim cmd As DbCommand = _db.GetStoredProcCommand("spGetIntestazioneByIDNew")
        Try
            _db.AddInParameter(cmd, "IDIntestazione", DbType.Int32, intIdItestazione)
            Using datareader As IDataReader = _db.ExecuteReader(cmd)
                While datareader.Read

                    'IDIntestazione
                    propIdIntestazioneNew = CType(datareader("IDIntestazione"), Integer)
                    txtIDSchedaLavoro.Text = CType(propIdIntestazioneNew, String)

                    'Data test report
                    propDataReportNew = Convert(datareader("Data").ToString)
                    dtpDataConsegna.Text = CType(propDataReportNew, String)

                    'Codice Articolo
                    propCodiceArticoloNew = datareader("CodArticolo").ToString
                    txtCodiceArticolo.Text = propCodiceArticoloNew

                    'Codice Ordine
                    propCodiceOrdineNew = datareader("NumOrdine").ToString
                    txtCodiceOrdine.Text = propCodiceOrdineNew

                    'Materiale
                    If Not datareader("Materiale").ToString Is Nothing Then
                        propMaterialeNew = datareader("Materiale").ToString
                        txtMateriale.SelectedItem = propMaterialeNew
                    Else
                        txtMateriale.SelectedText = ""
                    End If

                    'Riga Ordine
                    propRigaOrdineNumNew = CType(datareader("RigaOrdNum"), Integer)
                    txtNumeroRiga.Text = CType(propRigaOrdineNumNew, String)

                    'Numero Pezzi
                    propNumPezziNew = CType(datareader("NumPezzi"), Integer)
                    txtNumeroPezziOrd.Text = CType(propNumPezziNew, String)

                    'Note
                    propNoteNew = datareader("Note").ToString
                    Me.txtNote.Text = propNoteNew

                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Errore GetTestata : " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Funzioni Utility"

    Public Function Convert(ByVal value As Date) As Date
        Dim DateValue As DateTime = CType(value, DateTime)
        Return DateValue.ToShortDateString
    End Function

    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function

    Private Function IsInputNumeric(input As String) As Boolean
        If String.IsNullOrEmpty(input) Then
            IsInputNumeric = True
        End If
        If Not IsNumeric(input) Then
            IsInputNumeric = False
        End If
        If IsNumeric(input) Then
            IsInputNumeric = True
        End If
        Return IsInputNumeric
    End Function

    Private Sub txtNumeroPezziOrd_Validating(sender As Object, e As CancelEventArgs) Handles txtNumeroPezziOrd.Validating
        If IsInputNumeric(txtNumeroPezziOrd.Text) = True Then
            If txtNumeroPezziOrd.TextLength = 0 Then
                PezziOrdNum = 0
            Else
                PezziOrdNum = CType(Me.txtNumeroPezziOrd.Text, Integer)
            End If
        Else
            PezziOrdNum = 0
            MessageBox.Show("Per favore usare valori numerici per il numero riga o lasciarlo vuoto")
        End If
    End Sub

    Private Sub txtNumeroRiga_Validating(sender As Object, e As CancelEventArgs) Handles txtNumeroRiga.Validating
        If IsInputNumeric(txtNumeroRiga.Text) = True Then
            If txtNumeroRiga.TextLength = 0 Then
                RigaOrdNum = 0
            Else
                RigaOrdNum = CType(Me.txtNumeroRiga.Text, Integer)
            End If
        Else
            RigaOrdNum = 0
            MessageBox.Show("Per favore usare valori numerici per il numero riga o lasciarlo vuoto")
        End If
    End Sub

#End Region

#Region "Disegni"


    Private Sub popolaGriglia(ByVal pathFile As String)

        Try

            Dim files As [String]() = Directory.GetFiles(pathFile)

            Dim table As New DataTable()
            table.Columns.Add("NomeFile")
            table.Columns.Add("PercorsoFile")

            For i As Integer = 0 To files.Length - 1
                Dim file As New FileInfo(files(i))
                table.Rows.Add(file.Name, file.FullName)
            Next

            gridViewDisegni.DataSource = table


        Catch ex As ArgumentException
            MessageBox.Show("Non Ci Sono Disegni Salvati Per Questo Articolo : " + ex.Message)
        Catch ex As FileNotFoundException
            MessageBox.Show("Non Ci Sono Disegni Salvati Per Questo Articolo : " + ex.Message)
        Catch ex As DirectoryNotFoundException
            MessageBox.Show("Non Ci Sono Disegni Salvati Per Questo Articolo : " + ex.Message)
        End Try

    End Sub


    Private Sub gridViewDisegni_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridViewDisegni.CellContentClick

        'Griglia Disegni
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim nomeFile As String
        Dim strEstension As String
        Dim pathCompleto As String

        Try
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'TODO - Button Clicked - Execute Code Here
                nomeFile = CType(gridViewDisegni.CurrentRow.Cells(0).Value, String)
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

    Private Sub btnStampaScheda_Click(sender As Object, e As EventArgs) Handles btnStampaScheda.Click
        CommandBarLabelAvvisi.Text = "PER FAVORE ATTENDERE LA COMPILAZIONE DEL REPORT STAMPA:La Stampa si avviera in pochi secondi."
        If GetAndInsertPerStampa() = True Then
            Dim frmStampa As New frmStampa
            frmStampa.Show()
        Else
            CommandBarLabelAvvisi.Text = ""
            Exit Sub
        End If
        CommandBarLabelAvvisi.Text = String.Empty
    End Sub

    Public Function GetAndInsertPerStampa() As Boolean
        Try
            'Controlla Se l'ID è stato aggiornato
            propNuovoIDPerSalvareDaEsistente = CType(txtIDSchedaLavoro.Text, Integer)

            If propNuovoIDPerSalvareDaEsistente = propIdPerSalvaDaEsistente Then
                MessageBox.Show("ATTENZIONE: Per favore prima di Stampare devi aggiornare l'ID cliccando sul bottone Cambia ID Scheda !! E SALVARE LA NUOVA SCHEDA !!! ")
                GetAndInsertPerStampa = False
                Exit Function
            Else
                GetAndInsertPerStampa = True
                propIdIntestazioneStampa = propNuovoIDPerSalvareDaEsistente
            End If


        Catch ex As Exception
            MessageBox.Show("Errore GetAndInsertPerStampa :" & ex.Message)
        End Try
        Return GetAndInsertPerStampa
    End Function



#End Region

End Class