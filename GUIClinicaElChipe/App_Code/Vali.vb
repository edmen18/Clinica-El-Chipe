Imports Microsoft.VisualBasic

Public Class Vali
    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If ((Keyascii >= 48 And Keyascii <= 57) Or (Keyascii = 8)) Then
            SoloNumeros = Keyascii
        Else
            SoloNumeros = 0
        End If
    End Function
End Class
