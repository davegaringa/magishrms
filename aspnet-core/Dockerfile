# FROM microsoft/aspnetcore-build as build-image
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-image
 
WORKDIR /home/app
 
COPY ./*.sln ./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done
 
RUN dotnet restore
 
COPY . .
 
RUN dotnet test ./Tests/Tests.csproj
 
RUN dotnet publish ./MagisHRMS/MagisHRMS.csproj -o /publish/
 
# FROM microsoft/aspnetcore
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
 
WORKDIR /publish
 
COPY --from=build-image /publish .
 
# ENTRYPOINT ["dotnet", "MagisHRMS.dll"]

CMD ASPNETCORE_URLS=http://*:$PORT dotnet MagisHRMS.dll