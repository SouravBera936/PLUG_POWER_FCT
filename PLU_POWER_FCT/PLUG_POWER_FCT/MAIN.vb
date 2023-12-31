﻿Imports MadMilkman.Ini
Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Imports Ivi.Visa.Interop
Public Class MAIN
    Dim StopWatch As New Diagnostics.Stopwatch
    Dim productversion = Application.ProductVersion.ToString
    Dim ini As New IniFile
    Dim ini1 As New IniFile
    Dim cn As OleDb.OleDbConnection
    Dim oleCommand As OleDbCommand
    Dim pcname = System.Net.Dns.GetHostName
    Dim file As System.IO.StreamWriter
    Dim Power_Port As String = CONFIG.TextBox31.Text.ToString
    Dim Power_iomgr As New Ivi.Visa.Interop.ResourceManager
    Dim Power_instrany As New Ivi.Visa.Interop.FormattedIO488
    Dim Uniflash_Port = CONFIG.TextBox34.Text.ToString

    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Visible = False
        CheckBox1.Checked = False
        StartTimer3.Visible = False
        StopTimer.Visible = False
        ResetTimer.Visible = False
        Timer2.Enabled = True
        Me.StopWatch.Reset()
        TextBox5.Text = "00:00:00:000"
        TextBox5.Enabled = False
        Label10.Text = pcname
        Label3.Text = productversion
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        LOGINToolStripMenuItem.Enabled = True
        LOGOUTToolStripMenuItem.Enabled = False
        EXITToolStripMenuItem.Enabled = True
        CREATEUSERToolStripMenuItem.Enabled = False
        REMOVEUSERToolStripMenuItem.Enabled = False
        CHANGEPASSWORDToolStripMenuItem.Enabled = False
        FIRSTPASSYIELDToolStripMenuItem.Enabled = False
        FINALPASSYIELDToolStripMenuItem.Enabled = False
        ConfrigurationsToolStripMenuItem.Enabled = False
        ABOUTSOFTWAREToolStripMenuItem.Enabled = False
        HELPToolStripMenuItem.Enabled = False
        SETUPToolStripMenuItem.Enabled = False
        UPDATEDESIGNATIONToolStripMenuItem.Enabled = False
        Label10.Visible = False
        Label11.Visible = False
        Label10.Enabled = False
        Label11.Enabled = False
        Label12.Visible = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        Dim iret As Object = MsgBox("CONFRIGURING SYSTEM VARIABES AND DETAILS PLEASE SAVE AND CLOSE ALL THE WORKS.", vbInformation + vbOKOnly, "WARNING")
        If iret = vbOK Then
            Try
                ini1.Load("D:\DEV & FILES\PLUG_POWER_FCT\PLU_POWER_FCT\PLU_POWER_FCT\Project Files\TEST SETUP.ini")
                ini.Load("D:\DEV & FILES\PLUG_POWER_FCT\PLU_POWER_FCT\PLU_POWER_FCT\Project Files\Confrigurations.ini")
                CONFIG.TextBox1.Text = ini.Sections("DB_PROVIDER").Keys("Count").Value
                CONFIG.TextBox2.Text = ini.Sections("DB_SOURCE").Keys("Count").Value
                CONFIG.TextBox3.Text = ini.Sections("SECQURITY_INFO").Keys("Count").Value
                CONFIG.TextBox4.Text = ini.Sections("TRACKER").Keys("Count").Value
                CONFIG.TextBox5.Text = ini.Sections("SYSID_STRCOUNT").Keys("Count").Value
                CONFIG.TextBox6.Text = ini.Sections("BATID_STRCOUNT").Keys("Count").Value
                CONFIG.TextBox7.Text = ini.Sections("SMC_STRCOUNT").Keys("Count").Value
                CONFIG.TextBox8.Text = ini.Sections("HPC_STRCOUNT").Keys("Count").Value
                CONFIG.TextBox9.Text = ini.Sections("SSMC_STRCOUNT").Keys("Count").Value
                CONFIG.TextBox10.Text = ini.Sections("SYSID_GOLDEN").Keys("Count").Value
                CONFIG.TextBox11.Text = ini.Sections("BATID_GOLDEN").Keys("Count").Value
                CONFIG.TextBox12.Text = ini.Sections("SMC_GOLDEN").Keys("Count").Value
                CONFIG.TextBox13.Text = ini.Sections("HPC_GOLDEN").Keys("Count").Value
                CONFIG.TextBox14.Text = ini.Sections("SSMC_GOLDEN").Keys("Count").Value
                CONFIG.TextBox15.Text = ini.Sections("SYSID_SNAP1").Keys("Count").Value
                CONFIG.TextBox16.Text = ini.Sections("SYSID_SOFT").Keys("Count").Value
                CONFIG.TextBox17.Text = ini.Sections("TEMP_PATH").Keys("Count").Value
                CONFIG.TextBox18.Text = ini.Sections("SYSID_SNAP2").Keys("Count").Value
                CONFIG.TextBox19.Text = ini.Sections("SYSID_COMP").Keys("Count").Value
                CONFIG.TextBox20.Text = ini.Sections("SYSID_REPTMP").Keys("Count").Value
                CONFIG.TextBox21.Text = ini.Sections("SYSID_REPPATH").Keys("Count").Value
                CONFIG.TextBox22.Text = ini.Sections("SYSID_SNAME").Keys("Count").Value
                CONFIG.TextBox23.Text = ini.Sections("BATID_SNAP1").Keys("Count").Value
                CONFIG.TextBox24.Text = ini.Sections("BATID_SOFT").Keys("Count").Value
                CONFIG.TextBox25.Text = ini.Sections("BATID_COMP").Keys("Count").Value
                CONFIG.TextBox26.Text = ini.Sections("BATID_SNAP2").Keys("Count").Value
                CONFIG.TextBox27.Text = ini.Sections("BATID_SNAME").Keys("Count").Value
                CONFIG.TextBox29.Text = ini.Sections("BATID_REPTMP").Keys("Count").Value
                CONFIG.TextBox28.Text = ini.Sections("BATID_REPPATH").Keys("Count").Value
                CONFIG.TextBox30.Text = ini.Sections("SMC_FF_SNAP").Keys("Count").Value
                CONFIG.TextBox31.Text = ini.Sections("POWER_SUPPLY").Keys("Count").Value
                CONFIG.TextBox32.Text = ini.Sections("PS_VOLT").Keys("Count").Value
                CONFIG.TextBox33.Text = ini.Sections("PS_CURR").Keys("Count").Value
                CONFIG.TextBox34.Text = ini.Sections("UNIFLASH_PORT").Keys("Count").Value
                If ini1.Sections("UPPER_CASE").Keys("Count").Value = "true" Then
                    SETUP.CheckBox1.Checked = True
                Else
                    SETUP.CheckBox1.Checked = False
                End If
                If ini1.Sections("MARK_REC").Keys("Count").Value = "true" Then
                    SETUP.CheckBox2.Checked = True
                Else
                    SETUP.CheckBox2.Checked = False
                End If
                If ini1.Sections("SERIAL_VERIFY").Keys("Count").Value = "true" Then
                    SETUP.CheckBox3.Checked = True
                Else
                    SETUP.CheckBox3.Checked = False
                End If
                If ini1.Sections("PASS_REPEAT").Keys("Count").Value = "true" Then
                    SETUP.CheckBox4.Checked = True
                Else
                    SETUP.CheckBox4.Checked = False
                End If
                If ini1.Sections("TASKBAR_HIDE").Keys("Count").Value = "true" Then
                    SETUP.CheckBox5.Checked = True
                Else
                    SETUP.CheckBox5.Checked = False
                End If
                If ini1.Sections("IMG_COMP").Keys("Count").Value = "true" Then
                    SETUP.CheckBox6.Checked = True
                Else
                    SETUP.CheckBox6.Checked = False
                End If
                If ini1.Sections("KEEP_REC").Keys("Count").Value = "true" Then
                    SETUP.CheckBox7.Checked = True
                Else
                    SETUP.CheckBox7.Checked = False
                End If
            Catch ex As Exception
                Dim iret1 As Object = MsgBox("Error Loading Config File." & " " & ex.Message, vbCritical + vbOKOnly, "Error Loading Confrigurations")
                If iret1 = vbOK Then
                    Application.Exit()
                End If
            End Try
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                If cn.State = ConnectionState.Open Then
                    Dim SQL As String = "SELECT * FROM SYSTEM_1 WHERE (HOST_NAME = '" & pcname & "')"
                    oleCommand = New OleDbCommand(SQL, cn)
                    Dim reader As OleDbDataReader = oleCommand.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()
                        If reader("EXP_DATE") <= DateTime.Now Then
                            reader.Close()
                            Dim iret4 As Object = MsgBox("Registration Expired. Do you want to Renew Now?", vbQuestion + vbYesNo, "LISCENCE-MANAGER")
                            If iret4 = vbYes Then
                                SYSREG.ShowDialog()
                            ElseIf iret4 = vbNo Then
                                Application.Exit()
                            End If
                        Else
                            reader.Close()
                            LOGINToolStripMenuItem.Enabled = True
                            LOGOUTToolStripMenuItem.Enabled = False
                            EXITToolStripMenuItem.Enabled = True
                            CREATEUSERToolStripMenuItem.Enabled = False
                            REMOVEUSERToolStripMenuItem.Enabled = False
                            CHANGEPASSWORDToolStripMenuItem.Enabled = False
                            FIRSTPASSYIELDToolStripMenuItem.Enabled = False
                            FINALPASSYIELDToolStripMenuItem.Enabled = False
                            ConfrigurationsToolStripMenuItem.Enabled = False
                            ABOUTSOFTWAREToolStripMenuItem.Enabled = True
                            HELPToolStripMenuItem.Enabled = True
                            SETUPToolStripMenuItem.Enabled = False
                            ENABLEMANUALMODEToolStripMenuItem.Enabled = False
                        End If
                    Else
                        reader.Close()
                        Dim iret3 As Object = MsgBox("System Not Found In Registration. Do You Want To Register?", vbQuestion + vbYesNo, "LISCENC-MANAGER")
                        If iret3 = vbYes Then
                            SYSREG.ShowDialog()
                        ElseIf iret3 = vbNo Then
                            Application.Exit()
                        End If
                    End If

                End If
            Catch ex As Exception
                Dim iret2 As Object = MsgBox("Unable to Connect to DB. Contact Administrator" & ex.Message, vbCritical + vbOKOnly, "ERROR CONNECTING TO DB")
                If iret2 = vbOK Then
                    Application.Exit()
                End If
            End Try
        End If
        If SETUP.CheckBox5.Checked = True Then
            Module1.HideTaskbar(True)
        Else
            Module1.HideTaskbar(False)
        End If
    End Sub


    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Dim iret As Object = MsgBox("DO YOU WANT TO EXIT?", vbQuestion + vbYesNo, "EXIT-LOGIC")
        If iret = vbNo Then
            'donothing
        ElseIf iret = vbYes Then
            Module1.HideTaskbar(False)
            Application.Exit()
        End If
    End Sub
    Private Sub ConfrigurationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfrigurationsToolStripMenuItem.Click
        CONFIG.ShowDialog()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
        LOGIN.ShowDialog()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim path As String = CONFIG.TextBox4.Text.ToString()
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        Dim iret As Object = MsgBox("DO YOU WANT TO LOG-OUT?", vbQuestion + vbYesNo, "LOG-OUT")
        If iret = vbYes Then
            LOGINToolStripMenuItem.Enabled = True
            LOGOUTToolStripMenuItem.Enabled = False
            EXITToolStripMenuItem.Enabled = True
            CREATEUSERToolStripMenuItem.Enabled = False
            REMOVEUSERToolStripMenuItem.Enabled = False
            CHANGEPASSWORDToolStripMenuItem.Enabled = False
            FIRSTPASSYIELDToolStripMenuItem.Enabled = False
            FINALPASSYIELDToolStripMenuItem.Enabled = False
            ConfrigurationsToolStripMenuItem.Enabled = False
            ABOUTSOFTWAREToolStripMenuItem.Enabled = False
            HELPToolStripMenuItem.Enabled = False
            SETUPToolStripMenuItem.Enabled = False
            ENABLEMANUALMODEToolStripMenuItem.Enabled = False
            file.WriteLine("LOGOUT SUCCESS :" + "=" + TextBox3.Text + "_" & DateTime.Now.ToString("yyyy/MM/dd/HH:mm:ss"))
            file.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox6.Clear()
            TextBox4.Clear()
            TextBox3.Clear()
            Label10.Visible = False
            Label11.Visible = False
            Label12.Text = "Label12"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            TreeView1.CollapseAll()
        ElseIf iret = vbNo Then
            'donothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        STARTUP.TextBox2.Text = Me.TextBox3.Text
        STARTUP.TextBox5.Text = Me.Label12.Text
        Button3.Enabled = False
        STARTUP.ShowDialog()
    End Sub

    Private Sub SETUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SETUPToolStripMenuItem.Click
        SETUP.ShowDialog()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub ENABLEMANUALMODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENABLEMANUALMODEToolStripMenuItem.Click
        GroupBox4.Visible = True
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button8_TextChanged(sender As Object, e As EventArgs) Handles Button8.TextChanged
        If Button8.Text = "IDLE" Then
            Button8.BackColor = Color.Blue
        ElseIf Button8.Text = "RUNNING" Then
            Button8.BackColor = Color.Yellow
        ElseIf Button8.Text = "PASS" Then
            Button8.BackColor = Color.Green
        ElseIf Button8.Text = "FAIL" Then
            Button8.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Enabled = False
        If RadioButton1.Checked = True And SETUP.CheckBox6.Checked = True Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox16.Text.ToString)
            ProgressBar1.Value = 60
            System.Threading.Thread.Sleep(7000)
            SendKeys.Send("^(/)")
            System.Threading.Thread.Sleep(5000)
            Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Dim grab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Dim s As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(grab)
            s.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
            ProgressBar1.Value = 80
            p.Kill()
            IMGCOMP.PictureBox1.Image = Image.FromFile(CONFIG.TextBox19.Text.ToString)
            IMGCOMP.PictureBox2.Image = grab
            IMGCOMP.ShowDialog()
        ElseIf RadioButton1.Checked = True And SETUP.CheckBox6.Checked = False Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox16.Text.ToString)
            System.Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 60
            Button9.Visible = False
            PictureBox1.Image = Image.FromFile(CONFIG.TextBox18.Text.ToString)
            Label13.Text = "COMPARE THE PICTURES AND CLICK ON THE PROPER ACTION"
            Button10.Visible = True
            Button11.Visible = True
        ElseIf RadioButton2.Checked = True And SETUP.CheckBox6.Checked = True Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox16.Text.ToString)
            System.Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 60
            Button9.Visible = False
            PictureBox1.Image = Image.FromFile(CONFIG.TextBox18.Text.ToString)
            Label13.Text = "COMPARE THE PICTURES AND CLICK ON THE PROPER ACTION"
            Button10.Visible = True
            Button11.Visible = True
        ElseIf RadioButton2.Checked = True And SETUP.CheckBox6.Checked = False Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox16.Text.ToString)
            System.Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 60
            Button9.Visible = False
            PictureBox1.Image = Image.FromFile(CONFIG.TextBox18.Text.ToString)
            Label13.Text = "COMPARE THE PICTURES AND CLICK ON THE PROPER ACTION"
            Button10.Visible = True
            Button11.Visible = True
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        System.Threading.Thread.Sleep(5000)
        SendKeys.Send("^(/)")
        System.Threading.Thread.Sleep(5000)
        Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim grab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim s As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(grab)
        s.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
        ProgressBar1.Value = 80
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcessesByName(CONFIG.TextBox22.Text.ToString)
        If myProcesses.Length > 0 Then
            For Each myProcess In myProcesses
                If myProcess IsNot Nothing Then
                    myProcess.Kill()
                End If
            Next
        End If
        Call Me.Show()
        Clipboard.Clear()
        Clipboard.SetImage(grab)
        TextBox13.Text = "TRUE"
        Button8.Text = "PASS"
        TreeView1.SelectedNode.FirstNode.BackColor = Color.Green
        ProgressBar1.Value = 100
        UUT_RESULT.Label2.Text = "PASS"
        UUT_RESULT.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        System.Threading.Thread.Sleep(5000)
        SendKeys.Send("^(/)")
        System.Threading.Thread.Sleep(5000)
        Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim grab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim s As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(grab)
        s.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
        ProgressBar1.Value = 80
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcessesByName(CONFIG.TextBox22.Text.ToString)
        If myProcesses.Length > 0 Then
            For Each myProcess In myProcesses
                If myProcess IsNot Nothing Then
                    myProcess.Kill()
                End If
            Next
        End If
        Clipboard.Clear()
        Clipboard.SetImage(grab)
        Call Me.Show()
        TextBox13.Text = "FALSE"
        Button8.Text = "FAIL"
        TreeView1.SelectedNode.FirstNode.BackColor = Color.Red
        ProgressBar1.Value = 100
        UUT_RESULT.Label2.Text = "FAIL"
        UUT_RESULT.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim elapsed As TimeSpan = Me.StopWatch.Elapsed
        TextBox5.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub

    Private Sub StartTimer3_CheckedChanged(sender As Object, e As EventArgs) Handles StartTimer3.CheckedChanged
        Timer3.Start()
        Me.StopWatch.Start()
    End Sub

    Private Sub StopTimer_CheckedChanged(sender As Object, e As EventArgs) Handles StopTimer.CheckedChanged
        Timer3.Stop()
        Me.StopWatch.Stop()
    End Sub

    Private Sub ResetTimer_CheckedChanged(sender As Object, e As EventArgs) Handles ResetTimer.CheckedChanged
        Timer3.Stop()
        Me.StopWatch.Reset()
        TextBox5.Text = "00:00:00:000"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button15.Enabled = False
        If RadioButton1.Checked = True And SETUP.CheckBox6.Checked = True Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox24.Text.ToString)
            ProgressBar1.Value = 60
            System.Threading.Thread.Sleep(7000)
            SendKeys.Send("^(/)")
            System.Threading.Thread.Sleep(5000)
            Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Dim grab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            Dim s As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(grab)
            s.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
            ProgressBar1.Value = 80
            p.Kill()
            IMGCOMP.PictureBox1.Image = Image.FromFile(CONFIG.TextBox25.Text.ToString)
            IMGCOMP.PictureBox2.Image = grab
            IMGCOMP.ShowDialog()
        ElseIf RadioButton1.Checked = True And SETUP.CheckBox6.Checked = False Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox24.Text.ToString)
            System.Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 60
            Button15.Visible = False
            PictureBox1.Image = Image.FromFile(CONFIG.TextBox26.Text.ToString)
            Label15.Text = "COMPARE THE PICTURES AND CLICK ON THE PROPER ACTION"
            Button13.Visible = True
            Button14.Visible = True
        ElseIf RadioButton2.Checked = True And SETUP.CheckBox6.Checked = True Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox24.Text.ToString)
            System.Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 60
            Button15.Visible = False
            PictureBox1.Image = Image.FromFile(CONFIG.TextBox26.Text.ToString)
            Label15.Text = "COMPARE THE PICTURES AND CLICK ON THE PROPER ACTION"
            Button13.Visible = True
            Button14.Visible = True
        ElseIf RadioButton2.Checked = True And SETUP.CheckBox6.Checked = False Then
            ProgressBar1.Value = 40
            Dim p As Process = Process.Start(CONFIG.TextBox24.Text.ToString)
            System.Threading.Thread.Sleep(5000)
            ProgressBar1.Value = 60
            Button15.Visible = False
            PictureBox1.Image = Image.FromFile(CONFIG.TextBox26.Text.ToString)
            Label15.Text = "COMPARE THE PICTURES AND CLICK ON THE PROPER ACTION"
            Button13.Visible = True
            Button14.Visible = True
        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Hide()
        System.Threading.Thread.Sleep(5000)
        SendKeys.Send("^(/)")
        System.Threading.Thread.Sleep(5000)
        Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim grab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim s As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(grab)
        s.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
        ProgressBar1.Value = 80
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcessesByName(CONFIG.TextBox27.Text.ToString)
        If myProcesses.Length > 0 Then
            For Each myProcess In myProcesses
                If myProcess IsNot Nothing Then
                    myProcess.Kill()
                End If
            Next
        End If
        Call Me.Show()
        Clipboard.Clear()
        Clipboard.SetImage(grab)
        TextBox18.Text = "TRUE"
        Button12.Text = "PASS"
        TreeView1.SelectedNode.FirstNode.BackColor = Color.Green
        ProgressBar1.Value = 100
        UUT_RESULT.Label2.Text = "PASS"
        UUT_RESULT.ShowDialog()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        System.Threading.Thread.Sleep(5000)
        SendKeys.Send("^(/)")
        System.Threading.Thread.Sleep(5000)
        Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim grab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim s As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(grab)
        s.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
        ProgressBar1.Value = 80
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcessesByName(CONFIG.TextBox27.Text.ToString)
        If myProcesses.Length > 0 Then
            For Each myProcess In myProcesses
                If myProcess IsNot Nothing Then
                    myProcess.Kill()
                End If
            Next
        End If
        Clipboard.Clear()
        Clipboard.SetImage(grab)
        Call Me.Show()
        TextBox18.Text = "FALSE"
        Button12.Text = "FAIL"
        TreeView1.SelectedNode.FirstNode.BackColor = Color.Red
        ProgressBar1.Value = 100
        UUT_RESULT.Label2.Text = "FAIL"
        UUT_RESULT.ShowDialog()
    End Sub
    Private Sub Button12_TextChanged(sender As Object, e As EventArgs) Handles Button12.TextChanged
        If Button12.Text = "IDLE" Then
            Button12.BackColor = Color.Blue
        ElseIf Button12.Text = "RUNNING" Then
            Button12.BackColor = Color.Yellow
        ElseIf Button12.Text = "PASS" Then
            Button12.BackColor = Color.Green
        ElseIf Button12.Text = "FAIL" Then
            Button12.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button16_TextChanged(sender As Object, e As EventArgs) Handles Button16.TextChanged
        If Button16.Text = "IDLE" Then
            Button16.BackColor = Color.Blue
        ElseIf Button16.Text = "RUNNING" Then
            Button16.BackColor = Color.Yellow
        ElseIf Button16.Text = "PASS" Then
            Button16.BackColor = Color.Green
        ElseIf Button16.Text = "FAIL" Then
            Button16.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button17_TextChanged(sender As Object, e As EventArgs) Handles Button17.TextChanged
        If Button17.Text = "IDLE" Then
            Button17.BackColor = Color.Blue
        ElseIf Button17.Text = "RUNNING" Then
            Button17.BackColor = Color.Yellow
        ElseIf Button17.Text = "PASS" Then
            Button17.BackColor = Color.Green
        ElseIf Button17.Text = "FAIL" Then
            Button17.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button19_TextChanged(sender As Object, e As EventArgs) Handles Button19.TextChanged
        If Button19.Text = "IDLE" Then
            Button19.BackColor = Color.Blue
        ElseIf Button19.Text = "RUNNING" Then
            Button19.BackColor = Color.Yellow
        ElseIf Button19.Text = "PASS" Then
            Button19.BackColor = Color.Green
        ElseIf Button19.Text = "FAIL" Then
            Button19.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button18_TextChanged(sender As Object, e As EventArgs) Handles Button18.TextChanged
        If Button18.Text = "IDLE" Then
            Button18.BackColor = Color.Blue
        ElseIf Button18.Text = "RUNNING" Then
            Button18.BackColor = Color.Yellow
        ElseIf Button18.Text = "PASS" Then
            Button18.BackColor = Color.Green
        ElseIf Button18.Text = "FAIL" Then
            Button18.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button20_TextChanged(sender As Object, e As EventArgs) Handles Button20.TextChanged
        If Button20.Text = "IDLE" Then
            Button20.BackColor = Color.Blue
        ElseIf Button20.Text = "RUNNING" Then
            Button20.BackColor = Color.Yellow
        ElseIf Button20.Text = "PASS" Then
            Button20.BackColor = Color.Green
        ElseIf Button20.Text = "FAIL" Then
            Button20.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button21_TextChanged(sender As Object, e As EventArgs) Handles Button21.TextChanged
        If Button21.Text = "IDLE" Then
            Button21.BackColor = Color.Blue
        ElseIf Button21.Text = "RUNNING" Then
            Button21.BackColor = Color.Yellow
        ElseIf Button21.Text = "PASS" Then
            Button21.BackColor = Color.Green
        ElseIf Button21.Text = "FAIL" Then
            Button21.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button22_TextChanged(sender As Object, e As EventArgs) Handles Button22.TextChanged
        If Button22.Text = "IDLE" Then
            Button22.BackColor = Color.Blue
        ElseIf Button22.Text = "RUNNING" Then
            Button22.BackColor = Color.Yellow
        ElseIf Button22.Text = "PASS" Then
            Button22.BackColor = Color.Green
        ElseIf Button22.Text = "FAIL" Then
            Button22.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button23_TextChanged(sender As Object, e As EventArgs) Handles Button23.TextChanged
        If Button23.Text = "IDLE" Then
            Button23.BackColor = Color.Blue
        ElseIf Button23.Text = "RUNNING" Then
            Button23.BackColor = Color.Yellow
        ElseIf Button23.Text = "PASS" Then
            Button23.BackColor = Color.Green
        ElseIf Button23.Text = "FAIL" Then
            Button23.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button24_TextChanged(sender As Object, e As EventArgs) Handles Button24.TextChanged
        If Button24.Text = "IDLE" Then
            Button24.BackColor = Color.Blue
        ElseIf Button24.Text = "RUNNING" Then
            Button24.BackColor = Color.Yellow
        ElseIf Button24.Text = "PASS" Then
            Button24.BackColor = Color.Green
        ElseIf Button24.Text = "FAIL" Then
            Button24.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button25_TextChanged(sender As Object, e As EventArgs) Handles Button25.TextChanged
        If Button25.Text = "IDLE" Then
            Button25.BackColor = Color.Blue
        ElseIf Button25.Text = "RUNNING" Then
            Button25.BackColor = Color.Yellow
        ElseIf Button25.Text = "PASS" Then
            Button25.BackColor = Color.Green
        ElseIf Button25.Text = "FAIL" Then
            Button25.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button26_TextChanged(sender As Object, e As EventArgs) Handles Button26.TextChanged
        If Button26.Text = "IDLE" Then
            Button26.BackColor = Color.Blue
        ElseIf Button26.Text = "RUNNING" Then
            Button26.BackColor = Color.Yellow
        ElseIf Button26.Text = "PASS" Then
            Button26.BackColor = Color.Green
        ElseIf Button26.Text = "FAIL" Then
            Button26.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button27_TextChanged(sender As Object, e As EventArgs) Handles Button27.TextChanged
        If Button27.Text = "IDLE" Then
            Button27.BackColor = Color.Blue
        ElseIf Button27.Text = "RUNNING" Then
            Button27.BackColor = Color.Yellow
        ElseIf Button27.Text = "PASS" Then
            Button27.BackColor = Color.Green
        ElseIf Button27.Text = "FAIL" Then
            Button27.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button28_TextChanged(sender As Object, e As EventArgs) Handles Button28.TextChanged
        If Button28.Text = "IDLE" Then
            Button28.BackColor = Color.Blue
        ElseIf Button28.Text = "RUNNING" Then
            Button28.BackColor = Color.Yellow
        ElseIf Button28.Text = "PASS" Then
            Button28.BackColor = Color.Green
        ElseIf Button28.Text = "FAIL" Then
            Button28.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button29_TextChanged(sender As Object, e As EventArgs) Handles Button29.TextChanged
        If Button29.Text = "IDLE" Then
            Button29.BackColor = Color.Blue
        ElseIf Button29.Text = "RUNNING" Then
            Button29.BackColor = Color.Yellow
        ElseIf Button29.Text = "PASS" Then
            Button29.BackColor = Color.Green
        ElseIf Button29.Text = "FAIL" Then
            Button29.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button30_TextChanged(sender As Object, e As EventArgs) Handles Button30.TextChanged
        If Button30.Text = "IDLE" Then
            Button30.BackColor = Color.Blue
        ElseIf Button30.Text = "RUNNING" Then
            Button30.BackColor = Color.Yellow
        ElseIf Button30.Text = "PASS" Then
            Button30.BackColor = Color.Green
        ElseIf Button30.Text = "FAIL" Then
            Button30.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button31_TextChanged(sender As Object, e As EventArgs) Handles Button31.TextChanged
        If Button31.Text = "IDLE" Then
            Button31.BackColor = Color.Blue
        ElseIf Button31.Text = "RUNNING" Then
            Button31.BackColor = Color.Yellow
        ElseIf Button31.Text = "PASS" Then
            Button31.BackColor = Color.Green
        ElseIf Button31.Text = "FAIL" Then
            Button31.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button32_TextChanged(sender As Object, e As EventArgs) Handles Button32.TextChanged
        If Button32.Text = "IDLE" Then
            Button32.BackColor = Color.Blue
        ElseIf Button32.Text = "RUNNING" Then
            Button32.BackColor = Color.Yellow
        ElseIf Button32.Text = "PASS" Then
            Button32.BackColor = Color.Green
        ElseIf Button32.Text = "FAIL" Then
            Button32.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button33_TextChanged(sender As Object, e As EventArgs) Handles Button33.TextChanged
        If Button33.Text = "IDLE" Then
            Button33.BackColor = Color.Blue
        ElseIf Button33.Text = "RUNNING" Then
            Button33.BackColor = Color.Yellow
        ElseIf Button33.Text = "PASS" Then
            Button33.BackColor = Color.Green
        ElseIf Button33.Text = "FAIL" Then
            Button33.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button34_TextChanged(sender As Object, e As EventArgs) Handles Button34.TextChanged
        If Button34.Text = "IDLE" Then
            Button34.BackColor = Color.Blue
        ElseIf Button34.Text = "RUNNING" Then
            Button34.BackColor = Color.Yellow
        ElseIf Button34.Text = "PASS" Then
            Button34.BackColor = Color.Green
        ElseIf Button34.Text = "FAIL" Then
            Button34.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button35_TextChanged(sender As Object, e As EventArgs) Handles Button35.TextChanged
        If Button35.Text = "IDLE" Then
            Button35.BackColor = Color.Blue
        ElseIf Button35.Text = "RUNNING" Then
            Button35.BackColor = Color.Yellow
        ElseIf Button35.Text = "PASS" Then
            Button35.BackColor = Color.Green
        ElseIf Button35.Text = "FAIL" Then
            Button35.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button36_TextChanged(sender As Object, e As EventArgs) Handles Button36.TextChanged
        If Button36.Text = "IDLE" Then
            Button36.BackColor = Color.Blue
        ElseIf Button36.Text = "RUNNING" Then
            Button36.BackColor = Color.Yellow
        ElseIf Button36.Text = "PASS" Then
            Button36.BackColor = Color.Green
        ElseIf Button36.Text = "FAIL" Then
            Button36.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button37_TextChanged(sender As Object, e As EventArgs) Handles Button37.TextChanged
        If Button37.Text = "IDLE" Then
            Button37.BackColor = Color.Blue
        ElseIf Button37.Text = "RUNNING" Then
            Button37.BackColor = Color.Yellow
        ElseIf Button37.Text = "PASS" Then
            Button37.BackColor = Color.Green
        ElseIf Button37.Text = "FAIL" Then
            Button37.BackColor = Color.Red
        End If
    End Sub
    Private Sub Button39_TextChanged(sender As Object, e As EventArgs) Handles Button39.TextChanged
        If Button39.Text = "IDLE" Then
            Button39.BackColor = Color.Blue
        ElseIf Button39.Text = "RUNNING" Then
            Button39.BackColor = Color.Yellow
        ElseIf Button39.Text = "PASS" Then
            Button39.BackColor = Color.Green
        ElseIf Button39.Text = "FAIL" Then
            Button39.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If RadioButton1.Checked = True And SETUP.CheckBox6.Checked = True Then
            PS_CTRL.PowerSupply_RST()
            PS_CTRL.PowerSupply_ON()
            System.Threading.Thread.Sleep(5000)
            TreeView1.SelectedNode.Nodes(0).BackColor = Color.Yellow
            Button16.Text = "RUNNING"
            ProgressBar1.Value = 4.16
        End If
    End Sub
End Class
