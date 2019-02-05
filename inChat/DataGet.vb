Module DataGet
    '데이터 가져오기 역할을 하는 코드 모음 모듈

    Public Function getSource(url As String) '소스(HTML) GET 명령어
        Try
            Dim clie As New System.Net.WebClient()
            clie.Encoding = System.Text.Encoding.UTF8 '한국어 깨짐 방지

            Dim sourceString As String = clie.DownloadString(url)
            Return sourceString

        Catch
            Return "{ERROR}"
        End Try
    End Function

End Module
