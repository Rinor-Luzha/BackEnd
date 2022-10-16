#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Ratings.Elefanti/Ratings.Elefanti.csproj", "Ratings.Elefanti/"]
RUN dotnet restore "Ratings.Elefanti/Ratings.Elefanti.csproj"
COPY . .
WORKDIR "/src/Ratings.Elefanti"
RUN dotnet build "Ratings.Elefanti.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ratings.Elefanti.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ratings.Elefanti.dll"]