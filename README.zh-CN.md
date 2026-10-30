> **个人分叉，独立开发。** `main` = 上游 [BrimDeck](https://github.com/MoFeng2223/BrimDeck) v1.2.3 + 本地补丁，
> 当前版本 **1.3.13**。相对上游的改动：折叠规则多两条（后台窗口铺满屏幕、任意窗口碰到岛所在的区域）、
> 收起时点击展开、指示条形态启动即可见、自定义配额可以是紧凑表格。详见[本地补丁](#本地补丁)。
>
> 本仓库**不发布安装包**，[安装](#安装)一节讲怎么自己打包；官方版本请去上游。

<div align="center">

<a href="README.md"><img src="https://img.shields.io/badge/English-3A3A3C?style=for-the-badge" alt="English"></a>
<a href="README.zh-CN.md"><img src="https://img.shields.io/badge/%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87-0A84FF?style=for-the-badge" alt="简体中文"></a>

<img src="docs/icon.png" width="96" alt="BrimDeck 图标">

# BrimDeck - Windows 灵动岛

BrimDeck 是 Windows 11 上的灵动岛，在屏幕顶部集中显示 AI 编程工具的额度与用量，以及正在播放的音乐。<br>
平时收起在屏幕顶部，只在需要时展开。<br>
Windows 原生应用，使用 C# 与 WPF 开发，注重性能与流畅度。

![版本](https://img.shields.io/badge/版本-1.3.13-98DBB0?style=flat-square)
[![许可证](https://img.shields.io/badge/许可证-Apache%202.0-E5A385?style=flat-square)](LICENSE)
![界面语言](https://img.shields.io/badge/界面-简体中文%20%7C%20English-B9A8FF?style=flat-square)

<p><a href="#功能">功能</a> · <a href="#本地补丁">本地补丁</a> · <a href="#安装">安装</a> · <a href="#快速开始">快速开始</a> · <a href="#隐私">隐私</a> · <a href="#常见问题">常见问题</a> · <a href="#参与开发">参与开发</a> · <a href="README.md">English</a></p>

<img src="docs/zh-CN/images/hero.png" width="100%" alt="BrimDeck 从屏幕顶部的刘海展开为 AI 用量面板，依次切换到音乐页和系统监控页，最后收起">

</div>

## 为什么选择 BrimDeck

- **额度集中显示**：Claude、Codex、Cursor、Antigravity 等工具的额度集中在一个面板上，不必逐个打开网页、命令行或应用查看。
- **简化额度查询操作**：平时收起在屏幕顶部，点一下展开，移开鼠标或按 Esc 收起。
- **媒体控制**：内联预览与控制正在播放的歌曲，封面、律动条与歌词随音乐变化。
- **系统监控**：CPU、内存、网速等读数常驻在刘海或胶囊中，一眼即可看到。
- **全屏免打扰**：全屏玩游戏或看视频时自动隐藏，避免误触展开；可在设置中调整。
- **开箱即用**：自动识别本机已登录的 Claude、Codex、Cursor 等工具，无需填写密钥或重新登录。
- **Windows 原生**：基于 .NET 与 WPF 构建，以较低的资源占用提供流畅的动画体验。

## 功能

### 收起形态

BrimDeck 平时位于屏幕顶部中央，提供刘海（默认）、胶囊和指示条三种样式。

<table>
  <tr>
    <td align="center"><img src="docs/zh-CN/images/compact-notch.png" width="279" alt="刘海"><br>刘海（默认）</td>
    <td align="center"><img src="docs/zh-CN/images/compact-capsule.png" width="258" alt="胶囊"><br>胶囊</td>
    <td align="center"><img src="docs/zh-CN/images/compact-line.png" width="128" alt="指示条"><br>指示条</td>
  </tr>
</table>

- 刘海与胶囊通过配额环显示各工具的最高配额使用率，并支持音乐预览，可显示封面、律动条、歌名或当前歌词。

  <img src="docs/zh-CN/images/compact-notch-lyrics.png" width="279" alt="刘海中显示歌词">

- 刘海与胶囊可以显示时间，与配额环或音乐一起显示时位于右侧，单独显示时居中；可以自定义配色。

  <img src="docs/zh-CN/images/compact-clock.png" width="567" alt="刘海中的时间：简约、数码管、衬线样式位于配额环右侧，单独显示时居中">

- 某个工具的配额使用率升到预警（70%）或告警（90%）时，收起形态会显示提醒 5 秒；可在设置中关闭。

  <img src="docs/zh-CN/images/compact-alert.png" width="388" alt="配额提醒：Claude 5 小时已用 91%">

- 刘海与胶囊可以显示系统读数，与配额环、音乐并排显示。

  <img src="docs/zh-CN/images/compact-monitor.png" width="474" alt="刘海中的系统读数：配额环旁显示核心柱、CPU、内存、GPU 与网速">

- 刘海、胶囊和指示条的尺寸与位置可在设置中调整。

- 窗口最大化、或后台有窗口铺满屏幕时默认切换为指示条；任意窗口压到岛所在的区域时也会切换（见[本地补丁](#本地补丁)）。全屏游戏或视频播放时默认隐藏，避免误触展开。

### AI 用量

<img src="docs/zh-CN/images/usage.png" width="100%" alt="AI 用量页：Claude、Codex、Cursor、Antigravity 四列配额">

<img src="docs/zh-CN/images/details.png" width="100%" alt="模型明细页：按应用和模型列出 Token 用量与费用">

- 按工具分列展示套餐、配额使用率与重置倒计时，最多同时显示 7 个工具。
- 每列底部汇总今日和最近 7 天的 Token 用量与费用估算。
- 可查看各模型的用量与费用明细，支持按工具和日期范围统计。

可自定义配额提供商，并分别设置各列的配额与用量统计来源，详见[支持的工具](docs/zh-CN/ai-tools.md)。

### 音乐

<img src="docs/zh-CN/images/music.png" width="63%" alt="音乐页：封面、歌名、歌词、进度条和播放控制">

- 显示歌曲信息、同步歌词与播放进度，支持播放控制、播放模式切换，以及受支持播放器的进度调节。
- 支持同时接入多个播放器，可手动切换或固定显示其中一个。

支持接入 Windows 系统媒体控制的播放器，并对部分播放器做了专门优化，详见[播放器支持](docs/zh-CN/music-players.md)。

### 系统监控

<img src="docs/zh-CN/images/monitor.png" width="100%" alt="系统监控页：CPU 占用与各核心使用率、GPU、内存、网速，以及占用最高的应用">

- 实时显示 CPU、GPU、内存的占用和网络速度，以及每个核心的使用率。有多块显卡时默认显示独显；点击大号 GPU 读数可切换到下一块，也可在“设置 › 系统监控 › 显卡”中指定。
- 按 CPU 或内存列出占用最高的应用，点击应用可查看详情。
- 按物理硬盘逐行显示已用空间，一块硬盘分成多个盘符时按盘符分段；只列内置硬盘，不含 U 盘、SD 卡、移动硬盘和网络盘。
- 显示 CPU、GPU 和固态硬盘的温度（可在设置中关闭；刘海或胶囊中的 CPU、GPU 和硬盘读数也可显示温度）。无需管理员权限，也不安装驱动；读不到的项不显示。GPU 温度与任务管理器相同；CPU 温度来自主板固件的 ACPI 热区，可能是主板而非 CPU 本身的温度，许多电脑不提供。
- 显示整机功耗（单位 W），带最近一分钟的曲线，以及打开页面后的峰值；悬停提示另有平均值和读数的组成（“设置 › 系统监控 › 显示功耗”；刘海或胶囊也可显示）。读数优先取电脑自带的功率计；没有则取笔记本用电池供电时的电池放电功率；再没有就由 CPU 功率和 NVIDIA 显卡的板卡功率估算（悬停提示中注明），估算不含显示器、存储、风扇和电源损耗。只在页面或刘海、胶囊显示它时读取，NVIDIA 显卡只在其有负载时才询问；无需管理员权限，也不安装驱动。
- 笔记本和平板还显示本机电池：电量（按主题风格画的电池，接通电源时电池中间显示插头），系统给出时间时其后显示剩余时间或充满所需时间；电池位于功耗这一行的右端。悬停提示中有充放电功率、Windows 电源模式、节电模式和电池健康度（满充容量与设计容量之比）。刘海或胶囊也可显示电量（“设置 › 系统监控 ›”读数表）。用电池供电时电量降到 25% 及以下用警告色、15% 及以下用临界色；电量正常、充电或开启节电模式时不会用这两种颜色。没有电池的电脑不显示这一项。
- 配色默认跟随面板主题，也提供多种预设配色，并支持自定义。

本页参考并改编自 Nongfsq 的 macOS 系统监控 [ftop](https://github.com/Nongfsq/ftop)（MIT 许可证）。

### 面板主题

<img src="docs/zh-CN/images/themes.png" width="100%" alt="同一个 AI 用量页在深色、浅色、Night Owl、Dracula、赛博朋克：边缘行者主题，以及一个自定义主题示例下的样子">

- 内置深色、浅色、One Dark Pro、GitHub Dark、GitHub Light、Dracula、Night Owl、赛博朋克：边缘行者等主题。
- 可以在设置的“面板主题”页修改背景、前景、强调色等颜色，并保存为自定义主题；也可以按[主题制作指南](docs/zh-CN/themes.md)编写主题文件。

## 本地补丁

这一版在上游 v1.2.3 之上加的东西；下面的功能说明里已经包含它们，这里只讲与上游的差别。

### 多两条折叠规则

上游按「最大化 / 无边框全屏 / 独占全屏」三种情境决定面板形态。这里加了两种，默认都收成指示条：

- **后台铺满**：前台窗口后面有另一个窗口铺满整块屏幕（最大化，或 F11 那样的无边框全屏）时折叠。
  这**先问该应用自己的规则**：在「设置 › 窗口行为 › 应用程序规则」里给它配了“保持原有样式”的应用，
  在后台铺满屏幕时也不会让岛折叠。
- **触碰即缩**：任意窗口只要有像素压到岛收起后所占的那块区域就折叠——不看它是否全屏、是否贴着屏幕边缘，
  也不管它是不是当前窗口。这条只看位置，不看应用。

两条规则在「设置 › 窗口行为」里各有下拉框（保持原有样式 / 显示为指示条 / 隐藏），对应
`settings.json` 的 `BackgroundFullscreen` 与 `Overlapped`。

> 判定用的是岛**静止时的完整区域**（按 `Style` 配置的形态算），不是当前显示的那条细线。
> 用细线判定的话，缩成细线之后就碰不到原来那个窗口了，会每 400 毫秒来回抖。

### 收起时点击展开

上游靠悬停展开，而指示条只有 4 像素高，稍一移动就会展开又收起。这里改成**点击展开**，并把点击热区放大到
220×26，细线也点得中。`settings.json` 的 `ClickToExpand` 设为 `false` 可回到悬停展开。

### 指示条形态启动即可见

上游的开机动画是“圆点膨胀成收起形态”，指示条没有可膨胀的余地，会一直停在不透明度 0。这里让指示条直接显示。

### 自定义配额可以是表格

自定义配额来源新增 `kind: "rows"`：一张卡片里上下排多行，每行「名称 · 附注 · 读数」，整张表共用一个网格，
同一列在每行对齐、缺的留空；带 `percent` 的行旁边有一条小细条，标了 `remaining: true` 就按剩余比例画。

适合“一堆小数字”的来源：一个号一张卡片的话，一页只放得下两张，六个号要翻三页。

### 诊断

`%LOCALAPPDATA%\BrimDeck\context.log` 每次形态变化记一行，含 `ctx=`（判定结果）、`app=`（当时生效的应用）、
`kind=`（铺满方式，`Maximized` 或 `Borderless`）。排查“这会儿为什么是横条”直接看它。

## 安装

本仓库**不发布安装包**，需要从源码自行打包。官方版本和安装包请去[上游](https://github.com/MoFeng2223/BrimDeck)。

需要 Windows 11（x64）、[.NET 10 SDK](https://dotnet.microsoft.com/download) 和 PowerShell 7：

```powershell
git clone https://github.com/mozellaxaustelllmt-lgtm/BrimDeck.git
cd BrimDeck
pwsh scripts/Publish-Release.ps1 -Version 1.3.13
```

产物在 `artifacts\releases\`：`BrimDeck-1.3.13-Setup.exe`（运行后按提示安装）和
`BrimDeck-1.3.13-Portable-x64.zip`（解压后运行 `BrimDeck.exe`）。打包脚本会自己还原 Inno Setup；
如出现“Windows 已保护你的电脑”提示，点击“更多信息”→“仍要运行”。

设置和数据都在 `%LOCALAPPDATA%\BrimDeck`。应用内更新查的是上游的发布，本地版本号（1.3.x）高于上游，
所以不会提示你“更新”到旧版。

## 快速开始

1. 安装并启动 BrimDeck 后，面板会出现在主显示器顶部中央，默认显示 Claude 和 Codex。
2. 点一下面板即可展开，移开鼠标或按 Esc 收起。
3. 点击展开面板右上角的设置按钮，即可添加工具或调整设置；也可在展开的面板上点击右键，或双击系统托盘图标、通过托盘图标的右键菜单进入设置。

## 卸载

安装版：前往 Windows 设置中的“应用”卸载。免安装版：先在设置中关闭开机自启动（如已开启），再删除它的文件夹。

## 隐私

- 仅读取应用已有的登录状态与用量记录，不会修改、续期或注销它们的登录。
- 读取的登录令牌仅在内存中使用，不写入磁盘；手动填写的 API 密钥使用 Windows 的加密功能保存在本机。
- 仅在获取配额与用量、同步模型单价、获取歌词与封面、检查更新时联网，不会上传会话内容，也不会收集使用数据。

读取了哪些文件、会连接哪些地址，详见[数据与隐私](docs/zh-CN/privacy.md)。

## 常见问题

**某个工具显示"未连接"或"等待更新"怎么办？**
请确认该工具已在这台电脑上登录；例如 Antigravity 读取配额时需要桌面版正在运行。BrimDeck 读取不到数据时，只显示实际状态，不会显示虚假的数值。

**显示的费用是我实际支付的金额吗？**
不是。费用按接口金额或公开的模型单价计算，适合用来了解用量高低；订阅套餐的实际扣费以各服务商的账单为准。

## 参与开发

这是个人分叉，**不接 Pull Request**。上游的 Issues、Discussions 和路线图在
[MoFeng2223/BrimDeck](https://github.com/MoFeng2223/BrimDeck)。

跟随上游：

```bash
git fetch origin main
git merge origin/main
```

合并时注意 `SettingsMigrations`：步骤按**上游版本号**标注，而本分支的版本号已经更高，
标签比文件记录的版本旧的步骤不会执行。合并后要把新步骤的版本号改成本分支要发的版本，
并把 `CompactReadingTests` 里的 `Running` 常量一起改。

## 许可证

BrimDeck 采用 [Apache License 2.0](LICENSE)。第三方组件的许可证见 [ThirdPartyNotices.txt](src/BrimDeck/ThirdPartyNotices.txt)。

系统监控页参考并改编自 Nongfsq 的 [ftop](https://github.com/Nongfsq/ftop)，ftop 采用 MIT 许可证，感谢原作者。
