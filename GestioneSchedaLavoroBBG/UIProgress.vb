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

Public Class UIProgress
    'Non c'è molto in questa classe. 
    'Questa classe è semplicemente responsabile dell'aggiornamento dell'interfaccia del modulo mentre la copia avanza.

    Public strName As String
    Public lngBytes As Long
    Public lngMaxBytes As Long

    Public Sub New(ByVal FileName As String, ByVal Bytes As Long, ByVal MaxBytes As Long)
        strName = FileName
        lngBytes = Bytes
        lngMaxBytes = MaxBytes
    End Sub

End Class
