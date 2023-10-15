Public Class frmLogin
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Call DBConnection()  '디비연결 
        Dim sWhere As String

        sWhere = "AND 사원번호 = '" & txtID.Text.Trim & "'"

        If InsaFind(sWhere) Is Nothing Then ' 조회되지 않았을때의처리는 function안에서 처리했음

        Else                                ' 사원이 조회될 때.
            For Each data As DataRow In InsaFind(sWhere).Rows    'data = row 
                If data(2).ToString.Trim = txtPW.EditValue.ToString.Trim Then
                    mdiForm.Text = "인사관리 프로그래밍" & "-" & data(1).ToString
                    mdiForm.mnu로그인.Enabled = False
                    mdiForm.mnu로그아웃.Enabled = True
                    Me.Close()
                Else
                    MessageBox.Show("패스워드가 잘못됐습니다.", "로그인 실패",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPW.Focus()
                End If
            Next
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub txtPwd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPW.KeyDown
        If e.KeyData = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class