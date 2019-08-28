CREATE SCHEMA public
    AUTHORIZATION postgres;

COMMENT ON SCHEMA public
    IS 'Registro de Recem Nascidos';

GRANT ALL ON SCHEMA public TO postgres;

GRANT ALL ON SCHEMA public TO PUBLIC;
--==================Tabela de Estados=========================
CREATE TABLE IF NOT EXISTS UF (
	ID SERIAL PRIMARY KEY NOT NULL,
	Estado VARCHAR(20) UNIQUE NOT NULL
);
INSERT INTO Uf(estado) VALUES ('AC'),('AL'),('AM'),('AP'),('BA'),('CE'),('DF'),('ES'),('GO'),('MA'),('MG'),('MS'),('MT'),('PA'),('PB'),('PE'),('PI'),('PR'),('RJ'),('RN'),('RO'),('RR'),('RS'),('SC'),('SE'),('SP'),('TO');
--==================Tabela nome das cidades 'arruar'===========
CREATE TABLE IF NOT EXISTS Naturalidade (
	ID SERIAL PRIMARY KEY NOT NULL,
	Cidade VARCHAR(20) UNIQUE NOT NULL
);
--=================Tipo do livro de registros A / C AUX==========
CREATE TABLE IF NOT EXISTS Tipo_Livro (
	ID SERIAL PRIMARY KEY NOT NULL,
	Descricao VARCHAR(10) NOT NULL
);
insert into tipo_livro(descricao) values('A'),('C AUX');
--============================Tabela de Recem Nascidos===========
CREATE TABLE IF NOT EXISTS Recem_Nascido (
	ID SERIAL PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Data_Nascimento varchar(20) NOT NULL,
	Hora_Nascimento VARCHAR(10),
	DNVDO VARCHAR(20),
	ID_Sexo INT NOT NULL
);
--=======================Livro de Registros=====================
CREATE TABLE IF NOT EXISTS Livro (
	ID SERIAL PRIMARY KEY NOT NULL,
	ID_Tipo INT NOT NULL,
	ID_Rn INT NOT NULL,
	Numero_Pagina INT NOT NULL,
	Numero_Registro INT NOT NULL,
	Numero_Livro INT NOT NULL,
	FOREIGN KEY(ID_Tipo) REFERENCES Tipo_Livro (ID),
	FOREIGN KEY(ID_Rn) REFERENCES Recem_Nascido (ID)
);
--============================Padronização Sexo==============
CREATE TABLE IF NOT EXISTS Sexo (
	ID SERIAL PRIMARY KEY NOT NULL,
	Descricao VARCHAR(10) NOT NULL
);
INSERT INTO sexo(descricao) VALUES ('Masculino'),('Feminino');
--=========================Padronização Grau de parentesco=========
CREATE TABLE IF NOT EXISTS Grau_Parentesco (
	ID SERIAL PRIMARY KEY,
	Tipo VARCHAR(20) NOT NULL
);
INSERT INTO grau_parentesco(Tipo) VALUES ('Pai'),('Mae');
--===========================Tabela de Parentes=================
CREATE TABLE IF NOT EXISTS Parentes (
	ID SERIAL PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Data_Nascimento VARCHAR(20) NOT NULL,
	Idade INT NOT NULL,
	ID_Uf INT NOT NULL,
	ID_Naturalidade INT NOT NULL,
	ID_Parentesco INT NOT NULL,
	ID_Rn INT NOT NULL,
	FOREIGN KEY(ID_Uf) REFERENCES UF (ID),
	FOREIGN KEY(ID_Naturalidade) REFERENCES Naturalidade (ID),
	FOREIGN KEY(ID_Parentesco) REFERENCES Grau_Parentesco (ID),
	FOREIGN KEY(ID_Rn) REFERENCES Recem_Nascido (ID)
);

ALTER TABLE Recem_Nascido ADD FOREIGN KEY(ID_Sexo) REFERENCES Sexo (ID);
--===================================================================================================================
--============================FUNÇÕES================================================================================
--===================================================================================================================
--========================CONSULTA PARENTES==========================================================================
CREATE OR REPLACE FUNCTION pesquisaParente(_pesquisa varchar(20))
returns table(
	Nome varchar(50),
	Data_nascimento varchar(20),
	Idade INT,
	Uf varchar(10),
	Naturalidade varchar(10),
	Filho varchar(50)
)as
$$
begin
	return query
	SELECT pa.nome, pa.data_nascimento, pa.idade, u.estado, n.cidade, r.nome
	FROM Parentes AS pa
	INNER JOIN uf AS u ON pa.id_uf = u.id
	INNER JOIN naturalidade AS n ON pa.id_naturalidade = n.id
	INNER JOIN recem_nascido AS r ON pa.id_rn = r.id
	WHERE pa.nome like '%' || _pesquisa || '%';
