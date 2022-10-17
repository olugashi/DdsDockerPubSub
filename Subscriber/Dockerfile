#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Subscriber/DDSSubscriber.csproj", "Subscriber/"]
COPY ["DdsDataModel/DdsDataModel.csproj", "DdsDataModel/"]
RUN dotnet restore "Subscriber/DDSSubscriber.csproj"
COPY . .
WORKDIR "/src/Subscriber"
RUN dotnet build "DDSSubscriber.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DDSSubscriber.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DDSSubscriber.dll"]