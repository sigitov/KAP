Public Class analiz


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strMassYwDel As String
        Dim strMassXwDel As String
        Dim strMassY() As String
        Dim strMassX() As String
        For i = 0 To DataGridView2.Rows.Count - 2 Step 1

            strMassXwDel = strMassXwDel & DataGridView2.Item("DataGridViewTextBoxColumn1", i).Value & ";"
            strMassYwDel = strMassYwDel & DataGridView2.Item("DataGridViewTextBoxColumn2", i).Value & ";"
        Next
        strMassY = Split(strMassYwDel, ";")
        strMassX = Split(strMassXwDel, ";")
        For i = 0 To strMassX.Length - 2 '' UBound(strMassX)
            graf.Chart1.Series.Item(0).Points.AddXY(strMassX(i), strMassY(i)) '' установка точек диаграммы 
            graf.Chart1.Series.Item(0).Points.Item(i).Label = strMassY(i) '' подпись значений Y сверху точек диаграммы
        Next

        Dim strMassYwDel2 As String
        Dim strMassXwDel2 As String
        Dim strMassY2() As String
        Dim strMassX2() As String
        For i = 0 To DataGridView1.Rows.Count - 1 Step 1

            strMassXwDel2 = strMassXwDel2 & DataGridView1.Item("Column1", i).Value & ";"
            strMassYwDel2 = strMassYwDel2 & DataGridView1.Item("Column2", i).Value & ";"
        Next
        strMassY2 = Split(strMassYwDel2, ";")
        strMassX2 = Split(strMassXwDel2, ";")
        For i = 0 To strMassX2.Length - 3 Step 1 '' UBound(strMassX)
            graf.Chart2.Series.Add(i)
            graf.Chart2.Series.Item(i).LegendText = i & " " & strMassX2(i) & " " & strMassY2(i)
            graf.Chart2.Series.Item(i).Points.AddXY(i, strMassY2(i)) '' установка точек диаграммы 
            'graf.Chart2.Series.Item(i).Points.Item(i).Label = strMassY2(i)  '' подпись значений Y сверху точек диаграммы
        Next



        Dim strMassYwDel3 As String
        Dim strMassXwDel3 As String
        Dim strMassY3() As String
        Dim strMassX3() As String
        For i = 0 To 9 Step 1

            strMassXwDel3 = strMassXwDel3 & DataGridView4.Item("DataGridViewTextBoxColumn5", i).Value & ";"
            strMassYwDel3 = strMassYwDel3 & DataGridView4.Item("DataGridViewTextBoxColumn6", i).Value & ";"
        Next
        strMassY3 = Split(strMassYwDel3, ";")
        strMassX3 = Split(strMassXwDel3, ";")
        For i = 0 To strMassX3.Length - 2 Step 1 '' UBound(strMassX)
            graf.Chart3.Series.Add(i)
            graf.Chart3.Series.Item(i).LegendText = i & " " & strMassX3(i) & " " & strMassY3(i)
            graf.Chart3.Series.Item(i).Points.AddXY(i, strMassY3(i)) '' установка точек диаграммы 
            'graf.Chart2.Series.Item(i).Points.Item(i).Label = strMassY2(i)  '' подпись значений Y сверху точек диаграммы
        Next


        Dim strMassYwDel4 As String
        Dim strMassXwDel4 As String
        Dim strMassY4() As String
        Dim strMassX4() As String
        For i = 0 To 9 Step 1

            strMassXwDel4 = strMassXwDel4 & DataGridView5.Item("Column4", i).Value & ";"
            strMassYwDel4 = strMassYwDel4 & DataGridView5.Item("Column5", i).Value & ";"
        Next
        strMassY4 = Split(strMassYwDel4, ";")
        strMassX4 = Split(strMassXwDel4, ";")
        For i = 0 To strMassX4.Length - 2 Step 1 '' UBound(strMassX)
            graf.Chart4.Series.Add(i)
            graf.Chart4.Series.Item(i).LegendText = i & " " & strMassX4(i) & " " & strMassY4(i)
            graf.Chart4.Series.Item(i).Points.AddXY(i, strMassY4(i)) '' установка точек диаграммы 
            'graf.Chart2.Series.Item(i).Points.Item(i).Label = strMassY2(i)  '' подпись значений Y сверху точек диаграммы
        Next


        'тут топы по скачиваниям

        DataGridView4.Sort(DataGridView4.Columns.Item(2), System.ComponentModel.ListSortDirection.Descending)
        DataGridView5.Sort(DataGridView5.Columns.Item(2), System.ComponentModel.ListSortDirection.Descending)


        Dim strMassYwDel5 As String
        Dim strMassXwDel5 As String
        Dim strMassY5() As String
        Dim strMassX5() As String
        For i = 0 To 9 Step 1

            strMassXwDel5 = strMassXwDel5 & DataGridView6.Item("DataGridViewTextBoxColumn7", i).Value & ";"
            strMassYwDel5 = strMassYwDel5 & DataGridView6.Item("DataGridViewTextBoxColumn8", i).Value & ";"
        Next
        strMassY5 = Split(strMassYwDel5, ";")
        strMassX5 = Split(strMassXwDel5, ";")
        For i = 0 To strMassX5.Length - 2 Step 1 '' UBound(strMassX)
            graf.Chart5.Series.Add(i)
            graf.Chart5.Series.Item(i).LegendText = i & " " & strMassX5(i) & " " & strMassY5(i)
            graf.Chart5.Series.Item(i).Points.AddXY(i, strMassY5(i)) '' установка точек диаграммы 
            'graf.Chart2.Series.Item(i).Points.Item(i).Label = strMassY2(i)  '' подпись значений Y сверху точек диаграммы
        Next



        graf.Show()
    End Sub
End Class