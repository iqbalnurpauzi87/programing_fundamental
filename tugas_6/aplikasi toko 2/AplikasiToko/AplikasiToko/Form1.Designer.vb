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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.file_open = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_file_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_file_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_file_keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_file_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_file, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_file
        '
        Me.menu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_file_about, Me.NewToolStripMenuItem, Me.file_new, Me.file_open, Me.ToolStripSeparator1, Me.menu_file_login, Me.menu_file_logout, Me.menu_file_keluar})
        Me.menu_file.Name = "menu_file"
        Me.menu_file.Size = New System.Drawing.Size(37, 20)
        Me.menu_file.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'file_new
        '
        Me.file_new.Name = "file_new"
        Me.file_new.Size = New System.Drawing.Size(184, 26)
        Me.file_new.Text = "new"
        '
        'file_open
        '
        Me.file_open.Name = "file_open"
        Me.file_open.Size = New System.Drawing.Size(184, 26)
        Me.file_open.Text = "open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'menu_file_login
        '
        Me.menu_file_login.Image = Global.AplikasiToko.My.Resources.Resources.favicon
        Me.menu_file_login.Name = "menu_file_login"
        Me.menu_file_login.Size = New System.Drawing.Size(184, 26)
        Me.menu_file_login.Text = "Login"
        '
        'menu_file_logout
        '
        Me.menu_file_logout.Image = Global.AplikasiToko.My.Resources.Resources._error
        Me.menu_file_logout.Name = "menu_file_logout"
        Me.menu_file_logout.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.menu_file_logout.Size = New System.Drawing.Size(184, 26)
        Me.menu_file_logout.Text = "Logout"
        '
        'menu_file_keluar
        '
        Me.menu_file_keluar.Name = "menu_file_keluar"
        Me.menu_file_keluar.Size = New System.Drawing.Size(184, 26)
        Me.menu_file_keluar.Text = "Keluar"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.UndoToolStripMenuItem.Text = "undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.RedoToolStripMenuItem.Text = "redo"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodeToolStripMenuItem, Me.DesignToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ViewToolStripMenuItem.Text = "view"
        '
        'CodeToolStripMenuItem
        '
        Me.CodeToolStripMenuItem.Name = "CodeToolStripMenuItem"
        Me.CodeToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CodeToolStripMenuItem.Text = "code"
        '
        'DesignToolStripMenuItem
        '
        Me.DesignToolStripMenuItem.Name = "DesignToolStripMenuItem"
        Me.DesignToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.DesignToolStripMenuItem.Text = "design"
        '
        'menu_file_about
        '
        Me.menu_file_about.Name = "menu_file_about"
        Me.menu_file_about.Size = New System.Drawing.Size(184, 26)
        Me.menu_file_about.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Toko Abadi Sejahtera"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menu_file_login As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_file_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_file_keluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents file_new As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_file_about As ToolStripMenuItem
End Class
