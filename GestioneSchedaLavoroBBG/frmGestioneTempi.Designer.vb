<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestioneTempi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestioneTempi))
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.btnAggiungiTempi = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnUpdateTempi = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnCancellaTempi = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarButton1 = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadGroupBoxTempi = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGridViewTempi = New Telerik.WinControls.UI.RadGridView()
        Me.BindingSourceTempi = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTempi = New GestioneSchedaLavoroBBG.DsTempi()
        Me.StatusStripTempi = New System.Windows.Forms.StatusStrip()
        Me.RadGroupBoxAggiornaTempi = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtAggGiorniMontaggio = New System.Windows.Forms.TextBox()
        Me.lblAggGiorniMontaggio = New System.Windows.Forms.Label()
        Me.txtAggGiorniVerniciatura = New System.Windows.Forms.TextBox()
        Me.lblAggGiorniVerniciatura = New System.Windows.Forms.Label()
        Me.txtAggGiorniTrattamento = New System.Windows.Forms.TextBox()
        Me.lblAddGiorniTratt = New System.Windows.Forms.Label()
        Me.txtAggMinuti = New System.Windows.Forms.TextBox()
        Me.lblAggMin = New System.Windows.Forms.Label()
        Me.txtAggCodice = New System.Windows.Forms.TextBox()
        Me.lblAggCodice = New System.Windows.Forms.Label()
        Me.RadGroupBoxAddTempi = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtGiorniMontaggio = New System.Windows.Forms.TextBox()
        Me.lblGiorniMontaggio = New System.Windows.Forms.Label()
        Me.txtGiorniVerniciatura = New System.Windows.Forms.TextBox()
        Me.lblGiorniVern = New System.Windows.Forms.Label()
        Me.txtGiorniTrattamento = New System.Windows.Forms.TextBox()
        Me.lblGiorniTratta = New System.Windows.Forms.Label()
        Me.txtTempoMinuti = New System.Windows.Forms.TextBox()
        Me.lblTempoMinuti = New System.Windows.Forms.Label()
        Me.txtCodice = New System.Windows.Forms.TextBox()
        Me.lblCodice = New System.Windows.Forms.Label()
        Me.TblTempiTableAdapter = New GestioneSchedaLavoroBBG.DsTempiTableAdapters.tblTempiTableAdapter()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxTempi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxTempi.SuspendLayout()
        CType(Me.RadGridViewTempi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridViewTempi.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTempi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTempi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxAggiornaTempi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxAggiornaTempi.SuspendLayout()
        CType(Me.RadGroupBoxAddTempi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxAddTempi.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(820, 88)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnAggiungiTempi, Me.CommandBarSeparator1, Me.btnUpdateTempi, Me.CommandBarSeparator2, Me.btnCancellaTempi, Me.CommandBarSeparator3, Me.CommandBarButton1, Me.CommandBarSeparator4})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'btnAggiungiTempi
        '
        Me.btnAggiungiTempi.AccessibleDescription = "Aggiungi Tempi"
        Me.btnAggiungiTempi.AccessibleName = "Aggiungi Tempi"
        Me.btnAggiungiTempi.DisplayName = "CommandBarButton1"
        Me.btnAggiungiTempi.DrawText = True
        Me.btnAggiungiTempi.Image = CType(resources.GetObject("btnAggiungiTempi.Image"), System.Drawing.Image)
        Me.btnAggiungiTempi.Name = "btnAggiungiTempi"
        Me.btnAggiungiTempi.Text = "Aggiungi Tempi"
        Me.btnAggiungiTempi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAggiungiTempi.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'btnUpdateTempi
        '
        Me.btnUpdateTempi.AccessibleDescription = "Aggiorna Tempi"
        Me.btnUpdateTempi.AccessibleName = "Aggiorna Tempi"
        Me.btnUpdateTempi.DisplayName = "CommandBarButton1"
        Me.btnUpdateTempi.DrawText = True
        Me.btnUpdateTempi.Image = CType(resources.GetObject("btnUpdateTempi.Image"), System.Drawing.Image)
        Me.btnUpdateTempi.Name = "btnUpdateTempi"
        Me.btnUpdateTempi.Text = "Aggiorna Tempi"
        Me.btnUpdateTempi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdateTempi.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'btnCancellaTempi
        '
        Me.btnCancellaTempi.AccessibleDescription = "Cancella Tempi"
        Me.btnCancellaTempi.AccessibleName = "Cancella Tempi"
        Me.btnCancellaTempi.DisplayName = "CommandBarButton1"
        Me.btnCancellaTempi.DrawText = True
        Me.btnCancellaTempi.Image = CType(resources.GetObject("btnCancellaTempi.Image"), System.Drawing.Image)
        Me.btnCancellaTempi.Name = "btnCancellaTempi"
        Me.btnCancellaTempi.Text = "Cancella Tempi"
        Me.btnCancellaTempi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancellaTempi.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'CommandBarButton1
        '
        Me.CommandBarButton1.AccessibleDescription = "Esci "
        Me.CommandBarButton1.AccessibleName = "Esci "
        Me.CommandBarButton1.DisplayName = "CommandBarButton1"
        Me.CommandBarButton1.DrawText = True
        Me.CommandBarButton1.Image = CType(resources.GetObject("CommandBarButton1.Image"), System.Drawing.Image)
        Me.CommandBarButton1.Name = "CommandBarButton1"
        Me.CommandBarButton1.Text = "Esci "
        Me.CommandBarButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CommandBarButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'RadGroupBoxTempi
        '
        Me.RadGroupBoxTempi.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxTempi.Controls.Add(Me.RadGridViewTempi)
        Me.RadGroupBoxTempi.HeaderText = "Gestione Tempi Lavorazione Articoli"
        Me.RadGroupBoxTempi.Location = New System.Drawing.Point(12, 268)
        Me.RadGroupBoxTempi.Name = "RadGroupBoxTempi"
        Me.RadGroupBoxTempi.Size = New System.Drawing.Size(781, 361)
        Me.RadGroupBoxTempi.TabIndex = 1
        Me.RadGroupBoxTempi.Text = "Gestione Tempi Lavorazione Articoli"
        '
        'RadGridViewTempi
        '
        Me.RadGridViewTempi.AutoScroll = True
        Me.RadGridViewTempi.Location = New System.Drawing.Point(5, 21)
        '
        'RadGridViewTempi
        '
        Me.RadGridViewTempi.MasterTemplate.AllowAddNewRow = False
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.FieldName = "ID"
        GridViewDecimalColumn1.HeaderText = "ID"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.Name = "ID"
        GridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn1.FieldName = "Codice"
        GridViewTextBoxColumn1.HeaderText = "Codice"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "Codice"
        GridViewTextBoxColumn1.Width = 200
        GridViewDecimalColumn2.DataType = GetType(Double)
        GridViewDecimalColumn2.FieldName = "TempoMinuti"
        GridViewDecimalColumn2.HeaderText = "Tempo Minuti"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.Name = "TempoMinuti"
        GridViewDecimalColumn2.Width = 100
        GridViewDecimalColumn3.DataType = GetType(Double)
        GridViewDecimalColumn3.FieldName = "TempoDaMinutiAore"
        GridViewDecimalColumn3.HeaderText = "Tempo Minuti - Ore"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.Name = "TempoDaMinutiAore"
        GridViewDecimalColumn3.ReadOnly = True
        GridViewDecimalColumn3.Width = 140
        GridViewDecimalColumn4.DataType = GetType(Integer)
        GridViewDecimalColumn4.FieldName = "TempoGiorniTrattamento"
        GridViewDecimalColumn4.HeaderText = "Giorni Trattamento"
        GridViewDecimalColumn4.IsAutoGenerated = True
        GridViewDecimalColumn4.Name = "TempoGiorniTrattamento"
        GridViewDecimalColumn4.Width = 90
        GridViewDecimalColumn5.DataType = GetType(Integer)
        GridViewDecimalColumn5.FieldName = "TempoGiorniVerniciatura"
        GridViewDecimalColumn5.HeaderText = "Giorni Verniciatura"
        GridViewDecimalColumn5.IsAutoGenerated = True
        GridViewDecimalColumn5.Name = "TempoGiorniVerniciatura"
        GridViewDecimalColumn5.Width = 90
        GridViewDecimalColumn6.DataType = GetType(Integer)
        GridViewDecimalColumn6.FieldName = "TempoGiorniMontaggio"
        GridViewDecimalColumn6.HeaderText = "Giorni Montaggio"
        GridViewDecimalColumn6.Name = "TempoGiorniMontaggio"
        GridViewDecimalColumn6.Width = 90
        Me.RadGridViewTempi.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewDecimalColumn6})
        Me.RadGridViewTempi.MasterTemplate.DataSource = Me.BindingSourceTempi
        Me.RadGridViewTempi.MasterTemplate.EnableFiltering = True
        Me.RadGridViewTempi.MasterTemplate.EnableGrouping = False
        SortDescriptor1.PropertyName = "ID"
        Me.RadGridViewTempi.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RadGridViewTempi.Name = "RadGridViewTempi"
        Me.RadGridViewTempi.Size = New System.Drawing.Size(768, 335)
        Me.RadGridViewTempi.TabIndex = 0
        Me.RadGridViewTempi.Text = "Grid View Tempi"
        '
        'BindingSourceTempi
        '
        Me.BindingSourceTempi.DataMember = "tblTempi"
        Me.BindingSourceTempi.DataSource = Me.DsTempi
        Me.BindingSourceTempi.Sort = "ID"
        '
        'DsTempi
        '
        Me.DsTempi.DataSetName = "DsTempi"
        Me.DsTempi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStripTempi
        '
        Me.StatusStripTempi.Location = New System.Drawing.Point(0, 654)
        Me.StatusStripTempi.Name = "StatusStripTempi"
        Me.StatusStripTempi.Size = New System.Drawing.Size(820, 22)
        Me.StatusStripTempi.TabIndex = 2
        Me.StatusStripTempi.Text = "StatusStrip1"
        '
        'RadGroupBoxAggiornaTempi
        '
        Me.RadGroupBoxAggiornaTempi.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxAggiornaTempi.BackColor = System.Drawing.Color.Cornsilk
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.txtAggGiorniMontaggio)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.lblAggGiorniMontaggio)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.txtAggGiorniVerniciatura)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.lblAggGiorniVerniciatura)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.txtAggGiorniTrattamento)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.lblAddGiorniTratt)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.txtAggMinuti)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.lblAggMin)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.txtAggCodice)
        Me.RadGroupBoxAggiornaTempi.Controls.Add(Me.lblAggCodice)
        Me.RadGroupBoxAggiornaTempi.HeaderText = "Aggiorna Tempi"
        Me.RadGroupBoxAggiornaTempi.Location = New System.Drawing.Point(411, 99)
        Me.RadGroupBoxAggiornaTempi.Name = "RadGroupBoxAggiornaTempi"
        Me.RadGroupBoxAggiornaTempi.Size = New System.Drawing.Size(382, 163)
        Me.RadGroupBoxAggiornaTempi.TabIndex = 3
        Me.RadGroupBoxAggiornaTempi.Text = "Aggiorna Tempi"
        '
        'txtAggGiorniMontaggio
        '
        Me.txtAggGiorniMontaggio.Location = New System.Drawing.Point(123, 133)
        Me.txtAggGiorniMontaggio.Name = "txtAggGiorniMontaggio"
        Me.txtAggGiorniMontaggio.Size = New System.Drawing.Size(255, 20)
        Me.txtAggGiorniMontaggio.TabIndex = 17
        Me.txtAggGiorniMontaggio.Text = "15"
        '
        'lblAggGiorniMontaggio
        '
        Me.lblAggGiorniMontaggio.Location = New System.Drawing.Point(5, 136)
        Me.lblAggGiorniMontaggio.Name = "lblAggGiorniMontaggio"
        Me.lblAggGiorniMontaggio.Size = New System.Drawing.Size(112, 13)
        Me.lblAggGiorniMontaggio.TabIndex = 16
        Me.lblAggGiorniMontaggio.Text = "Giorni Montaggio :"
        Me.lblAggGiorniMontaggio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAggGiorniVerniciatura
        '
        Me.txtAggGiorniVerniciatura.Location = New System.Drawing.Point(123, 108)
        Me.txtAggGiorniVerniciatura.Name = "txtAggGiorniVerniciatura"
        Me.txtAggGiorniVerniciatura.Size = New System.Drawing.Size(255, 20)
        Me.txtAggGiorniVerniciatura.TabIndex = 15
        Me.txtAggGiorniVerniciatura.Text = "15"
        '
        'lblAggGiorniVerniciatura
        '
        Me.lblAggGiorniVerniciatura.Location = New System.Drawing.Point(5, 111)
        Me.lblAggGiorniVerniciatura.Name = "lblAggGiorniVerniciatura"
        Me.lblAggGiorniVerniciatura.Size = New System.Drawing.Size(112, 13)
        Me.lblAggGiorniVerniciatura.TabIndex = 14
        Me.lblAggGiorniVerniciatura.Text = "Giorni Verniciatura :"
        Me.lblAggGiorniVerniciatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAggGiorniTrattamento
        '
        Me.txtAggGiorniTrattamento.Location = New System.Drawing.Point(123, 82)
        Me.txtAggGiorniTrattamento.Name = "txtAggGiorniTrattamento"
        Me.txtAggGiorniTrattamento.Size = New System.Drawing.Size(255, 20)
        Me.txtAggGiorniTrattamento.TabIndex = 13
        Me.txtAggGiorniTrattamento.Text = "5"
        '
        'lblAddGiorniTratt
        '
        Me.lblAddGiorniTratt.Location = New System.Drawing.Point(5, 85)
        Me.lblAddGiorniTratt.Name = "lblAddGiorniTratt"
        Me.lblAddGiorniTratt.Size = New System.Drawing.Size(112, 13)
        Me.lblAddGiorniTratt.TabIndex = 12
        Me.lblAddGiorniTratt.Text = "Giorni Trattamento :"
        Me.lblAddGiorniTratt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAggMinuti
        '
        Me.txtAggMinuti.Location = New System.Drawing.Point(123, 58)
        Me.txtAggMinuti.Name = "txtAggMinuti"
        Me.txtAggMinuti.Size = New System.Drawing.Size(255, 20)
        Me.txtAggMinuti.TabIndex = 11
        '
        'lblAggMin
        '
        Me.lblAggMin.Location = New System.Drawing.Point(5, 61)
        Me.lblAggMin.Name = "lblAggMin"
        Me.lblAggMin.Size = New System.Drawing.Size(112, 13)
        Me.lblAggMin.TabIndex = 10
        Me.lblAggMin.Text = "Tempo Minuti :"
        Me.lblAggMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAggCodice
        '
        Me.txtAggCodice.Location = New System.Drawing.Point(123, 34)
        Me.txtAggCodice.Name = "txtAggCodice"
        Me.txtAggCodice.Size = New System.Drawing.Size(255, 20)
        Me.txtAggCodice.TabIndex = 9
        '
        'lblAggCodice
        '
        Me.lblAggCodice.Location = New System.Drawing.Point(5, 37)
        Me.lblAggCodice.Name = "lblAggCodice"
        Me.lblAggCodice.Size = New System.Drawing.Size(112, 13)
        Me.lblAggCodice.TabIndex = 8
        Me.lblAggCodice.Text = "Codice :"
        Me.lblAggCodice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadGroupBoxAddTempi
        '
        Me.RadGroupBoxAddTempi.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxAddTempi.BackColor = System.Drawing.Color.Azure
        Me.RadGroupBoxAddTempi.Controls.Add(Me.txtGiorniMontaggio)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.lblGiorniMontaggio)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.txtGiorniVerniciatura)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.lblGiorniVern)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.txtGiorniTrattamento)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.lblGiorniTratta)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.txtTempoMinuti)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.lblTempoMinuti)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.txtCodice)
        Me.RadGroupBoxAddTempi.Controls.Add(Me.lblCodice)
        Me.RadGroupBoxAddTempi.HeaderText = "Aggiungi Tempi"
        Me.RadGroupBoxAddTempi.Location = New System.Drawing.Point(12, 99)
        Me.RadGroupBoxAddTempi.Name = "RadGroupBoxAddTempi"
        Me.RadGroupBoxAddTempi.Size = New System.Drawing.Size(393, 163)
        Me.RadGroupBoxAddTempi.TabIndex = 4
        Me.RadGroupBoxAddTempi.Text = "Aggiungi Tempi"
        '
        'txtGiorniMontaggio
        '
        Me.txtGiorniMontaggio.Location = New System.Drawing.Point(133, 133)
        Me.txtGiorniMontaggio.Name = "txtGiorniMontaggio"
        Me.txtGiorniMontaggio.Size = New System.Drawing.Size(255, 20)
        Me.txtGiorniMontaggio.TabIndex = 9
        Me.txtGiorniMontaggio.Text = "15"
        '
        'lblGiorniMontaggio
        '
        Me.lblGiorniMontaggio.Location = New System.Drawing.Point(15, 136)
        Me.lblGiorniMontaggio.Name = "lblGiorniMontaggio"
        Me.lblGiorniMontaggio.Size = New System.Drawing.Size(112, 13)
        Me.lblGiorniMontaggio.TabIndex = 8
        Me.lblGiorniMontaggio.Text = "Giorni Montaggio :"
        Me.lblGiorniMontaggio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGiorniVerniciatura
        '
        Me.txtGiorniVerniciatura.Location = New System.Drawing.Point(133, 107)
        Me.txtGiorniVerniciatura.Name = "txtGiorniVerniciatura"
        Me.txtGiorniVerniciatura.Size = New System.Drawing.Size(255, 20)
        Me.txtGiorniVerniciatura.TabIndex = 7
        Me.txtGiorniVerniciatura.Text = "15"
        '
        'lblGiorniVern
        '
        Me.lblGiorniVern.Location = New System.Drawing.Point(15, 110)
        Me.lblGiorniVern.Name = "lblGiorniVern"
        Me.lblGiorniVern.Size = New System.Drawing.Size(112, 13)
        Me.lblGiorniVern.TabIndex = 6
        Me.lblGiorniVern.Text = "Giorni Verniciatura :"
        Me.lblGiorniVern.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGiorniTrattamento
        '
        Me.txtGiorniTrattamento.Location = New System.Drawing.Point(133, 81)
        Me.txtGiorniTrattamento.Name = "txtGiorniTrattamento"
        Me.txtGiorniTrattamento.Size = New System.Drawing.Size(255, 20)
        Me.txtGiorniTrattamento.TabIndex = 5
        Me.txtGiorniTrattamento.Text = "5"
        '
        'lblGiorniTratta
        '
        Me.lblGiorniTratta.Location = New System.Drawing.Point(15, 84)
        Me.lblGiorniTratta.Name = "lblGiorniTratta"
        Me.lblGiorniTratta.Size = New System.Drawing.Size(112, 13)
        Me.lblGiorniTratta.TabIndex = 4
        Me.lblGiorniTratta.Text = "Giorni Trattamento :"
        Me.lblGiorniTratta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempoMinuti
        '
        Me.txtTempoMinuti.Location = New System.Drawing.Point(133, 57)
        Me.txtTempoMinuti.Name = "txtTempoMinuti"
        Me.txtTempoMinuti.Size = New System.Drawing.Size(255, 20)
        Me.txtTempoMinuti.TabIndex = 3
        '
        'lblTempoMinuti
        '
        Me.lblTempoMinuti.Location = New System.Drawing.Point(15, 60)
        Me.lblTempoMinuti.Name = "lblTempoMinuti"
        Me.lblTempoMinuti.Size = New System.Drawing.Size(112, 13)
        Me.lblTempoMinuti.TabIndex = 2
        Me.lblTempoMinuti.Text = "Tempo Minuti :"
        Me.lblTempoMinuti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodice
        '
        Me.txtCodice.Location = New System.Drawing.Point(133, 33)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(255, 20)
        Me.txtCodice.TabIndex = 1
        '
        'lblCodice
        '
        Me.lblCodice.Location = New System.Drawing.Point(15, 36)
        Me.lblCodice.Name = "lblCodice"
        Me.lblCodice.Size = New System.Drawing.Size(112, 13)
        Me.lblCodice.TabIndex = 0
        Me.lblCodice.Text = "Codice :"
        Me.lblCodice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TblTempiTableAdapter
        '
        Me.TblTempiTableAdapter.ClearBeforeFill = True
        '
        'FrmGestioneTempi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 676)
        Me.Controls.Add(Me.RadGroupBoxAddTempi)
        Me.Controls.Add(Me.RadGroupBoxAggiornaTempi)
        Me.Controls.Add(Me.StatusStripTempi)
        Me.Controls.Add(Me.RadGroupBoxTempi)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGestioneTempi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Tempi"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxTempi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxTempi.ResumeLayout(False)
        CType(Me.RadGridViewTempi.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridViewTempi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTempi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTempi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxAggiornaTempi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxAggiornaTempi.ResumeLayout(False)
        Me.RadGroupBoxAggiornaTempi.PerformLayout()
        CType(Me.RadGroupBoxAddTempi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxAddTempi.ResumeLayout(False)
        Me.RadGroupBoxAddTempi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadGroupBoxTempi As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGridViewTempi As Telerik.WinControls.UI.RadGridView
    Friend WithEvents StatusStripTempi As StatusStrip
    Friend WithEvents RadGroupBoxAggiornaTempi As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btnAggiungiTempi As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnUpdateTempi As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents btnCancellaTempi As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarButton1 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadGroupBoxAddTempi As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents DsTempi As DsTempi
    Friend WithEvents BindingSourceTempi As BindingSource
    Friend WithEvents TblTempiTableAdapter As DsTempiTableAdapters.tblTempiTableAdapter
    Friend WithEvents txtTempoMinuti As TextBox
    Friend WithEvents lblTempoMinuti As Label
    Friend WithEvents txtCodice As TextBox
    Friend WithEvents lblCodice As Label
    Friend WithEvents txtGiorniVerniciatura As TextBox
    Friend WithEvents lblGiorniVern As Label
    Friend WithEvents txtGiorniTrattamento As TextBox
    Friend WithEvents lblGiorniTratta As Label
    Friend WithEvents txtAggGiorniVerniciatura As TextBox
    Friend WithEvents lblAggGiorniVerniciatura As Label
    Friend WithEvents txtAggGiorniTrattamento As TextBox
    Friend WithEvents lblAddGiorniTratt As Label
    Friend WithEvents txtAggMinuti As TextBox
    Friend WithEvents lblAggMin As Label
    Friend WithEvents txtAggCodice As TextBox
    Friend WithEvents lblAggCodice As Label
    Friend WithEvents lblGiorniMontaggio As Label
    Friend WithEvents lblAggGiorniMontaggio As Label
    Friend WithEvents txtGiorniMontaggio As TextBox
    Friend WithEvents txtAggGiorniMontaggio As TextBox
End Class
