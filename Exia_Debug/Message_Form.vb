Public Class Message_Form

    Dim Message_Form_stste As Boolean = False

    Private Sub Message_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Message_Form_stste Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Message_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Message_Form_stste = True
        Timer1.Enabled = True

        If Me.Text = "罗盘校正" Then
            Label1.Text = "罗盘校正中...请将控制器朝各个方向旋转"
        End If

    End Sub

 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Message_Form_stste = False Then
            Me.Close()
        End If

        If Me.Text = "罗盘校正" Then
            If (Message_Form_stste = True And Form1.Read_16(5) = 25) Then

                Message_Form_stste = False
                Label1.Text = "罗盘校正完成！"
            End If
        End If


    End Sub
End Class