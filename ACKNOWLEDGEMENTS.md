# 致谢

### 框架与依赖
- [Avalonia UI](https://avaloniaui.net/) — 跨平台 UI 框架（[AvaloniaUI/Avalonia](https://github.com/AvaloniaUI/Avalonia)）
- [SukiUI](https://github.com/kikipoulet/SukiUI) — Avalonia 主题与控件库
- [Tmds.DBus](https://github.com/tmds/Tmds.DBus) — Linux 下经 BlueZ D-Bus 与耳机通信

### 协议逆向与实现参考
以下为各品牌适配过程中实际参考的开源项目，命令码、帧格式与字段含义均来自其实机抓包或源码：

- **OPPO / OnePlus / realme**
  - [Leaf-lsgtky/OppoPods](https://github.com/Leaf-lsgtky/OppoPods) — OPPO 私有协议逆向基础
  - [1812z/OppoPods](https://github.com/1812z/OppoPods) — 功能实现参考
- **华为 FreeBuds**
  - [Nshpiter/HuaweiPods](https://github.com/Nshpiter/HuaweiPods) — 华为协议（帧格式、电量、降噪、EQ）逆向
  - [melianmiko/OpenFreebuds](https://github.com/melianmiko/OpenFreebuds) — 音质偏好等命令码参考（`sound_quality_preference.py`）
- **漫步者 Edifier**
  - [wh201906/mEDIFIER](https://github.com/wh201906/mEDIFIER) — 漫步者协议（含 Klinkore 分支的 SPP UUID 参考）
- **小米 / Redmi**
  - [CesurPolat/MiBudsClient](https://github.com/CesurPolat/MiBudsClient) — 小米协议参考
  - [web1n/android_packages_apps_XiaomiTWS](https://github.com/web1n/android_packages_apps_XiaomiTWS) — 小米 TWS App 参考
  - [web1n/android_packages_apps_XiaomiTWS_xiaomi-sdk](https://github.com/web1n/android_packages_apps_XiaomiTWS_xiaomi-sdk) — 小米 TWS SDK 参考
- **Apple AirPods / 通用 TWS 协议**
  - [silverpoetry/HyperEars](https://github.com/silverpoetry/HyperEars)
  - [Star-ZER0/Pods-Protocol-Reverse-Engineering](https://github.com/Star-ZER0/Pods-Protocol-Reverse-Engineering)
  - [librepods-org/librepods](https://github.com/librepods-org/librepods)

> vivo / iQOO 适配基于官方 App 的 Windows 端逆向（型号画像 GAIA 版本、噪声 SET 后缀等），相关实现已并入本项目代码，未单独引用外部仓库。
