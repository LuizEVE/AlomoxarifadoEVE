use DBAlmoxarifadoXY
go

Create table Produto(
IdProduto int identity(1,1) Primary key,
Descricao varchar(100),
UnMedida varchar(100),
EPermanente bit(0) default
)
select * from Categoria
select * from Produto

insert into Produto(Descricao, UnMedida, EPermanente, EstoqueAtual, PrecoProduto, IdCategoria)
values('Arroz', 'Kilo', 0, '200', '15.50', '1');
insert into Produto(Descricao, UnMedida, EPermanente, EstoqueAtual, PrecoProduto, IdCategoria)
values('CocaCola', 'Litro', 0, '200', '10.00', '2');
insert into Produto(Descricao, UnMedida, EPermanente, EstoqueAtual, PrecoProduto, IdCategoria)
values('Notebook', 'Unidade', 1, '200', '2499.99', '3');
insert into Produto(Descricao, UnMedida, EPermanente, EstoqueAtual, PrecoProduto, IdCategoria)
values('Fogão', 'Unidade', 1, '200', '1999.99', '4');
insert into Produto(Descricao, UnMedida, EPermanente, EstoqueAtual, PrecoProduto, IdCategoria)
values('Sabao em po', 'Kilograma', 0, '200', '20.00', '5');
insert into Produto(Descricao, UnMedida, EPermanente, EstoqueAtual, PrecoProduto, IdCategoria)
values('Sofa', 'Unidade', 1, '200', '2599.99', '6');

