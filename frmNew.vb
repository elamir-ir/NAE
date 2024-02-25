Imports System.IO
Imports System.Text

Public Class frmNew
    Dim si As Integer
    Public st As Integer = 0
    Dim ld As String = ""
    Public strOutput As String
    Public Function doc(ByVal a As String, ByVal b As Integer)
        Dim procInfo As New ProcessStartInfo()
        Dim prcc = New Process()
        Select Case b
            Case 1
                Dim path As String = Application.StartupPath() + "\NAE\das"
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(a)
                fs.Write(info, 0, info.Length)
                fs.Close()
                Try
                    procInfo.Verb = "runas"
                    procInfo.FileName = (Application.StartupPath() + "\NAE\anj.bat")
                    procInfo.WorkingDirectory = ""
                    procInfo.WindowStyle = ProcessWindowStyle.Hidden
                    procInfo.UseShellExecute = True
                    Dim localDate = DateTime.Now
                    procInfo.CreateNoWindow = True
                    prcc = Process.Start(procInfo)
                    prcc.WaitForExit()
                    Dim localDate2 = DateTime.Now - localDate
                    Return localDate2.TotalSeconds.ToString
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString())
                End Try
            Case 2
                Dim path As String = Application.StartupPath() + "\NAE\Batch.cmd"
                Dim fs As FileStream = File.Create(path)
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(a)
                fs.Write(info, 0, info.Length)
                fs.Close()
                Try
                    procInfo.FileName = (Application.StartupPath() + "\NAE\Batch.cmd")
                    procInfo.WorkingDirectory = ""
                    procInfo.WindowStyle = ProcessWindowStyle.Hidden
                    procInfo.UseShellExecute = False
                    Dim localDate = DateTime.Now
                    procInfo.CreateNoWindow = True
                    prcc = Process.Start(procInfo)
                    prcc.WaitForExit()
                    Dim localDate2 = DateTime.Now - localDate
                    Return localDate2.TotalSeconds.ToString
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString())
                End Try
        End Select
    End Function
    Private Sub address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles address.TextChanged
        If address.Text <> "" Then
            lstResult.Items.Add("فایل یا پوشه انتخاب شده : " + address.Text)
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        lstResult.Items.Add("نوع عملیات : " + ComboBox1.Text)
        ComboBox1.ResetText()
        si = ComboBox1.SelectedIndex + 4
        Select Case si
            Case 4
                TextBox1.Enabled = True
                address.Text = ""
                ListBox1.Items.Clear()
                Button2.Enabled = True
                Label5.Text = "رمز را وارد کنید:"
            Case 5
                TextBox1.Enabled = True
                address.Text = ""
                Button2.Enabled = True
                ListBox1.Items.Clear()
                Label5.Text = "رمز را وارد کنید:"
            Case 6
                TextBox1.Enabled = True
                address.Text = ""
                Button2.Enabled = True
                ListBox1.Items.Clear()
                Label5.Text = "رمز را وارد کنید:"
            Case 7
                TextBox1.Enabled = True
                address.Text = ""
                Button2.Enabled = True
                ListBox1.Items.Clear()
                Label5.Text = "رمز را وارد کنید:"
            Case 8
                TextBox1.Enabled = True
                Button2.Enabled = True
                address.Text = ""
                ListBox1.Items.Clear()
                Label5.Text = "تعداد دفعات تخریب اطلاعات:"
            Case 9
                TextBox1.Enabled = True
                Button2.Enabled = True
                address.Text = ""
                ListBox1.Items.Clear()
                Label5.Text = "تعداد دفعات تخریب اطلاعات:"
            Case 10
                TextBox1.Enabled = True
                address.Text = ""
                Button2.Enabled = True
                ListBox1.Items.Clear()
                Label5.Text = "نام پوشه پس از قفل کردن:"
            Case 11
                TextBox1.Enabled = True
                Button2.Enabled = True
                address.Text = ""
                ListBox1.Items.Clear()
                Label5.Text = "نام پوشه پس از قفل گشایی:"
            Case 12
                TextBox1.Enabled = False
                TextBox1.Text = ""
                Button2.Enabled = True
                Label5.Text = ""
                address.Text = ""
                ListBox1.Items.Clear()
            Case 13
                TextBox1.Enabled = False
                TextBox1.Text = ""
                Button2.Enabled = True
                Label5.Text = ""
                address.Text = ""
                ListBox1.Items.Clear()
            Case 14
                TextBox1.Enabled = False
                TextBox1.Text = ""
                Button2.Enabled = True
                address.Text = ""
                Label5.Text = ""
                ListBox1.Items.Clear()
            Case 15
                TextBox1.Enabled = False
                TextBox1.Text = ""
                Button2.Enabled = True
                address.Text = ""
                Label5.Text = ""
                ListBox1.Items.Clear()

        End Select
    End Sub
    Private Sub cmbDrives_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDrives.SelectedIndexChanged
        lstResult.Items.Add("درایو انتخاب شده : " + cmbDrives.Text)
        ComboBox1.ResetText()
    End Sub

    Private Sub cmbDriveProcc_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDriveProcc.SelectedIndexChanged
        lstResult.Items.Add("نوع عملیات : " + cmbDriveProcc.Text)
        ComboBox1.ResetText()
        si = cmbDriveProcc.SelectedIndex
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If TabControl1.SelectedIndex = 1 And cmbDriveProcc.SelectedIndex = -1 Then
            MsgBox("لطفا عملیاتی که می خواهید انجام شود را انتخاب کنید.")
        ElseIf TabControl1.SelectedIndex = 1 And cmbDrives.SelectedIndex = -1 Then
            MsgBox("لطفا یک درایو را انتخاب کنید.")
        ElseIf TabControl1.SelectedIndex = 0 And ComboBox1.SelectedIndex = -1 Then
            MsgBox("لطفا عملیاتی که می خواهید انجام شود را انتخاب کنید.")
        ElseIf TabControl1.SelectedIndex = 0 And address.Text = "" Then
            MsgBox("لطفا یک فایل یا پوشه را انتخاب کنید.")
        Else
            Select Case si
                Case 0
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + doc("select volume " + Mid(cmbDrives.SelectedItem, 1, 1) + vbCrLf + "attributes disk set readonly", 1))
                    MsgBox("برای اعمال تغییرات باید حافظه جانبی را قطع و وصل کنید.")
                Case 1
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + doc("select volume " + Mid(cmbDrives.SelectedItem, 1, 1) + vbCrLf + "attributes disk clear readonly", 1))
                    MsgBox("برای اعمال تغییرات باید حافظه جانبی را قطع و وصل کنید.")
                Case 2
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + doc("select volume " + Mid(cmbDrives.SelectedItem, 1, 1) + vbCrLf + "remove", 1))
                Case 3
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + doc("select volume " + Mid(cmbDrives.SelectedItem, 1, 1) + vbCrLf + "assign", 1))
                Case 4
                    If TextBox1.Text = "" Then
                        MsgBox("لطفا رمز خود را وارد کنید.")
                    Else
                        Dim localDate = DateTime.Now
                        Dim strSecretKey As String = TextBox1.Text.Trim()
                        Dim chrs As Char() = strSecretKey.ToCharArray
                        Dim bytes As Byte()
                        bytes = Encoding.UTF8.GetBytes(chrs)
                        EncDec.Enc(address.Text, strOutput, bytes)
                        File.Delete(address.Text)
                        Dim localDate2 = DateTime.Now - localDate
                        ProgressBar1.Value = 0
                        lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)
                    End If
                Case 5
                    If TextBox1.Text = "" Then
                        MsgBox("لطفا رمز خود را وارد کنید.")
                    Else
                        Dim localDate = DateTime.Now
                        Dim strSecretKey As String = TextBox1.Text.Trim()
                        Dim chrs As Char() = strSecretKey.ToCharArray
                        Dim bytes As Byte()
                        bytes = Encoding.UTF8.GetBytes(chrs)
                        EncDec.Dec(address.Text, strOutput, bytes)
                        If st = 1 Then
                            lstResult.Items.Add("رمز اشتباه است، فایل: " + address.Text)
                            File.Delete(strOutput)
                            st = 0
                        Else
                            File.Delete(address.Text)
                        End If
                        Dim localDate2 = DateTime.Now - localDate
                        ProgressBar1.Value = 0
                        lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)
                    End If
                Case 6
                    If TextBox1.Text = "" Then
                        MsgBox("لطفا رمز خود را وارد کنید.")
                    Else
                        Dim localDate = DateTime.Now
                        Dim path As String = address.Text
                        If Directory.Exists(path) Then
                            ProcessDirectory(path)
                        Else
                            MsgBox("Not a valid file or directory. " + path)
                        End If
                        Dim localDate2 = DateTime.Now - localDate
                        lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)
                    End If
                Case 7
                    If TextBox1.Text = "" Then
                        MsgBox("لطفا رمز خود را وارد کنید.")
                    Else
                        Dim localDate = DateTime.Now
                        Dim path As String = address.Text
                        If Directory.Exists(path) Then
                            ProcessDirectory(path)
                        Else
                            MsgBox("Not a valid file or directory. " + path)
                        End If
                        Dim localDate2 = DateTime.Now - localDate
                        lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)
                    End If
                Case 8
                    Dim ProcInfo = New ProcessStartInfo
                    ProcInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "nae\sdelete.exe"
                    ProcInfo.Arguments = "-p " + TextBox1.Text + " -q " + dels(address.Text)
                    Dim prcc As New Process
                    ProcInfo.UseShellExecute = False
                    Dim localDate = DateTime.Now
                    ProcInfo.CreateNoWindow = True
                    prcc = Process.Start(ProcInfo)
                    prcc.WaitForExit()
                    Dim localDate2 = DateTime.Now - localDate
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)
                Case 9
                    Dim ProcInfo = New ProcessStartInfo
                    ProcInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "nae\sdelete.exe"
                    ProcInfo.Arguments = "-p " + TextBox1.Text + " -s -q " + dels(address.Text)
                    Dim prcc As New Process
                    ProcInfo.UseShellExecute = False
                    Dim localDate = DateTime.Now
                    ProcInfo.CreateNoWindow = True
                    prcc = Process.Start(ProcInfo)
                    prcc.WaitForExit()
                    Dim localDate2 = DateTime.Now - localDate
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)

                Case 10
                    Dim localDate = DateTime.Now
                    My.Computer.FileSystem.RenameDirectory(address.Text, TextBox1.Text + ".{2559A1F2-21D7-11D4-BDAF-00C04F60B9F0}")
                    Dim localDate2 = DateTime.Now - localDate
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)
                Case 11
                    If TextBox1.Text = "" Then
                        MsgBox("لطفا نام پوشه پس از بازگشایی را انتخاب کنید.")
                    Else
                        Dim localDate = DateTime.Now
                        My.Computer.FileSystem.RenameDirectory(address.Text + ".{2559A1F2-21D7-11D4-BDAF-00C04F60B9F0}", TextBox1.Text)
                        Dim localDate2 = DateTime.Now - localDate
                        lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + localDate2.TotalSeconds.ToString)
                    End If
                Case 12
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + doc("cd /d " + dels(address.Text) + vbCrLf + "attrib +s +h *.* /s /d", 2))
                Case 13
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + doc("cd /d " + dels(address.Text) + vbCrLf + "attrib -s -h *.* /s /d", 2))
                Case 14
                    lstResult.Items.Add("پایان عملیات ، زمان اجرا:" + doc("Ren \\.\" + dels(address.Text) + " " + "AUX." + dels(Mid(address.Text, address.Text.LastIndexOf("\") + 2)), 2))
                Case 15
                    If ListBox1.SelectedIndex = -1 Then
                        MsgBox("لطفا از لیست، یک فایل را انتخاب کنید.")
                    Else
                        lstResult.Items.Add("زمان اجرا:" + doc("Ren \\.\" + dels(address.Text + "\" + ListBox1.SelectedItem) + " " + dels(Mid(ListBox1.SelectedItem, 5)), 2))
                    End If
                
            End Select
            TextBox1.Text = ""
            ComboBox1.ResetText()
            ComboBox1.SelectedIndex = -1
            cmbDriveProcc.ResetText()
            lstResult.Items.Remove("نوع عملیات : ")
            cmbDrives.ResetText()
            address.Text = ""
            Button2.Enabled = False
            ListBox1.Items.Clear()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim attr As System.IO.FileAttributes
        Dim info As System.IO.FileInfo
        Select Case si
            Case 4
                OpenFileDialog1.Title = "لطفا یک فایل گزینش کنید"
                OpenFileDialog1.Filter = "All files (*.*)|*.*"
                OpenFileDialog1.FilterIndex = 1
                OpenFileDialog1.FileName = String.Empty
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Try
                        info = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName)
                        attr = info.Attributes
                        address.Text = OpenFileDialog1.FileName
                        lstResult.Items.Add("Type: " + info.Attributes.ToString)
                        lstResult.Items.Add("Creation time: " + info.CreationTime.ToString)
                        lstResult.Items.Add("Last access time: " + info.LastAccessTime.ToString)
                        lstResult.Items.Add("Last write time: " + info.LastWriteTime.ToString)
                        lstResult.Items.Add("File size: " + info.Length.ToString + " Bytes")
                    Catch
                    End Try
                    Dim strFileToEncrypt As String = ""
                    Dim strExtension As String = ""
                    'Find out if the user chose a file.
                    strFileToEncrypt = OpenFileDialog1.FileName
                    address.Text = strFileToEncrypt
                    Dim iPosition As Integer = 0
                    'Get the position of the last "\" in the OpenFileDialog.FileName path.
                    '* -1 is when the character your searching for is not there.
                    '* IndexOf searches from left to right.
                    iPosition = strFileToEncrypt.LastIndexOf(".")
                    If iPosition = -1 Then
                        MessageBox.Show("Invalid file. Please select proper file.")
                    End If

                    'strOutputFile = the file path minus the last 8 characters (.encrypt)
                    strExtension = strFileToEncrypt.Substring(iPosition, (strFileToEncrypt.Length - iPosition))
                    'Assign strOutputFile to the position after the last "\" in the path.  
                    Dim strEncryptedExt As String = "@-@" + strExtension.Substring(1) + ".msh"
                    strOutput = strFileToEncrypt.Replace(strExtension, strEncryptedExt)
                    'Update buttons
                End If
            Case 5
                OpenFileDialog1.Title = "لطفا یک فایل گزینش کنید"
                OpenFileDialog1.FilterIndex = 1
                OpenFileDialog1.FileName = String.Empty
                OpenFileDialog1.Filter = "Encrypted Files (*.msh)|*.msh|All Files (*.*)|*.*"
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Try
                        info = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName)
                        attr = info.Attributes
                        address.Text = OpenFileDialog1.FileName
                        lstResult.Items.Add("Type: " + info.Attributes.ToString)
                        lstResult.Items.Add("Creation time: " + info.CreationTime.ToString)
                        lstResult.Items.Add("Last access time: " + info.LastAccessTime.ToString)
                        lstResult.Items.Add("Last write time: " + info.LastWriteTime.ToString)
                        lstResult.Items.Add("File size: " + info.Length.ToString + " Bytes")
                    Catch
                    End Try
                    Dim strFileToDecrypt As String = ""
                    Dim strExtension As String = ""
                    strFileToDecrypt = OpenFileDialog1.FileName
                    address.Text = strFileToDecrypt
                    Dim iPosition As Integer = 0
                    'Get the position of the last "\" in the OpenFileDialog.FileName path.
                    '* -1 is when the character your searching for is not there.
                    '* IndexOf searches from left to right.
                    iPosition = strFileToDecrypt.LastIndexOf(".msh")
                    If (iPosition = -1) OrElse (iPosition <> (strFileToDecrypt.Length - 4)) Then
                        MessageBox.Show("Invalid file. Please select proper encrypted file.")
                    End If

                    'strOutputFile = the file path minus the last 8 characters (.encrypt)
                    strOutput = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 4)
                    'Assign strOutputFile to the position after the last "\" in the path.
                    iPosition = strOutput.IndexOf("@-@")
                    If iPosition = -1 Then
                        MsgBox("نام فایل پس از رمزنگاری تغییر کرده و نرم افزار قادر به شناسایی پسوند آن نیست. به همین علت پسوند پیشفرض روی فایل گذاشته خواهد شد.")
                        strOutput = strOutput + ".dat"
                    Else
                        strOutput = strOutput.Replace("@-@", ".")
                    End If
                    'Update buttons
                End If
            Case 6
                If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    address.Text = FolderBrowserDialog1.SelectedPath
                End If
            Case 7
                OpenFileDialog1.FileName = String.Empty
                FolderBrowserDialog1.ShowDialog()
                'If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                address.Text = FolderBrowserDialog1.SelectedPath
                'End If
            Case 8
                OpenFileDialog1.FileName = String.Empty
                OpenFileDialog1.ShowDialog()
                'If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                address.Text = OpenFileDialog1.FileName
                'End If
            Case 9
                'If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                OpenFileDialog1.FileName = String.Empty
                FolderBrowserDialog1.ShowDialog()
                address.Text = FolderBrowserDialog1.SelectedPath
                TextBox1.Text = Mid(FolderBrowserDialog1.SelectedPath, FolderBrowserDialog1.SelectedPath.LastIndexOf("\") + 2, FolderBrowserDialog1.SelectedPath.Length)
                'End If
            Case 10
                'If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                OpenFileDialog1.FileName = String.Empty
                FolderBrowserDialog1.ShowDialog()
                If FolderBrowserDialog1.SelectedPath.Length >= 40 Then
                    If Mid(address.Text, FolderBrowserDialog1.SelectedPath.Length - 40, 39) <> ".{2559A1F2-21D7-11D4-BDAF-00C04F60B9F0}" Then
                        TextBox1.Text = Mid(FolderBrowserDialog1.SelectedPath, FolderBrowserDialog1.SelectedPath.LastIndexOf("\") + 2, FolderBrowserDialog1.SelectedPath.Length)
                        address.Text = FolderBrowserDialog1.SelectedPath
                    Else
                        MsgBox("پوشه ی قفل شده را نمیتوان دوباره قفل کرد.")
                    End If
                Else
                    TextBox1.Text = Mid(FolderBrowserDialog1.SelectedPath, FolderBrowserDialog1.SelectedPath.LastIndexOf("\") + 2, FolderBrowserDialog1.SelectedPath.Length)
                    address.Text = FolderBrowserDialog1.SelectedPath
                End If
                '  End If
            Case 11
                OpenFileDialog1.FileName = String.Empty
                If FolderBrowserDialog1.ShowDialog() = vbOK Then
                    If Mid(FolderBrowserDialog1.SelectedPath, FolderBrowserDialog1.SelectedPath.Length - 38, 39) = ".{2559A1F2-21D7-11D4-BDAF-00C04F60B9F0}" Then
                        address.Text = Mid(FolderBrowserDialog1.SelectedPath, 1, FolderBrowserDialog1.SelectedPath.Length - 39)
                        TextBox1.Text = Mid(FolderBrowserDialog1.SelectedPath, FolderBrowserDialog1.SelectedPath.LastIndexOf("\") + 2, FolderBrowserDialog1.SelectedPath.Length - 42)
                    Else
                        MsgBox("لطفا یک پوشه قفل شده را انتخاب کنید.")
                    End If
                End If
            Case 12
                    OpenFileDialog1.FileName = String.Empty
                    FolderBrowserDialog1.ShowDialog()
                address.Text = FolderBrowserDialog1.SelectedPath
            Case 13
                OpenFileDialog1.FileName = String.Empty
                FolderBrowserDialog1.ShowDialog()
                address.Text = FolderBrowserDialog1.SelectedPath
            Case 14
                OpenFileDialog1.FileName = String.Empty
                OpenFileDialog1.Title = "لطفا یک فایل گزینش کنید"
                OpenFileDialog1.Filter = "All files (*.*)|*.*"
                OpenFileDialog1.FilterIndex = 1
                OpenFileDialog1.ShowDialog()
                Try
                    info = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName)
                    attr = info.Attributes
                    address.Text = OpenFileDialog1.FileName
                    lstResult.Items.Add("Type: " + info.Attributes.ToString)
                    lstResult.Items.Add("Creation time: " + info.CreationTime.ToString)
                    lstResult.Items.Add("Last access time: " + info.LastAccessTime.ToString)
                    lstResult.Items.Add("Last write time: " + info.LastWriteTime.ToString)
                    lstResult.Items.Add("File size: " + info.Length.ToString + " Bytes")
                Catch
                End Try
            Case 15
                OpenFileDialog1.FileName = String.Empty
                FolderBrowserDialog1.ShowDialog()
                address.Text = FolderBrowserDialog1.SelectedPath
                    Try
                        ListFiles(FolderBrowserDialog1.SelectedPath)
                    Catch ex As Exception
                    End Try
        End Select
        If (si = 8 Or si = 9) And FolderBrowserDialog1.SelectedPath.Length = 3 Then
            address.Text = ""
            MsgBox("انتخاب یک درایو در این گزینه امکان پذیر نیست.")
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = Application.StartupPath() + "\NAE\Anj.bat"
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("Diskpart /s " + dels(Application.StartupPath() + "\NAE\das") + " > " + dels(Application.StartupPath() + "\NAE\kho"))
        fs.Write(info, 0, info.Length)
        fs.Close()
        rfrsh()
    End Sub
    Private Function dels(ByVal ent As String)
        ent = ent.Replace(" ", Chr(34) + " " + Chr(34))
        Return ent
    End Function
    Private Sub ListFiles(ByVal folderPath As String)
        ListBox1.Items.Clear()
        Dim fileNames = My.Computer.FileSystem.GetFiles(
            folderPath, FileIO.SearchOption.SearchTopLevelOnly, "AUX*.*")
        If fileNames.Count = 0 Then
            MsgBox("هیچ فایلی پیدا نشد.")
        Else
            For Each fileName As String In fileNames
                ListBox1.Items.Add(Mid(fileName, fileName.LastIndexOf("\") + 2))
            Next
        End If
    End Sub
    Private Function fhd()
        Dim mtn As String = ""
        Dim fr As String
        fr = My.Computer.FileSystem.ReadAllText(Application.StartupPath() + "\NAE\Kho")
        Dim lineCount = File.ReadAllLines(Application.StartupPath() + "\NAE\Kho").Length
        For x = 0 To lineCount - 9
            If Mid(fr, fr.IndexOf("Volume " + x.ToString) + 14, 1) = " " Then
                mtn += x.ToString + " " + Mid(fr, fr.IndexOf("Volume " + x.ToString) + 14, 15) + vbCrLf
            End If
        Next
        Return mtn
    End Function
    Private Function countCR(ByVal s)
        countCR = 0
        Dim n As Integer
        For n = 1 To Len(s)
            If Asc(Mid(s, n, 1)) = 13 Then
                countCR = countCR + 1
            End If
        Next n
        Return countCR
    End Function
    Private Function chk(ByVal pn)
        Dim p() As Process
        p = Process.GetProcessesByName(pn)
        If p.Count > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        lstResult.Items.Add("فایل انتخاب شده" + ListBox1.SelectedItem)
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rfrsh()
    End Sub
    Public Sub rfrsh()
        cmbDrives.ResetText()
        If si <> 3 Then
            ListBox2.Items.Add("x")
            Dim allDrives() As DriveInfo = DriveInfo.GetDrives
            Dim d As DriveInfo
            cmbDrives.Items.Clear()
            For Each d In allDrives
                If d.IsReady = True Then
                    Try
                        cmbDrives.Items.Add(d.Name + d.VolumeLabel)
                    Catch ex As Exception
                    End Try
                End If
            Next
        Else
            Dim w As String = fhd()
            If (String.IsNullOrEmpty(w) = False) Then
                Dim parts As String() = w.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
                cmbDrives.Items.Clear()
                For x = 0 To countCR(w) - 1
                    cmbDrives.Items.Add(parts(x))
                Next
            Else
                MsgBox("No hidden drives were found")
                cmbDrives.Items.Clear()
            End If
        End If
    End Sub
    Public Sub ProcessDirectory(ByVal targetDirectory As String)
        Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
        ' Process the list of files found in the directory.
        Dim fileName As String
        If si = 6 Then
            For Each fileName In fileEntries
                ProcessFileE(fileName)
            Next fileName
        Else
            For Each fileName In fileEntries
                If fileName.LastIndexOf(".msh") <> -1 Then
                    ProcessFileD(fileName)
                End If
            Next fileName
        End If
        Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
        ' Recurse into subdirectories of this directory.
        Dim subdirectory As String
        For Each subdirectory In subdirectoryEntries
            ProcessDirectory(subdirectory)
        Next subdirectory

    End Sub 'ProcessDirectory
    ' Insert logic for processing found files here.
    Public Sub ProcessFileE(ByVal fl As String)
        Dim strFileToEncrypt As String = fl
        Dim strExtension As String = ""
        Dim iPosition As Integer = 0
        iPosition = strFileToEncrypt.LastIndexOf(".")
        If iPosition <> -1 Then
            strExtension = strFileToEncrypt.Substring(iPosition, (strFileToEncrypt.Length - iPosition))
            Dim strEncryptedExt As String = "@-@" + strExtension.Substring(1) + ".msh"
            strOutput = strFileToEncrypt.Replace(strExtension, strEncryptedExt)
        Else
            strOutput = strFileToEncrypt + ".msh"
        End If
        Dim strSecretKey As String = TextBox1.Text.Trim()
        Dim chrs As Char() = strSecretKey.ToCharArray
        Dim bytes As Byte()
        bytes = Encoding.UTF8.GetBytes(chrs)
        EncDec.Enc(fl, strOutput, bytes)
        File.Delete(fl)
    End Sub
    Public Sub ProcessFileD(ByVal fl As String)
        Dim strFileToDecrypt As String = fl
        Dim strExtension As String = ""
        Dim iPosition As Integer = 0
        strOutput = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 4)
        iPosition = strOutput.IndexOf("@-@")
        If iPosition = -1 Then
            MsgBox("نام فایل پس از رمزنگاری تغییر کرده و نرم افزار قادر به شناسایی پسوند آن نیست. به همین علت پسوند پیشفرض روی فایل گذاشته خواهد شد.")
            strOutput = strOutput + ".dat"
        Else
            strOutput = strOutput.Replace("@-@", ".")
        End If
        Dim strSecretKey As String = TextBox1.Text.Trim()
        Dim chrs As Char() = strSecretKey.ToCharArray
        Dim bytes As Byte()
        bytes = Encoding.UTF8.GetBytes(chrs)
        EncDec.Dec(fl, strOutput, bytes)
        If st = 1 Then
            lstResult.Items.Add("رمز اشتباه است، فایل: " + fl)
            File.Delete(strOutput)
            st = 0
        Else
            File.Delete(fl)
        End If
    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Dim cc As New Process
        cc.Start(Application.StartupPath() + "\RHNM\index.html")
    End Sub
End Class