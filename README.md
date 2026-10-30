> **Personal fork, developed on its own line.** `main` is upstream [BrimDeck](https://github.com/MoFeng2223/BrimDeck) v1.2.3
> plus local patches, currently **1.3.13**. What differs from upstream: two more fold rules (a window filling the screen
> behind the front one, and any window reaching the area where the island sits), opening on a click, an Indicator that is
> visible at startup, and custom quotas that can be shown as one compact table. See [Local changes](#local-changes).
>
> This repository **publishes no installers**; [Install](#install) covers building it. For the official build go upstream.

<div align="center">

<a href="README.md"><img src="https://img.shields.io/badge/English-0A84FF?style=for-the-badge" alt="English"></a>
<a href="README.zh-CN.md"><img src="https://img.shields.io/badge/%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87-3A3A3C?style=for-the-badge" alt="简体中文"></a>

<img src="docs/icon.png" width="96" alt="BrimDeck icon">

# BrimDeck - A Dynamic Island for Windows

BrimDeck is a Dynamic Island for Windows 11 that brings your AI coding tool quotas, usage and the music you are playing together at the top of the screen.<br>
It stays collapsed at the top of the screen and opens only when you need it.<br>
A native Windows app built with C# and WPF, designed for performance and smoothness.

![Version](https://img.shields.io/badge/Version-1.3.13-98DBB0?style=flat-square)
[![License](https://img.shields.io/badge/License-Apache%202.0-E5A385?style=flat-square)](LICENSE)
![Interface languages](https://img.shields.io/badge/Interface-English%20%7C%20%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87-B9A8FF?style=flat-square)

<p><a href="#features">Features</a> · <a href="#local-changes">Local changes</a> · <a href="#install">Install</a> · <a href="#quick-start">Quick start</a> · <a href="#privacy">Privacy</a> · <a href="#faq">FAQ</a> · <a href="#contributing">Contributing</a> · <a href="README.zh-CN.md">简体中文</a></p>

<img src="docs/en-US/images/hero.png" width="100%" alt="BrimDeck opens from the notch at the top of the screen into the AI usage panel, switches to the music page and then the system monitor page, then collapses">

</div>

## Why BrimDeck

- **All quotas in one place**: Quotas for Claude, Codex, Cursor, Antigravity and more are shown in a single panel, so you no longer open each website, command line or app to check them.
- **Quota checks made simple**: BrimDeck stays collapsed at the top of the screen. Click it to open it, and move away or press Esc to close it.
- **Media control**: Preview and control the song that is playing inline; the cover, equalizer and lyrics follow the music.
- **System monitor**: CPU, memory, network speed and other readings stay in the notch or capsule, visible at a glance.
- **No interruptions in full screen**: Hides automatically while you play full-screen games or watch full-screen video, so it never opens by accident. Adjustable in settings.
- **Works out of the box**: Detects Claude, Codex, Cursor and other tools already signed in on this PC. No keys to enter and no extra sign-in.
- **Native Windows**: Built on .NET and WPF to deliver smooth animation with low resource use.

## Features

### Collapsed styles

BrimDeck sits at the top center of the screen and comes in three styles: Notch (default), Capsule and Indicator.

<table>
  <tr>
    <td align="center"><img src="docs/en-US/images/compact-notch.png" width="279" alt="Notch"><br>Notch (default)</td>
    <td align="center"><img src="docs/en-US/images/compact-capsule.png" width="258" alt="Capsule"><br>Capsule</td>
    <td align="center"><img src="docs/en-US/images/compact-line.png" width="128" alt="Indicator"><br>Indicator</td>
  </tr>
</table>

- Notch and Capsule show the highest quota usage of each tool as a ring, and preview the music that is playing with its cover, an equalizer, and the title or the current lyric line.

  <img src="docs/en-US/images/compact-notch-lyrics.png" width="279" alt="Notch showing a lyric line">

- The notch and capsule can show the time. It sits on the right when shown with the quota rings or music, and is centered when shown alone; its colors can be customized.

  <img src="docs/en-US/images/compact-clock.png" width="567" alt="Clock in the notch: Simple, Seven segment and Serif styles beside the quota rings, and the clock shown alone, centered">

- When a tool's quota usage rises to the warning (70%) or critical (90%) level, the collapsed view shows a notice for 5 seconds. You can turn this off in settings.

  <img src="docs/en-US/images/compact-alert.png" width="390" alt="Quota notice: Claude 5-hour 91% used">

- Notch and Capsule can show system readings next to the quota rings and the music.

  <img src="docs/en-US/images/compact-monitor.png" width="474" alt="System readings in the notch: core columns, CPU, memory, GPU and network speed beside the quota rings">

- The size and position of the Notch, Capsule and Indicator can be adjusted in settings.

- By default it turns into the Indicator when a window is maximized or when a window behind the front one fills the screen, and also when any window reaches the area it sits in (see [Local changes](#local-changes)). It hides during full-screen games or video so it never opens by accident.

### AI usage

<img src="docs/en-US/images/usage.png" width="100%" alt="AI usage page: quotas of Claude, Codex, Cursor and Antigravity in four columns">

<img src="docs/en-US/images/details.png" width="100%" alt="Model details page: tokens and cost by app and model">

- One column per tool shows the plan, quota usage and reset countdowns, for up to 7 tools at once.
- The bottom of each column totals tokens and estimated cost for today and the last 7 days.
- Token and cost details are available for each model, filtered by tool and date range.

You can choose the quota providers and set the quota and usage source of each column separately. See [Supported tools](docs/en-US/ai-tools.md).

### Music

<img src="docs/en-US/images/music.png" width="63%" alt="Music page: cover, title, lyrics, progress bar and playback controls">

- Shows song information, synced lyrics and playback progress, with playback controls, playback mode switching and seeking in supported players.
- Works with several players at once; switch between them or pin one.

Works with players that use Windows media controls, with extra support for some players. See [Supported players](docs/en-US/music-players.md).

### System monitor

<img src="docs/en-US/images/monitor.png" width="100%" alt="System monitor page: CPU usage and each core, GPU, memory, network speed and the busiest apps">

- Shows CPU, GPU and memory usage and network speed in real time, along with the usage of each core. With more than one graphics card, the discrete one shows by default; click the large GPU reading to show the next card, or choose one under Settings › System monitor › GPU.
- Lists the busiest apps by CPU or memory; click an app for its details.
- Shows the space in use on each physical drive, one line per drive, with a segment per letter for a drive split into several; only internal drives are listed, not USB sticks, SD cards, external or network drives.
- Shows CPU, GPU and solid-state drive temperatures (you can turn them off in settings; the CPU, GPU and drive readings in the notch or capsule can show them too). No administrator rights or drivers are needed; sensors that cannot be read are left out. The GPU temperature is the one Task Manager shows; the CPU temperature comes from the firmware's ACPI thermal zones, may be the board's rather than the CPU's own, and many PCs do not provide it.
- Shows the whole machine's power draw in watts, with the last minute as a curve and the peak since the page was opened; the tooltip adds the mean and what the figure is made of (Settings › System monitor › Show power; the notch or capsule can show it too). The figure comes from the PC's own power meter if it has one, else from the battery's discharge while a laptop runs on battery, else it is an estimate (the tooltip says so) from the processor's power and an NVIDIA graphics card's board power, which leaves out the display, storage, fans and power-supply loss. It is read only while the page or the notch or capsule shows it, and the NVIDIA card is asked only while it is working. No administrator rights or drivers are needed.
- On a laptop or tablet, also shows this PC's own battery: the charge as a battery drawn in the theme's style (with a plug in it while the PC is plugged in), followed by the time left or to full where Windows gives one; it sits at the right end of the power line. Its tooltip has the rate in watts, the Windows power mode, Battery saver and the battery's health (full-charge capacity against design capacity). The notch or capsule can show the charge too (Settings › System monitor › the readings table). At 25% or less the charge takes the warning color and at 15% or less the critical color while the PC runs on battery; a normal charge, charging or Battery saver never takes either color. PCs without a battery show nothing of it.
- Colors follow the panel theme by default; several preset color schemes are offered, and you can make your own.

The page is adapted from [ftop](https://github.com/Nongfsq/ftop) by Nongfsq (MIT License), a system monitor for macOS.

### Panel themes

<img src="docs/en-US/images/themes.png" width="100%" alt="The same AI usage page in the Dark, Light, Night Owl, Dracula and Cyberpunk: Edgerunners themes, and in an example custom theme">

- Built-in themes include Dark, Light, One Dark Pro, GitHub Dark, GitHub Light, Dracula, Night Owl and Cyberpunk: Edgerunners.
- On the Panel theme page in settings, you can change the background, foreground, accent and other colors and save them as a custom theme, or write a theme file by following the [theme guide](docs/en-US/themes.md).

## Local changes

What this build adds on top of upstream v1.2.3. The feature sections below describe it all; this section is only what differs.

### Two more fold rules

Upstream decides the shape from three cases: maximized, borderless full screen and exclusive full screen. This build adds
two, both folding to the Indicator by default:

- **Filled behind**: another window fills the whole screen behind the one in front — maximized, or borderless full screen
  such as F11. This one **asks that app's own rule first**: an app given "Keep style" under Settings › Window behavior ›
  App rules is left alone even while it fills the screen in the background.
- **Touched**: any window whose pixels reach the area the island occupies when collapsed folds it — whether or not it fills
  the screen, is snapped to an edge, or is the window in front. This one goes by position only, never by app.

Both appear under Settings › Window behavior with their own choices (keep style / show as indicator / hide), as
`BackgroundFullscreen` and `Overlapped` in `settings.json`.

> The test uses the island's **whole resting area** — the shape its configured style would take — not the thin line it may
> be showing. A box that shrank to the line would stop touching the very window that made it fold, and the island would
> flip every 400 ms.

### Opens on a click

Upstream opens on hover, and the Indicator is four pixels tall, so the smallest movement opens and closes it. Here it opens
on a click, with a 220×26 click target so the line is easy to hit. Set `ClickToExpand` to `false` in `settings.json` for
the hover behaviour.

### The Indicator is visible at startup

Upstream's start animation swells a dot into the collapsed shape; the line has no room for that and stays at zero opacity.
Here the line appears at once.

### A custom quota can be a table

A custom quota source can now return `kind: "rows"`: one card holding a table of lines, each with a name, cells and a
reading. All lines share one grid, so a column starts at the same place on every line and a line with nothing for a column
leaves it empty. A line with `percent` gets a short bar beside it, drawn from what is left when it also sets
`remaining: true`.

It suits a source with many small numbers: one card per account would show two per page, so six accounts cost three page turns.

### Diagnostics

`%LOCALAPPDATA%\BrimDeck\context.log` records a line per shape change with `ctx=` (the context detected), `app=` (the app
it resolved for) and `kind=` (`Maximized` or `Borderless`). It is the quickest way to see why the island is a line.

## Install

This repository **publishes no installers**; build it from source. The official build and its installers are at [upstream](https://github.com/MoFeng2223/BrimDeck).

Requires Windows 11 (x64), the [.NET 10 SDK](https://dotnet.microsoft.com/download) and PowerShell 7:

```powershell
git clone https://github.com/mozellaxaustelllmt-lgtm/BrimDeck.git
cd BrimDeck
pwsh scripts/Publish-Release.ps1 -Version 1.3.13
```

The artifacts land in `artifacts\releases\`: `BrimDeck-1.3.13-Setup.exe` (run it and follow the steps) and
`BrimDeck-1.3.13-Portable-x64.zip` (extract it and run `BrimDeck.exe`). The script restores Inno Setup itself. If
Windows shows "Windows protected your PC", select "More info", then "Run anyway".

Settings and data live in `%LOCALAPPDATA%\BrimDeck`. The in-app update check looks at the upstream releases; this
branch's version (1.3.x) is higher, so it will not offer to "update" you to an older build.

## Quick start

1. After you install and start BrimDeck, the panel appears at the top center of the primary display, showing Claude and Codex by default.
2. Click the panel to open it; move away or press Esc to close it.
3. Select the settings button at the top right of the open panel to add tools or change settings. You can also right-click the open panel, double-click the tray icon, or right-click the tray icon.

## Uninstall

Installer: uninstall BrimDeck from Apps in Windows Settings. Portable: turn off starting with Windows in settings if it is on, then delete its folder.

## Privacy

- Reads only the sign-in state and usage records that apps already keep, and never changes, renews or ends their sign-ins.
- Sign-in tokens are used only in memory and never written to disk; API keys you enter are stored on this PC, encrypted by Windows.
- Goes online only to read quotas and usage, update model prices, fetch lyrics and covers, and check for updates. Conversations are never uploaded, and no usage data is collected.

For the files BrimDeck reads and the addresses it connects to, see [Data and privacy](docs/en-US/privacy.md).

## FAQ

**A tool shows "Not connected" or "Waiting for update". What should I do?**
Make sure the tool is signed in on this PC; for example, Antigravity needs its desktop app running for its quota to be read. When BrimDeck cannot read the data, it shows the actual status and never makes up numbers.

**Is the cost shown what I actually pay?**
No. Costs come from the amounts reported by each service or from public model prices, and are meant to show how much you use. Your actual subscription charges are on each provider's bill.

## Contributing

This is a personal fork and takes no pull requests. Upstream's issues, discussions and roadmap are at
[MoFeng2223/BrimDeck](https://github.com/MoFeng2223/BrimDeck).

Following upstream:

```bash
git fetch origin main
git merge origin/main
```

One thing to watch: `SettingsMigrations` labels its steps with the **upstream** version, and this branch's version is
already higher, so a step labelled below the file's version never runs. Relabel a new step to the version this branch
builds, and change the `Running` constant in `CompactReadingTests` with it.

## License

BrimDeck is licensed under the [Apache License 2.0](LICENSE). Third-party licenses are listed in [ThirdPartyNotices.txt](src/BrimDeck/ThirdPartyNotices.txt).

The system monitor page is adapted from [ftop](https://github.com/Nongfsq/ftop) by Nongfsq, licensed under the MIT License; thanks to its author.
