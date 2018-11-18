
Imports Telerik.WinControls.UI
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Telerik.WinControls.UI.Localization
Public Class FrmGestioneTempi

    Public Shared factory As New DatabaseProviderFactory()
    Public Property _db As Database = factory.Create("dbSchedaLavoroBBGConnectionString")
    Public Property IndexRigaPerAggiorna As Integer

    Public Property IDFiltrato As Integer

    Private Sub FrmGestioneTempi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsTempi.tblTempi' table. You can move, or remove it, as needed.
        Me.TblTempiTableAdapter.Fill(Me.DsTempi.tblTempi)
        RadGridLocalizationProvider.CurrentProvider = New MyItalianRadGridLocalizationProvider()
    End Sub

    Private Sub CommandBarButton1_Click(sender As Object, e As EventArgs) Handles CommandBarButton1.Click
        Close()
    End Sub

    Private Sub BtnAggiungiTempi_Click(sender As Object, e As EventArgs) Handles btnAggiungiTempi.Click

        Dim strCodice As String = txtCodice.Text

        If strCodice = String.Empty Then
            MessageBox.Show("Il Campo Codice NON PUO Essere Vuoto.", "Controllo Campo Codice", MessageBoxButtons.OK)
            Exit Sub
        End If


        Dim floTempoMinuti As Decimal = CType(txtTempoMinuti.Text, Decimal)
        Dim GiorniTrattamento As Integer = CType(txtGiorniTrattamento.Text, Integer)
        Dim GiorniVerniciatura As Integer = CType(txtGiorniVerniciatura.Text, Integer)
        Dim GiorniMontaggio As Integer = CType(txtGiorniMontaggio.Text, Integer)

        Dim cmd As DbCommand

        Try

            cmd = _db.GetStoredProcCommand("spInsertTempi")

            _db.AddInParameter(cmd, "Codice", DbType.String, strCodice)
            _db.AddInParameter(cmd, "TempoMinuti", DbType.Decimal, floTempoMinuti)
            _db.AddInParameter(cmd, "TempoGiorniTrattamento", DbType.Int32, GiorniTrattamento)
            _db.AddInParameter(cmd, "TempoGiorniVerniciatura", DbType.Int32, GiorniVerniciatura)
            _db.AddInParameter(cmd, "TempoGiorniMontaggio", DbType.Int32, GiorniMontaggio)

            If (_db.ExecuteNonQuery(cmd) = 1) Then
                MessageBox.Show("Nuovo Tempi Codice inserito in database.", "Tempi Codice", MessageBoxButtons.OK)
            Else
                MessageBox.Show("ATTENZIONE!! Articolo già ESISTENTE !", "Tempi Codice", MessageBoxButtons.OK)
                Exit Sub
            End If

            'PopolaGrid
            TblTempiTableAdapter.Fill(Me.DsTempi.tblTempi)

            'Deseleziona righe
            RadGridViewTempi.ClearSelection()
            'Conta ultima riga
            Dim lastRow As GridViewRowInfo = Me.RadGridViewTempi.Rows(RadGridViewTempi.Rows.Count - 1)
            'Casting Integer righe
            Dim intRowCount As Integer = lastRow.Index
            'Scroll su ultima riga
            RadGridViewTempi.TableElement.ScrollToRow(intRowCount)
            'seleziona ultima riga
            lastRow.IsSelected = True

        Catch ex As Exception
            MessageBox.Show("Errore salvataggio Tempi : " & ex.Message)
        End Try

        txtCodice.Text = String.Empty
        txtTempoMinuti.Text = String.Empty


    End Sub

    Private Function GetSafeString(ByVal value As Object) As String
        If value Is Nothing Then
            Return String.Empty
        End If
        Return value.ToString()
    End Function

    Private Sub UpdatePanelInfo(ByVal currentRow As GridViewRowInfo)
        If currentRow IsNot Nothing AndAlso Not (TypeOf currentRow Is GridViewNewRowInfo) Then
            txtAggCodice.Text = Me.GetSafeString(currentRow.Cells("Codice").Value)
            txtAggMinuti.Text = Me.GetSafeString(currentRow.Cells("TempoMinuti").Value)
            txtAggGiorniTrattamento.Text = Me.GetSafeString(currentRow.Cells("TempoGiorniTrattamento").Value)
            txtAggGiorniVerniciatura.Text = Me.GetSafeString(currentRow.Cells("TempoGiorniVerniciatura").Value)
            txtAggGiorniMontaggio.Text = GetSafeString(currentRow.Cells("TempoGiorniMontaggio").Value)
        Else
            txtAggCodice.Text = String.Empty
            txtAggMinuti.Text = String.Empty
        End If
    End Sub

    Private Sub RadGridViewTempi_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridViewTempi.CellClick
        If TypeOf RadGridViewTempi.CurrentRow Is GridViewDataRowInfo Then
            IndexRigaPerAggiorna = RadGridViewTempi.Rows.IndexOf(DirectCast(RadGridViewTempi.CurrentRow, GridViewDataRowInfo))
        End If
    End Sub

    Private Sub RadGridViewTempi_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles RadGridViewTempi.CurrentRowChanged
        UpdatePanelInfo(RadGridViewTempi.CurrentRow)
        If e.CurrentRow.Cells("ID").Value IsNot Nothing Then
            IDFiltrato = CType(e.CurrentRow.Cells("ID").Value.ToString(), Integer)
        End If
    End Sub

    Public Function AggiornaTempiBusinessLayer(ByVal id As Integer)

        Dim ret As Nullable(Of Integer)

        Dim StrCodice As String
        Dim FloTempoMinuti As Decimal
        Dim GiorniTrattamento As Integer
        Dim GiorniVerniciatura As Integer
        Dim GiorniMontaggio As Integer

        Dim IdRiga As Integer

        StrCodice = txtAggCodice.Text
        FloTempoMinuti = System.Convert.ToDecimal(txtAggMinuti.Text)
        GiorniTrattamento = CType(txtAggGiorniTrattamento.Text, Integer)
        GiorniVerniciatura = CType(txtAggGiorniVerniciatura.Text, Integer)
        GiorniMontaggio = CType(txtAggGiorniMontaggio.Text, Integer)


        IdRiga = id

        ret = AggiornaTempi(id, StrCodice, FloTempoMinuti, GiorniTrattamento, GiorniVerniciatura, GiorniMontaggio)

        Try
            If Not (ret) Is Nothing Then
                Return ret
            Else
                Exit Function
            End If

        Catch ex As Exception
            MessageBox.Show("Errore AggiornaTempiBusinessLayer:" & ex.Message)
        End Try

    End Function

    Private Sub BtnUpdateTempi_Click(sender As Object, e As EventArgs) Handles btnUpdateTempi.Click
        Dim IntAggiornaTempiBusLayer As Nullable(Of Integer)
        Dim Result As DialogResult
        'Trova id selezionato
        ' PropIdTempiGlobal = Me.RadGridViewTempi.Rows(Me.RadGridViewTempi.CurrentRow.Index).Cells(0).Value

        'IDFiltrato è la proprieta dell'ID per la cancellazione mentre c'è il filtro nella griglia
        IntAggiornaTempiBusLayer = AggiornaTempiBusinessLayer(IDFiltrato)

        If Not IntAggiornaTempiBusLayer Is Nothing Then
            Result = MessageBox.Show("Tempi Articolo Aggiornato Con Successo", "Aggiornamento Tempi Articolo in Database", MessageBoxButtons.OKCancel)
            If Result = DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        'PopolaGridTempi()
        TblTempiTableAdapter.Fill(Me.DsTempi.tblTempi)

        'Torna sulla riga selezionata
        RadGridViewTempi.CurrentRow = RadGridViewTempi.Rows(IndexRigaPerAggiorna)

    End Sub

    Public Function AggiornaTempi(ByVal id As Integer, ByVal Codice As String, ByVal TempoMinuti As Decimal, ByVal TempoGiorniTrattamento As Integer, ByVal TempoGiorniVerniciatura As Integer, ByVal TempoGiorniMontaggio As Integer) As Integer

        Dim rowsAffected As Integer
        Dim updateCommand As DbCommand = Nothing
        updateCommand = _db.GetStoredProcCommand("spUpdateTblTempi")

        Try

            _db.AddInParameter(updateCommand, "Codice", DbType.String, Codice)
            _db.AddInParameter(updateCommand, "TempoMinuti", DbType.String, TempoMinuti)
            _db.AddInParameter(updateCommand, "TempoGiorniTrattamento", DbType.String, TempoGiorniTrattamento)
            _db.AddInParameter(updateCommand, "TempoGiorniVerniciatura", DbType.String, TempoGiorniVerniciatura)
            _db.AddInParameter(updateCommand, "TempoGiorniMontaggio", DbType.String, TempoGiorniMontaggio)
            _db.AddInParameter(updateCommand, "ID", DbType.Int32, id)

            rowsAffected = _db.ExecuteNonQuery(updateCommand)

        Catch ex As Exception
            MessageBox.Show("Errore AggiornaLottoMateriale: " & ex.Message)
        End Try

        Return rowsAffected

    End Function

    Private Sub BtnCancellaTempi_Click(sender As Object, e As EventArgs) Handles btnCancellaTempi.Click

        'Trova id selezionato
        '  PropIdTempiGlobal = Me.RadGridViewTempi.Rows(Me.RadGridViewTempi.CurrentRow.Index).Cells(0).Value
        PropIdTempiGlobal = RadGridViewTempi.ChildRows(RadGridViewTempi.CurrentRow.Index).Cells(0).Value

        Dim result As DialogResult

        If Not (PropIdTempiGlobal = Nothing) Then
            If RadGridViewTempi.SelectedRows.Count > 0 Then
                result = MessageBox.Show(" Sei sicuro di voler eliminare il Tempo N° : " & PropIdTempiGlobal & " ? ", "Elimina Tempi in Database", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    Exit Sub
                End If
                If result = Windows.Forms.DialogResult.OK Then
                    EliminaTempi(PropIdTempiGlobal)

                    'PopolaGridTempi()
                    'PopolaGridTempi()
                    Me.TblTempiTableAdapter.Fill(Me.DsTempi.tblTempi)
                Else
                    Exit Sub
                End If
            Else
                MessageBox.Show("Seleziona una riga !!")
            End If

        Else

        End If

    End Sub

    Public Function EliminaTempi(ByVal id As Integer)
        Dim deleteCommand As DbCommand = Nothing
        Dim rowsAffected As Integer
        Try
            deleteCommand = _db.GetStoredProcCommand("spDeleteTempiCodice")
            _db.AddInParameter(deleteCommand, "ID", DbType.Int32, id)
            rowsAffected = _db.ExecuteNonQuery(deleteCommand)
        Catch ex As Exception
            MessageBox.Show("Errore EliminaLottoMateriale : " & ex.Message)
        End Try
        Return rowsAffected
    End Function

End Class


#Region "CODICE VECCHIO O ESEMPIO"

    'Public Sub PopolaGridTempi()
    '    Try
    '        Dim cmd As DbCommand = _db.GetStoredProcCommand("spGetTblTempi")
    '        Using datareader As IDataReader = _db.ExecuteReader(cmd)
    '            RadGridViewTempi.MasterTemplate.LoadFrom(datareader)
    '        End Using
    '        Me.RadGridViewTempi.CurrentRow = Nothing
    '    Catch ex As Exception
    '        MessageBox.Show("Errore :" & ex.Message)
    '    End Try
    'End Sub

#End Region