end
$$
language plpgsql;
DROP FUNCTION pesquisaparente(character varying)
--====================================================================================================================
--=======================================Função de consulta Recem Nascido POR NOME====================================
CREATE OR REPLACE FUNCTION pesquisaNomeRN(_pesquisa varchar(20))
returns table(
	Nome varchar(50),
	Data_Nascimento varchar(10),
	Hora_Nascimento varchar(10),
	Sexo varchar(10),
	Tipo_Livro varchar(10),
	Numero_Livro int,
	Numero_Pagina int,
	Numero_Registro int,
	DnvDo varchar(20),
	Pai varchar(50),
	Mae varchar(50)
)as
$$
begin
	return query
	SELECT r.nome, r.data_nascimento, r.hora_nascimento,  s.descricao, tl.descricao, l.numero_livro,l.numero_pagina, l.numero_registro, r.dnvdo, p.nome, p1.nome
	FROM Recem_Nascido AS r
	INNER JOIN Sexo AS s ON r.id_sexo = s.id
	INNER JOIN livro AS l on l.id_rn = r.id
	INNER JOIN tipo_livro AS tl ON tl.id = l.id_tipo
	INNER JOIN Parentes AS p ON r.id = p.id_rn and p.id_parentesco = 1
	INNER JOIN Parentes as p1 ON r.id = p1.id_rn and p1.id_parentesco = 2	
	WHERE r.nome like '%' || _pesquisa || '%';
end
$$
language plpgsql;

--====================================================================================================================================
--=================================================PESQUISA DE RN POR DNV / DO========================================================
CREATE OR REPLACE FUNCTION pesquisaDnvDo(_pesquisa varchar(20))
returns table(
	Nome varchar(50),
	Data_Nascimento varchar(10),
	Hora_Nascimento varchar(10),
	Sexo varchar(10),
	Tipo_Livro varchar(10),
	Numero_Livro int,
	Numero_Pagina int,
	Numero_Registro int,
	DnvDo varchar(20),
	Pai varchar(50),
	Mae varchar(50)
)as
$$
begin
	return query
	SELECT r.nome, r.data_nascimento, r.hora_nascimento,  s.descricao, tl.descricao, l.numero_livro,l.numero_pagina, l.numero_registro, r.dnvdo, p.nome, p1.nome
	FROM Recem_Nascido AS r
	INNER JOIN Sexo AS s ON r.id_sexo = s.id
	INNER JOIN livro AS l on l.id_rn = r.id
	INNER JOIN tipo_livro AS tl ON tl.id = l.id_tipo
	INNER JOIN Parentes AS p ON r.id = p.id_rn and p.id_parentesco = 1
	INNER JOIN Parentes as p1 ON r.id = p1.id_rn and p1.id_parentesco = 2	
	WHERE r.dnvdo = _pesquisa;
end
$$
language plpgsql;
--==================================================================================================================================================
--=================================================INSERT Recem Nascido ++ LIVRO====================================================================
CREATE OR REPLACE FUNCTION insertRecemNascido(_nome VARCHAR(50), _dt_nascimento varchar(20), _hora_nascimento VARCHAR(20), _id_sexo INT, _DNVDO VARCHAR(20))
RETURNS VOID AS
$$
begin
	INSERT INTO recem_nascido (nome, data_nascimento, hora_nascimento, id_sexo, DNVDO)
	SELECT _nome, _dt_nascimento, _hora_nascimento, _id_sexo, _DNVDO
	WHERE NOT EXISTS (
	SELECT nome FROM recem_nascido WHERE nome = _nome
	);
end
$$
language plpgsql;
--====================================================================================================================
--===============================================INSERT Livro=========================================================
CREATE OR REPLACE FUNCTION insertLivro(_id_tipo INT, _n_pagina INT, _n_registro INT, _n_livro INT)
RETURNS VOID AS
$$
begin
	INSERT INTO livro (id_tipo, id_rn, numero_pagina, numero_registro, numero_livro)
	SELECT _id_tipo, (SELECT MAX(ID) FROM Recem_Nascido), _n_pagina, _n_registro, _n_livro
	WHERE NOT EXISTS (
    SELECT id_rn FROM livro WHERE id_rn = (SELECT MAX(ID) FROM Recem_Nascido)
);
end
$$
language plpgsql;
--=====================================================================================================================
--=============================================INSERT PARENTESCO=======================================================
CREATE OR REPLACE FUNCTION insertParentesco(_nome VARCHAR(50), _dt_nascimento VARCHAR(20), _idade INT, _uf VARCHAR(50), _naturalidade VARCHAR(50), _id_parentesco INT)
RETURNS VOID AS	
$$
begin
	PERFORM insertNaturalidade(_naturalidade);
	PERFORM insertParente(_nome, _dt_nascimento, _idade, (SELECT id FROM UF where estado = _uf), (SELECT id from naturalidade where cidade = _naturalidade), _id_parentesco, (SELECT MAX(ID) FROM Recem_Nascido));
end
$$
language plpgsql;
--======================================================================================================================
--======================================================INSERT NATURALIDADE=============================================
CREATE OR REPLACE FUNCTION insertNaturalidade(_naturalidade VARCHAR(50))
RETURNS VOID AS
$$
begin
	INSERT INTO naturalidade (cidade)
	SELECT _naturalidade
	WHERE NOT EXISTS (
    SELECT cidade FROM naturalidade WHERE cidade = _naturalidade
);
end
$$
language plpgsql;

--==================================================================================================================================
--============================================================INSERT PARENTE========================================================
CREATE OR REPLACE FUNCTION insertParente(_nome VARCHAR(50), _dt_nascimento VARCHAR(20), _idade INT, _id_uf INT, _id_naturalidade INT, _id_parentesco INT, _id_rn INT)
RETURNS VOID AS
$$
begin
	INSERT INTO parentes (nome, data_nascimento, idade, id_uf, id_naturalidade, id_parentesco, id_rn)
	SELECT _nome, _dt_nascimento, _idade, _id_uf, _id_naturalidade, _id_parentesco, _id_rn
	WHERE NOT EXISTS (
    SELECT nome FROM parentes WHERE nome = _nome
);
end
$$
language plpgsql;