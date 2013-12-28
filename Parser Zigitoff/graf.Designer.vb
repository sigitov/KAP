<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class graf
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title7 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title8 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title9 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title10 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea6.AxisX.Interval = 1.0R
        ChartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea6.AxisX.MaximumAutoSize = 100.0!
        ChartArea6.AxisX.Title = "Года"
        ChartArea6.AxisY.Title = "Количество аниме"
        ChartArea6.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend6)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "Количество"
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(518, 237)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Динамика выхода аниме"
        Title6.Name = "Title1"
        Title6.Text = "Динамика выхода аниме"
        Me.Chart1.Titles.Add(Title6)
        '
        'Chart2
        '
        ChartArea7.AxisX.Interval = 1.0R
        ChartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea7.AxisX.MaximumAutoSize = 100.0!
        ChartArea7.AxisX.Title = "Название"
        ChartArea7.AxisY.Title = "Количество скачиваний"
        ChartArea7.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend7)
        Me.Chart2.Location = New System.Drawing.Point(12, 255)
        Me.Chart2.Name = "Chart2"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Количество"
        Me.Chart2.Series.Add(Series7)
        Me.Chart2.Size = New System.Drawing.Size(518, 237)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        Title7.Name = "Title1"
        Title7.Text = "Топ 5 аниме"
        Me.Chart2.Titles.Add(Title7)
        '
        'Chart3
        '
        ChartArea8.AxisX.Interval = 1.0R
        ChartArea8.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea8.AxisX.MaximumAutoSize = 100.0!
        ChartArea8.AxisX.Title = "Название"
        ChartArea8.AxisY.Title = "Количество релизов"
        ChartArea8.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend8)
        Me.Chart3.Location = New System.Drawing.Point(12, 498)
        Me.Chart3.Name = "Chart3"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Количество"
        Me.Chart3.Series.Add(Series8)
        Me.Chart3.Size = New System.Drawing.Size(518, 237)
        Me.Chart3.TabIndex = 2
        Me.Chart3.Text = "Chart3"
        Title8.Name = "Title1"
        Title8.Text = "Топ 10 жанров"
        Me.Chart3.Titles.Add(Title8)
        '
        'Chart4
        '
        ChartArea9.AxisX.Interval = 1.0R
        ChartArea9.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea9.AxisX.MaximumAutoSize = 100.0!
        ChartArea9.AxisX.Title = "Название"
        ChartArea9.AxisY.Title = "Количество релизов"
        ChartArea9.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea9)
        Legend9.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend9)
        Me.Chart4.Location = New System.Drawing.Point(12, 741)
        Me.Chart4.Name = "Chart4"
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Количество"
        Me.Chart4.Series.Add(Series9)
        Me.Chart4.Size = New System.Drawing.Size(518, 237)
        Me.Chart4.TabIndex = 3
        Me.Chart4.Text = "Chart4"
        Title9.Name = "Title1"
        Title9.Text = "Топ 10 режиссёров"
        Me.Chart4.Titles.Add(Title9)
        '
        'Chart5
        '
        ChartArea10.AxisX.Interval = 1.0R
        ChartArea10.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea10.AxisX.MaximumAutoSize = 100.0!
        ChartArea10.AxisX.Title = "Название"
        ChartArea10.AxisY.Title = "Количество комментариев"
        ChartArea10.Name = "ChartArea1"
        Me.Chart5.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        Me.Chart5.Legends.Add(Legend10)
        Me.Chart5.Location = New System.Drawing.Point(12, 984)
        Me.Chart5.Name = "Chart5"
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Количество"
        Me.Chart5.Series.Add(Series10)
        Me.Chart5.Size = New System.Drawing.Size(518, 237)
        Me.Chart5.TabIndex = 4
        Me.Chart5.Text = "Chart5"
        Title10.Name = "Title1"
        Title10.Text = "Топ 10 обсуждаемых аниме"
        Me.Chart5.Titles.Add(Title10)
        '
        'graf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(558, 581)
        Me.Controls.Add(Me.Chart5)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.MaximizeBox = False
        Me.Name = "graf"
        Me.Text = "graf"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart5 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
