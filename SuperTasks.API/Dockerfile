FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SuperTasks.API/SuperTasks.API.csproj", "SuperTasks.API/"]
COPY ["SuperTasks.Application/SuperTasks.Application.csproj", "SuperTasks.Application/"]
COPY ["SuperTasks.Domain/SuperTasks.Domain.csproj", "SuperTasks.Domain/"]
COPY ["SuperTasks.Infrastructure/SuperTasks.Infrastructure.csproj", "SuperTasks.Infrastructure/"]
RUN dotnet restore "SuperTasks.API/SuperTasks.API.csproj"
COPY . .
WORKDIR "/src/SuperTasks.API"
RUN dotnet build "SuperTasks.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SuperTasks.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SuperTasks.API.dll"]
