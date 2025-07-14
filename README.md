🐾 Critipedia
Critipedia es una API REST desarrollada en ASP.NET Core para gestionar una enciclopedia de criaturas fantásticas o reales. Pensada para uso educativo, juegos o sistemas de catalogación.

✨ Características principales
CRUD completo para criaturas con detalles

Uso de Entity Framework Core para gestión de base de datos SQL Server

Pruebas unitarias con xUnit

Contenerización con Docker

Arquitectura limpia y modular

🧰 Tecnologías utilizadas
ASP.NET Core 7.0

Entity Framework Core

SQL Server

xUnit para pruebas

Docker

AutoMapper

🚀 Ejecución local
Clona el repositorio

Abre la solución Critipedia.sln en Visual Studio o Rider

Configura la cadena de conexión en appsettings.Development.json

Ejecuta el proyecto Critipedia.API (F5 o desde terminal con dotnet run en la carpeta src/Critipedia.API)

🧪 Pruebas
Desde la carpeta de tests:

bash
Copiar
Editar
dotnet test
📁 Estructura del proyecto
bash
Copiar
Editar
Critipedia/
├── src/
│   └── Critipedia.API/       # Proyecto API
├── tests/
│   └── Critipedia.Tests/     # Proyecto pruebas xUnit
├── Dockerfile
└── Critipedia.sln
👨‍💻 Autor
Raúl González Galán
🔗 LinkedIn
💻 GitHub

📄 Licencia
MIT License

