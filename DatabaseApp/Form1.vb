Public Class Form1
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim databaseobject As DatabaseFunction = New DatabaseFunction
        Dim name As String = TxtName.Text
        Dim address As String = TxtAddress.Text
        Dim report As DataSet = New DataSet
        report = databaseobject.Insert(name, address)
        DGVStudent.DataSource = report.Tables(0)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStudent.CellContentClick

    End Sub
End Class
