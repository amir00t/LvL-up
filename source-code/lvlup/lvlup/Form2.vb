Public Class FormCustom
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Dim DirExists As Boolean = Nothing
        If My.Computer.FileSystem.DirectoryExists("C:\ShortCut") Then
            DirExists = True
        End If
        If DirExists = False Then
            My.Computer.FileSystem.CreateDirectory("C:\ShortCut")
        End If
        Dim Position As String = "Not defined"
        If Middle.Checked Then
            Position = "Middle"
        Else
            If Bottom.Checked Then
                Position = "Bottom"
            End If
        End If
        Dim givenName As String = "Not defined"
        Dim givenURL As String = "Not defined"
        givenURL = URL.Text
        givenName = NameS.Text
        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("@echo off")
        sb.Append("start " + givenURL)
        IO.File.WriteAllText("C:\ShortCut\" + givenName + ".bat", sb.ToString())
        My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\" + givenName)
        My.Computer.Registry.ClassesRoot.CreateSubKey("DesktopBackground\Shell\" + givenName + "\command")
        My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\" + givenName, True).SetValue("", "@shell32.dll")
        My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\" + givenName + "\command", True).SetValue("", "C:\ShortCut\" + givenName + ".bat")
        My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\" + givenName, True).SetValue("icon", "explorer.exe")
        My.Computer.Registry.ClassesRoot.OpenSubKey("DesktopBackground\Shell\" + givenName, True).SetValue("Position", Position)
    End Sub
End Class