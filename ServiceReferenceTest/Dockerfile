#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM harbor.aacoptics.com/bcproject/dotnet-runtime:7 AS base
WORKDIR /app

FROM harbor.aacoptics.com/bcproject/dotnet-sdk:7 AS build
WORKDIR /src
COPY ["WorkerService1/WorkerService1.csproj", "WorkerService1/"]
RUN dotnet restore "WorkerService1/WorkerService1.csproj"
COPY . .
WORKDIR "/src/WorkerService1"
RUN dotnet build "WorkerService1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WorkerService1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WorkerService1.dll"]