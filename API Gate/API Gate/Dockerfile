#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API Gate/API Gate.csproj", "API Gate/"]
RUN dotnet restore "API Gate/API Gate.csproj"
COPY . .
WORKDIR "/src/API Gate"
RUN dotnet build "API Gate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API Gate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API Gate.dll"]