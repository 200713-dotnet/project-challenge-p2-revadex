# IMAGE SERVICE DOCKERFILE
FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /workspace
COPY . . 
RUN dotnet publish -c Release -o out Image.Service/ImageService.sln

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /workspace
COPY --from=build /workspace/out .
CMD [ "dotnet", "Image.Service.dll" ]