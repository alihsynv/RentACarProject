# 🚗 Rent A Car BackEnd Project

## Secure and Scalable Car Rental Management System

This project is a **Back-End** solution designed to fully manage the car rental process. Built on the **.NET** platform and adhering to **Clean Architecture** principles, this system provides centralized management for customer, car, and rental operations.

---

## 🧭 Project Index (Table of Contents)

* [✨ Key Features & Benefits](#-key-features--benefits)
* [💻 Tech Stack](#-tech-stack)
* [🏗️ Project Structure](#️-project-structure)
* [🛠️ Installation & Setup Instructions](#️-installation--setup-instructions)
* [🚀 Usage Examples & API Documentation](#-usage-examples--api-documentation)
* [🗺️ Roadmap](#️-roadmap)
* [🤝 Contributing Guidelines](#-contributing-guidelines)
* [⚖️ License](#️-license)
* [🙏 Acknowledgements](#-acknowledgements)

---

## ✨ Key Features & Benefits

The core capabilities and advantages of the system:

| Category | Feature | Benefit |
| :--- | :--- | :--- |
| **Management** | 🏎️ **Core Car Management** | Centralized management for car information (add, update, delete, search). |
| | 👥 **Customer Management** | Efficient tracking and management of customer details. |
| | 📝 **Rental Management** | Digitalization of the entire rental process (booking, handover, return). |
| **Security** | 🔑 **User Authentication (AuthManager)** | Reliable user login and identification using JWT (JSON Web Tokens). |
| | 🛡️ **Role-Based Authorization (SecuredOperation)** | Restricting access to endpoints based on user roles (e.g., Admin, Moderator). |
| **Auxiliary** | 🖼️ **Image Handling** | Management and storage of images associated with cars. |
| | 💉 **Dependency Injection (Autofac)** | Improved code maintainability and testability using the **Autofac** container. |

---

## 💻 Tech Stack

The project is built upon the following core technologies and libraries:

* **Back-End Framework:** C# / .NET Core Web API
* **Database:** SQL Server
* **ORM:** Entity Framework Core
* **Dependency Injection:** Autofac
* **Validation:** FluentValidation
* **Security:** JWT Authentication

---

## 🏗️ Project Structure

The project is organized according to the principles of **Clean Architecture**. The responsibilities of each layer are clearly defined to ensure a scalable and maintainable codebase:

| Project Name | Layer Responsibility | Key Contents |
| :--- | :--- | :--- |
| **`WebAPI/`** | **Presentation Layer** | The entry point for the system. Contains **API Endpoints** (Controllers) and application startup configuration (Startup/Program.cs). |
| **`Business/`** | **Business Logic Layer** | Holds the core **Business Logic** (Services) and **Rules**. Data validation (**FluentValidation**) is implemented here. |
| **`DataAccess/`** | **Infrastructure (Data Access Layer)** | Handles communication with the **Database**. Contains the **Repository Pattern** implementation (Concrete/EfCoreRepositories) and **DbContexts**. |
| **`Entities/`** | **Domain Layer** | All **Domain Entities** (e.g., Car, Customer, Rental, User) and their properties. |
| **`Core/`** | **Cross-Cutting Concerns** | **Shared components** utilized by all layers. Includes **Generic Repository** abstractions, **JWT Authentication**, and **Aspects** (Caching, Validation). |


## 🏗️ Project Structure

The project is organized according to the principles of **Clean Architecture**. The responsibilities of each layer are clearly defined to ensure a scalable and maintainable codebase.

```RentACarProject/ 
├── WebAPI/ -- 🌐 Presentation Layer: API Controllers & Configuration 
├── Business/ -- 🧠 Business Logic Layer: Services, Business Rules, Validation 
├── DataAccess/ -- 💾 Infrastructure Layer: Repositories & EF Core Contexts 
├── Core/ -- ⚙️ Cross-Cutting Concerns: Utilities, JWT Authentication, Generic Abstractions 
└── Entities/ -- 🧱 Domain Layer: Database/Domain Models (Car, User, etc.)
```
---

## 🛠️ Installation & Setup Instructions

Follow these steps to get the project running on your local machine:

### Prerequisites

* **[.NET SDK](https://dotnet.microsoft.com/download)** (Version compatible with the project)
* **SQL Server** (or another configured database)
* **Entity Framework Core Tools** (`dotnet tool install --global dotnet-ef`)

### Setup Steps

1.  **Clone the repository:**

    ```bash
    git clone [https://github.com/alihsynv/RentACarProject.git](https://github.com/alihsynv/RentACarProject.git)
    cd RentACarProject
    ```

2.  **Restore NuGet Packages:**

    ```bash
    dotnet restore
    ```

3.  **Configure the Database:**

    * Update the **Connection String** in `appsettings.json` (or relevant configuration file) to point to your SQL Server instance.

4.  **Apply Database Migrations:**

    ```bash
    dotnet ef database update
    ```

5.  **Build the Project:**

    ```bash
    dotnet build
    ```

6.  **Run the Project:**

    ```bash
    dotnet run
    ```
    * *Tip:* If you integrate **Swagger**, the API documentation will typically be available at `http://localhost:<port>/swagger/index.html`.

---

## 🚀 Usage Examples & API Documentation

API documentation is not yet fully available. We plan to integrate **Swagger/OpenAPI** soon. Please refer to the code and relevant controllers for implementation details.

**Example Controller (CarController):**

This example demonstrates how the **GetAll** operation, implemented in the business layer, is consumed:

```csharp
[ApiController]
[Route("api/[controller]")]
public class CarController : ControllerBase
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        // Retrieves all cars from the business layer
        var result = _carService.GetAll(); 
        
        // If the result is successful (result.Success == true), returns 200 OK
        if (result.Success)
        {
            return Ok(result);
        }
        
        // Otherwise, returns 400 Bad Request with the error message
        return BadRequest(result.Message); 
    }

    // Add more endpoints here (e.g., Post, Put, Delete)
}

```
---

## 🗺️ Roadmap
Future development plans and planned features for the project:

| Next Step | Details | Status |
| :--- | :--- | :--- |
| **`🚀 API Documentation`** | **Full Swagger/OpenAPI integration for easy endpoint testing.** | **⏳ Planned** |
| **`💳 Payment System`** | **"Secure integration with an external service (e.g., Stripe) for payment processing."** | **⏳ Planned** |
| **`🔍 Advanced Filtering & Search`** | **"Implementation of complex filtering (range, brand) and Full-Text Search for cars."** | **⏳ Planned**|
| **`🪵 Centralized Logging`** | **Application of effective system logging using a tool like Serilog.** | **💡 Idea Phase**|
| **`🧪 Comprehensive Tests`** | **Adding Unit and Integration Tests to ensure code quality and stability.** | **💡 Idea Phase**|

---

## 🤝 Contributing Guidelines
If you wish to contribute to the project, please follow these guidelines:

1. Fork 🍴 the repository.

2. Create Branch 🌿 Create a new branch for your feature or fix:
    ```bash
    git checkout -b feature/NewFeature
    ```
3. Test ✅ Make your changes and ensure they are well-tested.
4. Commit 💾 Commit your changes with a clear message:
    ```bash
    git commit -m "feat: [Short Description] added new feature"
    ```
5. Push 📤 Push to your branch:
    ```bash
    git push origin feature/NewFeature
    ```
6. Submit PR 📬 Submit a Pull Request (PR) with a clear and detailed description.

---

## ⚖️ License
This project is licensed under the MIT License.

Legal Details: See the LICENSE file for the full license terms.
    
Summary: You are free to use, copy, modify, and distribute the code, provided that the original copyright notice and license notice are included in all copies or substantial portions of the software.


---

## 🙏 Acknowledgements
We extend our sincere thanks to all the open-source technologies and community resources that made this project possible:

* 🟢 .NET Framework: The core development platform.
* 💾 Entity Framework Core: For efficient database interaction.
* 💉 Autofac: For powerful Dependency Injection (DI).
* 🔒 JWT (JSON Web Token): For secure Authentication.
* 🌐 All tutorials and online community resources used during development.
