Imports System.Data.SqlClient
Imports System.Data

Public Class 계산기
    Dim total As Double       '최종보여질값
    Dim save As Double        '첫번째 값 저장
    Dim Col As Integer        '무슨숫자에 색깔을 줄지 저장하는 변수
    Public Shared f As 계산기 '다른폼에 현재 폼 쓸 수 있게

    Public Structure Calculator
        Dim numberArr As ArrayList
        Dim signStack As Stack
    End Structure

    Dim bkCalulators As New ArrayList
    Dim InputStringArr As New ArrayList
    Public InputString As String = ""

    'sql
    Private myConn As SqlConnection = New SqlConnection("Initial Catalog=calcTest;" & "Data Source=127.0.0.1;Integrated Security=SSPI;")     'db 연결
    Private myCmd As SqlCommand         'db query문 실행
    Private myReader As SqlDataReader   'db query결과 검색

    Private Sub 계산기_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect '행선택여부 (selected)속성을 사용하려면 작성해야함
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

        'TODO: 이 코드는 데이터를 'CalcTestDataSet.Test' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        Me.TestTableAdapter.Fill(Me.CalcTestDataSet.Test)
        Dim calculatorInstance As New Calculator With {
        .numberArr = New ArrayList,
        .signStack = New Stack
        }
        bkCalulators.Add(calculatorInstance)
        ResultBox.Text = InputString

        LoadData()
    End Sub

    Private Sub LoadData()
        Dim command As New SqlCommand("select row_number() over(order by test_no) as no,test_input,test_val,test_date,test_no from test", myConn) 'select row_number() over(order by test_no) as no,test_input,test_val from test
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    '버튼 누를때
    Private Sub setLabelWindowIS(v As String)
        '입력 조건

        '최대 길이 제한
        If InputString.Length < 29 * 2 Then
            If InputString.Length = 0 And Not IsNumeric(v) Then '첫 입력 기호가 오면
                If v = "(" Then
                    InputString = InputString & v
                ElseIf v = "." Then
                    '텍스트중 ”.”이 없을시 텍스트에 ”.” 추가
                    If InStr(1, ResultBox.Text, ”.”, vbTextCompare) = 0 Then
                        InputString = "0.”
                    End If
                Else
                    Return
                End If

            ElseIf InputString.Length > 0 And Not IsNumeric(v) Then '첫 입력이 아님
                '첫 입력이 아닐때 기호가 오면
                If Not v = "(" And Not v = ")" And Not InputString.Last = "(" And Not InputString.Last = ")" And Not IsNumeric(InputString.Last) Then '괄호만 있지않을때,마지막 입력이 괄호가 아닐대
                    Dim tmp As String = ""
                    Dim i As Integer

                    '기호뒤에 기호가오면 맨끝 기호 대신 새로운 기호를 넣음
                    For i = 0 To InputString.Length - 2 Step 1
                        tmp = tmp & (InputString(i))
                    Next i

                    '기호 추가 전 입력된 문자열에 새로 입력된 기호 추가
                    InputString = tmp & v
                ElseIf v = "." Then
                    '텍스트중 ”.”이 없을시 텍스트에 ”.” 추가
                    If InStr(1, ResultBox.Text, ”.”, vbTextCompare) = 0 Then
                        InputString = InputString & v
                    End If
                Else
                    '그냥 기호 입력
                    InputString = InputString & v
                End If
            Else
                '문제 없으면 문자열 뒤에 추가
                InputString = InputString & v
            End If
            Label1.Text = InputString
            ResultBox.Text = InputString
        Else
            MsgBox("최대 58개만 입력할 수 있습니다. " + vbCrLf + "더이상 입력할 수 없습니다.", 0, "경고")
        End If
    End Sub

    '후위 표기법 변환
    Private Sub setNumberArrFromStack(numberArr As ArrayList, signStack As Stack)
        Dim i As Integer
        For i = 0 To signStack.Count - 1 Step 1
            numberArr.Add(signStack.Pop) '마지막 idx를 꺼냄
        Next i
    End Sub

    '색깔 지우는 함수
    Private Sub Color_remove()
        cmdBtn0.BackColor = Color.White
        cmdBtn1.BackColor = Color.White
        cmdBtn2.BackColor = Color.White
        cmdBtn3.BackColor = Color.White
        cmdBtn4.BackColor = Color.White
        cmdBtn5.BackColor = Color.White
        cmdBtn6.BackColor = Color.White
        cmdBtn7.BackColor = Color.White
        cmdBtn8.BackColor = Color.White
        cmdBtn9.BackColor = Color.White
    End Sub

    '색깔 변화시키는 함수
    Private Sub Color_set(setColor As Integer)
        '색깔 초기화
        Call Color_remove()

        '색깔 설정 
        Col = setColor
        Select Case Col
            Case 0
                cmdBtn0.BackColor = Color.Red
            Case 1
                cmdBtn1.BackColor = Color.Red
            Case 2
                cmdBtn2.BackColor = Color.Red
            Case 3
                cmdBtn3.BackColor = Color.Red
            Case 4
                cmdBtn4.BackColor = Color.Red
            Case 5
                cmdBtn5.BackColor = Color.Red
            Case 6
                cmdBtn6.BackColor = Color.Red
            Case 7
                cmdBtn7.BackColor = Color.Red
            Case 8
                cmdBtn8.BackColor = Color.Red
            Case 9
                cmdBtn9.BackColor = Color.Red
        End Select
    End Sub

    '=
    Public Sub eql()
        '일단 기본적인것만 우선 오류제어
        If InputString = "" Then
            Return
        ElseIf Not IsNumeric(InputString(InputString.Length - 1)) Then '마지막 문자가 기호면 리턴
            Select Case InputString(InputString.Length - 1)
                Case "+"
                    Return
                Case "-"
                    Return
                Case "×"
                    Return
                Case "÷"
                    Return
            End Select
        End If

        '입력된 식 분리하기
        setInputStringArr() ' inputString "1+2+3X4/2" -> inputStringArr {1,+,2,+,3,x,4,/,2} 로

        '원본 계산식 저장 생성
        Dim openBracket As Integer = 0

        '후위 표기법 변환
        Dim i As Integer
        For i = 0 To InputStringArr.Count - 1 Step 1  'inputStringArr {1,+,2,+,3,x,4,/,2}
            If IsNumeric(InputStringArr(i)) Then
                ' 숫자면 그냥 넣음
                bkCalulators(openBracket).numberArr.Add(InputStringArr(i))  '숫자Arr에 넣기 

            Else
                '기호면 몇개 체크해야함
                If InputStringArr(i) = "(" Then
                    '괄호가 열리면 
                    openBracket += 1
                    Dim calculatorInstance As New Calculator With {
                        .numberArr = New ArrayList,
                        .signStack = New Stack
                    }
                    bkCalulators.Add(calculatorInstance)

                ElseIf InputStringArr(i) = ")" Then
                    '괄호가 닫히면 삭제
                    setNumberArrFromStack(bkCalulators(openBracket).numberArr, bkCalulators(openBracket).signStack)
                    '이전 배열로 다 추가
                    Dim u As Integer
                    For u = 0 To bkCalulators(openBracket).numberArr.Count - 1 Step 1
                        bkCalulators(openBracket - 1).numberArr.Add(bkCalulators(openBracket).numberArr(u))
                    Next u
                    bkCalulators.RemoveAt(openBracket)
                    openBracket -= 1

                ElseIf bkCalulators(openBracket).signStack.Count = 0 And (InputStringArr(i) = "+" Or InputStringArr(i) = "-") Then
                    '스택의 처음 +-이런건 그냥 넣음
                    bkCalulators(openBracket).signStack.Push(InputStringArr(i))
                ElseIf InputStringArr(i) = "+" Or InputStringArr(i) = "-" Then
                    '그다음 +-는 스택이랑 교환
                    setNumberArrFromStack(bkCalulators(openBracket).numberArr, bkCalulators(openBracket).signStack)
                    bkCalulators(openBracket).signStack.Clear()
                    bkCalulators(openBracket).signStack.Push(InputStringArr(i))
                ElseIf InputStringArr(i) = "×" Or InputStringArr(i) = "÷" Then
                    '*/는 스택에 넣음
                    bkCalulators(openBracket).signStack.Push(InputStringArr(i))
                End If
            End If
        Next i

        '마지막 스택에 있는거 다넣음
        setNumberArrFromStack(bkCalulators(openBracket).numberArr, bkCalulators(openBracket).signStack) ' 결과  ===>  bkCalulators(openBracket).numberArr = {1,2,+3,4,2,/,x,+}

        '후위연산 출력
        Dim tmp As String = ""
        For i = 0 To bkCalulators(openBracket).numberArr.Count - 1 Step 1
            tmp = tmp & bkCalulators(openBracket).numberArr(i)  ' bkCalulators(openBracket).numberArr = {1,2,+3,4,2,/,x,+}
        Next

        '실제 계산
        '늦은바인딩에러떠서 배열을 새로만들어야함
        Dim result As New ArrayList
        result = setResultNumberArr(bkCalulators(openBracket).numberArr) 'bkCalulators(openBracket).numberArr = {1,2,+3,4,2,/,x,+}
        ResultBox.Text = CStr(result(0))

        'sql
        'myConn = New SqlConnection("Initial Catalog=calcTest;" & "Data Source=127.0.0.1;Integrated Security=SSPI;") '연결설정
        Dim testInput As String = ""

        For i = 0 To InputStringArr.Count - 1
            testInput = testInput & InputStringArr(i)
        Next

        '실행할 쿼리문 설정
        myCmd = New SqlCommand("insert into Test (test_no,test_input,test_val,test_date) 
                                values(next value for Test_seq,'" & testInput & "','" & result(0) & "',getdate())", myConn)

        '연결 
        myConn.Open()

        '커맨드 실행(읽기)
        myCmd.ExecuteNonQuery()
        MsgBox("입력완료")

        LoadData()

        '연결닫기
        myConn.Close()

        bkCalulators(openBracket).numberArr.Clear()
        bkCalulators(openBracket).signStack.Clear()
        result.Clear()
        InputStringArr.Clear()
        InputString = ""
        '색깔 초기화
        Call Color_remove()

    End Sub

    'c
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        '계산 중이던 내용 다 초기화
        InputStringArr.Clear()
        Label1.Text = ""
        InputString = ""
        ResultBox.Text = InputString
        Call Color_remove()
    End Sub
    '.
    Private Sub PointBtn_Click(sender As Object, e As EventArgs) Handles pointBtn.Click
        setLabelWindowIS(".")
        '텍스트중 ”.”이 없을시 텍스트에 ”.” 추가
        'If InStr(1, ResultBox.Text, ”.”, vbTextCompare) = 0 Then
        'ResultBox.Text = ResultBox.Text & ”.”
        'End If
    End Sub

    '지우기
    Private Sub EraseBtn_Click(sender As Object, e As EventArgs) Handles eraseBtn.Click
        If InputString.Length > 0 Then
            InputString = InputString.Remove(InputString.Length - 1)
            Label1.Text = InputString
            ResultBox.Text = InputString
        Else
            ResultBox.Text = InputString
        End If
    End Sub

    '=
    Private Sub EqualBtn_Click(sender As Object, e As EventArgs) Handles equalBtn.Click
        eql()
    End Sub

    '연산
    Private Function setResultNumberArr(numberArr As ArrayList) As ArrayList
        ' 'bkCalulators(openBracket).numberArr = {1,2,+3,4,2,/,x,+} 계산해서 배열 반환
        Dim tmp As Integer = 0
        Dim i As Integer = 0

        While Not numberArr.Count = 1
            If Not IsNumeric(numberArr(i)) Then

                Select Case numberArr(i)
                    Case "+"
                        tmp = CDbl(numberArr(i - 2)) + CDbl(numberArr(i - 1))
                    Case "-"
                        tmp = CDbl(numberArr(i - 2)) - CDbl(numberArr(i - 1))
                    Case "×"
                        tmp = CDbl(numberArr(i - 2)) * CDbl(numberArr(i - 1))
                    Case "÷"
                        tmp = CDbl(numberArr(i - 2)) \ CDbl(numberArr(i - 1))
                End Select

                numberArr(i - 2) = tmp
                numberArr.RemoveAt(i)
                numberArr.RemoveAt(i - 1)

                numberArr = setResultNumberArr(numberArr)
            End If

            i += 1
        End While
        Return numberArr
    End Function

    'inputString 을 inputStringArr 로 분리
    Private Sub setInputStringArr()
        '분리하기
        Dim tmp As String = ""
        Dim i As Integer
        For i = 0 To InputString.Length - 1 Step 1
            If Not IsNumeric(InputString(i)) Then '기호면
                InputStringArr.Add(tmp)
                tmp = ""
                InputStringArr.Add(InputString(i))
            Else '숫자면
                tmp = tmp & InputString(i)
            End If
        Next i
        InputStringArr.Add(tmp)
    End Sub

    '연산자 및 지우기
    '+
    Private Sub PlusBtn_Click(sender As Object, e As EventArgs) Handles plusBtn.Click
        setLabelWindowIS("+")
    End Sub
    '-
    Private Sub MinusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        setLabelWindowIS("-")
    End Sub
    '*
    Private Sub MultiplyBtn_Click(sender As Object, e As EventArgs) Handles multiplyBtn.Click
        setLabelWindowIS("×")
    End Sub
    '/
    Private Sub DivideBtn_Click(sender As Object, e As EventArgs) Handles divideBtn.Click
        setLabelWindowIS("÷")
    End Sub
    '(
    Private Sub LeftBtn_click(sender As Object, e As EventArgs) Handles leftBtn.Click
        setLabelWindowIS("(")
    End Sub
    ')
    Private Sub RightBtn_click(sender As Object, e As EventArgs) Handles rightBtn.Click
        setLabelWindowIS(")")
    End Sub


    '숫자입력
    '1
    Private Sub CmdBtn1_Click(sender As Object, e As EventArgs) Handles cmdBtn1.Click
        setLabelWindowIS("1")
        Call Color_set(cmdBtn1.Text)
    End Sub
    '2
    Private Sub CmdBtn2_Click(sender As Object, e As EventArgs) Handles cmdBtn2.Click
        setLabelWindowIS("2")
        Call Color_set(cmdBtn2.Text)
    End Sub
    '3
    Private Sub CmdBtn3_Click(sender As Object, e As EventArgs) Handles cmdBtn3.Click
        setLabelWindowIS("3")
        Call Color_set(cmdBtn3.Text)
    End Sub
    '4
    Private Sub CmdBtn4_Click(sender As Object, e As EventArgs) Handles cmdBtn4.Click
        setLabelWindowIS("4")
        Call Color_set(cmdBtn4.Text)
    End Sub
    '5
    Private Sub CmdBtn5_Click(sender As Object, e As EventArgs) Handles cmdBtn5.Click
        setLabelWindowIS("5")
        Call Color_set(cmdBtn5.Text)
    End Sub
    '6
    Private Sub CmdBtn6_Click(sender As Object, e As EventArgs) Handles cmdBtn6.Click
        setLabelWindowIS("6")
        Call Color_set(cmdBtn6.Text)
    End Sub
    '7
    Private Sub CmdBtn7_Click(sender As Object, e As EventArgs) Handles cmdBtn7.Click
        setLabelWindowIS("7")
        Call Color_set(cmdBtn7.Text)
    End Sub
    '8
    Private Sub CmdBtn8_Click(sender As Object, e As EventArgs) Handles cmdBtn8.Click
        setLabelWindowIS("8")
        Call Color_set(cmdBtn8.Text)
    End Sub
    '9
    Private Sub CmdBtn9_Click(sender As Object, e As EventArgs) Handles cmdBtn9.Click
        setLabelWindowIS("9")
        Call Color_set(cmdBtn9.Text)
    End Sub
    '0
    Private Sub CmdBtn0_Click(sender As Object, e As EventArgs) Handles cmdBtn0.Click
        setLabelWindowIS("0")
        Call Color_set(cmdBtn0.Text)
    End Sub
    '======================================================================================================================================


    '숫자화면
    Private Sub ResultBox_TextChanged(sender As Object, e As EventArgs) Handles ResultBox.TextChanged

    End Sub

    '평균 폼 열기
    Private Sub AvgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvgToolStripMenuItem.Click
        평균계산vb.Show()
    End Sub

    '키보드입력
    Private Sub FromKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad0
                setLabelWindowIS("0")
            Case Keys.NumPad1
                setLabelWindowIS("1")
            Case Keys.NumPad2
                setLabelWindowIS("2")
            Case Keys.NumPad3
                setLabelWindowIS("3")
            Case Keys.NumPad4
                setLabelWindowIS("4")
            Case Keys.NumPad5
                setLabelWindowIS("5")
            Case Keys.NumPad6
                setLabelWindowIS("6")
            Case Keys.NumPad7
                setLabelWindowIS("7")
            Case Keys.NumPad8
                setLabelWindowIS("8")
            Case Keys.NumPad9
                setLabelWindowIS("9")
            Case Keys.Add
                setLabelWindowIS("+")
            Case Keys.Subtract
                setLabelWindowIS("-")
            Case Keys.Multiply
                setLabelWindowIS("×")
            Case Keys.Divide
                setLabelWindowIS("÷")
            Case Keys.Enter
                eql()
            Case Keys.Back
                If InputString.Length > 0 Then
                    InputString = InputString.Remove(InputString.Length - 1)
                    Label1.Text = InputString
                    ResultBox.Text = InputString
                Else
                    ResultBox.Text = InputString
                End If
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    '삭제버튼
    Private Sub DelBtn_click(sender As Object, e As EventArgs) Handles delBtn.Click
        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim testNo As String = row.Cells(4).Value.ToString()

        If MsgBox("선택된 행을 삭제하시겠습니까?", vbQuestion + vbYesNo, "확인창") = vbYes Then
            myCmd = New SqlCommand("delete from test where test_no=" & testNo, myConn)
            myConn.Open()

            If myCmd.ExecuteNonQuery() > 0 Then ' 
                MsgBox("삭제완료")
            Else
                MsgBox("에러")
            End If
            LoadData()
            myConn.Close()
        End If

        '여러행 삭제(아직안됨)
        'If MsgBox("선택된 행을 삭제하시겠습니까?", vbQuestion + vbYesNo, "확인창") = vbYes Then
        '    Dim i As Integer
        '    For i = DataGridView1.Rows.Count - 1 To 0 Step -1
        '        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        '        Dim testno As String = row.Cells(4).Value.ToString()

        '        If DataGridView1.Rows(i).Selected = True Then
        '            myCmd = New SqlCommand("delete from test where test_no=" & testno, myConn)
        '            myConn.Open()

        '            If myCmd.ExecuteNonQuery() > 0 Then ' 
        '                MsgBox("삭제완료")
        '            Else
        '                MsgBox("에러")
        '            End If
        '            LoadData()
        '            myConn.Close()
        '        End If
        '    Next
        'End If
    End Sub
End Class
