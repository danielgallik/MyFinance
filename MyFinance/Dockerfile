ARG TARGETARCH
ARG BUILDPLATFORM
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Copy csproj and restore with target architecture
COPY *.csproj ./
RUN dotnet restore -a $TARGETARCH

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release --no-restore -a $TARGETARCH -o /app/publish

# Runtime stage - use target platform
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000
ENTRYPOINT ["dotnet", "MyFinance.dll"]