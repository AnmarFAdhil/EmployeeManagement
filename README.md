# Employee Management System

A simple ASP.NET MVC web application for managing employee information.

## Features

- User login page
- Employee CRUD operations (Create, Read, Update, Delete)
- View employees in a table/grid
- Add, edit, and delete employee records
- Basic logging when employees are deleted
- Clean architecture with Models, Controllers, Views, and Repository layer

## Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 or later (for running locally)

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   cd EmployeeManagement
   ```

2. Restore NuGet packages:
   ```
   dotnet restore
   ```

3. Build the project:
   ```
   dotnet build
   ```

4. Run the application:
   ```
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:5001` (or the URL shown in the console).

## Usage

1. On the login page, use the demo credentials:
   - Username: `admin`
   - Password: `password`

2. After logging in, you'll be redirected to the Employee List page.

3. From the Employee List:
   - Click "Create New" to add a new employee
   - Click "Edit" to modify an existing employee
   - Click "Details" to view employee information
   - Click "Delete" to remove an employee (this action is logged)

## Project Structure

- **Models/**: Contains the Employee model
- **Controllers/**: Contains LoginController and EmployeeController
- **Views/**: Contains Razor views for the UI
- **Services/**: Contains the repository interface and implementation for data access
- **wwwroot/**: Static files (CSS, JS, images)

## Logging

Basic logging is implemented for delete operations. Logs are written to the console and can be configured in `appsettings.json`.

## Technologies Used

- ASP.NET Core MVC
- C#
- Bootstrap (for styling)
- In-memory data storage (for demo purposes)