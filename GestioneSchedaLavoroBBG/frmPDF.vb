Public Class FrmPDF

    Public Sub New(ByVal documentName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        '...implementare qui la logica di validazione
        'del file name

        Try
            AxAcroPDF1.setShowToolbar(True)
            AxAcroPDF1.setShowScrollbars(True)
            AxAcroPDF1.LoadFile(documentName)
        Catch ex As Exception
            'Implementare la gestione delle eccezioni
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmPDF_Load(sender As Object, e As EventArgs) Handles Me.Load
        Using g = Graphics.FromHwnd(IntPtr.Zero)
            Panel1.Size = New Size(CInt(21 / 2.54 * g.DpiX), CInt(29.7 / 2.54 * g.DpiY))
        End Using
    End Sub
End Class