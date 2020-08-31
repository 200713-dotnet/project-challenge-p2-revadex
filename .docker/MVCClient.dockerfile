# MVC DOCKERFILE
FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /workspace
COPY . . 
RUN dotnet publish -c Release -o out Stardex.MVCClient/StarDex.Client/*.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /workspace
COPY --from=build /workspace/out .
CMD [ "dotnet", "StarDex.MVCClient.dll" ]