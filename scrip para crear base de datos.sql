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
go
create table servicio(
idservicio int identity (1,1)primary key not null,
nomcorto varchar(100),
descripcion varchar(100),
unmedida varchar(100),
montoxunmedida varchar(100),
fechaDato varchar(100)
)
go

create table pedido(
idpedido int primary key identity(1,1) not null,
idcliente int not null,
idusuario int not null,
idservicio int not null,
tola int not null,
FOREIGN KEY (idcliente) REFERENCES cliente(idcliente),
FOREIGN KEY (idusuario) REFERENCES usuario(idusuario),
FOREIGN KEY (idservicio) REFERENCES servicio(idservicio)
)







insert into cliente values('Juan Roman Riquelme', 'Iriondo 1729', '45678945', '444444445555')
go
insert into servicio values ('Pintar', 'C pinta wey', 'metro cuadrado', '50', '20/02/20')
go
insert into usuario values ('Prueba 1', 'Alsina 646', '54654987', '5555554', 'qwe', 'asd')
go