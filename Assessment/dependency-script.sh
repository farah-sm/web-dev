#!/bin/bash

#Dependencies:

#Install dotnet 8.0.2
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y apt-transport-https
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0.2


#install required packages (terminal):
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools

#Add migrations and update DB
dotnet new tool-manifest
dotnet tool install --local dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update


#To have controllers operate, we install these packages:
dotnet tool install --local dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

# To integrate the new Identity Framework, we need to add the capability to our DB, we run theis command and update our DB

dotnet ef migrations add IdentityAdded
dotnet ef database update

# To add the email registration functionality we will use MailKit a package from Jeffrey Stedfast
dotnet add package MailKit



# To add JWT we will need to install this dependency
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --force

