Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdiForm = Me
        Dim f As New frmLogin()
        f.ShowDialog()
    End Sub

    Private Sub mnu로그인_Click(sender As Object, e As EventArgs) Handles mnu로그인.Click
        Dim f As New frmLogin()
        f.ShowDialog()
    End Sub

    Private Sub mnu로그아웃_Click(sender As Object, e As EventArgs) Handles mnu로그아웃.Click
        Me.mnu로그아웃.Enabled = False
        Me.mnu로그인.Enabled = True

        Call DBClose()
    End Sub

    Private Sub mnu끝내기_Click(sender As Object, e As EventArgs) Handles mnu끝내기.Click
        Application.Exit()
    End Sub

    Private Sub mnu직원조회_Click(sender As Object, e As EventArgs) Handles mnu직원조회.Click
        Dim f As New frmInsaSearch()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnu직원수정_Click(sender As Object, e As EventArgs) Handles mnu직원수정.Click
        Dim f As New frmInsaUpdate()
        f.bTag = False
        f.Show()
    End Sub
End Class
