FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Base/Base.csproj", "Base/"]
RUN dotnet restore "Base/Base.csproj"
COPY . .
WORKDIR "/src/Base"
RUN dotnet build "Base.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Base.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Base.dll"]
