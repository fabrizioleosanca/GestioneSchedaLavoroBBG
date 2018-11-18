Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Telerik.WinControls.UI
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports Telerik.WinControls.Data
Imports Telerik.WinControls



Public Class mainForm

#Region "Proprieta Classe Campi Classe"
    Public Shared factory As New DatabaseProviderFactory()
    Public Property _db As Database = factory.Create("dbSchedaLavoroBBGConnectionString")
    Public Property RigaOrdNum As Nullable(Of Integer)
    Public Property PezziOrdNum As Nullable(Of Integer)

    Public collNomeFile As New Collection

    Private Delegate Sub ProgressChanged(ByVal info As UIProgress)
    Private Delegate Sub CopyError(ByVal err As UIError)

    Private OnChange As ProgressChanged
    Private OnError As CopyError


#End Region

#Region "Start Form"

    Public Sub New()

        ' This call is required by the designer.
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


        'Dim compositeFilter As New CompositeFilterDescriptor()
        'Dim txtCompleto As New FilterDescriptor("txtCompleto", FilterOperator.Contains, "")
        'Dim materiale As New FilterDescriptor("materiale", FilterOperator.Contains, "")
        'compositeFilter.FilterDescriptors.Add(txtCompleto)
        'compositeFilter.FilterDescriptors.Add(materiale)
        'compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        'Me.cmbLottoNum.EditorControl.MasterTemplate.FilterDescriptors.Add(compositeFilter)

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

        'Delegati per copia file asincrona
        AddHandler bwCopier.DoWork, AddressOf DoCopy
        AddHandler bwCopier.RunWorkerCompleted, AddressOf WorkerCompleted

        bwCopier.WorkerSupportsCancellation = True

        OnChange = AddressOf ChangeProgress
        OnError = AddressOf ErrorThrow

        UpdateUI(False)

        Me.cmbCodiceArticolo.DrawMode = DrawMode.Normal


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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' DateTimePickerConsegna.CustomFormat = "dd-MM-yyyy"
        DataGridView1.AutoGenerateColumns = False
        RiempiComboMateriali()
        PopolaComboLavorazioniBBG()
        PopolaComboClientiTrattamento()
        PopolaComboVari("spGetClienteVerniciatura", nomeControllo:=txtVerniciatura, nomeTab:="ClienteVerniciatura")
        PopolaComboVari("spGetClientiHelicoil", nomeControllo:=txtHelicoil, nomeTab:="ClienteHelicoil")
        PopolaComboVari("spGetTrattamenti", nomeControllo:=txtTrattamento, nomeTab:="Trattamenti")
        'PopolaComboVari("spGetOperatoreCombo", txtOperatore, "Operatore")
        RiempiComboOperatore()
        PopolaComboVari("spGetNoteVerniciaturaCombo", txtNoteVerniciatura, "NoteVerniciatura")
        PopolaComboVari("spNoteHelicoilCombo", txtNoteHelicoil, "NoteHelicoil")
        PopolaComboVari("spGetAnnoPerOrdine", cmbAnnoPerOrdini, "AnnoPerOrdine")
        SetAnnoOrdiniCorrente()
        cmbLottoNum.SelectedIndex = -1
        RiempiComboFornitori()
    End Sub

    Public Sub SetAnnoOrdiniCorrente()
        Dim DataCorrente As String = Date.Today.Year.ToString
        For Each anno As String In cmbAnnoPerOrdini.Items
            If anno = DataCorrente Then
                cmbAnnoPerOrdini.SelectedItem = anno
            End If
        Next
    End Sub

#End Region

#Region "Stampa"

    Private Sub BtnStampaMainForm_Click(sender As Object, e As EventArgs) Handles btnStampaMainForm.Click
        'Ripulisce la Label
        CommandBarLabel1.Text = String.Empty
        CommandBarLabel1.Text = "PER FAVORE ATTENDERE LA COMPILAZIONE DEL REPORT STAMPA:La Stampa si avviera in pochi secondi."
        propIdIntestazioneStampa = propIdIntestazione
        Dim frmStampa As New frmStampa
        frmStampa.Show()
        RipulisciForm()
    End Sub

#End Region

#Region "Copia File PDF"

    Private Sub BtnCaricaDisegniArticolo_Click(sender As Object, e As EventArgs) Handles btnCaricaDisegniArticolo.Click
        Dim docopy As Boolean = btnCaricaDisegniArticolo.Text = "Copia Disegni"
        UpdateUI(docopy)
        If (docopy) Then
            bwCopier.RunWorkerAsync()
        Else
            bwCopier.CancelAsync()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'BOTTONE PER VISUALIZZAZIONE DISEGNI O FILE ZIP
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim pathFile As String
        Dim strEstension As String
        Dim strDirZip As String

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

            pathFile = CType(DataGridView1.CurrentRow.Cells(1).Value, String)
            strEstension = Path.GetExtension(pathFile)
            strDirZip = Path.GetDirectoryName(pathFile)

            If strEstension = ".pdf" Then
                Dim frmViewer As New FrmPDF(pathFile)
                frmViewer.Show()
            End If

            If strEstension = ".zip" Then
                Process.Start("explorer.exe", pathFile)
            End If

        End If
    End Sub


    Private Sub DoCopy(ByVal sender As Object, ByVal e As DoWorkEventArgs)

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
            CommandBarLabel1.Text = "La Cartella del Disegno Esiste Gia.Continua la lettura File!"
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


        If Not DataGridView1.Rows(0).Cells("NomeFile").Value Is Nothing Then
            CommandBarLabel1.Text = "Copia Disegni Completato!"
        Else
            CommandBarLabel1.Text = "Disegni Non Trovati nella Directory Disegni!"
        End If

    End Sub

    Private Sub PopolaGriglia(ByVal pathFile As String)

        Try

            Dim files As [String]() = Directory.GetFiles(pathFile)

            Dim table As New DataTable()
            table.Columns.Add("NomeFile")
            table.Columns.Add("PercorsoFile")

            For i As Integer = 0 To files.Length - 1
                Dim file As New FileInfo(files(i))
                table.Rows.Add(file.Name, file.FullName)
            Next

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Errore Subroutine Popola Griglia : " + ex.Message)
        End Try

    End Sub

    Private Sub UpdateUI(ByVal docopy As Boolean)

        ToolStripStatusLabel1.Visible = docopy
        ToolStripProgressBar1.Visible = docopy

        If docopy Then
            btnCaricaDisegniArticolo.Text = "Cancella Copia Disegni"
        Else
            btnCaricaDisegniArticolo.Text = "Copia Disegni"
        End If

        ToolStripStatusLabel1.Text = "Inizio Copia..."
        ToolStripProgressBar1.Value = 0

    End Sub

