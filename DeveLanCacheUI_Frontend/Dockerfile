#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim-amd64 AS build
WORKDIR /src
COPY ["DeveLanCacheUI_Frontend/DeveLanCacheUI_Frontend.csproj", "DeveLanCacheUI_Frontend/"]
RUN dotnet restore "DeveLanCacheUI_Frontend/DeveLanCacheUI_Frontend.csproj"
COPY . .
WORKDIR "/src/DeveLanCacheUI_Frontend"
RUN dotnet build "DeveLanCacheUI_Frontend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DeveLanCacheUI_Frontend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DeveLanCacheUI_Frontend.dll"]