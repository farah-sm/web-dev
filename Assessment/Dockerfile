# Use the ASP.NET Core runtime image as base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project files and restore dependencies
COPY SearchRoles .
RUN dotnet restore "SearchRoles.csproj"

# Build the application
RUN dotnet build "SearchRoles.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "SearchRoles.csproj" -c Release -o /app/publish

# Final stage: use the published application to reduce image size
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SearchRoles.dll"]

# docker build -t my-web-app .
# docker run -d -p 8080:80 my-web-app
