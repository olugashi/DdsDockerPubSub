#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Publisher/DDSPublisher.csproj", "Publisher/"]
COPY ["DdsDataModel/DdsDataModel.csproj", "DdsDataModel/"]
RUN dotnet restore "Publisher/DDSPublisher.csproj"
COPY . .
WORKDIR "/src/Publisher"
RUN dotnet build "DDSPublisher.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DDSPublisher.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DDSPublisher.dll"]