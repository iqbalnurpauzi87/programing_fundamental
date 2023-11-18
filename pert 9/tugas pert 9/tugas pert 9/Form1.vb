Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arrkelas = {
            {"SI", "A"},
            {"SI", "B"},
            {"SI", "C"},
            {"SI", "D"},
            {"TI", "A"},
            {"TI", "B"},
            {"TEKIN", "A"},
            {"TEKIN", "B"}
        }

        Dim prodi As String

        prodi = cmb_jurusan_array.Text
        cmb_kelas_array.Items.Clear()

        For i = 0 To arrkelas.GetUpperBound(0)
            If prodi = arrkelas(i, 0) Then
                cmb_kelas_array.Items.Add(arrkelas(i, 1))
            End If
        Next

    End Sub

    Private Sub cmb_jurusan_array_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jurusan_array.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prodi As String

        prodi = cmb_jurusan_non_array.Text
        cmb_jurusan_non_array.Items.Clear()
        If prodi = "SI" Then
            cmb_kelas_non_array.Items.Add("A")
            cmb_kelas_non_array.Items.Add("B")
            cmb_kelas_non_array.Items.Add("C")
            cmb_kelas_non_array.Items.Add("D")

        ElseIf prodi = "TI" Then
            cmb_kelas_non_array.Items.Add("A")
            cmb_kelas_non_array.Items.Add("B")
        ElseIf prodi = "TEKIN" Then
            cmb_kelas_non_array.Items.Add("A")
            cmb_kelas_non_array.Items.Add("B")
        End If

    End Sub
End Class