#End Region

#Region "Ripulisci form"
    Public Sub RipulisciForm()
        'Ripulisce i combo windows
        Dim allCmb As New List(Of Control)
        For Each cmb As ComboBox In FindControlRecursive(allCmb, Me, GetType(ComboBox))
            ' cmb.SelectedIndex = -1
            cmb.Text = String.Empty
        Next

        'Ripulisce i texbox windows
        Dim allTxtWin As New List(Of Control)
        For Each Txt As TextBox In FindControlRecursive(allTxtWin, Me, GetType(TextBox))
            ' cmb.SelectedIndex = -1
            Txt.Text = String.Empty
        Next

        'Ripulisce i richtexbox windows
        Dim richTxt As New List(Of Control)
        For Each rTxt As RichTextBox In FindControlRecursive(richTxt, Me, GetType(RichTextBox))
            rTxt.Text = String.Empty
        Next

        Dim chk As New List(Of Control)
        For Each chkBox As CheckBox In FindControlRecursive(chk, Me, GetType(CheckBox))
            chkBox.Checked = False
        Next


        'Ripulisce i controlli telerik
        Dim q = GetAll(Me, GetType(RadTextBox))
        For Each frtb As RadTextBox In q
            frtb.Text = String.Empty
        Next

        Dim c = GetAll(Me, GetType(RadMultiColumnComboBox))
        For Each rmcc As RadMultiColumnComboBox In c
            rmcc.Text = String.Empty
        Next


        'Ripulisce la griglia disegni al cambio articolo
        Dim bindClear As New BindingSource
        Dim dsVuoto As New DataSet
        dsVuoto.Clear()
        bindClear.DataSource = dsVuoto
        DataGridView1.DataSource = bindClear

        'Campo di testo sulla barra menu
        CommandBarLabel1.Text = String.Empty

    End Sub


#End Region

