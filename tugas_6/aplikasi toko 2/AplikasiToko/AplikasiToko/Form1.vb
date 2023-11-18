Public Class Form1

    Private Sub menu_file_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_file_logout.Click
        If MsgBox("Apakah anda ingin keluar dari aplikasi ini ? ", MsgBoxStyle.YesNo, "Pertanyaan ?") = MsgBoxResult.Yes Then
            menu_file_logout.Visible = False
            menu_file_login.Visible = True
            menu_file_keluar.Visible = True


            menu_file_about.Visible = False
            file_new.Visible = False
            file_open.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        menu_file_logout.Visible = False

        menu_file_about.Visible = False
        file_new.Visible = False
        file_open.Visible = False
    End Sub

    Private Sub menu_file_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_file_keluar.Click
        If MsgBox("Apakah anda ingin keluar dari aplikasi ini ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            menu_file_about.Visible = True
            file_new.Visible = True
            file_open.Visible = True
            End
        End If
    End Sub

    Private Sub menu_file_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_file_login.Click


        Form2.MdiParent = Me
        Form2.Show()

    End Sub

    Private Sub menu_file_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_file_about.Click
        Frm_About.MdiParent = Me
        Frm_About.Show()

    End Sub

    Private Sub menu_file_Click(sender As Object, e As EventArgs) Handles menu_file.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
