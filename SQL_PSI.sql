
Use db_psi;
CREATE TABLE Ator (
	ID int NOT NULL,
    nome  varchar(255) NOT null,
    email varchar(255),
    telefone int(9),
	PRIMARY KEY (ID)
);
CREATE TABLE Atuacao (
	ID int NOT NULL,
    papel varchar(255) NOT null,
	idAtor int not null,
	idFilme int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (idAtor) REFERENCES Ator(ID),
	FOREIGN KEY (idFilme) REFERENCES Filme(ID)
);

CREATE TABLE Filme (
	ID int NOT NULL,
    titulo varchar(255)NOT null,
    verba double(20,2)NOT null,
    dtGravacaoFim Datetime NOT null,
	dtGravacaoInicio Datetime NOT null,
	idAtorRoteirista int ,
	PRIMARY KEY (ID),
	FOREIGN KEY (idAtorRoteirista) REFERENCES Ator(ID)
);

CREATE TABLE Produtor (
	ID int NOT NULL,
    nome varchar(255)NOT null,
    email varchar(255),
    telefone int(9),
	PRIMARY KEY (ID)
);

CREATE TABLE ProducaoFilme (
	ID int NOT NULL,
	idFilme int not null,
	idProdutor int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (idProdutor) REFERENCES Produtor(ID),
	FOREIGN KEY (idFilme) REFERENCES Filme(ID)
);

CREATE TABLE Diretor (
	ID int NOT NULL,
    nome varchar(255) NOT null,
    email varchar(255),
    telefone int(9),
	endereco varchar(255),
	PRIMARY KEY (ID)
);

CREATE TABLE DirecaoFilme (
	ID int NOT NULL,
	idFilme int not null,
	idDiretor int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (idDiretor) REFERENCES Diretor(ID),
	FOREIGN KEY (idFilme) REFERENCES Filme(ID)
);


CREATE TABLE Documentario (
	ID int NOT NULL ,
    assunto varchar(255) NOT null,
	idFilme int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (idFilme) REFERENCES Filme(ID)
);
CREATE TABLE LongaMetragem (
	ID int NOT NULL ,
    categoria varchar(255) NOT null,
	idFilme int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (idFilme) REFERENCES Filme(ID)
);



--    PRIMARY KEY (ID),
-- FOREIGN KEY (PersonID) REFERENCES Persons(ID)