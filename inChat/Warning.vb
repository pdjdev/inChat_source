Public Class Warning

#Region "GUIFX"
    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Dim OSVer As Version = System.Environment.OSVersion.Version()
            Select Case OSVer.Major
                Case Is < 5
                Case 5
                    If OSVer.Minor > 0 Then
                        cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                    End If
                Case Is > 5
                    cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
                Case Else
            End Select
            Return cp

        End Get
    End Property

    Private Sub FadeOnEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        FadeIn(Me)
    End Sub

    Private Sub FadeOffeffect(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FadeOut(Me)
    End Sub
#End Region '그림자 생성, 페이드 효과 코드

#Region "WindowDragging"
    Dim loc As Point

    Private Sub TitlePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub TitlePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub
#End Region 'GUI 드래그 코드

    Private Sub Warning_Load(sender As Object, e As EventArgs) Handles MyBase.Load '가운데에 경고문 뜨게 설정
        Me.Opacity = 0
        Me.Hide() '일단 Warning 무시 판별 후 Form Show하기 위해 숨김
        Dim showx = MainForm.Location.X + MainForm.Size.Width / 2 - Me.Size.Width / 2
        Dim showy = MainForm.Location.Y + MainForm.Size.Height / 2 - Me.Size.Height / 2
        Me.SetDesktopLocation(showx, showy)

        If My.Settings.warnshow = False Then
            OpenChat()
        End If
    End Sub

    Private Sub Close_BT_Click(sender As Object, e As EventArgs) Handles Close_BT.Click
        Me.Close()
    End Sub

    Private Sub ConncetBT_code_Click(sender As Object, e As EventArgs) Handles ConncetBT_code.Click
        If DisableCheck.Checked Then My.Settings.warnshow = False
        OpenChat()
    End Sub

    Private Sub OpenChat() '채팅창 실행
        '나중에 MainForm의 가장 최근 채팅 불러오기 기능 구현을 위해 경고문 확인후 값 저장
        My.Settings.last_chatcode = MainForm.chatcode
        My.Settings.last_chattitle = MainForm.chattitle

        ChatForm.WebBrowser1.Navigate("http://www.gagalive.kr/livechat1.swf?chatroom=inchat-" _
                      + MainForm.chatcode _
                      + "&fonttype=맑은 고딕&fontlarge=true")
        ChatForm.ChatCodeLabel.Text = MainForm.chattitle
        MainForm.Hide()
        ChatForm.Show()
        Me.Close()
    End Sub
End Class