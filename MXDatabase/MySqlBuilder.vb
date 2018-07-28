'Date: May 11th, 2010
'Author: Brandon Russell
'Description: Use this class to run either a Sql Insert or Update command without having to build a super long sql statement.
'To use this build a hash table and populate it with Field Name as the Key and the value of the Field as the hash value.
'Ex. Dim AHash as New HashTable
'    AHash.Add(FieldName,Value)
'    Dim NewSqlBuilder as New MySqlBuilder(TheConnectionString, AHash, TableName, WhereField(*Optional), WhereValue(*Optional), Action(<-Either INSERT Or UPDATE))
'    NewSqlBuilder.RunSql()
' The Return value tells how many records were affected or -1 if there was an error.
' Use the Get/Set Methods to change the Action, Hash Contents, etc... to run a diffrent Sql Command instead of having to create an entirely new object.
Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions

Public Class MySqlBuilder

    Dim CheckForDigit As Regex = New Regex("^\d+$")
    Dim CheckForDigitMatch As Match

    Dim MyHashTable As New Hashtable
    Dim MyStringBuilder As New StringBuilder
    Dim MyRow As DictionaryEntry
    Dim ra As Integer
    Dim myConnection As SqlConnection
    Dim myCommand As SqlCommand
    Dim sqltrans As SqlTransaction
    Dim MyTableName As String
    Dim MyWhereValue As String
    Dim MyWhereField As String
    Dim MyAction As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal TheConnection As String, ByVal TheHash As Hashtable, ByVal TheTable As String, ByVal WhereField As String, ByVal WhereValue As String, ByVal TheAction As String)
        MyHashTable = TheHash
        myConnection = New SqlConnection(TheConnection)
        MyTableName = TheTable
        MyWhereField = WhereField
        MyWhereValue = WhereValue
        MyAction = TheAction
    End Sub

    Public Sub New(ByVal TheConnection As String, ByVal TheHash As Hashtable, ByVal TheTable As String, ByVal TheAction As String)
        MyHashTable = TheHash
        myConnection = New SqlConnection(TheConnection)
        MyTableName = TheTable
        MyAction = TheAction
    End Sub

    Public Function GetHash()
        Return MyHashTable
    End Function

    Public Function GetTableName()
        Return MyTableName
    End Function

    Public Function GetWhereField()
        Return MyWhereField
    End Function

    Public Function GetWhereValue()
        Return MyWhereValue
    End Function

    Public Function GetAction()
        Return MyAction
    End Function

    Public Sub SetAction(ByVal TheAction As String)
        MyAction = TheAction
    End Sub

    Public Sub SetHash(ByVal TheHash As Hashtable)
        MyHashTable = TheHash
    End Sub

    Public Sub SetTableName(ByVal TheTable As String)
        MyTableName = TheTable
    End Sub

    Public Sub SetWhereField(ByVal WhereField As String)
        MyWhereField = WhereField
    End Sub

    Public Sub SetWhereValue(ByVal WhereValue As String)
        MyWhereValue = WhereValue
    End Sub

    Public Function RunSQL()
        MyStringBuilder.Remove(0, MyStringBuilder.Length)
        If MyAction.ToUpper = "INSERT" Then
            MyStringBuilder.Append("INSERT INTO " & MyTableName & "(")
            For Each Me.MyRow In MyHashTable
                MyStringBuilder.Append("" & MyRow.Key & ", ")
                
            Next
            MyStringBuilder.Remove(MyStringBuilder.Length - 2, 2)
            MyStringBuilder.Append(") values(")
            For Each Me.MyRow In MyHashTable

                CheckForDigitMatch = CheckForDigit.Match(MyRow.Value)
                If CheckForDigitMatch.Success Then
                    MyStringBuilder.Append("" & MyRow.Value & ", ")
                Else
                    MyStringBuilder.Append("'" & MyRow.Value & "', ")
                End If
                
            Next
            MyStringBuilder.Remove(MyStringBuilder.Length - 2, 2)
            MyStringBuilder.Append(")")
        ElseIf MyAction.ToUpper = "UPDATE" Then
            MyStringBuilder.Append("UPDATE " & MyTableName & " SET ")
            For Each Me.MyRow In MyHashTable
                CheckForDigitMatch = CheckForDigit.Match(MyRow.Value)
                If CheckForDigitMatch.Success Then
                    MyStringBuilder.Append(MyRow.Key & "=" & MyRow.Value & ", ")
                Else
                    MyStringBuilder.Append(MyRow.Key & "='" & MyRow.Value & "', ")
                End If

                
            Next
            MyStringBuilder.Remove(MyStringBuilder.Length - 2, 2)


            If MyWhereField <> "" And MyWhereValue <> "" Then
                CheckForDigitMatch = CheckForDigit.Match(MyWhereValue)
                If CheckForDigitMatch.Success Then
                    MyStringBuilder.Append(" WHERE " & MyWhereField & "=" & MyWhereValue & "")
                Else
                    MyStringBuilder.Append(" WHERE " & MyWhereField & "='" & MyWhereValue & "'")
                End If

            End If
        Else
            Return -1
        End If

        myConnection.Open()
        'Begin Transaction
        sqltrans = myConnection.BeginTransaction
        Try
            'MsgBox(MyStringBuilder.ToString)
            myCommand = New SqlCommand(MyStringBuilder.ToString, myConnection)
            myCommand.Transaction = sqltrans
            ra = myCommand.ExecuteNonQuery()


            'Commit Transactions
            sqltrans.Commit()
        Catch ex As Exception
            'Rollback Transactions
            sqltrans.Rollback()
            Return -1
        Finally
            myConnection.Close()
        End Try
        Return ra
    End Function



End Class
