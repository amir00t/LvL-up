<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustom
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
        Me.NameS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.URL = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Apply = New System.Windows.Forms.Button()
        Me.Middle = New System.Windows.Forms.RadioButton()
        Me.Bottom = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameS
        '
        Me.NameS.Location = New System.Drawing.Point(15, 25)
        Me.NameS.Name = "NameS"
        Me.NameS.Size = New System.Drawing.Size(312, 20)
        Me.NameS.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name of the shortcut (NOTE THIS TO UNINSTALL MANUALLY)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The URL (with http:// or https://)"
        '
        'URL
        '
        Me.URL.Location = New System.Drawing.Point(15, 83)
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(312, 20)
        Me.URL.TabIndex = 3
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(15, 155)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Apply
        '
        Me.Apply.Location = New System.Drawing.Point(252, 155)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(75, 23)
        Me.Apply.TabIndex = 5
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'Middle
        '
        Me.Middle.AutoSize = True
        Me.Middle.Location = New System.Drawing.Point(15, 132)
        Me.Middle.Name = "Middle"
        Me.Middle.Size = New System.Drawing.Size(56, 17)
        Me.Middle.TabIndex = 6
        Me.Middle.TabStop = True
        Me.Middle.Text = "Middle"
        Me.Middle.UseVisualStyleBackColor = True
        '
        'Bottom
        '
        Me.Bottom.AutoSize = True
        Me.Bottom.Location = New System.Drawing.Point(118, 132)
        Me.Bottom.Name = "Bottom"
        Me.Bottom.Size = New System.Drawing.Size(58, 17)
        Me.Bottom.TabIndex = 7
        Me.Bottom.TabStop = True
        Me.Bottom.Text = "Bottom"
        Me.Bottom.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Position"
        '
        'FormCustom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 187)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Bottom)
        Me.Controls.Add(Me.Middle)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameS)
        Me.Name = "FormCustom"
        Me.ShowIcon = False
        Me.Text = "Custom (URLs)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents URL As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents Apply As Button
    Friend WithEvents Middle As RadioButton
    Friend WithEvents Bottom As RadioButton
    Friend WithEvents Label3 As Label
End Class
