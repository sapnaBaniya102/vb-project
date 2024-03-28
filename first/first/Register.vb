Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class Register
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    ' Dim con As OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\contactdatabase.accdb")
    Dim cmd As New OleDb.OleDbCommand






    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles address.TextChanged

    End Sub

    'Private Sub registerpnl_Paint(sender As Object, e As PaintEventArgs) Handles MyBasepnl.Paint

    'End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles phonenumber.TextChanged

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles datetime.ValueChanged

    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles registercloase.Click

    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim op As OpenFileDialog = New OpenFileDialog
        If op.ShowDialog = DialogResult.OK Then
            picture.Image = Image.FromFile(op.FileName)
        End If



    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles picture.Click


    End Sub





    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If fullname.Text = Nothing Or username.Text = Nothing Or address.Text = Nothing Or email.Text = Nothing Or phonenumber.Text = Nothing Or password.Text = Nothing Then
            MsgBox("please enter above detail", MsgBoxStyle.Exclamation)
            fullname.Clear()
            username.Clear()
            address.Clear()
            email.Clear()
            phonenumber.Clear()
            password.Clear()
        Else
            con.Open()
            Dim fname As String = fullname.Text & ".jpg"
            Dim folder As String = "C:\Users\user\source\repos\first\image"
            Dim cmd As OleDbCommand = New OleDbCommand("select count(*) from register where email=? ", con)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = email.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MsgBox("Email already used", MsgBoxStyle.Exclamation)
            Else
                Dim sql As New OleDb.OleDbCommand
                sql.Connection = con
                sql.CommandText = "insert into register([name],[username],[address],[email],[phonenumber],[dateofbirth],[password],[image])values(?,?,?,?,?,?,?,?)"
                sql.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = fullname.Text
                sql.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = username.Text
                sql.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = address.Text
                sql.Parameters.AddWithValue("@4", OleDbType.VarChar).Value = email.Text
                sql.Parameters.AddWithValue("@5", OleDbType.VarChar).Value = phonenumber.Text
                sql.Parameters.AddWithValue("@6", OleDbType.VarChar).Value = datetime.Text
                sql.Parameters.AddWithValue("@7", OleDbType.VarChar).Value = password.Text
                sql.Parameters.AddWithValue("@8", OleDbType.VarChar).Value = fname
                sql.ExecuteNonQuery()
                con.Close()
                Dim path As String = System.IO.Path.Combine(folder, fname)
                Dim a As Image = picture.Image
                a.Save(path)
                MessageBox.Show(" inserted successfull")
                fullname.Clear()
                username.Clear()
                address.Clear()
                email.Clear()
                phonenumber.Clear()
                password.Clear()
                Me.Hide()
                login.Show()
                login.Activate()
            End If
        End If




    End Sub

    Private Sub fullname_TextChanged(sender As Object, e As EventArgs) Handles fullname.TextChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        login.Show()
        login.Activate()
    End Sub
End Class