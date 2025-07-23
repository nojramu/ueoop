# UE Object Oriented Programming Lessons

## Tech Stack Plan

### Core Technologies
- **Framework**: ASP.NET Core Blazor Server/WebAssembly
- **Language**: C# (.NET 8)
- **Database**: SQLite with Entity Framework Core
- **IDE**: Visual Studio Code (GitHub Codespaces compatible)

### Development Stack
- **Frontend**: Blazor Components (Razor syntax)
- **Backend**: ASP.NET Core Web API
- **ORM**: Entity Framework Core
- **CSS Framework**: Bootstrap 5 (included with Blazor templates)
- **Package Manager**: NuGet

### Essential Components for Web App
1. **Database Layer**
   - SQLite database file
   - Entity Framework Core DbContext
   - Data models/entities
   - Migrations

2. **Business Logic Layer**
   - Services for business operations
   - Data transfer objects (DTOs)
   - Validation logic

3. **Presentation Layer**
   - Blazor components (.razor files)
   - Shared layouts
   - Navigation components
   - Forms and data binding

4. **Configuration**
   - appsettings.json
   - Dependency injection setup
   - Database connection strings

### GitHub Codespaces Compatibility
✅ **Fully Compatible and Feasible**
- .NET SDK is pre-installed in Codespaces
- SQLite works perfectly (file-based database)
- No external database server required
- All tools available in browser-based VS Code
- Can run and debug locally in Codespaces
- Port forwarding for web app testing

## Required VS Code Extensions

### Essential Extensions
- **C# for Visual Studio Code** (`ms-dotnettools.csharp`)
  - C# language support and IntelliSense
  - Debugging capabilities
  - Code navigation and refactoring

- **C# Dev Kit** (`ms-dotnettools.csdevkit`)
  - Enhanced C# development experience
  - Project templates and scaffolding
  - Integrated testing support

### Recommended Extensions
- **Blazor Snippet Pack** (`razorslices.blazor-snippet-pack`)
  - Blazor component snippets
  - Razor syntax highlighting improvements

- **ASP.NET Core Snippets** (`ScottSauber.aspnetcore-snippets`)
  - ASP.NET Core code snippets
  - Controller and action shortcuts

- **Auto Rename Tag** (`formulahendry.auto-rename-tag`)
  - Automatically rename paired HTML/XML tags
  - Useful for Razor components

- **Bracket Pair Colorizer 2** (`CoenraadS.bracket-pair-colorizer-2`)
  - Color matching brackets
  - Better code readability

### Database Extensions
- **SQLite Viewer** (`qwtel.sqlite-viewer`)
  - View SQLite database contents
  - Query execution within VS Code

### Installation Notes
- Most extensions auto-install in GitHub Codespaces
- Use **Extensions** panel (`Ctrl+Shift+X`) to search and install
- Extensions provide IntelliSense, debugging,
