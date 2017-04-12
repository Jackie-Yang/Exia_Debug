Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.Check_PID()

    End Sub


    'PID参数整定



    Public Sub PID_Set(PID As System.Windows.Forms.Label, PID_index As Byte)
        If Val(Form1.THRO.Text) <> 0 Then
            MsgBox("请先将油门置零！", MsgBoxStyle.Exclamation, "注意安全")
        Else
            Dim inputStr As String
            inputStr = InputBox("请输入" + PID.Name + "设定值:", "PID参数整定", Val(PID.Text))
            If Len(inputStr) <> 0 Then

                Try
                    PID_Send(Val(inputStr) * 100, PID_index)
                    Form1.Check_PID()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub


    Public Sub PID_Send(inputData As UInteger, PID_index As Byte)
        Dim order(1) As Byte

        order(0) = PID_index
        Form1.SerialPort1.Write(order, 0, 1)
        order(0) = inputData >> 8
        Form1.SerialPort1.Write(order, 0, 1)
        order(0) = inputData And &HFF
        Form1.SerialPort1.Write(order, 0, 1)

    End Sub



    Private Sub ROLL_G_Kp_Click(sender As Object, e As EventArgs) Handles ROLL_G_Kp.Click

        PID_Set(ROLL_G_Kp, 9)

    End Sub


    Private Sub ROLL_G_Ki_Click(sender As Object, e As EventArgs) Handles ROLL_G_Ki.Click
        PID_Set(ROLL_G_Ki, 10)
    End Sub


    Private Sub ROLL_G_Kd_Click(sender As Object, e As EventArgs) Handles ROLL_G_Kd.Click
        PID_Set(ROLL_G_Kd, 11)
    End Sub


    Private Sub ROLL_Angle_Kp_Click(sender As Object, e As EventArgs) Handles ROLL_Angle_Kp.Click
        
        PID_Set(ROLL_Angle_Kp, 12)

    End Sub

    Private Sub ROLL_Angle_Ki_Click(sender As Object, e As EventArgs) Handles ROLL_Angle_Ki.Click
        PID_Set(ROLL_Angle_Ki, 13)
    End Sub



    Private Sub ROLL_Angle_Kd_Click(sender As Object, e As EventArgs) Handles ROLL_Angle_Kd.Click
        PID_Set(ROLL_Angle_Kd, 14)
    End Sub



    Private Sub PITCH_G_Kp_Click(sender As Object, e As EventArgs) Handles PITCH_G_Kp.Click
        PID_Set(PITCH_G_Kp, 15)
    End Sub

    Private Sub PITCH_G_Ki_Click(sender As Object, e As EventArgs) Handles PITCH_G_Ki.Click
        PID_Set(PITCH_G_Ki, 16)
    End Sub

    Private Sub PITCH_G_Kd_Click(sender As Object, e As EventArgs) Handles PITCH_G_Kd.Click
        PID_Set(PITCH_G_Kd, 17)
    End Sub


    Private Sub PITCH_Angle_Kp_Click(sender As Object, e As EventArgs) Handles PITCH_Angle_Kp.Click
        PID_Set(PITCH_Angle_Kp, 18)
    End Sub

    Private Sub PITCH_Angle_Ki_Click(sender As Object, e As EventArgs) Handles PITCH_Angle_Ki.Click
        PID_Set(PITCH_Angle_Ki, 19)
    End Sub

    Private Sub PITCH_Angle_Kd_Click(sender As Object, e As EventArgs) Handles PITCH_Angle_Kd.Click
        PID_Set(PITCH_Angle_Kd, 20)
    End Sub

    Private Sub YAW_G_Kp_Click(sender As Object, e As EventArgs) Handles YAW_G_Kp.Click
        PID_Set(YAW_G_Kp, 21)
    End Sub

    Private Sub YAW_G_Ki_Click(sender As Object, e As EventArgs) Handles YAW_G_Ki.Click
        PID_Set(YAW_G_Ki, 22)
    End Sub
    Private Sub YAW_G_Kd_Click(sender As Object, e As EventArgs) Handles YAW_G_Kd.Click
        PID_Set(YAW_G_Kd, 23)
    End Sub


   

    Private Sub Load_Btn_Click(sender As Object, e As EventArgs) Handles Load_Btn.Click
        Form4.ShowDialog()
    End Sub

    
    Private Sub Updata_Btn_Click(sender As Object, e As EventArgs) Handles Updata_Btn.Click
        Form1.Check_PID()
    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        FileOpen(1, "Roll_Gyro_PID.dat", OpenMode.Append)
        Print(1, "Date:" & Now, SPC(1), "----", SPC(1), "P:" & ROLL_G_Kp.Text, SPC(1), "I:" & ROLL_G_Ki.Text, SPC(1), "D:" & ROLL_G_Kd.Text, Chr(13) + Chr(10))
        FileClose(1)

        FileOpen(1, "Roll_Angle_PID.dat", OpenMode.Append)
        Print(1, "Date:" & Now, SPC(1), "----", SPC(1), "P:" & ROLL_Angle_Kp.Text, SPC(1), "I:" & ROLL_Angle_Ki.Text, SPC(1), "D:" & ROLL_Angle_Kd.Text, Chr(13) + Chr(10))
        FileClose(1)

        FileOpen(1, "Pitch_Gyro_PID.dat", OpenMode.Append)
        Print(1, "Date:" & Now, SPC(1), "----", SPC(1), "P:" & PITCH_G_Kp.Text, SPC(1), "I:" & PITCH_G_Ki.Text, SPC(1), "D:" & PITCH_G_Kd.Text, Chr(13) + Chr(10))
        FileClose(1)

        FileOpen(1, "Pitch_Angle_PID.dat", OpenMode.Append)
        Print(1, "Date:" & Now, SPC(1), "----", SPC(1), "P:" & PITCH_Angle_Kp.Text, SPC(1), "I:" & PITCH_Angle_Ki.Text, SPC(1), "D:" & PITCH_Angle_Kd.Text, Chr(13) + Chr(10))
        FileClose(1)

        FileOpen(1, "Yaw_Gyro_PID.dat", OpenMode.Append)
        Print(1, "Date:" & Now, SPC(1), "----", SPC(1), "P:" & YAW_G_Kp.Text, SPC(1), "I:" & YAW_G_Ki.Text, SPC(1), "D:" & YAW_G_Kd.Text, Chr(13) + Chr(10))
        FileClose(1)

        MsgBox("保存成功！", , "保存配置")

    End Sub
End Class