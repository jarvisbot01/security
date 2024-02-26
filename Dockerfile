ARG VARIANT=8.0.401-bookworm-slim-amd64
FROM mcr.microsoft.com/dotnet/sdk:${VARIANT} AS build
WORKDIR /source
EXPOSE 8080

COPY Api/*.csproj Api/
COPY Application/*.csproj Application/
COPY Domain/*.csproj Domain/
COPY Persistence/*csproj Persistence/
RUN dotnet restore Api/Api.csproj

COPY Api/ Api/
COPY Application/ Application/
COPY Domain/ Domain/
COPY Persistence/ Persistence/

FROM build AS publish
WORKDIR /source/Api
RUN dotnet publish --no-restore -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0.8-bookworm-slim-amd64
WORKDIR /app
ENV DEBIAN_FRONTEND=noninteractive
RUN apt-get update && apt-get upgrade -y \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/*
    
COPY --from=publish /app .

ENTRYPOINT ["dotnet"]
CMD ["Api.dll"]
