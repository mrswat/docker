ARG aspnet_ver=8.0
ARG netsdk_ver=8.0

FROM mcr.microsoft.com/dotnet/sdk:${netsdk_ver} AS build
WORKDIR /src
COPY src/*.csproj .
RUN dotnet restore
COPY src .
RUN dotnet build -c Release --no-restore

FROM build AS publish
RUN dotnet publish -c Release -o /publish --no-build

FROM mcr.microsoft.com/dotnet/aspnet:${aspnet_ver} AS runtime
WORKDIR /publish
COPY --from=publish /publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "DockerTest.dll"]