# Generador_Token

# Generador de Tokens

Aplicación de escritorio desarrollada en C# con Windows Forms para gestionar y generar tokens de activación asociados a equipos.

Permite consultar registros, generar códigos de activación y administrar equipos registrados mediante una base de datos MySQL.

## Funcionalidades

- Generación de tokens de activación.
- Consulta de equipos registrados.
- Asociación de tokens con equipos y direcciones MAC.
- Eliminación de registros.
- Conexión a base de datos MySQL.

## Tecnologías

- C#
- .NET Framework 4.7.2
- Windows Forms
- MySQL
- MySqlConnector

## Configuración

Por seguridad, las credenciales de la base de datos no deben incluirse en el repositorio. Configura los datos de conexión mediante variables de entorno o un archivo local ignorado por Git.

Crea un archivo de configuración local basado en la plantilla disponible y agrega tus valores:

```env
DB_HOST=TU_SERVIDOR
DB_NAME=TU_BASE_DE_DATOS
DB_USER=TU_USUARIO
DB_PASSWORD=TU_CONTRASENA
