Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class setting
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim cmd As OleDbCommand
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcurrent.TextChanged

    End Sub

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If (txtcurrent.Text = Nothing Or txtnew.Text = Nothing Or txtre.Text = Nothing) Then
            MsgBox("Please enter the details", MsgBoxStyle.Exclamation)
        Else
            If (txtnew.Text = txtre.Text) Then

                If (txtcurrent.Text = passwordmv) Then
                    con.Open()
                    Dim sql As String

                    sql = "select r_id from [register] where username='" & usernamemv & "' and password='" & passwordmv & "'"

                    Dim cmda As New OleDbCommand(sql, con)
                    Dim myreader As OleDbDataReader

                    myreader = cmda.ExecuteReader
                    myreader.Read()

                    rid = myreader("r_id")
                    myreader.Close()
                    cmd = New OleDbCommand("UPDATE [register] SET [password]='" & txtnew.Text & "' WHERE r_id=" & rid & "", con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    con.Close()
                    MsgBox("Password Updated Successfully")
                Else
                    MsgBox("Password Doesnot match")
                End If
            Else
                MsgBox("Rewrite password doesnot match new password")
            End If
        End If
    End Sub
End Class