# AmpaEspirituSantoMalaga
Es una pequeña aplicación de escritorio para la gestión de los socios del Ampa del Colegio Espiritu Santo de Málaga.
Esta aplicación esta personalizada para el Ampa del colegio Espiritu Santo, aunque puede ser utiliza por cualquier otra Ampa.

#Tecnologías utilizadas.
Dapper. Es motivo porque es una wrapper de Ado.Net y para hacer consulta y obtener los resultados se hace de una manera fácil y comoda.
Se ha utilizado una base de datos en access por la simplicidad que el archivo puede ser movido facilmente de un equipo a otro y para evitar más instalaciones. En un principio se penso utilizar una base de datos LocalDb (Sql Server), pero tenía tres problemas:
1) La primera vez que se abría la conexión tardaba mucho tiempo, debido que debía arrancar el servicio de sqlserver.
2) Al trabajar con un modo desconectado a la base de datos, si no se realizaban operaciones a la base de datos durante un tiempo el servicio se apagaba.
3) Es necesario instalarla.

# Requesitos.
Es necesario instalar el .Net Framework 4.

