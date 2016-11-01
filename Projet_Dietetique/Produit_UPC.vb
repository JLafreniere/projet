


Imports System.IO
Imports System.Net
Imports System.Text

Public Class Produit_UPC
    Public Property nomproduit As String
    Public Sub New(code As String)

        nomproduit = checkUPC(code)

    End Sub





    Public Function checkUPC(code As String)
        Try

            Dim tempcookies As New CookieContainer
            Dim encoding As New UTF8Encoding

            Dim postreq As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://www.upcdatabase.com/item/" & code), HttpWebRequest)
            postreq.Method = "GET"
            postreq.KeepAlive = True
            postreq.CookieContainer = tempcookies
            postreq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729"
            postreq.ContentType = "application/x-www-form-urlencoded"

            Dim postresponse As HttpWebResponse
            Try
                postresponse = DirectCast(postreq.GetResponse, HttpWebResponse)
                Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
                Dim thepage As String = postreqreader.ReadToEnd

                Dim mystr As String = thepage
                Dim cut_at As String = "<tr><td>Description</td><td></td><td>"
                Dim x As Integer = InStr(mystr, cut_at)

                Dim string_before As String = mystr.Substring(0, x - 2)
                Dim string_after As String = mystr.Substring(x + cut_at.Length - 1)


                Dim mystr2 As String = string_after
                Dim cut_at2 As String = "</td>"
                Dim x2 As Integer = InStr(mystr2, cut_at2)

                Dim string_before2 As String = mystr2.Substring(0, x2 - 1)
                Dim string_after2 As String = mystr2.Substring(x2 + cut_at2.Length - 1)


                Return string_before2

            Catch exc As Exception : MsgBox("CODE INVALIDE") : End Try


        Catch exc As Exception

        End Try
        Return "null"
    End Function

End Class
