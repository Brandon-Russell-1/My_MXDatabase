'Date : May 24th, 2010
'Author: Brandon Russell rbrandon87@gmail.com
'Usage: To log errors to a error log table in the Sql database.

Imports System.Text.RegularExpressions

Public Class ErrorLog
    Dim TheDescription As String = ""
    Dim TheDate As Date
    Dim TheUser As String = ""
    Dim TheMessage As String = ""

    Public Sub New()

    End Sub

    Public Sub New(ByVal ADescription As String, ByVal ADate As Date, ByVal AUser As String, ByVal AMessage As String)
        TheDescription = ADescription
        TheDate = ADate.ToUniversalTime
        TheUser = AUser
        TheMessage = AMessage
    End Sub

    Public Function GetDescription()
        Return TheDescription
    End Function

    Public Function GetDate()
        Return TheDate
    End Function

    Public Function GetUser()
        Return TheUser
    End Function

    Public Function GetMessage()
        Return TheMessage
    End Function

    Public Sub SetDescription(ByVal ADescription As String)
        TheDescription = ADescription
    End Sub

    Public Sub SetDate(ByVal ADate As Date)
        TheDate = ADate
    End Sub

    Public Sub SetUser(ByVal AUser As String)
        TheUser = AUser
    End Sub

    Public Sub SetMessage(ByVal AMesssage As String)
        TheMessage = AMesssage
    End Sub



    Public Sub SubmitError()
        Try
            TheDescription = Regex.Replace(TheDescription, "\'", " ", RegexOptions.Singleline)
            Dim AHash As New Hashtable
            AHash.Add("txtErrDescription", TheDescription)
            AHash.Add("txtErrDate", TheDate.ToString)
            AHash.Add("txtUser", TheUser)
            AHash.Add("txtApplication", TheMessage)

            Dim NewSqlBuilder As New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblErrorLog", "INSERT")
            Dim Test As Integer = NewSqlBuilder.RunSQL
        Catch ex As Exception
        End Try
    End Sub
End Class
