# Full-Stack Development Practice (全端開發練習作品集)

C#、ASP.NET Core Web API、SQL Server 與前端網頁開發的學習與實作紀錄。

## 專案簡介

本專案用來整理全端網頁開發的學習成果，包含 C# 基礎練習、ASP.NET Core Web API、SQL Server 資料庫操作，以及 HTML、CSS、JavaScript、Bootstrap、jQuery、Vue 3 和 React 等前端技術練習。

除了單一技術的練習，也實作了一個書籍管理系統，將前端頁面、後端 API 與 SQL Server 資料庫串接，練習基本的 CRUD 資料操作流程。

本作品集以實際完成的練習與功能為主，持續整理程式碼、測試紀錄及開發過程中的問題排除經驗。

## 技術與工具

| 類別 | 技術或工具 |
|---|---|
| 後端 | C#、ASP.NET Core Web API、Entity Framework Core |
| 資料庫 | Microsoft SQL Server、T-SQL |
| 前端 | HTML、CSS、JavaScript、Bootstrap |
| 前端延伸練習 | jQuery、Vue 3、React |
| API 測試 | Postman |
| 開發工具 | Visual Studio 2026、Visual Studio Code、SQL Server Management Studio |
| 版本控制 | Git、GitHub |

以上包含專案實作技術與獨立練習技術；不代表所有技術都已整合到同一個系統中。

## 專案結構

```text
Full-Stack-Development-Practice/
├── Backend-Practice/
│   ├── 01-CSharp-Basics/
│   │   ├── CSharp01_InputOutput/
│   │   ├── CSharp02_Variables/
│   │   └── ...
│   └── 02-ASP.NET-Core-WebAPI/
│       └── BookManagement.Api/
│           ├── BookManagement.Api/
│           │   ├── Controllers/
│           │   ├── Data/
│           │   ├── Migrations/
│           │   └── Models/
│           ├── database/
│           └── screenshots/
├── Frontend-Practice/
│   ├── 01-Frontend-Basics/
│   └── 02-BookManagement.Frontend/
│       ├── api.js
│       ├── index.html
│       ├── vue.html
│       └── screenshots/
├── .gitignore
└── README.md
```

## 一、C# 基礎練習

`Backend-Practice/01-CSharp-Basics/`

整理 C# 基礎與實作練習，涵蓋：

- 輸入與輸出、變數及資料型別
- 型別轉換與運算子
- 條件判斷與迴圈
- 方法與方法多載
- 陣列與字串
- 集合、類別與物件
- 建構子、屬性、繼承與多型
- 介面與列舉
- 例外處理與檔案操作
- JSON、非同步操作及綜合練習

此區域主要用來建立 C# 語法與物件導向程式設計的基礎。

## 二、書籍管理系統

### 專案位置

- 後端：`Backend-Practice/02-ASP.NET-Core-WebAPI/BookManagement.Api/`
- 前端：`Frontend-Practice/02-BookManagement.Frontend/`

### 系統架構

```text
使用者
  │
  ▼
HTML / JavaScript 或 Vue 3
  │
  │ HTTP Request / JSON
  ▼
ASP.NET Core Web API
  │
  ▼
Entity Framework Core
  │
  ▼
Microsoft SQL Server
```

前端透過 HTTP 請求呼叫後端 API，後端使用 Entity Framework Core 與 SQL Server 進行資料操作。

### 已實作及測試的功能

- 新增書籍（Create）
- 查詢書籍（Read）
- 修改書籍（Update）
- 刪除書籍（Delete）
- 基本輸入驗證與錯誤回應
- 前端透過 API 與資料庫進行資料操作
- 使用 JavaScript 與 Vue 3 製作兩種前端介面
- 使用 Postman 與前端操作測試 API
- 透過 SQL Server Management Studio 檢查資料

### 前端版本

| 檔案 | 說明 |
|---|---|
| `index.html` | 使用原生 JavaScript 製作的書籍管理介面 |
| `api.js` | 集中管理 API 呼叫 |
| `vue.html` | 使用 Vue 3 CDN 製作的書籍管理介面 |

兩種前端介面皆連接同一個後端 API，因此可透過資料庫確認操作結果是否一致。

### 測試紀錄

專案中的 `screenshots/` 資料夾保存部分操作與測試畫面，包括：

