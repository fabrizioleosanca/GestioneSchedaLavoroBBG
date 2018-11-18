Module modProprietaGlobali

#Region "Ordine Stampa Automatica"

    Public Property PropOrdineStampaAutomatica As String

#End Region


#Region "Proprieta Lotto Materiale"
    Public Property propIdLottoMateriale As Integer
#End Region

#Region "Propieta Per Combo Indice Riga"

    Public Property propCodiceRigaCombo As Integer
#End Region

#Region "Propieta Per Combo Operatore"
    Public Property PropIntOperatore As Integer
    Public Property PropStringOperatore As String
#End Region


#Region "Proprieta Salva Da Esistente Global"

    Public Property CodArtPerDisegniNew As String

    Public Property propNomeArticoloPerNomeDirRegNew As String

    Public Property propPathDirDisegnoNew As String

    Public Property propIdPerSalvaDaEsistente As Integer
    Public Property propIdIntestazioneNew As Integer
    Public Property propDataReportNew As Date
    Public Property propCodiceArticoloNew As String
    Public Property propCodiceOrdineNew As String
    Public Property propMaterialeNew As String
    Public Property propRigaOrdineNumNew As Integer
    Public Property propNumPezziNew As Integer
    Public Property propNoteNew As String

    Public Property propLavorazioniBBGNew As String
    Public Property propOperatoreNew As String
    Public Property propTrattamentoNew As String
    Public Property propClienteTrattamentoNew As String
    Public Property propClienteVerniciaturaNew As String
    Public Property propNoteVerniciaturaNew As String
    Public Property propClienteHelicoilNew As String
    Public Property propNoteHelicoilNew As String
    Public Property propAltreLavorazioniNew As String
    Public Property propNoteAltreLavorazioniNew As String
    Public Property propNuovoIDPerSalvareDaEsistente As Integer

#End Region


#Region "Proprieta Globali CopiaFile"

    Public collNomeFile As New Collection
    Public Property propCodicePadre As String
    Public Property propMeccanica As String
    Public Property propMeccanicaPerRicerca As String
    Public Property propCodiceArticolo As String
    Public Property propPathDisegniApprovati As String = "\\Desktopcadbbg\f\DISEGNI_APPROVATI\"
    'Public Property propPathDisegniApprovati As String = "C:\Users\fabri\Documents\BBGSCHEDA\DISEGNI_APPROVATI\"
    Public Property propNomeArticoloPerNomeDir As String
    Public Property nomeFilePerRicerca As String
    Public Property propPathDirCopiaFile As String
    Public Property propCodiceArticoloPerRicerca As String



#End Region




#Region "Proprieta Testata"

    Public Property propIdIntestazione As Integer
    Public Property CodiceArticolo As String
    Public Property propDataReport As Date
    Public Property boolReturnMain As Boolean = False
    Public Property propIdIntestazioneStampa As Integer


#End Region

#Region "Proprieta Stampa"

    '[IDIntestazione]
    Public Property propNumOrdineStampa As String
    Public Property propCodArticoloStampa As String
    Public Property propDataStampa As Date
    Public Property propMaterialeStampa As String
    Public Property propRigaOrdNumStampa As Integer
    Public Property propNumPezziStampa As Integer
    Public Property propNoteStampa As String

    '[IdIntestazione]
    Public Property propCodiceArticoloLavorazioniStampa As String
    Public Property propLavorazioneBBGStampa As String
    Public Property propOperatore As String
    Public Property propTrattamentoStampa As String
    Public Property propClienteTrattamentoStampa As String
    Public Property propClienteVerniciaturaStampa As String
    Public Property propNoteVerniciaturaStampa As String
    Public Property propClienteHelicoilStampa As String
    Public Property propNoteHelicoilStampa As String
    Public Property propAltreLavorazioniStampa As String
    Public Property propNoteAltreLavorazioniStampa As String
    Public Property propFai As Boolean
    Public Property propKc As Boolean


#End Region

#Region "Proprieta Articoli Registrati"

    Public Property propCodArtReg As String
    Public Property propNomeArticoloPerNomeDirReg As String

    Public Property propPathDirDisegno As String

#End Region

#Region "Proprieta Tempi"

    Public Property PropIdTempiGlobal As Integer

#End Region


End Module
