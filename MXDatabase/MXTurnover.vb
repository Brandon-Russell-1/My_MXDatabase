Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class MXTurnover

    Private Sub MXTurnover_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.TblMXTurnoverTableAdapter.Update(MxDatabaseDataSet.tblMXTurnover)
    End Sub




    Private Sub GeneralTurnover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblMXTurnover' table. You can move, or remove it, as needed.
        Me.TblMXTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblMXTurnover)


    End Sub


    Private Sub TblGeneralTurnoverDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblGeneralTurnoverDataGridView.CellEndEdit
        Me.TblMXTurnoverTableAdapter.Update(MxDatabaseDataSet.tblMXTurnover)
    End Sub


    Private Sub TblGeneralTurnoverDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TblGeneralTurnoverDataGridView.UserDeletedRow
        Me.TblMXTurnoverTableAdapter.Update(MxDatabaseDataSet.tblMXTurnover)
    End Sub

    Private Sub btnAddWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWeather.Click
        Try
            Dim myConnection As SqlConnection
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()
            If Not Me.GEntry.Text = "" Then
                Dim ResultString As String = Me.GEntry.Text
                ResultString = Regex.Replace(ResultString, "\'", " ", RegexOptions.Singleline)

                Dim com As SqlCommand = New SqlCommand("insert into tblMXTurnover( TurnDateTime, Entry, UserName) values('" & Me.GTurnoverStartDate.Value & "','" & ResultString & "','" & My.User.Name.ToString & "')", myConnection)
                Dim result As Integer = com.ExecuteNonQuery
                myConnection.Close()
                Me.TblMXTurnoverTableAdapter.Update(MxDatabaseDataSet.tblMXTurnover)
                Me.TblMXTurnoverTableAdapter.Fill(Me.MxDatabaseDataSet.tblMXTurnover)
            Else
                myConnection.Close()
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

    Private Sub TblGeneralTurnoverDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblGeneralTurnoverDataGridView.CellContentClick

    End Sub
End Class