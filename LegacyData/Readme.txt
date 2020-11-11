*NOTES FOR GAGE*
dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LegacyData" Microsoft.EntityFrameworkCore.SqlServer --output-dir scaffold
-- Scaffold database

dotnet ef migrations add Initial -o EfStructures\Migrations -c LegacyData.Dal.EfStructures.LegacyDataContext
dotnet ef database update -c LegacyData.Dal.EfStructures.LegacyDataContext

-- add & update database via EntityFrameworkCore
***END NOTES FOR GAGE***

*Notes for anyone standing this up*

LegacyData.WebApi folder contains WebApi project and Angular app (LegacyData.WebApi/ClientApp)

Standup instructions:

nuget restore
build to make sure it spins up

right click LegacyData.Test project and run all tests, good practice and will reinstantiate the database with a few rows of mock data

npm install
npm start

running .net sln in debug mode will also pull up frontend in localhost:44388
live reloading and api calls work on both as long as you're not editing frontend in visual studio, dont do that.