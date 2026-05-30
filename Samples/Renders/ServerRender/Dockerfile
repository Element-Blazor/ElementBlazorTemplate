#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["template/Samples/Renders/ServerRender/Element.ServerRender.csproj", "template/Samples/Renders/ServerRender/"]
COPY ["src/Components/Element.csproj", "src/Components/"]
COPY ["demo/demo.csproj", "demo/"]
COPY ["src/Markdown/Element.Markdown.csproj", "src/Markdown/"]
COPY ["src/X/Element.X.csproj", "src/X/"]
RUN dotnet restore "template/Samples/Renders/ServerRender/Element.ServerRender.csproj"
COPY . .
WORKDIR "/src/template/Samples/Renders/ServerRender"
RUN dotnet build "Element.ServerRender.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Element.ServerRender.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Element.ServerRender.dll"]
