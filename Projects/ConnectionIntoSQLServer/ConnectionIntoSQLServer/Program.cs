using Microsoft.Data.SqlClient;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("=== SQL Server Database Connection Demo ===\n");

// Connection string to connect to SQL Server
string masterConnectionString = "Data Source=localhost;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=30";
string databaseName = "SampleDB";
string connectionString = $"Data Source=localhost;Initial Catalog={databaseName};Integrated Security=True;Encrypt=True;TrustServerCertificate=True;Command Timeout=30";

try
{
    // Step 1: Create Database if it doesn't exist
    Console.WriteLine("Step 1: Creating database...");
    using (SqlConnection connection = new SqlConnection(masterConnectionString))
    {
        connection.Open();
        string createDbQuery = $@"
            IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '{databaseName}')
            BEGIN
                CREATE DATABASE {databaseName}
            END";
        
        using (SqlCommand command = new SqlCommand(createDbQuery, connection))
        {
            command.ExecuteNonQuery();
            Console.WriteLine($"Database '{databaseName}' created or already exists.\n");
        }
    }

    // Step 2: Create Table
    Console.WriteLine("Step 2: Creating table...");
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U')
            CREATE TABLE Employees (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(100) NOT NULL,
                Department NVARCHAR(100),
                Salary DECIMAL(18, 2),
                HireDate DATE
            )";
        
        using (SqlCommand command = new SqlCommand(createTableQuery, connection))
        {
            command.ExecuteNonQuery();
            Console.WriteLine("Table 'Employees' created or already exists.\n");
        }
    }

    // Step 3: Insert Data
    Console.WriteLine("Step 3: Inserting data...");
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        
        // Clear existing data for demo purposes
        string clearQuery = "DELETE FROM Employees";
        using (SqlCommand clearCommand = new SqlCommand(clearQuery, connection))
        {
            clearCommand.ExecuteNonQuery();
        }

        // Insert sample data
        string insertQuery = @"
            INSERT INTO Employees (Name, Department, Salary, HireDate) VALUES 
            (@Name, @Department, @Salary, @HireDate)";
        
        var employees = new[]
        {
            new { Name = "John Doe", Department = "IT", Salary = 75000m, HireDate = new DateTime(2020, 1, 15) },
            new { Name = "Jane Smith", Department = "HR", Salary = 65000m, HireDate = new DateTime(2019, 5, 20) },
            new { Name = "Mike Johnson", Department = "Finance", Salary = 80000m, HireDate = new DateTime(2021, 3, 10) },
            new { Name = "Sarah Williams", Department = "IT", Salary = 90000m, HireDate = new DateTime(2018, 11, 5) }
        };

        foreach (var emp in employees)
        {
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", emp.Name);
                command.Parameters.AddWithValue("@Department", emp.Department);
                command.Parameters.AddWithValue("@Salary", emp.Salary);
                command.Parameters.AddWithValue("@HireDate", emp.HireDate);
                command.ExecuteNonQuery();
                Console.WriteLine($"Inserted: {emp.Name}");
            }
        }
        Console.WriteLine($"\n{employees.Length} employees inserted successfully.\n");
    }

    // Step 4: Fetch and Display Data
    Console.WriteLine("Step 4: Fetching data...");
    Console.WriteLine("=".PadRight(80, '='));
    Console.WriteLine($"{"ID",-5} {"Name",-20} {"Department",-15} {"Salary",-12} {"Hire Date",-12}");
    Console.WriteLine("=".PadRight(80, '='));
    
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        string selectQuery = "SELECT Id, Name, Department, Salary, HireDate FROM Employees ORDER BY Id";
        
        using (SqlCommand command = new SqlCommand(selectQuery, connection))
        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string department = reader.IsDBNull(2) ? "N/A" : reader.GetString(2);
                decimal salary = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                DateTime hireDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4);
                
                Console.WriteLine($"{id,-5} {name,-20} {department,-15} ${salary,-11:N2} {hireDate:yyyy-MM-dd}");
            }
        }
    }
    
    Console.WriteLine("=".PadRight(80, '='));
    Console.WriteLine("\n✓ All operations completed successfully!");
}
catch (SqlException ex)
{
    Console.WriteLine($"\n❌ SQL Error occurred: {ex.Message}");
    Console.WriteLine($"Error Number: {ex.Number}");
    Console.WriteLine("\nTroubleshooting tips:");
    Console.WriteLine("- Ensure SQL Server is running");
    Console.WriteLine("- Check if Windows Authentication is enabled");
    Console.WriteLine("- Verify connection string settings");
}
catch (Exception ex)
{
    Console.WriteLine($"\n❌ Error occurred: {ex.Message}");
}
