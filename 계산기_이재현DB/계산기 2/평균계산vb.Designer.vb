<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 평균계산vb
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(평균계산vb))
        Me.inputBox = New System.Windows.Forms.TextBox()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.chkBoxVal = New System.Windows.Forms.CheckedListBox()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.Allcheck = New System.Windows.Forms.CheckBox()
        Me.AvgBtn = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'inputBox
        '
        Me.inputBox.Font = New System.Drawing.Font("굴림", 33.0!)
        Me.inputBox.Location = New System.Drawing.Point(21, 337)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(210, 58)
        Me.inputBox.TabIndex = 0
        Me.inputBox.Text = "0"
        Me.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.Font = New System.Drawing.Font("굴림", 14.0!, System.Drawing.FontStyle.Bold)
        Me.nextBtn.Location = New System.Drawing.Point(237, 337)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(60, 60)
        Me.nextBtn.TabIndex = 1
        Me.nextBtn.Text = "추가"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'chkBoxVal
        '
        Me.chkBoxVal.CheckOnClick = True
        Me.chkBoxVal.Font = New System.Drawing.Font("굴림", 15.0!)
        Me.chkBoxVal.FormattingEnabled = True
        Me.chkBoxVal.Location = New System.Drawing.Point(24, 117)
        Me.chkBoxVal.Name = "chkBoxVal"
        Me.chkBoxVal.Size = New System.Drawing.Size(276, 204)
        Me.chkBoxVal.TabIndex = 5
        '
        'delBtn
        '
        Me.delBtn.BackColor = System.Drawing.Color.Red
        Me.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delBtn.Font = New System.Drawing.Font("굴림", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.delBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.delBtn.Location = New System.Drawing.Point(168, 75)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(63, 36)
        Me.delBtn.TabIndex = 6
        Me.delBtn.Text = "삭제"
        Me.delBtn.UseVisualStyleBackColor = False
        '
        'Allcheck
        '
        Me.Allcheck.AutoSize = True
        Me.Allcheck.Checked = True
        Me.Allcheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Allcheck.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Allcheck.Location = New System.Drawing.Point(27, 87)
        Me.Allcheck.Name = "Allcheck"
        Me.Allcheck.Size = New System.Drawing.Size(95, 20)
        Me.Allcheck.TabIndex = 7
        Me.Allcheck.Text = "전체선택"
        Me.Allcheck.UseVisualStyleBackColor = True
        '
        'AvgBtn
        '
        Me.AvgBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.AvgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AvgBtn.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AvgBtn.Location = New System.Drawing.Point(237, 75)
        Me.AvgBtn.Name = "AvgBtn"
        Me.AvgBtn.Size = New System.Drawing.Size(63, 35)
        Me.AvgBtn.TabIndex = 8
        Me.AvgBtn.Text = "평균"
        Me.AvgBtn.UseVisualStyleBackColor = False
        '
        'ResultBox
        '
        Me.ResultBox.BackColor = System.Drawing.Color.White
        Me.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResultBox.Font = New System.Drawing.Font("굴림", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ResultBox.Location = New System.Drawing.Point(24, 23)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(276, 46)
        Me.ResultBox.TabIndex = 9
        Me.ResultBox.Text = "0"
        Me.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '평균계산vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(330, 412)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.AvgBtn)
        Me.Controls.Add(Me.Allcheck)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.chkBoxVal)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.inputBox)
        Me.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "평균계산vb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "평균계산vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputBox As TextBox
    Friend WithEvents nextBtn As Button
    Friend WithEvents chkBoxVal As CheckedListBox
    Friend WithEvents delBtn As Button
    Friend WithEvents Allcheck As CheckBox
    Friend WithEvents AvgBtn As Button
    Friend WithEvents ResultBox As TextBox
End Class
