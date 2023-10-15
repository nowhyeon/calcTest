Imports System.IO

Public Class frmInsaSearch
    Private Sub frmInsaSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '디폴트 이미지
        Dim defaultImgPath As String = "C:\Users\M2I_SOFT\source\repos\ADOPROJECT\ADOPROJECT\noimage.gif"
        PictureEdit1.Image = New Bitmap(Image.FromFile(defaultImgPath), 106, 106)  ' default이미지로 null처리

        '이미지 크기를 위한 행 높이 조절
        'gridView로 파싱 후 RowHeight 속성 사용
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(avDetail2.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
        gridView.RowHeight = 90

        'comboBoxEdit item List
        ComboSearch(cboDept, "s_부서Ser")
        ComboSearch(cboJik, "s_직급Ser")

        avDetail2.Dock = DockStyle.Bottom                'form bottom에 dock시키기
        avDetail2.Height = Me.ClientSize.Height / 1.175  '위아래 크기 조정

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim dataTable As DataTable
        Dim sWhere As String = ""
        Dim sOR As String = ""

        avDetail2.DataSource = Nothing

        If txtSabun.Text <> "" Then
            sWhere = sWhere & "AND 사원번호='" & txtSabun.Text.Trim & "'"
        End If

        If txtName.Text <> "" Then
            sWhere = sWhere & "AND 이름 Like ('" & txtName.Text.Trim & "')"
        End If

        If cboDept.Text <> "" Then
            sWhere = sWhere & "AND 부서코드='" & cboDept.Text.Substring(0, 2) & "'"
        End If

        If cboJik.Text <> "" Then
            sWhere = sWhere & "AND 직급코드='" & cboJik.Text.Substring(0, 2) & "'"
        End If

        If InsaFind(sWhere) Is Nothing Then

        Else                                        ' 조회할 사원이 있을 때

            dataTable = InsaFind(sWhere) ' InsaFind(sWhere) - 조건넣고 조회하면 DataTable로 반환

            '이미지 처리부분
            For Each data As DataRow In dataTable.Rows
                'data(16) = GetImageFromDatabase(data(0).ToString()) 
                GetImageFromDatabase(data(0).ToString()) ' 이미지로 변환
            Next

            '이미지 처리후 dataSource 에 dataTable 주입
            avDetail2.DataSource = dataTable
            '레프레쉬
            avDetail2.RefreshDataSource()
        End If
        searchClear()  '검색조건 초기화
    End Sub

    '처음 만든 gridControl 비활성화 상태라서 주석처리해둠 
    Private Sub avDetail_DblClick(sender As Object, e As EventArgs) Handles avDetail.DoubleClick
        '' GridControl에서 현재 활성화된 GridView 가져오기
        'Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(avDetail.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)

        'If gridView IsNot Nothing Then
        '    'Dim pt As Point = gridView.GridControl.PointToClient(Control.MousePosition)
        '    Dim pt As Point = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition)
        '    Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = gridView.CalcHitInfo(pt)

        '    If info.InRowCell Then
        '        ' 셀이 클릭되었을 때의 작업 수행
        '        Dim clickedRowHandle As Integer = info.RowHandle
        '        Dim clickedColumn As DevExpress.XtraGrid.Columns.GridColumn = info.Column
        '        'MessageBox.Show($"더블클릭한 셀의 값: {gridView.GetRowCellValue(clickedRowHandle, clickedColumn)}")
        '        Dim jumin() As String

        '        Dim value0 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("사원번호"))
        '        Dim value1 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("이름"))
        '        Dim value2 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("패스워드"))
        '        Dim value3 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("주민번호"))
        '        Dim value4 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("생년월일"))
        '        Dim value5 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("성별"))
        '        Dim value6 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("부서코드"))
        '        Dim value7 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("직급코드"))
        '        Dim value8 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("학력코드"))
        '        Dim value9 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("입사일"))
        '        Dim value10 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("퇴사일"))
        '        Dim value11 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("이메일"))
        '        Dim value12 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("우편번호"))
        '        Dim value13 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("주소1"))
        '        Dim value14 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("주소2"))
        '        Dim value15 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("집전화번호"))
        '        Dim value16 As Object = gridView.GetRowCellValue(clickedRowHandle, gridView.Columns("휴대폰번호"))

        '        jumin = value3.ToString.Split("-")

        '        Dim f As New frmInsaUpdate()
        '        f.txtSabun.EditValue = value0                     '사번
        '        f.txtName.EditValue = value1                      '이름
        '        f.txtPw.EditValue = value2                        '비밀번호
        '        f.txtJumin1.EditValue = jumin(0)                  '주민번호 앞자리
        '        f.txtJumin2.EditValue = jumin(1)                  '주민번호 뒷자리
        '        f.DateTimePicker3.Value = CDate(value4)           '생년월일
        '        If value5.ToString = "M" Then                     '남자일때
        '            f.RadioButton1.Checked = True
        '        ElseIf value5.ToString = "W" Then                 '여자일때
        '            f.RadioButton2.Checked = True
        '        Else
        '            f.RadioButton1.Checked = False
        '            f.RadioButton2.Checked = False
        '        End If

        '        Dim cmd As New SqlCommand("s_부서Ser", adoCon)
        '        cmd.CommandType = CommandType.StoredProcedure
        '        Dim rs As SqlDataReader = cmd.ExecuteReader

        '        While rs.Read()
        '            If value6.ToString = rs(0) Then
        '                f.cboDept.EditValue = rs(0) + "_" + rs(1) '부서 
        '            End If
        '        End While
        '        rs.Close()

        '        Dim cmd1 As New SqlCommand("s_직급Ser", adoCon)
        '        cmd1.CommandType = CommandType.StoredProcedure
        '        Dim rs1 As SqlDataReader = cmd1.ExecuteReader

        '        While rs1.Read()
        '            If value7.ToString = rs1(0) Then
        '                f.cboJik.EditValue = rs1(0) + "_" + rs1(1) '직급
        '            End If
        '        End While
        '        rs1.Close()

        '        Dim cmd2 As New SqlCommand("s_학력Ser", adoCon)
        '        cmd2.CommandType = CommandType.StoredProcedure
        '        Dim rs2 As SqlDataReader = cmd2.ExecuteReader

        '        While rs2.Read()
        '            If value8.ToString = rs2(0) Then
        '                f.cboSch.EditValue = rs2(0) + "_" + rs2(1)
        '            End If
        '        End While
        '        rs2.Close()

        '        f.DateTimePicker1.Value = CDate(value9)                       '입사일
        '        If value10.ToString.Trim <> "" Or value10 Is Nothing Then
        '            f.DateTimePicker2.Value = CDate(value10.ToString.Trim)    '퇴사일이 있을 때
        '        Else
        '            f.DateTimePicker2.Value = CDate("2999-12-31")             '퇴사일이 없을 때
        '        End If

        '        f.txtEmail.EditValue = value11.ToString
        '        f.txtZip.EditValue = value12.ToString
        '        f.txtAddr1.EditValue = value13.ToString
        '        f.txtAddr2.EditValue = value14.ToString
        '        f.txtTel1.EditValue = value15.ToString
        '        f.txtTel2.EditValue = value16.ToString

        '        f.bTag = True
        '        f.Owner = Me
        '        f.Show()
        '    End If
        'End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintGridControl(avDetail2) '출력할 gridControl 입력
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '조회없이 행추가 시 error
        If avDetail2.DataSource Is Nothing Then
            MessageBox.Show("데이터를 조회한 후 행을 추가해 주세요.")
            Return
        End If

        Dim dataTable As DataTable = DirectCast(avDetail2.DataSource, DataTable)
        Dim newRow As DataRow = dataTable.NewRow()
        dataTable.Rows.Add(newRow)
        avDetail2.RefreshDataSource()
    End Sub

    '삭제
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dataTable As DataTable = DirectCast(avDetail2.DataSource, DataTable)
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(avDetail2.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView) '한줄선택, gridView로
        Dim selectedRows As Integer = gridView.FocusedRowHandle

        Dim sabun As String = gridView.GetRowCellValue(selectedRows, gridView.Columns("사원번호")).ToString.Trim

        sQuery = String.Empty
        sQuery = sQuery & "UPDATE 사원                       "
        sQuery = sQuery & "   SET 사원상태 = '0'             " '사원상태 = 0 -> 조회시 보여지지 않음
        sQuery = sQuery & " WHERE 사원번호 = '" & sabun & "' "

        Dim cmd As SqlCommand = New SqlCommand(sQuery, adoCon)

        iResult = cmd.ExecuteNonQuery
        If iResult > 0 Then
            MessageBox.Show("삭제 성공")
        Else
            MessageBox.Show("삭제 실패")
        End If
        dataTable.Rows.RemoveAt(gridView.GetDataSourceRowIndex(selectedRows))
        avDetail2.RefreshDataSource()
    End Sub

    Private Sub InsaInsert(insaNo As String, '사원번호
                             name As String, '이름
                         password As String, '비번
                              rrn As String, '주민
                            birth As String, '생일
                              sex As String, '성별
                         deptCode As String, '부서코드
                          jikCode As String, '직급코드
                          schCode As String, '학력코드
                             join As String, '입사일
                            leave As String, '퇴사일
                            email As String, '이메일
                              zip As String, '우편
                            addr1 As String, '주소1
                            addr2 As String, '주소2
                             tel1 As String, '번호1
                             tel2 As String, '번호2
                            image As Image)  '이미지

        '유효성검사 실시 .. 부적합 시 MessageBox로 알림 0 반환
        '                   적합할 시 1 반환
        If effectiveness(insaNo, deptCode, jikCode, schCode) = 1 Then
            cmd = New SqlCommand("s_사원Ins", adoCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@사원번호", SqlDbType.Char, 5).Value = insaNo
            cmd.Parameters.Add("@이름", SqlDbType.Char, 10).Value = name
            cmd.Parameters.Add("@패스워드", SqlDbType.Char, 5).Value = password
            cmd.Parameters.Add("@주민번호", SqlDbType.Char, 14).Value = rrn
            cmd.Parameters.Add("@생년월일", SqlDbType.Char, 10).Value = birth
            cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = sex
            cmd.Parameters.Add("@부서코드", SqlDbType.Char, 2).Value = deptCode
            cmd.Parameters.Add("@직급코드", SqlDbType.Char, 2).Value = jikCode
            cmd.Parameters.Add("@학력코드", SqlDbType.Char, 2).Value = schCode
            cmd.Parameters.Add("@입사일", SqlDbType.Char, 10).Value = join
            cmd.Parameters.Add("@퇴사일", SqlDbType.Char, 10).Value = leave
            cmd.Parameters.Add("@이메일", SqlDbType.VarChar, 35).Value = email
            cmd.Parameters.Add("@우편번호", SqlDbType.Char, 7).Value = zip
            cmd.Parameters.Add("@주소1", SqlDbType.VarChar, 50).Value = addr1
            cmd.Parameters.Add("@주소2", SqlDbType.VarChar, 50).Value = addr2
            cmd.Parameters.Add("@집전화번호", SqlDbType.Char, 14).Value = tel1
            cmd.Parameters.Add("@휴대폰번호", SqlDbType.Char, 14).Value = tel2
            cmd.Parameters.Add("@이미지", SqlDbType.VarBinary).Value = ImageToByteArray(image)    '이미지를 byte로 바꾸고 집어넣음 

            iResult = cmd.ExecuteNonQuery
            If iResult > 0 Then
                MessageBox.Show("입력 성공")
            Else
                MessageBox.Show("입력 실패")
            End If
        End If


    End Sub

    Private Sub InsaModify(insaNo As String, '사원번호
                             name As String, '이름
                         password As String, '비번
                              rrn As String, '주민
                            birth As String, '생일
                              sex As String, '성별
                         deptCode As String, '부서코드
                          jikCode As String, '직급코드
                          schCode As String, '학력코드
                             join As String, '입사일
                            leave As String, '퇴사일
                            email As String, '이메일
                              zip As String, '우편
                            addr1 As String, '주소1
                            addr2 As String, '주소2
                             tel1 As String, '번호1
                             tel2 As String, '번호2
                            image As Image)  '이미지

        cmd = New SqlCommand("s_사원Upd", adoCon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@사원번호", SqlDbType.Char, 5).Value = insaNo
        cmd.Parameters.Add("@이름", SqlDbType.Char, 10).Value = name
        cmd.Parameters.Add("@패스워드", SqlDbType.Char, 5).Value = password
        cmd.Parameters.Add("@주민번호", SqlDbType.Char, 14).Value = rrn
        cmd.Parameters.Add("@생년월일", SqlDbType.Char, 10).Value = birth
        cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = sex
        cmd.Parameters.Add("@부서코드", SqlDbType.Char, 2).Value = deptCode
        cmd.Parameters.Add("@직급코드", SqlDbType.Char, 2).Value = jikCode
        cmd.Parameters.Add("@학력코드", SqlDbType.Char, 2).Value = schCode
        cmd.Parameters.Add("@입사일", SqlDbType.Char, 10).Value = join
        cmd.Parameters.Add("@퇴사일", SqlDbType.Char, 10).Value = leave
        cmd.Parameters.Add("@이메일", SqlDbType.VarChar, 35).Value = email
        cmd.Parameters.Add("@우편번호", SqlDbType.Char, 7).Value = zip
        cmd.Parameters.Add("@주소1", SqlDbType.VarChar, 50).Value = addr1
        cmd.Parameters.Add("@주소2", SqlDbType.VarChar, 50).Value = addr2
        cmd.Parameters.Add("@집전화번호", SqlDbType.Char, 14).Value = tel1
        cmd.Parameters.Add("@휴대폰번호", SqlDbType.Char, 14).Value = tel2
        cmd.Parameters.Add("@이미지", SqlDbType.VarBinary).Value = ImageToByteArray(image)

        iResult = cmd.ExecuteNonQuery
        If iResult > 0 Then
            MessageBox.Show("변경 성공")
        Else
            MessageBox.Show("변경 실패")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' avDetail2.DataSource  ->   DataTable
        Dim dataTable As DataTable = DirectCast(avDetail2.DataSource, DataTable)

        ' 데이터 테이블의 Row 하나의 상태를 확인하여 update.. insert.. 
        For Each data As DataRow In dataTable.Rows      'data = row

            If data.RowState = DataRowState.Added Then  'row의 상태가 추가 이면 
                InsaInsert(data(0).ToString.Trim,  '사원번호,
                           data(1).ToString.Trim,  '이름,
                           data(2).ToString.Trim,  '패스워드,
                           data(3).ToString.Trim,  '주민번호,
                           data(4).ToString.Trim,  '생년월일,
                           data(5).ToString.Trim,  '성별,
                           data(6).ToString.Trim,  '부서코드,
                           data(7).ToString.Trim,  '직급코드,
                           data(8).ToString.Trim,  '학력코드,
                           data(9).ToString.Trim,  '입사일,
                           data(10).ToString.Trim, '퇴사일,
                           data(11).ToString.Trim, '이메일,
                           data(12).ToString.Trim, '우편번호,W
                           data(13).ToString.Trim, '주소1,
                           data(14).ToString.Trim, '주소2,
                           data(15).ToString.Trim, '집전화번호
                           data(16).ToString.Trim, '휴대폰번호
                           PictureEdit1.Image) '이미지

                avDetail2.RefreshDataSource()

            ElseIf data.RowState = DataRowState.Modified Then 'row의 상태가 변경 이면 
                InsaModify(data(0).ToString.Trim,  '사원번호,
                           data(1).ToString.Trim,  '이름,
                           data(2).ToString.Trim,  '패스워드,
                           data(3).ToString.Trim,  '주민번호,
                           data(4).ToString.Trim,  '생년월일,
                           data(5).ToString.Trim,  '성별,
                           data(6).ToString.Trim,  '부서코드,
                           data(7).ToString.Trim,  '직급코드,
                           data(8).ToString.Trim,  '학력코드,
                           data(9).ToString.Trim,  '입사일,
                           data(10).ToString.Trim, '퇴사일,
                           data(11).ToString.Trim, '이메일,
                           data(12).ToString.Trim, '우편번호,
                           data(13).ToString.Trim, '주소1,
                           data(14).ToString.Trim, '주소2,
                           data(15).ToString.Trim, '집전화번호
                           data(16).ToString.Trim, '휴대폰번호
                           PictureEdit1.Image) '이미지

                avDetail2.RefreshDataSource()
            End If
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim filePath As String = "C:\\TestImgae\도진.jpg"
        Dim sourceImg As Image = Image.FromFile(filePath)

        Dim iconImg As New Bitmap(sourceImg, 106, 106)
        Dim iconStream As New MemoryStream

        PictureEdit1.Image = iconImg
        iconImg.Save("C:\\TestImgae\test_icon.jpg")


        'Dim img As Image
        'Dim imgData As Byte()
        'For Each dataRow As DataRow In xmlDataSet.Tables("Cars").Rows
        '    imgData = DirectCast(dataRow("Picture"), Byte()) ' Object 데이터를 byte 형식으로 형변환
        '    img = Image.FromStream(New MemoryStream(imgData)) ' byte 데이터를 Image로 형 변환
        '    imageSlider1.Images.Add(img)
        'Next
    End Sub

    Private Sub avDetail2_Click(sender As Object, e As EventArgs) Handles avDetail2.Click
        'Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(avDetail2.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView) 'gridView로 파싱
        'Dim selectedRows As Integer = gridView.FocusedRowHandle                ' 어디에 focus 되어있는지 
        'Dim sabun As String = gridView.GetRowCellValue(selectedRows, gridView.Columns("사원번호")).ToString 'focus된 row의 사원번호 
        'pictureEdit1.EditValue = gridView1.GetRowCellValue(e.RowHandle, "Picture")

    End Sub

    Private Sub btnSajin_Click(sender As Object, e As EventArgs) Handles btnSajin.Click
        Dim dlgOpen As New OpenFileDialog
        Dim filePath As String = "C:\\TestImage\"  '파일이 저장될 경로
        Dim filePathName As String                 '경로 포함 파일이름
        Dim fileName As String                     '경로 뺀 파일이름
        Dim saveFile As Image

        dlgOpen.Filter = "모든 파일(*.*)|*.*|그림 파일(*.ico);(*.bmp)|*.ico;*.bmp"

        If (dlgOpen.ShowDialog() = DialogResult.OK And dlgOpen.FileName() <> "") Then '파일 선택시

            '이미지 저장을 위한 부분
            filePathName = dlgOpen.FileName
            fileName = Path.GetFileName(filePathName)
            saveFile = Image.FromFile(filePathName)

            '선택한 파일 파싱  크기 
            Dim iconImg As New Bitmap(saveFile, 106, 106)
            '아이콘 이미지 보여줌
            PictureEdit1.Image = iconImg
        Else                                                                          '파일 선택 안 할시 
            Return
        End If

        'saveFile.Save(filePath & fileName)                                            '선택한 이미지 지정된 경로에 저장
    End Sub
End Class