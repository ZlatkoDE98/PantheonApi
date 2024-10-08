# Use the official .NET SDK as the base image for building the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy .csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the entire project and build the release
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official .NET runtime as the base image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the output from the build image
COPY --from=build /app/out .


# Start the application
ENTRYPOINT ["dotnet", "PantheonApi.dll"]
