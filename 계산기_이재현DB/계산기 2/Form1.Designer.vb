<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 계산기
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(계산기))
        Me.cmdBtn1 = New System.Windows.Forms.Button()
        Me.cmdBtn2 = New System.Windows.Forms.Button()
        Me.cmdBtn3 = New System.Windows.Forms.Button()
        Me.cmdBtn4 = New System.Windows.Forms.Button()
        Me.cmdBtn5 = New System.Windows.Forms.Button()
        Me.cmdBtn6 = New System.Windows.Forms.Button()
        Me.cmdBtn7 = New System.Windows.Forms.Button()
        Me.cmdBtn8 = New System.Windows.Forms.Button()
        Me.cmdBtn9 = New System.Windows.Forms.Button()
        Me.cmdBtn0 = New System.Windows.Forms.Button()
        Me.pointBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.plusBtn = New System.Windows.Forms.Button()
        Me.minusBtn = New System.Windows.Forms.Button()
        Me.multiplyBtn = New System.Windows.Forms.Button()
        Me.divideBtn = New System.Windows.Forms.Button()
        Me.equalBtn = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalcTestDataSet = New 계산기_2.calcTestDataSet()
        Me.eraseBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.메뉴ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.일반ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.leftBtn = New System.Windows.Forms.Button()
        Me.rightBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TestTableAdapter = New 계산기_2.calcTestDataSetTableAdapters.TestTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.delBtn = New System.Windows.Forms.Button()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBtn1
        '
        Me.cmdBtn1.BackColor = System.Drawing.Color.White
        Me.cmdBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn1.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn1.Location = New System.Drawing.Point(26, 121)
        Me.cmdBtn1.Name = "cmdBtn1"
        Me.cmdBtn1.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn1.TabIndex = 1
        Me.cmdBtn1.Text = "1"
        Me.cmdBtn1.UseVisualStyleBackColor = False
        '
        'cmdBtn2
        '
        Me.cmdBtn2.BackColor = System.Drawing.Color.White
        Me.cmdBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn2.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn2.Location = New System.Drawing.Point(117, 121)
        Me.cmdBtn2.Name = "cmdBtn2"
        Me.cmdBtn2.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn2.TabIndex = 1
        Me.cmdBtn2.Text = "2"
        Me.cmdBtn2.UseVisualStyleBackColor = False
        '
        'cmdBtn3
        '
        Me.cmdBtn3.BackColor = System.Drawing.Color.White
        Me.cmdBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn3.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn3.Location = New System.Drawing.Point(208, 121)
        Me.cmdBtn3.Name = "cmdBtn3"
        Me.cmdBtn3.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn3.TabIndex = 1
        Me.cmdBtn3.Text = "3"
        Me.cmdBtn3.UseVisualStyleBackColor = False
        '
        'cmdBtn4
        '
        Me.cmdBtn4.BackColor = System.Drawing.Color.White
        Me.cmdBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn4.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn4.Location = New System.Drawing.Point(26, 212)
        Me.cmdBtn4.Name = "cmdBtn4"
        Me.cmdBtn4.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn4.TabIndex = 1
        Me.cmdBtn4.Text = "4"
        Me.cmdBtn4.UseVisualStyleBackColor = False
        '
        'cmdBtn5
        '
        Me.cmdBtn5.BackColor = System.Drawing.Color.White
        Me.cmdBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn5.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn5.Location = New System.Drawing.Point(117, 212)
        Me.cmdBtn5.Name = "cmdBtn5"
        Me.cmdBtn5.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn5.TabIndex = 1
        Me.cmdBtn5.Text = "5"
        Me.cmdBtn5.UseVisualStyleBackColor = False
        '
        'cmdBtn6
        '
        Me.cmdBtn6.BackColor = System.Drawing.Color.White
        Me.cmdBtn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn6.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn6.Location = New System.Drawing.Point(208, 212)
        Me.cmdBtn6.Name = "cmdBtn6"
        Me.cmdBtn6.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn6.TabIndex = 1
        Me.cmdBtn6.Text = "6"
        Me.cmdBtn6.UseVisualStyleBackColor = False
        '
        'cmdBtn7
        '
        Me.cmdBtn7.BackColor = System.Drawing.Color.White
        Me.cmdBtn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn7.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn7.Location = New System.Drawing.Point(26, 303)
        Me.cmdBtn7.Name = "cmdBtn7"
        Me.cmdBtn7.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn7.TabIndex = 1
        Me.cmdBtn7.Text = "7"
        Me.cmdBtn7.UseVisualStyleBackColor = False
        '
        'cmdBtn8
        '
        Me.cmdBtn8.BackColor = System.Drawing.Color.White
        Me.cmdBtn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn8.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn8.Location = New System.Drawing.Point(117, 303)
        Me.cmdBtn8.Name = "cmdBtn8"
        Me.cmdBtn8.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn8.TabIndex = 1
        Me.cmdBtn8.Text = "8"
        Me.cmdBtn8.UseVisualStyleBackColor = False
        '
        'cmdBtn9
        '
        Me.cmdBtn9.BackColor = System.Drawing.Color.White
        Me.cmdBtn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn9.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn9.Location = New System.Drawing.Point(208, 303)
        Me.cmdBtn9.Name = "cmdBtn9"
        Me.cmdBtn9.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn9.TabIndex = 1
        Me.cmdBtn9.Text = "9"
        Me.cmdBtn9.UseVisualStyleBackColor = False
        '
        'cmdBtn0
        '
        Me.cmdBtn0.BackColor = System.Drawing.Color.White
        Me.cmdBtn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBtn0.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.cmdBtn0.Location = New System.Drawing.Point(117, 394)
        Me.cmdBtn0.Name = "cmdBtn0"
        Me.cmdBtn0.Size = New System.Drawing.Size(85, 85)
        Me.cmdBtn0.TabIndex = 1
        Me.cmdBtn0.Text = "0"
        Me.cmdBtn0.UseVisualStyleBackColor = False
        '
        'pointBtn
        '
        Me.pointBtn.BackColor = System.Drawing.Color.Tomato
        Me.pointBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pointBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.pointBtn.Location = New System.Drawing.Point(26, 394)
        Me.pointBtn.Name = "pointBtn"
        Me.pointBtn.Size = New System.Drawing.Size(85, 85)
        Me.pointBtn.TabIndex = 11
        Me.pointBtn.Text = "."
        Me.pointBtn.UseVisualStyleBackColor = False
        '
        'resetBtn
        '
        Me.resetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.resetBtn.Location = New System.Drawing.Point(299, 394)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(85, 85)
        Me.resetBtn.TabIndex = 12
        Me.resetBtn.Text = "c"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'plusBtn
        '
        Me.plusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plusBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.plusBtn.Location = New System.Drawing.Point(390, 121)
        Me.plusBtn.Name = "plusBtn"
        Me.plusBtn.Size = New System.Drawing.Size(85, 85)
        Me.plusBtn.TabIndex = 13
        Me.plusBtn.Text = "+"
        Me.plusBtn.UseVisualStyleBackColor = False
        '
        'minusBtn
        '
        Me.minusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minusBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.minusBtn.Location = New System.Drawing.Point(481, 121)
        Me.minusBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.minusBtn.Name = "minusBtn"
        Me.minusBtn.Size = New System.Drawing.Size(85, 85)
        Me.minusBtn.TabIndex = 14
        Me.minusBtn.Text = "-"
        Me.minusBtn.UseVisualStyleBackColor = False
        '
        'multiplyBtn
        '
        Me.multiplyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.multiplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.multiplyBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.multiplyBtn.Location = New System.Drawing.Point(390, 212)
        Me.multiplyBtn.Name = "multiplyBtn"
        Me.multiplyBtn.Size = New System.Drawing.Size(85, 85)
        Me.multiplyBtn.TabIndex = 15
        Me.multiplyBtn.Text = "*"
        Me.multiplyBtn.UseVisualStyleBackColor = False
        '
        'divideBtn
        '
        Me.divideBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.divideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divideBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.divideBtn.Location = New System.Drawing.Point(481, 212)
        Me.divideBtn.Name = "divideBtn"
        Me.divideBtn.Size = New System.Drawing.Size(85, 85)
        Me.divideBtn.TabIndex = 16
        Me.divideBtn.Text = "÷"
        Me.divideBtn.UseVisualStyleBackColor = False
        '
        'equalBtn
        '
        Me.equalBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equalBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.equalBtn.Location = New System.Drawing.Point(390, 394)
        Me.equalBtn.Name = "equalBtn"
        Me.equalBtn.Size = New System.Drawing.Size(176, 85)
        Me.equalBtn.TabIndex = 1
        Me.equalBtn.Text = "="
        Me.equalBtn.UseVisualStyleBackColor = False
        '
        'ResultBox
        '
        Me.ResultBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestBindingSource, "test_val", True))
        Me.ResultBox.Font = New System.Drawing.Font("굴림", 40.0!)
        Me.ResultBox.Location = New System.Drawing.Point(26, 46)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(540, 69)
        Me.ResultBox.TabIndex = 18
        Me.ResultBox.Text = "0"
        Me.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "Test"
        Me.TestBindingSource.DataSource = Me.CalcTestDataSet
        '
        'CalcTestDataSet
        '
        Me.CalcTestDataSet.DataSetName = "calcTestDataSet"
        Me.CalcTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'eraseBtn
        '
        Me.eraseBtn.BackColor = System.Drawing.Color.Tomato
        Me.eraseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eraseBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.eraseBtn.Location = New System.Drawing.Point(208, 394)
        Me.eraseBtn.Name = "eraseBtn"
        Me.eraseBtn.Size = New System.Drawing.Size(85, 85)
        Me.eraseBtn.TabIndex = 21
        Me.eraseBtn.Text = "←"
        Me.eraseBtn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("맑은 고딕", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.메뉴ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(973, 29)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '메뉴ToolStripMenuItem
        '
        Me.메뉴ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.일반ToolStripMenuItem, Me.AvgToolStripMenuItem})
        Me.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem"
        Me.메뉴ToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.메뉴ToolStripMenuItem.Text = "메뉴"
        '
        '일반ToolStripMenuItem
        '
        Me.일반ToolStripMenuItem.Name = "일반ToolStripMenuItem"
        Me.일반ToolStripMenuItem.Size = New System.Drawing.Size(112, 26)
        Me.일반ToolStripMenuItem.Text = "일반"
        '
        'AvgToolStripMenuItem
        '
        Me.AvgToolStripMenuItem.Name = "AvgToolStripMenuItem"
        Me.AvgToolStripMenuItem.Size = New System.Drawing.Size(112, 26)
        Me.AvgToolStripMenuItem.Text = "avg"
        '
        'leftBtn
        '
        Me.leftBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.leftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.leftBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.leftBtn.Location = New System.Drawing.Point(390, 303)
        Me.leftBtn.Name = "leftBtn"
        Me.leftBtn.Size = New System.Drawing.Size(85, 85)
        Me.leftBtn.TabIndex = 15
        Me.leftBtn.Text = "("
        Me.leftBtn.UseVisualStyleBackColor = False
        '
        'rightBtn
        '
        Me.rightBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rightBtn.Font = New System.Drawing.Font("굴림", 30.0!)
        Me.rightBtn.Location = New System.Drawing.Point(481, 303)
        Me.rightBtn.Name = "rightBtn"
        Me.rightBtn.Size = New System.Drawing.Size(85, 85)
        Me.rightBtn.TabIndex = 16
        Me.rightBtn.Text = ")"
        Me.rightBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 24
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(610, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(325, 216)
        Me.DataGridView1.TabIndex = 25
        '
        'delBtn
        '
        Me.delBtn.BackColor = System.Drawing.Color.Red
        Me.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delBtn.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.delBtn.Location = New System.Drawing.Point(857, 268)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(78, 39)
        Me.delBtn.TabIndex = 26
        Me.delBtn.Text = "삭제"
        Me.delBtn.UseVisualStyleBackColor = False
        '
        '계산기
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(973, 493)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rightBtn)
        Me.Controls.Add(Me.leftBtn)
        Me.Controls.Add(Me.eraseBtn)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.equalBtn)
        Me.Controls.Add(Me.divideBtn)
        Me.Controls.Add(Me.multiplyBtn)
        Me.Controls.Add(Me.minusBtn)
        Me.Controls.Add(Me.plusBtn)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.pointBtn)
        Me.Controls.Add(Me.cmdBtn0)
        Me.Controls.Add(Me.cmdBtn9)
        Me.Controls.Add(Me.cmdBtn8)
        Me.Controls.Add(Me.cmdBtn7)
        Me.Controls.Add(Me.cmdBtn6)
        Me.Controls.Add(Me.cmdBtn5)
        Me.Controls.Add(Me.cmdBtn4)
        Me.Controls.Add(Me.cmdBtn3)
        Me.Controls.Add(Me.cmdBtn2)
        Me.Controls.Add(Me.cmdBtn1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(300, 300)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "계산기"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "계산기"
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBtn1 As Button
    Friend WithEvents cmdBtn2 As Button
    Friend WithEvents cmdBtn3 As Button
    Friend WithEvents cmdBtn4 As Button
    Friend WithEvents cmdBtn5 As Button
    Friend WithEvents cmdBtn6 As Button
    Friend WithEvents cmdBtn7 As Button
    Friend WithEvents cmdBtn8 As Button
    Friend WithEvents cmdBtn9 As Button
    Friend WithEvents cmdBtn0 As Button
    Friend WithEvents pointBtn As Button
    Friend WithEvents plusBtn As Button
    Friend WithEvents minusBtn As Button
    Friend WithEvents multiplyBtn As Button
    Friend WithEvents divideBtn As Button
    Friend WithEvents equalBtn As Button
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents resetBtn As Button
    Friend WithEvents eraseBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 메뉴ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 일반ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents leftBtn As Button
    Friend WithEvents rightBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CalcTestDataSet As calcTestDataSet
    Friend WithEvents TestBindingSource As BindingSource
    Friend WithEvents TestTableAdapter As calcTestDataSetTableAdapters.TestTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents delBtn As Button
End Class
