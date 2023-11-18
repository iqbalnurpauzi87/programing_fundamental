Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim opsi, nama As String

    Public jam_kerja, jam_lembur, tidak_hadir As Double
    Public gaji_pokok, hasil, upah_jam_kerja, upah_jam_lembur, upah_uang_makan, potongan_alpa As Integer
    Dim kelasA() As String = {"adi", "adea", "adel", "adudu", "adit", "agus", "Asiah", "arif", "Afif", "atutu"}
    Dim kelasB() As String = {"bagas", "bagus", "bayu", "badru", "banyu", "baggus", "bharka", "banri", "badar", "barac"}
    Dim kelasC() As String = {"cailah", "cala", "cacing", "calida", "chandra", "cinta", "cantik", "cindy", "cantara", "carme"}


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("B")
        ComboBox1.Items.Add("C")
    End Sub



    Private Sub Button_hitung_Click(sender As Object, e As EventArgs) Handles Button_hitung.Click

        jam_kerja = Val(in_jam_kerja.Text)
        jam_lembur = Val(in_jam_lembur.Text)
        tidak_hadir = Val(in_jumlah_alpa.Text)

        upah_jam_kerja = 15000
        upah_jam_lembur = 10000
        upah_uang_makan = 10000
        potongan_alpa = -100000



        If opsi = "A" Then
            gaji_pokok = 6500000
        ElseIf opsi = "B" Then
            gaji_pokok = 4500000
        ElseIf opsi = "C" Then
            gaji_pokok = 3000000
        End If

        hasil = gaji_pokok + (jam_kerja * upah_jam_kerja) + (jam_lembur * upah_jam_lembur) + (tidak_hadir * potongan_alpa) + (jam_kerja * upah_uang_makan)

        ListBox2.Items.Clear()
        ListBox2.Items.Add("Nama : " & Me.ListBox1.SelectedItem)
        ListBox2.Items.Add("kelas : " & opsi)
        ListBox2.Items.Add("Gaji pokok : " & gaji_pokok)
        ListBox2.Items.Add("upah jam kerja : " & jam_kerja & " x " & upah_jam_kerja & " = " & (jam_kerja * upah_jam_kerja))
        ListBox2.Items.Add("upah lembur : " & jam_lembur & " x " & upah_jam_lembur & " = " & (jam_lembur * upah_jam_lembur))
        ListBox2.Items.Add("upah uang makan : " & jam_kerja & " x " & upah_uang_makan & " = " & (jam_kerja * upah_uang_makan))
        ListBox2.Items.Add("potongan alpa : " & tidak_hadir & " x " & potongan_alpa & " = " & (tidak_hadir * potongan_alpa))
        ListBox2.Items.Add("Total Gaji : " & hasil)


    End Sub


    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        If ComboBox1.Text = "A" Then
            opsi = "A"
            ListBox1.Items.Clear()
            For i = 0 To 9
                ListBox1.Items.Add(kelasA(i))
            Next
        ElseIf ComboBox1.Text = "B" Then
            opsi = "B"
            ListBox1.Items.Clear()
            For i = 0 To 9
                ListBox1.Items.Add(kelasB(i))
            Next
        ElseIf ComboBox1.Text = "C" Then
            opsi = "C"
            ListBox1.Items.Clear()
            For i = 0 To 9
                ListBox1.Items.Add(kelasB(i))
            Next
        End If
    End Sub
End Class
