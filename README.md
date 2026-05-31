<p align="center">
  <img src="Iqamah/Resources/iqamahbanner.png" alt="Iqamah Logo" width="400">
</p>

<h1 align="center">Iqamah</h1>
<p align="center"><em>The second call, for the first duty.</em></p>

<p align="center">
  Namaz vakitlerini takip eden, manevi hatırlatmalar sunan ve günlük ibadeti destekleyen bir Windows masaüstü uygulaması.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET_Framework-4.8-blue?logo=dotnet" alt=".NET Framework 4.8">
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows" alt="Windows">
  <img src="https://img.shields.io/badge/Sürüm-2.0.0-green" alt="Sürüm 2.0.0">
  <img src="https://img.shields.io/badge/Lisans-MIT-yellow" alt="Lisans">
</p>

---

## ✨ Özellikler

### 🕌 Namaz Vakitleri
- **Anlık namaz takvimi** — [Aladhan API](https://aladhan.com/prayer-times-api) üzerinden konumunuza göre doğru vakitleri çeker
- **Canlı geri sayım** — Bir sonraki namaz vaktine kalan süreyi animasyonlu olarak gösterir
- **Aktif vakit vurgulama** — İçinde bulunulan namaz vakti ana ekranda görsel olarak öne çıkar
- **Namaz takibi** — Gün boyunca kıldığınız namazları işaretleyerek takip edin
- **Çoklu hesaplama metotları** — 15+ hesaplama yöntemi desteği (Diyanet, MWL, ISNA, Mısır, Mekke, Karaçi vb.)
- **Çevrimdışı önbellek** — Son çekilen vakitleri yerel olarak saklar, internetsiz de çalışır

### 🔔 Akıllı Bildirimler
- **Özel bildirim pencereleri** — Standart Windows bildirimleri yerine güzel, özel tasarım bildirimler
- **Erteleme desteği** — Bildirimleri 5 dakikalık aralıklarla erteleyin (vakit başına en fazla 3 kez)
- **Vakit öncesi uyarı** — Namaz vaktinden X dakika önce hatırlatma alın (ayarlanabilir)
- **Cuma namazı bildirimi** — Özelleştirilebilir zamanlama ile özel Cuma hatırlatıcısı
- **Sesli uyarılar** — Namaz vakti (`prayerNotif.wav`) ve ön uyarı (`alert.wav`) için farklı bildirim sesleri
- **Otomatik sessiz mod** — Namaz vakti geldiğinde bilgisayar sesini otomatik olarak kapatma seçeneği

### 📿 Tesbihat & Zikir
- Ana ekranda hızlı sayım için **dijital tesbih sayacı**
- 7 yerleşik sayaçlı **genişletilmiş zikir penceresi** (FormTesbih):
  - Sübhanallah (33×)
  - Elhamdülillah (33×)
  - Allahü Ekber (33×)
  - Lâ ilâhe illallah (100×)
  - Sübhanallahi ve bihamdihi (100×)
  - Estağfirullah (100×)
  - Salavat-ı Şerife (100×)
- **Klavye kısayolları** — 1–7 ile say, R ile sıfırla, ESC ile kapat
- **Tamamlanma göstergeleri** — Hedef sayıya ulaşıldığında görsel geri bildirim

### 📖 Günün Hadisi
- **Döngülü hadis gösterimi** — Sahih kaynaklardan derlenmiş 25 hadis koleksiyonu
- **Otomatik döngü** — Her 30 saniyede yeni bir hadis
- **Kaynak bilgisi** — Her hadisin yanında kaynak referansı (Buhârî, Müslim, Tirmizî vb.)

### 🕋 Cuma Hutbeleri
- Diyanet İşleri Başkanlığı'nın haftalık hutbe arşivine **hızlı erişim**
- **Her zaman erişilebilir** — Hutbe butonu sadece Cuma günleri değil, her gün aktif

### 📅 Tarih Gösterimi
- **Çift takvim** — Miladi ve Hicri tarihleri aynı anda gösterir

### 🎨 Modern Arayüz
- **Koyu tema** — Göze hoş gelen zarif karanlık renk şeması
- **Kart tabanlı düzen** — Temiz, düzenli ve bölümlenmiş arayüz
- **Açılış ekranı** — İlk açılışta Besmele selamlı güzel yükleme ekranı
- **Kenarlıksız pencere** — Sürükleme destekli özel başlık çubuğu
- **Sistem tepsisi** — Sağ tık menüsüyle tepsiye küçültme (Göster, Ayarlar, Tesbihat, Çıkış)

---

## 🚀 Başlarken

### Gereksinimler

- **Windows 10/11**
- **.NET Framework 4.8** (çoğu Windows 10/11 sisteminde önceden yüklüdür)
- **İnternet bağlantısı** (namaz vakitlerini çekmek için; ilk çekimden sonra çevrimdışı önbellek mevcuttur)

### Kurulum

1. **Depoyu klonlayın**
   ```bash
   git clone https://github.com/yourusername/Iqamah.git
   ```

2. **Visual Studio'da açın**
   - `Iqamah.sln` dosyasını Visual Studio 2019 veya üstü ile açın

3. **NuGet paketlerini yükleyin**
   - Proje `Newtonsoft.Json` ve `ReaLTaiizor` kullanır — NuGet bunları otomatik olarak yükleyecektir

4. **Derleyin ve Çalıştırın**
   - `F5`'e basın veya `Derle > Çözümü Derle` üzerinden derleyin

### Hazır Kullanım

Derlenmiş bir sürümünüz varsa:
1. Son sürümü indirin
2. Arşivi çıkarın
3. `Iqamah.exe` dosyasını çalıştırın

---

## ⚙️ Ayarlar

Ana ekrandaki **⚙** butonundan veya sistem tepsisi sağ tık menüsünden ayarlara ulaşabilirsiniz.

| Ayar | Açıklama |
|---|---|
| **Şehir & Ülke** | Doğru namaz vakti hesaplaması için konumunuz |
| **Hesaplama Metodu** | 15+ yöntem arasından seçim (Diyanet, MWL, ISNA vb.) |
| **Bildirimler** | Namaz vakti bildirimlerini aç/kapat |
| **Vakit Öncesi Uyarı** | Her namaz vaktinden X dakika önce bildirim al (1–60 dk) |
| **Cuma Bildirimi** | Cuma namazı için özel hatırlatma |
| **Cuma Hutbesi** | Hutbe erişim butonunu göster/gizle |
| **Namaz Vakti Sessiz Mod** | Vakit geldiğinde bilgisayarı otomatik olarak sessize al |
| **Her Zaman Üstte** | Pencereyi diğer tüm pencerelerin üzerinde tut |
| **Tepsiye Küçült** | Görev çubuğu yerine sistem tepsisine küçült |

---

## ⌨️ Klavye Kısayolları

### Ana Pencere

| Tuş | İşlev |
|---|---|
| `F5` | Namaz vakitlerini yenile |
| `F1` | Hakkında penceresi |
| `Ctrl+T` | Her zaman üstte modunu aç/kapa |
| `Space` | Tesbih sayacını artır |
| `R` | Tesbih sayacını sıfırla |
| `ESC` | Tepsiye küçült |

### Tesbihat Penceresi

| Tuş | İşlev |
|---|---|
| `1–7` | İlgili zikir sayacını artır |
| `R` | Tüm sayaçları sıfırla |
| `ESC` | Pencereyi kapat |

---

## 🏗️ Proje Yapısı

```
Iqamah/
├── FormMain.cs/Designer.cs        # Ana uygulama penceresi
├── FormSettings.cs/Designer.cs    # Ayarlar penceresi
├── FormBildirim.cs/Designer.cs    # Özel bildirim penceresi
├── FormTesbih.cs/Designer.cs      # Genişletilmiş tesbihat/zikir penceresi
├── FormSplash.cs/Designer.cs      # Açılış ekranı
├── FormAbout.cs/Designer.cs       # Hakkında penceresi
├── AudioHelper.cs                 # Sistem sesi susturma/açma (Core Audio API)
├── GunlukIcerik.cs                # Günlük hadis içerik yöneticisi
├── Program.cs                     # Uygulama giriş noktası
├── Properties/
│   ├── Settings.settings          # Kullanıcı ayarları
│   ├── Resources.resx             # Gömülü kaynaklar (sesler, görseller)
│   └── AssemblyInfo.cs            # Derleme meta verileri
└── Resources/
    ├── iqamah.png                 # Uygulama logosu
    ├── prayerNotif.wav            # Namaz vakti bildirim sesi
    └── alert.wav                  # Vakit öncesi uyarı sesi
```

---

## 🛠️ Teknoloji Altyapısı

- **Dil:** C# (.NET Framework 4.8)
- **Arayüz:** Windows Forms (WinForms)
- **UI Kütüphanesi:** [ReaLTaiizor](https://github.com/Starter007/ReaLTaiizor) — özel kontroller ve tema
- **JSON İşleme:** [Newtonsoft.Json](https://www.newtonsoft.com/json)
- **Namaz Vakitleri API:** [Aladhan API](https://aladhan.com/prayer-times-api)
- **Ses Kontrolü:** Windows Core Audio API (COM Interop)

---

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Iqamah'ı geliştirmek isterseniz:

1. Depoyu fork'layın
2. Bir özellik dalı oluşturun (`git checkout -b ozellik/harika-ozellik`)
3. Değişikliklerinizi commit'leyin (`git commit -m 'Harika özellik eklendi'`)
4. Dalı push'layın (`git push origin ozellik/harika-ozellik`)
5. Bir Pull Request açın

---

## 🙏 Teşekkürler

- [Aladhan API](https://aladhan.com/) — ücretsiz ve doğru namaz vakti verileri sağladığı için
- [Diyanet İşleri Başkanlığı](https://www.diyanet.gov.tr/) — haftalık hutbe içerikleri için
- Hadis koleksiyonu sahih kaynaklardan derlenmiştir (Buhârî, Müslim, Tirmizî, Ebû Dâvûd, Nesâî, İbn Mâce ve Ahmed b. Hanbel)

---

<p align="center">
  <strong>Iqamah</strong> — The second call, for the first duty.<br>
  ❤️ ile yapıldı — <a href="#">Sixteen Digital</a>
</p>
