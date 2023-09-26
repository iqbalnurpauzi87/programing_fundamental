Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim kunci, hasil As String

        kunci = in_kunci.Text

        If kunci = "kopi luak kopi" Then
            hasil = "kunci benar"
        Else
            hasil = "kunci salah"
        End If

        out_hasil.Text = hasil





    End Sub
End Class
