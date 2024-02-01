Imports System.Windows.Forms

Module Validar
    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If ((Keyascii >= 48 And Keyascii <= 57) Or (Keyascii = 8)) Then
            SoloNumeros = Keyascii
        Else
            SoloNumeros = 0
        End If
    End Function
    Function SoloNumerosD(ByVal Keyascii As Short) As Short
        If ((Keyascii >= 48 And Keyascii <= 57) Or (Keyascii = 8) Or (Keyascii = 46) Or (Keyascii = 44)) Then
            SoloNumerosD = Keyascii
        Else
            SoloNumerosD = 0
        End If
    End Function
    Function SoloNumerosf(ByVal Keyascii As Short) As Short
        If ((Keyascii >= 48 And Keyascii <= 57) Or (Keyascii = 45) Or (Keyascii = 8)) Then
            SoloNumerosf = Keyascii
        Else
            SoloNumerosf = 0
        End If
    End Function
    Function SoloLetras(ByVal keyascii As Short) As Short
        If ((keyascii >= 65 And keyascii <= 90) Or (keyascii >= 97 And keyascii <= 122) Or (keyascii = 164) Or (keyascii = 32) Or (keyascii = 8) Or (keyascii = 165)) Then
            SoloLetras = keyascii
        Else
            SoloLetras = 0
        End If
    End Function
    Function NumerosAletras(ByVal numero As Decimal) As String
        Dim NumeroTraducido As String
        'NumeroTraducido = Format(numero, "0000000.00")
        'Procesamos el reconocimiento del numero convertido a cadena de caracteres, y lo traducimos a la expresión verbal del mismo, o sea en letras... 
        NumerosAletras = NumeroTraducido & "nuevos soles"
    End Function

End Module


