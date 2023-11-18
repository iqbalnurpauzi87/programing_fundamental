Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim looping As Integer

        looping = Val(in_looping.Text)
        Me.ListBox1.Items.Clear()

        For i = 1 To looping
            If i Mod 2 Then
                Me.ListBox1.Items.Add(" Ganjil " & i & i)

            Else
                Me.ListBox1.Items.Add(i & " Genap " & i)

            End If
        Next
    End Sub
End Class
