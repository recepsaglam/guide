<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MapForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MapForm1))
        Me.map = New GMap.NET.WindowsForms.GMapControl()
        Me.pnlKonum = New System.Windows.Forms.Panel()
        Me.btnKonumYenile = New System.Windows.Forms.Button()
        Me.lblKonumBilgisi = New System.Windows.Forms.Label()
        Me.txtGorevYukuKonum = New System.Windows.Forms.RichTextBox()
        Me.txtRoketKonum = New System.Windows.Forms.RichTextBox()
        Me.pnlUzaklik = New System.Windows.Forms.Panel()
        Me.lblOlcBG = New System.Windows.Forms.Label()
        Me.lblOlcBr = New System.Windows.Forms.Label()
        Me.btnUzaklıkOlc = New System.Windows.Forms.Button()
        Me.strBaslangicBoylam = New System.Windows.Forms.TextBox()
        Me.strBaslangicEnlem = New System.Windows.Forms.TextBox()
        Me.lblUzaklık = New System.Windows.Forms.Label()
        Me.pnlKonum.SuspendLayout()
        Me.pnlUzaklik.SuspendLayout()
        Me.SuspendLayout()
        '
        'map
        '
        Me.map.BackColor = System.Drawing.Color.White
        Me.map.Bearing = 0!
        Me.map.CanDragMap = True
        Me.map.EmptyTileColor = System.Drawing.Color.Navy
        Me.map.GrayScaleMode = False
        Me.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.map.LevelsKeepInMemory = 5
        Me.map.Location = New System.Drawing.Point(-3, -13)
        Me.map.MarkersEnabled = True
        Me.map.MaxZoom = 20
        Me.map.MinZoom = 3
        Me.map.MouseWheelZoomEnabled = True
        Me.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.map.Name = "map"
        Me.map.NegativeMode = False
        Me.map.PolygonsEnabled = True
        Me.map.RetryLoadTile = 0
        Me.map.RoutesEnabled = True
        Me.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.map.ShowTileGridLines = False
        Me.map.Size = New System.Drawing.Size(1071, 606)
        Me.map.TabIndex = 0
        Me.map.Zoom = 14.0R
        '
        'pnlKonum
        '
        Me.pnlKonum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKonum.Controls.Add(Me.btnKonumYenile)
        Me.pnlKonum.Controls.Add(Me.lblKonumBilgisi)
        Me.pnlKonum.Controls.Add(Me.txtGorevYukuKonum)
        Me.pnlKonum.Controls.Add(Me.txtRoketKonum)
        Me.pnlKonum.Location = New System.Drawing.Point(877, 12)
        Me.pnlKonum.Name = "pnlKonum"
        Me.pnlKonum.Size = New System.Drawing.Size(178, 150)
        Me.pnlKonum.TabIndex = 3
        '
        'btnKonumYenile
        '
        Me.btnKonumYenile.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnKonumYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonumYenile.Location = New System.Drawing.Point(102, 3)
        Me.btnKonumYenile.Name = "btnKonumYenile"
        Me.btnKonumYenile.Size = New System.Drawing.Size(71, 25)
        Me.btnKonumYenile.TabIndex = 5
        Me.btnKonumYenile.Text = "Yenile"
        Me.btnKonumYenile.UseVisualStyleBackColor = True
        '
        'lblKonumBilgisi
        '
        Me.lblKonumBilgisi.AutoSize = True
        Me.lblKonumBilgisi.Location = New System.Drawing.Point(5, 7)
        Me.lblKonumBilgisi.Name = "lblKonumBilgisi"
        Me.lblKonumBilgisi.Size = New System.Drawing.Size(91, 17)
        Me.lblKonumBilgisi.TabIndex = 4
        Me.lblKonumBilgisi.Text = "Konum Bilgisi"
        Me.lblKonumBilgisi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtGorevYukuKonum
        '
        Me.txtGorevYukuKonum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGorevYukuKonum.DetectUrls = False
        Me.txtGorevYukuKonum.ForeColor = System.Drawing.Color.Blue
        Me.txtGorevYukuKonum.HideSelection = False
        Me.txtGorevYukuKonum.Location = New System.Drawing.Point(4, 89)
        Me.txtGorevYukuKonum.Name = "txtGorevYukuKonum"
        Me.txtGorevYukuKonum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal
        Me.txtGorevYukuKonum.Size = New System.Drawing.Size(169, 56)
        Me.txtGorevYukuKonum.TabIndex = 5
        Me.txtGorevYukuKonum.Text = "Görev Yükü :" & Global.Microsoft.VisualBasic.ChrW(10) & "      Enlem > " & Global.Microsoft.VisualBasic.ChrW(10) & "    Boylam > "
        '
        'txtRoketKonum
        '
        Me.txtRoketKonum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoketKonum.DetectUrls = False
        Me.txtRoketKonum.ForeColor = System.Drawing.Color.Red
        Me.txtRoketKonum.HideSelection = False
        Me.txtRoketKonum.Location = New System.Drawing.Point(4, 27)
        Me.txtRoketKonum.Name = "txtRoketKonum"
        Me.txtRoketKonum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal
        Me.txtRoketKonum.Size = New System.Drawing.Size(169, 56)
        Me.txtRoketKonum.TabIndex = 4
        Me.txtRoketKonum.Text = "Roket :" & Global.Microsoft.VisualBasic.ChrW(10) & "      Enlem >       " & Global.Microsoft.VisualBasic.ChrW(10) & "    Boylam > "
        '
        'pnlUzaklik
        '
        Me.pnlUzaklik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUzaklik.Controls.Add(Me.lblOlcBG)
        Me.pnlUzaklik.Controls.Add(Me.lblOlcBr)
        Me.pnlUzaklik.Controls.Add(Me.btnUzaklıkOlc)
        Me.pnlUzaklik.Controls.Add(Me.strBaslangicBoylam)
        Me.pnlUzaklik.Controls.Add(Me.strBaslangicEnlem)
        Me.pnlUzaklik.Controls.Add(Me.lblUzaklık)
        Me.pnlUzaklik.Location = New System.Drawing.Point(916, 168)
        Me.pnlUzaklik.Name = "pnlUzaklik"
        Me.pnlUzaklik.Size = New System.Drawing.Size(139, 156)
        Me.pnlUzaklik.TabIndex = 6
        '
        'lblOlcBG
        '
        Me.lblOlcBG.AutoSize = True
        Me.lblOlcBG.BackColor = System.Drawing.Color.White
        Me.lblOlcBG.ForeColor = System.Drawing.Color.Blue
        Me.lblOlcBG.Location = New System.Drawing.Point(2, 131)
        Me.lblOlcBG.Name = "lblOlcBG"
        Me.lblOlcBG.Size = New System.Drawing.Size(54, 17)
        Me.lblOlcBG.TabIndex = 11
        Me.lblOlcBG.Text = "B -> G :"
        '
        'lblOlcBr
        '
        Me.lblOlcBr.AutoSize = True
        Me.lblOlcBr.BackColor = System.Drawing.Color.White
        Me.lblOlcBr.ForeColor = System.Drawing.Color.Red
        Me.lblOlcBr.Location = New System.Drawing.Point(2, 114)
        Me.lblOlcBr.Name = "lblOlcBr"
        Me.lblOlcBr.Size = New System.Drawing.Size(51, 17)
        Me.lblOlcBr.TabIndex = 7
        Me.lblOlcBr.Text = "B -> R :"
        '
        'btnUzaklıkOlc
        '
        Me.btnUzaklıkOlc.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnUzaklıkOlc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUzaklıkOlc.Location = New System.Drawing.Point(15, 85)
        Me.btnUzaklıkOlc.Name = "btnUzaklıkOlc"
        Me.btnUzaklıkOlc.Size = New System.Drawing.Size(100, 26)
        Me.btnUzaklıkOlc.TabIndex = 10
        Me.btnUzaklıkOlc.Text = "Uzaklığı Ölç"
        Me.btnUzaklıkOlc.UseVisualStyleBackColor = True
        '
        'strBaslangicBoylam
        '
        Me.strBaslangicBoylam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.strBaslangicBoylam.ForeColor = System.Drawing.Color.Gray
        Me.strBaslangicBoylam.Location = New System.Drawing.Point(7, 56)
        Me.strBaslangicBoylam.MaxLength = 9
        Me.strBaslangicBoylam.Name = "strBaslangicBoylam"
        Me.strBaslangicBoylam.Size = New System.Drawing.Size(122, 23)
        Me.strBaslangicBoylam.TabIndex = 9
        Me.strBaslangicBoylam.Text = "Başlangıç Boylamı"
        Me.strBaslangicBoylam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'strBaslangicEnlem
        '
        Me.strBaslangicEnlem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.strBaslangicEnlem.ForeColor = System.Drawing.Color.Gray
        Me.strBaslangicEnlem.Location = New System.Drawing.Point(7, 27)
        Me.strBaslangicEnlem.MaxLength = 9
        Me.strBaslangicEnlem.Name = "strBaslangicEnlem"
        Me.strBaslangicEnlem.Size = New System.Drawing.Size(122, 23)
        Me.strBaslangicEnlem.TabIndex = 8
        Me.strBaslangicEnlem.Text = "Başlangıç Enlemi"
        Me.strBaslangicEnlem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUzaklık
        '
        Me.lblUzaklık.AutoSize = True
        Me.lblUzaklık.Location = New System.Drawing.Point(16, 7)
        Me.lblUzaklık.Name = "lblUzaklık"
        Me.lblUzaklık.Size = New System.Drawing.Size(106, 17)
        Me.lblUzaklık.TabIndex = 4
        Me.lblUzaklık.Text = "Uzaklık Ölçümü"
        Me.lblUzaklık.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MapForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 588)
        Me.Controls.Add(Me.pnlUzaklik)
        Me.Controls.Add(Me.pnlKonum)
        Me.Controls.Add(Me.map)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MapForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUIDE Konum Arayüzü"
        Me.pnlKonum.ResumeLayout(False)
        Me.pnlKonum.PerformLayout()
        Me.pnlUzaklik.ResumeLayout(False)
        Me.pnlUzaklik.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents map As GMapControl
    Friend WithEvents pnlKonum As Panel
    Friend WithEvents txtRoketKonum As RichTextBox
    Friend WithEvents txtGorevYukuKonum As RichTextBox
    Friend WithEvents lblKonumBilgisi As Label
    Friend WithEvents btnKonumYenile As Button
    Friend WithEvents pnlUzaklik As Panel
    Friend WithEvents lblUzaklık As Label
    Friend WithEvents strBaslangicBoylam As TextBox
    Friend WithEvents strBaslangicEnlem As TextBox
    Friend WithEvents btnUzaklıkOlc As Button
    Friend WithEvents lblOlcBG As Label
    Friend WithEvents lblOlcBr As Label
End Class
