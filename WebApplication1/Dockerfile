# Use the official .NET 8 SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the csproj and restore dependencies
COPY ["WebApplication1.csproj", "./"]
RUN dotnet restore "WebApplication1.csproj"

# Copy the rest of the code and build it
COPY . .
RUN dotnet build "WebApplication1.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "WebApplication1.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final stage: Use the runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Set the environment variable for the ASP.NET Core port
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

ENTRYPOINT ["dotnet", "WebApplication1.dll"]
