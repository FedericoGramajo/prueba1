create database prueba 
go
use prueba

create table cliente(
idcliente int identity (1,1) primary key not null,
nombre varchar (100) not null,
direccion varchar (100),
dni varchar (100),
telefono varchar (100)
)
go
create table usuario (
idusuario int identity (1,1) primary key not null,
nombre varchar (100) not null,
direccion varchar (100),
dni varchar (100),
telefono varchar (100),
usuarionom varchar (100), 
contraseña varchar (100)
)