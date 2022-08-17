create database InventarioPlata
use InventarioPlata

create table Producto(
	IdProducto varchar(8) primary key not null,
	Articulo varchar(max),
	Precio varchar(max),
	Cantidad varchar(max),
	Medidas varchar(max),
	Categoria varchar(max),
	Familia varchar(max),
	Formato varchar(max),
	Modelo varchar(max),
	Comodin varchar(max),
);

create table Imagenes(
	IdImg int identity primary key not null,
	IdProducto varchar (8),
	NombreProducto varchar(max),
	Img image,
	foreign key (IdProducto) references Producto(IdProducto) on delete cascade
)

create table Total(
	IdTotal int identity primary key not null,
	Total varchar(max),
	TotalArt varchar (max),
	Fecha varchar(max),
	IdProducto varchar (8),
	foreign key (IdProducto) references Producto(IdProducto) on delete cascade,
	foreign key (IdProducto) references Producto(IdProducto) on update cascade
)

drop table Imagenes
drop table Producto
select * from Producto
select * from Imagenes
select * from Total
drop table Total