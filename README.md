# Windows Forms Client Management Application

## Description
This project is a Windows Forms application built with C# that enables users to manage client information in a PostgreSQL database. It includes features for adding, editing, and deleting clients while ensuring validation of the primary key (ClientCode) to prevent duplicates. The application also incorporates robust error handling, such as displaying a message if the database connection fails.

## Features
- CRUD operations for managing client data.
- Validation to ensure no duplicate "ClientCode" values are added.
- Customizable database connection string in the "ClientRepository" class.
- Informative error handling with "MessageBox" notifications.
- Separation of concerns for better maintainability.

## Prerequisites
- .NET 7.0
- Visual Studio (2019 or later recommended)
- PostgreSQL (if using a database connection)

## Installation
1. Clone this repository:

   git clone https://github.com/Rishi-Pahuja/client-crud-winforms

2. Open the solution in Visual Studio.

3. Build the project to restore dependencies.

## Database Connection

Database Connection
This application connects to a PostgreSQL database via a connection string defined in the ClientRepository class. If you wish to use your own database:

1. Update the connection string in ClientRepository with your database details.
	-Look for placeholders (e.g., server, database, username, password) and replace them with your values.

2. If you're unsure about how to set up the connection, feel free to reach out to me.

Alternatively, you can connect to your own database by populating the required variables in the connection string.

## Usage

1. Launch the application.

2. Use the following features:
	. Add Client: Add a new client to the database.
	. Edit Client: Modify an existing client's information (except ClientCode).
	. Delete Client: Remove a client entry.

3. If the database connection fails, a message box will notify you and refer you to this README file for troubleshooting.

## Troubleshooting

- Ensure PostgreSQL is installed and running.
- Verify that your connection string in ClientRepository is accurate.
- Make sure the required tables and schema exist in your database.

## Contact

For database-related queries or any other questions, reach out to me directly.

