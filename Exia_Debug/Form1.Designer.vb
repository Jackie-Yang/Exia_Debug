<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.openbtn = New System.Windows.Forms.Button()
        Me.portnamebox = New System.Windows.Forms.ComboBox()
        Me.baudratebox = New System.Windows.Forms.ComboBox()
        Me.statuslabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Rst_btn = New System.Windows.Forms.Button()
        Me.RUDD = New System.Windows.Forms.Label()
        Me.THRO = New System.Windows.Forms.Label()
        Me.AILE = New System.Windows.Forms.Label()
        Me.ELEV = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Accel_Z = New System.Windows.Forms.Label()
        Me.Accel_Y = New System.Windows.Forms.Label()
        Me.Accel_X = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Accel_offset_Z = New System.Windows.Forms.Label()
        Me.Accel_Sensor_Z = New System.Windows.Forms.Label()
        Me.Accel_offset_Y = New System.Windows.Forms.Label()
        Me.Accel_Sensor_Y = New System.Windows.Forms.Label()
        Me.Accel_offset_X = New System.Windows.Forms.Label()
        Me.Accel_Sensor_X = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ROLL = New System.Windows.Forms.Label()
        Me.PITCH = New System.Windows.Forms.Label()
        Me.YAW = New System.Windows.Forms.Label()
        Me.PID_Set = New System.Windows.Forms.Button()
        Me.Balance_Btn = New System.Windows.Forms.Button()
        Me.Stop_btn = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Gyro_Z = New System.Windows.Forms.Label()
        Me.Gyro_Y = New System.Windows.Forms.Label()
        Me.Gyro_X = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Gyro_offset_Z = New System.Windows.Forms.Label()
        Me.Gyro_Sensor_Z = New System.Windows.Forms.Label()
        Me.Gyro_offset_Y = New System.Windows.Forms.Label()
        Me.Gyro_Sensor_Y = New System.Windows.Forms.Label()
        Me.Gyro_offset_X = New System.Windows.Forms.Label()
        Me.Gyro_Sensor_X = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.High_Speed = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.High_Accel = New System.Windows.Forms.Label()
        Me.High = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.MS5611_high = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.MS5611_Pressure = New System.Windows.Forms.Label()
        Me.MS5611_Temperature = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.MPU6050_Temperature = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.HMC5883L_Y = New System.Windows.Forms.Label()
        Me.HMC5883L_Z_offset = New System.Windows.Forms.Label()
        Me.HMC5883L_Y_offset = New System.Windows.Forms.Label()
        Me.HMC5883L_X_offset = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.HMC5883L_angle = New System.Windows.Forms.Label()
        Me.HMC5883L_Z = New System.Windows.Forms.Label()
        Me.HMC5883L_X = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Print_openBtn = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Print_speedBox = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Channel1_gainBox = New System.Windows.Forms.ComboBox()
        Me.Channel2_gainBox = New System.Windows.Forms.ComboBox()
        Me.Channel3_gainBox = New System.Windows.Forms.ComboBox()
        Me.Channel4_gainBox = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Channel1_nameBox = New System.Windows.Forms.ComboBox()
        Me.Channel3_nameBox = New System.Windows.Forms.ComboBox()
        Me.Channel4_nameBox = New System.Windows.Forms.ComboBox()
        Me.Channel2_nameBox = New System.Windows.Forms.ComboBox()
        Me.Print_RstBtn = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Motor4 = New System.Windows.Forms.Label()
        Me.Motor3 = New System.Windows.Forms.Label()
        Me.Motor2 = New System.Windows.Forms.Label()
        Me.Motor1 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'openbtn
        '
        Me.openbtn.Location = New System.Drawing.Point(132, 26)
        Me.openbtn.Name = "openbtn"
        Me.openbtn.Size = New System.Drawing.Size(62, 20)
        Me.openbtn.TabIndex = 0
        Me.openbtn.Text = "打开串口"
        Me.openbtn.UseVisualStyleBackColor = True
        '
        'portnamebox
        '
        Me.portnamebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.portnamebox.FormattingEnabled = True
        Me.portnamebox.Location = New System.Drawing.Point(59, 26)
        Me.portnamebox.Name = "portnamebox"
        Me.portnamebox.Size = New System.Drawing.Size(67, 20)
        Me.portnamebox.Sorted = True
        Me.portnamebox.TabIndex = 1
        '
        'baudratebox
        '
        Me.baudratebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baudratebox.FormattingEnabled = True
        Me.baudratebox.Location = New System.Drawing.Point(59, 53)
        Me.baudratebox.Name = "baudratebox"
        Me.baudratebox.Size = New System.Drawing.Size(67, 20)
        Me.baudratebox.TabIndex = 2
        '
        'statuslabel
        '
        Me.statuslabel.AutoSize = True
        Me.statuslabel.Location = New System.Drawing.Point(57, 79)
        Me.statuslabel.Name = "statuslabel"
        Me.statuslabel.Size = New System.Drawing.Size(41, 12)
        Me.statuslabel.TabIndex = 4
        Me.statuslabel.Text = "status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.baudratebox)
        Me.GroupBox1.Controls.Add(Me.Rst_btn)
        Me.GroupBox1.Controls.Add(Me.portnamebox)
        Me.GroupBox1.Controls.Add(Me.statuslabel)
        Me.GroupBox1.Controls.Add(Me.openbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 102)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "串口"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "波特率:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "端口:"
        '
        'Rst_btn
        '
        Me.Rst_btn.Location = New System.Drawing.Point(132, 52)
        Me.Rst_btn.Name = "Rst_btn"
        Me.Rst_btn.Size = New System.Drawing.Size(62, 20)
        Me.Rst_btn.TabIndex = 10
        Me.Rst_btn.Text = "机体校正"
        Me.Rst_btn.UseVisualStyleBackColor = True
        '
        'RUDD
        '
        Me.RUDD.AutoSize = True
        Me.RUDD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RUDD.Location = New System.Drawing.Point(111, 40)
        Me.RUDD.Name = "RUDD"
        Me.RUDD.Size = New System.Drawing.Size(41, 12)
        Me.RUDD.TabIndex = 11
        Me.RUDD.Tag = "方向舵"
        Me.RUDD.Text = "无信号"
        '
        'THRO
        '
        Me.THRO.AutoSize = True
        Me.THRO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.THRO.Location = New System.Drawing.Point(111, 19)
        Me.THRO.Name = "THRO"
        Me.THRO.Size = New System.Drawing.Size(41, 12)
        Me.THRO.TabIndex = 12
        Me.THRO.Tag = "油门"
        Me.THRO.Text = "无信号"
        '
        'AILE
        '
        Me.AILE.AutoSize = True
        Me.AILE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AILE.Location = New System.Drawing.Point(111, 82)
        Me.AILE.Name = "AILE"
        Me.AILE.Size = New System.Drawing.Size(41, 12)
        Me.AILE.TabIndex = 13
        Me.AILE.Tag = "副翼"
        Me.AILE.Text = "无信号"
        '
        'ELEV
        '
        Me.ELEV.AutoSize = True
        Me.ELEV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ELEV.Location = New System.Drawing.Point(111, 61)
        Me.ELEV.Name = "ELEV"
        Me.ELEV.Size = New System.Drawing.Size(41, 12)
        Me.ELEV.TabIndex = 16
        Me.ELEV.Tag = "升降舵"
        Me.ELEV.Text = "无信号"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ELEV)
        Me.GroupBox2.Controls.Add(Me.RUDD)
        Me.GroupBox2.Controls.Add(Me.AILE)
        Me.GroupBox2.Controls.Add(Me.THRO)
        Me.GroupBox2.Location = New System.Drawing.Point(220, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 102)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "接收器信号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "方向舵(RUDD)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "油门(THRO)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "副翼(AILE)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "升降舵(ELEV)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Accel_Z)
        Me.GroupBox3.Controls.Add(Me.Accel_Y)
        Me.GroupBox3.Controls.Add(Me.Accel_X)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Accel_offset_Z)
        Me.GroupBox3.Controls.Add(Me.Accel_Sensor_Z)
        Me.GroupBox3.Controls.Add(Me.Accel_offset_Y)
        Me.GroupBox3.Controls.Add(Me.Accel_Sensor_Y)
        Me.GroupBox3.Controls.Add(Me.Accel_offset_X)
        Me.GroupBox3.Controls.Add(Me.Accel_Sensor_X)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 100)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "加速度传感器"
        '
        'Accel_Z
        '
        Me.Accel_Z.AutoSize = True
        Me.Accel_Z.Location = New System.Drawing.Point(130, 76)
        Me.Accel_Z.Name = "Accel_Z"
        Me.Accel_Z.Size = New System.Drawing.Size(41, 12)
        Me.Accel_Z.TabIndex = 15
        Me.Accel_Z.Text = "无信号"
        '
        'Accel_Y
        '
        Me.Accel_Y.AutoSize = True
        Me.Accel_Y.Location = New System.Drawing.Point(130, 56)
        Me.Accel_Y.Name = "Accel_Y"
        Me.Accel_Y.Size = New System.Drawing.Size(41, 12)
        Me.Accel_Y.TabIndex = 14
        Me.Accel_Y.Text = "无信号"
        '
        'Accel_X
        '
        Me.Accel_X.AutoSize = True
        Me.Accel_X.Location = New System.Drawing.Point(130, 36)
        Me.Accel_X.Name = "Accel_X"
        Me.Accel_X.Size = New System.Drawing.Size(41, 12)
        Me.Accel_X.TabIndex = 13
        Me.Accel_X.Text = "无信号"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(125, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 12)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "加速度(g)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "校正"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "数值"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 12)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Z轴"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 12)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Y轴"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "X轴"
        '
        'Accel_offset_Z
        '
        Me.Accel_offset_Z.AutoSize = True
        Me.Accel_offset_Z.Location = New System.Drawing.Point(83, 76)
        Me.Accel_offset_Z.Name = "Accel_offset_Z"
        Me.Accel_offset_Z.Size = New System.Drawing.Size(41, 12)
        Me.Accel_offset_Z.TabIndex = 6
        Me.Accel_offset_Z.Text = "无信号"
        '
        'Accel_Sensor_Z
        '
        Me.Accel_Sensor_Z.AutoSize = True
        Me.Accel_Sensor_Z.Location = New System.Drawing.Point(36, 76)
        Me.Accel_Sensor_Z.Name = "Accel_Sensor_Z"
        Me.Accel_Sensor_Z.Size = New System.Drawing.Size(41, 12)
        Me.Accel_Sensor_Z.TabIndex = 5
        Me.Accel_Sensor_Z.Text = "无信号"
        '
        'Accel_offset_Y
        '
        Me.Accel_offset_Y.AutoSize = True
        Me.Accel_offset_Y.Location = New System.Drawing.Point(83, 56)
        Me.Accel_offset_Y.Name = "Accel_offset_Y"
        Me.Accel_offset_Y.Size = New System.Drawing.Size(41, 12)
        Me.Accel_offset_Y.TabIndex = 4
        Me.Accel_offset_Y.Text = "无信号"
        '
        'Accel_Sensor_Y
        '
        Me.Accel_Sensor_Y.AutoSize = True
        Me.Accel_Sensor_Y.Location = New System.Drawing.Point(36, 56)
        Me.Accel_Sensor_Y.Name = "Accel_Sensor_Y"
        Me.Accel_Sensor_Y.Size = New System.Drawing.Size(41, 12)
        Me.Accel_Sensor_Y.TabIndex = 3
        Me.Accel_Sensor_Y.Text = "无信号"
        '
        'Accel_offset_X
        '
        Me.Accel_offset_X.AutoSize = True
        Me.Accel_offset_X.Location = New System.Drawing.Point(83, 36)
        Me.Accel_offset_X.Name = "Accel_offset_X"
        Me.Accel_offset_X.Size = New System.Drawing.Size(41, 12)
        Me.Accel_offset_X.TabIndex = 1
        Me.Accel_offset_X.Text = "无信号"
        '
        'Accel_Sensor_X
        '
        Me.Accel_Sensor_X.AutoSize = True
        Me.Accel_Sensor_X.Location = New System.Drawing.Point(36, 36)
        Me.Accel_Sensor_X.Name = "Accel_Sensor_X"
        Me.Accel_Sensor_X.Size = New System.Drawing.Size(41, 12)
        Me.Accel_Sensor_X.TabIndex = 0
        Me.Accel_Sensor_X.Text = "无信号"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.ROLL)
        Me.GroupBox4.Controls.Add(Me.PITCH)
        Me.GroupBox4.Controls.Add(Me.YAW)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 219)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(115, 121)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "实时姿态"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(59, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 12)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "数值"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 12)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "ROLL"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 12)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "PITCH"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 12)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "YAW"
        '
        'ROLL
        '
        Me.ROLL.AutoSize = True
        Me.ROLL.Location = New System.Drawing.Point(55, 44)
        Me.ROLL.Name = "ROLL"
        Me.ROLL.Size = New System.Drawing.Size(41, 12)
        Me.ROLL.TabIndex = 5
        Me.ROLL.Text = "无信号"
        '
        'PITCH
        '
        Me.PITCH.AutoSize = True
        Me.PITCH.Location = New System.Drawing.Point(55, 68)
        Me.PITCH.Name = "PITCH"
        Me.PITCH.Size = New System.Drawing.Size(41, 12)
        Me.PITCH.TabIndex = 3
        Me.PITCH.Text = "无信号"
        '
        'YAW
        '
        Me.YAW.AutoSize = True
        Me.YAW.Location = New System.Drawing.Point(55, 92)
        Me.YAW.Name = "YAW"
        Me.YAW.Size = New System.Drawing.Size(41, 12)
        Me.YAW.TabIndex = 0
        Me.YAW.Text = "无信号"
        '
        'PID_Set
        '
        Me.PID_Set.Location = New System.Drawing.Point(5, 23)
        Me.PID_Set.Name = "PID_Set"
        Me.PID_Set.Size = New System.Drawing.Size(62, 20)
        Me.PID_Set.TabIndex = 67
        Me.PID_Set.Text = "PID整定"
        Me.PID_Set.UseVisualStyleBackColor = True
        '
        'Balance_Btn
        '
        Me.Balance_Btn.Location = New System.Drawing.Point(71, 23)
        Me.Balance_Btn.Name = "Balance_Btn"
        Me.Balance_Btn.Size = New System.Drawing.Size(62, 20)
        Me.Balance_Btn.TabIndex = 57
        Me.Balance_Btn.Text = "中位姿态"
        Me.Balance_Btn.UseVisualStyleBackColor = True
        '
        'Stop_btn
        '
        Me.Stop_btn.Location = New System.Drawing.Point(137, 23)
        Me.Stop_btn.Name = "Stop_btn"
        Me.Stop_btn.Size = New System.Drawing.Size(62, 20)
        Me.Stop_btn.TabIndex = 11
        Me.Stop_btn.Text = "紧急停止"
        Me.Stop_btn.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Gyro_Z)
        Me.GroupBox5.Controls.Add(Me.Gyro_Y)
        Me.GroupBox5.Controls.Add(Me.Gyro_X)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.Gyro_offset_Z)
        Me.GroupBox5.Controls.Add(Me.Gyro_Sensor_Z)
        Me.GroupBox5.Controls.Add(Me.Gyro_offset_Y)
        Me.GroupBox5.Controls.Add(Me.Gyro_Sensor_Y)
        Me.GroupBox5.Controls.Add(Me.Gyro_offset_X)
        Me.GroupBox5.Controls.Add(Me.Gyro_Sensor_X)
        Me.GroupBox5.Location = New System.Drawing.Point(220, 115)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(194, 100)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "陀螺仪"
        '
        'Gyro_Z
        '
        Me.Gyro_Z.AutoSize = True
        Me.Gyro_Z.Location = New System.Drawing.Point(119, 76)
        Me.Gyro_Z.Name = "Gyro_Z"
        Me.Gyro_Z.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_Z.TabIndex = 15
        Me.Gyro_Z.Text = "无信号"
        '
        'Gyro_Y
        '
        Me.Gyro_Y.AutoSize = True
        Me.Gyro_Y.Location = New System.Drawing.Point(119, 56)
        Me.Gyro_Y.Name = "Gyro_Y"
        Me.Gyro_Y.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_Y.TabIndex = 14
        Me.Gyro_Y.Text = "无信号"
        '
        'Gyro_X
        '
        Me.Gyro_X.AutoSize = True
        Me.Gyro_X.Location = New System.Drawing.Point(119, 36)
        Me.Gyro_X.Name = "Gyro_X"
        Me.Gyro_X.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_X.TabIndex = 13
        Me.Gyro_X.Text = "无信号"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(109, 17)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 12)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "角速度(deg/s)"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(75, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 12)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "校正"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(34, 17)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 12)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "数值"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 76)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(23, 12)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "Z轴"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 56)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(23, 12)
        Me.Label35.TabIndex = 8
        Me.Label35.Text = "Y轴"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 36)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(23, 12)
        Me.Label36.TabIndex = 7
        Me.Label36.Text = "X轴"
        '
        'Gyro_offset_Z
        '
        Me.Gyro_offset_Z.AutoSize = True
        Me.Gyro_offset_Z.Location = New System.Drawing.Point(72, 76)
        Me.Gyro_offset_Z.Name = "Gyro_offset_Z"
        Me.Gyro_offset_Z.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_offset_Z.TabIndex = 6
        Me.Gyro_offset_Z.Text = "无信号"
        '
        'Gyro_Sensor_Z
        '
        Me.Gyro_Sensor_Z.AutoSize = True
        Me.Gyro_Sensor_Z.Location = New System.Drawing.Point(30, 76)
        Me.Gyro_Sensor_Z.Name = "Gyro_Sensor_Z"
        Me.Gyro_Sensor_Z.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_Sensor_Z.TabIndex = 5
        Me.Gyro_Sensor_Z.Text = "无信号"
        '
        'Gyro_offset_Y
        '
        Me.Gyro_offset_Y.AutoSize = True
        Me.Gyro_offset_Y.Location = New System.Drawing.Point(72, 56)
        Me.Gyro_offset_Y.Name = "Gyro_offset_Y"
        Me.Gyro_offset_Y.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_offset_Y.TabIndex = 4
        Me.Gyro_offset_Y.Text = "无信号"
        '
        'Gyro_Sensor_Y
        '
        Me.Gyro_Sensor_Y.AutoSize = True
        Me.Gyro_Sensor_Y.Location = New System.Drawing.Point(30, 56)
        Me.Gyro_Sensor_Y.Name = "Gyro_Sensor_Y"
        Me.Gyro_Sensor_Y.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_Sensor_Y.TabIndex = 3
        Me.Gyro_Sensor_Y.Text = "无信号"
        '
        'Gyro_offset_X
        '
        Me.Gyro_offset_X.AutoSize = True
        Me.Gyro_offset_X.Location = New System.Drawing.Point(72, 36)
        Me.Gyro_offset_X.Name = "Gyro_offset_X"
        Me.Gyro_offset_X.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_offset_X.TabIndex = 1
        Me.Gyro_offset_X.Text = "无信号"
        '
        'Gyro_Sensor_X
        '
        Me.Gyro_Sensor_X.AutoSize = True
        Me.Gyro_Sensor_X.Location = New System.Drawing.Point(30, 36)
        Me.Gyro_Sensor_X.Name = "Gyro_Sensor_X"
        Me.Gyro_Sensor_X.Size = New System.Drawing.Size(41, 12)
        Me.Gyro_Sensor_X.TabIndex = 0
        Me.Gyro_Sensor_X.Text = "无信号"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.High_Speed)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.High_Accel)
        Me.GroupBox6.Controls.Add(Me.High)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.MS5611_high)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.MS5611_Pressure)
        Me.GroupBox6.Location = New System.Drawing.Point(131, 219)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(139, 121)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "定高"
        '
        'High_Speed
        '
        Me.High_Speed.AutoSize = True
        Me.High_Speed.Location = New System.Drawing.Point(3, 92)
        Me.High_Speed.Name = "High_Speed"
        Me.High_Speed.Size = New System.Drawing.Size(65, 12)
        Me.High_Speed.TabIndex = 26
        Me.High_Speed.Text = "惯导加速度"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 12)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "超声波高度(m)"
        '
        'High_Accel
        '
        Me.High_Accel.AutoSize = True
        Me.High_Accel.Location = New System.Drawing.Point(88, 92)
        Me.High_Accel.Name = "High_Accel"
        Me.High_Accel.Size = New System.Drawing.Size(41, 12)
        Me.High_Accel.TabIndex = 25
        Me.High_Accel.Text = "无信号"
        '
        'High
        '
        Me.High.AutoSize = True
        Me.High.Location = New System.Drawing.Point(90, 22)
        Me.High.Name = "High"
        Me.High.Size = New System.Drawing.Size(41, 12)
        Me.High.TabIndex = 27
        Me.High.Text = "无信号"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(3, 68)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(71, 12)
        Me.Label38.TabIndex = 6
        Me.Label38.Text = "气压高度(m)"
        '
        'MS5611_high
        '
        Me.MS5611_high.AutoSize = True
        Me.MS5611_high.Location = New System.Drawing.Point(89, 68)
        Me.MS5611_high.Name = "MS5611_high"
        Me.MS5611_high.Size = New System.Drawing.Size(41, 12)
        Me.MS5611_high.TabIndex = 1
        Me.MS5611_high.Text = "无信号"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(4, 44)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 12)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "气压(kPa)"
        '
        'MS5611_Pressure
        '
        Me.MS5611_Pressure.AutoSize = True
        Me.MS5611_Pressure.Location = New System.Drawing.Point(90, 44)
        Me.MS5611_Pressure.Name = "MS5611_Pressure"
        Me.MS5611_Pressure.Size = New System.Drawing.Size(41, 12)
        Me.MS5611_Pressure.TabIndex = 4
        Me.MS5611_Pressure.Text = "无信号"
        '
        'MS5611_Temperature
        '
        Me.MS5611_Temperature.AutoSize = True
        Me.MS5611_Temperature.Location = New System.Drawing.Point(83, 68)
        Me.MS5611_Temperature.Name = "MS5611_Temperature"
        Me.MS5611_Temperature.Size = New System.Drawing.Size(41, 12)
        Me.MS5611_Temperature.TabIndex = 3
        Me.MS5611_Temperature.Text = "无信号"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(17, 68)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 12)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "温度(5611)"
        '
        'MPU6050_Temperature
        '
        Me.MPU6050_Temperature.AutoSize = True
        Me.MPU6050_Temperature.Location = New System.Drawing.Point(83, 44)
        Me.MPU6050_Temperature.Name = "MPU6050_Temperature"
        Me.MPU6050_Temperature.Size = New System.Drawing.Size(41, 12)
        Me.MPU6050_Temperature.TabIndex = 1
        Me.MPU6050_Temperature.Text = "无信号"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(17, 44)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 12)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "温度(6050)"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.HMC5883L_Y)
        Me.GroupBox7.Controls.Add(Me.HMC5883L_Z_offset)
        Me.GroupBox7.Controls.Add(Me.HMC5883L_Y_offset)
        Me.GroupBox7.Controls.Add(Me.HMC5883L_X_offset)
        Me.GroupBox7.Controls.Add(Me.Label48)
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Controls.Add(Me.HMC5883L_angle)
        Me.GroupBox7.Controls.Add(Me.HMC5883L_Z)
        Me.GroupBox7.Controls.Add(Me.HMC5883L_X)
        Me.GroupBox7.Controls.Add(Me.Label46)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.Label44)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Location = New System.Drawing.Point(418, 115)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(135, 100)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "罗盘"
        '
        'HMC5883L_Y
        '
        Me.HMC5883L_Y.AutoSize = True
        Me.HMC5883L_Y.Location = New System.Drawing.Point(36, 46)
        Me.HMC5883L_Y.Name = "HMC5883L_Y"
        Me.HMC5883L_Y.Size = New System.Drawing.Size(41, 12)
        Me.HMC5883L_Y.TabIndex = 13
        Me.HMC5883L_Y.Text = "无信号"
        '
        'HMC5883L_Z_offset
        '
        Me.HMC5883L_Z_offset.AutoSize = True
        Me.HMC5883L_Z_offset.Location = New System.Drawing.Point(79, 64)
        Me.HMC5883L_Z_offset.Name = "HMC5883L_Z_offset"
        Me.HMC5883L_Z_offset.Size = New System.Drawing.Size(41, 12)
        Me.HMC5883L_Z_offset.TabIndex = 12
        Me.HMC5883L_Z_offset.Text = "无信号"
        '
        'HMC5883L_Y_offset
        '
        Me.HMC5883L_Y_offset.AutoSize = True
        Me.HMC5883L_Y_offset.Location = New System.Drawing.Point(79, 46)
        Me.HMC5883L_Y_offset.Name = "HMC5883L_Y_offset"
        Me.HMC5883L_Y_offset.Size = New System.Drawing.Size(41, 12)
        Me.HMC5883L_Y_offset.TabIndex = 11
        Me.HMC5883L_Y_offset.Text = "无信号"
        '
        'HMC5883L_X_offset
        '
        Me.HMC5883L_X_offset.AutoSize = True
        Me.HMC5883L_X_offset.Location = New System.Drawing.Point(79, 28)
        Me.HMC5883L_X_offset.Name = "HMC5883L_X_offset"
        Me.HMC5883L_X_offset.Size = New System.Drawing.Size(41, 12)
        Me.HMC5883L_X_offset.TabIndex = 10
        Me.HMC5883L_X_offset.Text = "无信号"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(84, 12)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(29, 12)
        Me.Label48.TabIndex = 9
        Me.Label48.Text = "校正"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(39, 12)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(29, 12)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "数值"
        '
        'HMC5883L_angle
        '
        Me.HMC5883L_angle.AutoSize = True
        Me.HMC5883L_angle.Location = New System.Drawing.Point(36, 82)
        Me.HMC5883L_angle.Name = "HMC5883L_angle"
        Me.HMC5883L_angle.Size = New System.Drawing.Size(41, 12)
        Me.HMC5883L_angle.TabIndex = 7
        Me.HMC5883L_angle.Text = "无信号"
        '
        'HMC5883L_Z
        '
        Me.HMC5883L_Z.AutoSize = True
        Me.HMC5883L_Z.Location = New System.Drawing.Point(36, 64)
        Me.HMC5883L_Z.Name = "HMC5883L_Z"
        Me.HMC5883L_Z.Size = New System.Drawing.Size(41, 12)
        Me.HMC5883L_Z.TabIndex = 6
        Me.HMC5883L_Z.Text = "无信号"
        '
        'HMC5883L_X
        '
        Me.HMC5883L_X.AutoSize = True
        Me.HMC5883L_X.Location = New System.Drawing.Point(36, 28)
        Me.HMC5883L_X.Name = "HMC5883L_X"
        Me.HMC5883L_X.Size = New System.Drawing.Size(41, 12)
        Me.HMC5883L_X.TabIndex = 4
        Me.HMC5883L_X.Text = "无信号"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 64)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(23, 12)
        Me.Label46.TabIndex = 3
        Me.Label46.Text = "Z轴"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 46)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(23, 12)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "Y轴"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 28)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(23, 12)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "X轴"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(5, 82)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(29, 12)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "角度"
        '
        'Print_openBtn
        '
        Me.Print_openBtn.Location = New System.Drawing.Point(256, 69)
        Me.Print_openBtn.Name = "Print_openBtn"
        Me.Print_openBtn.Size = New System.Drawing.Size(62, 20)
        Me.Print_openBtn.TabIndex = 23
        Me.Print_openBtn.Text = "打开曲线"
        Me.Print_openBtn.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Print_speedBox)
        Me.GroupBox8.Controls.Add(Me.Label43)
        Me.GroupBox8.Controls.Add(Me.Channel1_gainBox)
        Me.GroupBox8.Controls.Add(Me.Channel2_gainBox)
        Me.GroupBox8.Controls.Add(Me.Channel3_gainBox)
        Me.GroupBox8.Controls.Add(Me.Channel4_gainBox)
        Me.GroupBox8.Controls.Add(Me.Label42)
        Me.GroupBox8.Controls.Add(Me.Label41)
        Me.GroupBox8.Controls.Add(Me.Label40)
        Me.GroupBox8.Controls.Add(Me.Label39)
        Me.GroupBox8.Controls.Add(Me.Channel1_nameBox)
        Me.GroupBox8.Controls.Add(Me.Channel3_nameBox)
        Me.GroupBox8.Controls.Add(Me.Channel4_nameBox)
        Me.GroupBox8.Controls.Add(Me.Channel2_nameBox)
        Me.GroupBox8.Controls.Add(Me.Print_RstBtn)
        Me.GroupBox8.Controls.Add(Me.Print_openBtn)
        Me.GroupBox8.Location = New System.Drawing.Point(10, 347)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(332, 120)
        Me.GroupBox8.TabIndex = 24
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "曲线监控"
        '
        'Print_speedBox
        '
        Me.Print_speedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Print_speedBox.FormattingEnabled = True
        Me.Print_speedBox.Location = New System.Drawing.Point(256, 42)
        Me.Print_speedBox.Name = "Print_speedBox"
        Me.Print_speedBox.Size = New System.Drawing.Size(62, 20)
        Me.Print_speedBox.TabIndex = 38
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(259, 23)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(53, 12)
        Me.Label43.TabIndex = 37
        Me.Label43.Text = "采样周期"
        '
        'Channel1_gainBox
        '
        Me.Channel1_gainBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel1_gainBox.Enabled = False
        Me.Channel1_gainBox.FormattingEnabled = True
        Me.Channel1_gainBox.Location = New System.Drawing.Point(154, 17)
        Me.Channel1_gainBox.Name = "Channel1_gainBox"
        Me.Channel1_gainBox.Size = New System.Drawing.Size(93, 20)
        Me.Channel1_gainBox.TabIndex = 36
        '
        'Channel2_gainBox
        '
        Me.Channel2_gainBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel2_gainBox.Enabled = False
        Me.Channel2_gainBox.FormattingEnabled = True
        Me.Channel2_gainBox.Location = New System.Drawing.Point(154, 42)
        Me.Channel2_gainBox.Name = "Channel2_gainBox"
        Me.Channel2_gainBox.Size = New System.Drawing.Size(93, 20)
        Me.Channel2_gainBox.TabIndex = 35
        '
        'Channel3_gainBox
        '
        Me.Channel3_gainBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel3_gainBox.Enabled = False
        Me.Channel3_gainBox.FormattingEnabled = True
        Me.Channel3_gainBox.Location = New System.Drawing.Point(154, 68)
        Me.Channel3_gainBox.Name = "Channel3_gainBox"
        Me.Channel3_gainBox.Size = New System.Drawing.Size(93, 20)
        Me.Channel3_gainBox.TabIndex = 34
        '
        'Channel4_gainBox
        '
        Me.Channel4_gainBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel4_gainBox.Enabled = False
        Me.Channel4_gainBox.FormattingEnabled = True
        Me.Channel4_gainBox.Location = New System.Drawing.Point(155, 93)
        Me.Channel4_gainBox.Name = "Channel4_gainBox"
        Me.Channel4_gainBox.Size = New System.Drawing.Size(93, 20)
        Me.Channel4_gainBox.TabIndex = 33
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(15, 96)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(41, 12)
        Me.Label42.TabIndex = 32
        Me.Label42.Text = "通道四"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(15, 71)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(41, 12)
        Me.Label41.TabIndex = 31
        Me.Label41.Text = "通道三"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(15, 45)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(41, 12)
        Me.Label40.TabIndex = 30
        Me.Label40.Text = "通道二"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(15, 20)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(41, 12)
        Me.Label39.TabIndex = 29
        Me.Label39.Text = "通道一"
        '
        'Channel1_nameBox
        '
        Me.Channel1_nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel1_nameBox.Enabled = False
        Me.Channel1_nameBox.FormattingEnabled = True
        Me.Channel1_nameBox.Location = New System.Drawing.Point(57, 17)
        Me.Channel1_nameBox.Name = "Channel1_nameBox"
        Me.Channel1_nameBox.Size = New System.Drawing.Size(91, 20)
        Me.Channel1_nameBox.TabIndex = 25
        '
        'Channel3_nameBox
        '
        Me.Channel3_nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel3_nameBox.Enabled = False
        Me.Channel3_nameBox.FormattingEnabled = True
        Me.Channel3_nameBox.Location = New System.Drawing.Point(57, 68)
        Me.Channel3_nameBox.Name = "Channel3_nameBox"
        Me.Channel3_nameBox.Size = New System.Drawing.Size(91, 20)
        Me.Channel3_nameBox.TabIndex = 28
        '
        'Channel4_nameBox
        '
        Me.Channel4_nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel4_nameBox.Enabled = False
        Me.Channel4_nameBox.FormattingEnabled = True
        Me.Channel4_nameBox.Location = New System.Drawing.Point(57, 93)
        Me.Channel4_nameBox.Name = "Channel4_nameBox"
        Me.Channel4_nameBox.Size = New System.Drawing.Size(91, 20)
        Me.Channel4_nameBox.TabIndex = 27
        '
        'Channel2_nameBox
        '
        Me.Channel2_nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Channel2_nameBox.Enabled = False
        Me.Channel2_nameBox.FormattingEnabled = True
        Me.Channel2_nameBox.Location = New System.Drawing.Point(57, 42)
        Me.Channel2_nameBox.Name = "Channel2_nameBox"
        Me.Channel2_nameBox.Size = New System.Drawing.Size(91, 20)
        Me.Channel2_nameBox.TabIndex = 26
        '
        'Print_RstBtn
        '
        Me.Print_RstBtn.Location = New System.Drawing.Point(256, 92)
        Me.Print_RstBtn.Name = "Print_RstBtn"
        Me.Print_RstBtn.Size = New System.Drawing.Size(62, 20)
        Me.Print_RstBtn.TabIndex = 24
        Me.Print_RstBtn.Text = "曲线重置"
        Me.Print_RstBtn.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.Label15)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.Label13)
        Me.GroupBox9.Controls.Add(Me.Motor4)
        Me.GroupBox9.Controls.Add(Me.Motor3)
        Me.GroupBox9.Controls.Add(Me.Motor2)
        Me.GroupBox9.Controls.Add(Me.Motor1)
        Me.GroupBox9.Location = New System.Drawing.Point(418, 7)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(134, 101)
        Me.GroupBox9.TabIndex = 25
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "电机输出"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 12)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "电机四"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 12)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "电机三"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 12)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "电机二"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "电机一"
        '
        'Motor4
        '
        Me.Motor4.AutoSize = True
        Me.Motor4.Location = New System.Drawing.Point(74, 82)
        Me.Motor4.Name = "Motor4"
        Me.Motor4.Size = New System.Drawing.Size(41, 12)
        Me.Motor4.TabIndex = 3
        Me.Motor4.Text = "无信号"
        '
        'Motor3
        '
        Me.Motor3.AutoSize = True
        Me.Motor3.Location = New System.Drawing.Point(74, 61)
        Me.Motor3.Name = "Motor3"
        Me.Motor3.Size = New System.Drawing.Size(41, 12)
        Me.Motor3.TabIndex = 2
        Me.Motor3.Text = "无信号"
        '
        'Motor2
        '
        Me.Motor2.AutoSize = True
        Me.Motor2.Location = New System.Drawing.Point(74, 40)
        Me.Motor2.Name = "Motor2"
        Me.Motor2.Size = New System.Drawing.Size(41, 12)
        Me.Motor2.TabIndex = 1
        Me.Motor2.Text = "无信号"
        '
        'Motor1
        '
        Me.Motor1.AutoSize = True
        Me.Motor1.Location = New System.Drawing.Point(74, 19)
        Me.Motor1.Name = "Motor1"
        Me.Motor1.Size = New System.Drawing.Size(41, 12)
        Me.Motor1.TabIndex = 0
        Me.Motor1.Text = "无信号"
        '
        'GroupBox10
        '
        Me.GroupBox10.Location = New System.Drawing.Point(276, 219)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(138, 121)
        Me.GroupBox10.TabIndex = 68
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "定位"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.MPU6050_Temperature)
        Me.GroupBox11.Controls.Add(Me.Label28)
        Me.GroupBox11.Controls.Add(Me.Label29)
        Me.GroupBox11.Controls.Add(Me.MS5611_Temperature)
        Me.GroupBox11.Location = New System.Drawing.Point(418, 219)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(134, 121)
        Me.GroupBox11.TabIndex = 69
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "其它"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.PID_Set)
        Me.GroupBox12.Controls.Add(Me.Stop_btn)
        Me.GroupBox12.Controls.Add(Me.Balance_Btn)
        Me.GroupBox12.Location = New System.Drawing.Point(348, 347)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(204, 120)
        Me.GroupBox12.TabIndex = 70
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "调试"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem1.Text = "关于 飞行器调试助手"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(556, 471)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "飞行器调试助手"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents openbtn As System.Windows.Forms.Button
    Friend WithEvents portnamebox As System.Windows.Forms.ComboBox
    Friend WithEvents baudratebox As System.Windows.Forms.ComboBox
    Friend WithEvents statuslabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rst_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RUDD As System.Windows.Forms.Label
    Friend WithEvents THRO As System.Windows.Forms.Label
    Friend WithEvents AILE As System.Windows.Forms.Label
    Friend WithEvents ELEV As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Accel_Sensor_X As System.Windows.Forms.Label
    Friend WithEvents Accel_offset_X As System.Windows.Forms.Label
    Friend WithEvents Accel_offset_Z As System.Windows.Forms.Label
    Friend WithEvents Accel_Sensor_Z As System.Windows.Forms.Label
    Friend WithEvents Accel_offset_Y As System.Windows.Forms.Label
    Friend WithEvents Accel_Sensor_Y As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Accel_Z As System.Windows.Forms.Label
    Friend WithEvents Accel_Y As System.Windows.Forms.Label
    Friend WithEvents Accel_X As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ROLL As System.Windows.Forms.Label
    Friend WithEvents PITCH As System.Windows.Forms.Label
    Friend WithEvents YAW As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Gyro_Z As System.Windows.Forms.Label
    Friend WithEvents Gyro_Y As System.Windows.Forms.Label
    Friend WithEvents Gyro_X As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Gyro_offset_Z As System.Windows.Forms.Label
    Friend WithEvents Gyro_Sensor_Z As System.Windows.Forms.Label
    Friend WithEvents Gyro_offset_Y As System.Windows.Forms.Label
    Friend WithEvents Gyro_Sensor_Y As System.Windows.Forms.Label
    Friend WithEvents Gyro_offset_X As System.Windows.Forms.Label
    Friend WithEvents Gyro_Sensor_X As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents MPU6050_Temperature As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents MS5611_Temperature As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents MS5611_Pressure As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents MS5611_high As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Print_openBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Print_RstBtn As System.Windows.Forms.Button
    Friend WithEvents Channel1_nameBox As System.Windows.Forms.ComboBox
    Friend WithEvents Channel3_nameBox As System.Windows.Forms.ComboBox
    Friend WithEvents Channel4_nameBox As System.Windows.Forms.ComboBox
    Friend WithEvents Channel2_nameBox As System.Windows.Forms.ComboBox
    Friend WithEvents Channel1_gainBox As System.Windows.Forms.ComboBox
    Friend WithEvents Channel2_gainBox As System.Windows.Forms.ComboBox
    Friend WithEvents Channel3_gainBox As System.Windows.Forms.ComboBox
    Friend WithEvents Channel4_gainBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Print_speedBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents HMC5883L_angle As System.Windows.Forms.Label
    Friend WithEvents HMC5883L_Z As System.Windows.Forms.Label
    Friend WithEvents HMC5883L_X As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents HMC5883L_Y As System.Windows.Forms.Label
    Friend WithEvents HMC5883L_Z_offset As System.Windows.Forms.Label
    Friend WithEvents HMC5883L_Y_offset As System.Windows.Forms.Label
    Friend WithEvents HMC5883L_X_offset As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Stop_btn As System.Windows.Forms.Button
    Friend WithEvents Balance_Btn As System.Windows.Forms.Button
    Friend WithEvents High_Accel As System.Windows.Forms.Label
    Friend WithEvents High_Speed As System.Windows.Forms.Label
    Friend WithEvents High As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents PID_Set As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Motor4 As System.Windows.Forms.Label
    Friend WithEvents Motor3 As System.Windows.Forms.Label
    Friend WithEvents Motor2 As System.Windows.Forms.Label
    Friend WithEvents Motor1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
