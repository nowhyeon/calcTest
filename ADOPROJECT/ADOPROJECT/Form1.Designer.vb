Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.기본관리ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu로그인 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu로그아웃 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu끝내기 = New System.Windows.Forms.ToolStripMenuItem()
        Me.직원관리ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu직원조회 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu직원수정 = New System.Windows.Forms.ToolStripMenuItem()
        Me.기타ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu보고서 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu메일 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Font = New System.Drawing.Font("한컴 고딕", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.기본관리ToolStripMenuItem, Me.직원관리ToolStripMenuItem, Me.기타ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(737, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '기본관리ToolStripMenuItem
        '
        Me.기본관리ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu로그인, Me.mnu로그아웃, Me.mnu끝내기})
        Me.기본관리ToolStripMenuItem.Name = "기본관리ToolStripMenuItem"
        Me.기본관리ToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.기본관리ToolStripMenuItem.Text = "기본관리"
        '
        'mnu로그인
        '
        Me.mnu로그인.Name = "mnu로그인"
        Me.mnu로그인.Size = New System.Drawing.Size(131, 22)
        Me.mnu로그인.Text = "로그인"
        '
        'mnu로그아웃
        '
        Me.mnu로그아웃.Name = "mnu로그아웃"
        Me.mnu로그아웃.Size = New System.Drawing.Size(131, 22)
        Me.mnu로그아웃.Text = "로그아웃"
        '
        'mnu끝내기
        '
        Me.mnu끝내기.Name = "mnu끝내기"
        Me.mnu끝내기.Size = New System.Drawing.Size(131, 22)
        Me.mnu끝내기.Text = "끝내기"
        '
        '직원관리ToolStripMenuItem
        '
        Me.직원관리ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu직원조회, Me.mnu직원수정})
        Me.직원관리ToolStripMenuItem.Name = "직원관리ToolStripMenuItem"
        Me.직원관리ToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.직원관리ToolStripMenuItem.Text = "직원관리"
        '
        'mnu직원조회
        '
        Me.mnu직원조회.Name = "mnu직원조회"
        Me.mnu직원조회.Size = New System.Drawing.Size(153, 22)
        Me.mnu직원조회.Text = "직원정보조회"
        '
        'mnu직원수정
        '
        Me.mnu직원수정.Name = "mnu직원수정"
        Me.mnu직원수정.Size = New System.Drawing.Size(153, 22)
        Me.mnu직원수정.Text = "직원정보수정"
        '
        '기타ToolStripMenuItem
        '
        Me.기타ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu보고서, Me.mnu메일})
        Me.기타ToolStripMenuItem.Name = "기타ToolStripMenuItem"
        Me.기타ToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.기타ToolStripMenuItem.Text = "기타"
        '
        'mnu보고서
        '
        Me.mnu보고서.Name = "mnu보고서"
        Me.mnu보고서.Size = New System.Drawing.Size(142, 22)
        Me.mnu보고서.Text = "보고서작성"
        '
        'mnu메일
        '
        Me.mnu메일.Name = "mnu메일"
        Me.mnu메일.Size = New System.Drawing.Size(142, 22)
        Me.mnu메일.Text = "메일보내기"
        '
        'Form1
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 299)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "인사관리"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 기본관리ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu로그인 As ToolStripMenuItem
    Friend WithEvents mnu로그아웃 As ToolStripMenuItem
    Friend WithEvents mnu끝내기 As ToolStripMenuItem
    Friend WithEvents 직원관리ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu직원조회 As ToolStripMenuItem
    Friend WithEvents mnu직원수정 As ToolStripMenuItem
    Friend WithEvents 기타ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu보고서 As ToolStripMenuItem
    Friend WithEvents mnu메일 As ToolStripMenuItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

#End Region

End Class
