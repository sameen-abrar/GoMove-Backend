# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
WORKDIR /src

COPY *.sln .
COPY GoMove.API/GoMove.API.csproj ./GoMove.API/
COPY GoMove.Services/GoMove.Services.csproj ./GoMove.Services/
COPY GoMove.Repositories/GoMove.Repositories.csproj ./GoMove.Repositories/
# Add other project references as needed

RUN dotnet restore

COPY . .
RUN dotnet build -c Release --no-restore

# Publish Stage
FROM base AS publish
RUN dotnet publish -c Release --no-restore -o /app

# Final Stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=publish /app .

# Set the entry point
ENTRYPOINT ["dotnet", "GoMove.API.dll"]
