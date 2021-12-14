CREATE TABLE [dbo].[adres](
id int not null PRIMARY KEY,
straatID int NOT NULL FOREIGN KEY REFERENCES straat(id),
huisnummer int NOT NULL,
appartementnummer int NULL,
busnummer int NULL,
huisnummerlabel int NOT NULL,
adreslocatieID int NOT NULL FOREIGN KEY REFERENCES adreslocatie(id),
postcode int NOT NULL
);