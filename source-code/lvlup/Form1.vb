Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BoM As String = "Not defined"
        If RadioButton1.Checked Then
            BoM = "Middle"
        Else
            If RadioButton2.Checked Then
                BoM = "Bottom"
            Else
                If BoM = "Not defined" Then
                    MessageBox.Show("Choose a Position")
                End If
            End If
            End If
        If CheckBox1.Checked Then
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\cmd")
            My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\cmd\command")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd", True).SetValue("", "@shell32.dll,-8506")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd\command", True).SetValue("", "cmd.exe")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd", True).SetValue("icon", "cmd.exe")
            My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\cmd", True).SetValue("Postion", BoM)
        Else
            If CheckBox2.Checked Then
                My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\regedit")
                My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\regedit\command")
                My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit", True).SetValue("", "@shell32.dll")
                My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit\command", True).SetValue("", "regedit.exe")
                My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit", True).SetValue("icon", "regedit.exe")
                My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\regedit", True).SetValue("Position", BoM)
            Else
                If CheckBox3.Checked Then
                    My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\Settings")
                    My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\Settings\command")
                    My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings", True).SetValue("", "@shell32.dll, -4161")
                    My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings", True).SetValue("icon", "control.exe")
                    My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings", True).SetValue("Position", BoM)
                    My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\Settings\command", True).SetValue("", "Control.exe")
                Else
                    If CheckBox4.Checked Then
                        My.Computer.Registry.ClassesRoot.CreateSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\moveto")
                        My.Computer.Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\moveto", True).SetValue("", "{c2fbb631-2971-11d1-a18c-00c04fd75d13}")
                    Else
                        If CheckBox5.Checked Then
                            My.Computer.Registry.ClassesRoot.CreateSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\copyto")
                            My.Computer.Registry.ClassesRoot.OpenSubKey("AllFilesystemObjects\shellex\ContextMenuHandlers\copyto", True).SetValue("", "{c2fbb630-2971-11d1-a18c-00c04fd75d13}")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox1.Checked Then
            My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\cmd")
        Else
            If CheckBox2.Checked Then
                My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\regedit")
            Else
                If CheckBox3.Checked Then
                    My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("DesktopBackground\Shell\Settings")
                Else
                    If CheckBox4.Checked Then
                        My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\shellex\ContextMenuHandlers\moveto")
                    Else
                        If CheckBox5.Checked Then
                            My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\shellex\ContextMenuHandlers\copyto")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormCustom.Show()
    End Sub
End Class
