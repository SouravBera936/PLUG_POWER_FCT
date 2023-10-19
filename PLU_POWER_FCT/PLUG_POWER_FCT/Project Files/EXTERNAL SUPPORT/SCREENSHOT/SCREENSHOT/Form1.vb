Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.ForeColor = Color.Yellow
        ProgressBar1.Value = 60
        System.Threading.Thread.Sleep(2000)
        Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim grab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim s As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(grab)
        s.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
        PictureBox1.Image = grab
        grab.Save("D:\DEV & FILES\PLUG_POWER_FCT\PLU_POWER_FCT\PLU_POWER_FCT\Project Files\BATID.jpg")
        Me.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 1
        ProgressBar1.Maximum = 100
    End Sub
End Class
