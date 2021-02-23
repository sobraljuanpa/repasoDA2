# Comandos ejecutados durante la creacion del proyecto

## Crear proyecto webapi
```
dotnet new webapi -o ListsApi
```

## Agrego dependencia entityframeworkcore con sqlite
```
dotnet add package Microsoft.EntityFrameworkCore.SQLite
```

## Agrego dependencias para scaffolding de controllers
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m Grocery -dc ListsContext -outDir Controllers
dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m Expense -dc ListsContext -outDir Controllers
```

## Primera migracion para crear la base de datos
```
dotnet ef migrations add CreateDatabase
dotnet ef database update
```