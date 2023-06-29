<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpVeriPaketiNot = New System.Windows.Forms.GroupBox()
        Me.lblVeriPaketiNot = New System.Windows.Forms.Label()
        Me.grpVeriGorevYuku = New System.Windows.Forms.GroupBox()
        Me.lblGorevYukuVeriPaketi = New System.Windows.Forms.Label()
        Me.grpVeriRoket = New System.Windows.Forms.GroupBox()
        Me.lblRoketVeriPaketi = New System.Windows.Forms.Label()
        Me.ptAeronist1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ptAeronist = New System.Windows.Forms.PictureBox()
        Me.lblSurumGecmisi = New System.Windows.Forms.Label()
        Me.lblSurumler = New System.Windows.Forms.Label()
        Me.ptAeronist2 = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblGuide = New System.Windows.Forms.Label()
        Me.ptGuide = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpVeriPaketiNot.SuspendLayout()
        Me.grpVeriGorevYuku.SuspendLayout()
        Me.grpVeriRoket.SuspendLayout()
        CType(Me.ptAeronist1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ptAeronist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptAeronist2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptGuide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 437)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpVeriPaketiNot)
        Me.TabPage1.Controls.Add(Me.grpVeriGorevYuku)
        Me.TabPage1.Controls.Add(Me.grpVeriRoket)
        Me.TabPage1.Controls.Add(Me.ptAeronist1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 407)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Veri Paketi Bilgisi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpVeriPaketiNot
        '
        Me.grpVeriPaketiNot.Controls.Add(Me.lblVeriPaketiNot)
        Me.grpVeriPaketiNot.Location = New System.Drawing.Point(6, 186)
        Me.grpVeriPaketiNot.Name = "grpVeriPaketiNot"
        Me.grpVeriPaketiNot.Size = New System.Drawing.Size(740, 89)
        Me.grpVeriPaketiNot.TabIndex = 12
        Me.grpVeriPaketiNot.TabStop = False
        Me.grpVeriPaketiNot.Text = "Arayüz v2'den Önemli Bilgilendirme"
        '
        'lblVeriPaketiNot
        '
        Me.lblVeriPaketiNot.AutoSize = True
        Me.lblVeriPaketiNot.Location = New System.Drawing.Point(7, 34)
        Me.lblVeriPaketiNot.Name = "lblVeriPaketiNot"
        Me.lblVeriPaketiNot.Size = New System.Drawing.Size(706, 34)
        Me.lblVeriPaketiNot.TabIndex = 0
        Me.lblVeriPaketiNot.Text = resources.GetString("lblVeriPaketiNot.Text")
        '
        'grpVeriGorevYuku
        '
        Me.grpVeriGorevYuku.Controls.Add(Me.lblGorevYukuVeriPaketi)
        Me.grpVeriGorevYuku.Location = New System.Drawing.Point(6, 96)
        Me.grpVeriGorevYuku.Name = "grpVeriGorevYuku"
        Me.grpVeriGorevYuku.Size = New System.Drawing.Size(487, 84)
        Me.grpVeriGorevYuku.TabIndex = 11
        Me.grpVeriGorevYuku.TabStop = False
        Me.grpVeriGorevYuku.Text = "Görev Yükü Veri Paketi"
        '
        'lblGorevYukuVeriPaketi
        '
        Me.lblGorevYukuVeriPaketi.AutoSize = True
        Me.lblGorevYukuVeriPaketi.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblGorevYukuVeriPaketi.Location = New System.Drawing.Point(6, 38)
        Me.lblGorevYukuVeriPaketi.Name = "lblGorevYukuVeriPaketi"
        Me.lblGorevYukuVeriPaketi.Size = New System.Drawing.Size(471, 20)
        Me.lblGorevYukuVeriPaketi.TabIndex = 1
        Me.lblGorevYukuVeriPaketi.Text = "<[gpsİrtifa, atmosferikBasınç, sıcaklık, nem, boylam, enlem]crc*>"
        '
        'grpVeriRoket
        '
        Me.grpVeriRoket.Controls.Add(Me.lblRoketVeriPaketi)
        Me.grpVeriRoket.Location = New System.Drawing.Point(6, 6)
        Me.grpVeriRoket.Name = "grpVeriRoket"
        Me.grpVeriRoket.Size = New System.Drawing.Size(487, 84)
        Me.grpVeriRoket.TabIndex = 10
        Me.grpVeriRoket.TabStop = False
        Me.grpVeriRoket.Text = "Roket Veri Paketi"
        '
        'lblRoketVeriPaketi
        '
        Me.lblRoketVeriPaketi.AutoSize = True
        Me.lblRoketVeriPaketi.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblRoketVeriPaketi.Location = New System.Drawing.Point(6, 38)
        Me.lblRoketVeriPaketi.Name = "lblRoketVeriPaketi"
        Me.lblRoketVeriPaketi.Size = New System.Drawing.Size(421, 20)
        Me.lblRoketVeriPaketi.TabIndex = 0
        Me.lblRoketVeriPaketi.Text = "<[gpsİrtifa, dikeyHız, roll, pitch, irtifa, boylam, enlem]crc*>"
        '
        'ptAeronist1
        '
        Me.ptAeronist1.BackgroundImage = CType(resources.GetObject("ptAeronist1.BackgroundImage"), System.Drawing.Image)
        Me.ptAeronist1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptAeronist1.Location = New System.Drawing.Point(301, 273)
        Me.ptAeronist1.Name = "ptAeronist1"
        Me.ptAeronist1.Size = New System.Drawing.Size(149, 151)
        Me.ptAeronist1.TabIndex = 9
        Me.ptAeronist1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ptAeronist)
        Me.TabPage2.Controls.Add(Me.lblSurumGecmisi)
        Me.TabPage2.Controls.Add(Me.lblSurumler)
        Me.TabPage2.Controls.Add(Me.ptAeronist2)
        Me.TabPage2.Controls.Add(Me.lblInfo)
        Me.TabPage2.Controls.Add(Me.lblGuide)
        Me.TabPage2.Controls.Add(Me.ptGuide)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(752, 407)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hakkında"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ptAeronist
        '
        Me.ptAeronist.BackgroundImage = CType(resources.GetObject("ptAeronist.BackgroundImage"), System.Drawing.Image)
        Me.ptAeronist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptAeronist.Location = New System.Drawing.Point(373, 12)
        Me.ptAeronist.Name = "ptAeronist"
        Me.ptAeronist.Size = New System.Drawing.Size(212, 43)
        Me.ptAeronist.TabIndex = 11
        Me.ptAeronist.TabStop = False
        '
        'lblSurumGecmisi
        '
        Me.lblSurumGecmisi.AutoSize = True
        Me.lblSurumGecmisi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSurumGecmisi.Location = New System.Drawing.Point(373, 187)
        Me.lblSurumGecmisi.Name = "lblSurumGecmisi"
        Me.lblSurumGecmisi.Size = New System.Drawing.Size(104, 16)
        Me.lblSurumGecmisi.TabIndex = 10
        Me.lblSurumGecmisi.Text = "Sürüm Geçmişi"
        '
        'lblSurumler
        '
        Me.lblSurumler.AutoSize = True
        Me.lblSurumler.Location = New System.Drawing.Point(373, 203)
        Me.lblSurumler.Name = "lblSurumler"
        Me.lblSurumler.Size = New System.Drawing.Size(279, 51)
        Me.lblSurumler.TabIndex = 9
        Me.lblSurumler.Text = "Aeronist Arayüz v1 > 2019 > Mücahid Aydın" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aeronist Arayüz v2 > 2022 > Furkan Coş" &
    "kun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aeronist Arayüz v3 > 2023 > Recep Sağlam" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ptAeronist2
        '
        Me.ptAeronist2.BackgroundImage = CType(resources.GetObject("ptAeronist2.BackgroundImage"), System.Drawing.Image)
        Me.ptAeronist2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptAeronist2.Location = New System.Drawing.Point(301, 273)
        Me.ptAeronist2.Name = "ptAeronist2"
        Me.ptAeronist2.Size = New System.Drawing.Size(149, 151)
        Me.ptAeronist2.TabIndex = 8
        Me.ptAeronist2.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(373, 124)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(230, 34)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "Son Güncelleme :: 15.06.23 @ 15:40" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recep Sağlam"
        '
        'lblGuide
        '
        Me.lblGuide.AutoSize = True
        Me.lblGuide.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblGuide.Location = New System.Drawing.Point(369, 46)
        Me.lblGuide.Name = "lblGuide"
        Me.lblGuide.Size = New System.Drawing.Size(216, 78)
        Me.lblGuide.TabIndex = 1
        Me.lblGuide.Text = "Yer İstasyonu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Arayüzü"
        '
        'ptGuide
        '
        Me.ptGuide.BackgroundImage = CType(resources.GetObject("ptGuide.BackgroundImage"), System.Drawing.Image)
        Me.ptGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptGuide.Location = New System.Drawing.Point(130, 16)
        Me.ptGuide.Name = "ptGuide"
        Me.ptGuide.Size = New System.Drawing.Size(237, 238)
        Me.ptGuide.TabIndex = 0
        Me.ptGuide.TabStop = False
        '
        'SettingsForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SettingsForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arayüz Bilgilendirme"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpVeriPaketiNot.ResumeLayout(False)
        Me.grpVeriPaketiNot.PerformLayout()
        Me.grpVeriGorevYuku.ResumeLayout(False)
        Me.grpVeriGorevYuku.PerformLayout()
        Me.grpVeriRoket.ResumeLayout(False)
        Me.grpVeriRoket.PerformLayout()
        CType(Me.ptAeronist1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ptAeronist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptAeronist2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptGuide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblGuide As Label
    Friend WithEvents ptGuide As PictureBox
    Friend WithEvents ptAeronist2 As PictureBox
    Friend WithEvents ptAeronist1 As PictureBox
    Friend WithEvents grpVeriGorevYuku As GroupBox
    Friend WithEvents grpVeriRoket As GroupBox
    Friend WithEvents lblGorevYukuVeriPaketi As Label
    Friend WithEvents lblRoketVeriPaketi As Label
    Friend WithEvents grpVeriPaketiNot As GroupBox
    Friend WithEvents lblVeriPaketiNot As Label
    Friend WithEvents lblSurumGecmisi As Label
    Friend WithEvents lblSurumler As Label
    Friend WithEvents ptAeronist As PictureBox
End Class
