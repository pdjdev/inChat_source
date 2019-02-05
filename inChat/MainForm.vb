Imports System.Net

Public Class MainForm
    Dim CurrentMode As String = "main" '현재 모드
    Dim schooldb As String = Nothing '학교 이름 DB
    Public chatcode As String = Nothing '채팅 코드
    Public chattitle As String = Nothing '채팅 이름 (FormTitle)

    Dim schoolfinder_error As Boolean = False '학교이름DB 로드 오류 판별

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

#Region "TextBoxEditInBG"
    Delegate Sub SetTextBoxInvoker(ByVal TextBox As TextBox, ByVal Text As String)
    Sub SetTextBox(ByVal TextBox As TextBox, ByVal Text As String)
        Try
            If TextBox.InvokeRequired = True Then
                TextBox.Invoke(New SetTextBoxInvoker(AddressOf SetTextBox), TextBox, Text)
            Else
                TextBox.Text = Text
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region 'Background 프로세스에서 Textbox GUI에 접근 가능하게 하는 Sub

    Private Sub BT1_Click(sender As Object, e As EventArgs) Handles BT1.Click '학교별버튼
        CurrentMode = "school"
        ModeSetting()
        SchoolDBready()
    End Sub

    Private Sub BT2_Click(sender As Object, e As EventArgs) Handles BT2.Click '직접코드입력
        CurrentMode = "code"
        ModeSetting()
    End Sub

    Private Sub BT3_Click(sender As Object, e As EventArgs) Handles BT3.Click '가장최근
        If My.Settings.last_chattitle = Nothing Then
            MsgBox("최근 채팅 기록을 찾을 수 없습니다.", vbInformation)
        Else
            If MsgBox(My.Settings.last_chattitle + vbCr + "해당 채팅방으로 접속하시겠습니까?", vbYesNo + vbQuestion) = vbYes Then

                '최근 채팅값 불러오기
                chatcode = My.Settings.last_chatcode
                chattitle = My.Settings.last_chattitle

                OpenChat()

            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked '개발정보
        CurrentMode = "info"
        ModeSetting()
    End Sub

    Private Sub ModeSetting() '모드 선택, 초기화 SUB

        '우선 모든 Panel을 숨기고 하나만 표시하여 Panel 전환
        PN1.Visible = False
        PN2.Visible = False
        PN3.Visible = False
        PN4.Visible = False

        Select Case CurrentMode
            Case "main" '메인 화면
                PN1.Visible = True
                TitlePanel.BackgroundImage = My.Resources.title_main
                Close_BT.BackgroundImage = My.Resources.close


            Case "school" '학교별 채팅
                PN2.Visible = True
                TitlePanel.BackgroundImage = My.Resources.title_school
                Close_BT.BackgroundImage = My.Resources.back
                Check_SaveClass.Checked = My.Settings.saveclass


                If My.Settings.saveclass Then '설정 저장여부
                    'TextBox_School.Text = My.Settings.recent_school 저장된 학교는 학교DB탐색 후 마치는 부분에서 채우기
                    Textbox_School_Name.Text = My.Settings.recent_name
                    Numeric_class.Value = My.Settings.recent_class
                    Numeric_grade.Value = My.Settings.recent_grade
                Else
                    Textbox_School_Name.Text = Nothing
                    Numeric_class.Value = 1
                    Numeric_grade.Value = 1
                End If


            Case "code" '직접 코드 입력
                PN3.Visible = True
                TitlePanel.BackgroundImage = My.Resources.title_codeenter
                Close_BT.BackgroundImage = My.Resources.back
                Check_norecord.Checked = My.Settings.norecord
                Check_Savecode.Checked = My.Settings.savecode


                If My.Settings.savecode Then '설정 저장여부
                    TextBox_code_code.Text = My.Settings.recent_code
                    TextBox_code_nick.Text = My.Settings.recent_nick
                Else
                    TextBox_code_code.Text = Nothing
                    TextBox_code_nick.Text = Nothing
                End If


            Case "info" '개발 정보
                PN4.Visible = True
                TitlePanel.BackgroundImage = My.Resources.title_info
                Close_BT.BackgroundImage = My.Resources.back


        End Select

    End Sub

    Private Sub Close_BT_Click(sender As Object, e As EventArgs) Handles Close_BT.Click
        If CurrentMode = "main" Then '모드 판별후 이전 아이콘 / 닫기 아이콘 판단
            Me.Close()
        Else
            CurrentMode = "main"
            ModeSetting()
        End If
    End Sub

    Private Sub SchoolDBready() '학교이름 DB 로딩 준비 SUB
        TextBox_School.Enabled = False
        TextBox_School.TextAlign = HorizontalAlignment.Center
        SchoolFinder.RunWorkerAsync()
    End Sub

    Private Sub SchoolFinder_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SchoolFinder.DoWork
        SetTextBox(TextBox_School, "서버에 접속 중입니다")

        If My.Computer.Network.IsAvailable = False Then
            SetTextBox(TextBox_School, "인터넷에 연결되어 있지 않습니다")
            schoolfinder_error = True
            Threading.Thread.Sleep(1000) '1초간 정지하여 오류를 표시
        Else
            Try
                SetTextBox(TextBox_School, "학교 이름을 불러오는 중")
                schooldb = getSource("http://schooldb.inchat.kro.kr/")
            Catch ex As Exception
                SetTextBox(TextBox_School, "DB에 접근할 수 없습니다")
                schoolfinder_error = True
                Threading.Thread.Sleep(1000) '1초간 정지하여 오류를 표시
            End Try
        End If
    End Sub

    Private Sub SchoolFinder_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles SchoolFinder.RunWorkerCompleted
        If schoolfinder_error = False Then '오류가 안 났을때
            Dim a() = Split(schooldb, vbLf) 'db string 나누기, 자동완성 추가
            TextBox_School.AutoCompleteCustomSource.AddRange(a)
        End If

        '마무리
        TextBox_School.Enabled = True
        If My.Settings.saveclass Then
            TextBox_School.Text = My.Settings.recent_school
        Else
            TextBox_School.Text = Nothing
        End If

        TextBox_School.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        SchoolFinder.RunWorkerAsync()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        ModeSetting()
        Me.Hide()
    End Sub

    Private Sub ConncetBT_class_Click(sender As Object, e As EventArgs) Handles ConncetBT_class.Click '학급 채팅방 버튼 눌렀을 시
        If TextBox_School.Text = Nothing Then '학교명 유효성 체크
            MsgBox("학교명을 입력해 주십시오.", vbCritical)

        ElseIf Textbox_School_Name.Text = Nothing Then '이름 유효성 체크
            MsgBox("이름을 입력해 주십시오.", vbCritical)

        ElseIf (TextBox_School.Text & Textbox_School_Name.text).Contains("!") Then '충돌 유발 가능한 문자열 있는지 필터링
            MsgBox("학교명, 이름에는 느낌표가 들어갈 수 없습니다.", vbCritical)

        Else
            If My.Settings.saveclass Then '저장여부 확인뒤 저장처리
                My.Settings.recent_school = TextBox_School.Text
                My.Settings.recent_name = Textbox_School_Name.Text
                My.Settings.recent_grade = Numeric_grade.Value
                My.Settings.recent_class = Numeric_class.Value
            End If

            chatcode = "inchat-s-" + TextBox_School.Text + "gr" + Numeric_grade.Value.ToString _
                + "cl" + Numeric_class.Value.ToString + "&user=" + Textbox_School_Name.Text '코드생성
            chattitle = TextBox_School.Text + " " + Numeric_grade.Value.ToString _
                + "학년 " + Numeric_class.Value.ToString + "반"

            OpenChat() '채팅SUB 실행

        End If
    End Sub

    Private Sub ConncetBT_code_Click(sender As Object, e As EventArgs) Handles ConncetBT_code.Click '채팅코드입력 버튼 눌렀을 시
        If TextBox_code_nick.Text = Nothing Then '닉네임 유효성 체크
            MsgBox("닉네임을 입력해 주십시오.", vbCritical)

        ElseIf TextBox_code_code.Text = Nothing Then '코드 유효성 체크
            MsgBox("채팅 코드를 입력해 주십시오.", vbCritical)

        ElseIf (TextBox_code_nick.Text & TextBox_code_code.Text).Contains("!") Then '충돌 우려 문자 체크
            MsgBox("채팅 코드와 닉네임에는 느낌표가 들어갈 수 없습니다.", vbCritical)

        ElseIf TextBox_code_code.TextLength < 5 Then
            If MsgBox("코드의 길이가 너무 짧습니다." + vbCr _
                   + "(충돌의 위험이 있습니다)" + vbCr _
                   + vbCr + "그래도 계속하시겠습니까?", vbYesNo + vbExclamation) = vbYes Then '보안 위험성 경고 -> 예 대답시 강제실행
                GoTo dotask
            End If

        Else
