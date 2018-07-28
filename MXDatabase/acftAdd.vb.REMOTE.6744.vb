' acftAdd.vb  July 6, 2010
'' This form is used to create a new aircraft on station when the A4 page is down. Some of the infomation is nessesary to insure
' that a valid PrimKey is made. You must have data in Tail Number, MDS, Block In, and Acft Spot. Other information is not needed.
' Author oglesbyzm@gmail.com




Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class acftAdd

    Dim PrimKey As String = ""
    Event NewRecordAddedEvent()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim PrimKey As String = ""
        PrimKey = TextBox1.Text.ToString + TextBox2.Text.ToString + TextBox3.Text.ToString + TextBox4.Text.ToString + System.DateTime.Today.Year.ToString
        PrimKey = Regex.Replace(PrimKey, "[\s\\]+", "")

        Dim AHash As New Hashtable
        AHash.Add("PrimKey", PrimKey)
        AHash.Add("AcftTailNumber", TextBox1.Text)
        AHash.Add("AcftType", TextBox2.Text)
        AHash.Add("BlockInDateTime", TextBox3.Text)
        AHash.Add("AcftSpot", TextBox4.Text)
        AHash.Add("LastDepDateTime", TextBox5.Text)
        AHash.Add("ETDDateTime", TextBox6.Text)
        AHash.Add("BPODateTime", TextBox7.Text)
        AHash.Add("Fuel", TextBox8.Text)
        AHash.Add("Lox", TextBox9.Text)
        AHash.Add("Nitro", TextBox10.Text)
        AHash.Add("Status", TextBox11.Text)
        Dim NewSqlBuilder As New MySqlBuilder(My.Settings.MxDatabaseConnectionString, AHash, "tblAcftOnStation", "INSERT")
        NewSqlBuilder.RunSQL()

        RaiseEvent NewRecordAddedEvent()

        Me.Close()
    End Sub

    Public Function GetPrimKey()
        Return PrimKey
    End Function

End Class