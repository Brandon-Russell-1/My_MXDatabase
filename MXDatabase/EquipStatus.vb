Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class EquipStatus



    Private Sub EquipStatus_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub EquipStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblGeneralInfo' table. You can move, or remove it, as needed.
        Me.TblGeneralInfoTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralInfo)

    End Sub

    Private Sub LoxLX01TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX01TextBox.TextChanged
        UpdateGeneralRecords("LoxLX01", Me.LoxLX01TextBox.Text)
    End Sub

    Private Sub UpdateGeneralRecords(ByVal PrimKey As String, ByVal value As String)
        Dim myConnection As SqlConnection
        myConnection = New SqlConnection(My.Settings.MxDatabaseConnectionString)
        myConnection.Open()

        Dim ResultString As String = value
        ResultString = Regex.Replace(ResultString, "\'", " ", RegexOptions.Singleline)

        Dim com As SqlCommand = New SqlCommand("UPDATE tblGeneralInfo SET " & PrimKey & "='" & value & "'", myConnection)
        Dim result As Integer = com.ExecuteNonQuery
        myConnection.Close()
        'Me.TblGeneralInfoTableAdapter.Update(MxDatabaseDataSet.tblGeneralInfo)
        'Me.TblGeneralInfoTableAdapter.Fill(Me.MxDatabaseDataSet.tblGeneralInfo)
    End Sub

    Private Sub LoxLX02TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX02TextBox.TextChanged
        UpdateGeneralRecords("LoxLX02", Me.LoxLX02TextBox.Text)
    End Sub

    Private Sub LoxLX03TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX03TextBox.TextChanged
        UpdateGeneralRecords("LoxLX03", Me.LoxLX03TextBox.Text)
    End Sub

    Private Sub LoxLX04TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX04TextBox.TextChanged
        UpdateGeneralRecords("LoxLX04", Me.LoxLX04TextBox.Text)
    End Sub

    Private Sub LoxLX05TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX05TextBox.TextChanged
        UpdateGeneralRecords("LoxLX05", Me.LoxLX05TextBox.Text)
    End Sub

    Private Sub LoxLX09TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX09TextBox.TextChanged
        UpdateGeneralRecords("LoxLX09", Me.LoxLX09TextBox.Text)
    End Sub

    Private Sub GoxCartTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoxCartTextBox.TextChanged
        UpdateGeneralRecords("GoxCart", Me.GoxCartTextBox.Text)
    End Sub

    Private Sub NitroTruck165TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroTruck165TextBox.TextChanged
        UpdateGeneralRecords("NitroTruck165", Me.NitroTruck165TextBox.Text)
    End Sub

    Private Sub NitroTruck745TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroTruck745TextBox.TextChanged
        UpdateGeneralRecords("NitroTruck745", Me.NitroTruck745TextBox.Text)
    End Sub

    Private Sub EngineStatusC5TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EngineStatusC5TextBox.TextChanged
        UpdateGeneralRecords("EngineStatusC5", Me.EngineStatusC5TextBox.Text)
    End Sub

    Private Sub EngineStatusC17TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EngineStatusC17TextBox.TextChanged
        UpdateGeneralRecords("EngineStatusC17", Me.EngineStatusC17TextBox.Text)
    End Sub

    Private Sub NitroCartNC1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroCartNC1TextBox.TextChanged
        UpdateGeneralRecords("NitroCartNC1", Me.NitroCartNC1TextBox.Text)
    End Sub

    Private Sub NitroCartNC3TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroCartNC3TextBox.TextChanged
        UpdateGeneralRecords("NitroCartNC3", Me.NitroCartNC3TextBox.Text)
    End Sub

    Private Sub NitroCartNC4TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroCartNC4TextBox.TextChanged
        UpdateGeneralRecords("NitroCartNC4", Me.NitroCartNC4TextBox.Text)
    End Sub

    Private Sub LoxLX01InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX01InfoTextBox.TextChanged
        UpdateGeneralRecords("LoxLX01Info", Me.LoxLX01InfoTextBox.Text)
    End Sub

    Private Sub LoxLX02InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX02InfoTextBox.TextChanged
        UpdateGeneralRecords("LoxLX02Info", Me.LoxLX02InfoTextBox.Text)
    End Sub

    Private Sub LoxLX03InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX03InfoTextBox.TextChanged
        UpdateGeneralRecords("LoxLX03Info", Me.LoxLX03InfoTextBox.Text)
    End Sub

    Private Sub LoxLX04InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX04InfoTextBox.TextChanged
        UpdateGeneralRecords("LoxLX04Info", Me.LoxLX04InfoTextBox.Text)
    End Sub

    Private Sub LoxLX05InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxLX05InfoTextBox.TextChanged
        UpdateGeneralRecords("LoxLX05Info", Me.LoxLX05InfoTextBox.Text)
    End Sub

    Private Sub LOxLX09InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOxLX09InfoTextBox.TextChanged
        UpdateGeneralRecords("LOxLX09Info", Me.LOxLX09InfoTextBox.Text)
    End Sub

    Private Sub GoxCartInfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoxCartInfoTextBox.TextChanged
        UpdateGeneralRecords("GoxCartInfo", Me.GoxCartInfoTextBox.Text)
    End Sub

    Private Sub EngineStatusC5InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EngineStatusC5InfoTextBox.TextChanged
        UpdateGeneralRecords("EngineStatusC5Info", Me.EngineStatusC5InfoTextBox.Text)
    End Sub

    Private Sub EngineStatusC17InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EngineStatusC17InfoTextBox.TextChanged
        UpdateGeneralRecords("EngineStatusC17Info", Me.EngineStatusC17InfoTextBox.Text)
    End Sub

    Private Sub NitroTruck165InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroTruck165InfoTextBox.TextChanged
        UpdateGeneralRecords("NitroTruck165Info", Me.NitroTruck165InfoTextBox.Text)
    End Sub

    Private Sub NitroTruck745InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroTruck745InfoTextBox.TextChanged
        UpdateGeneralRecords("NitroTruck745Info", Me.NitroTruck745InfoTextBox.Text)
    End Sub

    Private Sub NitroCartNC1InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroCartNC1InfoTextBox.TextChanged
        UpdateGeneralRecords("NitroCartNC1Info", Me.NitroCartNC1InfoTextBox.Text)
    End Sub

    Private Sub NitroCartNC3InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroCartNC3InfoTextBox.TextChanged
        UpdateGeneralRecords("NitroCartNC3Info", Me.NitroCartNC3InfoTextBox.Text)
    End Sub

    Private Sub NitroCartNC4InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroCartNC4InfoTextBox.TextChanged
        UpdateGeneralRecords("NitroCartNC4Info", Me.NitroCartNC4InfoTextBox.Text)
    End Sub
End Class