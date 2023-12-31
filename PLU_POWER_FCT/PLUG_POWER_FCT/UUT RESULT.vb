﻿Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Public Class UUT_RESULT
    Dim cn As OleDb.OleDbConnection
    Dim oleCommand As OleDbCommand
    Dim productversion = Application.ProductVersion.ToString
    Dim MODEL() As String = {"SYSTEM ID", "BATTERY ID", "SMC", "HPC", "UL SSMC"}
    Dim TEST_STEP() As String = {"PRE COATING TEST", "POST COATING TEST"}
    Dim TEST_MODE() As String = {"AUTOMATIC", "MANUAL"}
    Private Sub UUT_RESULT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = productversion
        If Label2.Text = "PASS" Then
            Label2.Text = "TEST SEQUENCE PASSED"
            Me.BackColor = Color.Green
            Label1.BackColor = Color.Green
            Label3.BackColor = Color.Green
            LinkLabel1.Visible = False
        ElseIf Label2.Text = "FAIL" Then
            Label2.Text = "TEST SEQUENCE FAILED"
            Me.BackColor = Color.Red
            Label1.BackColor = Color.Red
            Label3.BackColor = Color.Red
            LinkLabel1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MAIN.Label13.Visible = False
        If SETUP.CheckBox7.Checked = True Then
            MAIN.CheckBox1.Checked = True
            If MAIN.TextBox6.Text = "GOLDEN" Then
                clearSequence()
                MAIN.StopTimer.Checked = True
                keepRecord()
                Me.Close()
                MAIN.ResetTimer.Checked = True
                STARTUP.ShowDialog()
            Else
                generateReport()
                recordData()
                clearSequence()
                MAIN.StopTimer.Checked = True
                keepRecord()
                Me.Close()
                MAIN.ResetTimer.Checked = True
                STARTUP.ShowDialog()
            End If
        Else
            MAIN.CheckBox1.Checked = False
            If MAIN.TextBox6.Text = "GOLDEN" Then
                clearSequence()
                MAIN.StopTimer.Checked = True
                Me.Close()
                MAIN.ResetTimer.Checked = True
                STARTUP.ShowDialog()
            Else
                generateReport()
                recordData()
                clearSequence()
                MAIN.StopTimer.Checked = True
                Me.Close()
                MAIN.ResetTimer.Checked = True
                STARTUP.ShowDialog()
            End If
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FAILUREVIEW.ShowDialog()
    End Sub
    Function recordData() As Object
        Dim line1 As Label
        Dim line2 As Label
        If MAIN.TextBox1.Text = "SYSTEM ID" Then
line1:
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                Dim SQL1 As String = "INSERT INTO SYSTEM_ID (SERIAL_NUMBER, TEST_STEP, DONE_BY, DUT_ID, MARK, PROGRAMMING_TEST, TEST_RESULT, DATE_TIME, CYCLE_TIME, TESTER_ID ) VALUES ('" & MAIN.TextBox4.Text & "','" & MAIN.TextBox2.Text & "','" & MAIN.TextBox3.Text & "','" & MAIN.TextBox6.Text & "','" & MAIN.TextBox16.Text & "','" & MAIN.TextBox13.Text & "','" & MAIN.Button8.Text & "','" & DateTime.Now & "','" & MAIN.TextBox5.Text & "','" & MAIN.Label10.Text & "')"
                Dim command As New OleDbCommand(SQL1, cn)
                command.ExecuteNonQuery()
            Catch ex As Exception
                Dim iret As Object = MsgBox("Error Recording Data. Do you want to retry? : " & ex.Message, vbRetryCancel, "recordData Function Error")
                If iret = vbRetry Then
                    GoTo line1
                ElseIf iret = vbCancel Then
                    MsgBox("EXITING SOFTWARE")
                    Application.Exit()
                End If
            End Try
        ElseIf MAIN.TextBox1.Text = "BATTERY ID" Then
