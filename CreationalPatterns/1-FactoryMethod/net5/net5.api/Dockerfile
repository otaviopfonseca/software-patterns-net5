#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["net5.api/net5.api.csproj", "net5.api/"]
RUN dotnet restore "net5.api/net5.api.csproj"
COPY . .
WORKDIR "/src/net5.api"
RUN dotnet build "net5.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "net5.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "net5.api.dll"]