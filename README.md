# IMS_BISP — Malika Tech Market Inventory Management System

A desktop-based inventory management system built for **Malika Tech Market** in Tashkent, Uzbekistan. Designed for multi-store operations within a single market complex.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Frontend | C# WinForms (.NET Framework 4.7.2) |
| Data Access | Class Library (IMS_BISP.DAL) |
| Database | MS SQL Server |
| Containerization | Docker (SQL Server 2025) |

---

## Features

### Super Admin
- Manage stores (add, edit, activate/deactivate)
- Manage users (add, edit, reset password, activate/deactivate)
- View system-wide audit log
- Admin dashboard (active stores, users, products, pending requests)

### Store Manager
- Full inventory management (add, edit, delete, toggle visibility)
- Browse marketplace — view PUBLIC products from other stores
- Send inter-store product requests with proposed price
- Accept or reject incoming requests
- Store dashboard with stats and request summary

### Store Staff
- View and manage own store inventory
- Browse marketplace (view only)

---

## Project Structure

```
IMS_BISP/
├── Forms/              # Login and dialog forms
├── UserControls/       # Dashboard, Products, Marketplace, Requests, Manage, Audit
├── Sessions/           # UserSession static class
├── Resources/          # Images
└── App.config          # Connection string

IMS_BISP.DAL/
├── Data/               # Repositories (one per entity)
├── Models/             # Plain model classes
└── Mappers/            # SqlDataReader → Model mappers

docker/
├── init.sql            # Full DB schema + seed data
└── entrypoint.sh       # Docker entrypoint script
```

---

## Getting Started

### 1. Start the database

```bash
docker compose up -d
```

Wait ~30 seconds for SQL Server to initialize.

### 2. Run the application

Open `IMS_BISP.sln` in Visual Studio and press **F5**.

### 3. Default login credentials

| Username | Password | Role |
|---|---|---|
| admin | 1234 | Super Admin |
| bekzod21 | 1234 | Store Manager |
| jasur_pro | 1234 | Store Staff |
| mansur_aka | 1234 | Store Manager |
| flash_aziz | 1234 | Store Manager |

---

## Database

- **7 tables** — Roles, Stores, Users, Categories, Products, ProductRequests, AuditLog
- **30 stored procedures** — all DB operations go through stored procedures, no raw SQL in C#
- Connection string configured in `IMS_BISP/App.config`

---

## Academic Context

Developed as a final year capstone project for the **BSc (Hons) Business Information Systems** degree at Westminster International University in Tashkent (WIUT), 2025–2026.
