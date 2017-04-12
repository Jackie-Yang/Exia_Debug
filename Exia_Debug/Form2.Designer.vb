<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Curve1 = New Exia_Debug.Curve()
        Me.SuspendLayout()
        '
        'Curve1
        '
        Me.Curve1.BackColor = System.Drawing.Color.Black
        Me.Curve1.BackScroll = True
        Me.Curve1.BottomWidth = 30
        Me.Curve1.CurveLabelColor = System.Drawing.Color.Cyan
        Me.Curve1.CurveLabelStyle = False
        Me.Curve1.CurveNumber = 4
        Me.Curve1.CurveSmoothingMode = True
        Me.Curve1.DataLabelColor = System.Drawing.Color.Cyan
        Me.Curve1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Curve1.GridColor = System.Drawing.Color.Teal
        Me.Curve1.GridStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.Curve1.LabelFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Curve1.LeftWidth = 40
        Me.Curve1.Location = New System.Drawing.Point(-1, -1)
        Me.Curve1.MoveDispData = False
        Me.Curve1.Name = "Curve1"
        Me.Curve1.PolerColor = System.Drawing.Color.Magenta
        Me.Curve1.RightWidth = 14
        Me.Curve1.Size = New System.Drawing.Size(973, 660)
        Me.Curve1.TabIndex = 0
        Me.Curve1.TopWidth = 30
        Me.Curve1.XAxisFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Curve1.XAxisMax = 800.0R
        Me.Curve1.XAxisMin = 0.0R
        Me.Curve1.XAxisStrColor = System.Drawing.Color.Cyan
        Me.Curve1.XAxisStrScroll = True
        Me.Curve1.XHead = 4
        Me.Curve1.XLineNumber = 10
        Me.Curve1.YAxisMax = 1000.0R
        Me.Curve1.YAxisMin = -1000.0R
        Me.Curve1.YHead = 8
        Me.Curve1.YLineNumber = 10
        Me.Curve1.ZoomGridColor = System.Drawing.Color.Violet
        Me.Curve1.ZoomGridStyle = System.Drawing.Drawing2D.DashStyle.Dot
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.Curve1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "曲线监控"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Curve1 As Exia_Debug.Curve
End Class
