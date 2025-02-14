use DBAlmoxarifadoXYZ
go

select * from Categoria
Select * from Produto
Select * from Fornecedor
Select * from Entrada
Select * from ItensEntrada
Select * from Secretaria
Select * from Saida
Select * from ItensSaida

--Categoria
Insert into Categoria(Descricao)
values ('Alimentos')

--Produto
Insert into Produto(Descricao, UnMedida, EstoqueAtual, EPermanente, CodigoCategoria)
values ('Arroz', 'Kilo', '500', 0, '1')

--Fornecedor
insert into Fornecedor(NomeFornecedor, Endereco, Bairro, Cidade, Estado, Telefone, CNPJ)
values ('Luiz', 'Rua Caetano', 'Centro', 'Indiaroba', 'SE', '(79)9 9675-9541', '12.540.360/0001-21')

--Secretaria
insert into Secretaria(NomeSecretaria, Endereco, Bairro, Cidade, Estado, Telefone, CNPJ)
values ('Destribuidora', 'Rua Alguma Coisa', 'Alagoas', 'Estancia', 'SE', '(79)9 9600-0290')

--Entrada
insert into Entrada(DataEntrada, CodigoFronecedor, Observacao)
values ('09/01/2025', '1', 'Falta conferir')

--