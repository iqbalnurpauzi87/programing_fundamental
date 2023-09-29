Public Class Form1
    Dim status_jabatan As String
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim jam_kerja, uang_jam_kerja, lembur, uang_lembur, alfa, potong_alfa, uang_makan, gaji_pokok, gaji As Double


        jam_kerja = Val(in_jamkerja.Text)
        lembur = Val(in_jamlembur.Text)
        alfa = Val(in_jumlahtidakhadir.Text)

        uang_makan = jam_kerja * 10000
        uang_jam_kerja = jam_kerja * 15000
        uang_lembur = lembur * 10000
        potong_alfa = alfa * 10000


        status_jabatan = ComboBox1.Text
        If status_jabatan = "manager" Then
            gaji_pokok = 6500000
            gaji = gaji_pokok + uang_jam_kerja + uang_lembur + uang_makan - potong_alfa
            out_gaji.Text = gaji
        ElseIf status_jabatan = "wakil manager" Then
            gaji_pokok = 4500000
            gaji = gaji_pokok + uang_jam_kerja + uang_lembur + uang_makan - potong_alfa
            out_gaji.Text = gaji
        ElseIf status_jabatan = "kepala sub bagian" Then
            gaji_pokok = 3000000
            gaji = gaji_pokok + uang_jam_kerja + uang_lembur + uang_makan - potong_alfa
            out_gaji.Text = gaji
        ElseIf status_jabatan = "HRD" Then
            gaji_pokok = 2000000
            gaji = gaji_pokok + uang_jam_kerja + uang_lembur + uang_makan - potong_alfa
            out_gaji.Text = gaji


        End If

    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
