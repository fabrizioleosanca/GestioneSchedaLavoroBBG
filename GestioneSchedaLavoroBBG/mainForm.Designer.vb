<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBarraTitolo = New System.Windows.Forms.Panel()
        Me.lblSchedaLavorazione = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadGroupBoxRegistraTestata = New Telerik.WinControls.UI.RadGroupBox()
        Me.TableLayoutPanelTestata = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPrevistaConsegna = New System.Windows.Forms.Label()
        Me.lblOrdineArticolo = New System.Windows.Forms.Label()
        Me.cmbOrdineArticolo = New System.Windows.Forms.ComboBox()
        Me.lblCodiceArticolo = New System.Windows.Forms.Label()
        Me.cmbCodiceArticolo = New System.Windows.Forms.ComboBox()
        Me.lblNumRigaOrdine = New System.Windows.Forms.Label()
        Me.txtNumeroRigaOrdine = New System.Windows.Forms.TextBox()
        Me.lblNumeroPezziOrdine = New System.Windows.Forms.Label()
        Me.txtNumeroPezziOrdine = New System.Windows.Forms.TextBox()
        Me.lblMateriale = New System.Windows.Forms.Label()
        Me.cmbMateriale = New System.Windows.Forms.ComboBox()
        Me.lblMeccanica = New System.Windows.Forms.Label()
        Me.txtMeccanica = New System.Windows.Forms.TextBox()
        Me.lblDataConsegnaArt = New System.Windows.Forms.Label()
        Me.DateTimePickerDataConsegnaArticolo = New System.Windows.Forms.DateTimePicker()
        Me.cmbAnnoPerOrdini = New System.Windows.Forms.ComboBox()
        Me.lblLotto = New System.Windows.Forms.Label()
        Me.cmbLottoNum = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.rtxtNoteTestata = New System.Windows.Forms.RichTextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblFornitore = New System.Windows.Forms.Label()
        Me.cmbFornitore = New System.Windows.Forms.ComboBox()
        Me.lblStampaAutom = New System.Windows.Forms.Label()
        Me.txtOrdineDaStampare = New System.Windows.Forms.TextBox()
        Me.btnStampaOrdineAutomatico = New System.Windows.Forms.Button()
        Me.RadGroupBoxRegLavArt = New Telerik.WinControls.UI.RadGroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFAI = New System.Windows.Forms.Label()
        Me.lblLavorazioneBBG = New System.Windows.Forms.Label()
        Me.lblClienteTrattamento = New System.Windows.Forms.Label()
        Me.lblVerniciatura = New System.Windows.Forms.Label()
        Me.lblHelicoil = New System.Windows.Forms.Label()
        Me.lblAltreLavorazioni = New System.Windows.Forms.Label()
        Me.txtAltreLavorazioni = New System.Windows.Forms.TextBox()
        Me.lblOperatore = New System.Windows.Forms.Label()
        Me.lbTrattamento = New System.Windows.Forms.Label()
        Me.lblNoteVerniciatura = New System.Windows.Forms.Label()
        Me.lblNoteHelicoil = New System.Windows.Forms.Label()
        Me.lblNoteAltro = New System.Windows.Forms.Label()
        Me.txtNoteAltro = New System.Windows.Forms.TextBox()
        Me.txtLavorazioneBBG = New System.Windows.Forms.ComboBox()
        Me.txtClienteTrattamento = New System.Windows.Forms.ComboBox()
        Me.txtTrattamento = New System.Windows.Forms.ComboBox()
        Me.txtVerniciatura = New System.Windows.Forms.ComboBox()
        Me.txtHelicoil = New System.Windows.Forms.ComboBox()
        Me.txtOperatore = New System.Windows.Forms.ComboBox()
        Me.txtNoteVerniciatura = New System.Windows.Forms.ComboBox()
        Me.txtNoteHelicoil = New System.Windows.Forms.ComboBox()
        Me.lblOperaNum = New System.Windows.Forms.Label()
        Me.txtNumOperatore = New System.Windows.Forms.Label()
        Me.lblKC = New System.Windows.Forms.Label()
        Me.chkFAI = New System.Windows.Forms.CheckBox()
        Me.chkKC = New System.Windows.Forms.CheckBox()
        Me.RadGroupBoxSalvaScheda = New Telerik.WinControls.UI.RadGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomeFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercorsoFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnApriFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bwCopier = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.btnArticoliRegistrati = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnImportaInDatabase = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnCaricaDisegniArticolo = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadButtonRegistra = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnStampaMainForm = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnGestioneTempi = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator6 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnGestioneLottoMateriale = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator7 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnEsciApplicazione = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator8 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.PanelBarraTitolo.SuspendLayout()
        CType(Me.RadGroupBoxRegistraTestata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxRegistraTestata.SuspendLayout()
        Me.TableLayoutPanelTestata.SuspendLayout()
        CType(Me.cmbLottoNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLottoNum.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLottoNum.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxRegLavArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxRegLavArt.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RadGroupBoxSalvaScheda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxSalvaScheda.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraTitolo
        '
        Me.PanelBarraTitolo.BackgroundImage = CType(resources.GetObject("PanelBarraTitolo.BackgroundImage"), System.Drawing.Image)
        Me.PanelBarraTitolo.Controls.Add(Me.lblSchedaLavorazione)
        Me.PanelBarraTitolo.Controls.Add(Me.Label1)
        Me.PanelBarraTitolo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitolo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitolo.Name = "PanelBarraTitolo"
        Me.PanelBarraTitolo.Size = New System.Drawing.Size(1023, 54)
        Me.PanelBarraTitolo.TabIndex = 0
        '
        'lblSchedaLavorazione
        '
        Me.lblSchedaLavorazione.AutoSize = True
        Me.lblSchedaLavorazione.BackColor = System.Drawing.Color.Transparent
        Me.lblSchedaLavorazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedaLavorazione.ForeColor = System.Drawing.Color.Gold
        Me.lblSchedaLavorazione.Location = New System.Drawing.Point(406, 9)
        Me.lblSchedaLavorazione.Name = "lblSchedaLavorazione"
        Me.lblSchedaLavorazione.Size = New System.Drawing.Size(337, 33)
        Me.lblSchedaLavorazione.TabIndex = 1
        Me.lblSchedaLavorazione.Text = "Scheda Di Lavorazione"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BBG Metalmeccanica Snc"
        '
        'RadGroupBoxRegistraTestata
        '
        Me.RadGroupBoxRegistraTestata.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxRegistraTestata.Controls.Add(Me.TableLayoutPanelTestata)
        Me.RadGroupBoxRegistraTestata.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBoxRegistraTestata.HeaderText = "Registra Informazioni Articolo"
        Me.RadGroupBoxRegistraTestata.Location = New System.Drawing.Point(12, 142)
        Me.RadGroupBoxRegistraTestata.Name = "RadGroupBoxRegistraTestata"
        Me.RadGroupBoxRegistraTestata.Size = New System.Drawing.Size(967, 271)
        Me.RadGroupBoxRegistraTestata.TabIndex = 3
        Me.RadGroupBoxRegistraTestata.Text = "Registra Informazioni Articolo"
        '
        'TableLayoutPanelTestata
        '
        Me.TableLayoutPanelTestata.ColumnCount = 5
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370.0!))
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblPrevistaConsegna, 0, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblOrdineArticolo, 0, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbOrdineArticolo, 1, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblCodiceArticolo, 0, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbCodiceArticolo, 1, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblNumRigaOrdine, 3, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtNumeroRigaOrdine, 4, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblNumeroPezziOrdine, 3, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtNumeroPezziOrdine, 4, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblMateriale, 3, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbMateriale, 4, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblMeccanica, 0, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtMeccanica, 1, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblDataConsegnaArt, 3, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.DateTimePickerDataConsegnaArticolo, 4, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbAnnoPerOrdini, 1, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblLotto, 3, 4)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbLottoNum, 4, 4)
        Me.TableLayoutPanelTestata.Controls.Add(Me.rtxtNoteTestata, 1, 5)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblNote, 0, 5)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblFornitore, 0, 4)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbFornitore, 1, 4)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblStampaAutom, 0, 6)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtOrdineDaStampare, 3, 6)
        Me.TableLayoutPanelTestata.Controls.Add(Me.btnStampaOrdineAutomatico, 4, 6)
        Me.TableLayoutPanelTestata.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanelTestata.Location = New System.Drawing.Point(10, 18)
        Me.TableLayoutPanelTestata.Name = "TableLayoutPanelTestata"
        Me.TableLayoutPanelTestata.RowCount = 7
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTestata.Size = New System.Drawing.Size(955, 251)
        Me.TableLayoutPanelTestata.TabIndex = 0
        '
        'lblPrevistaConsegna
        '
        Me.lblPrevistaConsegna.Location = New System.Drawing.Point(3, 0)
        Me.lblPrevistaConsegna.Name = "lblPrevistaConsegna"
        Me.lblPrevistaConsegna.Size = New System.Drawing.Size(103, 29)
        Me.lblPrevistaConsegna.TabIndex = 0
        Me.lblPrevistaConsegna.Text = "Anno Per Ordini :"
        Me.lblPrevistaConsegna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOrdineArticolo
        '
        Me.lblOrdineArticolo.Location = New System.Drawing.Point(3, 30)
        Me.lblOrdineArticolo.Name = "lblOrdineArticolo"
        Me.lblOrdineArticolo.Size = New System.Drawing.Size(103, 30)
        Me.lblOrdineArticolo.TabIndex = 2
        Me.lblOrdineArticolo.Text = "Ordine Articolo :"
        Me.lblOrdineArticolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOrdineArticolo
        '
        Me.cmbOrdineArticolo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrdineArticolo.FormattingEnabled = True
        Me.cmbOrdineArticolo.Location = New System.Drawing.Point(113, 33)
        Me.cmbOrdineArticolo.Name = "cmbOrdineArticolo"
        Me.cmbOrdineArticolo.Size = New System.Drawing.Size(304, 25)
        Me.cmbOrdineArticolo.TabIndex = 3
        '
        'lblCodiceArticolo
        '
        Me.lblCodiceArticolo.Location = New System.Drawing.Point(3, 60)
        Me.lblCodiceArticolo.Name = "lblCodiceArticolo"
        Me.lblCodiceArticolo.Size = New System.Drawing.Size(103, 30)
        Me.lblCodiceArticolo.TabIndex = 4
        Me.lblCodiceArticolo.Text = "Codice Articolo :"
        Me.lblCodiceArticolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCodiceArticolo
        '
        Me.cmbCodiceArticolo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodiceArticolo.FormattingEnabled = True
        Me.cmbCodiceArticolo.Location = New System.Drawing.Point(113, 63)
        Me.cmbCodiceArticolo.Name = "cmbCodiceArticolo"
        Me.cmbCodiceArticolo.Size = New System.Drawing.Size(304, 25)
        Me.cmbCodiceArticolo.TabIndex = 5
        '
        'lblNumRigaOrdine
        '
        Me.lblNumRigaOrdine.Location = New System.Drawing.Point(438, 0)
        Me.lblNumRigaOrdine.Name = "lblNumRigaOrdine"
        Me.lblNumRigaOrdine.Size = New System.Drawing.Size(144, 29)
        Me.lblNumRigaOrdine.TabIndex = 8
        Me.lblNumRigaOrdine.Text = "Numero Riga Ordine :"
        Me.lblNumRigaOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumeroRigaOrdine
        '
        Me.txtNumeroRigaOrdine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroRigaOrdine.Location = New System.Drawing.Point(588, 3)
        Me.txtNumeroRigaOrdine.Name = "txtNumeroRigaOrdine"
        Me.txtNumeroRigaOrdine.Size = New System.Drawing.Size(343, 25)
        Me.txtNumeroRigaOrdine.TabIndex = 9
        '
        'lblNumeroPezziOrdine
        '
        Me.lblNumeroPezziOrdine.Location = New System.Drawing.Point(438, 30)
        Me.lblNumeroPezziOrdine.Name = "lblNumeroPezziOrdine"
        Me.lblNumeroPezziOrdine.Size = New System.Drawing.Size(144, 28)
        Me.lblNumeroPezziOrdine.TabIndex = 10
        Me.lblNumeroPezziOrdine.Text = "Numero Pezzi Ordine :"
        Me.lblNumeroPezziOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumeroPezziOrdine
        '
        Me.txtNumeroPezziOrdine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPezziOrdine.Location = New System.Drawing.Point(588, 33)
        Me.txtNumeroPezziOrdine.Name = "txtNumeroPezziOrdine"
        Me.txtNumeroPezziOrdine.Size = New System.Drawing.Size(343, 25)
        Me.txtNumeroPezziOrdine.TabIndex = 11
        '
        'lblMateriale
        '
        Me.lblMateriale.Location = New System.Drawing.Point(438, 60)
        Me.lblMateriale.Name = "lblMateriale"
        Me.lblMateriale.Size = New System.Drawing.Size(144, 28)
        Me.lblMateriale.TabIndex = 12
        Me.lblMateriale.Text = "Materiale :"
        Me.lblMateriale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMateriale
        '
        Me.cmbMateriale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMateriale.FormattingEnabled = True
        Me.cmbMateriale.Location = New System.Drawing.Point(588, 63)
        Me.cmbMateriale.Name = "cmbMateriale"
        Me.cmbMateriale.Size = New System.Drawing.Size(343, 25)
        Me.cmbMateriale.TabIndex = 13
        '
        'lblMeccanica
        '
        Me.lblMeccanica.Location = New System.Drawing.Point(3, 90)
        Me.lblMeccanica.Name = "lblMeccanica"
        Me.lblMeccanica.Size = New System.Drawing.Size(103, 20)
        Me.lblMeccanica.TabIndex = 14
        Me.lblMeccanica.Text = "Meccanica :"
        Me.lblMeccanica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMeccanica
        '
        Me.txtMeccanica.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeccanica.Location = New System.Drawing.Point(113, 93)
        Me.txtMeccanica.Name = "txtMeccanica"
        Me.txtMeccanica.Size = New System.Drawing.Size(304, 25)
        Me.txtMeccanica.TabIndex = 15
        '
        'lblDataConsegnaArt
        '
        Me.lblDataConsegnaArt.Location = New System.Drawing.Point(438, 90)
        Me.lblDataConsegnaArt.Name = "lblDataConsegnaArt"
        Me.lblDataConsegnaArt.Size = New System.Drawing.Size(144, 30)
        Me.lblDataConsegnaArt.TabIndex = 17
        Me.lblDataConsegnaArt.Text = "Data Consegna Articolo :"
        Me.lblDataConsegnaArt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePickerDataConsegnaArticolo
        '
        Me.DateTimePickerDataConsegnaArticolo.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDataConsegnaArticolo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDataConsegnaArticolo.Location = New System.Drawing.Point(588, 93)
        Me.DateTimePickerDataConsegnaArticolo.Name = "DateTimePickerDataConsegnaArticolo"
        Me.DateTimePickerDataConsegnaArticolo.Size = New System.Drawing.Size(343, 25)
        Me.DateTimePickerDataConsegnaArticolo.TabIndex = 18
        '
        'cmbAnnoPerOrdini
        '
        Me.cmbAnnoPerOrdini.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAnnoPerOrdini.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnnoPerOrdini.ForeColor = System.Drawing.Color.Red
        Me.cmbAnnoPerOrdini.FormattingEnabled = True
        Me.cmbAnnoPerOrdini.Location = New System.Drawing.Point(113, 3)
        Me.cmbAnnoPerOrdini.Name = "cmbAnnoPerOrdini"
        Me.cmbAnnoPerOrdini.Size = New System.Drawing.Size(304, 25)
        Me.cmbAnnoPerOrdini.TabIndex = 19
        '
        'lblLotto
        '
        Me.lblLotto.Location = New System.Drawing.Point(438, 120)
        Me.lblLotto.Name = "lblLotto"
        Me.lblLotto.Size = New System.Drawing.Size(144, 26)
        Me.lblLotto.TabIndex = 20
        Me.lblLotto.Text = "Lotto Codice :"
        Me.lblLotto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLottoNum
        '
        '
        'cmbLottoNum.NestedRadGridView
        '
        Me.cmbLottoNum.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLottoNum.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLottoNum.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbLottoNum.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.cmbLottoNum.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cmbLottoNum.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cmbLottoNum.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cmbLottoNum.EditorControl.MasterTemplate.EnableFiltering = True
        Me.cmbLottoNum.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cmbLottoNum.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cmbLottoNum.EditorControl.Name = "NestedRadGridView"
        Me.cmbLottoNum.EditorControl.ReadOnly = True
        Me.cmbLottoNum.EditorControl.ShowGroupPanel = False
        Me.cmbLottoNum.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cmbLottoNum.EditorControl.TabIndex = 0
        Me.cmbLottoNum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLottoNum.Location = New System.Drawing.Point(588, 123)
        Me.cmbLottoNum.Name = "cmbLottoNum"
        Me.cmbLottoNum.Size = New System.Drawing.Size(343, 23)
        Me.cmbLottoNum.TabIndex = 21
        Me.cmbLottoNum.TabStop = False
        '
        'rtxtNoteTestata
        '
        Me.rtxtNoteTestata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanelTestata.SetColumnSpan(Me.rtxtNoteTestata, 4)
        Me.rtxtNoteTestata.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtNoteTestata.Location = New System.Drawing.Point(113, 154)
        Me.rtxtNoteTestata.Name = "rtxtNoteTestata"
        Me.rtxtNoteTestata.Size = New System.Drawing.Size(818, 40)
        Me.rtxtNoteTestata.TabIndex = 7
        Me.rtxtNoteTestata.Text = ""
        '
        'lblNote
        '
        Me.lblNote.Location = New System.Drawing.Point(3, 151)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(103, 26)
        Me.lblNote.TabIndex = 16
        Me.lblNote.Text = "Note :"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFornitore
        '
        Me.lblFornitore.Location = New System.Drawing.Point(3, 120)
        Me.lblFornitore.Name = "lblFornitore"
        Me.lblFornitore.Size = New System.Drawing.Size(103, 26)
        Me.lblFornitore.TabIndex = 22
        Me.lblFornitore.Text = "Fornitore :"
        Me.lblFornitore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFornitore
        '
        Me.cmbFornitore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFornitore.FormattingEnabled = True
        Me.cmbFornitore.Location = New System.Drawing.Point(113, 123)
        Me.cmbFornitore.Name = "cmbFornitore"
        Me.cmbFornitore.Size = New System.Drawing.Size(304, 25)
        Me.cmbFornitore.TabIndex = 23
        '
        'lblStampaAutom
        '
        Me.lblStampaAutom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelTestata.SetColumnSpan(Me.lblStampaAutom, 2)
        Me.lblStampaAutom.Location = New System.Drawing.Point(3, 212)
        Me.lblStampaAutom.Name = "lblStampaAutom"
        Me.lblStampaAutom.Size = New System.Drawing.Size(414, 27)
        Me.lblStampaAutom.TabIndex = 24
        Me.lblStampaAutom.Text = "Stampa Ordine Automatico:"
        Me.lblStampaAutom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrdineDaStampare
        '
        Me.txtOrdineDaStampare.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrdineDaStampare.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdineDaStampare.Location = New System.Drawing.Point(438, 211)
        Me.txtOrdineDaStampare.Name = "txtOrdineDaStampare"
        Me.txtOrdineDaStampare.Size = New System.Drawing.Size(144, 29)
        Me.txtOrdineDaStampare.TabIndex = 25
        '
        'btnStampaOrdineAutomatico
        '
        Me.btnStampaOrdineAutomatico.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnStampaOrdineAutomatico.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStampaOrdineAutomatico.Location = New System.Drawing.Point(588, 212)
        Me.btnStampaOrdineAutomatico.Name = "btnStampaOrdineAutomatico"
        Me.btnStampaOrdineAutomatico.Size = New System.Drawing.Size(214, 26)
        Me.btnStampaOrdineAutomatico.TabIndex = 26
        Me.btnStampaOrdineAutomatico.Text = "Stampa Ordine Auto"
        Me.btnStampaOrdineAutomatico.UseVisualStyleBackColor = True
        '
        'RadGroupBoxRegLavArt
        '
        Me.RadGroupBoxRegLavArt.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxRegLavArt.Controls.Add(Me.TableLayoutPanel1)
        Me.RadGroupBoxRegLavArt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBoxRegLavArt.HeaderText = "Registrazione Lavorazioni Articolo"
        Me.RadGroupBoxRegLavArt.Location = New System.Drawing.Point(12, 419)
        Me.RadGroupBoxRegLavArt.Name = "RadGroupBoxRegLavArt"
        Me.RadGroupBoxRegLavArt.Size = New System.Drawing.Size(967, 225)
        Me.RadGroupBoxRegLavArt.TabIndex = 4
        Me.RadGroupBoxRegLavArt.Text = "Registrazione Lavorazioni Articolo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblFAI, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLavorazioneBBG, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblClienteTrattamento, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVerniciatura, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHelicoil, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAltreLavorazioni, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAltreLavorazioni, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOperatore, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTrattamento, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNoteVerniciatura, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNoteHelicoil, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNoteAltro, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNoteAltro, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLavorazioneBBG, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClienteTrattamento, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTrattamento, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVerniciatura, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHelicoil, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOperatore, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNoteVerniciatura, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNoteHelicoil, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOperaNum, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumOperatore, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblKC, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.chkFAI, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.chkKC, 4, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 30)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(952, 190)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblFAI
        '
        Me.lblFAI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFAI.Location = New System.Drawing.Point(3, 155)
        Me.lblFAI.Name = "lblFAI"
        Me.lblFAI.Size = New System.Drawing.Size(130, 29)
        Me.lblFAI.TabIndex = 30
        Me.lblFAI.Text = "FAI :"
        Me.lblFAI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLavorazioneBBG
        '
        Me.lblLavorazioneBBG.Location = New System.Drawing.Point(3, 0)
        Me.lblLavorazioneBBG.Name = "lblLavorazioneBBG"
        Me.lblLavorazioneBBG.Size = New System.Drawing.Size(129, 29)
        Me.lblLavorazioneBBG.TabIndex = 0
        Me.lblLavorazioneBBG.Text = "Lavorazione BBG :"
        Me.lblLavorazioneBBG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClienteTrattamento
        '
        Me.lblClienteTrattamento.Location = New System.Drawing.Point(3, 30)
        Me.lblClienteTrattamento.Name = "lblClienteTrattamento"
        Me.lblClienteTrattamento.Size = New System.Drawing.Size(129, 30)
        Me.lblClienteTrattamento.TabIndex = 1
        Me.lblClienteTrattamento.Text = "Cliente Trattamento :"
        Me.lblClienteTrattamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVerniciatura
        '
        Me.lblVerniciatura.Location = New System.Drawing.Point(3, 60)
        Me.lblVerniciatura.Name = "lblVerniciatura"
        Me.lblVerniciatura.Size = New System.Drawing.Size(129, 29)
        Me.lblVerniciatura.TabIndex = 2
        Me.lblVerniciatura.Text = "Cliente Verniciatura :"
        Me.lblVerniciatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHelicoil
        '
        Me.lblHelicoil.Location = New System.Drawing.Point(3, 90)
        Me.lblHelicoil.Name = "lblHelicoil"
        Me.lblHelicoil.Size = New System.Drawing.Size(129, 30)
        Me.lblHelicoil.TabIndex = 3
        Me.lblHelicoil.Text = "Cliente Helicoil :"
        Me.lblHelicoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAltreLavorazioni
        '
        Me.lblAltreLavorazioni.Location = New System.Drawing.Point(3, 120)
        Me.lblAltreLavorazioni.Name = "lblAltreLavorazioni"
        Me.lblAltreLavorazioni.Size = New System.Drawing.Size(129, 30)
        Me.lblAltreLavorazioni.TabIndex = 4
        Me.lblAltreLavorazioni.Text = "Altre Lavorazioni :"
        Me.lblAltreLavorazioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAltreLavorazioni
        '
        Me.txtAltreLavorazioni.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltreLavorazioni.Location = New System.Drawing.Point(139, 123)
        Me.txtAltreLavorazioni.Name = "txtAltreLavorazioni"
        Me.txtAltreLavorazioni.Size = New System.Drawing.Size(266, 25)
        Me.txtAltreLavorazioni.TabIndex = 9
        '
        'lblOperatore
        '
        Me.lblOperatore.Location = New System.Drawing.Point(424, 0)
        Me.lblOperatore.Name = "lblOperatore"
        Me.lblOperatore.Size = New System.Drawing.Size(113, 28)
        Me.lblOperatore.TabIndex = 10
        Me.lblOperatore.Text = "Operatore :"
        Me.lblOperatore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTrattamento
        '
        Me.lbTrattamento.Location = New System.Drawing.Point(424, 30)
        Me.lbTrattamento.Name = "lbTrattamento"
        Me.lbTrattamento.Size = New System.Drawing.Size(113, 25)
        Me.lbTrattamento.TabIndex = 11
        Me.lbTrattamento.Text = "Trattamento :"
        Me.lbTrattamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteVerniciatura
        '
        Me.lblNoteVerniciatura.Location = New System.Drawing.Point(424, 60)
        Me.lblNoteVerniciatura.Name = "lblNoteVerniciatura"
        Me.lblNoteVerniciatura.Size = New System.Drawing.Size(113, 29)
        Me.lblNoteVerniciatura.TabIndex = 12
        Me.lblNoteVerniciatura.Text = "Note Verniciatura :"
        Me.lblNoteVerniciatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteHelicoil
        '
        Me.lblNoteHelicoil.Location = New System.Drawing.Point(424, 90)
        Me.lblNoteHelicoil.Name = "lblNoteHelicoil"
        Me.lblNoteHelicoil.Size = New System.Drawing.Size(113, 28)
        Me.lblNoteHelicoil.TabIndex = 13
        Me.lblNoteHelicoil.Text = "Note Helicoil :"
        Me.lblNoteHelicoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteAltro
        '
        Me.lblNoteAltro.Location = New System.Drawing.Point(424, 120)
        Me.lblNoteAltro.Name = "lblNoteAltro"
        Me.lblNoteAltro.Size = New System.Drawing.Size(113, 30)
        Me.lblNoteAltro.TabIndex = 14
        Me.lblNoteAltro.Text = "Note Altro :"
        Me.lblNoteAltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNoteAltro
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtNoteAltro, 3)
        Me.txtNoteAltro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteAltro.Location = New System.Drawing.Point(543, 123)
        Me.txtNoteAltro.Name = "txtNoteAltro"
        Me.txtNoteAltro.Size = New System.Drawing.Size(406, 25)
        Me.txtNoteAltro.TabIndex = 19
        '
        'txtLavorazioneBBG
        '
        Me.txtLavorazioneBBG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLavorazioneBBG.FormattingEnabled = True
        Me.txtLavorazioneBBG.Location = New System.Drawing.Point(139, 3)
        Me.txtLavorazioneBBG.Name = "txtLavorazioneBBG"
        Me.txtLavorazioneBBG.Size = New System.Drawing.Size(266, 25)
        Me.txtLavorazioneBBG.TabIndex = 20
        '
        'txtClienteTrattamento
        '
        Me.txtClienteTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteTrattamento.FormattingEnabled = True
        Me.txtClienteTrattamento.Location = New System.Drawing.Point(139, 33)
        Me.txtClienteTrattamento.Name = "txtClienteTrattamento"
        Me.txtClienteTrattamento.Size = New System.Drawing.Size(266, 25)
        Me.txtClienteTrattamento.TabIndex = 21
        '
        'txtTrattamento
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTrattamento, 3)
        Me.txtTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrattamento.FormattingEnabled = True
        Me.txtTrattamento.Location = New System.Drawing.Point(543, 33)
        Me.txtTrattamento.Name = "txtTrattamento"
        Me.txtTrattamento.Size = New System.Drawing.Size(406, 25)
        Me.txtTrattamento.TabIndex = 22
        '
        'txtVerniciatura
        '
        Me.txtVerniciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerniciatura.FormattingEnabled = True
        Me.txtVerniciatura.Location = New System.Drawing.Point(139, 63)
        Me.txtVerniciatura.Name = "txtVerniciatura"
        Me.txtVerniciatura.Size = New System.Drawing.Size(266, 25)
        Me.txtVerniciatura.TabIndex = 23
        '
        'txtHelicoil
        '
        Me.txtHelicoil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelicoil.FormattingEnabled = True
        Me.txtHelicoil.Location = New System.Drawing.Point(139, 93)
        Me.txtHelicoil.Name = "txtHelicoil"
        Me.txtHelicoil.Size = New System.Drawing.Size(266, 25)
        Me.txtHelicoil.TabIndex = 24
        '
        'txtOperatore
        '
        Me.txtOperatore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperatore.FormattingEnabled = True
        Me.txtOperatore.Location = New System.Drawing.Point(543, 3)
        Me.txtOperatore.Name = "txtOperatore"
        Me.txtOperatore.Size = New System.Drawing.Size(277, 25)
        Me.txtOperatore.TabIndex = 25
        '
        'txtNoteVerniciatura
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtNoteVerniciatura, 3)
        Me.txtNoteVerniciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteVerniciatura.FormattingEnabled = True
        Me.txtNoteVerniciatura.Location = New System.Drawing.Point(543, 63)
        Me.txtNoteVerniciatura.Name = "txtNoteVerniciatura"
        Me.txtNoteVerniciatura.Size = New System.Drawing.Size(406, 25)
        Me.txtNoteVerniciatura.TabIndex = 26
        '
        'txtNoteHelicoil
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtNoteHelicoil, 3)
        Me.txtNoteHelicoil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteHelicoil.FormattingEnabled = True
        Me.txtNoteHelicoil.Location = New System.Drawing.Point(543, 93)
        Me.txtNoteHelicoil.Name = "txtNoteHelicoil"
        Me.txtNoteHelicoil.Size = New System.Drawing.Size(406, 25)
        Me.txtNoteHelicoil.TabIndex = 27
        '
        'lblOperaNum
        '
        Me.lblOperaNum.Location = New System.Drawing.Point(826, 0)
        Me.lblOperaNum.Name = "lblOperaNum"
        Me.lblOperaNum.Size = New System.Drawing.Size(31, 28)
        Me.lblOperaNum.TabIndex = 28
        Me.lblOperaNum.Text = "N°"
        Me.lblOperaNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumOperatore
        '
        Me.txtNumOperatore.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumOperatore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumOperatore.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOperatore.Location = New System.Drawing.Point(863, 0)
        Me.txtNumOperatore.Name = "txtNumOperatore"
        Me.txtNumOperatore.Size = New System.Drawing.Size(86, 30)
        Me.txtNumOperatore.TabIndex = 29
        Me.txtNumOperatore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKC
        '
        Me.lblKC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKC.Location = New System.Drawing.Point(424, 155)
        Me.lblKC.Name = "lblKC"
        Me.lblKC.Size = New System.Drawing.Size(113, 29)
        Me.lblKC.TabIndex = 31
        Me.lblKC.Text = "KC :"
        Me.lblKC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkFAI
        '
        Me.chkFAI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFAI.AutoSize = True
        Me.chkFAI.Location = New System.Drawing.Point(139, 160)
        Me.chkFAI.Name = "chkFAI"
        Me.chkFAI.Size = New System.Drawing.Size(266, 19)
        Me.chkFAI.TabIndex = 32
        Me.chkFAI.Text = "Seleziona Per FAI"
        Me.chkFAI.UseVisualStyleBackColor = True
        '
        'chkKC
        '
        Me.chkKC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkKC.AutoSize = True
        Me.chkKC.Location = New System.Drawing.Point(543, 160)
        Me.chkKC.Name = "chkKC"
        Me.chkKC.Size = New System.Drawing.Size(277, 19)
        Me.chkKC.TabIndex = 33
        Me.chkKC.Text = "Seleziona Per KC"
        Me.chkKC.UseVisualStyleBackColor = True
        '
        'RadGroupBoxSalvaScheda
        '
        Me.RadGroupBoxSalvaScheda.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxSalvaScheda.Controls.Add(Me.Panel1)
        Me.RadGroupBoxSalvaScheda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBoxSalvaScheda.HeaderText = "Disegni Articolo Selezionato"
        Me.RadGroupBoxSalvaScheda.Location = New System.Drawing.Point(12, 660)
        Me.RadGroupBoxSalvaScheda.Name = "RadGroupBoxSalvaScheda"
        Me.RadGroupBoxSalvaScheda.Size = New System.Drawing.Size(967, 202)
        Me.RadGroupBoxSalvaScheda.TabIndex = 5
        Me.RadGroupBoxSalvaScheda.Text = "Disegni Articolo Selezionato"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(5, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 175)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeFile, Me.PercorsoFile, Me.btnApriFile})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(950, 169)
        Me.DataGridView1.TabIndex = 1
        '
        'NomeFile
        '
        Me.NomeFile.DataPropertyName = "NomeFile"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeFile.DefaultCellStyle = DataGridViewCellStyle2
        Me.NomeFile.HeaderText = "Nome File"
        Me.NomeFile.Name = "NomeFile"
        Me.NomeFile.ToolTipText = "Nome del file Disegno"
        Me.NomeFile.Width = 200
        '
        'PercorsoFile
        '
        Me.PercorsoFile.DataPropertyName = "PercorsoFile"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercorsoFile.DefaultCellStyle = DataGridViewCellStyle3
        Me.PercorsoFile.HeaderText = "Percorso File"
        Me.PercorsoFile.Name = "PercorsoFile"
        Me.PercorsoFile.ToolTipText = "Percorso della posizione del file"
        Me.PercorsoFile.Width = 550
        '
        'btnApriFile
        '
        Me.btnApriFile.DataPropertyName = "btnApriFile"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApriFile.DefaultCellStyle = DataGridViewCellStyle4
        Me.btnApriFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnApriFile.HeaderText = "Apri File Pdf Disegni"
        Me.btnApriFile.Name = "btnApriFile"
        Me.btnApriFile.Text = "Apri File"
        Me.btnApriFile.ToolTipText = "Apri il file pdf per la stampa"
        Me.btnApriFile.UseColumnTextForButtonValue = True
        Me.btnApriFile.Width = 130
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 882)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1023, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        Me.CommandBarRowElement1.Text = ""
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnArticoliRegistrati, Me.CommandBarSeparator1, Me.btnImportaInDatabase, Me.CommandBarSeparator2, Me.btnCaricaDisegniArticolo, Me.CommandBarSeparator3, Me.RadButtonRegistra, Me.CommandBarSeparator4, Me.btnStampaMainForm, Me.CommandBarSeparator5, Me.btnGestioneTempi, Me.CommandBarSeparator6, Me.btnGestioneLottoMateriale, Me.CommandBarSeparator7, Me.btnEsciApplicazione, Me.CommandBarSeparator8, Me.CommandBarLabel1})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'btnArticoliRegistrati
        '
        Me.btnArticoliRegistrati.AccessibleDescription = "Articoli Registrati"
        Me.btnArticoliRegistrati.AccessibleName = "Articoli Registrati"
        Me.btnArticoliRegistrati.DisplayName = "CommandBarButton1"
        Me.btnArticoliRegistrati.DrawText = True
        Me.btnArticoliRegistrati.Image = CType(resources.GetObject("btnArticoliRegistrati.Image"), System.Drawing.Image)
        Me.btnArticoliRegistrati.Name = "btnArticoliRegistrati"
        Me.btnArticoliRegistrati.Text = "Articoli Registrati"
        Me.btnArticoliRegistrati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnArticoliRegistrati.ToolTipText = "Articoli Registrati"
        Me.btnArticoliRegistrati.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.AccessibleDescription = "CommandBarSeparator1"
        Me.CommandBarSeparator1.AccessibleName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'btnImportaInDatabase
        '
        Me.btnImportaInDatabase.AccessibleDescription = "Importa Ordini In Database"
        Me.btnImportaInDatabase.AccessibleName = "Importa Ordini In Database"
        Me.btnImportaInDatabase.DisplayName = "CommandBarButton1"
        Me.btnImportaInDatabase.DrawText = True
        Me.btnImportaInDatabase.Image = CType(resources.GetObject("btnImportaInDatabase.Image"), System.Drawing.Image)
        Me.btnImportaInDatabase.Name = "btnImportaInDatabase"
        Me.btnImportaInDatabase.Text = "Importa Ordini In Database"
        Me.btnImportaInDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnImportaInDatabase.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
        Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.DisplayName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'btnCaricaDisegniArticolo
        '
        Me.btnCaricaDisegniArticolo.AccessibleDescription = "Copia E Salva Disegni In DB"
        Me.btnCaricaDisegniArticolo.AccessibleName = "Copia E Salva Disegni In DB"
        Me.btnCaricaDisegniArticolo.DisplayName = "CommandBarButton1"
        Me.btnCaricaDisegniArticolo.DrawText = True
        Me.btnCaricaDisegniArticolo.Image = CType(resources.GetObject("btnCaricaDisegniArticolo.Image"), System.Drawing.Image)
        Me.btnCaricaDisegniArticolo.Name = "btnCaricaDisegniArticolo"
        Me.btnCaricaDisegniArticolo.Text = "Copia Disegni"
        Me.btnCaricaDisegniArticolo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCaricaDisegniArticolo.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.AccessibleDescription = "CommandBarSeparator3"
        Me.CommandBarSeparator3.AccessibleName = "CommandBarSeparator3"
        Me.CommandBarSeparator3.DisplayName = "CommandBarSeparator3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'RadButtonRegistra
        '
        Me.RadButtonRegistra.AccessibleDescription = "Registra Scheda In DB"
        Me.RadButtonRegistra.AccessibleName = "Registra Scheda In DB"
        Me.RadButtonRegistra.DisplayName = "CommandBarButton1"
        Me.RadButtonRegistra.DrawText = True
        Me.RadButtonRegistra.Image = CType(resources.GetObject("RadButtonRegistra.Image"), System.Drawing.Image)
        Me.RadButtonRegistra.Name = "RadButtonRegistra"
        Me.RadButtonRegistra.Text = "Registra Scheda"
        Me.RadButtonRegistra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RadButtonRegistra.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.AccessibleDescription = "CommandBarSeparator4"
        Me.CommandBarSeparator4.AccessibleName = "CommandBarSeparator4"
        Me.CommandBarSeparator4.DisplayName = "CommandBarSeparator4"
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.CommandBarSeparator4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'btnStampaMainForm
        '
        Me.btnStampaMainForm.AccessibleDescription = "Stampa Scheda"
        Me.btnStampaMainForm.AccessibleName = "Stampa Scheda"
        Me.btnStampaMainForm.DisplayName = "CommandBarButton1"
        Me.btnStampaMainForm.DrawText = True
        Me.btnStampaMainForm.Image = CType(resources.GetObject("btnStampaMainForm.Image"), System.Drawing.Image)
        Me.btnStampaMainForm.Name = "btnStampaMainForm"
        Me.btnStampaMainForm.Text = "Stampa Scheda"
        Me.btnStampaMainForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStampaMainForm.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.AccessibleDescription = "CommandBarSeparator5"
        Me.CommandBarSeparator5.AccessibleName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.DisplayName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'btnGestioneTempi
        '
        Me.btnGestioneTempi.AccessibleDescription = "Gestione Tempi"
        Me.btnGestioneTempi.AccessibleName = "Gestione Tempi"
        Me.btnGestioneTempi.DisplayName = "CommandBarButton1"
        Me.btnGestioneTempi.DrawText = True
        Me.btnGestioneTempi.Image = CType(resources.GetObject("btnGestioneTempi.Image"), System.Drawing.Image)
        Me.btnGestioneTempi.Name = "btnGestioneTempi"
        Me.btnGestioneTempi.Text = "Gestione Tempi"
        Me.btnGestioneTempi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGestioneTempi.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator6
        '
        Me.CommandBarSeparator6.AccessibleDescription = "CommandBarSeparator6"
        Me.CommandBarSeparator6.AccessibleName = "CommandBarSeparator6"
        Me.CommandBarSeparator6.DisplayName = "CommandBarSeparator6"
        Me.CommandBarSeparator6.Name = "CommandBarSeparator6"
        Me.CommandBarSeparator6.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator6.VisibleInOverflowMenu = False
        '
        'btnGestioneLottoMateriale
        '
        Me.btnGestioneLottoMateriale.AccessibleDescription = "Gestione Lotto"
        Me.btnGestioneLottoMateriale.AccessibleName = "Gestione Lotto"
        Me.btnGestioneLottoMateriale.DisplayName = "CommandBarButton1"
        Me.btnGestioneLottoMateriale.DrawText = True
        Me.btnGestioneLottoMateriale.Image = CType(resources.GetObject("btnGestioneLottoMateriale.Image"), System.Drawing.Image)
        Me.btnGestioneLottoMateriale.Name = "btnGestioneLottoMateriale"
        Me.btnGestioneLottoMateriale.Text = "Gestione Lotto"
        Me.btnGestioneLottoMateriale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGestioneLottoMateriale.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator7
        '
        Me.CommandBarSeparator7.AccessibleDescription = "CommandBarSeparator7"
        Me.CommandBarSeparator7.AccessibleName = "CommandBarSeparator7"
        Me.CommandBarSeparator7.DisplayName = "CommandBarSeparator7"
        Me.CommandBarSeparator7.Name = "CommandBarSeparator7"
        Me.CommandBarSeparator7.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator7.VisibleInOverflowMenu = False
        '
        'btnEsciApplicazione
        '
        Me.btnEsciApplicazione.AccessibleDescription = "Esci Dal Programma"
        Me.btnEsciApplicazione.AccessibleName = "Esci Dal Programma"
        Me.btnEsciApplicazione.DisplayName = "CommandBarButton1"
        Me.btnEsciApplicazione.DrawText = True
        Me.btnEsciApplicazione.Image = CType(resources.GetObject("btnEsciApplicazione.Image"), System.Drawing.Image)
        Me.btnEsciApplicazione.Name = "btnEsciApplicazione"
        Me.btnEsciApplicazione.Text = "Esci Dal Programma"
        Me.btnEsciApplicazione.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEsciApplicazione.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator8
        '
        Me.CommandBarSeparator8.AccessibleDescription = "CommandBarSeparator8"
        Me.CommandBarSeparator8.AccessibleName = "CommandBarSeparator8"
        Me.CommandBarSeparator8.DisplayName = "CommandBarSeparator8"
        Me.CommandBarSeparator8.Name = "CommandBarSeparator8"
        Me.CommandBarSeparator8.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator8.VisibleInOverflowMenu = False
        '
        'CommandBarLabel1
        '
        Me.CommandBarLabel1.AutoSize = False
        Me.CommandBarLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CommandBarLabel1.Bounds = New System.Drawing.Rectangle(0, 0, 150, 68)
        Me.CommandBarLabel1.DisplayName = "CommandBarLabel1"
        Me.CommandBarLabel1.DrawBorder = True
        Me.CommandBarLabel1.DrawFill = True
        Me.CommandBarLabel1.FlipText = False
        Me.CommandBarLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandBarLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.CommandBarLabel1.Name = "CommandBarLabel1"
        Me.CommandBarLabel1.Text = ""
        Me.CommandBarLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.CommandBarLabel1.TextWrap = True
        Me.CommandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 54)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1023, 72)
        Me.RadCommandBar1.TabIndex = 1
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.ClientSize = New System.Drawing.Size(1023, 904)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RadGroupBoxSalvaScheda)
        Me.Controls.Add(Me.RadGroupBoxRegLavArt)
        Me.Controls.Add(Me.RadGroupBoxRegistraTestata)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.PanelBarraTitolo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Schede Lavoro"
        Me.PanelBarraTitolo.ResumeLayout(False)
        Me.PanelBarraTitolo.PerformLayout()
        CType(Me.RadGroupBoxRegistraTestata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxRegistraTestata.ResumeLayout(False)
        Me.TableLayoutPanelTestata.ResumeLayout(False)
        Me.TableLayoutPanelTestata.PerformLayout()
        CType(Me.cmbLottoNum.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLottoNum.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLottoNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxRegLavArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxRegLavArt.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.RadGroupBoxSalvaScheda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxSalvaScheda.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelBarraTitolo As System.Windows.Forms.Panel
    Friend WithEvents lblSchedaLavorazione As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadGroupBoxRegistraTestata As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents TableLayoutPanelTestata As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblPrevistaConsegna As System.Windows.Forms.Label
    Friend WithEvents lblOrdineArticolo As System.Windows.Forms.Label
    Friend WithEvents cmbOrdineArticolo As System.Windows.Forms.ComboBox
    Friend WithEvents lblCodiceArticolo As System.Windows.Forms.Label
    Friend WithEvents cmbCodiceArticolo As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumRigaOrdine As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRigaOrdine As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroPezziOrdine As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPezziOrdine As System.Windows.Forms.TextBox
    Friend WithEvents lblMateriale As System.Windows.Forms.Label
    Friend WithEvents cmbMateriale As System.Windows.Forms.ComboBox
    Friend WithEvents RadGroupBoxRegLavArt As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblLavorazioneBBG As System.Windows.Forms.Label
    Friend WithEvents lblClienteTrattamento As System.Windows.Forms.Label
    Friend WithEvents lblVerniciatura As System.Windows.Forms.Label
    Friend WithEvents lblHelicoil As System.Windows.Forms.Label
    Friend WithEvents lblAltreLavorazioni As System.Windows.Forms.Label
    Friend WithEvents txtAltreLavorazioni As System.Windows.Forms.TextBox
    Friend WithEvents lblOperatore As System.Windows.Forms.Label
    Friend WithEvents lbTrattamento As System.Windows.Forms.Label
    Friend WithEvents lblNoteVerniciatura As System.Windows.Forms.Label
    Friend WithEvents lblNoteHelicoil As System.Windows.Forms.Label
    Friend WithEvents lblNoteAltro As System.Windows.Forms.Label
    Friend WithEvents txtNoteAltro As System.Windows.Forms.TextBox
    Friend WithEvents RadGroupBoxSalvaScheda As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents bwCopier As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblMeccanica As System.Windows.Forms.Label
    Friend WithEvents txtMeccanica As System.Windows.Forms.TextBox
    Friend WithEvents rtxtNoteTestata As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NomeFile As DataGridViewTextBoxColumn
    Friend WithEvents PercorsoFile As DataGridViewTextBoxColumn
    Friend WithEvents btnApriFile As DataGridViewButtonColumn
    Friend WithEvents txtLavorazioneBBG As ComboBox
    Friend WithEvents txtClienteTrattamento As ComboBox
    Friend WithEvents txtTrattamento As ComboBox
    Friend WithEvents txtVerniciatura As ComboBox
    Friend WithEvents txtHelicoil As ComboBox
    Friend WithEvents txtOperatore As ComboBox
    Friend WithEvents txtNoteVerniciatura As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoteHelicoil As System.Windows.Forms.ComboBox
    Friend WithEvents lblDataConsegnaArt As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerDataConsegnaArticolo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbAnnoPerOrdini As System.Windows.Forms.ComboBox
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnArticoliRegistrati As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnImportaInDatabase As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnCaricaDisegniArticolo As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadButtonRegistra As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnStampaMainForm As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator6 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnEsciApplicazione As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents lblLotto As System.Windows.Forms.Label
    Friend WithEvents cmbLottoNum As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblFornitore As System.Windows.Forms.Label
    Friend WithEvents cmbFornitore As System.Windows.Forms.ComboBox
    Friend WithEvents lblOperaNum As System.Windows.Forms.Label
    Friend WithEvents txtNumOperatore As System.Windows.Forms.Label
    Friend WithEvents lblFAI As Label
    Friend WithEvents lblKC As Label
    Friend WithEvents chkFAI As CheckBox
    Friend WithEvents chkKC As CheckBox
    Friend WithEvents btnGestioneTempi As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator7 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnGestioneLottoMateriale As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator8 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents lblStampaAutom As Label
    Friend WithEvents txtOrdineDaStampare As TextBox
    Friend WithEvents btnStampaOrdineAutomatico As Button
End Class
