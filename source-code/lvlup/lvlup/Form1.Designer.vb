<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Uninstall = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Custom = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMD = New System.Windows.Forms.RadioButton()
        Me.REGEDIT = New System.Windows.Forms.RadioButton()
        Me.Settings = New System.Windows.Forms.RadioButton()
        Me.MoveTo = New System.Windows.Forms.RadioButton()
        Me.CopyTo = New System.Windows.Forms.RadioButton()
        Me.Middle = New System.Windows.Forms.CheckBox()
        Me.Bottom = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LvL up"
        '
        'Apply
        '
        Me.Apply.Location = New System.Drawing.Point(309, 261)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(75, 23)
        Me.Apply.TabIndex = 8
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(12, 261)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Use this tool to install certain regedit.exe-Tweaks"
        '
        'Uninstall
        '
        Me.Uninstall.Location = New System.Drawing.Point(147, 261)
        Me.Uninstall.Name = "Uninstall"
        Me.Uninstall.Size = New System.Drawing.Size(75, 23)
        Me.Uninstall.TabIndex = 11
        Me.Uninstall.Text = "Uninstall"
        Me.Uninstall.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Every tweak is described on github and in the README"
        '
        'Custom
        '
        Me.Custom.Location = New System.Drawing.Point(228, 261)
        Me.Custom.Name = "Custom"
        Me.Custom.Size = New System.Drawing.Size(75, 23)
        Me.Custom.TabIndex = 13
        Me.Custom.Text = "Custom..."
        Me.Custom.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Position of the Shortcut (choose only one)"
        '
        'CMD
        '
        Me.CMD.AutoSize = True
        Me.CMD.Location = New System.Drawing.Point(12, 60)
        Me.CMD.Name = "CMD"
        Me.CMD.Size = New System.Drawing.Size(55, 20)
        Me.CMD.TabIndex = 17
        Me.CMD.TabStop = True
        Me.CMD.Text = "CMD"
        Me.CMD.UseVisualStyleBackColor = True
        '
        'REGEDIT
        '
        Me.REGEDIT.AutoSize = True
        Me.REGEDIT.Location = New System.Drawing.Point(12, 86)
        Me.REGEDIT.Name = "REGEDIT"
        Me.REGEDIT.Size = New System.Drawing.Size(82, 20)
        Me.REGEDIT.TabIndex = 18
        Me.REGEDIT.TabStop = True
        Me.REGEDIT.Text = "REGEDIT"
        Me.REGEDIT.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.Location = New System.Drawing.Point(12, 112)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(209, 20)
        Me.Settings.TabIndex = 19
        Me.Settings.TabStop = True
        Me.Settings.Text = "Settings (Win10 recommended)"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'MoveTo
        '
        Me.MoveTo.AutoSize = True
        Me.MoveTo.Location = New System.Drawing.Point(12, 138)
        Me.MoveTo.Name = "MoveTo"
        Me.MoveTo.Size = New System.Drawing.Size(83, 20)
        Me.MoveTo.TabIndex = 20
        Me.MoveTo.TabStop = True
        Me.MoveTo.Text = "Move to..."
        Me.MoveTo.UseVisualStyleBackColor = True
        '
        'CopyTo
        '
        Me.CopyTo.AutoSize = True
        Me.CopyTo.Location = New System.Drawing.Point(12, 164)
        Me.CopyTo.Name = "CopyTo"
        Me.CopyTo.Size = New System.Drawing.Size(83, 20)
        Me.CopyTo.TabIndex = 21
        Me.CopyTo.TabStop = True
        Me.CopyTo.Text = "Copy to..."
        Me.CopyTo.UseVisualStyleBackColor = True
        '
        'Middle
        '
        Me.Middle.AutoSize = True
        Me.Middle.Location = New System.Drawing.Point(12, 209)
        Me.Middle.Name = "Middle"
        Me.Middle.Size = New System.Drawing.Size(65, 20)
        Me.Middle.TabIndex = 22
        Me.Middle.Text = "Middle"
        Me.Middle.UseVisualStyleBackColor = True
        '
        'Bottom
        '
        Me.Bottom.AutoSize = True
        Me.Bottom.Location = New System.Drawing.Point(12, 235)
        Me.Bottom.Name = "Bottom"
        Me.Bottom.Size = New System.Drawing.Size(69, 20)
        Me.Bottom.TabIndex = 23
        Me.Bottom.Text = "Bottom"
        Me.Bottom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(393, 289)
        Me.Controls.Add(Me.Bottom)
        Me.Controls.Add(Me.Middle)
        Me.Controls.Add(Me.CopyTo)
        Me.Controls.Add(Me.MoveTo)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.REGEDIT)
        Me.Controls.Add(Me.CMD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Custom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Uninstall)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "LvL up your registry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Apply As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Uninstall As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Custom As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CMD As RadioButton
    Friend WithEvents REGEDIT As RadioButton
    Friend WithEvents Settings As RadioButton
    Friend WithEvents MoveTo As RadioButton
    Friend WithEvents CopyTo As RadioButton
    Friend WithEvents Middle As CheckBox
    Friend WithEvents Bottom As CheckBox
End Class
