' AddSOEForm.vb Modified 07 July 2010 to use SQLBuilder
' Adding SOE entrties to aircraft (inserts into tblSOE). Tail Number MDS and PrimKey are pulled from the selected Aircraft on Form1.vb
' Authors rbrandon87@gmail.com, oglesbyzm@gmail.com

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AddSOEForm
    Event NewRecordAddedEvent()
    Dim TheCurrentPrimKey As String = ""
    Dim CheckTailNum As String = ""
    Dim CheckMDSNum As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Dim myConnection As SqlConnection
            'myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            'myConnection.Open()

            If Not Me.TextBox1.Text = "" Then


                Dim ResultString As String = Me.TextBox1.Text
                ResultString = Regex.Replace(ResultString, "\'", " ", RegexOptions.Singleline)

                Dim AHash As New Hashtable
                AHash.Add("PrimKey", TheCurrentPrimKey)
                AHash.Add("MDS", CheckMDSNum)
                AHash.Add("AcftTailNum", CheckTailNum)
                AHash.Add("SOEDateTime", System.DateTime.Now.ToUniversalTime)
                AHash.Add("Entry", ResultString)
                AHash.Add("UserName", My.User.Name)
                Dim NewSqlBuilder As New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblSOE", "INSERT")
                NewSqlBuilder.RunSQL()

                'Dim com As SqlCommand = New SqlCommand("insert into tblSOE(PrimKey, MDS, AcftTailNum, SOEDateTime, Entry, UserName) values('" & TheCurrentPrimKey & "','" & CheckMDSNum & "', '" & CheckTailNum & "', '" & System.DateTime.Now.ToUniversalTime & "', '" & ResultString & "', '" & My.User.Name & "')", myConnection)
                'Dim result As Integer = com.ExecuteNonQuery

                RaiseEvent NewRecordAddedEvent()
                'myConnection.Close()
                Me.Close()
            Else
                'myConnection.Close()
                MsgBox("You can not submit a blank SOE")
            End If

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error adding the SOE Entry")
            MsgBox("Error adding SOE Entry")
        End Try
    End Sub

    Private Sub AddSOEForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.PrimKeyComboBox.SelectedValue = "PreFod"
    End Sub



    Private Sub AddSOEForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblAutoSOETableAdapter.Fill(Me.MxDatabaseDataSet.tblAutoSOE)
        Me.TblSOETableAdapter.Fill(Me.MxDatabaseDataSet.tblSOE)

        Me.lblAcftTailNum.Text = CheckTailNum
        Me.lblMDS.Text = CheckMDSNum

    End Sub

    Public Sub SetPrimKey(ByVal ThePrimKey As String, ByVal TheTail As String, ByVal TheMDS As String)
        TheCurrentPrimKey = ThePrimKey
        CheckTailNum = TheTail
        CheckMDSNum = TheMDS
    End Sub

    Public Function GetPrimKey()
        Return TheCurrentPrimKey
    End Function



    Private Sub PrimKeyComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimKeyComboBox.SelectedIndexChanged
        Try
            'Dim myConnection As SqlConnection
            'myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            'myConnection.Open()

            If Not Me.PrimKeyComboBox.SelectedValue = "" Then
                'Dim com As SqlCommand = New SqlCommand("insert into tblSOE(PrimKey, MDS, AcftTailNum, SOEDateTime, Entry, UserName) values('" & TheCurrentPrimKey & "','" & CheckMDSNum & "', '" & CheckTailNum & "', '" & System.DateTime.Now.ToUniversalTime & "', '" & Me.PrimKeyComboBox.SelectedValue & "', '" & My.User.Name & "')", myConnection)
                'Dim result As Integer = com.ExecuteNonQuery
                Dim AHash As New Hashtable
                AHash.Add("PrimKey", TheCurrentPrimKey)
                AHash.Add("MDS", CheckMDSNum)
                AHash.Add("AcftTailNum", CheckTailNum)
                AHash.Add("SOEDateTime", System.DateTime.Now.ToUniversalTime)
                AHash.Add("Entry", Me.PrimKeyComboBox.SelectedValue)
                AHash.Add("UserName", My.User.Name)
                Dim NewSqlBuilder As New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblSOE", "INSERT")
                NewSqlBuilder.RunSQL()


                RaiseEvent NewRecordAddedEvent()
                'myConnection.Close()
                Me.Close()
            Else
                'myConnection.Close()
            End If

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error adding the AutoSOE Entry")
            MsgBox("Error adding SOE Entry")
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