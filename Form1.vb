Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class Form1
    'Seri bağlantı için gereken tanımlamalar
    Dim serialPortRoket As IO.Ports.SerialPort = Nothing
    Dim serialPortGorevYuku As IO.Ports.SerialPort = Nothing
    Dim serialPortHYI As IO.Ports.SerialPort = Nothing
    Dim hyiVeri As Byte() = New Byte(77) {}
    Dim hyiPaketSayac As Integer
    Dim initialDataHyi As String = "+0000.00,+0000.00,+0000.00,+0000.00,+0000.00,+00.000000,+00.000000"
    Dim hyiVeriGorev() As String = initialDataHyi.Split(",")
    Dim hyiVeriRoket() As String = initialDataHyi.Split(",")
    Public enlemRoket, boylamRoket, enlemGorevYuku, boylamGorevYuku As Double

    'Görev yükü ve roket için veri paketi yapısı
    'roket veri paketi yapısı: <[gpsİrtifa, dikeyHız, roll, pitch, irtifa, gpsBoylam, gpsEnlem]crc>
    Enum enumVeriRoket
        gpsIrtifa
        dikeyHiz
        roll
        pitch
        irtifa
        gpsBoylam
        gpsEnlem
        crc
    End Enum

    'görev yükü veri paketi yapısı: <[gpsİrtifa, atmosferikBasınç, sıcaklık, nem, gpsBoylam, gpsEnlem]crc>
    Enum enumVeriGorevYuku
        gpsIrtifa
        atmosferikBasinc
        sicaklik
        nem
        gpsBoylam
        gpsEnlem
        crc
    End Enum

    'Başarılı ve başarısız gelen veri sayısını tutan değişkenler
    Dim roketBasariliVeri, roketBasarisizVeri,
        gorevYukuBasariliVeri, gorevYukuBasarisizVeri As Integer

    Private Sub Form1_Load() Handles MyBase.Load

        'Sisteme bağlı tüm seri aygıtları arayüzdeki comboboxlara ekler
        Dim lstPorts As ArrayList = New ArrayList()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbGorevYukuSerialPort.Items.Add(sp)
            cmbHYISerialPort.Items.Add(sp)
            cmbRoketSerialPort.Items.Add(sp)
            lstPorts.Add(sp)
        Next

        'Sisteme bağlı aygıtları comboboxlara atamaya çalışır
        Try
            cmbRoketSerialPort.SelectedItem = lstPorts(0)
            cmbGorevYukuSerialPort.SelectedItem = lstPorts(1)
            cmbHYISerialPort.SelectedItem = lstPorts(2)
        Catch ex As ArgumentOutOfRangeException
        End Try

        'Hakem yer istasyonu baud rate değerlerini comboboxa ekler
        Dim lstBaudRates() As Integer = {4800, 9600, 19200, 38400, 76800, 115200}
        For Each sa As String In lstBaudRates
            cmbHYIBaudRate.Items.Add(sa)
        Next
        cmbHYIBaudRate.SelectedItem = "19200"

        btnCloseRoketSerialPort.Hide()
        btnCloseGorevYukuSerialPort.Hide()
        btnCloseHYISerialPort.Hide()
        btnRefresh.Show()

        'Görev yükü grafikleri için bazı ayarlar
        With chrtGorevYukuİrtifa
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .ChartAreas(0).AxisY.MajorGrid.Enabled = False
            .Series("GPS İrtifa").Color = Color.Turquoise
        End With

        With chrtGorevYukuSicaklikNem
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .ChartAreas(0).AxisY.MajorGrid.Enabled = False
            .Series("Sıcaklık").Color = Color.Red
            .Series("Nem").Color = Color.Orange
        End With

        With chrtGorevYukuBasinc
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .ChartAreas(0).AxisY.MajorGrid.Enabled = False
            .Series("Basınç").Color = Color.Violet
        End With

        'Roket grafikleri için bazı ayarlar

        With chrtRoketİrtifa
            .Series("İrtifa").Color = Color.Turquoise
            .Series("GPS İrtifa").Color = Color.Green
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .ChartAreas(0).AxisY.MajorGrid.Enabled = False
        End With

        With chrtRoketRollPitch
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .ChartAreas(0).AxisY.MajorGrid.Enabled = False
            .Series("Roll").Color = Color.Green
            .Series("Pitch").Color = Color.Red
        End With

        With chrtRoketHiz
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .ChartAreas(0).AxisY.MajorGrid.Enabled = False
            .Series("Dikey Hız").Color = Color.Blue
        End With

    End Sub


    'Arayüzde bulunan combobox ve durum monitörüne kullanıcıdan veri girişini engeller
    Private Sub ComboBoxandTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbRoketSerialPort.KeyPress, cmbGorevYukuSerialPort.KeyPress, cmbHYISerialPort.KeyPress, cmbHYIBaudRate.KeyPress, txtDurum.KeyPress
        e.Handled = True
    End Sub

    'Bağlantı açma butonlarının kontrol edildiği bölüm
    Private Sub btnOpenRoketSerialPort_Click(sender As Object, e As EventArgs) Handles btnOpenRoketSerialPort.Click
        'Seri iletişimi gerçekleştirecek arka plan işlemini başlatır
        Try
            roketBgWorker.RunWorkerAsync()
        Catch ex As InvalidOperationException
        End Try
    End Sub
    Private Sub btnOpenGorevYukuSerialPort_Click(sender As Object, e As EventArgs) Handles btnOpenGorevYukuSerialPort.Click
        'Seri iletişimi gerçekleştirecek arka plan işlemini başlatır
        Try
            gorevYukuBgWorker.RunWorkerAsync()
        Catch ex As InvalidOperationException
        End Try
    End Sub
    Private Sub btnOpenHYISerialPort_Click(sender As Object, e As EventArgs) Handles btnOpenHYISerialPort.Click
        'Geçersiz Takım ID ve Interval değerini denetler
        Try
            If CInt(strTeamID.Text) >= 0 And CInt(strTeamID.Text) <= 255 And CInt(strInterval.Text) >= 100 Then
                'Seri iletişimi gerçekleştirecek arka plan işlemini başlatır
                Try
                    hyiBgWorker.RunWorkerAsync()
                Catch ex As InvalidOperationException
                End Try
            Else
                txtDurum.AppendText(vbNewLine & "> Hakem yer istasyonu için geçersiz bağlantı ayarları.")
                txtDurum.AppendText(vbNewLine & "  [Takım ID[0-255] && Interval > 100ms]")
            End If
        Catch ex As InvalidCastException
            txtDurum.AppendText(vbNewLine & "> Hakem yer istasyonu için eksik bağlantı ayarları.")
        End Try

    End Sub

    'Arka planda seri bağlantıdan gelen ve yazılan verilerin kontrol edildiği bölüm
    Private Sub BackgroundWorker1_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles roketBgWorker.DoWork
        'Roket
        Try
            Dim comPort As String = cmbRoketSerialPort.Text
            Dim comBaudrate As Integer = 9600

            Try
                serialPortRoket = My.Computer.Ports.OpenSerialPort(comPort)
                serialPortRoket.BaudRate = comBaudrate
                serialPortRoket.ReadTimeout = 120000

                btnCloseRoketSerialPort.Show()
                btnOpenRoketSerialPort.Hide()
                btnRefresh.Hide()

                Do
                    Try
                        'Veri paketini bitiş karakterine kadar al ve değişkene ata
                        Dim Incoming As String = serialPortRoket.ReadTo(">")

                        If Incoming Is Nothing Then
                            Exit Do
                        Else
                            'Checksum kontrolünü ile verilerin doğruluğunun sınandığı bölüm
                            If checksum(Incoming + ">") = True Then
                                'Grafik işlemlemlerinin başladığı yer
                                roketBasariliVeri += 1
                                lblRoketBasariliVeri.Text = "Başarılı : " & roketBasariliVeri
                                hyiVeriRoket = Incoming.Split(",")
                                Call graphRoket(Incoming)

                            Else
                                roketBasarisizVeri += 1
                                lblRoketBasarisizVeri.Text = "Başarısız : " & roketBasarisizVeri
                                Exit Try

                            End If

                        End If

                    Catch ex As UnauthorizedAccessException
                        txtDurum.AppendText(vbNewLine & "> Roket (" & comPort & ") bağlantısı koptu.")
                        Exit Do

                    End Try

                Loop

            Catch ex As TimeoutException
                txtDurum.AppendText(vbNewLine & "> Roket (" & comPort & ") bağlantısı zaman aşımına uğradı.")

            Catch ex As IO.IOException

            Finally
                If serialPortRoket IsNot Nothing Then serialPortRoket.Close()
                btnCloseRoketSerialPort.Hide()
                btnOpenRoketSerialPort.Show()
                btnRefresh.Show()

            End Try

        Catch ex As UnauthorizedAccessException
            txtDurum.AppendText(vbNewLine & "> Roket ile seri bağlantı kurulamadı.")
            btnCloseRoketSerialPort.Hide()
            btnOpenRoketSerialPort.Show()
            btnRefresh.Show()

        Catch ex As ArgumentException
            txtDurum.AppendText(vbNewLine & "> Roket için geçersiz bağlantı noktası.")

        End Try

    End Sub

    Private Sub BackgroundWorker2_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles gorevYukuBgWorker.DoWork
        'Görev Yükü
        Try
            Dim comPort As String = cmbGorevYukuSerialPort.Text
            Dim comBaudrate As Integer = 9600

            Try
                serialPortGorevYuku = My.Computer.Ports.OpenSerialPort(comPort)
                serialPortGorevYuku.BaudRate = comBaudrate
                serialPortGorevYuku.ReadTimeout = 120000

                btnCloseGorevYukuSerialPort.Show()
                btnOpenGorevYukuSerialPort.Hide()
                btnRefresh.Hide()

                Do
                    Try
                        'Veri paketini bitiş karakterine kadar al ve değişkene ata
                        Dim Incoming As String = serialPortGorevYuku.ReadTo(">")
                        If Incoming Is Nothing Then
                            Exit Do
                        Else
                            'Checksum kontrolünü ile verilerin doğruluğunun sınandığı bölüm
                            If checksum(Incoming + ">") = True Then
                                'Grafik işlemlemlerinin başladığı yer
                                gorevYukuBasariliVeri += 1
                                lblGorevYukuBasariliVeri.Text = "Başarılı : " & gorevYukuBasariliVeri
                                hyiVeriGorev = Incoming.Split(",")
                                Call graphGorevYuku(Incoming)

                            Else
                                gorevYukuBasarisizVeri += 1
                                lblGorevYukuBasarisizVeri.Text = "Başarısız : " & gorevYukuBasarisizVeri
                                Exit Try

                            End If

                        End If

                    Catch ex As UnauthorizedAccessException
                        txtDurum.AppendText(vbNewLine & "> Görev yükü (" & comPort & ") bağlantısı koptu.")
                        Exit Do

                    End Try

                Loop

            Catch ex As TimeoutException
                txtDurum.AppendText(vbNewLine & "> Görev yükü (" & comPort & ") bağlantısı zaman aşımına uğradı.")

            Catch ex As IO.IOException

            Finally
                If serialPortGorevYuku IsNot Nothing Then serialPortGorevYuku.Close()
                btnCloseGorevYukuSerialPort.Hide()
                btnOpenGorevYukuSerialPort.Show()
                btnRefresh.Show()

            End Try

        Catch ex As UnauthorizedAccessException
            txtDurum.AppendText(vbNewLine & "> Görev yükü ile seri bağlantı kurulamadı.")
            btnCloseGorevYukuSerialPort.Hide()
            btnOpenGorevYukuSerialPort.Show()
            btnRefresh.Show()

        Catch ex As ArgumentException
            txtDurum.AppendText(vbNewLine & "> Görev yükü için geçersiz bağlantı noktası.")

        End Try

    End Sub

    Private Sub BackgroundWorker3_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles hyiBgWorker.DoWork
        'Hakem Yer İstasyonu
        Try
            Dim comPort As String = cmbHYISerialPort.Text
            Dim comBaudrate As Integer = cmbHYIBaudRate.Text

            Try
                serialPortHYI = My.Computer.Ports.OpenSerialPort(comPort)
                serialPortHYI.BaudRate = comBaudrate
                serialPortHYI.Parity = IO.Ports.Parity.None
                serialPortHYI.StopBits = IO.Ports.StopBits.One
                serialPortHYI.DataBits = 8
                serialPortHYI.ReadTimeout = 120000

                btnCloseHYISerialPort.Show()
                btnOpenHYISerialPort.Hide()
                btnRefresh.Hide()

                Do
                    Try
                        'Veri paketini hakem yer istasyonuna yaz ve Interval değeri kadar bekle

                        Call hyiVeriPaketiOlustur()
                        serialPortHYI.Write(hyiVeri, 0, 78)
                        Threading.Thread.Sleep(strInterval.Text)

                    Catch ex As InvalidOperationException
                        Exit Do

                    Catch ex As UnauthorizedAccessException
                        txtDurum.AppendText(vbNewLine & "> Hakem yer istasyonu (" & comPort & ") bağlantısı koptu.")
                        Exit Do

                    End Try

                Loop

            Catch ex As TimeoutException
                txtDurum.AppendText(vbNewLine & "> Hakem yer istasyonu (" & comPort & ") bağlantısı zaman aşımına uğradı.")

            Catch ex As IO.IOException

            Finally
                If serialPortHYI IsNot Nothing Then serialPortHYI.Close()
                btnCloseHYISerialPort.Hide()
                btnOpenHYISerialPort.Show()
                btnRefresh.Show()

            End Try

        Catch ex As UnauthorizedAccessException
            txtDurum.AppendText(vbNewLine & "> Hakem yer istasyonu ile seri bağlantı kurulamadı.")
            btnCloseHYISerialPort.Hide()
            btnOpenHYISerialPort.Show()
            btnRefresh.Show()

        Catch ex As ArgumentException
            txtDurum.AppendText(vbNewLine & "> Hakem yer istasyonu için geçersiz bağlantı noktası.")

        End Try

    End Sub

    'Bağlantı kapatma butonlarının kontrol edildiği bölüm
    Private Sub btnCloseRoketSerialPort_Click() Handles btnCloseRoketSerialPort.Click
        Call CloseSerialPort_Click(serialPortRoket, btnCloseRoketSerialPort, btnOpenRoketSerialPort, "Roket")
    End Sub
    Private Sub btnCloseGorevYukuSerialPort_Click() Handles btnCloseGorevYukuSerialPort.Click
        Call CloseSerialPort_Click(serialPortGorevYuku, btnCloseGorevYukuSerialPort, btnOpenGorevYukuSerialPort, "Görev yükü")
    End Sub
    Private Sub btnCloseHYISerialPort_Click() Handles btnCloseHYISerialPort.Click
        Call CloseSerialPort_Click(serialPortHYI, btnCloseHYISerialPort, btnOpenHYISerialPort, "Hakem yer istasyonu")
    End Sub
    Private Sub CloseSerialPort_Click(ByRef targetSerialPort As Object, btnClose As Button, btnOpen As Button, target As String)
        Try
            targetSerialPort.Close()
            txtDurum.AppendText(vbNewLine & "> " & target & " ile bağlantı kapatıldı.")
        Catch ex As NullReferenceException
        End Try
        btnClose.Hide()
        btnOpen.Show()
        btnRefresh.Show()
    End Sub

    'Bağlantı noktalarını yenileyen butonun kontrol edildiği bölüm
    Private Sub btnRefresh_Click() Handles btnRefresh.Click
        'Önceden seçilmiş bağlantı noktalarını temizler
        cmbRoketSerialPort.Items.Clear()
        cmbGorevYukuSerialPort.Items.Clear()
        cmbHYISerialPort.Items.Clear()

        cmbRoketSerialPort.Text = String.Empty
        cmbGorevYukuSerialPort.Text = String.Empty
        cmbHYISerialPort.Text = String.Empty


        'Sisteme bağlı tüm seri aygıtları arayüzdeki comboboxlara ekler
        Dim lstPorts As ArrayList = New ArrayList()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbGorevYukuSerialPort.Items.Add(sp)
            cmbHYISerialPort.Items.Add(sp)
            cmbRoketSerialPort.Items.Add(sp)
            lstPorts.Add(sp)
        Next

        'Sisteme bağlı aygıtları comboboxlara atamaya çalışır
        Try
            cmbRoketSerialPort.SelectedItem = lstPorts(0)
            cmbGorevYukuSerialPort.SelectedItem = lstPorts(1)
            cmbHYISerialPort.SelectedItem = lstPorts(2)
        Catch ex As ArgumentOutOfRangeException
        End Try
    End Sub

    'Durum uyarılarını temizler
    Private Sub btnClear_Click() Handles btnClear.Click
        txtDurum.Clear()
    End Sub

    'Hakem yer istasyonuna gönderilecek verileri alan kutuların watermark yazılarını ve kutulsrs yalnızca sayı girilebilmesini ayarlar
    Private Sub strTeamID_Enter() Handles strTeamID.Enter
        If strTeamID.Text = "Takım ID" Then
            strTeamID.ForeColor = Color.Black
            strTeamID.Text = ""
        End If
    End Sub
    Private Sub strTeamID_Leave() Handles strTeamID.Leave
        If strTeamID.Text.Length = 0 Then
            strTeamID.ForeColor = Color.Gray
            strTeamID.Text = "Takım ID"
        End If
    End Sub
    Private Sub strInterval_Enter() Handles strInterval.Enter
        If strInterval.Text = "Interval (ms)" Then
            strInterval.ForeColor = Color.Black
            strInterval.Text = ""
        End If
    End Sub
    Private Sub strInterval_Leave() Handles strInterval.Leave
        If strInterval.Text.Length = 0 Then
            strInterval.ForeColor = Color.Gray
            strInterval.Text = "Interval (ms)"
        End If
    End Sub
    Private Sub strTeamId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles strTeamID.KeyPress, strInterval.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    'Arayüz ile ilgili bilgi veren bölüm
    Private Sub GUIDE_Click() Handles GUIDE.Click
        SettingsForm1.Show()
    End Sub
    Private Sub aeronist_Click(sender As Object, e As EventArgs) Handles aeronist.Click
        aeronist.Hide()
        zodyak.Show()
        GUIDE.BackgroundImage = Image.FromFile("..\..\Resources\zodyakIcon.png")
        Me.Text = "Zodyak Yer İstasyonu Arayüzü"
    End Sub
    Private Sub zodyak_Click(sender As Object, e As EventArgs) Handles zodyak.Click
        zodyak.Hide()
        aeronist.Show()
        GUIDE.BackgroundImage = Image.FromFile("..\..\Resources\aeronistIcon.png")
        Me.Text = "Aeronist Yer İstasyonu Arayüzü"
    End Sub

    Private Sub tmrDate_Tick(sender As Object, e As EventArgs) Handles tmrDate.Tick
        txtDate.Text = Format(Now, "HH:mm" & vbNewLine & "dd.MM.yyyy" & vbNewLine & "ddddddddd")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Gelen veri paketinin bütünlüğünün sınandığı yer
    Function checksum(veriPaketi) As Boolean
        Dim _rem As Byte = &H41
        Dim chrVeriPaketi() As Char

        chrVeriPaketi = veriPaketi.ToCharArray

        For i As Integer = 3 To 70
            _rem = _rem Xor Convert.ToByte(chrVeriPaketi(i))

            For j As Integer = 1 To 8
                If _rem And &H80 Then
                    _rem = CByte((_rem << 1) Xor &H7)
                Else
                    _rem <<= 1
                End If
            Next
        Next

        Dim dogruluk As Boolean
        Dim crc() As String

        crc = veriPaketi.Split("]")
        crc(1) = crc(1).Remove(3)

        If CInt(crc(1)) = _rem Then
            dogruluk = True
        Else
            dogruluk = False
        End If

        Return dogruluk
    End Function

    'Roket ve görev yükü grafiklerini çizen fonksiyonlar
    Function graphGorevYuku(veri)
        'görev yükü veri paketi yapısı: <[gpsİrtifa, atmosferikBasınç, sıcaklık, nem, gpsBoylam, gpsEnlem]crc>

        'Gelen veriden kontrol karakterlerini kaldır ve verileri bölerek diziye ata
        Dim kontrolVeri As String = Regex.Replace(veri, "[<>\[\]*]", "")
        Dim veriGorevYuku() As String = kontrolVeri.Split(",")

        'Enlem verisinden crc değerini sil
        veriGorevYuku(5) = veriGorevYuku(5).Trim("+").Remove(Len(veriGorevYuku(5)) - 4)
        veriGorevYuku(4) = veriGorevYuku(4).Trim("+")

        Try
            'Gelen verileri grafiklere ekle
            chrtGorevYukuSicaklikNem.Series("Sıcaklık").Points.AddY(veriGorevYuku(enumVeriGorevYuku.sicaklik).ToString)
            chrtGorevYukuSicaklikNem.Series("Nem").Points.AddY(veriGorevYuku(enumVeriGorevYuku.nem).ToString)
            chrtGorevYukuBasinc.Series("Basınç").Points.AddY(veriGorevYuku(enumVeriGorevYuku.atmosferikBasinc).ToString)
            chrtGorevYukuİrtifa.Series("GPS İrtifa").Points.AddY(veriGorevYuku(enumVeriGorevYuku.gpsIrtifa).ToString)

            'String veri tipinden double veri tipine dönüşüm.
            enlemGorevYuku = Convert.ToDouble(veriGorevYuku(enumVeriGorevYuku.gpsEnlem), CultureInfo.InvariantCulture)
            boylamGorevYuku = Convert.ToDouble(veriGorevYuku(enumVeriGorevYuku.gpsBoylam), CultureInfo.InvariantCulture)

            'Verileri açıklayıcı etiketlere ekle
            txtGorevYukuGpsİrtifa.Text = "GPS İrtifa: " & veriGorevYuku(enumVeriGorevYuku.gpsIrtifa) & " m"
            txtGorevYukuSicaklik.Text = "Sıcaklık: " & veriGorevYuku(enumVeriGorevYuku.sicaklik) & " °C"
            txtGorevYukuNem.Text = "Nem: " & veriGorevYuku(enumVeriGorevYuku.nem)
            txtGorevYukuBasinc.Text = "Atmosferik Basınç: " & veriGorevYuku(enumVeriGorevYuku.atmosferikBasinc)
            txtGorevYukuKonum.Text = "Konum: " & veriGorevYuku(enumVeriGorevYuku.gpsEnlem) & ", " & veriGorevYuku(enumVeriGorevYuku.gpsBoylam)

            'Ham veriyi ekle
            txtGorevYukuHam.AppendText(veri & ">")

            'Bazı grafiklerdeki gösterilecek veri sayısını kısıtlar
            If chrtGorevYukuSicaklikNem.Series(0).Points.Count = 16 Then
                chrtGorevYukuSicaklikNem.Series(0).Points.RemoveAt(0)
                chrtGorevYukuSicaklikNem.Series(1).Points.RemoveAt(0)
                chrtGorevYukuBasinc.Series(0).Points.RemoveAt(0)
            End If

        Catch ex As Exception
        End Try

        Return 1
    End Function

    Function graphRoket(veri)
        'roket veri paketi yapısı: <[gpsİrtifa, dikeyHız, roll, pitch, irtifa, gpsBoylam, gpsEnlem]crc>

        'Gelen veriden kontrol karakterlerini kaldır ve verileri bölerek diziye ata
        Dim kontrolVeri As String = Regex.Replace(veri, "[<>\[\]*]", "")
        Dim veriRoket() As String = kontrolVeri.Split(",")

        'Enlen verisinden crc değerini sil
        veriRoket(6) = veriRoket(6).Trim("+").Remove(Len(veriRoket(6)) - 4)
        veriRoket(5) = veriRoket(5).Trim("+")

        Try
            'Gelen verileri grafiklere ekle
            chrtRoketİrtifa.Series("İrtifa").Points.AddY(veriRoket(enumVeriRoket.irtifa).ToString)
            chrtRoketİrtifa.Series("GPS İrtifa").Points.AddY(veriRoket(enumVeriRoket.gpsIrtifa).ToString)
            chrtRoketHiz.Series("Dikey Hız").Points.AddY(veriRoket(enumVeriRoket.dikeyHiz).ToString)
            chrtRoketRollPitch.Series("Roll").Points.AddY(veriRoket(enumVeriRoket.roll).ToString)
            chrtRoketRollPitch.Series("Pitch").Points.AddY(veriRoket(enumVeriRoket.pitch).ToString)

            'String veri tipinden double veri tipine dönüşüm.
            enlemRoket = Convert.ToDouble(veriRoket(enumVeriRoket.gpsEnlem), CultureInfo.InvariantCulture)
            boylamRoket = Convert.ToDouble(veriRoket(enumVeriRoket.gpsBoylam), CultureInfo.InvariantCulture)

            'Verileri açıklayıcı etiketlere ekle
            txtRoketGpsİrtifa.Text = "GPS İrtifa: " & veriRoket(enumVeriRoket.gpsIrtifa) & " m"
            txtRoketİrtifa.Text = "İrtifa: " & vbNewLine & veriRoket(enumVeriRoket.irtifa) & " m"
            txtRoketDikeyHiz.Text = "Dikey Hız: " & veriRoket(enumVeriRoket.dikeyHiz)
            txtRoketKonum.Text = "Konum: " & veriRoket(enumVeriRoket.gpsEnlem) & ", " & veriRoket(enumVeriRoket.gpsBoylam)
            txtRoketRoll.Text = "Roll: " & veriRoket(enumVeriRoket.roll) & " °"
            txtRoketPitch.Text = "Pitch: " & veriRoket(enumVeriRoket.pitch) & " °"

            'Ham veriyi ekle
            txtRoketHam.AppendText(veri & ">")

            'Bazı grafiklerdeki gösterilecek veri sayısını kısıtlar
            If chrtRoketHiz.Series(0).Points.Count = 16 Then
                chrtRoketHiz.Series(0).Points.RemoveAt(0)
                chrtRoketRollPitch.Series(0).Points.RemoveAt(0)
                chrtRoketRollPitch.Series(1).Points.RemoveAt(0)
            End If

        Catch ex As Exception
        End Try

        Return 1
    End Function


    'Konum bilgisi arayüzünü başlatır
    Private Sub konum_Click(sender As Object, e As EventArgs) Handles txtRoketKonum.Click,
        txtGorevYukuKonum.Click
        MapForm1.Show()
    End Sub


    'Hakem yer istasyonu için veri paketini oluşturan bölüm
    Public Function hyiChecksum(hyiVeri) As Byte
        Dim checksum As Integer = 0

        For i As Integer = 4 To 74
            checksum += hyiVeri(i)
        Next

        Return checksum Mod 256
    End Function

    Public Function hyiVeriPaketiOlustur()
        'Veri paketinin değişmeyen byte'ları
        hyiVeri(0) = &HFF
        hyiVeri(1) = &HFF
        hyiVeri(2) = &H54
        hyiVeri(3) = &H52

        hyiVeri(4) = Convert.ToByte(strTeamID.Text)

        If hyiPaketSayac = 255 Then
            hyiPaketSayac = -1
        End If
        hyiPaketSayac += 1
        hyiVeri(5) = Convert.ToByte(hyiPaketSayac)

        Dim altitude = New FloatToByte(Convert.ToSingle(hyiVeriRoket(4), CultureInfo.InvariantCulture))
        hyiVeri(6) = altitude.ByteValues(0)
        hyiVeri(7) = altitude.ByteValues(1)
        hyiVeri(8) = altitude.ByteValues(2)
        hyiVeri(9) = altitude.ByteValues(3)

        Dim rocketGpsAltitude = New FloatToByte(Convert.ToSingle(hyiVeriRoket(0).Replace("<[", ""), CultureInfo.InvariantCulture))
        hyiVeri(10) = rocketGpsAltitude.ByteValues(0)
        hyiVeri(11) = rocketGpsAltitude.ByteValues(1)
        hyiVeri(12) = rocketGpsAltitude.ByteValues(2)
        hyiVeri(13) = rocketGpsAltitude.ByteValues(3)

        Dim rocketGpsLatitude = New FloatToByte(Convert.ToSingle(hyiVeriRoket(6).Remove(9), CultureInfo.InvariantCulture))
        hyiVeri(14) = rocketGpsLatitude.ByteValues(0)
        hyiVeri(15) = rocketGpsLatitude.ByteValues(1)
        hyiVeri(16) = rocketGpsLatitude.ByteValues(2)
        hyiVeri(17) = rocketGpsLatitude.ByteValues(3)

        Dim rocketGpsLongitude = New FloatToByte(Convert.ToSingle(hyiVeriRoket(5), CultureInfo.InvariantCulture))
        hyiVeri(18) = rocketGpsLongitude.ByteValues(0)
        hyiVeri(19) = rocketGpsLongitude.ByteValues(1)
        hyiVeri(20) = rocketGpsLongitude.ByteValues(2)
        hyiVeri(21) = rocketGpsLongitude.ByteValues(3)


        Dim taskLoadGpsAltitude = New FloatToByte(Convert.ToSingle(hyiVeriGorev(0).Replace("<[", ""), CultureInfo.InvariantCulture))
        hyiVeri(22) = taskLoadGpsAltitude.ByteValues(0)
        hyiVeri(23) = taskLoadGpsAltitude.ByteValues(1)
        hyiVeri(24) = taskLoadGpsAltitude.ByteValues(2)
        hyiVeri(25) = taskLoadGpsAltitude.ByteValues(3)

        Dim taskLoadGpsLatitude = New FloatToByte(Convert.ToSingle(hyiVeriGorev(5).Remove(9), CultureInfo.InvariantCulture))
        hyiVeri(26) = taskLoadGpsLatitude.ByteValues(0)
        hyiVeri(27) = taskLoadGpsLatitude.ByteValues(1)
        hyiVeri(28) = taskLoadGpsLatitude.ByteValues(2)
        hyiVeri(29) = taskLoadGpsLatitude.ByteValues(3)

        Dim taskLoadGpsLongitude = New FloatToByte(Convert.ToSingle(hyiVeriGorev(4), CultureInfo.InvariantCulture))
        hyiVeri(30) = taskLoadGpsLongitude.ByteValues(0)
        hyiVeri(31) = taskLoadGpsLongitude.ByteValues(1)
        hyiVeri(32) = taskLoadGpsLongitude.ByteValues(2)
        hyiVeri(33) = taskLoadGpsLongitude.ByteValues(3)

        'Kademe ile ilgili bilgiler yalnızca "Zorlu Görev" kategorisinde olduğu için bu değerler sıfır olarak atanmıştır.
        Dim stageGpsAltitude = New FloatToByte(0)
        hyiVeri(34) = stageGpsAltitude.ByteValues(0)
        hyiVeri(35) = stageGpsAltitude.ByteValues(1)
        hyiVeri(36) = stageGpsAltitude.ByteValues(2)
        hyiVeri(37) = stageGpsAltitude.ByteValues(3)

        Dim stageGpsLatitude = New FloatToByte(0)
        hyiVeri(38) = stageGpsLatitude.ByteValues(0)
        hyiVeri(39) = stageGpsLatitude.ByteValues(1)
        hyiVeri(40) = stageGpsLatitude.ByteValues(2)
        hyiVeri(41) = stageGpsLatitude.ByteValues(3)

        Dim stageGpsLongitude = New FloatToByte(0)
        hyiVeri(42) = stageGpsLongitude.ByteValues(0)
        hyiVeri(43) = stageGpsLongitude.ByteValues(1)
        hyiVeri(44) = stageGpsLongitude.ByteValues(2)
        hyiVeri(45) = stageGpsLongitude.ByteValues(3)

        'hyiVeri(46 - 74) bilgileri zorunlu olmadığı için sıfır olarak atanmıştır.
        Dim gyroX = New FloatToByte(0)
        hyiVeri(46) = gyroX.ByteValues(0)
        hyiVeri(47) = gyroX.ByteValues(1)
        hyiVeri(48) = gyroX.ByteValues(2)
        hyiVeri(49) = gyroX.ByteValues(3)

        Dim gyroY = New FloatToByte(0)
        hyiVeri(50) = gyroY.ByteValues(0)
        hyiVeri(51) = gyroY.ByteValues(1)
        hyiVeri(52) = gyroY.ByteValues(2)
        hyiVeri(53) = gyroY.ByteValues(3)

        Dim gyroZ = New FloatToByte(0)
        hyiVeri(54) = gyroZ.ByteValues(0)
        hyiVeri(55) = gyroZ.ByteValues(1)
        hyiVeri(56) = gyroZ.ByteValues(2)
        hyiVeri(57) = gyroZ.ByteValues(3)


        Dim accelX = New FloatToByte(0)
        hyiVeri(58) = accelX.ByteValues(0)
        hyiVeri(59) = accelX.ByteValues(1)
        hyiVeri(60) = accelX.ByteValues(2)
        hyiVeri(61) = accelX.ByteValues(3)

        Dim accelY = New FloatToByte(0)
        hyiVeri(62) = accelY.ByteValues(0)
        hyiVeri(63) = accelY.ByteValues(1)
        hyiVeri(64) = accelY.ByteValues(2)
        hyiVeri(65) = accelY.ByteValues(3)

        Dim accelZ = New FloatToByte(0)
        hyiVeri(66) = accelZ.ByteValues(0)
        hyiVeri(67) = accelZ.ByteValues(1)
        hyiVeri(68) = accelZ.ByteValues(2)
        hyiVeri(69) = accelZ.ByteValues(3)


        Dim angle = New FloatToByte(0)
        hyiVeri(70) = angle.ByteValues(0)
        hyiVeri(71) = angle.ByteValues(1)
        hyiVeri(72) = angle.ByteValues(2)
        hyiVeri(73) = angle.ByteValues(3)

        'FirstAndSecondOff = 1
        'FirstOnSecondOff = 2
        'FirstOffSecondOn = 3
        'FirstAndSecondOn = 4
        Dim rocketParachutesStatus As Byte = &H0
        hyiVeri(74) = rocketParachutesStatus

        Dim checkSum As Byte = hyiChecksum(hyiVeri)
        hyiVeri(75) = checkSum

        'Veri paketinin değişmeyen byte'ları
        hyiVeri(76) = &HD
        hyiVeri(77) = &HA

        Return 1
    End Function

End Class