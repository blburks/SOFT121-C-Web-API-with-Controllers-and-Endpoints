## FP-CSharp Web API

## Overview
This repository contains the **C# Web API** portion of the SOFT121 final project.  
It demonstrates object-oriented principles, API endpoints, and error handling.

**Note:** The React front-end (`client-app/`) will be added later.  
This submission currently includes only the backend API.

## Technologies Used
- C# / .NET 9.0
- ASP.NET Core Web API
- Visual Studio / VS Code
- Git & GitHub for version control

## Project Structure
```
FP-CSharp/
  ├── Controllers/
  │ └── HelloWorldController.cs
  ├── Models/
  │ └── Message.cs
  ├── Program.cs
  ├── FP-CSharp.csproj
  ├── Properties/ 
  │ └── launchSettings.json 
  ├── appsettings.json 
  ├── appsettings.Development.json 
  └── .gitignore
  ```
 
## Running the Project
Clone the repository: 
```bash
  git clone https://github.com/blburks/SOFT121-C-
  Web-API-with-Controllers-and-Endpoints.git
  cd FP-CSharp
```
Restore dependencies:
```bash
dotnet restore
```
Run the API
```bash
dotnet run
```
Access Endpoints
```
https://localhost:5030/api/helloworld
```

## Features
  - Clean folder structure
  - Example Controller (`HelloWorldController`)
  - Example model (`Message`)
  - Configuable via `appsettings.json`
  - Ready to integrate with a React front-end

## Next Steps
  - Add the React front-end (`client-app/`) in a separate folder
  - Connect the React front-end to this API for full-stack functionality

## Repository Link
[SOFT121-C-Web-API-with-Controllers-and-Endpoints]
(https://github.com/blburks/SOFT121-C-Web-API-with-Controllers-and-Endpoints.git)


