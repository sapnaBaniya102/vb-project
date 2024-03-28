Imports System.Data
Imports System.Data.OleDb

Public Class profile
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    ' Dim con As OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim cmd As OleDbCommand
    Dim id As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewpnl.Hide()
        updatepanel.Hide()

    End Sub

    Private Sub viewbtn_Click(sender As Object, e As EventArgs) Handles viewbtn.Click
        viewpnl.Show()
        updatepanel.Hide()
        con.Open()
        Dim sql As String
        sql = "select name,username,address,email,phonenumber,dateofbirth from [register] where username=? and password=?"
        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@1", usernamemv)
        cmd.Parameters.AddWithValue("@2", passwordmv)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        viewname.Text = myreader("name")
        username.Text = myreader("username")
        address.Text = myreader("address")
        email.Text = myreader("email")
        mobile.Text = myreader("phonenumber")
        dateofbirth.Text = myreader("dateofbirth")

        con.Close()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        viewpnl.Hide()
        updatepanel.Show()
        con.Open()

        Dim sql As String
        sql = "select r_id,name,username,address,email,phonenumber,dateofbirth from register where username=? and password=?"
        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@1", usernamemv)
        cmd.Parameters.AddWithValue("@2", passwordmv)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()
        id = myreader("r_id")
        name1.Text = myreader("name")
        username1.Text = myreader("username")
        address1.Text = myreader("address")
        email1.Text = myreader("email")
        mobile1.Text = myreader("phonenumber")
        dateofbirth1.Text = myreader("dateofbirth")
        myreader.Close()
        con.Close()

    End Sub

    Private Sub viewpnl_Paint(sender As Object, e As PaintEventArgs) Handles viewpnl.Paint

    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        con.Open()
        Dim comm As String
        comm = "update [register] set name='" & name1.Text & "',username='" & username1.Text & "',address='" & address1.Text & "',email='" & email1.Text & "',dateofbirth='" & dateofbirth1.Value & "',phonenumber='" & mobile1.Text & "' where r_id=" & id & ""
        cmd = New OleDbCommand(comm, con)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Updated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class