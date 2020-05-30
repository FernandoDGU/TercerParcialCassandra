DROP KEYSPACE IF EXISTS ExamenCassandra;

CREATE KEYSPACE IF NOT EXISTS "ExamenCassandra"
WITH durable_writes = true AND replication = {
	'class' : 'SimpleStrategy',
	'replication_factor' : 1
};

Use "ExamenCassandra";

DROP TABLE IF EXISTS Nota_venta;

CREATE TABLE Nota_venta(
idVenta		uuid, 
Nom_cliente	text,
Nom_Empresa	text,
Nombre_Empleado text,
Producto LIST<FROZEN<tuple<int,decimal,text>>>, //Cantidad,Precio,Nombre del producto (Data collection)
Fecha_Compra	timestamp, //(Date)
Total_final	decimal,
Primary Key(idVenta)
);