#Region "Eventi"

    Private Sub BtnEsciApplicazione_Click(sender As Object, e As EventArgs) Handles btnEsciApplicazione.Click
        Close()
    End Sub

    Private Sub RadButtonRegistra_Click(sender As Object, e As EventArgs) Handles RadButtonRegistra.Click

        Dim result As DialogResult
        Dim intSalvaTestataSchedaLavoroBusLayer As Nullable(Of Integer)
        Dim intSalvaLavorazioniBuslayer As Nullable(Of Integer)

        Try
            intSalvaTestataSchedaLavoroBusLayer = SalvaTestataSchedaLavoroBusLayer()
            intSalvaLavorazioniBuslayer = SalvaLavorazioniBuslayer()

            'Inserisce solo ID in tabella lavorazioni se il resto dei dati lavorazioni sono vuoti
            If (Not intSalvaTestataSchedaLavoroBusLayer Is Nothing) Then
                If (intSalvaLavorazioniBuslayer Is Nothing) Then
                    InserisciSoloIDLavorazioniSeVuote()
                End If

                result = MessageBox.Show("Scheda Lavorazione Inserita Con Successo", "Inserimento Scheda Lavorazioni in Database", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    Exit Sub
                End If
            End If

            'Salva anche in tabella per stampa
            SalvaSchedaInteraByIdIntestazioneStampa()

            Dim artTesto As String = CType(cmbCodiceArticolo.Text, String)
            Dim meccTesto As String = CType(txtMeccanica.Text, String)

            'Avverte di stampare la scheda se uno vuole
            CommandBarLabel1.Text = "ORA PUOI STAMPARE LA SCHEDA ARTICOLO: " + "Codice Padre " + artTesto + "; Meccanica " + meccTesto

            ' RipulisciForm()

        Catch ex As Exception
            MessageBox.Show("Errore Registrazione Scheda lavoro In Database :" & ex.Message)
        End Try

    End Sub

    Public Sub SalvaSchedaInteraByIdIntestazioneStampa()
        Dim ret As Nullable(Of Integer)
        Try
            Dim iDIntestazione As Integer = propIdIntestazione
            Dim numOrdine As String = cmbOrdineArticolo.Text
            Dim codiceArticolo As String = CType(Me.cmbCodiceArticolo.Text, String)
            Dim dataConsegna As Date = Convert(Me.DateTimePickerDataConsegnaArticolo.Text)
            Dim materiale As String = cmbMateriale.Text
            Dim rigaOrdNum As Integer = CType(Me.txtNumeroRigaOrdine.Text, Integer)

            Dim numPezzi As Integer = CType(Me.txtNumeroPezziOrdine.Text, Integer)
            Dim NoteTestata As String = rtxtNoteTestata.Text
            Dim fornitore As String = cmbFornitore.Text
            Dim lotto As String = cmbLottoNum.Text

            Dim lavorazioniBBG As String = txtLavorazioneBBG.Text
            'Dim operatore As String = txtOperatore.SelectedText.ToString
            'Dim NumeroOperatore As Integer = CType(txtOperatore.SelectedValue, Integer)
            Dim trattamento As String = txtTrattamento.Text
            Dim clienteTrattamento As String = txtClienteTrattamento.Text
            Dim clienteVerniciatura As String = txtVerniciatura.Text
            Dim noteVerniciatura As String = txtNoteVerniciatura.Text
            Dim clienteHelicoil As String = txtHelicoil.Text
            Dim noteHelicoil As String = txtNoteHelicoil.Text
            Dim altreLavorazioni As String = txtAltreLavorazioni.Text
            Dim noteAltreLavorazioni As String = txtNoteAltro.Text

            Dim boolFai As Boolean
            If chkFAI.Checked Then
                boolFai = True
            Else
                boolFai = False
            End If

            Dim boolKc As Boolean
            If chkKC.Checked Then
                boolKc = True
            Else
                boolKc = False
            End If


            ret = InsertSchedaInteraPerStampa(iDIntestazione, numOrdine, codiceArticolo, dataConsegna,
                                        materiale, rigaOrdNum, numPezzi, NoteTestata, fornitore, lotto, lavorazioniBBG, PropStringOperatore, PropIntOperatore,
                                        trattamento, clienteTrattamento, clienteVerniciatura, noteVerniciatura, clienteHelicoil, noteHelicoil,
                                        altreLavorazioni, noteAltreLavorazioni, boolFai, boolKc)

            If Not ret Is Nothing Then
                CommandBarLabel1.Text = "Salvata Anche Scheda In DB Per Stampa"
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

    Private Sub BtnImportaInDatabase_Click(sender As Object, e As EventArgs) Handles btnImportaInDatabase.Click
        Dim excelFileName As String
        Dim excelFilePath As String
        Dim openFileDialog1 As New OpenFileDialog()
        Dim ret As Integer?
        Dim result As DialogResult

        openFileDialog1.Filter = "Excel xlsm files (*.xlsm)|*.xlsm|" _
        & "Excel xlsx files (*.xlsx)|*.xlsx|" _
        & "Text Files (*.txt)|*.txt|" _
        & "Word Documents (*.doc;*.docx)|*.doc;*.docx|" _
        & "Image Files (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|" _
        & "All Files(*.*)|"

        'I selected the users my document folder
        'openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        'openFileDialog1.InitialDirectory = "C:\Users\fabri\Documents\BBGSCHEDA\OrdImportExcel\"
        openFileDialog1.InitialDirectory = "\\FABDESKTOPBBG\Users\fabri\Documents\BBG\OrdImportExcel\"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                excelFileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName)

                excelFilePath = openFileDialog1.FileName

                If (excelFileName IsNot Nothing) Then
                    ' Insert code to read the stream here.
                    ret = ImportDataFromExcel(excelFilePath, excelFileName)
                    If ret = 1 Then
                        result = MessageBox.Show("Inserimento Dati Excel In Database Avvenuto Con Successo !", "Salva Excel in Database", MessageBoxButtons.OKCancel)

                        If result = DialogResult.Cancel Then
                            Exit Sub
                        End If
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show("Non si legge nessun file dal disco. Original error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Attenzione non hai selezionato nessun file.")
        End If

    End Sub


    Public Function ImportDataFromExcel(excelFilePath As String, ByVal excelFileName As String) As Integer

        Dim ret As Integer = 0

        'Nome Tabella Nuovo Ordine Importato da excel
        Dim ssqltable As String = "tab" & excelFileName & "$"

        'Nome Tabella Nuovo Ordine mi serve per importarla nella tabella temporanea
        PropOrdineStampaAutomatica = ssqltable

        Dim myexceldataquery As String = "SELECT * FROM " & "[" & ssqltable & "]"

        Try
            'crea le connctionstring 
            Dim sexcelconnectionstring As String = CreateConnectionString(excelFilePath)
            Dim ssqlconnectionstring As String = ConfigurationManager.ConnectionStrings("dbSchedaLavoroBBGConnectionString").ConnectionString

            'esegue una stored procedure per cancellare una tabella se esiste
            Using delCommand = _db.GetStoredProcCommand("spDropSeEsiste")
                _db.AddInParameter(delCommand, "tableName", DbType.String, ssqltable)
                _db.ExecuteNonQuery(delCommand)
            End Using

            'Esegue una stored procedure per creare una tabella 
            Using createCommand = _db.GetStoredProcCommand("sp_tabCreate")
                _db.AddInParameter(createCommand, "tabName", DbType.String, ssqltable)
                _db.ExecuteNonQuery(createCommand)
            End Using

            'serie di comandi per la bulk copy data da file excel in una tabella database sql server
            Dim oledbconn As New OleDbConnection(sexcelconnectionstring)
            Dim oledbcmd As New OleDbCommand(myexceldataquery, oledbconn)
            oledbconn.Open()
            Dim dr As OleDbDataReader = oledbcmd.ExecuteReader()
            Dim bulkcopy As New SqlBulkCopy(ssqlconnectionstring)
            bulkcopy.DestinationTableName = ssqltable


            If Not dr Is Nothing Then
                While dr.Read()
                    bulkcopy.WriteToServer(dr)
                End While
                ret = 1
            Else
                dr.Close()
                oledbconn.Close()
                Return ret
                Exit Function
            End If

            dr.Close()
            oledbconn.Close()

        Catch ex As Exception
            MessageBox.Show("Errore ImportDataFromExcel : " & ex.Message)
        End Try
        Return ret

    End Function

    Public Shared Function CreateConnectionString(ByVal ExcelFilePath As String) As String
        Dim result As String = String.Empty
        Try
            If ExcelFilePath.ToLower.EndsWith(".xlsm") Then

                result = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;HDR=NO;IMEX=1""", ExcelFilePath)
            Else
                result = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=""Excel 8.0;HDR=NO;IMEX=1""", ExcelFilePath)
            End If
        Catch ex As Exception

        End Try
        Return result

    End Function

    Private Sub BtnArticoliRegistrati_Click(sender As Object, e As EventArgs) Handles btnArticoliRegistrati.Click
        Dim frmArt As New frmArticoliRegistrati
        frmArt.Show()
    End Sub


#End Region

