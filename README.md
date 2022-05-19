# TestUnityNodeJS

Test Unity with NodeJS and Express

# Instrucciones de instalación:

Clonar el repositorio en cualquier carpeta.

## Servidor:

Requisitos:

- Tener instalador NodeJS y el gestor de paquetes npm.
- Una vez instalados comprobarlo con node -v y npm -v. Tendrá que salir la versión actual instalada.

Desplegar el proyecto de node con npm:

- Dentro de la carpeta Server, habrá un archivo llamado "package.json". Ejecutar el siguiente comando para desplegar las dependencias:
  npm install
- Una vez desplegadas las dependencias, ejecutaremos el servidor a través del archivo "server.js" con el comando:
  node server.js

## Cliente:

Requisitos:

- Tener instalado Unity con la versión 2021.3.2f1

## Ejecución:

- Asegurarse de tener ejecutado el servidor antes de ejecutar la aplicación.
- Abrir el proyecto TestUnityNodeJS con Unity y abrir la escena "SampleScene"
- Pulsar en play para ejecutar la escena.
- Pulsar en el botón Connect y deberá devolver la hora actual mostrada en un campo de texto.

## Opcional:

- Sustituye/añade otra implementación del servicio usando sólo Node, sin requerir de Express.js
  En el archivo "nodeServer.js" podemos encontrar la implementación usando sólo Node. Ejecutar el servidor usando el siguiente comando:
  node nodeServer.js

- Formatea la hora de salida a tu gusto, con algún paquete de node a tu elección, por ejemplo: https://www.npmjs.com/package/date-and-time
  Se ha utilizado el paquete recomendado para formatear la hora

- Añade y configura un linter de tu elección al proyecto Node con una configuración básica, por ejemplo: https://github.com/airbnb/javascript
  He configurado ESlint con la guía de estilo airbnb y rectificado el fichero "server.js". Además he añadido una regla para el control de versiones git en "eslintrc.json":
  "rules": {
  "git" : "\*.js text eol=lf"
  }
