﻿Imports System.Data.OleDb
Public Class STARTUP
    Dim productversion = Application.ProductVersion.ToString
    Dim MODEL() As String = {"SYSTEM ID", "BATTERY ID", "SMC", "HPC", "UL SSMC"}
    Dim TEST_STEP() As String = {"PRE COATING TEST", "POST COATING TEST"}
    Dim TEST_MODE() As String = {"AUTOMATIC", "MANUAL"}
    Dim PROD_ID() As String = {"PROD", "GOLDEN", "INVALID"}
    Dim cn As OleDb.OleDbConnection
    Dim oleCommand As OleDbCommand
    Dim file As System.IO.StreamWriter
    Dim SystIDBox = {MAIN.TextBox7, MAIN.TextBox8, MAIN.TextBox9, MAIN.TextBox10, MAIN.TextBox11, MAIN.TextBox12, MAIN.TextBox13, MAIN.TextBox14, MAIN.TextBox15, MAIN.Button8}
    Dim BatIDBox = {MAIN.TextBox17, MAIN.TextBox18, MAIN.TextBox19, MAIN.TextBox20, MAIN.TextBox21, MAIN.TextBox22, MAIN.TextBox23, MAIN.TextBox24, MAIN.TextBox25, MAIN.Button12}
    Dim SmcBox = {MAIN.TextBox30, MAIN.TextBox31, MAIN.TextBox32, MAIN.TextBox33, MAIN.TextBox34, MAIN.TextBox26, MAIN.TextBox27, MAIN.TextBox28, MAIN.TextBox29,
        MAIN.TextBox35, MAIN.TextBox36, MAIN.TextBox37, MAIN.TextBox38, MAIN.Button16, MAIN.Button17, MAIN.TextBox152, MAIN.TextBox47, MAIN.TextBox48, MAIN.TextBox49,
        MAIN.TextBox50, MAIN.TextBox51, MAIN.TextBox41, MAIN.TextBox43, MAIN.TextBox45, MAIN.TextBox46, MAIN.TextBox39, MAIN.TextBox40, MAIN.TextBox42, MAIN.TextBox44,
        MAIN.TextBox52, MAIN.TextBox53, MAIN.TextBox54, MAIN.TextBox55, MAIN.TextBox56, MAIN.TextBox57, MAIN.TextBox58, MAIN.TextBox59, MAIN.TextBox60, MAIN.TextBox61,
        MAIN.TextBox62, MAIN.TextBox63, MAIN.TextBox64, MAIN.TextBox65, MAIN.TextBox66, MAIN.TextBox67, MAIN.TextBox71, MAIN.TextBox70, MAIN.TextBox69, MAIN.TextBox68,
        MAIN.TextBox72, MAIN.TextBox73, MAIN.TextBox74, MAIN.TextBox75, MAIN.Button19, MAIN.Button18, MAIN.Button20, MAIN.Button21, MAIN.Button22, MAIN.Button23, MAIN.Button24,
        MAIN.Button25, MAIN.TextBox76, MAIN.TextBox77, MAIN.TextBox78, MAIN.TextBox79, MAIN.TextBox80, MAIN.TextBox81, MAIN.TextBox82, MAIN.TextBox83, MAIN.TextBox84,
        MAIN.TextBox85, MAIN.TextBox86, MAIN.TextBox87, MAIN.TextBox88, MAIN.TextBox89, MAIN.TextBox90, MAIN.TextBox91, MAIN.TextBox92, MAIN.TextBox93, MAIN.TextBox94, MAIN.TextBox95,
        MAIN.TextBox96, MAIN.TextBox97, MAIN.TextBox98, MAIN.TextBox99, MAIN.TextBox100, MAIN.TextBox101, MAIN.TextBox102, MAIN.TextBox103, MAIN.TextBox104, MAIN.TextBox105,
        MAIN.TextBox106, MAIN.TextBox107, MAIN.TextBox108, MAIN.TextBox109, MAIN.TextBox110, MAIN.TextBox111, MAIN.TextBox112, MAIN.TextBox113, MAIN.TextBox114, MAIN.TextBox115,
        MAIN.TextBox116, MAIN.TextBox117, MAIN.TextBox118, MAIN.TextBox119, MAIN.TextBox120, MAIN.TextBox121, MAIN.TextBox122, MAIN.TextBox123, MAIN.TextBox124, MAIN.Button26,
        MAIN.Button27, MAIN.Button28, MAIN.Button29, MAIN.Button30, MAIN.Button31, MAIN.Button32, MAIN.Button33, MAIN.Button34, MAIN.Button35, MAIN.Button36, MAIN.TextBox129,
        MAIN.TextBox130, MAIN.TextBox131, MAIN.TextBox132, MAIN.TextBox133, MAIN.TextBox125, MAIN.TextBox126, MAIN.TextBox127, MAIN.TextBox128, MAIN.Button37, MAIN.TextBox138, MAIN.TextBox139,
        MAIN.TextBox140, MAIN.TextBox141, MAIN.TextBox142, MAIN.TextBox134, MAIN.TextBox135, MAIN.TextBox136, MAIN.TextBox137, MAIN.Button38, MAIN.TextBox147, MAIN.TextBox148, MAIN.TextBox149,
        MAIN.TextBox150, MAIN.TextBox151, MAIN.TextBox143, MAIN.TextBox144, MAIN.TextBox145, MAIN.TextBox146, MAIN.Button39}
    Dim SmcTextBox = {MAIN.TextBox27, MAIN.TextBox37, MAIN.TextBox43, MAIN.TextBox40, MAIN.TextBox54, MAIN.TextBox58, MAIN.TextBox62, MAIN.TextBox66, MAIN.TextBox69, MAIN.TextBox74, MAIN.TextBox86,
        MAIN.TextBox82, MAIN.TextBox90, MAIN.TextBox95, MAIN.TextBox99, MAIN.TextBox103, MAIN.TextBox107, MAIN.TextBox111, MAIN.TextBox115, MAIN.TextBox119, MAIN.TextBox123, MAIN.TextBox126,
        MAIN.TextBox135, MAIN.TextBox144}
    Dim SmcButton = {MAIN.Button16, MAIN.Button17, MAIN.Button19, MAIN.Button18, MAIN.Button20, MAIN.Button21, MAIN.Button22, MAIN.Button23, MAIN.Button24,
        MAIN.Button25, MAIN.Button26, MAIN.Button27, MAIN.Button28, MAIN.Button29, MAIN.Button30, MAIN.Button31, MAIN.Button32, MAIN.Button33, MAIN.Button34,
        MAIN.Button35, MAIN.Button36, MAIN.Button39, MAIN.Button37}

    Private Sub STARTUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox4.BackColor = Color.White
        If MAIN.CheckBox1.Checked = False Then
            MAIN.StopTimer.Checked = True
            MAIN.ResetTimer.Checked = True
            Label3.Text = productversion
            TextBox2.Enabled = False
            TextBox2.Text = MAIN.TextBox3.Text
            If TextBox5.Text = "OPERATOR" Then
                ComboBox3.Enabled = False
                ComboBox3.Text = ""
                ComboBox3.Items.Clear()
                ComboBox3.Items.AddRange(TEST_MODE)
                ComboBox3.SelectedIndex = 0
            Else
                ComboBox3.Text = ""
                ComboBox3.Items.Clear()
                ComboBox3.Items.AddRange(TEST_MODE)
                ComboBox3.Enabled = True
            End If
            ComboBox1.Text = ""
            ComboBox1.Items.Clear()
            ComboBox1.Items.AddRange(MODEL)
            ComboBox2.Text = ""
            ComboBox2.Items.Clear()
            ComboBox2.Items.AddRange(TEST_STEP)
            ComboBox4.Text = ""
            ComboBox4.Items.Clear()
            ComboBox4.Items.AddRange(PROD_ID)
            TextBox3.Clear()
            TextBox1.Clear()
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            MAIN.PictureBox1.Visible = False
            MAIN.Button9.Visible = False
            MAIN.Label13.Visible = False
            MAIN.Button10.Visible = False
            MAIN.Button11.Visible = False
            'BATID CLEARANCE
            MAIN.PictureBox2.Visible = False
            MAIN.Label15.Visible = False
            MAIN.Button13.Visible = False
            MAIN.Button14.Visible = False
            MAIN.Button15.Visible = False
        ElseIf MAIN.CheckBox1.Checked = True Then
            MAIN.PictureBox1.Visible = False
            MAIN.Button9.Visible = False
            MAIN.Label13.Visible = False
            MAIN.Button10.Visible = False
            MAIN.Button11.Visible = False
            'BATID CLEARANCE
            MAIN.PictureBox2.Visible = False
            MAIN.Label15.Visible = False
            MAIN.Button13.Visible = False
            MAIN.Button14.Visible = False
            MAIN.Button15.Visible = False
            MAIN.StopTimer.Checked = True
            MAIN.ResetTimer.Checked = True
            Label3.Text = productversion
            TextBox2.Enabled = False
            TextBox1.Clear()
            TextBox3.Clear()
            TextBox2.Text = MAIN.TextBox3.Text
            If TextBox5.Text = "OPERATOR" Then
                ComboBox3.Enabled = False
            Else
                ComboBox3.Enabled = True
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox4.Text = Me.TextBox1.Text.ToUpper
        ComboBox4.Items.Clear()
        ComboBox4.Items.AddRange(PROD_ID)
        Dim SL = TextBox1.Text
        If isGolden() = True And isSerialValid() = True Then
            ComboBox4.SelectedIndex = 1
            ComboBox4.Enabled = False
            CheckBox2.Checked = True
        ElseIf isGolden() = False And isSerialValid() = True Then
            ComboBox4.SelectedIndex = 0
            ComboBox4.Enabled = False
            CheckBox2.Checked = False
        ElseIf isGolden() = False And isSerialValid() = False Then
            ComboBox4.SelectedIndex = 2
            ComboBox4.Enabled = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MAIN.TextBox1.Clear()
        MAIN.TextBox2.Clear()
        MAIN.TextBox6.Clear()
        MAIN.TextBox4.Clear()
        MAIN.Button3.Enabled = True
        Me.Close()
    End Sub
    Function isGolden() As Boolean
        If ComboBox1.SelectedItem = "SYSTEM ID" And TextBox4.Text = CONFIG.TextBox10.Text Then
            Return True
        ElseIf ComboBox1.SelectedItem = "BATTERY ID" And TextBox4.Text = CONFIG.TextBox11.Text Then
            Return True
        ElseIf ComboBox1.SelectedItem = "SMC" And TextBox4.Text = CONFIG.TextBox12.Text Then
            Return True
        ElseIf ComboBox1.SelectedItem = "HPC" And TextBox4.Text = CONFIG.TextBox13.Text Then
            Return True
        ElseIf ComboBox1.SelectedItem = "UL SSMC" And TextBox4.Text = CONFIG.TextBox14.Text Then
            Return True
        Else
            Return False
        End If
    End Function
    Function isPassed() As Boolean
        If ComboBox1.SelectedItem = "SYSTEM ID" Then
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                Dim SQL As String = "SELECT * FROM SYSTEM_ID WHERE (SERIAL_NUMBER = '" & TextBox4.Text & "' AND TEST_STEP = '" & ComboBox2.SelectedItem & "' AND TEST_RESULT = 'PASS')"
                oleCommand = New OleDbCommand(SQL, cn)
                Dim reader As OleDbDataReader = oleCommand.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    If reader("TEST_RESULT") = "PASS" Then
                        CheckBox1.Checked = True
                        reader.Close()
                        Return True
                    Else
                        CheckBox1.Checked = False
                        reader.Close()
                        Return False
                    End If
                Else
                    CheckBox1.Checked = False
                    reader.Close()
                    Return False
                End If
            Catch ex As Exception
                Dim iret As Object = MsgBox("Error Executing isPassed() Function. : " & ex.Message, vbCritical + vbOKOnly, "isPassed?")
                If iret = vbOK Then
                    Exit Function
                End If
            End Try
        ElseIf ComboBox1.SelectedItem = "BATTERY ID" Then
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                Dim SQL As String = "SELECT * FROM BATTERY_ID WHERE (SERIAL_NUMBER = '" & TextBox4.Text & "' AND TEST_STEP = '" & ComboBox2.SelectedItem & "' AND TEST_RESULT = 'PASS')"
                oleCommand = New OleDbCommand(SQL, cn)
                Dim reader As OleDbDataReader = oleCommand.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    If reader("TEST_RESULT") = "PASS" Then
                        CheckBox1.Checked = True
                        reader.Close()
                        Return True
                    Else
                        CheckBox1.Checked = False
                        reader.Close()
                        Return False
                    End If
                Else
                    CheckBox1.Checked = False
                    reader.Close()
                    Return False
                End If
            Catch ex As Exception
                Dim iret As Object = MsgBox("Error Executing isPassed() Function. : " & ex.Message, vbCritical + vbOKOnly, "isPassed?")
                If iret = vbOK Then
                    Exit Function
                End If
            End Try
        ElseIf ComboBox1.SelectedItem = "SMC" Then
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                Dim SQL As String = "SELECT * FROM SMC WHERE (SERIAL_NUMBER = '" & TextBox4.Text & "' AND TEST_STEP = '" & ComboBox2.SelectedItem & "' AND TEST_RESULT = 'PASS')"
                oleCommand = New OleDbCommand(SQL, cn)
                Dim reader As OleDbDataReader = oleCommand.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    If reader("TEST_RESULT") = "PASS" Then
                        CheckBox1.Checked = True
                        reader.Close()
                        Return True
                    Else
                        CheckBox1.Checked = False
                        reader.Close()
                        Return False
                    End If
                Else
                    CheckBox1.Checked = False
                    reader.Close()
                    Return False
                End If
            Catch ex As Exception
                Dim iret As Object = MsgBox("Error Executing isPassed() Function. : " & ex.Message, vbCritical + vbOKOnly, "isPassed?")
                If iret = vbOK Then
                    Exit Function
                End If
            End Try
        ElseIf ComboBox1.SelectedItem = "HPC" Then
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                Dim SQL As String = "SELECT * FROM HPC WHERE (SERIAL_NUMBER = '" & TextBox4.Text & "' AND TEST_STEP = '" & ComboBox2.SelectedItem & "' AND TEST_RESULT = 'PASS')"
                oleCommand = New OleDbCommand(SQL, cn)
                Dim reader As OleDbDataReader = oleCommand.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    If reader("TEST_RESULT") = "PASS" Then
                        CheckBox1.Checked = True
                        reader.Close()
                        Return True
                    Else
                        CheckBox1.Checked = False
                        reader.Close()
                        Return False
                    End If
                Else
                    CheckBox1.Checked = False
                    reader.Close()
                    Return False
                End If
            Catch ex As Exception
                Dim iret As Object = MsgBox("Error Executing isPassed() Function. : " & ex.Message, vbCritical + vbOKOnly, "isPassed?")
                If iret = vbOK Then
                    Exit Function
                End If
            End Try
        ElseIf ComboBox1.SelectedItem = "UL SSMC" Then
            Try
                cn = New OleDbConnection
                cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
                cn.Open()
                Dim SQL As String = "SELECT * FROM UL SSMC WHERE (SERIAL_NUMBER = '" & TextBox4.Text & "' AND TEST_STEP = '" & ComboBox2.SelectedItem & "' AND TEST_RESULT = 'PASS')"
                oleCommand = New OleDbCommand(SQL, cn)
                Dim reader As OleDbDataReader = oleCommand.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    If reader("TEST_RESULT") = "PASS" Then
                        CheckBox1.Checked = True
                        reader.Close()
                        Return True
                    Else
                        CheckBox1.Checked = False
                        reader.Close()
                        Return False
                    End If
                Else
                    CheckBox1.Checked = False
                    reader.Close()
                    Return False
                End If
            Catch ex As Exception
                Dim iret As Object = MsgBox("Error Executing isPassed() Function. : " & ex.Message, vbCritical + vbOKOnly, "isPassed?")
                If iret = vbOK Then
                    Exit Function
                End If
            End Try
        End If
    End Function
    Function isSerialValid() As Boolean
        If ComboBox1.SelectedItem = "SYSTEM ID" Then
            If TextBox1.Text.Length = CONFIG.TextBox5.Text Then
                Return True
            Else
                Return False
            End If
        ElseIf ComboBox1.SelectedItem = "BATTERY ID" Then
            If TextBox1.Text.Length = CONFIG.TextBox6.Text Then
                Return True
            Else
                Return False
            End If
        ElseIf ComboBox1.SelectedItem = "SMC" Then
            If TextBox1.Text.Length = CONFIG.TextBox7.Text Then
                Return True
            Else
                Return False
            End If
        ElseIf ComboBox1.SelectedItem = "HPC" Then
            If TextBox1.Text.Length = CONFIG.TextBox8.Text Then
                Return True
            Else
                Return False
            End If
        ElseIf ComboBox1.SelectedItem = "UL SSMC" Then
            If TextBox1.Text.Length = CONFIG.TextBox9.Text Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SL = TextBox1.Text
        If ComboBox1.SelectedItem = Nothing Then
            Dim iret As Object = ("NO MODEL SELECTD TO RUN", vbCritical + vbOKOnly)
            If iret = vbOK Then
                Exit Sub
            End If
        ElseIf ComboBox2.SelectedItem = Nothing Then
            Dim iret1 As Object = ("NO TEST STEP SELECTD TO RUN", vbCritical + vbOKOnly)
            If iret1 = vbOK Then
                Exit Sub
            End If
        ElseIf ComboBox3.SelectedItem = Nothing Then
            Dim iret2 As Object = ("NO TEST MODE SELECTD TO RUN", vbCritical + vbOKOnly)
            If iret2 = vbOK Then
                Exit Sub
            End If
        Else
            If SETUP.CheckBox1.Checked = True Then
                SL = TextBox1.Text.ToUpper
                MAIN.TextBox4.Text = SL
                testStart1()
            Else
                SL = TextBox1.Text
                MAIN.TextBox4.Text = SL
                testStart1()
            End If
        End If
    End Sub
    Function testStart1() As Object
        If SETUP.CheckBox3.Checked = True Then
            If isSerialValid() Then
                testStart2()
            Else
                Dim iret As Object = MsgBox("INVALID SERIAL NUMBER", vbCritical + vbOKOnly, "isSerialValidCheck Failed")
                If iret = vbOK Then
                    TextBox1.Clear()
                    Exit Function
                End If
            End If
        Else
            testStart2()
        End If
    End Function
    Function testStart2() As Object
        If SETUP.CheckBox4.Checked = True And Me.CheckBox2.Checked = False Then
            If isPassed() = True And CheckBox1.Checked = True Then
                Dim iret As Object = MsgBox("UNIT IS ALREADY PASSED CANNOT RUN TEST", vbCritical + vbOKOnly, "isPassedCheck Function")
                If iret = vbOK Then
                    Exit Function
                End If
            Else
                teststartFnal()
            End If
        Else
            teststartFnal()
        End If
    End Function
    Function teststartFnal() As Object
        MAIN.TextBox1.Text = ComboBox1.SelectedItem
        MAIN.TextBox2.Text = ComboBox2.SelectedItem
        MAIN.TextBox6.Text = ComboBox4.SelectedItem
        If ComboBox1.SelectedItem = "SYSTEM ID" And ComboBox2.SelectedItem = "PRE COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                SysIdPreAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                SysIdPreManual()
            End If
        ElseIf ComboBox1.SelectedItem = "SYSTEM ID" And ComboBox2.SelectedItem = "POST COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                SysIdPostAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                SysIdPostManual()
            End If
        ElseIf ComboBox1.SelectedItem = "BATTERY ID" And ComboBox2.SelectedItem = "PRE COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                BatIdPreAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                BatIdPreManual()
            End If
        ElseIf ComboBox1.SelectedItem = "BATTERY ID" And ComboBox2.SelectedItem = "POST COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                BatIdPostAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                BatIdPostManual()
            End If
        ElseIf ComboBox1.SelectedItem = "SMC" And ComboBox2.SelectedItem = "PRE COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                SmcPreAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                SmcPreManual()
            End If
        ElseIf ComboBox1.SelectedItem = "SMC" And ComboBox2.SelectedItem = "POST COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                SmcPostAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                SmcPostManual()
            End If
        ElseIf ComboBox1.SelectedItem = "HPC" And ComboBox2.SelectedItem = "PRE COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                HpcPreAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                HpcPreManual()
            End If
        ElseIf ComboBox1.SelectedItem = "HPC" And ComboBox2.SelectedItem = "POST COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                HpcPostAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                HpcPostManual()
            End If
        ElseIf ComboBox1.SelectedItem = "UL SSMC" And ComboBox2.SelectedItem = "PRE COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                SsmcPreAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                SsmcPreManual()
            End If
        ElseIf ComboBox1.SelectedItem = "UL SSMC" And ComboBox2.SelectedItem = "POST COATING TEST" Then
            If ComboBox3.SelectedItem = "AUTOMATIC" Then
                SsmcPostAuto()
            ElseIf ComboBox3.SelectedItem = "MANUAL" Then
                SsmcPostManual()
            End If
        End If
    End Function
    Function SsmcPreAuto() As Object

    End Function
    Function SsmcPostAuto() As Object

    End Function
    Function SsmcPreManual() As Object

    End Function
    Function SsmcPostManual() As Object

    End Function
    Function HpcPreAuto() As Object

    End Function
    Function HpcPostAuto() As Object

    End Function
    Function HpcPreManual() As Object

    End Function
    Function HpcPostManual() As Object

    End Function
    Function BatIdPreAuto() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In BatIDBox
            tb.Enabled = False
        Next
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Close()
        MAIN.GroupBox2.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage2)
        MAIN.Button12.Text = "RUNNING"
        MAIN.RadioButton1.Checked = True
        MAIN.RadioButton2.Checked = False
        MAIN.PictureBox2.Image = Image.FromFile(CONFIG.TextBox23.Text.ToString)
        MAIN.Label15.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.Label15.Visible = True
        MAIN.PictureBox2.Visible += True
        MAIN.Button15.Visible = True
        MAIN.Button14.Visible = False
        MAIN.Button13.Visible = False
    End Function
    Function BatIdPostAuto() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In BatIDBox
            tb.Enabled = False
        Next
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Close()
        MAIN.GroupBox2.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage2)
        MAIN.Button12.Text = "RUNNING"
        MAIN.RadioButton1.Checked = True
        MAIN.RadioButton2.Checked = False
        MAIN.PictureBox2.Image = Image.FromFile(CONFIG.TextBox23.Text.ToString)
        MAIN.Label15.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.Label15.Visible = True
        MAIN.PictureBox2.Visible += True
        MAIN.Button15.Visible = True
        MAIN.Button14.Visible = False
        MAIN.Button13.Visible = False
    End Function
    Function BatIdPreManual() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In BatIDBox
            tb.Enabled = False
        Next
        MAIN.Button15.Enabled = True
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Dispose()
        MAIN.GroupBox2.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage2)
        MAIN.Button12.Text = "RUNNING"
        MAIN.RadioButton1.Checked = False
        MAIN.RadioButton2.Checked = True
        MAIN.PictureBox2.Image = Image.FromFile(CONFIG.TextBox23.Text.ToString)
        MAIN.Label15.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.PictureBox2.Visible = True
        MAIN.Button15.Visible = True
        MAIN.Label15.Visible = True
        MAIN.Button14.Visible = False
        MAIN.Button13.Visible = False
    End Function
    Function BatIdPostManual() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In BatIDBox
            tb.Enabled = False
        Next
        MAIN.Button15.Enabled = True
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Dispose()
        MAIN.GroupBox2.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage2)
        MAIN.Button12.Text = "RUNNING"
        MAIN.RadioButton1.Checked = False
        MAIN.RadioButton2.Checked = True
        MAIN.PictureBox2.Image = Image.FromFile(CONFIG.TextBox23.Text.ToString)
        MAIN.Label15.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.PictureBox2.Visible = True
        MAIN.Button15.Visible = True
        MAIN.Label15.Visible = True
        MAIN.Button14.Visible = False
        MAIN.Button13.Visible = False
    End Function
    Function SmcPreAuto() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SmcBox
            tb.Enabled = False
        Next
        For Each txt In SmcTextBox
            txt.Clear()
        Next
        For Each btn In SmcButton
            btn.Text = "IDLE"
        Next
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Close()
        MAIN.GroupBox2.Visible = True
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage3)
        MAIN.TabControl2.TabPages.Remove(MAIN.TabPage6)
        MAIN.TabControl2.TabPages.Remove(MAIN.TabPage7)
        MAIN.TabControl2.TabPages.Remove(MAIN.TabPage8)
        MAIN.TabControl2.TabPages.Remove(MAIN.TabPage10)
        MAIN.TabControl2.TabPages.Remove(MAIN.TabPage11)
        MAIN.TabControl2.TabPages.Remove(MAIN.TabPage12)
        MAIN.TabControl2.TabPages.Add(MAIN.TabPage6)
        MAIN.PictureBox3.Image = Image.FromFile(CONFIG.TextBox30.Text.ToString)
        MAIN.TextBox152.Text = "PLACE THE DUT IN FIXTURE AND CONNECT THE MSP430 CABLE AS SHOWN THEN CLICK ON CONTINUE"
        MAIN.Button40.Enabled = True
    End Function
    Function SmcPostAuto() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SmcBox
            tb.Enabled = False
        Next
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Dispose()
        MAIN.GroupBox2.Visible = True
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage3)
    End Function
    Function SmcPreManual() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SmcBox
            tb.Enabled = False
        Next
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Dispose()
        MAIN.GroupBox2.Visible = True
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage3)
    End Function
    Function SmcPostManual() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SmcBox
            tb.Enabled = False
        Next
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Dispose()
        MAIN.GroupBox2.Visible = True
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage3)
    End Function
    Function SysIdPreAuto() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SystIDBox
            tb.Enabled = False
        Next
        MAIN.Button9.Enabled = True
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Close()
        MAIN.GroupBox2.Visible = True
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage1)
        MAIN.Button8.Text = "RUNNING"
        MAIN.RadioButton1.Checked = True
        MAIN.RadioButton2.Checked = False
        MAIN.PictureBox1.Image = Image.FromFile(CONFIG.TextBox15.Text.ToString)
        MAIN.Label13.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.PictureBox1.Visible = True
        MAIN.Button9.Visible = True
        MAIN.Label13.Visible = True
        MAIN.Button10.Visible = False
        MAIN.Button11.Visible = False
    End Function
    Function SysIdPostAuto() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SystIDBox
            tb.Enabled = False
        Next
        MAIN.Button9.Enabled = True
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Close()
        MAIN.GroupBox2.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage1)
        MAIN.Button8.Text = "RUNNING"
        MAIN.RadioButton1.Checked = True
        MAIN.RadioButton2.Checked = False
        MAIN.PictureBox1.Image = Image.FromFile(CONFIG.TextBox15.Text.ToString)
        MAIN.Label13.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.PictureBox1.Visible = True
        MAIN.Button9.Visible = True
        MAIN.Label13.Visible = True
        MAIN.Button10.Visible = False
        MAIN.Button11.Visible = False
    End Function
    Function SysIdPreManual() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SystIDBox
            tb.Enabled = False
        Next
        MAIN.Button9.Enabled = True
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Dispose()
        MAIN.GroupBox2.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage1)
        MAIN.Button8.Text = "RUNNING"
        MAIN.RadioButton1.Checked = False
        MAIN.RadioButton2.Checked = True
        MAIN.PictureBox1.Image = Image.FromFile(CONFIG.TextBox15.Text.ToString)
        MAIN.Label13.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.PictureBox1.Visible = True
        MAIN.Button9.Visible = True
        MAIN.Label13.Visible = True
        MAIN.Button10.Visible = False
        MAIN.Button11.Visible = False
    End Function
    Function SysIdPostManual() As Object
        MAIN.ResetTimer.Checked = True
        MAIN.StartTimer3.Checked = True
        For Each tb In SystIDBox
            tb.Enabled = False
        Next
        MAIN.Button9.Enabled = True
        Dim tn As TreeNode
        For Each tn In MAIN.TreeView1.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
        Me.Dispose()
        MAIN.GroupBox2.Visible = True
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage1)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage2)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage3)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage4)
        MAIN.TabControl1.TabPages.Remove(MAIN.TabPage5)
        MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Yellow
        MAIN.GroupBox3.Visible = True
        MAIN.TabControl1.TabPages.Add(MAIN.TabPage1)
        MAIN.Button8.Text = "RUNNING"
        MAIN.RadioButton1.Checked = False
        MAIN.RadioButton2.Checked = True
        MAIN.PictureBox1.Image = Image.FromFile(CONFIG.TextBox15.Text.ToString)
        MAIN.Label13.Text = "CONNECT THE DUT AS SHOWN"
        MAIN.PictureBox1.Visible = True
        MAIN.Button9.Visible = True
        MAIN.Label13.Visible = True
        MAIN.Button10.Visible = False
        MAIN.Button11.Visible = False
    End Function
    Private Sub FindNode(ByVal tNode As TreeNode)
        Dim tn As TreeNode
        For Each tn In tNode.Nodes
            If tn.Text = ComboBox1.SelectedItem Then
                MAIN.TreeView1.SelectedNode = tn
                MAIN.TreeView1.SelectedNode.Expand()
                Exit For
            End If
            FindNode(tn)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedIndex = 2 Then
            ComboBox4.BackColor = Color.Red
        ElseIf ComboBox4.SelectedIndex = 1 Then
            ComboBox4.BackColor = Color.LightBlue
        ElseIf ComboBox4.SelectedIndex = 0 Then
            ComboBox4.BackColor = Color.Green
        End If
    End Sub
End Class