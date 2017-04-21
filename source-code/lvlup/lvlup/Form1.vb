Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Dim BoM As String = "Not defined"
        If Middle.Checked Then
            BoM = "Middle"
        ElseIf Bottom.Checked Then
            BoM = "Bottom"
        ElseIf BoM = "Not defined" Then
            MessageBox.Show("Choose a Position")
        End If
        If CMD.Checked Then
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\cmd")
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\cmd\command")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd", True).SetValue("", "@shell32.dll,-8506")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd\command", True).SetValue("", "cmd.exe")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd", True).SetValue("icon", "cmd.exe")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd", True).SetValue("Postion", BoM)
        ElseIf REGEDIT.Checked Then
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\regedit")
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\regedit\command")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit", True).SetValue("", "@shell32.dll")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit\command", True).SetValue("", "regedit.exe")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit", True).SetValue("icon", "regedit.exe")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit", True).SetValue("Position", BoM)
        ElseIf Settings.Checked Then
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\Settings")
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\Settings\command")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings", True).SetValue("", "@shell32.dll, -4161")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings", True).SetValue("icon", "control.exe")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings", True).SetValue("Position", BoM)
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings\command", True).SetValue("", "Control.exe")
        ElseIf MoveTo.Checked Then
            My.Computer.Registry.ClassesRoot.CreateSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\moveto")
            My.Computer.Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\moveto", True).SetValue("", "{c2fbb631-2971-11d1-a18c-00c04fd75d13}")
        ElseIf CopyTo.Checked Then
            My.Computer.Registry.ClassesRoot.CreateSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\copyto")
            My.Computer.Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\copyto", True).SetValue("", "{c2fbb630-2971-11d1-a18c-00c04fd75d13}")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Uninstall.Click
        Dim name As String = "Not defined"
        Dim ninstalled As String = " isn't installed"
        Dim uninstalled As String = " was uninstalled"
        If CMD.Checked Then
            name = "CMD"
        ElseIf REGEDIT.Checked Then
            name = "REGEDIT"
        ElseIf Settings.Checked Then
            name = "Settings"
        ElseIf MoveTo.Checked Then
            name = "Move To..."
        ElseIf CopyTo.Checked Then
            name = "Copy To..."
        ElseIf name = "Not defined" Then
            MessageBox.Show("Nothing selected!")
        End If
        If CMD.Checked Then
            If My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\cmd", "", Nothing) Then
                MessageBox.Show(name + ninstalled)
            ElseIf My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\cmd", "", "@shell32.dll,-8506") Then
                My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\cmd")
                MessageBox.Show(name + uninstalled)
            ElseIf REGEDIT.Checked Then
                If My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\regedit", "", Nothing) Then
                    MessageBox.Show(name + ninstalled)
                ElseIf My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\regedit", "", "@shell32.dll") Then
                    My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\regedit")
                    MessageBox.Show(name + uninstalled)
                ElseIf Settings.Checked Then
                    If My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\Settings", "", Nothing) Then
                        MessageBox.Show(name + ninstalled)
                    ElseIf My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\Settings", "", "@shell32.dll, -4161") Then
                        My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\Settings")
                        MessageBox.Show(name + uninstalled)
                    ElseIf MoveTo.Checked Then
                        If My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\moveto", "", Nothing) Then
                            MessageBox.Show(name + ninstalled)
                        ElseIf My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\moveto", "", "{c2fbb631-2971-11d1-a18c-00c04fd75d13}") Then
                            My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\moveto")
                            MessageBox.Show(name + uninstalled)
                        ElseIf My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\copyto", "", Nothing) Then
                            MessageBox.Show(name + uninstalled)
                        ElseIf My.Computer.Registry.ClassesRoot.GetValue("DesktopBackground\Shell\copyto", "", "{c2fbb630-2971-11d1-a18c-00c04fd75d13}") Then
                            My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\copyto")
                            MessageBox.Show(name + uninstalled)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Custom.Click
        FormCustom.Show()
    End Sub
End Class
