<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChatCodeLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.투명도조절ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.opa_20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opa_40 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opa_60 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opa_80 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opa_100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tools_Topmost = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tools_Refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 27)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChatCodeLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(96, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 27)
        Me.Panel2.TabIndex = 2
        '
        'ChatCodeLabel
        '
        Me.ChatCodeLabel.AutoSize = True
        Me.ChatCodeLabel.Location = New System.Drawing.Point(79, 6)
        Me.ChatCodeLabel.Name = "ChatCodeLabel"
        Me.ChatCodeLabel.Size = New System.Drawing.Size(97, 17)
        Me.ChatCodeLabel.TabIndex = 0
        Me.ChatCodeLabel.Text = "ChatCodeLabel"
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "설정..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(395, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "돌아가기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 27)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 23)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(491, 358)
        Me.WebBrowser1.TabIndex = 1
        '
        'ToolMenu
        '
        Me.ToolMenu.BackColor = System.Drawing.Color.White
        Me.ToolMenu.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ToolMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.투명도조절ToolStripMenuItem, Me.Tools_Topmost, Me.Tools_Refresh})
        Me.ToolMenu.Name = "ToolMenu"
        Me.ToolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolMenu.ShowCheckMargin = True
        Me.ToolMenu.ShowImageMargin = False
        Me.ToolMenu.Size = New System.Drawing.Size(159, 76)
        '
        '투명도조절ToolStripMenuItem
        '
        Me.투명도조절ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opa_20, Me.opa_40, Me.opa_60, Me.opa_80, Me.opa_100})
        Me.투명도조절ToolStripMenuItem.Name = "투명도조절ToolStripMenuItem"
        Me.투명도조절ToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.투명도조절ToolStripMenuItem.Text = "투명도 조절"
        '
        'opa_20
        '
        Me.opa_20.Name = "opa_20"
        Me.opa_20.Size = New System.Drawing.Size(152, 24)
        Me.opa_20.Text = "20%"
        '
        'opa_40
        '
        Me.opa_40.Name = "opa_40"
        Me.opa_40.Size = New System.Drawing.Size(152, 24)
        Me.opa_40.Text = "40%"
        '
        'opa_60
        '
        Me.opa_60.Name = "opa_60"
        Me.opa_60.Size = New System.Drawing.Size(152, 24)
        Me.opa_60.Text = "60%"
        '
        'opa_80
        '
        Me.opa_80.Name = "opa_80"
        Me.opa_80.Size = New System.Drawing.Size(152, 24)
        Me.opa_80.Text = "80%"
        '
        'opa_100
        '
        Me.opa_100.Checked = True
        Me.opa_100.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opa_100.Name = "opa_100"
        Me.opa_100.Size = New System.Drawing.Size(152, 24)
        Me.opa_100.Text = "불투명"
        '
        'Tools_Topmost
        '
        Me.Tools_Topmost.Name = "Tools_Topmost"
        Me.Tools_Topmost.Size = New System.Drawing.Size(158, 24)
        Me.Tools_Topmost.Text = "항상 위에"
        '
        'Tools_Refresh
        '
        Me.Tools_Refresh.Name = "Tools_Refresh"
        Me.Tools_Refresh.Size = New System.Drawing.Size(158, 24)
        Me.Tools_Refresh.Text = "새로 고침"
        '
        'ChatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(491, 385)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "ChatForm"
        Me.Text = "ChatForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ChatCodeLabel As Label
    Friend WithEvents ToolMenu As ContextMenuStrip
    Friend WithEvents 투명도조절ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents opa_20 As ToolStripMenuItem
    Friend WithEvents opa_40 As ToolStripMenuItem
    Friend WithEvents opa_60 As ToolStripMenuItem
    Friend WithEvents opa_80 As ToolStripMenuItem
    Friend WithEvents opa_100 As ToolStripMenuItem
    Friend WithEvents Tools_Topmost As ToolStripMenuItem
    Friend WithEvents Tools_Refresh As ToolStripMenuItem
End Class
