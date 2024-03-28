Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        With profile
            .TopLevel = False
            panel1.Controls.Add(profile)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        With contact
            .TopLevel = False
            panel1.Controls.Add(contact)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        With Group
            .TopLevel = False
            panel1.Controls.Add(Group)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        With email
            .TopLevel = False
            panel1.Controls.Add(email)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        With setting
            .TopLevel = False
            panel1.Controls.Add(setting)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Guna2ControlBox3_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
        contact_management_system.Show()
    End Sub
End Class