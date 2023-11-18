Public Class Form2

    Private Sub btn_login_Click(sender As System.Object, e As System.EventArgs) Handles btn_login.Click
        Dim username, password As String
        username = txt_username.Text()
        password = txt_password.Text()

        If username = "Iqbal_ganteng" And password = "iyabetul" Then
            Form1.menu_file_login.Visible = False
            Form1.menu_file_logout.Visible = True
            Form1.menu_file_keluar.Visible = False
            Form1.menu_file_about.Visible = True
            Form1.file_new.Visible = True
            Form1.file_open.Visible = True

            MsgBox("Anda Berhasil Login")

            Me.Close()
        Else
            MsgBox("Username atau Password Salah")
        End If

    End Sub
End Class