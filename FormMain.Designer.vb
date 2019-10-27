<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.groupBoxImage = New System.Windows.Forms.GroupBox()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.textBoxRotate = New System.Windows.Forms.TextBox()
        Me.groupBoxRotate = New System.Windows.Forms.GroupBox()
        Me.lblSx = New System.Windows.Forms.Label()
        Me.textBoxSy = New System.Windows.Forms.TextBox()
        Me.textBoxSx = New System.Windows.Forms.TextBox()
        Me.lblTy = New System.Windows.Forms.Label()
        Me.lblTx = New System.Windows.Forms.Label()
        Me.textBoxTy = New System.Windows.Forms.TextBox()
        Me.lblSy = New System.Windows.Forms.Label()
        Me.textBoxTx = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.groupBoxTranslate = New System.Windows.Forms.GroupBox()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.groupBoxAffine = New System.Windows.Forms.GroupBox()
        Me.groupBoxScale = New System.Windows.Forms.GroupBox()
        Me.groupBoxOperation = New System.Windows.Forms.GroupBox()
        Me.groupBoxImage.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxRotate.SuspendLayout()
        Me.groupBoxTranslate.SuspendLayout()
        Me.groupBoxAffine.SuspendLayout()
        Me.groupBoxScale.SuspendLayout()
        Me.groupBoxOperation.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(1, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(847, 29)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Affine"
        '
        'groupBoxImage
        '
        Me.groupBoxImage.Controls.Add(Me.pictureBox)
        Me.groupBoxImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBoxImage.Location = New System.Drawing.Point(266, 35)
        Me.groupBoxImage.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxImage.Name = "groupBoxImage"
        Me.groupBoxImage.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxImage.Size = New System.Drawing.Size(568, 578)
        Me.groupBoxImage.TabIndex = 6
        Me.groupBoxImage.TabStop = False
        Me.groupBoxImage.Text = "Image"
        '
        'pictureBox
        '
        Me.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox.Location = New System.Drawing.Point(8, 23)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(550, 539)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox.TabIndex = 3
        Me.pictureBox.TabStop = False
        '
        'textBoxRotate
        '
        Me.textBoxRotate.BackColor = System.Drawing.Color.White
        Me.textBoxRotate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxRotate.Location = New System.Drawing.Point(30, 36)
        Me.textBoxRotate.Name = "textBoxRotate"
        Me.textBoxRotate.Size = New System.Drawing.Size(92, 20)
        Me.textBoxRotate.TabIndex = 8
        Me.textBoxRotate.Text = "0"
        Me.textBoxRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'groupBoxRotate
        '
        Me.groupBoxRotate.Controls.Add(Me.textBoxRotate)
        Me.groupBoxRotate.Location = New System.Drawing.Point(18, 211)
        Me.groupBoxRotate.Name = "groupBoxRotate"
        Me.groupBoxRotate.Size = New System.Drawing.Size(147, 90)
        Me.groupBoxRotate.TabIndex = 7
        Me.groupBoxRotate.TabStop = False
        Me.groupBoxRotate.Text = "Rotate"
        '
        'lblSx
        '
        Me.lblSx.Location = New System.Drawing.Point(5, 22)
        Me.lblSx.Name = "lblSx"
        Me.lblSx.Size = New System.Drawing.Size(21, 23)
        Me.lblSx.TabIndex = 8
        Me.lblSx.Text = "X"
        '
        'textBoxSy
        '
        Me.textBoxSy.BackColor = System.Drawing.Color.White
        Me.textBoxSy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSy.Location = New System.Drawing.Point(30, 48)
        Me.textBoxSy.Name = "textBoxSy"
        Me.textBoxSy.Size = New System.Drawing.Size(92, 20)
        Me.textBoxSy.TabIndex = 7
        Me.textBoxSy.Text = "1"
        Me.textBoxSy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textBoxSx
        '
        Me.textBoxSx.BackColor = System.Drawing.Color.White
        Me.textBoxSx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSx.Location = New System.Drawing.Point(30, 22)
        Me.textBoxSx.Name = "textBoxSx"
        Me.textBoxSx.Size = New System.Drawing.Size(92, 20)
        Me.textBoxSx.TabIndex = 6
        Me.textBoxSx.Text = "1"
        Me.textBoxSx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTy
        '
        Me.lblTy.Location = New System.Drawing.Point(5, 48)
        Me.lblTy.Name = "lblTy"
        Me.lblTy.Size = New System.Drawing.Size(21, 20)
        Me.lblTy.TabIndex = 7
        Me.lblTy.Text = "Y"
        '
        'lblTx
        '
        Me.lblTx.Location = New System.Drawing.Point(5, 22)
        Me.lblTx.Name = "lblTx"
        Me.lblTx.Size = New System.Drawing.Size(21, 23)
        Me.lblTx.TabIndex = 6
        Me.lblTx.Text = "X"
        '
        'textBoxTy
        '
        Me.textBoxTy.BackColor = System.Drawing.Color.White
        Me.textBoxTy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxTy.Location = New System.Drawing.Point(30, 48)
        Me.textBoxTy.Name = "textBoxTy"
        Me.textBoxTy.Size = New System.Drawing.Size(92, 20)
        Me.textBoxTy.TabIndex = 5
        Me.textBoxTy.Text = "0"
        Me.textBoxTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSy
        '
        Me.lblSy.Location = New System.Drawing.Point(5, 48)
        Me.lblSy.Name = "lblSy"
        Me.lblSy.Size = New System.Drawing.Size(21, 23)
        Me.lblSy.TabIndex = 9
        Me.lblSy.Text = "Y"
        '
        'textBoxTx
        '
        Me.textBoxTx.BackColor = System.Drawing.Color.White
        Me.textBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxTx.Location = New System.Drawing.Point(30, 22)
        Me.textBoxTx.Name = "textBoxTx"
        Me.textBoxTx.Size = New System.Drawing.Size(92, 20)
        Me.textBoxTx.TabIndex = 4
        Me.textBoxTx.Text = "0"
        Me.textBoxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGo
        '
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(49, 309)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(92, 37)
        Me.btnGo.TabIndex = 9
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'groupBoxTranslate
        '
        Me.groupBoxTranslate.Controls.Add(Me.lblTy)
        Me.groupBoxTranslate.Controls.Add(Me.lblTx)
        Me.groupBoxTranslate.Controls.Add(Me.textBoxTy)
        Me.groupBoxTranslate.Controls.Add(Me.textBoxTx)
        Me.groupBoxTranslate.Location = New System.Drawing.Point(18, 21)
        Me.groupBoxTranslate.Name = "groupBoxTranslate"
        Me.groupBoxTranslate.Size = New System.Drawing.Size(147, 90)
        Me.groupBoxTranslate.TabIndex = 5
        Me.groupBoxTranslate.TabStop = False
        Me.groupBoxTranslate.Text = "Translate"
        '
        'btnInit
        '
        Me.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInit.Location = New System.Drawing.Point(43, 85)
        Me.btnInit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(150, 50)
        Me.btnInit.TabIndex = 2
        Me.btnInit.Text = "Init"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(43, 145)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 50)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFileSelect
        '
        Me.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileSelect.Location = New System.Drawing.Point(43, 23)
        Me.btnFileSelect.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(150, 50)
        Me.btnFileSelect.TabIndex = 1
        Me.btnFileSelect.Text = "File Select..."
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'groupBoxAffine
        '
        Me.groupBoxAffine.Controls.Add(Me.btnGo)
        Me.groupBoxAffine.Controls.Add(Me.groupBoxTranslate)
        Me.groupBoxAffine.Controls.Add(Me.groupBoxScale)
        Me.groupBoxAffine.Controls.Add(Me.groupBoxRotate)
        Me.groupBoxAffine.Location = New System.Drawing.Point(24, 203)
        Me.groupBoxAffine.Name = "groupBoxAffine"
        Me.groupBoxAffine.Size = New System.Drawing.Size(183, 359)
        Me.groupBoxAffine.TabIndex = 8
        Me.groupBoxAffine.TabStop = False
        Me.groupBoxAffine.Text = "Affine"
        '
        'groupBoxScale
        '
        Me.groupBoxScale.Controls.Add(Me.lblSy)
        Me.groupBoxScale.Controls.Add(Me.lblSx)
        Me.groupBoxScale.Controls.Add(Me.textBoxSy)
        Me.groupBoxScale.Controls.Add(Me.textBoxSx)
        Me.groupBoxScale.Location = New System.Drawing.Point(18, 115)
        Me.groupBoxScale.Name = "groupBoxScale"
        Me.groupBoxScale.Size = New System.Drawing.Size(147, 90)
        Me.groupBoxScale.TabIndex = 6
        Me.groupBoxScale.TabStop = False
        Me.groupBoxScale.Text = "Scale"
        '
        'groupBoxOperation
        '
        Me.groupBoxOperation.Controls.Add(Me.btnInit)
        Me.groupBoxOperation.Controls.Add(Me.btnClose)
        Me.groupBoxOperation.Controls.Add(Me.btnFileSelect)
        Me.groupBoxOperation.Controls.Add(Me.groupBoxAffine)
        Me.groupBoxOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBoxOperation.Location = New System.Drawing.Point(14, 35)
        Me.groupBoxOperation.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxOperation.Name = "groupBoxOperation"
        Me.groupBoxOperation.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.groupBoxOperation.Size = New System.Drawing.Size(240, 578)
        Me.groupBoxOperation.TabIndex = 5
        Me.groupBoxOperation.TabStop = False
        Me.groupBoxOperation.Text = "Operation"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 625)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.groupBoxImage)
        Me.Controls.Add(Me.groupBoxOperation)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.groupBoxImage.ResumeLayout(False)
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxRotate.ResumeLayout(False)
        Me.groupBoxRotate.PerformLayout()
        Me.groupBoxTranslate.ResumeLayout(False)
        Me.groupBoxTranslate.PerformLayout()
        Me.groupBoxAffine.ResumeLayout(False)
        Me.groupBoxScale.ResumeLayout(False)
        Me.groupBoxScale.PerformLayout()
        Me.groupBoxOperation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents groupBoxImage As GroupBox
    Private WithEvents pictureBox As PictureBox
    Private WithEvents textBoxRotate As TextBox
    Private WithEvents groupBoxRotate As GroupBox
    Private WithEvents lblSx As Label
    Private WithEvents textBoxSy As TextBox
    Private WithEvents textBoxSx As TextBox
    Private WithEvents lblTy As Label
    Private WithEvents lblTx As Label
    Private WithEvents textBoxTy As TextBox
    Private WithEvents lblSy As Label
    Private WithEvents textBoxTx As TextBox
    Private WithEvents btnGo As Button
    Private WithEvents groupBoxTranslate As GroupBox
    Private WithEvents btnInit As Button
    Private WithEvents btnClose As Button
    Private WithEvents btnFileSelect As Button
    Private WithEvents groupBoxAffine As GroupBox
    Private WithEvents groupBoxScale As GroupBox
    Private WithEvents groupBoxOperation As GroupBox
End Class
