Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer

        For i = 1 To 10
            Me.ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer

        For i = 1 To 10
            Me.ListBox1.Items.Add(i * 2)
        Next
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer

        For i = 1 To 10 - 2
            Me.ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer

        For i = 1 To 10 Step 2
            Me.ListBox1.Items.Add(i)
        Next
    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As Integer

        For i = 10 To 1 Step -1
            Me.ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As Integer

        For i = 10 To 1 Step -3
            Me.ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim i As Integer

        For i = 1 To 10
            Me.ListBox1.Items.Add("Hasil " & i)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