- 新增、查詢、修改及刪除書籍
- API 驗證錯誤
- SQL Server 資料檢查
- JavaScript 與 Vue 3 前端操作

這些截圖用來輔助說明實際測試過的功能。

## 三、前端基礎練習

`Frontend-Practice/01-Frontend-Basics/`

依照學習順序整理不同主題的練習檔案：

- HTML：個人資料卡、表單、表格、連結與圖片
- CSS：選擇器、盒模型、Flexbox、Grid
- JavaScript：變數、條件、迴圈、函式、陣列與物件
- DOM：元素選取、更新、事件及動態元素
- 表單驗證與事件代理
- Bootstrap：導覽列、表單、按鈕、表格及響應式版面
- 非同步 JavaScript、Fetch API 與 jQuery AJAX
- Vue 3 基礎及 React JSX、Props、useState 練習

這些檔案以獨立練習為主，方便依照主題閱讀與測試。

## 四、開發環境

開始執行前，請先準備：

- Windows 開發環境
- .NET SDK
- Visual Studio 2022 或其他支援 .NET 的開發工具
- Microsoft SQL Server
- SQL Server Management Studio（SSMS）
- 支援 HTML 與 JavaScript 的瀏覽器
- Git（選用，用於版本控制）

本專案開發時使用的 .NET SDK 版本為 10.0.402。若使用其他版本，請依照專案的目標框架及套件相容性調整。

## 五、本機執行方式

### 1. 取得專案

```bash
git clone https://github.com/hankcch2003/Full-Stack-Development-Practice.git
cd Full-Stack-Development-Practice
```

### 2. 設定 SQL Server

1. 啟動 SQL Server 服務。
2. 使用 SSMS 確認可以連線。
3. 檢查後端 `appsettings.Development.json` 中的連線字串。
4. 確認連線字串中的伺服器名稱、資料庫名稱與本機環境一致。

連線字串位於：

`Backend-Practice/02-ASP.NET-Core-WebAPI/BookManagement.Api/BookManagement.Api/appsettings.Development.json`

目前開發環境使用 Windows 整合驗證的設定範例：

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BookManagement;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

實際設定請以專案中的組態與 `Program.cs` 為準。若 SQL Server 使用不同的執行個體名稱，請修改 `Server` 值。

`TrustServerCertificate=True` 是開發環境中的憑證設定，不應未經評估直接沿用於正式環境。

### 3. 建立資料庫

可先檢查：

`Backend-Practice/02-ASP.NET-Core-WebAPI/BookManagement.Api/database/`

此資料夾包含資料庫建立及資料驗證 SQL 腳本。

如果專案使用 EF Core Migrations 管理資料表，請先確認目前資料庫狀態，再依照專案所使用的 SDK 與套件執行適當的 Migration 指令。

例如，在包含 `.csproj` 的後端專案目錄中：

```bash
dotnet ef database update
```

如果尚未安裝 EF Core CLI 工具，或缺少相應套件，請先依專案的套件版本完成設定。

### 4. 啟動後端 API

進入後端專案目錄：

```bash
cd Backend-Practice/02-ASP.NET-Core-WebAPI/BookManagement.Api/BookManagement.Api
dotnet restore
dotnet build
dotnet run
```

開發期間曾使用以下 API 位址：

- HTTP：`http://localhost:5145`
- HTTPS：`https://localhost:7076`

實際啟動位址請以終端機輸出及 `Properties/launchSettings.json` 為準。

### 5. 啟動前端

確認後端 API 正常執行後，再開啟前端：

`Frontend-Practice/02-BookManagement.Frontend/`

- 使用瀏覽器開啟 `index.html`，測試原生 JavaScript 版本。
- 使用瀏覽器開啟 `vue.html`，測試 Vue 3 版本。

`api.js` 中的 API 基底網址需要與實際後端位址一致。

若瀏覽器因跨來源政策（CORS）或本機檔案來源限制而無法呼叫 API，請檢查瀏覽器開發者工具與後端 CORS 設定，並考慮使用本機 HTTP 靜態檔案伺服器提供前端頁面。

## 六、開發過程中的問題與解決方式

### 1. Git 無法識別提交作者

**遇到的問題**

第一次執行 `git commit` 時，出現：

```text
Author identity unknown
fatal: unable to auto-detect email address
```

