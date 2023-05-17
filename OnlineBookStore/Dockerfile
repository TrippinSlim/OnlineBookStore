FROM mcr.microsoft.com/dotnet/aspnet:6.0

COPY /bin/Release/net6.0/publish/ OnlineBookStore/

ENV ASPNETCORE ENVIRONMENT Book
ENV Logging__Console__FormatterName=Simple

EXPOSE 5000
WORKDIR /OnlineBookStore
ENTRYPOINT ["dotnet", "OnlineBookStore.dll", "--urls=http://0.0.0.0:5000"]