#Region "Popola Combo"

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
                Me.txtLavorazioneBBG.Items.Add(datareader("Lavorazioni"))
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
                Me.cmbMateriale.Items.Add(datareader("Materiale"))
            End While
        End Using
    End Sub

    Public Sub RiempiComboOperatore()
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand

        Dim connectionstring As String = "Provider=SQLOLEDB;Data Source=UTENTEBBGSQL-PC\SQLEXPRESS;Initial Catalog=dbSchedaLavoroSviluppo;User Id=sa;Password=tito;"
        'Dim connectionstring As String = "Provider = SQLOLEDB;Data Source=FABLENOVO;Initial Catalog=dbSchedaLavoroSviluppo;Integrated Security=SSPI"

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

    Private Sub CmbOrdineArticolo_DropDown(sender As Object, e As EventArgs) Handles cmbOrdineArticolo.DropDown

        'Dim data As Date = Convert(Me.DateTimePickerConsegna.Text)
        'Dim anno As Integer = Year(data)
        Dim strAnno As String = CType(cmbAnnoPerOrdini.SelectedItem, String)
        Dim nomeTabella As String = "tblOrdini" + strAnno

        '    'Ripulisce il combo
        cmbOrdineArticolo.Items.Clear()
        cmbOrdineArticolo.Text = String.Empty

        Try

            CommandBarLabel1.Text = "Gli Ordini Visualizzati Sono  : " & " ORDINI LEONARDO " & strAnno

            Dim cmdOrdine As DbCommand
            Dim strSQL As String = "SELECT ID, CodiceOrdine FROM " + nomeTabella

            cmdOrdine = _db.GetSqlStringCommand(strSQL)

            Using datareader As IDataReader = _db.ExecuteReader(cmdOrdine)
                While datareader.Read
                    Me.cmbOrdineArticolo.Items.Add(datareader("CodiceOrdine"))
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Errore Riempimento Combo Ordini : " & ex.Message)
        End Try


    End Sub


    Private Sub CmbOrdineArticolo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrdineArticolo.SelectedIndexChanged

        Try
            Dim strCodiceOrdine As String = Me.cmbOrdineArticolo.Text

            'TODO Condizione se esiste Ordine

            Dim strNomeTabella As String = "tab" & strCodiceOrdine & "$"
            SetComboArticoloByOrdine(strNomeTabella)

            'Assegna articolo alla proprieta per la ricerca disegni
            propCodiceArticolo = CType(Me.cmbCodiceArticolo.Text, String)

            'Proprieta Globale Codice Ordine Per Stampa Automatica
            PropOrdineStampaAutomatica = strCodiceOrdine

            'textbox per la stampa automatica
            txtOrdineDaStampare.Text = PropOrdineStampaAutomatica

        Catch ex As Exception
            MessageBox.Show("Errore cmbOrdineArticolo_SelectedIndexChanged : " & ex.Message)
        End Try

    End Sub


    Public Sub SetComboArticoloByOrdine(ByVal strNomeTabella As String)
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        'Dim connectionString As String = ConfigurationManager.ConnectionStrings("dbSchedaLavoroBBGConnectionString").ConnectionString
        Dim connectionstring As String = "Provider=SQLOLEDB;Data Source=UTENTEBBGSQL-PC\SQLEXPRESS;Initial Catalog=dbSchedaLavoroSviluppo;User Id=sa;Password=tito;"
        'Dim connectionstring As String = "Provider = SQLOLEDB;Data Source=FABLENOVO;Initial Catalog=dbSchedaLavoroSviluppo;Integrated Security=SSPI"
        Dim strSQL As String = "SELECT Riga, Materiale, Quantita, Descrizione, DataConsegna, Ordine, Prezzo, CodicePadre, Meccanica, Note, Totale FROM " & strNomeTabella

        Try
            con = New OleDbConnection(connectionstring)
            con.Open()
            cmd = New OleDbCommand(strSQL, con)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim bs1 As New BindingSource()
            bs1.DataSource = dt
            Me.cmbCodiceArticolo.DisplayMember = "Materiale"
            Me.cmbCodiceArticolo.ValueMember = "Riga"
            Me.cmbCodiceArticolo.DataSource = bs1
        Catch ex As Exception
            MessageBox.Show("Il Codice Ordine Non è In Database Aggiungere!! " & ex.Message)
            RipulisciControlliSeOrdManca()
        End Try

    End Sub

    Public Sub RipulisciControlliSeOrdManca()
        'Ripulisce i combo windows

        cmbCodiceArticolo.Text = String.Empty
        txtMeccanica.Text = String.Empty
        cmbFornitore.Text = String.Empty
        rtxtNoteTestata.Text = String.Empty
        txtNumeroRigaOrdine.Text = String.Empty
        txtNumeroPezziOrdine.Text = String.Empty
        cmbMateriale.Text = String.Empty
        cmbLottoNum.Text = String.Empty

        'Ripulisce la griglia disegni al cambio articolo
        Dim bindClear As New BindingSource
        Dim dsVuoto As New DataSet
        dsVuoto.Clear()
        bindClear.DataSource = dsVuoto
        DataGridView1.DataSource = bindClear

        'Campo di testo sulla barra menu
        CommandBarLabel1.Text = String.Empty

    End Sub

    Private Sub CmbCodiceArticolo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodiceArticolo.SelectedIndexChanged

        'Ripulisce la griglia disegni al cambio articolo
        Dim bindClear As New BindingSource
        Dim dsVuoto As New DataSet
        dsVuoto.Clear()
        bindClear.DataSource = dsVuoto
        DataGridView1.DataSource = bindClear

        cmbFornitore.Text = String.Empty
        cmbLottoNum.Text = String.Empty

        'Campo di testo sulla barra menu
        CommandBarLabel1.Text = String.Empty

        Try

            'Ordine Scelto
            Dim strCodiceOrdine As String = "tab" & Me.cmbOrdineArticolo.Text & "$"

            'Assegna articolo alla proprieta per la ricerca disegni
            propCodiceArticolo = CType(Me.cmbCodiceArticolo.Text, String)

            Dim strArticolo As String = Me.cmbCodiceArticolo.Text

            Dim strSQL As String = "SELECT Riga, Materiale, Quantita, Descrizione, DataConsegna, Ordine, Prezzo, CodicePadre, Meccanica, Note, Totale FROM [" & strCodiceOrdine & "]  WHERE (Riga = " & cmbCodiceArticolo.SelectedValue.ToString & ") AND (Materiale = N'" & strArticolo & "'" & ") ORDER BY [Riga]"

            Dim cmd As DbCommand = _db.GetSqlStringCommand(strSQL)

            Using datareader As IDataReader = _db.ExecuteReader(cmd)

                While datareader.Read
                    txtNumeroRigaOrdine.Text = CType(datareader("Riga"), String)
                    txtNumeroPezziOrdine.Text = CType(datareader("Quantita"), String)
                    rtxtNoteTestata.Text = CType(datareader("Note"), String)
                    Dim dataConsegna As Date = Convert(datareader("DataConsegna"))
                    If Not IsDBNull(datareader("Meccanica")) Then
                        Dim strMeccanica As String = datareader("Meccanica").ToString
                        txtMeccanica.Text = strMeccanica
                        txtMeccanica.ForeColor = Color.Black
                        propMeccanica = strMeccanica
                    Else
                        txtMeccanica.Text = "Meccanica Non Presente!"
                        txtMeccanica.ForeColor = Color.Red
                    End If
                    DateTimePickerDataConsegnaArticolo.Value = CDate(dataConsegna)
                End While
            End Using


        Catch ex As Exception
            MessageBox.Show("Errore cmbCodiceArticolo_SelectedIndexChanged : " & ex.Message)
        End Try

    End Sub


