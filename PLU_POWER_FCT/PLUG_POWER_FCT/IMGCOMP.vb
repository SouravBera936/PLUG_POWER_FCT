﻿Public Class IMGCOMP
    Private Sub IMGCOMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MAIN.TextBox1.Text = "SYSTEM ID" And MAIN.TextBox2.Text = "PRE COATING TEST" Then
            If imageComparison() Then
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox13.Text = "TRUE"
                MAIN.Button8.Text = "PASS"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Green
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "PASS"
                UUT_RESULT.ShowDialog()
            Else
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox13.Text = "FALSE"
                MAIN.Button8.Text = "FAIL"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Red
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "FAIL"
                UUT_RESULT.ShowDialog()
            End If
        ElseIf MAIN.TextBox1.Text = "SYSTEM ID" And MAIN.TextBox2.Text = "POST COATING TEST" Then
            If imageComparison() Then
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox13.Text = "TRUE"
                MAIN.Button8.Text = "PASS"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Green
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "PASS"
                UUT_RESULT.ShowDialog()
            Else
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox13.Text = "FALSE"
                MAIN.Button8.Text = "FAIL"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Red
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "FAIL"
                UUT_RESULT.ShowDialog()
            End If
        ElseIf MAIN.TextBox1.Text = "BATTERY ID" And MAIN.TextBox2.Text = "PRE COATING TEST" Then
            If imageComparison() Then
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox18.Text = "TRUE"
                MAIN.Button12.Text = "PASS"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Green
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "PASS"
                UUT_RESULT.ShowDialog()
            Else
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox18.Text = "FALSE"
                MAIN.Button12.Text = "FAIL"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Red
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "FAIL"
                UUT_RESULT.ShowDialog()
            End If
        ElseIf MAIN.TextBox1.Text = "BATTERY ID" And MAIN.TextBox2.Text = "POST COATING TEST" Then
            If imageComparison() Then
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox18.Text = "TRUE"
                MAIN.Button12.Text = "PASS"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Green
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "PASS"
                UUT_RESULT.ShowDialog()
            Else
                Clipboard.Clear()
                Clipboard.SetImage(PictureBox2.Image)
                Me.Close()
                MAIN.TextBox18.Text = "FALSE"
                MAIN.Button12.Text = "FAIL"
                MAIN.TreeView1.SelectedNode.FirstNode.BackColor = Color.Red
                MAIN.ProgressBar1.Value = 100
                UUT_RESULT.Label2.Text = "FAIL"
                UUT_RESULT.ShowDialog()
            End If
        End If
    End Sub
    Function imageComparison() As Boolean
        Dim bmp1 As Bitmap = PictureBox1.Image
        Dim bmp2 As Bitmap = PictureBox2.Image
        Dim threshold As Integer = Integer.Parse("99")
        Dim wid As Integer = Math.Min(bmp1.Width, bmp2.Width)
        Dim hgt As Integer = Math.Min(bmp1.Height, bmp2.Height)
        Dim bmp3 As New Bitmap(wid, hgt)
        Dim are_identical As Boolean = True
        Dim color1, color2 As Color
        Dim eq_color As Color = Color.White
        Dim ne_color As Color = Color.Red
        Dim dr, dg, db, diff As Integer
        For x As Integer = 0 To wid - 1
            For y As Integer = 0 To hgt - 1
                color1 = bmp1.GetPixel(x, y)
                color2 = bmp2.GetPixel(x, y)
                dr = CInt(color1.R) - color2.R
                dg = CInt(color1.G) - color2.G
                db = CInt(color1.B) - color2.B
                diff = dr * dr + dg * dg + db * db
                If diff <= threshold Then
                    bmp3.SetPixel(x, y, eq_color)
                Else
                    bmp3.SetPixel(x, y, ne_color)
                    are_identical = False
                End If
            Next y
        Next x
        FAILUREVIEW.PictureBox1.Image = bmp3
        If (bmp1.Width <> bmp2.Width) OrElse (bmp1.Height <>
            bmp2.Height) Then
            are_identical = False
            Return False
        End If
        If are_identical Then
            Return True
        End If
    End Function

End Class