# DOMAIN SERVICE DOCKERFILE
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /workspace
COPY . . 
RUN dotnet publish -c Release -o out DomainService.ClientMVC/*.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /workspace
COPY --from=build /workspace/out .
CMD [ "dotnet", "DomainService.dll" ]