create database projetoclientes;
GO

create table clientes ( id int primary key, nome varchar(50), email varchar(50) );
GO

insert into clientes values (1,'Ana', 'ana@senai.edu.br');

insert into clientes values (2,'Benja', 'benja@senai.edu.br');

insert into clientes values (3,'Cezar', 'cezar@senai.edu.br');

select * from clientes;

use projetoclientes;
go
CREATE TABLE usuarios (
	id INT PRIMARY KEY IDENTITY,
	email VARCHAR(100) UNIQUE NOT NULL,
	senha VARCHAR(255) NOT NULL
);

INSERT INTO usuarios VALUES ('carlos@teste.com', '1345');
INSERT INTO usuarios VALUES ('eduardo@teste.com', '13456');
INSERT INTO usuarios VALUES ('miranda@teste.com', '134567');

select * from usuarios;


select email, senha from usuarios where id =2;

select email, HASHBYTES('md2',senha) from usuarios where id =2;
select email, HASHBYTES('md4',senha) from usuarios where id =2;
select email, HASHBYTES('md5',senha) from usuarios where id =2;

select email, senha, HASHBYTES('md5',senha) from usuarios;


select email, senha, HASHBYTES('md5',senha) as 'hashbytes', PWDENCRYPT(senha) as 'pwdencrypt' from usuarios;