# QuoteAPI
A simple RESTful API built with ASP.NET Core and Entity Framework Core.  
Provides CRUD operations for managing quotes stored in a SQLite database.

## Features
- Retrieve all quotes or a specific quote by ID  
- Add, update, or delete quotes  
- Database handled via Entity Framework Core  
- Integrated Swagger UI for interactive testing

## Technologies
C#, ASP.NET Core, Entity Framework Core, SQLite

## How to Run
1. Clone the repository  
2. Restore and start the app:
   ```bash
   dotnet restore
   dotnet run

# Example Usage
In Swagger, open the Quotes section to test endpoints:

GET /quotes – Returns all quotes
GET /quotes/{id} – Returns quote by ID
POST /quotes – Adds a new quote (provide JSON body)
PUT /quotes/{id} – Updates existing quote
DELETE /quotes/{id} – Deletes quote by ID

Each request responds with standard HTTP codes such as 200 OK, 201 Created, 400 Bad Request, or 404 Not Found.

# Testing the API
You can test all endpoints directly in Swagger UI:
Click on any request (e.g., GET /quotes)
Click “Try it out”
Modify parameters or request body if needed
Click “Execute” to send the request and view response codes and data.
