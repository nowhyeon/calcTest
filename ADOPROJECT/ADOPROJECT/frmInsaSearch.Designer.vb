<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsaSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsaSearch))
        Me.avDetail = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cboJik = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDept = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtSabun = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.avDetail2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSajin = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.avDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboJik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSabun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.avDetail2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'avDetail
        '
        Me.avDetail.Location = New System.Drawing.Point(1170, 12)
        Me.avDetail.MainView = Me.GridView1
        Me.avDetail.Name = "avDetail"
        Me.avDetail.Size = New System.Drawing.Size(321, 168)
        Me.avDetail.TabIndex = 0
        Me.avDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.avDetail.Visible = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.avDetail
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.AutoZoomDetail = True
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnPrint)
        Me.GroupControl1.Controls.Add(Me.cboJik)
        Me.GroupControl1.Controls.Add(Me.cboDept)
        Me.GroupControl1.Controls.Add(Me.txtName)
        Me.GroupControl1.Controls.Add(Me.txtSabun)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnFind)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(569, 106)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "검색조건"
        '
        'btnPrint
        '
        Me.btnPrint.Appearance.Font = New System.Drawing.Font("한컴 고딕", 9.749999!)
        Me.btnPrint.Appearance.Options.UseFont = True
        Me.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.btnPrint.ImageOptions.SvgImage = CType(resources.GetObject("btnPrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnPrint.Location = New System.Drawing.Point(492, 29)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(64, 64)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "프린트"
        '
        'cboJik
        '
        Me.cboJik.Location = New System.Drawing.Point(257, 63)
        Me.cboJik.Name = "cboJik"
        Me.cboJik.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.cboJik.Properties.Appearance.Options.UseFont = True
        Me.cboJik.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboJik.Size = New System.Drawing.Size(159, 30)
        Me.cboJik.TabIndex = 8
        '
        'cboDept
        '
        Me.cboDept.Location = New System.Drawing.Point(257, 30)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.cboDept.Properties.Appearance.Options.UseFont = True
        Me.cboDept.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDept.Size = New System.Drawing.Size(159, 30)
        Me.cboDept.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(74, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Size = New System.Drawing.Size(114, 30)
        Me.txtName.TabIndex = 6
        '
        'txtSabun
        '
        Me.txtSabun.Location = New System.Drawing.Point(74, 29)
        Me.txtSabun.Name = "txtSabun"
        Me.txtSabun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.txtSabun.Properties.Appearance.Options.UseFont = True
        Me.txtSabun.Size = New System.Drawing.Size(114, 30)
        Me.txtSabun.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(203, 66)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 24)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "직급 :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(203, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 24)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "부서 :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 24)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "이름 :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 24)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "사번 :"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("한컴 고딕", 9.749999!)
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.btnFind.ImageOptions.SvgImage = CType(resources.GetObject("btnFind.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnFind.Location = New System.Drawing.Point(422, 29)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(64, 64)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "조회"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("한컴 고딕", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Location = New System.Drawing.Point(155, 28)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 68)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "저장"
        '
        'btnDelete
        '
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("한컴 고딕", 9.749999!)
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.btnDelete.ImageOptions.SvgImage = CType(resources.GetObject("btnDelete.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnDelete.Location = New System.Drawing.Point(85, 28)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 68)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "삭제"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("한컴 고딕", 9.749999!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.btnAdd.ImageOptions.SvgImage = CType(resources.GetObject("btnAdd.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnAdd.Location = New System.Drawing.Point(15, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 68)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "행추가"
        '
        'avDetail2
        '
        Me.avDetail2.Location = New System.Drawing.Point(12, 214)
        Me.avDetail2.MainView = Me.GridView2
        Me.avDetail2.Name = "avDetail2"
        Me.avDetail2.Size = New System.Drawing.Size(1077, 318)
        Me.avDetail2.TabIndex = 2
        Me.avDetail2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.avDetail2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.AutoZoomDetail = True
        Me.GridView2.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnAdd)
        Me.GroupControl2.Controls.Add(Me.btnDelete)
        Me.GroupControl2.Controls.Add(Me.btnSave)
        Me.GroupControl2.Location = New System.Drawing.Point(587, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(237, 106)
        Me.GroupControl2.TabIndex = 14
        Me.GroupControl2.Text = "행편집"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(849, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(106, 106)
        Me.PictureEdit1.TabIndex = 15
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1019, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(52, 105)
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "SimpleButton1"
        Me.SimpleButton1.Visible = False
        '
        'btnSajin
        '
        Me.btnSajin.Appearance.Font = New System.Drawing.Font("한컴 고딕", 9.0!)
        Me.btnSajin.Appearance.Options.UseFont = True
        Me.btnSajin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter
        Me.btnSajin.ImageOptions.SvgImage = CType(resources.GetObject("btnSajin.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSajin.Location = New System.Drawing.Point(961, 13)
        Me.btnSajin.Name = "btnSajin"
        Me.btnSajin.Size = New System.Drawing.Size(52, 105)
        Me.btnSajin.TabIndex = 17
        Me.btnSajin.Text = "사진찾기"
        '
        'frmInsaSearch
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1508, 996)
        Me.Controls.Add(Me.btnSajin)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.avDetail2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.avDetail)
        Me.Name = "frmInsaSearch"
        Me.Text = "직원정보조회"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.avDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboJik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSabun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.avDetail2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents avDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboJik As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboDept As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSabun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents avDetail2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSajin As DevExpress.XtraEditors.SimpleButton
End Class
