
Imports System.Net
Imports System.Net.Mail
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.DataTable

Public Class email
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim command As OleDbDataAdapter
    Dim dt As DataTable
    Dim i As Integer = 0
    Dim id As Integer
    Dim email1 As String
    Dim date1 As Date = Today
    Dim cid As Integer
    Dim gid As Integer
    Dim smtp_server As New SmtpClient
    Dim e_mail As New MailMessage
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Close()
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("select count(*) from [contact] where contact_name=? AND r_id=" & Val(id) & "", con)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtto.Text

        Dim count = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            Dim cmd2 As OleDbCommand = New OleDbCommand("select c_id, email from [contact] where contact_name=? AND r_id=" & Val(id) & "", con)
            cmd2.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtto.Text
            Dim da1 As OleDbDataAdapter
            Dim dt1 As DataTable
            Dim ds1 As DataSet
            da1 = New OleDbDataAdapter
            dt1 = New DataTable
            ds1 = New DataSet

            da1.SelectCommand = cmd2

            da1.Fill(ds1, "msg")
            dt1 = ds1.Tables(0)
            Dim row As DataRow
            For Each row In dt1.Rows


                cid = row("c_id")
                email1 = row("email")
                Try
                    smtp_server.UseDefaultCredentials = False
                    smtp_server.Credentials = New Net.NetworkCredential("skyrootmam123@gmail.com", "ganestole")
                    smtp_server.Port = 587
                    smtp_server.EnableSsl = True
                    smtp_server.Host = "smtp.gmail.com"

                    e_mail = New MailMessage()
                    e_mail.From = New MailAddress(txtfrom.Text)
                    e_mail.To.Add(email1)
                    e_mail.Subject = txtsubject.Text
                    e_mail.IsBodyHtml = False
                    e_mail.Body = message.Text
                    smtp_server.Send(e_mail)
                    MsgBox("Mail Sent")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            con.Close()
        Else
            MsgBox("Contact name doesnot match")
        End If

    End Sub

    Private Sub txtsubject_TextChanged(sender As Object, e As EventArgs) Handles txtsubject.TextChanged

    End Sub

    Private Sub txtfrom_TextChanged(sender As Object, e As EventArgs) Handles txtfrom.TextChanged

    End Sub

    Private Sub email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim email1 As String
        Dim cmd As OleDbCommand = New OleDbCommand("select email,r_id from [register] where username='" & usernamemv & "' and password='" & passwordmv & "'", con)

        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        email1 = myreader("email")
        id = myreader("r_id")
        txtfrom.Text = email1
        myreader.Close()
        con.Close()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub
End Class