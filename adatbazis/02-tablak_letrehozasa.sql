use szallashely_kezelo;

create table szallashely(
	id VARCHAR(8) PRIMARY KEY,
	fajta VARCHAR(10),
	iranyitoszam VARCHAR(4),
	varos VARCHAR(100),
	utca VARCHAR(150),
	hazszam VARCHAR(4)
);

create table epitett_szallashely(
	id INT PRIMARY KEY IDENTITY(1, 1),
	szallashely_id VARCHAR(8),
	szoba_ara INT,
	csillagok TINYINT,
	CONSTRAINT FK_epitettSzallas_szallas FOREIGN KEY(szallashely_id) REFERENCES szallashely(id)
);

create table szalloda(
	epitett_id INT,
	wellness BIT,
	CONSTRAINT FK_szalloda_epitettSzallas FOREIGN KEY(epitett_id) REFERENCES epitett_szallashely(id)
);

create table panzio(
	epitett_id INT,
	reggeli BIT,
	CONSTRAINT FK_panzio_epitettSzallas FOREIGN KEY(epitett_id) REFERENCES epitett_szallashely(id)
);

create table camping(
	szallashely_id VARCHAR(8),
	vizpart BIT,
	CONSTRAINT FK_camping_szallas FOREIGN KEY(szallashely_id) REFERENCES szallashely(id)
);