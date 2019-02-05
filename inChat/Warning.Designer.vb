<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Warning))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DisableCheck = New System.Windows.Forms.CheckBox()
        Me.ConncetBT_code = New System.Windows.Forms.Button()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.Close_BT = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TopPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 246)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.DisableCheck)
        Me.Panel2.Controls.Add(Me.ConncetBT_code)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel2.Size = New System.Drawing.Size(339, 208)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.inChat.My.Resources.Resources.warn_txt
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 133)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'DisableCheck
        '
        Me.DisableCheck.AutoSize = True
        Me.DisableCheck.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.DisableCheck.Location = New System.Drawing.Point(229, 189)
        Me.DisableCheck.Name = "DisableCheck"
        Me.DisableCheck.Size = New System.Drawing.Size(100, 17)
        Me.DisableCheck.TabIndex = 10
        Me.DisableCheck.Text = "다시 보지 않기"
        Me.DisableCheck.UseVisualStyleBackColor = True
        '
        'ConncetBT_code
        '
        Me.ConncetBT_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConncetBT_code.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ConncetBT_code.Location = New System.Drawing.Point(18, 152)
        Me.ConncetBT_code.Name = "ConncetBT_code"
        Me.ConncetBT_code.Size = New System.Drawing.Size(303, 33)
        Me.ConncetBT_code.TabIndex = 9
        Me.ConncetBT_code.Text = "위 사항을 숙지하였습니다"
        Me.ConncetBT_code.UseVisualStyleBackColor = True
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.TitlePanel)
        Me.TopPanel.Controls.Add(Me.Close_BT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(339, 38)
        Me.TopPanel.TabIndex = 1
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.inChat.My.Resources.Resources.title_warn
        Me.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(301, 38)
        Me.TitlePanel.TabIndex = 2
        '
        'Close_BT
        '
        Me.Close_BT.BackgroundImage = Global.inChat.My.Resources.Resources.close
        Me.Close_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Close_BT.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_BT.Location = New System.Drawing.Point(301, 0)
        Me.Close_BT.Name = "Close_BT"
        Me.Close_BT.Size = New System.Drawing.Size(38, 38)
        Me.Close_BT.TabIndex = 1
        '
        'Warning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(341, 248)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Warning"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "inChat :: 경고"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents Close_BT As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DisableCheck As CheckBox
    Friend WithEvents ConncetBT_code As Button
End Class
