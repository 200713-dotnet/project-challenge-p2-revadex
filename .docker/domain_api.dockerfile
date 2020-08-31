# DOMAIN SERVICE DOCKERFILE
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /workspace
COPY . . 
RUN dotnet publish -c Release -o out Domain.Service/DomainService.Client/*.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /workspace
COPY --from=build /workspace/out .
CMD [ "dotnet", "Domain.Service.dll" ]