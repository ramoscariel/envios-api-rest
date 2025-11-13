## Requerimientos

- Docker

## Pasos de instalación y ejecución

1. Clonar repositorio

(En la raíz del proyecto)

2. `cd EnviosApiRest`
3. Construir imagen: `docker build -t envios-api .`
4. Ejecutar contenedor: `docker run -p 8080:8080 envios-api`

En .NET 9 los paquetes Swashbuckle/Swagger son reemplazados por los paquetes:

- Microsoft.AspNetCore.OpenApi
- Scalar.AspNetCore

## URLs

- OpenAPI JSON: http://localhost:8080/openapi/v1.json
- Interfaz: http://localhost:8080/scalar/
