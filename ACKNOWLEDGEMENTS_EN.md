# Acknowledgements

### Frameworks & Dependencies
- [Avalonia UI](https://avaloniaui.net/) — Cross-platform UI framework ([AvaloniaUI/Avalonia](https://github.com/AvaloniaUI/Avalonia))
- [SukiUI](https://github.com/kikipoulet/SukiUI) — Avalonia theme & control library
- [Tmds.DBus](https://github.com/tmds/Tmds.DBus) — Linux BlueZ D-Bus communication with the earbuds

### Protocol Reverse-Engineering & Implementation References
The open-source projects actually referenced while adapting each brand. Command codes, frame formats, and field
meanings come from their real-device captures or source code:

- **OPPO / OnePlus / realme**
  - [Leaf-lsgtky/OppoPods](https://github.com/Leaf-lsgtky/OppoPods) — basis for OPPO proprietary protocol reverse engineering
  - [1812z/OppoPods](https://github.com/1812z/OppoPods) — feature implementation reference
- **Huawei FreeBuds**
  - [Nshpiter/HuaweiPods](https://github.com/Nshpiter/HuaweiPods) — Huawei protocol (frame format, battery, ANC, EQ) reverse engineering
  - [melianmiko/OpenFreebuds](https://github.com/melianmiko/OpenFreebuds) — sound-quality preference command codes (`sound_quality_preference.py`)
- **Edifier**
  - [wh201906/mEDIFIER](https://github.com/wh201906/mEDIFIER) — Edifier protocol (incl. SPP UUID from the Klinkore fork)
- **Xiaomi / Redmi**
  - [CesurPolat/MiBudsClient](https://github.com/CesurPolat/MiBudsClient) — Xiaomi protocol reference
  - [web1n/android_packages_apps_XiaomiTWS](https://github.com/web1n/android_packages_apps_XiaomiTWS) — Xiaomi TWS app reference
  - [web1n/android_packages_apps_XiaomiTWS_xiaomi-sdk](https://github.com/web1n/android_packages_apps_XiaomiTWS_xiaomi-sdk) — Xiaomi TWS SDK reference
- **Apple AirPods / General TWS protocols**
  - [silverpoetry/HyperEars](https://github.com/silverpoetry/HyperEars)
  - [Star-ZER0/Pods-Protocol-Reverse-Engineering](https://github.com/Star-ZER0/Pods-Protocol-Reverse-Engineering)
  - [librepods-org/librepods](https://github.com/librepods-org/librepods)

> vivo / iQOO support is based on Windows-side reverse engineering of the official app (per-model GAIA version,
> noise SET suffix, etc.). The implementation is merged into this project's code and does not reference a separate
> external repository.
