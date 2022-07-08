
# C# Repository Pattern and Unit of work with EF Core 5
## Database  
Database: Northwind sample Database by Microsoft


## EF Core scaffolding

For Direct connection string for scaffolding, add reference for Nuget Package: EFCore SQL server and EF Core Tools. Make the project as startup where you want to Scaffold   
  
Open Package Manager Console and run the command below:    
For All Tables in database:  
Scaffold-DbContext "Your connection string here" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models   

For specific tables:  
Scaffold-DbContext "Your connection string here" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables Table1, Table2 -f   

## For Using Environment variables  
Add environment variables in Windows and restart Visual Studio 
