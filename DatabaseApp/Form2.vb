Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Form2

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase1.accdb")
    ' Dim con As OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim cmd As New OleDb.OleDbCommand






    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim op As OpenFileDialog = New OpenFileDialog
        If op.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(op.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        Dim fname As String = TextBox1.Text & ".jpg"
        Dim folder As String = "C:\Users\user\source\repos\first\image"
        cmd.CommandText = "Insert into [contactinfo]([contact_name],[image]) values('" & TextBox1.Text & "',@fname)"
        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.ExecuteNonQuery()


        con.Close()
        Dim path As String = System.IO.Path.Combine(folder, fname)
        Dim a As Image = PictureBox1.Image
        a.Save(path)
        MessageBox.Show("successfull")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()

            If con.State = ConnectionState.Open Then
                MsgBox("Connected")
            Else
                MsgBox("Not Connected!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
End Class