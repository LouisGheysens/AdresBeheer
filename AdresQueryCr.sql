CREATE TABLE [dbo].[adres](
id int not null PRIMARY KEY,
straatID int NOT NULL FOREIGN KEY REFERENCES straat(id),
huisnummer varchar(100) NOT NULL,
appartementnummer varchar(100) NULL,
busnummer varchar(100) NULL,
huisnummerlabel varchar(100) NOT NULL,
adreslocatieID int NOT NULL FOREIGN KEY REFERENCES adreslocatie(id),
postcode int NOT NULL
);