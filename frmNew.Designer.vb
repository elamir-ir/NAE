<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNew))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbFolder = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDrive = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbDriveProcc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbDrives = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1.SuspendLayout()
        Me.tbFolder.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.tbDrive.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListBox2
        '
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(0, 423)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(785, 4)
        Me.ListBox2.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbFolder)
        Me.TabControl1.Controls.Add(Me.tbDrive)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(386, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(392, 370)
        Me.TabControl1.TabIndex = 6
        '
        'tbFolder
        '
        Me.tbFolder.Controls.Add(Me.GroupBox5)
        Me.tbFolder.Controls.Add(Me.GroupBox9)
        Me.tbFolder.Controls.Add(Me.GroupBox6)
        Me.tbFolder.Controls.Add(Me.GroupBox7)
        Me.tbFolder.ImageIndex = 1
        Me.tbFolder.Location = New System.Drawing.Point(4, 31)
        Me.tbFolder.Name = "tbFolder"
        Me.tbFolder.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFolder.Size = New System.Drawing.Size(384, 335)
        Me.tbFolder.TabIndex = 1
        Me.tbFolder.Text = ":: محافظت از فایل ها و پوشه ها ::"
        Me.tbFolder.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(6, 98)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(374, 67)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "مرحله اول :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"رمز نگاری فایل", "رمز گشایی فایل", "رمز نگاری پوشه", "رمزگشایی پوشه", "وایپ کردن فایل", "وایپ کردن محتویات پوشه", "قفل کردن پوشه", "باز کردن قفل پوشه", "مخفی کردن محتویات پوشه", "نمایان کردن محتویات پوشه", "پاک نشدنی کردن فایل", "پاک شدنی کردن فایل"})
        Me.ComboBox1.Location = New System.Drawing.Point(5, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(364, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(259, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "نوع عملیات را تعیین کنید"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.TextBox1)
        Me.GroupBox9.Controls.Add(Me.ListBox1)
        Me.GroupBox9.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox9.Location = New System.Drawing.Point(6, 246)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(374, 89)
        Me.GroupBox9.TabIndex = 14
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "تنظیمات دیگر :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(259, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(257, 36)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 40)
        Me.TextBox1.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 20)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 56)
        Me.ListBox1.TabIndex = 12
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(374, 86)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "  راهنما  "
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(5, 22)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox2.Size = New System.Drawing.Size(363, 58)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.address)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(6, 171)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(374, 68)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "مرحله دوم :"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(328, 38)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 20)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "...."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(5, 39)
        Me.address.Margin = New System.Windows.Forms.Padding(2)
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Size = New System.Drawing.Size(320, 20)
        Me.address.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(197, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "فایل یا پوشه ی مورد نظر را انتخاب کنید"
        '
        'tbDrive
        '
        Me.tbDrive.Controls.Add(Me.GroupBox4)
        Me.tbDrive.Controls.Add(Me.GroupBox3)
        Me.tbDrive.Controls.Add(Me.GroupBox2)
        Me.tbDrive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbDrive.ImageIndex = 0
        Me.tbDrive.Location = New System.Drawing.Point(4, 31)
        Me.tbDrive.Name = "tbDrive"
        Me.tbDrive.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDrive.Size = New System.Drawing.Size(384, 335)
        Me.tbDrive.TabIndex = 0
        Me.tbDrive.Text = "::  محافظت از درایوهای سیستم ::"
        Me.tbDrive.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbDriveProcc)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(10, 98)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(370, 50)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "مرحله اول :"
        '
        'cmbDriveProcc
        '
        Me.cmbDriveProcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDriveProcc.FormattingEnabled = True
        Me.cmbDriveProcc.Items.AddRange(New Object() {"Write Protect کردن دیسک", "Writable کردن دیسک", "مخفی کردن درایو", "نمایش درایو"})
        Me.cmbDriveProcc.Location = New System.Drawing.Point(6, 18)
        Me.cmbDriveProcc.Name = "cmbDriveProcc"
        Me.cmbDriveProcc.Size = New System.Drawing.Size(228, 21)
        Me.cmbDriveProcc.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(253, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "نوع عملیات را تعیین کنید"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cmbDrives)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(10, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 57)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مرحله دوم :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(177, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 20)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbDrives
        '
        Me.cmbDrives.FormattingEnabled = True
        Me.cmbDrives.Location = New System.Drawing.Point(6, 18)
        Me.cmbDrives.Name = "cmbDrives"
        Me.cmbDrives.Size = New System.Drawing.Size(167, 21)
        Me.cmbDrives.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(238, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "درایو مورد نظر را انتخاب کنید"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 86)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  راهنما  "
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox11.Location = New System.Drawing.Point(6, 23)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox11.Size = New System.Drawing.Size(356, 58)
        Me.TextBox11.TabIndex = 0
        Me.TextBox11.Text = resources.GetString("TextBox11.Text")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "driveLock.png")
        Me.ImageList1.Images.SetKeyName(1, "fileLock.png")
        Me.ImageList1.Images.SetKeyName(2, "exit.png")
        Me.ImageList1.Images.SetKeyName(3, "accept.png")
        Me.ImageList1.Images.SetKeyName(4, "about.png")
        Me.ImageList1.Images.SetKeyName(5, "help.png")
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.ImageIndex = 2
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(17, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "خروج از برنامه"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStart.ImageIndex = 3
        Me.btnStart.ImageList = Me.ImageList1
        Me.btnStart.Location = New System.Drawing.Point(671, 383)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(105, 35)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "انجام عملیات"
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHelp.ImageIndex = 5
        Me.btnHelp.ImageList = Me.ImageList1
        Me.btnHelp.Location = New System.Drawing.Point(525, 383)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(125, 35)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "راهنمای برنامه"
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbout.ImageIndex = 4
        Me.btnAbout.ImageList = Me.ImageList1
        Me.btnAbout.Location = New System.Drawing.Point(386, 383)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(118, 35)
        Me.btnAbout.TabIndex = 11
        Me.btnAbout.Text = "درباره ما ..."
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(7, 14)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(359, 329)
        Me.lstResult.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.lstResult)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 370)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشاهده نتایج :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 345)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(358, 19)
        Me.ProgressBar1.TabIndex = 12
        '
        'frmNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 427)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ListBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNew"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار امنیت اطلاعات"
        Me.TabControl1.ResumeLayout(False)
        Me.tbFolder.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.tbDrive.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbFolder As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbDrive As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDriveProcc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbDrives As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
