# NetCore6APIMYSQL

Este es un proyecto en .NET 6 que implementa una API para acceder a una base de datos MySQL utilizando Dapper y MySQL.Data.

## Requisitos previos

Antes de ejecutar el proyecto, asegúrate de tener instalado lo siguiente:

- .NET 6 SDK (https://dotnet.microsoft.com/download/dotnet/6.0)

## Configuración

1. Abre el archivo `appsettings.json` y asegúrate de que la cadena de conexión a MySQL sea correcta. Verifica que el servidor, puerto, nombre de la base de datos, usuario y contraseña sean los correctos.

```json
{
"Logging": {
"LogLevel": {
"Default": "Information",
"Microsoft.AspNetCore": "Warning"
}
},
"AllowedHosts": "*",
"ConnectionStrings": {
"MySqlConnection": "server=localhost;port=3306;database=dbmarket;uid=user;password=Soyunpoposin1."
}
}
```

## Compilación y ejecución

Para compilar el proyecto, ejecuta el siguiente comando en la línea de comandos:

```
dotnet build
```

Una vez compilado con éxito, puedes ejecutar el proyecto con el siguiente comando:

```
dotnet run --project NetCore6APIMYSQL
```

Asegúrate de ejecutar el comando dentro del directorio raíz del proyecto.

La aplicación se ejecutará y estará disponible en `https://localhost:5001`.

## Uso

Puedes utilizar Swagger para explorar y probar los endpoints de la API. Abre tu navegador web y visita `https://localhost:5001/swagger/index.html`. Aquí encontrarás una interfaz interactiva que muestra todos los endpoints disponibles y te permite realizar solicitudes HTTP.

## Consideraciones adicionales

- En este proyecto de ejemplo, cada vez que se realiza una consulta a la base de datos, se crea una nueva conexión. Esto puede afectar el rendimiento en aplicaciones con un alto volumen de consultas. Considera implementar una estrategia de administración de conexiones más eficiente en entornos de producción.
- Asegúrate de mantener la seguridad de la cadena de conexión a la base de datos, evitando incluir credenciales confidenciales en repositorios públicos o compartirlos de manera insegura.
