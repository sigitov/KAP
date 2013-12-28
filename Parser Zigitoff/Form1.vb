Imports mshtml
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Dim Client As New Net.WebClient
    Dim curr_anime As String
    Dim csv_err As Integer = 0
    Dim it As Integer = 0
    Dim i5 As Integer = 0
    Dim i2 As Integer = 0
    Dim i3 As Integer = 0
    Dim i4 As Integer = 0
    Dim te() As String
    Dim tmp As Integer = 0
    Dim tmp2 As Integer = 0
    Dim ignor As Integer = 0
    Dim ffile As Integer = FreeFile()
    Dim sta, sta2 As String
    Dim hz As String
    Dim h, m, s As Integer
    Dim errors As Integer = 0
    Dim max As Integer = 0
    Dim anime, formats As String
    Function parsemyhtml2(ByVal html)
        Dim regexp As New Regex("<a href=(.*?) class=(.*?)>(.*?)</a>")
        Dim regexp2 As New Regex("<a href=(.*?)>(.*?)</a>")
        Dim m As MatchCollection
        m = regexp.Matches(html)
        For i = 0 To m.Count - 1
            RichTextBox2.AppendText(m.Item(i).Value & vbCrLf)
            If m.Item(i).Value.Contains("details.php") = True And m.Item(i).Value.Contains("userdetails") = False Then
                Dim ssilka() As String
                ssilka = m.Item(i).Value.Split(My.Settings.dududu)
                If RichTextBox3.Text.Contains("http://kinozal.tv" & ssilka(1)) = True Then
                    i3 = i3 + 1
                Else
                    i2 = i2 + 1
                    ListBox2.Items.Add("http://kinozal.tv" & ssilka(1))
                    RichTextBox3.AppendText("http://kinozal.tv" & ssilka(1) & vbCrLf)
                End If
            End If
            If m.Item(i).Value.Contains("page") = True Then
                Dim tes As String
                tes = m.Item(i).Value.Replace("</li><li>", "%")
                Dim tmp1() As String
                Dim tmp22() As String
                tmp1 = tes.Split("%")
                For ii = 0 To tmp1.Count - 1 Step 1
                    If tmp1(ii).Contains("dots") = False Then
                        tmp22 = tmp1(ii).Replace("<a href=", "").Replace("?c=20&amp;page=", "").Split(My.Settings.dududu)
                        If ignor = 0 Then
                            If tmp < tmp22(1) Then
                                tmp = tmp22(1)
                                Label13.Text = tmp
                            End If
                        End If
                        If ListBox1.Items.Contains(TextBox1.Text & "&page=" & tmp22(1)) = False Then
                            i4 = i4 + 1
                        End If


                        ListBox1.Items.Add(TextBox1.Text & "&page=" & tmp22(1))
                        RichTextBox4.AppendText(TextBox1.Text & "&page=" & tmp22(1) & vbCrLf)
                    End If
                Next
            End If
            i5 = i5 + 1
            Label3.Text = i5
            Label5.Text = i2
            Label7.Text = i3
            Label9.Text = i4
        Next
        ignor = 1
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            PictureBox1.ImageLocation = "http://kinozal.tv/pic/cat/" & TextBox1.Text.Split("=")(1) & ".gif"
            parsemyhtml2(Client.DownloadString(TextBox1.Text))
            Button1.Enabled = False
        Catch ex As Exception
            Button1.Enabled = True
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        For i = 1 To tmp Step 1
            Try
                Button2.Enabled = False
                Label11.Text = TextBox1.Text & "&page=" & i
                parsemyhtml2(Client.DownloadString(TextBox1.Text & "&page=" & i))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Threading.Thread.Sleep(15)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Button3.Enabled = False
            tmp2 = ListBox2.Items.Count
            FileOpen(ffile, "data.csv", OpenMode.Output)
            FileClose()
            Timer1.Start()
            Timer2.Start()
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim csv As String = ""
        Dim csv_arr() As String
        Dim regexp As New Regex("<b>Название:</b>(.*?)<br />")
        Dim regexp2 As New Regex("<b>Год выпуска:</b>(.*?)<br />")
        Dim regexp3 As New Regex("<b>Выпущено:</b>(.*?)<")
        Dim regexp4 As New Regex(">Скачали<span class=(.*?)>(.*?)</span>")
        Dim regexp5 As New Regex("<b>Продолжительность:</b>(.*?)<br />")
        Dim regexp6 As New Regex("Комментариев<span class=(.*?)>(.*?)</span>")
        Dim regexp7 As New Regex("Список файлов<span class=(.*?)>(.*?)</span>")
        Dim regexp8 As New Regex("<b> Название: </b>(.*?)<br />")
        Dim regexp9 As New Regex("<b>Название: </b>(.*?)<br />")
        Dim regexp10 As New Regex("<b>Качество:</b>(.*?)<br />")
        Dim regexp11 As New Regex("<b>Размер:</b>(.*?)<br />")
        Dim regexp12 As New Regex("<b>Аудио:</b>(.*?)<br />")
        Dim regexp13 As New Regex("<b>Видео:</b> (.*?)<br />")
        Dim regexp14 As New Regex("IMDb<span class=(.*?)floatright(.*?)>(.*?)</span>")
        Dim regexp15 As New Regex("Кинопоиск<span class=(.*?)floatright(.*?)>(.*?)</span>")
        Dim regexp16 As New Regex("<b>Режиссер:</b> <a href=(.*?) class=(.*?) target=(.*?)>(.*?)</a><br />")
        Dim regexp17 As New Regex("<b>Жанр:</b> (.*?)<br />")
        Dim html As String
        Dim m As MatchCollection
        FileOpen(ffile, "data.csv", OpenMode.Append)

        For ii = 0 To tmp2 - 1 Step 1
            Try
                Dim tololo() As String
                sta = ii
                sta2 = ListBox2.Items.Item(ii)
                html = Client.DownloadString(ListBox2.Items.Item(ii))
                Dim tol() As String
                tol = ListBox2.Items.Item(ii).split("=")
                csv = csv & tol(1) & ";"
                csv = csv & ListBox2.Items.Item(ii) & ";"
                ' Тут нужно добавить вариант с пробелами перед словом "Название"
                m = regexp.Matches(html)
                If m.Count > 0 Then
                    csv = csv & (m.Item(0).Value.Replace("<b>Название:</b> ", "").Replace("<br />", "").Replace("&quot;", "").Replace(";", "") & ";")
                End If
                m = regexp8.Matches(html)
                If m.Count > 0 Then
                    csv = csv & (m.Item(0).Value.Replace("<b> Название: </b> ", "").Replace("<br />", "").Replace("&quot;", "").Replace(";", "") & ";")
                End If
                m = regexp9.Matches(html)
                If m.Count > 0 Then
                    csv = csv & (m.Item(0).Value.Replace("<b>Название: </b>", "").Replace("<br />", "").Replace("&quot;", "").Replace(";", "") & ";")

                End If

                m = regexp2.Matches(html)
                If m.Item(0).Value.Contains("-") = True Then
                    tololo = m.Item(0).Value.Replace("<b>Год выпуска:</b> ", "").Replace("<br />", "").Split("-")
                    csv = csv & tololo(0) & ";"
                Else
                    csv = csv & (m.Item(0).Value.Replace("<b>Год выпуска:</b> ", "").Replace("<br />", "") & ";")
                End If
                m = regexp3.Matches(html)
                If m.Count > 0 Then
                    If m.Item(0).Value.Contains(",") = True Then
                        tololo = m.Item(0).Value.Replace("<b>Выпущено:</b> ", "").Replace("&quot", "").Replace("<", "").Split(",")
                        csv = csv & tololo(0) & ";"
                    Else
                        csv = csv & m.Item(0).Value.Replace("<b>Выпущено:</b> ", "").Replace("&quot", "").Replace("<", "") & ";"
                    End If
                Else
                    csv = csv & "Япония;"
                End If

                m = regexp4.Matches(html)
                If m.Count > 0 Then
                    tololo = m.Item(0).Value.Split(My.Settings.dududu)
                    csv = csv & tololo(2).Replace(">", "").Replace("</span", "") & ";"
                Else
                    csv = csv & "0;"
                End If
                m = regexp5.Matches(html)
                If m.Item(0).Value.Contains("x") = True Then
                    tololo = m.Item(0).Value.Replace("<b>Продолжительность:</b> ", "").Split("x")
                    If tololo(0).Contains("х") = True Then
                        tololo = tololo(0).Split("х")
                    End If
                    csv = csv & tololo(0).Replace(" ", "") & ";"
                Else
                    csv = csv & "1" & ";"
                End If
                m = regexp6.Matches(html)
                If m.Count > 0 Then
                    tololo = m.Item(0).Value.Split(My.Settings.dududu)
                    csv = csv & tololo(2).Replace(">", "").Replace("</span", "") & ";"
                Else
                    csv = csv & "0" & ";"
                End If

                m = regexp7.Matches(html)

                If m.Count > 0 Then
                    tololo = m.Item(0).Value.Split(My.Settings.dududu)
                    csv = csv & tololo(2).Replace(">", "").Replace("</span", "") & ";"
                Else
                    csv = csv & "0" & ";"
                End If

                m = regexp10.Matches(html)
                If m.Count > 0 Then
                    csv = csv & m.Item(0).Value.Replace("<b>Качество:</b>", "").Replace("<br />", "") & ";"
                End If
                m = regexp11.Matches(html)
                If m.Count > 0 Then
                    csv = csv & m.Item(0).Value.Replace("<b>Размер:</b>", "").Replace("<br />", "") & ";"
                End If
                m = regexp12.Matches(html)
                If m.Count > 0 Then
                    csv = csv & m.Item(0).Value.Replace("<b>Аудио:</b>", "").Replace("<br />", "") & ";"
                End If
                m = regexp13.Matches(html)
                If m.Count > 0 Then
                    csv = csv & m.Item(0).Value.Replace("<b>Видео:</b>", "").Replace("<br />", "") & ";"
                End If
                m = regexp14.Matches(html)
                If m.Count > 0 Then
                    csv = csv & m.Item(0).Value.Replace("IMDb<span class=", "").Replace(My.Settings.dududu, "").Replace("</span>", "").Replace("floatright", "").Replace(">", "") & ";"
                Else
                    csv = csv & "0;"
                End If
                m = regexp15.Matches(html)
                If m.Count > 0 Then
                    csv = csv & m.Item(0).Value.Replace("Кинопоиск<span class=", "").Replace(My.Settings.dududu, "").Replace("</span>", "").Replace("floatright", "").Replace(">", "") & ";"
                Else
                    csv = csv & "0;"
                End If
                m = regexp16.Matches(html)
                If m.Count > 0 Then
                    tololo = m.Item(0).Value.Split(My.Settings.dududu)
                    csv = csv & tololo(6).Replace(">", "").Replace("</a<br /", "").Replace("</a, <a href=", "") & ";"
                Else
                    csv = csv & "0;"
                End If
                m = regexp17.Matches(html)
                If m.Count > 0 Then
                    csv = csv & m.Item(0).Value.Replace("<b>Жанр:</b> ", "").Replace("<br />", "").Replace(", мультсериал", "").Replace(", полнометражный", "").Replace(", боевые искусства", "").Replace(", фильм", "")
                Else
                    csv = csv & "0"
                End If
                csv_arr = csv.Split(";")
                curr_anime = csv_arr(2)
                If csv_arr.Length < 17 Or csv_arr.Length > 17 Or csv_arr(15) = "0" Then
                    csv_err = csv_err + 1
                    csv = ""
                Else
                    PrintLine(ffile, csv)
                    csv = ""
                End If

            Catch ex As Exception

                csv = ""
                errors = errors + 1
                ' MsgBox(ex.Message)
            End Try
        Next
        FileClose()
        MsgBox("Работа программы завершена", MsgBoxStyle.Information)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label22.Text = errors
        Label24.Text = csv_err
        Label15.Text = curr_anime
        Label17.Text = sta
        Try
            ProgressBar1.Value = sta * 100 / (tmp2 - 1)
        Catch ex As Exception

        End Try

        Label18.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value = "100" Then
            Timer2.Stop()
            Timer1.Stop()
            Button4.Enabled = True
        End If
        Label26.Text = Math.Round((csv_err + errors) * 100 / sta, 2) & " %"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Stop()
        Timer2.Stop()
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        s = s + 1
        If s = 60 Then
            m = m + 1
            s = 0
        End If
        If m = 60 Then
            m = 0
            h = h + 1
        End If
        Label20.Text = h & ":" & m & ":" & s
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser("data.csv", System.Text.Encoding.Default)

        TextFieldParser1.Delimiters = New String() {";"}

        While Not TextFieldParser1.EndOfData
            Dim Row1 As String() = TextFieldParser1.ReadFields()

            If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                Dim i As Integer

                For i = 0 To Row1.Count - 1
                    DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                Next
            End If

            DataGridView1.Rows.Add(Row1)
        End While
        DataGridView1.Columns.Remove("Column1")
        DataGridView1.Columns.Remove("Column4")
        DataGridView1.Columns.Remove("Column11")
        DataGridView1.Columns.Remove("Column12")
        DataGridView1.Columns.Remove("Column13")
        DataGridView1.Columns.Remove("Column14")
        DataGridView1.Columns.Remove("Column16")

        Button5.Enabled = True
        Button6.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        FileOpen(ffile, "data2.csv", OpenMode.Output)
        Dim csv As String
        For i = 0 To DataGridView1.Rows.Count - 2 Step 1
            For ii = 0 To DataGridView1.Columns.Count - 1 Step 1
                If ii < DataGridView1.Columns.Count - 1 Then
                    csv = csv & DataGridView1.Item(ii, i).Value & ";"
                Else
                    csv = csv & DataGridView1.Item(ii, i).Value
                End If

            Next
            PrintLine(ffile, csv)
            csv = ""
        Next
        FileClose()
        MsgBox("Данные сохранены")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim rows As Integer = 0
        Dim cont As Integer = 0
        For i = 0 To DataGridView1.Rows.Count - 2 Step 1
            If DataGridView1.Item("Column5", i).Value > max Then
                max = DataGridView1.Item("Column5", i).Value
                analiz.Label6.Text = DataGridView1.Item("Column2", i).Value
                analiz.Label8.Text = DataGridView1.Item("Column5", i).Value
                analiz.DataGridView1.Rows.Add(DataGridView1.Item("Column2", i).Value, DataGridView1.Item("Column5", i).Value)
            End If

        Next
        max = 0
        For i = 0 To DataGridView1.Rows.Count - 2 Step 1
            If DataGridView1.Item("Column7", i).Value > max Then
                max = DataGridView1.Item("Column7", i).Value
                analiz.Label2.Text = DataGridView1.Item("Column2", i).Value
                analiz.Label4.Text = DataGridView1.Item("Column7", i).Value

            End If
        Next
        rows = analiz.DataGridView1.Rows.Count
        For i = rows - 7 To 0 Step -1
            analiz.DataGridView1.Rows.Remove(analiz.DataGridView1.Rows.Item(i))
            'analiz.DataGridView1.Rows.RemoveAt(analiz.DataGridView1.SelectedRows(i).Index)
        Next
        For ii = 1990 To 2013 Step 1
            For i = 0 To DataGridView1.Rows.Count - 2 Step 1

                If DataGridView1.Item("Column3", i).Value = ii Then
                    cont = cont + 1
                End If

            Next
            analiz.DataGridView2.Rows.Add(ii, cont)
            cont = 0
        Next
        For i = 0 To DataGridView1.Rows.Count - 2 Step 1
            If ListBox3.Items.Contains(DataGridView1.Item("Column9", i).Value.ToString.Split("(")(0).Replace(" ", "")) = False Then
                ListBox3.Items.Add(DataGridView1.Item("Column9", i).Value.ToString.Split("(")(0).Replace(" ", ""))
            End If
        Next
        Dim ci As Integer = 0
        Try
            For i = 0 To ListBox3.Items.Count - 1
                For ii = 0 To DataGridView1.Rows.Count - 2 Step 1
                    If DataGridView1.Item("Column9", ii).Value.ToString.Split("(")(0).Replace(" ", "") = ListBox3.Items(i).ToString Then
                        ci = ci + 1
                    End If
                Next
                analiz.DataGridView3.Rows.Add(ListBox3.Items(i), ci)
                ci = 0
            Next
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try


        Dim zanr() As String
        For i = 0 To DataGridView1.Rows.Count - 2 Step 1
            zanr = DataGridView1.Item("Column17", i).Value.ToString.Split(",")
            For ii = 0 To zanr.Length - 1 Step 1
                If ListBox4.Items.Contains(zanr(ii).Replace(" ", "").ToLower) = False Then
                    ListBox4.Items.Add(zanr(ii).Replace(" ", "").ToLower)
                End If
            Next

        Next
        Dim ca As Integer = 0
        Dim ca2 As Integer = 0
        Try
            For i = 0 To ListBox4.Items.Count - 1
                For ii = 0 To DataGridView1.Rows.Count - 2 Step 1
                    If DataGridView1.Item("Column17", ii).Value.ToString.Contains(ListBox4.Items(i).ToString) = True Then

                        ca2 = ca2 + DataGridView1.Item("Column5", ii).Value
                        ca = ca + 1
                    End If

                Next
                analiz.DataGridView4.Rows.Add(ListBox4.Items(i), ca, ca2)
                ca = 0
                ca2 = 0
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Заменить тут на массив ошибок
        Dim sm As Integer = 0
        For i = 0 To analiz.DataGridView4.Rows.Count - 2 Step 1
            If analiz.DataGridView4.Item("DataGridViewTextBoxColumn6", i - sm).Value = "0" Then
                analiz.DataGridView4.Rows.RemoveAt(i - sm)
                sm = sm + 1
            End If
        Next





        Dim hd As Integer = 0
        Dim hd1 As Integer = 0
        Dim hd2 As Integer = 0
        For i = 0 To DataGridView1.Rows.Count - 2 Step 1
            If ListBox6.Items.Contains(DataGridView1.Item("Column15", i).Value) = False Then
                ListBox6.Items.Add(DataGridView1.Item("Column15", i).Value)
            End If
        Next
        Dim cd As Integer = 0
        Dim cd2 As Integer = 0
        Try
            For i = 0 To ListBox6.Items.Count - 1
                For ii = 0 To DataGridView1.Rows.Count - 2 Step 1
                    If DataGridView1.Item("Column15", ii).Value = ListBox6.Items(i).ToString Then
                        cd = cd + 1
                        cd2 = cd2 + DataGridView1.Item("Column6", ii).Value
                        If ListBox6.Items(i) = "Датэ Хаято" Or ListBox6.Items(i) = "Хаято Датэ" Then
                            hd1 = hd1 + 1
                            hd2 = hd2 + DataGridView1.Item("Column6", ii).Value
                        End If
                    End If
                Next
                If ListBox6.Items(i) = "Датэ Хаято" Or ListBox6.Items(i) = "Хаято Датэ" Then

                Else
                    analiz.DataGridView5.Rows.Add(ListBox6.Items(i), cd, cd2)
                End If

                cd = 0
                cd2 = 0
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Dim tro As Integer
        For i = 0 To DataGridView1.Rows.Count - 2 Step 1
            tro = DataGridView1.Item("Column7", i).Value
            analiz.DataGridView6.Rows.Add(DataGridView1.Item("Column2", i).Value, tro)
        Next

      



        analiz.DataGridView5.Rows.Add("Хаято Датэ", hd1, hd2)
        analiz.DataGridView4.Sort(analiz.DataGridView4.Columns.Item(1), System.ComponentModel.ListSortDirection.Descending)
        analiz.DataGridView5.Sort(analiz.DataGridView5.Columns.Item(1), System.ComponentModel.ListSortDirection.Descending)
        analiz.DataGridView6.Sort(analiz.DataGridView6.Columns.Item(1), System.ComponentModel.ListSortDirection.Descending)
        analiz.Show()

    End Sub


End Class
