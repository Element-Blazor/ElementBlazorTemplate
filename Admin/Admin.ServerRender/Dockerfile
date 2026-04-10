#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["template/Admin/Admin.ServerRender/Element.Admin.ServerRender.csproj", "template/Admin/Admin.ServerRender/"]
COPY ["template/Admin/Admin/Element.Admin.csproj", "template/Admin/Admin/"]
COPY ["src/Markdown/Element.Markdown.csproj", "src/Markdown/"]
COPY ["src/Components/Element.csproj", "src/Components/"]
RUN dotnet restore "template/Admin/Admin.ServerRender/Element.Admin.ServerRender.csproj"
COPY . .
WORKDIR "/src/template/Admin/Admin.ServerRender"
RUN dotnet build "Element.Admin.ServerRender.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Element.Admin.ServerRender.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Element.Admin.ServerRender.dll"]