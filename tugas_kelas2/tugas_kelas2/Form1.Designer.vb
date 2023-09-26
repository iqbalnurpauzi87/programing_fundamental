<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.in_kunci = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.out_hasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'in_kunci
        '
        Me.in_kunci.Location = New System.Drawing.Point(123, 49)
        Me.in_kunci.Name = "in_kunci"
        Me.in_kunci.Size = New System.Drawing.Size(147, 20)
        Me.in_kunci.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'out_hasil
        '
        Me.out_hasil.Location = New System.Drawing.Point(123, 131)
        Me.out_hasil.Name = "out_hasil"
        Me.out_hasil.Size = New System.Drawing.Size(147, 20)
        Me.out_hasil.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "kunci"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 402)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.out_hasil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.in_kunci)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents in_kunci As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents out_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
