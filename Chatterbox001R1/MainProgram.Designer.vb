<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainProgram
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainProgram))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutChatterboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtsend1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectTo5757ChatterboxV004UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectTo44444ChatterboxV003BelowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.AboutChatterboxToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem})
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.InformationToolStripMenuItem.Text = "Menu"
        '
        'AboutChatterboxToolStripMenuItem
        '
        Me.AboutChatterboxToolStripMenuItem.Name = "AboutChatterboxToolStripMenuItem"
        Me.AboutChatterboxToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutChatterboxToolStripMenuItem.Text = "About Chatterbox"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(402, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 20)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Disconnect"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(14, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(497, 31)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Send Message"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtsend1
        '
        Me.txtsend1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsend1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsend1.ForeColor = System.Drawing.Color.Black
        Me.txtsend1.Location = New System.Drawing.Point(14, 94)
        Me.txtsend1.Name = "txtsend1"
        Me.txtsend1.Size = New System.Drawing.Size(497, 158)
        Me.txtsend1.TabIndex = 43
        Me.txtsend1.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 295)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(497, 176)
        Me.RichTextBox1.TabIndex = 41
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(402, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 20)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "IP Address:"
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(99, 63)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(297, 20)
        Me.txtip.TabIndex = 38
        Me.txtip.Text = "127.0.0.1"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(99, 32)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(412, 20)
        Me.txtusername.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nickname:"
        '
        'Timer1
        '
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectTo5757ChatterboxV004UpToolStripMenuItem, Me.ConnectTo44444ChatterboxV003BelowToolStripMenuItem})
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'ConnectTo5757ChatterboxV004UpToolStripMenuItem
        '
        Me.ConnectTo5757ChatterboxV004UpToolStripMenuItem.Name = "ConnectTo5757ChatterboxV004UpToolStripMenuItem"
        Me.ConnectTo5757ChatterboxV004UpToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.ConnectTo5757ChatterboxV004UpToolStripMenuItem.Text = "Connect to 5757 (Chatterbox v0.04 && Up)"
        '
        'ConnectTo44444ChatterboxV003BelowToolStripMenuItem
        '
        Me.ConnectTo44444ChatterboxV003BelowToolStripMenuItem.Name = "ConnectTo44444ChatterboxV003BelowToolStripMenuItem"
        Me.ConnectTo44444ChatterboxV003BelowToolStripMenuItem.Size = New System.Drawing.Size(313, 22)
        Me.ConnectTo44444ChatterboxV003BelowToolStripMenuItem.Text = "Connect to 44444 (Chatterbox v0.03 && Below)"
        '
        'MainProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 483)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtsend1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainProgram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chatterbox! ver 0.01 UP1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutChatterboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtsend1 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtip As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectTo5757ChatterboxV004UpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectTo44444ChatterboxV003BelowToolStripMenuItem As ToolStripMenuItem
End Class
