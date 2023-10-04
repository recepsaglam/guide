<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series17 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series18 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpRoket = New System.Windows.Forms.GroupBox()
        Me.txtRoketKonum = New System.Windows.Forms.Label()
        Me.txtRoketDikeyHiz = New System.Windows.Forms.Label()
        Me.txtRoketİrtifa = New System.Windows.Forms.Label()
        Me.txtRoketGpsİrtifa = New System.Windows.Forms.Label()
        Me.chrtRoketİrtifa = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grpRoketHam = New System.Windows.Forms.GroupBox()
        Me.ptRoketHorizon = New System.Windows.Forms.PictureBox()
        Me.txtRoketHam = New System.Windows.Forms.RichTextBox()
        Me.txtRoketPitch = New System.Windows.Forms.Label()
        Me.txtRoketRoll = New System.Windows.Forms.Label()
        Me.lblRoketBasarisizVeri = New System.Windows.Forms.Label()
        Me.lblRoketBasariliVeri = New System.Windows.Forms.Label()
        Me.chrtRoketRollPitch = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblRoketGelenVeri = New System.Windows.Forms.Label()
        Me.btnCloseRoketSerialPort = New System.Windows.Forms.Button()
        Me.btnOpenRoketSerialPort = New System.Windows.Forms.Button()
        Me.cmbRoketSerialPort = New System.Windows.Forms.ComboBox()
        Me.chrtRoketHiz = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grpGorevYuku = New System.Windows.Forms.GroupBox()
        Me.txtGorevYukuGpsİrtifa = New System.Windows.Forms.Label()
        Me.chrtGorevYukuİrtifa = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtGorevYukuBasinc = New System.Windows.Forms.Label()
        Me.txtGorevYukuSicaklik = New System.Windows.Forms.Label()
        Me.txtGorevYukuNem = New System.Windows.Forms.Label()
        Me.txtGorevYukuKonum = New System.Windows.Forms.Label()
        Me.lblGorevYukuBasarisizVeri = New System.Windows.Forms.Label()
        Me.lblGorevYukuBasariliVeri = New System.Windows.Forms.Label()
        Me.lblGorevYukuGelenVeri = New System.Windows.Forms.Label()
        Me.grpGorevYukuHam = New System.Windows.Forms.GroupBox()
        Me.txtGorevYukuHam = New System.Windows.Forms.RichTextBox()
        Me.btnCloseGorevYukuSerialPort = New System.Windows.Forms.Button()
        Me.btnOpenGorevYukuSerialPort = New System.Windows.Forms.Button()
        Me.cmbGorevYukuSerialPort = New System.Windows.Forms.ComboBox()
        Me.chrtGorevYukuBasinc = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrtGorevYukuSicaklikNem = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grpHYİ = New System.Windows.Forms.GroupBox()
        Me.btnCloseHYISerialPort = New System.Windows.Forms.Button()
        Me.strInterval = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.strTeamID = New System.Windows.Forms.TextBox()
        Me.cmbHYIBaudRate = New System.Windows.Forms.ComboBox()
        Me.btnOpenHYISerialPort = New System.Windows.Forms.Button()
        Me.cmbHYISerialPort = New System.Windows.Forms.ComboBox()
        Me.roketBgWorker = New System.ComponentModel.BackgroundWorker()
        Me.gorevYukuBgWorker = New System.ComponentModel.BackgroundWorker()
        Me.hyiBgWorker = New System.ComponentModel.BackgroundWorker()
        Me.grpDurum = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtDurum = New System.Windows.Forms.RichTextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GUIDE = New System.Windows.Forms.PictureBox()
        Me.aeronist = New System.Windows.Forms.PictureBox()
        Me.zodyak = New System.Windows.Forms.PictureBox()
        Me.tmrDate = New System.Windows.Forms.Timer(Me.components)
        Me.txtDate = New System.Windows.Forms.Label()
        Me.grpDate = New System.Windows.Forms.GroupBox()
        Me.grpRoket.SuspendLayout()
        CType(Me.chrtRoketİrtifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRoketHam.SuspendLayout()
        CType(Me.ptRoketHorizon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtRoketRollPitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtRoketHiz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGorevYuku.SuspendLayout()
        CType(Me.chrtGorevYukuİrtifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGorevYukuHam.SuspendLayout()
        CType(Me.chrtGorevYukuBasinc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtGorevYukuSicaklikNem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHYİ.SuspendLayout()
        Me.grpDurum.SuspendLayout()
        CType(Me.GUIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aeronist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zodyak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRoket
        '
        Me.grpRoket.Controls.Add(Me.txtRoketKonum)
        Me.grpRoket.Controls.Add(Me.txtRoketDikeyHiz)
        Me.grpRoket.Controls.Add(Me.txtRoketİrtifa)
        Me.grpRoket.Controls.Add(Me.txtRoketGpsİrtifa)
        Me.grpRoket.Controls.Add(Me.chrtRoketİrtifa)
        Me.grpRoket.Controls.Add(Me.grpRoketHam)
        Me.grpRoket.Controls.Add(Me.txtRoketPitch)
        Me.grpRoket.Controls.Add(Me.txtRoketRoll)
        Me.grpRoket.Controls.Add(Me.lblRoketBasarisizVeri)
        Me.grpRoket.Controls.Add(Me.lblRoketBasariliVeri)
        Me.grpRoket.Controls.Add(Me.chrtRoketRollPitch)
        Me.grpRoket.Controls.Add(Me.lblRoketGelenVeri)
        Me.grpRoket.Controls.Add(Me.btnCloseRoketSerialPort)
        Me.grpRoket.Controls.Add(Me.btnOpenRoketSerialPort)
        Me.grpRoket.Controls.Add(Me.cmbRoketSerialPort)
        Me.grpRoket.Controls.Add(Me.chrtRoketHiz)
        Me.grpRoket.Location = New System.Drawing.Point(12, 117)
        Me.grpRoket.Name = "grpRoket"
        Me.grpRoket.Size = New System.Drawing.Size(755, 718)
        Me.grpRoket.TabIndex = 2
        Me.grpRoket.TabStop = False
        Me.grpRoket.Text = "Roket Bağlantı Noktası"
        '
        'txtRoketKonum
        '
        Me.txtRoketKonum.AutoSize = True
        Me.txtRoketKonum.BackColor = System.Drawing.Color.White
        Me.txtRoketKonum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoketKonum.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRoketKonum.ForeColor = System.Drawing.Color.Navy
        Me.txtRoketKonum.Location = New System.Drawing.Point(75, 598)
        Me.txtRoketKonum.Name = "txtRoketKonum"
        Me.txtRoketKonum.Size = New System.Drawing.Size(60, 19)
        Me.txtRoketKonum.TabIndex = 24
        Me.txtRoketKonum.Text = "Konum "
        '
        'txtRoketDikeyHiz
        '
        Me.txtRoketDikeyHiz.AutoSize = True
        Me.txtRoketDikeyHiz.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRoketDikeyHiz.ForeColor = System.Drawing.Color.Blue
        Me.txtRoketDikeyHiz.Location = New System.Drawing.Point(542, 54)
        Me.txtRoketDikeyHiz.Name = "txtRoketDikeyHiz"
        Me.txtRoketDikeyHiz.Size = New System.Drawing.Size(64, 17)
        Me.txtRoketDikeyHiz.TabIndex = 23
        Me.txtRoketDikeyHiz.Text = "Dikey Hız"
        '
        'txtRoketİrtifa
        '
        Me.txtRoketİrtifa.AutoSize = True
        Me.txtRoketİrtifa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRoketİrtifa.ForeColor = System.Drawing.Color.Turquoise
        Me.txtRoketİrtifa.Location = New System.Drawing.Point(115, 76)
        Me.txtRoketİrtifa.Name = "txtRoketİrtifa"
        Me.txtRoketİrtifa.Size = New System.Drawing.Size(36, 17)
        Me.txtRoketİrtifa.TabIndex = 21
        Me.txtRoketİrtifa.Text = "İrtifa"
        '
        'txtRoketGpsİrtifa
        '
        Me.txtRoketGpsİrtifa.AutoSize = True
        Me.txtRoketGpsİrtifa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRoketGpsİrtifa.ForeColor = System.Drawing.Color.Green
        Me.txtRoketGpsİrtifa.Location = New System.Drawing.Point(263, 76)
        Me.txtRoketGpsİrtifa.Name = "txtRoketGpsİrtifa"
        Me.txtRoketGpsİrtifa.Size = New System.Drawing.Size(65, 17)
        Me.txtRoketGpsİrtifa.TabIndex = 20
        Me.txtRoketGpsİrtifa.Text = "GPS İrtifa"
        '
        'chrtRoketİrtifa
        '
        ChartArea7.Name = "ChartArea1"
        Me.chrtRoketİrtifa.ChartAreas.Add(ChartArea7)
        Me.chrtRoketİrtifa.Location = New System.Drawing.Point(6, 91)
        Me.chrtRoketİrtifa.Name = "chrtRoketİrtifa"
        Me.chrtRoketİrtifa.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series10.Name = "İrtifa"
        Series10.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series11.Name = "GPS İrtifa"
        Me.chrtRoketİrtifa.Series.Add(Series10)
        Me.chrtRoketİrtifa.Series.Add(Series11)
        Me.chrtRoketİrtifa.Size = New System.Drawing.Size(430, 500)
        Me.chrtRoketİrtifa.TabIndex = 32
        Me.chrtRoketİrtifa.Text = "Chart1"
        '
        'grpRoketHam
        '
        Me.grpRoketHam.Controls.Add(Me.ptRoketHorizon)
        Me.grpRoketHam.Controls.Add(Me.txtRoketHam)
        Me.grpRoketHam.Location = New System.Drawing.Point(185, 631)
        Me.grpRoketHam.Name = "grpRoketHam"
        Me.grpRoketHam.Size = New System.Drawing.Size(564, 81)
        Me.grpRoketHam.TabIndex = 19
        Me.grpRoketHam.TabStop = False
        Me.grpRoketHam.Text = "Ham Veri"
        '
        'ptRoketHorizon
        '
        Me.ptRoketHorizon.Location = New System.Drawing.Point(-69, -211)
        Me.ptRoketHorizon.Name = "ptRoketHorizon"
        Me.ptRoketHorizon.Size = New System.Drawing.Size(247, 204)
        Me.ptRoketHorizon.TabIndex = 26
        Me.ptRoketHorizon.TabStop = False
        '
        'txtRoketHam
        '
        Me.txtRoketHam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoketHam.DetectUrls = False
        Me.txtRoketHam.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRoketHam.HideSelection = False
        Me.txtRoketHam.Location = New System.Drawing.Point(6, 16)
        Me.txtRoketHam.Name = "txtRoketHam"
        Me.txtRoketHam.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal
        Me.txtRoketHam.Size = New System.Drawing.Size(552, 59)
        Me.txtRoketHam.TabIndex = 14
        Me.txtRoketHam.Text = ""
        '
        'txtRoketPitch
        '
        Me.txtRoketPitch.AutoSize = True
        Me.txtRoketPitch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRoketPitch.ForeColor = System.Drawing.Color.Red
        Me.txtRoketPitch.Location = New System.Drawing.Point(629, 354)
        Me.txtRoketPitch.Name = "txtRoketPitch"
        Me.txtRoketPitch.Size = New System.Drawing.Size(40, 17)
        Me.txtRoketPitch.TabIndex = 27
        Me.txtRoketPitch.Text = "Pitch"
        '
        'txtRoketRoll
        '
        Me.txtRoketRoll.AutoSize = True
        Me.txtRoketRoll.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtRoketRoll.ForeColor = System.Drawing.Color.Green
        Me.txtRoketRoll.Location = New System.Drawing.Point(508, 354)
        Me.txtRoketRoll.Name = "txtRoketRoll"
        Me.txtRoketRoll.Size = New System.Drawing.Size(31, 17)
        Me.txtRoketRoll.TabIndex = 26
        Me.txtRoketRoll.Text = "Roll"
        '
        'lblRoketBasarisizVeri
        '
        Me.lblRoketBasarisizVeri.AutoSize = True
        Me.lblRoketBasarisizVeri.ForeColor = System.Drawing.Color.Red
        Me.lblRoketBasarisizVeri.Location = New System.Drawing.Point(57, 689)
        Me.lblRoketBasarisizVeri.Name = "lblRoketBasarisizVeri"
        Me.lblRoketBasarisizVeri.Size = New System.Drawing.Size(78, 17)
        Me.lblRoketBasarisizVeri.TabIndex = 31
        Me.lblRoketBasarisizVeri.Text = "Başarısız : 0"
        '
        'lblRoketBasariliVeri
        '
        Me.lblRoketBasariliVeri.AutoSize = True
        Me.lblRoketBasariliVeri.ForeColor = System.Drawing.Color.Green
        Me.lblRoketBasariliVeri.Location = New System.Drawing.Point(57, 672)
        Me.lblRoketBasariliVeri.Name = "lblRoketBasariliVeri"
        Me.lblRoketBasariliVeri.Size = New System.Drawing.Size(70, 17)
        Me.lblRoketBasariliVeri.TabIndex = 30
        Me.lblRoketBasariliVeri.Text = "Başarılı : 0"
        '
        'chrtRoketRollPitch
        '
        ChartArea8.Name = "ChartArea1"
        Me.chrtRoketRollPitch.ChartAreas.Add(ChartArea8)
        Me.chrtRoketRollPitch.Location = New System.Drawing.Point(439, 355)
        Me.chrtRoketRollPitch.Name = "chrtRoketRollPitch"
        Me.chrtRoketRollPitch.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series12.Name = "Roll"
        Series12.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent
        Series13.ChartArea = "ChartArea1"
        Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series13.Name = "Pitch"
        Me.chrtRoketRollPitch.Series.Add(Series12)
        Me.chrtRoketRollPitch.Series.Add(Series13)
        Me.chrtRoketRollPitch.Size = New System.Drawing.Size(310, 270)
        Me.chrtRoketRollPitch.TabIndex = 28
        Me.chrtRoketRollPitch.Text = "Chart1"
        '
        'lblRoketGelenVeri
        '
        Me.lblRoketGelenVeri.AutoSize = True
        Me.lblRoketGelenVeri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblRoketGelenVeri.ForeColor = System.Drawing.Color.Black
        Me.lblRoketGelenVeri.Location = New System.Drawing.Point(46, 655)
        Me.lblRoketGelenVeri.Name = "lblRoketGelenVeri"
        Me.lblRoketGelenVeri.Size = New System.Drawing.Size(74, 17)
        Me.lblRoketGelenVeri.TabIndex = 29
        Me.lblRoketGelenVeri.Text = "Gelen Veri"
        '
        'btnCloseRoketSerialPort
        '
        Me.btnCloseRoketSerialPort.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCloseRoketSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseRoketSerialPort.Location = New System.Drawing.Point(174, 22)
        Me.btnCloseRoketSerialPort.Name = "btnCloseRoketSerialPort"
        Me.btnCloseRoketSerialPort.Size = New System.Drawing.Size(71, 25)
        Me.btnCloseRoketSerialPort.TabIndex = 2
        Me.btnCloseRoketSerialPort.Text = "Kapat"
        Me.btnCloseRoketSerialPort.UseVisualStyleBackColor = True
        '
        'btnOpenRoketSerialPort
        '
        Me.btnOpenRoketSerialPort.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnOpenRoketSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenRoketSerialPort.Location = New System.Drawing.Point(174, 22)
        Me.btnOpenRoketSerialPort.Name = "btnOpenRoketSerialPort"
        Me.btnOpenRoketSerialPort.Size = New System.Drawing.Size(71, 25)
        Me.btnOpenRoketSerialPort.TabIndex = 1
        Me.btnOpenRoketSerialPort.Text = "Aç"
        Me.btnOpenRoketSerialPort.UseVisualStyleBackColor = True
        '
        'cmbRoketSerialPort
        '
        Me.cmbRoketSerialPort.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRoketSerialPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRoketSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbRoketSerialPort.FormattingEnabled = True
        Me.cmbRoketSerialPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbRoketSerialPort.Location = New System.Drawing.Point(6, 22)
        Me.cmbRoketSerialPort.Name = "cmbRoketSerialPort"
        Me.cmbRoketSerialPort.Size = New System.Drawing.Size(162, 25)
        Me.cmbRoketSerialPort.Sorted = True
        Me.cmbRoketSerialPort.TabIndex = 0
        '
        'chrtRoketHiz
        '
        ChartArea9.Name = "ChartArea1"
        Me.chrtRoketHiz.ChartAreas.Add(ChartArea9)
        Me.chrtRoketHiz.Location = New System.Drawing.Point(439, 55)
        Me.chrtRoketHiz.Name = "chrtRoketHiz"
        Me.chrtRoketHiz.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series14.ChartArea = "ChartArea1"
        Series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series14.Name = "Dikey Hız"
        Series14.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent
        Me.chrtRoketHiz.Series.Add(Series14)
        Me.chrtRoketHiz.Size = New System.Drawing.Size(310, 270)
        Me.chrtRoketHiz.TabIndex = 18
        Me.chrtRoketHiz.Text = "Chart1"
        '
        'grpGorevYuku
        '
        Me.grpGorevYuku.Controls.Add(Me.txtGorevYukuGpsİrtifa)
        Me.grpGorevYuku.Controls.Add(Me.chrtGorevYukuİrtifa)
        Me.grpGorevYuku.Controls.Add(Me.txtGorevYukuBasinc)
        Me.grpGorevYuku.Controls.Add(Me.txtGorevYukuSicaklik)
        Me.grpGorevYuku.Controls.Add(Me.txtGorevYukuNem)
        Me.grpGorevYuku.Controls.Add(Me.txtGorevYukuKonum)
        Me.grpGorevYuku.Controls.Add(Me.lblGorevYukuBasarisizVeri)
        Me.grpGorevYuku.Controls.Add(Me.lblGorevYukuBasariliVeri)
        Me.grpGorevYuku.Controls.Add(Me.lblGorevYukuGelenVeri)
        Me.grpGorevYuku.Controls.Add(Me.grpGorevYukuHam)
        Me.grpGorevYuku.Controls.Add(Me.btnCloseGorevYukuSerialPort)
        Me.grpGorevYuku.Controls.Add(Me.btnOpenGorevYukuSerialPort)
        Me.grpGorevYuku.Controls.Add(Me.cmbGorevYukuSerialPort)
        Me.grpGorevYuku.Controls.Add(Me.chrtGorevYukuBasinc)
        Me.grpGorevYuku.Controls.Add(Me.chrtGorevYukuSicaklikNem)
        Me.grpGorevYuku.Location = New System.Drawing.Point(773, 117)
        Me.grpGorevYuku.Name = "grpGorevYuku"
        Me.grpGorevYuku.Size = New System.Drawing.Size(755, 718)
        Me.grpGorevYuku.TabIndex = 3
        Me.grpGorevYuku.TabStop = False
        Me.grpGorevYuku.Text = "Görev Yükü Bağlantı Noktası"
        '
        'txtGorevYukuGpsİrtifa
        '
        Me.txtGorevYukuGpsİrtifa.AutoSize = True
        Me.txtGorevYukuGpsİrtifa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGorevYukuGpsİrtifa.ForeColor = System.Drawing.Color.Turquoise
        Me.txtGorevYukuGpsİrtifa.Location = New System.Drawing.Point(171, 74)
        Me.txtGorevYukuGpsİrtifa.Name = "txtGorevYukuGpsİrtifa"
        Me.txtGorevYukuGpsİrtifa.Size = New System.Drawing.Size(65, 17)
        Me.txtGorevYukuGpsİrtifa.TabIndex = 10
        Me.txtGorevYukuGpsİrtifa.Text = "GPS İrtifa"
        '
        'chrtGorevYukuİrtifa
        '
        ChartArea10.Name = "ChartArea1"
        Me.chrtGorevYukuİrtifa.ChartAreas.Add(ChartArea10)
        Me.chrtGorevYukuİrtifa.Location = New System.Drawing.Point(6, 89)
        Me.chrtGorevYukuİrtifa.Name = "chrtGorevYukuİrtifa"
        Me.chrtGorevYukuİrtifa.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series15.ChartArea = "ChartArea1"
        Series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series15.Name = "GPS İrtifa"
        Me.chrtGorevYukuİrtifa.Series.Add(Series15)
        Me.chrtGorevYukuİrtifa.Size = New System.Drawing.Size(430, 500)
        Me.chrtGorevYukuİrtifa.TabIndex = 33
        Me.chrtGorevYukuİrtifa.Text = "Chart1"
        '
        'txtGorevYukuBasinc
        '
        Me.txtGorevYukuBasinc.AutoSize = True
        Me.txtGorevYukuBasinc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGorevYukuBasinc.ForeColor = System.Drawing.Color.Violet
        Me.txtGorevYukuBasinc.Location = New System.Drawing.Point(523, 354)
        Me.txtGorevYukuBasinc.Name = "txtGorevYukuBasinc"
        Me.txtGorevYukuBasinc.Size = New System.Drawing.Size(119, 17)
        Me.txtGorevYukuBasinc.TabIndex = 13
        Me.txtGorevYukuBasinc.Text = "Atmosferik Basınç"
        '
        'txtGorevYukuSicaklik
        '
        Me.txtGorevYukuSicaklik.AutoSize = True
        Me.txtGorevYukuSicaklik.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGorevYukuSicaklik.ForeColor = System.Drawing.Color.Red
        Me.txtGorevYukuSicaklik.Location = New System.Drawing.Point(599, 54)
        Me.txtGorevYukuSicaklik.Name = "txtGorevYukuSicaklik"
        Me.txtGorevYukuSicaklik.Size = New System.Drawing.Size(54, 17)
        Me.txtGorevYukuSicaklik.TabIndex = 11
        Me.txtGorevYukuSicaklik.Text = "Sıcaklık"
        '
        'txtGorevYukuNem
        '
        Me.txtGorevYukuNem.AutoSize = True
        Me.txtGorevYukuNem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGorevYukuNem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGorevYukuNem.Location = New System.Drawing.Point(494, 54)
        Me.txtGorevYukuNem.Name = "txtGorevYukuNem"
        Me.txtGorevYukuNem.Size = New System.Drawing.Size(39, 17)
        Me.txtGorevYukuNem.TabIndex = 12
        Me.txtGorevYukuNem.Text = "Nem"
        '
        'txtGorevYukuKonum
        '
        Me.txtGorevYukuKonum.AutoSize = True
        Me.txtGorevYukuKonum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGorevYukuKonum.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGorevYukuKonum.ForeColor = System.Drawing.Color.Navy
        Me.txtGorevYukuKonum.Location = New System.Drawing.Point(79, 598)
        Me.txtGorevYukuKonum.Name = "txtGorevYukuKonum"
        Me.txtGorevYukuKonum.Size = New System.Drawing.Size(60, 19)
        Me.txtGorevYukuKonum.TabIndex = 17
        Me.txtGorevYukuKonum.Text = "Konum "
        '
        'lblGorevYukuBasarisizVeri
        '
        Me.lblGorevYukuBasarisizVeri.AutoSize = True
        Me.lblGorevYukuBasarisizVeri.ForeColor = System.Drawing.Color.Red
        Me.lblGorevYukuBasarisizVeri.Location = New System.Drawing.Point(61, 689)
        Me.lblGorevYukuBasarisizVeri.Name = "lblGorevYukuBasarisizVeri"
        Me.lblGorevYukuBasarisizVeri.Size = New System.Drawing.Size(78, 17)
        Me.lblGorevYukuBasarisizVeri.TabIndex = 32
        Me.lblGorevYukuBasarisizVeri.Text = "Başarısız : 0"
        '
        'lblGorevYukuBasariliVeri
        '
        Me.lblGorevYukuBasariliVeri.AutoSize = True
        Me.lblGorevYukuBasariliVeri.ForeColor = System.Drawing.Color.Green
        Me.lblGorevYukuBasariliVeri.Location = New System.Drawing.Point(61, 672)
        Me.lblGorevYukuBasariliVeri.Name = "lblGorevYukuBasariliVeri"
        Me.lblGorevYukuBasariliVeri.Size = New System.Drawing.Size(70, 17)
        Me.lblGorevYukuBasariliVeri.TabIndex = 31
        Me.lblGorevYukuBasariliVeri.Text = "Başarılı : 0"
        '
        'lblGorevYukuGelenVeri
        '
        Me.lblGorevYukuGelenVeri.AutoSize = True
        Me.lblGorevYukuGelenVeri.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblGorevYukuGelenVeri.ForeColor = System.Drawing.Color.Black
        Me.lblGorevYukuGelenVeri.Location = New System.Drawing.Point(51, 655)
        Me.lblGorevYukuGelenVeri.Name = "lblGorevYukuGelenVeri"
        Me.lblGorevYukuGelenVeri.Size = New System.Drawing.Size(74, 17)
        Me.lblGorevYukuGelenVeri.TabIndex = 30
        Me.lblGorevYukuGelenVeri.Text = "Gelen Veri"
        '
        'grpGorevYukuHam
        '
        Me.grpGorevYukuHam.Controls.Add(Me.txtGorevYukuHam)
        Me.grpGorevYukuHam.Location = New System.Drawing.Point(212, 631)
        Me.grpGorevYukuHam.Name = "grpGorevYukuHam"
        Me.grpGorevYukuHam.Size = New System.Drawing.Size(537, 81)
        Me.grpGorevYukuHam.TabIndex = 15
        Me.grpGorevYukuHam.TabStop = False
        Me.grpGorevYukuHam.Text = "Ham Veri"
        '
        'txtGorevYukuHam
        '
        Me.txtGorevYukuHam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGorevYukuHam.DetectUrls = False
        Me.txtGorevYukuHam.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtGorevYukuHam.HideSelection = False
        Me.txtGorevYukuHam.Location = New System.Drawing.Point(6, 16)
        Me.txtGorevYukuHam.Name = "txtGorevYukuHam"
        Me.txtGorevYukuHam.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal
        Me.txtGorevYukuHam.Size = New System.Drawing.Size(525, 59)
        Me.txtGorevYukuHam.TabIndex = 14
        Me.txtGorevYukuHam.Text = ""
        '
        'btnCloseGorevYukuSerialPort
        '
        Me.btnCloseGorevYukuSerialPort.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCloseGorevYukuSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseGorevYukuSerialPort.Location = New System.Drawing.Point(174, 21)
        Me.btnCloseGorevYukuSerialPort.Name = "btnCloseGorevYukuSerialPort"
        Me.btnCloseGorevYukuSerialPort.Size = New System.Drawing.Size(71, 25)
        Me.btnCloseGorevYukuSerialPort.TabIndex = 3
        Me.btnCloseGorevYukuSerialPort.Text = "Kapat"
        Me.btnCloseGorevYukuSerialPort.UseVisualStyleBackColor = True
        '
        'btnOpenGorevYukuSerialPort
        '
        Me.btnOpenGorevYukuSerialPort.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnOpenGorevYukuSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenGorevYukuSerialPort.Location = New System.Drawing.Point(174, 21)
        Me.btnOpenGorevYukuSerialPort.Name = "btnOpenGorevYukuSerialPort"
        Me.btnOpenGorevYukuSerialPort.Size = New System.Drawing.Size(71, 25)
        Me.btnOpenGorevYukuSerialPort.TabIndex = 5
        Me.btnOpenGorevYukuSerialPort.Text = "Aç"
        Me.btnOpenGorevYukuSerialPort.UseVisualStyleBackColor = True
        '
        'cmbGorevYukuSerialPort
        '
        Me.cmbGorevYukuSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbGorevYukuSerialPort.FormattingEnabled = True
        Me.cmbGorevYukuSerialPort.Location = New System.Drawing.Point(6, 21)
        Me.cmbGorevYukuSerialPort.Name = "cmbGorevYukuSerialPort"
        Me.cmbGorevYukuSerialPort.Size = New System.Drawing.Size(162, 25)
        Me.cmbGorevYukuSerialPort.Sorted = True
        Me.cmbGorevYukuSerialPort.TabIndex = 5
        '
        'chrtGorevYukuBasinc
        '
        ChartArea11.Name = "ChartArea1"
        Me.chrtGorevYukuBasinc.ChartAreas.Add(ChartArea11)
        Me.chrtGorevYukuBasinc.Location = New System.Drawing.Point(439, 355)
        Me.chrtGorevYukuBasinc.Name = "chrtGorevYukuBasinc"
        Me.chrtGorevYukuBasinc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series16.ChartArea = "ChartArea1"
        Series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series16.Name = "Basınç"
        Series16.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent
        Me.chrtGorevYukuBasinc.Series.Add(Series16)
        Me.chrtGorevYukuBasinc.Size = New System.Drawing.Size(310, 270)
        Me.chrtGorevYukuBasinc.TabIndex = 9
        Me.chrtGorevYukuBasinc.Text = "Chart1"
        '
        'chrtGorevYukuSicaklikNem
        '
        ChartArea12.Name = "ChartArea1"
        Me.chrtGorevYukuSicaklikNem.ChartAreas.Add(ChartArea12)
        Me.chrtGorevYukuSicaklikNem.Location = New System.Drawing.Point(439, 55)
        Me.chrtGorevYukuSicaklikNem.Name = "chrtGorevYukuSicaklikNem"
        Me.chrtGorevYukuSicaklikNem.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series17.ChartArea = "ChartArea1"
        Series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series17.Name = "Sıcaklık"
        Series17.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent
        Series18.ChartArea = "ChartArea1"
        Series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series18.Name = "Nem"
        Me.chrtGorevYukuSicaklikNem.Series.Add(Series17)
        Me.chrtGorevYukuSicaklikNem.Series.Add(Series18)
        Me.chrtGorevYukuSicaklikNem.Size = New System.Drawing.Size(310, 270)
        Me.chrtGorevYukuSicaklikNem.TabIndex = 7
        Me.chrtGorevYukuSicaklikNem.Text = "Chart1"
        '
        'grpHYİ
        '
        Me.grpHYİ.Controls.Add(Me.btnCloseHYISerialPort)
        Me.grpHYİ.Controls.Add(Me.strInterval)
        Me.grpHYİ.Controls.Add(Me.Label1)
        Me.grpHYİ.Controls.Add(Me.strTeamID)
        Me.grpHYİ.Controls.Add(Me.cmbHYIBaudRate)
        Me.grpHYİ.Controls.Add(Me.btnOpenHYISerialPort)
        Me.grpHYİ.Controls.Add(Me.cmbHYISerialPort)
        Me.grpHYİ.Location = New System.Drawing.Point(1008, 3)
        Me.grpHYİ.Name = "grpHYİ"
        Me.grpHYİ.Size = New System.Drawing.Size(520, 70)
        Me.grpHYİ.TabIndex = 4
        Me.grpHYİ.TabStop = False
        Me.grpHYİ.Text = "Hakem Yer İstasyonu Bağlantı Noktası"
        '
        'btnCloseHYISerialPort
        '
        Me.btnCloseHYISerialPort.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCloseHYISerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseHYISerialPort.Location = New System.Drawing.Point(437, 30)
        Me.btnCloseHYISerialPort.Name = "btnCloseHYISerialPort"
        Me.btnCloseHYISerialPort.Size = New System.Drawing.Size(71, 25)
        Me.btnCloseHYISerialPort.TabIndex = 6
        Me.btnCloseHYISerialPort.Text = "Kapat"
        Me.btnCloseHYISerialPort.UseVisualStyleBackColor = True
        '
        'strInterval
        '
        Me.strInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.strInterval.ForeColor = System.Drawing.Color.Gray
        Me.strInterval.Location = New System.Drawing.Point(338, 30)
        Me.strInterval.MaxLength = 7
        Me.strInterval.Name = "strInterval"
        Me.strInterval.Size = New System.Drawing.Size(93, 23)
        Me.strInterval.TabIndex = 9
        Me.strInterval.Text = "Interval (ms)"
        Me.strInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 8
        '
        'strTeamID
        '
        Me.strTeamID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.strTeamID.ForeColor = System.Drawing.Color.Gray
        Me.strTeamID.Location = New System.Drawing.Point(262, 30)
        Me.strTeamID.MaxLength = 3
        Me.strTeamID.Name = "strTeamID"
        Me.strTeamID.Size = New System.Drawing.Size(70, 23)
        Me.strTeamID.TabIndex = 7
        Me.strTeamID.Text = "Takım ID"
        Me.strTeamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbHYIBaudRate
        '
        Me.cmbHYIBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbHYIBaudRate.FormattingEnabled = True
        Me.cmbHYIBaudRate.Location = New System.Drawing.Point(132, 30)
        Me.cmbHYIBaudRate.Name = "cmbHYIBaudRate"
        Me.cmbHYIBaudRate.Size = New System.Drawing.Size(120, 25)
        Me.cmbHYIBaudRate.Sorted = True
        Me.cmbHYIBaudRate.TabIndex = 6
        '
        'btnOpenHYISerialPort
        '
        Me.btnOpenHYISerialPort.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnOpenHYISerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenHYISerialPort.Location = New System.Drawing.Point(437, 30)
        Me.btnOpenHYISerialPort.Name = "btnOpenHYISerialPort"
        Me.btnOpenHYISerialPort.Size = New System.Drawing.Size(71, 25)
        Me.btnOpenHYISerialPort.TabIndex = 2
        Me.btnOpenHYISerialPort.Text = "Aç"
        Me.btnOpenHYISerialPort.UseVisualStyleBackColor = True
        '
        'cmbHYISerialPort
        '
        Me.cmbHYISerialPort.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbHYISerialPort.FormattingEnabled = True
        Me.cmbHYISerialPort.Location = New System.Drawing.Point(6, 30)
        Me.cmbHYISerialPort.Name = "cmbHYISerialPort"
        Me.cmbHYISerialPort.Size = New System.Drawing.Size(120, 25)
        Me.cmbHYISerialPort.Sorted = True
        Me.cmbHYISerialPort.TabIndex = 5
        '
        'roketBgWorker
        '
        '
        'gorevYukuBgWorker
        '
        '
        'hyiBgWorker
        '
        '
        'grpDurum
        '
        Me.grpDurum.Controls.Add(Me.btnClear)
        Me.grpDurum.Controls.Add(Me.txtDurum)
        Me.grpDurum.Location = New System.Drawing.Point(410, 3)
        Me.grpDurum.Name = "grpDurum"
        Me.grpDurum.Size = New System.Drawing.Size(592, 108)
        Me.grpDurum.TabIndex = 5
        Me.grpDurum.TabStop = False
        Me.grpDurum.Text = "Durum Uyarıları"
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(521, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Temizle"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtDurum
        '
        Me.txtDurum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDurum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDurum.DetectUrls = False
        Me.txtDurum.ForeColor = System.Drawing.Color.Red
        Me.txtDurum.HideSelection = False
        Me.txtDurum.Location = New System.Drawing.Point(6, 16)
        Me.txtDurum.Name = "txtDurum"
        Me.txtDurum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal
        Me.txtDurum.Size = New System.Drawing.Size(509, 86)
        Me.txtDurum.TabIndex = 0
        Me.txtDurum.Text = ""
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(1340, 79)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(188, 32)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Bağlantı Noktalarını Yenile"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'GUIDE
        '
        Me.GUIDE.BackgroundImage = CType(resources.GetObject("GUIDE.BackgroundImage"), System.Drawing.Image)
        Me.GUIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GUIDE.Cursor = System.Windows.Forms.Cursors.Help
        Me.GUIDE.Location = New System.Drawing.Point(180, 2)
        Me.GUIDE.Name = "GUIDE"
        Me.GUIDE.Size = New System.Drawing.Size(126, 118)
        Me.GUIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GUIDE.TabIndex = 7
        Me.GUIDE.TabStop = False
        '
        'aeronist
        '
        Me.aeronist.BackgroundImage = CType(resources.GetObject("aeronist.BackgroundImage"), System.Drawing.Image)
        Me.aeronist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.aeronist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aeronist.Location = New System.Drawing.Point(16, -28)
        Me.aeronist.Name = "aeronist"
        Me.aeronist.Size = New System.Drawing.Size(157, 156)
        Me.aeronist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.aeronist.TabIndex = 8
        Me.aeronist.TabStop = False
        '
        'zodyak
        '
        Me.zodyak.BackgroundImage = CType(resources.GetObject("zodyak.BackgroundImage"), System.Drawing.Image)
        Me.zodyak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.zodyak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.zodyak.Location = New System.Drawing.Point(2, -1)
        Me.zodyak.Name = "zodyak"
        Me.zodyak.Size = New System.Drawing.Size(172, 148)
        Me.zodyak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.zodyak.TabIndex = 9
        Me.zodyak.TabStop = False
        '
        'tmrDate
        '
        Me.tmrDate.Enabled = True
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Location = New System.Drawing.Point(8, 13)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(80, 51)
        Me.txtDate.TabIndex = 10
        Me.txtDate.Text = "HH:mm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dd.MM.yyyy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dddddddd"
        Me.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDate
        '
        Me.grpDate.Controls.Add(Me.txtDate)
        Me.grpDate.Location = New System.Drawing.Point(312, 3)
        Me.grpDate.Name = "grpDate"
        Me.grpDate.Size = New System.Drawing.Size(92, 70)
        Me.grpDate.TabIndex = 11
        Me.grpDate.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1540, 845)
        Me.Controls.Add(Me.grpDate)
        Me.Controls.Add(Me.GUIDE)
        Me.Controls.Add(Me.grpRoket)
        Me.Controls.Add(Me.aeronist)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grpDurum)
        Me.Controls.Add(Me.grpHYİ)
        Me.Controls.Add(Me.grpGorevYuku)
        Me.Controls.Add(Me.zodyak)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aeronist Yer İstasyonu Arayüzü"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpRoket.ResumeLayout(False)
        Me.grpRoket.PerformLayout()
        CType(Me.chrtRoketİrtifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRoketHam.ResumeLayout(False)
        CType(Me.ptRoketHorizon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtRoketRollPitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtRoketHiz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGorevYuku.ResumeLayout(False)
        Me.grpGorevYuku.PerformLayout()
        CType(Me.chrtGorevYukuİrtifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGorevYukuHam.ResumeLayout(False)
        CType(Me.chrtGorevYukuBasinc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtGorevYukuSicaklikNem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHYİ.ResumeLayout(False)
        Me.grpHYİ.PerformLayout()
        Me.grpDurum.ResumeLayout(False)
        CType(Me.GUIDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aeronist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zodyak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDate.ResumeLayout(False)
        Me.grpDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRoket As GroupBox
    Friend WithEvents grpGorevYuku As GroupBox
    Friend WithEvents grpHYİ As GroupBox
    Friend WithEvents cmbRoketSerialPort As ComboBox
    Friend WithEvents cmbGorevYukuSerialPort As ComboBox
    Friend WithEvents cmbHYISerialPort As ComboBox
    Friend WithEvents btnOpenRoketSerialPort As Button
    Friend WithEvents btnOpenGorevYukuSerialPort As Button
    Friend WithEvents cmbHYIBaudRate As ComboBox
    Friend WithEvents btnOpenHYISerialPort As Button
    Friend WithEvents strTeamID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents strInterval As TextBox
    Friend WithEvents roketBgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents gorevYukuBgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents hyiBgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents grpDurum As GroupBox
    Friend WithEvents txtDurum As RichTextBox
    Friend WithEvents btnCloseRoketSerialPort As Button
    Friend WithEvents btnCloseGorevYukuSerialPort As Button
    Friend WithEvents btnCloseHYISerialPort As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GUIDE As PictureBox
    Friend WithEvents aeronist As PictureBox
    Friend WithEvents chrtGorevYukuBasinc As DataVisualization.Charting.Chart
    Friend WithEvents chrtGorevYukuSicaklikNem As DataVisualization.Charting.Chart
    Friend WithEvents txtGorevYukuBasinc As Label
    Friend WithEvents txtGorevYukuNem As Label
    Friend WithEvents txtGorevYukuSicaklik As Label
    Friend WithEvents txtGorevYukuGpsİrtifa As Label
    Friend WithEvents txtGorevYukuHam As RichTextBox
    Friend WithEvents grpGorevYukuHam As GroupBox
    Friend WithEvents txtGorevYukuKonum As Label
    Friend WithEvents grpRoketHam As GroupBox
    Friend WithEvents txtRoketHam As RichTextBox
    Friend WithEvents chrtRoketHiz As DataVisualization.Charting.Chart
    Friend WithEvents txtRoketGpsİrtifa As Label
    Friend WithEvents txtRoketİrtifa As Label
    Friend WithEvents txtRoketDikeyHiz As Label
    Friend WithEvents txtRoketKonum As Label
    Friend WithEvents ptRoketHorizon As PictureBox
    Friend WithEvents txtRoketPitch As Label
    Friend WithEvents txtRoketRoll As Label
    Friend WithEvents chrtRoketRollPitch As DataVisualization.Charting.Chart
    Friend WithEvents lblRoketBasarisizVeri As Label
    Friend WithEvents lblRoketBasariliVeri As Label
    Friend WithEvents lblRoketGelenVeri As Label
    Friend WithEvents lblGorevYukuBasarisizVeri As Label
    Friend WithEvents lblGorevYukuBasariliVeri As Label
    Friend WithEvents lblGorevYukuGelenVeri As Label
    Friend WithEvents chrtRoketİrtifa As DataVisualization.Charting.Chart
    Friend WithEvents chrtGorevYukuİrtifa As DataVisualization.Charting.Chart
    Friend WithEvents zodyak As PictureBox
    Friend WithEvents tmrDate As Timer
    Friend WithEvents txtDate As Label
    Friend WithEvents grpDate As GroupBox
End Class
