Module modDB
    Public mdiForm As Form1  '메인폼
    Public adoCon As SqlConnection
    Public sQuery As String
    Public iResult As Integer '결과 행 반환
    Public cmd As New SqlCommand

    Public iRow, iCol As Integer

    Public Sub DBConnection()
        Try
            adoCon = New SqlConnection()
            adoCon.ConnectionString = "server=localhost;uid=sa;pwd=m2i_soft;database=ADOPROJECT;"
            adoCon.Open()

            If Not adoCon.State = ConnectionState.Open Then
                MessageBox.Show("DB연결 실패", "DB연결",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("DB연결 실패", "DB연결",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub

    Public Sub DBClose()
        If adoCon.State = ConnectionState.Open Then
            adoCon.Close()
        End If
    End Sub
End Module
