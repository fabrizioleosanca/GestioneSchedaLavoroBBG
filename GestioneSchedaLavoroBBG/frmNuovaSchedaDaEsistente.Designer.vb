<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuovaSchedaDaEsistente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuovaSchedaDaEsistente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cmdCambiaIDScheda = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdSalvaNuovaScheda = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.btnStampaScheda = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdChiudiForm = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarLabelAvvisi = New Telerik.WinControls.UI.CommandBarLabel()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadGroupBoxTestata = New Telerik.WinControls.UI.RadGroupBox()
        Me.TableLayoutPanelTestata = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCodiceOrdine = New System.Windows.Forms.Label()
        Me.lblCodiceArticolo = New System.Windows.Forms.Label()
        Me.lbldataConsegna = New System.Windows.Forms.Label()
        Me.lblRigaOrdine = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodiceOrdine = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCodiceArticolo = New Telerik.WinControls.UI.RadTextBox()
        Me.dtpDataConsegna = New System.Windows.Forms.DateTimePicker()
        Me.txtNumeroRiga = New Telerik.WinControls.UI.RadTextBox()
        Me.txtNumeroPezziOrd = New Telerik.WinControls.UI.RadTextBox()
        Me.lblFornitore = New System.Windows.Forms.Label()
        Me.cmbFornitore = New System.Windows.Forms.ComboBox()
        Me.lblLotto = New System.Windows.Forms.Label()
        Me.cmbLottoNum = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblMateriale = New System.Windows.Forms.Label()
        Me.txtMateriale = New System.Windows.Forms.ComboBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtNote = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.TableLayoutPanelLavorazioni = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNoteAltreLavorazioni = New System.Windows.Forms.TextBox()
        Me.txtAltreLavorazioni = New System.Windows.Forms.TextBox()
        Me.txtNoteHelicoil = New System.Windows.Forms.TextBox()
        Me.txtClienteHelicolil = New System.Windows.Forms.ComboBox()
        Me.txtNoteVernciatura = New System.Windows.Forms.TextBox()
        Me.txtClienteVerniciatura = New System.Windows.Forms.ComboBox()
        Me.txtTrattamento = New System.Windows.Forms.ComboBox()
        Me.txtClienteTrattamento = New System.Windows.Forms.ComboBox()
        Me.txtOperatore = New System.Windows.Forms.ComboBox()
        Me.txtLavorazioniBBG = New System.Windows.Forms.ComboBox()
        Me.lblLavorazioniBBG = New System.Windows.Forms.Label()
        Me.lblOperatore = New System.Windows.Forms.Label()
        Me.lblClienteTrattamento = New System.Windows.Forms.Label()
        Me.lblTrattamento = New System.Windows.Forms.Label()
        Me.lblAltreLavorazioni = New System.Windows.Forms.Label()
        Me.lblClienteVerniciatura = New System.Windows.Forms.Label()
        Me.lblNoteVerniciatura = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNoteHelicoil = New System.Windows.Forms.Label()
        Me.lblNoteAltreLavorazioni = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtNumOperatore = New System.Windows.Forms.TextBox()
        Me.lblFAI = New System.Windows.Forms.Label()
        Me.chkFAI = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkKC = New System.Windows.Forms.CheckBox()
        Me.lblSchedaLavoro = New Telerik.WinControls.UI.RadLabel()
        Me.txtIDSchedaLavoro = New System.Windows.Forms.TextBox()
        Me.RadGroupBoxSalvaScheda = New Telerik.WinControls.UI.RadGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gridViewDisegni = New System.Windows.Forms.DataGridView()
        Me.NomeFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercorsoFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnApriFile = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxTestata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxTestata.SuspendLayout()
        Me.TableLayoutPanelTestata.SuspendLayout()
        CType(Me.txtCodiceOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodiceArticolo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroRiga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroPezziOrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLottoNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLottoNum.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLottoNum.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        Me.TableLayoutPanelLavorazioni.SuspendLayout()
        CType(Me.lblSchedaLavoro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxSalvaScheda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxSalvaScheda.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gridViewDisegni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.AutoScroll = True
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(874, 72)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cmdCambiaIDScheda, Me.CommandBarSeparator1, Me.cmdSalvaNuovaScheda, Me.CommandBarSeparator2, Me.btnStampaScheda, Me.CommandBarSeparator3, Me.cmdChiudiForm, Me.CommandBarSeparator4, Me.CommandBarLabelAvvisi, Me.CommandBarSeparator5})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cmdCambiaIDScheda
        '
        Me.cmdCambiaIDScheda.AccessibleDescription = "Cambia ID Scheda"
        Me.cmdCambiaIDScheda.AccessibleName = "Cambia ID Scheda"
        Me.cmdCambiaIDScheda.DisplayName = "CommandBarButton1"
        Me.cmdCambiaIDScheda.DrawText = True
        Me.cmdCambiaIDScheda.Image = CType(resources.GetObject("cmdCambiaIDScheda.Image"), System.Drawing.Image)
        Me.cmdCambiaIDScheda.Name = "cmdCambiaIDScheda"
        Me.cmdCambiaIDScheda.Text = "Cambia ID Scheda"
        Me.cmdCambiaIDScheda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCambiaIDScheda.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'cmdSalvaNuovaScheda
        '
        Me.cmdSalvaNuovaScheda.AccessibleDescription = "Salva Nuova Scheda"
        Me.cmdSalvaNuovaScheda.AccessibleName = "Salva Nuova Scheda"
        Me.cmdSalvaNuovaScheda.DisplayName = "CommandBarButton1"
        Me.cmdSalvaNuovaScheda.DrawText = True
        Me.cmdSalvaNuovaScheda.Image = CType(resources.GetObject("cmdSalvaNuovaScheda.Image"), System.Drawing.Image)
        Me.cmdSalvaNuovaScheda.Name = "cmdSalvaNuovaScheda"
        Me.cmdSalvaNuovaScheda.Text = "Salva Nuova Scheda"
        Me.cmdSalvaNuovaScheda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSalvaNuovaScheda.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'btnStampaScheda
        '
        Me.btnStampaScheda.AccessibleDescription = "Stampa Scheda Lavorazioni"
        Me.btnStampaScheda.AccessibleName = "Stampa Scheda Lavorazioni"
        Me.btnStampaScheda.DisplayName = "CommandBarButton1"
        Me.btnStampaScheda.DrawText = True
        Me.btnStampaScheda.Image = CType(resources.GetObject("btnStampaScheda.Image"), System.Drawing.Image)
        Me.btnStampaScheda.Name = "btnStampaScheda"
        Me.btnStampaScheda.Text = "Stampa Scheda Lavorazioni"
        Me.btnStampaScheda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStampaScheda.ToolTipText = "Stampa Scheda Lavorazioni"
        Me.btnStampaScheda.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'cmdChiudiForm
        '
        Me.cmdChiudiForm.AccessibleDescription = "Chiudi"
        Me.cmdChiudiForm.AccessibleName = "Chiudi"
        Me.cmdChiudiForm.DisplayName = "CommandBarButton1"
        Me.cmdChiudiForm.DrawText = True
        Me.cmdChiudiForm.Image = CType(resources.GetObject("cmdChiudiForm.Image"), System.Drawing.Image)
        Me.cmdChiudiForm.Name = "cmdChiudiForm"
        Me.cmdChiudiForm.Text = "Chiudi"
        Me.cmdChiudiForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdChiudiForm.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'CommandBarLabelAvvisi
        '
        Me.CommandBarLabelAvvisi.AutoSize = False
        Me.CommandBarLabelAvvisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CommandBarLabelAvvisi.Bounds = New System.Drawing.Rectangle(0, 0, 230, 68)
        Me.CommandBarLabelAvvisi.DisplayName = "CommandBarLabel1"
        Me.CommandBarLabelAvvisi.DrawBorder = True
        Me.CommandBarLabelAvvisi.DrawFill = True
        Me.CommandBarLabelAvvisi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandBarLabelAvvisi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CommandBarLabelAvvisi.Name = "CommandBarLabelAvvisi"
        Me.CommandBarLabelAvvisi.Text = ""
        Me.CommandBarLabelAvvisi.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.CommandBarLabelAvvisi.TextWrap = True
        Me.CommandBarLabelAvvisi.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        'RadGroupBoxTestata
        '
        Me.RadGroupBoxTestata.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxTestata.Controls.Add(Me.TableLayoutPanelTestata)
        Me.RadGroupBoxTestata.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBoxTestata.HeaderText = "Dati Ordine e Articolo Scheda"
        Me.RadGroupBoxTestata.Location = New System.Drawing.Point(8, 117)
        Me.RadGroupBoxTestata.Name = "RadGroupBoxTestata"
        Me.RadGroupBoxTestata.Size = New System.Drawing.Size(837, 196)
        Me.RadGroupBoxTestata.TabIndex = 1
        Me.RadGroupBoxTestata.Text = "Dati Ordine e Articolo Scheda"
        '
        'TableLayoutPanelTestata
        '
        Me.TableLayoutPanelTestata.ColumnCount = 5
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanelTestata.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286.0!))
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblCodiceOrdine, 0, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblCodiceArticolo, 0, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lbldataConsegna, 0, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblRigaOrdine, 3, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.Label1, 3, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtCodiceOrdine, 1, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtCodiceArticolo, 1, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.dtpDataConsegna, 1, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtNumeroRiga, 4, 0)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtNumeroPezziOrd, 4, 1)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblFornitore, 0, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbFornitore, 1, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblLotto, 3, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.cmbLottoNum, 4, 3)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblMateriale, 3, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtMateriale, 4, 2)
        Me.TableLayoutPanelTestata.Controls.Add(Me.lblNote, 0, 4)
        Me.TableLayoutPanelTestata.Controls.Add(Me.txtNote, 1, 4)
        Me.TableLayoutPanelTestata.Location = New System.Drawing.Point(5, 21)
        Me.TableLayoutPanelTestata.Name = "TableLayoutPanelTestata"
        Me.TableLayoutPanelTestata.RowCount = 5
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTestata.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTestata.Size = New System.Drawing.Size(827, 170)
        Me.TableLayoutPanelTestata.TabIndex = 0
        '
        'lblCodiceOrdine
        '
        Me.lblCodiceOrdine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodiceOrdine.Location = New System.Drawing.Point(3, 0)
        Me.lblCodiceOrdine.Name = "lblCodiceOrdine"
        Me.lblCodiceOrdine.Size = New System.Drawing.Size(122, 29)
        Me.lblCodiceOrdine.TabIndex = 0
        Me.lblCodiceOrdine.Text = "Codice Ordine :"
        Me.lblCodiceOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodiceArticolo
        '
        Me.lblCodiceArticolo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodiceArticolo.Location = New System.Drawing.Point(3, 30)
        Me.lblCodiceArticolo.Name = "lblCodiceArticolo"
        Me.lblCodiceArticolo.Size = New System.Drawing.Size(122, 30)
        Me.lblCodiceArticolo.TabIndex = 1
        Me.lblCodiceArticolo.Text = "Codice Articolo :"
        Me.lblCodiceArticolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldataConsegna
        '
        Me.lbldataConsegna.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldataConsegna.Location = New System.Drawing.Point(3, 60)
        Me.lbldataConsegna.Name = "lbldataConsegna"
        Me.lbldataConsegna.Size = New System.Drawing.Size(122, 30)
        Me.lbldataConsegna.TabIndex = 2
        Me.lbldataConsegna.Text = "Data Consegna :"
        Me.lbldataConsegna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRigaOrdine
        '
        Me.lblRigaOrdine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRigaOrdine.Location = New System.Drawing.Point(414, 0)
        Me.lblRigaOrdine.Name = "lblRigaOrdine"
        Me.lblRigaOrdine.Size = New System.Drawing.Size(122, 29)
        Me.lblRigaOrdine.TabIndex = 4
        Me.lblRigaOrdine.Text = "N° Riga Ordine :"
        Me.lblRigaOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "N° Totale Pezzi :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodiceOrdine
        '
        Me.txtCodiceOrdine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodiceOrdine.Location = New System.Drawing.Point(131, 3)
        Me.txtCodiceOrdine.Name = "txtCodiceOrdine"
        Me.txtCodiceOrdine.Size = New System.Drawing.Size(268, 23)
        Me.txtCodiceOrdine.TabIndex = 7
        '
        'txtCodiceArticolo
        '
        Me.txtCodiceArticolo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodiceArticolo.Location = New System.Drawing.Point(131, 33)
        Me.txtCodiceArticolo.Name = "txtCodiceArticolo"
        Me.txtCodiceArticolo.Size = New System.Drawing.Size(268, 23)
        Me.txtCodiceArticolo.TabIndex = 8
        '
        'dtpDataConsegna
        '
        Me.dtpDataConsegna.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataConsegna.Location = New System.Drawing.Point(131, 63)
        Me.dtpDataConsegna.Name = "dtpDataConsegna"
        Me.dtpDataConsegna.Size = New System.Drawing.Size(268, 25)
        Me.dtpDataConsegna.TabIndex = 9
        '
        'txtNumeroRiga
        '
        Me.txtNumeroRiga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroRiga.Location = New System.Drawing.Point(544, 3)
        Me.txtNumeroRiga.Name = "txtNumeroRiga"
        Me.txtNumeroRiga.Size = New System.Drawing.Size(280, 23)
        Me.txtNumeroRiga.TabIndex = 11
        '
        'txtNumeroPezziOrd
        '
        Me.txtNumeroPezziOrd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPezziOrd.Location = New System.Drawing.Point(544, 33)
        Me.txtNumeroPezziOrd.Name = "txtNumeroPezziOrd"
        Me.txtNumeroPezziOrd.Size = New System.Drawing.Size(280, 23)
        Me.txtNumeroPezziOrd.TabIndex = 12
        '
        'lblFornitore
        '
        Me.lblFornitore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFornitore.Location = New System.Drawing.Point(3, 90)
        Me.lblFornitore.Name = "lblFornitore"
        Me.lblFornitore.Size = New System.Drawing.Size(122, 30)
        Me.lblFornitore.TabIndex = 14
        Me.lblFornitore.Text = "Fornitore :"
        Me.lblFornitore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFornitore
        '
        Me.cmbFornitore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFornitore.FormattingEnabled = True
        Me.cmbFornitore.Location = New System.Drawing.Point(131, 93)
        Me.cmbFornitore.Name = "cmbFornitore"
        Me.cmbFornitore.Size = New System.Drawing.Size(268, 25)
        Me.cmbFornitore.TabIndex = 15
        '
        'lblLotto
        '
        Me.lblLotto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotto.Location = New System.Drawing.Point(414, 90)
        Me.lblLotto.Name = "lblLotto"
        Me.lblLotto.Size = New System.Drawing.Size(122, 28)
        Me.lblLotto.TabIndex = 16
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
        Me.cmbLottoNum.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cmbLottoNum.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cmbLottoNum.EditorControl.Name = "NestedRadGridView"
        Me.cmbLottoNum.EditorControl.ReadOnly = True
        Me.cmbLottoNum.EditorControl.ShowGroupPanel = False
        Me.cmbLottoNum.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cmbLottoNum.EditorControl.TabIndex = 0
        Me.cmbLottoNum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLottoNum.Location = New System.Drawing.Point(544, 93)
        Me.cmbLottoNum.Name = "cmbLottoNum"
        Me.cmbLottoNum.Size = New System.Drawing.Size(280, 24)
        Me.cmbLottoNum.TabIndex = 17
        Me.cmbLottoNum.TabStop = False
        '
        'lblMateriale
        '
        Me.lblMateriale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMateriale.Location = New System.Drawing.Point(414, 60)
        Me.lblMateriale.Name = "lblMateriale"
        Me.lblMateriale.Size = New System.Drawing.Size(122, 30)
        Me.lblMateriale.TabIndex = 3
        Me.lblMateriale.Text = "Materiale :"
        Me.lblMateriale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMateriale
        '
        Me.txtMateriale.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMateriale.FormattingEnabled = True
        Me.txtMateriale.Location = New System.Drawing.Point(544, 63)
        Me.txtMateriale.Name = "txtMateriale"
        Me.txtMateriale.Size = New System.Drawing.Size(280, 25)
        Me.txtMateriale.TabIndex = 10
        '
        'lblNote
        '
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(3, 120)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(122, 30)
        Me.lblNote.TabIndex = 6
        Me.lblNote.Text = "Note :"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNote
        '
        Me.TableLayoutPanelTestata.SetColumnSpan(Me.txtNote, 4)
        Me.txtNote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(131, 123)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(693, 42)
        Me.txtNote.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 784)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(874, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.TableLayoutPanelLavorazioni)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox1.HeaderText = "Dati Lavorazioni Scheda"
        Me.RadGroupBox1.Location = New System.Drawing.Point(8, 320)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(837, 265)
        Me.RadGroupBox1.TabIndex = 4
        Me.RadGroupBox1.Text = "Dati Lavorazioni Scheda"
        '
        'TableLayoutPanelLavorazioni
        '
        Me.TableLayoutPanelLavorazioni.ColumnCount = 7
        Me.TableLayoutPanelLavorazioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanelLavorazioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
        Me.TableLayoutPanelLavorazioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanelLavorazioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanelLavorazioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanelLavorazioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanelLavorazioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256.0!))
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtNoteAltreLavorazioni, 6, 4)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtAltreLavorazioni, 1, 4)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtNoteHelicoil, 6, 3)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtClienteHelicolil, 6, 2)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtNoteVernciatura, 6, 1)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtClienteVerniciatura, 6, 0)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtTrattamento, 1, 3)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtClienteTrattamento, 1, 2)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtOperatore, 1, 1)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtLavorazioniBBG, 1, 0)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblLavorazioniBBG, 0, 0)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblOperatore, 0, 1)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblClienteTrattamento, 0, 2)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblTrattamento, 0, 3)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblAltreLavorazioni, 0, 4)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblClienteVerniciatura, 5, 0)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblNoteVerniciatura, 5, 1)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.Label3, 5, 2)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblNoteHelicoil, 5, 3)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblNoteAltreLavorazioni, 5, 4)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblNum, 2, 1)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.txtNumOperatore, 3, 1)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.lblFAI, 0, 5)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.chkFAI, 1, 5)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutPanelLavorazioni.Controls.Add(Me.chkKC, 1, 6)
        Me.TableLayoutPanelLavorazioni.Location = New System.Drawing.Point(5, 21)
        Me.TableLayoutPanelLavorazioni.Name = "TableLayoutPanelLavorazioni"
        Me.TableLayoutPanelLavorazioni.RowCount = 7
        Me.TableLayoutPanelLavorazioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanelLavorazioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanelLavorazioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanelLavorazioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanelLavorazioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanelLavorazioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanelLavorazioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanelLavorazioni.Size = New System.Drawing.Size(827, 239)
        Me.TableLayoutPanelLavorazioni.TabIndex = 0
        '
        'txtNoteAltreLavorazioni
        '
        Me.txtNoteAltreLavorazioni.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteAltreLavorazioni.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteAltreLavorazioni.Location = New System.Drawing.Point(574, 140)
        Me.txtNoteAltreLavorazioni.Name = "txtNoteAltreLavorazioni"
        Me.txtNoteAltreLavorazioni.Size = New System.Drawing.Size(250, 25)
        Me.txtNoteAltreLavorazioni.TabIndex = 37
        '
        'txtAltreLavorazioni
        '
        Me.txtAltreLavorazioni.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelLavorazioni.SetColumnSpan(Me.txtAltreLavorazioni, 3)
        Me.txtAltreLavorazioni.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltreLavorazioni.Location = New System.Drawing.Point(131, 140)
        Me.txtAltreLavorazioni.Name = "txtAltreLavorazioni"
        Me.txtAltreLavorazioni.Size = New System.Drawing.Size(290, 25)
        Me.txtAltreLavorazioni.TabIndex = 36
        '
        'txtNoteHelicoil
        '
        Me.txtNoteHelicoil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteHelicoil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteHelicoil.Location = New System.Drawing.Point(574, 106)
        Me.txtNoteHelicoil.Name = "txtNoteHelicoil"
        Me.txtNoteHelicoil.Size = New System.Drawing.Size(250, 25)
        Me.txtNoteHelicoil.TabIndex = 35
        '
        'txtClienteHelicolil
        '
        Me.txtClienteHelicolil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteHelicolil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteHelicolil.FormattingEnabled = True
        Me.txtClienteHelicolil.Location = New System.Drawing.Point(574, 72)
        Me.txtClienteHelicolil.Name = "txtClienteHelicolil"
        Me.txtClienteHelicolil.Size = New System.Drawing.Size(250, 25)
        Me.txtClienteHelicolil.TabIndex = 34
        '
        'txtNoteVernciatura
        '
        Me.txtNoteVernciatura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteVernciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteVernciatura.Location = New System.Drawing.Point(574, 38)
        Me.txtNoteVernciatura.Name = "txtNoteVernciatura"
        Me.txtNoteVernciatura.Size = New System.Drawing.Size(250, 25)
        Me.txtNoteVernciatura.TabIndex = 33
        '
        'txtClienteVerniciatura
        '
        Me.txtClienteVerniciatura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteVerniciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteVerniciatura.FormattingEnabled = True
        Me.txtClienteVerniciatura.Location = New System.Drawing.Point(574, 4)
        Me.txtClienteVerniciatura.Name = "txtClienteVerniciatura"
        Me.txtClienteVerniciatura.Size = New System.Drawing.Size(250, 25)
        Me.txtClienteVerniciatura.TabIndex = 32
        '
        'txtTrattamento
        '
        Me.txtTrattamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelLavorazioni.SetColumnSpan(Me.txtTrattamento, 3)
        Me.txtTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrattamento.FormattingEnabled = True
        Me.txtTrattamento.Location = New System.Drawing.Point(131, 106)
        Me.txtTrattamento.Name = "txtTrattamento"
        Me.txtTrattamento.Size = New System.Drawing.Size(290, 25)
        Me.txtTrattamento.TabIndex = 31
        '
        'txtClienteTrattamento
        '
        Me.txtClienteTrattamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelLavorazioni.SetColumnSpan(Me.txtClienteTrattamento, 3)
        Me.txtClienteTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteTrattamento.FormattingEnabled = True
        Me.txtClienteTrattamento.Location = New System.Drawing.Point(131, 72)
        Me.txtClienteTrattamento.Name = "txtClienteTrattamento"
        Me.txtClienteTrattamento.Size = New System.Drawing.Size(290, 25)
        Me.txtClienteTrattamento.TabIndex = 30
        '
        'txtOperatore
        '
        Me.txtOperatore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtOperatore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperatore.FormattingEnabled = True
        Me.txtOperatore.Location = New System.Drawing.Point(131, 38)
        Me.txtOperatore.Name = "txtOperatore"
        Me.txtOperatore.Size = New System.Drawing.Size(199, 25)
        Me.txtOperatore.TabIndex = 29
        '
        'txtLavorazioniBBG
        '
        Me.txtLavorazioniBBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanelLavorazioni.SetColumnSpan(Me.txtLavorazioniBBG, 3)
        Me.txtLavorazioniBBG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLavorazioniBBG.FormattingEnabled = True
        Me.txtLavorazioniBBG.Location = New System.Drawing.Point(131, 4)
        Me.txtLavorazioniBBG.Name = "txtLavorazioniBBG"
        Me.txtLavorazioniBBG.Size = New System.Drawing.Size(290, 25)
        Me.txtLavorazioniBBG.TabIndex = 28
        '
        'lblLavorazioniBBG
        '
        Me.lblLavorazioniBBG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLavorazioniBBG.Location = New System.Drawing.Point(3, 0)
        Me.lblLavorazioniBBG.Name = "lblLavorazioniBBG"
        Me.lblLavorazioniBBG.Size = New System.Drawing.Size(122, 34)
        Me.lblLavorazioniBBG.TabIndex = 0
        Me.lblLavorazioniBBG.Text = "Lavorazioni BBG :"
        Me.lblLavorazioniBBG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOperatore
        '
        Me.lblOperatore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperatore.Location = New System.Drawing.Point(3, 34)
        Me.lblOperatore.Name = "lblOperatore"
        Me.lblOperatore.Size = New System.Drawing.Size(122, 34)
        Me.lblOperatore.TabIndex = 1
        Me.lblOperatore.Text = "Operatore :"
        Me.lblOperatore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClienteTrattamento
        '
        Me.lblClienteTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteTrattamento.Location = New System.Drawing.Point(3, 68)
        Me.lblClienteTrattamento.Name = "lblClienteTrattamento"
        Me.lblClienteTrattamento.Size = New System.Drawing.Size(122, 34)
        Me.lblClienteTrattamento.TabIndex = 2
        Me.lblClienteTrattamento.Text = "Cliente Trattamento :"
        Me.lblClienteTrattamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTrattamento
        '
        Me.lblTrattamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrattamento.Location = New System.Drawing.Point(3, 102)
        Me.lblTrattamento.Name = "lblTrattamento"
        Me.lblTrattamento.Size = New System.Drawing.Size(122, 34)
        Me.lblTrattamento.TabIndex = 3
        Me.lblTrattamento.Text = "Trattamento :"
        Me.lblTrattamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAltreLavorazioni
        '
        Me.lblAltreLavorazioni.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltreLavorazioni.Location = New System.Drawing.Point(3, 136)
        Me.lblAltreLavorazioni.Name = "lblAltreLavorazioni"
        Me.lblAltreLavorazioni.Size = New System.Drawing.Size(122, 34)
        Me.lblAltreLavorazioni.TabIndex = 4
        Me.lblAltreLavorazioni.Text = "Altre Lavorazioni :"
        Me.lblAltreLavorazioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClienteVerniciatura
        '
        Me.lblClienteVerniciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteVerniciatura.Location = New System.Drawing.Point(440, 0)
        Me.lblClienteVerniciatura.Name = "lblClienteVerniciatura"
        Me.lblClienteVerniciatura.Size = New System.Drawing.Size(128, 34)
        Me.lblClienteVerniciatura.TabIndex = 5
        Me.lblClienteVerniciatura.Text = "Cliente Verniciatura :"
        Me.lblClienteVerniciatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteVerniciatura
        '
        Me.lblNoteVerniciatura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteVerniciatura.Location = New System.Drawing.Point(440, 34)
        Me.lblNoteVerniciatura.Name = "lblNoteVerniciatura"
        Me.lblNoteVerniciatura.Size = New System.Drawing.Size(128, 34)
        Me.lblNoteVerniciatura.TabIndex = 6
        Me.lblNoteVerniciatura.Text = "Note Verniciatura :"
        Me.lblNoteVerniciatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cliente Helicoil :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteHelicoil
        '
        Me.lblNoteHelicoil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteHelicoil.Location = New System.Drawing.Point(440, 102)
        Me.lblNoteHelicoil.Name = "lblNoteHelicoil"
        Me.lblNoteHelicoil.Size = New System.Drawing.Size(128, 34)
        Me.lblNoteHelicoil.TabIndex = 8
        Me.lblNoteHelicoil.Text = "Note Helicoil :"
        Me.lblNoteHelicoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoteAltreLavorazioni
        '
        Me.lblNoteAltreLavorazioni.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteAltreLavorazioni.Location = New System.Drawing.Point(440, 136)
        Me.lblNoteAltreLavorazioni.Name = "lblNoteAltreLavorazioni"
        Me.lblNoteAltreLavorazioni.Size = New System.Drawing.Size(128, 34)
        Me.lblNoteAltreLavorazioni.TabIndex = 9
        Me.lblNoteAltreLavorazioni.Text = "Note Altre Lavoraz. :"
        Me.lblNoteAltreLavorazioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum
        '
        Me.lblNum.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(336, 34)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(37, 34)
        Me.lblNum.TabIndex = 38
        Me.lblNum.Text = "N°"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumOperatore
        '
        Me.txtNumOperatore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNumOperatore.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOperatore.Location = New System.Drawing.Point(379, 38)
        Me.txtNumOperatore.Name = "txtNumOperatore"
        Me.txtNumOperatore.Size = New System.Drawing.Size(42, 25)
        Me.txtNumOperatore.TabIndex = 39
        '
        'lblFAI
        '
        Me.lblFAI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFAI.AutoSize = True
        Me.lblFAI.Location = New System.Drawing.Point(3, 180)
        Me.lblFAI.Name = "lblFAI"
        Me.lblFAI.Size = New System.Drawing.Size(122, 15)
        Me.lblFAI.TabIndex = 40
        Me.lblFAI.Text = "FAI :"
        Me.lblFAI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkFAI
        '
        Me.chkFAI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFAI.AutoSize = True
        Me.chkFAI.Location = New System.Drawing.Point(131, 178)
        Me.chkFAI.Name = "chkFAI"
        Me.chkFAI.Size = New System.Drawing.Size(199, 19)
        Me.chkFAI.TabIndex = 41
        Me.chkFAI.Text = "Seleziona Per FAI"
        Me.chkFAI.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "KC :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkKC
        '
        Me.chkKC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkKC.AutoSize = True
        Me.chkKC.Location = New System.Drawing.Point(131, 213)
        Me.chkKC.Name = "chkKC"
        Me.chkKC.Size = New System.Drawing.Size(199, 19)
        Me.chkKC.TabIndex = 43
        Me.chkKC.Text = "Seleziona Per KC"
        Me.chkKC.UseVisualStyleBackColor = True
        '
        'lblSchedaLavoro
        '
        Me.lblSchedaLavoro.AutoSize = False
        Me.lblSchedaLavoro.BackColor = System.Drawing.Color.Transparent
        Me.lblSchedaLavoro.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedaLavoro.ForeColor = System.Drawing.Color.Teal
        Me.lblSchedaLavoro.Location = New System.Drawing.Point(8, 84)
        Me.lblSchedaLavoro.Name = "lblSchedaLavoro"
        Me.lblSchedaLavoro.Size = New System.Drawing.Size(157, 18)
        Me.lblSchedaLavoro.TabIndex = 5
        Me.lblSchedaLavoro.Text = "ID Scheda Lavoro :"
        Me.lblSchedaLavoro.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIDSchedaLavoro
        '
        Me.txtIDSchedaLavoro.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtIDSchedaLavoro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSchedaLavoro.ForeColor = System.Drawing.Color.Teal
        Me.txtIDSchedaLavoro.Location = New System.Drawing.Point(171, 81)
        Me.txtIDSchedaLavoro.Name = "txtIDSchedaLavoro"
        Me.txtIDSchedaLavoro.Size = New System.Drawing.Size(127, 26)
        Me.txtIDSchedaLavoro.TabIndex = 6
        '
        'RadGroupBoxSalvaScheda
        '
        Me.RadGroupBoxSalvaScheda.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBoxSalvaScheda.Controls.Add(Me.Panel1)
        Me.RadGroupBoxSalvaScheda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBoxSalvaScheda.HeaderText = "Disegni Articolo Selezionato"
        Me.RadGroupBoxSalvaScheda.Location = New System.Drawing.Point(13, 605)
        Me.RadGroupBoxSalvaScheda.Name = "RadGroupBoxSalvaScheda"
        Me.RadGroupBoxSalvaScheda.Size = New System.Drawing.Size(832, 161)
        Me.RadGroupBoxSalvaScheda.TabIndex = 7
        Me.RadGroupBoxSalvaScheda.Text = "Disegni Articolo Selezionato"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gridViewDisegni)
        Me.Panel1.Location = New System.Drawing.Point(6, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 135)
        Me.Panel1.TabIndex = 1
        '
        'gridViewDisegni
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.gridViewDisegni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridViewDisegni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridViewDisegni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomeFile, Me.PercorsoFile, Me.btnApriFile})
        Me.gridViewDisegni.Location = New System.Drawing.Point(5, 4)
        Me.gridViewDisegni.Name = "gridViewDisegni"
        Me.gridViewDisegni.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridViewDisegni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridViewDisegni.Size = New System.Drawing.Size(810, 128)
        Me.gridViewDisegni.TabIndex = 1
        '
        'NomeFile
        '
        Me.NomeFile.DataPropertyName = "NomeFile"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeFile.DefaultCellStyle = DataGridViewCellStyle2
        Me.NomeFile.HeaderText = "Nome File"
        Me.NomeFile.Name = "NomeFile"
        Me.NomeFile.ToolTipText = "Nome del file Disegno"
        Me.NomeFile.Width = 150
        '
        'PercorsoFile
        '
        Me.PercorsoFile.DataPropertyName = "PercorsoFile"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercorsoFile.DefaultCellStyle = DataGridViewCellStyle3
        Me.PercorsoFile.HeaderText = "Percorso File"
        Me.PercorsoFile.Name = "PercorsoFile"
        Me.PercorsoFile.ToolTipText = "Percorso della posizione del file"
        Me.PercorsoFile.Width = 430
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
        Me.btnApriFile.Width = 180
        '
        'frmNuovaSchedaDaEsistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 806)
        Me.Controls.Add(Me.RadGroupBoxSalvaScheda)
        Me.Controls.Add(Me.txtIDSchedaLavoro)
        Me.Controls.Add(Me.lblSchedaLavoro)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RadGroupBoxTestata)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "frmNuovaSchedaDaEsistente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuova Scheda Da Scheda Esistente"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxTestata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxTestata.ResumeLayout(False)
        Me.TableLayoutPanelTestata.ResumeLayout(False)
        Me.TableLayoutPanelTestata.PerformLayout()
        CType(Me.txtCodiceOrdine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodiceArticolo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroRiga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroPezziOrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLottoNum.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLottoNum.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLottoNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.TableLayoutPanelLavorazioni.ResumeLayout(False)
        Me.TableLayoutPanelLavorazioni.PerformLayout()
        CType(Me.lblSchedaLavoro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxSalvaScheda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxSalvaScheda.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.gridViewDisegni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cmdSalvaNuovaScheda As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cmdCambiaIDScheda As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cmdChiudiForm As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadGroupBoxTestata As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents TableLayoutPanelTestata As TableLayoutPanel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblSchedaLavoro As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCodiceOrdine As Label
    Friend WithEvents lblCodiceArticolo As Label
    Friend WithEvents lbldataConsegna As Label
    Friend WithEvents lblMateriale As Label
    Friend WithEvents lblRigaOrdine As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNote As Label
    Friend WithEvents txtCodiceOrdine As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCodiceArticolo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtpDataConsegna As DateTimePicker
    Friend WithEvents txtMateriale As ComboBox
    Friend WithEvents txtNumeroRiga As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtNumeroPezziOrd As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtNote As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents TableLayoutPanelLavorazioni As TableLayoutPanel
    Friend WithEvents lblLavorazioniBBG As Label
    Friend WithEvents lblOperatore As Label
    Friend WithEvents lblClienteTrattamento As Label
    Friend WithEvents lblTrattamento As Label
    Friend WithEvents lblAltreLavorazioni As Label
    Friend WithEvents lblClienteVerniciatura As Label
    Friend WithEvents lblNoteVerniciatura As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNoteHelicoil As Label
    Friend WithEvents lblNoteAltreLavorazioni As Label
    Friend WithEvents txtLavorazioniBBG As ComboBox
    Friend WithEvents txtOperatore As ComboBox
    Friend WithEvents txtClienteTrattamento As ComboBox
    Friend WithEvents txtTrattamento As ComboBox
    Friend WithEvents txtClienteVerniciatura As ComboBox
    Friend WithEvents txtNoteVernciatura As TextBox
    Friend WithEvents txtClienteHelicolil As ComboBox
    Friend WithEvents txtNoteHelicoil As TextBox
    Friend WithEvents txtAltreLavorazioni As TextBox
    Friend WithEvents txtNoteAltreLavorazioni As TextBox
    Friend WithEvents txtIDSchedaLavoro As TextBox
    Friend WithEvents btnStampaScheda As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarLabelAvvisi As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadGroupBoxSalvaScheda As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gridViewDisegni As DataGridView
    Friend WithEvents lblFornitore As System.Windows.Forms.Label
    Friend WithEvents cmbFornitore As System.Windows.Forms.ComboBox
    Friend WithEvents lblLotto As System.Windows.Forms.Label
    Friend WithEvents cmbLottoNum As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblNum As Label
    Friend WithEvents txtNumOperatore As TextBox
    Friend WithEvents NomeFile As DataGridViewTextBoxColumn
    Friend WithEvents PercorsoFile As DataGridViewTextBoxColumn
    Friend WithEvents btnApriFile As DataGridViewButtonColumn
    Friend WithEvents lblFAI As Label
    Friend WithEvents chkFAI As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkKC As CheckBox
End Class