#End Region

#Region "Inserisci in Database Testata Scheda lavoro"

    Public Function SalvaTestataSchedaLavoroBusLayer() As Integer

        Dim retScheda As Integer?
        Dim intScheda As Integer?
        Dim pezziOrdNum As Integer
        Dim intContatore As Integer = contatore()
        propIdIntestazione = intContatore

        Dim iDIntestazione As Integer = intContatore
        Dim data As Date = Convert(Me.DateTimePickerDataConsegnaArticolo.Text)
        propCodiceArticolo = CType(Me.cmbCodiceArticolo.Text, String)
        Dim ordineArticolo As String = cmbOrdineArticolo.Text
        'Numero Pezzi e Numero Riga sono in evento validating
        pezziOrdNum = Integer.Parse(txtNumeroPezziOrdine.Text)
        Dim rigaOrdNum As Integer = Integer.Parse(txtNumeroRigaOrdine.Text)
        Dim materiale As String = cmbMateriale.Text
        Dim noteTestata As String = rtxtNoteTestata.Text
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

        Catch SqlEx As SqlException
            MessageBox.Show("Errori Database : " & SqlEx.Message)
        End Try

        Return rowsAffected

    End Function

#End Region

#Region "Inserisci in Database Lavorazioni"


    Public Function SalvaLavorazioniBuslayer() As Integer

        Dim retLavorazioni As Nullable(Of Integer)

        Try
            'ID 
            Dim iDIntestazione As Integer = propIdIntestazione
            Dim codArticolo As String = propCodiceArticolo
            Dim bolFAI As Boolean = chkFAI.Checked
            Dim bolKC As Boolean = chkKC.Checked

            Dim lavorazioneBBG As String = txtLavorazioneBBG.Text
            ' Dim operatore As String = txtOperatore.Text
            ' Dim NumeroOperatore As Integer = CType(txtOperatore.SelectedValue, Integer)
            Dim trattamento As String = txtTrattamento.Text
            Dim clienteTrattamento As String = txtClienteTrattamento.Text
            Dim verniciatura As String = txtVerniciatura.Text
            Dim noteVerniciatura As String = txtNoteVerniciatura.Text
            Dim helicoil As String = txtHelicoil.Text
            Dim noteHelicoil As String = txtNoteHelicoil.Text
            Dim altreEventualiLavorazioni As String = txtAltreLavorazioni.Text
            Dim noteAltreEventualiLav As String = txtNoteAltro.Text

            retLavorazioni = InsertLavorazioniSchedaLavoro(iDIntestazione, codArticolo, lavorazioneBBG,
                                                           PropStringOperatore, PropIntOperatore, trattamento, clienteTrattamento,
                                                           verniciatura, noteVerniciatura,
                                                           helicoil, noteHelicoil, altreEventualiLavorazioni, noteAltreEventualiLav, bolFAI, bolKC)


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


    Public Function InserisciSoloIDLavorazioniSeVuote() As Integer

        Dim intContatoreLavorazioni As Integer = propIdIntestazione
        Dim CodiceArticoloDb As String = propCodiceArticolo

        Dim IDIntestazione As Integer = intContatoreLavorazioni
        Dim strCodiceArticolo As String = CodiceArticoloDb

        Try
            Dim retInsertLavorazioniSoloID As Nullable(Of Integer) = InserisciSoloIDLavorazioniDAL(IDIntestazione, strCodiceArticolo)

            If Not retInsertLavorazioniSoloID Is Nothing Then
                InserisciSoloIDLavorazioniSeVuote = retInsertLavorazioniSoloID
            End If

        Catch ex As Exception
            MessageBox.Show("Errore inserisciSoloIDLavorazioniSeVuote : " & ex.Message)
        End Try

        Return InserisciSoloIDLavorazioniSeVuote

    End Function

    Public Function InserisciSoloIDLavorazioniDAL(ByVal idIntestazione As Integer, ByVal codArt As String) As Integer

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

#Region "Funzioni Utility"

    Public Function GetAll(ByVal control As Control, ByVal type As Type) As IEnumerable(Of Control)
        Dim controls As IEnumerable(Of Control) = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAll(ctrl, type)).Concat(controls).Where(Function(c) c.[GetType]() = type)
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

    Private Sub txtNumeroPezziOrdine_Validating(sender As Object, e As CancelEventArgs) Handles txtNumeroPezziOrdine.Validating
        If IsInputNumeric(txtNumeroPezziOrdine.Text) = True Then
            If txtNumeroPezziOrdine.TextLength = 0 Then
                PezziOrdNum = 0
            Else
                PezziOrdNum = CType(Me.txtNumeroPezziOrdine.Text, Integer)
            End If
        Else
            PezziOrdNum = 0
            MessageBox.Show("Per favore usare valori numerici per il numero riga o lasciarlo vuoto")
        End If
    End Sub

    Private Sub txtNumeroRigaOrdine_Validating(sender As Object, e As CancelEventArgs) Handles txtNumeroRigaOrdine.Validating
        If IsInputNumeric(txtNumeroRigaOrdine.Text) = True Then
            If txtNumeroRigaOrdine.TextLength = 0 Then
                RigaOrdNum = 0
            Else
                RigaOrdNum = CType(Me.txtNumeroRigaOrdine.Text, Integer)
            End If
        Else
            RigaOrdNum = 0
            MessageBox.Show("Per favore usare valori numerici per il numero riga o lasciarlo vuoto")
        End If
    End Sub


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
                        i = i + 1
                    End If
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Errore : " & ex.Message)
        End Try

        Return i

    End Function

    Public Function Convert(ByVal value As Date) As Date
        Dim DateValue As DateTime = CType(value, DateTime)
        Return DateValue.ToShortDateString
    End Function

    Private Sub BtnGestioneTempi_Click(sender As Object, e As EventArgs) Handles btnGestioneTempi.Click
        Dim frmTempi As New FrmGestioneTempi
        frmTempi.Show()
    End Sub

    Private Sub btnGestioneLottoMateriale_Click(sender As Object, e As EventArgs) Handles btnGestioneLottoMateriale.Click
        Dim frmGestioneLottoMateriale As New frmGestioneLottoMateriale
        frmGestioneLottoMateriale.Show()
    End Sub

    Private Sub btnStampaOrdineAutomatico_Click(sender As Object, e As EventArgs) Handles btnStampaOrdineAutomatico.Click
        Dim StampaOrdiniAutomatico As New frmStampaOrdiniAutomatico
        StampaOrdiniAutomatico.Show()
    End Sub

