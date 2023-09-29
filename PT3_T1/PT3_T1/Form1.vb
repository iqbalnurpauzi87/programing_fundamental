Public Class Form1

    Private Sub RUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RUN.Click
        Dim tugas, quis, uts, uas, uas_akhir, bonus, hasil As Double
        tugas = Val(in_tugas.Text * 0.2)
        quis = Val(in_quis.Text * 0.15)
        uts = Val(in_uts.Text * 0.3)
        uas = Val(in_uas.Text)

        If uas >= 80 Then
            bonus = 6
        ElseIf uas >= 70 Then
            bonus = 4
        ElseIf uas >= 66 Then
            bonus = 2
        Else
            bonus = 0
        End If

        uas_akhir = uas * 0.35

        hasil = uas_akhir + uts + quis + tugas + bonus

        out_hasil.Text = hasil




    End Sub

End Class
