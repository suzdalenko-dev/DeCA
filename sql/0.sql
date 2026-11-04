/*
dotnet user-secrets set "ConnectionStrings:DeCa" "Server=db77778.public.databaseasp.net,1433;Database=db77778;User Id=db77778;Password=Tc4?+9LxaB@8;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True"
Server=db77778.databaseasp.net;Database=db77778;User Id=db77778_suzdalenko;Password=8e-E_9GxhK?7;Encrypt=False;MultipleActiveResultSets=True;

Local: ConnectionStrings:DeCa mediante User Secrets.

MonsterASP.NET: ConnectionStrings__DeCa mediante variables de entorno.

Producción: ASPNETCORE_ENVIRONMENT=Production.

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.5
dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.5
dotnet tool install --global dotnet-ef --version 10.0.5

dotnet ef migrations add InitialCreate1
dotnet ef database update

public
Tc4?+9LxaB@8
*/

SELECT
    TABLE_SCHEMA,
    TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_SCHEMA, TABLE_NAME
;


select * from users;
