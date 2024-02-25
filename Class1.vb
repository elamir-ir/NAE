Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Security
Imports System.IO
Imports System
Imports System.ComponentModel
Class EncDec
    Public Shared sth As Integer = 0
    Public Shared s As Integer
    Public Shared Sub Enc(ByVal inputFile As String, ByVal outputFile As String, ByVal passwordBytes As Byte())
        Dim saltBytes As Byte() = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim cryptFile As String = outputFile
        Dim fsCrypt As New FileStream(cryptFile, FileMode.Create)
        Dim AES As New RijndaelManaged()
        AES.KeySize = 256
        AES.BlockSize = 128
        Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
        AES.Key = key.GetBytes(AES.KeySize / 8)
        AES.IV = key.GetBytes(AES.BlockSize / 8)
        AES.Padding = PaddingMode.Zeros
        AES.Mode = CipherMode.CBC
        Dim cs As New CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write)
        Dim fsIn As New FileStream(inputFile, FileMode.Open)
        Dim data As Byte() = New Byte(12342) {}
        s = My.Computer.FileSystem.GetFileInfo(inputFile).Length
        Dim ex As Byte() = {212, 245, 1, 43}
        cs.WriteByte(ex(0))
        cs.WriteByte(ex(1))
        cs.WriteByte(ex(2))
        cs.WriteByte(ex(3))
        While (fsIn.Read(data, 0, data.Length)) <> 0
            cs.Write(data, 0, data.Length)
            sth = sth + data.Length
        End While
        sth = 0
        fsIn.Close()
        cs.Close()
        fsCrypt.Close()
    End Sub
    Public Shared Sub Dec(ByVal inputFile As String, ByVal outputFile As String, ByVal passwordBytes As Byte())
        Dim saltBytes As Byte() = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim fsCrypt As New FileStream(inputFile, FileMode.Open)
        Dim AES As New RijndaelManaged()
        AES.KeySize = 256
        AES.BlockSize = 128
        Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
        AES.Key = key.GetBytes(AES.KeySize / 8)
        AES.IV = key.GetBytes(AES.BlockSize / 8)
        AES.Padding = PaddingMode.Zeros
        AES.Mode = CipherMode.CBC
        Dim cs As New CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read)
        Dim fsOut As New FileStream(outputFile, FileMode.Create)
        Dim data As Byte() = New Byte(12342) {}
        s = My.Computer.FileSystem.GetFileInfo(inputFile).Length
        Dim ex = {0, 0, 0, 0}
        ex(0) = cs.ReadByte()
        ex(1) = cs.ReadByte()
        ex(2) = cs.ReadByte()
        ex(3) = cs.ReadByte()
        If ex(0) = 212 And ex(1) = 245 And ex(2) = 1 And ex(3) = 43 Then
            While (cs.Read(data, 0, data.Length)) <> 0
                fsOut.Write(data, 0, data.Length)
                sth = sth + 1
            End While
        Else
            frmNew.st = 1
        End If
        sth = 0
        fsOut.Close()
        cs.Close()
        fsCrypt.Close()
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
End Class