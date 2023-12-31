﻿Imports System.Data.OleDb
Public Class PASSWORD_RST
    Dim productversion = Application.ProductVersion.ToString
    Dim cn As OleDb.OleDbConnection
    Dim oleCommand As OleDbCommand
    Dim file As System.IO.StreamWriter
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub PASSWORD_RST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        Button1.Enabled = False
        Button3.Enabled = False
        Label3.Text = productversion
        Button3.BackColor = Color.White
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            TextBox3.Enabled = False
            Button3.Enabled = False
        Else
            TextBox3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim path As String = CONFIG.TextBox4.Text.ToString()
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        file.Close()
        Try
            cn = New OleDbConnection
            cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
            cn.Open()
            Dim SQL As String = "SELECT * FROM USER_1 WHERE (USE_ID = '" & TextBox1.Text & "' AND DESIGNATION = '" & TextBox3.Text & "')"
            oleCommand = New OleDbCommand(SQL, cn)
            Dim reader As OleDbDataReader = oleCommand.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                If TextBox2.Text = reader("USER_NAME") And TextBox3.Text = reader("DESIGNATION") Then
                    Button3.BackColor = Color.Green
                    TextBox2.Enabled = False
                    Button1.Enabled = True
                    reader.Close()
                Else
                    Button3.BackColor = Color.Red
                    TextBox2.Clear()
                    TextBox3.Clear()
                    Button1.Enabled = False
                    reader.Close()
                End If
                Button3.Enabled = False
            End If
        Catch ex As Exception
            Dim iret As Object = MsgBox("Error checking Database" & ex.Message, vbCritical + vbOKOnly, "RST-PSW")
            If iret = vbOK Then
                file.WriteLine("PASSWORD RESET FAILED :" + "=" + TextBox1.Text + "_" & ex.Message & "_" & DateTime.Now.ToString("yyyy/MM/dd/HH:mm:ss"))
                file.Close()
                Application.Restart()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = CONFIG.TextBox4.Text.ToString()
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        Try
            cn = New OleDbConnection
            cn.ConnectionString = "Provider=" & CONFIG.TextBox1.Text & ";Data Source=" & CONFIG.TextBox2.Text & "; Persist Security Info=" & CONFIG.TextBox3.Text & ";"
            cn.Open()
            Dim SQL As String = "SELECT * FROM USER_1 WHERE (USE_ID = '" & TextBox1.Text & "' AND USER_NAME='" & TextBox2.Text & "')"
            oleCommand = New OleDbCommand(SQL, cn)
            Dim reader As OleDbDataReader = oleCommand.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Dim iret As Object = MsgBox("The Recovered Password Is :" & " " & reader("PASSWORD"), vbInformation + vbOKOnly, "PSW-RST")
                If iret = vbOK Then
                    file.WriteLine("PASSWORD RECOVERY SUCCESSFULL :" + "=" + TextBox1.Text + "_" & TextBox2.Text & "_" & DateTime.Now.ToString("yyyy/MM/dd/HH:mm:ss"))
                    file.Close()
                    reader.Close()
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If
    End Sub
End Class