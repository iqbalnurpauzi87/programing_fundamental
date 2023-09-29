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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.in_jamkerja = New System.Windows.Forms.TextBox()
        Me.in_jamlembur = New System.Windows.Forms.TextBox()
        Me.in_jumlahtidakhadir = New System.Windows.Forms.TextBox()
        Me.out_gaji = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gaji Karyawan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"manager", "wakil manager", "kepala sub bagian", "HRD"})
        Me.ComboBox1.Location = New System.Drawing.Point(177, 181)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Jam Kerja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jumlah Lembur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jumlah tidak hadir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jabatan"
        '
        'in_jamkerja
        '
        Me.in_jamkerja.Location = New System.Drawing.Point(177, 58)
        Me.in_jamkerja.Name = "in_jamkerja"
        Me.in_jamkerja.Size = New System.Drawing.Size(110, 20)
        Me.in_jamkerja.TabIndex = 10
        '
        'in_jamlembur
        '
        Me.in_jamlembur.Location = New System.Drawing.Point(177, 95)
        Me.in_jamlembur.Name = "in_jamlembur"
        Me.in_jamlembur.Size = New System.Drawing.Size(110, 20)
        Me.in_jamlembur.TabIndex = 11
        '
        'in_jumlahtidakhadir
        '
        Me.in_jumlahtidakhadir.Location = New System.Drawing.Point(177, 137)
        Me.in_jumlahtidakhadir.Name = "in_jumlahtidakhadir"
        Me.in_jumlahtidakhadir.Size = New System.Drawing.Size(110, 20)
        Me.in_jumlahtidakhadir.TabIndex = 12
        '
        'out_gaji
        '
        Me.out_gaji.Location = New System.Drawing.Point(177, 232)
        Me.out_gaji.Name = "out_gaji"
        Me.out_gaji.Size = New System.Drawing.Size(110, 20)
        Me.out_gaji.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Gajian"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 353)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.out_gaji)
        Me.Controls.Add(Me.in_jumlahtidakhadir)
        Me.Controls.Add(Me.in_jamlembur)
        Me.Controls.Add(Me.in_jamkerja)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents in_jamkerja As System.Windows.Forms.TextBox
    Friend WithEvents in_jamlembur As System.Windows.Forms.TextBox
    Friend WithEvents in_jumlahtidakhadir As System.Windows.Forms.TextBox
    Friend WithEvents out_gaji As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
