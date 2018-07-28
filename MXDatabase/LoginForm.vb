Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class LoginForm

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim myConnection As SqlConnection
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()
            'UserName Account LastLogin tblUserNames

            Dim CheckUserDataTable As DataTableCollection = MxDatabaseDataSet.Tables
            Dim CheckAccount As String = ""
            For Each row In CheckUserDataTable("tblUserNames").Select("UserName = '" & My.User.Name.ToString & "'")
                CheckAccount = row("Account").ToString
            Next row


            If CheckAccount = "" Then
                Dim com As SqlCommand = New SqlCommand("insert into tblUserNames(UserName, Account, LastLogin, CheckA4Load) values('" & My.User.Name & "','MOC', '" & System.DateTime.Now.ToUniversalTime & "', 'False')", myConnection)
                Dim result As Integer = com.ExecuteNonQuery

            Else
                If My.User.Name.ToString = "AVIANO\joel.davis" Or My.User.Name.ToString = "AVIANO\morgan.evans" Then
                    Dim com As SqlCommand = New SqlCommand("UPDATE tblUserNames SET Account='G1', LastLogin='" & System.DateTime.Now.ToUniversalTime & "', CheckA4Load='False' WHERE UserName='" & My.User.Name & "'", myConnection)
                    Dim result As Integer = com.ExecuteNonQuery
                Else
                    Dim com As SqlCommand = New SqlCommand("UPDATE tblUserNames SET Account='MOC', LastLogin='" & System.DateTime.Now.ToUniversalTime & "', CheckA4Load='False' WHERE UserName='" & My.User.Name & "'", myConnection)
                    Dim result As Integer = com.ExecuteNonQuery
                End If

            End If


            myConnection.Close()

            Me.Visible = False
            Dim MOCMain As New Main
            MOCMain.Show()
        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on MOC Login")
            MsgBox("Error on MOC Login")
        End Try

    End Sub



    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.TblUserNamesTableAdapter1.Fill(Me.MxDatabaseDataSet.tblUserNames)
        Catch ex As Exception
            MsgBox("Server is down! " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            Application.ExitThread()
            'Application.Exit()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim myConnection As SqlConnection
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()
            'UserName Account LastLogin tblUserNames

            Dim CheckUserDataTable As DataTableCollection = MxDatabaseDataSet.Tables
            Dim CheckAccount As String = ""
            For Each row In CheckUserDataTable("tblUserNames").Select("UserName = '" & My.User.Name.ToString & "'")
                CheckAccount = row("Account").ToString
            Next row


            If CheckAccount = "" Then
                Dim com As SqlCommand = New SqlCommand("insert into tblUserNames(UserName, Account, LastLogin) values('" & My.User.Name & "','G1', '" & System.DateTime.Now.ToUniversalTime & "')", myConnection)
                Dim result As Integer = com.ExecuteNonQuery

            Else
                Dim com As SqlCommand = New SqlCommand("UPDATE tblUserNames SET Account='G1', LastLogin='" & System.DateTime.Now.ToUniversalTime & "' WHERE UserName='" & My.User.Name & "'", myConnection)
                Dim result As Integer = com.ExecuteNonQuery
            End If


            myConnection.Close()

            Me.Visible = False
            Dim G1Main As New Main
            G1Main.Show()

        Catch ex As Exception
            MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error on G1 Login")
            MsgBox("Error on G1 Login")
        End Try
    End Sub

    Private Sub MyErrorLog(ByVal TheDescription As String, ByVal TheDate As Date, ByVal TheUser As String, ByVal TheMessage As String)
        Try
            TheDescription = Regex.Replace(TheDescription, "\'", " ", RegexOptions.Singleline)
            Dim myConnection As SqlConnection
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()

            Dim com As SqlCommand = New SqlCommand("insert into tblErrorLog(txtErrDescription, txtErrDate, txtUser, txtApplication) values('" & TheDescription & "','" & TheDate & "', '" & TheUser & "', '" & TheMessage & "')", myConnection)
            Dim result As Integer = com.ExecuteNonQuery

            myConnection.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class