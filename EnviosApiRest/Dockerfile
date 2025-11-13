# Etapa 1: compilaci�n
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copia y restaura dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia el resto del c�digo y compila
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: ejecuci�n
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .
EXPOSE 8080

ENTRYPOINT ["dotnet", "EnviosApiRest.dll"]
