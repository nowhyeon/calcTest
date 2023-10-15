Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' MyApplication에 대해 다음 이벤트를 사용할 수 있습니다.
    ' Startup: 응용 프로그램이 시작되고 시작 폼이 만들어지기 전에 발생합니다.
    ' Shutdown: 모든 응용 프로그램 폼이 닫힌 후에 발생합니다.  이 이벤트는 응용 프로그램이 비정상적으로 종료되는 경우에는 발생하지 않습니다.
    ' UnhandledException: 응용 프로그램에서 처리되지 않은 예외가 발생하는 경우 이 이벤트가 발생합니다.
    ' StartupNextInstance: 단일 인스턴스 응용 프로그램을 시작할 때 해당 응용 프로그램이 이미 활성 상태인 경우 발생합니다. 
    ' NetworkAvailabilityChanged: 네트워크가 연결되거나 연결이 끊어질 때 발생합니다.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Call DBConnection()  '디비연결 
            If IsForm1Open() Then
                MessageBox.Show("Form1이 이미 열려 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True ' 프로그램을 중단하려면 이벤트를 취소합니다.
            Else
                ' Form1이 열려 있지 않으면 새로운 폼을 생성하여 표시합니다.
            End If
        End Sub

        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If e.IsNetworkAvailable Then
                MessageBox.Show("인터넷에 연결되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("인터넷 연결이 끊어졌습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            If e.BringToForeground = True Then

            End If
        End Sub
    End Class
End Namespace
