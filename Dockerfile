ARG VARIANT=8.0.415-bookworm-slim-amd64
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
RUN dotnet publish -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0.21-bookworm-slim-amd64
WORKDIR /app
ENV DEBIAN_FRONTEND=noninteractive
RUN apt-get update -qq && apt-get upgrade -qq --no-install-recommends --no-install-suggests -yy && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

RUN groupadd --gid 1001 appgroup && \
    useradd --uid 1001 --no-create-home --shell /sbin/nologin -g appgroup appuser

COPY --from=publish /app .

RUN chown -R appuser:appgroup /app
RUN chmod -R 755 /app
USER appuser

ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet"]
CMD ["Api.dll"]
