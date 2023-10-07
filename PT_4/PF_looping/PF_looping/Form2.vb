Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim j As Integer

        For i = 1 To 5
            For j = 1 To i
                Me.ListBox1.Items.Add(i & " - " & j)
            Next
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer

        For i = 1 To 8
            Me.ListBox1.Items.Add(i & " - " & i * 4 & " - " & i + 1)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer

        For i = 1 To 8
            Me.ListBox1.Items.Add(i & " - " & 12 & " - " & 12 - i)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i, j As Integer

        For i = 1 To 8
            j = i * 3
            If (i < 8) Then
                Me.ListBox1.Items.Add(i & " -  A->" & j & " - " & j)
            Else
                Me.ListBox1.Items.Add(i & " -  A->" & j & " -  BERHASIL")
            End If
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a, b, c, d As Integer
        For a = 1 To 7
            b += 7
            c += 3
            d += b
            Me.ListBox1.Items.Add(a & " - " & b & " - " & c)
            If (a = 7) Then
                Me.ListBox1.Items.Add(a & " -  A->" & d & " -  Berhasil")
            End If

        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a, b, c, d As Integer

        For a = 1 To 8

            If a Mod 2 Then
                Me.ListBox1.Items.Add("Ganjil - " & a & " - " & a)
            Else

                Me.ListBox1.Items.Add(a & " - Genap - " & a)
            End If
            b += 7
            c += 3
            d += b
            If (a = 7) Then
                Me.ListBox1.Items.Add(a & " -  A->" & d & " -  Berhasil")
            End If

        Next

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim a, b, c, d As Integer

        b = 9
        For a = 1 To 8
            b -= 1
            Me.ListBox1.Items.Add(b & " - " & b - a & " - " & a)
        Next
    End Sub
End Class