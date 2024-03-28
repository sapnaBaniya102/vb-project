

Imports System.IO
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Register
    Dim gendervalue As String
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (OpenFileDialog1.ShowDialog = DialogResult.OK
        ) Then
            picture.ImageLocation = OpenFileDialog1.FileName
        End If



    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        contact_management_system.Show()
        contact_management_system.Activate()
        Me.Hide()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
    End Sub
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles full_name.TextChanged

    End Sub

    Private Sub Guna2HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ControlBox3_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        OpenFileDialog1.Filter = "All files(*.*)|*.*|Png Files(*.png)|*.png|Jpg Files(*.jpg)|*.jpg"
        If (OpenFileDialog1.ShowDialog = DialogResult.OK
        ) Then
            picture.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        cmd = New OleDbCommand("SELECT * FROM [user] WHERE email=@Email and phoneNumber=@number", con)
        cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Email.Text
        cmd.Parameters.Add("@number", OleDbType.VarChar).Value = number.Text
        Dim adtp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        adtp.Fill(table)
        If (table.Rows.Count > 0) Then
            MsgBox("Email and Phone number already used")
            username.Clear()
            full_name.Clear()
            number.Clear()
            pass.Clear()
            address.Clear()
            con_pass.Clear()
        Else
            Dim databaseobject As databaseproject = New databaseproject
            Dim fullname As String = full_name.Text
            Dim email1 As String = Email.Text
            Dim phoneNumber As String = number.Text
            Dim photo As String = picture.Text
            Dim uname As String = username.Text
            Dim address1 As String = address.Text
            Dim password As String = pass.Text
            Dim date1 As String = dateofbirth.Text
            Dim report As DataSet = New DataSet
            report = databaseobject.Insert(fullname, email1, gendervalue, phoneNumber, photo, uname, address1, password, date1)
        End If
        'DGVStudent.DataSource = report.Tables(0)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub male_btn_CheckedChanged(sender As Object, e As EventArgs) Handles male_btn.CheckedChanged
        gendervalue = "Male"
    End Sub

    Private Sub female_btn_CheckedChanged(sender As Object, e As EventArgs) Handles female_btn.CheckedChanged
        gendervalue = "Female"

    End Sub

    Private Sub picture_Click(sender As Object, e As EventArgs) Handles picture.Click
        picture.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub
End Class