# CarConfigurator
ASP.NET Web App Project. Car Configurator where user can customize a vehicle and order a car.

To run a local demo of this web app on your machine: 
1. Clone the repository from GitHub into Visual Studio 2022 with ASP.NET and .NET development workloads installed.
2. Ensure "Allow invalid certificates for resources loaded from localhost" in chrome://flags/ (or make the similar changes in your preferred browser).
3. Ensure that SQL Server Data Tools are installed with your Visual Studio along with EntityFrameworkCore, EntityFrameworkCore.SqlServer, and EntityFrameworkCore.Tools. Modify your Visual Studio using the installer and find these packages within the individual components.
5. Note: To allow database functionality to work you will need to update your Visual Studio local SQL database with the project's schema. Go to Tools -> NuGet Package Manager -> Package Manager Console -> Type in 'update-database' into the console and press Enter.
