Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting   '프린트
Imports System.IO                 '이미지
Module modFnc

    'comboBoxEdit item생성
    Public Sub ComboSearch(ByVal c As ComboBoxEdit, ByVal sql As String)
        Dim cmd As New SqlCommand(sql, adoCon)
        cmd.CommandType = CommandType.StoredProcedure
        Dim rs As SqlDataReader = cmd.ExecuteReader
        c.Properties.Items.Clear()

        While rs.Read()
            c.Properties.Items.Add(rs(0) + "_" + rs(1))
        End While
        rs.Close()
    End Sub

    'print 
    Public Sub PrintGridControl(ByVal gridControl As GridControl)
        ' GridControl의 PrintableComponentLink 생성
        Dim printableComponentLink As New PrintableComponentLink(New PrintingSystem())

        ' PrintableComponentLink에 GridControl을 할당
        printableComponentLink.Component = gridControl

        ' 프린터 설정
        printableComponentLink.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50) ' 여백 설정
        printableComponentLink.Landscape = True ' 가로 방향으로 출력 설정
        printableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4 ' 용지 종류 설정

        ' 프린트 미리보기
        printableComponentLink.ShowPreview()
    End Sub

    '유효성 검사
    Public Function effectiveness(ByVal insaNo As String,
                                  ByVal deptCode As String,
                                  ByVal jikCode As String,
                                  ByVal schCode As String) As Integer
        Dim sWhere As String = "AND 사원번호 = '" & insaNo & "'"

        If InsaFind(sWhere) IsNot Nothing Then   ' 입력한 사번을 조회해서 사번이 이미 있으면 
            MessageBox.Show("이미 사용중인 사원번호 입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return 0
        ElseIf insaNo = "" Then
            MessageBox.Show("사원번호를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return 0
        End If

        If deptCode = "" Or Not IsNumeric(deptCode.Trim) Or deptCode.Length <> 2 Then '
            MessageBox.Show("부서코드를 입력하세요. ex)01..02..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return 0
        End If

        If jikCode = "" Or Not IsNumeric(jikCode.Trim) Or jikCode.Length <> 2 Then ' 
            MessageBox.Show("직급코드를 입력하세요. ex)01..02..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return 0
        End If

        If schCode = "" Or Not IsNumeric(schCode.Trim) Or schCode.Length <> 2 Then ' 
            MessageBox.Show("학력코드를 입력하세요. ex)01..02..", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return 0
        End If
        Return 1
    End Function

    '로그인, frmInsa의 조회 에서 사용
    Public Function InsaFind(ByVal sWhere As String) As DataTable
        Dim adapter As SqlDataAdapter
        Dim dataTable As DataTable

        sQuery = String.Empty
        sQuery = sQuery & "SELECT 사원번호,       "
        sQuery = sQuery & "       이름,           "
        sQuery = sQuery & "       패스워드,       "
        sQuery = sQuery & "       주민번호,       "
        sQuery = sQuery & "       생년월일,       "
        sQuery = sQuery & "       성별,           "
        sQuery = sQuery & "       부서코드,       "
        sQuery = sQuery & "       직급코드,       "
        sQuery = sQuery & "       학력코드,       "
        sQuery = sQuery & "       입사일,         "
        sQuery = sQuery & "       퇴사일,         "
        sQuery = sQuery & "       이메일,         "
        sQuery = sQuery & "       우편번호,       "
        sQuery = sQuery & "       주소1,          "
        sQuery = sQuery & "       주소2,          "
        sQuery = sQuery & "       집전화번호,     "
        sQuery = sQuery & "       휴대폰번호,     "
        sQuery = sQuery & "       이미지          "
        sQuery = sQuery & "  FROM 사원            "
        sQuery = sQuery & " WHERE 1=1             "
        sQuery = sQuery & "   AND 사원상태 = '1'  " ' 삭제시 사원상태 0 으로 만들어서 삭제된거처럼 보이게 하기
        sQuery = sQuery & sWhere                    ' AND 사원번호 = txtSabun ,, OR 사원번호 = txtSabun..

        cmd = New SqlCommand(sQuery, adoCon)
        cmd.CommandType = CommandType.Text
        adapter = New SqlDataAdapter(cmd)

        dataTable = New DataTable()
        adapter.Fill(dataTable)

        If dataTable.Rows.Count = 0 Then
            MessageBox.Show("조회되는 사원이 없습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return Nothing
        Else
            Return dataTable
        End If
    End Function


    '검색조건 초기화
    Public Sub searchClear()
        Dim f As New frmInsaSearch

        f.txtSabun.Text = String.Empty
        f.txtName.Text = String.Empty
        f.cboDept.Text = String.Empty
        f.cboJik.Text = String.Empty
    End Sub

    ' 이미지를 바이트 배열로 변환하는 함수
    Public Function ImageToByteArray(image As Image) As Byte()
        Dim ms As New MemoryStream()
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    ' 데이터베이스에서 이미지를 가져오는 함수
    Public Function GetImageFromDatabase(sabun As String) As Image
        sQuery = String.Empty
        sQuery = sQuery & "SELECT 이미지                   "
        sQuery = sQuery & "  FROM 사원                     "
        sQuery = sQuery & " WHERE 사원번호 ='" & sabun & "'"
        cmd = New SqlCommand(sQuery, adoCon)

        Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            Dim ms As New MemoryStream(imageData)                          '사진가져옴

            'Dim resizedImage As New Bitmap(Image.FromStream(ms), 1000, 1000) '사진 크기조절

            'Return resizedImage                                            '크기조절된 사진 리턴
            Return Image.FromStream(ms)
        Else
            Return Nothing
        End If
    End Function

    '폼 두개 열리는거 막는 펑션 안되는거같음.
    Public Function IsForm1Open() As Boolean
        For Each form As Form In Application.OpenForms
            If TypeOf form Is Form1 Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
