<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Load_Btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.YAW_G_Kd = New System.Windows.Forms.Label()
        Me.YAW_G_Ki = New System.Windows.Forms.Label()
        Me.YAW_G_Kp = New System.Windows.Forms.Label()
        Me.PITCH_Angle_Kd = New System.Windows.Forms.Label()
        Me.PITCH_Angle_Ki = New System.Windows.Forms.Label()
        Me.PITCH_Angle_Kp = New System.Windows.Forms.Label()
        Me.PITCH_G_Kd = New System.Windows.Forms.Label()
        Me.PITCH_G_Ki = New System.Windows.Forms.Label()
        Me.PITCH_G_Kp = New System.Windows.Forms.Label()
        Me.ROLL_Angle_Kd = New System.Windows.Forms.Label()
        Me.ROLL_Angle_Ki = New System.Windows.Forms.Label()
        Me.ROLL_Angle_Kp = New System.Windows.Forms.Label()
        Me.ROLL_G_Kd = New System.Windows.Forms.Label()
        Me.ROLL_G_Ki = New System.Windows.Forms.Label()
        Me.ROLL_G_Kp = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Updata_Btn = New System.Windows.Forms.Button()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Load_Btn
        '
        Me.Load_Btn.Location = New System.Drawing.Point(82, 152)
        Me.Load_Btn.Name = "Load_Btn"
        Me.Load_Btn.Size = New System.Drawing.Size(67, 20)
        Me.Load_Btn.TabIndex = 5
        Me.Load_Btn.Text = "载入配置"
        Me.Load_Btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.YAW_G_Kd)
        Me.GroupBox1.Controls.Add(Me.YAW_G_Ki)
        Me.GroupBox1.Controls.Add(Me.YAW_G_Kp)
        Me.GroupBox1.Controls.Add(Me.PITCH_Angle_Kd)
        Me.GroupBox1.Controls.Add(Me.PITCH_Angle_Ki)
        Me.GroupBox1.Controls.Add(Me.PITCH_Angle_Kp)
        Me.GroupBox1.Controls.Add(Me.PITCH_G_Kd)
        Me.GroupBox1.Controls.Add(Me.PITCH_G_Ki)
        Me.GroupBox1.Controls.Add(Me.PITCH_G_Kp)
        Me.GroupBox1.Controls.Add(Me.ROLL_Angle_Kd)
        Me.GroupBox1.Controls.Add(Me.ROLL_Angle_Ki)
        Me.GroupBox1.Controls.Add(Me.ROLL_Angle_Kp)
        Me.GroupBox1.Controls.Add(Me.ROLL_G_Kd)
        Me.GroupBox1.Controls.Add(Me.ROLL_G_Ki)
        Me.GroupBox1.Controls.Add(Me.ROLL_G_Kp)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 134)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "姿态控制"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 12)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "ROLL"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 12)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "PITCH"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(19, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 12)
        Me.Label21.TabIndex = 88
        Me.Label21.Text = "YAW"
        '
        'YAW_G_Kd
        '
        Me.YAW_G_Kd.AutoSize = True
        Me.YAW_G_Kd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YAW_G_Kd.Location = New System.Drawing.Point(189, 97)
        Me.YAW_G_Kd.Name = "YAW_G_Kd"
        Me.YAW_G_Kd.Size = New System.Drawing.Size(41, 12)
        Me.YAW_G_Kd.TabIndex = 87
        Me.YAW_G_Kd.Text = "无信号"
        '
        'YAW_G_Ki
        '
        Me.YAW_G_Ki.AutoSize = True
        Me.YAW_G_Ki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YAW_G_Ki.Location = New System.Drawing.Point(128, 97)
        Me.YAW_G_Ki.Name = "YAW_G_Ki"
        Me.YAW_G_Ki.Size = New System.Drawing.Size(41, 12)
        Me.YAW_G_Ki.TabIndex = 86
        Me.YAW_G_Ki.Text = "无信号"
        '
        'YAW_G_Kp
        '
        Me.YAW_G_Kp.AutoSize = True
        Me.YAW_G_Kp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YAW_G_Kp.Location = New System.Drawing.Point(68, 97)
        Me.YAW_G_Kp.Name = "YAW_G_Kp"
        Me.YAW_G_Kp.Size = New System.Drawing.Size(41, 12)
        Me.YAW_G_Kp.TabIndex = 85
        Me.YAW_G_Kp.Text = "无信号"
        '
        'PITCH_Angle_Kd
        '
        Me.PITCH_Angle_Kd.AutoSize = True
        Me.PITCH_Angle_Kd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PITCH_Angle_Kd.Location = New System.Drawing.Point(372, 73)
        Me.PITCH_Angle_Kd.Name = "PITCH_Angle_Kd"
        Me.PITCH_Angle_Kd.Size = New System.Drawing.Size(41, 12)
        Me.PITCH_Angle_Kd.TabIndex = 84
        Me.PITCH_Angle_Kd.Text = "无信号"
        '
        'PITCH_Angle_Ki
        '
        Me.PITCH_Angle_Ki.AutoSize = True
        Me.PITCH_Angle_Ki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PITCH_Angle_Ki.Location = New System.Drawing.Point(312, 73)
        Me.PITCH_Angle_Ki.Name = "PITCH_Angle_Ki"
        Me.PITCH_Angle_Ki.Size = New System.Drawing.Size(41, 12)
        Me.PITCH_Angle_Ki.TabIndex = 83
        Me.PITCH_Angle_Ki.Text = "无信号"
        '
        'PITCH_Angle_Kp
        '
        Me.PITCH_Angle_Kp.AutoSize = True
        Me.PITCH_Angle_Kp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PITCH_Angle_Kp.Location = New System.Drawing.Point(252, 73)
        Me.PITCH_Angle_Kp.Name = "PITCH_Angle_Kp"
        Me.PITCH_Angle_Kp.Size = New System.Drawing.Size(41, 12)
        Me.PITCH_Angle_Kp.TabIndex = 82
        Me.PITCH_Angle_Kp.Text = "无信号"
        '
        'PITCH_G_Kd
        '
        Me.PITCH_G_Kd.AutoSize = True
        Me.PITCH_G_Kd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PITCH_G_Kd.Location = New System.Drawing.Point(189, 73)
        Me.PITCH_G_Kd.Name = "PITCH_G_Kd"
        Me.PITCH_G_Kd.Size = New System.Drawing.Size(41, 12)
        Me.PITCH_G_Kd.TabIndex = 81
        Me.PITCH_G_Kd.Text = "无信号"
        '
        'PITCH_G_Ki
        '
        Me.PITCH_G_Ki.AutoSize = True
        Me.PITCH_G_Ki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PITCH_G_Ki.Location = New System.Drawing.Point(128, 73)
        Me.PITCH_G_Ki.Name = "PITCH_G_Ki"
        Me.PITCH_G_Ki.Size = New System.Drawing.Size(41, 12)
        Me.PITCH_G_Ki.TabIndex = 80
        Me.PITCH_G_Ki.Text = "无信号"
        '
        'PITCH_G_Kp
        '
        Me.PITCH_G_Kp.AutoSize = True
        Me.PITCH_G_Kp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PITCH_G_Kp.Location = New System.Drawing.Point(68, 73)
        Me.PITCH_G_Kp.Name = "PITCH_G_Kp"
        Me.PITCH_G_Kp.Size = New System.Drawing.Size(41, 12)
        Me.PITCH_G_Kp.TabIndex = 79
        Me.PITCH_G_Kp.Text = "无信号"
        '
        'ROLL_Angle_Kd
        '
        Me.ROLL_Angle_Kd.AutoSize = True
        Me.ROLL_Angle_Kd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROLL_Angle_Kd.Location = New System.Drawing.Point(372, 49)
        Me.ROLL_Angle_Kd.Name = "ROLL_Angle_Kd"
        Me.ROLL_Angle_Kd.Size = New System.Drawing.Size(41, 12)
        Me.ROLL_Angle_Kd.TabIndex = 78
        Me.ROLL_Angle_Kd.Text = "无信号"
        '
        'ROLL_Angle_Ki
        '
        Me.ROLL_Angle_Ki.AutoSize = True
        Me.ROLL_Angle_Ki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROLL_Angle_Ki.Location = New System.Drawing.Point(312, 49)
        Me.ROLL_Angle_Ki.Name = "ROLL_Angle_Ki"
        Me.ROLL_Angle_Ki.Size = New System.Drawing.Size(41, 12)
        Me.ROLL_Angle_Ki.TabIndex = 77
        Me.ROLL_Angle_Ki.Text = "无信号"
        '
        'ROLL_Angle_Kp
        '
        Me.ROLL_Angle_Kp.AutoSize = True
        Me.ROLL_Angle_Kp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROLL_Angle_Kp.Location = New System.Drawing.Point(252, 49)
        Me.ROLL_Angle_Kp.Name = "ROLL_Angle_Kp"
        Me.ROLL_Angle_Kp.Size = New System.Drawing.Size(41, 12)
        Me.ROLL_Angle_Kp.TabIndex = 76
        Me.ROLL_Angle_Kp.Text = "无信号"
        '
        'ROLL_G_Kd
        '
        Me.ROLL_G_Kd.AutoSize = True
        Me.ROLL_G_Kd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROLL_G_Kd.Location = New System.Drawing.Point(189, 49)
        Me.ROLL_G_Kd.Name = "ROLL_G_Kd"
        Me.ROLL_G_Kd.Size = New System.Drawing.Size(41, 12)
        Me.ROLL_G_Kd.TabIndex = 75
        Me.ROLL_G_Kd.Text = "无信号"
        '
        'ROLL_G_Ki
        '
        Me.ROLL_G_Ki.AutoSize = True
        Me.ROLL_G_Ki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROLL_G_Ki.Location = New System.Drawing.Point(128, 49)
        Me.ROLL_G_Ki.Name = "ROLL_G_Ki"
        Me.ROLL_G_Ki.Size = New System.Drawing.Size(41, 12)
        Me.ROLL_G_Ki.TabIndex = 74
        Me.ROLL_G_Ki.Text = "无信号"
        '
        'ROLL_G_Kp
        '
        Me.ROLL_G_Kp.AutoSize = True
        Me.ROLL_G_Kp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROLL_G_Kp.Location = New System.Drawing.Point(68, 49)
        Me.ROLL_G_Kp.Name = "ROLL_G_Kp"
        Me.ROLL_G_Kp.Size = New System.Drawing.Size(41, 12)
        Me.ROLL_G_Kp.TabIndex = 67
        Me.ROLL_G_Kp.Text = "无信号"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(372, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 12)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "角度Kd"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(312, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 12)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "角度Ki"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(252, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 12)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "角度Kp"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(183, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "角速度Kd"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(123, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "角速度Ki"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(63, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 12)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "角速度Kp"
        '
        'Updata_Btn
        '
        Me.Updata_Btn.Location = New System.Drawing.Point(152, 152)
        Me.Updata_Btn.Name = "Updata_Btn"
        Me.Updata_Btn.Size = New System.Drawing.Size(67, 20)
        Me.Updata_Btn.TabIndex = 8
        Me.Updata_Btn.Text = "刷新参数"
        Me.Updata_Btn.UseVisualStyleBackColor = True
        '
        'Save_Btn
        '
        Me.Save_Btn.Enabled = False
        Me.Save_Btn.Location = New System.Drawing.Point(12, 152)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(67, 20)
        Me.Save_Btn.TabIndex = 9
        Me.Save_Btn.Text = "保存配置"
        Me.Save_Btn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 180)
        Me.Controls.Add(Me.Save_Btn)
        Me.Controls.Add(Me.Updata_Btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Load_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "PID整定"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Load_Btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents YAW_G_Kd As System.Windows.Forms.Label
    Friend WithEvents YAW_G_Ki As System.Windows.Forms.Label
    Friend WithEvents YAW_G_Kp As System.Windows.Forms.Label
    Friend WithEvents PITCH_Angle_Kd As System.Windows.Forms.Label
    Friend WithEvents PITCH_Angle_Ki As System.Windows.Forms.Label
    Friend WithEvents PITCH_Angle_Kp As System.Windows.Forms.Label
    Friend WithEvents PITCH_G_Kd As System.Windows.Forms.Label
    Friend WithEvents PITCH_G_Ki As System.Windows.Forms.Label
    Friend WithEvents PITCH_G_Kp As System.Windows.Forms.Label
    Friend WithEvents ROLL_Angle_Kd As System.Windows.Forms.Label
    Friend WithEvents ROLL_Angle_Ki As System.Windows.Forms.Label
    Friend WithEvents ROLL_Angle_Kp As System.Windows.Forms.Label
    Friend WithEvents ROLL_G_Kd As System.Windows.Forms.Label
    Friend WithEvents ROLL_G_Ki As System.Windows.Forms.Label
    Friend WithEvents ROLL_G_Kp As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Updata_Btn As System.Windows.Forms.Button
    Friend WithEvents Save_Btn As System.Windows.Forms.Button
End Class
