Check what port you've exposed, for me it's: http://localhost:5298/

Glossary Commands:


## Two ways to install a package 
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```
OR
## Hitting searching 
```
>NuGet Package Manager: Add Package"
```


## Run the following command to create migrations
```
dotnet ef migrations add InitialCreate

```

## Apply the migrations to update the database:

```
dotnet ef database update

```

-------------


Database update - after running 'dotnet ef database update' I get 'LocalDB is not supported on this platform.'


Checkout other database solutions:

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=YourStrongPassword' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest


Once I choose a solution, install the packages for that database solution and just change the reference to the database

Find out about the MAC references for the code. 


-----------


Database Solution SQL Lite

Now to run scaffolding for controllers, use the commands. 


## Install Entity Framework Core Tools Global Tool
```
dotnet tool install --global dotnet-ef
```
## Install the required dotnet scaffolding tool | Generates Controlers with views based on models
```
dotnet tool install --global dotnet-aspnet-codegenerator
```

## Run Scaffolding Command | 
### Replace YourControllerName, YourModelClassName, and YourDbContextClassName 
```
dotnet aspnet-codegenerator controller -name YourControllerName -m YourModelClassName -dc YourDbContextClassName --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```


