FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY bin/Release/netcoreapp3.1/publish /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "k8s-demo.dll"]