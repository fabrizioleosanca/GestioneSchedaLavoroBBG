<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStampaOrdiniAutomatico
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
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStampaOrdiniAutomatico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.btnStampaAutomatico = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnCopiaOrdineNuovo = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnChiudi = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadGroupBoxTxtNumOrdine = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnCaricaArticoli = New System.Windows.Forms.Button()
        Me.txtOrdineDaStampareAuto = New System.Windows.Forms.TextBox()
        Me.RadGroupBoxArticoliOrdine = New Telerik.WinControls.UI.RadGroupBox()
        Me.DataGridViewNuovoOrdineDaStampAuto = New System.Windows.Forms.DataGridView()
        Me.RigaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataConsegnaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodicePadreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeccanicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbSchedaLavoroBBGDataSet = New GestioneSchedaLavoroBBG.dbSchedaLavoroBBGDataSet()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TblNuovoOrdinePerAutomTableAdapter = New GestioneSchedaLavoroBBG.dbSchedaLavoroBBGDataSetTableAdapters.tblNuovoOrdinePerAutomTableAdapter()
        Me.RadGroupBoxArtInStampa = New Telerik.WinControls.UI.RadGroupBox()
        Me.lblCodiceInStampa = New System.Windows.Forms.Label()
        Me.btnAvvioStampaAutomatica = New System.Windows.Forms.Button()
        Me.PanelPrintObj = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxTxtNumOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxTxtNumOrdine.SuspendLayout()
        CType(Me.RadGroupBoxArticoliOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxArticoliOrdine.SuspendLayout()
        CType(Me.DataGridViewNuovoOrdineDaStampAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbSchedaLavoroBBGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.RadGroupBoxArtInStampa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxArtInStampa.SuspendLayout()
        Me.PanelPrintObj.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1370, 88)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnStampaAutomatico, Me.CommandBarSeparator1, Me.btnCopiaOrdineNuovo, Me.CommandBarSeparator2, Me.btnChiudi})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'btnStampaAutomatico
        '
        Me.btnStampaAutomatico.AccessibleDescription = "Stampa"
        Me.btnStampaAutomatico.AccessibleName = "Stampa"
        Me.btnStampaAutomatico.DisplayName = "CommandBarButton1"
        Me.btnStampaAutomatico.DrawText = True
        Me.btnStampaAutomatico.Image = CType(resources.GetObject("btnStampaAutomatico.Image"), System.Drawing.Image)
        Me.btnStampaAutomatico.Name = "btnStampaAutomatico"
        Me.btnStampaAutomatico.Text = "Stampa"
        Me.btnStampaAutomatico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.AccessibleDescription = "CommandBarSeparator1"
        Me.CommandBarSeparator1.AccessibleName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'btnCopiaOrdineNuovo
        '
        Me.btnCopiaOrdineNuovo.AccessibleDescription = "Copia Nuovo Ordine In Database Per La Stampa"
        Me.btnCopiaOrdineNuovo.AccessibleName = "Copia Nuovo Ordine In Database Per La Stampa"
        Me.btnCopiaOrdineNuovo.DisplayName = "CommandBarButton1"
        Me.btnCopiaOrdineNuovo.DrawText = True
        Me.btnCopiaOrdineNuovo.Image = CType(resources.GetObject("btnCopiaOrdineNuovo.Image"), System.Drawing.Image)
        Me.btnCopiaOrdineNuovo.Name = "btnCopiaOrdineNuovo"
        Me.btnCopiaOrdineNuovo.Text = "Copia Nuovo Ordine In Database Per La Stampa"
        Me.btnCopiaOrdineNuovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
        Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.DisplayName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'btnChiudi
        '
        Me.btnChiudi.AccessibleDescription = "Chiudi Finestra"
        Me.btnChiudi.AccessibleName = "Chiudi Finestra"
        Me.btnChiudi.DisplayName = "CommandBarButton1"
        Me.btnChiudi.DrawText = True
        Me.btnChiudi.Image = CType(resources.GetObject("btnChiudi.Image"), System.Drawing.Image)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Text = "Chiudi Finestra"
        Me.btnChiudi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadGroupBoxTxtNumOrdine
        '
        Me.RadGroupBoxTxtNumOrdine.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxTxtNumOrdine.Controls.Add(Me.btnCaricaArticoli)
        Me.RadGroupBoxTxtNumOrdine.Controls.Add(Me.txtOrdineDaStampareAuto)
        Me.RadGroupBoxTxtNumOrdine.HeaderText = "Numero Ordine Da Stampare"
        Me.RadGroupBoxTxtNumOrdine.Location = New System.Drawing.Point(7, 127)
        Me.RadGroupBoxTxtNumOrdine.Name = "RadGroupBoxTxtNumOrdine"
        Me.RadGroupBoxTxtNumOrdine.Size = New System.Drawing.Size(1349, 59)
        Me.RadGroupBoxTxtNumOrdine.TabIndex = 1
        Me.RadGroupBoxTxtNumOrdine.Text = "Numero Ordine Da Stampare"
        '
        'btnCaricaArticoli
        '
        Me.btnCaricaArticoli.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaricaArticoli.Location = New System.Drawing.Point(327, 21)
        Me.btnCaricaArticoli.Name = "btnCaricaArticoli"
        Me.btnCaricaArticoli.Size = New System.Drawing.Size(211, 29)
        Me.btnCaricaArticoli.TabIndex = 1
        Me.btnCaricaArticoli.Text = "Carica Articoli Da Stampare"
        Me.btnCaricaArticoli.UseVisualStyleBackColor = True
        '
        'txtOrdineDaStampareAuto
        '
        Me.txtOrdineDaStampareAuto.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtOrdineDaStampareAuto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdineDaStampareAuto.Location = New System.Drawing.Point(5, 21)
        Me.txtOrdineDaStampareAuto.Name = "txtOrdineDaStampareAuto"
        Me.txtOrdineDaStampareAuto.Size = New System.Drawing.Size(316, 29)
        Me.txtOrdineDaStampareAuto.TabIndex = 0
        '
        'RadGroupBoxArticoliOrdine
        '
        Me.RadGroupBoxArticoliOrdine.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxArticoliOrdine.Controls.Add(Me.DataGridViewNuovoOrdineDaStampAuto)
        Me.RadGroupBoxArticoliOrdine.HeaderText = "Articoli Ordine Da Stampare"
        Me.RadGroupBoxArticoliOrdine.Location = New System.Drawing.Point(10, 287)
        Me.RadGroupBoxArticoliOrdine.Name = "RadGroupBoxArticoliOrdine"
        Me.RadGroupBoxArticoliOrdine.Size = New System.Drawing.Size(1346, 285)
        Me.RadGroupBoxArticoliOrdine.TabIndex = 2
        Me.RadGroupBoxArticoliOrdine.Text = "Articoli Ordine Da Stampare"
        '
        'DataGridViewNuovoOrdineDaStampAuto
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.DataGridViewNuovoOrdineDaStampAuto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewNuovoOrdineDaStampAuto.AutoGenerateColumns = False
        Me.DataGridViewNuovoOrdineDaStampAuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewNuovoOrdineDaStampAuto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewNuovoOrdineDaStampAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewNuovoOrdineDaStampAuto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RigaDataGridViewTextBoxColumn, Me.MaterialeDataGridViewTextBoxColumn, Me.QuantitaDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn, Me.DataConsegnaDataGridViewTextBoxColumn, Me.OrdineDataGridViewTextBoxColumn, Me.PrezzoDataGridViewTextBoxColumn, Me.CodicePadreDataGridViewTextBoxColumn, Me.MeccanicaDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.TotaleDataGridViewTextBoxColumn})
        Me.DataGridViewNuovoOrdineDaStampAuto.DataSource = Me.BindingSource1
        Me.DataGridViewNuovoOrdineDaStampAuto.Location = New System.Drawing.Point(5, 21)
        Me.DataGridViewNuovoOrdineDaStampAuto.Name = "DataGridViewNuovoOrdineDaStampAuto"
        Me.DataGridViewNuovoOrdineDaStampAuto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewNuovoOrdineDaStampAuto.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        Me.DataGridViewNuovoOrdineDaStampAuto.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewNuovoOrdineDaStampAuto.Size = New System.Drawing.Size(1336, 256)
        Me.DataGridViewNuovoOrdineDaStampAuto.TabIndex = 0
        '
        'RigaDataGridViewTextBoxColumn
        '
        Me.RigaDataGridViewTextBoxColumn.DataPropertyName = "Riga"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RigaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.RigaDataGridViewTextBoxColumn.DividerWidth = 1
        Me.RigaDataGridViewTextBoxColumn.HeaderText = "N° Riga"
        Me.RigaDataGridViewTextBoxColumn.Name = "RigaDataGridViewTextBoxColumn"
        Me.RigaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RigaDataGridViewTextBoxColumn.ToolTipText = "Numero Riga Ordine Nuovo"
        '
        'MaterialeDataGridViewTextBoxColumn
        '
        Me.MaterialeDataGridViewTextBoxColumn.DataPropertyName = "Materiale"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MaterialeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MaterialeDataGridViewTextBoxColumn.DividerWidth = 1
        Me.MaterialeDataGridViewTextBoxColumn.HeaderText = "N° Codice Articolo"
        Me.MaterialeDataGridViewTextBoxColumn.Name = "MaterialeDataGridViewTextBoxColumn"
        Me.MaterialeDataGridViewTextBoxColumn.ToolTipText = "Numero di Codice Articolo"
        Me.MaterialeDataGridViewTextBoxColumn.Width = 150
        '
        'QuantitaDataGridViewTextBoxColumn
        '
        Me.QuantitaDataGridViewTextBoxColumn.DataPropertyName = "Quantita"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QuantitaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.QuantitaDataGridViewTextBoxColumn.DividerWidth = 1
        Me.QuantitaDataGridViewTextBoxColumn.HeaderText = "Quantita"
        Me.QuantitaDataGridViewTextBoxColumn.Name = "QuantitaDataGridViewTextBoxColumn"
        Me.QuantitaDataGridViewTextBoxColumn.ToolTipText = "Quantita Pezzi Da Fare"
        Me.QuantitaDataGridViewTextBoxColumn.Width = 60
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DescrizioneDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DescrizioneDataGridViewTextBoxColumn.DividerWidth = 1
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        Me.DescrizioneDataGridViewTextBoxColumn.ToolTipText = "Descrizione Articolo"
        Me.DescrizioneDataGridViewTextBoxColumn.Width = 200
        '
        'DataConsegnaDataGridViewTextBoxColumn
        '
        Me.DataConsegnaDataGridViewTextBoxColumn.DataPropertyName = "DataConsegna"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataConsegnaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataConsegnaDataGridViewTextBoxColumn.DividerWidth = 1
        Me.DataConsegnaDataGridViewTextBoxColumn.HeaderText = "Data Consegna Art."
        Me.DataConsegnaDataGridViewTextBoxColumn.Name = "DataConsegnaDataGridViewTextBoxColumn"
        Me.DataConsegnaDataGridViewTextBoxColumn.ToolTipText = "Data di Consegna Articolo"
        Me.DataConsegnaDataGridViewTextBoxColumn.Width = 150
        '
        'OrdineDataGridViewTextBoxColumn
        '
        Me.OrdineDataGridViewTextBoxColumn.DataPropertyName = "Ordine"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OrdineDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.OrdineDataGridViewTextBoxColumn.DividerWidth = 1
        Me.OrdineDataGridViewTextBoxColumn.HeaderText = "N° Ordine"
        Me.OrdineDataGridViewTextBoxColumn.Name = "OrdineDataGridViewTextBoxColumn"
        '
        'PrezzoDataGridViewTextBoxColumn
        '
        Me.PrezzoDataGridViewTextBoxColumn.DataPropertyName = "Prezzo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PrezzoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrezzoDataGridViewTextBoxColumn.DividerWidth = 1
        Me.PrezzoDataGridViewTextBoxColumn.HeaderText = "Prezzo"
        Me.PrezzoDataGridViewTextBoxColumn.Name = "PrezzoDataGridViewTextBoxColumn"
        '
        'CodicePadreDataGridViewTextBoxColumn
        '
        Me.CodicePadreDataGridViewTextBoxColumn.DataPropertyName = "CodicePadre"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CodicePadreDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.CodicePadreDataGridViewTextBoxColumn.DividerWidth = 1
        Me.CodicePadreDataGridViewTextBoxColumn.HeaderText = "Codice Padre"
        Me.CodicePadreDataGridViewTextBoxColumn.Name = "CodicePadreDataGridViewTextBoxColumn"
        '
        'MeccanicaDataGridViewTextBoxColumn
        '
        Me.MeccanicaDataGridViewTextBoxColumn.DataPropertyName = "Meccanica"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MeccanicaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.MeccanicaDataGridViewTextBoxColumn.DividerWidth = 1
        Me.MeccanicaDataGridViewTextBoxColumn.HeaderText = "Meccanica"
        Me.MeccanicaDataGridViewTextBoxColumn.Name = "MeccanicaDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NoteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.NoteDataGridViewTextBoxColumn.DividerWidth = 1
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ToolTipText = "Note Articolo"
        '
        'TotaleDataGridViewTextBoxColumn
        '
        Me.TotaleDataGridViewTextBoxColumn.DataPropertyName = "Totale"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TotaleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.TotaleDataGridViewTextBoxColumn.DividerWidth = 1
        Me.TotaleDataGridViewTextBoxColumn.HeaderText = "Totale"
        Me.TotaleDataGridViewTextBoxColumn.Name = "TotaleDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblNuovoOrdinePerAutom"
        Me.BindingSource1.DataSource = Me.DbSchedaLavoroBBGDataSet
        '
        'DbSchedaLavoroBBGDataSet
        '
        Me.DbSchedaLavoroBBGDataSet.DataSetName = "dbSchedaLavoroBBGDataSet"
        Me.DbSchedaLavoroBBGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelMsg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelMsg
        '
        Me.ToolStripStatusLabelMsg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelMsg.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabelMsg.Name = "ToolStripStatusLabelMsg"
        Me.ToolStripStatusLabelMsg.Size = New System.Drawing.Size(0, 17)
        '
        'TblNuovoOrdinePerAutomTableAdapter
        '
        Me.TblNuovoOrdinePerAutomTableAdapter.ClearBeforeFill = True
        '
        'RadGroupBoxArtInStampa
        '
        Me.RadGroupBoxArtInStampa.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxArtInStampa.Controls.Add(Me.lblCodiceInStampa)
        Me.RadGroupBoxArtInStampa.Controls.Add(Me.btnAvvioStampaAutomatica)
        Me.RadGroupBoxArtInStampa.HeaderText = "Articolo In Stampa"
        Me.RadGroupBoxArtInStampa.Location = New System.Drawing.Point(7, 197)
        Me.RadGroupBoxArtInStampa.Name = "RadGroupBoxArtInStampa"
        Me.RadGroupBoxArtInStampa.Size = New System.Drawing.Size(1349, 77)
        Me.RadGroupBoxArtInStampa.TabIndex = 4
        Me.RadGroupBoxArtInStampa.Text = "Articolo In Stampa"
        '
        'lblCodiceInStampa
        '
        Me.lblCodiceInStampa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodiceInStampa.Location = New System.Drawing.Point(252, 26)
        Me.lblCodiceInStampa.Name = "lblCodiceInStampa"
        Me.lblCodiceInStampa.Size = New System.Drawing.Size(663, 34)
        Me.lblCodiceInStampa.TabIndex = 1
        '
        'btnAvvioStampaAutomatica
        '
        Me.btnAvvioStampaAutomatica.Location = New System.Drawing.Point(21, 26)
        Me.btnAvvioStampaAutomatica.Name = "btnAvvioStampaAutomatica"
        Me.btnAvvioStampaAutomatica.Size = New System.Drawing.Size(220, 34)
        Me.btnAvvioStampaAutomatica.TabIndex = 0
        Me.btnAvvioStampaAutomatica.Text = "Avvia Stampa Automatica"
        Me.btnAvvioStampaAutomatica.UseVisualStyleBackColor = True
        '
        'PanelPrintObj
        '
        Me.PanelPrintObj.Controls.Add(Me.CrystalReportViewer2)
        Me.PanelPrintObj.Location = New System.Drawing.Point(11, 578)
        Me.PanelPrintObj.Name = "PanelPrintObj"
        Me.PanelPrintObj.Size = New System.Drawing.Size(1345, 234)
        Me.PanelPrintObj.TabIndex = 5
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1340, 234)
        Me.CrystalReportViewer2.TabIndex = 0
        '
        'frmStampaOrdiniAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PanelPrintObj)
        Me.Controls.Add(Me.RadGroupBoxArtInStampa)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RadGroupBoxArticoliOrdine)
        Me.Controls.Add(Me.RadGroupBoxTxtNumOrdine)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStampaOrdiniAutomatico"
        Me.Text = "Stampa Ordini Automatico"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxTxtNumOrdine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxTxtNumOrdine.ResumeLayout(False)
        Me.RadGroupBoxTxtNumOrdine.PerformLayout()
        CType(Me.RadGroupBoxArticoliOrdine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxArticoliOrdine.ResumeLayout(False)
        CType(Me.DataGridViewNuovoOrdineDaStampAuto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbSchedaLavoroBBGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.RadGroupBoxArtInStampa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxArtInStampa.ResumeLayout(False)
        Me.PanelPrintObj.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnStampaAutomatico As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadGroupBoxTxtNumOrdine As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtOrdineDaStampareAuto As TextBox
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnChiudi As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadGroupBoxArticoliOrdine As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents DataGridViewNuovoOrdineDaStampAuto As DataGridView
    Friend WithEvents btnCaricaArticoli As Button
    Friend WithEvents btnCopiaOrdineNuovo As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DbSchedaLavoroBBGDataSet As dbSchedaLavoroBBGDataSet
    Friend WithEvents TblNuovoOrdinePerAutomTableAdapter As dbSchedaLavoroBBGDataSetTableAdapters.tblNuovoOrdinePerAutomTableAdapter
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RigaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantitaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataConsegnaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodicePadreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MeccanicaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabelMsg As ToolStripStatusLabel
    Friend WithEvents RadGroupBoxArtInStampa As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btnAvvioStampaAutomatica As Button
    Friend WithEvents lblCodiceInStampa As Label
    Friend WithEvents PanelPrintObj As Panel
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
