use master
go
if exists(select * from sys.databases where name = 'TDSabado')
	drop database TDSabado
go

create database TDSabado
go

use TDSabado
go

create table Usuario(
	ID int identity primary key ,
	Nome varchar(100) not null,
	DataNascimento date not null,
	Username varchar(60) not null,
	userpass varchar(MAX) not null,
);

/*Usar token para o funcionario no tcc*/
create table Token(
	ID int identity primary key,
	UserID int references Usuario(ID),
	Value varchar(MAX) not null,
);
go

/*Usar no tcc */
create table Post(
	ID int identity primary key,
	UserID int references Usuario(ID),
	Moment datetime not null,
	Content varchar(MAX) not null,
);
go

create table PostImage(
	ID int identity primary key,
	PostId int references Post(ID),
	Bytes image not null,
);
go
select * from Usuario

/*Mostrar quem deu like no banco de dados*/
create table Likes(
	ID int identity primary key,
	PostId int references Post(ID),
	UserID int references Usuario(ID),
);
go

create table follow(
	ID int identity primary key,
	FollowId int references Usuario(ID),
	FollowerID int references Usuario(ID),
);