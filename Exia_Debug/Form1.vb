Option Explicit On
Imports System
Imports System.IO.Ports         '使用serialport所引用的命名空间
Imports System.Threading        '使用thread所引用的命名空间

Public Class Form1
    '  Dim strrec As String        '接收字符串
    ' Dim strsend As String       '发送字符串
    ' Dim intnum As Integer       '接收字节数=字符数+1（vblf）

    Dim Receive_Buf(36 * 2) As Byte             '串口读取一个数据包的缓存数组
    Dim Buf_Size As Integer = 36 * 2            '数据包字节大小

    '已注释，用定时器替代
    'Dim Last_Receive_time As Double = 0         '记录下界面参数的更新时间，控制界面参数采样时间
    'Dim Last_Print_time As Double = 0           '记录下绘制曲线参数的更新时间，控制曲线采样时间
    'Dim now

    Dim Serial_Is_Closing As Boolean = False    '记录下串口是否正在关闭
    Dim Serial_Is_Receiving As Boolean = False  '记录下串口是否在接收数据

    Public printLine As Boolean = False         '记录下是否打开绘制曲线窗口
    Dim printNum(4) As Integer                  '四个通道曲线输入

    Dim channel_index(4) As Integer             '记录下当前绘制的曲线是什么参数
    Dim channel_gain(4) As Double              '记录下当前绘制曲线的倍率

    Dim Print_speed As Integer = 25             '记录下当前的曲线采样时间




    '窗体初始化
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try         '在很多地方会使用try，意义是下面的操作可能会导致错误，下面的catch捕捉错误信息
            Dim ports As String() = SerialPort.GetPortNames() '必须用命名空间，用SerialPort,获取计算机的有效串口
            Dim port As String
            For Each port In ports
                portnamebox.Items.Add(port) '向combobox中添加项
            Next port

            baudratebox.Items.Add(9600)     '可选波特率选项
            baudratebox.Items.Add(38400)
            baudratebox.Items.Add(115200)

            '初始化界面

            baudratebox.SelectedIndex() = 2     '默认选项
            If portnamebox.Items.Count > 0 Then
                portnamebox.SelectedIndex() = 0
                Serial_Port1()      '初始化串口
            End If


        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "获取串口列表失败")
        End Try

        statuslabel.Text = "未连接"
        statuslabel.ForeColor = Color.Red


        '曲线绘制选项初始化
        Print_Channel_init(Channel1_nameBox)
        Print_Channel_init(Channel2_nameBox)
        Print_Channel_init(Channel3_nameBox)
        Print_Channel_init(Channel4_nameBox)


        '曲线倍率选项初始化
        Channel1_gainBox.Items.Add("无信号源")
        Channel1_gainBox.SelectedIndex = 0

        Channel2_gainBox.Items.Add("无信号源")
        Channel2_gainBox.SelectedIndex = 0

        Channel3_gainBox.Items.Add("无信号源")
        Channel3_gainBox.SelectedIndex = 0

        Channel4_gainBox.Items.Add("无信号源")
        Channel4_gainBox.SelectedIndex = 0

        '曲线采样周期选项初始化
        Print_speedBox.Items.Add("25ms")
        Print_speedBox.Items.Add("50ms")
        Print_speedBox.Items.Add("75ms")
        Print_speedBox.SelectedIndex = 0
        '用采样周期初始化定时器2
        Timer2.Interval = Val(Print_speedBox.Text)
        
        'Me.TopMost = True   '窗口保持最前
        ' baudratebox.Text = baudratebox.Items(0) 注释和不注释的地方可以替换
        'portnamebox.Text = portnamebox.Items(0)

    End Sub




    '如果尝试关闭窗口时串口正在工作，警告用户必须先关闭串口再关闭窗口
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If SerialPort1.IsOpen = True Then

                e.Cancel = True
                MsgBox("请先关闭串口！", MsgBoxStyle.Exclamation, "警告")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '打开PID整定窗口
    Private Sub PID_Set_Click_2(sender As Object, e As EventArgs) Handles PID_Set.Click
        Form3.Show()
    End Sub




    '--------------------------------------------------------------------------------------------
    '------------------------------串口操作部分--------------------------------------------------
    '--------------------------------------------------------------------------------------------


    '每次点击串口列表进行一次列表更新
    Private Sub portnamebox_Click(sender As Object, e As EventArgs) Handles portnamebox.Click
        Try
            Dim ports As String() = SerialPort.GetPortNames() '必须用命名空间，用SerialPort,获取计算机的有效串口
            Dim port As String
            portnamebox.Items.Clear()       '先将列表清空
            For Each port In ports
                portnamebox.Items.Add(port) '向combobox中添加项
            Next port
            If portnamebox.Items.Count > 0 Then
                portnamebox.SelectedIndex() = 0
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "获取串口列表失败")
        End Try
    End Sub



    '串口设置
    Private Sub Serial_Port1() '设置串口参数
        SerialPort1.BaudRate = Val(baudratebox.Text) '波特率
        SerialPort1.PortName = portnamebox.Text '串口名称
        SerialPort1.DataBits = 8 '数据位
        SerialPort1.StopBits = IO.Ports.StopBits.One '停止位
        SerialPort1.Parity = IO.Ports.Parity.None '校验位
    End Sub



    '打开/关闭串口
    Private Sub openbtn_Click(sender As Object, e As EventArgs) Handles openbtn.Click
        Try
            If SerialPort1.IsOpen = False Then
                Serial_Port1()      '按照参数初始化串口
                SerialPort1.Open()  '打开串口
                If SerialPort1.IsOpen = True Then   '确认串口已经打开
                    SerialPort1.DiscardInBuffer()       '清除串口多余数据
                    statuslabel.Text = "已连接" + "(" + SerialPort1.PortName + ")"
                    statuslabel.ForeColor = Color.Green
                    openbtn.Text = "关闭串口"
                    'Last_Receive_time = DateAndTime.Timer        '开始记录时间
                    Timer1.Enabled = True '开启定时器进行数据更新
                    'If printLine Then
                    Timer2.Enabled = True '开启定时器2进行曲线更新
                    'End If
                    Check_MPU6050_offset()
                    Check_HMC5883L_offset()
                    If Form3.IsHandleCreated Then
                        Check_PID()
                    End If
                End If
            Else
                Timer1.Enabled = False      '关闭数据更新
                Timer2.Enabled = False
                '不能直接关闭串口，会和串口接收事件有冲突
                Serial_Is_Closing = True            '表示正在关闭串口，不会对数据进行接收
                If Serial_Is_Receiving = False Then '若正在接收数据，则不会执行关闭串口
                    SerialPort1.Close()
                    Serial_Is_Closing = False
                    Serial_Close()  '串口关闭后执行的一些工作，将数据更新为“无信号”
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    '有关结束串口和串口接收的处理，因为串口接收频繁，如果直接关闭串口，会和串口接收触发事件冲突，
    '导致程序卡死，使用Closing和Receiving两个状态标志，触发关闭或中断的事件，都会将其置True
    '接下来判断另一个标识位有没有置True，如果有，则不会继续相应操作，没有，则在完成相应操作之后
    '再将标志置位False
    '但是由于close事件不能由于正在Receive而不执行，因此如若Receive事件发生时，发生了Close事件，在Receive
    '事件结束之后，会执行Close事件



    '触发接收事件
    Public Sub Sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Serial_Is_Receiving = True          '状态旗标置位，以免在进行接收数据同时关闭串口
            If Serial_Is_Closing = False Then   '若串口不在关闭过程，则可以进行接收
                ' Me.Invoke(New EventHandler(AddressOf Sp_Receiving))
                '调用接收数据函数，对窗体控件的操作需要和窗体控件同一线程，因此此函数使其在窗口的线程执行
                '后期改用定时器更新控件数据，因此不需要新建线程
                ReadBuf()                       '读取数据
                SerialPort1.DiscardInBuffer()   '丢弃剩余数据
            End If

            If Serial_Is_Closing Then           '若在串口接收过程按下串口关闭，则在这里进行串口关闭

                SerialPort1.Close() '关闭串口
                Serial_Is_Closing = False
                Me.Invoke(New EventHandler(AddressOf Serial_Close)) '对控件操作，同上，要和窗体同一线程

            End If

            Serial_Is_Receiving = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    '关闭串口之后的一些处理
    Private Sub Serial_Close()
        If SerialPort1.IsOpen = False Then
            statuslabel.Text = "未连接"
            statuslabel.ForeColor = Color.Red
            openbtn.Text = "打开串口"

            RUDD.Text = "无信号"
            THRO.Text = "无信号"
            AILE.Text = "无信号"
            ELEV.Text = "无信号"
            Accel_Sensor_X.Text = "无信号"
            Accel_offset_X.Text = "无信号"
            Accel_Sensor_Y.Text = "无信号"
            Accel_offset_Y.Text = "无信号"
            Accel_Sensor_Z.Text = "无信号"
            Accel_offset_Z.Text = "无信号"
            Accel_X.Text = "无信号"
            Accel_Y.Text = "无信号"
            Accel_Z.Text = "无信号"

            Gyro_Sensor_X.Text = "无信号"
            Gyro_offset_X.Text = "无信号"
            Gyro_Sensor_Y.Text = "无信号"
            Gyro_offset_Y.Text = "无信号"
            Gyro_Sensor_Z.Text = "无信号"
            Gyro_offset_Z.Text = "无信号"

            Gyro_X.Text = "无信号"
            Gyro_Y.Text = "无信号"
            Gyro_Z.Text = "无信号"

            MPU6050_Temperature.Text = "无信号"
            MS5611_Temperature.Text = "无信号"
            MS5611_Pressure.Text = "无信号"
            MS5611_high.Text = "无信号"

            HMC5883L_X.Text = "无信号"
            HMC5883L_Y.Text = "无信号"
            HMC5883L_Z.Text = "无信号"
            HMC5883L_angle.Text = "无信号"

            HMC5883L_X_offset.Text = "无信号"
            HMC5883L_Y_offset.Text = "无信号"
            HMC5883L_Z_offset.Text = "无信号"

            High.Text = "无信号"

            ROLL.Text = "无信号"
            PITCH.Text = "无信号"
            YAW.Text = "无信号"

            High.Text = "无信号"
            High_Accel.Text = "无信号"

            'ROLL_G_Kp.Text = "无信号"
            'ROLL_G_Ki.Text = "无信号"
            'ROLL_G_Kd.Text = "无信号"

            'ROLL_Angle_Kp.Text = "无信号"
            'ROLL_Angle_Ki.Text = "无信号"
            'ROLL_Angle_Kd.Text = "无信号"


        End If
    End Sub


   

    '----------------------------------------------------------------------------------------------
    '——————————————————获取串口参数部分—————————————————————
    '----------------------------------------------------------------------------------------------


    '从串口缓冲中读取数据包
    Private Function ReadBuf()
        Dim index As Integer

        Do While Check_Start() = False                  '检测包头
            If SerialPort1.BytesToRead <= 0 Then        '数据读取完毕，没有包头，读取包失败
                Return False
            End If
        Loop

        For index = 0 To Buf_Size - 1                   '读取数据
            Receive_Buf(index) = SerialPort1.ReadByte()
        Next index

        If Check_End() = False Then                     '检测包尾
            Return False
        End If

        Return True

    End Function


    '检测包头
    Private Function Check_Start()
        If SerialPort1.ReadByte() = &H7F Then               '包头
            If SerialPort1.ReadByte() = &HFF Then           '包头2
                If SerialPort1.ReadByte() = Buf_Size Then   '数据大小
                    If SerialPort1.ReadByte() = 0 Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function


    '检测包尾
    Private Function Check_End()
        If SerialPort1.ReadByte() = 123 Then                '校验
            If SerialPort1.ReadByte() = 0 Then
                If SerialPort1.ReadByte() = &HFF Then           '包尾1
                    If SerialPort1.ReadByte() = &HFE Then       '包尾2
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function


    '读取两个字节无符号数据
    Public Function Read_16(buf_index As Byte)
        Return System.BitConverter.ToUInt16(Receive_Buf, buf_index * 2)
    End Function

    '读取两个字节有符号数据
    Public Function Read_16_signed(buf_index As Byte)
        Return System.BitConverter.ToInt16(Receive_Buf, buf_index * 2)   '数组前面的低位，后面高位
    End Function

    '读取四个字节有符号数据
    Public Function Read_32_signed(buf_index As Byte)
        Return System.BitConverter.ToInt32(Receive_Buf, buf_index * 2)
    End Function




    '-----------------------------------------------------------------------------------------
    '-----------------------------绘制曲线部分------------------------------------------------
    '-----------------------------------------------------------------------------------------


    '开始绘制曲线
    Private Sub Print_openBtn_Click_1(sender As Object, e As EventArgs) Handles Print_openBtn.Click
        Form2.Show()        '打开绘制曲线窗口
        printLine = True    '标志位记录下当前正在绘制曲线

        Channel1_nameBox.Enabled = True     '打开通道选择选项
        Channel2_nameBox.Enabled = True
        Channel3_nameBox.Enabled = True
        Channel4_nameBox.Enabled = True

        ' Last_Print_time = DateAndTime.Timer
        'Timer2.Enabled = True       '开启定时器绘制曲线

    End Sub


    '曲线重置
    Private Sub Print_RstBtn_Click(sender As Object, e As EventArgs) Handles Print_RstBtn.Click

        Form2.Curve1.RealCurveInit()    '将曲线重置
        'Form2.Curve1.ZoomReset()

    End Sub


    '定时器2，用于绘图
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If printLine = True Then
            printNum(0) = Check_Channel(1) * channel_gain(0)
            printNum(1) = Check_Channel(2) * channel_gain(1)
            printNum(2) = Check_Channel(3) * channel_gain(2)
            printNum(3) = Check_Channel(4) * channel_gain(3)

            Form2.Curve1.RealCurve(printNum)
        End If
    End Sub




    '绘制曲线时的参数值显示
    Private Sub Print_Channel()
        Form2.printBuf = "通道一: " & Format(Check_Channel(1), "0.000") & " 通道二: " & Format(Check_Channel(2), "0.000") & " 通道三: " & Format(Check_Channel(3), "0.000") & " 通道四: " & Format(Check_Channel(4), "0.000")
        Form2.printNum()
    End Sub


    '读取相应曲线通道的参数
    Private Function Check_Channel(Channel As Byte)
        Dim result As Double = 0


        Select Case channel_index(Channel - 1)  '获取相应曲线要监测的参数，读取参数值
            Case 1
                result = Read_16_signed(10) / 16384  '计算加速度
            Case 2
                result = Read_16_signed(11) / 16384
            Case 3
                result = Read_16_signed(12) / 16384
            Case 4
                result = Read_16_signed(13) / 131   '计算角速度
            Case 5
                result = Read_16_signed(14) / 131
            Case 6
                result = Read_16_signed(15) / 131
            Case 7
                result = Read_16_signed(29) / 10    '姿态
            Case 8
                result = Read_16_signed(30) / 10
            Case 9
                result = Read_16_signed(31) / 10
            Case 10
                result = Read_16_signed(6 + Channel - 1) '临时信号
        End Select

        ' result = result * channel_gain(Channel - 1)

        Return result
    End Function



    '---------------------------------绘图参数初始化--------------------------------------------
    '------------添加检测需要的绘图参数，过程参数为响应通道的项目选择ComboBox---------
    Private Sub Print_Channel_init(ByRef Channel_NameBox As System.Windows.Forms.ComboBox)
        Channel_NameBox.Items.Add("无信号源")
        Channel_NameBox.Items.Add("X轴加速度")
        Channel_NameBox.Items.Add("Y轴加速度")
        Channel_NameBox.Items.Add("Z轴加速度")
        Channel_NameBox.Items.Add("X轴角速度")
        Channel_NameBox.Items.Add("Y轴角速度")
        Channel_NameBox.Items.Add("Z轴角速度")
        Channel_NameBox.Items.Add("侧滚(Roll) ")
        Channel_NameBox.Items.Add("俯仰(PITCH) ")
        Channel_NameBox.Items.Add("偏摆(YAW) ")

        Select Case Channel_NameBox.Name
            Case Channel1_nameBox.Name
                Channel_NameBox.Items.Add("临时信号源1 ")
            Case Channel2_nameBox.Name
                Channel_NameBox.Items.Add("临时信号源2 ")
            Case Channel3_nameBox.Name
                Channel_NameBox.Items.Add("临时信号源3 ")
            Case Channel4_nameBox.Name
                Channel_NameBox.Items.Add("临时信号源4 ")
        End Select
        Channel_NameBox.SelectedIndex() = 0
    End Sub




    '-------------------------------------绘图参数选择----------------------------------------------------

    '绘制曲线时选中相应项目，提供不同的精度和倍率选择
    '参数Channel_NameBox为某一通道监测的项目选项，Channel_GainBox为倍率选项
    Private Sub Print_Channel_Select(ByRef Channel_NameBox As System.Windows.Forms.ComboBox, ByRef Channel_GainBox As System.Windows.Forms.ComboBox)

        Dim index As Byte

        '根据Channel选择数组index
        Select Case Channel_NameBox.Name
            Case Channel1_nameBox.Name
                index = 0
            Case Channel2_nameBox.Name
                index = 1
            Case Channel3_nameBox.Name
                index = 2
            Case Channel4_nameBox.Name
                index = 3
        End Select

        '记录被选中的信号源，开始绘制曲线
        channel_index(index) = Channel_NameBox.SelectedIndex

        Select Case Channel_NameBox.SelectedIndex
            Case 0
                Channel_GainBox.Enabled = False                    '无信号源，灵敏度无法选择，并清空选项
                Channel_GainBox.Items.Clear()
                Channel_GainBox.Items.Add("无信号源")
                Channel_GainBox.SelectedIndex = 0
                channel_gain(index) = 0                     '设置倍率
                Form2.Curve1.CurveLabelText(index) = Channel_NameBox.Text  '在曲线中更新曲线标签
            Case 1 To 3
                Channel_GainBox.Enabled = True                 '根据信号源添加相应的灵敏度选项
                Channel_GainBox.Items.Clear()
                Channel_GainBox.Items.Add("500格/g")           '添加倍率选项
                Channel_GainBox.Items.Add("750格/g")
                Channel_GainBox.Items.Add("1000格/g")
                Channel_GainBox.Items.Add("1500格/g")
                Channel_GainBox.Items.Add("2000格/g")
                Channel_GainBox.SelectedIndex = 0               '默认倍率
                channel_gain(index) = 500
                Form2.Curve1.CurveLabelText(index) = Channel_NameBox.Text + "(" + Channel_GainBox.Text + ")"
            Case 4 To 6
                Channel_GainBox.Enabled = True
                Channel_GainBox.Items.Clear()
                Channel_GainBox.Items.Add("1格/(deg/s)")
                Channel_GainBox.Items.Add("2格/(deg/s)")
                Channel_GainBox.Items.Add("3格/(deg/s)")
                Channel_GainBox.Items.Add("4格/(deg/s)")
                Channel_GainBox.SelectedIndex = 2
                channel_gain(index) = 3
                Form2.Curve1.CurveLabelText(index) = Channel_NameBox.Text + "(" + Channel_GainBox.Text + ")"
            Case 7 To 9
                Channel_GainBox.Enabled = True
                Channel_GainBox.Items.Clear()
                Channel_GainBox.Items.Add("2格/deg")
                Channel_GainBox.Items.Add("5格/deg")
                Channel_GainBox.Items.Add("10格/deg")
                Channel_GainBox.Items.Add("20格/deg")
                Channel_GainBox.SelectedIndex = 0
                channel_gain(index) = 2
                Form2.Curve1.CurveLabelText(index) = Channel_NameBox.Text + "(" + Channel_GainBox.Text + ")"
            Case 10
                Channel_GainBox.Enabled = True
                Channel_GainBox.Items.Clear()
                Channel_GainBox.Items.Add("0.1格/单位")
                Channel_GainBox.Items.Add("0.5格/单位")
                Channel_GainBox.Items.Add("1格/单位")
                Channel_GainBox.Items.Add("2格/单位")
                Channel_GainBox.Items.Add("5格/单位")
                Channel_GainBox.Items.Add("10格/单位")
                Channel_GainBox.SelectedIndex = 2
                channel_gain(0) = 1
                Form2.Curve1.CurveLabelText(index) = Channel_NameBox.Text + "(" + Channel_GainBox.Text + ")"

                '更新曲线标签
        End Select
    End Sub

    '根据不同的绘图项目，显示不同的绘图精度
    Private Sub Channel1_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel1_nameBox.SelectedIndexChanged

        Print_Channel_Select(Channel1_nameBox, Channel1_gainBox)

    End Sub

    Private Sub Channel2_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel2_nameBox.SelectedIndexChanged

        Print_Channel_Select(Channel2_nameBox, Channel2_gainBox)

    End Sub

    Private Sub Channel3_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel3_nameBox.SelectedIndexChanged
        
        Print_Channel_Select(Channel3_nameBox, Channel3_gainBox)

    End Sub

    Private Sub Channel4_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel4_nameBox.SelectedIndexChanged
        
        Print_Channel_Select(Channel4_nameBox, Channel4_gainBox)

    End Sub

    '-------------------------------------绘图精度选择-------------------------------------------------------
    '更新精度
    Private Sub Channel1_gain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel1_gainBox.SelectedIndexChanged
        channel_gain(0) = Val(Channel1_gainBox.Text)    '获取列表中的倍率值
        Form2.Curve1.CurveLabelText(0) = Channel1_nameBox.Text + "(" + Channel1_gainBox.Text + ")"
        '更新曲线的标签
    End Sub

    Private Sub Channel2_gain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel2_gainBox.SelectedIndexChanged
        channel_gain(1) = Val(Channel2_gainBox.Text)
        Form2.Curve1.CurveLabelText(1) = Channel2_nameBox.Text + "(" + Channel2_gainBox.Text + ")"
    End Sub

    Private Sub Channel3_gain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel3_gainBox.SelectedIndexChanged
        channel_gain(2) = Val(Channel3_gainBox.Text)
        Form2.Curve1.CurveLabelText(2) = Channel3_nameBox.Text + "(" + Channel3_gainBox.Text + ")"
    End Sub

    Private Sub Channel4_gain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Channel4_gainBox.SelectedIndexChanged
        channel_gain(3) = Val(Channel4_gainBox.Text)
        Form2.Curve1.CurveLabelText(3) = Channel4_nameBox.Text + "(" + Channel4_gainBox.Text + ")"
    End Sub


    '-----------------------------------------绘图采样周期选择-----------------------------------------------
    Private Sub Print_speedBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Print_speedBox.SelectedIndexChanged
        'Print_speed = Val(Print_speedBox.Text)  '更新曲线采样时间
        Timer2.Interval = Val(Print_speedBox.Text)  '更新曲线采样时间
    End Sub




    '--------------------------------------------------------------------------------------------------
    '————————————————————机体操作部分——————————————————————
    '-------------------------------------------------------------------------------------------------


    '-----------------------------------设置接收器信号函数--------------------------------------------

    '参数receiver为设置的项目的label，如油门为THRO，command为向下位机发送的操作指令，如设置油门发送3
    Private Sub receiver_set(receiver As System.Windows.Forms.Label, command As Byte)
        Dim inputStr As String
        Dim offset As Byte = 0      '由于油门范围为0~100，其他3项为-50~50，需要偏移
        'receiver.Tag为预先在空间中设定好的名称，油门的Tag为“油门”
        inputStr = InputBox("请输入" + receiver.Tag + "设定值:", receiver.Tag + "设定", Val(receiver.Text))
        If Len(inputStr) <> 0 Then

            If (receiver.Name <> THRO.Name) Then    '除油门外都需要偏移
                offset = 50
            End If

            If Val(inputStr) >= 0 - offset And Val(inputStr) <= 100 - offset Then
                Try
                    Dim order(1) As Byte
                    order(0) = command
                    SerialPort1.Write(order, 0, 1)
                    order(0) = Val(inputStr) + offset
                    SerialPort1.Write(order, 0, 1)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("请正确输入" + receiver.Tag + "设定值！", MsgBoxStyle.Exclamation, "输入错误")
            End If


        End If
    End Sub


    '设置油门等
    Private Sub THRO_Click(sender As Object, e As EventArgs) Handles THRO.Click
        receiver_set(THRO, 3)
    End Sub

    '设置方向舵
    Private Sub RUDD_Click(sender As Object, e As EventArgs) Handles RUDD.Click
        receiver_set(RUDD, 4)
        'Dim inputStr As String
        'inputStr = InputBox("请输入方向舵设定值:", "方向舵设定", Val(RUDD.Text))
        'If Len(inputStr) <> 0 Then

        '    If Val(inputStr) >= -50 And Val(inputStr) <= 50 Then
        '        Try
        '            Dim order(1) As Byte
        '            order(0) = 4
        '            SerialPort1.Write(order, 0, 1)
        '            order(0) = Val(inputStr) + 50
        '            SerialPort1.Write(order, 0, 1)
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '        End Try

        '    Else
        '        MsgBox("请正确输入方向舵设定值！", MsgBoxStyle.Exclamation, "输入错误")
        '    End If
        'End If
    End Sub

    '设置升降舵
    Private Sub ELEV_Click(sender As Object, e As EventArgs) Handles ELEV.Click
        receiver_set(ELEV, 5)
    End Sub

    '设置副翼
    Private Sub AILE_Click(sender As Object, e As EventArgs) Handles AILE.Click
        receiver_set(AILE, 6)
    End Sub



    '油门紧急停止，只发送一个字节数据防止传输错误
    Private Sub Stop_btn_Click_2(sender As Object, e As EventArgs) Handles Stop_btn.Click
        Try
            Dim order(1) As Byte
            order(0) = 7
            SerialPort1.Write(order, 0, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '恢复中位，只发送一个字节数据防止传输错误
    Private Sub Balance_Btn_Click_2(sender As Object, e As EventArgs) Handles Balance_Btn.Click
        Try
            Dim order(1) As Byte
            order(0) = 8
            SerialPort1.Write(order, 0, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    '对机体信息重置，校正
    Private Sub Rst_btn_Click(sender As Object, e As EventArgs) Handles Rst_btn.Click
        Dim order(1) As Byte
        Try
            If MsgBox("即将进行罗盘校正", MsgBoxStyle.OkCancel, "罗盘校正") = MsgBoxResult.Ok Then
                'HMC5883L_X_offset.Text = 0
                'HMC5883L_Y_offset.Text = 0
                'HMC5883L_Z_offset.Text = 0

                order(0) = 2
                SerialPort1.Write(order, 0, 1)

                Message_Form.Text = "罗盘校正"
                Message_Form.ShowDialog()
                Check_HMC5883L_offset()

            End If
            If MsgBox("请将控制器水平放置", MsgBoxStyle.OkCancel, "水平校正") = MsgBoxResult.Ok Then
                order(0) = 0
                SerialPort1.Write(order, 0, 1)
                Check_MPU6050_offset()
            End If

            If MsgBox("将当前高度设置为参考高度", MsgBoxStyle.OkCancel, "高度置零") = MsgBoxResult.Ok Then
                order(0) = 1
                SerialPort1.Write(order, 0, 1)
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    



    '---------------------------------------------------------------------------------------------
    '-----------------------------------单次读取下位机参数部分------------------------------------
    '每次读取先发送一个字节指令，如果Buf的第5位收到的数据和发出的指令一致，表明数据已经发送到第4位
    '---------------------------------------------------------------------------------------------

    Private Sub Check_MPU6050_offset()
        Dim order(1) As Byte

        Try
            '查看加速度传感器校正数据
            order(0) = 25
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 25
            Loop
            Accel_offset_X.Text = Read_16_signed(4)

            order(0) = 26
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 26
            Loop
            Accel_offset_Y.Text = Read_16_signed(4)

            order(0) = 27
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 27
            Loop
            Accel_offset_Z.Text = Read_16_signed(4)

            '查看陀螺仪校正数据
            order(0) = 28
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 28
            Loop
            Gyro_offset_X.Text = Read_16_signed(4)

            order(0) = 29
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 29
            Loop
            Gyro_offset_Y.Text = Read_16_signed(4)

            order(0) = 30
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 30
            Loop
            Gyro_offset_Z.Text = Read_16_signed(4)


            order(0) = 24
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = &HFFFF

            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Check_HMC5883L_offset()
        Dim order(1) As Byte

        Try
            '查看加速度传感器校正数据
            order(0) = 31
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 31
            Loop
            HMC5883L_X_offset.Text = Read_16_signed(4)

            order(0) = 32
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 32
            Loop
            HMC5883L_Y_offset.Text = Read_16_signed(4)

            order(0) = 33
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 33
            Loop
            HMC5883L_Z_offset.Text = Read_16_signed(4)

            order(0) = 24
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = &HFFFF

            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Sub Check_PID()          '获取PID参数
        Dim order(1) As Byte

        Try
            'Roll
            order(0) = 34
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 34
            Loop
            Form3.ROLL_G_Kp.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 35
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 35
            Loop
            Form3.ROLL_G_Ki.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 36
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 36
            Loop
            Form3.ROLL_G_Kd.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 37
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 37
            Loop
            Form3.ROLL_Angle_Kp.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 38
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 38
            Loop
            Form3.ROLL_Angle_Ki.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 39
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 39
            Loop
            Form3.ROLL_Angle_Kd.Text = Format(Read_16(4) / 100, "0.00")

            'Pitch
            order(0) = 40
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 40
            Loop
            Form3.PITCH_G_Kp.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 41
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 41
            Loop
            Form3.PITCH_G_Ki.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 42
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 42
            Loop
            Form3.PITCH_G_Kd.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 43
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 43
            Loop
            Form3.PITCH_Angle_Kp.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 44
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 44
            Loop
            Form3.PITCH_Angle_Ki.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 45
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 45
            Loop
            Form3.PITCH_Angle_Kd.Text = Format(Read_16(4) / 100, "0.00")

            'Yaw
            'Pitch
            order(0) = 46
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 46
            Loop
            Form3.YAW_G_Kp.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 47
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 47
            Loop
            Form3.YAW_G_Ki.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 48
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = 48
            Loop
            Form3.YAW_G_Kd.Text = Format(Read_16(4) / 100, "0.00")

            order(0) = 24
            SerialPort1.Write(order, 0, 1)
            Do Until Read_16(5) = &HFFFF

            Loop

            Form3.Save_Btn.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    '---------------------------定时器1用于参数更新-----------------------------------------------
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If printLine Then
            Print_Channel()         '更新曲线上显示的参数
        End If

        If (Read_16(5) = 0) Then    '状态位为0即控制器复位，重新读取配置信息
            Check_PID()
            Check_MPU6050_offset()
            Check_HMC5883L_offset()
        End If

        '数据接收
        If Read_16(0) = 0 Then
            RUDD.Text = "无信号"
        Else
            '数据处理()
            RUDD.Text = Fix((Read_16(0) - 1100) / 8 + 0.5) - 50    '方向舵  
        End If

        If Read_16(1) = 0 Then
            THRO.Text = "无信号"
        Else
            '数据处理()
            THRO.Text = Fix((Read_16(1) - 1100) / 8 + 0.5)         '油门
        End If

        If Read_16(2) = 0 Then
            AILE.Text = "无信号"
        Else
            '数据处理()
            AILE.Text = Fix((Read_16(2) - 1100) / 8 + 0.5) - 50    '副翼
        End If

        If Read_16(3) = 0 Then
            ELEV.Text = "无信号"
        Else
            '数据处理()
            ELEV.Text = Fix((Read_16(3) - 1100) / 8 + 0.5) - 50    '升降舵
        End If




        If Read_16(32) = 0 Then
            Motor1.Text = "无信号"
        Else
            '数据处理()
            Motor1.Text = Fix((Read_16(32) - 1100) / 8 + 0.5)         '1号电机
        End If

        If Read_16(33) = 0 Then
            Motor2.Text = "无信号"
        Else
            '数据处理()
            Motor2.Text = Fix((Read_16(33) - 1100) / 8 + 0.5)         '2号电机
        End If

        If Read_16(34) = 0 Then
            Motor3.Text = "无信号"
        Else
            '数据处理()
            Motor3.Text = Fix((Read_16(34) - 1100) / 8 + 0.5)         '3号电机
        End If

        If Read_16(35) = 0 Then
            Motor4.Text = "无信号"
        Else
            '数据处理()
            Motor4.Text = Fix((Read_16(35) - 1100) / 8 + 0.5)         '4号电机
        End If

        Accel_Sensor_X.Text = Read_16_signed(10)
        'Accel_offset_X.Text = Read_16_signed(5)
        Accel_Sensor_Y.Text = Read_16_signed(11)
        'Accel_offset_Y.Text = Read_16_signed(7)
        Accel_Sensor_Z.Text = Read_16_signed(12)
        'Accel_offset_Z.Text = Read_16_signed(9)

        Gyro_Sensor_X.Text = Read_16_signed(13)
        ' Gyro_offset_X.Text = Read_16_signed(11)
        Gyro_Sensor_Y.Text = Read_16_signed(14)
        ' Gyro_offset_Y.Text = Read_16_signed(13)
        Gyro_Sensor_Z.Text = Read_16_signed(15)
        'Gyro_offset_Z.Text = Read_16_signed(15)
        MPU6050_Temperature.Text = Format(Read_16_signed(16) / 340 + 36.53, "0.000")
        MS5611_Temperature.Text = Read_32_signed(17) / 100
        MS5611_Pressure.Text = Read_32_signed(19) / 1000
        MS5611_high.Text = Read_32_signed(21) / 100
        HMC5883L_X.Text = Read_16_signed(23)
        HMC5883L_Y.Text = Read_16_signed(24)
        HMC5883L_Z.Text = Read_16_signed(25)
        HMC5883L_angle.Text = Read_16_signed(26) / 10

        'HMC5883L_X_offset.Text = Read_16_signed(27)
        'HMC5883L_Y_offset.Text = Read_16_signed(28)
        'HMC5883L_Z_offset.Text = Read_16_signed(29)
        ROLL.Text = Read_16_signed(29) / 10
        PITCH.Text = Read_16_signed(30) / 10
        YAW.Text = Read_16_signed(31) / 10

        'ROLL_G_Kp.Text = Format(Read_16(33) / 100, "0.00")
        'ROLL_G_Ki.Text = Format(Read_16(34) / 100, "0.00")
        'ROLL_G_Kd.Text = Format(Read_16(35) / 100, "0.00")
        'ROLL_Angle_Kp.Text = Format(Read_16(36) / 100, "0.00")
        'ROLL_Angle_Ki.Text = Format(Read_16(37) / 100, "0.00")
        'ROLL_Angle_Kd.Text = Format(Read_16(38) / 100, "0.00")

        'PITCH_G_Kp.Text = Format(Read_16(39) / 100, "0.00")
        'PITCH_G_Ki.Text = Format(Read_16(40) / 100, "0.00")
        'PITCH_G_Kd.Text = Format(Read_16(41) / 100, "0.00")
        'PITCH_Angle_Kp.Text = Format(Read_16(42) / 100, "0.00")
        'PITCH_Angle_Ki.Text = Format(Read_16(43) / 100, "0.00")
        'PITCH_Angle_Kd.Text = Format(Read_16(44) / 100, "0.00")

        'YAW_G_Kp.Text = Format(Read_16(49) / 100, "0.00")
        'YAW_G_Ki.Text = Format(Read_16(50) / 100, "0.00")
        'YAW_G_Kd.Text = Format(Read_16(51) / 100, "0.00")

        High.Text = Format(Read_16(27) / 1000, "0.000")
        High_Accel.Text = Format(Read_16_signed(28) / 1000, "0.000")
        '       High_Speed.Text = Format(Read_16_signed(35) / 1000, "0.000")

        Accel_X.Text = Format(Val(Accel_Sensor_X.Text) / 16384, "0.000")
        Accel_Y.Text = Format(Val(Accel_Sensor_Y.Text) / 16384, "0.000")
        Accel_Z.Text = Format(Val(Accel_Sensor_Z.Text) / 16384, "0.000")

        Gyro_X.Text = Format(Val(Gyro_Sensor_X.Text) / 131, "0.000")
        Gyro_Y.Text = Format(Val(Gyro_Sensor_Y.Text) / 131, "0.000")
        Gyro_Z.Text = Format(Val(Gyro_Sensor_Z.Text) / 131, "0.000")

        'High_Accel.Text = Val(Accel_Z.Text) / Math.Sqrt(Math.Tan(Val(ROLL.Text) / 57.3) * Math.Tan(Val(ROLL.Text) / 57.3) + Math.Tan(Val(PITCH.Text) / 57.3) * Math.Tan(Val(PITCH.Text) / 57.3) + 1) - Val(Accel_X.Text) * Math.Sin(Val(ROLL.Text) / 57.3) + Val(Accel_Y.Text) * Math.Sin(Val(PITCH.Text) / 57.3)
    End Sub

    











    '已注释，之前不用定时器更新数据时使用该接收函数


    ''接收数据调用过程
    'Private Sub Sp_Receiving(ByVal sender As Object, ByVal e As EventArgs)


    '    Now = DateAndTime.Timer

    '    Try
    '        'receivebytes_count.Text = Str(Val(receivebytes_count.Text) + SerialPort1.BytesToRead)'数据计数
    '        'While SerialPort1.BytesToRead > 0   '查看串口缓存中数据量
    '        ' Threading.Thread.Sleep(10) '延时
    '        'receive_data = SerialPort1.ReadExisting.ToString '读取缓冲区中的数据
    '        ReadBuf()
    '        SerialPort1.DiscardInBuffer()
    '        If ((Now - Last_Print_time) * 1000 > Print_speed) And printLine Then    '是否到达曲线采样时间

    '            If ReadBuf() = True Then

    '                Last_Print_time = Now

    '                printNum(0) = Check_Channel(1) * channel_gain(0)
    '                printNum(1) = Check_Channel(2) * channel_gain(1)
    '                printNum(2) = Check_Channel(3) * channel_gain(2)
    '                printNum(3) = Check_Channel(4) * channel_gain(3)

    '                Form2.Curve1.RealCurve(printNum)

    '                'Last_Print_time = DateAndTime.Timer
    '                SerialPort1.DiscardInBuffer()
    '            End If


    '        ElseIf (Now - Last_Receive_time) * 1000 > 500 Then      '是否到达参数采样时间

    '            If ReadBuf() = True Then    '判断是否成功获取数据包
    '                Last_Receive_time = Now   '读取成功，记录下此次获取的时间

    '                If printLine Then
    '                    Print_Channel()         '更新绘图参数
    '                End If

    '                '数据接收
    '                If Read_16(0) = 0 Then
    '                    RUDD.Text = "无信号"
    '                Else
    '                    '数据处理()
    '                    RUDD.Text = Fix((Read_16(0) - 1100) / 8 + 0.5) - 50    '方向舵  
    '                End If

    '                If Read_16(1) = 0 Then
    '                    THRO.Text = "无信号"
    '                Else
    '                    '数据处理()
    '                    THRO.Text = Fix((Read_16(1) - 1100) / 8 + 0.5)         '油门
    '                End If

    '                If Read_16(2) = 0 Then
    '                    AILE.Text = "无信号"
    '                Else
    '                    '数据处理()
    '                    AILE.Text = Fix((Read_16(2) - 1100) / 8 + 0.5) - 50    '副翼
    '                End If

    '                If Read_16(3) = 0 Then
    '                    ELEV.Text = "无信号"
    '                Else
    '                    '数据处理()
    '                    ELEV.Text = Fix((Read_16(3) - 1100) / 8 + 0.5) - 50    '升降舵
    '                End If



    '                Accel_Sensor_X.Text = Read_16_signed(4)
    '                Accel_offset_X.Text = Read_16_signed(5)
    '                Accel_Sensor_Y.Text = Read_16_signed(6)
    '                Accel_offset_Y.Text = Read_16_signed(7)
    '                Accel_Sensor_Z.Text = Read_16_signed(8)
    '                Accel_offset_Z.Text = Read_16_signed(9)

    '                Gyro_Sensor_X.Text = Read_16_signed(10)
    '                Gyro_offset_X.Text = Read_16_signed(11)
    '                Gyro_Sensor_Y.Text = Read_16_signed(12)
    '                Gyro_offset_Y.Text = Read_16_signed(13)
    '                Gyro_Sensor_Z.Text = Read_16_signed(14)
    '                Gyro_offset_Z.Text = Read_16_signed(15)
    '                MPU6050_Temperature.Text = Format(Read_16_signed(16) / 340 + 36.53, "0.000")
    '                MS5611_Temperature.Text = Read_32_signed(17) / 100
    '                MS5611_Pressure.Text = Read_32_signed(19) / 1000
    '                MS5611_high.Text = Read_32_signed(21) / 100
    '                HMC5883L_X.Text = Read_16_signed(23)
    '                HMC5883L_Y.Text = Read_16_signed(24)
    '                HMC5883L_Z.Text = Read_16_signed(25)
    '                HMC5883L_angle.Text = Read_16_signed(26) / 10

    '                HMC5883L_X_offset.Text = Read_16_signed(27)
    '                HMC5883L_Y_offset.Text = Read_16_signed(28)
    '                HMC5883L_Z_offset.Text = Read_16_signed(29)
    '                YAW.Text = Read_16_signed(30) / 10
    '                PITCH.Text = Read_16_signed(31) / 10
    '                ROLL.Text = Read_16_signed(32) / 10

    '                'ROLL_G_Kp.Text = Format(Read_16(33) / 100, "0.00")
    '                'ROLL_G_Ki.Text = Format(Read_16(34) / 100, "0.00")
    '                'ROLL_G_Kd.Text = Format(Read_16(35) / 100, "0.00")
    '                'ROLL_Angle_Kp.Text = Format(Read_16(36) / 100, "0.00")
    '                'ROLL_Angle_Ki.Text = Format(Read_16(37) / 100, "0.00")
    '                'ROLL_Angle_Kd.Text = Format(Read_16(38) / 100, "0.00")

    '                'PITCH_G_Kp.Text = Format(Read_16(39) / 100, "0.00")
    '                'PITCH_G_Ki.Text = Format(Read_16(40) / 100, "0.00")
    '                'PITCH_G_Kd.Text = Format(Read_16(41) / 100, "0.00")
    '                'PITCH_Angle_Kp.Text = Format(Read_16(42) / 100, "0.00")
    '                'PITCH_Angle_Ki.Text = Format(Read_16(43) / 100, "0.00")
    '                'PITCH_Angle_Kd.Text = Format(Read_16(44) / 100, "0.00")

    '                'YAW_G_Kp.Text = Format(Read_16(49) / 100, "0.00")
    '                'YAW_G_Ki.Text = Format(Read_16(50) / 100, "0.00")
    '                'YAW_G_Kd.Text = Format(Read_16(51) / 100, "0.00")

    '                High.Text = Format(Read_16(33) / 1000, "0.000")
    '                High_Accel.Text = Format(Read_16_signed(34) / 1000, "0.000")
    '                '       High_Speed.Text = Format(Read_16_signed(35) / 1000, "0.000")




    '                Accel_X.Text = Format(Val(Accel_Sensor_X.Text) / 16384, "0.000")
    '                Accel_Y.Text = Format(Val(Accel_Sensor_Y.Text) / 16384, "0.000")
    '                Accel_Z.Text = Format(Val(Accel_Sensor_Z.Text) / 16384, "0.000")

    '                Gyro_X.Text = Format(Val(Gyro_Sensor_X.Text) / 131, "0.000")
    '                Gyro_Y.Text = Format(Val(Gyro_Sensor_Y.Text) / 131, "0.000")
    '                Gyro_Z.Text = Format(Val(Gyro_Sensor_Z.Text) / 131, "0.000")

    '                'High_Accel.Text = Val(Accel_Z.Text) / Math.Sqrt(Math.Tan(Val(ROLL.Text) / 57.3) * Math.Tan(Val(ROLL.Text) / 57.3) + Math.Tan(Val(PITCH.Text) / 57.3) * Math.Tan(Val(PITCH.Text) / 57.3) + 1) - Val(Accel_X.Text) * Math.Sin(Val(ROLL.Text) / 57.3) + Val(Accel_Y.Text) * Math.Sin(Val(PITCH.Text) / 57.3)


    '            End If


    '        Else
    '            SerialPort1.DiscardInBuffer()       '不到采样时间，丢弃数据


    '        End If

    '        'End While

    '        'SerialPort1.DiscardInBuffer()'清空串口缓冲

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
