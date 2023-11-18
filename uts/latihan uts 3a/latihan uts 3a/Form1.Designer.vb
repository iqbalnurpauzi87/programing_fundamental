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
        in_jam_kerja = New TextBox()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Label2 = New Label()
        in_jam_lembur = New TextBox()
        Label3 = New Label()
        in_jumlah_alpa = New TextBox()
        Button_hitung = New Button()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        ListBox2 = New ListBox()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' in_jam_kerja
        ' 
        in_jam_kerja.Location = New Point(73, 151)
        in_jam_kerja.Name = "in_jam_kerja"
        in_jam_kerja.Size = New Size(100, 23)
        in_jam_kerja.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 2
        Label1.Text = "jumlah jam kerja"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(230, 222)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(210, 94)
        ListBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 15)
        Label2.TabIndex = 5
        Label2.Text = "jumlah jam lembur"
        ' 
        ' in_jam_lembur
        ' 
        in_jam_lembur.Location = New Point(73, 222)
        in_jam_lembur.Name = "in_jam_lembur"
        in_jam_lembur.Size = New Size(100, 23)
        in_jam_lembur.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 266)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 7
        Label3.Text = "jumlah tidah hadir"
        ' 
        ' in_jumlah_alpa
        ' 
        in_jumlah_alpa.Location = New Point(73, 293)
        in_jumlah_alpa.Name = "in_jumlah_alpa"
        in_jumlah_alpa.Size = New Size(100, 23)
        in_jumlah_alpa.TabIndex = 6
        ' 
        ' Button_hitung
        ' 
        Button_hitung.Location = New Point(73, 344)
        Button_hitung.Name = "Button_hitung"
        Button_hitung.Size = New Size(75, 23)
        Button_hitung.TabIndex = 8
        Button_hitung.Text = "Hitung"
        Button_hitung.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(230, 151)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(231, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 10
        Label4.Text = "Pilih Kelas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(231, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 11
        Label5.Text = "Pilih nama"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(73, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(364, 65)
        Label6.TabIndex = 13
        Label6.Text = "PT. ABC ABADI"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(73, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(289, 25)
        Label7.TabIndex = 14
        Label7.Text = "hitung gaji karyawan anda disini"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(231, 344)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(250, 184)
        ListBox2.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(73, 551)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 25)
        Label8.TabIndex = 16
        Label8.Text = "jawaban no 11"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(651, 595)
        Controls.Add(Label8)
        Controls.Add(ListBox2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Button_hitung)
        Controls.Add(Label3)
        Controls.Add(in_jumlah_alpa)
        Controls.Add(Label2)
        Controls.Add(in_jam_lembur)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(in_jam_kerja)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents in_jam_kerja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents in_jam_lembur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents in_jumlah_alpa As TextBox
    Friend WithEvents Button_hitung As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label8 As Label
End Class
