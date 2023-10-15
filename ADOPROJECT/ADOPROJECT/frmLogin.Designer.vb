<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.txtPW = New DevExpress.XtraEditors.TextEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPW.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(124, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Size = New System.Drawing.Size(100, 30)
        Me.txtID.TabIndex = 0
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(124, 63)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.txtPW.Properties.Appearance.Options.UseFont = True
        Me.txtPW.Size = New System.Drawing.Size(100, 30)
        Me.txtPW.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(230, 23)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(54, 30)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "확인(D)"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(230, 63)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(54, 30)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "취소(C)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("한컴 고딕", 15.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 26)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "사원번호 : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("한컴 고딕", 15.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(60, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 26)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "암호 : "
        '
        'frmLogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 122)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtID)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "로그인"
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPW.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPW As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
