Public Class ChatForm
    Dim isclosing As Boolean = True '프로그램 종료 액션 여부

    '채팅 폼 로딩
    Private Sub ChatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '이전폼 중앙으로 위치 설정
        Dim showx = MainForm.Location.X + MainForm.Size.Width / 2 - Me.Size.Width / 2
        Dim showy = MainForm.Location.Y + MainForm.Size.Height / 2 - Me.Size.Height / 2

        AlignCodeLabel()
        WebBrowser1.ScriptErrorsSuppressed = True '임베디드 브라우저 에러 msg 비활성화, 디버깅시 해제
        Me.Text = "inChat :: " + MainForm.chattitle '타이틀 설정
        Me.Opacity = My.Settings.opacity '투명값 설정 불러오기
        Me.TopMost = My.Settings.topmost '항상 위 설정 불러오기

        '현재 폼 위치 지정후 표시
        Me.SetDesktopLocation(showx, showy)
    End Sub

    'Form1으로 돌아가기
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isclosing = False '액션 취소
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub ChatForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If isclosing Then MainForm.Close()
    End Sub

    Private Sub Panel2_SizeChanged(sender As Object, e As EventArgs) Handles Panel2.SizeChanged
        AlignCodeLabel()
    End Sub

    '상단 채팅코드 표시 Label 중앙정렬
    Private Sub AlignCodeLabel()
        ChatCodeLabel.Location = New Point((Panel2.Width - ChatCodeLabel.Width) / 2, ChatCodeLabel.Location.Y)
    End Sub

    '설정 버튼 눌렀을 시 커서에 목록 뜨도록 설정
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ToolMenu.Show()
        ToolMenu.Location = Cursor.Position
    End Sub

    Private Sub Tools_Refresh_Click(sender As Object, e As EventArgs) Handles Tools_Refresh.Click
        WebBrowser1.Refresh() '새로 고침
    End Sub

    '항상 위 클릭시 설정값 지정
    Private Sub Tools_Topmost_Click(sender As Object, e As EventArgs) Handles Tools_Topmost.Click
        If Me.TopMost = False Then
            Me.TopMost = True
            Tools_Topmost.Checked = True
            My.Settings.topmost = True
        Else
            Me.TopMost = False
            Tools_Topmost.Checked = False
            My.Settings.topmost = False
        End If
    End Sub

    Private Sub ToolMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ToolMenu.Opening
        '도구 목록 열리기 전 준비

        If Me.TopMost = True Then
            Tools_Topmost.Checked = True
        Else
            Tools_Topmost.Checked = False
        End If

        opa_20.Checked = False
        opa_40.Checked = False
        opa_60.Checked = False
        opa_80.Checked = False
        opa_100.Checked = False

        '투명도 판별 후 체킹
        Select Case Me.Opacity
            Case 0.2
                opa_20.Checked = True

            Case 0.4
                opa_40.Checked = True

            Case 0.6
                opa_60.Checked = True

            Case 0.8
                opa_80.Checked = True

            Case 1
                opa_100.Checked = True

        End Select
    End Sub

    '투명도 선택
    Private Sub opa_20_Click(sender As Object, e As EventArgs) Handles opa_20.Click
        Me.Opacity = 0.2
        My.Settings.opacity = 0.2
    End Sub

    Private Sub opa_40_Click(sender As Object, e As EventArgs) Handles opa_40.Click
        Me.Opacity = 0.4
        My.Settings.opacity = 0.4
    End Sub

    Private Sub opa_60_Click(sender As Object, e As EventArgs) Handles opa_60.Click
        Me.Opacity = 0.6
        My.Settings.opacity = 0.6
    End Sub

    Private Sub opa_80_Click(sender As Object, e As EventArgs) Handles opa_80.Click
        Me.Opacity = 0.8
        My.Settings.opacity = 0.8
    End Sub

    Private Sub opa_100_Click(sender As Object, e As EventArgs) Handles opa_100.Click
        Me.Opacity = 1
        My.Settings.opacity = 1
    End Sub
End Class