**原因**

Git 尚未設定提交紀錄使用的作者名稱及電子郵件。

**解決方式**

設定 Git 作者資訊：

```bash
git config --global user.name "你的 GitHub 使用者名稱"
git config --global user.email "你的 GitHub 關聯電子郵件"
```

再透過以下指令確認：

```bash
git config --global user.name
git config --global user.email
```

這是本專案版本控制初始化過程中實際遇到並解決的問題。

### 2. Git 因 safe.directory 阻止操作

**遇到的問題**

在專案目錄執行 Git 指令時，出現安全目錄相關警告，導致部分操作失敗。

**原因**

Git 對目前目錄的安全性或擁有者判定不符合預期。

**解決方式**

確認這是自己的專案目錄後，將該目錄加入 Git 安全目錄設定：

```bash
git config --global --add safe.directory E:/Full-Stack-Development-Practice
```

之後重新執行原本的 Git 指令。

這個設定只應用於自己信任的目錄，不應將不明或他人控制的目錄一律加入安全清單。

### 3. 本機與 GitHub 的提交歷史不同

**遇到的問題**

本機已建立第一筆提交，但 GitHub 上原本已存在另一筆提交，因此兩邊的歷史並非從同一個提交開始。

**原因**

本機使用 `git init` 建立新歷史，而 GitHub 儲存庫先前已建立遠端提交。

**解決方式**

先抓取遠端提交，再允許合併不同歷史：

```bash
git fetch origin
git merge origin/main --allow-unrelated-histories
```

確認合併成功後，再推送：

```bash
git push -u origin main
```

本專案已成功完成這次合併與推送，沒有使用強制推送覆蓋遠端歷史。

### 4. Git 出現 LF 與 CRLF 換行提示

**遇到的問題**

Windows 環境下，Git 提示檔案的 LF 換行格式可能會轉換為 CRLF。

**原因**

不同作業系統及 Git 設定可能採用不同的文字檔換行格式。

**處理方式**

若只是換行格式提示，且檔案內容正常，通常不代表提交失敗。可先確認：

```bash
git status
```

如果未出現實際錯誤，通常不需要因此重建專案或刪除檔案。

### 5. 常見問題：後端無法連接 SQL Server

**可能原因**

- SQL Server 服務尚未啟動。
- 連線字串中的伺服器名稱不正確。
- 資料庫尚未建立或 Migration 尚未套用。
- Windows 整合驗證或資料庫權限不足。

**排查方式**

1. 先使用 SSMS 測試相同伺服器是否可連線。
2. 檢查 `appsettings.Development.json` 的連線字串。
3. 查看後端終端機中的完整錯誤訊息。
4. 確認資料庫名稱、資料表及 Migration 狀態。

這是可供後續除錯參考的排查流程，不代表每一種情況都已在本專案實際發生。

### 6. 常見問題：前端無法呼叫 API

**可能原因**

- 後端尚未啟動。
- `api.js` 中的 API 位址或連接埠不正確。
- 瀏覽器攔截跨來源請求。
- API 回傳錯誤，或請求資料格式不符合預期。

**排查方式**

1. 確認後端已正常啟動。
2. 檢查 `api.js` 中的 API 基底網址。
3. 使用 Postman 獨立測試 API。
4. 查看瀏覽器開發者工具的 Console 與 Network。
5. 確認後端 CORS 設定、HTTP 狀態碼及回傳內容。

先將問題分成前端請求、後端處理及資料庫操作三個層次，有助於縮小除錯範圍。

## 七、目前學習成果

透過本專案，練習了以下開發流程：

- 使用 C# 建立基礎程式與物件導向概念。
- 使用 ASP.NET Core Web API 處理 HTTP 請求。
- 使用 Entity Framework Core 連接 SQL Server。
- 使用 SQL 腳本檢查資料庫及資料操作結果。
- 使用 JavaScript Fetch API 呼叫後端服務。
- 使用 Vue 3 製作另一種前端介面。
- 使用 Postman、瀏覽器開發者工具及 SSMS 協助測試。
- 使用 Git 與 GitHub 管理及公開專案原始碼。
- 記錄開發環境設定、版本控制與常見錯誤排查方式。

本作品集主要呈現學習過程、實作內容及目前已驗證的功能，並持續改善程式碼結構、文件及測試品質。