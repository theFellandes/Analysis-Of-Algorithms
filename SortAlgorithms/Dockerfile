FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SortAlgorithms/SortAlgorithms.csproj", "SortAlgorithms/"]
RUN dotnet restore "SortAlgorithms/SortAlgorithms.csproj"
COPY . .
WORKDIR "/src/SortAlgorithms"
RUN dotnet build "SortAlgorithms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SortAlgorithms.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SortAlgorithms.dll"]
