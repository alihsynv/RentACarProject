# Rent A Car BackEnd Project

A back-end system for managing car rentals.

## Key Features & Benefits

*   **Core Car Management:** Functionality for adding, updating, and retrieving car information.
*   **Customer Management:** Manages customer details, allowing for efficient tracking of rentals.
*   **Rental Management:** Handles the entire rental process, from booking to return.
*   **User Authentication:** Secure authentication of users using AuthManager.
*   **Role-Based Authorization:** Utilizes SecuredOperation for restricting access to endpoints.
*   **Image Handling:** Manages images associated with cars.

## Prerequisites & Dependencies

*   .NET SDK (version compatible with the project, check project file).
*   SQL Server (or other database configured in the project).
*   Autofac (for dependency injection).

## Installation & Setup Instructions

1.  **Clone the repository:**

    ```bash
    git clone https://github.com/alihsynv/RentACarProject.git
    cd RentACarProject
    ```

2.  **Restore NuGet Packages:**

    ```bash
    dotnet restore
    ```

3.  **Configure the Database:**

    *   Update the connection string in `appsettings.json` (or relevant configuration file) to point to your SQL Server instance.

4.  **Apply Database Migrations:**

    ```bash
    dotnet ef database update
    ```

    *   Ensure you have Entity Framework Core tools installed: `dotnet tool install --global dotnet-ef`

5.  **Build the Project:**

    ```bash
    dotnet build
    ```

6.  **Run the Project:**

    ```bash
    dotnet run
    ```

## Usage Examples & API Documentation

API documentation is not yet available. Please refer to the code and relevant controllers for implementation details.

**Example Controller (CarController - Hypothetical):**

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
        var result = _carService.GetAll();
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }

    // Add more endpoints here
}
```

## Configuration Options

The project utilizes `appsettings.json` for configuration. Key configuration sections include:

*   **ConnectionStrings:** Specifies the database connection string.
*   **TokenOptions:** Settings related to JWT authentication.

## Contributing Guidelines

1.  Fork the repository.
2.  Create a new branch for your feature or bug fix.
3.  Make your changes and ensure they are well-tested.
4.  Submit a pull request with a clear description of your changes.

## License Information

License not specified. All rights reserved to the owner (alihsynv).
Please contact the owner for licensing terms.

