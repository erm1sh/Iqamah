<p align="center">
  <img src="Iqamah/Resources/iqamahbanner.png" alt="Iqamah Logo" width="400">
</p>

<h1 align="center">Iqamah</h1>
<p align="center"><em>The second call, for the first duty.</em></p>

<p align="center">
  A Windows desktop application for tracking prayer times, receiving mindful reminders, and supporting your daily worship.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET_Framework-4.8-blue?logo=dotnet" alt=".NET Framework 4.8">
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows" alt="Windows">
  <img src="https://img.shields.io/badge/Version-2.0.0-green" alt="Version 2.0.0">
  <img src="https://img.shields.io/badge/License-MIT-yellow" alt="License">
</p>

---

## ✨ Features

### 🕌 Prayer Times
- **Accurate prayer schedule** — Fetches times for your location via the [Aladhan API](https://aladhan.com/prayer-times-api)
- **Live countdown** — Animated countdown to the next prayer
- **Active prayer highlight** — The current prayer period is visually emphasized on the main screen
- **Prayer tracking** — Mark each prayer as completed throughout the day
- **15+ calculation methods** — Diyanet, MWL, ISNA, Egyptian, Mecca, Karachi and more
- **Offline cache** — Stores the last fetched times locally; works without internet after first launch

### 🔔 Smart Notifications
- **Custom notification windows** — Beautiful, purpose-built notifications instead of standard Windows alerts
- **Snooze support** — Snooze notifications in 5-minute intervals (up to 3 times per prayer)
- **Pre-prayer reminder** — Get notified X minutes before each prayer (configurable)
- **Friday prayer notification** — Dedicated Jumu'ah reminder with customizable timing
- **Audio alerts** — Separate sounds for prayer time (`prayerNotif.wav`) and pre-prayer warning (`alert.wav`)
- **Auto-silence mode** — Automatically mutes your computer when a prayer time begins

### 📿 Dhikr & Tasbih
- **Digital tasbih counter** on the main screen for quick counting
- **Extended dhikr window** with 7 built-in counters:
  - SubhanAllah (33×)
  - Alhamdulillah (33×)
  - Allahu Akbar (33×)
  - La ilaha illallah (100×)
  - SubhanAllahi wa bihamdihi (100×)
  - Astaghfirullah (100×)
  - Salawat (100×)
- **Keyboard shortcuts** — Keys 1–7 to count, R to reset, ESC to close
- **Completion indicators** — Visual feedback when a target count is reached

### 📖 Daily Hadith
- **Rotating hadith display** — A collection of 25 hadith from authentic sources
- **Auto-rotation** — A new hadith every 30 seconds
- **Source references** — Each hadith includes its reference (Bukhari, Muslim, Tirmidhi, etc.)

### 🕋 Friday Khutbah
- **Quick access** to the weekly khutbah archive from the Diyanet (Turkish Presidency of Religious Affairs)
- **Always accessible** — The khutbah button is active every day, not just Fridays

### 📅 Dual Calendar
- Displays both **Gregorian and Hijri dates** simultaneously

### 🎨 Modern Interface
- **Dark theme** — Elegant, easy-on-the-eyes color scheme
- **Card-based layout** — Clean, organized, and well-structured UI
- **Splash screen** — Beautiful loading screen with Basmala on first launch
- **Borderless window** — Custom title bar with drag support
- **System tray** — Minimize to tray with right-click menu (Show, Settings, Dhikr, Exit)

---

## 🚀 Getting Started

### Requirements

- **Windows 10/11**
- **.NET Framework 4.8** (pre-installed on most Windows 10/11 systems)
- **Internet connection** (for fetching prayer times; offline cache available after first fetch)

### Installation (from source)

1. **Clone the repository**
   ```bash
   git clone https://github.com/erm1sh/Iqamah.git
   ```

2. **Open in Visual Studio**
   - Open `Iqamah.sln` with Visual Studio 2019 or later

3. **Restore NuGet packages**
   - The project uses `Newtonsoft.Json` and `ReaLTaiizor` — NuGet will install them automatically

4. **Build and Run**
   - Press `F5` or go to **Build → Build Solution**

### Ready-to-use

If you have a compiled release:
1. Download the latest release
2. Extract the archive
3. Run `Iqamah.exe`

---

## ⚙️ Settings

Access settings via the **⚙** button on the main screen or through the system tray right-click menu.

| Setting | Description |
|---|---|
| **City & Country** | Your location for accurate prayer time calculation |
| **Calculation Method** | Choose from 15+ methods (Diyanet, MWL, ISNA, etc.) |
| **Notifications** | Enable/disable prayer time notifications |
| **Pre-Prayer Alert** | Get notified X minutes before each prayer (1–60 min) |
| **Friday Notification** | Special reminder for Jumu'ah prayer |
| **Friday Khutbah** | Show/hide the khutbah access button |
| **Auto-Silence Mode** | Automatically mute computer at prayer time |
| **Always on Top** | Keep the window above all other windows |
| **Minimize to Tray** | Minimize to system tray instead of taskbar |

---

## ⌨️ Keyboard Shortcuts

### Main Window

| Key | Action |
|---|---|
| `F5` | Refresh prayer times |
| `F1` | About window |
| `Ctrl+T` | Toggle always-on-top |
| `Space` | Increment tasbih counter |
| `R` | Reset tasbih counter |
| `ESC` | Minimize to tray |

### Dhikr Window

| Key | Action |
|---|---|
| `1–7` | Increment the corresponding dhikr counter |
| `R` | Reset all counters |
| `ESC` | Close window |

---

## 🏗️ Project Structure

```
Iqamah/
├── FormMain.cs/Designer.cs        # Main application window
├── FormSettings.cs/Designer.cs    # Settings window
├── FormBildirim.cs/Designer.cs    # Custom notification window
├── FormTesbih.cs/Designer.cs      # Extended dhikr/tasbih window
├── FormSplash.cs/Designer.cs      # Splash screen
├── FormAbout.cs/Designer.cs       # About window
├── AudioHelper.cs                 # System audio mute/unmute (Core Audio API)
├── GunlukIcerik.cs                # Daily hadith content manager
├── Program.cs                     # Application entry point
├── Properties/
│   ├── Settings.settings          # User settings
│   ├── Resources.resx             # Embedded resources (sounds, images)
│   └── AssemblyInfo.cs            # Assembly metadata
└── Resources/
    ├── iqamah.png                 # App logo
    ├── prayerNotif.wav            # Prayer time notification sound
    └── alert.wav                  # Pre-prayer alert sound
```

---

## 🛠️ Tech Stack

- **Language:** C# (.NET Framework 4.8)
- **UI Framework:** Windows Forms (WinForms)
- **UI Library:** [ReaLTaiizor](https://github.com/Starter007/ReaLTaiizor) — custom controls and theming
- **JSON:** [Newtonsoft.Json](https://www.newtonsoft.com/json)
- **Prayer Times API:** [Aladhan API](https://aladhan.com/prayer-times-api)
- **Audio Control:** Windows Core Audio API (COM Interop)

---

## 🤝 Contributing

Contributions are welcome! To contribute to Iqamah:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

---

## 🙏 Acknowledgements

- [Aladhan API](https://aladhan.com/) — for providing free and accurate prayer time data
- [Diyanet İşleri Başkanlığı](https://www.diyanet.gov.tr/) — for weekly khutbah content
- Hadith collection sourced from authentic references (Bukhari, Muslim, Tirmidhi, Abu Dawud, Nasa'i, Ibn Majah, and Ahmad ibn Hanbal)

---

<p align="center">
  <strong>Iqamah</strong> — The second call, for the first duty.<br>
  Made with ❤️ — <a href="#">Sixteen Digital</a>
</p>
