Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class retrive
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    ' Dim con As OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Private Sub retrive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim sql As String

        sql = "select r_id from register where username='" & username1.Text & "' and password='" & pass.Text & "'"

        Dim cmd As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader

        myreader = cmd.ExecuteReader
            myreader.Read()
        Dim id As Integer
        id = myreader("r_id")
        Dim query As New OleDb.OleDbCommand
        query.Connection = con

        query.CommandText = "insert into [contact]([contact_name],[con_number],[business],[email],[dateofbirth],[r_id])values(@name,@number,@business,@email,@dateofbirth,@r)"
        query.Parameters.AddWithValue("@name", TextBox1.Text)
        query.Parameters.AddWithValue("@number", TextBox5.Text)
        query.Parameters.AddWithValue("@business", TextBox2.Text)
        query.Parameters.AddWithValue("@email", TextBox4.Text)
        query.Parameters.AddWithValue("@dateofbirth", TextBox3.Text)
        query.Parameters.AddWithValue("@r", id)
        query.ExecuteNonQuery()

        myreader.Close()

        con.Close()
    End Sub
End Class