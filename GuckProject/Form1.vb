'This Application Made By: GuckTube YT
'Owner GTIT Private Server: iTavage
'Dont forget to Subscribe: GuckTube YT
'Also Dont forget to subscribe my friends
'Kocak Z
'Fakemodz
'Jacky Harmonis
'Poor GT
'My Discord: GuckTubeYT#8912
Imports System.Net
Imports System.IO


Public Class Form1
    'Turn ON
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Delete File
        My.Computer.FileSystem.DeleteFile("C:\Windows\System32\drivers\etc\hosts")
        'Update Message
        lblMsg.Text = "GTPS Is Turn ON"
        'Edit File
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Windows\System32\drivers\etc\hosts", True)
        file.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ")
        file.WriteLine("# ")
        file.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows. ")
        file.WriteLine("# ")
        file.WriteLine("# This file contains the mappings of IP addresses to host names. Each ")
        file.WriteLine("# entry should be kept on an individual line. The IP address should ")
        file.WriteLine("# be placed in the first column followed by the corresponding host name. ")
        file.WriteLine("# The IP address and the host name should be separated by at least one ")
        file.WriteLine("# space. ")
        file.WriteLine("# ")
        file.WriteLine("# Additionally, comments (such as these) may be inserted on individual ")
        file.WriteLine("# lines or following the machine name denoted by a '#' symbol. ")
        file.WriteLine("# ")
        file.WriteLine("# For example: ")
        file.WriteLine("# ")
        file.WriteLine("#      102.54.94.97     rhino.acme.com          # source server ")
        file.WriteLine("#       38.25.63.10     x.acme.com              # x client host ")
        file.WriteLine(" ")
        file.WriteLine("# localhost name resolution is handled within DNS itself. ")
        file.WriteLine("#      127.0.0.1       localhost ")
        file.WriteLine("#      ::1             localhost ")
        'You Can Change IP VPS
        file.WriteLine("YourIPVPS growtopia1.com")
        file.WriteLine("YourIPVPS growtopia2.com")
        file.Close()

    End Sub
    'Turn OFF
    'No need to change this
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Delete File
        My.Computer.FileSystem.DeleteFile("C:\Windows\System32\drivers\etc\hosts")
        'Updated Message
        lblMsg.Text = "GTPS Is Turn OFF"
        'Edit File
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Windows\System32\drivers\etc\hosts", True)
        file.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ")
        file.WriteLine("# ")
        file.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows. ")
        file.WriteLine("# ")
        file.WriteLine("# This file contains the mappings of IP addresses to host names. Each ")
        file.WriteLine("# entry should be kept on an individual line. The IP address should ")
        file.WriteLine("# be placed in the first column followed by the corresponding host name. ")
        file.WriteLine("# The IP address and the host name should be separated by at least one ")
        file.WriteLine("# space. ")
        file.WriteLine("# ")
        file.WriteLine("# Additionally, comments (such as these) may be inserted on individual ")
        file.WriteLine("# lines or following the machine name denoted by a '#' symbol. ")
        file.WriteLine("# ")
        file.WriteLine("# For example: ")
        file.WriteLine("# ")
        file.WriteLine("#      102.54.94.97     rhino.acme.com          # source server ")
        file.WriteLine("#       38.25.63.10     x.acme.com              # x client host ")
        file.WriteLine(" ")
        file.WriteLine("# localhost name resolution is handled within DNS itself. ")
        file.WriteLine("#      127.0.0.1       localhost ")
        file.WriteLine("#      ::1             localhost ")
        file.Close()
    End Sub
    'Check Status Server ON/OFF
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Using client = New System.Net.WebClient()
                'You can Change Google.com to anything
                'Example: www.bing.com
                Using Stream = client.OpenRead("http://www.google.com")
                    'No Need to change this
                    'If error, you can change this
                    Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "C:\Server\Status.txt"
                    If File.Exists("C:\Server\Status.txt") Then
                        My.Computer.FileSystem.DeleteFile("C:\Server\Status.txt")
                    End If
                    'You Can Change this
                    My.Computer.Network.DownloadFile("http://IPVPS/PATH/NAME.TXT", "C:\Server\Status.txt")
                    'No need to change this
                    'if error, you can change this
                    Dim Reader As New IO.StreamReader("C:\Server\Status.txt")
                    Dim FileContents As String = Reader.ReadToEnd
                    Reader.Close()

                    MessageBox.Show(FileContents) 'Not really neccesary, but just to see that we have the string

                    'Then do whatever you need to do with your string
                End Using
            End Using
        Catch
            MessageBox.Show("Your Internet Is Offline")
        End Try
    End Sub
    'Changelog, IDK This is will Useful or no
    'You can Delete Changelog by Delete Changelog Button
    'if you think it's useful, don't delete Changelog button
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Using client = New System.Net.WebClient()
                'You can Change Google.com to anything
                'Example: www.bing.com
                Using Stream = client.OpenRead("http://www.google.com")
                    'No Need to change this
                    'If error, you can change this
                    Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "C:\Server\Changelog.txt"
                    If File.Exists("C:\Server\Changelog.txt") Then
                        My.Computer.FileSystem.DeleteFile("C:\Server\Changelog.txt")
                    End If
                    'You Can Change this
                    My.Computer.Network.DownloadFile("http://IPVPS/PATH/NAME.TXT", "C:\Server\Changelog.txt")
                    'No Need to change this
                    'If error, you can change this
                    Dim Reader As New IO.StreamReader("C:\Server\Changelog.txt")
                    Dim FileContents As String = Reader.ReadToEnd
                    Reader.Close()

                    MessageBox.Show(FileContents) 'Not really neccesary, but just to see that we have the string

                    'Then do whatever you need to do with your string
                End Using
            End Using
        Catch
            MessageBox.Show("Your Internet Is Offline")
        End Try
    End Sub
End Class


