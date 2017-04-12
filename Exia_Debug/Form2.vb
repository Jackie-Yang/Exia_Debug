Public Class Form2

    Public printBuf As String = "无信号"

    '关闭窗口时将通道选择关闭
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.printLine = False
        '  Form1.Timer2.Enabled = False
        Form1.Channel1_nameBox.SelectedIndex = 0
        Form1.Channel1_nameBox.Enabled = False
        Form1.Channel2_nameBox.SelectedIndex = 0
        Form1.Channel2_nameBox.Enabled = False
        Form1.Channel3_nameBox.SelectedIndex = 0
        Form1.Channel3_nameBox.Enabled = False
        Form1.Channel4_nameBox.SelectedIndex = 0
        Form1.Channel4_nameBox.Enabled = False
        Form1.Opacity = 1
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.TopMost = True
        Curve1.CurveLabelText(0) = "通道一"
        Curve1.CurveLabelText(1) = "通道二"
        Curve1.CurveLabelText(2) = "通道三"
        Curve1.CurveLabelText(3) = "通道四"

        printBuf = "无信号"
        printNum()


    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Curve1.Size = New Size(Me.Width - 10, Me.Height - 80)   'Height - 90)
        Curve1.RealCurveInit()
        printNum()
        'Curve1.ZoomReset()
    End Sub

    Public Sub printNum()
        Dim tempBmp As Bitmap

        tempBmp = New Bitmap(Curve1.CurveState.Width, Curve1.CurveState.Height)

        Dim Gr As Graphics = Graphics.FromImage(tempBmp)
        Dim strSize As SizeF

        strSize = Gr.MeasureString(printBuf, Curve1.Font)

        Gr.DrawString(printBuf, Curve1.Font, Brushes.Cyan, _
                      New Point(Curve1.CurveState.Width - strSize.Width - Curve1.RightIn_temp, Curve1.CurveState.Height - strSize.Height))

        'Gr.DrawString(dataStr, Curve1.Font, Curve1.DataLabelColor, _
        '              New Point(Me.Curve1.CurveState.Width - strSize.Width - BackStyle.RightIn, Me.Curve1.CurveState.Height - strSize.Height))

        'Gr.DrawString(dataStr, BackStyle.StrFont, BackStyle.DataLabelColor, _
        '              New Point(Me.CurveState.Width - strSize.Width - BackStyle.RightIn, Me.CurveState.Height - strSize.Height))

        Curve1.CurveState.Image = tempBmp
    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.Opacity = 0.65
        Form1.TopMost = False
    End Sub
End Class