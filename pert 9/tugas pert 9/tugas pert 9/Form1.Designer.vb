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
        cmb_jurusan_array = New ComboBox()
        cmb_kelas_array = New ComboBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        cmb_kelas_non_array = New ComboBox()
        cmb_jurusan_non_array = New ComboBox()
        SuspendLayout()
        ' 
        ' cmb_jurusan_array
        ' 
        cmb_jurusan_array.FormattingEnabled = True
        cmb_jurusan_array.Items.AddRange(New Object() {"SI", "TI", "TEKIN"})
        cmb_jurusan_array.Location = New Point(43, 102)
        cmb_jurusan_array.Name = "cmb_jurusan_array"
        cmb_jurusan_array.Size = New Size(158, 23)
        cmb_jurusan_array.TabIndex = 0
        ' 
        ' cmb_kelas_array
        ' 
        cmb_kelas_array.FormattingEnabled = True
        cmb_kelas_array.Location = New Point(43, 195)
        cmb_kelas_array.Name = "cmb_kelas_array"
        cmb_kelas_array.Size = New Size(158, 23)
        cmb_kelas_array.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(43, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 37)
        Label1.TabIndex = 2
        Label1.Text = "Array"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(43, 148)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Proses"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(406, 148)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Proses"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(406, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 37)
        Label2.TabIndex = 6
        Label2.Text = "Non-Array"
        ' 
        ' cmb_kelas_non_array
        ' 
        cmb_kelas_non_array.FormattingEnabled = True
        cmb_kelas_non_array.Location = New Point(406, 195)
        cmb_kelas_non_array.Name = "cmb_kelas_non_array"
        cmb_kelas_non_array.Size = New Size(158, 23)
        cmb_kelas_non_array.TabIndex = 5
        ' 
        ' cmb_jurusan_non_array
        ' 
        cmb_jurusan_non_array.FormattingEnabled = True
        cmb_jurusan_non_array.Items.AddRange(New Object() {"SI", "TI", "TEKIN"})
        cmb_jurusan_non_array.Location = New Point(406, 102)
        cmb_jurusan_non_array.Name = "cmb_jurusan_non_array"
        cmb_jurusan_non_array.Size = New Size(158, 23)
        cmb_jurusan_non_array.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(cmb_kelas_non_array)
        Controls.Add(cmb_jurusan_non_array)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(cmb_kelas_array)
        Controls.Add(cmb_jurusan_array)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmb_jurusan_array As ComboBox
    Friend WithEvents cmb_kelas_array As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_kelas_non_array As ComboBox
    Friend WithEvents cmb_jurusan_non_array As ComboBox
End Class
