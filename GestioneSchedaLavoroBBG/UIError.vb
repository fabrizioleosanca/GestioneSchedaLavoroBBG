Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports Telerik.WinControls.UI
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Text
Imports System.Collections.Generic

Public Class UIError
    'Questa semplice classe lancia un errore quando qualcosa va storto nell'operazione di copia. 
    'Andiamo al resto del codice del modulo. Aggiungi il costruttore:

    Public strErrorMsg As String
    Public strFilePath As String
    Public drResult As DialogResult

    Public Sub New(ByVal ex As Exception, ByVal FilePath As String)
        strErrorMsg = ex.Message
        strFilePath = FilePath
        drResult = DialogResult.Cancel
    End Sub

End Class