#End Region


End Class


#Region "Codice Vecchio o Archiviato"





'Private Sub cmbOrdineArticolo_DropDown(sender As Object, e As EventArgs) Handles cmbOrdineArticolo.DropDown

'    Dim data As Date = Convert(Me.DateTimePickerConsegna.Text)
'    Dim anno As Integer = Year(data)
'    Dim di As New IO.DirectoryInfo("C:\Users\posta\Documents\BBG\ORDINI LEONARDO\")
'    Dim nomeDir2017 As String
'    Dim nomeDi As String

'    'Ripulisce il combo
'    cmbOrdineArticolo.Items.Clear()
'    cmbOrdineArticolo.Text = String.Empty

'    Try

'        'Elenca le subDirectory nella Dir Ordini
'        Dim Drs() As IO.DirectoryInfo = di.GetDirectories()
'        'Loop dentro Ordini
'        For Each dr As IO.DirectoryInfo In Drs

'            'Nome delle Dir in Ordini e.g. :2015 , 2016 etc...
'            Dim nomeDir As String = (dr.Name)

'            'Se il nome della Dir è uguale all'anno della data selezionata
'            If (nomeDir = CStr(anno)) Then

'                'Se l'anno è >= 2017 la Dir Ordini è Leonardo senno Sirio
'                If nomeDir >= "2017" Then
'                    'Directory Ordini Leonardo
'                    Dim di2017 As New IO.DirectoryInfo("C:\Users\posta\Documents\BBG\ORDINI LEONARDO\" & nomeDir)
'                    'Collection delle Directory nelle Dir dal 2017 in poi quindi Leonardo
'                    Dim Drs2017() As IO.DirectoryInfo = di2017.GetDirectories()
'                    'Loop in Dir dal 2017 
'                    For Each dr2017 As IO.DirectoryInfo In Drs2017
'                        nomeDir2017 = (dr2017.Name)

'                        If nomeDir2017 = "ORDINI LEONARDO " & nomeDir Then
'                            Dim fileEntries As String() = Directory.GetFiles("C:\Users\posta\Documents\BBG\ORDINI LEONARDO\" & nomeDir & "\" & nomeDir2017)
'                            Dim fileName As String
'                            For Each fileName In fileEntries
'                                Dim NomeFile As String = Path.GetFileNameWithoutExtension(fileName)
'                                If Mid(NomeFile, 1, 2) = "48" Then
'                                    cmbOrdineArticolo.Items.Add(NomeFile)
'                                End If

'                            Next fileName
'                        End If
'                    Next dr2017

'                    CommandBarLabel1.Text = "Gli Ordini Visualizzati Sono  : " & " ORDINI LEONARDO " & nomeDir


'                Else

'                    'Se l'anno è inferiore al 2017 la Dir Ordini è Sirio
'                    Dim d As New IO.DirectoryInfo("C:\Users\posta\Documents\BBG\ORDINI LEONARDO\" & nomeDir)
'                    Dim DrGet() As IO.DirectoryInfo = d.GetDirectories()
'                    For Each dr3 As IO.DirectoryInfo In DrGet
'                        nomeDi = (dr3.Name)
'                        If nomeDi = "ORDINI SIRIO PANEL " & nomeDir Then
'                            Dim fileEntries As String() = Directory.GetFiles("C:\Users\posta\Documents\BBG\ORDINI LEONARDO\" & nomeDir & "\" & nomeDi)
'                            Dim fileName2 As String
'                            For Each fileName2 In fileEntries
'                                Dim NomeFile2 As String = Path.GetFileNameWithoutExtension(fileName2)
'                                If Mid(NomeFile2, 1, 2) = "48" Then
'                                    cmbOrdineArticolo.Items.Add(NomeFile2)
'                                End If
'                            Next fileName2
'                        End If
'                    Next dr3

'                    CommandBarLabel1.Text = "Gli Ordini Visualizzati Sono  : " & " ORDINI SIRIO PANEL " & nomeDir

'                End If

'            End If

'        Next dr

'    Catch ex As Exception
'        MessageBox.Show("Errore Riempimento Combo Ordini : " & ex.Message)
'    End Try


'End Sub







'ZipFile.ExtractToDirectory(pathFile, strDirZip)
'Process.Start("explorer.exe", strDirZip)
'Dim Proc As String = "Explorer.exe"
'Dim Args As String = ControlChars.Quote & IO.Path.Combine("C:\", "Folder with spaces in the name") & ControlChars.Quote


'If Not (propCodicePadre = String.Empty) Then
'    If Not (propCodicePadre = propCodiceArticolo) Then
'        Array.Resize(arrFile, arrFile.Length + 1)
'        arrFile(arrFile.Length - 1) = propCodicePadre
'    End If
'End If

''Crea La directory con nome articolo dove verranno copiati i disegni
'If (Not System.IO.Directory.Exists(strPathArticolo)) Then
'    System.IO.Directory.CreateDirectory(strPathArticolo)
'End If

'Public Sub SaveFile(ByVal filePath As String, ByVal codArticolo As String)

'    Try

