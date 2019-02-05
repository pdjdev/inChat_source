Module GUIeffect

    Public Sub FadeIn(Form As Form)
        Form.Opacity = 0
_return:
        If Not Form.Opacity = 1 Then
            Form.Opacity = Form.Opacity + 0.1
            Form.Invalidate()
            Threading.Thread.Sleep(10)
            GoTo _return
        End If
    End Sub

    Public Sub FadeOut(Form As Form)
_return:
        If Not Form.Opacity = 0 Then
            Form.Opacity = Form.Opacity - 0.1
            Form.Invalidate()
            Threading.Thread.Sleep(10)
            GoTo _return
        End If
    End Sub
End Module
