Imports System.Security.Cryptography
Imports System.Text

Module ModuleSecurity
    Public Function HashSHA256(ByVal rawText As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            ' 1. Convert plaintext string into UTF-8 byte array
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(rawText)

            ' 2. Compute 256-bit hash bytes
            Dim hashBytes As Byte() = sha256.ComputeHash(inputBytes)

            ' 3. Convert byte array into a 64-character lowercase hexadecimal string
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function
End Module
