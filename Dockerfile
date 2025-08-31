# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia os arquivos do projeto
COPY IdNetQrCodeDecoder/IdNetQrCodeDecoder.csproj ./
RUN dotnet restore

# Copia todo o código
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

# Define porta exposta
EXPOSE 8080

# Inicia a API
ENTRYPOINT ["dotnet", "IdNetQrCodeDecoder.dll"]
