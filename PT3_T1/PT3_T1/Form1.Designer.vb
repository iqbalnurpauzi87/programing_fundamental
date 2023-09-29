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
        Me.x = New System.Windows.Forms.Label()
        Me.in_tugas = New System.Windows.Forms.TextBox()
        Me.in_quis = New System.Windows.Forms.TextBox()
        Me.in_uts = New System.Windows.Forms.TextBox()
        Me.in_uas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RUN = New System.Windows.Forms.Button()
        Me.out_hasil = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'x
        '
        Me.x.AutoSize = True
        Me.x.Location = New System.Drawing.Point(68, 55)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(74, 13)
        Me.x.TabIndex = 0
        Me.x.Text = "NILAI TUGAS"
        '
        'in_tugas
        '
        Me.in_tugas.Location = New System.Drawing.Point(152, 48)
        Me.in_tugas.Name = "in_tugas"
        Me.in_tugas.Size = New System.Drawing.Size(100, 20)
        Me.in_tugas.TabIndex = 1
        '
        'in_quis
        '
        Me.in_quis.Location = New System.Drawing.Point(152, 88)
        Me.in_quis.Name = "in_quis"
        Me.in_quis.Size = New System.Drawing.Size(100, 20)
        Me.in_quis.TabIndex = 2
        '
        'in_uts
        '
        Me.in_uts.Location = New System.Drawing.Point(152, 131)
        Me.in_uts.Name = "in_uts"
        Me.in_uts.Size = New System.Drawing.Size(100, 20)
        Me.in_uts.TabIndex = 3
        '
        'in_uas
        '
        Me.in_uas.Location = New System.Drawing.Point(152, 176)
        Me.in_uas.Name = "in_uas"
        Me.in_uas.Size = New System.Drawing.Size(100, 20)
        Me.in_uas.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NILAI QUIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NILAI UTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NILAI UAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NILAI*20%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "NILAI*15%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "NILAI*30%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "NILAI*35%"
        '
        'RUN
        '
        Me.RUN.Location = New System.Drawing.Point(159, 222)
        Me.RUN.Name = "RUN"
        Me.RUN.Size = New System.Drawing.Size(92, 28)
        Me.RUN.TabIndex = 12
        Me.RUN.Text = "Hitung"
        Me.RUN.UseVisualStyleBackColor = True
        '
        'out_hasil
        '
        Me.out_hasil.Location = New System.Drawing.Point(152, 271)
        Me.out_hasil.Name = "out_hasil"
        Me.out_hasil.Size = New System.Drawing.Size(96, 20)
        Me.out_hasil.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 39)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "jika nilai UAS>66 mendapat bonus 2, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "jika nilai UAS>70 mendapat bonus 4," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "jika n" & _
            "ilai UAS>80 mendapat bonus 6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 431)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.out_hasil)
        Me.Controls.Add(Me.RUN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.in_uas)
        Me.Controls.Add(Me.in_uts)
        Me.Controls.Add(Me.in_quis)
        Me.Controls.Add(Me.in_tugas)
        Me.Controls.Add(Me.x)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents x As System.Windows.Forms.Label
    Friend WithEvents in_tugas As System.Windows.Forms.TextBox
    Friend WithEvents in_quis As System.Windows.Forms.TextBox
    Friend WithEvents in_uts As System.Windows.Forms.TextBox
    Friend WithEvents in_uas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RUN As System.Windows.Forms.Button
    Friend WithEvents out_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
