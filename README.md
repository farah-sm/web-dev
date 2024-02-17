# My First MVC App in C#
## Use this as a guide to build your first, C# MVC App with a DB integrated

Here we look at the steps to take creating a "Code first Approach"
It's worth noting this was compiled to create the MVC app using visual studio code
Visual studio code is a lot more light weight then VS code and hence the details in the commands, if you found this useful hit star!

To run this code, clone the repo locally, before you run it, expose the port of your choise by 
navigating to the path:

```
/S3/Website/Properties/launchSettings.json
```
and changing the port from mine, 5298 to a port choice of your own. On Line 7 and 25: 
```
applicationUrl": "http://localhost:5298
```

## Sequence
1. Creating a new project
2. Creating Model classes Adding DBContext model class
3. Registering the context with dependency injection
4. Adding the Database Connection string
5. Install the package manager
6. Installation of required packages using the package manager 
7. Adding the Migrations
8. Adding the Controllers
9. Adding the respective Views
10. Now "Scaffolding" time
11. Now run your app

-----------

1. Creating a new project

Use the command

```
dotnet new webapi
dotnet new mvc
```

-----------

2. Creating Model classes Adding DBContext model classes

Create a file under the Models folder, name it as what you would name 
Create many Files as you would like Models created

-----------
3. Registering the context with dependency injection

In the program.cs we add this code, this is subject to which databse
solution your choose, in this case I use SQLLite:

```
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
```
-----------
4. Adding the Database Connection string

In the appsettings.json file we connection string to our database server, this is subject to which databse solution your choose, 
In this case I use SQLLite

```
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=mydatabase.db"
  }
```
-----------

5. Installing the Package Manager

Two ways to install a package 
```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
OR

Hitting searching 
```
>NuGet Package Manager: Add Package"
```

-----------
6. Installation of required packages using the package manager 

## Install Entity Framework Core Tools Global Tool
```
dotnet tool install --global dotnet-ef
```

Packages Installed for this program, can be found in the path:
```
bin/Debug/net8.0/S3.deps.json
```
The dependencies I have in my app are:

    "Microsoft.EntityFrameworkCore": "8.0.1",
    "Microsoft.EntityFrameworkCore.Design": "8.0.1",
    "Microsoft.EntityFrameworkCore.Sqlite": "8.0.1",
    "Microsoft.EntityFrameworkCore.Tools": "8.0.1",
    "Microsoft.VisualStudio.Web.CodeGeneration.Design": "8.0.0"

Only use packages you need. 


-----------

7. Adding the Migrations

Run the following command to create migrations
```
dotnet new tool-manifest

dotnet tool install --local dotnet-ef

dotnet ef migrations add InitialCreate


```

Apply the migrations to update the database:

```
dotnet ef database update

```

-------------

8. Adding the controllers

Create the controllers, by manually getting them into the controllers folder. Be sure to use 
the correct naming convention, if your model is called Grade.cs then its corresponding
controller would be called GradesController.cs

Or Via the command line

```
dotnet tool install --local dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

```
dotnet aspnet-codegenerator controller -name StudentsController -async -api -m Student -dc SchoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name CoursesController -async -api -m Course -dc SchoolContext -outDir Controllers
dotnet aspnet-codegenerator controller -name EnrollmentsController -async -api -m Enrollment -dc SchoolContext -outDir Controllers
```


-------------

9. Adding the respective Views

Create the View files, they will be in "cshtml" files, be sure to modularise it, in our context 
I would create a folder called Views/Grades/* and create my files within, again for loose coupling 
I seperate my "cshtml" files for every operation. 
E.g. I have a Create, Delete, Edit, Index, Details file within the folder.

-------------
10. Now "Scaffolding" time

In Visual Studio code, you need the package "dotnet-aspnet-codegenerator" for the application to run. This command
creates Controllers and Views that correspond to your Models. 

First check if you have the package installed using this command:

```
dotnet tool install --global dotnet-ef
```
If you do not see the package then use this command to install it:

```
dotnet tool install --global dotnet-aspnet-codegenerator
```

-------------

11. Now run your app 

```dotnet run```




-------------

BONUS:

To query the databse, naviagte to the database file, and run the command:

```
saeds-desktop[web-dev~main]:[homie-cluster]$ sqlite3 mydatabase.db "SELECT * FROM Students"
                                              1|Mahamed|1998-08-09 08:43:00|69.0|111.0|```