'        Dim filebyte As Byte() = Nothing
'        Dim ssqlconnectionstring As String = ConfigurationManager.ConnectionStrings("dbSchedaLavoroBBGConnectionString").ConnectionString
'        Dim con As New SqlConnection(ssqlconnectionstring)
'        Dim cmd As SqlCommand = Nothing

'        filebyte = System.IO.File.ReadAllBytes(filePath)

'        cmd = New SqlCommand("INSERT INTO tblFileDisegni (CodiceArticolo,FilePdfByteArray) VALUES (@CodiceArticolo,@FilePdfByteArray", con)
'        cmd.Parameters.Add("@CodiceArticolo", SqlDbType.NVarChar).Value = codArticolo
'        cmd.Parameters.Add("@FilePdfByteArray", SqlDbType.VarBinary).Value = filebyte

'        con.Open()
'        cmd.ExecuteNonQuery()
'        con.Close()

'    Catch ex As Exception
'        MsgBox(Err.Description, MsgBoxStyle.Exclamation)
'    End Try


'End Sub

'Public Sub GetDisegni()

'    Dim connectionString As String = ConfigurationManager.ConnectionStrings("dbSchedaLavoroBBGConnectionString").ConnectionString

'    Dim sql As String = "SELECT [CodiceArticolo],[FilePdfByteArray] FROM [tblFileDisegni]"
'    Dim connection As New SqlConnection(connectionString)
'    Dim dataadapter As New SqlDataAdapter(sql, connection)
'    Dim ds As New DataSet()
'    connection.Open()
'    dataadapter.Fill(ds, "tblFileDisegni")
'    connection.Close()
'    DataGridViewDisegni.DataSource = ds
'    DataGridViewDisegni.DataMember = "tblFileDisegni"
'End Sub


'Public Sub ChangeProgress(ByVal info As UIProgress)
'    ToolStripProgressBar1.Value = CInt(100.0 * info.lngBytes / info.lngMaxBytes)
'    ToolStripStatusLabel1.Text = "Sto copiando il file : " + info.strName
'End Sub

'Private Sub ErrorThrow(ByVal err As UIError)
'    Dim msg As String = String.Format("Errore durante la copia del file {0}\n{1}\n Click OK per continuare la copia dei file ", err.strFilePath, err.strErrorMsg)
'    err.drResult = MessageBox.Show(msg, "Errore Copia File", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
'End Sub

'Private Sub WorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
'    UpdateUI(False)
'End Sub

'Private Sub UpdateUI(ByVal docopy As Boolean)
'    ToolStripStatusLabel1.Visible = docopy
'    ToolStripProgressBar1.Visible = docopy
'    ToolStripStatusLabel1.Text = "Copia File Avviata..."
'    ToolStripProgressBar1.Value = 0
'End Sub


'Public Sub New()

'    InitializeComponent()
'    AddHandler bwCopier.DoWork, AddressOf DoCopy
'    AddHandler bwCopier.RunWorkerCompleted, AddressOf WorkerCompleted

'    bwCopier.WorkerSupportsCancellation = True

'    OnChange = AddressOf ChangeProgress
'    OnError = AddressOf ErrorThrow

'    UpdateUI(False)

'End Sub

'Public Delegate Sub ProgressChanged(ByVal info As UIProgress)
'Public Delegate Sub CopyError(ByVal err As UIError)
'Public OnChange As ProgressChanged
'Public OnError As CopyError



'Public Class UIProgress

'    Public strName As String
'    Public lngBytes As Long
'    Public lngMaxBytes As Long

'    Public Sub New(ByVal FileName As String,
'         ByVal Bytes As Long, ByVal MaxBytes As Long)
'        strName = FileName
'        Bytes = Bytes
'        MaxBytes = MaxBytes
'    End Sub


'End Class

'Public Class UIError

'    Public strErrorMsg As String
'    Public strFilePath As String
'    Public drResult As DialogResult

'    Public Sub New(ByVal ex As Exception,
'         ByVal FilePath As String)
'        strErrorMsg = ex.Message
'        strFilePath = FilePath
'        drResult = DialogResult.Cancel
'    End Sub


'End Class

'Public Sub DoCopy(ByVal sender As Object, ByVal e As DoWorkEventArgs)

'    propNomeArticoloPerNomeDir = propCodiceArticolo.Replace("/", "-")

'    Dim strPathArticolo As String = propPathDisegniApprovati & propNomeArticoloPerNomeDir

'    'Crea La directory con nome articolo dove verranno copiati i disegni
'    If (Not System.IO.Directory.Exists(strPathArticolo)) Then
'        System.IO.Directory.CreateDirectory(strPathArticolo)
'    End If

'    'Array file articoli meccanica e codicepadre da ricercare
'    Dim arrFile As String() = {propCodiceArticolo}

'    If Not (propCodicePadre = String.Empty) Then
'        If Not (propCodicePadre = propCodiceArticolo) Then
'            Array.Resize(arrFile, arrFile.Length + 1)
'            arrFile(arrFile.Length - 1) = propCodicePadre
'        End If
'    End If

'    If Not (propMeccanica = String.Empty) Then
'        If Not (propMeccanica = propCodiceArticolo) Then
'            Array.Resize(arrFile, arrFile.Length + 1)
'            arrFile(arrFile.Length - 1) = propMeccanica
'        End If
'    End If

'    'Collection dei file trovati 
'    Dim lstFiles As New List(Of FileInfo)

'    'Path dei disegni da copiare
'    Dim strFolderPath As String = "\\Bbgmeccanica\hrd disk est f\CARTELLA DISEGNI\"

'    'Oggetto directory disegni da cercare
'    Dim diDirectory As New DirectoryInfo(strFolderPath)

'    Dim lngMaxBytes As Long = 0


'    nomeFilePerRicerca = Trim(propNomeArticoloPerNomeDir)
'    'Directory 
'    Dim fiFolder As FileInfo() = diDirectory.GetFiles(nomeFilePerRicerca, SearchOption.AllDirectories)


'    'Per ogni file in array arrFile
'    For Each strFiles As String In arrFile
'        For Each fiFile As FileInfo In fiFolder
'            If ((fiFile.Attributes And FileAttributes.Directory) <> 0) Then Continue For
'            lstFiles.Add(fiFile)
'            lngMaxBytes += fiFile.Length
'        Next fiFile

