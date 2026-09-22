# 📚 BookVault

> A modern book catalog and inventory management web application built with ASP.NET Core MVC and Entity Framework Core.

---

## 🖥️ Overview

**BookVault** is a full-stack web application that allows users to manage a digital book inventory. It provides a clean, responsive interface to add, view, edit, search, and delete book records — including details like title, author, genre, price, and stock availability.

The project follows the **MVC (Model-View-Controller)** architectural pattern and uses **Entity Framework Core** for database operations with **SQL Server**.

---

## ✨ Features

- 📖 **Full CRUD** — Create, Read, Update, and Delete book records
- 🔍 **Live Search** — Filter books by title, author, or genre instantly
- 📦 **Stock Status Badges** — Visual indicators for In Stock, Low Stock, and Out of Stock
- 🎨 **Custom UI Design** — Deep navy and gold theme with Bootstrap 5
- ✅ **Server-side Validation** — Data annotations with user-friendly error messages
- 🔔 **Toast Notifications** — Real-time feedback on all CRUD operations
- 📱 **Responsive Layout** — Works on desktop and mobile

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (.NET 6) |
| ORM | Entity Framework Core 6 |
| Database | Microsoft SQL Server |
| Frontend | Razor Views, Bootstrap 5, Bootstrap Icons |
| Fonts | Google Fonts — Inter |
| Notifications | Toastr.js |
| Validation | jQuery Unobtrusive Validation |

---

## 📁 Project Structure

```
BookVault/
├── Controllers/
│   ├── HomeController.cs       # Landing page
│   └── ProductController.cs    # Full CRUD + search
├── Data/
│   └── ApplicationDbContext.cs # EF Core DbContext
├── Models/
│   ├── Product.cs              # Book entity model
│   └── ErrorViewModel.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml        # Hero landing page
│   ├── Product/
│   │   ├── Index.cshtml        # Book catalog with search
│   │   ├── Create.cshtml       # Add new book form
│   │   ├── Edit.cshtml         # Edit book form
│   │   └── Delete.cshtml       # Delete confirmation
│   └── Shared/
│       ├── _Layout.cshtml      # Global navbar and footer
│       └── _Notification.cshtml
├── wwwroot/
│   └── css/site.css            # Custom BookVault design system
├── Migrations/                 # EF Core database migrations
└── appsettings.json
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or SQL Server Express
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/BookVault.git
   cd BookVault
   ```

2. **Update the connection string** in `appsettings.json`
   ```json
   "BookVaultConnection": "Server=.;Database=BookVaultDb;Trusted_Connection=True;"
   ```

3. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:5001`

---

## 📋 Product Model

| Field | Type | Description |
|---|---|---|
| `Id` | int | Primary key |
| `Title` | string | Book title (required) |
| `Author` | string | Author name (required) |
| `Price` | decimal | Selling price in USD |
| `Genre` | string | Book genre/category |
| `StockQuantity` | int | Units available in inventory |
| `CreatedDateTime` | DateTime | Date the record was added |

---

## 👤 Author

**Riyaz**
- GitHub: [Riyaz510](https://github.com/Riyaz510)

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).
