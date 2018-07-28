Public Class manAcftEdit

    Private Sub TblAcftOnStationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblAcftOnStationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MxDatabaseDataSet)

    End Sub

    Private Sub manAcftEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MxDatabaseDataSet.tblAcftOnStation' table. You can move, or remove it, as needed.
        Me.TblAcftOnStationTableAdapter.Fill(Me.MxDatabaseDataSet.tblAcftOnStation)
    End Sub

    Private Sub AcftSpotTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcftSpotTextBox.TextChanged
        Dim AHash As New Hashtable
        AHash.Add("AcftSpot", Me.AcftSpotTextBox.Text)
        Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.AcftTailNumberListBox.SelectedValue, "UPDATE")
        Dim Test As Integer = NewSqlBuilder.RunSQL
    End Sub

    Private Sub StatusTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusTextBox.TextChanged
        Dim AHash As New Hashtable
        AHash.Add("Status", Me.StatusTextBox.Text)
        Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.AcftTailNumberListBox.SelectedValue, "UPDATE")
        Dim Test As Integer = NewSqlBuilder.RunSQL
    End Sub

    Private Sub FuelTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuelTextBox.TextChanged
        Dim AHash As New Hashtable
        AHash.Add("Fuel", Me.FuelTextBox.Text)
        Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.AcftTailNumberListBox.SelectedValue, "UPDATE")
        Dim Test As Integer = NewSqlBuilder.RunSQL
    End Sub

    Private Sub NitroTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NitroTextBox.TextChanged
        Dim AHash As New Hashtable
        AHash.Add("Nitro", Me.NitroTextBox.Text)
        Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.AcftTailNumberListBox.SelectedValue, "UPDATE")
        Dim Test As Integer = NewSqlBuilder.RunSQL
    End Sub

    Private Sub LoxTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoxTextBox.TextChanged
        Dim AHash As New Hashtable
        AHash.Add("Lox", Me.LoxTextBox.Text)
        Dim NewSqlBuilder As MySqlBuilder = New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "PrimKey", Me.AcftTailNumberListBox.SelectedValue, "UPDATE")
        Dim Test As Integer = NewSqlBuilder.RunSQL
    End Sub
End Class