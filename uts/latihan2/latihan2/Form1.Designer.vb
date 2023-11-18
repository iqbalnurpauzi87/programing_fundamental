<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        in_looping = New TextBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Looping = New Label()
        SuspendLayout()
        ' 
        ' in_looping
        ' 
        in_looping.Location = New Point(148, 101)
        in_looping.Name = "in_looping"
        in_looping.Size = New Size(100, 23)
        in_looping.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(61, 152)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(288, 229)
        ListBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(274, 100)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Looping
        ' 
        Looping.AutoSize = True
        Looping.Location = New Point(61, 104)
        Looping.Name = "Looping"
        Looping.Size = New Size(51, 15)
        Looping.TabIndex = 3
        Looping.Text = "Looping"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(499, 450)
        Controls.Add(Looping)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(in_looping)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents in_looping As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Looping As Label
End Class
