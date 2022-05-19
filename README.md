# TestUnityNodeJS
Test Unity with NodeJS and Express

Instrucciones de instalación:
========================================

Clonar el repositorio en cualquier carpeta.

Servidor:
----------

Requisitos:
 - Tener instalador NodeJS y el gestor de paquetes npm.
 - Una vez instalados comprobarlo con node -v y npm -v. Tendrá que salir la versión actual instalada.

Desplegar el proyecto de node con npm:
 - Dentro de la carpeta Server, habrá un archivo llamado "package.json". Ejecutar el siguiente comando para desplegar las dependencias:
    npm install
 - Una vez desplegadas las dependencias, ejecutaremos el servidor a través del archivo "server.js" con el comando:
    node server.js

Cliente:
----------

Requisitos:
 - Tener instalado Unity con la versión 2021.3.2f1




Ejecución:
----------

 - Asegurarse de tener ejecutado el servidor antes de ejecutar la aplicación.
 - Abrir el proyecto TestUnityNodeJS con Unity y abrir la escena "SampleScene"
 - Pulsar en play para ejecutar la escena.
 - Pulsar en el botón Connect y deberá devolver la hora actual mostrada en un campo de texto.
