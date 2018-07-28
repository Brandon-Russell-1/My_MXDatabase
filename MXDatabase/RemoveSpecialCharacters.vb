'Date: May 24th, 2010
'Author: Brandon Russell rbrandon87@gmail.com
'Usage: To remove special characters being used within a sql statement, i.e. '

Imports System.Text.RegularExpressions
Imports System.Text

Public Class RemoveSpecialCharacters

    Dim TheOrigString As String = ""
    Dim TheModifiedString As String = ""
    Dim TheSpecialCharacter As String = ""

    Public Sub New()

    End Sub

    Public Sub New(ByVal AString As String, ByVal ASpecialCharacter As String)
        TheOrigString = AString
        TheSpecialCharacter = ASpecialCharacter
    End Sub

    Public Function GetSpecialCharacter()
        Return TheSpecialCharacter
    End Function

    Public Sub SetSpecialCharacter(ByVal ASpecialCharacter As String)
        TheSpecialCharacter = ASpecialCharacter
    End Sub

    Public Function GetOrigString()
        Return TheOrigString
    End Function

    Public Sub SetOrigString(ByVal AString As String)
        TheOrigString = AString
    End Sub

    Public Function RunRemoveAction()
        TheModifiedString = Regex.Replace(TheOrigString, TheSpecialCharacter, " ")
        Return TheModifiedString
    End Function


End Class