'    Next strFiles

'    Dim lngBytes As Long = 0

'    For Each file As FileInfo In lstFiles
'        'Copia file nella dir a parte e in una dir con nome articolo
'        Try
'            Me.BeginInvoke(OnChange, New Object() {New UIProgress(file.Name, lngBytes, lngMaxBytes)})

'            'Copia i disegni 
'            System.IO.File.Copy(file.FullName, strPathArticolo + "\" + file.Name, True)

'            'TODO: Aggiungere file in database e popolare griglia
'            SaveFile(strPathArticolo + "\" + file.Name, propCodiceArticolo)



'        Catch ex As Exception
'            Dim err As New UIError(ex, file.FullName)
'            Me.Invoke(OnError, New Object() {err})
'            If err.drResult = Windows.Forms.DialogResult.Cancel Then Exit For
'        End Try

'        lngBytes += file.Length

'    Next file

'End Sub


'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
'    Dim strsql As String = Nothing
'    Dim con As New SqlConnection("Data Source=LOCALHOS-A4AE79\LOCALHOST1;Initial Catalog=library_alborz;Integrated Security=True")
'    Dim da As New SqlDataAdapter()
'    Dim ds As New DataSet()

'    Try
'        strsql = "select pdffld from  pdftbl "
'        da = New SqlDataAdapter(strsql, con)
'        da.Fill(ds, "tbl")

'        'Get image data from gridview column.
'        Dim pdfData As Byte() = Convert.ToByte(ds.Tables("tbl").Rows(0)(0))

'        'Initialize pdf  variable

'        'Read pdf  data into a memory stream
'        Using ms As New MemoryStream(pdfData, 0, pdfData.Length)
'            ms.Write(pdfData, 0, pdfData.Length)

'            'Set pdf variable value using memory stream.
'            PdfDocument1.Load(ms)
'            PdfPageView1.Document = PdfDocument1

'            PdfPageView1.Refresh()


'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.ToString())
'    End Try
'End Sub


'Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork


'    'Array file articoli meccanica e codicepadre da ricercare
'    Dim arrFile As String() = {propCodiceArticolo}

'    'Controlla se esiste il codice padre
'    If Not (propCodicePadre = String.Empty) Then
'        If Not (propCodicePadre = propCodiceArticolo) Then
'            Array.Resize(arrFile, arrFile.Length + 1)
'            arrFile(arrFile.Length - 1) = propCodicePadre
'        End If
'    End If

'    'Controlla se esiste la meccanica
'    If Not (propMeccanica = String.Empty) Then
'        If Not (propMeccanica = propCodiceArticolo) Then
'            Array.Resize(arrFile, arrFile.Length + 1)
'            arrFile(arrFile.Length - 1) = propMeccanica
'        End If
'    End If


'    'Dir Disegni
'    Dim pathDir As String
'    pathDir = "\\Bbgmeccanica\hrd disk est f\CARTELLA DISEGNI\"

'    For l_index As Integer = 0 To UBound(arrFile)
'        BackgroundWorker1.ReportProgress(l_index)
'        Dim l_text As String = CStr(arrFile(l_index).ToString)
'        propCodiceArticolo = Trim(l_text.Replace("/", "-"))

'        ProcessDirectory(pathDir)

'        If BackgroundWorker1.CancellationPending Then
'            BackgroundWorker1.ReportProgress(CInt(l_index), "In Cancellazione...")
'            Exit For
'        End If
'    Next

'    If BackgroundWorker1.CancellationPending Then
'        e.Cancel = True
'        BackgroundWorker1.ReportProgress(100, "Cancellato.")
'    End If

'End Sub

'Public Sub ProcessDirectory(ByVal targetDirectory As String)
'    Dim fileEntries As String() = Directory.GetFiles(targetDirectory, "*" & propCodiceArticolo & "*")
'    ' Process the list of files found in the directory.
'    Dim fileName As String
'    For Each fileName In fileEntries
'        ProcessFile(fileName)
'    Next fileName
'    Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
'    ' Recurse into subdirectories of this directory.
'    Dim subdirectory As String
'    For Each subdirectory In subdirectoryEntries
'        ProcessDirectory(subdirectory)
'    Next subdirectory
'End Sub 'ProcessDirectory

'Public Sub ProcessFile(ByVal pathF As String)
'    Try
'        nomeFile = Path.GetFileName(pathF)
'        Dim directoryPath As String = Path.GetDirectoryName(pathF)
'        If Not File.Exists(Path.Combine(strPathArticolo + "\", nomeFile)) Then
'            My.Computer.FileSystem.CopyFile(Path.Combine(directoryPath, nomeFile), Path.Combine(strPathArticolo + "\", nomeFile))
'            collNomeFile.Add(nomeFile)
'        End If
'        'CheckedListBox1.Items.Add(fileName)
'    Catch ex As Exception
'        MessageBox.Show("Errore : " & ex.Message)
'    End Try
'End Sub 'ProcessFile

'Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
'    'ToolStripStatusLabel1.Text = e.ProgressPercentage.ToString & "% Completato."
'    'Me.ProgressBar1.Value = e.ProgressPercentage
'End Sub

'Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

'    If e.Error IsNot Nothing Then
'        '' if BackgroundWorker terminated due to error
'        MessageBox.Show(e.Error.Message)
'        ToolStripStatusLabel1.Text = "Errore Task!"

'    ElseIf e.Cancelled Then
'        '' otherwise if it was cancelled
'        MessageBox.Show("Task cancellato!")
'        ToolStripStatusLabel1.Text = "Task Cancellato!"

'    Else
'        ' '' otherwise it completed normally
'        'For Each item In collNomeFile
'        '    CheckedListBox1.Items.Add(item)
'        'Next

'        'For i As Integer = 0 To CheckedListBox1.Items.Count - 1
'        '    CheckedListBox1.SetItemChecked(i, True)
'        'Next

'        MessageBox.Show("File Trovati Copiati e Incollati Completato!")

'        'Me.ProgressBar1.Value = 0
'        ToolStripStatusLabel1.Text = String.Empty
'    End If

'End Sub





#End Region