dotask:
            If My.Settings.savecode Then '저장여부 확인뒤 저장처리
                My.Settings.recent_nick = TextBox_code_nick.Text
                My.Settings.recent_code = TextBox_code_code.Text
            End If

            '코드생성
            chatcode = "inchat-c-" + TextBox_code_code.Text
            If Check_norecord.Checked Then chatcode += "!" '방 코드 끝에 느낌표 넣을시 기록 안남음
            chatcode += "&user=" + TextBox_code_nick.Text


            chattitle = TextBox_code_code.Text
            OpenChat()
        End If
    End Sub

    Private Sub Check_SaveClass_CheckedChanged(sender As Object, e As EventArgs) Handles Check_SaveClass.CheckedChanged
        My.Settings.saveclass = Check_SaveClass.Checked '학급 저장 여부 저장
    End Sub

    Private Sub Check_Savecode_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Savecode.CheckedChanged
        My.Settings.savecode = Check_Savecode.Checked '코드 저장 여부 저장
    End Sub

    Private Sub Check_norecord_CheckedChanged(sender As Object, e As EventArgs) Handles Check_norecord.CheckedChanged
        My.Settings.norecord = Check_norecord.Checked '기록 여부 저장
    End Sub

    Private Sub OpenChat()
        Warning.Show()
    End Sub


    '//디버깅용(설정값 초기화)//

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("설정값을 초기화하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            My.Settings.Reset()
            My.Settings.Save()

            MsgBox("프로그램이 종료됩니다. 다시 실행해 주세요.", vbInformation)
            Me.Close()

        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        '다운로드 링크
        Process.Start("http://inchat.kro.kr")
    End Sub

    Dim clickcount = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        clickcount += 1
        If clickcount >= 5 Then
            Label6.Text = "인 . . . 챗"
        End If
    End Sub
End Class