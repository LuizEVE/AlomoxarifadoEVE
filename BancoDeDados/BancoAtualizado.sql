 create database DBAlmoxarifadoXYZ
 go
 use DBAlmoxarifadoXYZ
 go

 create table  Categoria(
    Codigo int identity(1,1) Primary key,
    Descricao varchar(100)
);

CREATE TABLE Produto (
    Codigo INT IDENTITY(1,1) PRIMARY KEY,
    Descricao VARCHAR(100) NOT NULL,
    UnMedida VARCHAR(100) NOT NULL,
    EstoqueAtual FLOAT,
    EPermanente BIT DEFAULT 0 -- Define 0 como valor padrão
);

Create table (

);