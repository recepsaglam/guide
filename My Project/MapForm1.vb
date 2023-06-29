Imports GMap.NET.WindowsForms.Markers
Imports System.Globalization
Imports System.Text.RegularExpressions

' Not: Visual Basic dilinin double değişkenleri sıfır değerinde başlatması nedeniyle
'      Konum arayüzünde hiçbir zaman (0,0) konumuna işaretçi eklenemiyor.

Public Class MapForm1
    'Haritaya eklenecek işaretçilerin ve yolların tanımlanması
    Dim markers As GMapOverlay = New GMapOverlay("markers")
    Dim routes As GMapOverlay = New GMapOverlay("routes")
    Dim pointsBR As List(Of PointLatLng) = New List(Of PointLatLng)()
    Dim pointsBG As List(Of PointLatLng) = New List(Of PointLatLng)()

    Private Sub MapForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Harita sağlayıcısının ve verinin sadece sunucudan alınmasını ayarlayan kısım
        map.MapProvider = MapProviders.BingSatelliteMapProvider.Instance
        map.Manager.Mode = AccessMode.ServerAndCache
        map.ShowCenter = False

        'Harita sürüklemeyi sol tıklama ile yapılmasını sağlar
        map.DragButton = MouseButtons.Left

        'Haritanın başlangıç konumunu ayarlar
        map.Position = New PointLatLng(40.9893729, 28.724966)

        'Konum kutusunun hiçbir zaman boş görünmemesi için ufak bir ayar
        If Form1.enlemGorevYuku And Form1.boylamGorevYuku Then
            txtGorevYukuKonum.Clear()
        End If
        If Form1.enlemRoket And Form1.boylamRoket Then
            txtRoketKonum.Clear()
        End If

        mapMarker(Form1.enlemRoket, Form1.boylamRoket, "Roket")
        mapMarker(Form1.enlemGorevYuku, Form1.boylamGorevYuku, "Görev Yükü")

    End Sub

    Private Sub mapMarker(enlem, boylam, hedef)
        If enlem And boylam Then
            'Haritanın işaretçiyi ortalaması için gereken satır
            map.Position = New PointLatLng(enlem, boylam)

            'İşaretçinin rengini ayarlar ve kutuya enlem ve boylamı ekler
            Dim strVeri As String = hedef & " :" & vbNewLine &
                                "      Enlem > " & enlem & vbNewLine &
                                "    Boylam > " & boylam

            Dim markerColor As Integer
            If Not String.Compare(hedef, "Roket") Then
                markerColor = GMarkerGoogleType.red
                txtRoketKonum.AppendText(strVeri)
            ElseIf Not String.Compare(hedef, "Görev Yükü") Then
                markerColor = GMarkerGoogleType.blue
                txtGorevYukuKonum.AppendText(strVeri)
            Else
                markerColor = GMarkerGoogleType.yellow
            End If

            'İşaretçinin diziye eklendiği kısım
            Dim marker As GMapMarker = New GMarkerGoogle(New PointLatLng(enlem, boylam),
                                                         markerColor)
            markers.Markers.Add(marker)

        End If

        'İşaretçilerin haritaya eklendiği kısım
        map.Overlays.Add(markers)

    End Sub

    'Arayüzde bulunan konum bölümüne kullanıcıdan veri girişini engeller
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoketKonum.KeyPress, txtGorevYukuKonum.KeyPress
        e.Handled = True
    End Sub

    'Konum ve işaretçilerin yenilenmesini sağlar
    Private Sub btnKonumYenile_Click(sender As Object, e As EventArgs) Handles btnKonumYenile.Click, btnUzaklıkOlc.Click
        'Önceki işaretçileri kaldırır
        markers.Clear()

        'Konum bilgisini içeren kutuları yeniler
        If Form1.enlemGorevYuku And Form1.boylamGorevYuku Then
            txtGorevYukuKonum.Clear()
        End If
        If Form1.enlemRoket And Form1.boylamRoket Then
            txtRoketKonum.Clear()
        End If

        'İşaretçileri yeniden ekler
        mapMarker(Form1.enlemRoket, Form1.boylamRoket, "Roket")
        mapMarker(Form1.enlemGorevYuku, Form1.boylamGorevYuku, "Görev Yükü")

        Try
            'Regex ile verinin uygunluğu kontrol edilir
            Dim regexp As Regex
            regexp = New Regex("\d{1,2},{0,1}\d{0,6}")

            Dim enlem As Double = Convert.ToDouble(strBaslangicEnlem.Text,
                                                   CultureInfo.InvariantCulture)
            Dim boylam As Double = Convert.ToDouble(strBaslangicBoylam.Text,
                                                    CultureInfo.InvariantCulture)

            If regexp.IsMatch(enlem) And regexp.IsMatch(boylam) Then
                mapMarker(enlem, boylam, "Başlangıç")
            End If
        Catch ex As Exception
        End Try

    End Sub

    'Uzaklık ölçümü girişlerinin watermark yazılarını ve yalnızca uygun karakter girişini ayarlar 
    Private Sub strBaslangicEnlem_Enter() Handles strBaslangicEnlem.Enter
        If strBaslangicEnlem.Text = "Başlangıç Enlemi" Then
            strBaslangicEnlem.ForeColor = Color.Black
            strBaslangicEnlem.Text = ""
        End If
    End Sub
    Private Sub strBaslangicEnlem_Leave() Handles strBaslangicEnlem.Leave
        If strBaslangicEnlem.Text.Length = 0 Then
            strBaslangicEnlem.ForeColor = Color.Gray
            strBaslangicEnlem.Text = "Başlangıç Enlemi"
        End If
    End Sub
    Private Sub strBaslangicBoylam_Enter() Handles strBaslangicBoylam.Enter
        If strBaslangicBoylam.Text = "Başlangıç Boylamı" Then
            strBaslangicBoylam.ForeColor = Color.Black
            strBaslangicBoylam.Text = ""
        End If
    End Sub
    Private Sub strBaslangicBoylam_Leave() Handles strBaslangicBoylam.Leave
        If strBaslangicBoylam.Text.Length = 0 Then
            strBaslangicBoylam.ForeColor = Color.Gray
            strBaslangicBoylam.Text = "Başlangıç Boylamı"
        End If
    End Sub
    Private Sub strBaslangic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles strBaslangicEnlem.KeyPress, strBaslangicBoylam.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnUzaklıkOlc_Click(sender As Object, e As EventArgs) Handles btnUzaklıkOlc.Click, btnKonumYenile.Click
        Dim enlem, boylam As Double

        'Girilen enlem ve boylam bilgisini uygun veri tipine çevirir
        Try
            enlem = Convert.ToDouble(strBaslangicEnlem.Text,
                                     CultureInfo.InvariantCulture)
            boylam = Convert.ToDouble(strBaslangicBoylam.Text,
                                      CultureInfo.InvariantCulture)
        Catch ex As Exception
        End Try

        If enlem And boylam Then
            'Önceki ölçümleri temizler
            routes.Routes.Clear()
            pointsBR.Clear()
            pointsBG.Clear()

            'Regex ile verinin uygunluğu kontrol edilir
            Dim regexp As Regex
            regexp = New Regex("\d{1,2},{0,1}\d{0,6}")

            If regexp.IsMatch(enlem) And regexp.IsMatch(boylam) Then
                'Yol çizimi gerçekleştirilir
                If Form1.enlemRoket And Form1.boylamRoket Then
                    pointsBR.Add(New PointLatLng(enlem, boylam))
                    pointsBR.Add(New PointLatLng(Form1.enlemRoket, Form1.boylamRoket))
                    Dim routeBR As GMapRoute = New GMapRoute(pointsBR, "Başlangıç -> Roket")
                    routeBR.Stroke = New Pen(Color.Red, 2)
                    routes.Routes.Add(routeBR)
                    lblOlcBr.Text = "B -> R : " & routeBR.Distance & " km"
                End If

                If Form1.enlemGorevYuku And Form1.boylamGorevYuku Then
                    pointsBG.Add(New PointLatLng(enlem, boylam))
                    pointsBG.Add(New PointLatLng(Form1.enlemGorevYuku, Form1.boylamGorevYuku))
                    Dim routeBG As GMapRoute = New GMapRoute(pointsBG, "Başlangıç -> Görev Yükü")
                    routeBG.Stroke = New Pen(Color.Blue, 2)
                    routes.Routes.Add(routeBG)
                    lblOlcBG.Text = "B -> G : " & routeBG.Distance & " km"
                End If

            End If

        End If

        'Çizilen yollar haritaya eklenir
        map.Overlays.Add(routes)

    End Sub

End Class