line2:
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                Dim SQL1 As String = "INSERT INTO BATTERY_ID (SERIAL_NUMBER, TEST_STEP, DONE_BY, DUT_ID, MARK, PROGRAMMING_TEST, TEST_RESULT, DATE_TIME, CYCLE_TIME, TESTER_ID ) VALUES ('" & MAIN.TextBox4.Text & "','" & MAIN.TextBox2.Text & "','" & MAIN.TextBox3.Text & "','" & MAIN.TextBox6.Text & "','" & MAIN.TextBox16.Text & "','" & MAIN.TextBox18.Text & "','" & MAIN.Button12.Text & "','" & DateTime.Now & "','" & MAIN.TextBox5.Text & "','" & MAIN.Label10.Text & "')"
                Dim command As New OleDbCommand(SQL1, cn)
                command.ExecuteNonQuery()
            Catch ex As Exception
                Dim iret As Object = MsgBox("Error Recording Data. Do you want to retry? : " & ex.Message, vbRetryCancel, "recordData Function Error")
                If iret = vbRetry Then
                    GoTo line1
                ElseIf iret = vbCancel Then
                    MsgBox("EXITING SOFTWARE")
                    Application.Exit()
                End If
            End Try
        End If
    End Function
    Function generateReport() As Object
        If MAIN.TextBox1.Text = "SYSTEM ID" Then
            Dim xlapp = New Microsoft.Office.Interop.Excel.Application
            xlapp.DisplayAlerts = False
            Dim workbook = xlapp.Workbooks.Open(CONFIG.TextBox20.Text.ToString)
            Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim worksheet1 As Microsoft.Office.Interop.Excel.Worksheet
            worksheet = workbook.Sheets("SYSTEM-ID")
            worksheet1 = workbook.Sheets.Add(After:=worksheet)
            worksheet1.Paste()
            worksheet.Range("D6").Value = MAIN.TextBox3.Text
            worksheet.Range("D7").Value = MAIN.TextBox2.Text
            worksheet.Range("D8").Value = MAIN.TextBox4.Text
            worksheet.Range("D9").Value = DateTime.Now.ToString
            worksheet.Range("F7").Value = MAIN.Label10.Text
            worksheet.Range("F6").Value = MAIN.TextBox5.Text
            worksheet.Range("D12").Value = MAIN.Button8.Text
            worksheet.Range("G15").Value = MAIN.TextBox13.Text
            worksheet.Range("J15").Value = MAIN.Button8.Text
            If worksheet.Range("D12").Value = "PASS" Then
                worksheet.Range("K15").Value = "1"
            Else
                worksheet.Range("K15").Value = "0"
            End If
            With worksheet1.PageSetup
                .Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape
                .Zoom = False
                .FitToPagesTall = 1
                .FitToPagesWide = 1
            End With
            workbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, CONFIG.TextBox21.Text.ToString & MAIN.TextBox4.Text.ToString & "_" & MAIN.TextBox2.Text.ToString & "_" & MAIN.Button8.Text.ToString & Format(Now(), "hhmmssmmddyy") & ".pdf", vbNormal)
            worksheet1.Delete()
            Clipboard.Clear()
            workbook.Close(True)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            workbook = Nothing
            xlapp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlapp)
            xlapp = Nothing
            Process.GetProcessesByName("EXCEL")(0).Kill()
        ElseIf MAIN.TextBox1.Text = "BATTERY ID" Then
            Dim xlapp = New Microsoft.Office.Interop.Excel.Application
            xlapp.DisplayAlerts = False
            Dim workbook = xlapp.Workbooks.Open(CONFIG.TextBox29.Text.ToString)
            Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim worksheet1 As Microsoft.Office.Interop.Excel.Worksheet
            worksheet = workbook.Sheets("BATERY-ID")
            worksheet1 = workbook.Sheets.Add(After:=worksheet)
            worksheet1.Paste()
            worksheet.Range("D6").Value = MAIN.TextBox3.Text
            worksheet.Range("D7").Value = MAIN.TextBox2.Text
            worksheet.Range("D8").Value = MAIN.TextBox4.Text
            worksheet.Range("D9").Value = DateTime.Now.ToString
            worksheet.Range("F7").Value = MAIN.Label10.Text
            worksheet.Range("F6").Value = MAIN.TextBox5.Text
            worksheet.Range("D12").Value = MAIN.Button12.Text
            worksheet.Range("G15").Value = MAIN.TextBox18.Text
            worksheet.Range("J15").Value = MAIN.Button12.Text
            If worksheet.Range("D12").Value = "PASS" Then
                worksheet.Range("K15").Value = "1"
            Else
                worksheet.Range("K15").Value = "0"
            End If
            With worksheet1.PageSetup
                .Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape
                .Zoom = False
                .FitToPagesTall = 1
                .FitToPagesWide = 1
            End With
            workbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, CONFIG.TextBox28.Text.ToString & MAIN.TextBox4.Text.ToString & "_" & MAIN.TextBox2.Text.ToString & "_" & MAIN.Button12.Text.ToString & Format(Now(), "hhmmssmmddyy") & ".pdf", vbNormal)
            worksheet1.Delete()
            Clipboard.Clear()
            workbook.Close(True)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            workbook = Nothing
            xlapp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlapp)
            xlapp = Nothing
            Process.GetProcessesByName("EXCEL")(0).Kill()
        End If
    End Function
    Function clearSequence() As Object
        If MAIN.TextBox1.Text = "SYSTEM ID" Then
            MAIN.PictureBox1.Visible = False
            MAIN.Button9.Visible = False
            MAIN.Button11.Visible = False
            MAIN.Button10.Visible = False
            MAIN.TextBox13.Clear()
            MAIN.Button8.Text = "IDLE"
            MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.White
            MAIN.ProgressBar1.Value = 1
        ElseIf MAIN.TextBox1.Text = "BATTERY ID" Then
            MAIN.PictureBox2.Visible = False
            MAIN.Button15.Visible = False
            MAIN.Button13.Visible = False
            MAIN.Button14.Visible = False
            MAIN.TextBox18.Clear()
            MAIN.Button12.Text = "IDLE"
            MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.White
            MAIN.ProgressBar1.Value = 1
        End If
    End Function
    Function keepRecord() As Object
        If MAIN.TextBox1.Text = "SYSTEM ID" And MAIN.TextBox2.Text = "PRE COATING TEST" Then
            If MAIN.RadioButton1.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 0
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 0
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 0
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            ElseIf MAIN.RadioButton2.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 0
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 0
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 1
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            End If
        ElseIf MAIN.TextBox1.Text = "SYSTEM ID" And MAIN.TextBox2.Text = "POST COATING TEST" Then
            If MAIN.RadioButton1.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 0
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 1
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 0
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            ElseIf MAIN.RadioButton2.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 0
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 1
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 1
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            End If
        ElseIf MAIN.TextBox1.Text = "BATTERY ID" And MAIN.TextBox2.Text = "PRE COATING TEST" Then
            If MAIN.RadioButton1.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 1
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 0
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 0
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            ElseIf MAIN.RadioButton2.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 1
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 0
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 1
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            End If
        ElseIf MAIN.TextBox1.Text = "BATTERY ID" And MAIN.TextBox2.Text = "POST COATING TEST" Then
            If MAIN.RadioButton1.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 1
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 1
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 0
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            ElseIf MAIN.RadioButton2.Checked = True Then
                STARTUP.ComboBox1.Items.Clear()
                STARTUP.ComboBox1.Items.AddRange(MODEL)
                STARTUP.ComboBox1.SelectedIndex = 1
                STARTUP.ComboBox2.Items.Clear()
                STARTUP.ComboBox2.Items.AddRange(TEST_STEP)
                STARTUP.ComboBox2.SelectedIndex = 1
                STARTUP.ComboBox3.Items.Clear()
                STARTUP.ComboBox3.Items.AddRange(TEST_MODE)
                STARTUP.ComboBox3.SelectedIndex = 1
                STARTUP.TextBox1.Clear()
                STARTUP.TextBox3.Clear()
                MAIN.TextBox6.Clear()
                MAIN.TextBox4.Clear()
            End If
        End If
    End Function
End Class