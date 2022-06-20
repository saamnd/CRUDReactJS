1. Ejecutar el script scriptdb.sql para inicializar la base de datos MS SQL Server

2. Ingresar a la carpeta "backend"
3. Modificar la conexión mediante el API en el backend de ser necesario

-en la carpeta backend/prueba3/appsettings.json

  "ConnectionStrings": {
    "Conexion": "Data Source=.;Initial catalog=DB;Integrated Security=true"
  },

en este caso el Server es del tipo Authentication = Windows Authentication

4. Ejecutar ApiInv.sln

5. Abrir la carpeta "frontend" 

6. ejecutar los siguientes comandos en la terminal
-npm install
-npm start
