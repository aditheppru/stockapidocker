ARG VERSION=5.0-focal
FROM mcr.microsoft.com/dotnet/sdk:$VERSION AS build
WORKDIR /src

#test4
COPY ["StockApi/", "StockApi/"]

RUN dotnet publish "StockApi/StockApi.csproj" -c Release -o /app/publish
RUN ls -la /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:$VERSION AS final
ENV ASPNETCORE_URLS=http://+:8080
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "StockApi.Api.dll","--urls","http://0.0.0.0:8080"]
