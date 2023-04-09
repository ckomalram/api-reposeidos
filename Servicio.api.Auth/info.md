# 1.0.1

- Crear proyecto
- Instalar librerías
- Crear entidad User
- Crear contexto de seguridad
- Crear ConnectionString en appsettings.json
- Se inyecta sql server en program cs
- Se inyecta iodentity core en program cs
- Se inyecta SystemClock para hora actual en programcs.
- Se crea securitycontextData
- Se inyecta securitycontextdata en program.cs
- Crear migracion
  - dotnet ef migrations add InitialCreate
- Ejecutar Migracion
  - dotnet ef database update
