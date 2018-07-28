Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class MorningSheetEdit

    Private Sub MorningSheetEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.TblMorningSheetNotesTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetNotes)
        Me.TEMPInboundTableAdapter.Update(Me.MxDatabaseDataSet.TEMPInbound)
    End Sub



    Private Sub MorningSheetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblAcftOnStation' table. You can move, or remove it, as needed.
        Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblWebsiteHelpLocation' table. You can move, or remove it, as needed.
        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)

        Me.TblMorningSheetNotesTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetNotes)
        Me.TEMPInboundTableAdapter.Fill(Me.MxDatabaseDataSet.TEMPInbound)
        Me.TblMorningSheetNotesTableAdapter.Fill(Me.MxDatabaseDataSet.tblMorningSheetNotes)
        Me.TEMPInboundTableAdapter.Fill(Me.MxDatabaseDataSet.TEMPInbound)
        Me.TblTempMorningSheetPWTableAdapter.Fill(Me.MxDatabaseDataSet.tblTempMorningSheetPW)

        Dim CheckParkingCountTable As DataTableCollection = MxDatabaseDataSet.Tables
        Dim CheckC5Parking As Integer
        Dim CheckC17Parking As Integer
        Dim CheckC5Working As Integer
        Dim Check17Working As Integer

        CheckC5Parking = 0
        CheckC17Parking = 0
        CheckC5Working = 0
        Check17Working = 0

        For Each row In CheckParkingCountTable("tblAcftOnStation").Select("AcftType LIKE 'C005%'")
            CheckC5Parking += 1
        Next row

        For Each row In CheckParkingCountTable("tblAcftOnStation").Select("AcftType LIKE 'C017%'")
            CheckC17Parking += 1
        Next row
        
        C5ParkingATextBox.Text = CheckC5Parking
        C17ParkingATextBox.Text = CheckC17Parking


        For Each row In CheckParkingCountTable("tblAcftOnStation").Select("AcftType LIKE 'C005%'")
            If CInt(row("Fuel").ToString.Substring(4, 3)) <> 0 Or row("Status").ToString.Contains("NMC") Or row("ETICDateTime").ToString <> "" Then
                CheckC5Working += 1
            End If
        Next row

        For Each row In CheckParkingCountTable("tblAcftOnStation").Select("AcftType LIKE 'C017%'")
            If CInt(row("Fuel").ToString.Substring(4, 3)) <> 0 Or row("Status").ToString.Contains("NMC") Or row("ETICDateTime").ToString <> "" Then
                Check17Working += 1
            End If
        Next row

        C5WorkingATextBox.Text = CheckC5Working
        C17WorkingATextBox.Text = Check17Working

    End Sub

    Private Sub C5ParkingATextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5ParkingATextBox.TextChanged
        Try
            Update_Data("tblTempMorningSheetPW", "C5ParkingA", C5ParkingATextBox.Text)
            ParkingTotalTextBox.Text = AddTotals(CInt(C17ParkingATextBox.Text), CInt(C5ParkingATextBox.Text)).ToString
        Catch ex As Exception
            'MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Adding Error on Morning Sheet update")
        End Try
    End Sub


    Private Sub Update_Data(ByVal TableName As String, ByVal FieldName As String, ByVal ValueName As String)

        Dim myConnection As SqlConnection
        myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        myConnection.Open()

        Dim com As SqlCommand = New SqlCommand("UPDATE " & TableName & " SET " & FieldName & "='" & ValueName & "'", myConnection)
        Dim result As Integer = com.ExecuteNonQuery

        myConnection.Close()


    End Sub

    Private Sub C17ParkingATextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C17ParkingATextBox.TextChanged
        Try
            Update_Data("tblTempMorningSheetPW", "C17ParkingA", C17ParkingATextBox.Text)
            ParkingTotalTextBox.Text = AddTotals(CInt(C17ParkingATextBox.Text), CInt(C5ParkingATextBox.Text)).ToString
        Catch ex As Exception
            ' MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Adding Error on Morning Sheet update")
        End Try

    End Sub

    Private Sub ParkingTotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParkingTotalTextBox.TextChanged
        Update_Data("tblTempMorningSheetPW", "ParkingTotal", ParkingTotalTextBox.Text)
    End Sub

    Private Sub C5WorkingATextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5WorkingATextBox.TextChanged
        Try
            Update_Data("tblTempMorningSheetPW", "C5WorkingA", C5WorkingATextBox.Text)
            WorkingTotalTextBox.Text = AddTotals(CInt(C17WorkingATextBox.Text), CInt(C5WorkingATextBox.Text)).ToString
        Catch ex As Exception
            ' MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Adding Error on Morning Sheet update")
        End Try
    End Sub

    Private Sub C17WorkingATextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C17WorkingATextBox.TextChanged
        Try
            Update_Data("tblTempMorningSheetPW", "C17WorkingA", C17WorkingATextBox.Text)
            WorkingTotalTextBox.Text = AddTotals(CInt(C17WorkingATextBox.Text), CInt(C5WorkingATextBox.Text)).ToString
        Catch ex As Exception
            ' MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Adding Error on Morning Sheet update")
        End Try
    End Sub

    Private Sub WorkingTotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkingTotalTextBox.TextChanged
        Update_Data("tblTempMorningSheetPW", "WorkingTotal", WorkingTotalTextBox.Text)
    End Sub




    Private Sub btnUpdateG2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateG2.Click
        Try
            Dim myConnection As SqlConnection
            myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
            myConnection.Open()


            Dim InbdInfo As String = GetClipboardText()
            If InbdInfo = "No Clipboard Data" Then
                MsgBox("Copy from G2Web, then try again.")
                myConnection.Close()
                Exit Sub
            End If
            Dim InboundCount As Integer = InbdInfo.Split(vbCrLf).Count - 2
            'MsgBox(InbdInfo)
            Dim InboundArray(InboundCount)() As String
            Dim i As Integer = 0
            Dim x As Integer = 0

            For Each row In InbdInfo.Split(vbCrLf)
                'MsgBox(row)
                InboundArray(i) = row.Split()
                i = i + 1
                If i > InboundCount Then
                    Exit For
                End If
            Next

            Dim com As SqlCommand = New SqlCommand("DELETE FROM TEMPInbound", myConnection)
            Dim result As Integer = com.ExecuteNonQuery

            For i = 1 To InboundCount
                '1=mds 3=tail 5=mission 7=status 9=PrevICAO 11=NextICAO 13=ArrETA 15=GndTime 17=ArrETD 23=Pri 25=CW
                'MsgBox(InboundArray(i)(0) & " - " & InboundArray(i)(1) & " - " & InboundArray(i)(2) & " - " & InboundArray(i)(3) & " - " & InboundArray(i)(4) & " - " & InboundArray(i)(5) & " - " & InboundArray(i)(6) & " - " & InboundArray(i)(7) & " - " & InboundArray(i)(8) & " - " & InboundArray(i)(9) & " - " & InboundArray(i)(10) & " - " & InboundArray(i)(11) & " - " & InboundArray(i)(12) & " - " & InboundArray(i)(13) & " - " & InboundArray(i)(14))


                com = New SqlCommand("insert into TEMPInbound(MDS, TailNum, MissionNum, Status, PrevICAO, NextICAO, EstTime, GndTime, SchedTime, Pri, CW) values('" & InboundArray(i)(1) & "','" & InboundArray(i)(3) & "', '" & InboundArray(i)(5) & "', '" & InboundArray(i)(7) & "', '" & InboundArray(i)(9) & "', '" & InboundArray(i)(11) & "', '" & InboundArray(i)(13) & "', '" & InboundArray(i)(15) & "', '" & InboundArray(i)(17) & "', '" & InboundArray(i)(23) & "', '" & InboundArray(i)(25) & "')", myConnection)
                result = com.ExecuteNonQuery
            Next
            myConnection.Close()

            Me.TEMPInboundTableAdapter.Update(Me.MxDatabaseDataSet.TEMPInbound)
            Me.TEMPInboundTableAdapter.Fill(Me.MxDatabaseDataSet.TEMPInbound)

            MsgBox("Inbound Information Updated!")
            'MsgBox(Clipboard.GetDataObject().GetData(DataFormats.UnicodeText))
        Catch ex As Exception
            Dim NewErrorLog As ErrorLog = New ErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error with G2 Update")
            NewErrorLog.SubmitError()
            'MyErrorLog(ex.Message, System.DateTime.Now, My.User.Name, "Error with G2 Update")
            MsgBox("Error with G2 Update: " & ex.Message)
        End Try
    End Sub

    Public Function GetClipboardText() As String
        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        With objClipboard
            If .GetDataPresent(DataFormats.Text) Then
                Return .GetData(DataFormats.Text)
            Else
                Return "No Clipboard Data"
            End If
        End With
    End Function

    Private Sub TEMPInboundDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TEMPInboundDataGridView.CellEndEdit
        Me.TEMPInboundTableAdapter.Update(Me.MxDatabaseDataSet.TEMPInbound)
    End Sub




    Private Sub TEMPInboundDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles TEMPInboundDataGridView.UserDeletedRow
        Me.TEMPInboundTableAdapter.Update(Me.MxDatabaseDataSet.TEMPInbound)
    End Sub



    Private Sub TblMorningSheetNotesDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMorningSheetNotesDataGridView.CellEndEdit
        Me.TblMorningSheetNotesTableAdapter.Update(Me.MxDatabaseDataSet.tblMorningSheetNotes)
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

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Me.TblWebsiteHelpLocationTableAdapter.Fill(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)
        Me.TblWebsiteHelpLocationTableAdapter.Update(Me.MxDatabaseDataSet.tblWebsiteHelpLocation)

        Dim CheckWebsiteUpdate As DataTableCollection = MxDatabaseDataSet.Tables
        Dim TempWebsite As String = ""
        For Each row In CheckWebsiteUpdate("tblWebsiteHelpLocation").Select("ID='G2'")
            TempWebsite = row("Location").ToString
        Next row

        System.Diagnostics.Process.Start(TempWebsite)
    End Sub

    Private Function AddTotals(ByVal C5Count As Integer, ByVal C17Count As Integer)

        If C17Count = 0 Then
            Return C5Count
            'ParkingTotalTextBox.Text = CInt(C5ParkingATextBox.Text)
        ElseIf C5Count = 0 Then
            Return C17Count
            'ParkingTotalTextBox.Text = CInt(C5ParkingATextBox.Text) + CInt(C17ParkingATextBox.Text)
        Else
            Return C5Count + C17Count
        End If


    End Function


End Class