FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env
WORKDIR /app

COPY . ./
RUN dotnet restore

RUN dotnet publish BuberDinner.Api -c Release -o publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/publish .
ENTRYPOINT [ "dotnet", "BuberDinner.Api.dll" ]