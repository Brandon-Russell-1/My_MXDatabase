' GeneralTurnover.vb Modified 07 July 2010 to use SQLBuilder
' Adds General Turnover entires,inserts into tblGeneralTurnover, then refreshes the Data set to display on screen.
' Authors rbrandon87@gmail.com, oglesbyzm@gmail.com

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class GeneralTurnover

    Private Sub GeneralTurnover_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.TblGeneralTurnoverTableAdapter.Update(MxDatabaseDataSet.tblGeneralTurnover)
    End Sub




    Private Sub GeneralTurnover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblGeneralTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralTurnover)

    End Sub


    Private Sub TblGeneralTurnoverDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblGeneralTurnoverDataGridView.CellEndEdit
        Me.TblGeneralTurnoverTableAdapter.Update(MxDatabaseDataSet.tblGeneralTurnover)
    End Sub


    Private Sub TblGeneralTurnoverDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblGeneralTurnoverDataGridView.UserDeletedRow
        Me.TblGeneralTurnoverTableAdapter.Update(MxDatabaseDataSet.tblGeneralTurnover)
    End Sub

    Private Sub btnAddWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWeather.Click
        Try
            'Dim myConnection As SqlConnection
            'myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            'myConnection.Open()
            If Not Me.GEntry.Text = "" Then
                Dim ResultString As String = Me.GEntry.Text
                ResultString = Regex.Replace(ResultString, "\'", " ", RegexOptions.Singleline)

                Dim AHash As New Hashtable
                AHash.Add("TurnDateTime", System.DateTime.Now.ToUniversalTime)
                AHash.Add("Entry", ResultString)
                AHash.Add("UserName", My.User.Name)
                Dim NewSqlBuilder As New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblGeneralTurnover", "INSERT")
                NewSqlBuilder.RunSQL()

                'Dim com As SqlCommand = New SqlCommand("insert into tblGeneralTurnover( TurnDateTime, Entry, UserName) values('" & Me.GTurnoverStartDate.Value & "','" & ResultString & "','" & My.User.Name.ToString & "')", myConnection)
                'Dim result As Integer = com.ExecuteNonQuery
                'myConnection.Close()
                Me.TblGeneralTurnoverTableAdapter.Update(MxDatabaseDataSet.tblGeneralTurnover)
                Me.TblGeneralTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralTurnover)
            Else
                'myConnection.Close()
                MsgBox("You can not submit a blank SOE")
            End If
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error adding general turnover")
            MsgBox("Error adding general turnover")
        End Try
    End Sub


    Private Sub MyErrorLog(ByVal TheDescription As String, ByVal TheDate As Date, ByVal TheUser As String, ByVal TheMessage As String)
        TheDescription = Regex.Replace(TheDescription, "\'", " ", RegexOptions.Singleline)
        Dim myConnection As SqlConnection
        myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        myConnection.Open()

        Dim com As SqlCommand = New SqlCommand("insert into tblErrorLog(txtErrDescription, txtErrDate, txtUser, txtApplication) values('" & TheDescription & "','" & TheDate & "', '" & TheUser & "', '" & TheMessage & "')", myConnection)
        Dim result As Integer = com.ExecuteNonQuery

        myConnection.Close()
    End Sub
End Class