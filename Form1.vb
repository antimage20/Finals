Public Class frmLogin
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Application.Exit()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Length = 0 Or txtPassword.Text.Length = 0 Then

            If txtUsername.Text.Length = 0 And txtPassword.Text.Length = 0 Then
                ErrorProvider1.SetError(txtUsername, "Please Fill Username!")
                ErrorProvider1.SetError(txtPassword, "Please Fill Password!")
                MessageBox.Show("Please Fill Username & Password", "Empty Dialog",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf txtUsername.Text.Length = 0 Then
                ErrorProvider1.SetError(txtUsername, "Please Fill Username!")
                MessageBox.Show("Please Fill Username", "Empty Dialog",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txtPassword.Text.Length = 0 Then
                ErrorProvider1.SetError(txtPassword, "Please Fill Password!")
                MessageBox.Show("Please Fill Password", "Empty Dialog",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf txtUsername.Text.Length > 0 And txtPassword.Text.Length > 0 Then

            If txtUsername.Text = "Admin" And txtPassword.Text = "123456" Then
                MessageBox.Show("Login Successful!" & ControlChars.NewLine & "Hello Admin",
                                "Login Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtUsername.Text = ""
                txtPassword.Text = ""
                Me.Hide()
                MainForm.Show()

            ElseIf txtUsername.Text IsNot "Admin" And txtPassword.Text = "123456" Then

                MessageBox.Show("Wrong UserName!" & ControlChars.NewLine & "Please Type Again....",
                                "Login Dialog", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUsername.Text = ""

            ElseIf txtPassword.Text IsNot "123456" And txtUsername.Text = "Admin" Then

                MessageBox.Show("Wrong Password!" & ControlChars.NewLine & "Please Type Again....",
                                "Login Dialog", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Clear()

            Else
                MessageBox.Show("Wrong UsernName and Password!" & ControlChars.NewLine & "Login Unsuccessful! Please try again....",
                                "Login Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Clear()
                txtPassword.Clear()

            End If
        End If
        txtUsername.Focus()

    End Sub
End Class
