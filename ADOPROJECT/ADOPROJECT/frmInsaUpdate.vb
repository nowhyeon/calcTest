Imports DevExpress.XtraEditors
Public Class frmInsaUpdate
    Inherits DevExpress.XtraEditors.XtraForm
    Public bTag As Boolean

    Private Sub frmInsaUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboSearch(cboDept, "s_부서Ser")
        ComboSearch(cboJik, "s_직급Ser")
        ComboSearch(cboSch, "s_학력Ser")

        txtSabun.Enabled = False

        If bTag = False Then
            Call btnClear_Click(sender, e)
        ElseIf bTag = True Then
            btnInsert.Enabled = False
        End If
    End Sub

    Private Sub clear()
        Me.txtSabun.EditValue = ""
        Me.txtName.EditValue = ""
        Me.txtPw.EditValue = ""
        Me.txtJumin1.EditValue = ""
        Me.txtJumin2.EditValue = ""
        Me.DateTimePicker3.Value = Now
        Me.RadioButton1.Checked = True
        Me.cboDept.EditValue = ""
        Me.cboJik.EditValue = ""
        Me.cboSch.EditValue = ""
        Me.DateTimePicker1.Value = Now
        Me.DateTimePicker2.Value = CDate("2999-12-31")
        Me.txtEmail.EditValue = ""
        Me.txtZip.EditValue = ""
        Me.txtAddr1.EditValue = ""
        Me.txtAddr2.EditValue = ""
        Me.txtTel1.EditValue = ""
        Me.txtTel2.EditValue = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call clear()

        sQuery = ""
        sQuery = sQuery + "SELECT RIGHT(MAX(사원번호),3)+1  "
        sQuery = sQuery + "  FROM 사원                      "
        sQuery = sQuery + " WHERE LEFT(사원번호,2)='" & Now.Year.ToString.Substring(2, 2) & "'"

        Dim cmd As New SqlCommand(sQuery, adoCon)
        Dim dept_code As String
        Dim o As Object = cmd.ExecuteScalar()

        If (o.GetType() Is GetType(System.DBNull)) Then
            txtSabun.EditValue = Now.Year.ToString.Substring(2, 2) & "001"                            '해당년도의 첫번째 사원이면 해당년도2자리 + 001
        Else
            txtSabun.EditValue = Now.Year.ToString.Substring(2, 2) & Format(CType(o, Integer), "000") '아니면 마지막사원의 + 1
        End If

        btnInsert.Enabled = True : btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        If txtName.EditValue.ToString = "" Then
            MessageBox.Show("이름은 필수 입력사항 입니다.")
            txtName.Focus()
            Exit Sub
        End If

        If txtPw.EditValue.ToString = "" Then
            MessageBox.Show("패스워드는 필수 입력사항 입니다.")
            txtPw.Focus()
            Exit Sub
        End If

        If txtEmail.EditValue.ToString = "" Then
            MessageBox.Show("이메일은 필수 입력사항 입니다.")
            txtEmail.Focus()
            Exit Sub
        End If

        If txtJumin1.EditValue.ToString = "" Or txtJumin1.Text.Length <> 6 Then
            MessageBox.Show("주민번호 앞자리는 필수 입력 사항이며" + vbCrLf + "숫자6자리입니다")
            txtJumin1.Focus()
            Exit Sub
        End If

        If txtJumin2.EditValue.ToString = "" Or txtJumin2.Text.Length <> 7 Then
            MessageBox.Show("주민번호 앞자리는 필수 입력 사항이며" + vbCrLf + "숫자7자리입니다")
            txtJumin2.Focus()
            Exit Sub
        End If

        If cboDept.SelectedIndex < 0 Then
            MessageBox.Show("부서는 필수 입력사항 입니다.")
            cboDept.Focus()
            Exit Sub
        End If

        If cboJik.SelectedIndex < 0 Then
            MessageBox.Show("직급은 필수 입력사항 입니다.")
            cboJik.Focus()
            Exit Sub
        End If

        If cboSch.SelectedIndex < 0 Then
            MessageBox.Show("최종학력은 필수 입력사항 입니다.")
            cboSch.Focus()
            Exit Sub
        End If
        Dim cmd As SqlCommand = New SqlCommand("s_사원Ins", adoCon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@사원번호", SqlDbType.Char, 5).Value = txtSabun.EditValue.ToString.Trim
        cmd.Parameters.Add("@이름", SqlDbType.Char, 10).Value = txtName.EditValue.ToString.Trim
        cmd.Parameters.Add("@패스워드", SqlDbType.Char, 5).Value = txtPw.EditValue.ToString.Trim
        cmd.Parameters.Add("@주민번호", SqlDbType.Char, 14).Value = txtJumin1.EditValue.ToString.Trim + "-" + txtJumin2.EditValue.ToString.Trim
        cmd.Parameters.Add("@생년월일", SqlDbType.Char, 10).Value = Format(DateTimePicker3.Value, "yyyy-MM-dd")
        If RadioButton1.Checked = True Then
            cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = "M"
        ElseIf RadioButton2.Checked = True Then
            cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = "W"
        Else
            cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = "-"
        End If
        cmd.Parameters.Add("@부서코드", SqlDbType.Char, 2).Value = cboDept.EditValue.ToString.Substring(0, 2).Trim
        cmd.Parameters.Add("@직급코드", SqlDbType.Char, 2).Value = cboJik.EditValue.ToString.Substring(0, 2).Trim
        cmd.Parameters.Add("@학력코드", SqlDbType.Char, 2).Value = cboDept.EditValue.ToString.Substring(0, 2).Trim
        cmd.Parameters.Add("@입사일", SqlDbType.Char, 10).Value = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        cmd.Parameters.Add("@퇴사일", SqlDbType.Char, 10).Value = Format(DateTimePicker2.Value, "yyyy-MM-dd")
        cmd.Parameters.Add("@이메일", SqlDbType.VarChar, 35).Value = txtEmail.EditValue.ToString.Trim
        cmd.Parameters.Add("@우편번호", SqlDbType.Char, 7).Value = txtZip.EditValue.ToString.Trim
        cmd.Parameters.Add("@주소1", SqlDbType.VarChar, 50).Value = txtAddr1.EditValue.ToString.Trim
        cmd.Parameters.Add("@주소2", SqlDbType.VarChar, 50).Value = txtAddr2.EditValue.ToString.Trim
        cmd.Parameters.Add("@집전화번호", SqlDbType.Char, 14).Value = txtTel1.EditValue.ToString.Trim
        cmd.Parameters.Add("@휴대폰번호", SqlDbType.Char, 14).Value = txtTel2.EditValue.ToString.Trim

        Dim iResult As Integer = cmd.ExecuteNonQuery
        If iResult > 0 Then
            MessageBox.Show("입력 성공")
            Me.Close()
        Else
            MessageBox.Show("입력 실패")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As SqlCommand = New SqlCommand("s_사원Upd", adoCon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@사원번호", SqlDbType.Char, 5).Value = txtSabun.EditValue.ToString.Trim
        cmd.Parameters.Add("@이름", SqlDbType.Char, 10).Value = txtName.EditValue.ToString.Trim
        cmd.Parameters.Add("@패스워드", SqlDbType.Char, 5).Value = txtPw.EditValue.ToString.Trim
        cmd.Parameters.Add("@주민번호", SqlDbType.Char, 14).Value = txtJumin1.EditValue.ToString.Trim + "-" + txtJumin2.EditValue.ToString.Trim
        cmd.Parameters.Add("@생년월일", SqlDbType.Char, 10).Value = Format(DateTimePicker3.Value, "yyyy-MM-dd")
        If RadioButton1.Checked = True Then
            cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = "M"
        ElseIf RadioButton2.Checked = True Then
            cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = "W"
        Else
            cmd.Parameters.Add("@성별", SqlDbType.Char, 1).Value = "-"
        End If
        cmd.Parameters.Add("@부서코드", SqlDbType.Char, 2).Value = cboDept.EditValue.ToString.Substring(0, 2).Trim
        cmd.Parameters.Add("@직급코드", SqlDbType.Char, 2).Value = cboJik.EditValue.ToString.Substring(0, 2).Trim
        cmd.Parameters.Add("@학력코드", SqlDbType.Char, 2).Value = cboSch.EditValue.ToString.Substring(0, 2).Trim
        cmd.Parameters.Add("@입사일", SqlDbType.Char, 10).Value = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        cmd.Parameters.Add("@퇴사일", SqlDbType.Char, 10).Value = Format(DateTimePicker2.Value, "yyyy-MM-dd")
        cmd.Parameters.Add("@이메일", SqlDbType.VarChar, 35).Value = txtEmail.EditValue.ToString.Trim
        cmd.Parameters.Add("@우편번호", SqlDbType.Char, 7).Value = txtZip.EditValue.ToString.Trim
        cmd.Parameters.Add("@주소1", SqlDbType.VarChar, 50).Value = txtAddr1.EditValue.ToString.Trim
        cmd.Parameters.Add("@주소2", SqlDbType.VarChar, 50).Value = txtAddr2.EditValue.ToString.Trim
        cmd.Parameters.Add("@집전화번호", SqlDbType.Char, 14).Value = txtTel1.EditValue.ToString.Trim
        cmd.Parameters.Add("@휴대폰번호", SqlDbType.Char, 14).Value = txtTel2.EditValue.ToString.Trim

        Dim iResult As Integer = cmd.ExecuteNonQuery
        If iResult > 0 Then
            MessageBox.Show("변경 성공")
            Me.Close()
        Else
            MessageBox.Show("변경 실패")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Clcik(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As SqlCommand = New SqlCommand("s_사원Del", adoCon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@사원번호", SqlDbType.Char, 5).Value = txtSabun.EditValue.ToString.Trim

        Dim iResult As Integer = cmd.ExecuteNonQuery
        If iResult > 0 Then
            MessageBox.Show("삭제 성공")
            Me.Close()
        Else
            MessageBox.Show("삭제 실패")
        End If
    End Sub
End Class