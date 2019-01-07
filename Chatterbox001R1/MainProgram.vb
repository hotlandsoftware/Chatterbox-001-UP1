Imports System.Net.Sockets 'no longer using that winsock bullshit that faifls to run under 10 because 10 is a pile of monkey shit
Imports System.Threading
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Dns 'you'll see why

Public Class MainProgram
    Dim listener As New TcpListener(5757) '1-2-3-4 i declare a thumb war
    Dim listener2 As New TcpListener(44444) '1-2-3-4 i declare a thumb war
    Dim client As TcpClient
    Dim mysocket As Socket 'jim actually tried to use another 30 line method to define sockets.. what a faggot
    Dim message As String = ""
    Dim serveriplist As IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()) 'see jim? it actually had a purpose. you owe me a sandwich
    Dim nameip As String

    Private Sub MainProgram_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        listener.Stop()
        Form1.Close()
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        Changelog.Show()
    End Sub

    Private Sub AboutChatterboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutChatterboxToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = False
        txtsend1.Enabled = False
        Button1.Visible = True
        Button3.Visible = False
        Button2.Enabled = False
    End Sub

    Private Sub listening()
        listener.Start() 'lets start the listener for christs sake
    End Sub

    Private Sub listening2()
        listener.Start() 'lets start the listener for christs sake
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'error detections and validation

        Try

            If txtip.Text = "" Then
                MsgBox("There is nothing in the IP address box. Please enter an IP.")
                txtip.Focus()
                txtsend1.Enabled = False

            Else

                Dim listthread As New Thread(New ThreadStart(AddressOf listening))
                listthread.Start()

                Timer1.Enabled = True

                client = New TcpClient(txtip.Text, 5757)
                Dim writer As New StreamWriter(client.GetStream())

                writer.Write("[" & TimeOfDay & "] " & txtusername.Text & " has signed on.")
                writer.Flush()
                txtsend1.Enabled = True
                Button1.Visible = False
                Button2.Enabled = True
                Button3.Visible = True

            End If
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If listener.Pending = True Then ' lets set the listener port to continue listening for connections
            Message = "" 'blank it out
            client = listener.AcceptTcpClient() 'accept him for christs sake, who cares if he's LGBT?

            Dim reader As New StreamReader(client.GetStream())
            While reader.Peek > -1
                Message = Message + Convert.ToChar(reader.Read()).ToString
            End While

            RichTextBox1.Text = RichTextBox1.Text + Environment.NewLine + Message + vbCrLf 'lets display the text stored in the listening ports buffer

            RichTextBox1.SelectionStart = Len(RichTextBox1.Text)
            RichTextBox1.ScrollToCaret()

        Else : End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            client = New TcpClient(txtip.Text, 5757)
            Dim writer As New StreamWriter(client.GetStream())
            'save the message onto the client's listening socket buffer

            writer.Write(txtusername.Text & ":" & " " & txtsend1.Text)
            writer.Flush()

            RichTextBox1.Text += (txtusername.Text & ":" & " " & txtsend1.Text) + vbCrLf
            txtsend1.Clear()
            txtsend1.Focus()

        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        listener.Stop()
        Form1.Close()
    End Sub

    Private Sub ConnectTo5757ChatterboxV004UpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectTo5757ChatterboxV004UpToolStripMenuItem.Click
        Try

            If txtip.Text = "" Then
                MsgBox("There is nothing in the IP address box. Please enter an IP.")
                txtip.Focus()
                txtsend1.Enabled = False

            Else

                Dim listthread As New Thread(New ThreadStart(AddressOf listening))
                listthread.Start()

                Timer1.Enabled = True

                client = New TcpClient(txtip.Text, 5757)
                Dim writer As New StreamWriter(client.GetStream())

                writer.Write("[" & TimeOfDay & "] " & txtusername.Text & " has signed on.")
                writer.Flush()
                txtsend1.Enabled = True
                Button1.Visible = False
                Button2.Enabled = True
                Button3.Visible = True

            End If
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub ConnectTo44444ChatterboxV003BelowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectTo44444ChatterboxV003BelowToolStripMenuItem.Click
        Try

            If txtip.Text = "" Then
                MsgBox("There is nothing in the IP address box. Please enter an IP.")
                txtip.Focus()
                txtsend1.Enabled = False

            Else

                Dim listthread As New Thread(New ThreadStart(AddressOf listening))
                listthread.Start()

                Timer1.Enabled = True

                client = New TcpClient(txtip.Text, 44444)
                Dim writer As New StreamWriter(client.GetStream())

                writer.Write("[" & TimeOfDay & "] " & txtusername.Text & " has signed on.")
                writer.Flush()
                txtsend1.Enabled = True
                Button1.Visible = False
                Button2.Enabled = True
                Button3.Visible = True

            End If
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub
End Class