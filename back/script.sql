use master
go
if exists(select * from sys.databases where name = 'TDSalbado')
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

);