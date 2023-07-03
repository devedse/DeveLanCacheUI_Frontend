FROM nginx:stable-alpine AS base
COPY ./DeveLanCacheUI_Frontend/nginxconfig/nginx.conf /etc/nginx/nginx.conf
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DeveLanCacheUI_Frontend/DeveLanCacheUI_Frontend.csproj", "DeveLanCacheUI_Frontend/"]
RUN dotnet restore "DeveLanCacheUI_Frontend/DeveLanCacheUI_Frontend.csproj"
COPY . .
WORKDIR "/src/DeveLanCacheUI_Frontend"
RUN dotnet build "DeveLanCacheUI_Frontend.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_VERSION
ARG VER=${BUILD_VERSION:-1.0.0}
RUN dotnet publish "DeveLanCacheUI_Frontend.csproj" -c Release -o /app/publish /p:Version=$VER /p:UseAppHost=false

FROM base AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
CMD ["nginx", "-g", "daemon off;"]