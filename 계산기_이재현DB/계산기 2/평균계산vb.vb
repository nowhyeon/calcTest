Public Class 평균계산vb
    Dim sum As Double = 0     '평균을위한 총합
    Dim num As Integer = 0    '체크된 갯수
    Dim avg As Double         '평균


    '점수등록
    Public Sub Input_pnc()
        Try
            chkBoxVal.Items.Add(CDbl(inputBox.Text)) '체크박스리스트에 추가
            inputBox.Text = ""                       '입력창 초기화 
        Catch ex As Exception
            MsgBox("숫자만 입력하세요")
            inputBox.Text = ""
        End Try
    End Sub

    '팝업
    Public Sub PopUp()
        If MsgBox("값을 계산기에 적용시키시겠습니까?", vbQuestion + vbYesNo, "확인창") = vbYes Then
            계산기.InputString = 계산기.InputString & ResultBox.Text
            계산기.ResultBox.Text = Math.Round(CDbl(ResultBox.Text), 0)     '계산기 폼 ResultBox에 값 집어넣기
            chkBoxVal.Items.Clear()                    '닫을때  hide 할거라 값 초기화
            Me.Hide()                                  '숨김
        Else
            chkBoxVal.Items.Clear()
            Me.Hide()
        End If
    End Sub

    '전체 체크
    Public Sub Allchk()
        If Allcheck.Checked = True Then             '전체 체크가 체크 되어있으면
            Dim i As Integer
            For i = 0 To chkBoxVal.Items.Count - 1
                chkBoxVal.SetItemChecked(i, True)   '항목 전체 체크 true
            Next
        ElseIf Allcheck.Checked = False Then
            Dim i As Integer
            For i = 0 To chkBoxVal.Items.Count - 1
                chkBoxVal.SetItemChecked(i, False)  '항목 전체 체크 false
            Next
        End If
    End Sub


    '다음버튼 누르면
    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        Call Input_pnc()    '체크박스 리스트에 추가
        Call Allchk()
    End Sub

    '엔터 esc 버튼
    Private Sub InputBox_keypress(sender As Object, e As KeyPressEventArgs) Handles inputBox.KeyPress
        If Asc(e.KeyChar) = 13 Then     '엔터누르면
            Call Input_pnc()            '체크박스 리스트에 추가
            Call Allchk()
        ElseIf Asc(e.KeyChar) = 27 Then 'Esc 누르면
            Call PopUp()                '닫으면 팝업창
        End If
    End Sub

    '삭제버튼
    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        Dim delNum As String = ""
        Dim i As Integer
        For i = chkBoxVal.Items.Count - 1 To 0 Step -1 '0부터 증가하면서 삭제하면 배열 길이가 바껴서 역순으로 돌림
            If chkBoxVal.GetItemChecked(i) = True Then
                chkBoxVal.Items.RemoveAt(i)
                'delNum = delNum & i & ","
            End If
        Next
    End Sub

    '평균버튼 눌렀을때
    Private Sub AvgBtn_click(sender As Object, e As EventArgs) Handles AvgBtn.Click
        sum = 0
        num = 0
        Dim i As Integer
        For i = 0 To chkBoxVal.Items.Count - 1
            If chkBoxVal.GetItemChecked(i) = True Then
                sum = sum + chkBoxVal.Items(i)
                num = num + 1
            End If
            ResultBox.Text = sum / num
        Next
    End Sub

    '전체선택 눌렀을때
    Private Sub All_Check(sender As Object, e As EventArgs) Handles Allcheck.CheckedChanged
        Call Allchk()
    End Sub

    '체크박스 항목 클릭했을때
    Private Sub chkBoxItem_click(sender As Object, e As ItemCheckEventArgs) Handles chkBoxVal.ItemCheck

    End Sub

    '폼 닫힐때
    Private Sub Avg_close(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Call PopUp()
    End Sub
End Class
