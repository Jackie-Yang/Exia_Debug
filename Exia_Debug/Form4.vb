Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

        '禁止修改表格，删除可以
        ' DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToOrderColumns = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        '禁止用户排序
        DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

        PID_selected.SelectedIndex = 0

        'PID_selected.SelectedIndex = -1
        'PID_selected.Items.Add("Roll_Gyro")
        'PID_selected.Items.Add("Roll_Angle")
        'PID_selected.Items.Add("Pitch_Gyro")
        'PID_selected.Items.Add("Pitch_Angle")
        'PID_selected.Items.Add("Yaw_Gyro")
    End Sub

    Private Sub PID_selected_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PID_selected.SelectedIndexChanged

        'Dim input_time As Date
        Dim input_time_str As String
        Dim input_Str As String
        Dim input_data As Single

        DataGridView1.Rows.Clear() '清空表格

        Try
            FileOpen(1, PID_selected.Text + "_PID.dat", OpenMode.Input) '打开相应记录文件

            Do Until EOF(1)

                input_Str = LineInput(1)
                input_Str = LTrim(input_Str)

                DataGridView1.Rows.Insert(0)

                Do Until Len(input_Str) = 0
                    If Microsoft.VisualBasic.Left(input_Str, 5) = "Date:" Then  '找到日期项
                        '删除日期字符串"Date:"
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len("Date:"))
                        '截取日期，在“ ---- ”之前
                        input_time_str = Microsoft.VisualBasic.Left(input_Str, InStr(input_Str, " ---- ") - 1)
                        'input_time = CDate(input_time_str)
                        '在字符串中删除日期的字符串以及“ ---- ”
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len(input_time_str) - Len(" ---- "))
                        '显示到表格
                        DataGridView1.Rows(0).Cells(0).Value = input_time_str

                    ElseIf Microsoft.VisualBasic.Left(input_Str, 2) = "P:" Then '找到“P”项
                        '删除字符串“P:”
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len("P:"))
                        '读取P数据
                        input_data = Val(input_Str)
                        '从字符串删除P数据的字符串
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len(Format(input_data, "0.00")))
                        '清空格
                        input_Str = LTrim(input_Str)
                        '显示到表格
                        DataGridView1.Rows(0).Cells(1).Value = input_data
                    ElseIf Microsoft.VisualBasic.Left(input_Str, 2) = "I:" Then '原理同上
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len("I:"))
                        input_data = Val(input_Str)
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len(Format(input_data, "0.00")))
                        input_Str = LTrim(input_Str)
                        DataGridView1.Rows(0).Cells(2).Value = input_data
                    ElseIf Microsoft.VisualBasic.Left(input_Str, 2) = "D:" Then
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len("D:"))
                        input_data = Val(input_Str)
                        input_Str = Microsoft.VisualBasic.Right(input_Str, Len(input_Str) - Len(Format(input_data, "0.00")))
                        input_Str = LTrim(input_Str)
                        DataGridView1.Rows(0).Cells(3).Value = input_data
                    End If
                Loop

                'If (Not EOF(1)) Then
                '    DataGridView1.Rows.Insert(0)
                'End If

            Loop

            FileClose(1)

            DataGridView1.Focus()

        Catch ex As Exception   '找不到记录文件
            MessageBox.Show(ex.Message, "未找到整定记录")
        End Try



    End Sub





    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If MsgBox("是否载入当前参数", MsgBoxStyle.OkCancel, "参数载入") = MsgBoxResult.Ok Then

            If Val(Form1.THRO.Text) <> 0 Then
                MsgBox("请先将油门置零！", MsgBoxStyle.Exclamation, "注意安全")
            Else
                Dim PID_index_base As Byte
                '计算PID项的索引基值，如ROLL_G的基值为9，Roll_Angle的为12
                PID_index_base = 9 + PID_selected.SelectedIndex * 3
                Try
                    Form3.PID_Send(DataGridView1.Rows(e.RowIndex).Cells(1).Value * 100, PID_index_base) 'Kp
                    Form3.PID_Send(DataGridView1.Rows(e.RowIndex).Cells(2).Value * 100, PID_index_base + 1) 'Ki
                    Form3.PID_Send(DataGridView1.Rows(e.RowIndex).Cells(3).Value * 100, PID_index_base + 2) 'Kd
                    Form1.Check_PID()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

            Me.Close()

        End If


    End Sub


End Class