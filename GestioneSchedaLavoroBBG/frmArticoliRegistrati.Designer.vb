<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticoliRegistrati
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticoliRegistrati))
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cmdAnteprimaDiStampaScheda = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdEliminaScheda = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdNuovoArtDaEsistente = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdSalvaDisegni = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdChiudi = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarLabelSchede = New Telerik.WinControls.UI.CommandBarLabel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBoxAggLavorazioni = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtNoteHelicoil = New System.Windows.Forms.ComboBox()
        Me.txtNoteVerniciatura = New System.Windows.Forms.ComboBox()
        Me.chkKC = New System.Windows.Forms.CheckBox()
        Me.lblKC = New System.Windows.Forms.Label()
        Me.chkFAI = New System.Windows.Forms.CheckBox()
        Me.lblFAI = New System.Windows.Forms.Label()
        Me.txtNumOperatore = New System.Windows.Forms.Label()
        Me.lblNumOper = New System.Windows.Forms.Label()
        Me.txtClienteHelicolil = New System.Windows.Forms.ComboBox()
        Me.txtClienteVerniciatura = New System.Windows.Forms.ComboBox()
        Me.txtTrattamento = New System.Windows.Forms.ComboBox()
        Me.txtClienteTrattamento = New System.Windows.Forms.ComboBox()
        Me.txtOperatore = New System.Windows.Forms.ComboBox()
        Me.txtLavorazioniBBG = New System.Windows.Forms.ComboBox()
        Me.btnAggiornaScheda = New System.Windows.Forms.Button()
        Me.txtNoteAltreLavorazioni = New System.Windows.Forms.TextBox()
        Me.txtAltreLavorazioni = New System.Windows.Forms.TextBox()
        Me.lblNoteAltreLavor = New System.Windows.Forms.Label()
        Me.lblAltreLavorazioni = New System.Windows.Forms.Label()
        Me.lblNoteHelicoil = New System.Windows.Forms.Label()
        Me.lblClienteHelicoil = New System.Windows.Forms.Label()
        Me.lblNoteVerniciatura = New System.Windows.Forms.Label()
        Me.lblClienteVerniciatura = New System.Windows.Forms.Label()
        Me.lblTrattamento = New System.Windows.Forms.Label()
        Me.lblClienteTrattamento = New System.Windows.Forms.Label()
        Me.lblOperatore = New System.Windows.Forms.Label()
        Me.lblLavorazioniBBG = New System.Windows.Forms.Label()
        Me.RadGroupBoxAggSchedaArt = New Telerik.WinControls.UI.RadGroupBox()
        Me.cmbLottoNum = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblLotto = New System.Windows.Forms.Label()
        Me.cmbFornitore = New System.Windows.Forms.ComboBox()
        Me.lblFornitori = New System.Windows.Forms.Label()
        Me.txtMateriale = New System.Windows.Forms.ComboBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.txtNumeroPezziOrd = New System.Windows.Forms.TextBox()
        Me.txtNumeroRiga = New System.Windows.Forms.TextBox()
        Me.dtpDataConsegna = New System.Windows.Forms.DateTimePicker()
        Me.txtCodiceArticolo = New System.Windows.Forms.TextBox()
        Me.txtCodiceOrdine = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblNumeroPezzi = New System.Windows.Forms.Label()
        Me.lblNumeroRigaOrd = New System.Windows.Forms.Label()
        Me.lblMateriale = New System.Windows.Forms.Label()
        Me.lblDataConsegna = New System.Windows.Forms.Label()
        Me.lblCodArticolo = New System.Windows.Forms.Label()
        Me.lblCodiceOrdine = New System.Windows.Forms.Label()
        Me.GroupBoxSchedeRegistrate = New System.Windows.Forms.GroupBox()
        Me.DataGridViewDisegni = New Telerik.WinControls.UI.RadGridView()
        Me.GroupBoxDisegniScheda = New System.Windows.Forms.GroupBox()
        Me.gridViewDisegni = New System.Windows.Forms.DataGridView()
        Me.NomeFileSchede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercorsoFileSchede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnApriFileSchede = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.NomeFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercorsoFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnApriFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CommandBarRowElement4 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bwCopier = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadGroupBoxAggLavorazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxAggLavorazioni.SuspendLayout()
        CType(Me.RadGroupBoxAggSchedaArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxAggSchedaArt.SuspendLayout()
        CType(Me.cmbLottoNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLottoNum.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLottoNum.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSchedeRegistrate.SuspendLayout()
        CType(Me.DataGridViewDisegni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDisegni.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDisegniScheda.SuspendLayout()
        CType(Me.gridViewDisegni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1204, 72)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cmdAnteprimaDiStampaScheda, Me.CommandBarSeparator1, Me.cmdEliminaScheda, Me.CommandBarSeparator4, Me.cmdNuovoArtDaEsistente, Me.CommandBarSeparator2, Me.cmdSalvaDisegni, Me.CommandBarSeparator5, Me.cmdChiudi, Me.CommandBarSeparator3, Me.CommandBarLabelSchede})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cmdAnteprimaDiStampaScheda
        '
        Me.cmdAnteprimaDiStampaScheda.AccessibleDescription = "Anteprima Di Stampa Scheda"
        Me.cmdAnteprimaDiStampaScheda.AccessibleName = "Anteprima Di Stampa Scheda"
        Me.cmdAnteprimaDiStampaScheda.DisplayName = "CommandBarButton1"
        Me.cmdAnteprimaDiStampaScheda.DrawText = True
        Me.cmdAnteprimaDiStampaScheda.Image = CType(resources.GetObject("cmdAnteprimaDiStampaScheda.Image"), System.Drawing.Image)
        Me.cmdAnteprimaDiStampaScheda.Name = "cmdAnteprimaDiStampaScheda"
        Me.cmdAnteprimaDiStampaScheda.Text = "Anteprima Di Stampa Scheda"
        Me.cmdAnteprimaDiStampaScheda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAnteprimaDiStampaScheda.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'cmdEliminaScheda
        '
        Me.cmdEliminaScheda.AccessibleDescription = "Elimina Scheda"
        Me.cmdEliminaScheda.AccessibleName = "Elimina Scheda"
        Me.cmdEliminaScheda.DisplayName = "CommandBarButton1"
        Me.cmdEliminaScheda.DrawText = True
        Me.cmdEliminaScheda.Image = CType(resources.GetObject("cmdEliminaScheda.Image"), System.Drawing.Image)
        Me.cmdEliminaScheda.Name = "cmdEliminaScheda"
        Me.cmdEliminaScheda.Text = "Elimina Scheda"
        Me.cmdEliminaScheda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEliminaScheda.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'cmdNuovoArtDaEsistente
        '
        Me.cmdNuovoArtDaEsistente.AccessibleDescription = "Nuovo Art. Da Art. Esistente"
        Me.cmdNuovoArtDaEsistente.AccessibleName = "Nuovo Art. Da Art. Esistente"
        Me.cmdNuovoArtDaEsistente.DisplayName = "CommandBarButton1"
        Me.cmdNuovoArtDaEsistente.DrawText = True
        Me.cmdNuovoArtDaEsistente.Image = CType(resources.GetObject("cmdNuovoArtDaEsistente.Image"), System.Drawing.Image)
        Me.cmdNuovoArtDaEsistente.Name = "cmdNuovoArtDaEsistente"
        Me.cmdNuovoArtDaEsistente.Text = "Nuovo Art. Da Art. Esistente"
        Me.cmdNuovoArtDaEsistente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdNuovoArtDaEsistente.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'cmdSalvaDisegni
        '
        Me.cmdSalvaDisegni.AccessibleDescription = "Salva Disegni"
        Me.cmdSalvaDisegni.AccessibleName = "Salva Disegni"
        Me.cmdSalvaDisegni.DisplayName = "CommandBarButton1"
        Me.cmdSalvaDisegni.DrawText = True
        Me.cmdSalvaDisegni.Image = CType(resources.GetObject("cmdSalvaDisegni.Image"), System.Drawing.Image)
        Me.cmdSalvaDisegni.Name = "cmdSalvaDisegni"
        Me.cmdSalvaDisegni.Text = "Salva Disegni"
        Me.cmdSalvaDisegni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSalvaDisegni.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'cmdChiudi
        '
        Me.cmdChiudi.AccessibleDescription = "Chiudi"
        Me.cmdChiudi.AccessibleName = "Chiudi"
        Me.cmdChiudi.DisplayName = "CommandBarButton1"
        Me.cmdChiudi.DrawText = True
        Me.cmdChiudi.Image = CType(resources.GetObject("cmdChiudi.Image"), System.Drawing.Image)
        Me.cmdChiudi.Name = "cmdChiudi"
        Me.cmdChiudi.Text = "Chiudi"
        Me.cmdChiudi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdChiudi.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'CommandBarLabelSchede
        '
        Me.CommandBarLabelSchede.AutoSize = False
        Me.CommandBarLabelSchede.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CommandBarLabelSchede.Bounds = New System.Drawing.Rectangle(0, 0, 300, 68)
        Me.CommandBarLabelSchede.DisplayName = "CommandBarLabel1"
        Me.CommandBarLabelSchede.DrawBorder = True
        Me.CommandBarLabelSchede.DrawFill = True
        Me.CommandBarLabelSchede.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandBarLabelSchede.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.CommandBarLabelSchede.Name = "CommandBarLabelSchede"
        Me.CommandBarLabelSchede.Text = ""
        Me.CommandBarLabelSchede.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.CommandBarLabelSchede.TextWrap = True
        Me.CommandBarLabelSchede.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadPanel1
        '
        Me.RadPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadPanel1.Controls.Add(Me.RadGroupBoxAggLavorazioni)
        Me.RadPanel1.Controls.Add(Me.RadGroupBoxAggSchedaArt)
        Me.RadPanel1.Location = New System.Drawing.Point(739, 94)
        Me.RadPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(438, 788)
        Me.RadPanel1.TabIndex = 3
        '
        'RadGroupBoxAggLavorazioni
        '
        Me.RadGroupBoxAggLavorazioni.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxAggLavorazioni.BackColor = System.Drawing.Color.White
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtNoteHelicoil)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtNoteVerniciatura)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.chkKC)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblKC)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.chkFAI)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblFAI)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtNumOperatore)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblNumOper)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtClienteHelicolil)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtClienteVerniciatura)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtTrattamento)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtClienteTrattamento)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtOperatore)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtLavorazioniBBG)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.btnAggiornaScheda)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtNoteAltreLavorazioni)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.txtAltreLavorazioni)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblNoteAltreLavor)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblAltreLavorazioni)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblNoteHelicoil)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblClienteHelicoil)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblNoteVerniciatura)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblClienteVerniciatura)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblTrattamento)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblClienteTrattamento)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblOperatore)
        Me.RadGroupBoxAggLavorazioni.Controls.Add(Me.lblLavorazioniBBG)
        Me.RadGroupBoxAggLavorazioni.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBoxAggLavorazioni.HeaderText = "Aggiorna Lavorazioni"
        Me.RadGroupBoxAggLavorazioni.Location = New System.Drawing.Point(5, 309)
        Me.RadGroupBoxAggLavorazioni.Name = "RadGroupBoxAggLavorazioni"
        Me.RadGroupBoxAggLavorazioni.Size = New System.Drawing.Size(424, 476)
        Me.RadGroupBoxAggLavorazioni.TabIndex = 1
        Me.RadGroupBoxAggLavorazioni.Text = "Aggiorna Lavorazioni"
        '
        'txtNoteHelicoil
        '
        Me.txtNoteHelicoil.FormattingEnabled = True
        Me.txtNoteHelicoil.Location = New System.Drawing.Point(162, 233)
        Me.txtNoteHelicoil.Name = "txtNoteHelicoil"
        Me.txtNoteHelicoil.Size = New System.Drawing.Size(245, 21)
        Me.txtNoteHelicoil.TabIndex = 40
        '
        'txtNoteVerniciatura
        '
        Me.txtNoteVerniciatura.FormattingEnabled = True
        Me.txtNoteVerniciatura.Location = New System.Drawing.Point(163, 180)
        Me.txtNoteVerniciatura.Name = "txtNoteVerniciatura"
        Me.txtNoteVerniciatura.Size = New System.Drawing.Size(244, 21)
        Me.txtNoteVerniciatura.TabIndex = 39
        '
        'chkKC
        '
        Me.chkKC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKC.Location = New System.Drawing.Point(162, 338)
        Me.chkKC.Name = "chkKC"
        Me.chkKC.Size = New System.Drawing.Size(130, 19)
        Me.chkKC.TabIndex = 38
        Me.chkKC.Text = "Seleziona Per KC"
        Me.chkKC.UseVisualStyleBackColor = True
        '
        'lblKC
        '
        Me.lblKC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKC.Location = New System.Drawing.Point(15, 339)
        Me.lblKC.Name = "lblKC"
        Me.lblKC.Size = New System.Drawing.Size(146, 19)
        Me.lblKC.TabIndex = 37
        Me.lblKC.Text = "KC :"
        Me.lblKC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkFAI
        '
        Me.chkFAI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFAI.Location = New System.Drawing.Point(162, 316)
        Me.chkFAI.Name = "chkFAI"
        Me.chkFAI.Size = New System.Drawing.Size(130, 19)
        Me.chkFAI.TabIndex = 36
        Me.chkFAI.Text = "Seleziona Per FAI"
        Me.chkFAI.UseVisualStyleBackColor = True
        '
        'lblFAI
        '
        Me.lblFAI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFAI.Location = New System.Drawing.Point(15, 316)
        Me.lblFAI.Name = "lblFAI"
        Me.lblFAI.Size = New System.Drawing.Size(146, 19)
        Me.lblFAI.TabIndex = 35
        Me.lblFAI.Text = "FAI :"
        Me.lblFAI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumOperatore
        '
        Me.txtNumOperatore.BackColor = System.Drawing.Color.Cornsilk
        Me.txtNumOperatore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumOperatore.Location = New System.Drawing.Point(162, 77)
        Me.txtNumOperatore.Name = "txtNumOperatore"
        Me.txtNumOperatore.Size = New System.Drawing.Size(68, 25)
        Me.txtNumOperatore.TabIndex = 34
        '
        'lblNumOper
        '
        Me.lblNumOper.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOper.Location = New System.Drawing.Point(8, 79)
        Me.lblNumOper.Name = "lblNumOper"
        Me.lblNumOper.Size = New System.Drawing.Size(153, 19)
        Me.lblNumOper.TabIndex = 33
        Me.lblNumOper.Text = "Numero Operatore :"
        Me.lblNumOper.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtClienteHelicolil
        '
        Me.txtClienteHelicolil.FormattingEnabled = True
        Me.txtClienteHelicolil.Location = New System.Drawing.Point(162, 210)
        Me.txtClienteHelicolil.Name = "txtClienteHelicolil"
        Me.txtClienteHelicolil.Size = New System.Drawing.Size(245, 21)
        Me.txtClienteHelicolil.TabIndex = 32
        '
        'txtClienteVerniciatura
        '
        Me.txtClienteVerniciatura.FormattingEnabled = True
        Me.txtClienteVerniciatura.Location = New System.Drawing.Point(163, 157)
        Me.txtClienteVerniciatura.Name = "txtClienteVerniciatura"
        Me.txtClienteVerniciatura.Size = New System.Drawing.Size(244, 21)
        Me.txtClienteVerniciatura.TabIndex = 31
        '
        'txtTrattamento
        '
        Me.txtTrattamento.FormattingEnabled = True
        Me.txtTrattamento.Location = New System.Drawing.Point(162, 128)
        Me.txtTrattamento.Name = "txtTrattamento"
        Me.txtTrattamento.Size = New System.Drawing.Size(245, 21)
        Me.txtTrattamento.TabIndex = 30
        '
        'txtClienteTrattamento
        '
        Me.txtClienteTrattamento.FormattingEnabled = True
        Me.txtClienteTrattamento.Location = New System.Drawing.Point(162, 105)
        Me.txtClienteTrattamento.Name = "txtClienteTrattamento"
        Me.txtClienteTrattamento.Size = New System.Drawing.Size(245, 21)
        Me.txtClienteTrattamento.TabIndex = 29
        '
        'txtOperatore
        '
        Me.txtOperatore.FormattingEnabled = True
        Me.txtOperatore.Location = New System.Drawing.Point(162, 53)
        Me.txtOperatore.Name = "txtOperatore"
        Me.txtOperatore.Size = New System.Drawing.Size(245, 21)
        Me.txtOperatore.TabIndex = 28
        '
        'txtLavorazioniBBG
        '
        Me.txtLavorazioniBBG.FormattingEnabled = True
        Me.txtLavorazioniBBG.Location = New System.Drawing.Point(162, 30)
        Me.txtLavorazioniBBG.Name = "txtLavorazioniBBG"
        Me.txtLavorazioniBBG.Size = New System.Drawing.Size(245, 21)
        Me.txtLavorazioniBBG.TabIndex = 27
        '
        'btnAggiornaScheda
        '
        Me.btnAggiornaScheda.Location = New System.Drawing.Point(168, 387)
        Me.btnAggiornaScheda.Name = "btnAggiornaScheda"
        Me.btnAggiornaScheda.Size = New System.Drawing.Size(239, 32)
        Me.btnAggiornaScheda.TabIndex = 26
        Me.btnAggiornaScheda.Text = "Aggiorna Scheda"
        Me.btnAggiornaScheda.UseVisualStyleBackColor = True
        '
        'txtNoteAltreLavorazioni
        '
        Me.txtNoteAltreLavorazioni.Location = New System.Drawing.Point(162, 285)
        Me.txtNoteAltreLavorazioni.Name = "txtNoteAltreLavorazioni"
        Me.txtNoteAltreLavorazioni.Size = New System.Drawing.Size(245, 20)
        Me.txtNoteAltreLavorazioni.TabIndex = 25
        '
        'txtAltreLavorazioni
        '
        Me.txtAltreLavorazioni.Location = New System.Drawing.Point(162, 263)
        Me.txtAltreLavorazioni.Name = "txtAltreLavorazioni"
        Me.txtAltreLavorazioni.Size = New System.Drawing.Size(245, 20)
        Me.txtAltreLavorazioni.TabIndex = 24
        '
        'lblNoteAltreLavor
        '
        Me.lblNoteAltreLavor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteAltreLavor.Location = New System.Drawing.Point(8, 282)
        Me.lblNoteAltreLavor.Name = "lblNoteAltreLavor"
        Me.lblNoteAltreLavor.Size = New System.Drawing.Size(153, 19)
        Me.lblNoteAltreLavor.TabIndex = 23
        Me.lblNoteAltreLavor.Text = "Note Altre Lavorazioni :"
        Me.lblNoteAltreLavor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAltreLavorazioni
        '
        Me.lblAltreLavorazioni.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltreLavorazioni.Location = New System.Drawing.Point(8, 263)
        Me.lblAltreLavorazioni.Name = "lblAltreLavorazioni"
        Me.lblAltreLavorazioni.Size = New System.Drawing.Size(153, 19)
        Me.lblAltreLavorazioni.TabIndex = 22
        Me.lblAltreLavorazioni.Text = "Altre Lavorazioni :"
        Me.lblAltreLavorazioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteHelicoil
        '
        Me.lblNoteHelicoil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteHelicoil.Location = New System.Drawing.Point(8, 231)
        Me.lblNoteHelicoil.Name = "lblNoteHelicoil"
        Me.lblNoteHelicoil.Size = New System.Drawing.Size(153, 19)
        Me.lblNoteHelicoil.TabIndex = 19
        Me.lblNoteHelicoil.Text = "Note Helicoil :"
        Me.lblNoteHelicoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClienteHelicoil
        '
        Me.lblClienteHelicoil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteHelicoil.Location = New System.Drawing.Point(8, 212)
        Me.lblClienteHelicoil.Name = "lblClienteHelicoil"
        Me.lblClienteHelicoil.Size = New System.Drawing.Size(153, 19)
        Me.lblClienteHelicoil.TabIndex = 18
        Me.lblClienteHelicoil.Text = "Cliente Helicoil :"
        Me.lblClienteHelicoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteVerniciatura
        '
        Me.lblNoteVerniciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteVerniciatura.Location = New System.Drawing.Point(9, 178)
        Me.lblNoteVerniciatura.Name = "lblNoteVerniciatura"
        Me.lblNoteVerniciatura.Size = New System.Drawing.Size(153, 19)
        Me.lblNoteVerniciatura.TabIndex = 15
        Me.lblNoteVerniciatura.Text = "Note Verniciatura :"
        Me.lblNoteVerniciatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClienteVerniciatura
        '
        Me.lblClienteVerniciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteVerniciatura.Location = New System.Drawing.Point(9, 159)
        Me.lblClienteVerniciatura.Name = "lblClienteVerniciatura"
        Me.lblClienteVerniciatura.Size = New System.Drawing.Size(153, 19)
        Me.lblClienteVerniciatura.TabIndex = 14
        Me.lblClienteVerniciatura.Text = "Cliente Verniciatura :"
        Me.lblClienteVerniciatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTrattamento
        '
        Me.lblTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrattamento.Location = New System.Drawing.Point(8, 125)
        Me.lblTrattamento.Name = "lblTrattamento"
        Me.lblTrattamento.Size = New System.Drawing.Size(153, 19)
        Me.lblTrattamento.TabIndex = 11
        Me.lblTrattamento.Text = "Trattamento :"
        Me.lblTrattamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClienteTrattamento
        '
        Me.lblClienteTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteTrattamento.Location = New System.Drawing.Point(8, 106)
        Me.lblClienteTrattamento.Name = "lblClienteTrattamento"
        Me.lblClienteTrattamento.Size = New System.Drawing.Size(153, 19)
        Me.lblClienteTrattamento.TabIndex = 10
        Me.lblClienteTrattamento.Text = "Cliente Trattamento :"
        Me.lblClienteTrattamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOperatore
        '
        Me.lblOperatore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperatore.Location = New System.Drawing.Point(8, 53)
        Me.lblOperatore.Name = "lblOperatore"
        Me.lblOperatore.Size = New System.Drawing.Size(153, 19)
        Me.lblOperatore.TabIndex = 2
        Me.lblOperatore.Text = "Operatore :"
        Me.lblOperatore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLavorazioniBBG
        '
        Me.lblLavorazioniBBG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLavorazioniBBG.Location = New System.Drawing.Point(8, 30)
        Me.lblLavorazioniBBG.Name = "lblLavorazioniBBG"
        Me.lblLavorazioniBBG.Size = New System.Drawing.Size(153, 19)
        Me.lblLavorazioniBBG.TabIndex = 1
        Me.lblLavorazioniBBG.Text = "Lavorazioni BBG :"
        Me.lblLavorazioniBBG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadGroupBoxAggSchedaArt
        '
        Me.RadGroupBoxAggSchedaArt.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxAggSchedaArt.BackColor = System.Drawing.Color.White
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.cmbLottoNum)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblLotto)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.cmbFornitore)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblFornitori)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.txtMateriale)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.txtNote)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.txtNumeroPezziOrd)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.txtNumeroRiga)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.dtpDataConsegna)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.txtCodiceArticolo)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.txtCodiceOrdine)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblNote)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblNumeroPezzi)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblNumeroRigaOrd)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblMateriale)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblDataConsegna)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblCodArticolo)
        Me.RadGroupBoxAggSchedaArt.Controls.Add(Me.lblCodiceOrdine)
        Me.RadGroupBoxAggSchedaArt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBoxAggSchedaArt.HeaderText = "Aggiorna Scheda Articolo"
        Me.RadGroupBoxAggSchedaArt.Location = New System.Drawing.Point(6, 3)
        Me.RadGroupBoxAggSchedaArt.Name = "RadGroupBoxAggSchedaArt"
        Me.RadGroupBoxAggSchedaArt.Size = New System.Drawing.Size(424, 290)
        Me.RadGroupBoxAggSchedaArt.TabIndex = 0
        Me.RadGroupBoxAggSchedaArt.Text = "Aggiorna Scheda Articolo"
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
        Me.cmbLottoNum.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cmbLottoNum.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cmbLottoNum.EditorControl.Name = "NestedRadGridView"
        Me.cmbLottoNum.EditorControl.ReadOnly = True
        Me.cmbLottoNum.EditorControl.ShowGroupPanel = False
        Me.cmbLottoNum.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cmbLottoNum.EditorControl.TabIndex = 0
        Me.cmbLottoNum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLottoNum.Location = New System.Drawing.Point(145, 194)
        Me.cmbLottoNum.Name = "cmbLottoNum"
        Me.cmbLottoNum.Size = New System.Drawing.Size(264, 27)
        Me.cmbLottoNum.TabIndex = 18
        Me.cmbLottoNum.TabStop = False
        '
        'lblLotto
        '
        Me.lblLotto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotto.Location = New System.Drawing.Point(11, 194)
        Me.lblLotto.Name = "lblLotto"
        Me.lblLotto.Size = New System.Drawing.Size(128, 19)
        Me.lblLotto.TabIndex = 17
        Me.lblLotto.Text = "Lotto :"
        Me.lblLotto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFornitore
        '
        Me.cmbFornitore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFornitore.FormattingEnabled = True
        Me.cmbFornitore.Location = New System.Drawing.Point(145, 166)
        Me.cmbFornitore.Name = "cmbFornitore"
        Me.cmbFornitore.Size = New System.Drawing.Size(265, 23)
        Me.cmbFornitore.TabIndex = 16
        '
        'lblFornitori
        '
        Me.lblFornitori.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornitori.Location = New System.Drawing.Point(11, 169)
        Me.lblFornitori.Name = "lblFornitori"
        Me.lblFornitori.Size = New System.Drawing.Size(128, 19)
        Me.lblFornitori.TabIndex = 15
        Me.lblFornitori.Text = "Fornitore :"
        Me.lblFornitori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMateriale
        '
        Me.txtMateriale.FormattingEnabled = True
        Me.txtMateriale.Location = New System.Drawing.Point(145, 96)
        Me.txtMateriale.Name = "txtMateriale"
        Me.txtMateriale.Size = New System.Drawing.Size(265, 21)
        Me.txtMateriale.TabIndex = 14
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(145, 227)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(265, 56)
        Me.txtNote.TabIndex = 13
        '
        'txtNumeroPezziOrd
        '
        Me.txtNumeroPezziOrd.Location = New System.Drawing.Point(145, 143)
        Me.txtNumeroPezziOrd.Name = "txtNumeroPezziOrd"
        Me.txtNumeroPezziOrd.Size = New System.Drawing.Size(265, 20)
        Me.txtNumeroPezziOrd.TabIndex = 12
        '
        'txtNumeroRiga
        '
        Me.txtNumeroRiga.Location = New System.Drawing.Point(145, 120)
        Me.txtNumeroRiga.Name = "txtNumeroRiga"
        Me.txtNumeroRiga.Size = New System.Drawing.Size(265, 20)
        Me.txtNumeroRiga.TabIndex = 11
        '
        'dtpDataConsegna
        '
        Me.dtpDataConsegna.Location = New System.Drawing.Point(145, 73)
        Me.dtpDataConsegna.Name = "dtpDataConsegna"
        Me.dtpDataConsegna.Size = New System.Drawing.Size(265, 20)
        Me.dtpDataConsegna.TabIndex = 10
        '
        'txtCodiceArticolo
        '
        Me.txtCodiceArticolo.Location = New System.Drawing.Point(145, 50)
        Me.txtCodiceArticolo.Name = "txtCodiceArticolo"
        Me.txtCodiceArticolo.Size = New System.Drawing.Size(265, 20)
        Me.txtCodiceArticolo.TabIndex = 8
        '
        'txtCodiceOrdine
        '
        Me.txtCodiceOrdine.Location = New System.Drawing.Point(145, 27)
        Me.txtCodiceOrdine.Name = "txtCodiceOrdine"
        Me.txtCodiceOrdine.Size = New System.Drawing.Size(265, 20)
        Me.txtCodiceOrdine.TabIndex = 7
        '
        'lblNote
        '
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(11, 227)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(128, 19)
        Me.lblNote.TabIndex = 6
        Me.lblNote.Text = "Note :"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumeroPezzi
        '
        Me.lblNumeroPezzi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPezzi.Location = New System.Drawing.Point(11, 143)
        Me.lblNumeroPezzi.Name = "lblNumeroPezzi"
        Me.lblNumeroPezzi.Size = New System.Drawing.Size(128, 19)
        Me.lblNumeroPezzi.TabIndex = 5
        Me.lblNumeroPezzi.Text = "Numero Pezzi :"
        Me.lblNumeroPezzi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumeroRigaOrd
        '
        Me.lblNumeroRigaOrd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroRigaOrd.Location = New System.Drawing.Point(11, 120)
        Me.lblNumeroRigaOrd.Name = "lblNumeroRigaOrd"
        Me.lblNumeroRigaOrd.Size = New System.Drawing.Size(128, 19)
        Me.lblNumeroRigaOrd.TabIndex = 4
        Me.lblNumeroRigaOrd.Text = "Numero Riga Ord :"
        Me.lblNumeroRigaOrd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMateriale
        '
        Me.lblMateriale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMateriale.Location = New System.Drawing.Point(11, 97)
        Me.lblMateriale.Name = "lblMateriale"
        Me.lblMateriale.Size = New System.Drawing.Size(128, 19)
        Me.lblMateriale.TabIndex = 3
        Me.lblMateriale.Text = "Materiale :"
        Me.lblMateriale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDataConsegna
        '
        Me.lblDataConsegna.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataConsegna.Location = New System.Drawing.Point(11, 74)
        Me.lblDataConsegna.Name = "lblDataConsegna"
        Me.lblDataConsegna.Size = New System.Drawing.Size(128, 19)
        Me.lblDataConsegna.TabIndex = 2
        Me.lblDataConsegna.Text = "Data Consegna :"
        Me.lblDataConsegna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodArticolo
        '
        Me.lblCodArticolo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodArticolo.Location = New System.Drawing.Point(11, 51)
        Me.lblCodArticolo.Name = "lblCodArticolo"
        Me.lblCodArticolo.Size = New System.Drawing.Size(128, 19)
        Me.lblCodArticolo.TabIndex = 1
        Me.lblCodArticolo.Text = "Codice Articolo :"
        Me.lblCodArticolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodiceOrdine
        '
        Me.lblCodiceOrdine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodiceOrdine.Location = New System.Drawing.Point(11, 27)
        Me.lblCodiceOrdine.Name = "lblCodiceOrdine"
        Me.lblCodiceOrdine.Size = New System.Drawing.Size(128, 19)
        Me.lblCodiceOrdine.TabIndex = 0
        Me.lblCodiceOrdine.Text = "Codice Ordine :"
        Me.lblCodiceOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBoxSchedeRegistrate
        '
        Me.GroupBoxSchedeRegistrate.BackColor = System.Drawing.Color.White
        Me.GroupBoxSchedeRegistrate.Controls.Add(Me.DataGridViewDisegni)
        Me.GroupBoxSchedeRegistrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSchedeRegistrate.Location = New System.Drawing.Point(5, 92)
        Me.GroupBoxSchedeRegistrate.Name = "GroupBoxSchedeRegistrate"
        Me.GroupBoxSchedeRegistrate.Size = New System.Drawing.Size(722, 562)
        Me.GroupBoxSchedeRegistrate.TabIndex = 4
        Me.GroupBoxSchedeRegistrate.TabStop = False
        Me.GroupBoxSchedeRegistrate.Text = "Schede Registrate"
        '
        'DataGridViewDisegni
        '
        Me.DataGridViewDisegni.AutoScroll = True
        Me.DataGridViewDisegni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDisegni.Location = New System.Drawing.Point(3, 18)
        '
        'DataGridViewDisegni
        '
        Me.DataGridViewDisegni.MasterTemplate.AllowAddNewRow = False
        Me.DataGridViewDisegni.MasterTemplate.AllowCellContextMenu = False
        Me.DataGridViewDisegni.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.DataGridViewDisegni.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.FieldName = "IDIntestazione"
        GridViewTextBoxColumn1.HeaderText = "ID"
        GridViewTextBoxColumn1.Name = "IDIntestazione"
        GridViewTextBoxColumn2.FieldName = "NumOrdine"
        GridViewTextBoxColumn2.HeaderText = "Codice Ordine"
        GridViewTextBoxColumn2.Name = "NumOrdine"
        GridViewTextBoxColumn2.Width = 120
        GridViewTextBoxColumn3.FieldName = "CodArticolo"
        GridViewTextBoxColumn3.HeaderText = "Codice Articolo"
        GridViewTextBoxColumn3.Name = "CodArticolo"
        GridViewTextBoxColumn3.Width = 180
        GridViewDateTimeColumn1.FieldName = "Data"
        GridViewDateTimeColumn1.HeaderText = "Data Consegna"
        GridViewDateTimeColumn1.Name = "Data"
        GridViewDateTimeColumn1.Width = 120
        GridViewTextBoxColumn4.FieldName = "Note"
        GridViewTextBoxColumn4.HeaderText = "Note"
        GridViewTextBoxColumn4.Name = "Note"
        GridViewTextBoxColumn4.Width = 210
        Me.DataGridViewDisegni.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDateTimeColumn1, GridViewTextBoxColumn4})
        Me.DataGridViewDisegni.MasterTemplate.EnableAlternatingRowColor = True
        Me.DataGridViewDisegni.MasterTemplate.EnableFiltering = True
        Me.DataGridViewDisegni.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide
        Me.DataGridViewDisegni.Name = "DataGridViewDisegni"
        Me.DataGridViewDisegni.ReadOnly = True
        Me.DataGridViewDisegni.Size = New System.Drawing.Size(716, 541)
        Me.DataGridViewDisegni.TabIndex = 0
        '
        'GroupBoxDisegniScheda
        '
        Me.GroupBoxDisegniScheda.Controls.Add(Me.gridViewDisegni)
        Me.GroupBoxDisegniScheda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDisegniScheda.Location = New System.Drawing.Point(3, 663)
        Me.GroupBoxDisegniScheda.Name = "GroupBoxDisegniScheda"
        Me.GroupBoxDisegniScheda.Size = New System.Drawing.Size(727, 216)
        Me.GroupBoxDisegniScheda.TabIndex = 5
        Me.GroupBoxDisegniScheda.TabStop = False
        Me.GroupBoxDisegniScheda.Text = "Disegni Articolo Scheda"
        '
        'gridViewDisegni
        '
        Me.gridViewDisegni.AllowUserToAddRows = False
        Me.gridViewDisegni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridViewDisegni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeFileSchede, Me.PercorsoFileSchede, Me.btnApriFileSchede})
        Me.gridViewDisegni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridViewDisegni.Location = New System.Drawing.Point(3, 18)
        Me.gridViewDisegni.Name = "gridViewDisegni"
        Me.gridViewDisegni.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridViewDisegni.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridViewDisegni.Size = New System.Drawing.Size(721, 195)
        Me.gridViewDisegni.TabIndex = 0
        '
        'NomeFileSchede
        '
        Me.NomeFileSchede.DataPropertyName = "NomeFileSchede"
        Me.NomeFileSchede.HeaderText = "Nome File"
        Me.NomeFileSchede.Name = "NomeFileSchede"
        Me.NomeFileSchede.ReadOnly = True
        Me.NomeFileSchede.ToolTipText = "Nome File"
        Me.NomeFileSchede.Width = 160
        '
        'PercorsoFileSchede
        '
        Me.PercorsoFileSchede.DataPropertyName = "PercorsoFileSchede"
        Me.PercorsoFileSchede.HeaderText = "Percorso File"
        Me.PercorsoFileSchede.Name = "PercorsoFileSchede"
        Me.PercorsoFileSchede.ReadOnly = True
        Me.PercorsoFileSchede.ToolTipText = "Percorso File"
        Me.PercorsoFileSchede.Width = 350
        '
        'btnApriFileSchede
        '
        Me.btnApriFileSchede.DataPropertyName = "btnApriFileSchede"
        Me.btnApriFileSchede.HeaderText = "Apri File Pdf Disegni"
        Me.btnApriFileSchede.Name = "btnApriFileSchede"
        Me.btnApriFileSchede.ReadOnly = True
        Me.btnApriFileSchede.Text = "Apri File"
        Me.btnApriFileSchede.ToolTipText = "Apri File"
        Me.btnApriFileSchede.UseColumnTextForButtonValue = True
        Me.btnApriFileSchede.Width = 150
        '
        'NomeFile
        '
        Me.NomeFile.DataPropertyName = "NomeFile"
        Me.NomeFile.HeaderText = "Nome File"
        Me.NomeFile.Name = "NomeFile"
        Me.NomeFile.ToolTipText = "Mostra Il Nome Del File Disegno"
        '
        'PercorsoFile
        '
        Me.PercorsoFile.DataPropertyName = "PercorsoFile"
        Me.PercorsoFile.HeaderText = "Percorso File"
        Me.PercorsoFile.Name = "PercorsoFile"
        Me.PercorsoFile.ToolTipText = "Posizione Del File In Hard Disk"
        Me.PercorsoFile.Width = 280
        '
        'btnApriFile
        '
        Me.btnApriFile.DataPropertyName = "btnApriFile"
        Me.btnApriFile.HeaderText = "Apri File"
        Me.btnApriFile.Name = "btnApriFile"
        Me.btnApriFile.Text = "Apri File"
        Me.btnApriFile.ToolTipText = "Apri File Pdf Oppure Zip"
        '
        'CommandBarRowElement4
        '
        Me.CommandBarRowElement4.MinSize = New System.Drawing.Size(25, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 897)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1204, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(200, 17)
        '
        'frmArticoliRegistrati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1204, 919)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBoxSchedeRegistrate)
        Me.Controls.Add(Me.GroupBoxDisegniScheda)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticoliRegistrati"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articoli Registrati"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.RadGroupBoxAggLavorazioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxAggLavorazioni.ResumeLayout(False)
        Me.RadGroupBoxAggLavorazioni.PerformLayout()
        CType(Me.RadGroupBoxAggSchedaArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxAggSchedaArt.ResumeLayout(False)
        Me.RadGroupBoxAggSchedaArt.PerformLayout()
        CType(Me.cmbLottoNum.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLottoNum.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLottoNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSchedeRegistrate.ResumeLayout(False)
        CType(Me.DataGridViewDisegni.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDisegni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDisegniScheda.ResumeLayout(False)
        CType(Me.gridViewDisegni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cmdAnteprimaDiStampaScheda As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cmdEliminaScheda As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cmdChiudi As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBoxAggLavorazioni As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBoxAggSchedaArt As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lblMateriale As System.Windows.Forms.Label
    Friend WithEvents lblDataConsegna As System.Windows.Forms.Label
    Friend WithEvents lblCodArticolo As System.Windows.Forms.Label
    Friend WithEvents lblCodiceOrdine As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRigaOrd As System.Windows.Forms.Label
    Friend WithEvents txtCodiceArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodiceOrdine As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblNumeroPezzi As System.Windows.Forms.Label
    Friend WithEvents dtpDataConsegna As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroPezziOrd As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroRiga As System.Windows.Forms.TextBox
    Friend WithEvents lblTrattamento As System.Windows.Forms.Label
    Friend WithEvents lblClienteTrattamento As System.Windows.Forms.Label
    Friend WithEvents lblOperatore As System.Windows.Forms.Label
    Friend WithEvents lblLavorazioniBBG As System.Windows.Forms.Label
    Friend WithEvents lblNoteVerniciatura As System.Windows.Forms.Label
    Friend WithEvents lblClienteVerniciatura As System.Windows.Forms.Label
    Friend WithEvents lblNoteHelicoil As System.Windows.Forms.Label
    Friend WithEvents lblClienteHelicoil As System.Windows.Forms.Label
    Friend WithEvents txtNoteAltreLavorazioni As System.Windows.Forms.TextBox
    Friend WithEvents txtAltreLavorazioni As System.Windows.Forms.TextBox
    Friend WithEvents lblNoteAltreLavor As System.Windows.Forms.Label
    Friend WithEvents lblAltreLavorazioni As System.Windows.Forms.Label
    Friend WithEvents btnAggiornaScheda As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSchedeRegistrate As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDisegniScheda As System.Windows.Forms.GroupBox
    Friend WithEvents NomeFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PercorsoFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnApriFile As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewDisegni As Telerik.WinControls.UI.RadGridView
    Friend WithEvents gridViewDisegni As System.Windows.Forms.DataGridView
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarLabelSchede As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents txtMateriale As System.Windows.Forms.ComboBox
    Friend WithEvents txtOperatore As System.Windows.Forms.ComboBox
    Friend WithEvents txtLavorazioniBBG As System.Windows.Forms.ComboBox
    Friend WithEvents txtClienteTrattamento As System.Windows.Forms.ComboBox
    Friend WithEvents txtTrattamento As System.Windows.Forms.ComboBox
    Friend WithEvents txtClienteVerniciatura As System.Windows.Forms.ComboBox
    Friend WithEvents txtClienteHelicolil As System.Windows.Forms.ComboBox
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cmdNuovoArtDaEsistente As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents lblFornitori As Label
    Friend WithEvents cmbFornitore As ComboBox
    Friend WithEvents lblLotto As Label
    Friend WithEvents cmbLottoNum As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblNumOper As System.Windows.Forms.Label
    Friend WithEvents txtNumOperatore As System.Windows.Forms.Label
    Friend WithEvents CommandBarRowElement4 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents cmdSalvaDisegni As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents bwCopier As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents NomeFileSchede As DataGridViewTextBoxColumn
    Friend WithEvents PercorsoFileSchede As DataGridViewTextBoxColumn
    Friend WithEvents btnApriFileSchede As DataGridViewButtonColumn
    Friend WithEvents lblFAI As Label
    Friend WithEvents chkKC As CheckBox
    Friend WithEvents lblKC As Label
    Friend WithEvents chkFAI As CheckBox
    Friend WithEvents txtNoteVerniciatura As ComboBox
    Friend WithEvents txtNoteHelicoil As ComboBox
End Class
