#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cartegory.API/Cartegory.API.csproj", "Cartegory.API/"]
RUN dotnet restore "Cartegory.API/Cartegory.API.csproj"
COPY . .
WORKDIR "/src/Cartegory.API"
RUN dotnet build "Cartegory.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cartegory.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cartegory.API.dll"]