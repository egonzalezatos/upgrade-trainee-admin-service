FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
EXPOSE 80
WORKDIR app/
COPY ./release .
    
#ENV
ENV ASPNETCORE_ENVIRONMENT=Development
ENV DB_SERVER=localhost
ENV DB_PORT=1433
ENV DB_USERNAME=sa
ENV DB_PASSWORD=11111
ENV DB_DATABASE=ProfileManagementDB
ENV GRPC_PORT=666

ENTRYPOINT ["dotnet", "Upgrade.TraineeAdmin.dll"]