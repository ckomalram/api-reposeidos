# Parte # 1 Dev - Init

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

# Parte # 2 Dev - Implementando pattern CQRS

Crear DTO
Crear MappingProfile
Instalar librerías FluentValidation
Instalar librerías MediaTR
Crear Register Class
Inyectar a program.cs automapper
Inyectar a program.cs mediatr
Inyectar a program.cs fluentvalidation
Crear controlador

# Parte # 3 Dev - JWT en nuestros Microservices ( https://randomkeygen.com/)

Instalar librerías para JWT
Crear clase JWT
Inyectar con addscopre la clase token en program.cs
Crear logica de token en el register.cs
