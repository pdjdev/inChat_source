<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FormPanel = New System.Windows.Forms.Panel()
        Me.PN1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT2 = New System.Windows.Forms.Panel()
        Me.BT3 = New System.Windows.Forms.Panel()
        Me.BT1 = New System.Windows.Forms.Panel()
        Me.PN4 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PN3 = New System.Windows.Forms.Panel()
        Me.Check_norecord = New System.Windows.Forms.CheckBox()
        Me.Check_Savecode = New System.Windows.Forms.CheckBox()
        Me.ConncetBT_code = New System.Windows.Forms.Button()
        Me.TextBox_code_nick = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_code_code = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PN2 = New System.Windows.Forms.Panel()
        Me.Textbox_School_Name = New System.Windows.Forms.TextBox()
        Me.ConncetBT_class = New System.Windows.Forms.Button()
        Me.Check_SaveClass = New System.Windows.Forms.CheckBox()
        Me.Numeric_class = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Numeric_grade = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_School = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.Close_BT = New System.Windows.Forms.Panel()
        Me.SchoolFinder = New System.ComponentModel.BackgroundWorker()
        Me.FormPanel.SuspendLayout()
        Me.PN1.SuspendLayout()
        Me.PN4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PN3.SuspendLayout()
        Me.PN2.SuspendLayout()
        CType(Me.Numeric_class, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numeric_grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White
        Me.FormPanel.Controls.Add(Me.PN4)
        Me.FormPanel.Controls.Add(Me.PN1)
        Me.FormPanel.Controls.Add(Me.PN3)
        Me.FormPanel.Controls.Add(Me.PN2)
        Me.FormPanel.Controls.Add(Me.TopPanel)
        Me.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormPanel.Location = New System.Drawing.Point(1, 1)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(422, 249)
        Me.FormPanel.TabIndex = 0
        '
        'PN1
        '
        Me.PN1.Controls.Add(Me.LinkLabel1)
        Me.PN1.Controls.Add(Me.Label1)
        Me.PN1.Controls.Add(Me.BT2)
        Me.PN1.Controls.Add(Me.BT3)
        Me.PN1.Controls.Add(Me.BT1)
        Me.PN1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN1.Location = New System.Drawing.Point(0, 38)
        Me.PN1.Margin = New System.Windows.Forms.Padding(0)
        Me.PN1.Name = "PN1"
        Me.PN1.Padding = New System.Windows.Forms.Padding(15)
        Me.PN1.Size = New System.Drawing.Size(422, 211)
        Me.PN1.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(362, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(42, 21)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "정보"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "채팅 타입을 선택해 주세요"
        '
        'BT2
        '
        Me.BT2.BackColor = System.Drawing.Color.Transparent
        Me.BT2.BackgroundImage = Global.inChat.My.Resources.Resources.BT2
        Me.BT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT2.Location = New System.Drawing.Point(176, 45)
        Me.BT2.Margin = New System.Windows.Forms.Padding(5)
        Me.BT2.Name = "BT2"
        Me.BT2.Size = New System.Drawing.Size(226, 68)
        Me.BT2.TabIndex = 2
        '
        'BT3
        '
        Me.BT3.BackColor = System.Drawing.Color.Transparent
        Me.BT3.BackgroundImage = Global.inChat.My.Resources.Resources.BT3
        Me.BT3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT3.Location = New System.Drawing.Point(176, 123)
        Me.BT3.Margin = New System.Windows.Forms.Padding(5)
        Me.BT3.Name = "BT3"
        Me.BT3.Size = New System.Drawing.Size(226, 68)
        Me.BT3.TabIndex = 1
        '
        'BT1
        '
        Me.BT1.BackColor = System.Drawing.Color.Transparent
        Me.BT1.BackgroundImage = Global.inChat.My.Resources.Resources.BT1
        Me.BT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT1.Location = New System.Drawing.Point(20, 45)
        Me.BT1.Margin = New System.Windows.Forms.Padding(5)
        Me.BT1.Name = "BT1"
        Me.BT1.Size = New System.Drawing.Size(146, 146)
        Me.BT1.TabIndex = 0
        '
        'PN4
        '
        Me.PN4.Controls.Add(Me.LinkLabel2)
        Me.PN4.Controls.Add(Me.Label8)
        Me.PN4.Controls.Add(Me.Button1)
        Me.PN4.Controls.Add(Me.RichTextBox1)
        Me.PN4.Controls.Add(Me.Label6)
        Me.PN4.Controls.Add(Me.PictureBox1)
        Me.PN4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN4.Location = New System.Drawing.Point(0, 38)
        Me.PN4.Name = "PN4"
        Me.PN4.Size = New System.Drawing.Size(422, 211)
        Me.PN4.TabIndex = 4
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(317, 15)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(87, 15)
        Me.LinkLabel2.TabIndex = 19
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "최신 버전 받기"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.Location = New System.Drawing.Point(339, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 26)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "0.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "공개용 빌드"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 44)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "설정값 초기화" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(디버깅용)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(157, 72)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(247, 121)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.Location = New System.Drawing.Point(149, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 47)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "inChat Beta"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.inChat.My.Resources.Resources.icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PN3
        '
        Me.PN3.Controls.Add(Me.Check_norecord)
        Me.PN3.Controls.Add(Me.Check_Savecode)
        Me.PN3.Controls.Add(Me.ConncetBT_code)
        Me.PN3.Controls.Add(Me.TextBox_code_nick)
        Me.PN3.Controls.Add(Me.Label3)
        Me.PN3.Controls.Add(Me.TextBox_code_code)
        Me.PN3.Controls.Add(Me.Label2)
        Me.PN3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN3.Location = New System.Drawing.Point(0, 38)
        Me.PN3.Name = "PN3"
        Me.PN3.Padding = New System.Windows.Forms.Padding(40)
        Me.PN3.Size = New System.Drawing.Size(422, 211)
        Me.PN3.TabIndex = 3
        '
        'Check_norecord
        '
        Me.Check_norecord.AutoSize = True
        Me.Check_norecord.Location = New System.Drawing.Point(222, 163)
        Me.Check_norecord.Name = "Check_norecord"
        Me.Check_norecord.Size = New System.Drawing.Size(162, 19)
        Me.Check_norecord.TabIndex = 5
        Me.Check_norecord.Text = "채팅 완료 후 기록 지우기"
        Me.Check_norecord.UseVisualStyleBackColor = True
        '
        'Check_Savecode
        '
        Me.Check_Savecode.AutoSize = True
        Me.Check_Savecode.Location = New System.Drawing.Point(294, 19)
        Me.Check_Savecode.Name = "Check_Savecode"
        Me.Check_Savecode.Size = New System.Drawing.Size(90, 19)
        Me.Check_Savecode.TabIndex = 4
        Me.Check_Savecode.Text = "값 저장하기"
        Me.Check_Savecode.UseVisualStyleBackColor = True
        '
        'ConncetBT_code
        '
        Me.ConncetBT_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConncetBT_code.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ConncetBT_code.Location = New System.Drawing.Point(38, 126)
        Me.ConncetBT_code.Name = "ConncetBT_code"
        Me.ConncetBT_code.Size = New System.Drawing.Size(341, 33)
        Me.ConncetBT_code.TabIndex = 3
        Me.ConncetBT_code.Text = "접속하기"
        Me.ConncetBT_code.UseVisualStyleBackColor = True
        '
        'TextBox_code_nick
        '
        Me.TextBox_code_nick.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox_code_nick.Location = New System.Drawing.Point(134, 43)
        Me.TextBox_code_nick.Name = "TextBox_code_nick"
        Me.TextBox_code_nick.Size = New System.Drawing.Size(245, 33)
        Me.TextBox_code_nick.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "닉네임"
        '
        'TextBox_code_code
        '
        Me.TextBox_code_code.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox_code_code.Location = New System.Drawing.Point(134, 82)
        Me.TextBox_code_code.Name = "TextBox_code_code"
        Me.TextBox_code_code.Size = New System.Drawing.Size(245, 33)
        Me.TextBox_code_code.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "채팅 코드"
        '
        'PN2
        '
        Me.PN2.Controls.Add(Me.Textbox_School_Name)
        Me.PN2.Controls.Add(Me.ConncetBT_class)
        Me.PN2.Controls.Add(Me.Check_SaveClass)
        Me.PN2.Controls.Add(Me.Numeric_class)
        Me.PN2.Controls.Add(Me.Label7)
        Me.PN2.Controls.Add(Me.Numeric_grade)
        Me.PN2.Controls.Add(Me.Label5)
        Me.PN2.Controls.Add(Me.TextBox_School)
        Me.PN2.Controls.Add(Me.Label4)
        Me.PN2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN2.Location = New System.Drawing.Point(0, 38)
        Me.PN2.Name = "PN2"
        Me.PN2.Padding = New System.Windows.Forms.Padding(40)
        Me.PN2.Size = New System.Drawing.Size(422, 211)
        Me.PN2.TabIndex = 2
        '
        'Textbox_School_Name
        '
        Me.Textbox_School_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Textbox_School_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Textbox_School_Name.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Textbox_School_Name.Location = New System.Drawing.Point(281, 85)
        Me.Textbox_School_Name.Name = "Textbox_School_Name"
        Me.Textbox_School_Name.Size = New System.Drawing.Size(98, 33)
        Me.Textbox_School_Name.TabIndex = 4
        '
        'ConncetBT_class
        '
        Me.ConncetBT_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConncetBT_class.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ConncetBT_class.Location = New System.Drawing.Point(43, 149)
        Me.ConncetBT_class.Name = "ConncetBT_class"
        Me.ConncetBT_class.Size = New System.Drawing.Size(336, 33)
        Me.ConncetBT_class.TabIndex = 6
        Me.ConncetBT_class.Text = "접속하기"
        Me.ConncetBT_class.UseVisualStyleBackColor = True
        '
        'Check_SaveClass
        '
        Me.Check_SaveClass.AutoSize = True
        Me.Check_SaveClass.Location = New System.Drawing.Point(254, 126)
        Me.Check_SaveClass.Name = "Check_SaveClass"
        Me.Check_SaveClass.Size = New System.Drawing.Size(130, 19)
        Me.Check_SaveClass.TabIndex = 5
        Me.Check_SaveClass.Text = "마지막 값 저장하기"
        Me.Check_SaveClass.UseVisualStyleBackColor = True
        '
        'Numeric_class
        '
        Me.Numeric_class.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Numeric_class.Location = New System.Drawing.Point(143, 86)
        Me.Numeric_class.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.Numeric_class.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Numeric_class.Name = "Numeric_class"
        Me.Numeric_class.Size = New System.Drawing.Size(55, 33)
        Me.Numeric_class.TabIndex = 3
        Me.Numeric_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Numeric_class.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.Location = New System.Drawing.Point(202, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "반 이름"
        '
        'Numeric_grade
        '
        Me.Numeric_grade.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Numeric_grade.Location = New System.Drawing.Point(43, 86)
        Me.Numeric_grade.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.Numeric_grade.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Numeric_grade.Name = "Numeric_grade"
        Me.Numeric_grade.Size = New System.Drawing.Size(48, 33)
        Me.Numeric_grade.TabIndex = 2
        Me.Numeric_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Numeric_grade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "학년"
        '
        'TextBox_School
        '
        Me.TextBox_School.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox_School.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox_School.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox_School.Location = New System.Drawing.Point(111, 41)
        Me.TextBox_School.Name = "TextBox_School"
        Me.TextBox_School.Size = New System.Drawing.Size(268, 33)
        Me.TextBox_School.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "학교명"
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.TitlePanel)
        Me.TopPanel.Controls.Add(Me.Close_BT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(422, 38)
        Me.TopPanel.TabIndex = 0
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.inChat.My.Resources.Resources.title_main
        Me.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(384, 38)
        Me.TitlePanel.TabIndex = 2
        '
        'Close_BT
        '
        Me.Close_BT.BackgroundImage = Global.inChat.My.Resources.Resources.close
        Me.Close_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Close_BT.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_BT.Location = New System.Drawing.Point(384, 0)
        Me.Close_BT.Name = "Close_BT"
        Me.Close_BT.Size = New System.Drawing.Size(38, 38)
        Me.Close_BT.TabIndex = 1
        '
        'SchoolFinder
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(424, 251)
        Me.Controls.Add(Me.FormPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inChat"
        Me.FormPanel.ResumeLayout(False)
        Me.PN1.ResumeLayout(False)
        Me.PN1.PerformLayout()
        Me.PN4.ResumeLayout(False)
        Me.PN4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PN3.ResumeLayout(False)
        Me.PN3.PerformLayout()
        Me.PN2.ResumeLayout(False)
        Me.PN2.PerformLayout()
        CType(Me.Numeric_class, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numeric_grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormPanel As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents PN1 As Panel
    Friend WithEvents Close_BT As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BT2 As Panel
    Friend WithEvents BT3 As Panel
    Friend WithEvents BT1 As Panel
    Friend WithEvents PN2 As Panel
    Friend WithEvents PN3 As Panel
    Friend WithEvents TitlePanel As Panel
    Private WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PN4 As Panel
    Friend WithEvents ConncetBT_code As Button
    Friend WithEvents TextBox_code_nick As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_code_code As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Check_Savecode As CheckBox
    Friend WithEvents ConncetBT_class As Button
    Friend WithEvents Check_SaveClass As CheckBox
    Friend WithEvents Numeric_class As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Numeric_grade As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_School As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Check_norecord As CheckBox
    Friend WithEvents SchoolFinder As System.ComponentModel.BackgroundWorker
    Friend WithEvents Textbox_School_Name As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
