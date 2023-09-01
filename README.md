# JWT Authentication Project

This project is a skill-building exercise focused on implementing JWT (JSON Web Token) authentication for accessing weather forecast data.

## Project Overview

The project consists of two main endpoints:

1. `/token`: This endpoint requires a `x-www-form-urlencoded` request containing a password and username. It generates a JWT token used for authentication.

2. `/weatherforecast`: This endpoint requires authentication using the JWT token obtained from the `/token` endpoint. It provides access to weather forecast data.

## Technologies Used

- Backend Framework: .NET 6
- Authentication Package:
  - Microsoft.AspNetCore.Authentication.JwtBearer
  - System.IdentityModel.Tokens.Jwt
    
## Getting Started

To get started with the project, follow these steps:

1. Clone the repository
2. Open the solution in Visual Studio or your preferred IDE.
3. Restore NuGet packages.
4. Configure the appsettings.json
5. Build and run the application.

## API Documentation

### `/token` Endpoint

- Method: `POST`
- Request Content-Type: `application/x-www-form-urlencoded`
- Request Body Parameters:
  - `grant_type`: password
  - `username`: [Type: string, Required] Any username for authentication.
  - `password`: [Type: string, Required] Any password for authentication.
- Response: [Specify the expected response format]

### `/weatherforecast` Endpoint

- Method: `GET`
- Request Headers:
  - `Authorization`: [Type: string, Required] The JWT token obtained from the `/token` endpoint.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

Happy coding!

