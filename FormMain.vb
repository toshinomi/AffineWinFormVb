Public Class FormMain
    Private m_mousePoint As Point
    Private m_strOpenFileName As String

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        AddHandler lblTitle.MouseDown, AddressOf OnMouseDownLblTitle
        AddHandler lblTitle.MouseMove, AddressOf OnMouseMoveLblTitle
        AddHandler btnFileSelect.Click, AddressOf OnClickBtnFileSelect
        AddHandler btnClose.Click, AddressOf OnClickBtnClose
        AddHandler btnInit.Click, AddressOf OnClickBtnInit
        AddHandler btnGo.Click, AddressOf OnClickBtnGo
        AddHandler textBoxSx.KeyPress, AddressOf OnKeyPressTextBoxSx
        AddHandler textBoxSy.KeyPress, AddressOf OnKeyPressTextBoxSy
    End Sub

    Private Sub OnMouseDownLblTitle(sender As Object, e As MouseEventArgs)
        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then
            m_mousePoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub OnMouseMoveLblTitle(sender As Object, e As MouseEventArgs)
        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then
            Me.Left += e.X - m_mousePoint.X
            Me.Top += e.Y - m_mousePoint.Y
        End If
    End Sub

    Private Sub OnClickBtnFileSelect(sender As Object, e As EventArgs)
        Dim openFileDlg As ComOpenFileDialog = New ComOpenFileDialog()
        openFileDlg.Filter = "JPG|*.jpg|PNG|*.png"
        openFileDlg.Title = "Open the file"
        If (openFileDlg.ShowDialog() = True) Then
            pictureBox.Image = Nothing
            m_strOpenFileName = openFileDlg.FileName
            pictureBox.ImageLocation = m_strOpenFileName
        End If

        Return
    End Sub

    Private Sub OnClickBtnClose(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Close the application ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (result = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub

    Private Sub OnClickBtnInit(sender As Object, e As EventArgs)
        If Not String.IsNullOrWhiteSpace(m_strOpenFileName) Then
            pictureBox.ImageLocation = m_strOpenFileName
        End If
    End Sub

    Private Sub OnClickBtnGo(sender As Object, e As EventArgs)
        If (String.IsNullOrWhiteSpace(m_strOpenFileName)) Then
            Return
        End If

        Dim affineInfo As CAffineInfo = New CAffineInfo()
        If (Not IsEmpty(textBoxTx.Text)) Then
            affineInfo.Translate.Tx = Single.Parse(textBoxTx.Text)
        End If
        If (Not IsEmpty(textBoxTy.Text)) Then
            affineInfo.Translate.Ty = Single.Parse(textBoxTy.Text)
        End If

        If (Not IsEmpty(textBoxSx.Text)) Then
            affineInfo.Scale.Sx = Single.Parse(textBoxSx.Text)
        End If
        If (Not IsEmpty(textBoxSy.Text)) Then
            affineInfo.Scale.Sy = Single.Parse(textBoxSy.Text)
        End If

        If (Not IsEmpty(textBoxRotate.Text)) Then
            affineInfo.Rotate.Angle = Single.Parse(textBoxRotate.Text)
        End If

        pictureBox.Image = Affine(affineInfo)
    End Sub

    Public Function IsEmpty(_str As String) As Boolean
        Dim bIsEmpty As Boolean = False
        If (String.IsNullOrWhiteSpace(_str)) Then
            bIsEmpty = True
        End If

        Return bIsEmpty
    End Function

    Public Function Affine(_affineInfo As CAffineInfo) As Image
        Dim fTx As Single = _affineInfo.Translate.Tx
        Dim fTy As Single = _affineInfo.Translate.Ty
        Dim fSx As Single = _affineInfo.Scale.Sx
        Dim fSy As Single = _affineInfo.Scale.Sy
        Dim fAngle As Single = _affineInfo.Rotate.Angle

        Dim bitmap As Bitmap = New Bitmap(pictureBox.Width, pictureBox.Height)
        Dim graphics As Graphics = Graphics.FromImage(bitmap)

        Dim image As Image = Image.FromFile(m_strOpenFileName)

        graphics.ResetTransform()
        graphics.TranslateTransform(fTx, fTy, System.Drawing.Drawing2D.MatrixOrder.Append)
        graphics.ScaleTransform(fSx, fSy)
        graphics.RotateTransform(fAngle, System.Drawing.Drawing2D.MatrixOrder.Append)
        graphics.DrawImage(image, New Rectangle(0, 0, pictureBox.Width, pictureBox.Height))

        image.Dispose()
        graphics.Dispose()

        Return Bitmap
    End Function

    Private Sub OnKeyPressTextBoxSx(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar = ".") Then
            Dim textbox As TextBox = CType(sender, TextBox)
            If (textbox.TextLength <= 0) Then
                e.Handled = True
                Return
            End If
            If (CountChar(textbox.Text, ".") >= 1) Then
                e.Handled = True
                Return
            End If
        End If
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And Not e.KeyChar = "." And Not e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        Return
    End Sub

    Private Sub OnKeyPressTextBoxSy(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar = ".") Then
            Dim textbox As TextBox = CType(sender, TextBox)
            If (textbox.TextLength <= 0) Then
                e.Handled = True
                Return
            End If
            If (CountChar(textbox.Text, ".") >= 1) Then
                e.Handled = True
                Return
            End If
        End If
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And Not e.KeyChar = "." And Not e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        Return
    End Sub

    Public Function CountChar(_str As String, _strChar As String) As Integer
        Return _str.Length - _str.Replace(_strChar, "").Length
    End Function
End Class

Public Class CAffineInfo
    Private m_translate As CTranslate
    Private m_scale As CScale
    Private m_rotate As CRotate

    Public Property Translate() As CTranslate
        Set(value As CTranslate)
            m_translate = value
        End Set
        Get
            Return m_translate
        End Get
    End Property

    Public Property Scale() As CScale
        Set(value As CScale)
            m_scale = value
        End Set
        Get
            Return m_scale
        End Get
    End Property

    Public Property Rotate() As CRotate
        Set(value As CRotate)
            m_rotate = value
        End Set
        Get
            Return m_rotate
        End Get
    End Property

    Public Sub New()
        m_translate = New CTranslate()
        m_scale = New CScale()
        m_rotate = New CRotate()
    End Sub
End Class

Public Class CTranslate
    Private m_fTx As Single
    Private m_fTy As Single

    Public Property Tx() As Single
        Set(value As Single)
            m_fTx = value
        End Set
        Get
            Return m_fTx
        End Get
    End Property

    Public Property Ty() As Single
        Set(value As Single)
            m_fTy = value
        End Set
        Get
            Return m_fTy
        End Get
    End Property

    Public Sub New()
        m_fTx = 0.0F
        m_fTy = 0.0F
    End Sub
End Class

Public Class CScale
    Private m_fSx As Single
    Private m_fSy As Single

    Public Property Sx() As Single
        Set(value As Single)
            If (value > 0) Then
                m_fSx = value
            End If
        End Set
        Get
            Return m_fSx
        End Get
    End Property

    Public Property Sy() As Single
        Set(value As Single)
            If (value > 0) Then
                m_fSy = value
            End If
        End Set
        Get
            Return m_fSy
        End Get
    End Property

    Public Sub New()
        m_fSx = 1.0F
        m_fSy = 1.0F
    End Sub
End Class

Public Class CRotate
    Private m_angle As Single

    Public Property Angle() As Single
        Set(value As Single)
            If (value > 0) Then
                m_angle = value
            End If
        End Set
        Get
            Return m_angle
        End Get
    End Property

    Public Sub New()
        m_angle = 0.0F
    End Sub
End Class
