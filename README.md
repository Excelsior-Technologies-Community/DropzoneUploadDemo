
# **DropzoneUploadDemo**

# DropzoneUploadDemo – Drag & Drop File Upload

This project demonstrates **drag-and-drop file upload** using **Dropzone.js** with ASP.NET Core MVC and SQL Server.

---

## 🚀 Features
- Drag & drop file upload
- Multiple file upload support
- Save files to server
- Save file metadata in database

---

## 🧱 Tech Stack
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Dropzone.js

---

## 📁 Key Files
Models/UploadedFile.cs
Controllers/FileController.cs
Views/File/Upload.cshtml
wwwroot/uploads/


---

## ⚙️ Setup Steps

### 1️⃣ Create Upload Folder
wwwroot/uploads


### 2️⃣ Run Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
▶️ Run Project

dotnet run
Open:
```
/File/Upload
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/2036f85a-6f18-4122-a2f0-74d81908a2a3" />


✅ Use Cases
Document management systems
Profile file uploads\
Admin file handling
