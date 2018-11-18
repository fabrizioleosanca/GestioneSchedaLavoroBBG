Imports System.Runtime.CompilerServices
Module ModuleUnBold
    <Extension()>
    Public Sub UnBold(Of T As Control)(cc As Control.ControlCollection)
        For Each c As Control In cc
            If Not TypeOf c Is T AndAlso c.GetType.GetProperty("Font") IsNot Nothing Then
                Dim RegularFont As New Font(c.Font.FontFamily, c.Font.Size, FontStyle.Regular)
                c.Font = RegularFont
            ElseIf c.HasChildren Then
                UnBold(Of T)(c.Controls)
            End If
        Next
    End Sub
End Module
