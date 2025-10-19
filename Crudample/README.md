# Crudample - Student Management System

A simple CRUD (Create, Read, Update, Delete) application built with **ASP.NET Core Blazor Server** and **SQLite** for managing student records.

## 🎯 Overview

This application demonstrates fundamental database operations using Entity Framework Core with a clean, interactive web interface. It's designed for learning Object-Oriented Programming concepts and web development with C#.

## 🗄️ Database Structure

### SQLite Database
- **Database File**: `AppData/app.db`
- **Database Type**: SQLite (file-based, no server required)
- **ORM**: Entity Framework Core

### Students Table Schema

```sql
CREATE TABLE Students (
    Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    Name TEXT NULL,
    Age INTEGER NOT NULL
);
```

| Column | Type    | Description                    | Constraints           |
|--------|---------|--------------------------------|-----------------------|
| Id     | INTEGER | Unique student identifier      | PRIMARY KEY, AUTO INCREMENT |
| Name   | TEXT    | Student's full name            | Can be NULL           |
| Age    | INTEGER | Student's age in years         | NOT NULL              |

### Entity Model (C#)

```csharp
public class Student
{
    public int Id { get; set; }        // Auto-generated primary key
    public string? Name { get; set; }  // Nullable string
    public int Age { get; set; }       // Required integer
}
```

## 🔧 CRUD Operations

### ✅ **CREATE** - Add New Student
- **Method**: `AddStudent()`
- **UI**: Form with Name and Age fields
- **Validation**: 
  - Name: Required, cannot be empty
  - Age: Must be greater than 0
- **Database**: `INSERT INTO Students (Age, Name) VALUES (@age, @name)`

### 📖 **READ** - Display Students
- **Method**: `LoadStudents()`
- **UI**: Table showing Id, Name, Age, and Actions
- **Database**: `SELECT * FROM Students ORDER BY Name`
- **Features**: Shows count of total students

### ✏️ **UPDATE** - Edit Student
- **Method**: `UpdateStudent()`
- **UI**: Same form as CREATE, pre-filled with existing data
- **Process**: Click Edit → Modify → Click Update
- **Database**: `UPDATE Students SET Age = @age, Name = @name WHERE Id = @id`

### 🗑️ **DELETE** - Remove Student
- **Method**: `DeleteStudent()` → `ConfirmDelete()`
- **UI**: Delete button → Confirmation dialog → Confirm/Cancel
- **Database**: `DELETE FROM Students WHERE Id = @id`
- **Safety**: Requires explicit confirmation

### 🧹 **CLEAR ALL** - Empty Database
- **Method**: `ClearDatabase()` → `ConfirmClearDatabase()`
- **UI**: "Clear All Data" button (only visible when students exist)
- **Process**: Removes ALL students with strong confirmation warning
- **Database**: `DELETE FROM Students` (removes all records)

## 🚀 How to Run

### Prerequisites
- .NET 8 SDK
- Visual Studio Code (recommended)

### Simple Instructions

1. **Navigate to the project directory**:
   ```bash
   cd /workspaces/ueoop/Crudample
   ```

2. **Build the application**:
   ```bash
   dotnet build
   ```

3. **Run the application**:
   ```bash
   dotnet run
   ```

4. **Open in browser**:
   - The application will show the URL (usually `http://localhost:5000` or similar)
   - Open that URL in your web browser

## 📱 How to Use the Application

### Adding Students
1. Fill in the **Student Name** field
2. Enter the **Age** (must be > 0)
3. Click **"Add Student"** button
4. Student appears in the list below

### Editing Students
1. Find the student in the list
2. Click the **"Edit"** button (pencil icon)
3. Modify the name or age in the form
4. Click **"Update"** to save changes
5. Click **"Cancel"** to discard changes

### Deleting a Single Student
1. Find the student in the list
2. Click the **"Delete"** button (trash icon)
3. A warning dialog appears
4. Click **"Yes, Delete"** to confirm or **"Cancel"** to abort

### Clearing All Data
1. Click **"Clear All Data"** button (top-right of student list)
2. ⚠️ **DANGER**: A red warning dialog appears
3. Click **"Yes, Delete All"** to remove ALL students
4. Click **"Cancel"** to abort

## 🏗️ Project Structure

```
Crudample/
├── Components/
│   ├── Pages/
│   │   └── Home.razor           # Main CRUD interface
│   ├── Layout/
│   │   └── MainLayout.razor     # Page layout
│   ├── Routes.razor             # Routing configuration
│   └── App.razor               # Root application component
├── Data/
│   ├── Student.cs              # Student entity model
│   └── AppDbContext.cs         # Entity Framework context
├── AppData/
│   └── app.db                  # SQLite database file
├── Program.cs                  # Application configuration
└── Crudample.csproj           # Project file
```

## 🛠️ Technical Implementation

### Entity Framework Configuration
```csharp
// Program.cs
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=AppData/app.db"));
```

### Database Context
```csharp
// Data/AppDbContext.cs
public class AppDbContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();
}
```

### Blazor Component Features
- **Interactive Server Rendering**: Real-time UI updates
- **Data Binding**: Two-way binding with form inputs
- **State Management**: Proper component state handling
- **Error Handling**: Try-catch blocks with user feedback
- **Validation**: Client-side form validation

## 🔍 Database Inspection

### View Database Contents (Terminal)
```bash
# Show all students
sqlite3 AppData/app.db "SELECT * FROM Students;"

# Count students
sqlite3 AppData/app.db "SELECT COUNT(*) FROM Students;"

# Show table structure
sqlite3 AppData/app.db ".schema Students"
```

## 🎓 Learning Objectives

This project demonstrates:

1. **Object-Oriented Programming**:
   - Entity models (Student class)
   - Encapsulation and data access
   - Method organization and separation of concerns

2. **Database Operations**:
   - Entity Framework Core ORM
   - CRUD operations
   - Data persistence and retrieval

3. **Web Development**:
   - Blazor Server components
   - Interactive UI with real-time updates
   - Form handling and validation

4. **Software Engineering**:
   - Project structure and organization
   - Error handling and user feedback
   - User experience design (confirmations, status messages)

## 🚨 Important Notes

- **Data Persistence**: All data is stored in the SQLite database file
- **Auto-ID Generation**: Student IDs are automatically assigned by the database
- **Real-time Updates**: Changes appear immediately without page refresh
- **Data Safety**: Delete and Clear operations require explicit confirmation
- **Error Handling**: Application provides feedback for successful and failed operations

---

**Happy Coding! 🎉**
