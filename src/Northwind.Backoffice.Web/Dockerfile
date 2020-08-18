#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY Northwind.Backoffice.Web/Northwind.Backoffice.Web.csproj Northwind.Backoffice.Web/
COPY Northwind.Backoffice.Core/Northwind.Backoffice.Core.csproj Northwind.Backoffice.Core/
COPY Northwind.Backoffice.Infrastructure/Northwind.Backoffice.Infrastructure.csproj Northwind.Backoffice.Infrastructure/
COPY . .
WORKDIR "/src/Northwind.Backoffice.Web"
RUN dotnet build "Northwind.Backoffice.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Northwind.Backoffice.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Northwind.Backoffice.Web.dll"]
